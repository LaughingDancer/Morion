namespace app.UserControlsStatistics
{
    partial class UC_Статистика
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.Charts.WinForms.ChartFont chartFont9 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.ChartFont chartFont10 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.ChartFont chartFont11 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.ChartFont chartFont12 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Grid grid4 = new Guna.Charts.WinForms.Grid();
            Guna.Charts.WinForms.Tick tick4 = new Guna.Charts.WinForms.Tick();
            Guna.Charts.WinForms.ChartFont chartFont13 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Grid grid5 = new Guna.Charts.WinForms.Grid();
            Guna.Charts.WinForms.Tick tick5 = new Guna.Charts.WinForms.Tick();
            Guna.Charts.WinForms.ChartFont chartFont14 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Grid grid6 = new Guna.Charts.WinForms.Grid();
            Guna.Charts.WinForms.PointLabel pointLabel2 = new Guna.Charts.WinForms.PointLabel();
            Guna.Charts.WinForms.ChartFont chartFont15 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Tick tick6 = new Guna.Charts.WinForms.Tick();
            Guna.Charts.WinForms.ChartFont chartFont16 = new Guna.Charts.WinForms.ChartFont();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.gunaChart1 = new Guna.Charts.WinForms.GunaChart();
            this.ButtonChartHorizontalBar = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonChartPie = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonChartBar = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1118, 50);
            this.guna2Panel2.TabIndex = 17;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(470, 0);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(178, 39);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Статистика";
            // 
            // gunaChart1
            // 
            this.gunaChart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartFont9.FontName = "Arial";
            this.gunaChart1.Legend.LabelFont = chartFont9;
            this.gunaChart1.Location = new System.Drawing.Point(0, 50);
            this.gunaChart1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.gunaChart1.Name = "gunaChart1";
            this.gunaChart1.Size = new System.Drawing.Size(1118, 455);
            this.gunaChart1.TabIndex = 18;
            chartFont10.FontName = "Arial";
            chartFont10.Size = 12;
            chartFont10.Style = Guna.Charts.WinForms.ChartFontStyle.Bold;
            this.gunaChart1.Title.Font = chartFont10;
            chartFont11.FontName = "Arial";
            this.gunaChart1.Tooltips.BodyFont = chartFont11;
            chartFont12.FontName = "Arial";
            chartFont12.Size = 9;
            chartFont12.Style = Guna.Charts.WinForms.ChartFontStyle.Bold;
            this.gunaChart1.Tooltips.TitleFont = chartFont12;
            this.gunaChart1.XAxes.GridLines = grid4;
            chartFont13.FontName = "Arial";
            tick4.Font = chartFont13;
            this.gunaChart1.XAxes.Ticks = tick4;
            this.gunaChart1.YAxes.GridLines = grid5;
            chartFont14.FontName = "Arial";
            tick5.Font = chartFont14;
            this.gunaChart1.YAxes.Ticks = tick5;
            this.gunaChart1.ZAxes.GridLines = grid6;
            chartFont15.FontName = "Arial";
            pointLabel2.Font = chartFont15;
            this.gunaChart1.ZAxes.PointLabels = pointLabel2;
            chartFont16.FontName = "Arial";
            tick6.Font = chartFont16;
            this.gunaChart1.ZAxes.Ticks = tick6;
            // 
            // ButtonChartHorizontalBar
            // 
            this.ButtonChartHorizontalBar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ButtonChartHorizontalBar.BackColor = System.Drawing.Color.Transparent;
            this.ButtonChartHorizontalBar.BorderRadius = 10;
            this.ButtonChartHorizontalBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonChartHorizontalBar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonChartHorizontalBar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonChartHorizontalBar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonChartHorizontalBar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonChartHorizontalBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ButtonChartHorizontalBar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.ButtonChartHorizontalBar.ForeColor = System.Drawing.Color.White;
            this.ButtonChartHorizontalBar.Location = new System.Drawing.Point(280, 525);
            this.ButtonChartHorizontalBar.Margin = new System.Windows.Forms.Padding(10, 0, 10, 20);
            this.ButtonChartHorizontalBar.Name = "ButtonChartHorizontalBar";
            this.ButtonChartHorizontalBar.Size = new System.Drawing.Size(250, 50);
            this.ButtonChartHorizontalBar.TabIndex = 27;
            this.ButtonChartHorizontalBar.Text = "Отходы";
            this.ButtonChartHorizontalBar.UseTransparentBackground = true;
            this.ButtonChartHorizontalBar.Click += new System.EventHandler(this.ButtonChartPie_Click);
            // 
            // ButtonChartPie
            // 
            this.ButtonChartPie.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ButtonChartPie.BackColor = System.Drawing.Color.Transparent;
            this.ButtonChartPie.BorderRadius = 10;
            this.ButtonChartPie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonChartPie.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonChartPie.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonChartPie.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonChartPie.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonChartPie.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ButtonChartPie.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.ButtonChartPie.ForeColor = System.Drawing.Color.White;
            this.ButtonChartPie.Location = new System.Drawing.Point(550, 525);
            this.ButtonChartPie.Margin = new System.Windows.Forms.Padding(10, 0, 10, 20);
            this.ButtonChartPie.Name = "ButtonChartPie";
            this.ButtonChartPie.Size = new System.Drawing.Size(250, 50);
            this.ButtonChartPie.TabIndex = 28;
            this.ButtonChartPie.Text = "Расход Ткани";
            this.ButtonChartPie.UseTransparentBackground = true;
            this.ButtonChartPie.Click += new System.EventHandler(this.ButtonChartPie_Click_1);
            // 
            // ButtonChartBar
            // 
            this.ButtonChartBar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ButtonChartBar.BackColor = System.Drawing.Color.Transparent;
            this.ButtonChartBar.BorderRadius = 10;
            this.ButtonChartBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonChartBar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonChartBar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonChartBar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonChartBar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonChartBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ButtonChartBar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.ButtonChartBar.ForeColor = System.Drawing.Color.White;
            this.ButtonChartBar.Location = new System.Drawing.Point(10, 525);
            this.ButtonChartBar.Margin = new System.Windows.Forms.Padding(10, 0, 10, 20);
            this.ButtonChartBar.Name = "ButtonChartBar";
            this.ButtonChartBar.Size = new System.Drawing.Size(250, 50);
            this.ButtonChartBar.TabIndex = 30;
            this.ButtonChartBar.Text = "Заказанные Изделия";
            this.ButtonChartBar.UseTransparentBackground = true;
            this.ButtonChartBar.Click += new System.EventHandler(this.ButtonChartBar_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(820, 525);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 20);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(250, 50);
            this.guna2Button1.TabIndex = 31;
            this.guna2Button1.Text = "Бригады";
            this.guna2Button1.UseTransparentBackground = true;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // UC_Статистика
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.ButtonChartBar);
            this.Controls.Add(this.ButtonChartPie);
            this.Controls.Add(this.ButtonChartHorizontalBar);
            this.Controls.Add(this.gunaChart1);
            this.Controls.Add(this.guna2Panel2);
            this.Name = "UC_Статистика";
            this.Size = new System.Drawing.Size(1118, 595);
            this.Load += new System.EventHandler(this.UC_Статистика_Load);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.Charts.WinForms.GunaChart gunaChart1;
        private Guna.UI2.WinForms.Guna2Button ButtonChartHorizontalBar;
        private Guna.UI2.WinForms.Guna2Button ButtonChartPie;
        private Guna.UI2.WinForms.Guna2Button ButtonChartBar;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}
