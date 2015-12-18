using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_ThuHP
{
    public partial class frm_SuaTKCaNhan : Form
    {
        public frm_SuaTKCaNhan()
        {
            InitializeComponent();
        }
        DB_DADataContext db = new DB_DADataContext();

        private void frm_SuaTKCaNhan_Load(object sender, EventArgs e)
        {
           
            var nd = (from u in db.users
                        select u).Single();
            nd.username = txt_username.Text;
            nd.password = txt_password.Text;
            nd.Email = txt_email.Text;
            nd.HoTen = txt_name.Text;
            nd.Phone = int.Parse(txt_phone.Text);
            db.SubmitChanges();
            txt_username.Enabled = false;
            txt_password.Focus();
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
        public static bool IsValidEmail(string inputEmail)
        {
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputEmail))
                return (true);
            else
                return (false);
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
            else if(IsValidEmail(txt_email.Text)==false)
            {
                MessageBox.Show("Bạn cần nhập đúng định dạng email");
                txt_email.Focus();
            }
            else if(IsNumber(txt_phone.Text)==false)
            {
                MessageBox.Show("Bạn cần nhập định dạng số cho số điện thoại");
                txt_phone.Focus();
            }
            {
                ck = true;
            }
            return ck;
        }
        private void txt_update_Click(object sender, EventArgs e)
        {
            if (check() )
            {
                var username = db.users.Where(us => us.username == txt_username.Text && us.password == txt_password.Text).FirstOrDefault();
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

    }
}
