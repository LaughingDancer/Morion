using app.Classes;
using app.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app
{
    public partial class ГлавнаяШ : Form
    {
        private UC_Главная ucГлавная;
        private Dictionary<string, string> employeeData;
        private byte[] employeePhoto;
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            DesktopPanel.Controls.Clear();
            DesktopPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }
        public ГлавнаяШ(string login)
        {
            InitializeComponent();
            ucГлавная = new UC_Главная();
            addUserControl(ucГлавная);
            LoadEmployeeData(login);
        }
        private void LoadEmployeeData(string login)
        {
            DB db = new DB();
            employeeData = db.GetEmployeeDataByLogin(login);
            employeePhoto = db.GetEmployeePhotoByLogin(login);
            ucГлавная.LoadEmployeeData(employeeData, employeePhoto);
        }

        private void ГлавнаяШ_Resize(object sender, EventArgs e)
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

        private void guna2Button22_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            Авторизация to = new Авторизация();
            to.ShowDialog();
            Close();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {

        }
    }
}
