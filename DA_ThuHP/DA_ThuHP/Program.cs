using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_ThuHP
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frm_dangnhap());
            //Application.Run(new frm());
            Application.Run(new frm_ChuaDongHP());
            //Application.Run(new frm_DongHP());
            //Application.Run(new frm_ThuHP());
            //Application.Run(new frm_importData());
            //Application.Run(new frm_QuanLiNguoiDung());
        }
    }
}
