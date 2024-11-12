using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app.CustomMessageBoxes
{
    public partial class CustomMessageYesNo : Form
    {
        public CustomMessageYesNo()
        {
            InitializeComponent();
        }
        public Image MessageIcon
        {
            get { return PictureBoxIcon.Image; }
            set { PictureBoxIcon.Image = value; }
        }
        public string Message
        {
            get { return LabelMessage.Text; }
            set { LabelMessage.Text = value; }
        }

        private void ButtonYes_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void ButtonNo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }
    }
}
