namespace QuanlyThuVien
{
    partial class QuanLySachForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.searchBox = new QuanlyThuVien.CustomControls.Custom_SearchBox();
            this.tabControl = new Custom_TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvSach = new QuanlyThuVien.CustomControls.Custom_DataGridView();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLamMoi = new QuanlyThuVien.CustomControls.Custom_Button();
            this.btnXoa = new QuanlyThuVien.CustomControls.Custom_Button();
            this.btnSua = new QuanlyThuVien.CustomControls.Custom_Button();
            this.btnThem = new QuanlyThuVien.CustomControls.Custom_Button();
            this.infoPanelSach = new System.Windows.Forms.Panel();
            this.txtTenSach = new QuanlyThuVien.CustomControls.Custom_TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaSach = new QuanlyThuVien.CustomControls.Custom_TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.custom_DataGridView1 = new QuanlyThuVien.CustomControls.Custom_DataGridView();
            this.MaPhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSach_TabMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HanTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai_TabMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custom_Button4 = new QuanlyThuVien.CustomControls.Custom_Button();
            this.custom_Button3 = new QuanlyThuVien.CustomControls.Custom_Button();
            this.custom_Button2 = new QuanlyThuVien.CustomControls.Custom_Button();
            this.custom_Button1 = new QuanlyThuVien.CustomControls.Custom_Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.custom_TextBox2 = new QuanlyThuVien.CustomControls.Custom_TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).BeginInit();
            this.infoPanelSach.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.custom_DataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ SÁCH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(22, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(382, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quản lý thông tin sách và hoạt động mượn trả";
            // 
            // searchBox
            // 
            this.searchBox.BackColor = System.Drawing.Color.White;
            this.searchBox.Location = new System.Drawing.Point(20, 85);
            this.searchBox.Name = "searchBox";
            this.searchBox.PlaceholderText = "Tìm kiếm theo mã sách, tên sách...";
            this.searchBox.Size = new System.Drawing.Size(500, 45);
            this.searchBox.TabIndex = 2;
            this.searchBox.SearchClicked += new System.EventHandler(this.SearchBox_SearchClicked);
            // 
            // tabControl
            // 
            this.tabControl.ActiveTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.tabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.ItemSize = new System.Drawing.Size(120, 45);
            this.tabControl.Location = new System.Drawing.Point(20, 145);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(900, 520);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvSach);
            this.tabPage1.Controls.Add(this.btnLamMoi);
            this.tabPage1.Controls.Add(this.btnXoa);
            this.tabPage1.Controls.Add(this.btnSua);
            this.tabPage1.Controls.Add(this.btnThem);
            this.tabPage1.Controls.Add(this.infoPanelSach);
            this.tabPage1.Location = new System.Drawing.Point(4, 49);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(892, 467);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "SÁCH";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvSach
            // 
            this.dgvSach.AllowUserToAddRows = false;
            this.dgvSach.AllowUserToDeleteRows = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgvSach.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSach.BackgroundColor = System.Drawing.Color.White;
            this.dgvSach.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSach.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSach.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSach,
            this.TenSach,
            this.TrangThai});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(245)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSach.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvSach.EnableHeadersVisualStyles = false;
            this.dgvSach.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dgvSach.Location = new System.Drawing.Point(15, 250);
            this.dgvSach.MultiSelect = false;
            this.dgvSach.Name = "dgvSach";
            this.dgvSach.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSach.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvSach.RowHeadersVisible = false;
            this.dgvSach.RowHeadersWidth = 51;
            this.dgvSach.RowTemplate.Height = 40;
            this.dgvSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSach.Size = new System.Drawing.Size(830, 240);
            this.dgvSach.TabIndex = 5;
            // 
            // MaSach
            // 
            this.MaSach.HeaderText = "MaSach";
            this.MaSach.MinimumWidth = 6;
            this.MaSach.Name = "MaSach";
            this.MaSach.ReadOnly = true;
            // 
            // TenSach
            // 
            this.TenSach.HeaderText = "TenSach";
            this.TenSach.MinimumWidth = 6;
            this.TenSach.Name = "TenSach";
            this.TenSach.ReadOnly = true;
            // 
            // TrangThai
            // 
            this.TrangThai.HeaderText = "TrangThai";
            this.TrangThai.MinimumWidth = 6;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.Transparent;
            this.btnLamMoi.BorderRadius = 8;
            this.btnLamMoi.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.FlatAppearance.BorderSize = 0;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(480, 190);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(140, 42);
            this.btnLamMoi.TabIndex = 4;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Transparent;
            this.btnXoa.BorderRadius = 8;
            this.btnXoa.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(325, 190);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(140, 42);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Transparent;
            this.btnSua.BorderRadius = 8;
            this.btnSua.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(170, 190);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(140, 42);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Transparent;
            this.btnThem.BorderRadius = 8;
            this.btnThem.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(15, 190);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(140, 42);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "+ Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // infoPanelSach
            // 
            this.infoPanelSach.BackColor = System.Drawing.Color.White;
            this.infoPanelSach.Controls.Add(this.txtTenSach);
            this.infoPanelSach.Controls.Add(this.label5);
            this.infoPanelSach.Controls.Add(this.txtMaSach);
            this.infoPanelSach.Controls.Add(this.label4);
            this.infoPanelSach.Controls.Add(this.label3);
            this.infoPanelSach.Location = new System.Drawing.Point(10, 10);
            this.infoPanelSach.Name = "infoPanelSach";
            this.infoPanelSach.Size = new System.Drawing.Size(860, 160);
            this.infoPanelSach.TabIndex = 0;
            // 
            // txtTenSach
            // 
            this.txtTenSach.BackColor = System.Drawing.Color.White;
            this.txtTenSach.BorderColor = System.Drawing.Color.Black;
            this.txtTenSach.BorderRadius = 6;
            this.txtTenSach.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenSach.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtTenSach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtTenSach.Location = new System.Drawing.Point(400, 75);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.PlaceholderText = "Nhập tên sách...";
            this.txtTenSach.Size = new System.Drawing.Size(440, 25);
            this.txtTenSach.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(400, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tên sách";
            // 
            // txtMaSach
            // 
            this.txtMaSach.BackColor = System.Drawing.Color.White;
            this.txtMaSach.BorderColor = System.Drawing.Color.Black;
            this.txtMaSach.BorderRadius = 6;
            this.txtMaSach.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaSach.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtMaSach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtMaSach.Location = new System.Drawing.Point(15, 75);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.PlaceholderText = "Nhập mã sách...";
            this.txtMaSach.Size = new System.Drawing.Size(350, 25);
            this.txtMaSach.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mã sách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "THÔNG TIN SÁCH";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.custom_DataGridView1);
            this.tabPage2.Controls.Add(this.custom_Button4);
            this.tabPage2.Controls.Add(this.custom_Button3);
            this.tabPage2.Controls.Add(this.custom_Button2);
            this.tabPage2.Controls.Add(this.custom_Button1);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 49);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(892, 467);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = " MƯỢN / TRẢ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // custom_DataGridView1
            // 
            this.custom_DataGridView1.AllowUserToAddRows = false;
            this.custom_DataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.custom_DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle12;
            this.custom_DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.custom_DataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.custom_DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.custom_DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.custom_DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.custom_DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.custom_DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.custom_DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhieu,
            this.DocGia,
            this.TenSach_TabMuon,
            this.NgayMuon,
            this.HanTra,
            this.TrangThai_TabMuon});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(245)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.custom_DataGridView1.DefaultCellStyle = dataGridViewCellStyle14;
            this.custom_DataGridView1.EnableHeadersVisualStyles = false;
            this.custom_DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.custom_DataGridView1.Location = new System.Drawing.Point(15, 250);
            this.custom_DataGridView1.MultiSelect = false;
            this.custom_DataGridView1.Name = "custom_DataGridView1";
            this.custom_DataGridView1.ReadOnly = true;
            this.custom_DataGridView1.RowHeadersVisible = false;
            this.custom_DataGridView1.RowHeadersWidth = 51;
            this.custom_DataGridView1.RowTemplate.Height = 40;
            this.custom_DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.custom_DataGridView1.Size = new System.Drawing.Size(830, 240);
            this.custom_DataGridView1.TabIndex = 5;
            // 
            // MaPhieu
            // 
            this.MaPhieu.HeaderText = "MaPhieu";
            this.MaPhieu.MinimumWidth = 6;
            this.MaPhieu.Name = "MaPhieu";
            this.MaPhieu.ReadOnly = true;
            // 
            // DocGia
            // 
            this.DocGia.HeaderText = "DocGia";
            this.DocGia.MinimumWidth = 6;
            this.DocGia.Name = "DocGia";
            this.DocGia.ReadOnly = true;
            // 
            // TenSach_TabMuon
            // 
            this.TenSach_TabMuon.HeaderText = "TenSach";
            this.TenSach_TabMuon.MinimumWidth = 6;
            this.TenSach_TabMuon.Name = "TenSach_TabMuon";
            this.TenSach_TabMuon.ReadOnly = true;
            // 
            // NgayMuon
            // 
            this.NgayMuon.HeaderText = "NgayMuon";
            this.NgayMuon.MinimumWidth = 6;
            this.NgayMuon.Name = "NgayMuon";
            this.NgayMuon.ReadOnly = true;
            // 
            // HanTra
            // 
            this.HanTra.HeaderText = "HanTra";
            this.HanTra.MinimumWidth = 6;
            this.HanTra.Name = "HanTra";
            this.HanTra.ReadOnly = true;
            // 
            // TrangThai_TabMuon
            // 
            this.TrangThai_TabMuon.HeaderText = "TrangThai";
            this.TrangThai_TabMuon.MinimumWidth = 6;
            this.TrangThai_TabMuon.Name = "TrangThai_TabMuon";
            this.TrangThai_TabMuon.ReadOnly = true;
            // 
            // custom_Button4
            // 
            this.custom_Button4.BackColor = System.Drawing.Color.Transparent;
            this.custom_Button4.BorderRadius = 8;
            this.custom_Button4.ButtonColor = System.Drawing.Color.Gray;
            this.custom_Button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.custom_Button4.FlatAppearance.BorderSize = 0;
            this.custom_Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.custom_Button4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.custom_Button4.ForeColor = System.Drawing.Color.White;
            this.custom_Button4.Location = new System.Drawing.Point(497, 190);
            this.custom_Button4.Name = "custom_Button4";
            this.custom_Button4.Size = new System.Drawing.Size(140, 42);
            this.custom_Button4.TabIndex = 4;
            this.custom_Button4.Text = "Làm mới";
            this.custom_Button4.UseVisualStyleBackColor = false;
            this.custom_Button4.Click += new System.EventHandler(this.BtnLamMoi_Click);
            // 
            // custom_Button3
            // 
            this.custom_Button3.BackColor = System.Drawing.Color.Transparent;
            this.custom_Button3.BorderRadius = 8;
            this.custom_Button3.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.custom_Button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.custom_Button3.FlatAppearance.BorderSize = 0;
            this.custom_Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.custom_Button3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.custom_Button3.ForeColor = System.Drawing.Color.White;
            this.custom_Button3.Location = new System.Drawing.Point(348, 190);
            this.custom_Button3.Name = "custom_Button3";
            this.custom_Button3.Size = new System.Drawing.Size(140, 42);
            this.custom_Button3.TabIndex = 3;
            this.custom_Button3.Text = "Gia hạn";
            this.custom_Button3.UseVisualStyleBackColor = false;
            // 
            // custom_Button2
            // 
            this.custom_Button2.BackColor = System.Drawing.Color.Transparent;
            this.custom_Button2.BorderRadius = 8;
            this.custom_Button2.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.custom_Button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.custom_Button2.FlatAppearance.BorderSize = 0;
            this.custom_Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.custom_Button2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.custom_Button2.ForeColor = System.Drawing.Color.White;
            this.custom_Button2.Location = new System.Drawing.Point(200, 190);
            this.custom_Button2.Name = "custom_Button2";
            this.custom_Button2.Size = new System.Drawing.Size(140, 42);
            this.custom_Button2.TabIndex = 2;
            this.custom_Button2.Text = "Xác nhận trả";
            this.custom_Button2.UseVisualStyleBackColor = false;
            // 
            // custom_Button1
            // 
            this.custom_Button1.BackColor = System.Drawing.Color.Transparent;
            this.custom_Button1.BorderRadius = 8;
            this.custom_Button1.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.custom_Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.custom_Button1.FlatAppearance.BorderSize = 0;
            this.custom_Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.custom_Button1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.custom_Button1.ForeColor = System.Drawing.Color.White;
            this.custom_Button1.Location = new System.Drawing.Point(20, 190);
            this.custom_Button1.Name = "custom_Button1";
            this.custom_Button1.Size = new System.Drawing.Size(174, 42);
            this.custom_Button1.TabIndex = 1;
            this.custom_Button1.Text = "+ Lập phiếu mượn";
            this.custom_Button1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.custom_TextBox2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 160);
            this.panel1.TabIndex = 0;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(575, 75);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 33);
            this.comboBox2.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(575, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 25);
            this.label9.TabIndex = 5;
            this.label9.Text = "Sách";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(405, 75);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 33);
            this.comboBox1.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(400, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 25);
            this.label8.TabIndex = 3;
            this.label8.Text = "Độc Giả";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "Mã Phiếu";
            // 
            // custom_TextBox2
            // 
            this.custom_TextBox2.BackColor = System.Drawing.Color.White;
            this.custom_TextBox2.BorderColor = System.Drawing.Color.Black;
            this.custom_TextBox2.BorderRadius = 6;
            this.custom_TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.custom_TextBox2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.custom_TextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.custom_TextBox2.Location = new System.Drawing.Point(15, 75);
            this.custom_TextBox2.Name = "custom_TextBox2";
            this.custom_TextBox2.PlaceholderText = "";
            this.custom_TextBox2.ReadOnly = true;
            this.custom_TextBox2.Size = new System.Drawing.Size(350, 25);
            this.custom_TextBox2.TabIndex = 1;
            this.custom_TextBox2.Text = "PM0001";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(278, 30);
            this.label6.TabIndex = 0;
            this.label6.Text = "THÔNG TIN MƯỢN / TRẢ";
            // 
            // QuanLySachForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "QuanLySachForm";
            this.Size = new System.Drawing.Size(950, 700);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).EndInit();
            this.infoPanelSach.ResumeLayout(false);
            this.infoPanelSach.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.custom_DataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private QuanlyThuVien.CustomControls.Custom_SearchBox searchBox;
        private Custom_TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel infoPanelSach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private QuanlyThuVien.CustomControls.Custom_TextBox txtMaSach;
        private QuanlyThuVien.CustomControls.Custom_TextBox txtTenSach;
        private System.Windows.Forms.Label label5;
        private QuanlyThuVien.CustomControls.Custom_Button btnThem;
        private QuanlyThuVien.CustomControls.Custom_Button btnSua;
        private QuanlyThuVien.CustomControls.Custom_Button btnLamMoi;
        private QuanlyThuVien.CustomControls.Custom_Button btnXoa;
        private QuanlyThuVien.CustomControls.Custom_DataGridView dgvSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private QuanlyThuVien.CustomControls.Custom_TextBox custom_TextBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label9;
        private QuanlyThuVien.CustomControls.Custom_Button custom_Button1;
        private QuanlyThuVien.CustomControls.Custom_Button custom_Button4;
        private QuanlyThuVien.CustomControls.Custom_Button custom_Button3;
        private QuanlyThuVien.CustomControls.Custom_Button custom_Button2;
        private QuanlyThuVien.CustomControls.Custom_DataGridView custom_DataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach_TabMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn HanTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai_TabMuon;
    }
}
