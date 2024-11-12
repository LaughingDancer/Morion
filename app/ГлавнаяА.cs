using app.Classes;
using app.UserControls;
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
            guna2Button3.Click += guna2Button3_Click;
            guna2Button4.Click += guna2Button4_Click;
            guna2Button5.Click += guna2Button5_Click;
            guna2Button6.Click += guna2Button6_Click;
            guna2Button7.Click += guna2Button7_Click;
            guna2Button9.Click += guna2Button9_Click;
            guna2Button10.Click += guna2Button10_Click;

            guna2Button13.Click += guna2Button13_Click;
            guna2Button14.Click += guna2Button14_Click;
            guna2Button15.Click += guna2Button15_Click;
            guna2Button16.Click += guna2Button16_Click;
            guna2Button17.Click += guna2Button17_Click;
            guna2Button18.Click += guna2Button18_Click;
            guna2Button19.Click += guna2Button19_Click;
            guna2Button20.Click += guna2Button20_Click;

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

        private void menuChart_Click(object sender, EventArgs e)
        {
            menuTransitionTwo.Start();
        }

        private void menuTransitionOne_Tick(object sender, EventArgs e)
        {
            if (menuExpandOne == false)
            {
                MainPanelMenuContainer1.Height += 10;
                if (MainPanelMenuContainer1.Height >= 500)
                {
                    menuTransitionOne.Stop();
                    menuExpandOne = true;
                }
            }
            else
            {
                MainPanelMenuContainer1.Height -= 10;
                if (MainPanelMenuContainer1.Height <= 50)
                {
                    menuTransitionOne.Stop();
                    menuExpandOne = false;
                }
            }
        }

        private void menuTransitionTwo_Tick(object sender, EventArgs e)
        {
            if (menuExpandTwo == false)
            {
                MainPanelMenuContainer2.Height += 10;
                if (MainPanelMenuContainer2.Height >= 500)
                {
                    menuTransitionTwo.Stop();
                    menuExpandTwo = true;
                }
            }
            else
            {
                MainPanelMenuContainer2.Height -= 10;
                if (MainPanelMenuContainer2.Height <= 50)
                {
                    menuTransitionTwo.Stop();
                    menuExpandTwo = false;
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
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            UC_ВариантыОптимизацииА uc = new UC_ВариантыОптимизацииА();
            addUserControl(uc);
            foreach (var button in MainPanelMenuContainer2.Controls.OfType<Guna.UI2.WinForms.Guna2Button>())
            {
                button.Checked = false;
            }
            _selectedButton1 = sender as Guna.UI2.WinForms.Guna2Button;
            _selectedButton1.Checked = true;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            UC_ДеталиЗаказаА uc = new UC_ДеталиЗаказаА();
            addUserControl(uc);
            foreach (var button in MainPanelMenuContainer2.Controls.OfType<Guna.UI2.WinForms.Guna2Button>())
            {
                button.Checked = false;
            }
            _selectedButton1 = sender as Guna.UI2.WinForms.Guna2Button;
            _selectedButton1.Checked = true;
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            UC_ЗаказыА uc = new UC_ЗаказыА();
            addUserControl(uc);
            foreach (var button in MainPanelMenuContainer2.Controls.OfType<Guna.UI2.WinForms.Guna2Button>())
            {
                button.Checked = false;
            }
            _selectedButton1 = sender as Guna.UI2.WinForms.Guna2Button;
            _selectedButton1.Checked = true;
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            UC_ИзделияА uc = new UC_ИзделияА();
            addUserControl(uc);
            foreach (var button in MainPanelMenuContainer2.Controls.OfType<Guna.UI2.WinForms.Guna2Button>())
            {
                button.Checked = false;
            }
            _selectedButton1 = sender as Guna.UI2.WinForms.Guna2Button;
            _selectedButton1.Checked = true;
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            UC_ИзделияТканиА uc = new UC_ИзделияТканиА();
            addUserControl(uc);
            foreach (var button in MainPanelMenuContainer2.Controls.OfType<Guna.UI2.WinForms.Guna2Button>())
            {
                button.Checked = false;
            }
            _selectedButton1 = sender as Guna.UI2.WinForms.Guna2Button;
            _selectedButton1.Checked = true;
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            UC_ПользователиА uc = new UC_ПользователиА();
            addUserControl(uc);
            foreach (var button in MainPanelMenuContainer2.Controls.OfType<Guna.UI2.WinForms.Guna2Button>())
            {
                button.Checked = false;
            }
            _selectedButton1 = sender as Guna.UI2.WinForms.Guna2Button;
            _selectedButton1.Checked = true;
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            UC_СотрудникиА uc = new UC_СотрудникиА();
            addUserControl(uc);
            foreach (var button in MainPanelMenuContainer2.Controls.OfType<Guna.UI2.WinForms.Guna2Button>())
            {
                button.Checked = false;
            }
            _selectedButton1 = sender as Guna.UI2.WinForms.Guna2Button;
            _selectedButton1.Checked = true;
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            UC_ТканиА uc = new UC_ТканиА();
            addUserControl(uc);
            foreach (var button in MainPanelMenuContainer2.Controls.OfType<Guna.UI2.WinForms.Guna2Button>())
            {
                button.Checked = false;
            }
            _selectedButton1 = sender as Guna.UI2.WinForms.Guna2Button;
            _selectedButton1.Checked = true;
        }

        private void guna2Button13_Click(object sender, EventArgs e)
        {
            UC_ВариантыОптимизацииСА uc = new UC_ВариантыОптимизацииСА();
            addUserControl(uc);
            foreach (var button in MainPanelMenuContainer1.Controls.OfType<Guna.UI2.WinForms.Guna2Button>())
            {
                button.Checked = false;
            }
            _selectedButton2 = sender as Guna.UI2.WinForms.Guna2Button;
            _selectedButton2.Checked = true;
        }

        private void guna2Button14_Click(object sender, EventArgs e)
        {
            UC_ДеталиЗаказаСА uc = new UC_ДеталиЗаказаСА();
            addUserControl(uc);
            foreach (var button in MainPanelMenuContainer1.Controls.OfType<Guna.UI2.WinForms.Guna2Button>())
            {
                button.Checked = false;
            }
            _selectedButton2 = sender as Guna.UI2.WinForms.Guna2Button;
            _selectedButton2.Checked = true;
        }

        private void guna2Button15_Click(object sender, EventArgs e)
        {
            UC_ЗаказыСА uc = new UC_ЗаказыСА();
            addUserControl(uc);
            foreach (var button in MainPanelMenuContainer1.Controls.OfType<Guna.UI2.WinForms.Guna2Button>())
            {
                button.Checked = false;
            }
            _selectedButton2 = sender as Guna.UI2.WinForms.Guna2Button;
            _selectedButton2.Checked = true;
        }

        private void guna2Button16_Click(object sender, EventArgs e)
        {
            UC_ИзделияСА uc = new UC_ИзделияСА();
            addUserControl(uc);
            foreach (var button in MainPanelMenuContainer1.Controls.OfType<Guna.UI2.WinForms.Guna2Button>())
            {
                button.Checked = false;
            }
            _selectedButton2 = sender as Guna.UI2.WinForms.Guna2Button;
            _selectedButton2.Checked = true;
        }

        private void guna2Button18_Click(object sender, EventArgs e)
        {
            UC_ПользователиСА uc = new UC_ПользователиСА();
            addUserControl(uc);
            foreach (var button in MainPanelMenuContainer1.Controls.OfType<Guna.UI2.WinForms.Guna2Button>())
            {
                button.Checked = false;
            }
            _selectedButton2 = sender as Guna.UI2.WinForms.Guna2Button;
            _selectedButton2.Checked = true;
        }

        private void guna2Button19_Click(object sender, EventArgs e)
        {
            UC_СотрудникиСА uc = new UC_СотрудникиСА();
            addUserControl(uc);
            foreach (var button in MainPanelMenuContainer1.Controls.OfType<Guna.UI2.WinForms.Guna2Button>())
            {
                button.Checked = false;
            }
            _selectedButton2 = sender as Guna.UI2.WinForms.Guna2Button;
            _selectedButton2.Checked = true;
        }

        private void guna2Button20_Click(object sender, EventArgs e)
        {
            UC_ТканиСА uc = new UC_ТканиСА();
            addUserControl(uc);
            foreach (var button in MainPanelMenuContainer1.Controls.OfType<Guna.UI2.WinForms.Guna2Button>())
            {
                button.Checked = false;
            }
            _selectedButton2 = sender as Guna.UI2.WinForms.Guna2Button;
            _selectedButton2.Checked = true;
        }

        private void guna2Button17_Click(object sender, EventArgs e)
        {
            UC_ИзделияТканиСА uc = new UC_ИзделияТканиСА();
            addUserControl(uc);
            foreach (var button in MainPanelMenuContainer1.Controls.OfType<Guna.UI2.WinForms.Guna2Button>())
            {
                button.Checked = false;
            }
            _selectedButton2 = sender as Guna.UI2.WinForms.Guna2Button;
            _selectedButton2.Checked = true;
        }

        private void guna2Button21_Click(object sender, EventArgs e)
        {
            UC_Персонал uc = new UC_Персонал();
            addUserControl(uc);
            foreach (var button in MainPanelMenuContainer1.Controls.OfType<Guna.UI2.WinForms.Guna2Button>())
            {
                button.Checked = false;
            }
            foreach (var button in MainPanelMenuContainer2.Controls.OfType<Guna.UI2.WinForms.Guna2Button>())
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
    }
}
