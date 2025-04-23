using app.Classes;
using app.Forms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace app.UserControlsSeamstress
{
    public partial class UC_ЗаказыШвея : UserControl
    {
        private DB DB;
        private int employeeId;
        private int brigadeId;
        public void RefreshDataGridView()
        {
            RefreshDataGrid(DataGridViewOrders);
        }
        public UC_ЗаказыШвея(int employeeId)
        {
            InitializeComponent();
            DB = new DB();
            this.employeeId = employeeId;
            this.brigadeId = GetEmployeeBrigadeId(employeeId);
        }
        private static int GetEmployeeBrigadeId(int employeeId)
        {
            int brigadeId = -1;
            string query = "SELECT КодБригады FROM Сотрудники WHERE КодСотрудника = @EmployeeId";
            using (SqlConnection connection = new SqlConnection(DB.StringConnectionDB))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@EmployeeId", employeeId);
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        brigadeId = Convert.ToInt32(result);
                    }
                }
            }
            return brigadeId;
        }
        private void CreateColumns()
        {
            DataGridViewOrders.Columns.Add("КодЗаказа", "КодЗаказа");
            DataGridViewOrders.Columns["КодЗаказа"].Visible = false;
            DataGridViewOrders.Columns.Add("НазваниеИзделия", "Изделия");
            DataGridViewOrders.Columns.Add("НазваниеРазмера", "Размер");
            DataGridViewOrders.Columns.Add("КоличествоИзделий", "Количество Изделий (шт)");
            DataGridViewOrders.Columns.Add("КоличествоВыполненных", "Готовые Изделия (шт)");
            DataGridViewOrders.Columns.Add("Вид", "Ткань");
            DataGridViewOrders.Columns.Add("Длина", "Длина (м)");
            DataGridViewOrders.Columns.Add("Ширина", "Ширина (м)");
            DataGridViewOrders.Columns.Add("ДатаЗаказа", "Дата Заказа");
            DataGridViewOrders.Columns["ДатаЗаказа"].Width = 80;
        }
        private static void ReadSingleRow(DataGridView DGW, IDataRecord record)
        {
            DGW.Rows.Add(
                record.GetInt32(0),
                record.GetString(1),
                record.GetString(2),
                record.GetInt32(3),
                record.GetInt32(4),
                record.GetString(5),
                record.GetDecimal(6),
                record.GetDecimal(7),
                record.GetDateTime(8).ToShortDateString()
            );
        }
        private void RefreshDataGrid(DataGridView DGW)
        {
            DGW.Rows.Clear();

            string queryString = @"SELECT з.КодЗаказа, и.НазваниеИзделия, р.НазваниеРазмер, во.КоличествоИзделий, з.КоличествоВыполненных, т.Вид, т.Длина, т.Ширина, з.ДатаЗаказа FROM Заказы з JOIN ВариантыОптимизации во ON з.КодОптимизации = во.КодОптимизации JOIN Размеры р ON во.КодРазмера = р.КодРазмера JOIN Изделия и ON во.КодИзделия = и.КодИзделия JOIN Ткани т ON во.КодТкани = т.КодТкани WHERE з.Статус = 'Не выполнено' AND з.КодБригады = @BrigadeId";
            using (SqlConnection connection = new SqlConnection(DB.StringConnectionDB))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(queryString, connection))
                {
                    command.Parameters.AddWithValue("@BrigadeId", brigadeId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ReadSingleRow(DGW, reader);
                        }
                    }
                }
            }
        }
        private void Search(DataGridView DGW)
        {
            DGW.Rows.Clear();
            string searchQuery = @"SELECT з.КодЗаказа, и.НазваниеИзделия, р.НазваниеРазмер, во.КоличествоИзделий, з.КоличествоВыполненных, т.Вид, т.Длина, т.Ширина, з.ДатаЗаказа FROM Заказы з JOIN ВариантыОптимизации во ON з.КодОптимизации = во.КодОптимизации JOIN Размеры р ON во.КодРазмера = р.КодРазмера JOIN Изделия и ON во.КодИзделия = и.КодИзделия JOIN Ткани т ON во.КодТкани = т.КодТкани WHERE з.Статус = 'Не выполнено' AND з.КодБригады = @BrigadeId AND CONCAT(и.НазваниеИзделия, р.НазваниеРазмер, т.Вид) LIKE @SearchText";
            using (SqlConnection connection = new SqlConnection(DB.StringConnectionDB))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(searchQuery, connection))
                {
                    command.Parameters.AddWithValue("@BrigadeId", brigadeId);
                    command.Parameters.AddWithValue("@SearchText", "%" + searchTextBox.Text + "%");

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ReadSingleRow(DGW, reader);
                        }
                    }
                }
            }
        }
        private void comboSearch()
        {
            string query = @"SELECT DISTINCT и.НазваниеИзделия FROM Изделия и JOIN ВариантыОптимизации во ON и.КодИзделия = во.КодИзделия JOIN Заказы з ON во.КодОптимизации = з.КодОптимизации WHERE з.КодБригады = @BrigadeId";
            using (SqlConnection connection = new SqlConnection(DB.StringConnectionDB))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@BrigadeId", brigadeId);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataSet DS = new DataSet();
                    adapter.Fill(DS, "НазваниеИзделия");
                    DataRow allRow = DS.Tables["НазваниеИзделия"].NewRow();
                    allRow["НазваниеИзделия"] = "Все Изделия";
                    DS.Tables["НазваниеИзделия"].Rows.InsertAt(allRow, 0);
                    comboBoxProduct.DisplayMember = "НазваниеИзделия";
                    comboBoxProduct.ValueMember = "НазваниеИзделия";
                    comboBoxProduct.DataSource = DS.Tables["НазваниеИзделия"];
                }
            }
        }
        private void display_DGW()
        {
            string query;
            if (comboBoxProduct.Text == "Все Изделия")
            {
                query = @"SELECT з.КодЗаказа, и.НазваниеИзделия, р.НазваниеРазмер, во.КоличествоИзделий, з.КоличествоВыполненных, т.Вид, т.Длина, т.Ширина, з.ДатаЗаказа FROM Заказы з JOIN ВариантыОптимизации во ON з.КодОптимизации = во.КодОптимизации JOIN Размеры р ON во.КодРазмера = р.КодРазмера JOIN Изделия и ON во.КодИзделия = и.КодИзделия JOIN Ткани т ON во.КодТкани = т.КодТкани WHERE з.Статус = 'Не выполнено' AND з.КодБригады = @BrigadeId";
            }
            else
            {
                query = @"SELECT з.КодЗаказа, и.НазваниеИзделия, р.НазваниеРазмер, во.КоличествоИзделий, з.КоличествоВыполненных, т.Вид, т.Длина, т.Ширина, з.ДатаЗаказа FROM Заказы з JOIN ВариантыОптимизации во ON з.КодОптимизации = во.КодОптимизации JOIN Размеры р ON во.КодРазмера = р.КодРазмера JOIN Изделия и ON во.КодИзделия = и.КодИзделия JOIN Ткани т ON во.КодТкани = т.КодТкани WHERE з.Статус = 'Не выполнено' AND з.КодБригады = @BrigadeId AND и.НазваниеИзделия = @ProductName";
            }
            DataGridViewOrders.Rows.Clear();
            using (SqlConnection connection = new SqlConnection(DB.StringConnectionDB))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@BrigadeId", brigadeId);
                    if (comboBoxProduct.Text != "Все Изделия")
                    {
                        command.Parameters.AddWithValue("@ProductName", comboBoxProduct.Text);
                    }
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DataGridViewOrders.Rows.Add(
                                reader["КодЗаказа"],
                                reader["НазваниеИзделия"],
                                reader["НазваниеРазмер"],
                                reader["КоличествоИзделий"],
                                reader["КоличествоВыполненных"],
                                reader["Вид"],
                                reader["Длина"],
                                reader["Ширина"],
                                ((DateTime)reader["ДатаЗаказа"]).ToShortDateString()
                            );
                        }
                    }
                }
            }
        }
        private void comboBoxProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            display_DGW();
        }
        private void UC_ЗаказыШвея_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(DataGridViewOrders);
            comboSearch();
            display_DGW();
        }
        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            Search(DataGridViewOrders);
        }
        private void DataGridViewOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DataGridViewOrders.Rows[e.RowIndex];
                int кодЗаказа = Convert.ToInt32(row.Cells["КодЗаказа"].Value);
                int количествоИзделий = Convert.ToInt32(row.Cells["КоличествоИзделий"].Value);
                int количествоВыполненных = Convert.ToInt32(row.Cells["КоличествоВыполненных"].Value);
                ВыполнениеЗаказа form = new ВыполнениеЗаказа(кодЗаказа, количествоИзделий, количествоВыполненных, this);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    RefreshDataGrid(DataGridViewOrders);
                }
            }
        }
    }
}