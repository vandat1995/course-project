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
    public partial class frmRpKhachHang : Form
    {
        public frmRpKhachHang()
        {
            InitializeComponent();
        }

        private void frmRpKhachHang_Load(object sender, EventArgs e)
        {
            string sql = "select DiaChi from KhachHang";
            DataTable dt = classKetNoi.getData(sql);
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "DiaChi";
            comboBox1.ValueMember = "DiaChi";

            this.KhachHangTableAdapter.Fill(this.QLGasDataSet1.KhachHang, "%");

            this.reportViewer1.RefreshReport();
            // TODO: This line of code loads data into the 'QLGasDataSet1.KhachHang' table. You can move, or remove it, as needed.

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string city = "%" +comboBox1.SelectedValue.ToString() + "%";

            this.KhachHangTableAdapter.Fill(this.QLGasDataSet1.KhachHang, city);

            this.reportViewer1.RefreshReport();
        }
    }
}
