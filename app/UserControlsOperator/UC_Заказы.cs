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
    public partial class UC_Заказы : UserControl
    {
        private DB DB;
        private ExcelExporter excelExporter;
        public void RefreshDataGridView()
        {
            RefreshDataGrid(DataGridViewOrders);
        }
        public UC_Заказы()
        {
            InitializeComponent();
            DB = new DB();
            excelExporter = new ExcelExporter();
        }
        private void CreateColumns()
        {
            DataGridViewOrders.Columns.Add("КодЗаказа", "КодЗаказа");
            DataGridViewOrders.Columns["КодЗаказа"].Visible = false;

            DataGridViewOrders.Columns.Add("НазваниеИзделия", "Изделия");
            DataGridViewOrders.Columns.Add("НазваниеРазмера", "Размер");
            DataGridViewOrders.Columns.Add("ВидТкани", "Ткань"); // Добавленный столбец
            DataGridViewOrders.Columns.Add("КоличествоИзделий", "Количество");
            DataGridViewOrders.Columns.Add("КоличествоВыполненных", "Выполненные");
            DataGridViewOrders.Columns.Add("Статус", "Статус");
            DataGridViewOrders.Columns.Add("ОбщаяСтоимость", "Общая Стоимость");
            DataGridViewOrders.Columns.Add("ДатаЗаказа", "Дата Заказа");

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
                record.GetString(2),                        // НазваниеРазмер
                record.GetString(3),                        // ВидТкани
                record.GetInt32(4),                         // КоличествоИзделий
                record.GetInt32(5),                         // КоличествоВыполненных
                record.GetString(6),                        // Статус
                record.GetDecimal(7),                       // ОбщаяСтоимость
                record.GetDateTime(8).ToShortDateString(),  // ДатаЗаказа
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
    Ткани.Вид AS ВидТкани,
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
JOIN 
    Ткани ON ВариантыОптимизации.КодТкани = Ткани.КодТкани";

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
    Ткани.Вид AS ВидТкани,
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
JOIN 
    Ткани ON ВариантыОптимизации.КодТкани = Ткани.КодТкани
WHERE 
    CONCAT(Изделия.НазваниеИзделия, Размеры.НазваниеРазмер, Ткани.Вид, Заказы.Статус, Заказы.ОбщаяСтоимость, Заказы.ДатаЗаказа) LIKE '%" + searchTextBox.Text + "%'";

            SqlCommand sqlCommand = new SqlCommand(querrySearch, DB.GetConnection());
            DB.OpenConnection();
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                DGW.Rows.Add(
                    reader.GetInt32(0),                         // КодЗаказа
                    reader.GetString(1),                        // НазваниеИзделия
                    reader.GetString(2),                        // НазваниеРазмер
                    reader.GetString(3),                        // ВидТкани
                    reader.GetInt32(4),                         // КоличествоИзделий
                    reader.GetInt32(5),                         // КоличествоВыполненных
                    reader.GetString(6),                        // Статус
                    reader.GetDecimal(7),                       // ОбщаяСтоимость
                    reader.GetDateTime(8).ToShortDateString(),  // ДатаЗаказа
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
    Ткани.Вид AS ВидТкани,
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
JOIN 
    Ткани ON ВариантыОптимизации.КодТкани = Ткани.КодТкани";
            }
            else
            {
                querrySearch = $@"
SELECT 
    Заказы.КодЗаказа, 
    Изделия.НазваниеИзделия, 
    Размеры.НазваниеРазмер, 
    Ткани.Вид AS ВидТкани,
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
JOIN 
    Ткани ON ВариантыОптимизации.КодТкани = Ткани.КодТкани
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
                    row["ВидТкани"],                     // ВидТкани
                    row["КоличествоИзделий"],            // КоличествоИзделий
                    row["КоличествоВыполненных"],        // КоличествоВыполненных
                    row["Статус"],                       // Статус
                    row["ОбщаяСтоимость"],               // ОбщаяСтоимость
                    ((DateTime)row["ДатаЗаказа"]).ToShortDateString(),  // ДатаЗаказа
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

        private void ButtonExcel_Click(object sender, EventArgs e)
        {
            excelExporter.ExportExcel(DataGridViewOrders);
        }
    }
}
