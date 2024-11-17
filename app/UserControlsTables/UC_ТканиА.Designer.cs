namespace app.UserControls
{
    partial class UC_ТканиА
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.comboBoxPostSearch = new Guna.UI2.WinForms.Guna2ComboBox();
            this.searchTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.DataGridViewPeople = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ButtonExcel = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1092, 50);
            this.guna2Panel2.TabIndex = 16;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(500, 0);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(93, 39);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Ткани";
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
            this.comboBoxPostSearch.Location = new System.Drawing.Point(327, 72);
            this.comboBoxPostSearch.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.comboBoxPostSearch.Name = "comboBoxPostSearch";
            this.comboBoxPostSearch.Size = new System.Drawing.Size(300, 50);
            this.comboBoxPostSearch.TabIndex = 31;
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
            this.searchTextBox.Location = new System.Drawing.Point(20, 72);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.PasswordChar = '\0';
            this.searchTextBox.PlaceholderText = "Поиск";
            this.searchTextBox.SelectedText = "";
            this.searchTextBox.Size = new System.Drawing.Size(300, 50);
            this.searchTextBox.TabIndex = 29;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // DataGridViewPeople
            // 
            this.DataGridViewPeople.AllowUserToAddRows = false;
            this.DataGridViewPeople.AllowUserToDeleteRows = false;
            this.DataGridViewPeople.AllowUserToResizeColumns = false;
            this.DataGridViewPeople.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(69)))), ((int)(((byte)(103)))));
            this.DataGridViewPeople.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.DataGridViewPeople.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridViewPeople.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(124)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(90)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(90)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewPeople.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.DataGridViewPeople.ColumnHeadersHeight = 40;
            this.DataGridViewPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridViewPeople.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(69)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(69)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewPeople.DefaultCellStyle = dataGridViewCellStyle12;
            this.DataGridViewPeople.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(10)))));
            this.DataGridViewPeople.Location = new System.Drawing.Point(20, 139);
            this.DataGridViewPeople.Margin = new System.Windows.Forms.Padding(0);
            this.DataGridViewPeople.Name = "DataGridViewPeople";
            this.DataGridViewPeople.ReadOnly = true;
            this.DataGridViewPeople.RowHeadersVisible = false;
            this.DataGridViewPeople.RowHeadersWidth = 60;
            this.DataGridViewPeople.RowTemplate.Height = 60;
            this.DataGridViewPeople.Size = new System.Drawing.Size(1052, 421);
            this.DataGridViewPeople.TabIndex = 28;
            this.DataGridViewPeople.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(69)))), ((int)(((byte)(103)))));
            this.DataGridViewPeople.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridViewPeople.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridViewPeople.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridViewPeople.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridViewPeople.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(124)))), ((int)(((byte)(185)))));
            this.DataGridViewPeople.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(10)))));
            this.DataGridViewPeople.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(90)))), ((int)(((byte)(0)))));
            this.DataGridViewPeople.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridViewPeople.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DataGridViewPeople.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridViewPeople.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridViewPeople.ThemeStyle.HeaderStyle.Height = 40;
            this.DataGridViewPeople.ThemeStyle.ReadOnly = true;
            this.DataGridViewPeople.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(69)))), ((int)(((byte)(103)))));
            this.DataGridViewPeople.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewPeople.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DataGridViewPeople.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridViewPeople.ThemeStyle.RowsStyle.Height = 60;
            this.DataGridViewPeople.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(69)))), ((int)(((byte)(103)))));
            this.DataGridViewPeople.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
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
            this.ButtonExcel.Location = new System.Drawing.Point(872, 72);
            this.ButtonExcel.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonExcel.Name = "ButtonExcel";
            this.ButtonExcel.Size = new System.Drawing.Size(200, 50);
            this.ButtonExcel.TabIndex = 32;
            this.ButtonExcel.UseTransparentBackground = true;
            this.ButtonExcel.Click += new System.EventHandler(this.ButtonExcel_Click);
            // 
            // UC_ТканиА
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ButtonExcel);
            this.Controls.Add(this.comboBoxPostSearch);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.DataGridViewPeople);
            this.Controls.Add(this.guna2Panel2);
            this.Name = "UC_ТканиА";
            this.Size = new System.Drawing.Size(1092, 560);
            this.Load += new System.EventHandler(this.UC_ТканиА_Load);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPeople)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxPostSearch;
        private Guna.UI2.WinForms.Guna2TextBox searchTextBox;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridViewPeople;
        private Guna.UI2.WinForms.Guna2Button ButtonExcel;
    }
}
