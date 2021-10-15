using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLBANHANGT3
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-559F9J1F\SQLEXPRESS;Initial Catalog=QLBH;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand cmd = conn.CreateCommand();

            try
            {
                conn.Open();
                cmd.CommandText = "select * from Login where Username = '" + txt_taikhoan.Text + "'and Password = '" + txt_matkhau.Text + "'";
                SqlDataReader data = cmd.ExecuteReader();
                if (data.Read() == true)
                {
                    MessageBox.Show("Đăng nhậpthành công");
                    frmMain main = new frmMain();
                    main.Show();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại");
                    txt_taikhoan.Clear();
                    txt_matkhau.Clear();
                    txt_taikhoan.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("kết nối thất bại!");
            }
        }

        private void txt_matkhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btn_dangnhap.PerformClick();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn muốn thoát?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (kq == DialogResult.Yes)
                this.Close();
        }
    }
}
