namespace app.Forms
{
    partial class ДобавлениеПерсонал
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
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.textBoxName = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxSurname = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.comboBoxPost = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.HeaderPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.HeaderPanelLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.IconClose = new Guna.UI2.WinForms.Guna2Button();
            this.buttonSave = new Guna.UI2.WinForms.Guna2Button();
            this.pictureSet = new Guna.UI2.WinForms.Guna2PictureBox();
            this.HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSet)).BeginInit();
            this.SuspendLayout();
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
            // textBoxName
            // 
            this.textBoxName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(10)))));
            this.textBoxName.BorderRadius = 10;
            this.textBoxName.BorderThickness = 2;
            this.textBoxName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxName.DefaultText = "";
            this.textBoxName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(10)))));
            this.textBoxName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxName.ForeColor = System.Drawing.Color.Black;
            this.textBoxName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(10)))));
            this.textBoxName.Location = new System.Drawing.Point(50, 338);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.PasswordChar = '\0';
            this.textBoxName.PlaceholderText = "Имя";
            this.textBoxName.SelectedText = "";
            this.textBoxName.Size = new System.Drawing.Size(350, 50);
            this.textBoxName.TabIndex = 14;
            this.textBoxName.TabStop = false;
            this.textBoxName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxName_KeyDown);
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(10)))));
            this.textBoxSurname.BorderRadius = 10;
            this.textBoxSurname.BorderThickness = 2;
            this.textBoxSurname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxSurname.DefaultText = "";
            this.textBoxSurname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxSurname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxSurname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxSurname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxSurname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(10)))));
            this.textBoxSurname.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxSurname.ForeColor = System.Drawing.Color.Black;
            this.textBoxSurname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(10)))));
            this.textBoxSurname.Location = new System.Drawing.Point(50, 280);
            this.textBoxSurname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.PasswordChar = '\0';
            this.textBoxSurname.PlaceholderText = "Фамилия";
            this.textBoxSurname.SelectedText = "";
            this.textBoxSurname.Size = new System.Drawing.Size(350, 50);
            this.textBoxSurname.TabIndex = 15;
            this.textBoxSurname.TabStop = false;
            this.textBoxSurname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSurname_KeyDown);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(10)))));
            this.textBoxEmail.BorderRadius = 10;
            this.textBoxEmail.BorderThickness = 2;
            this.textBoxEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxEmail.DefaultText = "";
            this.textBoxEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(10)))));
            this.textBoxEmail.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxEmail.ForeColor = System.Drawing.Color.Black;
            this.textBoxEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(10)))));
            this.textBoxEmail.Location = new System.Drawing.Point(50, 396);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.PasswordChar = '\0';
            this.textBoxEmail.PlaceholderText = "Электронная Почта";
            this.textBoxEmail.SelectedText = "";
            this.textBoxEmail.Size = new System.Drawing.Size(350, 50);
            this.textBoxEmail.TabIndex = 16;
            this.textBoxEmail.TabStop = false;
            this.textBoxEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxEmail_KeyDown);
            // 
            // comboBoxPost
            // 
            this.comboBoxPost.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxPost.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(10)))));
            this.comboBoxPost.BorderRadius = 10;
            this.comboBoxPost.BorderThickness = 2;
            this.comboBoxPost.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxPost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPost.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(10)))));
            this.comboBoxPost.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(10)))));
            this.comboBoxPost.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.comboBoxPost.ForeColor = System.Drawing.Color.Black;
            this.comboBoxPost.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(10)))));
            this.comboBoxPost.ItemHeight = 44;
            this.comboBoxPost.Items.AddRange(new object[] {
            "Швея",
            "Оператор",
            "Специалист КБД"});
            this.comboBoxPost.Location = new System.Drawing.Point(50, 453);
            this.comboBoxPost.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxPost.Name = "comboBoxPost";
            this.comboBoxPost.Size = new System.Drawing.Size(350, 50);
            this.comboBoxPost.TabIndex = 23;
            this.comboBoxPost.Enter += new System.EventHandler(this.comboBoxPost_Enter);
            this.comboBoxPost.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxPost_KeyDown);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.HeaderPanel;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.Controls.Add(this.HeaderPanelLabel);
            this.HeaderPanel.Controls.Add(this.IconClose);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(450, 40);
            this.HeaderPanel.TabIndex = 32;
            // 
            // HeaderPanelLabel
            // 
            this.HeaderPanelLabel.BackColor = System.Drawing.Color.Transparent;
            this.HeaderPanelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HeaderPanelLabel.ForeColor = System.Drawing.Color.White;
            this.HeaderPanelLabel.Location = new System.Drawing.Point(12, 7);
            this.HeaderPanelLabel.Name = "HeaderPanelLabel";
            this.HeaderPanelLabel.Size = new System.Drawing.Size(218, 26);
            this.HeaderPanelLabel.TabIndex = 3;
            this.HeaderPanelLabel.Text = "Морион | Добавление";
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
            this.IconClose.Location = new System.Drawing.Point(410, 0);
            this.IconClose.Name = "IconClose";
            this.IconClose.Size = new System.Drawing.Size(40, 40);
            this.IconClose.TabIndex = 0;
            this.IconClose.UseTransparentBackground = true;
            this.IconClose.Click += new System.EventHandler(this.IconClose_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.BackColor = System.Drawing.Color.Transparent;
            this.buttonSave.BorderRadius = 10;
            this.buttonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonSave.FillColor = System.Drawing.Color.Green;
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.HoverState.FillColor = System.Drawing.Color.ForestGreen;
            this.buttonSave.Location = new System.Drawing.Point(50, 511);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(350, 50);
            this.buttonSave.TabIndex = 22;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseTransparentBackground = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // pictureSet
            // 
            this.pictureSet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureSet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureSet.ImageRotate = 0F;
            this.pictureSet.Location = new System.Drawing.Point(100, 60);
            this.pictureSet.Margin = new System.Windows.Forms.Padding(0);
            this.pictureSet.Name = "pictureSet";
            this.pictureSet.Size = new System.Drawing.Size(250, 200);
            this.pictureSet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureSet.TabIndex = 2;
            this.pictureSet.TabStop = false;
            this.pictureSet.Click += new System.EventHandler(this.pictureSet_Click);
            // 
            // ДобавлениеПерсонал
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(450, 577);
            this.Controls.Add(this.HeaderPanel);
            this.Controls.Add(this.comboBoxPost);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.pictureSet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ДобавлениеПерсонал";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ДобавлениеПерсонал";
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2PictureBox pictureSet;
        private Guna.UI2.WinForms.Guna2TextBox textBoxEmail;
        private Guna.UI2.WinForms.Guna2TextBox textBoxSurname;
        private Guna.UI2.WinForms.Guna2TextBox textBoxName;
        private Guna.UI2.WinForms.Guna2Button buttonSave;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxPost;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Panel HeaderPanel;
        private Guna.UI2.WinForms.Guna2HtmlLabel HeaderPanelLabel;
        private Guna.UI2.WinForms.Guna2Button IconClose;
    }
}