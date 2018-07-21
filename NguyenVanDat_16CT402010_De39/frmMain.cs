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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            userToolStripMenuItem.Text = "Xin chào: " + frmLogin.id;
        }

        frmSanPham frmSP;
        private void SanPham_Click(object sender, EventArgs e)
        {
            if (frmSP == null || frmSP.IsDisposed)
            {
                frmSP = new frmSanPham();
                frmSP.MdiParent = this;
                frmSP.Show();
            }
            else
                frmSP.Activate();
        }


        frmKhachHang frmKH;
        private void KhachHang_Click(object sender, EventArgs e)
        {
            if (frmKH == null || frmKH.IsDisposed)
            {
                frmKH = new frmKhachHang();
                frmKH.MdiParent = this;
                frmKH.Show();
            }
            else
                frmKH.Activate();
        }

        frmHangSanXuat frmHSX;
        private void HangSanXuat_Click(object sender, EventArgs e)
        {
            if (frmHSX == null || frmHSX.IsDisposed)
            {
                frmHSX = new frmHangSanXuat();
                frmHSX.MdiParent = this;
                frmHSX.Show();
            }
            else
                frmHSX.Activate();
        }

        frmNoiBaoHanh frmNBH;
        private void NoiBaoHanh_Click(object sender, EventArgs e)
        {
            if (frmNBH == null || frmNBH.IsDisposed)
            {
                frmNBH = new frmNoiBaoHanh();
                frmNBH.MdiParent = this;
                frmNBH.Show();
            }
            else
                frmNBH.Activate();
        }

        frmPhieuXuat frmPX;
        private void PhieuXuat_Click(object sender, EventArgs e)
        {
            if (frmPX == null || frmPX.IsDisposed)
            {
                frmPX = new frmPhieuXuat();
                frmPX.MdiParent = this;
                frmPX.Show();
            }
            else
                frmPX.Activate();
        }

        private void Thoat_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        frmSearch frmSearch;
        private void TimKiem_Click(object sender, EventArgs e)
        {
            if (frmSearch == null || frmSearch.IsDisposed)
            {
                frmSearch = new frmSearch();
                frmSearch.MdiParent = this;
                frmSearch.Show();
            }
            else
                frmSearch.Activate();
        }

        frmChangePassword frmChangePW;
        private void DoiMatKhau_Click(object sender, EventArgs e)
        {
            if (frmChangePW == null || frmChangePW.IsDisposed)
            {
                frmChangePW = new frmChangePassword();
                frmChangePW.MdiParent = this;
                frmChangePW.Show();
            }
            else
                frmChangePW.Activate();
        }

        frmAuthor frmAu;
        private void TacGia_Click(object sender, EventArgs e)
        {
            if (frmAu == null || frmAu.IsDisposed)
            {
                frmAu = new frmAuthor();
                frmAu.MdiParent = this;
                frmAu.Show();
            }
            else
                frmAu.Activate();
        }

        frmRpSanPham frmRpSP;
        private void sanPhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmRpSP == null || frmRpSP.IsDisposed)
            {
                frmRpSP = new frmRpSanPham();
                frmRpSP.MdiParent = this;
                frmRpSP.Show();
            }
            else
                frmRpSP.Activate();
        }

        frmRpKhachHang frmRpKH;
        private void khachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmRpKH == null || frmRpKH.IsDisposed)
            {
                frmRpKH = new frmRpKhachHang();
                frmRpKH.MdiParent = this;
                frmRpKH.Show();
            }
            else
                frmRpKH.Activate();
        }

        frmRpHoaDon frmCTPX;
        private void PhieuXuatTooltip_Click(object sender, EventArgs e)
        {
            if (frmCTPX == null || frmCTPX.IsDisposed)
            {
                frmCTPX = new frmRpHoaDon();
                frmCTPX.MdiParent = this;
                frmCTPX.Show();
            }
            else
                frmCTPX.Activate();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát?", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop) == DialogResult.Cancel)
            {
                e.Cancel = true;
            } 
        }
    }
}
