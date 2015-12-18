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
    public partial class frmStatisticalByUser : Telerik.WinControls.UI.RadForm
    {
        public frmStatisticalByUser()
        {
            InitializeComponent();
        }

        private void frmStatisticalByUser_Load(object sender, EventArgs e)
        {
            this.hocPhiTheoNguoiThuTableAdapter1.Fill(this.dsHocPhiTheoNguoiThu1.HocPhiTheoNguoiThu, session.Semester);
            this.inlineReportSlot1.Prepare();
        }
    }
}
