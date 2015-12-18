namespace ThuHocPhi
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.đăngNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chọnHọcKỳToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dữLiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaThôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNgườiDùngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thuHọcPhíToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thuHọcPhíTheoSBDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchSinhViênĐãĐóngHọcPhíToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inDanhSáchSinhViênChưaĐóngHọcPhíToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemHọcPhíTheoKỳToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêThuHọcPhíTheoNgàyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemHọcPhíToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giớiThiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbHour = new System.Windows.Forms.Label();
            this.lbNgay = new System.Windows.Forms.Label();
            this.lbUser = new System.Windows.Forms.Label();
            this.lbHocKy = new System.Windows.Forms.Label();
            this.lbText = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngNhậpToolStripMenuItem,
            this.chọnHọcKỳToolStripMenuItem,
            this.dữLiệuToolStripMenuItem,
            this.quảnLýTàiKhoảnToolStripMenuItem,
            this.thuHọcPhíToolStripMenuItem,
            this.giớiThiệuToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1455, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // đăngNhậpToolStripMenuItem
            // 
            this.đăngNhậpToolStripMenuItem.Image = global::ThuHocPhi.Properties.Resources.secrecy_icon;
            this.đăngNhậpToolStripMenuItem.Name = "đăngNhậpToolStripMenuItem";
            this.đăngNhậpToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.đăngNhậpToolStripMenuItem.Text = "Đăng nhập";
            this.đăngNhậpToolStripMenuItem.Click += new System.EventHandler(this.đăngNhậpToolStripMenuItem_Click);
            // 
            // chọnHọcKỳToolStripMenuItem
            // 
            this.chọnHọcKỳToolStripMenuItem.Image = global::ThuHocPhi.Properties.Resources.select;
            this.chọnHọcKỳToolStripMenuItem.Name = "chọnHọcKỳToolStripMenuItem";
            this.chọnHọcKỳToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.chọnHọcKỳToolStripMenuItem.Text = "Chọn học kỳ";
            this.chọnHọcKỳToolStripMenuItem.Click += new System.EventHandler(this.chọnHọcKỳToolStripMenuItem_Click);
            // 
            // dữLiệuToolStripMenuItem
            // 
            this.dữLiệuToolStripMenuItem.Image = global::ThuHocPhi.Properties.Resources.data;
            this.dữLiệuToolStripMenuItem.Name = "dữLiệuToolStripMenuItem";
            this.dữLiệuToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.dữLiệuToolStripMenuItem.Text = "Dữ liệu";
            this.dữLiệuToolStripMenuItem.Click += new System.EventHandler(this.dữLiệuToolStripMenuItem_Click);
            // 
            // quảnLýTàiKhoảnToolStripMenuItem
            // 
            this.quảnLýTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sửaThôngTinCáNhânToolStripMenuItem,
            this.quảnLýNgườiDùngToolStripMenuItem});
            this.quảnLýTàiKhoảnToolStripMenuItem.Image = global::ThuHocPhi.Properties.Resources.User_Clients_icon;
            this.quảnLýTàiKhoảnToolStripMenuItem.Name = "quảnLýTàiKhoảnToolStripMenuItem";
            this.quảnLýTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.quảnLýTàiKhoảnToolStripMenuItem.Text = "Quản lý tài khoản";
            // 
            // sửaThôngTinCáNhânToolStripMenuItem
            // 
            this.sửaThôngTinCáNhânToolStripMenuItem.Image = global::ThuHocPhi.Properties.Resources.edituser;
            this.sửaThôngTinCáNhânToolStripMenuItem.Name = "sửaThôngTinCáNhânToolStripMenuItem";
            this.sửaThôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.sửaThôngTinCáNhânToolStripMenuItem.Text = "Sửa thông tin cá nhân";
            this.sửaThôngTinCáNhânToolStripMenuItem.Click += new System.EventHandler(this.sửaThôngTinCáNhânToolStripMenuItem_Click);
            // 
            // quảnLýNgườiDùngToolStripMenuItem
            // 
            this.quảnLýNgườiDùngToolStripMenuItem.Image = global::ThuHocPhi.Properties.Resources.User_Menu_24;
            this.quảnLýNgườiDùngToolStripMenuItem.Name = "quảnLýNgườiDùngToolStripMenuItem";
            this.quảnLýNgườiDùngToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.quảnLýNgườiDùngToolStripMenuItem.Text = "Quản lý người dùng";
            this.quảnLýNgườiDùngToolStripMenuItem.Click += new System.EventHandler(this.quảnLýNgườiDùngToolStripMenuItem_Click);
            // 
            // thuHọcPhíToolStripMenuItem
            // 
            this.thuHọcPhíToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thuHọcPhíTheoSBDToolStripMenuItem,
            this.danhSáchSinhViênĐãĐóngHọcPhíToolStripMenuItem,
            this.inDanhSáchSinhViênChưaĐóngHọcPhíToolStripMenuItem,
            this.xemHọcPhíTheoKỳToolStripMenuItem,
            this.thốngKêThuHọcPhíTheoNgàyToolStripMenuItem,
            this.xemHọcPhíToolStripMenuItem});
            this.thuHọcPhíToolStripMenuItem.Image = global::ThuHocPhi.Properties.Resources.Money_icon;
            this.thuHọcPhíToolStripMenuItem.Name = "thuHọcPhíToolStripMenuItem";
            this.thuHọcPhíToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.thuHọcPhíToolStripMenuItem.Text = "Thu học phí";
            // 
            // thuHọcPhíTheoSBDToolStripMenuItem
            // 
            this.thuHọcPhíTheoSBDToolStripMenuItem.Image = global::ThuHocPhi.Properties.Resources.money_icon__1_;
            this.thuHọcPhíTheoSBDToolStripMenuItem.Name = "thuHọcPhíTheoSBDToolStripMenuItem";
            this.thuHọcPhíTheoSBDToolStripMenuItem.Size = new System.Drawing.Size(355, 26);
            this.thuHọcPhíTheoSBDToolStripMenuItem.Text = "In biên lai thu học phí";
            this.thuHọcPhíTheoSBDToolStripMenuItem.Click += new System.EventHandler(this.thuHọcPhíTheoSBDToolStripMenuItem_Click);
            // 
            // danhSáchSinhViênĐãĐóngHọcPhíToolStripMenuItem
            // 
            this.danhSáchSinhViênĐãĐóngHọcPhíToolStripMenuItem.Image = global::ThuHocPhi.Properties.Resources.Todo_List_24;
            this.danhSáchSinhViênĐãĐóngHọcPhíToolStripMenuItem.Name = "danhSáchSinhViênĐãĐóngHọcPhíToolStripMenuItem";
            this.danhSáchSinhViênĐãĐóngHọcPhíToolStripMenuItem.Size = new System.Drawing.Size(355, 26);
            this.danhSáchSinhViênĐãĐóngHọcPhíToolStripMenuItem.Text = "In danh sách sinh viên đã đóng học phí";
            this.danhSáchSinhViênĐãĐóngHọcPhíToolStripMenuItem.Click += new System.EventHandler(this.danhSáchSinhViênĐãĐóngHọcPhíToolStripMenuItem_Click);
            // 
            // inDanhSáchSinhViênChưaĐóngHọcPhíToolStripMenuItem
            // 
            this.inDanhSáchSinhViênChưaĐóngHọcPhíToolStripMenuItem.Image = global::ThuHocPhi.Properties.Resources.List_24;
            this.inDanhSáchSinhViênChưaĐóngHọcPhíToolStripMenuItem.Name = "inDanhSáchSinhViênChưaĐóngHọcPhíToolStripMenuItem";
            this.inDanhSáchSinhViênChưaĐóngHọcPhíToolStripMenuItem.Size = new System.Drawing.Size(355, 26);
            this.inDanhSáchSinhViênChưaĐóngHọcPhíToolStripMenuItem.Text = "In danh sách sinh viên chưa đóng học phí";
            this.inDanhSáchSinhViênChưaĐóngHọcPhíToolStripMenuItem.Click += new System.EventHandler(this.inDanhSáchSinhViênChưaĐóngHọcPhíToolStripMenuItem_Click);
            // 
            // xemHọcPhíTheoKỳToolStripMenuItem
            // 
            this.xemHọcPhíTheoKỳToolStripMenuItem.Image = global::ThuHocPhi.Properties.Resources.Apps_preferences_contact_list_icon;
            this.xemHọcPhíTheoKỳToolStripMenuItem.Name = "xemHọcPhíTheoKỳToolStripMenuItem";
            this.xemHọcPhíTheoKỳToolStripMenuItem.Size = new System.Drawing.Size(355, 26);
            this.xemHọcPhíTheoKỳToolStripMenuItem.Text = "Thống kê thu học phí theo người lập";
            this.xemHọcPhíTheoKỳToolStripMenuItem.Click += new System.EventHandler(this.xemHọcPhíTheoKỳToolStripMenuItem_Click);
            // 
            // thốngKêThuHọcPhíTheoNgàyToolStripMenuItem
            // 
            this.thốngKêThuHọcPhíTheoNgàyToolStripMenuItem.Image = global::ThuHocPhi.Properties.Resources.Calendar_icon;
            this.thốngKêThuHọcPhíTheoNgàyToolStripMenuItem.Name = "thốngKêThuHọcPhíTheoNgàyToolStripMenuItem";
            this.thốngKêThuHọcPhíTheoNgàyToolStripMenuItem.Size = new System.Drawing.Size(355, 26);
            this.thốngKêThuHọcPhíTheoNgàyToolStripMenuItem.Text = "Thống kê thu học phí theo ngày";
            this.thốngKêThuHọcPhíTheoNgàyToolStripMenuItem.Click += new System.EventHandler(this.thốngKêThuHọcPhíTheoNgàyToolStripMenuItem_Click);
            // 
            // xemHọcPhíToolStripMenuItem
            // 
            this.xemHọcPhíToolStripMenuItem.Image = global::ThuHocPhi.Properties.Resources.see;
            this.xemHọcPhíToolStripMenuItem.Name = "xemHọcPhíToolStripMenuItem";
            this.xemHọcPhíToolStripMenuItem.Size = new System.Drawing.Size(355, 26);
            this.xemHọcPhíToolStripMenuItem.Text = "Xem học phí";
            this.xemHọcPhíToolStripMenuItem.Click += new System.EventHandler(this.xemHọcPhíToolStripMenuItem_Click);
            // 
            // giớiThiệuToolStripMenuItem
            // 
            this.giớiThiệuToolStripMenuItem.Image = global::ThuHocPhi.Properties.Resources.Apps_preferences_desktop_notification_icon;
            this.giớiThiệuToolStripMenuItem.Name = "giớiThiệuToolStripMenuItem";
            this.giớiThiệuToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.giớiThiệuToolStripMenuItem.Text = "Giới thiệu";
            this.giớiThiệuToolStripMenuItem.Click += new System.EventHandler(this.giớiThiệuToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Image = global::ThuHocPhi.Properties.Resources.exit241;
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbHour);
            this.groupBox1.Controls.Add(this.lbNgay);
            this.groupBox1.Controls.Add(this.lbUser);
            this.groupBox1.Controls.Add(this.lbHocKy);
            this.groupBox1.Controls.Add(this.lbText);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 506);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1455, 73);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // lbHour
            // 
            this.lbHour.AutoSize = true;
            this.lbHour.Font = new System.Drawing.Font("Segoe UI", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHour.Location = new System.Drawing.Point(1289, 46);
            this.lbHour.Name = "lbHour";
            this.lbHour.Size = new System.Drawing.Size(32, 19);
            this.lbHour.TabIndex = 5;
            this.lbHour.Text = "Giờ";
            // 
            // lbNgay
            // 
            this.lbNgay.AutoSize = true;
            this.lbNgay.Font = new System.Drawing.Font("Segoe UI", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgay.Location = new System.Drawing.Point(1358, 45);
            this.lbNgay.Name = "lbNgay";
            this.lbNgay.Size = new System.Drawing.Size(56, 19);
            this.lbNgay.TabIndex = 4;
            this.lbNgay.Text = "Ngày : ";
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Font = new System.Drawing.Font("Segoe UI", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.Location = new System.Drawing.Point(1365, 22);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(0, 19);
            this.lbUser.TabIndex = 3;
            // 
            // lbHocKy
            // 
            this.lbHocKy.AutoSize = true;
            this.lbHocKy.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHocKy.ForeColor = System.Drawing.Color.DarkRed;
            this.lbHocKy.Location = new System.Drawing.Point(22, 45);
            this.lbHocKy.Name = "lbHocKy";
            this.lbHocKy.Size = new System.Drawing.Size(0, 23);
            this.lbHocKy.TabIndex = 1;
            // 
            // lbText
            // 
            this.lbText.AutoSize = true;
            this.lbText.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbText.ForeColor = System.Drawing.Color.Red;
            this.lbText.Location = new System.Drawing.Point(12, 18);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(677, 23);
            this.lbText.TabIndex = 0;
            this.lbText.Text = "Chào mừng bạn đến với ứng dụng Thu Học Phí phương thức bảo lưu điểm quá trình";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::ThuHocPhi.Properties.Resources.line_background_light_shape_form_50586_1920x1080;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1455, 579);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm thu học phí";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dữLiệuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sửaThôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNgườiDùngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thuHọcPhíToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thuHọcPhíTheoSBDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemHọcPhíTheoKỳToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inDanhSáchSinhViênChưaĐóngHọcPhíToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchSinhViênĐãĐóngHọcPhíToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giớiThiệuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chọnHọcKỳToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbText;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbHocKy;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.ToolStripMenuItem đăngNhậpToolStripMenuItem;
        private System.Windows.Forms.Label lbNgay;
        private System.Windows.Forms.ToolStripMenuItem thốngKêThuHọcPhíTheoNgàyToolStripMenuItem;
        private System.Windows.Forms.Label lbHour;
        private System.Windows.Forms.ToolStripMenuItem xemHọcPhíToolStripMenuItem;

    }
}
