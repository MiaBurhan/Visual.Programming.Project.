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
            lblAccountTitle = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblAccountTitle
            // 
            lblAccountTitle.AutoSize = true;
            lblAccountTitle.BackColor = Color.White;
            lblAccountTitle.Font = new Font("Microsoft YaHei", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAccountTitle.Location = new Point(301, 78);
            lblAccountTitle.Margin = new Padding(2, 0, 2, 0);
            lblAccountTitle.Name = "lblAccountTitle";
            lblAccountTitle.Size = new Size(132, 39);
            lblAccountTitle.TabIndex = 0;
            lblAccountTitle.Text = "Sign Up";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(197, 134);
            label1.Name = "label1";
            label1.Size = new Size(109, 30);
            label1.TabIndex = 1;
            label1.Text = "Username";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.ForeColor = Color.FromArgb(35, 47, 62);
            textBox1.Location = new Point(203, 167);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(335, 25);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.ForeColor = Color.FromArgb(35, 47, 62);
            textBox2.Location = new Point(203, 246);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(335, 25);
            textBox2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(197, 213);
            label2.Name = "label2";
            label2.Size = new Size(64, 30);
            label2.TabIndex = 3;
            label2.Text = "Email";
            // 
            // textBox3
            // 
            textBox3.ForeColor = Color.FromArgb(35, 47, 62);
            textBox3.Location = new Point(203, 328);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(335, 25);
            textBox3.TabIndex = 6;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(197, 295);
            label3.Name = "label3";
            label3.Size = new Size(103, 30);
            label3.TabIndex = 5;
            label3.Text = "Password";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(35, 47, 62);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft YaHei", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(204, 390);
            button1.Name = "button1";
            button1.Size = new Size(337, 51);
            button1.TabIndex = 7;
            button1.Text = "Sign Up";
            button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(176, 57);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(384, 422);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(502, 329);
            button2.Name = "button2";
            button2.Size = new Size(30, 23);
            button2.TabIndex = 9;
            button2.Text = "👁";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // AccountForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 47, 62);
            ClientSize = new Size(743, 559);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(lblAccountTitle);
            Controls.Add(pictureBox1);
            Margin = new Padding(2);
            Name = "AccountForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ShopHub - Your Account";
            Load += AccountForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAccountTitle;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private Button button1;
        private PictureBox pictureBox1;
        private Button button2;
    }
}