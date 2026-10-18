using QuanlyThuVien.Helpers;
using System;
using System.Data.SqlTypes;
using System.Windows.Forms;

namespace QuanlyThuVien
{
    public partial class HomePage : UserControl
    {
        public HomePage()
        {
            InitializeComponent();
            LoadData();

            // Cập nhật thời gian thực
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += (s, e) => lblDateTime.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            timer.Start();
        }

        private void LoadData()
        {
            dgvRecent.Rows.Clear();
            dgvRecent.Rows.Add("PM0001", "Nguyễn Văn A", "Lập trình C#", "Đang mượn");
            dgvRecent.Rows.Add("PM0002", "Trần Thị B", "Toán cao cấp", "Đã trả");
            dgvRecent.Rows.Add("PM0003", "Lê Văn C", "Vật lý đại cương", "Quá hạn");
        }

        private void btnLapPhieu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chuyển đến form lập phiếu mượn!", "Thông báo");
        }

        private void btnXacNhanTra_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chuyển đến form xác nhận trả sách!", "Thông báo");
        }

        private void btnThemDocGia_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chuyển đến form thêm độc giả!", "Thông báo");
        }
    }
}