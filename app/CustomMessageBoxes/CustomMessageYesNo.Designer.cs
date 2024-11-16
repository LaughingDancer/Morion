namespace app.CustomMessageBoxes
{
    partial class CustomMessageYesNo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PanelMessage = new Guna.UI2.WinForms.Guna2Panel();
            this.LabelMessage = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ButtonYes = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonNo = new Guna.UI2.WinForms.Guna2Button();
            this.PictureBoxIcon = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelMessage
            // 
            this.PanelMessage.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMessage.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(183)))), ((int)(((byte)(211)))));
            this.PanelMessage.Location = new System.Drawing.Point(0, 0);
            this.PanelMessage.Name = "PanelMessage";
            this.PanelMessage.Size = new System.Drawing.Size(30, 180);
            this.PanelMessage.TabIndex = 2;
            // 
            // LabelMessage
            // 
            this.LabelMessage.AutoSize = false;
            this.LabelMessage.BackColor = System.Drawing.Color.Transparent;
            this.LabelMessage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelMessage.Location = new System.Drawing.Point(169, 31);
            this.LabelMessage.Name = "LabelMessage";
            this.LabelMessage.Size = new System.Drawing.Size(237, 73);
            this.LabelMessage.TabIndex = 4;
            this.LabelMessage.Text = "Сообщение";
            // 
            // ButtonYes
            // 
            this.ButtonYes.BorderRadius = 5;
            this.ButtonYes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonYes.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.ButtonYes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonYes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonYes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonYes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonYes.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(155)))), ((int)(((byte)(53)))));
            this.ButtonYes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.ButtonYes.ForeColor = System.Drawing.Color.White;
            this.ButtonYes.Location = new System.Drawing.Point(169, 110);
            this.ButtonYes.Name = "ButtonYes";
            this.ButtonYes.Size = new System.Drawing.Size(100, 35);
            this.ButtonYes.TabIndex = 5;
            this.ButtonYes.Text = "Да";
            this.ButtonYes.Click += new System.EventHandler(this.ButtonYes_Click);
            // 
            // ButtonNo
            // 
            this.ButtonNo.BorderRadius = 5;
            this.ButtonNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonNo.DialogResult = System.Windows.Forms.DialogResult.No;
            this.ButtonNo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonNo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonNo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.ButtonNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.ButtonNo.ForeColor = System.Drawing.Color.White;
            this.ButtonNo.Location = new System.Drawing.Point(306, 110);
            this.ButtonNo.Name = "ButtonNo";
            this.ButtonNo.Size = new System.Drawing.Size(100, 35);
            this.ButtonNo.TabIndex = 6;
            this.ButtonNo.Text = "Нет";
            this.ButtonNo.Click += new System.EventHandler(this.ButtonNo_Click);
            // 
            // PictureBoxIcon
            // 
            this.PictureBoxIcon.BackColor = System.Drawing.Color.Transparent;
            this.PictureBoxIcon.Image = global::app.Properties.Resources.qustions;
            this.PictureBoxIcon.ImageRotate = 0F;
            this.PictureBoxIcon.Location = new System.Drawing.Point(36, 35);
            this.PictureBoxIcon.Name = "PictureBoxIcon";
            this.PictureBoxIcon.Size = new System.Drawing.Size(110, 110);
            this.PictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxIcon.TabIndex = 3;
            this.PictureBoxIcon.TabStop = false;
            this.PictureBoxIcon.UseTransparentBackground = true;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 20;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.DragForm = false;
            this.guna2BorderlessForm1.ResizeForm = false;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // CustomMessageYesNo
            // 
            this.AcceptButton = this.ButtonYes;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 180);
            this.Controls.Add(this.ButtonNo);
            this.Controls.Add(this.ButtonYes);
            this.Controls.Add(this.LabelMessage);
            this.Controls.Add(this.PictureBoxIcon);
            this.Controls.Add(this.PanelMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomMessageYesNo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomMessageOK";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel PanelMessage;
        private Guna.UI2.WinForms.Guna2PictureBox PictureBoxIcon;
        private Guna.UI2.WinForms.Guna2HtmlLabel LabelMessage;
        private Guna.UI2.WinForms.Guna2Button ButtonYes;
        private Guna.UI2.WinForms.Guna2Button ButtonNo;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
    }
}