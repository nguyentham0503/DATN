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
    public partial class frm_ChuaDongHP : Form
    {
        DB_DADataContext db = new DB_DADataContext();
        public frm_ChuaDongHP()
        {
            InitializeComponent();
            //inlineReportSlot1.RenderCompleted += new EventHandler(inlineReportSlot1_RenderCompleted);
        }

        //private void inlineReportSlot1_RenderCompleted(object sender, EventArgs e)
        //{
        //    PerpetuumSoft.Reporting.Components.IReportSource rs = sender as PerpetuumSoft.Reporting.Components.IReportSource;
        //    using (PerpetuumSoft.Reporting.View.PreviewForm previewForm = new PerpetuumSoft.Reporting.View.PreviewForm(rs))
        //    {
        //        previewForm.WindowState = FormWindowState.Maximized;
        //        previewForm.ShowDialog(this);
        //    }

        //}

        private void frm_ChuaDongHP_Load(object sender, EventArgs e)
        {                     
            //this.reportViewer1.RefreshReport();
            //inlineReportSlot1.Prepare();
        }
    }
}
