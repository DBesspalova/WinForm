namespace WinFormFirst
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            lbWelcome = new Label();
            btMain = new Button();
            lbPoints = new Label();
            SuspendLayout();
            // 
            // lbWelcome
            // 
            lbWelcome.Anchor = AnchorStyles.None;
            lbWelcome.AutoSize = true;
            lbWelcome.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbWelcome.ForeColor = Color.Fuchsia;
            lbWelcome.Location = new Point(332, 37);
            lbWelcome.Name = "lbWelcome";
            lbWelcome.Size = new Size(279, 32);
            lbWelcome.TabIndex = 0;
            lbWelcome.Text = "Welcome to survey!";
            // 
            // btMain
            // 
            btMain.AccessibleRole = AccessibleRole.None;
            btMain.Anchor = AnchorStyles.None;
            btMain.BackColor = Color.FromArgb(65, 65, 65);
            btMain.Cursor = Cursors.Hand;
            btMain.FlatAppearance.BorderSize = 0;
            btMain.FlatAppearance.MouseDownBackColor = Color.Black;
            btMain.FlatAppearance.MouseOverBackColor = Color.FromArgb(80, 80, 80);
            btMain.FlatStyle = FlatStyle.Flat;
            btMain.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btMain.ForeColor = SystemColors.Control;
            btMain.Location = new Point(334, 161);
            btMain.Name = "btMain";
            btMain.Size = new Size(277, 58);
            btMain.TabIndex = 1;
            btMain.Text = "Gо";
            btMain.UseVisualStyleBackColor = false;
            btMain.Click += GetNotificationClick;
            // 
            // lbPoints
            // 
            lbPoints.AutoSize = true;
            lbPoints.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbPoints.ForeColor = SystemColors.Control;
            lbPoints.Location = new Point(24, 23);
            lbPoints.Name = "lbPoints";
            lbPoints.Size = new Size(136, 27);
            lbPoints.TabIndex = 2;
            lbPoints.Text = "X = 0 : Y = 0";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 33, 33);
            ClientSize = new Size(982, 453);
            Controls.Add(lbPoints);
            Controls.Add(btMain);
            Controls.Add(lbWelcome);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(600, 300);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Intel Application";
            Click += FormClick;
            MouseMove += MouseFormMove;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbWelcome;
        private Button btMain;
        private Label lbPoints;
    }
}