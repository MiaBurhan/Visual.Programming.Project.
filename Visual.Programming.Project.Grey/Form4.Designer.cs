namespace Visual.Programming.Project.Grey
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            panelBanner = new Panel();
            label5 = new Label();
            panel1 = new Panel();
            flowPanelOrders = new FlowLayoutPanel();
            panelBanner.SuspendLayout();
            SuspendLayout();
            // 
            // panelBanner
            // 
            panelBanner.BackColor = Color.FromArgb(35, 47, 62);
            panelBanner.Controls.Add(label5);
            panelBanner.Controls.Add(panel1);
            panelBanner.Location = new Point(1, -1);
            panelBanner.Margin = new Padding(2);
            panelBanner.Name = "panelBanner";
            panelBanner.Size = new Size(885, 132);
            panelBanner.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Calibri", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(309, 48);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(274, 45);
            label5.TabIndex = 26;
            label5.Text = "Your Orders Cart";
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Location = new Point(11, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(151, 139);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // flowPanelOrders
            // 
            flowPanelOrders.AutoScroll = true;
            flowPanelOrders.Location = new Point(7, 143);
            flowPanelOrders.Margin = new Padding(2);
            flowPanelOrders.Name = "flowPanelOrders";
            flowPanelOrders.Size = new Size(868, 564);
            flowPanelOrders.TabIndex = 2;
            flowPanelOrders.Paint += flowPanelOrders_Paint;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(882, 714);
            Controls.Add(flowPanelOrders);
            Controls.Add(panelBanner);
            Margin = new Padding(2);
            Name = "Form4";
            Text = "Your order ";
            Load += Form4_Load;
            panelBanner.ResumeLayout(false);
            panelBanner.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelBanner;
        private FlowLayoutPanel flowPanelOrders;
        private Panel panel1;
        private Label label5;
    }
}