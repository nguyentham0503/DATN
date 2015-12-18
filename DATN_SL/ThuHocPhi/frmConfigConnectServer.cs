using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Telerik.WinControls;
using System.IO;

namespace ThuHocPhi
{
    public partial class frmConfigConnectServer : Telerik.WinControls.UI.RadForm
    {        
        public frmConfigConnectServer()
        {
            InitializeComponent();
        }
        public SqlConnection getcon(string server, string db, string user, string pass)
        {
            return new SqlConnection("Data Source=" + server + ";Initial Catalog=" + db + ";User ID=" + user + ";Password=" + pass + ";");
        }                
        private void frmConfigConnectServer_Load(object sender, EventArgs e)
        {
            txtMachine.Text = "GIAP-PC";
            txtDatabase.Text = "thuhocphi";
            txtUsername.Text = "sa";
            txtPassword.Text = "123456";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        frmManagerUsers mu = new frmManagerUsers();
        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = getcon(txtMachine.Text, txtDatabase.Text, txtUsername.Text, txtPassword.Text);
            try
            {
                con.Open();
                string path = Environment.CurrentDirectory + "/" + "connect.txt";
                if (!File.Exists(path))
                {
                    File.CreateText(path);
                    using (StreamWriter sw = new StreamWriter(path))
                    {
                        sw.WriteLine("Máy chủ : " + txtMachine.Text);
                        sw.WriteLine("Cơ sở dữ liệu : " + txtDatabase.Text);
                        sw.WriteLine("Người dùng : " + txtUsername.Text);
                        sw.WriteLine("Mật khẩu : " + txtPassword.Text.ToMD5());
                    }

                }
                else
                {
                    using (StreamWriter sw = new StreamWriter(path))
                    {
                        sw.WriteLine("Máy chủ : " + txtMachine.Text);
                        sw.WriteLine("Cơ sở dữ liệu : " + txtDatabase.Text);
                        sw.WriteLine("Người dùng : " + txtUsername.Text);
                        sw.WriteLine("Mật khẩu : " + txtPassword.Text.ToMD5());
                    }
                }
            }
            catch
            {
                MessageBox.Show("Kết nối thất bại","Chú ý",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show("Kết nối thành công tới server"+txtMachine.Text, "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.Hide();
            this.Close();                        
        }
    }
}
