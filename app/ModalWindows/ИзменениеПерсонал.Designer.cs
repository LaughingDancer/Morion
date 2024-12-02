namespace app.Forms
{
    partial class ИзменениеПерсонал
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
            this.comboBoxPost = new Guna.UI2.WinForms.Guna2ComboBox();
            this.buttonChange = new Guna.UI2.WinForms.Guna2Button();
            this.textBoxSalary = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxSurname = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxName = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.DateTimePickerEmployee = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.pictureSet = new Guna.UI2.WinForms.Guna2PictureBox();
            this.buttonChangePassword = new Guna.UI2.WinForms.Guna2Button();
            this.HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSet)).BeginInit();
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
            this.HeaderPanel.Size = new System.Drawing.Size(450, 40);
            this.HeaderPanel.TabIndex = 31;
            // 
            // HeaderPanelLabel
            // 
            this.HeaderPanelLabel.BackColor = System.Drawing.Color.Transparent;
            this.HeaderPanelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HeaderPanelLabel.ForeColor = System.Drawing.Color.White;
            this.HeaderPanelLabel.Location = new System.Drawing.Point(12, 7);
            this.HeaderPanelLabel.Name = "HeaderPanelLabel";
            this.HeaderPanelLabel.Size = new System.Drawing.Size(262, 26);
            this.HeaderPanelLabel.TabIndex = 3;
            this.HeaderPanelLabel.Text = "Морион | Редактирование";
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
            this.comboBoxPost.Location = new System.Drawing.Point(50, 570);
            this.comboBoxPost.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.comboBoxPost.Name = "comboBoxPost";
            this.comboBoxPost.Size = new System.Drawing.Size(350, 50);
            this.comboBoxPost.TabIndex = 39;
            this.comboBoxPost.Enter += new System.EventHandler(this.comboBoxPost_Enter);
            this.comboBoxPost.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxPost_KeyDown);
            // 
            // buttonChange
            // 
            this.buttonChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonChange.BackColor = System.Drawing.Color.Transparent;
            this.buttonChange.BorderRadius = 10;
            this.buttonChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonChange.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonChange.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonChange.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonChange.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonChange.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.buttonChange.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.buttonChange.ForeColor = System.Drawing.Color.White;
            this.buttonChange.Location = new System.Drawing.Point(50, 640);
            this.buttonChange.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(350, 50);
            this.buttonChange.TabIndex = 38;
            this.buttonChange.Text = "Изменить";
            this.buttonChange.UseTransparentBackground = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // textBoxSalary
            // 
            this.textBoxSalary.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(10)))));
            this.textBoxSalary.BorderRadius = 10;
            this.textBoxSalary.BorderThickness = 2;
            this.textBoxSalary.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxSalary.DefaultText = "";
            this.textBoxSalary.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxSalary.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxSalary.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxSalary.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxSalary.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(10)))));
            this.textBoxSalary.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxSalary.ForeColor = System.Drawing.Color.Black;
            this.textBoxSalary.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(10)))));
            this.textBoxSalary.Location = new System.Drawing.Point(50, 450);
            this.textBoxSalary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 10);
            this.textBoxSalary.Name = "textBoxSalary";
            this.textBoxSalary.PasswordChar = '\0';
            this.textBoxSalary.PlaceholderText = "Зарплата";
            this.textBoxSalary.SelectedText = "";
            this.textBoxSalary.Size = new System.Drawing.Size(350, 50);
            this.textBoxSalary.TabIndex = 36;
            this.textBoxSalary.TabStop = false;
            this.textBoxSalary.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSalary_KeyDown);
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
            this.textBoxEmail.Location = new System.Drawing.Point(50, 390);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 10);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.PasswordChar = '\0';
            this.textBoxEmail.PlaceholderText = "Электронная Почта";
            this.textBoxEmail.SelectedText = "";
            this.textBoxEmail.Size = new System.Drawing.Size(350, 50);
            this.textBoxEmail.TabIndex = 35;
            this.textBoxEmail.TabStop = false;
            this.textBoxEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxEmail_KeyDown);
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
            this.textBoxSurname.Location = new System.Drawing.Point(50, 270);
            this.textBoxSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 10);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.PasswordChar = '\0';
            this.textBoxSurname.PlaceholderText = "Фамилия";
            this.textBoxSurname.SelectedText = "";
            this.textBoxSurname.Size = new System.Drawing.Size(350, 50);
            this.textBoxSurname.TabIndex = 34;
            this.textBoxSurname.TabStop = false;
            this.textBoxSurname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSurname_KeyDown);
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
            this.textBoxName.Location = new System.Drawing.Point(50, 330);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 10);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.PasswordChar = '\0';
            this.textBoxName.PlaceholderText = "Имя";
            this.textBoxName.SelectedText = "";
            this.textBoxName.Size = new System.Drawing.Size(350, 50);
            this.textBoxName.TabIndex = 33;
            this.textBoxName.TabStop = false;
            this.textBoxName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxName_KeyDown);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.HeaderPanel;
            this.guna2DragControl1.UseTransparentDrag = true;
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
            // DateTimePickerEmployee
            // 
            this.DateTimePickerEmployee.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(10)))));
            this.DateTimePickerEmployee.BorderRadius = 10;
            this.DateTimePickerEmployee.BorderThickness = 2;
            this.DateTimePickerEmployee.Checked = true;
            this.DateTimePickerEmployee.FillColor = System.Drawing.Color.White;
            this.DateTimePickerEmployee.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DateTimePickerEmployee.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateTimePickerEmployee.Location = new System.Drawing.Point(50, 510);
            this.DateTimePickerEmployee.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.DateTimePickerEmployee.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateTimePickerEmployee.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateTimePickerEmployee.Name = "DateTimePickerEmployee";
            this.DateTimePickerEmployee.Size = new System.Drawing.Size(350, 50);
            this.DateTimePickerEmployee.TabIndex = 40;
            this.DateTimePickerEmployee.Value = new System.DateTime(2024, 11, 10, 14, 2, 55, 140);
            // 
            // pictureSet
            // 
            this.pictureSet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureSet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureSet.ImageRotate = 0F;
            this.pictureSet.Location = new System.Drawing.Point(100, 60);
            this.pictureSet.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.pictureSet.Name = "pictureSet";
            this.pictureSet.Size = new System.Drawing.Size(250, 200);
            this.pictureSet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureSet.TabIndex = 32;
            this.pictureSet.TabStop = false;
            this.pictureSet.Click += new System.EventHandler(this.pictureSet_Click);
            // 
            // buttonChangePassword
            // 
            this.buttonChangePassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonChangePassword.BackColor = System.Drawing.Color.Transparent;
            this.buttonChangePassword.BorderRadius = 10;
            this.buttonChangePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonChangePassword.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonChangePassword.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonChangePassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonChangePassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonChangePassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonChangePassword.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.buttonChangePassword.ForeColor = System.Drawing.Color.White;
            this.buttonChangePassword.Location = new System.Drawing.Point(50, 700);
            this.buttonChangePassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.buttonChangePassword.MinimumSize = new System.Drawing.Size(300, 50);
            this.buttonChangePassword.Name = "buttonChangePassword";
            this.buttonChangePassword.Size = new System.Drawing.Size(350, 50);
            this.buttonChangePassword.TabIndex = 41;
            this.buttonChangePassword.Text = "Изменить пароль";
            this.buttonChangePassword.UseTransparentBackground = true;
            this.buttonChangePassword.Click += new System.EventHandler(this.buttonChangePassword_Click);
            // 
            // ИзменениеПерсонал
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(450, 773);
            this.Controls.Add(this.buttonChangePassword);
            this.Controls.Add(this.DateTimePickerEmployee);
            this.Controls.Add(this.comboBoxPost);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.textBoxSalary);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.pictureSet);
            this.Controls.Add(this.HeaderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ИзменениеПерсонал";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ИзменениеПерсонал";
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel HeaderPanel;
        private Guna.UI2.WinForms.Guna2HtmlLabel HeaderPanelLabel;
        private Guna.UI2.WinForms.Guna2Button IconClose;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxPost;
        private Guna.UI2.WinForms.Guna2Button buttonChange;
        private Guna.UI2.WinForms.Guna2TextBox textBoxSalary;
        private Guna.UI2.WinForms.Guna2TextBox textBoxEmail;
        private Guna.UI2.WinForms.Guna2TextBox textBoxSurname;
        private Guna.UI2.WinForms.Guna2TextBox textBoxName;
        private Guna.UI2.WinForms.Guna2PictureBox pictureSet;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateTimePickerEmployee;
        private Guna.UI2.WinForms.Guna2Button buttonChangePassword;
    }
}