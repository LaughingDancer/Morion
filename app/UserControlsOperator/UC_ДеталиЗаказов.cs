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

namespace app.UserControlsOperator
{
    public partial class UC_ДеталиЗаказов : UserControl
    {
        private DB DB;
        public void RefreshDataGridView()
        {
            RefreshDataGrid(DataGridViewOrders);
        }
        public UC_ДеталиЗаказов()
        {
            InitializeComponent();
            DB = new DB();
        }
        private void CreateColumns()
        {
            DataGridViewOrders.Columns.Add("КодЗаказа", "КодЗаказа");
            DataGridViewOrders.Columns["КодЗаказа"].Visible = false;

            DataGridViewOrders.Columns.Add("НазваниеИзделия", "НазваниеИзделия");
            DataGridViewOrders.Columns.Add("НазваниеРазмера", "НазваниеРазмера");
            DataGridViewOrders.Columns.Add("КоличествоИзделий", "КоличествоИзделий");
            DataGridViewOrders.Columns.Add("КоличествоВыполненных", "КоличествоВыполненных");
            DataGridViewOrders.Columns.Add("Статус", "Статус");
            DataGridViewOrders.Columns.Add("ОбщаяСтоимость", "ОбщаяСтоимость");
            DataGridViewOrders.Columns.Add("ДатаЗаказа", "ДатаЗаказа");

            DataGridViewImageColumn newDeleteColumn = new DataGridViewImageColumn();
            newDeleteColumn.Name = "DeleteColumn";
            newDeleteColumn.HeaderText = "Удалить";
            newDeleteColumn.Image = Properties.Resources.delete;
            newDeleteColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            DataGridViewOrders.Columns.Add(newDeleteColumn);
            DataGridViewOrders.Columns["DeleteColumn"].DisplayIndex = DataGridViewOrders.Columns.Count - 1;
            DataGridViewOrders.Columns["DeleteColumn"].Width = 60;
            DataGridViewOrders.Columns["DeleteColumn"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void ReadSingleRow(DataGridView DGW, IDataRecord record)
        {
            DGW.Rows.Add(
                record.GetInt32(0),                         // КодЗаказа
                record.GetString(1),                        // НазваниеИзделия
                record.GetString(2),                        // НазваниеРазмера
                record.GetInt32(3),                         // КоличествоИзделий
                record.GetInt32(4),                         // КоличествоВыполненных
                record.GetString(5),                        // Статус
                record.GetDecimal(6),                       // ОбщаяСтоимость
                record.GetDateTime(7).ToShortDateString(),                      // ДатаЗаказа
                Properties.Resources.delete
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
    Заказы.Статус, 
    Заказы.ОбщаяСтоимость, 
    Заказы.ДатаЗаказа 
FROM 
    Заказы 
JOIN 
    ВариантыОптимизации ON Заказы.КодОптимизации = ВариантыОптимизации.КодОптимизации
JOIN 
    Размеры ON ВариантыОптимизации.КодРазмера = Размеры.КодРазмера
JOIN 
    Изделия ON ВариантыОптимизации.КодИзделия = Изделия.КодИзделия";

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
    Заказы.Статус, 
    Заказы.ОбщаяСтоимость, 
    Заказы.ДатаЗаказа 
FROM 
    Заказы 
JOIN 
    ВариантыОптимизации ON Заказы.КодОптимизации = ВариантыОптимизации.КодОптимизации
JOIN 
    Размеры ON ВариантыОптимизации.КодРазмера = Размеры.КодРазмера
JOIN 
    Изделия ON ВариантыОптимизации.КодИзделия = Изделия.КодИзделия
WHERE 
    CONCAT(Изделия.НазваниеИзделия, Размеры.НазваниеРазмер, Заказы.Статус, Заказы.ОбщаяСтоимость, Заказы.ДатаЗаказа) LIKE '%" + searchTextBox.Text + "%'";

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
                    reader.GetString(5),                        // Статус
                    reader.GetDecimal(6),                       // ОбщаяСтоимость
                    reader.GetDateTime(7).ToShortDateString(),                      // ДатаЗаказа
                    Properties.Resources.delete
                );
            }
            reader.Close();
        }

        private void comboSearch()
        {
            string quarrySearchPost = $"SELECT DISTINCT Статус FROM Заказы";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(quarrySearchPost, DB.GetConnection());
            DB.OpenConnection();
            DataSet DS = new DataSet();
            sqlDataAdapter.Fill(DS, "Статус");

            DataRow allRow = DS.Tables["Статус"].NewRow();
            allRow["Статус"] = "Все Статусы";
            DS.Tables["Статус"].Rows.InsertAt(allRow, 0);

            comboBoxStatus.DisplayMember = "Статус";
            comboBoxStatus.ValueMember = "Статус";
            comboBoxStatus.DataSource = DS.Tables["Статус"];
            DB.CloseConnection();

            comboBoxStatus.SelectedIndex = 0;
        }
        private void display_DGW()
        {
            string querrySearch;

            if (comboBoxStatus.Text == "Все Статусы")
            {
                querrySearch = $@"
SELECT 
    Заказы.КодЗаказа, 
    Изделия.НазваниеИзделия, 
    Размеры.НазваниеРазмер, 
    ВариантыОптимизации.КоличествоИзделий, 
    Заказы.КоличествоВыполненных, 
    Заказы.Статус, 
    Заказы.ОбщаяСтоимость, 
    Заказы.ДатаЗаказа 
FROM 
    Заказы 
JOIN 
    ВариантыОптимизации ON Заказы.КодОптимизации = ВариантыОптимизации.КодОптимизации
JOIN 
    Размеры ON ВариантыОптимизации.КодРазмера = Размеры.КодРазмера
JOIN 
    Изделия ON ВариантыОптимизации.КодИзделия = Изделия.КодИзделия";
            }
            else
            {
                querrySearch = $@"
SELECT 
    Заказы.КодЗаказа, 
    Изделия.НазваниеИзделия, 
    Размеры.НазваниеРазмер, 
    ВариантыОптимизации.КоличествоИзделий, 
    Заказы.КоличествоВыполненных, 
    Заказы.Статус, 
    Заказы.ОбщаяСтоимость, 
    Заказы.ДатаЗаказа 
FROM 
    Заказы 
JOIN 
    ВариантыОптимизации ON Заказы.КодОптимизации = ВариантыОптимизации.КодОптимизации
JOIN 
    Размеры ON ВариантыОптимизации.КодРазмера = Размеры.КодРазмера
JOIN 
    Изделия ON ВариантыОптимизации.КодИзделия = Изделия.КодИзделия
WHERE 
    Заказы.Статус = @Статус";
            }

            SqlCommand sqlCommand = new SqlCommand(querrySearch, DB.GetConnection());

            if (comboBoxStatus.Text != "Все Статусы")
            {
                sqlCommand.Parameters.AddWithValue("@Статус", comboBoxStatus.Text);
            }

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable DT = new DataTable();
            DataGridViewOrders.Rows.Clear();

            sqlDataAdapter.Fill(DT);

            foreach (DataRow row in DT.Rows)
            {
                DataGridViewOrders.Rows.Add(
                    row["КодЗаказа"],                    // КодЗаказа
                    row["НазваниеИзделия"],              // НазваниеИзделия
                    row["НазваниеРазмер"],               // НазваниеРазмер
                    row["КоличествоИзделий"],            // КоличествоИзделий
                    row["КоличествоВыполненных"],        // КоличествоВыполненных
                    row["Статус"],                       // Статус
                    row["ОбщаяСтоимость"],               // ОбщаяСтоимость
                    ((DateTime)row["ДатаЗаказа"]).ToShortDateString(),                   // ДатаЗаказа
                    Properties.Resources.delete
                );
            }
        }
        private void comboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            display_DGW();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            Search(DataGridViewOrders);
        }

        private void DataGridViewOptimizationOptions_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DataGridViewOrders.Columns["DeleteColumn"].Index && e.RowIndex >= 0)
            {
                DataGridViewOrders.Cursor = Cursors.Hand;
            }
        }

        private void DataGridViewOptimizationOptions_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewOrders.Cursor = Cursors.Default;
        }

        private void UC_ДеталиЗаказов_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(DataGridViewOrders);
            comboSearch();
            display_DGW();
        }

        private void DataGridViewOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == DataGridViewOrders.Columns["DeleteColumn"].Index)
                {
                    int orderId = Convert.ToInt32(DataGridViewOrders.Rows[e.RowIndex].Cells["КодЗаказа"].Value);
                    string productName = DataGridViewOrders.Rows[e.RowIndex].Cells["НазваниеИзделия"].Value.ToString();

                    УдалениеЗаказа deleteForm = new УдалениеЗаказа(orderId, productName, this);
                    deleteForm.FormClosed += (s, args) => RefreshDataGridView();
                    deleteForm.Show();
                }
            }
        }
    }
}
