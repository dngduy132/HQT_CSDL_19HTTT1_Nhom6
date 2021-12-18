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

        private void XemThongTinSanPham_Click(object sender, EventArgs e)
        {
            //KhachHang.KH_ThongTinSanPham frm = new KhachHang.KH_ThongTinSanPham();
            //frm.MdiParent = this;
            //frm.Name = "KH_ThongTinSanPham";
            //frm.Show();
            KhachHang.KH_ThongTinSanPham frm = new KhachHang.KH_ThongTinSanPham();
            frm.ShowDialog();
        }

        private void XemThongTinDoanhNghiep_Click(object sender, EventArgs e)
        {
            //KhachHang.KH_ThongTinDoanhNghiep frm = new KhachHang.KH_ThongTinDoanhNghiep();
            //frm.MdiParent = this;
            //frm.Name = "KH_ThongTinDoanhNghiep";
            //frm.Show();
            KhachHang.KH_ThongTinDoanhNghiep frm = new KhachHang.KH_ThongTinDoanhNghiep();
            frm.ShowDialog();
        }

        private void TimKiemDoanhNghiep_Click(object sender, EventArgs e)
        {
            //KhachHang.KH_TimKiemDoanhNghiep frm = new KhachHang.KH_TimKiemDoanhNghiep();
            //frm.MdiParent = this;
            //frm.Name = "KH_TimKiemDoanhNghiep";
            //frm.Show();
            KhachHang.KH_TimKiemDoanhNghiep frm = new KhachHang.KH_TimKiemDoanhNghiep();
            frm.ShowDialog();
        }

        private void TimKiemSanPham_Click(object sender, EventArgs e)
        {
            //KhachHang.KH_TimKiemSanPham frm = new KhachHang.KH_TimKiemSanPham();
            //frm.MdiParent = this;
            //frm.Name = "KH_TimKiemSanPham";
            //frm.Show();
            KhachHang.KH_TimKiemSanPham frm = new KhachHang.KH_TimKiemSanPham();
            frm.ShowDialog();
        }

        private void ThongKeSanPham_Click(object sender, EventArgs e)
        {
            //KhachHang.KH_ThongKeSanPham frm = new KhachHang.KH_ThongKeSanPham();
            //frm.MdiParent = this;
            //frm.Name = "KH_ThongKeSanPham";
            //frm.Show();
            KhachHang.KH_ThongKeSanPham frm = new KhachHang.KH_ThongKeSanPham();
            frm.ShowDialog();
        }

        private void MuaHang_Click(object sender, EventArgs e)
        {
            //KhachHang.KH_MuaHang frm = new KhachHang.KH_MuaHang();
            //frm.MdiParent = this;
            //frm.Name = "KH_MuaHang";
            //frm.Show();
            KhachHang.KH_MuaHang frm = new KhachHang.KH_MuaHang();
            frm.ShowDialog();
        }

        private void XemDanhSachDonDatHang_Click(object sender, EventArgs e)
        {
            //DoanhNghiep.DN_XemDanhSachDonDatHang frm = new DoanhNghiep.DN_XemDanhSachDonDatHang();
            //frm.MdiParent = this;
            //frm.Name = "DN_XemDanhSachDonDatHang";
            //frm.Show();
            DoanhNghiep.DN_XemDanhSachDonDatHang frm = new DoanhNghiep.DN_XemDanhSachDonDatHang();
            frm.ShowDialog();
        }

        private void CapNhatThongTinSanPham_Click(object sender, EventArgs e)
        {
            //DoanhNghiep.DN_CapNhatThongTinSanPham frm = new DoanhNghiep.DN_CapNhatThongTinSanPham();
            //frm.MdiParent = this;
            //frm.Name = "DN_CapNhatThongTinSanPham";
            //frm.Show();
            DoanhNghiep.DN_CapNhatThongTinSanPham frm = new DoanhNghiep.DN_CapNhatThongTinSanPham();
            frm.ShowDialog();
        }

        private void ThemMoiSanPham_Click(object sender, EventArgs e)
        {
            //DoanhNghiep.DN_ThemMoiSanPham frm = new DoanhNghiep.DN_ThemMoiSanPham();
            //frm.MdiParent = this;
            //frm.Name = "DN_ThemMoiSanPham";
            //frm.Show();
            DoanhNghiep.DN_ThemMoiSanPham frm = new DoanhNghiep.DN_ThemMoiSanPham();
            frm.ShowDialog();
        }

        private void NhanGiaoHang_Click(object sender, EventArgs e)
        {
            //TaiXe.TX_NhanGiaoHang frm = new TaiXe.TX_NhanGiaoHang();
            //frm.MdiParent = this;
            //frm.Name = "TX_NhanGiaoHang";
            //frm.Show();
            TaiXe.TX_NhanGiaoHang frm = new TaiXe.TX_NhanGiaoHang();
            frm.ShowDialog();
        }

        private void QT_XemThongTinDoanhNghiep_Click(object sender, EventArgs e)
        {
            //QuanTri.QT_XemThongTinDoanhNghiep frm = new QuanTri.QT_XemThongTinDoanhNghiep();
            //frm.MdiParent = this;
            //frm.Name = "QT_XemThongTinDoanhNghiep";
            //frm.Show();
            QuanTri.QT_XemThongTinDoanhNghiep frm = new QuanTri.QT_XemThongTinDoanhNghiep();
            frm.ShowDialog();
        }

        private void CapNhatThongTinDoanhNghiep_Click(object sender, EventArgs e)
        {
            //QuanTri.QT_CapNhatThongTinDoanhNghiep frm = new QuanTri.QT_CapNhatThongTinDoanhNghiep();
            //frm.MdiParent = this;
            //frm.Name = "QT_CapNhatThongTinDoanhNghiep";
            //frm.Show();
            QuanTri.QT_CapNhatThongTinDoanhNghiep frm = new QuanTri.QT_CapNhatThongTinDoanhNghiep();
            frm.ShowDialog();
        }

        private void ChinhSuaThongTinDoanhNghiep_Click(object sender, EventArgs e)
        {
            //NhanVien.NV_CapNhatThongTinDoanhNghiep frm = new NhanVien.NV_CapNhatThongTinDoanhNghiep();
            //frm.MdiParent = this;
            //frm.Name = "NV_CapNhatThongTinDoanhNghiep";
            //frm.Show();
            NhanVien.NV_CapNhatThongTinDoanhNghiep frm = new NhanVien.NV_CapNhatThongTinDoanhNghiep();
            frm.ShowDialog();
        }

        private void ChinhSuaThongTinHoaDon_Click(object sender, EventArgs e)
        {
            //NhanVien.NV_CapNhatThongTinHopDong frm = new NhanVien.NV_CapNhatThongTinHopDong();
            //frm.MdiParent = this;
            //frm.Name = "NV_CapNhatThongTinHopDong";
            //frm.Show();
            NhanVien.NV_CapNhatThongTinHopDong frm = new NhanVien.NV_CapNhatThongTinHopDong();
            frm.ShowDialog();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            function.Connect();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
