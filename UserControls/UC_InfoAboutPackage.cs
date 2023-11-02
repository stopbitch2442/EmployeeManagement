using EmployeeManagement.HelpForms;
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
                    string query = $"SELECT DISTINCT Part FROM [192.168.0.94].[datamart].[dbo].[tbPartNumber] tbPartNumber WHERE tbPartNumber.date BETWEEN '{startDate} 00:00:00' AND '{endDate} 23:59:59';";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();

                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            string part = reader["Part"].ToString();
                            DGV_PartiesForTheDay.Rows.Add(part);
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
                    string query = $@"SELECT OrderNum,PosInOrder,Item,PosInPart FROM [192.168.0.94].[datamart].[dbo].[tbPartNumber] tbPartNumber WHERE tbPartNumber.Part = '{selectedPart}';";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();

                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            string ordernum = reader["OrderNum"].ToString();
                            string posinorder = reader["PosInOrder"].ToString();
                            string item = reader["Item"].ToString();
                            string posinpart = reader["PosInPart"].ToString();
                            DGV_tbPartNumber.Rows.Add(posinpart, posinorder, ordernum, item);
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
                            ISNULL(tbPyramida.TimeScan, Null) AS RescanTimeScan
                        FROM 
                            Project p
                        JOIN 
                            BarCode bc ON bc.idProject = p.ID
                        LEFT JOIN 
                            [datamart].[dbo].[tbGlassBarCodePyramida] tbPyramida ON tbPyramida.Barcode = bc.BarCode
                        LEFT JOIN [Glass].[dbo].SawTaskMain SawTaskMain ON bc.idSawTaskMain_Assembly = SawTaskMain.id
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

                            DGV_DetailsItem.Rows.Add(barcode, Pyramida, timeScan, commentary, rescanPyramida, rescanTimeScan, name, gpName, size);
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

        private void DGV_PartiesForTheDay_SelectionChanged(object sender, EventArgs e)
        {
            DGV_tbPartNumber.Rows.Clear();
            DGV_DetailsItem.Rows.Clear();
            if (DGV_PartiesForTheDay.SelectedRows.Count > 0)
            {
                string selectedPart = DGV_PartiesForTheDay.SelectedRows[0].Cells["Part"].Value.ToString();
                LoadDetailInfo_DGV(selectedPart);
            }

        }
        private void DGV_tbPartNumber_SelectionChanged(object sender, EventArgs e)
        {
            DGV_DetailsItem.Rows.Clear();
            if (DGV_tbPartNumber.SelectedRows.Count > 0)
            {
                string selectedOrderNum = DGV_tbPartNumber.SelectedRows[0].Cells["OrderNum"].Value.ToString();
                LoadDetailInfoAboutItem(selectedOrderNum);
            }

        }

        private void btn_SearchPart_Click_1(object sender, EventArgs e)
        {
            DGV_tbPartNumber.Rows.Clear();
            DGV_DetailsItem.Rows.Clear();
            if (DGV_PartiesForTheDay.Rows.Count > 0)
            {
                DGV_PartiesForTheDay.Rows.Clear();
                LoadListOfPartiesForTheDay();
            }
            LoadListOfPartiesForTheDay();
        }
    }
}

