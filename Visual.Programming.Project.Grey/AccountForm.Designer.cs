namespace Visual.Programming.Project.Grey
{
    partial class AccountForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountForm));
            lblAccountTitle = new Label();
            panelProfile = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            panelProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblAccountTitle
            // 
            lblAccountTitle.AutoSize = true;
            lblAccountTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAccountTitle.Location = new Point(322, 22);
            lblAccountTitle.Name = "lblAccountTitle";
            lblAccountTitle.Size = new Size(272, 54);
            lblAccountTitle.TabIndex = 0;
            lblAccountTitle.Text = "Your Account";
            // 
            // panelProfile
            // 
            panelProfile.BackColor = Color.FromArgb(19, 25, 33);
            panelProfile.Controls.Add(pictureBox1);
            panelProfile.Controls.Add(label2);
            panelProfile.Controls.Add(label1);
            panelProfile.Location = new Point(222, 91);
            panelProfile.Name = "panelProfile";
            panelProfile.Size = new Size(455, 243);
            panelProfile.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(100, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(249, 183);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(194, 189);
            label1.Name = "label1";
            label1.Size = new Size(81, 26);
            label1.TabIndex = 1;
            label1.Text = "Admin";
            // 
            // AccountForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 644);
            Controls.Add(panelProfile);
            Controls.Add(lblAccountTitle);
            Name = "AccountForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ShopHub - Your Account";
            panelProfile.ResumeLayout(false);
            panelProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAccountTitle;
        private Panel panelProfile;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
    }
}