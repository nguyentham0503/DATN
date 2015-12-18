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
    public partial class frmReportHPByDate : Telerik.WinControls.UI.RadForm
    {
        public frmReportHPByDate()
        {
            InitializeComponent();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            this.hocPhiTheoDateTableAdapter1.Fill(this.dsHocPhiTheoNgay1.HocPhiTheoDate, session.Semester, session.From.ToShortDateString(), session.To.ToShortDateString());
            this.inlineReportSlot1.Prepare();
        }
    }
}
