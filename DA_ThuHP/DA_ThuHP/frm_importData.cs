using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace DA_ThuHP
{
    public partial class frm_importData : Form
    {
        public frm_importData()
        {
            InitializeComponent();
            //btnBrowse.Click += new EventHandler(btnBrowse_Click);
            //btnImportExcel.Click += new EventHandler(btnImportExcel_Click);
            //btn_browser.Click + = new EventHandler();

        }
        DB_DADataContext db = new DB_DADataContext();
        private void btn_browser_Click(object sender, EventArgs e)
        {
            // Browse đến file cần import
            OpenFileDialog ofd = new OpenFileDialog();
            // Lấy đường dẫn file import vừa chọn
            txt_pathfile.Text = ofd.ShowDialog() == DialogResult.OK ? ofd.FileName : "";
        }

        private void btn_importExcel_Click(object sender, EventArgs e)
        {
            if (!ValidInput())
                return;

            // Đọc dữ liệu từ tập tin excel trả về DataTable
            DataTable data = ReadDataFromExcelFile();

            // Import dữ liệu đọc được vào database
            ImportIntoDatabase(data);

            // Lấy hết dữ liệu import từ database hiển thị lên gridView
            ShowData();
        }
        private DataTable ReadDataFromExcelFile()
        {
            string connectionString = @"Provider=Microsoft.Jet.OleDb.4.0;Data Source=" + txt_pathfile + ";Extended Properties=\"Excel 12.0 XML\";";
            // Tạo đối tượng kết nối
            OleDbConnection oledbConn = new OleDbConnection(connectionString);
            DataTable data = null;
            try
            {
                // Mở kết nối
                oledbConn.Open();

                // Tạo đối tượng OleDBCommand và query data từ sheet có tên "Sheet1"
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM [Sheet1$]", oledbConn);

                // Tạo đối tượng OleDbDataAdapter để thực thi việc query lấy dữ liệu từ tập tin excel
                OleDbDataAdapter oleda = new OleDbDataAdapter();

                oleda.SelectCommand = cmd;

                // Tạo đối tượng DataContext để hứng dữ liệu từ tập tin excel
                DataSet db = new DataSet();
                //DB_DADataContext db = new DB_DADataContext();
                // Đổ đữ liệu từ tập excel vào DataSet
                oleda.Fill(db);
                //oleda.Fill(db);

                data = db.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                // Đóng chuỗi kết nối
                oledbConn.Close();
            }
            return data;
        }
 
        private void ImportIntoDatabase(DataTable data)
        {
            if (data == null || data.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để import");
                return;
            }

            DB_THPTableAdapters.dkbldqtTableAdapter adapter = new DB_THPTableAdapters.dkbldqtTableAdapter();
            string MaSV = "", HoTenSV = "",NgaySinh = "",MaLop="",HocKy = "",NamHoc = "";
            int TongSoTC = 0;
            bool DongHP = false;
            try
            {
                for (int i = 2; i < data.Rows.Count; i++)
                {
                    MaSV = data.Rows[i]["MaSV"].ToString().Trim();
                    HoTenSV = data.Rows[i]["HoTenSV"].ToString().Trim();
                    NgaySinh = data.Rows[i]["NgaySinh"].ToString().Trim();
                    MaLop = data.Rows[i]["MaLop"].ToString().Trim();
                    HocKy = data.Rows[i]["HocKy"].ToString().Trim();
                    NamHoc = data.Rows[i]["NamHoc"].ToString().Trim();
                    TongSoTC = int.Parse(data.Rows[i]["TongSoTC"].ToString().Trim());
                    DongHP = bool.Parse(data.Rows[i]["DongHP"].ToString().Trim());
                    //DB_THP.dkbldqtDataTable existingdkbldqt = adapter.GetSvBy(MaSV);                    
                    //// Nếu nhân viên chưa tồn tại trong DB thì thêm mới
                    //if (existingdkbldqt == null || existingdkbldqt.Rows.Count == 0)
                    //{
                    //    adapter.InsertSV(MaSV, HoTenSV, NgaySinh,MaLop,HocKy,NamHoc,TongSoTC,DongHP);
                    //}
                    //// Ngược lại, nhân viên đã tồn tại trong DB thì update
                    //else
                    //{
                    //    adapter.UpdateDkbldqtByMaSV(HoTenSV, NgaySinh, MaLop, HocKy, NamHoc, TongSoTC, DongHP, MaSV);
                    //}
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            MessageBox.Show("Kết thúc import");
        }

        private void ShowData()
        {
            DB_THPTableAdapters.dkbldqtTableAdapter adapter = new DB_THPTableAdapters.dkbldqtTableAdapter();
            //HumanResourceTableAdapters.EmployeeInfoTableAdapter adapter = new HumanResourceTableAdapters.EmployeeInfoTableAdapter();
            dgv_dataExcel.DataSource = adapter.GetData();
        }
        private bool ValidInput()
        {
            if (txt_pathfile.Text.Trim() == "")
            {
                MessageBox.Show("Xin vui lòng chọn tập tin excel cần import");
                return false;
            }
            return true;
        }

    }
}
