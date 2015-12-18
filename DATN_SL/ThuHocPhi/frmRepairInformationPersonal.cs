using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Telerik.WinControls;

namespace ThuHocPhi
{
    public partial class frmRepairInformationPersonal : Telerik.WinControls.UI.RadForm
    {
        public frmRepairInformationPersonal()
        {
            InitializeComponent();
        }
        DB_ThuHPDataContext db = new DB_ThuHPDataContext();

        private void frmRepairInformationPersonal_Load(object sender, EventArgs e)
        {
            var nd = db.users.Where(u => u.username == session.Username).FirstOrDefault();
            //var nd = (from u in db.users
            //          select u).Single();
            txtUsername.Text = nd.username;
            txtPassword.Text = "";
            txtPhone.Text = nd.Phone.ToString();
            txtName.Text = nd.HoTen;
            txtUsername.Enabled = false;
            txtPassword.Focus();
        }
        public bool IsNumber(string pText)
        {
            String regexString = @"^[-+]?[0-9]*\.?[0-9]+$";
            Regex r = new Regex(regexString);
            if (r.IsMatch(pText))
                return true;
            else
                return false;
        }
         
        private bool check()
        {
            bool ck = false;
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Xin nhập tên người dùng ");
                txtUsername.Focus();

            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Xin nhập mật khẩu ");
                txtPassword.Focus();

            }
            else if ((txtConfirmPassword.Text) != (txtPassword.Text))
            {
                MessageBox.Show("Bạn cần nhập đúng mật khẩu");
                txtConfirmPassword.Focus();
            }
            else if (IsNumber(txtPhone.Text) == false)
            {
                MessageBox.Show("Bạn cần nhập định dạng số cho số điện thoại");
                txtPhone.Focus();
            }
            {
                ck = true;
            }
            return ck;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (check())
            {
                var username = db.users.Where(us => us.username == txtUsername.Text).Single();
                if (username != null)
                {

                    MessageBox.Show("Cập nhật thông tin người dùng thành công !");
                }
                else
                {
                    MessageBox.Show("Cập nhật không thành công !");
                    return;
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtUsername.Enabled = false;
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
            txtPassword.Focus();
        }

    }
}
