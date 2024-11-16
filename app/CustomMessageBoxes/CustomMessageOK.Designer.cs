namespace app.CustomMessageBoxes
{
    partial class CustomMessageOK
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
            this.ButtonOK = new Guna.UI2.WinForms.Guna2Button();
            this.PictureBoxIcon = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelMessage
            // 
            this.PanelMessage.Dock = System.Windows.Forms.DockStyle.Left;
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
            this.LabelMessage.Location = new System.Drawing.Point(169, 35);
            this.LabelMessage.Name = "LabelMessage";
            this.LabelMessage.Size = new System.Drawing.Size(249, 69);
            this.LabelMessage.TabIndex = 4;
            this.LabelMessage.Text = "Сообщение";
            // 
            // ButtonOK
            // 
            this.ButtonOK.BorderRadius = 5;
            this.ButtonOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ButtonOK.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonOK.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonOK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonOK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonOK.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ButtonOK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.ButtonOK.ForeColor = System.Drawing.Color.White;
            this.ButtonOK.Location = new System.Drawing.Point(169, 110);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new System.Drawing.Size(249, 35);
            this.ButtonOK.TabIndex = 5;
            this.ButtonOK.Text = "ОК";
            this.ButtonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // PictureBoxIcon
            // 
            this.PictureBoxIcon.BackColor = System.Drawing.Color.Transparent;
            this.PictureBoxIcon.Image = global::app.Properties.Resources.checkOK;
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
            // CustomMessageOK
            // 
            this.AcceptButton = this.ButtonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 180);
            this.Controls.Add(this.ButtonOK);
            this.Controls.Add(this.LabelMessage);
            this.Controls.Add(this.PictureBoxIcon);
            this.Controls.Add(this.PanelMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomMessageOK";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CustomMessageOK";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel PanelMessage;
        private Guna.UI2.WinForms.Guna2PictureBox PictureBoxIcon;
        private Guna.UI2.WinForms.Guna2HtmlLabel LabelMessage;
        private Guna.UI2.WinForms.Guna2Button ButtonOK;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
    }
}