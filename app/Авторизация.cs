using app.Classes;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace app
{
    public partial class Авторизация : Form
    {
        private readonly HttpClient _httpClient;
        public Авторизация() : this(new HttpClient()) { }

        public Авторизация(HttpClient httpClient)
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(set_background);
            this.Resize += new EventHandler(Авторизация_Resize);
            FormPanelTextBoxPassword.IconRight = Properties.Resources.visionHide;
            FormPanelTextBoxPassword.UseSystemPasswordChar = true;
            _httpClient = httpClient;
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
        private async void FormPanelButtonEnterance_Click(object sender, EventArgs e)
        {
            var login = FormPanelTextBoxLogin.Text;
            var password = FormPanelTextBoxPassword.Text;
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MyCustomMessageBox.ShowMessage("Заполните все поля", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var authResult = await AuthorizeViaApi(login, password);
            if (authResult.position == "Уволен")
            {
                MyCustomMessageBox.ShowMessage("Доступ запрещен. Ваш аккаунт деактивирован.",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (authResult.isAuthorized)
            {
                MyCustomMessageBox.ShowMessage("Вход успешно выполнен!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        MyCustomMessageBox.ShowMessage("Неизвестная должность.",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                }
                Close();
            }
            else
            {
                MyCustomMessageBox.ShowMessage("Неверный логин или пароль.",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public async Task<(bool isAuthorized, string position)> AuthorizeViaApi(string login, string password)
        {
            try
            {
                var request = new { login, password };
                var response = await _httpClient.PostAsJsonAsync("http://localhost:8000/api/auth/login", request);
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadFromJsonAsync<AuthResponse>();
                    return (result.success, result.position);
                }
                return (false, null);
            }
            catch
            {
                return (false, null);
            }
        }
        public class AuthResponse
        {
            public bool success { get; set; }
            public string position { get; set; }
            public string message { get; set; }
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
    }
}
