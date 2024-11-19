using app.Classes;
using app.UserControls;
using app.UserControlsOperator;
using app.UserControlsSpecialist;
using app.UserControlsStatistics;
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
    public partial class ГлавнаяА : Form
    {
        private Guna.UI2.WinForms.Guna2Button _selectedButton1;
        private Guna.UI2.WinForms.Guna2Button _selectedButton2;
        bool menuExpandOne = false;
        bool menuExpandTwo = false;
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
        public ГлавнаяА(string login)
        {
            InitializeComponent();
            ucГлавная = new UC_Главная();
            addUserControl(ucГлавная);

            guna2Button2.Click += guna2Button2_Click;
            guna2Button4.Click += guna2Button4_Click;
            guna2Button5.Click += guna2Button5_Click;
            guna2Button10.Click += guna2Button10_Click;

            LoadEmployeeData(login);
        }
        private void LoadEmployeeData(string login)
        {
            DB db = new DB();
            employeeData = db.GetEmployeeDataByLogin(login);
            employeePhoto = db.GetEmployeePhotoByLogin(login);
            ucГлавная.LoadEmployeeData(employeeData, employeePhoto);
        }

        private void menuTable_Click(object sender, EventArgs e)
        {
            menuTransitionOne.Start();
        }

        private void menuTransitionOne_Tick(object sender, EventArgs e)
        {
            if (menuExpandOne == false)
            {
                MainPanelMenuContainer1.Height += 10;
                if (MainPanelMenuContainer1.Height >= 375)
                {
                    menuTransitionOne.Stop();
                    menuExpandOne = true;
                }
            }
            else
            {
                MainPanelMenuContainer1.Height -= 10;
                if (MainPanelMenuContainer1.Height <= 75)
                {
                    menuTransitionOne.Stop();
                    menuExpandOne = false;
                }
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

        private void Главная_Resize(object sender, EventArgs e)
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

        private void HomeButton_Click(object sender, EventArgs e)
        {
            ucГлавная.LoadEmployeeData(employeeData, employeePhoto);
            addUserControl(ucГлавная);
            foreach (var button in MainPanelMenuContainer1.Controls.OfType<Guna.UI2.WinForms.Guna2Button>())
            {
                button.Checked = false;
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            UC_ВариантыОптимизацииА uc = new UC_ВариантыОптимизацииА();
            addUserControl(uc);
        }


        private void guna2Button4_Click(object sender, EventArgs e)
        {
            UC_Заказы uc = new UC_Заказы();
            addUserControl(uc);
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            UC_Изделия uc = new UC_Изделия();
            addUserControl(uc);
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            UC_ТканиА uc = new UC_ТканиА();
            addUserControl(uc);
        }

        private void guna2Button21_Click(object sender, EventArgs e)
        {
            UC_Персонал uc = new UC_Персонал();
            addUserControl(uc);
            foreach (var button in MainPanelMenuContainer1.Controls.OfType<Guna.UI2.WinForms.Guna2Button>())
            {
                button.Checked = false;
            }
        }

        private void guna2Button22_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            Авторизация to = new Авторизация();
            to.ShowDialog();
            Close();
        }

        private void menuChart_Click(object sender, EventArgs e)
        {
            UC_Статистика uc = new UC_Статистика();
            addUserControl(uc);
            foreach (var button in MainPanelMenuContainer1.Controls.OfType<Guna.UI2.WinForms.Guna2Button>())
            {
                button.Checked = false;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            UC_ЖурналБэкап uc = new UC_ЖурналБэкап();
            addUserControl(uc);
            foreach (var button in MainPanelMenuContainer1.Controls.OfType<Guna.UI2.WinForms.Guna2Button>())
            {
                button.Checked = false;
            }
        }
    }
}
