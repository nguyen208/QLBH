namespace QLBANHANGT3
{
    partial class frmbaocaohoadon
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CrystalReport_baocaohd1 = new QLBANHANGT3.CrystalReport_baocaohd();
            this.button1 = new System.Windows.Forms.Button();
            this.cbx_makh = new System.Windows.Forms.ComboBox();
            this.qLBANHANGT3DataSet1 = new QLBANHANGT3.QLBANHANGT3DataSet1();
            this.tbkhachhangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_khachhangTableAdapter = new QLBANHANGT3.QLBANHANGT3DataSet1TableAdapters.tb_khachhangTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.qLBANHANGT3DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbkhachhangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 53);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.CrystalReport_baocaohd1;
            this.crystalReportViewer1.Size = new System.Drawing.Size(824, 370);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(159, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Thực hiện";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbx_makh
            // 
            this.cbx_makh.DataSource = this.tbkhachhangBindingSource;
            this.cbx_makh.DisplayMember = "Tenkh";
            this.cbx_makh.FormattingEnabled = true;
            this.cbx_makh.Location = new System.Drawing.Point(21, 12);
            this.cbx_makh.Name = "cbx_makh";
            this.cbx_makh.Size = new System.Drawing.Size(121, 21);
            this.cbx_makh.TabIndex = 2;
            // 
            // qLBANHANGT3DataSet1
            // 
            this.qLBANHANGT3DataSet1.DataSetName = "QLBANHANGT3DataSet1";
            this.qLBANHANGT3DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbkhachhangBindingSource
            // 
            this.tbkhachhangBindingSource.DataMember = "tb_khachhang";
            this.tbkhachhangBindingSource.DataSource = this.qLBANHANGT3DataSet1;
            // 
            // tb_khachhangTableAdapter
            // 
            this.tb_khachhangTableAdapter.ClearBeforeFill = true;
            // 
            // frmbaocaohoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 423);
            this.Controls.Add(this.cbx_makh);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "frmbaocaohoadon";
            this.Text = "frmbaocaohoadon";
            this.Load += new System.EventHandler(this.frmbaocaohoadon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLBANHANGT3DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbkhachhangBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private CrystalReport_baocaohd CrystalReport_baocaohd1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbx_makh;
        private QLBANHANGT3DataSet1 qLBANHANGT3DataSet1;
        private System.Windows.Forms.BindingSource tbkhachhangBindingSource;
        private QLBANHANGT3DataSet1TableAdapters.tb_khachhangTableAdapter tb_khachhangTableAdapter;
    }
}