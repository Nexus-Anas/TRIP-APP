namespace TRIP_APP
{
    partial class LoadingForm
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
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.circleBar = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.LoadingTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // circleBar
            // 
            this.circleBar.Animated = true;
            this.circleBar.AnimationSpeed = 0.8F;
            this.circleBar.FillOffset = 5;
            this.circleBar.FillThickness = 14;
            this.circleBar.Location = new System.Drawing.Point(400, 227);
            this.circleBar.Name = "circleBar";
            this.circleBar.ProgressColor = System.Drawing.Color.Cyan;
            this.circleBar.ProgressColor2 = System.Drawing.Color.SlateBlue;
            this.circleBar.ProgressEndCap = System.Drawing.Drawing2D.LineCap.Round;
            this.circleBar.ProgressOffset = 4;
            this.circleBar.ProgressStartCap = System.Drawing.Drawing2D.LineCap.Round;
            this.circleBar.ProgressThickness = 15;
            this.circleBar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.circleBar.ShadowDecoration.Parent = this.circleBar;
            this.circleBar.Size = new System.Drawing.Size(150, 150);
            this.circleBar.TabIndex = 27;
            this.circleBar.Value = 30;
            // 
            // LoadingTimer
            // 
            this.LoadingTimer.Interval = 1000;
            this.LoadingTimer.Tick += new System.EventHandler(this.LoadingTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 485);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 32);
            this.label1.TabIndex = 28;
            this.label1.Text = "Powered By:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label2.Location = new System.Drawing.Point(28, 522);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 32);
            this.label2.TabIndex = 29;
            this.label2.Text = "TEAM MATRIX";
            // 
            // LoadingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(958, 573);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.circleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoadingForm";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoadingForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoadingForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LoadingForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LoadingForm_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Guna.UI2.WinForms.Guna2CircleProgressBar circleBar;
        private System.Windows.Forms.Timer LoadingTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}