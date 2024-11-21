namespace app
{
    partial class ГлавнаяА
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ГлавнаяА));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.HeaderPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.IconMinimized = new Guna.UI2.WinForms.Guna2Button();
            this.IconMaximized = new Guna.UI2.WinForms.Guna2Button();
            this.IconClose = new Guna.UI2.WinForms.Guna2Button();
            this.MainPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.menuChart = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button22 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button21 = new Guna.UI2.WinForms.Guna2Button();
            this.MainPanelMenuContainer1 = new System.Windows.Forms.FlowLayoutPanel();
            this.menuTable = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button10 = new Guna.UI2.WinForms.Guna2Button();
            this.HomeButton = new Guna.UI2.WinForms.Guna2Button();
            this.menuTransitionOne = new System.Windows.Forms.Timer(this.components);
            this.DesktopPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.HeaderPanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.MainPanelMenuContainer1.SuspendLayout();
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
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.HeaderPanel;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.Controls.Add(this.IconMinimized);
            this.HeaderPanel.Controls.Add(this.IconMaximized);
            this.HeaderPanel.Controls.Add(this.IconClose);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.HeaderPanel.Location = new System.Drawing.Point(300, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(1300, 40);
            this.HeaderPanel.TabIndex = 1;
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
            this.IconMinimized.Location = new System.Drawing.Point(1180, 0);
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
            this.IconMaximized.Location = new System.Drawing.Point(1220, 0);
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
            this.IconClose.Location = new System.Drawing.Point(1260, 0);
            this.IconClose.Name = "IconClose";
            this.IconClose.Size = new System.Drawing.Size(40, 40);
            this.IconClose.TabIndex = 0;
            this.IconClose.UseTransparentBackground = true;
            this.IconClose.Click += new System.EventHandler(this.IconClose_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.AutoScroll = true;
            this.MainPanel.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.MainPanel.Controls.Add(this.guna2Button1);
            this.MainPanel.Controls.Add(this.menuChart);
            this.MainPanel.Controls.Add(this.guna2Button22);
            this.MainPanel.Controls.Add(this.guna2Button21);
            this.MainPanel.Controls.Add(this.MainPanelMenuContainer1);
            this.MainPanel.Controls.Add(this.HomeButton);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MainPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(300, 700);
            this.MainPanel.TabIndex = 0;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.guna2Button1.Image = global::app.Properties.Resources.database;
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2Button1.Location = new System.Drawing.Point(0, 305);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(0);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(300, 75);
            this.guna2Button1.TabIndex = 8;
            this.guna2Button1.Text = "Журнал и бэкап";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // menuChart
            // 
            this.menuChart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuChart.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.menuChart.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.menuChart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.menuChart.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.menuChart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.menuChart.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuChart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.menuChart.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.menuChart.ForeColor = System.Drawing.Color.White;
            this.menuChart.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.menuChart.Image = global::app.Properties.Resources.pie_chart;
            this.menuChart.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.menuChart.ImageSize = new System.Drawing.Size(40, 40);
            this.menuChart.Location = new System.Drawing.Point(0, 230);
            this.menuChart.Margin = new System.Windows.Forms.Padding(0);
            this.menuChart.Name = "menuChart";
            this.menuChart.Size = new System.Drawing.Size(300, 75);
            this.menuChart.TabIndex = 7;
            this.menuChart.Text = "Статистика";
            this.menuChart.Click += new System.EventHandler(this.menuChart_Click);
            // 
            // guna2Button22
            // 
            this.guna2Button22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button22.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button22.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button22.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button22.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button22.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Button22.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.guna2Button22.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.guna2Button22.ForeColor = System.Drawing.Color.White;
            this.guna2Button22.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(36)))), ((int)(((byte)(20)))));
            this.guna2Button22.Image = global::app.Properties.Resources.exit;
            this.guna2Button22.Location = new System.Drawing.Point(0, 625);
            this.guna2Button22.Name = "guna2Button22";
            this.guna2Button22.Size = new System.Drawing.Size(300, 75);
            this.guna2Button22.TabIndex = 6;
            this.guna2Button22.Text = "Выход";
            this.guna2Button22.Click += new System.EventHandler(this.guna2Button22_Click);
            // 
            // guna2Button21
            // 
            this.guna2Button21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button21.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.guna2Button21.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button21.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button21.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button21.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button21.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Button21.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.guna2Button21.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.guna2Button21.ForeColor = System.Drawing.Color.White;
            this.guna2Button21.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.guna2Button21.Image = global::app.Properties.Resources.teamwork;
            this.guna2Button21.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button21.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2Button21.Location = new System.Drawing.Point(0, 155);
            this.guna2Button21.Name = "guna2Button21";
            this.guna2Button21.Size = new System.Drawing.Size(300, 75);
            this.guna2Button21.TabIndex = 2;
            this.guna2Button21.Text = "Персонал";
            this.guna2Button21.Click += new System.EventHandler(this.guna2Button21_Click);
            // 
            // MainPanelMenuContainer1
            // 
            this.MainPanelMenuContainer1.Controls.Add(this.menuTable);
            this.MainPanelMenuContainer1.Controls.Add(this.guna2Button2);
            this.MainPanelMenuContainer1.Controls.Add(this.guna2Button4);
            this.MainPanelMenuContainer1.Controls.Add(this.guna2Button5);
            this.MainPanelMenuContainer1.Controls.Add(this.guna2Button10);
            this.MainPanelMenuContainer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainPanelMenuContainer1.Location = new System.Drawing.Point(0, 80);
            this.MainPanelMenuContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.MainPanelMenuContainer1.Name = "MainPanelMenuContainer1";
            this.MainPanelMenuContainer1.Size = new System.Drawing.Size(300, 75);
            this.MainPanelMenuContainer1.TabIndex = 0;
            // 
            // menuTable
            // 
            this.menuTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuTable.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.menuTable.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.menuTable.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.menuTable.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.menuTable.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.menuTable.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.menuTable.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.menuTable.ForeColor = System.Drawing.Color.White;
            this.menuTable.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.menuTable.Image = global::app.Properties.Resources.spreadsheet;
            this.menuTable.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.menuTable.ImageSize = new System.Drawing.Size(40, 40);
            this.menuTable.Location = new System.Drawing.Point(0, 0);
            this.menuTable.Margin = new System.Windows.Forms.Padding(0);
            this.menuTable.Name = "menuTable";
            this.menuTable.Size = new System.Drawing.Size(300, 75);
            this.menuTable.TabIndex = 7;
            this.menuTable.Text = "Таблицы";
            this.menuTable.Click += new System.EventHandler(this.menuTable_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button2.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(10)))));
            this.guna2Button2.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(61)))), ((int)(((byte)(81)))));
            this.guna2Button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button2.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(61)))), ((int)(((byte)(81)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(10)))));
            this.guna2Button2.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(61)))), ((int)(((byte)(81)))));
            this.guna2Button2.Location = new System.Drawing.Point(0, 75);
            this.guna2Button2.Margin = new System.Windows.Forms.Padding(0);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(300, 75);
            this.guna2Button2.TabIndex = 1;
            this.guna2Button2.Text = "Варианты оптимизации";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2Button4
            // 
            this.guna2Button4.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button4.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(10)))));
            this.guna2Button4.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(61)))), ((int)(((byte)(81)))));
            this.guna2Button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button4.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(61)))), ((int)(((byte)(81)))));
            this.guna2Button4.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(10)))));
            this.guna2Button4.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(61)))), ((int)(((byte)(81)))));
            this.guna2Button4.Location = new System.Drawing.Point(0, 150);
            this.guna2Button4.Margin = new System.Windows.Forms.Padding(0);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.Size = new System.Drawing.Size(300, 75);
            this.guna2Button4.TabIndex = 3;
            this.guna2Button4.Text = "Заказы";
            this.guna2Button4.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // guna2Button5
            // 
            this.guna2Button5.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button5.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(10)))));
            this.guna2Button5.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(61)))), ((int)(((byte)(81)))));
            this.guna2Button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button5.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(61)))), ((int)(((byte)(81)))));
            this.guna2Button5.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.guna2Button5.ForeColor = System.Drawing.Color.White;
            this.guna2Button5.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(10)))));
            this.guna2Button5.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(61)))), ((int)(((byte)(81)))));
            this.guna2Button5.Location = new System.Drawing.Point(0, 225);
            this.guna2Button5.Margin = new System.Windows.Forms.Padding(0);
            this.guna2Button5.Name = "guna2Button5";
            this.guna2Button5.Size = new System.Drawing.Size(300, 75);
            this.guna2Button5.TabIndex = 4;
            this.guna2Button5.Text = "Изделия";
            this.guna2Button5.Click += new System.EventHandler(this.guna2Button5_Click);
            // 
            // guna2Button10
            // 
            this.guna2Button10.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button10.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(10)))));
            this.guna2Button10.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(61)))), ((int)(((byte)(81)))));
            this.guna2Button10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button10.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.guna2Button10.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button10.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button10.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button10.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(61)))), ((int)(((byte)(81)))));
            this.guna2Button10.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.guna2Button10.ForeColor = System.Drawing.Color.White;
            this.guna2Button10.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(10)))));
            this.guna2Button10.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(61)))), ((int)(((byte)(81)))));
            this.guna2Button10.Location = new System.Drawing.Point(0, 300);
            this.guna2Button10.Margin = new System.Windows.Forms.Padding(0);
            this.guna2Button10.Name = "guna2Button10";
            this.guna2Button10.Size = new System.Drawing.Size(300, 75);
            this.guna2Button10.TabIndex = 9;
            this.guna2Button10.Text = "Ткани";
            this.guna2Button10.Click += new System.EventHandler(this.guna2Button10_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HomeButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.HomeButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.HomeButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.HomeButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.HomeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.HomeButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.HomeButton.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.HomeButton.ForeColor = System.Drawing.Color.White;
            this.HomeButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.HomeButton.Image = global::app.Properties.Resources.Logo;
            this.HomeButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.HomeButton.ImageSize = new System.Drawing.Size(50, 50);
            this.HomeButton.Location = new System.Drawing.Point(0, 0);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(300, 80);
            this.HomeButton.TabIndex = 0;
            this.HomeButton.Text = "Морион";
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // menuTransitionOne
            // 
            this.menuTransitionOne.Interval = 10;
            this.menuTransitionOne.Tick += new System.EventHandler(this.menuTransitionOne_Tick);
            // 
            // DesktopPanel
            // 
            this.DesktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DesktopPanel.Location = new System.Drawing.Point(300, 40);
            this.DesktopPanel.Name = "DesktopPanel";
            this.DesktopPanel.Size = new System.Drawing.Size(1300, 660);
            this.DesktopPanel.TabIndex = 4;
            // 
            // ГлавнаяА
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 700);
            this.Controls.Add(this.DesktopPanel);
            this.Controls.Add(this.HeaderPanel);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1600, 700);
            this.Name = "ГлавнаяА";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Resize += new System.EventHandler(this.Главная_Resize);
            this.HeaderPanel.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.MainPanelMenuContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Panel MainPanel;
        private System.Windows.Forms.FlowLayoutPanel MainPanelMenuContainer1;
        private Guna.UI2.WinForms.Guna2Button HomeButton;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private Guna.UI2.WinForms.Guna2Button menuTable;
        private Guna.UI2.WinForms.Guna2Button guna2Button10;
        private Guna.UI2.WinForms.Guna2Panel HeaderPanel;
        private Guna.UI2.WinForms.Guna2Button IconMinimized;
        private Guna.UI2.WinForms.Guna2Button IconMaximized;
        private Guna.UI2.WinForms.Guna2Button IconClose;
        private Guna.UI2.WinForms.Guna2Button guna2Button22;
        private Guna.UI2.WinForms.Guna2Button guna2Button21;
        private System.Windows.Forms.Timer menuTransitionOne;
        private Guna.UI2.WinForms.Guna2Panel DesktopPanel;
        private Guna.UI2.WinForms.Guna2Button menuChart;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}