namespace app
{
    partial class ГлавнаяШ
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
            this.MainPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.orderDetails = new Guna.UI2.WinForms.Guna2Button();
            this.ordering = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button22 = new Guna.UI2.WinForms.Guna2Button();
            this.HomeButton = new Guna.UI2.WinForms.Guna2Button();
            this.HeaderPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.IconMinimized = new Guna.UI2.WinForms.Guna2Button();
            this.IconMaximized = new Guna.UI2.WinForms.Guna2Button();
            this.IconClose = new Guna.UI2.WinForms.Guna2Button();
            this.DesktopPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.MainPanel.SuspendLayout();
            this.HeaderPanel.SuspendLayout();
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
            // MainPanel
            // 
            this.MainPanel.AutoScroll = true;
            this.MainPanel.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.MainPanel.Controls.Add(this.orderDetails);
            this.MainPanel.Controls.Add(this.ordering);
            this.MainPanel.Controls.Add(this.guna2Button22);
            this.MainPanel.Controls.Add(this.HomeButton);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MainPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(200, 450);
            this.MainPanel.TabIndex = 2;
            // 
            // orderDetails
            // 
            this.orderDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.orderDetails.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.orderDetails.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.orderDetails.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.orderDetails.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.orderDetails.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.orderDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.orderDetails.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.orderDetails.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.orderDetails.ForeColor = System.Drawing.Color.White;
            this.orderDetails.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.orderDetails.Image = global::app.Properties.Resources.order;
            this.orderDetails.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.orderDetails.ImageSize = new System.Drawing.Size(30, 30);
            this.orderDetails.Location = new System.Drawing.Point(0, 130);
            this.orderDetails.Name = "orderDetails";
            this.orderDetails.Size = new System.Drawing.Size(200, 50);
            this.orderDetails.TabIndex = 8;
            this.orderDetails.Text = "Детали заказов";
            this.orderDetails.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // ordering
            // 
            this.ordering.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ordering.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.ordering.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ordering.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ordering.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ordering.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ordering.Dock = System.Windows.Forms.DockStyle.Top;
            this.ordering.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.ordering.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ordering.ForeColor = System.Drawing.Color.White;
            this.ordering.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.ordering.Image = global::app.Properties.Resources.document;
            this.ordering.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ordering.ImageSize = new System.Drawing.Size(30, 30);
            this.ordering.Location = new System.Drawing.Point(0, 80);
            this.ordering.Name = "ordering";
            this.ordering.Size = new System.Drawing.Size(200, 50);
            this.ordering.TabIndex = 7;
            this.ordering.Text = "Оформить заказ";
            this.ordering.TextOffset = new System.Drawing.Point(10, 0);
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
            this.guna2Button22.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2Button22.ForeColor = System.Drawing.Color.White;
            this.guna2Button22.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(36)))), ((int)(((byte)(20)))));
            this.guna2Button22.Image = global::app.Properties.Resources.exit;
            this.guna2Button22.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button22.Location = new System.Drawing.Point(0, 400);
            this.guna2Button22.Name = "guna2Button22";
            this.guna2Button22.Size = new System.Drawing.Size(200, 50);
            this.guna2Button22.TabIndex = 6;
            this.guna2Button22.Text = "Выход";
            this.guna2Button22.Click += new System.EventHandler(this.guna2Button22_Click);
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
            this.HomeButton.Location = new System.Drawing.Point(0, 0);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(200, 80);
            this.HomeButton.TabIndex = 0;
            this.HomeButton.Text = "Морион";
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.Controls.Add(this.IconMinimized);
            this.HeaderPanel.Controls.Add(this.IconMaximized);
            this.HeaderPanel.Controls.Add(this.IconClose);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.HeaderPanel.Location = new System.Drawing.Point(200, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(600, 40);
            this.HeaderPanel.TabIndex = 3;
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
            this.IconMinimized.Location = new System.Drawing.Point(480, 0);
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
            this.IconMaximized.Location = new System.Drawing.Point(520, 0);
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
            this.IconClose.Location = new System.Drawing.Point(560, 0);
            this.IconClose.Name = "IconClose";
            this.IconClose.Size = new System.Drawing.Size(40, 40);
            this.IconClose.TabIndex = 0;
            this.IconClose.UseTransparentBackground = true;
            this.IconClose.Click += new System.EventHandler(this.IconClose_Click);
            // 
            // DesktopPanel
            // 
            this.DesktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DesktopPanel.Location = new System.Drawing.Point(200, 40);
            this.DesktopPanel.Name = "DesktopPanel";
            this.DesktopPanel.Size = new System.Drawing.Size(600, 410);
            this.DesktopPanel.TabIndex = 4;
            // 
            // ГлавнаяШ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DesktopPanel);
            this.Controls.Add(this.HeaderPanel);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ГлавнаяШ";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ГлавнаяШ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Resize += new System.EventHandler(this.ГлавнаяШ_Resize);
            this.MainPanel.ResumeLayout(false);
            this.HeaderPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Panel MainPanel;
        private Guna.UI2.WinForms.Guna2Button orderDetails;
        private Guna.UI2.WinForms.Guna2Button ordering;
        private Guna.UI2.WinForms.Guna2Button guna2Button22;
        private Guna.UI2.WinForms.Guna2Button HomeButton;
        private Guna.UI2.WinForms.Guna2Panel HeaderPanel;
        private Guna.UI2.WinForms.Guna2Button IconMinimized;
        private Guna.UI2.WinForms.Guna2Button IconMaximized;
        private Guna.UI2.WinForms.Guna2Button IconClose;
        private Guna.UI2.WinForms.Guna2Panel DesktopPanel;
    }
}