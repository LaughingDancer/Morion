using app.CustomMessageBoxes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.Classes
{
    public static class MyCustomMessageBox
    {
        public static System.Windows.Forms.DialogResult ShowMessage(string message, System.Windows.Forms.MessageBoxButtons button, System.Windows.Forms.MessageBoxIcon icon)
        {
            System.Windows.Forms.DialogResult DLGResult = System.Windows.Forms.DialogResult.None;
            switch (button)
            {
                case System.Windows.Forms.MessageBoxButtons.OK:
                    using (CustomMessageOK MessageOK = new CustomMessageOK())
                    {
                        MessageOK.Message = message;
                        switch (icon)
                        {
                            case System.Windows.Forms.MessageBoxIcon.Information:
                                MessageOK.MessageIcon = Properties.Resources.checkOK;
                                MessageOK.PanelColor = Color.FromArgb(57, 155, 53);
                                MessageOK.ButtonColor = Color.FromArgb(57, 155, 53);
                                MessageOK.ButtonTextColor = Color.White;
                                break;
                            case System.Windows.Forms.MessageBoxIcon.Warning:
                                MessageOK.MessageIcon = Properties.Resources.warning;
                                MessageOK.PanelColor = Color.FromArgb(255, 221, 64);
                                MessageOK.ButtonColor = Color.FromArgb(255, 221, 64);
                                MessageOK.ButtonTextColor = Color.Black;
                                break;
                            case System.Windows.Forms.MessageBoxIcon.Error:
                                MessageOK.MessageIcon = Properties.Resources.cancel;
                                MessageOK.PanelColor = Color.FromArgb(244, 67, 54);
                                MessageOK.ButtonColor = Color.FromArgb(244, 67, 54);
                                MessageOK.ButtonTextColor = Color.White;
                                break;
                        }
                        DLGResult = MessageOK.ShowDialog();
                    }
                    break;
                case System.Windows.Forms.MessageBoxButtons.YesNo:
                    using (CustomMessageYesNo MessageYesNo = new CustomMessageYesNo())
                    {
                        MessageYesNo.Message = message;
                        switch (icon)
                        {
                            case System.Windows.Forms.MessageBoxIcon.Question:
                                MessageYesNo.MessageIcon = Properties.Resources.qustions;
                                break;
                        }
                        DLGResult = MessageYesNo.ShowDialog();
                    }
                    break;
            }
            return DLGResult;
        }
    }
}
