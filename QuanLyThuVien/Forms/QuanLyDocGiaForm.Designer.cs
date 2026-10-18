namespace QuanLyThuVien.Forms
{
    partial class QuanLyDocGiaForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.searchBoxDocGia = new QuanlyThuVien.CustomControls.Custom_SearchBox();
            this.infoPanelDocGia = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHoTen = new QuanlyThuVien.CustomControls.Custom_TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbGioiTinh = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSDT = new QuanlyThuVien.CustomControls.Custom_TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmail = new QuanlyThuVien.CustomControls.Custom_TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDiaChi = new QuanlyThuVien.CustomControls.Custom_TextBox();
            this.btnThemDG = new QuanlyThuVien.CustomControls.Custom_Button();
            this.btnSuaDG = new QuanlyThuVien.CustomControls.Custom_Button();
            this.btnXoaDG = new QuanlyThuVien.CustomControls.Custom_Button();
            this.btnLamMoiDG = new QuanlyThuVien.CustomControls.Custom_Button();
            this.dgvDocGia = new QuanlyThuVien.CustomControls.Custom_DataGridView();
            this.MaDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.infoPanelDocGia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocGia)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label1.Location = new System.Drawing.Point(20, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ ĐỘC GIẢ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(20, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(337, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quản lý thông tin độc giả và thẻ thư viện";
            // 
            // searchBoxDocGia
            // 
            this.searchBoxDocGia.BackColor = System.Drawing.Color.White;
            this.searchBoxDocGia.Location = new System.Drawing.Point(20, 85);
            this.searchBoxDocGia.Name = "searchBoxDocGia";
            this.searchBoxDocGia.PlaceholderText = "Tìm kiếm theo họ tên, số điện thoại, email...";
            this.searchBoxDocGia.Size = new System.Drawing.Size(500, 45);
            this.searchBoxDocGia.TabIndex = 2;
            this.searchBoxDocGia.SearchClicked += new System.EventHandler(this.searchBoxDocGia_SearchClicked);
            // 
            // infoPanelDocGia
            // 
            this.infoPanelDocGia.BackColor = System.Drawing.Color.White;
            this.infoPanelDocGia.Controls.Add(this.txtDiaChi);
            this.infoPanelDocGia.Controls.Add(this.label10);
            this.infoPanelDocGia.Controls.Add(this.dtpNgayLap);
            this.infoPanelDocGia.Controls.Add(this.label9);
            this.infoPanelDocGia.Controls.Add(this.txtEmail);
            this.infoPanelDocGia.Controls.Add(this.label8);
            this.infoPanelDocGia.Controls.Add(this.txtSDT);
            this.infoPanelDocGia.Controls.Add(this.label7);
            this.infoPanelDocGia.Controls.Add(this.dtpNgaySinh);
            this.infoPanelDocGia.Controls.Add(this.label6);
            this.infoPanelDocGia.Controls.Add(this.cbGioiTinh);
            this.infoPanelDocGia.Controls.Add(this.label5);
            this.infoPanelDocGia.Controls.Add(this.txtHoTen);
            this.infoPanelDocGia.Controls.Add(this.label4);
            this.infoPanelDocGia.Controls.Add(this.label3);
            this.infoPanelDocGia.Location = new System.Drawing.Point(20, 145);
            this.infoPanelDocGia.Name = "infoPanelDocGia";
            this.infoPanelDocGia.Size = new System.Drawing.Size(900, 250);
            this.infoPanelDocGia.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label3.Location = new System.Drawing.Point(15, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "THÔNG TIN ĐỘC GIẢ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Họ tên";
            // 
            // txtHoTen
            // 
            this.txtHoTen.BackColor = System.Drawing.Color.White;
            this.txtHoTen.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtHoTen.BorderRadius = 6;
            this.txtHoTen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHoTen.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtHoTen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtHoTen.Location = new System.Drawing.Point(15, 70);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.PlaceholderText = "Nhập họ tên...";
            this.txtHoTen.Size = new System.Drawing.Size(350, 25);
            this.txtHoTen.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(400, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Giới Tính";
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGioiTinh.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGioiTinh.FormattingEnabled = true;
            this.cbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cbGioiTinh.Location = new System.Drawing.Point(400, 70);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(200, 33);
            this.cbGioiTinh.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(630, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ngày Sinh";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(630, 70);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(250, 31);
            this.dtpNgaySinh.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "SDT";
            // 
            // txtSDT
            // 
            this.txtSDT.BackColor = System.Drawing.Color.White;
            this.txtSDT.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtSDT.BorderRadius = 6;
            this.txtSDT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSDT.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSDT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtSDT.Location = new System.Drawing.Point(15, 145);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.PlaceholderText = "Nhập số điện thoại...";
            this.txtSDT.Size = new System.Drawing.Size(200, 25);
            this.txtSDT.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(250, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 25);
            this.label8.TabIndex = 9;
            this.label8.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtEmail.BorderRadius = 6;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtEmail.Location = new System.Drawing.Point(250, 145);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderText = "Nhập email...";
            this.txtEmail.Size = new System.Drawing.Size(350, 25);
            this.txtEmail.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(630, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 25);
            this.label9.TabIndex = 11;
            this.label9.Text = "Ngày Lập";
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayLap.Location = new System.Drawing.Point(630, 145);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(250, 31);
            this.dtpNgayLap.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(15, 180);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 25);
            this.label10.TabIndex = 13;
            this.label10.Text = "Địa Chỉ";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BackColor = System.Drawing.Color.White;
            this.txtDiaChi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtDiaChi.BorderRadius = 6;
            this.txtDiaChi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDiaChi.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtDiaChi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtDiaChi.Location = new System.Drawing.Point(15, 205);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.PlaceholderText = "Nhập địa chỉ...";
            this.txtDiaChi.Size = new System.Drawing.Size(865, 25);
            this.txtDiaChi.TabIndex = 14;
            // 
            // btnThemDG
            // 
            this.btnThemDG.BackColor = System.Drawing.Color.Transparent;
            this.btnThemDG.BorderRadius = 8;
            this.btnThemDG.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnThemDG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemDG.FlatAppearance.BorderSize = 0;
            this.btnThemDG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemDG.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnThemDG.ForeColor = System.Drawing.Color.White;
            this.btnThemDG.Location = new System.Drawing.Point(20, 400);
            this.btnThemDG.Name = "btnThemDG";
            this.btnThemDG.Size = new System.Drawing.Size(140, 42);
            this.btnThemDG.TabIndex = 4;
            this.btnThemDG.Text = "+ Thêm";
            this.btnThemDG.UseVisualStyleBackColor = false;
            this.btnThemDG.Click += new System.EventHandler(this.btnThemDG_Click);
            // 
            // btnSuaDG
            // 
            this.btnSuaDG.BackColor = System.Drawing.Color.Transparent;
            this.btnSuaDG.BorderRadius = 8;
            this.btnSuaDG.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnSuaDG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuaDG.FlatAppearance.BorderSize = 0;
            this.btnSuaDG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaDG.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnSuaDG.ForeColor = System.Drawing.Color.White;
            this.btnSuaDG.Location = new System.Drawing.Point(175, 400);
            this.btnSuaDG.Name = "btnSuaDG";
            this.btnSuaDG.Size = new System.Drawing.Size(140, 42);
            this.btnSuaDG.TabIndex = 5;
            this.btnSuaDG.Text = "Sửa";
            this.btnSuaDG.UseVisualStyleBackColor = false;
            this.btnSuaDG.Click += new System.EventHandler(this.btnSuaDG_Click);
            // 
            // btnXoaDG
            // 
            this.btnXoaDG.BackColor = System.Drawing.Color.Transparent;
            this.btnXoaDG.BorderRadius = 8;
            this.btnXoaDG.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnXoaDG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaDG.FlatAppearance.BorderSize = 0;
            this.btnXoaDG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaDG.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnXoaDG.ForeColor = System.Drawing.Color.White;
            this.btnXoaDG.Location = new System.Drawing.Point(330, 400);
            this.btnXoaDG.Name = "btnXoaDG";
            this.btnXoaDG.Size = new System.Drawing.Size(140, 42);
            this.btnXoaDG.TabIndex = 6;
            this.btnXoaDG.Text = "Xóa";
            this.btnXoaDG.UseVisualStyleBackColor = false;
            this.btnXoaDG.Click += new System.EventHandler(this.btnXoaDG_Click);
            // 
            // btnLamMoiDG
            // 
            this.btnLamMoiDG.BackColor = System.Drawing.Color.Transparent;
            this.btnLamMoiDG.BorderRadius = 8;
            this.btnLamMoiDG.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.btnLamMoiDG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoiDG.FlatAppearance.BorderSize = 0;
            this.btnLamMoiDG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoiDG.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnLamMoiDG.ForeColor = System.Drawing.Color.White;
            this.btnLamMoiDG.Location = new System.Drawing.Point(485, 400);
            this.btnLamMoiDG.Name = "btnLamMoiDG";
            this.btnLamMoiDG.Size = new System.Drawing.Size(140, 42);
            this.btnLamMoiDG.TabIndex = 7;
            this.btnLamMoiDG.Text = "Làm mới";
            this.btnLamMoiDG.UseVisualStyleBackColor = false;
            this.btnLamMoiDG.Click += new System.EventHandler(this.btnLamMoiDG_Click);
            // 
            // dgvDocGia
            // 
            this.dgvDocGia.AllowUserToAddRows = false;
            this.dgvDocGia.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgvDocGia.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDocGia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDocGia.BackgroundColor = System.Drawing.Color.White;
            this.dgvDocGia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDocGia.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDocGia.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDocGia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDocGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocGia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDG,
            this.HoTen,
            this.NgaySinh,
            this.GioiTinh,
            this.DiaChi,
            this.SDT,
            this.Email,
            this.NgayLap,
            this.TrangThai});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(245)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDocGia.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDocGia.EnableHeadersVisualStyles = false;
            this.dgvDocGia.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dgvDocGia.Location = new System.Drawing.Point(20, 450);
            this.dgvDocGia.MultiSelect = false;
            this.dgvDocGia.Name = "dgvDocGia";
            this.dgvDocGia.ReadOnly = true;
            this.dgvDocGia.RowHeadersVisible = false;
            this.dgvDocGia.RowHeadersWidth = 51;
            this.dgvDocGia.RowTemplate.Height = 40;
            this.dgvDocGia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDocGia.Size = new System.Drawing.Size(900, 280);
            this.dgvDocGia.TabIndex = 8;
            this.dgvDocGia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDocGia_CellDoubleClick);
            // 
            // MaDG
            // 
            this.MaDG.FillWeight = 0.3331338F;
            this.MaDG.HeaderText = "Mã Độc Giả";
            this.MaDG.MinimumWidth = 6;
            this.MaDG.Name = "MaDG";
            this.MaDG.ReadOnly = true;
            // 
            // HoTen
            // 
            this.HoTen.FillWeight = 1.699078F;
            this.HoTen.HeaderText = "Họ Tên";
            this.HoTen.MinimumWidth = 6;
            this.HoTen.Name = "HoTen";
            this.HoTen.ReadOnly = true;
            // 
            // NgaySinh
            // 
            this.NgaySinh.FillWeight = 2.585727F;
            this.NgaySinh.HeaderText = "Ngày Sinh";
            this.NgaySinh.MinimumWidth = 6;
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.ReadOnly = true;
            // 
            // GioiTinh
            // 
            this.GioiTinh.FillWeight = 3.588098F;
            this.GioiTinh.HeaderText = "Giới Tính\t";
            this.GioiTinh.MinimumWidth = 6;
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.ReadOnly = true;
            // 
            // DiaChi
            // 
            this.DiaChi.FillWeight = 24.18296F;
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            // 
            // SDT
            // 
            this.SDT.FillWeight = 37.35366F;
            this.SDT.HeaderText = "SDT";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            this.SDT.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.FillWeight = 125.042F;
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // NgayLap
            // 
            this.NgayLap.FillWeight = 223.932F;
            this.NgayLap.HeaderText = "Ngày Lập Thẻ";
            this.NgayLap.MinimumWidth = 6;
            this.NgayLap.Name = "NgayLap";
            this.NgayLap.ReadOnly = true;
            // 
            // TrangThai
            // 
            this.TrangThai.FillWeight = 481.2835F;
            this.TrangThai.HeaderText = "Trạng Thái";
            this.TrangThai.MinimumWidth = 6;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            // 
            // QuanLyDocGiaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.dgvDocGia);
            this.Controls.Add(this.btnLamMoiDG);
            this.Controls.Add(this.btnXoaDG);
            this.Controls.Add(this.btnSuaDG);
            this.Controls.Add(this.btnThemDG);
            this.Controls.Add(this.infoPanelDocGia);
            this.Controls.Add(this.searchBoxDocGia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "QuanLyDocGiaForm";
            this.Size = new System.Drawing.Size(950, 750);
            this.infoPanelDocGia.ResumeLayout(false);
            this.infoPanelDocGia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocGia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private QuanlyThuVien.CustomControls.Custom_SearchBox searchBoxDocGia;
        private System.Windows.Forms.Panel infoPanelDocGia;
        private System.Windows.Forms.Label label3;
        private QuanlyThuVien.CustomControls.Custom_TextBox txtHoTen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbGioiTinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label label6;
        private QuanlyThuVien.CustomControls.Custom_TextBox txtSDT;
        private System.Windows.Forms.Label label7;
        private QuanlyThuVien.CustomControls.Custom_TextBox txtEmail;
        private System.Windows.Forms.Label label8;
        private QuanlyThuVien.CustomControls.Custom_TextBox txtDiaChi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
        private System.Windows.Forms.Label label9;
        private QuanlyThuVien.CustomControls.Custom_Button btnThemDG;
        private QuanlyThuVien.CustomControls.Custom_Button btnSuaDG;
        private QuanlyThuVien.CustomControls.Custom_Button btnXoaDG;
        private QuanlyThuVien.CustomControls.Custom_Button btnLamMoiDG;
        private QuanlyThuVien.CustomControls.Custom_DataGridView dgvDocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
    }
}
