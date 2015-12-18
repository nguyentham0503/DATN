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
    public partial class frmDongHPByDateAndUser : Telerik.WinControls.UI.RadForm
    {
        public frmDongHPByDateAndUser()
        {
            InitializeComponent();
        }

        private void frmDongHPByDateAndUser_Load(object sender, EventArgs e)
        {
            this.dongHPByDateAndUserTableAdapter1.Fill(this.dsDongHPByDateAndUser1.DongHPByDateAndUser, session.Semester, session.From.ToShortDateString(), session.To.ToShortDateString(), session.Username);
            this.inlineReportSlot1.Prepare();
            //this.dongHPByDateAndUserTableAdapter1.Fill(this.dsDongHPByDateAndUser1.DongHPByDateAndUser, session.Semester, session.From.ToShortDateString(), session.To.ToShortDateString(),session.Username);
            //this.inlineReportSlot1.Prepare();
        }
    }
}
