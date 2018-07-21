using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NguyenVanDat_16CT402010_De39
{
    public partial class frmRpSanPham : Form
    {
        public frmRpSanPham()
        {
            InitializeComponent();
        }

        private void frmRpSanPham_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLGasDataSet.SanPham' table. You can move, or remove it, as needed.
            this.SanPhamTableAdapter.Fill(this.QLGasDataSet.SanPham);
            this.reportViewer1.RefreshReport();
        }
    }
}
