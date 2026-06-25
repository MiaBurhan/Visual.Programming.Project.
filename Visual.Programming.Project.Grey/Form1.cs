using System.Runtime.CompilerServices;

namespace Visual.Programming.Project.Grey
{
    public partial class HomeForm : Form
    {
        public HomeForm() => InitializeComponent();


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
            ProductsForm productsForm = new ProductsForm(); 
            productsForm.Show();
        }

        private void btnAddToCart1_Click(object sender, EventArgs e)
        {
            if (sender is Button clickedButton)
            {
                string productName = clickedButton.Tag?.ToString() ?? "Product";

                Form3 cartForm = new Form3();
                cartForm.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sender is Button clickedButton)
            {
                string productName = clickedButton.Tag?.ToString() ?? "Product";

                Form3 cartForm = new Form3();
                cartForm.ShowDialog();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (sender is Button clickedButton)
            {
                string productName = clickedButton.Tag?.ToString() ?? "Product";

                Form3 cartForm = new Form3();
                cartForm.ShowDialog();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Open the orders form - use Form4 as the orders dialog
            Form4 yourOrderForm = new Form4();
            yourOrderForm.ShowDialog();
        }
    }
}
