using System;
using System.Drawing;
using System.Windows.Forms;

namespace Visual.Programming.Project.Grey
{
    internal static class UIHelper
    {
        // Adds a hover effect to a control
        public static void AddHoverEffect(Control control, Color hoverBack, Color normalBack)
        {
            control.MouseEnter += (s, e) => control.BackColor = hoverBack;
            control.MouseLeave += (s, e) => control.BackColor = normalBack;
        }

        // Make panel responsive when parent resizes
        public static void AnchorToAll(Control control)
        {
            control.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        }

        // Helper to convert resource bitmap to icon
        public static Icon IconFromResourceBitmap(System.Drawing.Bitmap bmp)
        {
            if (bmp == null) return SystemIcons.Application;
            try
            {
                return Icon.FromHandle(bmp.GetHicon());
            }
            catch
            {
                return SystemIcons.Application;
            }
        }

        // Apply button styles across a container
        public static void ApplyButtonStyles(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is Button btn)
                {
                    Theme.StyleButton(btn);
                    AddHoverEffect(btn, ControlPaint.Dark(Theme.Accent), Theme.Accent);
                }

                if (c.HasChildren)
                    ApplyButtonStyles(c);
            }
        }
    }
}
