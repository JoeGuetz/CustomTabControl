using System.Drawing;
using System.Drawing.Drawing2D;

namespace System.Windows.Forms
{
    public class TabStyleVisualStudioProvider : TabStyleProvider
    {
        public TabStyleVisualStudioProvider(CustomTabControl tabControl) : base(tabControl)
        {
            _FocusTrack = true;
            _Overlap = 0;
            _Radius = 20;
            Padding = new Point(10, 3);
        }

        public override void AddTabBorder(GraphicsPath path, Rectangle tabBounds)
        {
            switch (_TabControl.Alignment)
            {
                case TabAlignment.Top:
                    path.AddLine(tabBounds.X, tabBounds.Bottom, tabBounds.X + tabBounds.Height - 4, tabBounds.Y + 2);
                    path.AddLine(tabBounds.X + tabBounds.Height, tabBounds.Y, tabBounds.Right - 3, tabBounds.Y);
                    path.AddArc(tabBounds.Right - 6, tabBounds.Y, 6, 6, 270, 90);
                    path.AddLine(tabBounds.Right, tabBounds.Y + 3, tabBounds.Right, tabBounds.Bottom);
                    break;

                case TabAlignment.Bottom:
                    path.AddLine(tabBounds.Right, tabBounds.Y, tabBounds.Right, tabBounds.Bottom - 3);
                    path.AddArc(tabBounds.Right - 6, tabBounds.Bottom - 6, 6, 6, 0, 90);
                    path.AddLine(tabBounds.Right - 3, tabBounds.Bottom, tabBounds.X + tabBounds.Height, tabBounds.Bottom);
                    path.AddLine(tabBounds.X + tabBounds.Height - 4, tabBounds.Bottom - 2, tabBounds.X, tabBounds.Y);
                    break;

                case TabAlignment.Left:
                    path.AddLine(tabBounds.Right, tabBounds.Bottom, tabBounds.X + 3, tabBounds.Bottom);
                    path.AddArc(tabBounds.X, tabBounds.Bottom - 6, 6, 6, 90, 90);
                    path.AddLine(tabBounds.X, tabBounds.Bottom - 3, tabBounds.X, tabBounds.Y + tabBounds.Width);
                    path.AddLine(tabBounds.X + 2, tabBounds.Y + tabBounds.Width - 4, tabBounds.Right, tabBounds.Y);
                    break;

                case TabAlignment.Right:
                    path.AddLine(tabBounds.X, tabBounds.Y, tabBounds.Right - 2, tabBounds.Y + tabBounds.Width - 4);
                    path.AddLine(tabBounds.Right, tabBounds.Y + tabBounds.Width, tabBounds.Right, tabBounds.Bottom - 3);
                    path.AddArc(tabBounds.Right - 6, tabBounds.Bottom - 6, 6, 6, 0, 90);
                    path.AddLine(tabBounds.Right - 3, tabBounds.Bottom, tabBounds.X, tabBounds.Bottom);
                    break;
            }
        }

    }
}
