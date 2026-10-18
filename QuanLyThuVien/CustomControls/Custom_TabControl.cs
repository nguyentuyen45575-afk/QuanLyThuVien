using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class Custom_TabControl : TabControl
{
    private Color activeTabColor = Color.FromArgb(52, 152, 219);
    private Color inactiveTabColor = Color.FromArgb(150, 150, 150);
    private Color backgroundColor = Color.White;

    public Color ActiveTabColor
    {
        get => activeTabColor;
        set { activeTabColor = value; Invalidate(); }
    }

    public Custom_TabControl()
    {
        this.SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint |
                      ControlStyles.OptimizedDoubleBuffer, true);
        this.Appearance = TabAppearance.FlatButtons;
        this.ItemSize = new Size(120, 45);
        this.SizeMode = TabSizeMode.Fixed;
        this.Font = new Font("Segoe UI", 12, FontStyle.Bold);
        this.BackColor = backgroundColor;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        Graphics g = e.Graphics;
        g.SmoothingMode = SmoothingMode.AntiAlias;

        for (int i = 0; i < this.TabCount; i++)
        {
            Rectangle tabRect = this.GetTabRect(i);
            bool isSelected = (i == this.SelectedIndex);

            // Vẽ background tab
            using (SolidBrush brush = new SolidBrush(backgroundColor))
            {
                g.FillRectangle(brush, tabRect);
            }

            // Vẽ gạch dưới cho tab active
            if (isSelected)
            {
                using (SolidBrush brush = new SolidBrush(activeTabColor))
                {
                    g.FillRectangle(brush, tabRect.X, tabRect.Bottom - 3,
                        tabRect.Width, 3);
                }
            }

            // Vẽ text
            Color textColor = isSelected ? activeTabColor : inactiveTabColor;
            using (SolidBrush textBrush = new SolidBrush(textColor))
            {
                using (StringFormat sf = new StringFormat())
                {
                    sf.Alignment = StringAlignment.Center;
                    sf.LineAlignment = StringAlignment.Center;
                    g.DrawString(this.TabPages[i].Text, this.Font, textBrush,
                        tabRect, sf);
                }
            }
        }
    }
}