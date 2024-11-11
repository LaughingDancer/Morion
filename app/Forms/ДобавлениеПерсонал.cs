using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using app.Classes;
using Guna.UI2.WinForms;
using static app.Classes.ValidationData;
using System.Data.SqlClient;
using System.Drawing.Imaging;
using System.Net.Mail;
using System.Net;
using app.UserControls;

namespace app.Forms
{
    public partial class ДобавлениеПерсонал : Form
    {
        private byte[] selectedPhotoBytes;
        private DB DB;
        private string con = @"Data Source=MAKSIMN;Initial Catalog=Морион;Integrated Security=True";
        private UC_Персонал ucПерсонал;
        public ДобавлениеПерсонал(UC_Персонал ucПерсонал)
        {
            this.ucПерсонал = ucПерсонал;
            DB = new DB();
            InitializeComponent();
        }

        private void pictureSet_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFile = openFileDialog.FileName;
                pictureSet.Image = Image.FromFile(selectedFile);
                selectedPhotoBytes = File.ReadAllBytes(selectedFile);
            }
        }


        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == string.Empty || textBoxSurname.Text == string.Empty || textBoxEmail.Text == string.Empty || textBoxLogin.Text == string.Empty || textBoxPassword.Text == string.Empty || comboBoxPost.Text == string.Empty)
            {
                MessageBox.Show("Заполните все поля", "Ошибка");
                return;
            }
            Validation validator = new Validation();
            string firstName = textBoxName.Text;
            string lastName = textBoxSurname.Text;
            string email = textBoxEmail.Text;
            string post = comboBoxPost.Text;
            if (!validator.ValidateLastName(lastName))
            {
                MessageBox.Show("Некорректная фамилия", "Ошибка");
                return;
            }
            if (!validator.ValidateFirstName(firstName))
            {
                MessageBox.Show("Некорректное имя", "Ошибка");
                return;
            }
            if (!validator.ValidateEmail(email))
            {
                MessageBox.Show("Некорректный email", "Ошибка");
                return;
            }
            ValidationPassword PassV = new ValidationPassword();
            if (PassV.Validation(textBoxPassword.Text) == false)
            {
                return;
            }
            if (textBoxPassword.Text == textBoxLogin.Text)
            {
                MessageBox.Show("Пароль и логин не должны совпадать.", "Ошибка");
                return;
            }
            ValidationLogin LV = new ValidationLogin();
            if (LV.Validation(textBoxLogin.Text) == false)
            {
                return;
            }
            if (!LV.CheckLoginUniqueness(textBoxLogin.Text))
            {
                MessageBox.Show("Логин уже существует. Выберите другой логин.", "Ошибка");
                return;
            }
            else
            {
                int userId = RegisterUser(textBoxLogin.Text, textBoxPassword.Text, comboBoxPost.Text);
                if (userId > 0)
                {
                    int employeeId = RegisterEmployee(textBoxName.Text, textBoxSurname.Text, textBoxEmail.Text, userId);
                    if (employeeId > 0)
                    {
                        var uploader = new ImageUploader(con);
                        uploader.Upload(employeeId, pictureSet);
                        SendMessage(textBoxLogin.Text, textBoxPassword.Text, textBoxEmail.Text);
                        ucПерсонал.RefreshDataGridView();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Ошибка при регистрации сотрудника.", "Ошибка");
                    }
                }
                else
                {
                    MessageBox.Show("Ошибка при регистрации пользователя.", "Ошибка");
                }
            }
        }

        private int RegisterUser(string login, string password, string post)
        {
            Hashing GH = new Hashing();
            string queryadd = $"INSERT INTO Пользователи (Логин, Пароль, Должность) VALUES ('{login}', '{GH.Hash(password)}', '{post}'); SELECT SCOPE_IDENTITY();";
            var DB = new DB();
            return DB.QueryExecuteScalar(queryadd);
        }

        private int RegisterEmployee(string firstName, string lastName, string email, int userId)
        {
            var queryAdd = $"INSERT INTO Сотрудники (Имя, Фамилия, ЭлектроннаяПочта, КодПользователя) VALUES ('{firstName}', '{lastName}', '{email}', {userId}); SELECT SCOPE_IDENTITY();";
            var DB = new DB();
            return DB.QueryExecuteScalar(queryAdd);
        }
        class ImageUploader
        {
            private readonly string _connectionString;

            public ImageUploader(string connectionString)
            {
                _connectionString = connectionString;
            }

            public void Upload(int employeeId, PictureBox pictureBox)
            {
                using (var connection = new SqlConnection(_connectionString))
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "UPDATE Сотрудники SET Фото = @Фото WHERE КодСотрудника = @EmployeeId";

                    var image = new Bitmap(pictureBox.Image);
                    using (var memoryStream = new MemoryStream())
                    {
                        image.Save(memoryStream, ImageFormat.Jpeg);
                        memoryStream.Position = 0;

                        var sqlParameterPhoto = new SqlParameter("@Фото", SqlDbType.VarBinary, (int)memoryStream.Length)
                        {
                            Value = memoryStream.ToArray()
                        };
                        command.Parameters.Add(sqlParameterPhoto);

                        var sqlParameterEmployeeId = new SqlParameter("@EmployeeId", SqlDbType.Int)
                        {
                            Value = employeeId
                        };
                        command.Parameters.Add(sqlParameterEmployeeId);
                    }
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        private void SendMessage(string login, string password, string email)
        {
            // Настройки SMTP-сервера Mail.ru
            string smtpServer = "smtp.mail.ru"; //smpt сервер(зависит от почты отправителя)
            int smtpPort = 587; // Обычно используется порт 587 для TLS
            string smtpUsername = "noreplymorion@mail.ru"; //твоя почта, с которой отправляется сообщение
            string smtpPassword = "TeB6bnQkvFsBR1evpPw9";//пароль приложения (от почты)

            // Создаем объект клиента SMTP
            using (SmtpClient smtpClient = new SmtpClient(smtpServer, smtpPort))
            {
                // Настройки аутентификации
                smtpClient.Credentials = new NetworkCredential(smtpUsername, smtpPassword);
                smtpClient.EnableSsl = true;

                using (MailMessage mailMessage = new MailMessage())
                {
                    mailMessage.From = new MailAddress(smtpUsername);
                    mailMessage.To.Add(email); // Укажите адрес получателя
                    mailMessage.Subject = "Добро пожаловать в компанию 'Морион'!";
                    mailMessage.Body = $"Логин: {login} \r\nПароль: {password} \r\nНикому не сообщайте эти данные";

                    try
                    {
                        // Отправляем сообщение
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

        private void IconClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
