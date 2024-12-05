using app.Classes;
using app.UserControls;
using app.UserControlsOperator;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace app
{
    public partial class ГлавнаяО : Form
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
        public ГлавнаяО(string login)
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
            int employeeId = Convert.ToInt32(employeeData["КодСотрудника"]);
            ucГлавная.LoadEmployeeData(employeeData, employeePhoto);
        }
        private void HomeButton_Click(object sender, EventArgs e)
        {
            ucГлавная.LoadEmployeeData(employeeData, employeePhoto);
            addUserControl(ucГлавная);
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
        private void ordering_Click(object sender, EventArgs e)
        {
            int employeeId = Convert.ToInt32(employeeData["КодСотрудника"]);
            UC_ОформитьЗаказ uc = new UC_ОформитьЗаказ(employeeId);
            addUserControl(uc);
        }
        private void orderDetails_Click(object sender, EventArgs e)
        {
            UC_Заказы uc = new UC_Заказы();
            addUserControl(uc);
        }
        private void ГлавнаяО_Resize(object sender, EventArgs e)
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
        private void ProductList_Click(object sender, EventArgs e)
        {
            UC_Изделия uc = new UC_Изделия();
            addUserControl(uc);
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            int employeeId = Convert.ToInt32(employeeData["КодСотрудника"]);
            UC_ВариантыОптимизацииО uc = new UC_ВариантыОптимизацииО(employeeId);
            addUserControl(uc);
        }
    }
}
