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
    public partial class frmbaocaonv : Form
    {
        public frmbaocaonv()
        {
            InitializeComponent();
        }

        private void frmbaocaonv_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_thuchien_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=WINDOWS-10\SQLEXPRESS;Initial Catalog=QLBANHANGT3;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd = conn.CreateCommand();
            cmd.CommandText = "select * from tb_nhanvien where Gioitinh=N'"+cbx_gioitinh.Text+"'";
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            data.Fill(dt);
            CrystalReport_QLNV rpt = new CrystalReport_QLNV();
            rpt.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rpt;
        }
    }
}
