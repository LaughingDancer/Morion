using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            ActiveForm.Hide();
            ГлавнаяА to = new ГлавнаяА();
            to.ShowDialog();
            Close();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            ГлавнаяО to = new ГлавнаяО();
            to.ShowDialog();
            Close();
        }
    }
}
