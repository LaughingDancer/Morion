namespace app.Forms
{
    partial class ДобавлениеИзделия
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
            this.buttonSave = new Guna.UI2.WinForms.Guna2Button();
            this.pictureSet = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.TextBoxDensity = new Guna.UI2.WinForms.Guna2TextBox();
            this.ComboBoxSize = new Guna.UI2.WinForms.Guna2ComboBox();
            this.ComboBoxFabric = new Guna.UI2.WinForms.Guna2ComboBox();
            this.TextBoxWidth = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxLength = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxProduct = new Guna.UI2.WinForms.Guna2TextBox();
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
            this.HeaderPanel.TabIndex = 33;
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
            this.buttonSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Location = new System.Drawing.Point(50, 640);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(350, 50);
            this.buttonSave.TabIndex = 44;
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
            this.pictureSet.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.pictureSet.Name = "pictureSet";
            this.pictureSet.Size = new System.Drawing.Size(250, 200);
            this.pictureSet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureSet.TabIndex = 40;
            this.pictureSet.TabStop = false;
            this.pictureSet.Click += new System.EventHandler(this.pictureSet_Click);
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
            // TextBoxDensity
            // 
            this.TextBoxDensity.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(10)))));
            this.TextBoxDensity.BorderRadius = 10;
            this.TextBoxDensity.BorderThickness = 2;
            this.TextBoxDensity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxDensity.DefaultText = "";
            this.TextBoxDensity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxDensity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxDensity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxDensity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxDensity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(10)))));
            this.TextBoxDensity.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TextBoxDensity.ForeColor = System.Drawing.Color.Black;
            this.TextBoxDensity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(10)))));
            this.TextBoxDensity.Location = new System.Drawing.Point(50, 510);
            this.TextBoxDensity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 10);
            this.TextBoxDensity.Name = "TextBoxDensity";
            this.TextBoxDensity.PlaceholderText = "Плотность (г/м2)";
            this.TextBoxDensity.SelectedText = "";
            this.TextBoxDensity.Size = new System.Drawing.Size(350, 50);
            this.TextBoxDensity.TabIndex = 56;
            this.TextBoxDensity.TabStop = false;
            this.TextBoxDensity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxDensity_KeyDown);
            // 
            // ComboBoxSize
            // 
            this.ComboBoxSize.BackColor = System.Drawing.Color.Transparent;
            this.ComboBoxSize.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(10)))));
            this.ComboBoxSize.BorderRadius = 10;
            this.ComboBoxSize.BorderThickness = 2;
            this.ComboBoxSize.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxSize.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(10)))));
            this.ComboBoxSize.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(10)))));
            this.ComboBoxSize.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ComboBoxSize.ForeColor = System.Drawing.Color.Black;
            this.ComboBoxSize.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(10)))));
            this.ComboBoxSize.ItemHeight = 44;
            this.ComboBoxSize.Items.AddRange(new object[] {
            "S",
            "M",
            "L",
            "XL"});
            this.ComboBoxSize.Location = new System.Drawing.Point(50, 330);
            this.ComboBoxSize.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.ComboBoxSize.Name = "ComboBoxSize";
            this.ComboBoxSize.Size = new System.Drawing.Size(350, 50);
            this.ComboBoxSize.TabIndex = 55;
            this.ComboBoxSize.DropDown += new System.EventHandler(this.ComboBoxSize_DropDown);
            this.ComboBoxSize.DropDownClosed += new System.EventHandler(this.ComboBoxSize_DropDownClosed);
            this.ComboBoxSize.Enter += new System.EventHandler(this.ComboBoxSize_Enter);
            this.ComboBoxSize.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ComboBoxSize_KeyDown);
            // 
            // ComboBoxFabric
            // 
            this.ComboBoxFabric.BackColor = System.Drawing.Color.Transparent;
            this.ComboBoxFabric.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(10)))));
            this.ComboBoxFabric.BorderRadius = 10;
            this.ComboBoxFabric.BorderThickness = 2;
            this.ComboBoxFabric.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxFabric.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxFabric.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(10)))));
            this.ComboBoxFabric.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(10)))));
            this.ComboBoxFabric.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ComboBoxFabric.ForeColor = System.Drawing.Color.Black;
            this.ComboBoxFabric.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(10)))));
            this.ComboBoxFabric.ItemHeight = 44;
            this.ComboBoxFabric.Items.AddRange(new object[] {
            "Хлопок",
            "Полиэфир",
            "Смесовая"});
            this.ComboBoxFabric.Location = new System.Drawing.Point(50, 570);
            this.ComboBoxFabric.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.ComboBoxFabric.Name = "ComboBoxFabric";
            this.ComboBoxFabric.Size = new System.Drawing.Size(350, 50);
            this.ComboBoxFabric.TabIndex = 54;
            this.ComboBoxFabric.DropDown += new System.EventHandler(this.ComboBoxFabric_DropDown);
            this.ComboBoxFabric.DropDownClosed += new System.EventHandler(this.ComboBoxFabric_DropDownClosed);
            this.ComboBoxFabric.Enter += new System.EventHandler(this.ComboBoxFabric_Enter);
            this.ComboBoxFabric.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ComboBoxFabric_KeyDown);
            // 
            // TextBoxWidth
            // 
            this.TextBoxWidth.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(10)))));
            this.TextBoxWidth.BorderRadius = 10;
            this.TextBoxWidth.BorderThickness = 2;
            this.TextBoxWidth.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxWidth.DefaultText = "";
            this.TextBoxWidth.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxWidth.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxWidth.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxWidth.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxWidth.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(10)))));
            this.TextBoxWidth.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TextBoxWidth.ForeColor = System.Drawing.Color.Black;
            this.TextBoxWidth.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(10)))));
            this.TextBoxWidth.Location = new System.Drawing.Point(50, 450);
            this.TextBoxWidth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 10);
            this.TextBoxWidth.Name = "TextBoxWidth";
            this.TextBoxWidth.PlaceholderText = "Ширина (м)";
            this.TextBoxWidth.SelectedText = "";
            this.TextBoxWidth.Size = new System.Drawing.Size(350, 50);
            this.TextBoxWidth.TabIndex = 53;
            this.TextBoxWidth.TabStop = false;
            this.TextBoxWidth.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxWidth_KeyDown);
            // 
            // TextBoxLength
            // 
            this.TextBoxLength.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(10)))));
            this.TextBoxLength.BorderRadius = 10;
            this.TextBoxLength.BorderThickness = 2;
            this.TextBoxLength.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxLength.DefaultText = "";
            this.TextBoxLength.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxLength.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxLength.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxLength.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxLength.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(10)))));
            this.TextBoxLength.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TextBoxLength.ForeColor = System.Drawing.Color.Black;
            this.TextBoxLength.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(10)))));
            this.TextBoxLength.Location = new System.Drawing.Point(50, 390);
            this.TextBoxLength.Margin = new System.Windows.Forms.Padding(4, 0, 4, 10);
            this.TextBoxLength.Name = "TextBoxLength";
            this.TextBoxLength.PlaceholderText = "Длина (м)";
            this.TextBoxLength.SelectedText = "";
            this.TextBoxLength.Size = new System.Drawing.Size(350, 50);
            this.TextBoxLength.TabIndex = 52;
            this.TextBoxLength.TabStop = false;
            this.TextBoxLength.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxLength_KeyDown);
            // 
            // TextBoxProduct
            // 
            this.TextBoxProduct.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(10)))));
            this.TextBoxProduct.BorderRadius = 10;
            this.TextBoxProduct.BorderThickness = 2;
            this.TextBoxProduct.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxProduct.DefaultText = "";
            this.TextBoxProduct.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxProduct.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxProduct.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(10)))));
            this.TextBoxProduct.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TextBoxProduct.ForeColor = System.Drawing.Color.Black;
            this.TextBoxProduct.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(10)))));
            this.TextBoxProduct.Location = new System.Drawing.Point(50, 270);
            this.TextBoxProduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 10);
            this.TextBoxProduct.Name = "TextBoxProduct";
            this.TextBoxProduct.PlaceholderText = "Изделие";
            this.TextBoxProduct.SelectedText = "";
            this.TextBoxProduct.Size = new System.Drawing.Size(350, 50);
            this.TextBoxProduct.TabIndex = 51;
            this.TextBoxProduct.TabStop = false;
            this.TextBoxProduct.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxProduct_KeyDown);
            // 
            // ДобавлениеИзделия
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(450, 712);
            this.Controls.Add(this.TextBoxDensity);
            this.Controls.Add(this.ComboBoxSize);
            this.Controls.Add(this.ComboBoxFabric);
            this.Controls.Add(this.TextBoxWidth);
            this.Controls.Add(this.TextBoxLength);
            this.Controls.Add(this.TextBoxProduct);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.pictureSet);
            this.Controls.Add(this.HeaderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ДобавлениеИзделия";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ДобавлениеИзделия";
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel HeaderPanel;
        private Guna.UI2.WinForms.Guna2HtmlLabel HeaderPanelLabel;
        private Guna.UI2.WinForms.Guna2Button IconClose;
        private Guna.UI2.WinForms.Guna2Button buttonSave;
        private Guna.UI2.WinForms.Guna2PictureBox pictureSet;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxDensity;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBoxSize;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBoxFabric;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxWidth;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxLength;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxProduct;
    }
}