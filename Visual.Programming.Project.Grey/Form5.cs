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

        private void button7_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (sender is Button clickedButton)
            {
                string productName = clickedButton.Tag?.ToString() ?? "Product";

                Form3 cartForm = new Form3(productName);
                cartForm.ShowDialog();
            }
        }

        private void button6_Click(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
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
            if (sender is Button clickedButton)
            {
                string productName = clickedButton.Tag?.ToString() ?? "Product";

                Form3 cartForm = new Form3(productName);
                cartForm.ShowDialog();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (sender is Button clickedButton)
            {
                string productName = clickedButton.Tag?.ToString() ?? "Product";

                Form3 cartForm = new Form3(productName);
                cartForm.ShowDialog();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (sender is Button clickedButton)
            {
                string productName = clickedButton.Tag?.ToString() ?? "Product";

                Form3 cartForm = new Form3(productName);
                cartForm.ShowDialog();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (sender is Button clickedButton)
            {
                string productName = clickedButton.Tag?.ToString() ?? "Product";

                Form3 cartForm = new Form3(productName);
                cartForm.ShowDialog();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (sender is Button clickedButton)
            {
                string productName = clickedButton.Tag?.ToString() ?? "Product";

                Form3 cartForm = new Form3(productName);
                cartForm.ShowDialog();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (sender is Button clickedButton)
            {
                string productName = clickedButton.Tag?.ToString() ?? "Product";

                Form3 cartForm = new Form3();
                cartForm.ShowDialog();
            }
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
