using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Visual.Programming.Project.Grey
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // populate orders when form loads
            YourOrder_Load(sender, e);
        }

        private void YourOrder_Load(object sender, EventArgs e)
        {
            flowPanelOrders.Controls.Clear();

            foreach (var order in OrderManager.Orders)
            {
                Panel itemPanel = new Panel();
                itemPanel.Width = flowPanelOrders.Width - 30;
                itemPanel.Height = 60;
                itemPanel.BorderStyle = BorderStyle.FixedSingle;
                itemPanel.Margin = new Padding(5);

                Label lbl = new Label();
                lbl.Text = order.ProductName + "\n" + order.CustomerName;
                lbl.AutoSize = false;
                lbl.Width = 300;
                lbl.Height = 50;
                lbl.Location = new Point(10, 5);
                lbl.Font = new Font("Segoe UI", 9, FontStyle.Bold);

                Button btnBuyAgain = new Button();
                btnBuyAgain.Text = "Buy It Again";
                btnBuyAgain.Width = 130;
                btnBuyAgain.Height = 35;
                btnBuyAgain.Location = new Point(330, 12);
                btnBuyAgain.BackColor = Color.Orange;
                btnBuyAgain.Tag = order.ProductName;
                btnBuyAgain.Click += BtnBuyAgain_Click;

                itemPanel.Controls.Add(lbl);
                itemPanel.Controls.Add(btnBuyAgain);

                flowPanelOrders.Controls.Add(itemPanel);
            }
        }

        private void BtnBuyAgain_Click(object sender, EventArgs e)
        {
            Button clickedBtn = (Button)sender;
            string productName = clickedBtn.Tag.ToString();

            OrderManager.Orders.Add(new Order
            {
                ProductName = productName,
                CustomerName = "Repeat Customer",
                Email = ""
            });

            MessageBox.Show($"{productName}\n\nYou bought this product again successfully!",
                "Order Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);

            YourOrder_Load(sender, e);   // list ko refresh kar do naye order ke saath
        }

        private void panelBanner_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form4 yourOrderForm = new Form4();
            yourOrderForm.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AllProducts dealsForm = new AllProducts();
            dealsForm.Show();

        }
    }
}
