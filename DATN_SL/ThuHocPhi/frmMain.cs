using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace ThuHocPhi
{
    public partial class frmMain : Telerik.WinControls.UI.RadForm
    {
        public static string User = string.Empty;
        public static string Hocky = string.Empty;
        int day = DateTime.Now.Day;
        int month = DateTime.Now.Month;
        int year = DateTime.Now.Year;
        public frmMain()
        {
            InitializeComponent();
            timer1.Start();
            //lbUser.Text = "Welcome to:" + (str);
            //this.txtUser.Text = session.Username;
            //lbUsername.Text = session.Username;
        }
        public void ChangeLabel(string s)
        {
            lbUser.Text = s;
        }
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool CheckExitsForm(string name)
        {
            bool check = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }
        private void ActiveChildForm(string name)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    frm.Activate();
                    break;
                }
            }
        }
        public void an()
        {
            chọnHọcKỳToolStripMenuItem.Enabled = false;
            dữLiệuToolStripMenuItem.Enabled = false;
            quảnLýTàiKhoảnToolStripMenuItem.Enabled = false;
            thuHọcPhíToolStripMenuItem.Enabled = false;
        }
        public void hien()
        {
            chọnHọcKỳToolStripMenuItem.Enabled = true;
            dữLiệuToolStripMenuItem.Enabled = true;
            quảnLýTàiKhoảnToolStripMenuItem.Enabled = true;
            thuHọcPhíToolStripMenuItem.Enabled = true;
            đăngNhậpToolStripMenuItem.Enabled = false;
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            an();
            this.lbHocKy.Text = "Học kỳ hiện tại :  Bạn chưa chọn học kỳ ";            
            this.lbNgay.Text = "Ngày :   " +day + "/" + month + "/" + year;
        }

        private void dữLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExitsForm("frmImportData"))
            {
                frmImportData CDHP = new frmImportData();
                CDHP.MdiParent = this;
                CDHP.Show();
            }
            else ActiveChildForm("frmImportData"); 
        }

        private void sửaThôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExitsForm("frmRepairInformationPersonal"))
            {
                frmRepairInformationPersonal STTCN = new frmRepairInformationPersonal();
                STTCN.MdiParent = this;
                STTCN.Show();
            }
            else ActiveChildForm("frmRepairInformationPersonal"); 
        }

        private void quảnLýNgườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExitsForm("frmManagerUsers"))
            {
                frmManagerUsers QLND = new frmManagerUsers();
                QLND.MdiParent = this;
                QLND.Show();
            }
            else ActiveChildForm("frmManagerUsers");
        }

        private void inDanhSáchSinhViênChưaĐóngHọcPhíToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExitsForm("frmNotShutFees"))
            {
                frmNotShutFees CDHP = new frmNotShutFees();
                CDHP.MdiParent = this;
                CDHP.Show();
            }
            else ActiveChildForm("frmNotShutFees");
        }

        private void danhSáchSinhViênĐãĐóngHọcPhíToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExitsForm("frmShutedFees"))
            {
                frmShutedFees DHP = new frmShutedFees();
                DHP.MdiParent = this;
                DHP.Show();
            }
            else ActiveChildForm("frmShutedFees");
        }

        private void thuHọcPhíTheoSBDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExitsForm("frmFees"))
            {
                frmFees THP = new frmFees();
                THP.MdiParent = this;
                THP.Show();
            }
            else ActiveChildForm("frmFees");
        }
        int x = 12, y = 18, a = 1;
        Random random = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.lbHour.Text = DateTime.Now.ToShortTimeString();
            //this.lbHour.Text = DateTime.Now.TimeOfDay.ToString();
            try
            {
                x += a;
                lbText.Location = new Point(x, y);
                if (x>=690)
                {
                    a = -1;
                    lbText.ForeColor = Color.FromArgb(random.Next(0,255),random.Next(0,255),random.Next(0,255));
                }
                if(x<=12)
                {
                    a = 1;
                    lbText.ForeColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
                }
            }
            catch(Exception ex)
            {

            }
        }
      
        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {            
                frmLogin DN = new frmLogin();                
                DN.ShowDialog();
                if (!string.IsNullOrEmpty(User))
                {
                    this.lbUser.Text = "Xin chào :  "+(User);                    
                    this.chọnHọcKỳToolStripMenuItem.Enabled = true;
                    this.đăngNhậpToolStripMenuItem.Enabled = false;
                    //this.hien();
                } 
        }

        private void chọnHọcKỳToolStripMenuItem_Click(object sender, EventArgs e)
        {

                frmSelectSemester CHK = new frmSelectSemester();
                //CHK.MdiParent = this;
                CHK.ShowDialog();
                if (!string.IsNullOrEmpty(Hocky))
                {
                    this.lbHocKy.Text = "Học kỳ hiện tại :  " + (Hocky);                    
                    this.dữLiệuToolStripMenuItem.Enabled = true;
                    this.quảnLýTàiKhoảnToolStripMenuItem.Enabled = true;
                    this.thuHọcPhíToolStripMenuItem.Enabled = true;                    
                    //this.hien();
                }
            
        }

        private void xemHọcPhíTheoKỳToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExitsForm("frmStatisticalByUser"))
            {
                frmStatisticalByUser HPNT = new frmStatisticalByUser();
                HPNT.MdiParent = this;
                HPNT.Show();
            }
            else ActiveChildForm("frmStatisticalByUser");
        }

        private void thốngKêThuHọcPhíTheoNgàyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExitsForm("frmStatisticalByDate"))
            {
                frmStatisticalByDate HPN = new frmStatisticalByDate();
                HPN.MdiParent = this;
                HPN.Show();
            }
            else ActiveChildForm("frmStatisticalByDate");
        }

        private void xemHọcPhíToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExitsForm("frmSVDongHPdgv"))
            {
                frmSVDongHPdgv DHP = new frmSVDongHPdgv();
                DHP.MdiParent = this;
                DHP.Show();
            }
            else ActiveChildForm("frmSVDongHPdgv");
        }

        private void giớiThiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExitsForm("frmIntrodue"))
            {
                frmIntrodue GT = new frmIntrodue();
                GT.MdiParent = this;
                GT.Show();
            }
            else ActiveChildForm("frmIntrodue");
        }

    }
}
