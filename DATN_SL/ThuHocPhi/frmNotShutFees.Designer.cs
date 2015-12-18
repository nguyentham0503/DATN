namespace ThuHocPhi
{
    partial class frmNotShutFees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNotShutFees));
            this.reportViewer1 = new PerpetuumSoft.Reporting.View.ReportViewer();
            this.inlineReportSlot1 = new PerpetuumSoft.Reporting.Components.InlineReportSlot(this.components);
            this.reportManager1 = new PerpetuumSoft.Reporting.Components.ReportManager(this.components);
            this.dsChuaDongHP1 = new ThuHocPhi.DSChuaDongHP();
            this.chuaDongHPTableAdapter1 = new ThuHocPhi.DSChuaDongHPTableAdapters.ChuaDongHPTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsChuaDongHP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.PageIndex = 0;
            this.reportViewer1.Size = new System.Drawing.Size(768, 523);
            this.reportViewer1.Source = this.inlineReportSlot1;
            this.reportViewer1.SplashForm = null;
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.ViewMode = PerpetuumSoft.Reporting.View.ViewMode.ContinuedPage;
            // 
            // inlineReportSlot1
            // 
            this.inlineReportSlot1.DocumentStream = resources.GetString("inlineReportSlot1.DocumentStream");
            this.inlineReportSlot1.ReportName = "ChuaDongHP";
            this.inlineReportSlot1.ReportScriptType = typeof(PerpetuumSoft.Reporting.Rendering.ReportScriptBase);
            // 
            // reportManager1
            // 
            this.reportManager1.DataSources = new PerpetuumSoft.Reporting.Components.ObjectPointerCollection(new string[] {
            "ChuaDongHP"}, new object[] {
            ((object)(this.dsChuaDongHP1))});
            this.reportManager1.OwnerForm = this;
            this.reportManager1.Reports.AddRange(new PerpetuumSoft.Reporting.Components.ReportSlot[] {
            this.inlineReportSlot1});
            // 
            // dsChuaDongHP1
            // 
            this.dsChuaDongHP1.DataSetName = "DSChuaDongHP";
            this.dsChuaDongHP1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chuaDongHPTableAdapter1
            // 
            this.chuaDongHPTableAdapter1.ClearBeforeFill = true;
            // 
            // frmNotShutFees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(768, 523);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNotShutFees";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách sinh viên chưa đóng học phí";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsChuaDongHP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PerpetuumSoft.Reporting.View.ReportViewer reportViewer1;
        private PerpetuumSoft.Reporting.Components.ReportManager reportManager1;
        private PerpetuumSoft.Reporting.Components.InlineReportSlot inlineReportSlot1;
        private DSChuaDongHP dsChuaDongHP1;
        private DSChuaDongHPTableAdapters.ChuaDongHPTableAdapter chuaDongHPTableAdapter1;
    }
}
