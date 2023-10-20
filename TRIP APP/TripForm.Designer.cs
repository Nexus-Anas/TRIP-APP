namespace TRIP_APP
{
    partial class TripForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.navBar = new System.Windows.Forms.Panel();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnExit = new Guna.UI2.WinForms.Guna2CircleButton();
            this.dgvTrip = new Guna.UI2.WinForms.Guna2DataGridView();
            this.DownPanel = new Guna.UI.WinForms.GunaElipsePanel();
            this.txtAddTrip = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnNewTrip = new Guna.UI.WinForms.GunaElipsePanel();
            this.ProgressBarNewTrip = new Guna.UI2.WinForms.Guna2ProgressIndicator();
            this.lblNewTrip = new Guna.UI.WinForms.GunaLabel();
            this.btnSelectTrip = new Guna.UI2.WinForms.Guna2Button();
            this.timerNewTrip = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.navBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrip)).BeginInit();
            this.DownPanel.SuspendLayout();
            this.btnNewTrip.SuspendLayout();
            this.gunaElipsePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // navBar
            // 
            this.navBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.navBar.Controls.Add(this.btnMinimize);
            this.navBar.Controls.Add(this.btnExit);
            this.navBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.navBar.Location = new System.Drawing.Point(0, 0);
            this.navBar.Name = "navBar";
            this.navBar.Size = new System.Drawing.Size(391, 39);
            this.navBar.TabIndex = 1;
            this.navBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.navBar_MouseDown);
            this.navBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.navBar_MouseMove);
            this.navBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.navBar_MouseUp);
            // 
            // btnMinimize
            // 
            this.btnMinimize.CheckedState.Parent = this.btnMinimize;
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.CustomImages.Parent = this.btnMinimize;
            this.btnMinimize.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.HoverState.FillColor = System.Drawing.Color.Cyan;
            this.btnMinimize.HoverState.Parent = this.btnMinimize;
            this.btnMinimize.Location = new System.Drawing.Point(333, 10);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnMinimize.ShadowDecoration.Parent = this.btnMinimize;
            this.btnMinimize.Size = new System.Drawing.Size(20, 20);
            this.btnMinimize.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnMinimize, "Minimize");
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.CheckedState.Parent = this.btnExit;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.CustomImages.Parent = this.btnExit;
            this.btnExit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.HoverState.FillColor = System.Drawing.Color.Red;
            this.btnExit.HoverState.Parent = this.btnExit;
            this.btnExit.Location = new System.Drawing.Point(359, 10);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnExit.ShadowDecoration.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(20, 20);
            this.btnExit.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnExit, "Exit");
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dgvTrip
            // 
            this.dgvTrip.AllowUserToAddRows = false;
            this.dgvTrip.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvTrip.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTrip.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTrip.BackgroundColor = System.Drawing.Color.White;
            this.dgvTrip.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTrip.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTrip.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTrip.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTrip.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTrip.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTrip.EnableHeadersVisualStyles = false;
            this.dgvTrip.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTrip.Location = new System.Drawing.Point(13, 68);
            this.dgvTrip.Name = "dgvTrip";
            this.dgvTrip.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTrip.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTrip.RowHeadersVisible = false;
            this.dgvTrip.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTrip.Size = new System.Drawing.Size(313, 245);
            this.dgvTrip.TabIndex = 2;
            this.dgvTrip.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvTrip.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTrip.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvTrip.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvTrip.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvTrip.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvTrip.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvTrip.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTrip.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvTrip.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTrip.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvTrip.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTrip.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvTrip.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvTrip.ThemeStyle.ReadOnly = true;
            this.dgvTrip.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTrip.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTrip.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvTrip.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvTrip.ThemeStyle.RowsStyle.Height = 22;
            this.dgvTrip.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTrip.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // DownPanel
            // 
            this.DownPanel.BackColor = System.Drawing.Color.Transparent;
            this.DownPanel.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(54)))), ((int)(((byte)(78)))));
            this.DownPanel.Controls.Add(this.txtAddTrip);
            this.DownPanel.Controls.Add(this.btnNewTrip);
            this.DownPanel.Location = new System.Drawing.Point(25, 62);
            this.DownPanel.Name = "DownPanel";
            this.DownPanel.Size = new System.Drawing.Size(340, 160);
            this.DownPanel.TabIndex = 9;
            // 
            // txtAddTrip
            // 
            this.txtAddTrip.Animated = true;
            this.txtAddTrip.BorderColor = System.Drawing.Color.MediumSpringGreen;
            this.txtAddTrip.BorderRadius = 10;
            this.txtAddTrip.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddTrip.DefaultText = "";
            this.txtAddTrip.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAddTrip.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAddTrip.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddTrip.DisabledState.Parent = this.txtAddTrip;
            this.txtAddTrip.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddTrip.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.txtAddTrip.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtAddTrip.FocusedState.Parent = this.txtAddTrip;
            this.txtAddTrip.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddTrip.ForeColor = System.Drawing.Color.White;
            this.txtAddTrip.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddTrip.HoverState.Parent = this.txtAddTrip;
            this.txtAddTrip.Location = new System.Drawing.Point(13, 11);
            this.txtAddTrip.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAddTrip.Name = "txtAddTrip";
            this.txtAddTrip.PasswordChar = '\0';
            this.txtAddTrip.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtAddTrip.PlaceholderText = "Type trip name";
            this.txtAddTrip.SelectedText = "";
            this.txtAddTrip.ShadowDecoration.Parent = this.txtAddTrip;
            this.txtAddTrip.Size = new System.Drawing.Size(313, 30);
            this.txtAddTrip.TabIndex = 37;
            this.txtAddTrip.TextOffset = new System.Drawing.Point(2, 0);
            // 
            // btnNewTrip
            // 
            this.btnNewTrip.BackColor = System.Drawing.Color.Transparent;
            this.btnNewTrip.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnNewTrip.Controls.Add(this.ProgressBarNewTrip);
            this.btnNewTrip.Controls.Add(this.lblNewTrip);
            this.btnNewTrip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewTrip.Location = new System.Drawing.Point(13, 49);
            this.btnNewTrip.Name = "btnNewTrip";
            this.btnNewTrip.Size = new System.Drawing.Size(313, 99);
            this.btnNewTrip.TabIndex = 9;
            this.btnNewTrip.Click += new System.EventHandler(this.btnNewTrip_Click);
            this.btnNewTrip.MouseEnter += new System.EventHandler(this.btnNewTrip_MouseEnter);
            this.btnNewTrip.MouseLeave += new System.EventHandler(this.btnNewTrip_MouseLeave);
            // 
            // ProgressBarNewTrip
            // 
            this.ProgressBarNewTrip.CircleSize = 0.8F;
            this.ProgressBarNewTrip.Location = new System.Drawing.Point(208, 6);
            this.ProgressBarNewTrip.Name = "ProgressBarNewTrip";
            this.ProgressBarNewTrip.ProgressColor = System.Drawing.Color.MediumSpringGreen;
            this.ProgressBarNewTrip.Size = new System.Drawing.Size(86, 86);
            this.ProgressBarNewTrip.TabIndex = 26;
            this.ProgressBarNewTrip.MouseEnter += new System.EventHandler(this.ProgressBarNewTrip_MouseEnter);
            // 
            // lblNewTrip
            // 
            this.lblNewTrip.AutoSize = true;
            this.lblNewTrip.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewTrip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblNewTrip.Location = new System.Drawing.Point(19, 30);
            this.lblNewTrip.Name = "lblNewTrip";
            this.lblNewTrip.Size = new System.Drawing.Size(158, 36);
            this.lblNewTrip.TabIndex = 6;
            this.lblNewTrip.Text = "New Trip +";
            this.lblNewTrip.MouseEnter += new System.EventHandler(this.lblNewTrip_MouseEnter);
            // 
            // btnSelectTrip
            // 
            this.btnSelectTrip.Animated = true;
            this.btnSelectTrip.BackColor = System.Drawing.Color.Transparent;
            this.btnSelectTrip.BorderColor = System.Drawing.Color.SpringGreen;
            this.btnSelectTrip.BorderRadius = 12;
            this.btnSelectTrip.BorderThickness = 2;
            this.btnSelectTrip.CheckedState.Parent = this.btnSelectTrip;
            this.btnSelectTrip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectTrip.CustomImages.Parent = this.btnSelectTrip;
            this.btnSelectTrip.FillColor = System.Drawing.Color.Transparent;
            this.btnSelectTrip.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectTrip.ForeColor = System.Drawing.Color.White;
            this.btnSelectTrip.HoverState.Parent = this.btnSelectTrip;
            this.btnSelectTrip.Location = new System.Drawing.Point(13, 13);
            this.btnSelectTrip.Name = "btnSelectTrip";
            this.btnSelectTrip.ShadowDecoration.BorderRadius = 12;
            this.btnSelectTrip.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnSelectTrip.ShadowDecoration.Depth = 50;
            this.btnSelectTrip.ShadowDecoration.Enabled = true;
            this.btnSelectTrip.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnSelectTrip.ShadowDecoration.Parent = this.btnSelectTrip;
            this.btnSelectTrip.Size = new System.Drawing.Size(313, 45);
            this.btnSelectTrip.TabIndex = 21;
            this.btnSelectTrip.Text = "Select Trip";
            this.btnSelectTrip.Click += new System.EventHandler(this.btnSelectTrip_Click);
            // 
            // timerNewTrip
            // 
            this.timerNewTrip.Interval = 1000;
            this.timerNewTrip.Tick += new System.EventHandler(this.timerNewTrip_Tick);
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.White;
            this.toolTip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolTip1.IsBalloon = true;
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(54)))), ((int)(((byte)(78)))));
            this.gunaElipsePanel1.Controls.Add(this.dgvTrip);
            this.gunaElipsePanel1.Controls.Add(this.btnSelectTrip);
            this.gunaElipsePanel1.Location = new System.Drawing.Point(25, 265);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Size = new System.Drawing.Size(340, 326);
            this.gunaElipsePanel1.TabIndex = 38;
            // 
            // TripForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(391, 613);
            this.Controls.Add(this.gunaElipsePanel1);
            this.Controls.Add(this.DownPanel);
            this.Controls.Add(this.navBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TripForm";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TripForm";
            this.Load += new System.EventHandler(this.TripForm_Load);
            this.navBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrip)).EndInit();
            this.DownPanel.ResumeLayout(false);
            this.btnNewTrip.ResumeLayout(false);
            this.btnNewTrip.PerformLayout();
            this.gunaElipsePanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel navBar;
        private Guna.UI2.WinForms.Guna2CircleButton btnMinimize;
        private Guna.UI2.WinForms.Guna2CircleButton btnExit;
        private Guna.UI2.WinForms.Guna2DataGridView dgvTrip;
        private Guna.UI.WinForms.GunaElipsePanel DownPanel;
        private Guna.UI.WinForms.GunaElipsePanel btnNewTrip;
        private Guna.UI2.WinForms.Guna2ProgressIndicator ProgressBarNewTrip;
        private Guna.UI.WinForms.GunaLabel lblNewTrip;
        private Guna.UI2.WinForms.Guna2Button btnSelectTrip;
        private System.Windows.Forms.Timer timerNewTrip;
        private System.Windows.Forms.ToolTip toolTip1;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private Guna.UI2.WinForms.Guna2TextBox txtAddTrip;
    }
}