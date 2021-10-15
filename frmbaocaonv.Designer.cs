namespace QLBANHANGT3
{
    partial class frmbaocaonv
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CrystalReport_QLNV1 = new QLBANHANGT3.CrystalReport_QLNV();
            this.cbx_gioitinh = new System.Windows.Forms.ComboBox();
            this.btn_thuchien = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 46);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.CrystalReport_QLNV1;
            this.crystalReportViewer1.Size = new System.Drawing.Size(716, 374);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // cbx_gioitinh
            // 
            this.cbx_gioitinh.FormattingEnabled = true;
            this.cbx_gioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbx_gioitinh.Location = new System.Drawing.Point(12, 19);
            this.cbx_gioitinh.Name = "cbx_gioitinh";
            this.cbx_gioitinh.Size = new System.Drawing.Size(121, 21);
            this.cbx_gioitinh.TabIndex = 1;
            // 
            // btn_thuchien
            // 
            this.btn_thuchien.Location = new System.Drawing.Point(150, 19);
            this.btn_thuchien.Name = "btn_thuchien";
            this.btn_thuchien.Size = new System.Drawing.Size(75, 23);
            this.btn_thuchien.TabIndex = 2;
            this.btn_thuchien.Text = "Thực hiện";
            this.btn_thuchien.UseVisualStyleBackColor = true;
            this.btn_thuchien.Click += new System.EventHandler(this.btn_thuchien_Click);
            // 
            // frmbaocaonv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 420);
            this.Controls.Add(this.btn_thuchien);
            this.Controls.Add(this.cbx_gioitinh);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "frmbaocaonv";
            this.Text = "frmbaocaonv";
            this.Load += new System.EventHandler(this.frmbaocaonv_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private CrystalReport_QLNV CrystalReport_QLNV1;
        private System.Windows.Forms.ComboBox cbx_gioitinh;
        private System.Windows.Forms.Button btn_thuchien;
    }
}