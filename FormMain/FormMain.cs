
using System;
using System.Windows.Forms;

namespace FormMain
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            // Đưa hai giao diện vào panel chứa nội dung
            if (!panel1.Controls.Contains(bookManagement1))
            {
                panel1.Controls.Add(bookManagement1);
            }

            if (!panel1.Controls.Contains(userManagement1))
            {
                panel1.Controls.Add(userManagement1);
            }

            // Mặc định hiển thị giao diện Quản lý sách
            HienThiManHinh(bookManagement1);
        }

        // Hiển thị một UserControl trong panel1
        private void HienThiManHinh(Control manHinh)
        {
            bookManagement1.Visible = false;
            userManagement1.Visible = false;

            if (!panel1.Controls.Contains(manHinh))
            {
                panel1.Controls.Add(manHinh);
            }

            manHinh.Dock = DockStyle.Fill;
            manHinh.Visible = true;
            manHinh.BringToFront();
        }

        // Nút Quản lý sách
        private void btnSach_Click(object sender, EventArgs e)
        {
            HienThiManHinh(bookManagement1);
        }

        // Nút Quản lý độc giả
        private void btnDocGia_Click(object sender, EventArgs e)
        {
            HienThiManHinh(userManagement1);
        }

        // Nút Trang chủ
        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            HienThiManHinh(bookManagement1);
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

