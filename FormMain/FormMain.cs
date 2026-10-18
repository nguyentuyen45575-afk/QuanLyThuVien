
using System;
using System.Windows.Forms;

namespace FormMain
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        // Nút Quản lý sách
        private void btnSach_Click(object sender, EventArgs e)
        {

        }

        // Nút Quản lý độc giả
        private void btnDocGia_Click(object sender, EventArgs e)
        {

        }

        // Nút Trang chủ
        private void btnTrangChu_Click(object sender, EventArgs e)
        {

        }

        // Nút Thống kê
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Chức năng thống kê chưa được triển khai.",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // Nút Đăng xuất
        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn đăng xuất?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}

