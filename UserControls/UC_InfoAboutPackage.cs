using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EmployeeManagement
{
    public partial class UC_InfoAboutPackage : UserControl
    {
        private DbContext dbContext;
        public UC_InfoAboutPackage()
        {
            InitializeComponent();
            dbContext = new DbContext();
        }

        private void UC_Employees_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Поиск партий по заданной пользователем дате
        /// </summary>
        private void LoadListOfPartiesForTheDay()
        {
            try
            {
                string startDate = DTP_DateStartSearchPart.Value.ToString("yyyyMMdd");
                string endDate = DTP_DateEndSearchPart.Value.ToString("yyyyMMdd");

                using (SqlConnection connection = DbContext.GetSqlConnection())
                {
                    string query = $"SELECT isNull(kommis_num,'Нет') as kommis_num \r\nFROM OpenQuery(DIRECTPLAN,'SELECT distinct pk.kommis_num FROM dp_data.plan_orders po LEFT JOIN plan_kommis pk on po.id = pk.order_id\r\nWHERE DATE(FROM_UNIXTIME(date_produce)) BETWEEN ''{startDate}'' AND ''{endDate}''');";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();

                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            string kommis_num = reader["kommis_num"].ToString();
                            DGV_PartiesForTheDay.Rows.Add(kommis_num);
                        }

                        reader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при загрузке данных: " + ex.Message);
            }
        }

        /// <summary>
        /// Выполняем запрос выбора по партиям и выводим во второй Datagrid номера заказов(DGV_tbPartNumber) 
        /// </summary>
        /// <param name="selectedPart">Выбранная партия в Datagrid'е DGV_PartiesForTheDay</param>
        private void LoadDetailInfo_DGV(string selectedPart)
        {
            try
            {
                using (SqlConnection connection = DbContext.GetSqlConnection())
                {
                    string query = $@"SELECT OrderNum,PosInOrder,Item,Part FROM [192.168.0.94].[datamart].[dbo].[tbPartNumber] tbPartNumber WHERE tbPartNumber.Part = '{selectedPart}';";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();

                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            string ordernum = reader["OrderNum"].ToString();
                            string posinorder = reader["PosInOrder"].ToString();
                            string item = reader["Item"].ToString();
                            string part = reader["Part"].ToString();
                            DGV_tbPartNumber.Rows.Add(posinorder, ordernum, item, part);
                        }

                        reader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при загрузке данных: " + ex.Message);
            }
        }

        /// <summary>
        /// Детализация информации по заказам
        /// </summary>
        /// <param name="orderNum">Номер заказа</param>
        private void LoadDetailInfoAboutItem(string orderNum)
        {
            try
            {
                using (SqlConnection connection = DbContext.GetSqlConnection())
                {
                    string query = $@"
                        SELECT 
                            p.GPName,
                            p.Size,
                            p.Commentary,
                            bc.BarCode,
                            bc.idPyramidCompleted,
                            bc.TimeScan,
                            CASE WHEN name IS NULL THEN 'Брянск' ELSE name END AS name,
                            ISNULL(tbPyramida.Pyramida, '') AS RescanPyramida,
                            ISNULL(tbPyramida.TimeScan, Null) AS RescanTimeScan,
                            tbPartNumber.Part,
                            tbPartNumber.OrderNum
                        FROM 
                            Project p
                        JOIN 
                            BarCode bc ON bc.idProject = p.ID
                        LEFT JOIN [datamart].[dbo].[tbGlassBarCodePyramida] tbPyramida ON tbPyramida.Barcode = bc.BarCode
                        LEFT JOIN [Glass].[dbo].SawTaskMain SawTaskMain ON bc.idSawTaskMain_Assembly = SawTaskMain.id
                        LEFT JOIN [192.168.0.94].[datamart].[dbo].[tbPartNumber] tbPartNumber ON tbPartNumber.OrderNum = p.OrderNum
                        WHERE 
                            p.OrderNum = '{orderNum}';";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();

                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            string gpName = reader["GPName"].ToString();
                            string size = reader["Size"].ToString();
                            string commentary = reader["Commentary"].ToString();
                            string timeScan = reader["TimeScan"].ToString();
                            string rescanPyramida = reader["RescanPyramida"].ToString();
                            string rescanTimeScan = reader["RescanTimeScan"].ToString();
                            string name = reader["name"].ToString();
                            string barcode = reader["BarCode"].ToString();
                            string Pyramida = reader["idPyramidCompleted"].ToString();
                            string partItem = reader["Part"].ToString();
                            string orderItem = reader["OrderNum"].ToString();

                            DGV_DetailsItem.Rows.Add(barcode, Pyramida, timeScan, commentary, rescanPyramida, rescanTimeScan, name, gpName, size, partItem, orderItem);
                        }

                        reader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при загрузке данных: " + ex.Message);
            }
        }

        /// <summary>
        /// При выборе партии грузим заказы в датагрид DGV_tbPartNumber
        /// </summary>
        private void DGV_PartiesForTheDay_SelectionChanged(object sender, EventArgs e)
        {
            DGV_tbPartNumber.Rows.Clear();
            DGV_DetailsItem.Rows.Clear();

            if (DGV_PartiesForTheDay.SelectedRows.Count > 0)
            {
                string selectedPart = DGV_PartiesForTheDay.SelectedRows[0].Cells["kommis_num"].Value.ToString();
                LoadDetailInfo_DGV(selectedPart);
            }
        }

        /// <summary>
        /// При выборе заказа грузим изделия в датагрид DGV_DetailsItem
        /// </summary>
        private void DGV_tbPartNumber_SelectionChanged(object sender, EventArgs e)
        {
            DGV_DetailsItem.Rows.Clear();
            if (DGV_tbPartNumber.SelectedRows.Count > 0)
            {
                string selectedOrderNum = DGV_tbPartNumber.SelectedRows[0].Cells["OrderNum"].Value.ToString();
                LoadDetailInfoAboutItem(selectedOrderNum);
            }
        }

        /// <summary>
        /// Поиск партии в разрезе даты производственного плана
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SearchPart_Click_1(object sender, EventArgs e)
        {
            checkbox_selectAllParts.Checked = false;
            DGV_PartiesForTheDay.Rows.Clear();
            DGV_tbPartNumber.Rows.Clear();
            DGV_DetailsItem.Rows.Clear();
            if (DGV_PartiesForTheDay.Rows.Count > 0)
            {
                DGV_PartiesForTheDay.Rows.Clear();
                LoadListOfPartiesForTheDay();
            }
            LoadListOfPartiesForTheDay();
        }

        /// <summary>
        /// Выводим партии, заказы,все изделия,помеченные маркером
        /// </summary>
        private void btn_showSelectPart_Click(object sender, EventArgs e)
        {
            DGV_tbPartNumber.Rows.Clear();
            DGV_DetailsItem.Rows.Clear();

            getAllPartWithMarks();
            getAllItemsWithMarks();
        }

        /// <summary>
        /// Получение всех изделий помеченных маркером
        /// </summary>
        private void getAllItemsWithMarks()
        {
            if (DGV_tbPartNumber.Rows.Count > 0)
            {
                for (int i = 0; i < DGV_tbPartNumber.Rows.Count; i++)
                {
                    string selectedOrder = DGV_tbPartNumber.Rows[i].Cells["OrderNum"].Value.ToString();
                    LoadDetailInfoAboutItem(selectedOrder);
                }
            }
        }

        /// <summary>
        /// Получение всех партий помеченных маркером
        /// </summary>
        private void getAllPartWithMarks()
        {
            for (int i = 0; i < DGV_PartiesForTheDay.Rows.Count; i++)
            {
                DataGridViewCheckBoxCell selectCell = DGV_PartiesForTheDay.Rows[i].Cells["Select"] as DataGridViewCheckBoxCell;

                if (selectCell != null && selectCell.Value != null && selectCell.Value.ToString() == "1")
                {
                    DataGridViewCell partCell = DGV_PartiesForTheDay.Rows[i].Cells["kommis_num"];

                    if (partCell != null && partCell.Value != null)
                    {
                        string selectedPart = partCell.Value.ToString();
                        LoadDetailInfo_DGV(selectedPart);
                    }
                }
            }
        }

        /// <summary>
        /// Если ставим галку на выборе, для всех партий проставляется маркер
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkbox_selectAllParts_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_selectAllParts.Checked)
            {
                for (int i = 0; i < DGV_PartiesForTheDay.Rows.Count; i++)
                {
                    DataGridViewCheckBoxCell selectCell = DGV_PartiesForTheDay.Rows[i].Cells["Select"] as DataGridViewCheckBoxCell;
                    selectCell.Value = "1";
                }
            }
            else
            {
                for (int i = 0; i < DGV_PartiesForTheDay.Rows.Count; i++)
                {
                    DataGridViewCheckBoxCell selectCell = DGV_PartiesForTheDay.Rows[i].Cells["Select"] as DataGridViewCheckBoxCell;
                    selectCell.Value = "0";
                }
            }
        }
    }
}

