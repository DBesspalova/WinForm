namespace WinFormFirst
{
    partial class GameCanvas
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
            btNo = new Button();
            btYes = new Button();
            Label = new TextBox();
            SuspendLayout();
            // 
            // btNo
            // 
            btNo.BackColor = Color.Red;
            btNo.FlatStyle = FlatStyle.Flat;
            btNo.Font = new Font("Tempus Sans ITC", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btNo.Location = new Point(299, 182);
            btNo.Name = "btNo";
            btNo.Size = new Size(94, 55);
            btNo.TabIndex = 0;
            btNo.Text = "No!";
            btNo.UseVisualStyleBackColor = false;
            btNo.MouseEnter += ButtonMoveEvent;
            // 
            // btYes
            // 
            btYes.AccessibleRole = AccessibleRole.None;
            btYes.Anchor = AnchorStyles.None;
            btYes.BackColor = Color.Green;
            btYes.FlatStyle = FlatStyle.Flat;
            btYes.Font = new Font("Tempus Sans ITC", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btYes.ForeColor = SystemColors.ActiveCaptionText;
            btYes.Location = new Point(556, 182);
            btYes.Name = "btYes";
            btYes.Size = new Size(94, 55);
            btYes.TabIndex = 1;
            btYes.Text = "Yes";
            btYes.UseVisualStyleBackColor = false;
            btYes.Click += btYes_Click;
            // 
            // Label
            // 
            Label.Anchor = AnchorStyles.None;
            Label.BackColor = SystemColors.MenuBar;
            Label.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Label.ForeColor = SystemColors.InactiveCaptionText;
            Label.Location = new Point(245, 54);
            Label.Name = "Label";
            Label.Size = new Size(491, 36);
            Label.TabIndex = 2;
            Label.Text = "Are you satisfied with your Salaru?";
            Label.TextAlign = HorizontalAlignment.Center;
            Label.TextChanged += textBox1_TextChanged;
            // 
            // GameCanvas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 453);
            Controls.Add(Label);
            Controls.Add(btYes);
            Controls.Add(btNo);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "GameCanvas";
            Text = "Survey";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btNo;
        private Button btYes;
        private TextBox Label;
    }
}