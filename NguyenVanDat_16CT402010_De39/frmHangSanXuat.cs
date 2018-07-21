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
    public partial class frmHangSanXuat : Form
    {
        public frmHangSanXuat()
        {
            InitializeComponent();
        }

        void Reset()
        {
            addNew = true;
            txtTenHangSX.Clear();
            txtDiaChi.Clear();
            txtSDT.Clear();
            txtTenHangSX.Focus();
            dgvData.ClearSelection();
        }

        string MaHangSX()
        {
            string sql = "SELECT MAX(RIGHT(MaHangSX, LEN(MaHangSX)-2)) FROM HangSanXuat";
            int maH = Convert.ToInt32(classKetNoi.getMa(sql)) + 1;

            string ma = maH.ToString();
            string pre = "H";
            for (int i = ma.Length; i < 4; i++)
                pre += "0";
            return pre + ma;
        }

        void loadData()
        {
            txtMaHangSX.Text = MaHangSX();

            DataTable dtH = classKetNoi.getData("select * from HangSanXuat");
            dgvData.DataSource = dtH;
            dgvData.Columns[0].HeaderText = "Mã Hãng SX";
            dgvData.Columns[1].HeaderText = "Tên Hãng SX";
            dgvData.Columns[2].HeaderText = "Địa chỉ tại VN";
            dgvData.Columns[3].HeaderText = "Số điện thoại";
            dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            Reset();
        }

        private void frmHangSanXuat_Load(object sender, EventArgs e)
        {
            txtMaHangSX.Enabled = false;
            //sdt chỉ cao nhất 11 kí tự
            txtSDT.MaxLength = 11;
            loadData();
            dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvData.ReadOnly = true;
        }

        bool addNew = true;
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string ma = txtMaHangSX.Text;
            string ten = txtTenHangSX.Text.Trim();
            string address = txtDiaChi.Text.Trim();
            string phone = txtSDT.Text.Trim();

            if (ten == "" || address == "" || phone == "" || ma=="")
            {
                if (ma == "")
                {
                    txtMaHangSX.Text = MaHangSX();
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
                    if (MessageBox.Show("Bạn có chắc muốn thêm mới " + ma + " ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        try
                        {
                            string sql = "insert into HangSanXuat values('"+ ma +"', N'"+ ten +"', N'"+ address +"', '"+ phone +"')";
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
                            string sql = "update HangSanXuat set TenHangSX=N'" + ten + "', DiaChiVPChinhTaiVN=N'" + address + "', SoDienThoai='" + phone + "' where MaHangSX='" + ma + "'";
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ma = txtMaHangSX.Text;
            if (ma == MaHangSX() || ma == "")
            {
                MessageBox.Show("Vui lòng chọn Hãng muốn xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa Hãng có mã " + ma, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string sql = "delete from HangSanXuat where MaHangSX='" + ma + "'";
                    classKetNoi.querySql(sql);
                    loadData();
                    MessageBox.Show("Xóa thành công.");
                }
            } 
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            addNew = false;
            int r = dgvData.CurrentCell.RowIndex;
            txtMaHangSX.Text = dgvData.Rows[r].Cells[0].Value.ToString();
            txtTenHangSX.Text = dgvData.Rows[r].Cells[1].Value.ToString();
            txtDiaChi.Text = dgvData.Rows[r].Cells[2].Value.ToString();
            txtSDT.Text = dgvData.Rows[r].Cells[3].Value.ToString();
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
