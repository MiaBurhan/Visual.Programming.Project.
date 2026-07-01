using System.Drawing;
using System.Windows.Forms;

namespace Visual.Programming.Project.Grey
{
    internal static class Theme
    {
        public static readonly Color Primary = Color.FromArgb(35, 47, 62);
        public static readonly Color Accent = Color.FromArgb(255, 153, 0);
        public static readonly Color Background = Color.FromArgb(246, 247, 249);
        public static readonly Color CardBackground = Color.White;
        public static readonly Color MutedText = Color.FromArgb(120, 120, 120);

        public static readonly Font HeaderFont = new Font("Segoe UI", 14F, FontStyle.Bold);
        public static readonly Font TitleFont = new Font("Segoe UI", 11F, FontStyle.Bold);
        public static readonly Font BodyFont = new Font("Segoe UI", 9F, FontStyle.Regular);

        // Apply consistent form styling
        public static void ApplyFormStyle(Form form)
        {
            form.BackColor = Background;
            form.ForeColor = Color.Black;
            form.Font = BodyFont;
            form.StartPosition = FormStartPosition.CenterScreen;
            // Apply icon from resources if available
            try
            {
                var bmp = Properties.Resources.batman;
                if (bmp != null)
                {
                    form.Icon = System.Drawing.Icon.FromHandle(bmp.GetHicon());
                }
            }
            catch { }
        }

        // Apply button style
        public static void StyleButton(Button btn)
        {
            btn.BackColor = Accent;
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = BodyFont;
            btn.Cursor = Cursors.Hand;
        }
    }
}
