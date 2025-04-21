using System.Data.SqlClient;
namespace app.Classes
{
    internal class ValidationLogin
    {
        static readonly string StringConnectionDB = @"Data Source=MAKSIMN;Initial Catalog=Морион;Integrated Security=True";
        public bool CheckLoginUniqueness(string login)
        {
            using (SqlConnection connection = new SqlConnection(StringConnectionDB))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM Пользователи WHERE Логин = @Login";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Login", login);
                    int count = (int)command.ExecuteScalar();
                    return count == 0;
                }
            }
        }
    }
}
