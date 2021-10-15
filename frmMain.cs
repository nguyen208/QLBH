using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBANHANGT3
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmnhanvien nv = new frmnhanvien();
            nv.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmhanghoa hh = new frmhanghoa();
            hh.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmkhachhang kh = new frmkhachhang();
            kh.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frmhoadon hd = new frmhoadon();
            hd.Show();
        }
    }
}
