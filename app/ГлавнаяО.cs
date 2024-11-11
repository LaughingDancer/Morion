using app.UserControls;
using app.UserControlsOperator;
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
    public partial class ГлавнаяО : Form
    {
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            DesktopPanel.Controls.Clear();
            DesktopPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }
        public ГлавнаяО()
        {
            InitializeComponent();
            UC_Главная uc = new UC_Главная();
            addUserControl(uc);
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            UC_Главная uc = new UC_Главная();
            addUserControl(uc);
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
            UC_ОформитьЗаказ uc = new UC_ОформитьЗаказ();
            addUserControl(uc);
        }

        private void orderDetails_Click(object sender, EventArgs e)
        {
            UC_ДеталиЗаказов uc = new UC_ДеталиЗаказов();
            addUserControl(uc);
        }
    }
}
