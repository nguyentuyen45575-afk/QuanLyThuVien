using FormMain;

namespace FormMain
{
    partial class FormMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.lblLibrary = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnDocGia = new System.Windows.Forms.Button();
            this.btnSach = new System.Windows.Forms.Button();
            this.btnTrangChu = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.picBanner = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bookManagement1 = new FormMain.BookManagement();
            this.userManagement1 = new FormMain.UserManagement();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBanner)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panelMenu.Controls.Add(this.lblLibrary);
            this.panelMenu.Controls.Add(this.picLogo);
            this.panelMenu.Controls.Add(this.btnDangXuat);
            this.panelMenu.Controls.Add(this.btnDocGia);
            this.panelMenu.Controls.Add(this.btnSach);
            this.panelMenu.Controls.Add(this.btnTrangChu);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(5);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(288, 845);
            this.panelMenu.TabIndex = 0;
            // 
            // lblLibrary
            // 
            this.lblLibrary.AutoSize = true;
            this.lblLibrary.BackColor = System.Drawing.Color.Transparent;
            this.lblLibrary.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibrary.ForeColor = System.Drawing.Color.White;
            this.lblLibrary.Location = new System.Drawing.Point(78, 121);
            this.lblLibrary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLibrary.Name = "lblLibrary";
            this.lblLibrary.Size = new System.Drawing.Size(132, 28);
            this.lblLibrary.TabIndex = 10;
            this.lblLibrary.Text = "Tên Thư Viện";
            this.lblLibrary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(100, 19);
            this.picLogo.Margin = new System.Windows.Forms.Padding(4);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(92, 88);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 9;
            this.picLogo.TabStop = false;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.FlatAppearance.BorderSize = 0;
            this.btnDangXuat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(64)))), ((int)(((byte)(67)))));
            this.btnDangXuat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(54)))), ((int)(((byte)(57)))));
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.ForeColor = System.Drawing.Color.White;
            this.btnDangXuat.Location = new System.Drawing.Point(0, 780);
            this.btnDangXuat.Margin = new System.Windows.Forms.Padding(5);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(288, 60);
            this.btnDangXuat.TabIndex = 8;
            this.btnDangXuat.Text = "🚪 Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = true;
            // 
            // btnDocGia
            // 
            this.btnDocGia.FlatAppearance.BorderSize = 0;
            this.btnDocGia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(64)))), ((int)(((byte)(67)))));
            this.btnDocGia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(54)))), ((int)(((byte)(57)))));
            this.btnDocGia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDocGia.ForeColor = System.Drawing.Color.White;
            this.btnDocGia.Location = new System.Drawing.Point(0, 342);
            this.btnDocGia.Margin = new System.Windows.Forms.Padding(5);
            this.btnDocGia.Name = "btnDocGia";
            this.btnDocGia.Size = new System.Drawing.Size(288, 60);
            this.btnDocGia.TabIndex = 3;
            this.btnDocGia.Text = "👤 Quản lý độc giả";
            this.btnDocGia.UseVisualStyleBackColor = true;
            this.btnDocGia.Click += new System.EventHandler(this.btnDocGia_Click);
            // 
            // btnSach
            // 
            this.btnSach.FlatAppearance.BorderSize = 0;
            this.btnSach.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(64)))), ((int)(((byte)(67)))));
            this.btnSach.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(54)))), ((int)(((byte)(57)))));
            this.btnSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSach.ForeColor = System.Drawing.Color.White;
            this.btnSach.Location = new System.Drawing.Point(0, 272);
            this.btnSach.Margin = new System.Windows.Forms.Padding(5);
            this.btnSach.Name = "btnSach";
            this.btnSach.Size = new System.Drawing.Size(288, 60);
            this.btnSach.TabIndex = 2;
            this.btnSach.Text = "📚 Quản lý sách";
            this.btnSach.UseVisualStyleBackColor = true;
            this.btnSach.Click += new System.EventHandler(this.btnSach_Click);
            // 
            // btnTrangChu
            // 
            this.btnTrangChu.FlatAppearance.BorderSize = 0;
            this.btnTrangChu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(64)))), ((int)(((byte)(67)))));
            this.btnTrangChu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(54)))), ((int)(((byte)(57)))));
            this.btnTrangChu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrangChu.ForeColor = System.Drawing.Color.White;
            this.btnTrangChu.Location = new System.Drawing.Point(0, 202);
            this.btnTrangChu.Margin = new System.Windows.Forms.Padding(5);
            this.btnTrangChu.Name = "btnTrangChu";
            this.btnTrangChu.Size = new System.Drawing.Size(288, 60);
            this.btnTrangChu.TabIndex = 1;
            this.btnTrangChu.Text = "🏠 Trang chủ";
            this.btnTrangChu.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(288, 787);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1252, 58);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.picBanner);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(288, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(4);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1252, 158);
            this.panelHeader.TabIndex = 2;
            // 
            // picBanner
            // 
            this.picBanner.BackColor = System.Drawing.Color.Transparent;
            this.picBanner.BackgroundImage = global::FormMain.Properties.Resources.The_Library___Floor_of_Art;
            this.picBanner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picBanner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBanner.Image = global::FormMain.Properties.Resources.The_Library___Floor_of_Art;
            this.picBanner.Location = new System.Drawing.Point(0, 0);
            this.picBanner.Margin = new System.Windows.Forms.Padding(4);
            this.picBanner.Name = "picBanner";
            this.picBanner.Size = new System.Drawing.Size(1252, 158);
            this.picBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBanner.TabIndex = 2;
            this.picBanner.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bookManagement1);
            this.panel1.Controls.Add(this.userManagement1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(288, 158);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1252, 629);
            this.panel1.TabIndex = 3;
            // 
            // bookManagement1
            // 
            this.bookManagement1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookManagement1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.bookManagement1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.bookManagement1.Location = new System.Drawing.Point(0, 0);
            this.bookManagement1.Margin = new System.Windows.Forms.Padding(0);
            this.bookManagement1.Name = "bookManagement1";
            this.bookManagement1.Padding = new System.Windows.Forms.Padding(19, 12, 19, 12);
            this.bookManagement1.Size = new System.Drawing.Size(1252, 629);
            this.bookManagement1.TabIndex = 1;
            // 
            // userManagement1
            // 
            this.userManagement1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.userManagement1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userManagement1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.userManagement1.Location = new System.Drawing.Point(0, 0);
            this.userManagement1.Margin = new System.Windows.Forms.Padding(2);
            this.userManagement1.Name = "userManagement1";
            this.userManagement1.Size = new System.Drawing.Size(1252, 629);
            this.userManagement1.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1540, 845);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HỆ THỐNG QUẢN LÝ THƯ VIỆN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBanner)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnTrangChu;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Button btnDocGia;
        private System.Windows.Forms.Button btnSach;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblLibrary;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picBanner;
        private UserManagement userManagement1;
        private BookManagement bookManagement1;

        private class BookManagement : global::FormMain.BookManagement
        {
        }

        private class UserManagement : global::FormMain.UserManagement
        {
        }
    }
}

