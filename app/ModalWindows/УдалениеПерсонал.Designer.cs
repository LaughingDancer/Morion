namespace app.Forms
{
    partial class УдалениеПерсонал
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
            this.HeaderPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.HeaderPanelLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.IconClose = new Guna.UI2.WinForms.Guna2Button();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.buttonFire = new Guna.UI2.WinForms.Guna2Button();
            this.labelQuation = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.labelEmployeeInfo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.HeaderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.Controls.Add(this.HeaderPanelLabel);
            this.HeaderPanel.Controls.Add(this.IconClose);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(508, 40);
            this.HeaderPanel.TabIndex = 32;
            // 
            // HeaderPanelLabel
            // 
            this.HeaderPanelLabel.BackColor = System.Drawing.Color.Transparent;
            this.HeaderPanelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HeaderPanelLabel.ForeColor = System.Drawing.Color.White;
            this.HeaderPanelLabel.Location = new System.Drawing.Point(12, 7);
            this.HeaderPanelLabel.Name = "HeaderPanelLabel";
            this.HeaderPanelLabel.Size = new System.Drawing.Size(217, 26);
            this.HeaderPanelLabel.TabIndex = 3;
            this.HeaderPanelLabel.Text = "Морион | Увольнение";
            // 
            // IconClose
            // 
            this.IconClose.BackColor = System.Drawing.Color.Transparent;
            this.IconClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.IconClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.IconClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.IconClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.IconClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.IconClose.FillColor = System.Drawing.Color.Empty;
            this.IconClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.IconClose.ForeColor = System.Drawing.Color.White;
            this.IconClose.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.IconClose.Image = global::app.Properties.Resources.closeW;
            this.IconClose.ImageSize = new System.Drawing.Size(30, 30);
            this.IconClose.Location = new System.Drawing.Point(468, 0);
            this.IconClose.Name = "IconClose";
            this.IconClose.Size = new System.Drawing.Size(40, 40);
            this.IconClose.TabIndex = 0;
            this.IconClose.UseTransparentBackground = true;
            this.IconClose.Click += new System.EventHandler(this.IconClose_Click);
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
            // buttonFire
            // 
            this.buttonFire.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFire.BackColor = System.Drawing.Color.Transparent;
            this.buttonFire.BorderRadius = 10;
            this.buttonFire.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFire.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonFire.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonFire.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonFire.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonFire.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonFire.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.buttonFire.ForeColor = System.Drawing.Color.White;
            this.buttonFire.Location = new System.Drawing.Point(83, 194);
            this.buttonFire.Margin = new System.Windows.Forms.Padding(0);
            this.buttonFire.Name = "buttonFire";
            this.buttonFire.Size = new System.Drawing.Size(350, 50);
            this.buttonFire.TabIndex = 39;
            this.buttonFire.Text = "Уволить";
            this.buttonFire.UseTransparentBackground = true;
            this.buttonFire.Click += new System.EventHandler(this.buttonFire_Click);
            // 
            // labelQuation
            // 
            this.labelQuation.BackColor = System.Drawing.Color.Transparent;
            this.labelQuation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelQuation.Location = new System.Drawing.Point(49, 78);
            this.labelQuation.Name = "labelQuation";
            this.labelQuation.Size = new System.Drawing.Size(411, 26);
            this.labelQuation.TabIndex = 40;
            this.labelQuation.Text = "Вы уверены, что хотите уволить сотрудника:";
            // 
            // labelEmployeeInfo
            // 
            this.labelEmployeeInfo.BackColor = System.Drawing.Color.Transparent;
            this.labelEmployeeInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEmployeeInfo.Location = new System.Drawing.Point(217, 121);
            this.labelEmployeeInfo.Name = "labelEmployeeInfo";
            this.labelEmployeeInfo.Size = new System.Drawing.Size(74, 26);
            this.labelEmployeeInfo.TabIndex = 41;
            this.labelEmployeeInfo.Text = "quations";
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.HeaderPanel;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // УдалениеПерсонал
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(508, 268);
            this.Controls.Add(this.labelEmployeeInfo);
            this.Controls.Add(this.labelQuation);
            this.Controls.Add(this.buttonFire);
            this.Controls.Add(this.HeaderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "УдалениеПерсонал";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "УдалениеПерсонал";
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel HeaderPanel;
        private Guna.UI2.WinForms.Guna2HtmlLabel HeaderPanelLabel;
        private Guna.UI2.WinForms.Guna2Button IconClose;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Button buttonFire;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelQuation;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelEmployeeInfo;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}