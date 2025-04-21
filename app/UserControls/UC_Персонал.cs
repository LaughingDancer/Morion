using app.Classes;
using app.Forms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace app.UserControls
{
    public partial class UC_Персонал : UserControl
    {
        private DB DB;
        public void RefreshDataGridView()
        {
            RefreshDataGrid(DataGridViewPeople);
        }
        public UC_Персонал()
        {
            InitializeComponent();
            DB = new DB();
            DataGridViewPeople.CellMouseEnter += DataGridViewPeople_CellMouseEnter;
            DataGridViewPeople.CellMouseLeave += DataGridViewPeople_CellMouseLeave;
        }
        private void CreateColumns()
        {
            DataGridViewPeople.Columns.Add("КодСотрудника", "КодСотрудника");
            DataGridViewPeople.Columns["КодСотрудника"].Visible = false;
            DataGridViewPeople.Columns.Add("Логин", "Логин");
            DataGridViewPeople.Columns.Add("Фамилия", "Фамилия");
            DataGridViewPeople.Columns.Add("Имя", "Имя");
            DataGridViewPeople.Columns.Add("ЭлектроннаяПочта", "Email");
            DataGridViewPeople.Columns.Add("ДатаПриема", "Дата Приема");
            DataGridViewPeople.Columns.Add("Зарплата", "Зарплата");
            DataGridViewPeople.Columns.Add("Должность", "Должность");
            DataGridViewPeople.Columns.Add("Бригада", "Бригада");
            DataGridViewImageColumn newEditColumn = new DataGridViewImageColumn();
            newEditColumn.Name = "EditColumn";
            newEditColumn.HeaderText = "Изменить";
            newEditColumn.Image = Properties.Resources.edit;
            newEditColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            DataGridViewPeople.Columns.Add(newEditColumn);
            DataGridViewPeople.Columns["EditColumn"].DisplayIndex = DataGridViewPeople.Columns.Count - 1;
            DataGridViewPeople.Columns["EditColumn"].Width = 60;
            DataGridViewPeople.Columns["EditColumn"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataGridViewImageColumn newDeleteColumn = new DataGridViewImageColumn();
            newDeleteColumn.Name = "DeleteColumn";
            newDeleteColumn.HeaderText = "Уволить";
            newDeleteColumn.Image = Properties.Resources.delete;
            newDeleteColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            DataGridViewPeople.Columns.Add(newDeleteColumn);
            DataGridViewPeople.Columns["DeleteColumn"].DisplayIndex = DataGridViewPeople.Columns.Count - 1;
            DataGridViewPeople.Columns["DeleteColumn"].Width = 60;
            DataGridViewPeople.Columns["DeleteColumn"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        private static void ReadSingleRow(DataGridView DGW, IDataRecord Record)
        {
            string brigadeName = Record["НазваниеБригады"] == DBNull.Value ? " " : Record["НазваниеБригады"].ToString();
            DGW.Rows.Add(
                Record["КодСотрудника"],
                Record["Логин"],
                Record["Фамилия"],
                Record["Имя"],
                Record["ЭлектроннаяПочта"],
                ((DateTime)Record["ДатаПриема"]).ToShortDateString(),
                Record["Зарплата"],
                Record["Должность"],
                brigadeName,
                Properties.Resources.edit,
                Properties.Resources.delete
            );
        }
        private void RefreshDataGrid(DataGridView DGW)
        {
            DGW.Rows.Clear();
            string queryString = @"SELECT Сотрудники.*, Пользователи.Логин, Пользователи.Должность, Бригады.НазваниеБригады FROM Сотрудники JOIN Пользователи ON Сотрудники.КодПользователя = Пользователи.КодПользователя LEFT JOIN Бригады ON Сотрудники.КодБригады = Бригады.КодБригады WHERE Сотрудники.Статус <> 'Уволен' OR Сотрудники.Статус IS NULL";
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
        private void UC_Персонал_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(DataGridViewPeople);
            comboSearch();
            display_DGW();
        }
        private void DataGridViewPeople_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.ColumnIndex == DataGridViewPeople.Columns["EditColumn"].Index || e.ColumnIndex == DataGridViewPeople.Columns["DeleteColumn"].Index) && e.RowIndex >= 0)
            {
                DataGridViewPeople.Cursor = Cursors.Hand;
            }
        }
        private void DataGridViewPeople_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewPeople.Cursor = Cursors.Default;
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ДобавлениеПерсонал toForm = new ДобавлениеПерсонал(this);
            toForm.Show();
        }
        private void DataGridViewPeople_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == DataGridViewPeople.Columns["EditColumn"].Index)
                {
                    int employeeId = Convert.ToInt32(DataGridViewPeople.Rows[e.RowIndex].Cells["КодСотрудника"].Value);
                    string firstName = DataGridViewPeople.Rows[e.RowIndex].Cells["Имя"].Value.ToString();
                    string lastName = DataGridViewPeople.Rows[e.RowIndex].Cells["Фамилия"].Value.ToString();
                    string email = DataGridViewPeople.Rows[e.RowIndex].Cells["ЭлектроннаяПочта"].Value.ToString();
                    string dateOfHire = DataGridViewPeople.Rows[e.RowIndex].Cells["ДатаПриема"].Value.ToString();
                    string salary = DataGridViewPeople.Rows[e.RowIndex].Cells["Зарплата"].Value.ToString();
                    string post = DataGridViewPeople.Rows[e.RowIndex].Cells["Должность"].Value.ToString();
                    string login = DataGridViewPeople.Rows[e.RowIndex].Cells["Логин"].Value.ToString();
                    ИзменениеПерсонал editForm = new ИзменениеПерсонал(employeeId, firstName, lastName, email, dateOfHire, salary, post, login, this);
                    editForm.Show();
                    RefreshDataGridView();
                }
                else if (e.ColumnIndex == DataGridViewPeople.Columns["DeleteColumn"].Index)
                {
                    int employeeId = Convert.ToInt32(DataGridViewPeople.Rows[e.RowIndex].Cells["КодСотрудника"].Value);
                    string firstName = DataGridViewPeople.Rows[e.RowIndex].Cells["Имя"].Value.ToString();
                    string lastName = DataGridViewPeople.Rows[e.RowIndex].Cells["Фамилия"].Value.ToString();
                    string email = DataGridViewPeople.Rows[e.RowIndex].Cells["ЭлектроннаяПочта"].Value.ToString();
                    УдалениеПерсонал fireForm = new УдалениеПерсонал(employeeId, firstName, lastName, email, this);
                    fireForm.Show();
                }
            }
        }
        private void Search(DataGridView DGW)
        {
            DGW.Rows.Clear();
            string querrySearch = $@"SELECT Сотрудники.*, Пользователи.Логин, Пользователи.Должность, Бригады.НазваниеБригады FROM Сотрудники JOIN Пользователи ON Сотрудники.КодПользователя = Пользователи.КодПользователя LEFT JOIN Бригады ON Сотрудники.КодБригады = Бригады.КодБригады WHERE (Сотрудники.Статус <> 'Уволен' OR Сотрудники.Статус IS NULL) AND CONCAT(Имя, Фамилия, ЭлектроннаяПочта, ДатаПриема, Зарплата, Пользователи.Логин, Пользователи.Должность, Бригады.НазваниеБригады) LIKE '%{searchTextBox.Text}%'";
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
            string quarrySearchPost = $"SELECT DISTINCT Должность FROM Пользователи";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(quarrySearchPost, DB.GetConnection());
            DB.OpenConnection();
            DataSet DS = new DataSet();
            sqlDataAdapter.Fill(DS, "Должность");
            DataRow allRow = DS.Tables["Должность"].NewRow();
            allRow["Должность"] = "Все Должности";
            DS.Tables["Должность"].Rows.InsertAt(allRow, 0);
            comboBoxPostSearch.DisplayMember = "Должность";
            comboBoxPostSearch.ValueMember = "Должность";
            comboBoxPostSearch.DataSource = DS.Tables["Должность"];
            DB.CloseConnection();
            comboBoxPostSearch.SelectedIndex = 0;
        }
        private void display_DGW()
        {
            string querrySearch;
            if (comboBoxPostSearch.Text == "Все Должности")
            {
                querrySearch = @"SELECT Сотрудники.*, Пользователи.Должность, Пользователи.Логин, Бригады.НазваниеБригады FROM Сотрудники JOIN Пользователи ON Сотрудники.КодПользователя = Пользователи.КодПользователя LEFT JOIN Бригады ON Сотрудники.КодБригады = Бригады.КодБригады WHERE Сотрудники.Статус <> 'Уволен' OR Сотрудники.Статус IS NULL";
            }
            else
            {
                querrySearch = @"SELECT Сотрудники.*, Пользователи.Должность, Пользователи.Логин, Бригады.НазваниеБригады FROM Сотрудники JOIN Пользователи ON Сотрудники.КодПользователя = Пользователи.КодПользователя LEFT JOIN Бригады ON Сотрудники.КодБригады = Бригады.КодБригады WHERE Пользователи.Должность = @Должность AND (Сотрудники.Статус <> 'Уволен' OR Сотрудники.Статус IS NULL)";
            }
            SqlCommand sqlCommand = new SqlCommand(querrySearch, DB.GetConnection());
            if (comboBoxPostSearch.Text != "Все Должности")
            {
                sqlCommand.Parameters.AddWithValue("@Должность", comboBoxPostSearch.Text);
            }
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable DT = new DataTable();
            DataGridViewPeople.Rows.Clear();
            sqlDataAdapter.Fill(DT);
            foreach (DataRow row in DT.Rows)
            {
                string brigadeName = row["НазваниеБригады"] == DBNull.Value ? " " : row["НазваниеБригады"].ToString();
                DataGridViewPeople.Rows.Add(
                    row["КодСотрудника"],
                    row["Логин"],
                    row["Фамилия"],
                    row["Имя"],
                    row["ЭлектроннаяПочта"],
                    ((DateTime)row["ДатаПриема"]).ToShortDateString(),
                    row["Зарплата"],
                    row["Должность"],
                    brigadeName,
                    Properties.Resources.edit,
                    Properties.Resources.delete
                );
            }
        }
        private void comboBoxPostSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            display_DGW();
        }
    }
}
