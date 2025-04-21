using app.Classes;
using app.UserControls;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;
namespace app.Forms
{
    public partial class УдалениеПерсонал : Form
    {
        private int employeeId;
        private string firstName;
        private string lastName;
        private string email;
        private DB DB;
        private UC_Персонал ucПерсонал;
        public УдалениеПерсонал(int employeeId, string firstName, string lastName, string email, UC_Персонал ucПерсонал)
        {
            InitializeComponent();
            this.employeeId = employeeId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.ucПерсонал = ucПерсонал;
            DB = new DB();
            labelEmployeeInfo.Text = $"{lastName} {firstName}";
            labelEmployeeInfo.TextAlignment = ContentAlignment.MiddleCenter;
            labelEmployeeInfo.Location = new Point(
                (this.ClientSize.Width - labelEmployeeInfo.Width) / 2,
                (this.ClientSize.Height - labelEmployeeInfo.Height) / 2);
        }
        private void IconClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void buttonFire_Click(object sender, EventArgs e)
        {
            DialogResult result = MyCustomMessageBox.ShowMessage(
        "Вы уверены, что хотите уволить сотрудника?",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(DB.StringConnectionDB))
                    {
                        connection.Open();
                        string queryUpdateStatus = @"UPDATE Сотрудники SET Статус = 'Уволен', КодБригады = NULL WHERE КодСотрудника = @КодСотрудника";
                        using (SqlCommand command = new SqlCommand(queryUpdateStatus, connection))
                        {
                            command.Parameters.AddWithValue("@КодСотрудника", employeeId);
                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                SendMessage(email);
                                MyCustomMessageBox.ShowMessage(
                                    "Сотрудник успешно уволен!",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                                ucПерсонал.RefreshDataGridView();
                                Close();
                            }
                            else
                            {
                                MyCustomMessageBox.ShowMessage(
                                    "Не удалось найти сотрудника для увольнения.",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MyCustomMessageBox.ShowMessage(
                        $"Ошибка при увольнении сотрудника: {ex.Message}",
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
        private void SendMessage(string email)
        {
            string smtpServer = "smtp.mail.ru";
            int smtpPort = 587;
            string smtpUsername = "noreplymorion@mail.ru";
            string smtpPassword = "m1wkssLZ6rkq5waDKdLh";
            using (SmtpClient smtpClient = new SmtpClient(smtpServer, smtpPort))
            {
                smtpClient.Credentials = new NetworkCredential(smtpUsername, smtpPassword);
                smtpClient.EnableSsl = true;

                using (MailMessage mailMessage = new MailMessage())
                {
                    mailMessage.From = new MailAddress(smtpUsername);
                    mailMessage.To.Add(email);
                    mailMessage.Subject = "Вы уволены из компании 'Морион'!";
                    mailMessage.Body = $"Уважаемый {firstName} {lastName},\r\n" +
                                     "Уведомляем Вас о прекращении сотрудничества с компанией 'Морион'.\r\n" +
                                     "С уважением, Команда 'Морион'";
                    try
                    {
                        smtpClient.Send(mailMessage);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Ошибка отправки сообщения: {ex.Message}");
                    }
                }
            }
        }
    }
}