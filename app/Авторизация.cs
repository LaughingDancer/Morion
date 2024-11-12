using app.Classes;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app
{
    public partial class Авторизация : Form
    {
        public Авторизация()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(set_background);
            this.Resize += new EventHandler(Авторизация_Resize);
            FormPanelTextBoxPassword.IconRight = Properties.Resources.visionHide;
            FormPanelTextBoxPassword.UseSystemPasswordChar = true;
        }

        private void IconClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void IconMaximized_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void IconMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Авторизация_Resize(object sender, EventArgs e)
        {
            this.Invalidate();
            if (this.WindowState == FormWindowState.Maximized)
            {
                guna2BorderlessForm1.BorderRadius = 0;
            }
            else
            {
                guna2BorderlessForm1.BorderRadius = 20;
            }
        }

        private void set_background(Object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Rectangle gradient_rectangle = new Rectangle(0, 0, Width, Height);
            Brush b = new LinearGradientBrush(gradient_rectangle, Color.FromArgb(33, 41, 61), Color.FromArgb(255, 120, 10), 270f);
            graphics.FillRectangle(b, gradient_rectangle);
        }

        private void FormPanelTextBoxPassword_IconRightClick(object sender, EventArgs e)
        {
            if (FormPanelTextBoxPassword.UseSystemPasswordChar)
            {
                FormPanelTextBoxPassword.UseSystemPasswordChar = false;
                FormPanelTextBoxPassword.IconRight = Properties.Resources.vision;
            }
            else
            {
                FormPanelTextBoxPassword.UseSystemPasswordChar = true;
                FormPanelTextBoxPassword.IconRight = Properties.Resources.visionHide;
            }
        }

        private void FormPanelButtonEnterance_Click(object sender, EventArgs e)
        {
            var login = FormPanelTextBoxLogin.Text;
            var password = FormPanelTextBoxPassword.Text;
            if (login == string.Empty || password == string.Empty)
            {
                MyCustomMessageBox.ShowMessage("Заполните все поля", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var authResult = AuthorizeUser(login, password);
            if (authResult.isAuthorized)
            {
                ActiveForm.Hide();
                switch (authResult.position)
                {
                    case "Специалист КБД":
                        ГлавнаяА toГлавнаяА = new ГлавнаяА(login);
                        toГлавнаяА.ShowDialog();
                        break;
                    case "Оператор":
                        ГлавнаяО toГлавнаяО = new ГлавнаяО(login);
                        toГлавнаяО.ShowDialog();
                        break;
                    case "Швея":
                        ГлавнаяШ toГлавнаяШ = new ГлавнаяШ(login);
                        toГлавнаяШ.ShowDialog();
                        break;
                    default:
                        MyCustomMessageBox.ShowMessage("Неизвестная должность.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                }
                Close();
            }
            else
            {
                MyCustomMessageBox.ShowMessage("Неверный логин или пароль.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private (bool isAuthorized, string position) AuthorizeUser(string login, string password)
        {
            bool isAuthorized = false;
            string position = string.Empty;
            var dbQeury = new DB();
            var getHash = new Hashing();
            using (SqlConnection con = new SqlConnection(dbQeury.StringConnection()))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand($"SELECT * FROM Пользователи" +
                    $" WHERE Логин ='{login}' and Пароль = '{getHash.Hash(password)}'", con))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            if (reader["Пароль"].ToString() == getHash.Hash(password) &&
                                reader["Логин"].ToString() == login)
                            {
                                isAuthorized = true;
                                position = reader["Должность"].ToString();
                                MyCustomMessageBox.ShowMessage("Вход успешно выполнен!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            return (isAuthorized, position);
        }

        private void FormPanelTextBoxLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                FormPanelTextBoxPassword.Focus();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                FormPanelButtonEnterance.PerformClick();
                e.Handled = true;
            }
        }

        private void FormPanelTextBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                FormPanelTextBoxLogin.Focus();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                FormPanelButtonEnterance.PerformClick();
                e.Handled = true;
            }
        }

        private void FormPanelButtonEnterance_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FormPanelButtonEnterance.PerformClick();
                e.Handled = true;
            }
        }
    }
}
