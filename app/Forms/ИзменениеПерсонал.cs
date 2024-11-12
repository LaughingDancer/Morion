using app.Classes;
using app.UserControls;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void buttonChange_Click(object sender, EventArgs e)
        {
            DateTime dateOfHire = DateTime.Parse(DateTimePickerEmployee.Text);
            string formattedDateOfHire = dateOfHire.ToString("yyyy-MM-dd");

            if (!decimal.TryParse(textBoxSalary.Text, out decimal salary))
            {
                MyCustomMessageBox.ShowMessage("Значение зарплаты должно быть числом.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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
            else if (e.KeyCode == Keys.Enter)
            {
                buttonChange.PerformClick();
                e.Handled = true;
            }
        }

        private void buttonChange_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonChange.PerformClick();
                e.Handled = true;
            }
        }
    }
}
