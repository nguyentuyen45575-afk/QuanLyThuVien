using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace QuanlyThuVien.CustomControls
{
    public class Custom_SearchBox : Panel
    {
        private Custom_TextBox searchTextBox;
        private Custom_Button searchButton;
        private int borderRadius = 25;

        public string PlaceholderText
        {
            get => searchTextBox.PlaceholderText;
            set => searchTextBox.PlaceholderText = value;
        }

        public string SearchText => searchTextBox.Text;

        public event System.EventHandler SearchClicked;

        public Custom_SearchBox()
        {
            this.Height = 45;
            this.BackColor = Color.White;

            searchTextBox = new Custom_TextBox();
            searchTextBox.PlaceholderText = "Tìm kiếm...";
            searchTextBox.Dock = DockStyle.Fill;
            searchTextBox.BorderRadius = 0;
            searchTextBox.BorderColor = Color.Transparent;
            searchTextBox.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    SearchClicked?.Invoke(this, System.EventArgs.Empty);
            };

            searchButton = new Custom_Button();
            searchButton.Text = "";
            searchButton.Size = new Size(45, 35);
            searchButton.Dock = DockStyle.Right;
            searchButton.ButtonColor = Color.FromArgb(52, 152, 219);
            searchButton.Click += (s, e) => SearchClicked?.Invoke(this, System.EventArgs.Empty);

            this.Controls.Add(searchTextBox);
            this.Controls.Add(searchButton);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            using (Pen pen = new Pen(Color.FromArgb(200, 200, 200), 1))
            {
                g.DrawPath(pen, GetRoundedPath(this.ClientRectangle, borderRadius));
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