using app.Classes;
using app.Forms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace app.UserControlsOperator
{
    public partial class UC_Изделия : UserControl
    {
        private DB DB;
        private ExcelExporter excelExporter;
        public void RefreshDataGridView()
        {
            RefreshDataGrid(DataGridViewProduct);
        }
        public UC_Изделия()
        {
            InitializeComponent();
            DB = new DB();
            excelExporter = new ExcelExporter();
            DataGridViewProduct.CellMouseEnter += DataGridViewProduct_CellMouseEnter;
            DataGridViewProduct.CellMouseLeave += DataGridViewProduct_CellMouseLeave;
        }
        private void CreateColumns()
        {
            DataGridViewProduct.Columns.Add("КодРазмера", "КодРазмера");
            DataGridViewProduct.Columns["КодРазмера"].Visible = false;
            DataGridViewProduct.Columns.Add("КодИзделия", "КодИзделия");
            DataGridViewProduct.Columns["КодИзделия"].Visible = false;
            DataGridViewProduct.Columns.Add("НазваниеИзделия", "Изделие");
            DataGridViewProduct.Columns.Add("НазваниеРазмер", "Размер");
            DataGridViewProduct.Columns.Add("НеобходимаяДлинаТкани", "Длина");
            DataGridViewProduct.Columns.Add("НеобходимаяШиринаТкани", "Ширина");
            DataGridViewProduct.Columns.Add("Плотность", "Плотность");
            DataGridViewProduct.Columns.Add("КодТкани", "Ткань");
            DataGridViewImageColumn newEditColumn = new DataGridViewImageColumn();
            newEditColumn.Name = "EditColumn";
            newEditColumn.HeaderText = "Изменить";
            newEditColumn.Image = Properties.Resources.edit;
            newEditColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            DataGridViewProduct.Columns.Add(newEditColumn);
            DataGridViewProduct.Columns["EditColumn"].DisplayIndex = DataGridViewProduct.Columns.Count - 1;
            DataGridViewProduct.Columns["EditColumn"].Width = 60;
            DataGridViewProduct.Columns["EditColumn"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataGridViewImageColumn newDeleteColumn = new DataGridViewImageColumn();
            newDeleteColumn.Name = "DeleteColumn";
            newDeleteColumn.HeaderText = "Удалить";
            newDeleteColumn.Image = Properties.Resources.delete;
            newDeleteColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            DataGridViewProduct.Columns.Add(newDeleteColumn);
            DataGridViewProduct.Columns["DeleteColumn"].DisplayIndex = DataGridViewProduct.Columns.Count - 1;
            DataGridViewProduct.Columns["DeleteColumn"].Width = 60;
            DataGridViewProduct.Columns["DeleteColumn"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        private static void ReadSingleRow(DataGridView DGW, IDataRecord record)
        {
            DGW.Rows.Add(
                record.GetInt32(0),
                record.GetInt32(1),
                record.GetString(3),
                record.GetString(2),
                record.GetDecimal(4),
                record.GetDecimal(5),
                record.GetDecimal(6),
                record.GetString(7),
                Properties.Resources.edit,
                Properties.Resources.delete
            );
        }
        private void RefreshDataGrid(DataGridView DGW)
        {
            DGW.Rows.Clear();
            string queryString = @"SELECT Размеры.КодРазмера, Изделия.КодИзделия, Размеры.НазваниеРазмер, Изделия.НазваниеИзделия, Размеры.НеобходимаяДлинаТкани, Размеры.НеобходимаяШиринаТкани, Изделия.Плотность, Ткани.Вид AS ВидТкани FROM Размеры JOIN Изделия ON Размеры.КодИзделия = Изделия.КодИзделия JOIN Ткани ON Изделия.КодТкани = Ткани.КодТкани";
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
        private void UC_Изделия_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(DataGridViewProduct);
            comboSearch();
            display_DGW();
        }
        private void DataGridViewProduct_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.ColumnIndex == DataGridViewProduct.Columns["EditColumn"].Index || e.ColumnIndex == DataGridViewProduct.Columns["DeleteColumn"].Index) && e.RowIndex >= 0)
            {
                DataGridViewProduct.Cursor = Cursors.Hand;
            }
        }
        private void DataGridViewProduct_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewProduct.Cursor = Cursors.Default;
        }
        private void Search(DataGridView DGW)
        {
            DGW.Rows.Clear();
            string querrySearch = $"SELECT Размеры.КодРазмера, Изделия.КодИзделия, Размеры.НазваниеРазмер, Изделия.НазваниеИзделия, Размеры.НеобходимаяДлинаТкани, Размеры.НеобходимаяШиринаТкани, Изделия.Плотность, Ткани.Вид AS ВидТкани FROM Размеры JOIN Изделия ON Размеры.КодИзделия = Изделия.КодИзделия JOIN Ткани ON Изделия.КодТкани = Ткани.КодТкани WHERE CONCAT(НазваниеРазмер, НазваниеИзделия, НеобходимаяДлинаТкани, НеобходимаяШиринаТкани, Плотность, Ткани.Вид) LIKE '%" + searchTextBox.Text + "%'";
            SqlCommand sqlCommand = new SqlCommand(querrySearch, DB.GetConnection());
            DB.OpenConnection();
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                DGW.Rows.Add(
                    reader.GetInt32(0),
                    reader.GetInt32(1),
                    reader.GetString(3),
                    reader.GetString(2),
                    reader.GetDecimal(4),
                    reader.GetDecimal(5),
                    reader.GetDecimal(6),
                    reader.GetString(7),
                    Properties.Resources.edit,
                    Properties.Resources.delete
                );
            }
            reader.Close();
        }
        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            Search(DataGridViewProduct);
        }
        private void comboSearch()
        {
            string quarrySearchPost = $"SELECT DISTINCT НазваниеИзделия FROM Изделия";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(quarrySearchPost, DB.GetConnection());
            DB.OpenConnection();
            DataSet DS = new DataSet();
            sqlDataAdapter.Fill(DS, "НазваниеИзделия");
            DataRow allRow = DS.Tables["НазваниеИзделия"].NewRow();
            allRow["НазваниеИзделия"] = "Все Изделия";
            DS.Tables["НазваниеИзделия"].Rows.InsertAt(allRow, 0);
            comboBoxPostSearch.DisplayMember = "НазваниеИзделия";
            comboBoxPostSearch.ValueMember = "НазваниеИзделия";
            comboBoxPostSearch.DataSource = DS.Tables["НазваниеИзделия"];
            DB.CloseConnection();
            comboBoxPostSearch.SelectedIndex = 0;
        }
        private void display_DGW()
        {
            string querrySearch;
            if (comboBoxPostSearch.Text == "Все Изделия")
            {
                querrySearch = $"SELECT Размеры.КодРазмера, Изделия.КодИзделия, Размеры.НазваниеРазмер, Изделия.НазваниеИзделия, Размеры.НеобходимаяДлинаТкани, Размеры.НеобходимаяШиринаТкани, Изделия.Плотность, Ткани.Вид AS ВидТкани FROM Размеры JOIN Изделия ON Размеры.КодИзделия = Изделия.КодИзделия JOIN Ткани ON Изделия.КодТкани = Ткани.КодТкани";
            }
            else
            {
                querrySearch = $"SELECT Размеры.КодРазмера, Изделия.КодИзделия, Размеры.НазваниеРазмер, Изделия.НазваниеИзделия, Размеры.НеобходимаяДлинаТкани, Размеры.НеобходимаяШиринаТкани, Изделия.Плотность, Ткани.Вид AS ВидТкани FROM Размеры JOIN Изделия ON Размеры.КодИзделия = Изделия.КодИзделия JOIN Ткани ON Изделия.КодТкани = Ткани.КодТкани WHERE Изделия.НазваниеИзделия = @НазваниеИзделия";
            }
            SqlCommand sqlCommand = new SqlCommand(querrySearch, DB.GetConnection());
            if (comboBoxPostSearch.Text != "Все Изделия")
            {
                sqlCommand.Parameters.AddWithValue("@НазваниеИзделия", comboBoxPostSearch.Text);
            }
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable DT = new DataTable();
            DataGridViewProduct.Rows.Clear();
            sqlDataAdapter.Fill(DT);
            foreach (DataRow row in DT.Rows)
            {
                DataGridViewProduct.Rows.Add(
                    row["КодРазмера"],
                    row["КодИзделия"],
                    row["НазваниеИзделия"],
                    row["НазваниеРазмер"],
                    row["НеобходимаяДлинаТкани"],
                    row["НеобходимаяШиринаТкани"],
                    row["Плотность"],
                    row["ВидТкани"],
                    Properties.Resources.edit,
                    Properties.Resources.delete
                );
            }
        }
        private void comboBoxPostSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            display_DGW();
        }
        private void DataGridViewProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == DataGridViewProduct.Columns["EditColumn"].Index)
                {
                    int sizeId = Convert.ToInt32(DataGridViewProduct.Rows[e.RowIndex].Cells["КодРазмера"].Value);
                    string sizeName = DataGridViewProduct.Rows[e.RowIndex].Cells["НазваниеРазмер"].Value.ToString();
                    int productId = Convert.ToInt32(DataGridViewProduct.Rows[e.RowIndex].Cells["КодИзделия"].Value);
                    string productName = DataGridViewProduct.Rows[e.RowIndex].Cells["НазваниеИзделия"].Value.ToString();
                    string length = DataGridViewProduct.Rows[e.RowIndex].Cells["НеобходимаяДлинаТкани"].Value.ToString();
                    string width = DataGridViewProduct.Rows[e.RowIndex].Cells["НеобходимаяШиринаТкани"].Value.ToString();
                    string density = DataGridViewProduct.Rows[e.RowIndex].Cells["Плотность"].Value.ToString();
                    string fabricId = DataGridViewProduct.Rows[e.RowIndex].Cells["КодТкани"].Value.ToString();
                    ИзменениеИзделия editForm = new ИзменениеИзделия(sizeId, sizeName, productId, productName, length, width, density, fabricId, this);
                    editForm.FormClosed += (s, args) => RefreshDataGridView();
                    editForm.Show();
                }
                else if (e.ColumnIndex == DataGridViewProduct.Columns["DeleteColumn"].Index)
                {
                    int productId = Convert.ToInt32(DataGridViewProduct.Rows[e.RowIndex].Cells["КодИзделия"].Value);
                    string productName = DataGridViewProduct.Rows[e.RowIndex].Cells["НазваниеИзделия"].Value.ToString();
                    УдалениеИзделия deleteForm = new УдалениеИзделия(productId, productName, this);
                    deleteForm.FormClosed += (s, args) => RefreshDataGridView();
                    deleteForm.Show();
                }

            }
        }
        private void ButtonSaveOrder_Click(object sender, EventArgs e)
        {
            ДобавлениеИзделия toForm = new ДобавлениеИзделия(this);
            toForm.Show();
        }
        private void ButtonExcel_Click(object sender, EventArgs e)
        {
            excelExporter.ExportExcel(DataGridViewProduct);
        }
    }
}
