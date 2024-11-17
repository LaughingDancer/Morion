using app.Classes;
using app.Forms;
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

namespace app.UserControlsSeamstress
{
    public partial class UC_ЗаказыШвея : UserControl
    {
        private DB DB;
        public void RefreshDataGridView()
        {
            RefreshDataGrid(DataGridViewOrders);
        }
        public UC_ЗаказыШвея()
        {
            InitializeComponent();
            DB = new DB();
        }
        private void CreateColumns()
        {
            DataGridViewOrders.Columns.Add("КодЗаказа", "КодЗаказа");
            DataGridViewOrders.Columns["КодЗаказа"].Visible = false;

            DataGridViewOrders.Columns.Add("НазваниеИзделия", "Изделия");
            DataGridViewOrders.Columns.Add("НазваниеРазмера", "Размер");
            DataGridViewOrders.Columns.Add("КоличествоИзделий", "Количество");
            DataGridViewOrders.Columns.Add("КоличествоВыполненных", "Выполненные");
            DataGridViewOrders.Columns.Add("Вид", "Ткань");
            DataGridViewOrders.Columns.Add("Длина", "Длина");
            DataGridViewOrders.Columns.Add("Ширина", "Ширина");
            DataGridViewOrders.Columns.Add("ДатаЗаказа", "Дата Заказа");
        }
        private void ReadSingleRow(DataGridView DGW, IDataRecord record)
        {
            DGW.Rows.Add(
                record.GetInt32(0),                         // КодЗаказа
                record.GetString(1),                        // НазваниеИзделия
                record.GetString(2),                        // НазваниеРазмера
                record.GetInt32(3),                         // КоличествоИзделий
                record.GetInt32(4),                         // КоличествоВыполненных
                record.GetString(5),                        // Вид
                record.GetDecimal(6),                       // Длина
                record.GetDecimal(7),                       // Ширина
                record.GetDateTime(8).ToShortDateString()
            );
        }
        private void RefreshDataGrid(DataGridView DGW)
        {
            DGW.Rows.Clear();
            string queryString = @"
SELECT 
    Заказы.КодЗаказа, 
    Изделия.НазваниеИзделия, 
    Размеры.НазваниеРазмер, 
    ВариантыОптимизации.КоличествоИзделий, 
    Заказы.КоличествоВыполненных, 
    Ткани.Вид, 
    Ткани.Длина, 
    Ткани.Ширина, 
    Заказы.ДатаЗаказа 
FROM 
    Заказы 
JOIN 
    ВариантыОптимизации ON Заказы.КодОптимизации = ВариантыОптимизации.КодОптимизации
JOIN 
    Размеры ON ВариантыОптимизации.КодРазмера = Размеры.КодРазмера
JOIN 
    Изделия ON ВариантыОптимизации.КодИзделия = Изделия.КодИзделия
JOIN 
    Ткани ON ВариантыОптимизации.КодТкани = Ткани.КодТкани
WHERE 
    Заказы.Статус = 'Не выполнено'";

            SqlCommand command = new SqlCommand(queryString, DB.GetConnection());
            try
            {
                DB.OpenConnection();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ReadSingleRow(DGW, reader);
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Ошибка выполнения запроса: {ex.Message}");
            }
            finally
            {
                DB.CloseConnection();
            }
        }
        private void Search(DataGridView DGW)
        {
            DGW.Rows.Clear();
            string querrySearch = $@"
SELECT 
    Заказы.КодЗаказа, 
    Изделия.НазваниеИзделия, 
    Размеры.НазваниеРазмер, 
    ВариантыОптимизации.КоличествоИзделий, 
    Заказы.КоличествоВыполненных, 
    Ткани.Вид, 
    Ткани.Длина, 
    Ткани.Ширина, 
    Заказы.ДатаЗаказа 
FROM 
    Заказы 
JOIN 
    ВариантыОптимизации ON Заказы.КодОптимизации = ВариантыОптимизации.КодОптимизации
JOIN 
    Размеры ON ВариантыОптимизации.КодРазмера = Размеры.КодРазмера
JOIN 
    Изделия ON ВариантыОптимизации.КодИзделия = Изделия.КодИзделия
JOIN 
    Ткани ON ВариантыОптимизации.КодТкани = Ткани.КодТкани
WHERE 
    CONCAT(Изделия.НазваниеИзделия, ВариантыОптимизации.КоличествоИзделий, Размеры.НазваниеРазмер, Ткани.Вид, Ткани.Длина, Ткани.Ширина, Заказы.ДатаЗаказа) LIKE '%" + searchTextBox.Text + "%'";

            SqlCommand sqlCommand = new SqlCommand(querrySearch, DB.GetConnection());
            DB.OpenConnection();
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                DGW.Rows.Add(
                    reader.GetInt32(0),                         // КодЗаказа
                    reader.GetString(1),                        // НазваниеИзделия
                    reader.GetString(2),                        // НазваниеРазмер
                    reader.GetInt32(3),                         // КоличествоИзделий
                    reader.GetInt32(4),                         // КоличествоВыполненных
                    reader.GetString(5),                        // Вид
                    reader.GetDecimal(6),                       // Длина
                    reader.GetDecimal(7),                       // Ширина
                    reader.GetDateTime(8).ToShortDateString()
                );
            }
            reader.Close();
        }
        private void comboSearch()
        {
            string quarrySearchProduct = $"SELECT DISTINCT НазваниеИзделия FROM Изделия";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(quarrySearchProduct, DB.GetConnection());
            DB.OpenConnection();
            DataSet DS = new DataSet();
            sqlDataAdapter.Fill(DS, "НазваниеИзделия");

            DataRow allRow = DS.Tables["НазваниеИзделия"].NewRow();
            allRow["НазваниеИзделия"] = "Все Изделия";
            DS.Tables["НазваниеИзделия"].Rows.InsertAt(allRow, 0);

            comboBoxProduct.DisplayMember = "НазваниеИзделия";
            comboBoxProduct.ValueMember = "НазваниеИзделия";
            comboBoxProduct.DataSource = DS.Tables["НазваниеИзделия"];
            DB.CloseConnection();

            comboBoxProduct.SelectedIndex = 0;
        }
        private void display_DGW()
        {
            string querrySearch;

            if (comboBoxProduct.Text == "Все Изделия")
            {
                querrySearch = @"
SELECT 
    Заказы.КодЗаказа, 
    Изделия.НазваниеИзделия, 
    Размеры.НазваниеРазмер, 
    ВариантыОптимизации.КоличествоИзделий, 
    Заказы.КоличествоВыполненных, 
    Ткани.Вид, 
    Ткани.Длина, 
    Ткани.Ширина, 
    Заказы.ДатаЗаказа 
FROM 
    Заказы 
JOIN 
    ВариантыОптимизации ON Заказы.КодОптимизации = ВариантыОптимизации.КодОптимизации
JOIN 
    Размеры ON ВариантыОптимизации.КодРазмера = Размеры.КодРазмера
JOIN 
    Изделия ON ВариантыОптимизации.КодИзделия = Изделия.КодИзделия
JOIN 
    Ткани ON ВариантыОптимизации.КодТкани = Ткани.КодТкани
WHERE 
    Заказы.Статус = 'Не выполнено'";
            }
            else
            {
                querrySearch = @"
SELECT 
    Заказы.КодЗаказа, 
    Изделия.НазваниеИзделия, 
    Размеры.НазваниеРазмер, 
    ВариантыОптимизации.КоличествоИзделий, 
    Заказы.КоличествоВыполненных, 
    Ткани.Вид, 
    Ткани.Длина, 
    Ткани.Ширина, 
    Заказы.ДатаЗаказа 
FROM 
    Заказы 
JOIN 
    ВариантыОптимизации ON Заказы.КодОптимизации = ВариантыОптимизации.КодОптимизации
JOIN 
    Размеры ON ВариантыОптимизации.КодРазмера = Размеры.КодРазмера
JOIN 
    Изделия ON ВариантыОптимизации.КодИзделия = Изделия.КодИзделия
JOIN 
    Ткани ON ВариантыОптимизации.КодТкани = Ткани.КодТкани
WHERE 
    Заказы.Статус = 'Не выполнено' AND
    Изделия.НазваниеИзделия = @НазваниеИзделия";
            }

            SqlCommand sqlCommand = new SqlCommand(querrySearch, DB.GetConnection());

            if (comboBoxProduct.Text != "Все Изделия")
            {
                sqlCommand.Parameters.AddWithValue("@НазваниеИзделия", comboBoxProduct.Text);
            }

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable DT = new DataTable();
            DataGridViewOrders.Rows.Clear();

            try
            {
                DB.OpenConnection();
                sqlDataAdapter.Fill(DT);

                foreach (DataRow row in DT.Rows)
                {
                    DataGridViewOrders.Rows.Add(
                        row["КодЗаказа"],                    // КодЗаказа
                        row["НазваниеИзделия"],              // НазваниеИзделия
                        row["НазваниеРазмер"],               // НазваниеРазмер
                        row["КоличествоИзделий"],            // КоличествоИзделий
                        row["КоличествоВыполненных"],        // КоличествоВыполненных
                        row["Вид"],                          // Вид
                        row["Длина"],                        // Длина
                        row["Ширина"],                       // Ширина
                        ((DateTime)row["ДатаЗаказа"]).ToShortDateString()
                    );
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Ошибка выполнения запроса: {ex.Message}");
            }
            finally
            {
                DB.CloseConnection();
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
