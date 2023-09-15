using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EmployeeManagement.HelpForms
{
    public partial class EditEmployeeForm : Form
    {
        private DbContext dbContext;
        private int employeeId;
        public EditEmployeeForm(int id, DbContext context)
        {
            InitializeComponent();
            employeeId = id;
            dbContext = context;
        }

        private void EditEmployeeForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_EditEmployee_Click(object sender, EventArgs e)
        {
            // Получение данных из текстовых полей
            string firstName = textbox_Name.Text;
            string lastName = textbox_LastName.Text;
            string email = textbox_Email.Text;
            string dateOfBirth = textbox_DOB.Text;

            try
            {
                // Получение подключения
                using (SqlConnection connection = DbContext.GetSqlConnection())
                {
                    // Проверка существования сотрудника с указанным идентификатором
                    string checkQuery = "SELECT COUNT(*) FROM Employees WHERE EmployeeID = @EmployeeID";
                    using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@EmployeeID", employeeId);
                        connection.Open();
                        int employeeCount = (int)checkCommand.ExecuteScalar();

                        // Если сотрудник с указанным идентификатором найден
                        if (employeeCount > 0)
                        {
                            // Обновление данных сотрудника
                            string updateQuery = "UPDATE Employees SET FirstName = @FirstName, LastName = @LastName, Email = @Email, DateOfBirth = @DateOfBirth WHERE EmployeeID = @EmployeeID";
                            using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                            {
                                updateCommand.Parameters.AddWithValue("@FirstName", firstName);
                                updateCommand.Parameters.AddWithValue("@LastName", lastName);
                                updateCommand.Parameters.AddWithValue("@Email", email);
                                updateCommand.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                                updateCommand.Parameters.AddWithValue("@EmployeeID", employeeId);
                                updateCommand.ExecuteNonQuery();
                            }

                            MessageBox.Show("Информация о сотруднике успешно обновлена!");
                            this.Close(); // Закрытие формы после успешного обновления
                        }
                        else
                        {
                            MessageBox.Show("Сотрудник с указанным идентификатором не существует!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Обработка ошибок
                MessageBox.Show("Произошла ошибка при обновлении данных сотрудника: " + ex.Message);
            }
        }
    }

}
