using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace QuanlyThuVien.CustomControls
{
    public class Custom_Sidebar : Panel
    {
        private List<SidebarItem> items = new List<SidebarItem>();
        private int selectedIndex = -1;
        private int hoverIndex = -1;

        public int SelectedIndex
        {
            get => selectedIndex;
            set { selectedIndex = value; Invalidate(); }
        }

        public List<SidebarItem> Items => items;
        public event EventHandler<int> ItemSelected;

        public Custom_Sidebar()
        {
            this.BackColor = Color.FromArgb(26, 26, 46);
            this.Width = 240;
            this.Dock = DockStyle.Left;
            this.DoubleBuffered = true;
        }

        public void AddItem(string text, string icon = "")
        {
            items.Add(new SidebarItem { Text = text, Icon = icon });
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            int y = 30;
            int itemHeight = 50;
            int padding = 15;

            // Avatar
            Rectangle avatarRect = new Rectangle((this.Width - 60) / 2, y, 60, 60);
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(52, 152, 219)))
            {
                g.FillEllipse(brush, avatarRect);
            }
            using (SolidBrush brush = new SolidBrush(Color.White))
            {
                g.DrawString("👤", new Font("Segoe UI Emoji", 28), brush,
                    avatarRect.X + 10, avatarRect.Y + 8);
            }
            y += 75;

            // Tên thư viện
            using (SolidBrush brush = new SolidBrush(Color.White))
            {
                g.DrawString("Thư Viện", new Font("Segoe UI", 13, FontStyle.Bold), brush,
                    (this.Width - 80) / 2, y);
            }
            y += 35;

            // Separator
            using (Pen pen = new Pen(Color.FromArgb(60, 60, 90), 1))
            {
                g.DrawLine(pen, 20, y, this.Width - 20, y);
            }
            y += 15;

            // Menu items
            for (int i = 0; i < items.Count; i++)
            {
                Rectangle itemRect = new Rectangle(15, y, this.Width - 30, itemHeight);
                bool isSelected = (i == selectedIndex);
                bool isHover = (i == hoverIndex);

                Color bgColor;
                if (isSelected) bgColor = Color.FromArgb(52, 152, 219);
                else if (isHover) bgColor = Color.FromArgb(45, 45, 70);
                else bgColor = Color.Transparent;

                if (bgColor != Color.Transparent)
                {
                    using (SolidBrush brush = new SolidBrush(bgColor))
                    {
                        g.FillPath(brush, GetRoundedPath(itemRect, 8));
                    }
                }

                Color textColor = isSelected ? Color.White : Color.FromArgb(180, 180, 200);
                string displayText = $"{items[i].Icon}  {items[i].Text}";
                g.DrawString(displayText,
                    new Font("Segoe UI", 11, isSelected ? FontStyle.Bold : FontStyle.Regular),
                    new SolidBrush(textColor),
                    itemRect.X + padding, itemRect.Y + (itemHeight - 20) / 2);

                y += itemHeight + 5;
            }

            // Logout
            int logoutY = this.Height - 70;
            Rectangle logoutRect = new Rectangle(15, logoutY, this.Width - 30, itemHeight);
            bool logoutHover = (hoverIndex == items.Count);
            if (logoutHover)
            {
                using (SolidBrush brush = new SolidBrush(Color.FromArgb(244, 67, 54)))
                {
                    g.FillPath(brush, GetRoundedPath(logoutRect, 8));
                }
            }
            g.DrawString("🚪  Đăng xuất",
                new Font("Segoe UI", 11),
                new SolidBrush(logoutHover ? Color.White : Color.FromArgb(180, 180, 200)),
                logoutRect.X + padding, logoutRect.Y + (itemHeight - 20) / 2);
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            int y = 30 + 75 + 35 + 15;
            int itemHeight = 50;

            for (int i = 0; i < items.Count; i++)
            {
                Rectangle itemRect = new Rectangle(15, y, this.Width - 30, itemHeight);
                if (itemRect.Contains(e.Location))
                {
                    selectedIndex = i;
                    this.Invalidate();
                    ItemSelected?.Invoke(this, i);
                    return;
                }
                y += itemHeight + 5;
            }

            int logoutY = this.Height - 70;
            Rectangle logoutRect = new Rectangle(15, logoutY, this.Width - 30, itemHeight);
            if (logoutRect.Contains(e.Location))
            {
                ItemSelected?.Invoke(this, -1);
            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            int y = 30 + 75 + 35 + 15;
            int itemHeight = 50;
            int newHover = -1;

            for (int i = 0; i < items.Count; i++)
            {
                Rectangle itemRect = new Rectangle(15, y, this.Width - 30, itemHeight);
                if (itemRect.Contains(e.Location)) { newHover = i; break; }
                y += itemHeight + 5;
            }

            int logoutY = this.Height - 70;
            Rectangle logoutRect = new Rectangle(15, logoutY, this.Width - 30, itemHeight);
            if (logoutRect.Contains(e.Location)) newHover = items.Count;

            if (newHover != hoverIndex)
            {
                hoverIndex = newHover;
                this.Invalidate();
            }
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            hoverIndex = -1;
            this.Invalidate();
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
    }

    public class SidebarItem
    {
        public string Text { get; set; }
        public string Icon { get; set; }
    }
}