using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ThuHocPhi
{
    public partial class frmLogin : Telerik.WinControls.UI.RadForm
    {
        public frmLogin()
        {
            InitializeComponent();            
        }
        frmManagerUsers mu = new frmManagerUsers();
        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtUsername.Focus();
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
            else
            {
                ck = true;
            }
            return ck;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (check())
            {
                DB_ThuHPDataContext db = new DB_ThuHPDataContext();
                var us = db.users.Where(u => u.username == txtUsername.Text && u.password == txtPassword.Text.ToMD5()).FirstOrDefault();
                if (us != null)
                {
                    session.Username = txtUsername.Text;
                    session.HoTen = us.HoTen;
                    //MessageBox.Show(session.HoTen.ToString());
                    //MessageBox.Show(session.Username.ToString());
                    MessageBox.Show("Đăng nhập thành công !");
                    frmMain.User = session.Username.ToString();           
                    this.Hide();                    
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu !");
                    return;
                }
            }
            //if (ckb_rememberPass.Checked)
            //{
            //    Properties.Settings.Default.username = txtUsername.Text;
            //    Properties.Settings.Default.password = txtPassword.Text;
            //    Properties.Settings.Default.Save();
            //}
            //else
            //{
            //    Properties.Settings.Default.username = "";
            //    Properties.Settings.Default.password = "";
            //    Properties.Settings.Default.Save();
            //}
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {            
            //txtUsername.Text = Properties.Settings.Default.username;
            //txtPassword.Text = Properties.Settings.Default.password;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {           
            frmConfigConnectServer CON = new frmConfigConnectServer();
            CON.Show();         
        }
    }
}
