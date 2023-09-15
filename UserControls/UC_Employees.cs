using EmployeeManagement.HelpForms;
using System;
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
    public partial class UC_Employees : UserControl
    {
        private DbContext dbContext;
        public UC_Employees()
        {
            InitializeComponent();
            dbContext = new DbContext(); // Инициализация DbContext
        }

        private void UC_Employees_Load(object sender, EventArgs e)
        {
            LoadEmployeeData(); // Сразу загружаем в наш лист - сотрудников
            textbox_Id.Text = "Введите Id сюда"; // Переписать на многоиспользуемый код(haunt)
            textbox_Id.ForeColor = Color.Gray;
        }

        private void LoadEmployeeData()
        {
            // Создание списка для хранения данных сотрудников
            List<string> employees = new List<string>();

            try
            {
                // Получение подключения
                using (SqlConnection connection = DbContext.GetSqlConnection())
                {
                    // Создание запроса к базе данных (поиск Employee)
                    string query = "SELECT e.EmployeeID, e.FirstName, e.LastName, e.Email, e.DateOfBirth, d.DepartmentName, p.PositionName " +
                                   "FROM Employees e " +
                                   "INNER JOIN Departments d ON e.DepartmentID = d.DepartmentID " +
                                   "INNER JOIN Positions p ON e.PositionID = p.PositionID";

                    // Создание команды для выполнения запроса
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();

                        // Выполнение запроса и получение результатов
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Перебор результатов и добавление их в список
                            while (reader.Read())
                            {
                                string employee = $"{reader["EmployeeId"]} {reader["FirstName"]} {reader["LastName"]} - {reader["DepartmentName"]} ({reader["PositionName"]})";
                                employees.Add(employee);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при загрузке данных: " + ex.Message);
            }

            // Отображение списка сотрудников в ListBox
            listBox1.DataSource = employees;
        }

        private void textbox_Id_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textbox_Id.Text))
            {
                textbox_Id.Text = "Введите Id сюда";
                textbox_Id.ForeColor = Color.Gray;
            }
        }

        private void textbox_Id_Enter(object sender, EventArgs e)
        {
            if (textbox_Id.Text == "Введите Id сюда")
            {
                textbox_Id.Clear();
                textbox_Id.ForeColor = Color.Black;
            }
        }

        private void btn_EmployeeList_Click(object sender, EventArgs e)
        {
            LoadEmployeeData();
        }

        private void btn_GetInformationEmployeeById_Click(object sender, EventArgs e)
        {
            // Создание списка для хранения данных сотрудников
            List<string> employees = new List<string>();
            string sId = textbox_Id.Text.Trim();
            if (!string.IsNullOrEmpty(sId))
            {
                try
                {
                    int id = int.Parse(sId);
                    // Получение подключения
                    using (SqlConnection connection = DbContext.GetSqlConnection())
                    {
                        // Создание запроса к базе данных (поиск Employee по Id из textbox)
                        string query = @"SELECT e.EmployeeID, e.FirstName, e.LastName, e.Email, e.DateOfBirth, d.DepartmentName, p.PositionName
                                    FROM Employees e
                                    INNER JOIN Departments d ON e.DepartmentID = d.DepartmentID
                                    INNER JOIN Positions p ON e.PositionID = p.PositionID
                                    WHERE e.EmployeeID = @Id";

                        // Создание команды для выполнения запроса
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Id", id);
                            connection.Open();

                            // Выполнение запроса и получение результатов
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                // Перебор результатов и добавление их в список
                                while (reader.Read())
                                {
                                    string employee = $"{reader["FirstName"]} {reader["LastName"]} - {reader["DepartmentName"]} ({reader["PositionName"]})";
                                    employees.Add(employee);
                                }
                            }
                        }
                    }
                }

                catch (Exception ex)
                {
                    // Обработка ошибок
                    MessageBox.Show("Произошла ошибка при загрузке данных: " + ex.Message);
                }

                // Отображение списка сотрудников в ListBox
                listBox1.DataSource = employees;
            }
            else
            {
                MessageBox.Show("Необходимо заполнить поле Id");
            }
        }

        private void btn_EditEmployee_Click(object sender, EventArgs e)
        {
            string sId = textbox_Id.Text.Trim();
            if (!string.IsNullOrEmpty(sId))
            {
                try
                {
                    int id = int.Parse(sId);

                    // Check if the employee exists before proceeding with update
                    bool employeeExists = CheckEmployeeExists(id);

                    if (employeeExists)
                    {
                        EditEmployeeForm editForm = new EditEmployeeForm(id, dbContext);
                        editForm.ShowDialog();
                        LoadEmployeeData();
                    }
                    else
                    {
                        MessageBox.Show("Сотрудник с указанным идентификатором не найден.");
                    }
                }
                catch (Exception ex)
                {
                    // Обработка ошибок
                    MessageBox.Show("Произошла ошибка: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Необходимо заполнить поле Id");
            }
        }
        private bool CheckEmployeeExists(int id)
        {
            bool exists = false;

            try
            {
                // Получение подключения
                using (SqlConnection connection = DbContext.GetSqlConnection())
                {

                    // Создание запроса к базе данных для проверки существования сотрудника
                    string query = "SELECT COUNT(*) FROM Employees WHERE EmployeeID = @Id";

                    // Создание команды для выполнения запроса
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", id);
                        connection.Open();

                        // Выполнение запроса и получение результата
                        int count = (int)command.ExecuteScalar();

                        exists = count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Обработка ошибок
                MessageBox.Show("Произошла ошибка при проверке существования сотрудника: " + ex.Message);
            }
            return exists;
        }

        private void btn_DeleteEmployee_Click(object sender, EventArgs e)
        {
            string sId = textbox_Id.Text;
            if (!string.IsNullOrEmpty(sId))
            {
                try
                {
                    int id;
                    if (int.TryParse(sId, out id))
                    {
                        // Получение подключения
                        using (SqlConnection connection = DbContext.GetSqlConnection())
                        {
                            // Проверка существования сотрудника с указанным ID
                            string checkQuery = "SELECT COUNT(*) FROM Employees WHERE EmployeeID = @Id";
                            using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                            {
                                checkCommand.Parameters.AddWithValue("@Id", id);
                                connection.Open();

                                int count = (int)checkCommand.ExecuteScalar();
                                if (count == 0)
                                {
                                    MessageBox.Show("Сотрудник с указанным ID не найден.");
                                    return;
                                }
                            }

                            // Создание запроса к базе данных для удаления сотрудника по ID
                            string deleteQuery = "DELETE FROM Employees WHERE EmployeeID = @Id";

                            // Создание команды для выполнения запроса
                            using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                            {
                                command.Parameters.AddWithValue("@Id", id);

                                // Выполнение запроса удаления
                                int rowsAffected = command.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Сотрудник успешно удален.");
                                    LoadEmployeeData();
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Некорректный формат ID.");
                    }
                }
                catch (Exception ex)
                {
                    // Обработка ошибок
                    MessageBox.Show("Произошла ошибка при удалении сотрудника: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Необходимо заполнить поле Id");
            }
        }
        private void btn_GetDepartList_Click(object sender, EventArgs e)
        {
            // Создание списка для хранения данных сотрудников
            List<string> departList = new List<string>();
            List<string> positionList = new List<string>();

            try
            {
                // Получение подключения
                using (SqlConnection connection = DbContext.GetSqlConnection())
                {
                    // Создание запроса к базе данных (поиск департаментов и должностей)
                    string query = @"SELECT d.DepartmentName, p.PositionName
                             FROM Departments d
                             INNER JOIN Positions p ON d.DepartmentID = p.PositionID";

                    // Создание команды для выполнения запроса
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();

                        // Выполнение запроса и получение результатов
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string departmentName = reader["DepartmentName"].ToString();
                                string positionName = reader["PositionName"].ToString();

                                // Добавление департамента, если он отсутствует в списке
                                if (!departList.Contains(departmentName))
                                {
                                    departList.Add(departmentName);
                                }

                                // Добавление должности, если она отсутствует в списке
                                if (!positionList.Contains(positionName))
                                {
                                    positionList.Add(positionName);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при загрузке данных: " + ex.Message);
            }

            // Объединение списков департаментов и должностей
            departList.AddRange(positionList);

            // Отображение списка сотрудников в ListBox
            listBox1.DataSource = departList;
        }

        private void btn_GetEmployeesByLastName_Click(object sender, EventArgs e)
        {
            // Создание списка для хранения данных сотрудников
            List<string> employees = new List<string>();
            string lastName = textbox_LastName.Text;
            try
            {
                // Получение подключения
                using (SqlConnection connection = DbContext.GetSqlConnection())
                {
                    // Создание команды для выполнения запроса
                    using (SqlCommand command = new SqlCommand("GetEmployeesByLastName", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@LastName", lastName);
                        connection.Open();

                        // Выполнение запроса и получение результатов
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Перебор результатов и добавление их в список
                            while (reader.Read())
                            {
                                string employee = $"{reader["FirstName"]} {reader["LastName"]} - {reader["DepartmentName"]} ({reader["PositionName"]})";
                                employees.Add(employee);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при загрузке данных: " + ex.Message);
            }
            // Отображение списка сотрудников в ListBox
            listBox1.DataSource = employees;
        }
    }
}

