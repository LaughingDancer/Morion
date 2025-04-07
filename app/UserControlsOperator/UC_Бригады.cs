using app.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using app.ModalWindows;
using app.Forms;

namespace app.UserControlsOperator
{
    public partial class UC_Бригады : UserControl
    {
        private DB DB;
        private ExcelExporter excelExporter;
        public void RefreshDataGridView()
        {
            RefreshDataGrid(DataGridViewBrigade);
        }
        public UC_Бригады()
        {
            InitializeComponent();
            DB = new DB();
            excelExporter = new ExcelExporter();
        }
        private void CreateColumns()
        {
            DataGridViewBrigade.Columns.Add("КодБригады", "КодБригады");
            DataGridViewBrigade.Columns["КодБригады"].Visible = false;
            DataGridViewBrigade.Columns.Add("НазваниеБригады", "Название бригады");

            DataGridViewImageColumn newEditColumn = new DataGridViewImageColumn();
            newEditColumn.Name = "EditColumn";
            newEditColumn.HeaderText = "Изменить";
            newEditColumn.Image = Properties.Resources.edit;
            newEditColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            DataGridViewBrigade.Columns.Add(newEditColumn);
            DataGridViewBrigade.Columns["EditColumn"].DisplayIndex = DataGridViewBrigade.Columns.Count - 1;
            DataGridViewBrigade.Columns["EditColumn"].Width = 80;
            DataGridViewBrigade.Columns["EditColumn"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewImageColumn newDeleteColumn = new DataGridViewImageColumn();
            newDeleteColumn.Name = "DeleteColumn";
            newDeleteColumn.HeaderText = "Удалить";
            newDeleteColumn.Image = Properties.Resources.delete;
            newDeleteColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            DataGridViewBrigade.Columns.Add(newDeleteColumn);
            DataGridViewBrigade.Columns["DeleteColumn"].DisplayIndex = DataGridViewBrigade.Columns.Count - 1;
            DataGridViewBrigade.Columns["DeleteColumn"].Width = 80;
            DataGridViewBrigade.Columns["DeleteColumn"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void ReadSingleRow(DataGridView DGW, IDataRecord record)
        {
            DGW.Rows.Add(
                record.GetInt32(0),
                record.GetString(1),
                Properties.Resources.edit,
                Properties.Resources.delete
            );
        }

        private void RefreshDataGrid(DataGridView DGW)
        {
            DGW.Rows.Clear();
            string queryString = @"SELECT КодБригады, НазваниеБригады FROM Бригады";

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

        private void UC_Бригады_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(DataGridViewBrigade);
            comboSearch();
            display_DGW();
        }

        private void DataGridViewBrigade_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.ColumnIndex == DataGridViewBrigade.Columns["EditColumn"].Index ||
                 e.ColumnIndex == DataGridViewBrigade.Columns["DeleteColumn"].Index) && e.RowIndex >= 0)
            {
                DataGridViewBrigade.Cursor = Cursors.Hand;
            }
        }

        private void DataGridViewBrigade_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewBrigade.Cursor = Cursors.Default;
        }
        private void Search(DataGridView DGW)
        {
            DGW.Rows.Clear();
            string querySearch = $"SELECT КодБригады, НазваниеБригады FROM Бригады WHERE НазваниеБригады LIKE '%{searchTextBox.Text}%'";

            SqlCommand sqlCommand = new SqlCommand(querySearch, DB.GetConnection());
            DB.OpenConnection();
            SqlDataReader reader = sqlCommand.ExecuteReader();

            while (reader.Read())
            {
                DGW.Rows.Add(
                    reader.GetInt32(0),
                    reader.GetString(1),
                    Properties.Resources.edit,
                    Properties.Resources.delete
                );
            }
            reader.Close();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            Search(DataGridViewBrigade);
        }
        private void comboSearch()
        {
            string querySearch = $"SELECT DISTINCT НазваниеБригады FROM Бригады";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(querySearch, DB.GetConnection());
            DB.OpenConnection();
            DataSet DS = new DataSet();
            sqlDataAdapter.Fill(DS, "НазваниеБригады");

            DataRow allRow = DS.Tables["НазваниеБригады"].NewRow();
            allRow["НазваниеБригады"] = "Все бригады";
            DS.Tables["НазваниеБригады"].Rows.InsertAt(allRow, 0);

            comboBoxBrigadeSearch.DisplayMember = "НазваниеБригады";
            comboBoxBrigadeSearch.ValueMember = "НазваниеБригады";
            comboBoxBrigadeSearch.DataSource = DS.Tables["НазваниеБригады"];

            DB.CloseConnection();
            comboBoxBrigadeSearch.SelectedIndex = 0;
        }

        private void display_DGW()
        {
            string querySearch;

            if (comboBoxBrigadeSearch.Text == "Все бригады")
            {
                querySearch = "SELECT КодБригады, НазваниеБригады FROM Бригады";
            }
            else
            {
                querySearch = "SELECT КодБригады, НазваниеБригады FROM Бригады WHERE НазваниеБригады = @НазваниеБригады";
            }

            SqlCommand sqlCommand = new SqlCommand(querySearch, DB.GetConnection());

            if (comboBoxBrigadeSearch.Text != "Все бригады")
            {
                sqlCommand.Parameters.AddWithValue("@НазваниеБригады", comboBoxBrigadeSearch.Text);
            }

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable DT = new DataTable();
            DataGridViewBrigade.Rows.Clear();
            sqlDataAdapter.Fill(DT);

            foreach (DataRow row in DT.Rows)
            {
                DataGridViewBrigade.Rows.Add(
                    row["КодБригады"],
                    row["НазваниеБригады"],
                    Properties.Resources.edit,
                    Properties.Resources.delete
                );
            }
        }

        private void comboBoxBridageSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            display_DGW();
        }

        private void DataGridViewBrigade_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == DataGridViewBrigade.Columns["EditColumn"].Index)
                {
                    int brigadeId = Convert.ToInt32(DataGridViewBrigade.Rows[e.RowIndex].Cells["КодБригады"].Value);
                    string brigadeName = DataGridViewBrigade.Rows[e.RowIndex].Cells["НазваниеБригады"].Value.ToString();

                    // Здесь нужно создать форму для редактирования бригады
                    ИзменениеБригады editForm = new ИзменениеБригады(brigadeId, brigadeName, this);
                    editForm.FormClosed += (s, args) => RefreshDataGridView();
                    editForm.Show();
                }
                else if (e.ColumnIndex == DataGridViewBrigade.Columns["DeleteColumn"].Index)
                {
                    int brigadeId = Convert.ToInt32(DataGridViewBrigade.Rows[e.RowIndex].Cells["КодБригады"].Value);
                    string brigadeName = DataGridViewBrigade.Rows[e.RowIndex].Cells["НазваниеБригады"].Value.ToString();

                    // Здесь нужно создать форму для удаления бригады
                    УдалениеБригады deleteForm = new УдалениеБригады(brigadeId, brigadeName, this);
                    deleteForm.FormClosed += (s, args) => RefreshDataGridView();
                    deleteForm.Show();
                }
            }
        }

        private void ButtonSaveOrder_Click(object sender, EventArgs e)
        {
            ДобавлениеБригады toForm = new ДобавлениеБригады(this);
            toForm.Show();
        }

        private void ButtonExcel_Click(object sender, EventArgs e)
        {
            excelExporter.ExportExcel(DataGridViewBrigade);
        }
    }
}
