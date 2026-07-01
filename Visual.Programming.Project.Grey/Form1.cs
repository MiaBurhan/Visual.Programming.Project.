using System;
using System.Drawing;
using System.Windows.Forms;

namespace Visual.Programming.Project.Grey
{
    public partial class HomeForm : Form
    {

        public HomeForm()
        {
            InitializeComponent();
            Theme.ApplyFormStyle(this);
            UIHelper.ApplyButtonStyles(this);
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblBackToTop_Click(object sender, EventArgs e)
        {
            // Scroll the main products flow panel to top
            flowProducts.AutoScrollPosition = new Point(0, 0);
        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void lblName1_Click(object sender, EventArgs e)
        {

        }

        private void panelFooter_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            AccountForm accountForm = new AccountForm();
            accountForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AllProducts dealsForm = new AllProducts();
            dealsForm.Show();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            AllProducts frm = new AllProducts();
            frm.ShowDialog();
        }

        private void btnAddToCart1_Click(object sender, EventArgs e)
        {
            if (sender is Button clickedButton)
            {
                string productName = clickedButton.Tag?.ToString() ?? "Product";

                Form3 cartForm = new Form3(productName);
                cartForm.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sender is Button clickedButton)
            {
                string productName = clickedButton.Tag?.ToString() ?? "Product";

                Form3 cartForm = new Form3(productName);
                cartForm.ShowDialog();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (sender is Button clickedButton)
            {
                string productName = clickedButton.Tag?.ToString() ?? "Product";

                Form3 cartForm = new Form3(productName);
                cartForm.ShowDialog();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Open the orders form - use Form4 as the orders dialog
            Form4 yourOrderForm = new Form4();
            yourOrderForm.ShowDialog();
        }

        private void lblCategory1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnShopNow_Click(object sender, EventArgs e)
        {
            AllProducts frm = new AllProducts();
            frm.ShowDialog();
        }

        private void lblPerks_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void picProduct1_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void label53_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (sender is Button clickedButton)
            {
                string productName = clickedButton.Tag?.ToString() ?? "Product";

                Form3 cartForm = new Form3();
                cartForm.ShowDialog();
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (sender is Button clickedButton)
            {
                string productName = clickedButton.Tag?.ToString() ?? "Product";

                Form3 cartForm = new Form3();
                cartForm.ShowDialog();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (sender is Button clickedButton)
            {
                string productName = clickedButton.Tag?.ToString() ?? "Product";

                Form3 cartForm = new Form3();
                cartForm.ShowDialog();
            }
        }

        private void panelBackToTop_Paint(object sender, PaintEventArgs e)
        {


            this.AutoScrollPosition = new Point(0, 0);

        }

        private void label52_Click(object sender, EventArgs e)
        {

        }
    }
}
