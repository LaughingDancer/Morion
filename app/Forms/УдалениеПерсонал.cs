using app.Classes;
using app.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Web.UI.WebControls;

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
            DialogResult result = MyCustomMessageBox.ShowMessage("Вы уверены, что хотите уволить сотрудника?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string queryDeleteEmployee = "DELETE FROM Сотрудники WHERE КодСотрудника = @КодСотрудника";
                using (SqlConnection connection = new SqlConnection(DB.StringConnection()))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(queryDeleteEmployee, connection))
                    {
                        command.Parameters.AddWithValue("@КодСотрудника", employeeId);
                        command.ExecuteNonQuery();
                    }
                }
                SendMessage(email);
                ucПерсонал.RefreshDataGridView();
                Close();
            }
            else
            {
                MyCustomMessageBox.ShowMessage("Действие отменено.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }
        private void SendMessage(string email)
        {
            string smtpServer = "smtp.mail.ru";
            int smtpPort = 587;
            string smtpUsername = "noreplymorion@mail.ru";
            string smtpPassword = "TeB6bnQkvFsBR1evpPw9";

            using (SmtpClient smtpClient = new SmtpClient(smtpServer, smtpPort))
            {
                smtpClient.Credentials = new NetworkCredential(smtpUsername, smtpPassword);
                smtpClient.EnableSsl = true;

                using (MailMessage mailMessage = new MailMessage())
                {
                    mailMessage.From = new MailAddress(smtpUsername);
                    mailMessage.To.Add(email);
                    mailMessage.Subject = "Вы уволины из компании 'Морион'!";
                    mailMessage.Body = $"Уважаемый {firstName} {lastName},\r\nУведомляем Вас о прекращении сотрудничества с компанией 'Морион'.\r\nС уважением, Команда 'Морион'";
                    try
                    {
                        smtpClient.Send(mailMessage);
                        Console.WriteLine("Сообщение успешно отправлено.");
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
