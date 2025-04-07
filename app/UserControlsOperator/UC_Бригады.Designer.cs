namespace app.UserControlsOperator
{
    partial class UC_Бригады
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
            this.comboBoxBrigadeSearch = new Guna.UI2.WinForms.Guna2ComboBox();
            this.searchTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.DataGridViewBrigade = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ButtonExcel = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonSaveOrder = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewBrigade)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxBrigadeSearch
            // 
            this.comboBoxBrigadeSearch.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxBrigadeSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(10)))));
            this.comboBoxBrigadeSearch.BorderRadius = 10;
            this.comboBoxBrigadeSearch.BorderThickness = 2;
            this.comboBoxBrigadeSearch.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxBrigadeSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBrigadeSearch.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(10)))));
            this.comboBoxBrigadeSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(10)))));
            this.comboBoxBrigadeSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.comboBoxBrigadeSearch.ForeColor = System.Drawing.Color.Black;
            this.comboBoxBrigadeSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(10)))));
            this.comboBoxBrigadeSearch.ItemHeight = 44;
            this.comboBoxBrigadeSearch.Location = new System.Drawing.Point(327, 70);
            this.comboBoxBrigadeSearch.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.comboBoxBrigadeSearch.Name = "comboBoxBrigadeSearch";
            this.comboBoxBrigadeSearch.Size = new System.Drawing.Size(300, 50);
            this.comboBoxBrigadeSearch.TabIndex = 28;
            this.comboBoxBrigadeSearch.SelectedIndexChanged += new System.EventHandler(this.comboBoxBridageSearch_SelectedIndexChanged);
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
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.PasswordChar = '\0';
            this.searchTextBox.PlaceholderText = "Поиск";
            this.searchTextBox.SelectedText = "";
            this.searchTextBox.Size = new System.Drawing.Size(300, 50);
            this.searchTextBox.TabIndex = 27;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // DataGridViewBrigade
            // 
            this.DataGridViewBrigade.AllowUserToAddRows = false;
            this.DataGridViewBrigade.AllowUserToDeleteRows = false;
            this.DataGridViewBrigade.AllowUserToResizeColumns = false;
            this.DataGridViewBrigade.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(69)))), ((int)(((byte)(103)))));
            this.DataGridViewBrigade.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewBrigade.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridViewBrigade.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(90)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(90)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewBrigade.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewBrigade.ColumnHeadersHeight = 40;
            this.DataGridViewBrigade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridViewBrigade.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(69)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(69)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewBrigade.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridViewBrigade.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(10)))));
            this.DataGridViewBrigade.Location = new System.Drawing.Point(20, 142);
            this.DataGridViewBrigade.Margin = new System.Windows.Forms.Padding(0, 0, 20, 20);
            this.DataGridViewBrigade.Name = "DataGridViewBrigade";
            this.DataGridViewBrigade.ReadOnly = true;
            this.DataGridViewBrigade.RowHeadersVisible = false;
            this.DataGridViewBrigade.RowHeadersWidth = 60;
            this.DataGridViewBrigade.RowTemplate.Height = 60;
            this.DataGridViewBrigade.Size = new System.Drawing.Size(1260, 498);
            this.DataGridViewBrigade.TabIndex = 26;
            this.DataGridViewBrigade.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(69)))), ((int)(((byte)(103)))));
            this.DataGridViewBrigade.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridViewBrigade.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridViewBrigade.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridViewBrigade.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridViewBrigade.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(235)))));
            this.DataGridViewBrigade.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(10)))));
            this.DataGridViewBrigade.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(90)))), ((int)(((byte)(0)))));
            this.DataGridViewBrigade.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridViewBrigade.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DataGridViewBrigade.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridViewBrigade.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridViewBrigade.ThemeStyle.HeaderStyle.Height = 40;
            this.DataGridViewBrigade.ThemeStyle.ReadOnly = true;
            this.DataGridViewBrigade.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(69)))), ((int)(((byte)(103)))));
            this.DataGridViewBrigade.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewBrigade.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DataGridViewBrigade.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridViewBrigade.ThemeStyle.RowsStyle.Height = 60;
            this.DataGridViewBrigade.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(69)))), ((int)(((byte)(103)))));
            this.DataGridViewBrigade.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.DataGridViewBrigade.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewBrigade_CellClick);
            this.DataGridViewBrigade.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewBrigade_CellMouseEnter);
            this.DataGridViewBrigade.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewBrigade_CellMouseLeave);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel2);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1300, 50);
            this.guna2Panel1.TabIndex = 25;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(585, 0);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(130, 39);
            this.guna2HtmlLabel2.TabIndex = 0;
            this.guna2HtmlLabel2.Text = "Бригады";
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
            this.ButtonExcel.Location = new System.Drawing.Point(870, 70);
            this.ButtonExcel.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonExcel.Name = "ButtonExcel";
            this.ButtonExcel.Size = new System.Drawing.Size(200, 50);
            this.ButtonExcel.TabIndex = 35;
            this.ButtonExcel.UseTransparentBackground = true;
            this.ButtonExcel.Click += new System.EventHandler(this.ButtonExcel_Click);
            // 
            // ButtonSaveOrder
            // 
            this.ButtonSaveOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSaveOrder.BackColor = System.Drawing.Color.Transparent;
            this.ButtonSaveOrder.BorderRadius = 10;
            this.ButtonSaveOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSaveOrder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonSaveOrder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonSaveOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonSaveOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonSaveOrder.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.ButtonSaveOrder.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.ButtonSaveOrder.ForeColor = System.Drawing.Color.White;
            this.ButtonSaveOrder.Location = new System.Drawing.Point(1080, 70);
            this.ButtonSaveOrder.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ButtonSaveOrder.Name = "ButtonSaveOrder";
            this.ButtonSaveOrder.Size = new System.Drawing.Size(200, 50);
            this.ButtonSaveOrder.TabIndex = 34;
            this.ButtonSaveOrder.Text = "Создать";
            this.ButtonSaveOrder.UseTransparentBackground = true;
            this.ButtonSaveOrder.Click += new System.EventHandler(this.ButtonSaveOrder_Click);
            // 
            // UC_Бригады
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ButtonExcel);
            this.Controls.Add(this.ButtonSaveOrder);
            this.Controls.Add(this.comboBoxBrigadeSearch);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.DataGridViewBrigade);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "UC_Бригады";
            this.Size = new System.Drawing.Size(1300, 660);
            this.Load += new System.EventHandler(this.UC_Бригады_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewBrigade)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox comboBoxBrigadeSearch;
        private Guna.UI2.WinForms.Guna2TextBox searchTextBox;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridViewBrigade;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2Button ButtonExcel;
        private Guna.UI2.WinForms.Guna2Button ButtonSaveOrder;
    }
}
