namespace QLBANHANGT3
{
    partial class frmhoadon
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtp_ngaylap = new System.Windows.Forms.DateTimePicker();
            this.txt_makh = new System.Windows.Forms.TextBox();
            this.txt_manv = new System.Windows.Forms.TextBox();
            this.txt_mahd1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbx_mahang = new System.Windows.Forms.ComboBox();
            this.tbhanghoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLBANHANGT3DataSet = new QLBANHANGT3.QLBANHANGT3DataSet();
            this.btn_load = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.txt_thanhtien = new System.Windows.Forms.TextBox();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.txt_dongia = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_mahd2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tb_hanghoaTableAdapter = new QLBANHANGT3.QLBANHANGT3DataSetTableAdapters.tb_hanghoaTableAdapter();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbhanghoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBANHANGT3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(606, 64);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(132, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ HOÁ ĐƠN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtp_ngaylap);
            this.groupBox1.Controls.Add(this.txt_makh);
            this.groupBox1.Controls.Add(this.txt_manv);
            this.groupBox1.Controls.Add(this.txt_mahd1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(2, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(606, 83);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hoá đơn";
            // 
            // dtp_ngaylap
            // 
            this.dtp_ngaylap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ngaylap.Location = new System.Drawing.Point(357, 50);
            this.dtp_ngaylap.Name = "dtp_ngaylap";
            this.dtp_ngaylap.Size = new System.Drawing.Size(200, 20);
            this.dtp_ngaylap.TabIndex = 3;
            // 
            // txt_makh
            // 
            this.txt_makh.Location = new System.Drawing.Point(104, 50);
            this.txt_makh.Name = "txt_makh";
            this.txt_makh.Size = new System.Drawing.Size(177, 20);
            this.txt_makh.TabIndex = 1;
            // 
            // txt_manv
            // 
            this.txt_manv.Location = new System.Drawing.Point(357, 19);
            this.txt_manv.Name = "txt_manv";
            this.txt_manv.Size = new System.Drawing.Size(200, 20);
            this.txt_manv.TabIndex = 2;
            // 
            // txt_mahd1
            // 
            this.txt_mahd1.Location = new System.Drawing.Point(104, 19);
            this.txt_mahd1.Name = "txt_mahd1";
            this.txt_mahd1.Size = new System.Drawing.Size(177, 20);
            this.txt_mahd1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(302, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ngày lập";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(302, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã NV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã KH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Hoá Đơn";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbx_mahang);
            this.groupBox2.Controls.Add(this.btn_load);
            this.groupBox2.Controls.Add(this.btn_thoat);
            this.groupBox2.Controls.Add(this.btn_xoa);
            this.groupBox2.Controls.Add(this.btn_them);
            this.groupBox2.Controls.Add(this.txt_thanhtien);
            this.groupBox2.Controls.Add(this.txt_soluong);
            this.groupBox2.Controls.Add(this.txt_dongia);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txt_mahd2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(2, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(606, 145);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chi tiết hoa đơn";
            // 
            // cbx_mahang
            // 
            this.cbx_mahang.DataSource = this.tbhanghoaBindingSource;
            this.cbx_mahang.DisplayMember = "Mahang";
            this.cbx_mahang.FormattingEnabled = true;
            this.cbx_mahang.Location = new System.Drawing.Point(114, 51);
            this.cbx_mahang.Name = "cbx_mahang";
            this.cbx_mahang.Size = new System.Drawing.Size(177, 21);
            this.cbx_mahang.TabIndex = 10;
            this.cbx_mahang.SelectedIndexChanged += new System.EventHandler(this.cbx_mahang_SelectedIndexChanged);
            // 
            // tbhanghoaBindingSource
            // 
            this.tbhanghoaBindingSource.DataMember = "tb_hanghoa";
            this.tbhanghoaBindingSource.DataSource = this.qLBANHANGT3DataSet;
            // 
            // qLBANHANGT3DataSet
            // 
            this.qLBANHANGT3DataSet.DataSetName = "QLBANHANGT3DataSet";
            this.qLBANHANGT3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(332, 116);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(75, 23);
            this.btn_load.TabIndex = 9;
            this.btn_load.Text = "Load";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(440, 116);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_thoat.TabIndex = 9;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(216, 116);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa.TabIndex = 9;
            this.btn_xoa.Text = "Xoá HĐ";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(114, 116);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 23);
            this.btn_them.TabIndex = 9;
            this.btn_them.Text = "Thêm HĐ";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // txt_thanhtien
            // 
            this.txt_thanhtien.Location = new System.Drawing.Point(114, 84);
            this.txt_thanhtien.Name = "txt_thanhtien";
            this.txt_thanhtien.Size = new System.Drawing.Size(453, 20);
            this.txt_thanhtien.TabIndex = 8;
            // 
            // txt_soluong
            // 
            this.txt_soluong.Location = new System.Drawing.Point(367, 56);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(200, 20);
            this.txt_soluong.TabIndex = 7;
            this.txt_soluong.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_soluong_KeyDown);
            // 
            // txt_dongia
            // 
            this.txt_dongia.Location = new System.Drawing.Point(367, 25);
            this.txt_dongia.Name = "txt_dongia";
            this.txt_dongia.Size = new System.Drawing.Size(200, 20);
            this.txt_dongia.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(41, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Thành tiền";
            // 
            // txt_mahd2
            // 
            this.txt_mahd2.Location = new System.Drawing.Point(114, 25);
            this.txt_mahd2.Name = "txt_mahd2";
            this.txt_mahd2.Size = new System.Drawing.Size(177, 20);
            this.txt_mahd2.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(312, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Số lượng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(312, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Đơn giá";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Mã hàng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Mã Hoá Đơn";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 311);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(606, 150);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tb_hanghoaTableAdapter
            // 
            this.tb_hanghoaTableAdapter.ClearBeforeFill = true;
            // 
            // frmhoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 466);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "frmhoadon";
            this.Text = "frmhoadon";
            this.Load += new System.EventHandler(this.frmhoadon_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbhanghoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBANHANGT3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtp_ngaylap;
        private System.Windows.Forms.TextBox txt_makh;
        private System.Windows.Forms.TextBox txt_manv;
        private System.Windows.Forms.TextBox txt_mahd1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.TextBox txt_thanhtien;
        private System.Windows.Forms.TextBox txt_soluong;
        private System.Windows.Forms.TextBox txt_dongia;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_mahd2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbx_mahang;
        private QLBANHANGT3DataSet qLBANHANGT3DataSet;
        private System.Windows.Forms.BindingSource tbhanghoaBindingSource;
        private QLBANHANGT3DataSetTableAdapters.tb_hanghoaTableAdapter tb_hanghoaTableAdapter;
    }
}