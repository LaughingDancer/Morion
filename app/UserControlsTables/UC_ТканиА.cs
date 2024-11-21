using app.Classes;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace app.UserControls
{
    public partial class UC_ТканиА : UserControl
    {
        private DB DB;
        private ExcelExporter excelExporter;
        public void RefreshDataGridView()
        {
            RefreshDataGrid(DataGridViewPeople);
        }
        public UC_ТканиА()
        {
            InitializeComponent();
            DB = new DB();
            excelExporter = new ExcelExporter();
        }
        private void CreateColumns()
        {
            DataGridViewPeople.Columns.Add("КодТкани", "КодТкани");
            DataGridViewPeople.Columns["КодТкани"].Visible = false;
            DataGridViewPeople.Columns.Add("Вид", "Вид");
            DataGridViewPeople.Columns.Add("Ширина", "Ширина");
            DataGridViewPeople.Columns.Add("Длина", "Длина");
            DataGridViewPeople.Columns.Add("ЦенаЗаМетр", "Цена за метр");
            DataGridViewPeople.Columns.Add("Количество", "Количество");
        }
        private void ReadSingleRow(DataGridView DGW, IDataRecord Record)
        {
            DGW.Rows.Add(
                Record["КодТкани"],
                Record["Вид"],
                Record["Ширина"],
                Record["Длина"],
                Record["ЦенаЗаМетр"],
                Record["Количество"]
            );
        }
        private void RefreshDataGrid(DataGridView DGW)
        {
            DGW.Rows.Clear();
            string queryString = "SELECT * FROM Ткани";
            SqlCommand command = new SqlCommand(queryString, DB.GetConnection());
            DB.OpenConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(DGW, reader);
            }
            reader.Close();
            DB.CloseConnection();
        }
        private void UC_ТканиА_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(DataGridViewPeople);
            comboSearch();
            display_DGW();
        }
        private void Search(DataGridView DGW)
        {
            DGW.Rows.Clear();
            string querrySearch = $@"
        SELECT * 
        FROM Ткани 
        WHERE CONCAT(Вид, Ширина, Длина, ЦенаЗаМетр, Количество) LIKE '%" + searchTextBox.Text + "%'";
            SqlCommand sqlCommand = new SqlCommand(querrySearch, DB.GetConnection());
            DB.OpenConnection();
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(DGW, reader);
            }
            reader.Close();
            DB.CloseConnection();
        }
        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            Search(DataGridViewPeople);
        }
        private void comboSearch()
        {
            string quarrySearchPost = $"SELECT DISTINCT Вид FROM Ткани";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(quarrySearchPost, DB.GetConnection());
            DB.OpenConnection();
            DataSet DS = new DataSet();
            sqlDataAdapter.Fill(DS, "Вид");
            DataRow allRow = DS.Tables["Вид"].NewRow();
            allRow["Вид"] = "Все Виды";
            DS.Tables["Вид"].Rows.InsertAt(allRow, 0);
            comboBoxPostSearch.DisplayMember = "Вид";
            comboBoxPostSearch.ValueMember = "Вид";
            comboBoxPostSearch.DataSource = DS.Tables["Вид"];
            DB.CloseConnection();
            comboBoxPostSearch.SelectedIndex = 0;
        }
        private void display_DGW()
        {
            string querrySearch;
            if (comboBoxPostSearch.Text == "Все Виды")
            {
                querrySearch = "SELECT * FROM Ткани";
            }
            else
            {
                querrySearch = $@"
                SELECT * 
                FROM Ткани 
                WHERE Вид = @Вид";
            }
            SqlCommand sqlCommand = new SqlCommand(querrySearch, DB.GetConnection());
            if (comboBoxPostSearch.Text != "Все Виды")
            {
                sqlCommand.Parameters.AddWithValue("@Вид", comboBoxPostSearch.Text);
            }
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable DT = new DataTable();
            DataGridViewPeople.Rows.Clear();
            sqlDataAdapter.Fill(DT);
            foreach (DataRow row in DT.Rows)
            {
                DataGridViewPeople.Rows.Add(
                    row["КодТкани"],
                    row["Вид"],
                    row["Ширина"],
                    row["Длина"],
                    row["ЦенаЗаМетр"],
                    row["Количество"]
                );
            }
        }
        private void comboBoxPostSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            display_DGW();
        }
        private void ButtonExcel_Click(object sender, EventArgs e)
        {
            excelExporter.ExportExcel(DataGridViewPeople);
        }
    }
}