using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Visual.Programming.Project.Grey
{
    public partial class AllProducts : Form
    {
        public AllProducts()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            Theme.ApplyFormStyle(this);
            //UIHelper.ApplyButtonStyles(this);

        }

        private void lblProduct1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AllProducts_Load(object sender, EventArgs e)
        {

        }

        // Centralized handler: if user is logged in add directly to orders, otherwise open checkout Form3
        private void TryAddProduct(object sender)
        {
            if (!(sender is Button clickedButton))
                return;

            string productName = clickedButton.Tag?.ToString() ?? "Product";

            if (Session.IsLoggedIn)
            {
                OrderManager.AddOrder(productName, Session.Username, 0m, string.Empty, null);
                MessageBox.Show($"{productName} added to Your Orders.", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // show the orders form
                //var orders = new Form4();
                //orders.Show();
            }
            else
            {
                using Form3 cartForm = new Form3(productName);
                cartForm.ShowDialog();
            }
        }

        private void button7_Click(object sender, EventArgs e) => TryAddProduct(sender);

        private void button1_Click(object sender, EventArgs e) => TryAddProduct(sender);

        private void button2_Click(object sender, EventArgs e) => TryAddProduct(sender);

        private void button6_Click(object sender, EventArgs e) => TryAddProduct(sender);

        private void button3_Click(object sender, EventArgs e) => TryAddProduct(sender);

        private void button4_Click(object sender, EventArgs e) => TryAddProduct(sender);

        private void button5_Click(object sender, EventArgs e) => TryAddProduct(sender);

        private void button8_Click(object sender, EventArgs e) => TryAddProduct(sender);

        private void button9_Click(object sender, EventArgs e) => TryAddProduct(sender);

        private void button10_Click(object sender, EventArgs e) => TryAddProduct(sender);

        private void button11_Click(object sender, EventArgs e) => TryAddProduct(sender);

        private void button12_Click(object sender, EventArgs e)
        {
            // this button previously opened an empty checkout form; preserve behavior for logged-out users
            if (Session.IsLoggedIn)
            {
                MessageBox.Show("No product selected.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var orders = new Form4();
                orders.Show();
            }
            else
            {
                using Form3 cartForm = new Form3();
                cartForm.ShowDialog();
            }
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e) => TryAddProduct(sender);

        private void button2_Click_1(object sender, EventArgs e) => TryAddProduct(sender);

        private void button6_Click_1(object sender, EventArgs e) => TryAddProduct(sender);

        private void button8_Click_1(object sender, EventArgs e) => TryAddProduct(sender);

        private void button9_Click_1(object sender, EventArgs e) => TryAddProduct(sender);

        private void button18_Click(object sender, EventArgs e) => TryAddProduct(sender);

        private void button5_Click_1(object sender, EventArgs e) => TryAddProduct(sender);

        private void button20_Click(object sender, EventArgs e) => TryAddProduct(sender);

        private void button19_Click(object sender, EventArgs e) => TryAddProduct(sender);

        private void button3_Click_1(object sender, EventArgs e) => TryAddProduct(sender);

        private void button4_Click_1(object sender, EventArgs e) => TryAddProduct(sender);


        private void label28_Click(object sender, EventArgs e)
        {
            HomeForm f1 = new HomeForm();
            f1.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
