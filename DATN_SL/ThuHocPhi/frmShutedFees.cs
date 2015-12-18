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
    public partial class frmShutedFees : Telerik.WinControls.UI.RadForm
    {
        public frmShutedFees()
        {
            InitializeComponent();
        }

        private void frmTest_Load(object sender, EventArgs e)
        {
            this.dongHPTableAdapter1.Fill(this.dsDongHP1.DongHP,session.Semester,session.HoTen);
            this.inlineReportSlot1.Prepare();
        }
    }
}
