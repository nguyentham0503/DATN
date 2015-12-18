using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using Telerik.WinControls;

namespace ThuHocPhi
{
    public partial class frmManagerUsers : Telerik.WinControls.UI.RadForm
    {
        DB_ThuHPDataContext db = new DB_ThuHPDataContext();
        public frmManagerUsers()
        {
            InitializeComponent();
        }

        public void an()
        {
            txtUsername.Enabled = false;
            btnCancel.Enabled = false;
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
        }

        public void hien()
        {
            btnCancel.Enabled = true;
            btnSave.Enabled = true;
        }
        private void redgv()
        {
            var list = from u in db.users
                       select u;
            dgvUsers.DataSource = list;
            dgvUsers.Columns[0].HeaderText = "Tên người dùng";
            dgvUsers.Columns[1].HeaderText = "Mật khẩu";
            dgvUsers.Columns[2].HeaderText = "Họ và tên";
            dgvUsers.Columns[3].HeaderText = "Số điện thoại";
        }
        private void reset()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
        }

        private void frmManagerUsers_Load(object sender, EventArgs e)
        {
            an();
            redgv();
            reset();
        }
        private void binding()
        {
            txtUsername.Text = dgvUsers.CurrentRow.Cells[0].Value.ToString();
            txtPassword.Text = dgvUsers.CurrentRow.Cells[1].Value.ToString();           
            txtConfirmPassword.Text = dgvUsers.CurrentRow.Cells[1].Value.ToString();            
            if (dgvUsers.CurrentRow.Cells[2].Value != null)
            {
                txtName.Text = dgvUsers.CurrentRow.Cells[2].Value.ToString();
            }
            else
            {
                txtName.Text = "";
            }
            if (dgvUsers.CurrentRow.Cells[3].Value != null)
            {
                txtPhone.Text = dgvUsers.CurrentRow.Cells[3].Value.ToString();
            }
            else
            {
                txtPhone.Text = "";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            binding();
            txtUsername.Enabled = false;
            txtPassword.Enabled = false;
            txtConfirmPassword.Enabled = false;
            btnCancel.Enabled = true;
            btnDelete.Enabled = true;
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
        private void btnAdd_Click(object sender, EventArgs e)
        {
            hien();
            txtUsername.Enabled = true;            
            reset();
            txtUsername.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            frmManagerUsers QLND = new frmManagerUsers();
            user us = new user();
            //frmRepairInformationPersonal TTCN = new frmRepairInformationPersonal();
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
            else if (txtConfirmPassword.Text != txtPassword.Text)
            {                
                MessageBox.Show("Bạn phải nhập đúng mật khẩu !");
                txtConfirmPassword.Text = "";
                txtConfirmPassword.Focus();               
            }
            else if ((txtPhone.Text !="") && (IsNumber(txtPhone.Text) == false))
            {

                MessageBox.Show("Bạn phải nhập định dạng số cho điện thoại");
                txtPhone.Text = "";
                txtPhone.Focus();

            }
            else
            {
                us.username = txtUsername.Text;
                us.password = txtPassword.Text.ToMD5();
                
                if (txtName.Text != "")
                {
                    us.HoTen = txtName.Text;
                }
                else
                {
                    us.HoTen = null;
                }
                if (txtPhone.Text != "")
                {
                    us.Phone = int.Parse(txtPhone.Text);
                }
                else
                {
                    us.Phone = null;
                }                
                db.users.InsertOnSubmit(us);
                db.SubmitChanges();
                redgv();
                dgvUsers.Enabled = true;
                MessageBox.Show("Thêm mới thánh công");
                reset();
                btnAdd.Focus();
                an();
                btnDelete.Enabled = true;
                
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var l = (from us in db.users
                     where us.username == txtUsername.Text
                     select us).Single();
            //l.Email = txt_email.Text;
            if ((txtPhone.Text != "") && (IsNumber(txtPhone.Text) == false))
            {

                MessageBox.Show("Bạn phải nhập định dạng số cho điện thoại");
                txtPhone.Text = "";
                txtPhone.Focus();

            }
            else
            {
                l.username = txtUsername.Text;
                l.password = txtPassword.Text;
                //l.password = Decrypt(txtPassword.Text, true);
                if (txtName.Text != "")
                {
                    l.HoTen = txtName.Text;
                }
                else
                {
                    l.HoTen = null;
                }
                if (txtPhone.Text != "")
                {
                    l.Phone = int.Parse(txtPhone.Text);
                }
                else
                {
                    l.Phone = null;
                }
                db.SubmitChanges();
                redgv();
                MessageBox.Show("Sửa thành công");                                
                reset();
                txtPassword.Enabled = true;
                txtConfirmPassword.Enabled = true;
            }
            //l.HoTen = txtName.Text;
            //l.Phone = int.Parse(txtPhone.Text);
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn đối tượng để xóa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmManagerUsers_Load(sender, e);
                return;
            }
            var del = db.users.SingleOrDefault(d => d.username == txtUsername.Text);
            db.users.DeleteOnSubmit(del);
            DialogResult dia = new DialogResult();
            dia = MessageBox.Show("Bạn có muốn xóa không ?" + "", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dia == DialogResult.Yes) db.SubmitChanges();
            dgvUsers.Enabled = true;
            btnAdd.Focus();
            redgv();
            reset();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            reset();
            hien();
            txtUsername.Focus();
            redgv();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                redgv();
            }
            else
            {
                var search = from u in db.users
                             where u.username.ToString().Contains(txtSearch.Text)
                             select u;
                dgvUsers.DataSource = search;
            }
        }
    }
    public static class HL
    {
        public static string ToMD5(this string str)
        {
            string result = "";
            byte[] buffer = Encoding.UTF8.GetBytes(str);
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            buffer = md5.ComputeHash(buffer);
            for (int i = 0; i < buffer.Length; i++)
            {
                result += buffer[i].ToString("X2");
            }
            return result;
        }
        //public static string Encrypt(string toEncrypt, bool useHashing)
        //{
        //    byte[] keyArray;
        //    byte[] toEncryptArray = Encoding.UTF8.GetBytes(toEncrypt);
        //    if (useHashing)
        //    {
        //        var hashmd5 = new MD5CryptoServiceProvider();
        //        keyArray = hashmd5.ComputeHash(Encoding.UTF8.GetBytes(toEncrypt));
        //    }
        //    else keyArray = Encoding.UTF8.GetBytes(toEncrypt);
        //    var tdes = new TripleDESCryptoServiceProvider
        //    {
        //        Key = keyArray,
        //        Mode = CipherMode.ECB,
        //        Padding = PaddingMode.PKCS7
        //    };
        //    ICryptoTransform cTransform = tdes.CreateEncryptor();
        //    byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
        //    return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        //}        
    }
}
