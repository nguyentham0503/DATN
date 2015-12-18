using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DA_ThuHP
{
    public partial class frm_dangnhap : Form
    {
        public frm_dangnhap()
        {
            InitializeComponent();
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }
        private bool check()
        {
            bool ck = false;
            if (txt_username.Text == "")
            {
                MessageBox.Show("Xin nhập tên người dùng ");
                txt_username.Focus();

            }
            else if (txt_password.Text == "")
            {
                MessageBox.Show("Xin nhập mật khẩu ");
                txt_password.Focus();

            }
            else
            {
                ck = true;
            }
            return ck;
        }
        private void btn_login_Click(object sender, EventArgs e)
        {
            
            if(check())
            {
                DB_DADataContext db = new DB_DADataContext();               
                var username = db.users.Where(u => u.username == txt_username.Text && u.password == txt_password.Text).FirstOrDefault();
                if (username != null)
                {
                    MessageBox.Show("Đăng nhập thành công !");
                    this.Hide();
                    frm_main frm = new frm_main();
                    frm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu !");
                    return;
                }
            }
        }
    }
}
