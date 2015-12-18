using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace ThuHocPhi
{
    public partial class frmStatisticalByDate : Telerik.WinControls.UI.RadForm
    {
        public frmStatisticalByDate()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //string dt = dateTimePicker1.Value.ToShortDateString();
            if(rdBtnAll.Checked==true)
            {
                session.From = Convert.ToDateTime(dtpFrom.Value.ToShortDateString());
                session.To = Convert.ToDateTime(dtpTo.Value.ToShortDateString());
                //MessageBox.Show("from" + session.From.ToShortDateString()+"to"+session.To.ToShortDateString());
                frmReportHPByDate HPN = new frmReportHPByDate();
                HPN.ShowDialog();
            }
            else if(rdBtnOne.Checked==true)
            {
                session.From = Convert.ToDateTime(dtpFrom.Value.ToShortDateString());
                session.To = Convert.ToDateTime(dtpTo.Value.ToShortDateString());
                //MessageBox.Show("from" + session.From.ToShortDateString()+"to"+session.To.ToShortDateString());
                frmDongHPByDateAndUser HPNN = new frmDongHPByDateAndUser();
                HPNN.ShowDialog();
            }
        }
    }
}
