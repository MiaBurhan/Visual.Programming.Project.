using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Visual.Programming.Project.Grey
{
    public partial class AccountForm : Form
    {
        private Label errorLabel1;
        private Label errorLabel2;
        private Label errorLabel3;
        public AccountForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            // Create inline validation labels placed under existing text boxes
            errorLabel1 = CreateErrorLabel();
            errorLabel2 = CreateErrorLabel();
            errorLabel3 = CreateErrorLabel();

            // position labels if textboxes exist
            if (this.Controls.ContainsKey("textBox1"))
            {
                var tb = this.Controls["textBox1"] as TextBox;
                PlaceLabelUnderControl(tb, errorLabel1);
            }
            if (this.Controls.ContainsKey("textBox2"))
            {
                var tb = this.Controls["textBox2"] as TextBox;
                PlaceLabelUnderControl(tb, errorLabel2);
            }
            if (this.Controls.ContainsKey("textBox3"))
            {
                var tb = this.Controls["textBox3"] as TextBox;
                PlaceLabelUnderControl(tb, errorLabel3);
            }

            // wire submit/save if button1 exists
            if (this.Controls.ContainsKey("button1"))
            {
                var b = this.Controls["button1"] as Button;
                b.Click += Button1_Click;
            }
        }

        private void AccountForm_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.PasswordChar = '*';

        }

        private void button2_Click(object sender, EventArgs e)
        {
        
            if (textBox3.PasswordChar == '*')
            {
                textBox3.PasswordChar = '\0'; 
            }
            else
            {
                textBox3.PasswordChar = '*'; 
            }
        
    }

        private Label CreateErrorLabel()
        {
            return new Label
            {
                AutoSize = true,
                ForeColor = Color.DarkRed,
                Visible = false,
                Text = "Enter data or fill the box",
                Font = new Font(Font.FontFamily, 8f)
            };
        }

        private void PlaceLabelUnderControl(Control ctrl, Label label)
        {
            if (ctrl == null) return;
            label.Left = ctrl.Left;
            label.Top = ctrl.Bottom + 2;
            label.Visible = false;
            ctrl.Parent.Controls.Add(label);
            ctrl.BringToFront();
        }

        private void Button1_Click(object? sender, EventArgs e)
        {
            bool hasError = false;

            // validate textBox1
            if (this.Controls.ContainsKey("textBox1") && string.IsNullOrWhiteSpace((this.Controls["textBox1"] as TextBox)?.Text))
            {
                errorLabel1.Visible = true;
                hasError = true;
            }
            else
            {
                errorLabel1.Visible = false;
            }

            // validate textBox2
            if (this.Controls.ContainsKey("textBox2") && string.IsNullOrWhiteSpace((this.Controls["textBox2"] as TextBox)?.Text))
            {
                errorLabel2.Visible = true;
                hasError = true;
            }
            else
            {
                errorLabel2.Visible = false;
            }

            // validate textBox3
            if (this.Controls.ContainsKey("textBox3") && string.IsNullOrWhiteSpace((this.Controls["textBox3"] as TextBox)?.Text))
            {
                errorLabel3.Visible = true;
                hasError = true;
            }
            else
            {
                errorLabel3.Visible = false;
            }

            if (hasError)
            {
                return;
            }

            // if all valid, save user
            var user = new User
            {
                Name = (this.Controls.ContainsKey("textBox1") ? (this.Controls["textBox1"] as TextBox)?.Text ?? string.Empty : string.Empty),
                Email = (this.Controls.ContainsKey("textBox2") ? (this.Controls["textBox2"] as TextBox)?.Text ?? string.Empty : string.Empty),
                Password = (this.Controls.ContainsKey("textBox3") ? (this.Controls["textBox3"] as TextBox)?.Text ?? string.Empty : string.Empty)
            };

            try
            {
                UserManager.SaveUser(user);
                MessageBox.Show("Account saved successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to save account: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
