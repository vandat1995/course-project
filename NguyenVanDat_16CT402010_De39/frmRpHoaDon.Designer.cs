namespace NguyenVanDat_16CT402010_De39
{
    partial class frmRpHoaDon
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ChiTietPhieuXuatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QLGasDataSet2 = new NguyenVanDat_16CT402010_De39.QLGasDataSet2();
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ChiTietPhieuXuatTableAdapter = new NguyenVanDat_16CT402010_De39.QLGasDataSet2TableAdapters.ChiTietPhieuXuatTableAdapter();
            this.DataTable1TableAdapter = new NguyenVanDat_16CT402010_De39.QLGasDataSet2TableAdapters.DataTable1TableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.KhachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.KhachHangTableAdapter = new NguyenVanDat_16CT402010_De39.QLGasDataSet2TableAdapters.KhachHangTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChiTietPhieuXuatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLGasDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KhachHangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Số phiếu xuất:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(766, 65);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tùy chỉnh phiếu xuất";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(275, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(165, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(473, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 27);
            this.button1.TabIndex = 3;
            this.button1.Text = "Xem";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ChiTietPhieuXuatBindingSource
            // 
            this.ChiTietPhieuXuatBindingSource.DataMember = "ChiTietPhieuXuat";
            this.ChiTietPhieuXuatBindingSource.DataSource = this.QLGasDataSet2;
            // 
            // QLGasDataSet2
            // 
            this.QLGasDataSet2.DataSetName = "QLGasDataSet2";
            this.QLGasDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.QLGasDataSet2;
            // 
            // ChiTietPhieuXuatTableAdapter
            // 
            this.ChiTietPhieuXuatTableAdapter.ClearBeforeFill = true;
            // 
            // DataTable1TableAdapter
            // 
            this.DataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ChiTietPhieuXuatBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.DataTable1BindingSource;
            reportDataSource3.Name = "DataSet3";
            reportDataSource3.Value = this.KhachHangBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "NguyenVanDat_16CT402010_De39.RpPhieuXuat.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 83);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(766, 295);
            this.reportViewer1.TabIndex = 3;
            // 
            // KhachHangBindingSource
            // 
            this.KhachHangBindingSource.DataMember = "KhachHang";
            this.KhachHangBindingSource.DataSource = this.QLGasDataSet2;
            // 
            // KhachHangTableAdapter
            // 
            this.KhachHangTableAdapter.ClearBeforeFill = true;
            // 
            // frmRpHoaDon
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 390);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRpHoaDon";
            this.Text = "Báo cáo chi tiết Phiếu Xuất";
            this.Load += new System.EventHandler(this.frmRpHoaDon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChiTietPhieuXuatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLGasDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KhachHangBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource ChiTietPhieuXuatBindingSource;
        private QLGasDataSet2 QLGasDataSet2;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private QLGasDataSet2TableAdapters.ChiTietPhieuXuatTableAdapter ChiTietPhieuXuatTableAdapter;
        private QLGasDataSet2TableAdapters.DataTable1TableAdapter DataTable1TableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource KhachHangBindingSource;
        private QLGasDataSet2TableAdapters.KhachHangTableAdapter KhachHangTableAdapter;
    }
}