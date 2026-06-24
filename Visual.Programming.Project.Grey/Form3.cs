using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Visual.Programming.Project.Grey
{
    public partial class Form3 : Form
    {
        private readonly string _productName;
        public Form3()
        {
            InitializeComponent();
        }

        public Form3(string productName) : this()
        {
            _productName = productName ?? string.Empty;
            // Show product name on the form (uses lblLimitedTime label for display)
            try
            {
                lblLimitedTime.Text = "Buy Product: " + _productName;
            }
            catch
            {
                // if label isn't available for some reason, ignore
            }
        }

        private void deals_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnShopNow_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text.Trim();
            string email = textBox2.Text.Trim();

            if (string.IsNullOrEmpty(name) || name == textBox1.PlaceholderText ||
                string.IsNullOrEmpty(email) || email == textBox2.PlaceholderText)
            {
                MessageBox.Show("Please fill all required fields.", "Missing Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show($"{_productName}\n\nYou bought this product successfully!",
                "Order Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }
    }
}
