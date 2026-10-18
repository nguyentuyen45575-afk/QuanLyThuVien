using System;
using System.Windows.Forms;
using QuanlyThuVien.Helpers;

namespace QuanlyThuVien
{
    public partial class QuanLySachForm : UserControl
    {
        public QuanLySachForm()
        {
            InitializeComponent();
            LoadSampleData();

            // Gán events
            searchBox.SearchClicked += SearchBox_SearchClicked;
            btnThem.Click += BtnThem_Click;
            btnSua.Click += BtnSua_Click;
            btnXoa.Click += BtnXoa_Click;
            btnLamMoi.Click += BtnLamMoi_Click;
        }

        private void LoadSampleData()
        {
            dgvSach.Rows.Clear();
            dgvSach.Rows.Add("S001", "Lập trình C#", "Có sẵn");
            dgvSach.Rows.Add("S002", "Toán cao cấp", "Đang mượn");
            dgvSach.Rows.Add("S003", "Vật lý đại cương", "Có sẵn");
            dgvSach.Rows.Add("S004", "Hóa học hữu cơ", "Có sẵn");
            dgvSach.Rows.Add("S005", "Lịch sử Việt Nam", "Đang mượn");
        }

        private void SearchBox_SearchClicked(object sender, EventArgs e)
        {
            string keyword = searchBox.SearchText.Trim().ToLower();
            dgvSach.Rows.Clear();

            if (string.IsNullOrEmpty(keyword))
            {
                LoadSampleData();
                return;
            }

            // Tìm kiếm giả lập
            foreach (DataGridViewRow row in dgvSach.Rows)
            {
                string ma = row.Cells["MaSach"].Value?.ToString().ToLower() ?? "";
                string ten = row.Cells["TenSach"].Value?.ToString().ToLower() ?? "";
                if (ma.Contains(keyword) || ten.Contains(keyword))
                {
                    dgvSach.Rows.Add(row.Cells["MaSach"].Value,
                                     row.Cells["TenSach"].Value,
                                     row.Cells["TrangThai"].Value);
                }
            }
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {

        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (dgvSach.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn sách cần sửa!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtTenSach.Text))
            {
                MessageBox.Show("Vui lòng nhập tên sách!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dgvSach.CurrentRow.Cells["TenSach"].Value = txtTenSach.Text;
            MessageBox.Show("Sửa thông tin thành công!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (dgvSach.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn sách cần xóa!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show($"Bạn có chắc muốn xóa sách '{dgvSach.CurrentRow.Cells["TenSach"].Value}'?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dgvSach.Rows.Remove(dgvSach.CurrentRow);
                MessageBox.Show("Xóa thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaSach.Text = "";
            txtTenSach.Text = "";
            dgvSach.ClearSelection();
            LoadSampleData();
        }
    }
}