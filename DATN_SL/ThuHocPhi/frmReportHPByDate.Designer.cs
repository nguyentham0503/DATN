namespace ThuHocPhi
{
    partial class frmReportHPByDate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportHPByDate));
            this.reportManager1 = new PerpetuumSoft.Reporting.Components.ReportManager(this.components);
            this.dsHocPhiTheoNgay1 = new ThuHocPhi.DSHocPhiTheoNgay();
            this.inlineReportSlot1 = new PerpetuumSoft.Reporting.Components.InlineReportSlot(this.components);
            this.reportViewer1 = new PerpetuumSoft.Reporting.View.ReportViewer();
            this.hocPhiTheoDateTableAdapter1 = new ThuHocPhi.DSHocPhiTheoNgayTableAdapters.HocPhiTheoDateTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsHocPhiTheoNgay1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // reportManager1
            // 
            this.reportManager1.DataSources = new PerpetuumSoft.Reporting.Components.ObjectPointerCollection(new string[] {
            "HocPhiTheoNgay"}, new object[] {
            ((object)(this.dsHocPhiTheoNgay1))});
            this.reportManager1.OwnerForm = this;
            this.reportManager1.Reports.AddRange(new PerpetuumSoft.Reporting.Components.ReportSlot[] {
            this.inlineReportSlot1});
            // 
            // dsHocPhiTheoNgay1
            // 
            this.dsHocPhiTheoNgay1.DataSetName = "DSHocPhiTheoNgay";
            this.dsHocPhiTheoNgay1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inlineReportSlot1
            // 
            this.inlineReportSlot1.DocumentStream = resources.GetString("inlineReportSlot1.DocumentStream");
            this.inlineReportSlot1.ReportName = "";
            this.inlineReportSlot1.ReportScriptType = typeof(PerpetuumSoft.Reporting.Rendering.ReportScriptBase);
            // 
            // reportViewer1
            // 
            this.reportViewer1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.PageIndex = 0;
            this.reportViewer1.Size = new System.Drawing.Size(880, 522);
            this.reportViewer1.Source = this.inlineReportSlot1;
            this.reportViewer1.SplashForm = null;
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.ViewMode = PerpetuumSoft.Reporting.View.ViewMode.ContinuedPage;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // hocPhiTheoDateTableAdapter1
            // 
            this.hocPhiTheoDateTableAdapter1.ClearBeforeFill = true;
            // 
            // frmReportHPByDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(880, 522);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmReportHPByDate";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReportHPByDate";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dsHocPhiTheoNgay1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PerpetuumSoft.Reporting.Components.ReportManager reportManager1;
        private PerpetuumSoft.Reporting.View.ReportViewer reportViewer1;
        private DSHocPhiTheoNgay dsHocPhiTheoNgay1;
        private DSHocPhiTheoNgayTableAdapters.HocPhiTheoDateTableAdapter hocPhiTheoDateTableAdapter1;
        private PerpetuumSoft.Reporting.Components.InlineReportSlot inlineReportSlot1;
    }
}
