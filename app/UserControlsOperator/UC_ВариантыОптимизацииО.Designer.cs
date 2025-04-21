namespace app.UserControlsOperator
{
    partial class UC_ВариантыОптимизацииО
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.comboBoxPostSearch = new Guna.UI2.WinForms.Guna2ComboBox();
            this.searchTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.DataGridViewOptimizationOptions = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ButtonExcel = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewOptimizationOptions)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(900, 50);
            this.guna2Panel2.TabIndex = 14;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(349, 0);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(202, 39);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Оптимизация";
            // 
            // comboBoxPostSearch
            // 
            this.comboBoxPostSearch.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxPostSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(10)))));
            this.comboBoxPostSearch.BorderRadius = 10;
            this.comboBoxPostSearch.BorderThickness = 2;
            this.comboBoxPostSearch.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxPostSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPostSearch.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(10)))));
            this.comboBoxPostSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(10)))));
            this.comboBoxPostSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.comboBoxPostSearch.ForeColor = System.Drawing.Color.Black;
            this.comboBoxPostSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(10)))));
            this.comboBoxPostSearch.ItemHeight = 44;
            this.comboBoxPostSearch.Items.AddRange(new object[] {
            "Швея",
            "Оператор",
            "Специалист КБД"});
            this.comboBoxPostSearch.Location = new System.Drawing.Point(330, 70);
            this.comboBoxPostSearch.Margin = new System.Windows.Forms.Padding(0, 3, 3, 0);
            this.comboBoxPostSearch.Name = "comboBoxPostSearch";
            this.comboBoxPostSearch.Size = new System.Drawing.Size(300, 50);
            this.comboBoxPostSearch.TabIndex = 54;
            this.comboBoxPostSearch.SelectedIndexChanged += new System.EventHandler(this.comboBoxPostSearch_SelectedIndexChanged);
            // 
            // searchTextBox
            // 
            this.searchTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(10)))));
            this.searchTextBox.BorderRadius = 10;
            this.searchTextBox.BorderThickness = 2;
            this.searchTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchTextBox.DefaultText = "";
            this.searchTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(10)))));
            this.searchTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.searchTextBox.ForeColor = System.Drawing.Color.Black;
            this.searchTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(10)))));
            this.searchTextBox.Location = new System.Drawing.Point(20, 70);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 10, 20);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.PlaceholderText = "Поиск";
            this.searchTextBox.SelectedText = "";
            this.searchTextBox.Size = new System.Drawing.Size(300, 50);
            this.searchTextBox.TabIndex = 53;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // DataGridViewOptimizationOptions
            // 
            this.DataGridViewOptimizationOptions.AllowUserToAddRows = false;
            this.DataGridViewOptimizationOptions.AllowUserToDeleteRows = false;
            this.DataGridViewOptimizationOptions.AllowUserToResizeColumns = false;
            this.DataGridViewOptimizationOptions.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(69)))), ((int)(((byte)(103)))));
            this.DataGridViewOptimizationOptions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewOptimizationOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridViewOptimizationOptions.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(90)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(90)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewOptimizationOptions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewOptimizationOptions.ColumnHeadersHeight = 40;
            this.DataGridViewOptimizationOptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridViewOptimizationOptions.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(69)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(69)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewOptimizationOptions.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridViewOptimizationOptions.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(10)))));
            this.DataGridViewOptimizationOptions.Location = new System.Drawing.Point(20, 140);
            this.DataGridViewOptimizationOptions.Margin = new System.Windows.Forms.Padding(0);
            this.DataGridViewOptimizationOptions.Name = "DataGridViewOptimizationOptions";
            this.DataGridViewOptimizationOptions.ReadOnly = true;
            this.DataGridViewOptimizationOptions.RowHeadersVisible = false;
            this.DataGridViewOptimizationOptions.RowHeadersWidth = 60;
            this.DataGridViewOptimizationOptions.RowTemplate.Height = 60;
            this.DataGridViewOptimizationOptions.Size = new System.Drawing.Size(860, 440);
            this.DataGridViewOptimizationOptions.TabIndex = 52;
            this.DataGridViewOptimizationOptions.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(69)))), ((int)(((byte)(103)))));
            this.DataGridViewOptimizationOptions.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridViewOptimizationOptions.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridViewOptimizationOptions.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridViewOptimizationOptions.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridViewOptimizationOptions.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(235)))));
            this.DataGridViewOptimizationOptions.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(10)))));
            this.DataGridViewOptimizationOptions.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(90)))), ((int)(((byte)(0)))));
            this.DataGridViewOptimizationOptions.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridViewOptimizationOptions.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DataGridViewOptimizationOptions.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridViewOptimizationOptions.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridViewOptimizationOptions.ThemeStyle.HeaderStyle.Height = 40;
            this.DataGridViewOptimizationOptions.ThemeStyle.ReadOnly = true;
            this.DataGridViewOptimizationOptions.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(69)))), ((int)(((byte)(103)))));
            this.DataGridViewOptimizationOptions.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewOptimizationOptions.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DataGridViewOptimizationOptions.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridViewOptimizationOptions.ThemeStyle.RowsStyle.Height = 60;
            this.DataGridViewOptimizationOptions.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(69)))), ((int)(((byte)(103)))));
            this.DataGridViewOptimizationOptions.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // ButtonExcel
            // 
            this.ButtonExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonExcel.BackColor = System.Drawing.Color.Transparent;
            this.ButtonExcel.BorderRadius = 10;
            this.ButtonExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonExcel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonExcel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonExcel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonExcel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonExcel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(115)))), ((int)(((byte)(70)))));
            this.ButtonExcel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.ButtonExcel.ForeColor = System.Drawing.Color.White;
            this.ButtonExcel.Image = global::app.Properties.Resources.excel;
            this.ButtonExcel.ImageSize = new System.Drawing.Size(50, 50);
            this.ButtonExcel.Location = new System.Drawing.Point(680, 70);
            this.ButtonExcel.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonExcel.Name = "ButtonExcel";
            this.ButtonExcel.Size = new System.Drawing.Size(200, 50);
            this.ButtonExcel.TabIndex = 55;
            this.ButtonExcel.UseTransparentBackground = true;
            this.ButtonExcel.Click += new System.EventHandler(this.ButtonExcel_Click);
            // 
            // UC_ВариантыОптимизацииО
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ButtonExcel);
            this.Controls.Add(this.comboBoxPostSearch);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.DataGridViewOptimizationOptions);
            this.Controls.Add(this.guna2Panel2);
            this.Name = "UC_ВариантыОптимизацииО";
            this.Size = new System.Drawing.Size(900, 600);
            this.Load += new System.EventHandler(this.UC_ВариантыОптимизацииО_Load);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewOptimizationOptions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button ButtonExcel;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxPostSearch;
        private Guna.UI2.WinForms.Guna2TextBox searchTextBox;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridViewOptimizationOptions;
    }
}
