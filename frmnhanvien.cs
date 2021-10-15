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
    public partial class frmnhanvien : Form
    {
        public frmnhanvien()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-559F9J1F\SQLEXPRESS;Initial Catalog=QLBH;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter data = new SqlDataAdapter();
        DataTable dt = new DataTable();
        public void loaddulieu()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "select * from NhanVien";
            data.SelectCommand = cmd;
            dt.Clear();
            data.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void frmnhanvien_Load(object sender, EventArgs e)
        {
            conn.Open();
            loaddulieu();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "insert into NhanVien values('"+txt_manv.Text+"',N'"+txt_tennv.Text+"',N'"+cbx_gioitinh.Text+"','"+txt_sodt.Text+"',N'"+txt_diachi.Text+"')";
            cmd.ExecuteNonQuery();
            loaddulieu();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            txt_manv.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txt_tennv.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            cbx_gioitinh.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txt_sodt.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            txt_diachi.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "update NhanVien set MaNV='" + txt_manv.Text + "',TenNV=N'" + txt_tennv.Text + "',GioiTinh=N'" + cbx_gioitinh.Text + "',SoDT='" + txt_sodt.Text + "',diachi=N'" + txt_diachi.Text + "'where MaNV='"+txt_manv.Text+"'";
            cmd.ExecuteNonQuery();
            loaddulieu();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "delete from NhanVien where MaNV='"+txt_manv.Text+"'";
            cmd.ExecuteNonQuery();
            loaddulieu();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_manv.Text = "";
            txt_tennv.Text = "";
            cbx_gioitinh.Text = "";
            txt_sodt.Text = "";
            txt_diachi.Text = "";
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn muốn thoát?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
                this.Close();
        }

    }
}
