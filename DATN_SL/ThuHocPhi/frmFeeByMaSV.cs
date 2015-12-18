using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace ThuHocPhi
{
    public partial class frmFeeByMaSV : Telerik.WinControls.UI.RadForm
    {
        public frmFeeByMaSV()
        {
            InitializeComponent();
        }
        public frmFeeByMaSV(string s)
        {
            InitializeComponent();
            this.thuHocPhiTableAdapter1.Fill(this.dsThuHocPhi1.ThuHocPhi, s);
            this.inlineReportSlot1.Prepare();
        }
        private void frmTest_Load(object sender, EventArgs e)
        {
            
            //this.thuHocPhiTableAdapter1.Fill(this.dsThuHocPhi1.ThuHocPhi,session.MaSV);  
            ////this.thuHocPhiTableAdapter1.Fill(this.dsThuHocPhi1.ThuHocPhi,"0113316");
            //this.inlineReportSlot1.Prepare();           


        }

        private void frmFeeByMaSV_Load(object sender, EventArgs e)
        {

        }
    }
}
