using app.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app.UserControls
{
    public partial class UC_Главная : UserControl
    {
        private DB DB;
        public UC_Главная()
        {
            InitializeComponent();
            DB = new DB();
            TextBoxLogin.IconRight = Properties.Resources.visionHide;
            TextBoxLogin.UseSystemPasswordChar = true;
        }
        public void LoadEmployeeData(Dictionary<string, string> employeeData, byte[] photoBytes)
        {
            // Пример отображения данных о сотруднике
            searchTextBox.Text = employeeData["Имя"];
            TextBoxSurname.Text = employeeData["Фамилия"];
            TextBoxEmail.Text = employeeData["ЭлектроннаяПочта"];
            TextBoxDateOfHire.Text = employeeData["ДатаПриема"];
            TextBoxSalary.Text = employeeData["Зарплата"];
            TextBoxPost.Text = employeeData["Должность"];
            TextBoxLogin.Text = employeeData["Логин"];

            // Загрузка фотографии
            if (photoBytes != null)
            {
                using (MemoryStream ms = new MemoryStream(photoBytes))
                {
                    PictureBoxEmployee.Image = Image.FromStream(ms);
                }
            }
            else
            {
                PictureBoxEmployee.Image = Properties.Resources.default_photo;
            }
        }

        private void TextBoxLogin_IconRightClick(object sender, EventArgs e)
        {
            if (TextBoxLogin.UseSystemPasswordChar)
            {
                TextBoxLogin.UseSystemPasswordChar = false;
                TextBoxLogin.IconRight = Properties.Resources.vision;
            }
            else
            {
                TextBoxLogin.UseSystemPasswordChar = true;
                TextBoxLogin.IconRight = Properties.Resources.visionHide;
            }
        }
        private string GeneratePassword()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()_+=[{]};:<>|./?";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, 12)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            DialogResult result = MyCustomMessageBox.ShowMessage("Вы уверены, что хотите изменить пароль?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Генерация нового пароля
                string newPassword = GeneratePassword();

                // Хеширование нового пароля
                Hashing hashing = new Hashing();
                string hashedPassword = hashing.Hash(newPassword);

                // Обновление пароля в базе данных
                string queryUpdatePassword = "UPDATE Пользователи SET Пароль = @Пароль WHERE Логин = @Логин";
                using (SqlConnection connection = new SqlConnection(DB.StringConnection()))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(queryUpdatePassword, connection))
                    {
                        command.Parameters.AddWithValue("@Пароль", hashedPassword);
                        command.Parameters.AddWithValue("@Логин", TextBoxLogin.Text);
                        command.ExecuteNonQuery();
                    }
                }

                // Отправка нового пароля на почту
                SendMessage(TextBoxLogin.Text, newPassword, TextBoxEmail.Text);

                MyCustomMessageBox.ShowMessage("Пароль успешно изменен и отправлен на почту.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MyCustomMessageBox.ShowMessage("Действие отменено.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void SendMessage(string login, string password, string email)
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
                    mailMessage.Subject = "Добро пожаловать в компанию 'Морион'!";
                    mailMessage.Body = $"Логин: {login} \r\nПароль: {password} \r\nНикому не сообщайте эти данные";
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
