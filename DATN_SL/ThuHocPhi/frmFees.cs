using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using Telerik.WinControls;

namespace ThuHocPhi
{
    public partial class frmFees : Telerik.WinControls.UI.RadForm
    {        
        public frmFees()
        {
            InitializeComponent();
        }
        DB_ThuHPDataContext db = new DB_ThuHPDataContext();        
        private void txtMaSV_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                var HoTen = db.dkbldqts.Where(u => u.MaSV == txtMaSV.Text).FirstOrDefault();
                if (HoTen != null)
                {
                    lbName.Text = HoTen.HoTenSV + " - " + HoTen.NgaySinh;                   
                }
                else
                {
                    lbName.Text = "Không tìm thấy sinh viên nào !";
                }
            }
            if(e.KeyCode == Keys.Escape)
            {
                lbName.Text = "";
            }
        }

        private bool check()
        {
            bool ck = false;
            if (txtMaSV.Text == "")
            {
                MessageBox.Show("Xin nhập Mã sinh viên ");
                txtMaSV.Focus();
            }
            else
            {
                ck = true;
            }
            return ck;
        }
        //frmMain frmM = new frmMain();
        private void btnFees_Click(object sender, EventArgs e)
        {
            if(check())
            {
                var l = db.dkbldqts.Where(u => u.MaSV == txtMaSV.Text).FirstOrDefault();
                if (l != null)
                {
                    session.MaSV = txtMaSV.Text;
                    l.NgayDong = DateTime.Now;
                    l.NguoiThu = session.Username.ToString();
                    db.SubmitChanges();
                    //MessageBox.Show("Masv : " + session.MaSV.ToString());                   
                    //frmTest.Ma = session.MaSV.ToString();
                    if (l.NgayDong == null)
                    {
                        frmFeeByMaSV frmT = new frmFeeByMaSV(session.MaSV.ToString());
                        frmT.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Sinh viên này đã đóng học phí !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Sinh viên này không tồn tại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtMaSV.Text = "";
            lbName.Text = "";
            txtMaSV.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
