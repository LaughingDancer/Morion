using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                            throw new Exception("No result returned from the query.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Возникла ошибка при выполнении запроса: " + ex.Message, "Ошибка");
                return -1; // Возвращаем -1 в случае ошибки
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
                        MessageBox.Show("Действие успешно выполнено!", "Успех");
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
    }
}
