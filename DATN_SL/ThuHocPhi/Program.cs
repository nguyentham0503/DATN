using System;
using System.Linq;
using System.Windows.Forms;

namespace ThuHocPhi
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
            //Application.Run(new frmSVDongHPdgv());
            //Application.Run(new frmStatisticalByDate());
            Application.Run(new frmMain());
            //Application.Run(new frmConfigConnectServer());
            //Application.Run(new frmFees());
            //Application.Run(new frmShutedFees());
            //Application.Run(new frmNotShutFees());
            //Application.Run(new frmSelectSemester());
        }
    }
}