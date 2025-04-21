using app.Classes;
using app.UserControlsOperator;
using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
namespace app.ModalWindows
{
    public partial class ДобавлениеБригады : Form
    {
        private DB DB;
        private UC_Бригады ucБригады;
        public ДобавлениеБригады(UC_Бригады ucБригады)
        {
            InitializeComponent();
            this.ucБригады = ucБригады;
            DB = new DB();
        }
        private bool ValidateBrigadeName(string name)
        {
            return Regex.IsMatch(name, @"^[a-zA-Zа-яА-ЯёЁ0-9\s-]+$");
        }
        private bool ValidateInput()
        {
            string brigadeName = textBoxBrigadeName.Text.Trim();

            if (string.IsNullOrWhiteSpace(brigadeName))
            {
                MyCustomMessageBox.ShowMessage("Название бригады не может быть пустым.",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (brigadeName.Length > 100)
            {
                MyCustomMessageBox.ShowMessage("Название бригады слишком длинное (максимум 100 символов).",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!ValidateBrigadeName(brigadeName))
            {
                MyCustomMessageBox.ShowMessage("Название бригады содержит недопустимые символы.\n" +
                    "Допустимы: буквы, цифры, пробелы и дефисы.",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            string checkQuery = "SELECT COUNT(*) FROM Бригады WHERE НазваниеБригады = @НазваниеБригады";
            using (SqlConnection connection = new SqlConnection(DB.StringConnectionDB))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(checkQuery, connection))
                {
                    command.Parameters.AddWithValue("@НазваниеБригады", brigadeName);
                    int count = (int)command.ExecuteScalar();
                    if (count > 0)
                    {
                        MyCustomMessageBox.ShowMessage("Бригада с таким названием уже существует.",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
            }
            return true;
        }
        private void SaveBrigade()
        {
            string insertQuery = "INSERT INTO Бригады (НазваниеБригады) VALUES (@НазваниеБригады)";
            using (SqlConnection connection = new SqlConnection(DB.StringConnectionDB))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@НазваниеБригады", textBoxBrigadeName.Text);
                    command.ExecuteNonQuery();
                }
            }
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                SaveBrigade();
                MyCustomMessageBox.ShowMessage("Бригада успешно добавлена!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ucБригады.RefreshDataGridView();
                this.Close();
            }
        }
        private void IconClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void textBoxBrigadeName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonSave.PerformClick();
                e.Handled = true;
            }
        }
    }
}
