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
    public partial class frmhoadon : Form
    {
        public frmhoadon()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=WINDOWS-10\SQLEXPRESS;Initial Catalog=QLBANHANGT3;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter data = new SqlDataAdapter();
        DataTable dt = new DataTable();
        DataTable dt1 = new DataTable();
        public void loaddulieu()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "select tb_hoadon.mahd,makh,manv,ngaylap,mahang,dongiaban,soluongmua,thanhtien from tb_hoadon,tb_cthd where tb_hoadon.mahd=tb_cthd.mahd";
            data.SelectCommand = cmd;
            dt.Clear();
            data.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void frmhoadon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBANHANGT3DataSet.tb_hanghoa' table. You can move, or remove it, as needed.
            this.tb_hanghoaTableAdapter.Fill(this.qLBANHANGT3DataSet.tb_hanghoa);
            conn.Open();
            loaddulieu();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_mahd2.ReadOnly = true;
            int i = dataGridView1.CurrentRow.Index;
            txt_mahd1.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txt_mahd2.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txt_makh.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txt_manv.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            dtp_ngaylap.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            cbx_mahang.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            txt_dongia.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            txt_soluong.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
            txt_thanhtien.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "insert into tb_hoadon values('"+txt_mahd1.Text+"','"+txt_makh.Text+"','"+txt_manv.Text+"','"+dtp_ngaylap.Text+"')insert into tb_cthd values('"+txt_mahd2.Text+"','"+cbx_mahang.Text+"','"+txt_dongia.Text+"','"+txt_soluong.Text+"','"+txt_thanhtien.Text+"')";
            cmd.ExecuteNonQuery();
            loaddulieu();
        }
        
        private void btn_load_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "delete from tb_hoadon where mahd='"+txt_mahd1.Text+"'";
            cmd.ExecuteNonQuery();
            loaddulieu();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn muốn thoát?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (kq == DialogResult.Yes)
                this.Close();
        }

        private void txt_soluong_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                
                txt_mahd2.Text = txt_mahd1.Text;

                int dg, sl, tt;
                dg = Convert.ToInt32(txt_dongia.Text);
                sl = Convert.ToInt32(txt_soluong.Text);
                tt = dg * sl;
                txt_thanhtien.Text = tt.ToString();
            }
        }

        private void cbx_mahang_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "select dongiamua from tb_hanghoa where mahang='" + cbx_mahang.Text + "'";
            data.SelectCommand = cmd;
            dt1.Clear();
            data.Fill(dt1);
            foreach (DataRow row in dt1.Rows)
            {
                string str = row[0].ToString();
                float dg1, dg2;
                dg1 = Convert.ToSingle(str);
                dg2 = dg1 + (dg1 * 10 / 100);
                txt_dongia.Text = dg2.ToString();
            }
        }
    }
}
