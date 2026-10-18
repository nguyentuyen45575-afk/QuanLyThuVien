using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace QuanlyThuVien.CustomControls
{
    public class Custom_TextBox : TextBox
    {
        private string placeholderText = "";
        private Color placeholderColor = Color.FromArgb(180, 180, 180);
        private Color borderColor = Color.FromArgb(200, 200, 200);
        private Color borderColorFocus = Color.FromArgb(52, 152, 219);
        private int borderRadius = 6;
        private int borderWidth = 1;
        private bool isFocused = false;

        public string PlaceholderText
        {
            get => placeholderText;
            set { placeholderText = value; Invalidate(); }
        }

        public Color BorderColor
        {
            get => borderColor;
            set { borderColor = value; Invalidate(); }
        }

        public int BorderRadius
        {
            get => borderRadius;
            set { borderRadius = value; Invalidate(); }
        }

        public Custom_TextBox()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
            this.BorderStyle = BorderStyle.None;
            this.Font = new Font("Segoe UI", 11);
            this.BackColor = Color.White;
            this.ForeColor = Color.FromArgb(51, 51, 51);
            this.Size = new Size(250, 40);
        }

        protected override void OnGotFocus(System.EventArgs e)
        {
            base.OnGotFocus(e);
            isFocused = true;
            this.Invalidate();
        }

        protected override void OnLostFocus(System.EventArgs e)
        {
            base.OnLostFocus(e);
            isFocused = false;
            this.Invalidate();
        }

        protected override void OnTextChanged(System.EventArgs e)
        {
            base.OnTextChanged(e);
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            if (string.IsNullOrEmpty(this.Text) && !string.IsNullOrEmpty(placeholderText))
            {
                using (SolidBrush brush = new SolidBrush(placeholderColor))
                {
                    g.DrawString(placeholderText, this.Font, brush,
                        new PointF(12, (this.Height - this.Font.Height) / 2));
                }
            }

            Color currentBorderColor = isFocused ? borderColorFocus : borderColor;
            using (Pen pen = new Pen(currentBorderColor, borderWidth))
            {
                g.DrawPath(pen, GetRoundedPath(this.ClientRectangle, borderRadius));
            }
        }

        private GraphicsPath GetRoundedPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            // ✅ Giới hạn radius không vượt quá nửa kích thước nhỏ nhất
            int maxRadius = Math.Min(rect.Width, rect.Height) / 2;
            radius = Math.Min(radius, maxRadius);

            // Nếu radius = 0, vẽ hình chữ nhật thường
            if (radius <= 0)
            {
                path.AddRectangle(rect);
                return path;
            }

            int diameter = radius * 2;

            // Đảm bảo diameter không vượt quá kích thước
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