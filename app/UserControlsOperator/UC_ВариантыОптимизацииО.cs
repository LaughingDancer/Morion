using app.Classes;
using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace app.UserControlsOperator
{
    public partial class UC_ВариантыОптимизацииО : UserControl
    {
        private DB DB;
        private ExcelExporter excelExporter;
        private int employeeId;
        public UC_ВариантыОптимизацииО(int employeeId)
        {
            InitializeComponent();
            this.employeeId = employeeId;
            DB = new DB();
            excelExporter = new ExcelExporter();
        }
        private void CreateColumns()
        {
            DataGridViewOptimizationOptions.Columns.Add("КодОптимизации", "КодОптимизации");
            DataGridViewOptimizationOptions.Columns["КодОптимизации"].Visible = false;
            DataGridViewOptimizationOptions.Columns.Add("КодСотрудника", "КодСотрудника");
            DataGridViewOptimizationOptions.Columns["КодСотрудника"].Visible = false;
            DataGridViewOptimizationOptions.Columns.Add("ФамилияСотрудника", "Сотрудник");
            DataGridViewOptimizationOptions.Columns.Add("ВидТкани", "Ткань");
            DataGridViewOptimizationOptions.Columns.Add("ДлинаТкани", "Длина (м)");
            DataGridViewOptimizationOptions.Columns.Add("ШиринаТкани", "Ширина (м)");
            DataGridViewOptimizationOptions.Columns.Add("НазваниеИзделия", "Изделия");
            DataGridViewOptimizationOptions.Columns.Add("НазваниеРазмер", "Размер");
            DataGridViewOptimizationOptions.Columns["НазваниеРазмер"].Width = 65;
            DataGridViewOptimizationOptions.Columns.Add("КоличествоИзделий", "Количество Изделий (шт)");
            DataGridViewOptimizationOptions.Columns.Add("КоличествоОтходов", "Отходы (м)");
            DataGridViewOptimizationOptions.Columns["КоличествоОтходов"].Width = 65;
            DataGridViewOptimizationOptions.Columns.Add("ПроцентОтходов", "Отходы (%)");
            DataGridViewOptimizationOptions.Columns["ПроцентОтходов"].Width = 65;
            DataGridViewOptimizationOptions.Columns.Add("ДатаСоздания", "Дата Создания");
            DataGridViewOptimizationOptions.Columns["ДатаСоздания"].Width = 65;
        }
        private static void ReadSingleRow(DataGridView DGW, IDataRecord Record)
        {
            DGW.Rows.Add(
                Record["КодОптимизации"],
                Record["КодСотрудника"],
                Record["ФамилияСотрудника"],
                Record["ВидТкани"],
                Record["ДлинаТкани"],
                Record["ШиринаТкани"],
                Record["НазваниеИзделия"],
                Record["НазваниеРазмер"],
                Record["КоличествоИзделий"],
                Record["КоличествоОтходов"],
                Record["ПроцентОтходов"],
                Record["ДатаСоздания"]
            );
        }
        private void RefreshDataGrid(DataGridView DGW)
        {
            DGW.Rows.Clear();
            string queryString = @"SELECT ВариантыОптимизации.КодОптимизации, ВариантыОптимизации.КодСотрудника, Сотрудники.Фамилия AS ФамилияСотрудника, Ткани.Вид AS ВидТкани, Изделия.НазваниеИзделия, Размеры.НазваниеРазмер, ВариантыОптимизации.КоличествоИзделий, ВариантыОптимизации.КоличествоОтходов, ВариантыОптимизации.ПроцентОтходов, ВариантыОптимизации.ДатаСоздания, Ткани.Длина AS ДлинаТкани, Ткани.Ширина AS ШиринаТкани FROM ВариантыОптимизации JOIN Ткани ON ВариантыОптимизации.КодТкани = Ткани.КодТкани JOIN Изделия ON ВариантыОптимизации.КодИзделия = Изделия.КодИзделия JOIN Размеры ON ВариантыОптимизации.КодРазмера = Размеры.КодРазмера JOIN Сотрудники ON ВариантыОптимизации.КодСотрудника = Сотрудники.КодСотрудника WHERE ВариантыОптимизации.КодСотрудника = @КодСотрудника";
            SqlCommand command = new SqlCommand(queryString, DB.GetConnection());
            command.Parameters.AddWithValue("@КодСотрудника", employeeId);
            DB.OpenConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(DGW, reader);
            }
            reader.Close();
            DB.CloseConnection();
        }
        private void UC_ВариантыОптимизацииО_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(DataGridViewOptimizationOptions);
            comboSearch();
            display_DGW();
        }
        private void Search(DataGridView DGW)
        {
            DGW.Rows.Clear();
            string querrySearch = $@"SELECT ВариантыОптимизации.КодОптимизации, ВариантыОптимизации.КодСотрудника, Сотрудники.Фамилия AS ФамилияСотрудника, Ткани.Вид AS ВидТкани, Изделия.НазваниеИзделия, Размеры.НазваниеРазмер, ВариантыОптимизации.КоличествоИзделий, ВариантыОптимизации.КоличествоОтходов, ВариантыОптимизации.ПроцентОтходов, ВариантыОптимизации.ДатаСоздания, Ткани.Длина AS ДлинаТкани, Ткани.Ширина AS ШиринаТкани FROM ВариантыОптимизации JOIN Ткани ON ВариантыОптимизации.КодТкани = Ткани.КодТкани JOIN Изделия ON ВариантыОптимизации.КодИзделия = Изделия.КодИзделия JOIN Размеры ON ВариантыОптимизации.КодРазмера = Размеры.КодРазмера JOIN Сотрудники ON ВариантыОптимизации.КодСотрудника = Сотрудники.КодСотрудника WHERE CONCAT(Сотрудники.Фамилия, Ткани.Вид, Изделия.НазваниеИзделия, Размеры.НазваниеРазмер, ВариантыОптимизации.КоличествоИзделий, ВариантыОптимизации.КоличествоОтходов, ВариантыОптимизации.ПроцентОтходов, ВариантыОптимизации.ДатаСоздания, Ткани.Длина, Ткани.Ширина) LIKE '%{searchTextBox.Text}%'";
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
            string querrySearch = @"SELECT ВариантыОптимизации.КодОптимизации, ВариантыОптимизации.КодСотрудника, Сотрудники.Фамилия AS ФамилияСотрудника, Ткани.Вид AS ВидТкани, Изделия.НазваниеИзделия, Размеры.НазваниеРазмер, ВариантыОптимизации.КоличествоИзделий, ВариантыОптимизации.КоличествоОтходов, ВариантыОптимизации.ПроцентОтходов, ВариантыОптимизации.ДатаСоздания, Ткани.Длина AS ДлинаТкани, Ткани.Ширина AS ШиринаТкани FROM ВариантыОптимизации JOIN Ткани ON ВариантыОптимизации.КодТкани = Ткани.КодТкани JOIN Изделия ON ВариантыОптимизации.КодИзделия = Изделия.КодИзделия JOIN Размеры ON ВариантыОптимизации.КодРазмера = Размеры.КодРазмера JOIN Сотрудники ON ВариантыОптимизации.КодСотрудника = Сотрудники.КодСотрудника WHERE ВариантыОптимизации.КодСотрудника = @КодСотрудника AND (@Вид IS NULL OR Ткани.Вид = @Вид) AND (@Поиск IS NULL OR CONCAT(Сотрудники.Фамилия, Ткани.Вид, Изделия.НазваниеИзделия, Размеры.НазваниеРазмер, ВариантыОптимизации.КоличествоИзделий, ВариантыОптимизации.КоличествоОтходов, ВариантыОптимизации.ПроцентОтходов, ВариантыОптимизации.ДатаСоздания, Ткани.Длина, Ткани.Ширина) LIKE '%' + @Поиск + '%')";
            SqlCommand sqlCommand = new SqlCommand(querrySearch, DB.GetConnection());
            sqlCommand.Parameters.AddWithValue("@КодСотрудника", employeeId);
            if (comboBoxPostSearch.Text != "Все Виды")
            {
                sqlCommand.Parameters.AddWithValue("@Вид", comboBoxPostSearch.Text);
            }
            else
            {
                sqlCommand.Parameters.AddWithValue("@Вид", DBNull.Value);
            }
            if (!string.IsNullOrWhiteSpace(searchTextBox.Text))
            {
                sqlCommand.Parameters.AddWithValue("@Поиск", searchTextBox.Text);
            }
            else
            {
                sqlCommand.Parameters.AddWithValue("@Поиск", DBNull.Value);
            }
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable DT = new DataTable();
            DataGridViewOptimizationOptions.Rows.Clear();
            sqlDataAdapter.Fill(DT);
            foreach (DataRow row in DT.Rows)
            {
                DataGridViewOptimizationOptions.Rows.Add(
                    row["КодОптимизации"],
                    row["КодСотрудника"],
                    row["ФамилияСотрудника"],
                    row["ВидТкани"],
                    row["ДлинаТкани"],
                    row["ШиринаТкани"],
                    row["НазваниеИзделия"],
                    row["НазваниеРазмер"],
                    row["КоличествоИзделий"],
                    row["КоличествоОтходов"],
                    row["ПроцентОтходов"],
                    ((DateTime)row["ДатаСоздания"]).ToShortDateString()
                );
            }
        }
        private void comboBoxPostSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            display_DGW();
        }
        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            Search(DataGridViewOptimizationOptions);
        }
        private void ButtonExcel_Click(object sender, EventArgs e)
        {
            excelExporter.ExportExcel(DataGridViewOptimizationOptions);
        }
    }
}