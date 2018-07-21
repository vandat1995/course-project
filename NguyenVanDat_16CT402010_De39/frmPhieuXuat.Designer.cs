namespace NguyenVanDat_16CT402010_De39
{
    partial class frmPhieuXuat
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPhieuXuat = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNgayLapPhieu = new System.Windows.Forms.DateTimePicker();
            this.cbMaKhach = new System.Windows.Forms.ComboBox();
            this.btnNhapLai = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtSoPhieuXuat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDataPX = new System.Windows.Forms.DataGridView();
            this.tabChiTietPhieuXuat = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvDataCTPX = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.cbSoPhieuXuat = new System.Windows.Forms.ComboBox();
            this.cbMaSanPham = new System.Windows.Forms.ComboBox();
            this.btnNhapLai2 = new System.Windows.Forms.Button();
            this.btnXoa2 = new System.Windows.Forms.Button();
            this.btnLuu2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPhieuXuat.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataPX)).BeginInit();
            this.tabChiTietPhieuXuat.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataCTPX)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPhieuXuat);
            this.tabControl1.Controls.Add(this.tabChiTietPhieuXuat);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(666, 461);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPhieuXuat
            // 
            this.tabPhieuXuat.Controls.Add(this.groupBox1);
            this.tabPhieuXuat.Controls.Add(this.groupBox2);
            this.tabPhieuXuat.Location = new System.Drawing.Point(4, 24);
            this.tabPhieuXuat.Name = "tabPhieuXuat";
            this.tabPhieuXuat.Padding = new System.Windows.Forms.Padding(3);
            this.tabPhieuXuat.Size = new System.Drawing.Size(658, 433);
            this.tabPhieuXuat.TabIndex = 0;
            this.tabPhieuXuat.Text = "Phiếu xuất";
            this.tabPhieuXuat.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtNgayLapPhieu);
            this.groupBox1.Controls.Add(this.cbMaKhach);
            this.groupBox1.Controls.Add(this.btnNhapLai);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnLuu);
            this.groupBox1.Controls.Add(this.txtSoPhieuXuat);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(617, 113);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phiếu xuất";
            // 
            // txtNgayLapPhieu
            // 
            this.txtNgayLapPhieu.Checked = false;
            this.txtNgayLapPhieu.CustomFormat = "dd/MM/yyyy";
            this.txtNgayLapPhieu.Enabled = false;
            this.txtNgayLapPhieu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtNgayLapPhieu.Location = new System.Drawing.Point(339, 26);
            this.txtNgayLapPhieu.Name = "txtNgayLapPhieu";
            this.txtNgayLapPhieu.Size = new System.Drawing.Size(153, 21);
            this.txtNgayLapPhieu.TabIndex = 1;
            // 
            // cbMaKhach
            // 
            this.cbMaKhach.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbMaKhach.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbMaKhach.FormattingEnabled = true;
            this.cbMaKhach.Location = new System.Drawing.Point(111, 67);
            this.cbMaKhach.Name = "cbMaKhach";
            this.cbMaKhach.Size = new System.Drawing.Size(106, 23);
            this.cbMaKhach.TabIndex = 2;
            // 
            // btnNhapLai
            // 
            this.btnNhapLai.Image = global::NguyenVanDat_16CT402010_De39.Properties.Resources.Button_Refresh_icon;
            this.btnNhapLai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhapLai.Location = new System.Drawing.Point(449, 67);
            this.btnNhapLai.Name = "btnNhapLai";
            this.btnNhapLai.Size = new System.Drawing.Size(90, 30);
            this.btnNhapLai.TabIndex = 5;
            this.btnNhapLai.Text = "Nhập lại";
            this.btnNhapLai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNhapLai.UseVisualStyleBackColor = true;
            this.btnNhapLai.Click += new System.EventHandler(this.btnNhapLai_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::NguyenVanDat_16CT402010_De39.Properties.Resources.delete_icon;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(373, 67);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(70, 30);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Image = global::NguyenVanDat_16CT402010_De39.Properties.Resources.Save_as_icon;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(297, 67);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(70, 30);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtSoPhieuXuat
            // 
            this.txtSoPhieuXuat.Location = new System.Drawing.Point(112, 26);
            this.txtSoPhieuXuat.Name = "txtSoPhieuXuat";
            this.txtSoPhieuXuat.Size = new System.Drawing.Size(105, 21);
            this.txtSoPhieuXuat.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã khách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày lập phiếu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số phiếu xuất";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgvDataPX);
            this.groupBox2.Location = new System.Drawing.Point(8, 125);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(617, 300);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách phiếu xuất";
            // 
            // dgvDataPX
            // 
            this.dgvDataPX.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDataPX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataPX.Location = new System.Drawing.Point(6, 20);
            this.dgvDataPX.Name = "dgvDataPX";
            this.dgvDataPX.Size = new System.Drawing.Size(605, 274);
            this.dgvDataPX.TabIndex = 0;
            this.dgvDataPX.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDataPX_CellClick);
            // 
            // tabChiTietPhieuXuat
            // 
            this.tabChiTietPhieuXuat.Controls.Add(this.groupBox4);
            this.tabChiTietPhieuXuat.Controls.Add(this.groupBox3);
            this.tabChiTietPhieuXuat.Location = new System.Drawing.Point(4, 24);
            this.tabChiTietPhieuXuat.Name = "tabChiTietPhieuXuat";
            this.tabChiTietPhieuXuat.Padding = new System.Windows.Forms.Padding(3);
            this.tabChiTietPhieuXuat.Size = new System.Drawing.Size(658, 433);
            this.tabChiTietPhieuXuat.TabIndex = 1;
            this.tabChiTietPhieuXuat.Text = "Chi tiết phiếu xuất";
            this.tabChiTietPhieuXuat.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.dgvDataCTPX);
            this.groupBox4.Location = new System.Drawing.Point(8, 125);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(642, 302);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách chi tiết phiếu xuất";
            // 
            // dgvDataCTPX
            // 
            this.dgvDataCTPX.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDataCTPX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataCTPX.Location = new System.Drawing.Point(6, 20);
            this.dgvDataCTPX.Name = "dgvDataCTPX";
            this.dgvDataCTPX.Size = new System.Drawing.Size(630, 276);
            this.dgvDataCTPX.TabIndex = 0;
            this.dgvDataCTPX.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDataCTPX_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.btnPrint);
            this.groupBox3.Controls.Add(this.lblTenSP);
            this.groupBox3.Controls.Add(this.txtSoLuong);
            this.groupBox3.Controls.Add(this.cbSoPhieuXuat);
            this.groupBox3.Controls.Add(this.cbMaSanPham);
            this.groupBox3.Controls.Add(this.btnNhapLai2);
            this.groupBox3.Controls.Add(this.btnXoa2);
            this.groupBox3.Controls.Add(this.btnLuu2);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(8, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(642, 113);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin chi tiết phiếu xuất";
            // 
            // lblTenSP
            // 
            this.lblTenSP.AutoSize = true;
            this.lblTenSP.Location = new System.Drawing.Point(433, 29);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(50, 15);
            this.lblTenSP.TabIndex = 6;
            this.lblTenSP.Text = "Tên SP:";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(111, 67);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(77, 21);
            this.txtSoLuong.TabIndex = 2;
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuong_KeyPress);
            // 
            // cbSoPhieuXuat
            // 
            this.cbSoPhieuXuat.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbSoPhieuXuat.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbSoPhieuXuat.FormattingEnabled = true;
            this.cbSoPhieuXuat.Location = new System.Drawing.Point(111, 26);
            this.cbSoPhieuXuat.Name = "cbSoPhieuXuat";
            this.cbSoPhieuXuat.Size = new System.Drawing.Size(77, 23);
            this.cbSoPhieuXuat.TabIndex = 0;
            this.cbSoPhieuXuat.SelectedIndexChanged += new System.EventHandler(this.cbSoPhieuXuat_SelectedIndexChanged);
            // 
            // cbMaSanPham
            // 
            this.cbMaSanPham.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbMaSanPham.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbMaSanPham.FormattingEnabled = true;
            this.cbMaSanPham.Location = new System.Drawing.Point(300, 26);
            this.cbMaSanPham.Name = "cbMaSanPham";
            this.cbMaSanPham.Size = new System.Drawing.Size(127, 23);
            this.cbMaSanPham.TabIndex = 1;
            this.cbMaSanPham.SelectedIndexChanged += new System.EventHandler(this.cbMaSanPham_SelectedIndexChanged);
            this.cbMaSanPham.SelectedValueChanged += new System.EventHandler(this.cbMaSanPham_SelectedValueChanged);
            // 
            // btnNhapLai2
            // 
            this.btnNhapLai2.Image = global::NguyenVanDat_16CT402010_De39.Properties.Resources.Button_Refresh_icon;
            this.btnNhapLai2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhapLai2.Location = new System.Drawing.Point(452, 67);
            this.btnNhapLai2.Name = "btnNhapLai2";
            this.btnNhapLai2.Size = new System.Drawing.Size(90, 30);
            this.btnNhapLai2.TabIndex = 5;
            this.btnNhapLai2.Text = "Nhập lại";
            this.btnNhapLai2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNhapLai2.UseVisualStyleBackColor = true;
            this.btnNhapLai2.Click += new System.EventHandler(this.btnNhapLai2_Click);
            // 
            // btnXoa2
            // 
            this.btnXoa2.Image = global::NguyenVanDat_16CT402010_De39.Properties.Resources.delete_icon;
            this.btnXoa2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa2.Location = new System.Drawing.Point(376, 67);
            this.btnXoa2.Name = "btnXoa2";
            this.btnXoa2.Size = new System.Drawing.Size(70, 30);
            this.btnXoa2.TabIndex = 4;
            this.btnXoa2.Text = "Xóa";
            this.btnXoa2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa2.UseVisualStyleBackColor = true;
            this.btnXoa2.Click += new System.EventHandler(this.btnXoa2_Click);
            // 
            // btnLuu2
            // 
            this.btnLuu2.Image = global::NguyenVanDat_16CT402010_De39.Properties.Resources.Save_as_icon;
            this.btnLuu2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu2.Location = new System.Drawing.Point(300, 67);
            this.btnLuu2.Name = "btnLuu2";
            this.btnLuu2.Size = new System.Drawing.Size(70, 30);
            this.btnLuu2.TabIndex = 3;
            this.btnLuu2.Text = "Lưu";
            this.btnLuu2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu2.UseVisualStyleBackColor = true;
            this.btnLuu2.Click += new System.EventHandler(this.btnLuu2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số lượng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(205, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã sản phẩm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Số phiếu xuất";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(548, 67);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(79, 30);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.Text = "In hóa đơn";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // frmPhieuXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 461);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmPhieuXuat";
            this.Text = "Phiếu xuất";
            this.Load += new System.EventHandler(this.frmPhieuXuat_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPhieuXuat.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataPX)).EndInit();
            this.tabChiTietPhieuXuat.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataCTPX)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPhieuXuat;
        private System.Windows.Forms.TabPage tabChiTietPhieuXuat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNhapLai;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox txtSoPhieuXuat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDataPX;
        private System.Windows.Forms.DateTimePicker txtNgayLapPhieu;
        private System.Windows.Forms.ComboBox cbMaKhach;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbMaSanPham;
        private System.Windows.Forms.Button btnNhapLai2;
        private System.Windows.Forms.Button btnXoa2;
        private System.Windows.Forms.Button btnLuu2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvDataCTPX;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.ComboBox cbSoPhieuXuat;
        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.Button btnPrint;
    }
}