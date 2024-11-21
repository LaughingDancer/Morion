using app.Classes;
using app.UserControls;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using static app.Classes.ValidationData;

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
        private DB DB;
        private byte[] selectedPhotoBytes;
        private UC_Персонал ucПерсонал;
        public ИзменениеПерсонал(int employeeId, string firstName, string lastName, string email, string dateOfHire, string salary, string post, UC_Персонал ucПерсонал)
        {
            InitializeComponent();
            this.employeeId = employeeId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.dateOfHire = dateOfHire;
            this.salary = salary;
            this.post = post;
            DB = new DB();
            this.ucПерсонал = ucПерсонал;
            textBoxName.Text = firstName;
            textBoxSurname.Text = lastName;
            textBoxEmail.Text = email;
            DateTimePickerEmployee.Text = dateOfHire;
            textBoxSalary.Text = salary;
            comboBoxPost.Text = post;
            LoadEmployeePhoto();
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

            if (selectedPhotoBytes == null || selectedPhotoBytes.Length == 0)
            {
                MyCustomMessageBox.ShowMessage("Пожалуйста, загрузите фотографию сотрудника.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
        private void buttonChange_Click(object sender, EventArgs e)
        {
            DateTime dateOfHire = DateTime.Parse(DateTimePickerEmployee.Text);
            string formattedDateOfHire = dateOfHire.ToString("yyyy-MM-dd");
            string queryUpEmployee = "UPDATE Сотрудники SET Имя = @Имя, Фамилия = @Фамилия, ЭлектроннаяПочта = @ЭлектроннаяПочта, ДатаПриема = @ДатаПриема, Зарплата = @Зарплата WHERE КодСотрудника = @КодСотрудника";
            using (SqlConnection connection = new SqlConnection(DB.StringConnection()))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(queryUpEmployee, connection))
                {
                    command.Parameters.AddWithValue("@Имя", textBoxName.Text);
                    command.Parameters.AddWithValue("@Фамилия", textBoxSurname.Text);
                    command.Parameters.AddWithValue("@ЭлектроннаяПочта", textBoxEmail.Text);
                    command.Parameters.AddWithValue("@ДатаПриема", formattedDateOfHire);
                    command.Parameters.AddWithValue("@Зарплата", salary);
                    command.Parameters.AddWithValue("@КодСотрудника", employeeId);
                    command.ExecuteNonQuery();
                }
            }
            string queryUpUser = "UPDATE Пользователи SET Должность = @Должность WHERE КодПользователя = (SELECT КодПользователя FROM Сотрудники WHERE КодСотрудника = @КодСотрудника)";
            using (SqlConnection connection = new SqlConnection(DB.StringConnection()))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(queryUpUser, connection))
                {
                    command.Parameters.AddWithValue("@Должность", comboBoxPost.Text);
                    command.Parameters.AddWithValue("@КодСотрудника", employeeId);
                    command.ExecuteNonQuery();
                }
            }
            if (selectedPhotoBytes != null)
            {
                string queryUpPhoto = "UPDATE Сотрудники SET Фото = @Фото WHERE КодСотрудника = @КодСотрудника";
                using (SqlConnection connection = new SqlConnection(DB.StringConnection()))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(queryUpPhoto, connection))
                    {
                        command.Parameters.AddWithValue("@Фото", selectedPhotoBytes);
                        command.Parameters.AddWithValue("@КодСотрудника", employeeId);
                        command.ExecuteNonQuery();
                    }
                }
            }
            MyCustomMessageBox.ShowMessage("Данные успешно обновлены!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ucПерсонал.RefreshDataGridView();
            Close();
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
    }
}
