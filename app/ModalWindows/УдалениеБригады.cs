using app.Classes;
using app.UserControlsOperator;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
namespace app.ModalWindows
{
    public partial class УдалениеБригады : Form
    {
        private DB DB;
        private UC_Бригады ucБригады;
        private int brigadeId;
        private string brigadeName;
        public УдалениеБригады(int brigadeId, string brigadeName, UC_Бригады ucБригады)
        {
            InitializeComponent();
            this.ucБригады = ucБригады;
            this.brigadeId = brigadeId;
            this.brigadeName = brigadeName;
            DB = new DB();
            labelBrigadeInfo.Text = $"{brigadeName}";
            labelBrigadeInfo.TextAlignment = ContentAlignment.MiddleCenter;
            labelBrigadeInfo.Location = new Point(
                (this.ClientSize.Width - labelBrigadeInfo.Width) / 2,
                (this.ClientSize.Height - labelBrigadeInfo.Height) / 2);
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MyCustomMessageBox.ShowMessage(
                "Вы уверены, что хотите удалить бригаду?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    DeleteBrigade(brigadeId);
                    MyCustomMessageBox.ShowMessage(
                        "Бригада успешно удалена!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    ucБригады.RefreshDataGridView();
                    this.Close();
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 547)
                    {
                        MyCustomMessageBox.ShowMessage(
                            "Невозможно удалить бригаду, так как она привязана к сотрудникам.\n" +
                            "Сначала измените бригаду у сотрудников или удалите их.",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    else
                    {
                        MyCustomMessageBox.ShowMessage(
                            "Ошибка при удалении бригады: " + ex.Message,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MyCustomMessageBox.ShowMessage(
                        "Ошибка при удалении бригады: " + ex.Message,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                MyCustomMessageBox.ShowMessage(
                    "Действие отменено.",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                Close();
            }
        }
        private static void DeleteBrigade(int brigadeId)
        {
            using (SqlConnection connection = new SqlConnection(DB.StringConnectionDB))
            {
                connection.Open();
                string updateEmployeesQuery = @"UPDATE Сотрудники SET КодБригады = NULL WHERE КодБригады = @КодБригады";

                using (SqlCommand updateCommand = new SqlCommand(updateEmployeesQuery, connection))
                {
                    updateCommand.Parameters.AddWithValue("@КодБригады", brigadeId);
                    updateCommand.ExecuteNonQuery();
                }
                string deleteBrigadeQuery = @"DELETE FROM Бригады WHERE КодБригады = @КодБригады";
                using (SqlCommand deleteCommand = new SqlCommand(deleteBrigadeQuery, connection))
                {
                    deleteCommand.Parameters.AddWithValue("@КодБригады", brigadeId);
                    deleteCommand.ExecuteNonQuery();
                }
            }
        }
        private void IconClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
