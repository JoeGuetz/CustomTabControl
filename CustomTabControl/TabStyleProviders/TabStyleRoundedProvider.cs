using System.Drawing;
using System.Drawing.Drawing2D;

namespace System.Windows.Forms
{
    public class TabStyleRoundedProvider : TabStyleProvider
    {
        public TabStyleRoundedProvider(CustomTabControl tabControl) : base(tabControl)
        {
            _FocusTrack = true;
            _Overlap = 0;
            _Radius = 12;
            Padding = new Point(10, 3);
        }

        public override void AddTabBorder(GraphicsPath path, Rectangle tabBounds)
        {
            switch (_TabControl.Alignment)
            {
                case TabAlignment.Top:
                    path.AddLine(tabBounds.X, tabBounds.Bottom, tabBounds.X, tabBounds.Y + _Radius);
                    path.AddArc(tabBounds.X, tabBounds.Y, _Radius * 2, _Radius * 2, 180, 90);
                    path.AddLine(tabBounds.X + _Radius, tabBounds.Y, tabBounds.Right - _Radius, tabBounds.Y);
                    path.AddArc(tabBounds.Right - _Radius * 2, tabBounds.Y, _Radius * 2, _Radius * 2, 270, 90);
                    path.AddLine(tabBounds.Right, tabBounds.Y + _Radius, tabBounds.Right, tabBounds.Bottom);
                    break;

                case TabAlignment.Bottom:
                    path.AddLine(tabBounds.Right, tabBounds.Y, tabBounds.Right, tabBounds.Bottom - _Radius);
                    path.AddArc(tabBounds.Right - _Radius * 2, tabBounds.Bottom - _Radius * 2, _Radius * 2, _Radius * 2, 0, 90);
                    path.AddLine(tabBounds.Right - _Radius, tabBounds.Bottom, tabBounds.X + _Radius, tabBounds.Bottom);
                    path.AddArc(tabBounds.X, tabBounds.Bottom - _Radius + 2, _Radius * 2, _Radius * 2, 90, 90);
                    path.AddLine(tabBounds.X, tabBounds.Bottom - _Radius, tabBounds.X, tabBounds.Y);
                    break;

                case TabAlignment.Left:
                    path.AddLine(tabBounds.Right, tabBounds.Bottom, tabBounds.X + _Radius, tabBounds.Bottom);
                    path.AddArc(tabBounds.X, tabBounds.Bottom - _Radius * 2, _Radius * 2, _Radius * 2, 90, 90);
                    path.AddLine(tabBounds.X, tabBounds.Bottom - _Radius, tabBounds.X, tabBounds.Y + _Radius);
                    path.AddArc(tabBounds.X, tabBounds.Y, _Radius * 2, _Radius * 2, 180, 90);
                    path.AddLine(tabBounds.X + _Radius, tabBounds.Y, tabBounds.Right, tabBounds.Y);
                    break;

                case TabAlignment.Right:
                    path.AddLine(tabBounds.X, tabBounds.Y, tabBounds.Right - _Radius, tabBounds.Y);
                    path.AddArc(tabBounds.Right - _Radius * 2, tabBounds.Y, _Radius + 2, _Radius + 2, 270, 90);
                    path.AddLine(tabBounds.Right, tabBounds.Y + _Radius, tabBounds.Right, tabBounds.Bottom - _Radius);
                    path.AddArc(tabBounds.Right - _Radius * 2, tabBounds.Bottom - _Radius * 2, _Radius * 2, _Radius * 2, 0, 90);
                    path.AddLine(tabBounds.Right - _Radius, tabBounds.Bottom, tabBounds.X, tabBounds.Bottom);
                    break;
            }
        }

    }
}
