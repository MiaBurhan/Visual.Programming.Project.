using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Drawing;

namespace Visual.Programming.Project.Grey
{
    public partial class Form3 : Form
    {
        private readonly string _productName;

        public Form3() : this(string.Empty)
        {
            InitializeComponent();
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
            string cardNumber = textBox3.Text.Trim();
            string address = textBox4.Text.Trim();

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
            if (string.IsNullOrWhiteSpace(cardNumber))
            {
                MessageBox.Show("Please enter debit card number.");
                textBox3.Focus();
                return;
            }

            if (!cardNumber.All(char.IsDigit))
            {
                MessageBox.Show("Card number must contain digits only.");
                textBox3.Focus();
                return;
            }

            if (cardNumber.Length != 16)
            {
                MessageBox.Show("Debit card number must be 16 digits.");
                textBox3.Focus();
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
    }
}
    