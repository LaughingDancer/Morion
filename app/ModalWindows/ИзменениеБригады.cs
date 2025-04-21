using app.Classes;
using app.UserControlsOperator;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace app.ModalWindows
{
    public partial class ИзменениеБригады : Form
    {
        private int brigadeId;
        private string brigadeName;
        private DB DB;
        private UC_Бригады ucБригады;
        public ИзменениеБригады(int brigadeId, string brigadeName, UC_Бригады ucБригады)
        {
            InitializeComponent();
            this.brigadeId = brigadeId;
            this.brigadeName = brigadeName;
            this.ucБригады = ucБригады;
            DB = new DB();
            textBoxBrigadeName.Text = brigadeName;
        }
        private bool ValidateInput()
        {
            string newBrigadeName = textBoxBrigadeName.Text.Trim();
            if (string.IsNullOrWhiteSpace(newBrigadeName))
            {
                MyCustomMessageBox.ShowMessage("Название бригады не может быть пустым.",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (newBrigadeName.Length > 100)
            {
                MyCustomMessageBox.ShowMessage("Название бригады слишком длинное (максимум 100 символов).",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (newBrigadeName == brigadeName)
            {
                MyCustomMessageBox.ShowMessage("Название бригады не было изменено.",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            string checkQuery = "SELECT COUNT(*) FROM Бригады WHERE НазваниеБригады = @НазваниеБригады AND КодБригады != @КодБригады";
            using (SqlConnection connection = new SqlConnection(DB.StringConnectionDB))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(checkQuery, connection))
                {
                    command.Parameters.AddWithValue("@НазваниеБригады", newBrigadeName);
                    command.Parameters.AddWithValue("@КодБригады", brigadeId);
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
        private void UpdateBrigade()
        {
            string newBrigadeName = textBoxBrigadeName.Text.Trim();
            string updateQuery = "UPDATE Бригады SET НазваниеБригады = @НазваниеБригады WHERE КодБригады = @КодБригады";
            using (SqlConnection connection = new SqlConnection(DB.StringConnectionDB))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@НазваниеБригады", newBrigadeName);
                    command.Parameters.AddWithValue("@КодБригады", brigadeId);
                    command.ExecuteNonQuery();
                }
            }
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                try
                {
                    UpdateBrigade();
                    MyCustomMessageBox.ShowMessage("Название бригады успешно изменено!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ucБригады.RefreshDataGridView();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MyCustomMessageBox.ShowMessage("Ошибка при изменении бригады: " + ex.Message,
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void textBoxBrigadeName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonSave.PerformClick();
                e.Handled = true;
            }
        }
        private void IconClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
