namespace QLBANHANGT3
{
    partial class frmDangNhap
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
			this.txt_matkhau = new System.Windows.Forms.TextBox();
			this.txt_taikhoan = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btn_thoat = new System.Windows.Forms.Button();
			this.btn_dangnhap = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txt_matkhau
			// 
			this.txt_matkhau.Location = new System.Drawing.Point(161, 180);
			this.txt_matkhau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txt_matkhau.Name = "txt_matkhau";
			this.txt_matkhau.PasswordChar = '*';
			this.txt_matkhau.Size = new System.Drawing.Size(265, 22);
			this.txt_matkhau.TabIndex = 9;
			this.txt_matkhau.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_matkhau_KeyDown);
			// 
			// txt_taikhoan
			// 
			this.txt_taikhoan.Location = new System.Drawing.Point(161, 126);
			this.txt_taikhoan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txt_taikhoan.Name = "txt_taikhoan";
			this.txt_taikhoan.Size = new System.Drawing.Size(265, 22);
			this.txt_taikhoan.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(53, 188);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(79, 17);
			this.label3.TabIndex = 6;
			this.label3.Text = "MẬT KHẨU";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(53, 134);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(82, 17);
			this.label2.TabIndex = 7;
			this.label2.Text = "TÀI KHOẢN";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(107, 71);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(244, 29);
			this.label1.TabIndex = 8;
			this.label1.Text = "FORM ĐĂNG NHẬP";
			// 
			// btn_thoat
			// 
			this.btn_thoat.Location = new System.Drawing.Point(283, 246);
			this.btn_thoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btn_thoat.Name = "btn_thoat";
			this.btn_thoat.Size = new System.Drawing.Size(100, 28);
			this.btn_thoat.TabIndex = 11;
			this.btn_thoat.Text = "THOÁT";
			this.btn_thoat.UseVisualStyleBackColor = true;
			this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
			// 
			// btn_dangnhap
			// 
			this.btn_dangnhap.Location = new System.Drawing.Point(127, 246);
			this.btn_dangnhap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btn_dangnhap.Name = "btn_dangnhap";
			this.btn_dangnhap.Size = new System.Drawing.Size(107, 28);
			this.btn_dangnhap.TabIndex = 10;
			this.btn_dangnhap.Text = "ĐĂNG NHẬP";
			this.btn_dangnhap.UseVisualStyleBackColor = true;
			this.btn_dangnhap.Click += new System.EventHandler(this.btn_dangnhap_Click);
			// 
			// frmDangNhap
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(481, 346);
			this.Controls.Add(this.txt_matkhau);
			this.Controls.Add(this.txt_taikhoan);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btn_thoat);
			this.Controls.Add(this.btn_dangnhap);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "frmDangNhap";
			this.Text = "frmDangNhap";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_matkhau;
        private System.Windows.Forms.TextBox txt_taikhoan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_dangnhap;
    }
}