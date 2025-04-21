using app.Classes;
using app.UserControls;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;
using static app.Classes.ValidationData;
using System.Data;
namespace app.Forms
{
    public partial class ИзменениеПерсонал : Form
    {
        private string firstName;
        private string lastName;
        private string email;
        private string dateOfHire;
        private string salary;
        private string post;
        private int employeeId;
        private string login;
        private DB DB;
        private byte[] selectedPhotoBytes;
        private UC_Персонал ucПерсонал;
        private string con = @"Data Source=MAKSIMN;Initial Catalog=Морион;Integrated Security=True";
        private bool isShveyaSelected = false;
        public ИзменениеПерсонал(int employeeId, string firstName, string lastName, string email, string dateOfHire, string salary, string post, string login, UC_Персонал ucПерсонал)
        {
            InitializeComponent();
            this.employeeId = employeeId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.dateOfHire = dateOfHire;
            this.salary = salary;
            this.post = post;
            this.login = login;
            DB = new DB();
            this.ucПерсонал = ucПерсонал;
            textBoxName.Text = firstName;
            textBoxSurname.Text = lastName;
            textBoxEmail.Text = email;
            DateTimePickerEmployee.Text = dateOfHire;
            textBoxSalary.Text = salary;
            comboBoxPost.Text = post;
            LoadEmployeePhoto();
            CheckPostAndSetBrigadeState(post);
            LoadBrigadesAndCurrentBrigade();
            selectedPhotoBytes = DB.GetEmployeePhoto(employeeId);
        }
        private void LoadEmployeePhoto()
        {
            byte[] photoBytes = DB.GetEmployeePhoto(employeeId);
            if (photoBytes != null)
            {
                using (MemoryStream ms = new MemoryStream(photoBytes))
                {
                    pictureSet.Image = Image.FromStream(ms);
                }
            }
            else
            {
                pictureSet.Image = Properties.Resources.default_photo;
            }
        }
        private void LoadBrigadesAndCurrentBrigade()
        {
            try
            {
                if (isShveyaSelected)
                {
                    string query = @"SELECT b.КодБригады, b.НазваниеБригады, CASE WHEN s.КодБригады = b.КодБригады THEN 1 ELSE 0 END AS IsCurrent FROM Бригады b LEFT JOIN Сотрудники s ON s.КодСотрудника = @КодСотрудника ORDER BY IsCurrent DESC, b.НазваниеБригады";
                    DataTable dt = new DataTable();
                    using (SqlConnection connection = new SqlConnection(DB.StringConnectionDB))
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@КодСотрудника", employeeId);
                        connection.Open();
                        dt.Load(command.ExecuteReader());
                    }
                    comboBoxBrigade.DisplayMember = "НазваниеБригады";
                    comboBoxBrigade.ValueMember = "КодБригады";
                    comboBoxBrigade.DataSource = dt;

                    if (dt.Rows.Count > 0 && dt.Rows[0]["IsCurrent"].ToString() == "1")
                    {
                        comboBoxBrigade.SelectedValue = dt.Rows[0]["КодБригады"];
                    }
                }
                else
                {
                    comboBoxBrigade.DataSource = null;
                    comboBoxBrigade.Items.Clear();
                    comboBoxBrigade.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                MyCustomMessageBox.ShowMessage("Ошибка при загрузке бригад: " + ex.Message,
                                             MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CheckPostAndSetBrigadeState(string post)
        {
            isShveyaSelected = post == "Швея";
            comboBoxBrigade.Enabled = isShveyaSelected;
            if (!isShveyaSelected)
            {
                comboBoxBrigade.DataSource = null;
                comboBoxBrigade.Items.Clear();
                comboBoxBrigade.Text = string.Empty;
            }
        }
        private bool ValidateInput()
        {
            var firstName = textBoxName.Text;
            var lastName = textBoxSurname.Text;
            var email = textBoxEmail.Text;
            var post = comboBoxPost.Text;
            var salary = textBoxSalary.Text;
            if (string.IsNullOrEmpty(firstName) && string.IsNullOrEmpty(lastName) && string.IsNullOrEmpty(email) && string.IsNullOrEmpty(post) && string.IsNullOrEmpty(salary))
            {
                MyCustomMessageBox.ShowMessage("Заполните все поля", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(firstName))
            {
                MyCustomMessageBox.ShowMessage("Заполните поле Имя", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(lastName))
            {
                MyCustomMessageBox.ShowMessage("Заполните поле Фамилия", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(email))
            {
                MyCustomMessageBox.ShowMessage("Заполните поле электронная почта", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(post))
            {
                MyCustomMessageBox.ShowMessage("Выберите Должность", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(salary))
            {
                MyCustomMessageBox.ShowMessage("Заполните поле Зарплата", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            Validation validator = new Validation();
            if (!validator.ValidateLastName(lastName))
            {
                MyCustomMessageBox.ShowMessage("Некорректная фамилия", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!validator.ValidateFirstName(firstName))
            {
                MyCustomMessageBox.ShowMessage("Некорректное имя", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!validator.ValidateEmail(email))
            {
                MyCustomMessageBox.ShowMessage("Некорректный email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!decimal.TryParse(salary, out decimal salaryValue) || salaryValue <= 0)
            {
                MyCustomMessageBox.ShowMessage("Зарплата должна быть положительным числом.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void buttonChange_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;
            try
            {
                DateTime dateOfHire = DateTime.Parse(DateTimePickerEmployee.Text);
                string formattedDateOfHire = dateOfHire.ToString("yyyy-MM-dd");
                using (SqlConnection connection = new SqlConnection(DB.StringConnectionDB))
                {
                    connection.Open();
                    string queryUpEmployee = @"UPDATE Сотрудники SET Имя = @Имя, Фамилия = @Фамилия, ЭлектроннаяПочта = @ЭлектроннаяПочта, ДатаПриема = @ДатаПриема, Зарплата = @Зарплата, КодБригады = @КодБригады, Фото = ISNULL(@Фото, Фото) WHERE КодСотрудника = @КодСотрудника";
                    using (SqlCommand command = new SqlCommand(queryUpEmployee, connection))
                    {
                        command.Parameters.AddWithValue("@Имя", textBoxName.Text);
                        command.Parameters.AddWithValue("@Фамилия", textBoxSurname.Text);
                        command.Parameters.AddWithValue("@ЭлектроннаяПочта", textBoxEmail.Text);
                        command.Parameters.AddWithValue("@ДатаПриема", formattedDateOfHire);
                        command.Parameters.AddWithValue("@Зарплата", decimal.Parse(textBoxSalary.Text));
                        command.Parameters.AddWithValue("@КодСотрудника", employeeId);
                        if (selectedPhotoBytes != null && selectedPhotoBytes.Length > 0)
                        {
                            command.Parameters.AddWithValue("@Фото", selectedPhotoBytes);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@Фото", DBNull.Value);
                        }
                        if (isShveyaSelected && comboBoxBrigade.SelectedValue != null &&
                            comboBoxBrigade.SelectedValue.ToString() != "")
                        {
                            command.Parameters.AddWithValue("@КодБригады", comboBoxBrigade.SelectedValue);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@КодБригады", DBNull.Value);
                        }

                        command.ExecuteNonQuery();
                    }
                    string queryUpUser = @"UPDATE Пользователи SET Должность = @Должность WHERE КодПользователя = (SELECT КодПользователя FROM Сотрудники WHERE КодСотрудника = @КодСотрудника)";
                    using (SqlCommand command = new SqlCommand(queryUpUser, connection))
                    {
                        command.Parameters.AddWithValue("@Должность", comboBoxPost.Text);
                        command.Parameters.AddWithValue("@КодСотрудника", employeeId);
                        command.ExecuteNonQuery();
                    }
                }
                MyCustomMessageBox.ShowMessage("Данные успешно обновлены!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ucПерсонал.RefreshDataGridView();
                Close();
            }
            catch (Exception ex)
            {
                MyCustomMessageBox.ShowMessage("Ошибка при обновлении данных: " + ex.Message,
                                             MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                buttonChange.PerformClick();
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
                buttonChange.PerformClick();
                e.Handled = true;
            }
        }
        private void textBoxEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                textBoxSalary.Focus();
                e.Handled = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                textBoxName.Focus();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                buttonChange.PerformClick();
                e.Handled = true;
            }
        }
        private void textBoxSalary_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                textBoxEmail.Focus();
                e.Handled = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                comboBoxPost.Focus();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                buttonChange.PerformClick();
                e.Handled = true;
            }
        }
        private void comboBoxPost_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                textBoxSalary.Focus();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                buttonChange.PerformClick();
                e.Handled = true;
            }
        }
        private void comboBoxPost_Enter(object sender, EventArgs e)
        {
            comboBoxPost.DroppedDown = true;
        }

        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            DialogResult result = MyCustomMessageBox.ShowMessage("Вы уверены, что хотите изменить пароль?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string newPassword = GeneratePassword();
                Hashing hashing = new Hashing();
                string hashedPassword = hashing.Hash(newPassword);
                string queryUpdatePassword = "UPDATE Пользователи SET Пароль = @Пароль WHERE Логин = @Логин";
                using (SqlConnection connection = new SqlConnection(DB.StringConnectionDB))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(queryUpdatePassword, connection))
                    {
                        command.Parameters.AddWithValue("@Пароль", hashedPassword);
                        command.Parameters.AddWithValue("@Логин", login);
                        command.ExecuteNonQuery();
                    }
                }
                SendMessage(login, newPassword, textBoxEmail.Text);
                MyCustomMessageBox.ShowMessage("Пароль успешно изменен и отправлен на почту.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MyCustomMessageBox.ShowMessage("Действие отменено.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private static string GeneratePassword()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()_+=[{]};:<>|./?";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, 12)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        private static void SendMessage(string login, string password, string email)
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
        private void comboBoxPost_SelectedIndexChanged(object sender, EventArgs e)
        {
            isShveyaSelected = comboBoxPost.Text == "Швея";
            comboBoxBrigade.Enabled = isShveyaSelected;

            if (!isShveyaSelected)
            {
                comboBoxBrigade.SelectedIndex = -1;
            }
        }
    }
}
