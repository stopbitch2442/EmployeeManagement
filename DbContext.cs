using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    public class DbContext
    {
        // Метод для подключения к базе данных
        public static SqlConnection GetSqlConnection()
        {
            // Получение строки подключения из конфигурационного файла
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

            // Создание и возвращение объекта подключения
            return new SqlConnection(connectionString);
        }
    }
}
