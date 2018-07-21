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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        public static string id;
        public static string pw;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            id = txtID.Text.Trim();
            pw = txtPassword.Text.Trim();
            if (id == "" || pw == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin đăng nhập.", "Thông báo");
            }
            else
            {
                DataTable dt = classKetNoi.getData("select * from Users where ID='" + id + "' AND Password='" + pw + "'");

                if (dt.Rows.Count == 1)
                {
                    frmMain frm = new frmMain();
                    frm.Show();
                    this.Hide(); 
                }
                else
                    MessageBox.Show("Thông tin đăng nhập không chính xác.", "Thông báo");
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtID.Focus();
        }
    }
}
