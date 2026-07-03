using System;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;

namespace Visual.Programming.Project.Grey
{
    public partial class Form3 : Form
    {
        private readonly string _productName;

        public Form3() : this(string.Empty)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public Form3(string productName)
        {
            InitializeComponent();
            _productName = productName ?? string.Empty;
            lblLimitedTime.Text = string.IsNullOrWhiteSpace(_productName) ? "Buy Product" : "Buy Product: " + _productName;
        }

        private void deals_Load(object sender, EventArgs e)
        {
            // no-op for now
        }

        private void btnShopNow_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text.Trim();
            string email = textBox2.Text.Trim();
            // textBox5 holds the debit card (formatted with dashes), textBox3 holds the address
            string cardNumberRaw = textBox5.Text.Trim();
            string address = textBox3.Text.Trim();

            // Name Validation
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please enter your name.");
                textBox1.Focus();
                return;
            }

            // Email Validation
            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Please enter your email.");
                textBox2.Focus();
                return;
            }

            if (!Regex.IsMatch(email,
                @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Please enter a valid email address.");
                textBox2.Focus();
                return;
            }

            // Card Number Validation
            // Allow formatted input (dashes) in the UI; validate using digits only
            string cardDigits = new string(cardNumberRaw.Where(char.IsDigit).ToArray());

            if (string.IsNullOrWhiteSpace(cardNumberRaw) || cardDigits.Length == 0)
            {
                MessageBox.Show("Please enter debit card number.");
                textBox5.Focus();
                return;
            }

            if (cardDigits.Length != 16)
            {
                MessageBox.Show("Debit card number must be 16 digits.");
                textBox5.Focus();
                return;
            }

            // Address Validation
            if (string.IsNullOrWhiteSpace(address))
            {
                MessageBox.Show("Please enter your address.");
                textBox4.Focus();
                return;
            }

            // Product Validation
            if (string.IsNullOrWhiteSpace(_productName))
            {
                MessageBox.Show("No product selected.");
                return;
            }

            MessageBox.Show(
                $"Product: {_productName}\n\n" +
                $"Customer: {name}\n" +
                $"Email: {email}\n\n" +
                $"Order Placed Successfully!",
                "Order Confirmed",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // placeholder for designer event
        }

        private void label5_Click(object sender, EventArgs e)
        {
            // placeholder for designer event
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panelBanner_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblLimitedTime_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
    