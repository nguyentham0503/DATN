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
    public partial class frmNotShutFees : Telerik.WinControls.UI.RadForm
    {
        public frmNotShutFees()
        {
            InitializeComponent();
        }

        private void frmTest_Load(object sender, EventArgs e)
        {                        
            this.chuaDongHPTableAdapter1.Fill(this.dsChuaDongHP1.ChuaDongHP,session.Semester,session.HoTen);
            this.inlineReportSlot1.Prepare();   
        }
    }
}
