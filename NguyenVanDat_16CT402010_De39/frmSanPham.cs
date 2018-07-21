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
    public partial class frmSanPham : Form
    {
        public frmSanPham()
        {
            InitializeComponent();
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            txtMaSP.Enabled = false;
            loadData();
            dgvSanPham.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSanPham.ReadOnly = true;

        }

        void Reset()
        {
            addNew = true;
            txtTenSP.Clear();
            txtBaoHanh.Clear();
            txtDonGia.Clear();
            txtNhaSX.Clear();
            txtTenSP.Focus();
            dgvSanPham.ClearSelection();
        }

        void loadData()
        {
            txtMaSP.Text = MaSP();
            DataTable dtSP = classKetNoi.getData("select * from SanPham");
            dgvSanPham.DataSource = dtSP;
            dgvSanPham.Columns[0].HeaderText = "Mã Sản Phẩm";
            dgvSanPham.Columns[1].HeaderText = "Tên Sản Phẩm";
            dgvSanPham.Columns[2].HeaderText = "Nhà Sản Xuất";
            dgvSanPham.Columns[3].HeaderText = "Bảo Hành (tháng)";
            dgvSanPham.Columns[4].HeaderText = "Đơn giá";
            dgvSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Reset();
        }

        string MaSP()
        {
            string sql = "SELECT MAX(RIGHT(MaSanPham, LEN(MaSanPham)-2)) FROM SanPham";
            int numSP = Convert.ToInt32(classKetNoi.getMa(sql)) + 1;

            string num = numSP.ToString();
            string pre = "SP";
            for (int i = num.Length; i < 3; i++)
                pre += "0";
            return pre + num;

        }

        bool addNew = true;
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string ma = txtMaSP.Text;
            string ten = txtTenSP.Text.Trim();
            string nhasx = txtNhaSX.Text.Trim();
            string bh = txtBaoHanh.Text.Trim();
            string dongia = txtDonGia.Text.Trim();

            if(ten=="" || nhasx=="" || bh=="" || dongia=="" || ma == "")
            {
                //nếu click vào hàng trắng cuối datagrid thì lấy mã cho nó
                if (ma == "")
                {
                    txtMaSP.Text = MaSP();
                    addNew = true;
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //add new
                if (addNew)
                {
                    if(MessageBox.Show("Bạn có chắc muốn thêm mới "+ ma + " ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        try
                        {
                            string sql = "insert into SanPham values('"+ma+"', N'"+ten+"', N'"+nhasx+"',"+bh+","+dongia+")";
                            classKetNoi.querySql(sql);
                            loadData();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi " + ex + ". Vui lòng thử lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                //ngược lại là chỉnh sửa
                else
                {
                    if (MessageBox.Show("Bạn có chắc muốn sửa " + ma + " ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        try
                        {
                            string sql = "update SanPham set TenSanPham=N'"+ ten +"', NhaSanXuat=N'"+ nhasx +"', ThoiHanBaoHanh="+ bh +", DonGia="+ dongia +" where MaSanPham='"+ ma +"'";
                            classKetNoi.querySql(sql);
                            loadData();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi " + ex + ". Vui lòng thử lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }   
            }
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            addNew = false;
            int r = dgvSanPham.CurrentCell.RowIndex;
            txtMaSP.Text = dgvSanPham.Rows[r].Cells[0].Value.ToString();
            txtTenSP.Text = dgvSanPham.Rows[r].Cells[1].Value.ToString();
            txtNhaSX.Text = dgvSanPham.Rows[r].Cells[2].Value.ToString();
            txtBaoHanh.Text = dgvSanPham.Rows[r].Cells[3].Value.ToString();
            txtDonGia.Text = dgvSanPham.Rows[r].Cells[4].Value.ToString();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ma = txtMaSP.Text;
            try
            {
                if (ma == MaSP() || ma == "")
                    MessageBox.Show("Vui lòng chọn sản phẩm muốn xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    if (MessageBox.Show("Bạn có chắc muốn xóa sản phẩm có mã " + ma, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        string sql = "delete from SanPham where MaSanPham='" + ma + "'";
                        classKetNoi.querySql(sql);
                        loadData();
                        MessageBox.Show("Xóa thành công.");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi. Vui lòng thử lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBaoHanh_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
