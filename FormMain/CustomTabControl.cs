
using System.Drawing;
using System.Windows.Forms;

namespace FormMain
{
    public class CustomTabControl : TabControl
    {
        public CustomTabControl()
        {
            DrawMode = TabDrawMode.OwnerDrawFixed;
            ItemSize = new Size(150, 40);
            SizeMode = TabSizeMode.Fixed;
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            if (e.Index < 0 || e.Index >= TabPages.Count)
                return;

            Rectangle rect = GetTabRect(e.Index);
            bool selected = e.Index == SelectedIndex;

            Color background = selected
                ? Color.FromArgb(40, 39, 41)
                : Color.White;

            Color foreground = selected
                ? Color.White
                : Color.Black;

            using (Brush brush = new SolidBrush(background))
            {
                e.Graphics.FillRectangle(brush, rect);
            }

            TextRenderer.DrawText(
                e.Graphics,
                TabPages[e.Index].Text,
                Font,
                rect,
                foreground,
                TextFormatFlags.HorizontalCenter |
                TextFormatFlags.VerticalCenter |
                TextFormatFlags.EndEllipsis);
        }
    }
}