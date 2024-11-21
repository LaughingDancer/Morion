using System;
using System.Drawing;
using System.Windows.Forms;

namespace app.CustomMessageBoxes
{
    public partial class CustomMessageOK : Form
    {
        public CustomMessageOK()
        {
            InitializeComponent();
        }
        public System.Drawing.Image MessageIcon
        {
            get { return PictureBoxIcon.Image; }
            set { PictureBoxIcon.Image = value; }
        }
        public string Message
        {
            get { return LabelMessage.Text; }
            set { LabelMessage.Text = value; }
        }
        public Color PanelColor
        {
            get { return PanelMessage.FillColor; }
            set { PanelMessage.FillColor = value; }
        }
        public Color ButtonColor
        {
            get { return ButtonOK.FillColor; }
            set { ButtonOK.FillColor = value; }
        }
        public Color ButtonTextColor
        {
            get { return ButtonOK.ForeColor; }
            set { ButtonOK.ForeColor = value; }
        }
        private void ButtonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
