using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;

namespace ThuHocPhi
{
    public partial class frmSVDongHPdgv : Telerik.WinControls.UI.RadForm
    {
        public frmSVDongHPdgv()
        {
            InitializeComponent();
        }
        DB_ThuHPDataContext db = new DB_ThuHPDataContext();
        private void frmSVDongHPdgv_Load(object sender, EventArgs e)
        {
            redgv();
        }

        private void redgv()
        {
            //string hk = session.Semester.ToString();
            //&& h.HocKy1.ToString().Contains(session.Semester)            
            var list = from u in db.dkbldqts
                       join h in db.HocKies on u.HocKyID equals h.HocKyID
                       where u.NgayDong.ToString().Contains("") && h.HocKy1.ToString().Contains(session.Semester)
                       select new{                           
                           u.MaSV, 
                           u.HoTenSV,
                           u.NgaySinh,
                           u.MaLop,
                           u.NgayDong,
                           TienHP=((u.TongSoTC) * (h.HocPhi))
                       };
            //Console.WriteLine(list);
            dgvDongHP.DataSource = list;
            dgvDongHP.Columns[0].HeaderText = "Mã sinh viên";
            dgvDongHP.Columns[1].HeaderText = "Họ và tên";
            dgvDongHP.Columns[2].HeaderText = "Ngày sinh";
            dgvDongHP.Columns[3].HeaderText = "Mã lớp";
            dgvDongHP.Columns[4].HeaderText = "Ngày đóng";
            dgvDongHP.Columns[5].HeaderText = "Tiền học phí";
            this.dgvDongHP.Columns["TienHP"].DefaultCellStyle.Format = "###,###";
            //row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                redgv();
            }
            else
            {                
                var search = from u in db.dkbldqts
                           join h in db.HocKies on u.HocKyID equals h.HocKyID
                             where u.MaSV.ToString().Contains(txtSearch.Text) && u.NgayDong.ToString().Contains("") && h.HocKy1.ToString().Contains(session.Semester)
                           select new
                           {                               
                               u.MaSV,
                               u.HoTenSV,
                               u.NgaySinh,
                               u.MaLop,
                               u.NgayDong,                               
                               TienHP = ((u.TongSoTC) * (h.HocPhi))
                           };
                dgvDongHP.DataSource = search;
            }
        }

        private void dgvDongHP_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dgvDongHP.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }

    }
}
