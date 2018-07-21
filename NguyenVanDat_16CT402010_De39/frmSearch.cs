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
    public partial class frmSearch : Form
    {
        public frmSearch()
        {
            InitializeComponent();
        }

        void SeachSP(string ma, string ten)
        {
            string sql;
            
            sql = ten != "" && ma != "" ? "select * from SanPham where MaSanPham='" + ma + "' AND TenSanPham like N'%" + ten + "%'" : sql = ten == "" ? "select * from SanPham where MaSanPham='" + ma + "'" : "select * from SanPham where TenSanPham like N'%" + ten + "%'";
            
            DataTable dt = classKetNoi.getData(sql);
            
            if (dt.Rows.Count < 1)
                MessageBox.Show("Không tìm thấy Sản phẩm này.");
            else
            {
                dgvDataSP.DataSource = dt;
                dgvDataSP.Columns[0].HeaderText = "Mã SP";
                dgvDataSP.Columns[1].HeaderText = "Tên SP";
                dgvDataSP.Columns[2].HeaderText = "Nhà sản xuất";
                dgvDataSP.Columns[3].HeaderText = "Bảo hành (tháng)";
                dgvDataSP.Columns[4].HeaderText = "Đơn giá";
                dgvDataSP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void btnSearch1_Click(object sender, EventArgs e)
        {
            dgvDataSP.DataSource = null;
            string ma = txtMaSP.Text.Trim();
            string ten = txtTenSP.Text.Trim();
            if(ma=="" && ten == "")
            {
                MessageBox.Show("Vui lòng nhập Mã hoặc Tên sản phẩm cần tìm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    SeachSP(ma, ten);
                }
                catch (Exception)
                {
                    MessageBox.Show("Lỗi vui lòng thử lại.");
                }
            }
            txtMaSP.Focus();

        }
        
        private void frmSearch_Load(object sender, EventArgs e)
        {
            txtMaSP.MaxLength = 5;
            txtMaKH.MaxLength = 5;
        }

        void SeachKH(string ma, string ten)
        {
            string sql;

            sql = ten != "" && ma != "" ? "select * from KhachHang where MaKhach='" + ma + "' AND TenKhach like N'%" + ten + "%'" : sql = ten == "" ? "select * from KhachHang where MaKhach='" + ma + "'" : "select * from KhachHang where TenKhach like N'%" + ten + "%'";

            DataTable dt = classKetNoi.getData(sql);

            if (dt.Rows.Count < 1)
                MessageBox.Show("Không tìm thấy Khách hàng này.");
            else
            {
                dgvDataKH.DataSource = dt;
                dgvDataKH.Columns[0].HeaderText = "Mã khách hàng";
                dgvDataKH.Columns[1].HeaderText = "Tên khách hàng";
                dgvDataKH.Columns[2].HeaderText = "Địa chỉ";
                dgvDataKH.Columns[3].HeaderText = "Số điện thoại";
                dgvDataKH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void btnSearch2_Click(object sender, EventArgs e)
        {
            dgvDataKH.DataSource = null;
            string ma = txtMaKH.Text.Trim();
            string ten = txtTenKH.Text.Trim();
            if (ma == "" && ten == "")
            {
                MessageBox.Show("Vui lòng nhập Mã hoặc Tên khách hàng cần tìm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    SeachKH(ma, ten);
                }
                catch (Exception)
                {
                    MessageBox.Show("Lỗi vui lòng thử lại.");
                }
            }
            txtMaKH.Focus();
        }
    }
}
