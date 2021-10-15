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
    public partial class frmbaocaohoadon : Form
    {
        public frmbaocaohoadon()
        {
            InitializeComponent();
        }

        private void frmbaocaohoadon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBANHANGT3DataSet1.tb_khachhang' table. You can move, or remove it, as needed.
            this.tb_khachhangTableAdapter.Fill(this.qLBANHANGT3DataSet1.tb_khachhang);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=WINDOWS-10\SQLEXPRESS;Initial Catalog=QLBANHANGT3;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd = conn.CreateCommand();
            cmd.CommandText = "select * from View_report where Tenkh=N'"+cbx_makh.Text+"'";
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            data.Fill(dt);
            CrystalReport_baocaohd rpt = new CrystalReport_baocaohd();
            rpt.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rpt;
        }
    }
}
