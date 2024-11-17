using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace app.Classes
{
    internal class DB
    {
        private SqlConnection sqlConnection = new SqlConnection(@"Data Source=MAKSIMN;Initial Catalog=Морион;Integrated Security=True");
        public string StringConnection()
        {
            return @"Data Source=MAKSIMN;Initial Catalog=Морион;Integrated Security=True";
        }
        public SqlDataAdapter QueryExecute(string query)
        {
            try
            {
                SqlConnection myCon = new SqlConnection(StringConnection());
                myCon.Open();
                SqlDataAdapter SDA = new SqlDataAdapter(query, myCon);
                SDA.SelectCommand.ExecuteNonQuery();
                return SDA;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Возникла ошибка при выполнении запроса: " + ex.Message, "Ошибка");
                return null;
            }
        }
        public void OpenConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }
        public void CloseConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }
        public SqlConnection GetConnection()
        {
            return sqlConnection;
        }
        public int QueryExecuteScalar(string query)
        {
            try
            {
                using (SqlConnection myCon = new SqlConnection(StringConnection()))
                {
                    myCon.Open();
                    using (SqlCommand command = new SqlCommand(query, myCon))
                    {
                        object result = command.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            return Convert.ToInt32(result);
                        }
                        else
                        {
                            throw new Exception("Запрос не вернул никакого результата.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Возникла ошибка при выполнении запроса: " + ex.Message, "Ошибка");
                return -1;
            }
        }

        public void QueryExecuteNonQuery(string query)
        {
            try
            {
                using (SqlConnection myCon = new SqlConnection(StringConnection()))
                {
                    myCon.Open();
                    using (SqlCommand command = new SqlCommand(query, myCon))
                    {
                        command.ExecuteNonQuery();
                        MyCustomMessageBox.ShowMessage("Данные успешно обновлены!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Возникла ошибка при выполнении запроса: " + ex.Message, "Ошибка");
            }
        }
        public byte[] GetEmployeePhoto(int employeeId)
        {
            using (SqlConnection connection = new SqlConnection(StringConnection()))
            {
                connection.Open();
                string query = "SELECT Фото FROM Сотрудники WHERE КодСотрудника = @EmployeeId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@EmployeeId", employeeId);
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        return (byte[])result;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }
        public byte[] GetProductPhoto(int productId)
        {
            using (SqlConnection connection = new SqlConnection(StringConnection()))
            {
                connection.Open();
                string query = "SELECT Фото FROM Изделия WHERE КодИзделия = @ProductId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ProductId", productId);
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        return (byte[])result;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }
        public (string Name, byte[] Photo) GetProductDetails(int productId)
        {
            using (SqlConnection connection = new SqlConnection(StringConnection()))
            {
                connection.Open();
                string query = "SELECT НазваниеИзделия, Фото FROM Изделия WHERE КодИзделия = @ProductId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ProductId", productId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string name = reader["НазваниеИзделия"].ToString();
                            byte[] photo = reader["Фото"] as byte[];
                            return (name, photo);
                        }
                        else
                        {
                            return (null, null);
                        }
                    }
                }
            }
        }


        public Dictionary<string, string> GetEmployeeDataByLogin(string login)
        {
            Dictionary<string, string> employeeData = new Dictionary<string, string>();
            using (SqlConnection con = new SqlConnection(StringConnection()))
            {
                con.Open();
                string query = @"
        SELECT Сотрудники.КодСотрудника, Сотрудники.Имя, Сотрудники.Фамилия, Сотрудники.ЭлектроннаяПочта, 
               Сотрудники.ДатаПриема, Сотрудники.Зарплата, Пользователи.Должность, Пользователи.Пароль, Пользователи.Логин
        FROM Сотрудники
        INNER JOIN Пользователи ON Сотрудники.КодПользователя = Пользователи.КодПользователя
        WHERE Пользователи.Логин = @Логин";
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@Логин", login);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            employeeData["КодСотрудника"] = reader["КодСотрудника"].ToString();
                            employeeData["Имя"] = reader["Имя"].ToString();
                            employeeData["Фамилия"] = reader["Фамилия"].ToString();
                            employeeData["ЭлектроннаяПочта"] = reader["ЭлектроннаяПочта"].ToString();
                            employeeData["ДатаПриема"] = reader["ДатаПриема"].ToString();
                            employeeData["Зарплата"] = reader["Зарплата"].ToString();
                            employeeData["Должность"] = reader["Должность"].ToString();
                            employeeData["Пароль"] = reader["Пароль"].ToString();
                            employeeData["Логин"] = reader["Логин"].ToString();
                        }
                    }
                }
            }
            return employeeData;
        }
        public byte[] GetEmployeePhotoByLogin(string login)
        {
            using (SqlConnection con = new SqlConnection(StringConnection()))
            {
                con.Open();
                string query = @"
                SELECT Фото
                FROM Сотрудники
                INNER JOIN Пользователи ON Сотрудники.КодПользователя = Пользователи.КодПользователя
                WHERE Пользователи.Логин = @Логин";
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@Логин", login);
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        return (byte[])result;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }
        public DataTable GetOptimizationData()
        {
            DataTable dataTable = new DataTable();
            string query = @"
        SELECT 
            Изделия.НазваниеИзделия, 
            Размеры.НазваниеРазмер, 
            ВариантыОптимизации.КоличествоИзделий, 
            ВариантыОптимизации.КоличествоОтходов, 
            ВариантыОптимизации.ПроцентОтходов, 
            Ткани.Вид AS ВидТкани, 
            Ткани.Длина, 
            Ткани.Ширина 
        FROM 
            ВариантыОптимизации 
        JOIN 
            Ткани ON ВариантыОптимизации.КодТкани = Ткани.КодТкани
        JOIN 
            Изделия ON ВариантыОптимизации.КодИзделия = Изделия.КодИзделия
        JOIN 
            Размеры ON ВариантыОптимизации.КодРазмера = Размеры.КодРазмера";

            SqlDataAdapter adapter = QueryExecute(query);
            if (adapter != null)
            {
                adapter.Fill(dataTable);
            }
            return dataTable;
        }
        public DataTable GetChartFabric()
        {
            DataTable dataTable = new DataTable();
            string query = @"
        SELECT 
            Ткани.Вид AS ВидТкани, 
            SUM(ВариантыОптимизации.КоличествоИзделий) AS КоличествоИзделий
        FROM 
            ВариантыОптимизации 
        JOIN 
            Ткани ON ВариантыОптимизации.КодТкани = Ткани.КодТкани
        GROUP BY 
            Ткани.Вид";

            SqlDataAdapter adapter = QueryExecute(query);
            if (adapter != null)
            {
                adapter.Fill(dataTable);
            }
            return dataTable;
        }
    }
}
