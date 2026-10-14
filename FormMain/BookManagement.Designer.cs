using FormMain;

namespace FormMain
{
    partial class BookManagement
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.customTabControl1 = new CustomTabControl();
            this.tabSach = new System.Windows.Forms.TabPage();
            this.panelBookList = new System.Windows.Forms.Panel();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.colMaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.panelBookButtons = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnThemSach = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.grpThongTinSach = new System.Windows.Forms.GroupBox();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabMuonTra = new System.Windows.Forms.TabPage();
            this.panelMuonTraList = new System.Windows.Forms.Panel();
            this.dgvMuonTra = new System.Windows.Forms.DataGridView();
            this.colMaPhieuMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenDocGiaMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenSachMuonTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHanTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThaiMuonTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.panelMuonTraButtons = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.grpThongTinMuonTra = new System.Windows.Forms.GroupBox();
            this.lblHanTra = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.cboSach = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboDocGia = new System.Windows.Forms.ComboBox();
            this.txtMaPhieu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelTitle.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.customTabControl1.SuspendLayout();
            this.tabSach.SuspendLayout();
            this.panelBookList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.panelBookButtons.SuspendLayout();
            this.grpThongTinSach.SuspendLayout();
            this.tabMuonTra.SuspendLayout();
            this.panelMuonTraList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuonTra)).BeginInit();
            this.panelMuonTraButtons.SuspendLayout();
            this.grpThongTinMuonTra.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.Transparent;
            this.panelTitle.Controls.Add(this.label2);
            this.panelTitle.Controls.Add(this.label1);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(19, 12);
            this.panelTitle.Margin = new System.Windows.Forms.Padding(4);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(910, 81);
            this.panelTitle.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.label2.Location = new System.Drawing.Point(0, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(367, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quản lý thông tin sách và hoạt động mượn trả";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.label1.Location = new System.Drawing.Point(0, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ SÁCH";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.txtSearch);
            this.flowLayoutPanel1.Controls.Add(this.btnSearch);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(19, 93);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(910, 62);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Location = new System.Drawing.Point(16, 14);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(437, 30);
            this.txtSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(461, 14);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(131, 40);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "🔍  Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // customTabControl1
            // 
            this.customTabControl1.Controls.Add(this.tabSach);
            this.customTabControl1.Controls.Add(this.tabMuonTra);
            this.customTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customTabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.customTabControl1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.customTabControl1.ItemSize = new System.Drawing.Size(150, 40);
            this.customTabControl1.Location = new System.Drawing.Point(0, 0);
            this.customTabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.customTabControl1.Name = "customTabControl1";
            this.customTabControl1.SelectedIndex = 0;
            this.customTabControl1.Size = new System.Drawing.Size(910, 622);
            this.customTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.customTabControl1.TabIndex = 2;
            // 
            // tabSach
            // 
            this.tabSach.Controls.Add(this.panelBookList);
            this.tabSach.Controls.Add(this.panelBookButtons);
            this.tabSach.Controls.Add(this.grpThongTinSach);
            this.tabSach.Location = new System.Drawing.Point(4, 44);
            this.tabSach.Margin = new System.Windows.Forms.Padding(4);
            this.tabSach.Name = "tabSach";
            this.tabSach.Padding = new System.Windows.Forms.Padding(4);
            this.tabSach.Size = new System.Drawing.Size(902, 574);
            this.tabSach.TabIndex = 0;
            this.tabSach.Text = "📚 SÁCH  ";
            this.tabSach.UseVisualStyleBackColor = true;
            // 
            // panelBookList
            // 
            this.panelBookList.BackColor = System.Drawing.Color.White;
            this.panelBookList.Controls.Add(this.dgvBooks);
            this.panelBookList.Controls.Add(this.label5);
            this.panelBookList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBookList.Location = new System.Drawing.Point(4, 285);
            this.panelBookList.Margin = new System.Windows.Forms.Padding(4);
            this.panelBookList.Name = "panelBookList";
            this.panelBookList.Padding = new System.Windows.Forms.Padding(12);
            this.panelBookList.Size = new System.Drawing.Size(894, 285);
            this.panelBookList.TabIndex = 8;
            // 
            // dgvBooks
            // 
            this.dgvBooks.AllowUserToAddRows = false;
            this.dgvBooks.AllowUserToDeleteRows = false;
            this.dgvBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBooks.BackgroundColor = System.Drawing.Color.White;
            this.dgvBooks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaSach,
            this.colTenSach,
            this.colTrangThai});
            this.dgvBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBooks.EnableHeadersVisualStyles = false;
            this.dgvBooks.GridColor = System.Drawing.Color.White;
            this.dgvBooks.Location = new System.Drawing.Point(12, 37);
            this.dgvBooks.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBooks.MultiSelect = false;
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.RowHeadersVisible = false;
            this.dgvBooks.RowHeadersWidth = 51;
            this.dgvBooks.RowTemplate.Height = 35;
            this.dgvBooks.RowTemplate.ReadOnly = true;
            this.dgvBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBooks.Size = new System.Drawing.Size(870, 236);
            this.dgvBooks.TabIndex = 3;
            // 
            // colMaSach
            // 
            this.colMaSach.FillWeight = 20F;
            this.colMaSach.HeaderText = "Mã sách";
            this.colMaSach.MinimumWidth = 6;
            this.colMaSach.Name = "colMaSach";
            // 
            // colTenSach
            // 
            this.colTenSach.FillWeight = 55F;
            this.colTenSach.HeaderText = "Tên sách";
            this.colTenSach.MinimumWidth = 6;
            this.colTenSach.Name = "colTenSach";
            // 
            // colTrangThai
            // 
            this.colTrangThai.FillWeight = 25F;
            this.colTrangThai.HeaderText = "Trạng thái";
            this.colTrangThai.MinimumWidth = 6;
            this.colTrangThai.Name = "colTrangThai";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(12, 12);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "DANH SÁCH SÁCH";
            // 
            // panelBookButtons
            // 
            this.panelBookButtons.BackColor = System.Drawing.Color.White;
            this.panelBookButtons.Controls.Add(this.button4);
            this.panelBookButtons.Controls.Add(this.button2);
            this.panelBookButtons.Controls.Add(this.btnThemSach);
            this.panelBookButtons.Controls.Add(this.button3);
            this.panelBookButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBookButtons.Location = new System.Drawing.Point(4, 210);
            this.panelBookButtons.Margin = new System.Windows.Forms.Padding(4);
            this.panelBookButtons.Name = "panelBookButtons";
            this.panelBookButtons.Padding = new System.Windows.Forms.Padding(6, 12, 6, 6);
            this.panelBookButtons.Size = new System.Drawing.Size(894, 75);
            this.panelBookButtons.TabIndex = 7;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Gray;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(456, 12);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(138, 45);
            this.button4.TabIndex = 1;
            this.button4.Text = "Làm mới";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Blue;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(156, 12);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 45);
            this.button2.TabIndex = 5;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnThemSach
            // 
            this.btnThemSach.BackColor = System.Drawing.Color.Black;
            this.btnThemSach.FlatAppearance.BorderSize = 0;
            this.btnThemSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemSach.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemSach.ForeColor = System.Drawing.Color.White;
            this.btnThemSach.Location = new System.Drawing.Point(6, 12);
            this.btnThemSach.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemSach.Name = "btnThemSach";
            this.btnThemSach.Size = new System.Drawing.Size(138, 45);
            this.btnThemSach.TabIndex = 1;
            this.btnThemSach.Text = "+ Thêm";
            this.btnThemSach.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(306, 12);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(138, 45);
            this.button3.TabIndex = 0;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // grpThongTinSach
            // 
            this.grpThongTinSach.BackColor = System.Drawing.Color.White;
            this.grpThongTinSach.Controls.Add(this.txtMaSach);
            this.grpThongTinSach.Controls.Add(this.txtTenSach);
            this.grpThongTinSach.Controls.Add(this.label3);
            this.grpThongTinSach.Controls.Add(this.label4);
            this.grpThongTinSach.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpThongTinSach.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpThongTinSach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.grpThongTinSach.Location = new System.Drawing.Point(4, 4);
            this.grpThongTinSach.Margin = new System.Windows.Forms.Padding(4);
            this.grpThongTinSach.Name = "grpThongTinSach";
            this.grpThongTinSach.Padding = new System.Windows.Forms.Padding(19, 19, 19, 12);
            this.grpThongTinSach.Size = new System.Drawing.Size(894, 206);
            this.grpThongTinSach.TabIndex = 6;
            this.grpThongTinSach.TabStop = false;
            this.grpThongTinSach.Text = "THÔNG TIN SÁCH";
            // 
            // txtMaSach
            // 
            this.txtMaSach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaSach.Location = new System.Drawing.Point(25, 88);
            this.txtMaSach.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(374, 29);
            this.txtMaSach.TabIndex = 0;
            // 
            // txtTenSach
            // 
            this.txtTenSach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenSach.Location = new System.Drawing.Point(450, 88);
            this.txtTenSach.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(374, 29);
            this.txtTenSach.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 56);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã sách";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(450, 56);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên sách";
            // 
            // tabMuonTra
            // 
            this.tabMuonTra.Controls.Add(this.panelMuonTraList);
            this.tabMuonTra.Controls.Add(this.panelMuonTraButtons);
            this.tabMuonTra.Controls.Add(this.grpThongTinMuonTra);
            this.tabMuonTra.Location = new System.Drawing.Point(4, 44);
            this.tabMuonTra.Margin = new System.Windows.Forms.Padding(4);
            this.tabMuonTra.Name = "tabMuonTra";
            this.tabMuonTra.Padding = new System.Windows.Forms.Padding(4);
            this.tabMuonTra.Size = new System.Drawing.Size(902, 574);
            this.tabMuonTra.TabIndex = 1;
            this.tabMuonTra.Text = "📖 MƯỢN / TRẢ";
            this.tabMuonTra.UseVisualStyleBackColor = true;
            // 
            // panelMuonTraList
            // 
            this.panelMuonTraList.BackColor = System.Drawing.Color.White;
            this.panelMuonTraList.Controls.Add(this.dgvMuonTra);
            this.panelMuonTraList.Controls.Add(this.label11);
            this.panelMuonTraList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMuonTraList.Location = new System.Drawing.Point(4, 335);
            this.panelMuonTraList.Margin = new System.Windows.Forms.Padding(4);
            this.panelMuonTraList.Name = "panelMuonTraList";
            this.panelMuonTraList.Padding = new System.Windows.Forms.Padding(12);
            this.panelMuonTraList.Size = new System.Drawing.Size(894, 235);
            this.panelMuonTraList.TabIndex = 2;
            // 
            // dgvMuonTra
            // 
            this.dgvMuonTra.AllowUserToAddRows = false;
            this.dgvMuonTra.AllowUserToDeleteRows = false;
            this.dgvMuonTra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMuonTra.BackgroundColor = System.Drawing.Color.White;
            this.dgvMuonTra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMuonTra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMuonTra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaPhieuMuon,
            this.colTenDocGiaMuon,
            this.Column1,
            this.colTenSachMuonTra,
            this.colNgayMuon,
            this.colHanTra,
            this.colNgayTra,
            this.colTrangThaiMuonTra});
            this.dgvMuonTra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMuonTra.GridColor = System.Drawing.Color.White;
            this.dgvMuonTra.Location = new System.Drawing.Point(12, 37);
            this.dgvMuonTra.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMuonTra.MultiSelect = false;
            this.dgvMuonTra.Name = "dgvMuonTra";
            this.dgvMuonTra.ReadOnly = true;
            this.dgvMuonTra.RowHeadersVisible = false;
            this.dgvMuonTra.RowHeadersWidth = 51;
            this.dgvMuonTra.RowTemplate.Height = 35;
            this.dgvMuonTra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMuonTra.Size = new System.Drawing.Size(870, 186);
            this.dgvMuonTra.TabIndex = 3;
            // 
            // colMaPhieuMuon
            // 
            this.colMaPhieuMuon.HeaderText = "Mã phiếu";
            this.colMaPhieuMuon.MinimumWidth = 6;
            this.colMaPhieuMuon.Name = "colMaPhieuMuon";
            this.colMaPhieuMuon.ReadOnly = true;
            // 
            // colTenDocGiaMuon
            // 
            this.colTenDocGiaMuon.HeaderText = "Độc giả";
            this.colTenDocGiaMuon.MinimumWidth = 6;
            this.colTenDocGiaMuon.Name = "colTenDocGiaMuon";
            this.colTenDocGiaMuon.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // colTenSachMuonTra
            // 
            this.colTenSachMuonTra.HeaderText = "Tên sách";
            this.colTenSachMuonTra.MinimumWidth = 6;
            this.colTenSachMuonTra.Name = "colTenSachMuonTra";
            this.colTenSachMuonTra.ReadOnly = true;
            // 
            // colNgayMuon
            // 
            this.colNgayMuon.HeaderText = "Ngày mượn";
            this.colNgayMuon.MinimumWidth = 6;
            this.colNgayMuon.Name = "colNgayMuon";
            this.colNgayMuon.ReadOnly = true;
            // 
            // colHanTra
            // 
            this.colHanTra.HeaderText = "Hạn trả";
            this.colHanTra.MinimumWidth = 6;
            this.colHanTra.Name = "colHanTra";
            this.colHanTra.ReadOnly = true;
            // 
            // colNgayTra
            // 
            this.colNgayTra.HeaderText = "Ngày trả";
            this.colNgayTra.MinimumWidth = 6;
            this.colNgayTra.Name = "colNgayTra";
            this.colNgayTra.ReadOnly = true;
            // 
            // colTrangThaiMuonTra
            // 
            this.colTrangThaiMuonTra.HeaderText = "Trạng thái";
            this.colTrangThaiMuonTra.MinimumWidth = 6;
            this.colTrangThaiMuonTra.Name = "colTrangThaiMuonTra";
            this.colTrangThaiMuonTra.ReadOnly = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Top;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.label11.Location = new System.Drawing.Point(12, 12);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(247, 25);
            this.label11.TabIndex = 2;
            this.label11.Text = "DANH SÁCH MƯỢN / TRẢ";
            // 
            // panelMuonTraButtons
            // 
            this.panelMuonTraButtons.BackColor = System.Drawing.Color.White;
            this.panelMuonTraButtons.Controls.Add(this.button7);
            this.panelMuonTraButtons.Controls.Add(this.button6);
            this.panelMuonTraButtons.Controls.Add(this.button5);
            this.panelMuonTraButtons.Controls.Add(this.button1);
            this.panelMuonTraButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMuonTraButtons.Location = new System.Drawing.Point(4, 260);
            this.panelMuonTraButtons.Margin = new System.Windows.Forms.Padding(4);
            this.panelMuonTraButtons.Name = "panelMuonTraButtons";
            this.panelMuonTraButtons.Size = new System.Drawing.Size(894, 75);
            this.panelMuonTraButtons.TabIndex = 1;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Green;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(588, 12);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(181, 45);
            this.button7.TabIndex = 3;
            this.button7.Text = "Làm mới";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Gray;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(394, 12);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(181, 45);
            this.button6.TabIndex = 2;
            this.button6.Text = "Gia hạn";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Blue;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(200, 12);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(181, 45);
            this.button5.TabIndex = 1;
            this.button5.Text = "Xác nhận trả";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(6, 12);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "+ Lập phiếu mượn";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // grpThongTinMuonTra
            // 
            this.grpThongTinMuonTra.BackColor = System.Drawing.Color.White;
            this.grpThongTinMuonTra.Controls.Add(this.lblHanTra);
            this.grpThongTinMuonTra.Controls.Add(this.label10);
            this.grpThongTinMuonTra.Controls.Add(this.dtpNgayMuon);
            this.grpThongTinMuonTra.Controls.Add(this.label9);
            this.grpThongTinMuonTra.Controls.Add(this.cboSach);
            this.grpThongTinMuonTra.Controls.Add(this.label8);
            this.grpThongTinMuonTra.Controls.Add(this.cboDocGia);
            this.grpThongTinMuonTra.Controls.Add(this.txtMaPhieu);
            this.grpThongTinMuonTra.Controls.Add(this.label7);
            this.grpThongTinMuonTra.Controls.Add(this.label6);
            this.grpThongTinMuonTra.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpThongTinMuonTra.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpThongTinMuonTra.ForeColor = System.Drawing.Color.Black;
            this.grpThongTinMuonTra.Location = new System.Drawing.Point(4, 4);
            this.grpThongTinMuonTra.Margin = new System.Windows.Forms.Padding(4);
            this.grpThongTinMuonTra.Name = "grpThongTinMuonTra";
            this.grpThongTinMuonTra.Padding = new System.Windows.Forms.Padding(19, 19, 19, 12);
            this.grpThongTinMuonTra.Size = new System.Drawing.Size(894, 256);
            this.grpThongTinMuonTra.TabIndex = 0;
            this.grpThongTinMuonTra.TabStop = false;
            this.grpThongTinMuonTra.Text = "THÔNG TIN MƯỢN / TRẢ";
            // 
            // lblHanTra
            // 
            this.lblHanTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.lblHanTra.Location = new System.Drawing.Point(688, 162);
            this.lblHanTra.Margin = new System.Windows.Forms.Padding(4);
            this.lblHanTra.Name = "lblHanTra";
            this.lblHanTra.Size = new System.Drawing.Size(199, 32);
            this.lblHanTra.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(688, 131);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 25);
            this.label10.TabIndex = 8;
            this.label10.Text = "Hạn Trả";
            // 
            // dtpNgayMuon
            // 
            this.dtpNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayMuon.Location = new System.Drawing.Point(450, 162);
            this.dtpNgayMuon.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayMuon.Name = "dtpNgayMuon";
            this.dtpNgayMuon.Size = new System.Drawing.Size(199, 32);
            this.dtpNgayMuon.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(450, 131);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 25);
            this.label9.TabIndex = 6;
            this.label9.Text = "Ngày Mượn";
            // 
            // cboSach
            // 
            this.cboSach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSach.FormattingEnabled = true;
            this.cboSach.Location = new System.Drawing.Point(25, 162);
            this.cboSach.Margin = new System.Windows.Forms.Padding(4);
            this.cboSach.Name = "cboSach";
            this.cboSach.Size = new System.Drawing.Size(374, 33);
            this.cboSach.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 131);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 25);
            this.label8.TabIndex = 4;
            this.label8.Text = "Sách";
            // 
            // cboDocGia
            // 
            this.cboDocGia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDocGia.FormattingEnabled = true;
            this.cboDocGia.Location = new System.Drawing.Point(450, 75);
            this.cboDocGia.Margin = new System.Windows.Forms.Padding(4);
            this.cboDocGia.Name = "cboDocGia";
            this.cboDocGia.Size = new System.Drawing.Size(374, 33);
            this.cboDocGia.TabIndex = 3;
            // 
            // txtMaPhieu
            // 
            this.txtMaPhieu.Location = new System.Drawing.Point(25, 75);
            this.txtMaPhieu.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.ReadOnly = true;
            this.txtMaPhieu.Size = new System.Drawing.Size(374, 32);
            this.txtMaPhieu.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(450, 44);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 25);
            this.label7.TabIndex = 1;
            this.label7.Text = "Độc Giả";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 44);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mã Phiếu";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.customTabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(19, 155);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(910, 622);
            this.panel1.TabIndex = 3;
            // 
            // BookManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panelTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.Location = new System.Drawing.Point(0, 38);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "BookManagement";
            this.Padding = new System.Windows.Forms.Padding(19, 12, 19, 12);
            this.Size = new System.Drawing.Size(948, 795);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.customTabControl1.ResumeLayout(false);
            this.tabSach.ResumeLayout(false);
            this.panelBookList.ResumeLayout(false);
            this.panelBookList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.panelBookButtons.ResumeLayout(false);
            this.grpThongTinSach.ResumeLayout(false);
            this.grpThongTinSach.PerformLayout();
            this.tabMuonTra.ResumeLayout(false);
            this.panelMuonTraList.ResumeLayout(false);
            this.panelMuonTraList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuonTra)).EndInit();
            this.panelMuonTraButtons.ResumeLayout(false);
            this.grpThongTinMuonTra.ResumeLayout(false);
            this.grpThongTinMuonTra.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TabPage tabSach;
        private System.Windows.Forms.TabPage tabMuonTra;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThemSach;
        private System.Windows.Forms.GroupBox grpThongTinSach;
        private System.Windows.Forms.Panel panelBookButtons;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panelBookList;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
        private System.Windows.Forms.GroupBox grpThongTinMuonTra;
        private System.Windows.Forms.TextBox txtMaPhieu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker lblHanTra;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpNgayMuon;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboSach;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboDocGia;
        private System.Windows.Forms.Panel panelMuonTraButtons;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelMuonTraList;
        private System.Windows.Forms.DataGridView dgvMuonTra;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaPhieuMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenDocGiaMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenSachMuonTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHanTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThaiMuonTra;
        private CustomTabControl customTabControl1;
    }
}
