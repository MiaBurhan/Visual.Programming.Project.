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

            panelBanner.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flowProducts.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        }
        public HomeForm(string username)
        {
            InitializeComponent();
            Theme.ApplyFormStyle(this);
            label11.Text = username;
            panelBanner.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flowProducts.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Maximized;

            // Start at top
            this.AutoScrollPosition = new Point(0, 0);
            flowProducts.AutoScrollPosition = new Point(0, 0);

            timer1.Interval = 20;
            timer1.Start();
        }

        

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        
        private void button8_Click_2(object sender, EventArgs e)
        {
            AccountForm af = new AccountForm();
            af.Show();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            AllProducts all = new AllProducts();
            all.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Form4 yorder = new Form4();
            yorder.Show();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            if (Session.IsLoggedIn)
            {
                MessageBox.Show("No product selected.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //var orders = new Form4();
                //orders.Show();
            }
            else
            {
                Form3 cart = new Form3();
                cart.Show();
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (Session.IsLoggedIn)
            {
                OrderManager.AddOrder(label14.Text, Session.Username, 0m, string.Empty, null);
                MessageBox.Show($"{label14.Text} added to Your Orders.", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //var orders = new Form4();
                //orders.Show();
            }
            else
            {
                Form3 cart = new Form3(label14.Text);
                cart.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Session.IsLoggedIn)
            {
                OrderManager.AddOrder(label9.Text, Session.Username, 0m, string.Empty, null);
                MessageBox.Show($"{label9.Text} added to Your Orders.", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //var orders = new Form4();
                //orders.Show();
            }
            else
            {
                Form3 cart = new Form3(label9.Text);
                cart.Show();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (Session.IsLoggedIn)
            {
                OrderManager.AddOrder(label4.Text, Session.Username, 0m, string.Empty, null);
                MessageBox.Show($"{label4.Text} added to Your Orders.", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //var orders = new Form4();
                //orders.Show();
            }
            else
            {
                Form3 cart = new Form3(label4.Text);
                cart.Show();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (Session.IsLoggedIn)
            {
                OrderManager.AddOrder(label5.Text, Session.Username, 0m, string.Empty, null);
                MessageBox.Show($"{label5.Text} added to Your Orders.", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //var orders = new Form4();
                //orders.Show();
            }
            else
            {
                Form3 cart = new Form3(label5.Text);
                cart.Show();
            }
        }


       

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {

        }


        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            if (Session.IsLoggedIn)
            {
                OrderManager.AddOrder(label8.Text, Session.Username, 0m, string.Empty, null);
                MessageBox.Show($"{label8.Text} added to Your Orders.", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //var orders = new Form4();
                //orders.Show();
            }
            else
            {
                Form3 cart = new Form3(label8.Text);
                cart.Show();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            const int speed = 6;

            lblPerks.Left -= speed;
            lblSubtitle.Left -= speed;

            if (lblPerks.Right <= 0)
            {
                lblPerks.Left = lblSubtitle.Right;
            }

            if (lblSubtitle.Right <= 0)
            {
                lblSubtitle.Left = lblPerks.Right;
            }
        }

        private void lblPerks_Click_1(object sender, EventArgs e)
        {
        }

        private void button11_Click(object sender, EventArgs e)
        {
            login lg= new login();
            lg.Show();
        }
    }
}
