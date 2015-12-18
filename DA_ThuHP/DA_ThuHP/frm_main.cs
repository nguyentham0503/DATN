using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_ThuHP
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
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
        private void sinhViênChưaĐóngHọcPhíToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExitsForm("frm_ChuaDongHP"))
            {
                frm_ChuaDongHP CDHP = new frm_ChuaDongHP();
                CDHP.MdiParent = this;
                CDHP.Show();
            }
            else ActiveChildForm("frm_ChuaDongHP");     
        }

        private void chỉnhSửaThôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExitsForm("frm_SuaTKCaNhan"))
            {
                frm_SuaTKCaNhan STKCN = new frm_SuaTKCaNhan();
                STKCN.MdiParent = this;
                //STKCN.MdiParent = this;
                STKCN.Show();
            }
            else ActiveChildForm("frm_SuaTKCaNhan"); 
        }

        private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExitsForm("frm_QuanLiNguoiDung"))
            {
                frm_QuanLiNguoiDung QLND = new frm_QuanLiNguoiDung();
                QLND.MdiParent = this;
                QLND.Show();
            }
            else ActiveChildForm("frm_QuanLiNguoiDung"); 
        }

        private void thúHọcPhíTheoSBDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExitsForm("frm_ThuHP"))
            {
                frm_ThuHP THP = new frm_ThuHP();
                THP.MdiParent = this;
                THP.Show();
            }
            else ActiveChildForm("frm_ThuHP"); 
        }

        private void sinhViênĐãĐóngHọcPhíToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExitsForm("frm_DongHP"))
            {
                frm_DongHP DHP = new frm_DongHP();
                DHP.MdiParent = this;
                DHP.Show();
            }
            else ActiveChildForm("frm_DongHP"); 
        }

        private void importDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExitsForm("frm_importData"))
            {
                frm_importData ID = new frm_importData();
                ID.MdiParent = this;
                ID.Show();
            }
            else ActiveChildForm("frm_importData"); 
        }

    }
}
