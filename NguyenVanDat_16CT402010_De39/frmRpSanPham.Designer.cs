namespace NguyenVanDat_16CT402010_De39
{
    partial class frmRpSanPham
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
            this.SanPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QLGasDataSet = new NguyenVanDat_16CT402010_De39.QLGasDataSet();
            this.SanPhamTableAdapter = new NguyenVanDat_16CT402010_De39.QLGasDataSetTableAdapters.SanPhamTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.SanPhamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLGasDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // SanPhamBindingSource
            // 
            this.SanPhamBindingSource.DataMember = "SanPham";
            this.SanPhamBindingSource.DataSource = this.QLGasDataSet;
            // 
            // QLGasDataSet
            // 
            this.QLGasDataSet.DataSetName = "QLGasDataSet";
            this.QLGasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SanPhamTableAdapter
            // 
            this.SanPhamTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet_SP";
            reportDataSource1.Value = this.SanPhamBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "NguyenVanDat_16CT402010_De39.RpSanPham.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(759, 461);
            this.reportViewer1.TabIndex = 0;
            // 
            // frmRpSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 461);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmRpSanPham";
            this.Text = "Thống kê sản phẩm";
            this.Load += new System.EventHandler(this.frmRpSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SanPhamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLGasDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource SanPhamBindingSource;
        private QLGasDataSet QLGasDataSet;
        private QLGasDataSetTableAdapters.SanPhamTableAdapter SanPhamTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}