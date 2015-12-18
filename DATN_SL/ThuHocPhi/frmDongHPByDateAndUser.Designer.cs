namespace ThuHocPhi
{
    partial class frmDongHPByDateAndUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDongHPByDateAndUser));
            this.reportManager1 = new PerpetuumSoft.Reporting.Components.ReportManager(this.components);
            this.inlineReportSlot1 = new PerpetuumSoft.Reporting.Components.InlineReportSlot(this.components);
            this.reportViewer1 = new PerpetuumSoft.Reporting.View.ReportViewer();
            this.dsDongHPByDateAndUser1 = new ThuHocPhi.DSDongHPByDateAndUser();
            this.dongHPByDateAndUserTableAdapter1 = new ThuHocPhi.DSDongHPByDateAndUserTableAdapters.DongHPByDateAndUserTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsDongHPByDateAndUser1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // reportManager1
            // 
            this.reportManager1.DataSources = new PerpetuumSoft.Reporting.Components.ObjectPointerCollection(new string[] {
            "DongHPByDateAndUser"}, new object[] {
            ((object)(this.dsDongHPByDateAndUser1))});
            this.reportManager1.OwnerForm = this;
            this.reportManager1.Reports.AddRange(new PerpetuumSoft.Reporting.Components.ReportSlot[] {
            this.inlineReportSlot1});
            // 
            // inlineReportSlot1
            // 
            this.inlineReportSlot1.DocumentStream = resources.GetString("inlineReportSlot1.DocumentStream");
            this.inlineReportSlot1.ReportName = "DongHPByUserDate";
            this.inlineReportSlot1.ReportScriptType = typeof(PerpetuumSoft.Reporting.Rendering.ReportScriptBase);
            // 
            // reportViewer1
            // 
            this.reportViewer1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.PageIndex = 0;
            this.reportViewer1.Size = new System.Drawing.Size(989, 604);
            this.reportViewer1.Source = this.inlineReportSlot1;
            this.reportViewer1.SplashForm = null;
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.ViewMode = PerpetuumSoft.Reporting.View.ViewMode.ContinuedPage;
            // 
            // dsDongHPByDateAndUser1
            // 
            this.dsDongHPByDateAndUser1.DataSetName = "DSDongHPByDateAndUser";
            this.dsDongHPByDateAndUser1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dongHPByDateAndUserTableAdapter1
            // 
            this.dongHPByDateAndUserTableAdapter1.ClearBeforeFill = true;
            // 
            // frmDongHPByDateAndUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(989, 604);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDongHPByDateAndUser";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách sinh viên đóng học phí theo người lập ngày hiện tại";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDongHPByDateAndUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsDongHPByDateAndUser1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PerpetuumSoft.Reporting.Components.ReportManager reportManager1;
        private DSDongHPByDateAndUser dsDongHPByDateAndUser1;
        private DSDongHPByDateAndUserTableAdapters.DongHPByDateAndUserTableAdapter dongHPByDateAndUserTableAdapter1;
        private PerpetuumSoft.Reporting.Components.InlineReportSlot inlineReportSlot1;
        private PerpetuumSoft.Reporting.View.ReportViewer reportViewer1;
    }
}
