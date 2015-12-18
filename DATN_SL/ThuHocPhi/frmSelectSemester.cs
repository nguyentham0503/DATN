using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using Telerik.WinControls;

namespace ThuHocPhi
{
    public partial class frmSelectSemester : Telerik.WinControls.UI.RadForm
    {
        public frmSelectSemester()
        {
            InitializeComponent();
        }        
        private void frmSelectSemester_Load(object sender, EventArgs e)
        {
            using(ThuHocPhi.DB_ThuHPDataContext hp = new DB_ThuHPDataContext())
            {
                var cb = from hk in hp.HocKies
                         select new { hk.HocKyID, hk.HocKy1 };
                cbbSemester.DataSource = cb;
                cbbSemester.DisplayMember = "HocKy1";
                cbbSemester.ValueMember = "HocKyID";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbbSemester.Text))
            {
                MessageBox.Show("Bạn chưa chọn học kỳ !");
            }
            else
            {
                session.Semester = cbbSemester.Text;
                MessageBox.Show("Chọn học kỳ thành công !");
                this.Hide();
                frmMain.Hocky = session.Semester.ToString();
                this.Close();
            }                       
        }

    }
}
