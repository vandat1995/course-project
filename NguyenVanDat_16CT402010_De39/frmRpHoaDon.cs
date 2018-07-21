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
    public partial class frmRpHoaDon : Form
    {
        public frmRpHoaDon()
        {
            InitializeComponent();
        }

        private void frmRpHoaDon_Load(object sender, EventArgs e)
        {

            string sql = "select SoPhieuXuat from PhieuXuat";
            DataTable dt = classKetNoi.getData(sql);
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "SoPhieuXuat";
            comboBox1.ValueMember = "SoPhieuXuat";

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sopx = comboBox1.SelectedValue.ToString();
            // TODO: This line of code loads data into the 'QLGasDataSet2.ChiTietPhieuXuat' table. You can move, or remove it, as needed.
            this.ChiTietPhieuXuatTableAdapter.Fill(this.QLGasDataSet2.ChiTietPhieuXuat);
            // TODO: This line of code loads data into the 'QLGasDataSet2.DataTable1' table. You can move, or remove it, as needed.
            this.DataTable1TableAdapter.Fill(this.QLGasDataSet2.DataTable1, sopx);
            // TODO: This line of code loads data into the 'QLGasDataSet2.KhachHang' table. You can move, or remove it, as needed.
            this.KhachHangTableAdapter.Fill(this.QLGasDataSet2.KhachHang, sopx);

            this.reportViewer1.RefreshReport();
        }
    }
}
