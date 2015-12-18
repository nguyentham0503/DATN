namespace DA_ThuHP
{
    partial class frm_importData
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
            this.dgv_dataExcel = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_importExcel = new System.Windows.Forms.Button();
            this.btn_browser = new System.Windows.Forms.Button();
            this.txt_pathfile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dataExcel)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_dataExcel
            // 
            this.dgv_dataExcel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_dataExcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dataExcel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_dataExcel.Location = new System.Drawing.Point(0, 175);
            this.dgv_dataExcel.Name = "dgv_dataExcel";
            this.dgv_dataExcel.RowTemplate.Height = 24;
            this.dgv_dataExcel.Size = new System.Drawing.Size(1020, 506);
            this.dgv_dataExcel.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_importExcel);
            this.groupBox1.Controls.Add(this.btn_browser);
            this.groupBox1.Controls.Add(this.txt_pathfile);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1020, 152);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // btn_importExcel
            // 
            this.btn_importExcel.AllowDrop = true;
            this.btn_importExcel.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_importExcel.Location = new System.Drawing.Point(388, 88);
            this.btn_importExcel.Name = "btn_importExcel";
            this.btn_importExcel.Size = new System.Drawing.Size(146, 42);
            this.btn_importExcel.TabIndex = 6;
            this.btn_importExcel.Text = "Import Excel";
            this.btn_importExcel.UseVisualStyleBackColor = true;
            this.btn_importExcel.Click += new System.EventHandler(this.btn_importExcel_Click);
            // 
            // btn_browser
            // 
            this.btn_browser.AllowDrop = true;
            this.btn_browser.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_browser.Location = new System.Drawing.Point(718, 37);
            this.btn_browser.Name = "btn_browser";
            this.btn_browser.Size = new System.Drawing.Size(127, 39);
            this.btn_browser.TabIndex = 5;
            this.btn_browser.Text = "Browser";
            this.btn_browser.UseVisualStyleBackColor = true;
            this.btn_browser.Click += new System.EventHandler(this.btn_browser_Click);
            // 
            // txt_pathfile
            // 
            this.txt_pathfile.AllowDrop = true;
            this.txt_pathfile.Location = new System.Drawing.Point(242, 45);
            this.txt_pathfile.Name = "txt_pathfile";
            this.txt_pathfile.Size = new System.Drawing.Size(438, 22);
            this.txt_pathfile.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(430, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chọn file";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(138, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Chọn file";
            // 
            // frm_importData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 681);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_dataExcel);
            this.Name = "frm_importData";
            this.Text = "frm_importData";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dataExcel)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_dataExcel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_importExcel;
        private System.Windows.Forms.Button btn_browser;
        private System.Windows.Forms.TextBox txt_pathfile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}