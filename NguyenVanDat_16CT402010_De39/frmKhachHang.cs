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
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }

        void Reset()
        {
            addNew = true;
            txtTenKH.Clear();
            txtDiaChi.Clear();
            txtSDT.Clear();
            txtTenKH.Focus();
            dgvKhachHang.ClearSelection();
        }

        void loadData()
        {
            txtMaKH.Text = getMaKH();

            DataTable dtKH = classKetNoi.getData("select * from KhachHang");
            dgvKhachHang.DataSource = dtKH;

            dgvKhachHang.Columns[0].HeaderText = "Mã KH";
            dgvKhachHang.Columns[1].HeaderText = "Tên khách hàng";
            dgvKhachHang.Columns[2].HeaderText = "Địa chỉ";
            dgvKhachHang.Columns[3].HeaderText = "Số điện thoại";

            dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            Reset();
        }

        string getMaKH()
        {
            string sql = "SELECT MAX(RIGHT(MaKhach, LEN(MaKhach)-2)) FROM KhachHang";
            int maKH = Convert.ToInt32(classKetNoi.getMa(sql)) + 1;

            string ma = maKH.ToString();
            string pre = "KH";
            for(int i = ma.Length; i < 3; i++)
                pre += "0";
            return pre + ma;
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            txtMaKH.Enabled = false;
            loadData();
            dgvKhachHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKhachHang.ReadOnly = true;
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            loadData();
        }

        bool addNew = true;
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string ma = txtMaKH.Text;
            string name = txtTenKH.Text.Trim();
            string address = txtDiaChi.Text.Trim();
            string phone = txtSDT.Text.Trim();

            if (name == "" || address == "" || phone == "" || ma == "")
            {
                //nếu click xuống cái hàng trắng cuối cùng trong datagrid thì
                if (ma == "")
                {
                    txtMaKH.Text = getMaKH();
                    addNew = true;
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //addnew = true thì thêm mới 
                if (addNew)
                {
                    if(MessageBox.Show("Bạn có chắc muốn thêm mới "+ ma + " ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        try
                        {
                            string sql = "insert into KhachHang values('" + ma + "', N'" + name + "', N'" + address + "', '" + phone + "')";
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
                            string sql = "update KhachHang set TenKhach=N'"+ name +"', DiaChi=N'"+ address +"', SoDienThoai='"+ phone +"' where MaKhach='"+ ma +"'";
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

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Chỉ đc nhập số 
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            addNew = false;
            int r = dgvKhachHang.CurrentCell.RowIndex;
            txtMaKH.Text = dgvKhachHang.Rows[r].Cells[0].Value.ToString();
            txtTenKH.Text = dgvKhachHang.Rows[r].Cells[1].Value.ToString();
            txtDiaChi.Text = dgvKhachHang.Rows[r].Cells[2].Value.ToString();
            txtSDT.Text = dgvKhachHang.Rows[r].Cells[3].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ma = txtMaKH.Text;
            try
            {
                if (ma == getMaKH() || ma == "")
                {
                    MessageBox.Show("Vui lòng chọn khách hàng muốn xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (MessageBox.Show("Bạn có chắc muốn xóa khách hàng có mã " + ma, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        string sql = "delete from KhachHang where MaKhach='" + ma + "'";
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
    }
}
