namespace app.Forms
{
    partial class ДобавлениеЗаказ
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
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.HeaderPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.HeaderPanelLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.IconClose = new Guna.UI2.WinForms.Guna2Button();
            this.buttonSave = new Guna.UI2.WinForms.Guna2Button();
            this.PictureBoxProductPhoto = new Guna.UI2.WinForms.Guna2PictureBox();
            this.СomboBoxSeamstress = new Guna.UI2.WinForms.Guna2ComboBox();
            this.TextBoxTotalCost = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxProductName = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxSize = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxWaste = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxWastePercentage = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxCreationDate = new Guna.UI2.WinForms.Guna2TextBox();
            this.HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxProductPhoto)).BeginInit();
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
            this.HeaderPanel.TabIndex = 33;
            // 
            // HeaderPanelLabel
            // 
            this.HeaderPanelLabel.BackColor = System.Drawing.Color.Transparent;
            this.HeaderPanelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HeaderPanelLabel.ForeColor = System.Drawing.Color.White;
            this.HeaderPanelLabel.Location = new System.Drawing.Point(12, 7);
            this.HeaderPanelLabel.Name = "HeaderPanelLabel";
            this.HeaderPanelLabel.Size = new System.Drawing.Size(225, 26);
            this.HeaderPanelLabel.TabIndex = 3;
            this.HeaderPanelLabel.Text = "Морион | Оформление";
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
            this.buttonSave.Location = new System.Drawing.Point(50, 730);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(350, 50);
            this.buttonSave.TabIndex = 38;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseTransparentBackground = true;
            // 
            // PictureBoxProductPhoto
            // 
            this.PictureBoxProductPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBoxProductPhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBoxProductPhoto.ImageRotate = 0F;
            this.PictureBoxProductPhoto.Location = new System.Drawing.Point(100, 54);
            this.PictureBoxProductPhoto.Margin = new System.Windows.Forms.Padding(0);
            this.PictureBoxProductPhoto.Name = "PictureBoxProductPhoto";
            this.PictureBoxProductPhoto.Size = new System.Drawing.Size(250, 200);
            this.PictureBoxProductPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxProductPhoto.TabIndex = 34;
            this.PictureBoxProductPhoto.TabStop = false;
            // 
            // СomboBoxSeamstress
            // 
            this.СomboBoxSeamstress.BackColor = System.Drawing.Color.Transparent;
            this.СomboBoxSeamstress.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(10)))));
            this.СomboBoxSeamstress.BorderRadius = 10;
            this.СomboBoxSeamstress.BorderThickness = 2;
            this.СomboBoxSeamstress.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.СomboBoxSeamstress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.СomboBoxSeamstress.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(10)))));
            this.СomboBoxSeamstress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(10)))));
            this.СomboBoxSeamstress.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.СomboBoxSeamstress.ForeColor = System.Drawing.Color.Black;
            this.СomboBoxSeamstress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(10)))));
            this.СomboBoxSeamstress.ItemHeight = 44;
            this.СomboBoxSeamstress.Location = new System.Drawing.Point(50, 266);
            this.СomboBoxSeamstress.Margin = new System.Windows.Forms.Padding(4);
            this.СomboBoxSeamstress.Name = "СomboBoxSeamstress";
            this.СomboBoxSeamstress.Size = new System.Drawing.Size(350, 50);
            this.СomboBoxSeamstress.TabIndex = 39;
            // 
            // TextBoxTotalCost
            // 
            this.TextBoxTotalCost.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(10)))));
            this.TextBoxTotalCost.BorderRadius = 10;
            this.TextBoxTotalCost.BorderThickness = 2;
            this.TextBoxTotalCost.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxTotalCost.DefaultText = "";
            this.TextBoxTotalCost.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxTotalCost.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxTotalCost.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxTotalCost.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxTotalCost.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(10)))));
            this.TextBoxTotalCost.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TextBoxTotalCost.ForeColor = System.Drawing.Color.Black;
            this.TextBoxTotalCost.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(10)))));
            this.TextBoxTotalCost.Location = new System.Drawing.Point(50, 324);
            this.TextBoxTotalCost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBoxTotalCost.Name = "TextBoxTotalCost";
            this.TextBoxTotalCost.PasswordChar = '\0';
            this.TextBoxTotalCost.PlaceholderText = "ОбщаяСтоимость";
            this.TextBoxTotalCost.SelectedText = "";
            this.TextBoxTotalCost.Size = new System.Drawing.Size(350, 50);
            this.TextBoxTotalCost.TabIndex = 37;
            this.TextBoxTotalCost.TabStop = false;
            // 
            // TextBoxProductName
            // 
            this.TextBoxProductName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(10)))));
            this.TextBoxProductName.BorderRadius = 10;
            this.TextBoxProductName.BorderThickness = 2;
            this.TextBoxProductName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxProductName.DefaultText = "";
            this.TextBoxProductName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxProductName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxProductName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxProductName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxProductName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(10)))));
            this.TextBoxProductName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TextBoxProductName.ForeColor = System.Drawing.Color.Black;
            this.TextBoxProductName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(10)))));
            this.TextBoxProductName.Location = new System.Drawing.Point(50, 382);
            this.TextBoxProductName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBoxProductName.Name = "TextBoxProductName";
            this.TextBoxProductName.PasswordChar = '\0';
            this.TextBoxProductName.PlaceholderText = "Изделие";
            this.TextBoxProductName.SelectedText = "";
            this.TextBoxProductName.Size = new System.Drawing.Size(350, 50);
            this.TextBoxProductName.TabIndex = 40;
            this.TextBoxProductName.TabStop = false;
            // 
            // TextBoxSize
            // 
            this.TextBoxSize.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(10)))));
            this.TextBoxSize.BorderRadius = 10;
            this.TextBoxSize.BorderThickness = 2;
            this.TextBoxSize.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxSize.DefaultText = "";
            this.TextBoxSize.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxSize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxSize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxSize.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxSize.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(10)))));
            this.TextBoxSize.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TextBoxSize.ForeColor = System.Drawing.Color.Black;
            this.TextBoxSize.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(10)))));
            this.TextBoxSize.Location = new System.Drawing.Point(50, 440);
            this.TextBoxSize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBoxSize.Name = "TextBoxSize";
            this.TextBoxSize.PasswordChar = '\0';
            this.TextBoxSize.PlaceholderText = "Размер";
            this.TextBoxSize.SelectedText = "";
            this.TextBoxSize.Size = new System.Drawing.Size(350, 50);
            this.TextBoxSize.TabIndex = 41;
            this.TextBoxSize.TabStop = false;
            // 
            // TextBoxQuantity
            // 
            this.TextBoxQuantity.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(10)))));
            this.TextBoxQuantity.BorderRadius = 10;
            this.TextBoxQuantity.BorderThickness = 2;
            this.TextBoxQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxQuantity.DefaultText = "";
            this.TextBoxQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(10)))));
            this.TextBoxQuantity.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TextBoxQuantity.ForeColor = System.Drawing.Color.Black;
            this.TextBoxQuantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(10)))));
            this.TextBoxQuantity.Location = new System.Drawing.Point(50, 498);
            this.TextBoxQuantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBoxQuantity.Name = "TextBoxQuantity";
            this.TextBoxQuantity.PasswordChar = '\0';
            this.TextBoxQuantity.PlaceholderText = "Количество";
            this.TextBoxQuantity.SelectedText = "";
            this.TextBoxQuantity.Size = new System.Drawing.Size(350, 50);
            this.TextBoxQuantity.TabIndex = 42;
            this.TextBoxQuantity.TabStop = false;
            // 
            // TextBoxWaste
            // 
            this.TextBoxWaste.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(10)))));
            this.TextBoxWaste.BorderRadius = 10;
            this.TextBoxWaste.BorderThickness = 2;
            this.TextBoxWaste.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxWaste.DefaultText = "";
            this.TextBoxWaste.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxWaste.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxWaste.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxWaste.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxWaste.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(10)))));
            this.TextBoxWaste.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TextBoxWaste.ForeColor = System.Drawing.Color.Black;
            this.TextBoxWaste.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(10)))));
            this.TextBoxWaste.Location = new System.Drawing.Point(50, 556);
            this.TextBoxWaste.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBoxWaste.Name = "TextBoxWaste";
            this.TextBoxWaste.PasswordChar = '\0';
            this.TextBoxWaste.PlaceholderText = "Остаток";
            this.TextBoxWaste.SelectedText = "";
            this.TextBoxWaste.Size = new System.Drawing.Size(350, 50);
            this.TextBoxWaste.TabIndex = 43;
            this.TextBoxWaste.TabStop = false;
            // 
            // TextBoxWastePercentage
            // 
            this.TextBoxWastePercentage.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(10)))));
            this.TextBoxWastePercentage.BorderRadius = 10;
            this.TextBoxWastePercentage.BorderThickness = 2;
            this.TextBoxWastePercentage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxWastePercentage.DefaultText = "";
            this.TextBoxWastePercentage.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxWastePercentage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxWastePercentage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxWastePercentage.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxWastePercentage.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(10)))));
            this.TextBoxWastePercentage.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TextBoxWastePercentage.ForeColor = System.Drawing.Color.Black;
            this.TextBoxWastePercentage.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(10)))));
            this.TextBoxWastePercentage.Location = new System.Drawing.Point(50, 614);
            this.TextBoxWastePercentage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBoxWastePercentage.Name = "TextBoxWastePercentage";
            this.TextBoxWastePercentage.PasswordChar = '\0';
            this.TextBoxWastePercentage.PlaceholderText = "Остаток %";
            this.TextBoxWastePercentage.SelectedText = "";
            this.TextBoxWastePercentage.Size = new System.Drawing.Size(350, 50);
            this.TextBoxWastePercentage.TabIndex = 44;
            this.TextBoxWastePercentage.TabStop = false;
            // 
            // TextBoxCreationDate
            // 
            this.TextBoxCreationDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(10)))));
            this.TextBoxCreationDate.BorderRadius = 10;
            this.TextBoxCreationDate.BorderThickness = 2;
            this.TextBoxCreationDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxCreationDate.DefaultText = "";
            this.TextBoxCreationDate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxCreationDate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxCreationDate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxCreationDate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxCreationDate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(10)))));
            this.TextBoxCreationDate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TextBoxCreationDate.ForeColor = System.Drawing.Color.Black;
            this.TextBoxCreationDate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(10)))));
            this.TextBoxCreationDate.Location = new System.Drawing.Point(50, 672);
            this.TextBoxCreationDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBoxCreationDate.Name = "TextBoxCreationDate";
            this.TextBoxCreationDate.PasswordChar = '\0';
            this.TextBoxCreationDate.PlaceholderText = "Дата создания";
            this.TextBoxCreationDate.SelectedText = "";
            this.TextBoxCreationDate.Size = new System.Drawing.Size(350, 50);
            this.TextBoxCreationDate.TabIndex = 45;
            this.TextBoxCreationDate.TabStop = false;
            // 
            // ДобавлениеЗаказ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(450, 791);
            this.Controls.Add(this.TextBoxCreationDate);
            this.Controls.Add(this.TextBoxWastePercentage);
            this.Controls.Add(this.TextBoxWaste);
            this.Controls.Add(this.TextBoxQuantity);
            this.Controls.Add(this.TextBoxSize);
            this.Controls.Add(this.TextBoxProductName);
            this.Controls.Add(this.СomboBoxSeamstress);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.TextBoxTotalCost);
            this.Controls.Add(this.PictureBoxProductPhoto);
            this.Controls.Add(this.HeaderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ДобавлениеЗаказ";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ДобавлениеЗаказ";
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxProductPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Panel HeaderPanel;
        private Guna.UI2.WinForms.Guna2HtmlLabel HeaderPanelLabel;
        private Guna.UI2.WinForms.Guna2Button IconClose;
        private Guna.UI2.WinForms.Guna2PictureBox PictureBoxProductPhoto;
        private Guna.UI2.WinForms.Guna2Button buttonSave;
        private Guna.UI2.WinForms.Guna2ComboBox СomboBoxSeamstress;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxTotalCost;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxProductName;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxQuantity;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxSize;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxCreationDate;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxWastePercentage;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxWaste;
    }
}