using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Visual.Programming.Project.Grey.Controls
{
    public class OrderCard : UserControl
    {
        private PictureBox? _picture;
        private Label? _title;
        private Label? _meta;
        private Label? _price;
        private Button? _btnBuyAgain;

        public event EventHandler<string> BuyAgainClicked;

        public OrderCard()
        {
            InitializeControls();
            Theme.StyleButton(_btnBuyAgain);
        }

        private void InitializeControls()
        {
            this.Height = 100;
            this.Width = 800;
            this.BackColor = Theme.CardBackground;

            _picture = new PictureBox { Size = new Size(84, 84), Location = new Point(10, 8), SizeMode = PictureBoxSizeMode.Zoom };
            _title = new Label { Location = new Point(110, 10), Size = new Size(420, 24), Font = Theme.TitleFont };
            _meta = new Label { Location = new Point(110, 36), Size = new Size(420, 20), Font = Theme.BodyFont, ForeColor = Theme.MutedText };
            _price = new Label { Location = new Point(560, 20), AutoSize = true, Font = new Font("Segoe UI", 12F, FontStyle.Bold), ForeColor = Theme.Accent };
            _btnBuyAgain = new Button { Text = "Buy It Again", Size = new Size(120, 34), Location = new Point(560, 54), BackColor = Theme.Accent };

            _btnBuyAgain.Click += (s, e) => BuyAgainClicked?.Invoke(this, ProductName);

            this.Controls.Add(_picture);
            this.Controls.Add(_title);
            this.Controls.Add(_meta);
            this.Controls.Add(_price);
            this.Controls.Add(_btnBuyAgain);

            UIHelper.AddHoverEffect(this, Color.FromArgb(248, 248, 248), Theme.CardBackground);
        }

        private void InitializeComponent()
        {
            SuspendLayout();
            // 
            // OrderCard
            // 
            Name = "OrderCard";
            Size = new Size(166, 237);
            ResumeLayout(false);

        }

        // Properties to set
        public string ProductName { get; private set; }

        public void SetData(string productName, string customer, DateTime date, string priceDisplay, string imagePath)
        {
            ProductName = productName;
            _title.Text = productName;
            _meta.Text = customer + " • " + date.ToShortDateString();
            _price.Text = priceDisplay;

            if (!string.IsNullOrWhiteSpace(imagePath) && File.Exists(imagePath))
            {
                try { _picture.Image = Image.FromFile(imagePath); }
                catch { _picture.Image = Properties.Resources.batman; }
            }
            else
            {
                _picture.Image = Properties.Resources.batman;
            }
        }
    }
}
