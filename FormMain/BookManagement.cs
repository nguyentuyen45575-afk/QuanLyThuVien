
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FormMain
{
    public partial class BookManagement : UserControl
    {
        // ==================== DỮ LIỆU SÁCH ====================

        private class Book
        {
            public string MaSach { get; set; }
            public string TenSach { get; set; }
            public string TrangThai { get; set; }
        }

        private class BorrowRecord
        {
            public string MaPhieu { get; set; }
            public string TenDocGia { get; set; }
            public string MaDocGia { get; set; }
            public string MaSach { get; set; }
            public string TenSach { get; set; }
            public DateTime NgayMuon { get; set; }
            public DateTime HanTra { get; set; }
            public DateTime? NgayTra { get; set; }
            public string TrangThai { get; set; }
        }

        private readonly List<Book> books = new List<Book>();
        private readonly List<BorrowRecord> borrowRecords =
            new List<BorrowRecord>();

        // Danh sách độc giả được cung cấp từ UserManagement
        private readonly Dictionary<string, string> readers =
            new Dictionary<string, string>();

        private bool isEditing = false;
        private string editingBookId = "";

        public BookManagement()
        {
            InitializeComponent();

            InitializeTables();
            RegisterEvents();
            RefreshBookList();
            RefreshBorrowList();
            ResetBookForm();
            ResetBorrowForm();
        }

        // ==================== KHỞI TẠO ====================

        private void InitializeTables()
        {
            dgvBooks.AutoGenerateColumns = false;
            dgvBooks.ReadOnly = true;
            dgvBooks.AllowUserToAddRows = false;
            dgvBooks.AllowUserToDeleteRows = false;
            dgvBooks.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dgvBooks.MultiSelect = false;

            dgvMuonTra.AutoGenerateColumns = false;
            dgvMuonTra.ReadOnly = true;
            dgvMuonTra.AllowUserToAddRows = false;
            dgvMuonTra.AllowUserToDeleteRows = false;
            dgvMuonTra.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dgvMuonTra.MultiSelect = false;

            // Sửa tiêu đề cột được đặt tên mặc định trong Designer
            Column1.HeaderText = "Mã độc giả";
        }

        private void RegisterEvents()
        {
            btnSearch.Click += btnSearch_Click;
            txtSearch.KeyDown += txtSearch_KeyDown;

            btnThemSach.Click += btnThemSach_Click;
            button2.Click += button2_Click;
            button3.Click += button3_Click;
            button4.Click += button4_Click;

            dgvBooks.SelectionChanged += dgvBooks_SelectionChanged;

            button1.Click += button1_Click;
            button5.Click += button5_Click;
            button6.Click += button6_Click;
            button7.Click += button7_Click;

            dgvMuonTra.SelectionChanged +=
                dgvMuonTra_SelectionChanged;

            dtpNgayMuon.ValueChanged += dtpNgayMuon_ValueChanged;
        }

        // Gọi hàm này từ FormMain sau khi có danh sách độc giả.
        // maDocGia là mã độc giả, tenDocGia là tên độc giả.
        public void SetReaders(
            IEnumerable<KeyValuePair<string, string>> danhSachDocGia)
        {
            readers.Clear();

            foreach (var reader in danhSachDocGia)
            {
                if (!string.IsNullOrWhiteSpace(reader.Key) &&
                    !string.IsNullOrWhiteSpace(reader.Value))
                {
                    readers[reader.Key] = reader.Value;
                }
            }

            LoadReaderCombo();
        }

        private void LoadReaderCombo()
        {
            cboDocGia.DataSource = null;
            cboDocGia.Items.Clear();

            cboDocGia.DisplayMember = "Value";
            cboDocGia.ValueMember = "Key";

            cboDocGia.DataSource = readers
                .Select(x => new KeyValuePair<string, string>(
                    x.Key, x.Value))
                .ToList();

            cboDocGia.SelectedIndex = -1;
        }

        // ==================== QUẢN LÝ SÁCH ====================

        private void btnThemSach_Click(object sender, EventArgs e)
        {
            string maSach = txtMaSach.Text.Trim();
            string tenSach = txtTenSach.Text.Trim();

            if (maSach == "" || tenSach == "")
            {
                MessageBox.Show(
                    "Vui lòng nhập mã sách và tên sách.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (isEditing)
            {
                MessageBox.Show(
                    "Bạn đang sửa sách. Hãy nhấn nút Sửa để lưu thay đổi.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            if (books.Any(x =>
                x.MaSach.Equals(
                    maSach, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show(
                    "Mã sách đã tồn tại.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            books.Add(new Book
            {
                MaSach = maSach,
                TenSach = tenSach,
                TrangThai = "Có sẵn"
            });

            RefreshBookList();
            ResetBookForm();

            MessageBox.Show("Thêm sách thành công.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Lần đầu nhấn Sửa: chọn sách và chuyển sang chế độ sửa.
            if (!isEditing)
            {
                if (dgvBooks.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn sách cần sửa.");
                    return;
                }

                editingBookId =
                    dgvBooks.SelectedRows[0]
                    .Cells["colMaSach"].Value?.ToString() ?? "";

                Book book = books.FirstOrDefault(
                    x => x.MaSach == editingBookId);

                if (book == null)
                    return;

                txtMaSach.Text = book.MaSach;
                txtTenSach.Text = book.TenSach;

                txtMaSach.ReadOnly = true;
                isEditing = true;

                button2.Text = "Lưu sửa";
                return;
            }

            // Lần tiếp theo nhấn Sửa: lưu thông tin mới.
            string tenSachMoi = txtTenSach.Text.Trim();

            if (tenSachMoi == "")
            {
                MessageBox.Show("Vui lòng nhập tên sách.");
                return;
            }

            Book selectedBook = books.FirstOrDefault(
                x => x.MaSach == editingBookId);

            if (selectedBook == null)
            {
                MessageBox.Show("Không tìm thấy sách cần sửa.");
                ResetBookForm();
                return;
            }

            selectedBook.TenSach = tenSachMoi;

            // Đồng bộ tên sách với các phiếu mượn hiện có.
            foreach (BorrowRecord record in borrowRecords.Where(
                x => x.MaSach == editingBookId))
            {
                record.TenSach = tenSachMoi;
            }

            RefreshBookList();
            RefreshBorrowList();
            ResetBookForm();

            MessageBox.Show("Cập nhật sách thành công.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dgvBooks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sách cần xóa.");
                return;
            }

            string maSach = dgvBooks.SelectedRows[0]
                .Cells["colMaSach"].Value?.ToString() ?? "";

            Book book = books.FirstOrDefault(
                x => x.MaSach == maSach);

            if (book == null)
                return;

            bool dangMuon = borrowRecords.Any(
                x => x.MaSach == maSach && x.NgayTra == null);

            if (dangMuon)
            {
                MessageBox.Show(
                    "Sách đang được mượn, không thể xóa.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa sách này?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            books.Remove(book);

            RefreshBookList();
            ResetBookForm();
            MessageBox.Show("Xóa sách thành công.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ResetBookForm();
            RefreshBookList();
            txtSearch.Clear();
        }

        private void ResetBookForm()
        {
            isEditing = false;
            editingBookId = "";

            txtMaSach.Clear();
            txtTenSach.Clear();

            txtMaSach.ReadOnly = false;
            button2.Text = "Sửa";

            if (dgvBooks != null)
                dgvBooks.ClearSelection();
        }

        // ==================== HIỂN THỊ DANH SÁCH SÁCH ====================

        private void RefreshBookList(string keyword = "")
        {
            string search = keyword.Trim();

            var data = books.Where(x =>
                x.MaSach.IndexOf(
                    search, StringComparison.OrdinalIgnoreCase) >= 0 ||
                x.TenSach.IndexOf(
                    search, StringComparison.OrdinalIgnoreCase) >= 0
            ).ToList();

            dgvBooks.Rows.Clear();

            foreach (Book book in data)
            {
                dgvBooks.Rows.Add(
                    book.MaSach,
                    book.TenSach,
                    book.TrangThai);
            }

            LoadBookCombo();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            RefreshBookList(txtSearch.Text);
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                RefreshBookList(txtSearch.Text);
                e.SuppressKeyPress = true;
            }
        }

        private void dgvBooks_SelectionChanged(
            object sender, EventArgs e)
        {
            if (isEditing || dgvBooks.SelectedRows.Count == 0)
                return;

            DataGridViewRow row = dgvBooks.SelectedRows[0];

            txtMaSach.Text =
                row.Cells["colMaSach"].Value?.ToString() ?? "";

            txtTenSach.Text =
                row.Cells["colTenSach"].Value?.ToString() ?? "";
        }

        private void LoadBookCombo()
        {
            string selectedId = "";

            if (cboSach.SelectedValue != null)
                selectedId = cboSach.SelectedValue.ToString();

            var data = books
                .Where(x => x.TrangThai == "Có sẵn")
                .Select(x => new
                {
                    MaSach = x.MaSach,
                    TenHienThi = x.MaSach + " - " + x.TenSach
                })
                .ToList();

            cboSach.DataSource = null;
            cboSach.Items.Clear();
            cboSach.DisplayMember = "TenHienThi";
            cboSach.ValueMember = "MaSach";
            cboSach.DataSource = data;

            if (data.Any(x => x.MaSach == selectedId))
                cboSach.SelectedValue = selectedId;
            else
                cboSach.SelectedIndex = -1;
        }

        // ==================== QUẢN LÝ MƯỢN / TRẢ ====================

        private void ResetBorrowForm()
        {
            txtMaPhieu.Text = GenerateBorrowId();

            if (cboDocGia.DataSource != null)
                cboDocGia.SelectedIndex = -1;

            if (cboSach.DataSource != null)
                cboSach.SelectedIndex = -1;

            dtpNgayMuon.Value = DateTime.Today;
            lblHanTra.Value = DateTime.Today.AddDays(14);
        }

        private string GenerateBorrowId()
        {
            int number = 1;

            while (borrowRecords.Any(
                x => x.MaPhieu == "PM" + number.ToString("D4")))
            {
                number++;
            }

            return "PM" + number.ToString("D4");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cboDocGia.SelectedIndex < 0 ||
                cboSach.SelectedIndex < 0)
            {
                MessageBox.Show(
                    "Vui lòng chọn độc giả và sách cần mượn.");
                return;
            }

            string maDocGia = cboDocGia.SelectedValue.ToString();
            string tenDocGia = cboDocGia.Text;
            string maSach = cboSach.SelectedValue.ToString();

            Book book = books.FirstOrDefault(
                x => x.MaSach == maSach);

            if (book == null || book.TrangThai != "Có sẵn")
            {
                MessageBox.Show("Sách không còn sẵn để mượn.");
                RefreshBookList();
                return;
            }

            if (dtpNgayMuon.Value.Date > DateTime.Today)
            {
                MessageBox.Show(
                    "Ngày mượn không được ở tương lai.");
                return;
            }

            if (lblHanTra.Value.Date < dtpNgayMuon.Value.Date)
            {
                MessageBox.Show(
                    "Hạn trả phải lớn hơn hoặc bằng ngày mượn.");
                return;
            }

            borrowRecords.Add(new BorrowRecord
            {
                MaPhieu = GenerateBorrowId(),
                MaDocGia = maDocGia,
                TenDocGia = tenDocGia,
                MaSach = book.MaSach,
                TenSach = book.TenSach,
                NgayMuon = dtpNgayMuon.Value.Date,
                HanTra = lblHanTra.Value.Date,
                NgayTra = null,
                TrangThai = "Đang mượn"
            });

            book.TrangThai = "Đang mượn";

            RefreshBookList();
            RefreshBorrowList();
            ResetBorrowForm();

            MessageBox.Show("Lập phiếu mượn thành công.");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BorrowRecord record = GetSelectedBorrowRecord();

            if (record == null)
            {
                MessageBox.Show("Vui lòng chọn phiếu mượn cần trả.");
                return;
            }

            if (record.NgayTra.HasValue)
            {
                MessageBox.Show("Phiếu mượn này đã được trả.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Xác nhận độc giả đã trả sách?",
                "Xác nhận trả sách",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            record.NgayTra = DateTime.Today;
            record.TrangThai = "Đã trả";

            Book book = books.FirstOrDefault(
                x => x.MaSach == record.MaSach);

            if (book != null)
                book.TrangThai = "Có sẵn";

            RefreshBookList();
            RefreshBorrowList();

            MessageBox.Show("Xác nhận trả sách thành công.");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            BorrowRecord record = GetSelectedBorrowRecord();

            if (record == null)
            {
                MessageBox.Show("Vui lòng chọn phiếu cần gia hạn.");
                return;
            }

            if (record.NgayTra.HasValue)
            {
                MessageBox.Show(
                    "Không thể gia hạn phiếu đã trả sách.");
                return;
            }

            record.HanTra = record.HanTra.AddDays(7);

            if (record.HanTra.Date < DateTime.Today)
                record.TrangThai = "Quá hạn";

            RefreshBorrowList();

            MessageBox.Show(
                "Gia hạn thành công thêm 7 ngày.\nHạn trả mới: " +
                record.HanTra.ToString("dd/MM/yyyy"));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ResetBorrowForm();
            RefreshBorrowList();
            RefreshBookList();
        }

        private void dtpNgayMuon_ValueChanged(
            object sender, EventArgs e)
        {
            if (dtpNgayMuon.Value.Date <= lblHanTra.Value.Date)
            {
                // Tự động đề xuất hạn trả sau 14 ngày.
                lblHanTra.Value =
                    dtpNgayMuon.Value.Date.AddDays(14);
            }
        }

        private BorrowRecord GetSelectedBorrowRecord()
        {
            if (dgvMuonTra.SelectedRows.Count == 0)
                return null;

            string maPhieu = dgvMuonTra.SelectedRows[0]
                .Cells["colMaPhieuMuon"].Value?.ToString() ?? "";

            return borrowRecords.FirstOrDefault(
                x => x.MaPhieu == maPhieu);
        }

        private void dgvMuonTra_SelectionChanged(
            object sender, EventArgs e)
        {
            BorrowRecord record = GetSelectedBorrowRecord();

            if (record == null)
                return;

            txtMaPhieu.Text = record.MaPhieu;

            if (readers.ContainsKey(record.MaDocGia))
                cboDocGia.SelectedValue = record.MaDocGia;
            else
                cboDocGia.SelectedIndex = -1;

            if (cboSach.DataSource != null &&
                books.Any(x => x.MaSach == record.MaSach &&
                               x.TrangThai == "Có sẵn"))
            {
                cboSach.SelectedValue = record.MaSach;
            }
            else
            {
                cboSach.SelectedIndex = -1;
            }

            dtpNgayMuon.Value = record.NgayMuon;
            lblHanTra.Value = record.HanTra;
        }

        private void RefreshBorrowList()
        {
            dgvMuonTra.Rows.Clear();

            foreach (BorrowRecord record in borrowRecords)
            {
                string status = record.TrangThai;

                if (!record.NgayTra.HasValue &&
                    record.HanTra.Date < DateTime.Today)
                {
                    status = "Quá hạn";
                }

                dgvMuonTra.Rows.Add(
                    record.MaPhieu,
                    record.TenDocGia,
                    record.MaDocGia,
                    record.TenSach,
                    record.NgayMuon.ToString("dd/MM/yyyy"),
                    record.HanTra.ToString("dd/MM/yyyy"),
                    record.NgayTra.HasValue
                        ? record.NgayTra.Value.ToString("dd/MM/yyyy")
                        : "",
                    status);
            }
        }
    }
}