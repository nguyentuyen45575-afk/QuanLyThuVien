namespace QuanlyThuVien
{
    partial class HomePage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.custom_StatCard1 = new QuanlyThuVien.CustomControls.Custom_StatCard();
            this.custom_StatCard2 = new QuanlyThuVien.CustomControls.Custom_StatCard();
            this.custom_StatCard3 = new QuanlyThuVien.CustomControls.Custom_StatCard();
            this.custom_StatCard4 = new QuanlyThuVien.CustomControls.Custom_StatCard();
            this.notifPanel = new System.Windows.Forms.Panel();
            this.notif4 = new System.Windows.Forms.Panel();
            this.notif2 = new System.Windows.Forms.Panel();
            this.notif3 = new System.Windows.Forms.Panel();
            this.notif1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.recentPanel = new System.Windows.Forms.Panel();
            this.dgvRecent = new QuanlyThuVien.CustomControls.Custom_DataGridView();
            this.MaPhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.quickPanel = new System.Windows.Forms.Panel();
            this.btnThemDocGia = new QuanlyThuVien.CustomControls.Custom_Button();
            this.btnXacNhanTra = new QuanlyThuVien.CustomControls.Custom_Button();
            this.btnLapPhieu = new QuanlyThuVien.CustomControls.Custom_Button();
            this.headerPanel.SuspendLayout();
            this.statsPanel.SuspendLayout();
            this.notifPanel.SuspendLayout();
            this.notif1.SuspendLayout();
            this.recentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecent)).BeginInit();
            this.quickPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.White;
            this.headerPanel.Controls.Add(this.lblDateTime);
            this.headerPanel.Controls.Add(this.label1);
            this.headerPanel.Location = new System.Drawing.Point(10, 10);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(920, 90);
            this.headerPanel.TabIndex = 0;
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.Location = new System.Drawing.Point(25, 55);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(150, 22);
            this.lblDateTime.TabIndex = 1;
            this.lblDateTime.Text = "18/10/2026 14:30";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Xin chào, Admin!";
            // 
            // statsPanel
            // 
            this.statsPanel.Controls.Add(this.custom_StatCard1);
            this.statsPanel.Controls.Add(this.custom_StatCard2);
            this.statsPanel.Controls.Add(this.custom_StatCard3);
            this.statsPanel.Controls.Add(this.custom_StatCard4);
            this.statsPanel.Location = new System.Drawing.Point(10, 115);
            this.statsPanel.Name = "statsPanel";
            this.statsPanel.Size = new System.Drawing.Size(920, 140);
            this.statsPanel.TabIndex = 1;
            this.statsPanel.WrapContents = false;
            // 
            // custom_StatCard1
            // 
            this.custom_StatCard1.BackColor = System.Drawing.Color.White;
            this.custom_StatCard1.CardColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.custom_StatCard1.Icon = "📚";
            this.custom_StatCard1.Location = new System.Drawing.Point(3, 3);
            this.custom_StatCard1.Name = "custom_StatCard1";
            this.custom_StatCard1.Size = new System.Drawing.Size(223, 120);
            this.custom_StatCard1.TabIndex = 0;
            this.custom_StatCard1.Title = "Tổng số sách";
            this.custom_StatCard1.Value = "1,234";
            // 
            // custom_StatCard2
            // 
            this.custom_StatCard2.BackColor = System.Drawing.Color.White;
            this.custom_StatCard2.CardColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.custom_StatCard2.Icon = "👥";
            this.custom_StatCard2.Location = new System.Drawing.Point(232, 3);
            this.custom_StatCard2.Name = "custom_StatCard2";
            this.custom_StatCard2.Size = new System.Drawing.Size(234, 120);
            this.custom_StatCard2.TabIndex = 1;
            this.custom_StatCard2.Title = "Độc giả";
            this.custom_StatCard2.Value = "567";
            // 
            // custom_StatCard3
            // 
            this.custom_StatCard3.BackColor = System.Drawing.Color.White;
            this.custom_StatCard3.CardColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.custom_StatCard3.Icon = "📊";
            this.custom_StatCard3.Location = new System.Drawing.Point(472, 3);
            this.custom_StatCard3.Name = "custom_StatCard3";
            this.custom_StatCard3.Size = new System.Drawing.Size(227, 120);
            this.custom_StatCard3.TabIndex = 2;
            this.custom_StatCard3.Title = "Đang mượn";
            this.custom_StatCard3.Value = "89";
            // 
            // custom_StatCard4
            // 
            this.custom_StatCard4.BackColor = System.Drawing.Color.White;
            this.custom_StatCard4.CardColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.custom_StatCard4.Icon = "📊";
            this.custom_StatCard4.Location = new System.Drawing.Point(705, 3);
            this.custom_StatCard4.Name = "custom_StatCard4";
            this.custom_StatCard4.Size = new System.Drawing.Size(273, 120);
            this.custom_StatCard4.TabIndex = 3;
            this.custom_StatCard4.Title = "Quá hạn";
            this.custom_StatCard4.Value = "12";
            // 
            // notifPanel
            // 
            this.notifPanel.BackColor = System.Drawing.Color.White;
            this.notifPanel.Controls.Add(this.notif4);
            this.notifPanel.Controls.Add(this.notif2);
            this.notifPanel.Controls.Add(this.notif3);
            this.notifPanel.Controls.Add(this.notif1);
            this.notifPanel.Controls.Add(this.label2);
            this.notifPanel.Location = new System.Drawing.Point(10, 270);
            this.notifPanel.Name = "notifPanel";
            this.notifPanel.Size = new System.Drawing.Size(450, 280);
            this.notifPanel.TabIndex = 2;
            // 
            // notif4
            // 
            this.notif4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notif4.Location = new System.Drawing.Point(20, 210);
            this.notif4.Name = "notif4";
            this.notif4.Size = new System.Drawing.Size(410, 40);
            this.notif4.TabIndex = 6;
            // 
            // notif2
            // 
            this.notif2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notif2.Location = new System.Drawing.Point(20, 110);
            this.notif2.Name = "notif2";
            this.notif2.Size = new System.Drawing.Size(410, 40);
            this.notif2.TabIndex = 4;
            // 
            // notif3
            // 
            this.notif3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notif3.Location = new System.Drawing.Point(20, 160);
            this.notif3.Name = "notif3";
            this.notif3.Size = new System.Drawing.Size(410, 40);
            this.notif3.TabIndex = 5;
            // 
            // notif1
            // 
            this.notif1.Controls.Add(this.label3);
            this.notif1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notif1.Location = new System.Drawing.Point(20, 60);
            this.notif1.Name = "notif1";
            this.notif1.Size = new System.Drawing.Size(410, 40);
            this.notif1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "🔔 Thông báo";
            // 
            // recentPanel
            // 
            this.recentPanel.BackColor = System.Drawing.Color.White;
            this.recentPanel.Controls.Add(this.dgvRecent);
            this.recentPanel.Controls.Add(this.label4);
            this.recentPanel.Location = new System.Drawing.Point(470, 270);
            this.recentPanel.Name = "recentPanel";
            this.recentPanel.Size = new System.Drawing.Size(470, 280);
            this.recentPanel.TabIndex = 3;
            // 
            // dgvRecent
            // 
            this.dgvRecent.AllowUserToAddRows = false;
            this.dgvRecent.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgvRecent.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvRecent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecent.BackgroundColor = System.Drawing.Color.White;
            this.dgvRecent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRecent.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvRecent.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRecent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvRecent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhieu,
            this.DocGia,
            this.Sach,
            this.TrangThai});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(245)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRecent.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvRecent.EnableHeadersVisualStyles = false;
            this.dgvRecent.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dgvRecent.Location = new System.Drawing.Point(20, 55);
            this.dgvRecent.MultiSelect = false;
            this.dgvRecent.Name = "dgvRecent";
            this.dgvRecent.ReadOnly = true;
            this.dgvRecent.RowHeadersVisible = false;
            this.dgvRecent.RowHeadersWidth = 51;
            this.dgvRecent.RowTemplate.Height = 40;
            this.dgvRecent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecent.Size = new System.Drawing.Size(430, 210);
            this.dgvRecent.TabIndex = 1;
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
            // Sach
            // 
            this.Sach.HeaderText = "Sach";
            this.Sach.MinimumWidth = 6;
            this.Sach.Name = "Sach";
            this.Sach.ReadOnly = true;
            // 
            // TrangThai
            // 
            this.TrangThai.HeaderText = "TrangThai";
            this.TrangThai.MinimumWidth = 6;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 31);
            this.label4.TabIndex = 0;
            this.label4.Text = "📋 Giao dịch gần đây";
            // 
            // quickPanel
            // 
            this.quickPanel.BackColor = System.Drawing.Color.White;
            this.quickPanel.Controls.Add(this.btnThemDocGia);
            this.quickPanel.Controls.Add(this.btnXacNhanTra);
            this.quickPanel.Controls.Add(this.btnLapPhieu);
            this.quickPanel.Location = new System.Drawing.Point(10, 565);
            this.quickPanel.Name = "quickPanel";
            this.quickPanel.Size = new System.Drawing.Size(920, 70);
            this.quickPanel.TabIndex = 4;
            // 
            // btnThemDocGia
            // 
            this.btnThemDocGia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnThemDocGia.BorderRadius = 8;
            this.btnThemDocGia.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.btnThemDocGia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemDocGia.FlatAppearance.BorderSize = 0;
            this.btnThemDocGia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemDocGia.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnThemDocGia.ForeColor = System.Drawing.Color.White;
            this.btnThemDocGia.Location = new System.Drawing.Point(450, 15);
            this.btnThemDocGia.Name = "btnThemDocGia";
            this.btnThemDocGia.Size = new System.Drawing.Size(200, 42);
            this.btnThemDocGia.TabIndex = 2;
            this.btnThemDocGia.Text = "👤 Thêm độc giả";
            this.btnThemDocGia.UseVisualStyleBackColor = false;
            this.btnThemDocGia.Click += new System.EventHandler(this.btnThemDocGia_Click);
            // 
            // btnXacNhanTra
            // 
            this.btnXacNhanTra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnXacNhanTra.BorderRadius = 8;
            this.btnXacNhanTra.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnXacNhanTra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXacNhanTra.FlatAppearance.BorderSize = 0;
            this.btnXacNhanTra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXacNhanTra.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnXacNhanTra.ForeColor = System.Drawing.Color.White;
            this.btnXacNhanTra.Location = new System.Drawing.Point(235, 15);
            this.btnXacNhanTra.Name = "btnXacNhanTra";
            this.btnXacNhanTra.Size = new System.Drawing.Size(200, 42);
            this.btnXacNhanTra.TabIndex = 1;
            this.btnXacNhanTra.Text = "✅ Xác nhận trả sách";
            this.btnXacNhanTra.UseVisualStyleBackColor = false;
            this.btnXacNhanTra.Click += new System.EventHandler(this.btnXacNhanTra_Click);
            // 
            // btnLapPhieu
            // 
            this.btnLapPhieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnLapPhieu.BorderRadius = 8;
            this.btnLapPhieu.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnLapPhieu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLapPhieu.FlatAppearance.BorderSize = 0;
            this.btnLapPhieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLapPhieu.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnLapPhieu.ForeColor = System.Drawing.Color.White;
            this.btnLapPhieu.Location = new System.Drawing.Point(20, 15);
            this.btnLapPhieu.Name = "btnLapPhieu";
            this.btnLapPhieu.Size = new System.Drawing.Size(200, 42);
            this.btnLapPhieu.TabIndex = 0;
            this.btnLapPhieu.Text = "📄 Lập phiếu mượn";
            this.btnLapPhieu.UseVisualStyleBackColor = false;
            this.btnLapPhieu.Click += new System.EventHandler(this.btnLapPhieu_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.quickPanel);
            this.Controls.Add(this.recentPanel);
            this.Controls.Add(this.notifPanel);
            this.Controls.Add(this.statsPanel);
            this.Controls.Add(this.headerPanel);
            this.Name = "HomePage";
            this.Size = new System.Drawing.Size(950, 700);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.statsPanel.ResumeLayout(false);
            this.notifPanel.ResumeLayout(false);
            this.notifPanel.PerformLayout();
            this.notif1.ResumeLayout(false);
            this.notif1.PerformLayout();
            this.recentPanel.ResumeLayout(false);
            this.recentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecent)).EndInit();
            this.quickPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel statsPanel;
        private QuanlyThuVien.CustomControls.Custom_StatCard custom_StatCard1;
        private QuanlyThuVien.CustomControls.Custom_StatCard custom_StatCard2;
        private QuanlyThuVien.CustomControls.Custom_StatCard custom_StatCard3;
        private QuanlyThuVien.CustomControls.Custom_StatCard custom_StatCard4;
        private System.Windows.Forms.Panel notifPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel notif1;
        private System.Windows.Forms.Panel notif4;
        private System.Windows.Forms.Panel notif2;
        private System.Windows.Forms.Panel notif3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel recentPanel;
        private System.Windows.Forms.Label label4;
        private QuanlyThuVien.CustomControls.Custom_DataGridView dgvRecent;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.Panel quickPanel;
        private QuanlyThuVien.CustomControls.Custom_Button btnThemDocGia;
        private QuanlyThuVien.CustomControls.Custom_Button btnXacNhanTra;
        private QuanlyThuVien.CustomControls.Custom_Button btnLapPhieu;
    }
}
