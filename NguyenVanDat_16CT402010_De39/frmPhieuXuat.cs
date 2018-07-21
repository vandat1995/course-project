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
    public partial class frmPhieuXuat : Form
    {
        public frmPhieuXuat()
        {
            InitializeComponent();
        }

        private void frmPhieuXuat_Load(object sender, EventArgs e)
        {
            loadData();
            txtSoPhieuXuat.Enabled = false;

            dgvDataPX.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDataPX.ReadOnly = true;
            dgvDataCTPX.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDataCTPX.ReadOnly = true;

        }

        void Reset()
        {
            addNew = true;
            txtNgayLapPhieu.ResetText();
            cbMaKhach.SelectedIndex = 0;
            dgvDataPX.ClearSelection();

            //chitietphieuxuat
            addNew2 = true;
            txtSoLuong.ResetText();
            txtSoLuong.Focus();
            cbSoPhieuXuat.SelectedIndex = 0;
            cbMaSanPham.SelectedIndex = 0;
            dgvDataCTPX.ClearSelection();

            lblTenSP.Text = "Tên SP:";
        }

        string SoPX()
        {
            string sql = "SELECT MAX(RIGHT(SoPhieuXuat, LEN(SoPhieuXuat)-2)) FROM PhieuXuat";
            int maPX = Convert.ToInt32(classKetNoi.getMa(sql)) + 1;

            string ma = maPX.ToString();
            string pre = "PX";
            for (int i = ma.Length; i < 3; i++)
                pre += "0";
            return pre + ma;
        }

        void loadData()
        {
            txtSoPhieuXuat.Text = SoPX();
            
            //load datagrid PhieuXuat
            DataTable dtPX = classKetNoi.getData("select * from PhieuXuat");
            dgvDataPX.DataSource = dtPX;
            dgvDataPX.Columns[0].HeaderText = "Số phiếu xuất";
            dgvDataPX.Columns[1].HeaderText = "Mã khách hàng";
            dgvDataPX.Columns[2].HeaderText = "Ngày lập phiếu";
            dgvDataPX.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //load combobox ma KhachHang
            DataTable dtMaKH = classKetNoi.getData("select MaKhach from KhachHang");
            DataRow rowKH = dtMaKH.NewRow();
            rowKH["MaKhach"] = "[--Chọn một--]";
            dtMaKH.Rows.InsertAt(rowKH, 0);
            cbMaKhach.DataSource = dtMaKH;
            cbMaKhach.DisplayMember = "MaKhach";
            cbMaKhach.ValueMember = "MaKhach";

            //load datagrid chitietphieuxuat
            DataTable dtCT = classKetNoi.getData("select * from ChiTietPhieuXuat");
            dgvDataCTPX.DataSource = dtCT;
            dgvDataCTPX.Columns[0].HeaderText = "ID";
            dgvDataCTPX.Columns[1].HeaderText = "Số phiếu xuất";
            dgvDataCTPX.Columns[2].HeaderText = "Mã sản phẩm";
            dgvDataCTPX.Columns[3].HeaderText = "Số lượng";
            dgvDataCTPX.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDataCTPX.Columns[0].Visible = false;

            //load combobox số phiếu xuất 
            DataTable dtSoPX = classKetNoi.getData("select SoPhieuXuat from PhieuXuat");
            DataRow rowPX = dtSoPX.NewRow();
            rowPX["SoPhieuXuat"] = "[--Chọn một--]";
            dtSoPX.Rows.InsertAt(rowPX, 0);
            cbSoPhieuXuat.DataSource = dtSoPX;
            cbSoPhieuXuat.DisplayMember = "SoPhieuXuat";
            cbSoPhieuXuat.ValueMember = "SoPhieuXuat";

            //load combobox MaSanPham
            DataTable dtMaSP = classKetNoi.getData("select MaSanPham from SanPham");
            DataRow rowSP = dtMaSP.NewRow();
            rowSP[0] = "[--Chọn một--]";
            dtMaSP.Rows.InsertAt(rowSP, 0);
            cbMaSanPham.DataSource = dtMaSP;
            cbMaSanPham.DisplayMember = "MaSanPham";
            cbMaSanPham.ValueMember = "MaSanPham";
            
            //load ten san pham lblTenSP


            Reset();
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            loadData();
        }

        bool addNew = true;
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sopx = txtSoPhieuXuat.Text;
            string ngaylap = txtNgayLapPhieu.Text;
            string makh;
            //bắt lỗi nếu ko lấy đc makh thì cho nó bằng ""
            try
            {
                makh = cbMaKhach.SelectedValue.ToString();
            }
            catch (Exception)
            {
                makh = "";
            }

            //neu người dùng ko chọn mã khách hoặc click vào dòng trắng cuối datagrid
            if (cbMaKhach.SelectedIndex == 0 || makh=="" || sopx=="")
            {
                if (sopx == "")
                {
                    txtSoPhieuXuat.Text = SoPX();
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
                    if (MessageBox.Show("Bạn có chắc muốn thêm mới " + sopx + " ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        try
                        {
                            string sql = "SET DATEFORMAT DMY insert into PhieuXuat values('" + sopx + "', '" + makh + "', '" + ngaylap + "')";
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
                    if (MessageBox.Show("Bạn có chắc muốn sửa " + sopx + " ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        try
                        {
                            string sql = "update PhieuXuat set MaKhach = '"+ makh +"' where SoPhieuXuat='"+ sopx +"'";
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ma = txtSoPhieuXuat.Text;
            try
            {
                if (ma == SoPX() || ma == "")
                {
                    MessageBox.Show("Vui lòng chọn Phiếu xuất muốn xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (MessageBox.Show("Bạn có chắc muốn xóa Phiếu xuất có mã " + ma, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        string sql = "delete from PhieuXuat where SoPhieuXuat='" + ma + "'";
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

        private void dgvDataPX_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            addNew = false;
            int r = dgvDataPX.CurrentCell.RowIndex;
            txtSoPhieuXuat.Text = dgvDataPX.Rows[r].Cells[0].Value.ToString();
            cbMaKhach.SelectedValue = dgvDataPX.Rows[r].Cells[1].Value.ToString();
            txtNgayLapPhieu.Text = dgvDataPX.Rows[r].Cells[2].Value.ToString();
        }

        bool addNew2 = true;
        private void btnLuu2_Click(object sender, EventArgs e)
        {
            string soluong = txtSoLuong.Text.Trim() ;
            string masp, sophieuxuat;
            //bắt lỗi nếu ko lấy đc makh thì cho nó bằng ""
            try
            {
                masp = cbMaSanPham.SelectedValue.ToString();
                sophieuxuat = cbSoPhieuXuat.SelectedValue.ToString();
            }
            catch (Exception)
            {
                masp = "";
                sophieuxuat = "";
            }

            //neu người dùng ko chọn mã sp hoặc hoặc số phieu xuat hoac click vào dòng trắng cuối datagrid
            if (cbMaSanPham.SelectedIndex == 0 || cbSoPhieuXuat.SelectedIndex == 0 || masp == "" || sophieuxuat == "" || soluong == "")
            {
                if(masp=="" || sophieuxuat == "")
                {
                    addNew2 = true;
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //addnew2 = true thì thêm mới 
                if (addNew2)
                {
                    if (MessageBox.Show("Bạn có chắc muốn thêm mới Chi tiết phiếu xuất này ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        try
                        {
                            string sql = "insert into ChiTietPhieuXuat values('"+ sophieuxuat +"', '"+ masp +"',"+ soluong +")";
                            classKetNoi.querySql(sql);
                            loadData();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi .Vui lòng thử lại. Lưu ý: Số phiếu xuất và Mã sản phẩm phải là duy nhất không được trùng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                //ngược lại là chỉnh sửa
                else
                {
                    //lấy id dưới datagridview để làm điều kiện sửa
                    string id = dgvDataCTPX.Rows[dgvDataCTPX.CurrentCell.RowIndex].Cells[0].Value.ToString();
                    if (MessageBox.Show("Bạn có chắc muốn sửa Chi tiết phiếu xuất này không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        try
                        {
                            //chưa làm 
                            string sql = "update ChiTietPhieuXuat set SoLuong='"+ soluong +"', SoPhieuXuat='"+ sophieuxuat +"', MaSanPham='"+ masp + "' where id="+id;
                            classKetNoi.querySql(sql);
                            loadData();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi .Vui lòng thử lại. Lưu ý: Số phiếu xuất và Mã sản phẩm phải là duy nhất không được trùng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void btnXoa2_Click(object sender, EventArgs e)
        {
            string id = dgvDataCTPX.Rows[dgvDataCTPX.CurrentCell.RowIndex].Cells[0].Value.ToString();
            string sl = txtSoLuong.Text;
            try
            {
                //neu sl = "" tức là nhấn dòng trống cuối datagrid
                if (sl == "")
                    MessageBox.Show("Vui lòng chọn Chi tiết muốn xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    if (MessageBox.Show("Bạn có chắc muốn xóa chi tiết này ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        string sql = "delete from ChiTietPhieuXuat where id="+ id;
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

        private void btnNhapLai2_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void dgvDataCTPX_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                addNew2 = false;
                int r = dgvDataCTPX.CurrentCell.RowIndex;
                cbSoPhieuXuat.SelectedValue = dgvDataCTPX.Rows[r].Cells[1].Value.ToString();
                int r2 = dgvDataCTPX.CurrentCell.RowIndex;
                cbMaSanPham.SelectedValue = dgvDataCTPX.Rows[r2].Cells[2].Value.ToString();
                txtSoLuong.Text = dgvDataCTPX.Rows[r2].Cells[3].Value.ToString();
            }
            catch(Exception)
            {
                MessageBox.Show("Chọn dòng có nội dung.");
            }
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void cbMaSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMaSanPham.SelectedIndex == 0)
            {
                return;
            }
            else
            {
                string masp = cbMaSanPham.SelectedValue.ToString();
                string sql = "select TenSanPham from SanPham where MaSanPham='" + masp + "'";
                string tensp = classKetNoi.getMa(sql);
                lblTenSP.Text = "Tên SP: " + tensp;
            }
        }

        private void cbMaSanPham_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void cbSoPhieuXuat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSoPhieuXuat.SelectedIndex == 0)
            {
                return;
            }
            else
            {
                string sopx = cbSoPhieuXuat.SelectedValue.ToString();
                string sql = "select * from ChiTietPhieuXuat where SoPhieuXuat='" + sopx + "'  order by ID";
                DataTable dt = classKetNoi.getData(sql);
                dgvDataCTPX.DataSource = dt;
                dgvDataCTPX.Columns[0].HeaderText = "ID";
                dgvDataCTPX.Columns[1].HeaderText = "Số phiếu xuất";
                dgvDataCTPX.Columns[2].HeaderText = "Mã sản phẩm";
                dgvDataCTPX.Columns[3].HeaderText = "Số lượng";
                dgvDataCTPX.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvDataCTPX.Columns[0].Visible = false;
                
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            frmRpHoaDon frmCTPX = new frmRpHoaDon();
            frmCTPX.Show();
        }
    }
}
