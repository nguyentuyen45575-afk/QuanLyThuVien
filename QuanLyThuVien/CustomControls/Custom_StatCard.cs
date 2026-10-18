using QuanlyThuVien.Helpers;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace QuanlyThuVien.CustomControls
{
    public class Custom_StatCard : Panel
    {
        public string Title { get; set; } = "Title";
        public string Value { get; set; } = "0";
        public string Icon { get; set; } = "📊";
        public Color CardColor { get; set; } = AppColor.Primary;

        public Custom_StatCard()
        {
            this.Size = new Size(240, 120);
            this.BackColor = Color.White;
            this.DoubleBuffered = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = this.ClientRectangle;

            using (GraphicsPath path = GetRoundedPath(rect, 12))
            {
                using (SolidBrush brush = new SolidBrush(Color.White))
                {
                    g.FillPath(brush, path);
                }
                using (Pen pen = new Pen(Color.FromArgb(30, 0, 0, 0), 1))
                {
                    g.DrawPath(pen, path);
                }
            }

            Rectangle colorBar = new Rectangle(0, 0, 6, rect.Height);
            using (SolidBrush brush = new SolidBrush(CardColor))
            {
                g.FillRectangle(brush, colorBar);
            }

            g.DrawString(Icon, new Font("Segoe UI Emoji", 28),
                new SolidBrush(CardColor), 20, 15);

            g.DrawString(Title, new Font("Segoe UI", 10),
                new SolidBrush(AppColor.TextSecondary), 80, 20);

            g.DrawString(Value, new Font("Segoe UI", 22, FontStyle.Bold),
                new SolidBrush(AppColor.TextPrimary), 80, 48);
        }

        private GraphicsPath GetRoundedPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            int maxRadius = Math.Min(rect.Width, rect.Height) / 2;
            radius = Math.Min(radius, maxRadius);

            if (radius <= 0)
            {
                path.AddRectangle(rect);
                return path;
            }

            int d = radius * 2;
            if (d > rect.Width) d = rect.Width;
            if (d > rect.Height) d = rect.Height;

            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
            path.CloseFigure();

            return path;
        }
    }
}