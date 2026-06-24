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
            InitializeComponent();




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
            deals dealsForm = new deals();
            dealsForm.Show();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }
    }
}
