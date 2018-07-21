namespace NguyenVanDat_16CT402010_De39
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.HeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.DoiMatKhau = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.SanPham = new System.Windows.Forms.ToolStripMenuItem();
            this.KhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.HangSanXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.NoiBaoHanh = new System.Windows.Forms.ToolStripMenuItem();
            this.PhieuXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.ThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.sanPhamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.khachHangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PhieuXuatTooltip = new System.Windows.Forms.ToolStripMenuItem();
            this.TimKiem = new System.Windows.Forms.ToolStripMenuItem();
            this.TacGia = new System.Windows.Forms.ToolStripMenuItem();
            this.Thoat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HeThong,
            this.DanhMuc,
            this.ThongKe,
            this.TimKiem,
            this.TacGia,
            this.Thoat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(635, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // HeThong
            // 
            this.HeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DoiMatKhau,
            this.toolStripSeparator1,
            this.userToolStripMenuItem});
            this.HeThong.Image = global::NguyenVanDat_16CT402010_De39.Properties.Resources.Apps_system_software_update_icon;
            this.HeThong.Name = "HeThong";
            this.HeThong.Size = new System.Drawing.Size(85, 20);
            this.HeThong.Text = "Hệ thống";
            // 
            // DoiMatKhau
            // 
            this.DoiMatKhau.Image = global::NguyenVanDat_16CT402010_De39.Properties.Resources.Apps_preferences_desktop_user_password_icon;
            this.DoiMatKhau.Name = "DoiMatKhau";
            this.DoiMatKhau.Size = new System.Drawing.Size(145, 22);
            this.DoiMatKhau.Text = "Đổi mật khẩu";
            this.DoiMatKhau.Click += new System.EventHandler(this.DoiMatKhau_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(142, 6);
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.Enabled = false;
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.userToolStripMenuItem.Text = "user";
            // 
            // DanhMuc
            // 
            this.DanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SanPham,
            this.KhachHang,
            this.HangSanXuat,
            this.NoiBaoHanh,
            this.PhieuXuat});
            this.DanhMuc.Image = global::NguyenVanDat_16CT402010_De39.Properties.Resources.Apps_menu_editor_icon;
            this.DanhMuc.Name = "DanhMuc";
            this.DanhMuc.Size = new System.Drawing.Size(90, 20);
            this.DanhMuc.Text = "Danh mục";
            // 
            // SanPham
            // 
            this.SanPham.Name = "SanPham";
            this.SanPham.Size = new System.Drawing.Size(149, 22);
            this.SanPham.Text = "Sản phẩm";
            this.SanPham.Click += new System.EventHandler(this.SanPham_Click);
            // 
            // KhachHang
            // 
            this.KhachHang.Name = "KhachHang";
            this.KhachHang.Size = new System.Drawing.Size(149, 22);
            this.KhachHang.Text = "Khách hàng";
            this.KhachHang.Click += new System.EventHandler(this.KhachHang_Click);
            // 
            // HangSanXuat
            // 
            this.HangSanXuat.Name = "HangSanXuat";
            this.HangSanXuat.Size = new System.Drawing.Size(149, 22);
            this.HangSanXuat.Text = "Hãng sản xuất";
            this.HangSanXuat.Click += new System.EventHandler(this.HangSanXuat_Click);
            // 
            // NoiBaoHanh
            // 
            this.NoiBaoHanh.Name = "NoiBaoHanh";
            this.NoiBaoHanh.Size = new System.Drawing.Size(149, 22);
            this.NoiBaoHanh.Text = "Nơi bảo hành";
            this.NoiBaoHanh.Click += new System.EventHandler(this.NoiBaoHanh_Click);
            // 
            // PhieuXuat
            // 
            this.PhieuXuat.Name = "PhieuXuat";
            this.PhieuXuat.Size = new System.Drawing.Size(149, 22);
            this.PhieuXuat.Text = "Phiếu xuất";
            this.PhieuXuat.Click += new System.EventHandler(this.PhieuXuat_Click);
            // 
            // ThongKe
            // 
            this.ThongKe.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sanPhamToolStripMenuItem,
            this.khachHangToolStripMenuItem,
            this.PhieuXuatTooltip});
            this.ThongKe.Image = global::NguyenVanDat_16CT402010_De39.Properties.Resources.Stats_icon;
            this.ThongKe.Name = "ThongKe";
            this.ThongKe.Size = new System.Drawing.Size(70, 20);
            this.ThongKe.Text = "Report";
            // 
            // sanPhamToolStripMenuItem
            // 
            this.sanPhamToolStripMenuItem.Name = "sanPhamToolStripMenuItem";
            this.sanPhamToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.sanPhamToolStripMenuItem.Text = "Sản phẩm";
            this.sanPhamToolStripMenuItem.Click += new System.EventHandler(this.sanPhamToolStripMenuItem_Click);
            // 
            // khachHangToolStripMenuItem
            // 
            this.khachHangToolStripMenuItem.Name = "khachHangToolStripMenuItem";
            this.khachHangToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.khachHangToolStripMenuItem.Text = "Khách hàng";
            this.khachHangToolStripMenuItem.Click += new System.EventHandler(this.khachHangToolStripMenuItem_Click);
            // 
            // PhieuXuatTooltip
            // 
            this.PhieuXuatTooltip.Name = "PhieuXuatTooltip";
            this.PhieuXuatTooltip.Size = new System.Drawing.Size(137, 22);
            this.PhieuXuatTooltip.Text = "Phiếu Xuất";
            this.PhieuXuatTooltip.Click += new System.EventHandler(this.PhieuXuatTooltip_Click);
            // 
            // TimKiem
            // 
            this.TimKiem.Image = global::NguyenVanDat_16CT402010_De39.Properties.Resources.Start_Menu_Search_icon;
            this.TimKiem.Name = "TimKiem";
            this.TimKiem.Size = new System.Drawing.Size(85, 20);
            this.TimKiem.Text = "Tìm kiếm";
            this.TimKiem.Click += new System.EventHandler(this.TimKiem_Click);
            // 
            // TacGia
            // 
            this.TacGia.Image = global::NguyenVanDat_16CT402010_De39.Properties.Resources.administrator_icon;
            this.TacGia.Name = "TacGia";
            this.TacGia.Size = new System.Drawing.Size(72, 20);
            this.TacGia.Text = "Tác giả";
            this.TacGia.Click += new System.EventHandler(this.TacGia_Click);
            // 
            // Thoat
            // 
            this.Thoat.Image = global::NguyenVanDat_16CT402010_De39.Properties.Resources.if_stock_exit_29650;
            this.Thoat.Name = "Thoat";
            this.Thoat.Size = new System.Drawing.Size(66, 20);
            this.Thoat.Text = "Thoát";
            this.Thoat.Click += new System.EventHandler(this.Thoat_Click_1);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(635, 374);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Phần mềm quản lý bán hàng bếp và bình gaz";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem HeThong;
        private System.Windows.Forms.ToolStripMenuItem DoiMatKhau;
        private System.Windows.Forms.ToolStripMenuItem DanhMuc;
        private System.Windows.Forms.ToolStripMenuItem ThongKe;
        private System.Windows.Forms.ToolStripMenuItem TimKiem;
        private System.Windows.Forms.ToolStripMenuItem TacGia;
        private System.Windows.Forms.ToolStripMenuItem SanPham;
        private System.Windows.Forms.ToolStripMenuItem KhachHang;
        private System.Windows.Forms.ToolStripMenuItem HangSanXuat;
        private System.Windows.Forms.ToolStripMenuItem NoiBaoHanh;
        private System.Windows.Forms.ToolStripMenuItem PhieuXuat;
        private System.Windows.Forms.ToolStripMenuItem Thoat;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sanPhamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem khachHangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PhieuXuatTooltip;
    }
}