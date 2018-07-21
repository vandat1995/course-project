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
    public partial class frmChangePassword : Form
    {
        public frmChangePassword()
        {
            InitializeComponent();
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            lblUser.Text += frmLogin.id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string oldpass = txtOldPass.Text;
            string newpass1 = txtNewPass1.Text;
            string newpass2 = txtNewPass2.Text;
            if (oldpass == "" || newpass1 == "" || newpass2 == "")
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo");
            else
            {
                if (oldpass != frmLogin.pw)
                    MessageBox.Show("Mật khẩu cũ không đúng. Vui lòng nhập lại.", "Thông báo");
                else
                {
                    if (newpass1 != newpass2)
                        MessageBox.Show("Mật khẩu mới không chính xác vui lòng thử lại.", "Thông báo");
                    else
                    {
                        try
                        {
                            classKetNoi.querySql("update Users set Password='" + newpass1 + "' where ID='" + frmLogin.id + "'");
                            MessageBox.Show("Đổi mật khẩu thành công.", "Thông báo");
                            this.Dispose();
                        }
                        catch(Exception)
                        {
                            MessageBox.Show("Lỗi. Vui lòng thử lại.", "Thông báo");
                        }
                    }
                }
            }

        }
    }
}
