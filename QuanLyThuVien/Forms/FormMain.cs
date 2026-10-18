using QuanLyThuVien.Forms;
using System;
using System.Windows.Forms;

namespace QuanlyThuVien
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            // Thêm menu items vào sidebar
            sidebar.AddItem("Trang chủ", "🏠");
            sidebar.AddItem("Quản lý sách", "");
            sidebar.AddItem("Quản lý độc giả", "👤");

            // Gán event
            sidebar.ItemSelected += Sidebar_ItemSelected;

            // Cập nhật ngày
            lblDate.Text = DateTime.Now.ToString("dd/MM/yyyy");

            // Load trang chủ mặc định
            LoadPage(0);
        }

        private void Sidebar_ItemSelected(object sender, int index)
        {
            if (index == -1)
            {
                if (MessageBox.Show("Bạn có muốn đăng xuất?", "Xác nhận",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Application.Exit();
                }
                return;
            }
            LoadPage(index);
        }

        private void LoadPage(int index)
        {
            contentPanel.Controls.Clear();

            UserControl page = null;
            switch (index)
            {
                case 0: page = new HomePage(); break;
                case 1: page = new QuanLySachForm(); break;
                case 2: page = new QuanLyDocGiaForm(); break;
            }

            if (page != null)
            {
                page.Dock = DockStyle.Fill;
                contentPanel.Controls.Add(page);
            }
        }
    }
}