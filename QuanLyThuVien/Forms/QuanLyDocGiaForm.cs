using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien.Forms
{
    public partial class QuanLyDocGiaForm : UserControl
    {
        private int maDGCounter = 3;
        public QuanLyDocGiaForm()
        {
            InitializeComponent();
            LoadSampleData();
        }

        private void LoadSampleData()
        {
            dgvDocGia.Rows.Clear();
            dgvDocGia.Rows.Add("DG001", "Nguyễn Văn A", "15/05/2000", "Nam", "Hà Nội", "0123456789", "a@email.com", "18/10/2026", "Hoạt động");
            dgvDocGia.Rows.Add("DG002", "Trần Thị B", "20/08/1999", "Nữ", "TP.HCM", "0987654321", "b@email.com", "18/10/2026", "Hoạt động");
        }

        private void searchBoxDocGia_SearchClicked(object sender, EventArgs e)
        {
            string keyword = searchBoxDocGia.SearchText.Trim().ToLower();

            if (string.IsNullOrEmpty(keyword))
            {
                LoadSampleData();
                return;
            }

            // Lọc DataGridView
            foreach (DataGridViewRow row in dgvDocGia.Rows)
            {
                string hoTen = row.Cells["HoTen"].Value?.ToString().ToLower() ?? "";
                string sdt = row.Cells["SDT"].Value?.ToString() ?? "";
                string email = row.Cells["Email"].Value?.ToString().ToLower() ?? "";

                row.Visible = hoTen.Contains(keyword) ||
                              sdt.Contains(keyword) ||
                              email.Contains(keyword);
            }
        }

        private void btnThemDG_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maDG = $"DG{maDGCounter:D3}";
            maDGCounter++;

            dgvDocGia.Rows.Add(
                maDG,
                txtHoTen.Text,
                dtpNgaySinh.Value.ToString("dd/MM/yyyy"),
                cbGioiTinh.Text,
                txtDiaChi.Text,
                txtSDT.Text,
                txtEmail.Text,
                dtpNgayLap.Value.ToString("dd/MM/yyyy"),
                "Hoạt động"
            );

            MessageBox.Show("Thêm độc giả thành công!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            ClearInputs();
        }

        private void btnSuaDG_Click(object sender, EventArgs e)
        {
            if (dgvDocGia.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn độc giả cần sửa!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var row = dgvDocGia.CurrentRow;
            row.Cells["HoTen"].Value = txtHoTen.Text;
            row.Cells["GioiTinh"].Value = cbGioiTinh.Text;
            row.Cells["DiaChi"].Value = txtDiaChi.Text;
            row.Cells["SDT"].Value = txtSDT.Text;
            row.Cells["Email"].Value = txtEmail.Text;

            MessageBox.Show("Sửa thông tin thành công!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoaDG_Click(object sender, EventArgs e)
        {
            if (dgvDocGia.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn độc giả cần xóa!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa độc giả này?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dgvDocGia.Rows.Remove(dgvDocGia.CurrentRow);
                MessageBox.Show("Xóa thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputs();
            }
        }

        private void btnLamMoiDG_Click(object sender, EventArgs e)
        {
            ClearInputs();
            dgvDocGia.ClearSelection();
            LoadSampleData();
        }

        private void dgvDocGia_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvDocGia.Rows[e.RowIndex];
            txtHoTen.Text = row.Cells["HoTen"].Value?.ToString() ?? "";
            cbGioiTinh.Text = row.Cells["GioiTinh"].Value?.ToString() ?? "";
            txtDiaChi.Text = row.Cells["DiaChi"].Value?.ToString() ?? "";
            txtSDT.Text = row.Cells["SDT"].Value?.ToString() ?? "";
            txtEmail.Text = row.Cells["Email"].Value?.ToString() ?? "";
        }

        private void ClearInputs()
        {
            txtHoTen.Text = "";
            txtSDT.Text = "";
            txtEmail.Text = "";
            txtDiaChi.Text = "";
            cbGioiTinh.SelectedIndex = -1;
        }
    }
}
