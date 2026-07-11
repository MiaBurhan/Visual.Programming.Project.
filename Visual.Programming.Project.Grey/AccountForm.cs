using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
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

   

        private void button1_Click_1(object sender, EventArgs e)
        {

            using (SqlConnection con = new SqlConnection(Database.connectionString))
            {
                con.Open();

                string query = @"INSERT INTO Users
                        (Username, Email, Address, DebitCard, Password)
                        VALUES
                        (@Username,@Email,@Address,@DebitCard,@Password)";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@Username", textBox1.Text);
                cmd.Parameters.AddWithValue("@Email", textBox2.Text);
                cmd.Parameters.AddWithValue("@Address", textBox4.Text);
                cmd.Parameters.AddWithValue("@DebitCard", textBox5.Text);
                cmd.Parameters.AddWithValue("@Password", textBox3.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Account Created Successfully!");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private bool isFormatting = false;
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (isFormatting) return;
            isFormatting = true;

            TextBox tb = (TextBox)sender;
            int cursorPos = tb.SelectionStart;
            int oldLength = tb.Text.Length;

            // Keep only digits
            string digitsOnly = new string(tb.Text.Where(char.IsDigit).ToArray());

            // Limit to 16 digits max
            if (digitsOnly.Length > 16)
                digitsOnly = digitsOnly.Substring(0, 16);

            // Insert dash after every 4 digits
            string formatted = string.Empty;
            for (int i = 0; i < digitsOnly.Length; i++)
            {
                if (i > 0 && i % 4 == 0)
                    formatted += "-";
                formatted += digitsOnly[i];
            }

            tb.Text = formatted;

            // Adjust cursor position after formatting
            int newLength = tb.Text.Length;
            int diff = newLength - oldLength;
            int newCursorPos = cursorPos + diff;

            if (newCursorPos < 0) newCursorPos = 0;
            if (newCursorPos > tb.Text.Length) newCursorPos = tb.Text.Length;

            tb.SelectionStart = newCursorPos;

            isFormatting = false;
        }
    }
}
