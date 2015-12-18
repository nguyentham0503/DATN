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
    public partial class frm_QuanLiNguoiDung : Form
    {
        DB_DADataContext db = new DB_DADataContext();
        public frm_QuanLiNguoiDung()
        {
            InitializeComponent();
        }
        public void an()
        {
            txt_username.Enabled = false;
            txt_password.Enabled = false;
            btn_cancel.Enabled = false;
            btn_save.Enabled = false;
            btn_delete.Enabled = false;
        }

        public void hien()
        {
            btn_cancel.Enabled = true;
            btn_save.Enabled = true;
        }
        
        private void redgv()
        {
            var list = from u in db.users
                        select u;
            dgv_TaiKhoan.DataSource = list;
            dgv_TaiKhoan.Columns[0].HeaderText = "Tên người dùng";
            dgv_TaiKhoan.Columns[1].HeaderText = "Mật khẩu";
            dgv_TaiKhoan.Columns[2].HeaderText = "Email";
            dgv_TaiKhoan.Columns[3].HeaderText = "Họ và tên";
            dgv_TaiKhoan.Columns[4].HeaderText = "Số điện thoại";
        }
        private void reset()
        {
            txt_username.Text = "";
            txt_password.Text = "";
            txt_email.Text = "";            
            txt_name.Text = "";
            txt_phone.Text = "";
        }
        private void frm_QuanLiNguoiDung_Load(object sender, EventArgs e)
        {
            an();
            redgv();
            reset();
        }
        private void binding()
        {
            txt_username.Text = dgv_TaiKhoan.CurrentRow.Cells[0].Value.ToString();
            txt_password.Text = dgv_TaiKhoan.CurrentRow.Cells[1].Value.ToString();            
            if(dgv_TaiKhoan.CurrentRow.Cells[2].Value != null)
            {
                txt_email.Text = dgv_TaiKhoan.CurrentRow.Cells[2].Value.ToString();
            }
            else
            {
                txt_email.Text = "";
            }
            if (dgv_TaiKhoan.CurrentRow.Cells[3].Value != null)
            {
                txt_name.Text = dgv_TaiKhoan.CurrentRow.Cells[3].Value.ToString();
            }
            else
            {
                txt_name.Text = "";
            }
            if (dgv_TaiKhoan.CurrentRow.Cells[4].Value != null)
            {
                txt_phone.Text = dgv_TaiKhoan.CurrentRow.Cells[4].Value.ToString();
            }
            else
            {
                txt_phone.Text = "";
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_TaiKhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            binding();
            btn_delete.Enabled = true;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            hien();
            txt_username.Enabled = true;
            txt_password.Enabled = true;
            reset();
            txt_username.Focus();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            frm_QuanLiNguoiDung QLND = new frm_QuanLiNguoiDung();
            user us = new user();
            frm_SuaTKCaNhan TTCN = new frm_SuaTKCaNhan();
            if (txt_username.Text == "")
            {
                MessageBox.Show("Xin nhập tên người dùng ");
                txt_username.Focus();

            }
            else if (txt_password.Text == "")
            {
                MessageBox.Show("Xin nhập mật khẩu ");
                txt_password.Focus();

            }
            //else if (TTCN.IsNumber(txt_phone.Text) == false)
            //{
            //    MessageBox.Show("Bạn phải nhập định dạng số cho điện thoại");
            //    txt_phone.Focus();
            //}
            else
            {
                us.username = txt_username.Text;
                us.password = txt_password.Text;
                if(txt_email.Text !="")
                {
                    us.Email = txt_email.Text;
                }
                else
                {
                    us.Email = null;
                }
                if (txt_name.Text != "")
                {
                    us.HoTen = txt_name.Text;
                }
                else
                {
                    us.HoTen = null;
                }
                if (txt_phone.Text != "")
                {
                    us.Phone = int.Parse(txt_phone.Text);
                }
                else
                {
                    us.Phone = null;
                }      
                db.users.InsertOnSubmit(us);
                db.SubmitChanges();
                redgv();
                dgv_TaiKhoan.Enabled = true;
                MessageBox.Show("Thêm mới thánh công");
                reset();
                btn_add.Focus();
                an();
                btn_delete.Enabled = true;
            }        
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            var l = ( from us in db.users
                      where us.username ==txt_username.Text
                      select us ).Single();
            l.Email = txt_email.Text;
            l.HoTen = txt_name.Text;
            l.Phone = int.Parse(txt_phone.Text);
            db.SubmitChanges();
            MessageBox.Show("Sửa thành công");
            redgv();
            reset();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if(txt_username.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn đối tượng để xóa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frm_QuanLiNguoiDung_Load(sender, e);
                return;
            }
            var del = db.users.SingleOrDefault(d => d.username == txt_username.Text);
            db.users.DeleteOnSubmit(del);
            DialogResult dia = new DialogResult();
            dia = MessageBox.Show("Bạn có muốn xóa không ?" + "", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dia == DialogResult.Yes) db.SubmitChanges();
            dgv_TaiKhoan.Enabled = true;
            btn_add.Focus();
            redgv();
            reset();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            reset();
            hien();
            txt_email.Focus();
            redgv();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            if(txt_search.Text =="")
            {
                redgv();
            }
            else
            {
                var search = from u in db.users
                             where u.username.ToString().Contains(txt_search.Text)
                             select u;
                dgv_TaiKhoan.DataSource = search;
            }
        }




    }
}
