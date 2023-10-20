namespace TRIP_APP
{
    partial class AddPeopleForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.navBar = new System.Windows.Forms.Panel();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnExit = new Guna.UI2.WinForms.Guna2CircleButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.DownPanel = new Guna.UI.WinForms.GunaElipsePanel();
            this.panelDuration = new Guna.UI.WinForms.GunaElipsePanel();
            this.btnAddPeople = new Guna.UI2.WinForms.Guna2Button();
            this.txtAddPeople = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvPerson = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnSelectTrip = new Guna.UI2.WinForms.Guna2Button();
            this.navBar.SuspendLayout();
            this.DownPanel.SuspendLayout();
            this.panelDuration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).BeginInit();
            this.SuspendLayout();
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
            this.navBar.TabIndex = 2;
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
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // DownPanel
            // 
            this.DownPanel.BackColor = System.Drawing.Color.Transparent;
            this.DownPanel.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(54)))), ((int)(((byte)(78)))));
            this.DownPanel.Controls.Add(this.dgvPerson);
            this.DownPanel.Location = new System.Drawing.Point(12, 239);
            this.DownPanel.Name = "DownPanel";
            this.DownPanel.Size = new System.Drawing.Size(367, 349);
            this.DownPanel.TabIndex = 10;
            // 
            // panelDuration
            // 
            this.panelDuration.BackColor = System.Drawing.Color.Transparent;
            this.panelDuration.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(54)))), ((int)(((byte)(78)))));
            this.panelDuration.Controls.Add(this.btnSelectTrip);
            this.panelDuration.Controls.Add(this.btnAddPeople);
            this.panelDuration.Controls.Add(this.txtAddPeople);
            this.panelDuration.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelDuration.Location = new System.Drawing.Point(12, 67);
            this.panelDuration.Name = "panelDuration";
            this.panelDuration.Size = new System.Drawing.Size(367, 140);
            this.panelDuration.TabIndex = 37;
            // 
            // btnAddPeople
            // 
            this.btnAddPeople.Animated = true;
            this.btnAddPeople.BackColor = System.Drawing.Color.Transparent;
            this.btnAddPeople.BorderRadius = 5;
            this.btnAddPeople.CheckedState.Parent = this.btnAddPeople;
            this.btnAddPeople.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPeople.CustomImages.Parent = this.btnAddPeople;
            this.btnAddPeople.FillColor = System.Drawing.Color.Cyan;
            this.btnAddPeople.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPeople.ForeColor = System.Drawing.Color.Black;
            this.btnAddPeople.HoverState.Parent = this.btnAddPeople;
            this.btnAddPeople.Location = new System.Drawing.Point(323, 13);
            this.btnAddPeople.Name = "btnAddPeople";
            this.btnAddPeople.ShadowDecoration.Parent = this.btnAddPeople;
            this.btnAddPeople.Size = new System.Drawing.Size(36, 30);
            this.btnAddPeople.TabIndex = 37;
            this.btnAddPeople.Text = "+";
            this.btnAddPeople.Click += new System.EventHandler(this.btnAddPeople_Click);
            // 
            // txtAddPeople
            // 
            this.txtAddPeople.Animated = true;
            this.txtAddPeople.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.txtAddPeople.BorderRadius = 10;
            this.txtAddPeople.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddPeople.DefaultText = "";
            this.txtAddPeople.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAddPeople.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAddPeople.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddPeople.DisabledState.Parent = this.txtAddPeople;
            this.txtAddPeople.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddPeople.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.txtAddPeople.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtAddPeople.FocusedState.Parent = this.txtAddPeople;
            this.txtAddPeople.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddPeople.ForeColor = System.Drawing.Color.White;
            this.txtAddPeople.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddPeople.HoverState.Parent = this.txtAddPeople;
            this.txtAddPeople.Location = new System.Drawing.Point(8, 13);
            this.txtAddPeople.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAddPeople.Name = "txtAddPeople";
            this.txtAddPeople.PasswordChar = '\0';
            this.txtAddPeople.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtAddPeople.PlaceholderText = "Add new people";
            this.txtAddPeople.SelectedText = "";
            this.txtAddPeople.ShadowDecoration.Parent = this.txtAddPeople;
            this.txtAddPeople.Size = new System.Drawing.Size(291, 30);
            this.txtAddPeople.TabIndex = 36;
            this.txtAddPeople.TextOffset = new System.Drawing.Point(2, 0);
            // 
            // dgvPerson
            // 
            this.dgvPerson.AllowUserToAddRows = false;
            this.dgvPerson.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvPerson.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPerson.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPerson.BackgroundColor = System.Drawing.Color.White;
            this.dgvPerson.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPerson.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPerson.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPerson.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPerson.ColumnHeadersHeight = 21;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPerson.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPerson.EnableHeadersVisualStyles = false;
            this.dgvPerson.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPerson.Location = new System.Drawing.Point(8, 10);
            this.dgvPerson.Name = "dgvPerson";
            this.dgvPerson.ReadOnly = true;
            this.dgvPerson.RowHeadersVisible = false;
            this.dgvPerson.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPerson.Size = new System.Drawing.Size(351, 330);
            this.dgvPerson.TabIndex = 38;
            this.dgvPerson.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvPerson.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPerson.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvPerson.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvPerson.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvPerson.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvPerson.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvPerson.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPerson.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvPerson.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPerson.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvPerson.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPerson.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvPerson.ThemeStyle.HeaderStyle.Height = 21;
            this.dgvPerson.ThemeStyle.ReadOnly = true;
            this.dgvPerson.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPerson.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPerson.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvPerson.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvPerson.ThemeStyle.RowsStyle.Height = 22;
            this.dgvPerson.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPerson.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
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
            this.btnSelectTrip.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectTrip.ForeColor = System.Drawing.Color.White;
            this.btnSelectTrip.HoverState.Parent = this.btnSelectTrip;
            this.btnSelectTrip.Location = new System.Drawing.Point(8, 83);
            this.btnSelectTrip.Name = "btnSelectTrip";
            this.btnSelectTrip.ShadowDecoration.BorderRadius = 12;
            this.btnSelectTrip.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnSelectTrip.ShadowDecoration.Depth = 50;
            this.btnSelectTrip.ShadowDecoration.Enabled = true;
            this.btnSelectTrip.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnSelectTrip.ShadowDecoration.Parent = this.btnSelectTrip;
            this.btnSelectTrip.Size = new System.Drawing.Size(351, 42);
            this.btnSelectTrip.TabIndex = 38;
            this.btnSelectTrip.Text = "Start Trip";
            this.btnSelectTrip.Click += new System.EventHandler(this.btnSelectTrip_Click);
            // 
            // AddPeopleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(391, 613);
            this.Controls.Add(this.panelDuration);
            this.Controls.Add(this.DownPanel);
            this.Controls.Add(this.navBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddPeopleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddPeopleForm";
            this.Load += new System.EventHandler(this.AddPeopleForm_Load);
            this.navBar.ResumeLayout(false);
            this.DownPanel.ResumeLayout(false);
            this.panelDuration.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel navBar;
        private Guna.UI2.WinForms.Guna2CircleButton btnMinimize;
        private Guna.UI2.WinForms.Guna2CircleButton btnExit;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Guna.UI.WinForms.GunaElipsePanel DownPanel;
        private Guna.UI.WinForms.GunaElipsePanel panelDuration;
        private Guna.UI2.WinForms.Guna2Button btnAddPeople;
        private Guna.UI2.WinForms.Guna2TextBox txtAddPeople;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPerson;
        private Guna.UI2.WinForms.Guna2Button btnSelectTrip;
    }
}