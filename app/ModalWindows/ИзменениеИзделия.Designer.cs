namespace app.Forms
{
    partial class ИзменениеИзделия
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
            this.ComboBoxFabric = new Guna.UI2.WinForms.Guna2ComboBox();
            this.buttonChange = new Guna.UI2.WinForms.Guna2Button();
            this.TextBoxWidth = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxLength = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxProduct = new Guna.UI2.WinForms.Guna2TextBox();
            this.ComboBoxSize = new Guna.UI2.WinForms.Guna2ComboBox();
            this.TextBoxDensity = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.pictureSet = new Guna.UI2.WinForms.Guna2PictureBox();
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
            this.HeaderPanel.TabIndex = 32;
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
            this.ComboBoxFabric.Location = new System.Drawing.Point(50, 568);
            this.ComboBoxFabric.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.ComboBoxFabric.Name = "ComboBoxFabric";
            this.ComboBoxFabric.Size = new System.Drawing.Size(350, 50);
            this.ComboBoxFabric.TabIndex = 47;
            this.ComboBoxFabric.Enter += new System.EventHandler(this.ComboBoxFabric_Enter);
            this.ComboBoxFabric.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ComboBoxFabric_KeyDown);
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
            this.buttonChange.FillColor = System.Drawing.Color.Green;
            this.buttonChange.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.buttonChange.ForeColor = System.Drawing.Color.White;
            this.buttonChange.HoverState.FillColor = System.Drawing.Color.ForestGreen;
            this.buttonChange.Location = new System.Drawing.Point(50, 638);
            this.buttonChange.Margin = new System.Windows.Forms.Padding(0);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(350, 50);
            this.buttonChange.TabIndex = 46;
            this.buttonChange.Text = "Изменить";
            this.buttonChange.UseTransparentBackground = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
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
            this.TextBoxWidth.Location = new System.Drawing.Point(50, 453);
            this.TextBoxWidth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBoxWidth.Name = "TextBoxWidth";
            this.TextBoxWidth.PasswordChar = '\0';
            this.TextBoxWidth.PlaceholderText = "Ширина";
            this.TextBoxWidth.SelectedText = "";
            this.TextBoxWidth.Size = new System.Drawing.Size(350, 50);
            this.TextBoxWidth.TabIndex = 45;
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
            this.TextBoxLength.Location = new System.Drawing.Point(50, 395);
            this.TextBoxLength.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBoxLength.Name = "TextBoxLength";
            this.TextBoxLength.PasswordChar = '\0';
            this.TextBoxLength.PlaceholderText = "Длина";
            this.TextBoxLength.SelectedText = "";
            this.TextBoxLength.Size = new System.Drawing.Size(350, 50);
            this.TextBoxLength.TabIndex = 44;
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
            this.TextBoxProduct.Location = new System.Drawing.Point(50, 280);
            this.TextBoxProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBoxProduct.Name = "TextBoxProduct";
            this.TextBoxProduct.PasswordChar = '\0';
            this.TextBoxProduct.PlaceholderText = "Изделие";
            this.TextBoxProduct.SelectedText = "";
            this.TextBoxProduct.Size = new System.Drawing.Size(350, 50);
            this.TextBoxProduct.TabIndex = 42;
            this.TextBoxProduct.TabStop = false;
            this.TextBoxProduct.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxProduct_KeyDown);
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
            this.ComboBoxSize.Location = new System.Drawing.Point(50, 337);
            this.ComboBoxSize.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.ComboBoxSize.Name = "ComboBoxSize";
            this.ComboBoxSize.Size = new System.Drawing.Size(350, 50);
            this.ComboBoxSize.TabIndex = 49;
            this.ComboBoxSize.Enter += new System.EventHandler(this.ComboBoxSize_Enter);
            this.ComboBoxSize.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ComboBoxSize_KeyDown);
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
            this.TextBoxDensity.Location = new System.Drawing.Point(50, 511);
            this.TextBoxDensity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBoxDensity.Name = "TextBoxDensity";
            this.TextBoxDensity.PasswordChar = '\0';
            this.TextBoxDensity.PlaceholderText = "Плотность";
            this.TextBoxDensity.SelectedText = "";
            this.TextBoxDensity.Size = new System.Drawing.Size(350, 50);
            this.TextBoxDensity.TabIndex = 50;
            this.TextBoxDensity.TabStop = false;
            this.TextBoxDensity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxDensity_KeyDown);
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
            // pictureSet
            // 
            this.pictureSet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureSet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureSet.ImageRotate = 0F;
            this.pictureSet.Location = new System.Drawing.Point(100, 69);
            this.pictureSet.Margin = new System.Windows.Forms.Padding(0);
            this.pictureSet.Name = "pictureSet";
            this.pictureSet.Size = new System.Drawing.Size(250, 200);
            this.pictureSet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureSet.TabIndex = 41;
            this.pictureSet.TabStop = false;
            this.pictureSet.Click += new System.EventHandler(this.pictureSet_Click);
            // 
            // ИзменениеИзделия
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(450, 714);
            this.Controls.Add(this.TextBoxDensity);
            this.Controls.Add(this.ComboBoxSize);
            this.Controls.Add(this.ComboBoxFabric);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.TextBoxWidth);
            this.Controls.Add(this.TextBoxLength);
            this.Controls.Add(this.TextBoxProduct);
            this.Controls.Add(this.pictureSet);
            this.Controls.Add(this.HeaderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ИзменениеИзделия";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ИзменениеИзделия";
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel HeaderPanel;
        private Guna.UI2.WinForms.Guna2HtmlLabel HeaderPanelLabel;
        private Guna.UI2.WinForms.Guna2Button IconClose;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBoxFabric;
        private Guna.UI2.WinForms.Guna2Button buttonChange;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxWidth;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxLength;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxProduct;
        private Guna.UI2.WinForms.Guna2PictureBox pictureSet;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBoxSize;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxDensity;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}