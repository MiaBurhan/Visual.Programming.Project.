using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Visual.Programming.Project.Grey.Controls;

namespace Visual.Programming.Project.Grey
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            Theme.ApplyFormStyle(this);

            // style buttons across the form
            ApplyButtonStyles(this);

            // ensure responsive behavior
            flowPanelOrders.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // populate orders when form loads
            YourOrder_Load(sender, e);
        }

        private void ApplyButtonStyles(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is Button btn)
                {
                    Theme.StyleButton(btn);
                    UIHelper.AddHoverEffect(btn, Color.FromArgb(255, 140, 0), Theme.Accent);
                }

                // recurse into containers
                if (c.HasChildren)
                    ApplyButtonStyles(c);
            }
        }

        private void YourOrder_Load(object sender, EventArgs e)
        {
            flowPanelOrders.Controls.Clear();

            foreach (var order in OrderManager.Orders.ToList())
            {
                var card = new OrderCard();
                card.Width = Math.Max(700, flowPanelOrders.ClientSize.Width - 40);
                card.SetData(order.ProductName, order.CustomerName, order.CreatedAt, order.PriceDisplay, order.ImagePath);
                card.BuyAgainClicked += Card_BuyAgainClicked;
                card.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

                flowPanelOrders.Controls.Add(card);
            }
        }

        private void Card_BuyAgainClicked(object sender, string productName)
        {
            // Add order to history
            OrderManager.AddOrder(productName, "Repeat Customer", 0m, "");

            MessageBox.Show($"{productName}\n\nYou bought this product again successfully!",
                "Order Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);

            YourOrder_Load(this, EventArgs.Empty);
        }

        private void panelBanner_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Open your orders (current form) - keep behavior but avoid opening duplicate
            // Bring to front instead
            this.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AllProducts dealsForm = new AllProducts();
            dealsForm.Show();
        }
    }
}
