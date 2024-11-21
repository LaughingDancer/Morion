using app.Classes;
using app.Forms;
using System;
using System.Data;
using System.Data.SqlClient;
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
            DataGridViewOrders.Columns.Add("ВидТкани", "Ткань");
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
            DataGridViewOrders.Columns["DeleteColumn"].Width = 80;
            DataGridViewOrders.Columns["DeleteColumn"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        private void ReadSingleRow(DataGridView DGW, IDataRecord record)
        {
            DGW.Rows.Add(
                record.GetInt32(0),
                record.GetString(1),
                record.GetString(2),
                record.GetString(3),
                record.GetInt32(4),
                record.GetInt32(5),
                record.GetString(6),
                record.GetDecimal(7),
                record.GetDateTime(8).ToShortDateString(),
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
                MyCustomMessageBox.ShowMessage("Возникла ошибка при выполнении запроса: " + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetString(3),
                    reader.GetInt32(4),
                    reader.GetInt32(5),
                    reader.GetString(6),
                    reader.GetDecimal(7),
                    reader.GetDateTime(8).ToShortDateString(),
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
                    row["КодЗаказа"],
                    row["НазваниеИзделия"],
                    row["НазваниеРазмер"],
                    row["ВидТкани"],
                    row["КоличествоИзделий"],
                    row["КоличествоВыполненных"],
                    row["Статус"],
                    row["ОбщаяСтоимость"],
                    ((DateTime)row["ДатаЗаказа"]).ToShortDateString(),
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
