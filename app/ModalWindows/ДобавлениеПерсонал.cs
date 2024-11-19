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
        private string GeneratePassword()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()_+=[{]};:<>|./?";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, 12)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        private string GenerateLogin(string password)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()_+=[{]};:<>|./?";
            var random = new Random();
            string login;
            do
            {
                login = new string(Enumerable.Repeat(chars, 12)
                    .Select(s => s[random.Next(s.Length)]).ToArray());
            } while (login == password);
            return login;
        }


        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == string.Empty || textBoxSurname.Text == string.Empty || textBoxEmail.Text == string.Empty || comboBoxPost.Text == string.Empty)
            {
                MyCustomMessageBox.ShowMessage("Заполните все поля", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (textBoxName.Text == string.Empty)
            {
                MyCustomMessageBox.ShowMessage("Заполните поле Имя", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (textBoxSurname.Text == string.Empty)
            {
                MyCustomMessageBox.ShowMessage("Заполните поле Фамилия", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (textBoxEmail.Text == string.Empty)
            {
                MyCustomMessageBox.ShowMessage("Заполните поле электронная почта", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (comboBoxPost.Text == string.Empty)
            {
                MyCustomMessageBox.ShowMessage("Выберите Должность", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Validation validator = new Validation();
            string firstName = textBoxName.Text;
            string lastName = textBoxSurname.Text;
            string email = textBoxEmail.Text;
            string post = comboBoxPost.Text;

            if (!validator.ValidateLastName(lastName))
            {
                MyCustomMessageBox.ShowMessage("Некорректная фамилия", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!validator.ValidateFirstName(firstName))
            {
                MyCustomMessageBox.ShowMessage("Некорректное имя", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!validator.ValidateEmail(email))
            {
                MyCustomMessageBox.ShowMessage("Некорректный email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string password = GeneratePassword();
            string login = GenerateLogin(password);

            ValidationLogin LV = new ValidationLogin();
            if (!LV.CheckLoginUniqueness(login))
            {
                MyCustomMessageBox.ShowMessage("Логин уже существует. Попробуйте снова.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password == login)
            {
                MyCustomMessageBox.ShowMessage("Пароль и логин не должны совпадать.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int userId = RegisterUser(login, password, comboBoxPost.Text);
            if (userId > 0)
            {
                int employeeId = RegisterEmployee(textBoxName.Text, textBoxSurname.Text, textBoxEmail.Text, userId);
                if (employeeId > 0)
                {
                    var uploader = new ImageUploader(con);
                    uploader.Upload(employeeId, pictureSet);
                    SendMessage(login, password, textBoxEmail.Text);
                    ucПерсонал.RefreshDataGridView();
                    MyCustomMessageBox.ShowMessage("Сотрудник упешно зарегистрирован!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MyCustomMessageBox.ShowMessage("Ошибка при регистрации сотрудника.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MyCustomMessageBox.ShowMessage("Ошибка при регистрации пользователя.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void IconClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBoxSurname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                textBoxName.Focus();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                buttonSave.PerformClick();
                e.Handled = true;
            }
        }

        private void textBoxName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                textBoxEmail.Focus();
                e.Handled = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                textBoxSurname.Focus();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                buttonSave.PerformClick();
                e.Handled = true;
            }
        }

        private void textBoxEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                textBoxName.Focus();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                buttonSave.PerformClick();
                e.Handled = true;
            }
        }

        private void buttonSave_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonSave.PerformClick();
                e.Handled = true;
            }
        }
    }
}
