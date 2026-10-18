using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace QuanlyThuVien.CustomControls
{
    public class Custom_Button : Button
    {
        private int borderRadius = 8;
        private Color hoverColor;
        private Color normalColor;
        private bool isHovering = false;

        public int BorderRadius
        {
            get => borderRadius;
            set { borderRadius = value; Invalidate(); }
        }

        public Color ButtonColor
        {
            get => normalColor;
            set
            {
                normalColor = value;
                int r = Math.Max(0, value.R - 25);
                int g = Math.Max(0, value.G - 25);
                int b = Math.Max(0, value.B - 25);
                hoverColor = Color.FromArgb(r, g, b);
                Invalidate();
            }
        }

        public Custom_Button()
        {
            this.SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.OptimizedDoubleBuffer, true);
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            this.ForeColor = Color.White;
            this.Cursor = Cursors.Hand;
            this.Size = new Size(120, 42);
            this.normalColor = Color.FromArgb(52, 152, 219);
            this.hoverColor = Color.FromArgb(41, 128, 185);
            this.BackColor = normalColor;
        }

        protected override void OnMouseEnter(System.EventArgs e)
        {
            base.OnMouseEnter(e);
            isHovering = true;
            this.Invalidate();
        }

        protected override void OnMouseLeave(System.EventArgs e)
        {
            base.OnMouseLeave(e);
            isHovering = false;
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Color currentColor = isHovering ? hoverColor : normalColor;

            using (SolidBrush brush = new SolidBrush(currentColor))
            {
                g.FillPath(brush, GetRoundedPath(this.ClientRectangle, borderRadius));
            }

            using (StringFormat sf = new StringFormat())
            {
                sf.Alignment = StringAlignment.Center;
                sf.LineAlignment = StringAlignment.Center;
                g.DrawString(this.Text, this.Font, new SolidBrush(this.ForeColor),
                    this.ClientRectangle, sf);
            }
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

            int diameter = radius * 2;
            if (diameter > rect.Width) diameter = rect.Width;
            if (diameter > rect.Height) diameter = rect.Height;

            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();

            return path;
        }

        protected override void OnResize(System.EventArgs e)
        {
            base.OnResize(e);
            this.Invalidate();
        }
    }
}