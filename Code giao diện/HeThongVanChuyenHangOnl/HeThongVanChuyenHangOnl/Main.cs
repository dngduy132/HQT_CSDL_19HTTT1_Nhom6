using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeThongVanChuyenHangOnl
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void doanhNghiệpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void xemDanhToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void xemThôngTinDoanhNghiệpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongTinDoanhNghiep frm = new ThongTinDoanhNghiep();
            frm.MdiParent = this;
            frm.Name = "ThongTinDoanhNghiep";
            frm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void xemThôngTinSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongTinSanPham frm = new ThongTinSanPham();
            frm.MdiParent = this;
            frm.Name = "ThongTinSanPham";
            frm.Show();
        }

        private void tìmKiếmDoanhNghiệpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimKiemDoanhNghiep frm = new TimKiemDoanhNghiep();
            frm.MdiParent = this;
            frm.Name = "TimKiemDoanhNghiep";
            frm.Show();
        }
    }
}
