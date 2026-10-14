
using System;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FormMain
{
    public partial class UserManagement : UserControl
    {
        private DataTable dtDocGia;
        private int maTiepTheo = 1;
        private bool dangHienThiTimKiem = false;

        public UserManagement()
        {
            InitializeComponent();

            KhoiTaoDuLieu();
            CauHinhBang();
            GanSuKien();
            LamMoi();
            HienThiDanhSach();
        }

        // Khởi tạo dữ liệu
        private void KhoiTaoDuLieu()
        {
            dtDocGia = new DataTable();

            dtDocGia.Columns.Add("MaDocGia", typeof(int));
            dtDocGia.Columns.Add("HoTen", typeof(string));
            dtDocGia.Columns.Add("Date", typeof(DateTime));
            dtDocGia.Columns.Add("Gender", typeof(string));
            dtDocGia.Columns.Add("Address", typeof(string));
            dtDocGia.Columns.Add("PhoneNumber", typeof(string));
            dtDocGia.Columns.Add("Email", typeof(string));
            dtDocGia.Columns.Add("NgayLapThe", typeof(DateTime));
            dtDocGia.Columns.Add("Status", typeof(string));

            cboStatus.Items.Clear();
            cboStatus.Items.Add("Tất cả");
            cboStatus.Items.Add("Đang hoạt động");
            cboStatus.Items.Add("Đã khóa");
            cboStatus.SelectedIndex = 0;
        }

        // Cấu hình DataGridView có sẵn trong Designer
        private void CauHinhBang()
        {
            dgvUsers.AutoGenerateColumns = false;

            MaDocGia.DataPropertyName = "MaDocGia";
            HoTen.DataPropertyName = "HoTen";
            Date.DataPropertyName = "Date";
            Gender.DataPropertyName = "Gender";
            Address.DataPropertyName = "Address";
            PhoneNumber.DataPropertyName = "PhoneNumber";
            Email.DataPropertyName = "Email";
            NgayLapThe.DataPropertyName = "NgayLapThe";
            Status.DataPropertyName = "Status";

            Date.DefaultCellStyle.Format = "dd/MM/yyyy";
            NgayLapThe.DefaultCellStyle.Format = "dd/MM/yyyy";

            dgvUsers.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.MultiSelect = false;
            dgvUsers.ReadOnly = true;
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dateTimePicker1.MaxDate = DateTime.Today;
            dateTimePicker1.Value = DateTime.Today.AddYears(-18);

            dateTimePicker2.MaxDate = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today;
        }

        // Gắn sự kiện cho các nút
        private void GanSuKien()
        {
            btnThem.Click += btnThem_Click;
            button1.Click += button1_Click;
            button2.Click += button2_Click;
            button3.Click += button3_Click;
            btnSearch.Click += btnSearch_Click;

            dgvUsers.CellClick += dgvUsers_CellClick;

            txtSearch.KeyDown += txtSearch_KeyDown;
            cboStatus.SelectedIndexChanged += cboStatus_SelectedIndexChanged;
        }

        // Hiển thị danh sách và tổng số
        private void HienThiDanhSach(DataTable bang = null)
        {
            DataTable duLieu = bang ?? dtDocGia;

            dgvUsers.DataSource = null;
            dgvUsers.DataSource = duLieu;

            textBox4.Text = duLieu.Rows.Count.ToString();
        }

        // Kiểm tra dữ liệu
        private bool KiemTraDuLieu()
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên độc giả!");
                txtHoTen.Focus();
                return false;
            }

            if (comboBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn giới tính!");
                comboBox1.Focus();
                return false;
            }

            string sdt = textBox3.Text.Trim();

            if (!Regex.IsMatch(sdt, @"^[0-9]{10,11}$"))
            {
                MessageBox.Show(
                    "Số điện thoại phải gồm 10 hoặc 11 chữ số!");
                textBox3.Focus();
                return false;
            }

            string email = textBox2.Text.Trim();

            if (email != "" &&
                !Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Email không hợp lệ!");
                textBox2.Focus();
                return false;
            }

            if (dateTimePicker1.Value.Date >= DateTime.Today)
            {
                MessageBox.Show("Ngày sinh phải trước ngày hiện tại!");
                return false;
            }

            return true;
        }

        // Kiểm tra số điện thoại và email trùng
        private bool KiemTraTrung(int? maBoQua = null)
        {
            string sdt = textBox3.Text.Trim();
            string email = textBox2.Text.Trim();

            foreach (DataRow row in dtDocGia.Rows)
            {
                int ma = Convert.ToInt32(row["MaDocGia"]);

                if (maBoQua.HasValue && ma == maBoQua.Value)
                    continue;

                if (row["PhoneNumber"].ToString() == sdt)
                {
                    MessageBox.Show("Số điện thoại đã tồn tại!");
                    return false;
                }

                if (email != "" &&
                    string.Equals(
                        row["Email"].ToString(),
                        email,
                        StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Email đã tồn tại!");
                    return false;
                }
            }

            return true;
        }

        // Thêm độc giả
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!KiemTraDuLieu() || !KiemTraTrung())
                return;

            dtDocGia.Rows.Add(
                maTiepTheo++,
                txtHoTen.Text.Trim(),
                dateTimePicker1.Value.Date,
                comboBox1.Text.Trim(),
                textBox1.Text.Trim(),
                textBox3.Text.Trim(),
                textBox2.Text.Trim(),
                dateTimePicker2.Value.Date,
                "Đang hoạt động"
            );

            CapNhatVaLamMoi();

            MessageBox.Show("Thêm độc giả thành công!");
        }

        // Lấy mã độc giả đang chọn
        private int? LayMaDangChon()
        {
            if (dgvUsers.CurrentRow == null ||
                dgvUsers.CurrentRow.IsNewRow)
                return null;

            object value =
                dgvUsers.CurrentRow.Cells["MaDocGia"].Value;

            if (value == null || value == DBNull.Value)
                return null;

            return Convert.ToInt32(value);
        }

        // Sửa độc giả
        private void button2_Click(object sender, EventArgs e)
        {
            int? ma = LayMaDangChon();

            if (ma == null)
            {
                MessageBox.Show("Vui lòng chọn độc giả cần sửa!");
                return;
            }

            if (!KiemTraDuLieu() || !KiemTraTrung(ma))
                return;

            DataRow row = dtDocGia.AsEnumerable()
                .FirstOrDefault(r =>
                    r.Field<int>("MaDocGia") == ma.Value);

            if (row == null)
            {
                MessageBox.Show("Không tìm thấy độc giả!");
                return;
            }

            row["HoTen"] = txtHoTen.Text.Trim();
            row["Date"] = dateTimePicker1.Value.Date;
            row["Gender"] = comboBox1.Text.Trim();
            row["Address"] = textBox1.Text.Trim();
            row["PhoneNumber"] = textBox3.Text.Trim();
            row["Email"] = textBox2.Text.Trim();
            row["NgayLapThe"] = dateTimePicker2.Value.Date;

            CapNhatVaLamMoi();

            MessageBox.Show("Cập nhật độc giả thành công!");
        }

        // Xóa độc giả
        private void button1_Click(object sender, EventArgs e)
        {
            int? ma = LayMaDangChon();

            if (ma == null)
            {
                MessageBox.Show("Vui lòng chọn độc giả cần xóa!");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa độc giả này?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            DataRow row = dtDocGia.AsEnumerable()
                .FirstOrDefault(r =>
                    r.Field<int>("MaDocGia") == ma.Value);

            if (row != null)
                dtDocGia.Rows.Remove(row);

            CapNhatVaLamMoi();

            MessageBox.Show("Xóa độc giả thành công!");
        }

        // Làm mới biểu mẫu
        private void button3_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            dangHienThiTimKiem = false;
            cboStatus.SelectedIndex = 0;

            LamMoi();
            HienThiDanhSach();
        }

        private void LamMoi()
        {
            txtHoTen.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

            comboBox1.SelectedIndex = -1;

            dateTimePicker1.Value =
                DateTime.Today.AddYears(-18);

            dateTimePicker2.Value = DateTime.Today;

            dgvUsers.ClearSelection();
            txtHoTen.Focus();
        }

        private void CapNhatVaLamMoi()
        {
            dangHienThiTimKiem = false;
            HienThiDanhSach();
            LamMoi();
        }

        // Tìm kiếm theo họ tên, số điện thoại, email
        private void btnSearch_Click(object sender, EventArgs e)
        {
            TimKiemDocGia();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                TimKiemDocGia();
            }
        }

        private void TimKiemDocGia()
        {
            string tuKhoa = txtSearch.Text.Trim();

            dangHienThiTimKiem = tuKhoa.Length > 0;
            string trangThai = cboStatus.Text;

            var ketQua = dtDocGia.AsEnumerable().Where(row =>
            {
                string hoTen = row["HoTen"].ToString();
                string sdt = row["PhoneNumber"].ToString();
                string email = row["Email"].ToString();
                string status = row["Status"].ToString();

                bool khopTuKhoa =
                    tuKhoa == "" ||
                    hoTen.IndexOf(
                        tuKhoa, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    sdt.IndexOf(
                        tuKhoa, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    email.IndexOf(
                        tuKhoa, StringComparison.OrdinalIgnoreCase) >= 0;

                bool khopTrangThai =
                    trangThai == "Tất cả" || status == trangThai;

                return khopTuKhoa && khopTrangThai;
            });

            DataTable bangKetQua = dtDocGia.Clone();

            foreach (DataRow row in ketQua)
                bangKetQua.ImportRow(row);

            HienThiDanhSach(bangKetQua);
        }

        // Lọc khi đổi trạng thái
        private void cboStatus_SelectedIndexChanged(
            object sender, EventArgs e)
        {
            if (dtDocGia != null)
                TimKiemDocGia();
        }

        // Chọn một dòng để đưa dữ liệu lên biểu mẫu
        private void dgvUsers_CellClick(
            object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvUsers.Rows[e.RowIndex];

            txtHoTen.Text =
                Convert.ToString(row.Cells["HoTen"].Value);

            textBox1.Text =
                Convert.ToString(row.Cells["Address"].Value);

            textBox2.Text =
                Convert.ToString(row.Cells["Email"].Value);

            textBox3.Text =
                Convert.ToString(row.Cells["PhoneNumber"].Value);

            comboBox1.Text =
                Convert.ToString(row.Cells["Gender"].Value);

            if (row.Cells["Date"].Value != null &&
                row.Cells["Date"].Value != DBNull.Value)
            {
                dateTimePicker1.Value =
                    Convert.ToDateTime(row.Cells["Date"].Value);
            }

            if (row.Cells["NgayLapThe"].Value != null &&
                row.Cells["NgayLapThe"].Value != DBNull.Value)
            {
                dateTimePicker2.Value =
                    Convert.ToDateTime(row.Cells["NgayLapThe"].Value);
            }
        }
    }
}