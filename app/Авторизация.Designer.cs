namespace app
{
    partial class Авторизация
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Авторизация));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.HeaderPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.HeaderPanelLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.IconMinimized = new Guna.UI2.WinForms.Guna2Button();
            this.IconMaximized = new Guna.UI2.WinForms.Guna2Button();
            this.IconClose = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.FormPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.FormPanelButtonEnterance = new Guna.UI2.WinForms.Guna2GradientButton();
            this.FormPanelTextBoxPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.FormPanelTextBoxLogin = new Guna.UI2.WinForms.Guna2TextBox();
            this.FormPanelLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.HeaderPanel.SuspendLayout();
            this.FormPanel.SuspendLayout();
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
            // HeaderPanel
            // 
            this.HeaderPanel.Controls.Add(this.HeaderPanelLabel);
            this.HeaderPanel.Controls.Add(this.IconMinimized);
            this.HeaderPanel.Controls.Add(this.IconMaximized);
            this.HeaderPanel.Controls.Add(this.IconClose);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(1000, 40);
            this.HeaderPanel.TabIndex = 0;
            // 
            // HeaderPanelLabel
            // 
            this.HeaderPanelLabel.BackColor = System.Drawing.Color.Transparent;
            this.HeaderPanelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HeaderPanelLabel.ForeColor = System.Drawing.Color.White;
            this.HeaderPanelLabel.Location = new System.Drawing.Point(12, 7);
            this.HeaderPanelLabel.Name = "HeaderPanelLabel";
            this.HeaderPanelLabel.Size = new System.Drawing.Size(80, 26);
            this.HeaderPanelLabel.TabIndex = 3;
            this.HeaderPanelLabel.Text = "Морион";
            // 
            // IconMinimized
            // 
            this.IconMinimized.BackColor = System.Drawing.Color.Transparent;
            this.IconMinimized.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.IconMinimized.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.IconMinimized.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.IconMinimized.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.IconMinimized.Dock = System.Windows.Forms.DockStyle.Right;
            this.IconMinimized.FillColor = System.Drawing.Color.Empty;
            this.IconMinimized.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.IconMinimized.ForeColor = System.Drawing.Color.White;
            this.IconMinimized.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(100)))));
            this.IconMinimized.Image = global::app.Properties.Resources.minimizeW;
            this.IconMinimized.ImageSize = new System.Drawing.Size(24, 24);
            this.IconMinimized.Location = new System.Drawing.Point(880, 0);
            this.IconMinimized.Name = "IconMinimized";
            this.IconMinimized.Size = new System.Drawing.Size(40, 40);
            this.IconMinimized.TabIndex = 2;
            this.IconMinimized.UseTransparentBackground = true;
            this.IconMinimized.Click += new System.EventHandler(this.IconMinimized_Click);
            // 
            // IconMaximized
            // 
            this.IconMaximized.BackColor = System.Drawing.Color.Transparent;
            this.IconMaximized.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.IconMaximized.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.IconMaximized.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.IconMaximized.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.IconMaximized.Dock = System.Windows.Forms.DockStyle.Right;
            this.IconMaximized.FillColor = System.Drawing.Color.Empty;
            this.IconMaximized.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.IconMaximized.ForeColor = System.Drawing.Color.White;
            this.IconMaximized.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(100)))));
            this.IconMaximized.Image = global::app.Properties.Resources.expand_window;
            this.IconMaximized.ImageSize = new System.Drawing.Size(30, 30);
            this.IconMaximized.Location = new System.Drawing.Point(920, 0);
            this.IconMaximized.Name = "IconMaximized";
            this.IconMaximized.Size = new System.Drawing.Size(40, 40);
            this.IconMaximized.TabIndex = 1;
            this.IconMaximized.UseTransparentBackground = true;
            this.IconMaximized.Click += new System.EventHandler(this.IconMaximized_Click);
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
            this.IconClose.Location = new System.Drawing.Point(960, 0);
            this.IconClose.Name = "IconClose";
            this.IconClose.Size = new System.Drawing.Size(40, 40);
            this.IconClose.TabIndex = 0;
            this.IconClose.UseTransparentBackground = true;
            this.IconClose.Click += new System.EventHandler(this.IconClose_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.HeaderPanel;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // FormPanel
            // 
            this.FormPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FormPanel.BackColor = System.Drawing.Color.Transparent;
            this.FormPanel.BorderRadius = 25;
            this.FormPanel.Controls.Add(this.FormPanelButtonEnterance);
            this.FormPanel.Controls.Add(this.FormPanelTextBoxPassword);
            this.FormPanel.Controls.Add(this.FormPanelTextBoxLogin);
            this.FormPanel.Controls.Add(this.FormPanelLabel);
            this.FormPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(235)))));
            this.FormPanel.Location = new System.Drawing.Point(250, 175);
            this.FormPanel.Name = "FormPanel";
            this.FormPanel.Size = new System.Drawing.Size(500, 400);
            this.FormPanel.TabIndex = 1;
            this.FormPanel.UseTransparentBackground = true;
            // 
            // FormPanelButtonEnterance
            // 
            this.FormPanelButtonEnterance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FormPanelButtonEnterance.BorderRadius = 15;
            this.FormPanelButtonEnterance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormPanelButtonEnterance.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.FormPanelButtonEnterance.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.FormPanelButtonEnterance.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.FormPanelButtonEnterance.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.FormPanelButtonEnterance.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.FormPanelButtonEnterance.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.FormPanelButtonEnterance.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.FormPanelButtonEnterance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.FormPanelButtonEnterance.ForeColor = System.Drawing.Color.White;
            this.FormPanelButtonEnterance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.FormPanelButtonEnterance.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(100)))));
            this.FormPanelButtonEnterance.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(100)))));
            this.FormPanelButtonEnterance.Location = new System.Drawing.Point(84, 314);
            this.FormPanelButtonEnterance.Name = "FormPanelButtonEnterance";
            this.FormPanelButtonEnterance.Size = new System.Drawing.Size(333, 55);
            this.FormPanelButtonEnterance.TabIndex = 8;
            this.FormPanelButtonEnterance.Text = "Вход";
            this.FormPanelButtonEnterance.Click += new System.EventHandler(this.FormPanelButtonEnterance_Click);
            // 
            // FormPanelTextBoxPassword
            // 
            this.FormPanelTextBoxPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FormPanelTextBoxPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(10)))));
            this.FormPanelTextBoxPassword.BorderRadius = 15;
            this.FormPanelTextBoxPassword.BorderThickness = 2;
            this.FormPanelTextBoxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FormPanelTextBoxPassword.DefaultText = "";
            this.FormPanelTextBoxPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.FormPanelTextBoxPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.FormPanelTextBoxPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FormPanelTextBoxPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FormPanelTextBoxPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(235)))));
            this.FormPanelTextBoxPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(5)))));
            this.FormPanelTextBoxPassword.FocusedState.FillColor = System.Drawing.Color.White;
            this.FormPanelTextBoxPassword.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.FormPanelTextBoxPassword.ForeColor = System.Drawing.Color.Black;
            this.FormPanelTextBoxPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(5)))));
            this.FormPanelTextBoxPassword.IconLeft = global::app.Properties.Resources._lock;
            this.FormPanelTextBoxPassword.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.FormPanelTextBoxPassword.IconLeftSize = new System.Drawing.Size(25, 25);
            this.FormPanelTextBoxPassword.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.FormPanelTextBoxPassword.IconRightOffset = new System.Drawing.Point(10, 0);
            this.FormPanelTextBoxPassword.IconRightSize = new System.Drawing.Size(25, 25);
            this.FormPanelTextBoxPassword.Location = new System.Drawing.Point(84, 219);
            this.FormPanelTextBoxPassword.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.FormPanelTextBoxPassword.Name = "FormPanelTextBoxPassword";
            this.FormPanelTextBoxPassword.PasswordChar = '\0';
            this.FormPanelTextBoxPassword.PlaceholderForeColor = System.Drawing.Color.Black;
            this.FormPanelTextBoxPassword.PlaceholderText = "Пароль";
            this.FormPanelTextBoxPassword.SelectedText = "";
            this.FormPanelTextBoxPassword.Size = new System.Drawing.Size(333, 55);
            this.FormPanelTextBoxPassword.TabIndex = 7;
            this.FormPanelTextBoxPassword.TextOffset = new System.Drawing.Point(10, 0);
            this.FormPanelTextBoxPassword.IconRightClick += new System.EventHandler(this.FormPanelTextBoxPassword_IconRightClick);
            this.FormPanelTextBoxPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormPanelTextBoxPassword_KeyDown);
            // 
            // FormPanelTextBoxLogin
            // 
            this.FormPanelTextBoxLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FormPanelTextBoxLogin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(10)))));
            this.FormPanelTextBoxLogin.BorderRadius = 15;
            this.FormPanelTextBoxLogin.BorderThickness = 2;
            this.FormPanelTextBoxLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FormPanelTextBoxLogin.DefaultText = "";
            this.FormPanelTextBoxLogin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.FormPanelTextBoxLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.FormPanelTextBoxLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FormPanelTextBoxLogin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FormPanelTextBoxLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(235)))));
            this.FormPanelTextBoxLogin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(5)))));
            this.FormPanelTextBoxLogin.FocusedState.FillColor = System.Drawing.Color.White;
            this.FormPanelTextBoxLogin.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.FormPanelTextBoxLogin.ForeColor = System.Drawing.Color.Black;
            this.FormPanelTextBoxLogin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(5)))));
            this.FormPanelTextBoxLogin.IconLeft = global::app.Properties.Resources.user;
            this.FormPanelTextBoxLogin.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.FormPanelTextBoxLogin.IconLeftSize = new System.Drawing.Size(25, 25);
            this.FormPanelTextBoxLogin.Location = new System.Drawing.Point(84, 127);
            this.FormPanelTextBoxLogin.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.FormPanelTextBoxLogin.Name = "FormPanelTextBoxLogin";
            this.FormPanelTextBoxLogin.PasswordChar = '\0';
            this.FormPanelTextBoxLogin.PlaceholderForeColor = System.Drawing.Color.Black;
            this.FormPanelTextBoxLogin.PlaceholderText = "Логин";
            this.FormPanelTextBoxLogin.SelectedText = "";
            this.FormPanelTextBoxLogin.Size = new System.Drawing.Size(333, 55);
            this.FormPanelTextBoxLogin.TabIndex = 6;
            this.FormPanelTextBoxLogin.TextOffset = new System.Drawing.Point(10, 0);
            this.FormPanelTextBoxLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormPanelTextBoxLogin_KeyDown);
            // 
            // FormPanelLabel
            // 
            this.FormPanelLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FormPanelLabel.BackColor = System.Drawing.Color.Transparent;
            this.FormPanelLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.FormPanelLabel.Location = new System.Drawing.Point(103, 50);
            this.FormPanelLabel.Name = "FormPanelLabel";
            this.FormPanelLabel.Size = new System.Drawing.Size(308, 47);
            this.FormPanelLabel.TabIndex = 5;
            this.FormPanelLabel.Text = "Добро пожаловать";
            // 
            // Авторизация
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 750);
            this.Controls.Add(this.FormPanel);
            this.Controls.Add(this.HeaderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Авторизация";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.Авторизация_Resize);
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            this.FormPanel.ResumeLayout(false);
            this.FormPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Panel HeaderPanel;
        private Guna.UI2.WinForms.Guna2Button IconClose;
        private Guna.UI2.WinForms.Guna2Button IconMaximized;
        private Guna.UI2.WinForms.Guna2Button IconMinimized;
        private Guna.UI2.WinForms.Guna2HtmlLabel HeaderPanelLabel;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Panel FormPanel;
        private Guna.UI2.WinForms.Guna2TextBox FormPanelTextBoxPassword;
        private Guna.UI2.WinForms.Guna2TextBox FormPanelTextBoxLogin;
        private Guna.UI2.WinForms.Guna2HtmlLabel FormPanelLabel;
        private Guna.UI2.WinForms.Guna2GradientButton FormPanelButtonEnterance;
    }
}

