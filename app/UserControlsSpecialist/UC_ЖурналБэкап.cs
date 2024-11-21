using app.Classes;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace app.UserControlsSpecialist
{
    public partial class UC_ЖурналБэкап : UserControl
    {
        private DB DB;
        private ExcelExporter excelExporter;
        public UC_ЖурналБэкап()
        {
            InitializeComponent();
            DB = new DB();
            excelExporter = new ExcelExporter();
        }
        private void CreateColumns()
        {
            DataGridViewChangeLog.Columns.Add("Код", "Код");
            DataGridViewChangeLog.Columns["Код"].Visible = false;
            DataGridViewChangeLog.Columns.Add("Таблица", "Таблица");
            DataGridViewChangeLog.Columns.Add("Действие", "Действие");
            DataGridViewChangeLog.Columns.Add("СтароеЗначение", "Старое Значение");
            DataGridViewChangeLog.Columns.Add("НовоеЗначение", "Новое Значение");
            DataGridViewChangeLog.Columns.Add("ДатаИзменения", "Дата Изменения");
        }
        private void RefreshDataGrid(DataGridView DGW)
        {
            DGW.Rows.Clear();
            string queryString = @"
        SELECT 
            Код, 
            Таблица, 
            Действие, 
            СтароеЗначение, 
            НовоеЗначение, 
            ДатаИзменения 
        FROM 
            ЖурналИзменений";

            SqlCommand command = new SqlCommand(queryString, DB.GetConnection());
            DB.OpenConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRowChangeLog(DGW, reader);
            }
            reader.Close();
            DB.CloseConnection();
        }
        private void ReadSingleRowChangeLog(DataGridView DGW, IDataRecord Record)
        {
            DGW.Rows.Add(
                Record["Код"],
                Record["Таблица"],
                Record["Действие"],
                Record["СтароеЗначение"],
                Record["НовоеЗначение"],
                Record["ДатаИзменения"]
            );
        }
        private void comboSearchTable()
        {
            string quarrySearchTable = "SELECT DISTINCT Таблица FROM ЖурналИзменений";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(quarrySearchTable, DB.GetConnection());
            DB.OpenConnection();
            DataSet DS = new DataSet();
            sqlDataAdapter.Fill(DS, "Таблица");
            DataRow allRow = DS.Tables["Таблица"].NewRow();
            allRow["Таблица"] = "Все Таблицы";
            DS.Tables["Таблица"].Rows.InsertAt(allRow, 0);
            comboBoxTable.DisplayMember = "Таблица";
            comboBoxTable.ValueMember = "Таблица";
            comboBoxTable.DataSource = DS.Tables["Таблица"];
            DB.CloseConnection();
            comboBoxTable.SelectedIndex = 0;
        }
        private void SearchChangeLog(DataGridView DGW)
        {
            string querrySearch = $@"
        SELECT 
            Код, 
            Таблица, 
            Действие, 
            СтароеЗначение, 
            НовоеЗначение, 
            ДатаИзменения 
        FROM 
            ЖурналИзменений 
        WHERE 
            CONCAT(Таблица, Действие, СтароеЗначение, НовоеЗначение, ДатаИзменения) LIKE '%{searchTextBox.Text}%'";
            SqlCommand sqlCommand = new SqlCommand(querrySearch, DB.GetConnection());
            DB.OpenConnection();
            SqlDataReader reader = sqlCommand.ExecuteReader();
            DataGridViewChangeLog.Rows.Clear();
            while (reader.Read())
            {
                ReadSingleRowChangeLog(DataGridViewChangeLog, reader);
            }
            reader.Close();
            DB.CloseConnection();
        }
        private void display_DGW()
        {
            string querrySearch;
            if (comboBoxTable.Text == "Все Таблицы")
            {
                querrySearch = @"
            SELECT 
                Код, 
                Таблица, 
                Действие, 
                СтароеЗначение, 
                НовоеЗначение, 
                ДатаИзменения 
            FROM 
                ЖурналИзменений";
            }
            else
            {
                querrySearch = $@"
            SELECT 
                Код, 
                Таблица, 
                Действие, 
                СтароеЗначение, 
                НовоеЗначение, 
                ДатаИзменения 
            FROM 
                ЖурналИзменений 
            WHERE 
                Таблица = @Таблица";
            }
            SqlCommand sqlCommand = new SqlCommand(querrySearch, DB.GetConnection());
            if (comboBoxTable.Text != "Все Таблицы")
            {
                sqlCommand.Parameters.AddWithValue("@Таблица", comboBoxTable.Text);
            }
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable DT = new DataTable();
            DataGridViewChangeLog.Rows.Clear();
            sqlDataAdapter.Fill(DT);
            foreach (DataRow row in DT.Rows)
            {
                DataGridViewChangeLog.Rows.Add(
                    row["Код"],
                    row["Таблица"],
                    row["Действие"],
                    row["СтароеЗначение"],
                    row["НовоеЗначение"],
                    row["ДатаИзменения"]
                );
            }
        }
        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            SearchChangeLog(DataGridViewChangeLog);
        }
        private void UC_ЖурналБэкап_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(DataGridViewChangeLog);
            display_DGW();
            comboSearchTable();
        }
        private void comboBoxTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            display_DGW();
        }
        private void ButtonExcel_Click(object sender, EventArgs e)
        {
            excelExporter.ExportExcel(DataGridViewChangeLog);
        }
        public void BackupDatabase(string databaseName)
        {
            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Title = "Выберите место для сохранения резервной копии";
                    saveFileDialog.Filter = "SQL Backup Files (*.bak)|*.bak";
                    string defaultPath = @"C:\BackupDB";
                    saveFileDialog.InitialDirectory = Directory.Exists(defaultPath) ? defaultPath : Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    saveFileDialog.FileName = $"{databaseName}_Backup_{DateTime.Now:yyyyMMdd_HHmmss}.bak";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string backupPath = saveFileDialog.FileName;
                        if (!Directory.Exists(Path.GetDirectoryName(backupPath)))
                        {
                            Directory.CreateDirectory(Path.GetDirectoryName(backupPath));
                        }
                        ServerConnection serverConnection = new ServerConnection
                        {
                            ServerInstance = "MAKSIMN",
                            LoginSecure = true
                        };
                        Server server = new Server(serverConnection);
                        if (!server.Databases.Contains(databaseName))
                        {
                            throw new Exception($"База данных '{databaseName}' не найдена на сервере '{serverConnection.ServerInstance}'.");
                        }
                        Backup backup = new Backup
                        {
                            Action = BackupActionType.Database,
                            Database = databaseName 
                        };
                        backup.Devices.AddDevice(backupPath, DeviceType.File);
                        backup.SqlBackup(server);
                        MyCustomMessageBox.ShowMessage($"Резервное копирование успешно завершено. Файл сохранен по пути:\n{backupPath}", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MyCustomMessageBox.ShowMessage($"Ошибка при резервном копировании:\n{ex.Message}\n{ex.InnerException?.Message}",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ButtonChartHorizontalBar_Click(object sender, EventArgs e)
        {
            string databaseName = "Морион";
            BackupDatabase(databaseName);
        }
    }
}
