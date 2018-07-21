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
    public partial class frmNoiBaoHanh : Form
    {
        public frmNoiBaoHanh()
        {
            InitializeComponent();
        }

        private void frmNoiBaoHanh_Load(object sender, EventArgs e)
        {
            txtSDT.MaxLength = 11;
            loadData();
            
            dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvData.ReadOnly = true;
        }

        void Reset()
        {
            addNew = true;
            txtTenDBH.ResetText();
            txtSDT.ResetText();
            txtDiaChi.ResetText();
            cbMaHangSX.SelectedIndex = 0;
            cbSTT.SelectedIndex = 0;
            cbMaHangSX.Focus();

            dgvData.ClearSelection();
        }

        void loadData()
        {
            //load datagrid
            DataTable dt = classKetNoi.getData("select * from NoiBaoHanh order by ID");
            dgvData.DataSource = dt;
            dgvData.Columns[0].HeaderText = "ID";
            dgvData.Columns[1].HeaderText = "Mã hãng SX";
            dgvData.Columns[2].HeaderText = "Số TT";
            dgvData.Columns[3].HeaderText = "Tên điểm BH";
            dgvData.Columns[4].HeaderText = "Địa chỉ";
            dgvData.Columns[5].HeaderText = "Số điện thoại";
            dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvData.Columns[0].Visible = false;

            //load combobox Ma Hang SX
            dt = classKetNoi.getData("select MaHangSX from HangSanXuat");
            DataRow row = dt.NewRow();
            row["MaHangSX"] = "[--Chọn một--]";
            dt.Rows.InsertAt(row, 0);
            cbMaHangSX.DataSource = dt;
            cbMaHangSX.DisplayMember = "MaHangSX";
            cbMaHangSX.ValueMember = "MaHangSX";

            //load combobox So TT
            dt = classKetNoi.getData("select SoPhieuXuat from PhieuXuat");
            row = dt.NewRow();
            row["SoPhieuXuat"] = "[--Chọn một--]";
            dt.Rows.InsertAt(row, 0);
            cbSTT.DataSource = dt;
            cbSTT.DisplayMember = "SoPhieuXuat";
            cbSTT.ValueMember = "SoPhieuXuat";

            Reset();
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            loadData();
        }

        bool addNew = true;
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string tendiembh = txtTenDBH.Text.Trim();
            string address = txtDiaChi.Text.Trim();
            string phone = txtSDT.Text.Trim();
            string sott, mahsx;
            try
            {
                sott = cbSTT.SelectedValue.ToString();
                mahsx = cbMaHangSX.SelectedValue.ToString();
            }
            catch (Exception)
            {
                sott = "";
                mahsx = "";
            }

            if (tendiembh=="" || address=="" || phone=="" || sott=="" || mahsx=="" || cbMaHangSX.SelectedIndex==0 || cbSTT.SelectedIndex == 0)
            {
                //nếu click vào dòng trống cuối datagrid 
                if (sott == "" || mahsx == "")
                {
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
                    if (MessageBox.Show("Bạn có chắc muốn thêm mới Nơi bảo hành này ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        try
                        {
                            string sql = "insert into NoiBaoHanh values('"+ mahsx +"', '"+ sott +"', N'"+ tendiembh +"', N'"+ address +"', '"+ phone +"')";
                            classKetNoi.querySql(sql);
                            loadData();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi. Vui lòng thử lại. Lưu ý: Mã hãng SX và Số TT phải là duy nhất.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                //ngược lại là chỉnh sửa
                else
                {
                    //lấy id dưới datagridview để làm điều kiện sửa
                    string id = dgvData.Rows[dgvData.CurrentCell.RowIndex].Cells[0].Value.ToString();
                    if (MessageBox.Show("Bạn có chắc muốn sửa Nơi bảo hành này ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        try
                        {
                            string sql = "update NoiBaoHanh set MaHangSX='"+ mahsx +"', SoTT='"+ sott +"', TenDiemBaoHanh=N'"+ tendiembh +"', DiaChi=N'"+ address +"', SoDienThoai='"+ phone +"' where ID="+id;
                            classKetNoi.querySql(sql);
                            loadData();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi. Vui lòng thử lại. Lưu ý: Mã hãng SX và Số TT phải là duy nhất.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            addNew = false;
            int r = dgvData.CurrentCell.RowIndex;
            cbMaHangSX.SelectedValue = dgvData.Rows[r].Cells[1].Value.ToString();
            cbSTT.SelectedValue = dgvData.Rows[r].Cells[2].Value.ToString();
            txtTenDBH.Text = dgvData.Rows[r].Cells[3].Value.ToString();
            txtDiaChi.Text = dgvData.Rows[r].Cells[4].Value.ToString();
            txtSDT.Text = dgvData.Rows[r].Cells[5].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string id = dgvData.Rows[dgvData.CurrentCell.RowIndex].Cells[0].Value.ToString();
            string phone = txtSDT.Text;
            try
            {
                //neu phone = "" tức là nhấn dòng trống cuối datagrid
                if (phone == "")
                    MessageBox.Show("Vui lòng chọn Nơi bảo hành muốn xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    if (MessageBox.Show("Bạn có chắc muốn xóa Nơi bảo hành này ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        string sql = "delete from NoiBaoHanh where id=" + id;
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

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
