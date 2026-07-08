using System;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Visual.Programming.Project.Grey
{
    public partial class Form3 : Form
    {
        private readonly string _productName;
        internal Order CreatedOrder { get; private set; }

        public Form3() : this(string.Empty)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public Form3(string productName)
        {
            InitializeComponent();
            _productName = productName ?? string.Empty;
            this.StartPosition = FormStartPosition.CenterScreen;
            //lblLimitedTime.Text = string.IsNullOrWhiteSpace(_productName) ? "Buy Product" : "Buy Product: " + _productName;
        }

        private void deals_Load(object sender, EventArgs e)
        {
            // no-op for now
        }

        private void btnShopNow_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text.Trim();
            string email = textBox2.Text.Trim();
            string address = textBox3.Text.Trim();
            string phone = textBox4.Text.Trim();
            string card = textBox5.Text.Trim();

            if (name == "")
            {
                MessageBox.Show("Please enter your name.");
                return;
            }

            if (email == "")
            {
                MessageBox.Show("Please enter your email.");
                return;
            }

            if (address == "")
            {
                MessageBox.Show("Please enter your address.");
                return;
            }

            if (phone == "")
            {
                MessageBox.Show("Please enter your phone number.");
                return;
            }

            if (card == "")
            {
                MessageBox.Show("Please enter your debit card number.");
                return;
            }

            try
            {
                SqlConnection con = new SqlConnection();

                con.Open();

                string sql = @"INSERT INTO Orders
        (
            User_Name,
            User_Email,
            Address,
            Phone,
            Debit_Card,
            Product_Name,
            Product_Price
        )
        VALUES
        (
            @User_Name,
            @User_Email,
            @Address,
            @Phone,
            @Debit_Card,
            @Product_Name,
            @Product_Price
        )";

                SqlCommand cmd = new SqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@User_Name", name);
                cmd.Parameters.AddWithValue("@User_Email", email);
                cmd.Parameters.AddWithValue("@Address", address);
                cmd.Parameters.AddWithValue("@Phone", phone);
                cmd.Parameters.AddWithValue("@Debit_Card", card);

                // Product Name
                cmd.Parameters.AddWithValue("@Product_Name", _productName);

                // Product Price (abhi 0 save hoga)
                cmd.Parameters.AddWithValue("@Product_Price", 0);

                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show(
                    "Order Placed Successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
    