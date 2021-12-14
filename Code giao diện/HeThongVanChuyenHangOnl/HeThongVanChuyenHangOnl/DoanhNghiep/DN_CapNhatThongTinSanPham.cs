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

namespace HeThongVanChuyenHangOnl.DoanhNghiep
{
    public partial class DN_CapNhatThongTinSanPham : Form
    {
        public DN_CapNhatThongTinSanPham()
        {
            InitializeComponent();
        }

        private void DN_CapNhatThongTinSanPham_Load(object sender, EventArgs e)
        {
            function.FillCombo("SELECT MADN FROM DOANH_NGHIEP", comBoxMaDN, "MADN", "MADN");
            comBoxMaDN.SelectedIndex = -1;      
        }

        private void ResetValueCapNhat()
        {
            comBoxMaDN.Text = "";
            comBoxMaCN.Text = "";
            comBoxMaSP.Text = "";
            textTenSP.Text = "";
            textGiaSP.Text = "";
            textSoLuong.Text = "";
        }

        private void ResetValueXoa()
        {
            comBoxMaSP.Text = "";
            textTenSP.Text = "";
            textGiaSP.Text = "";
            textSoLuong.Text = "";
        }

        private void comBoxMaSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str;
            if (comBoxMaSP.Text == "")
            {
                textTenSP.Text = "";
                textGiaSP.Text = "";
                textSoLuong.Text = "";
            }
            str = "SELECT TEN_SP FROM SAN_PHAM WHERE MA_SP =N'" + comBoxMaSP.SelectedValue + "'";
            textTenSP.Text = function.GetFieldValues(str);
            str = "SELECT GIA FROM SAN_PHAM WHERE MA_SP =N'" + comBoxMaSP.SelectedValue + "'";
            textGiaSP.Text = function.GetFieldValues(str);
            str = "SELECT SO_LUONG FROM SAN_PHAM WHERE MA_SP =N'" + comBoxMaSP.SelectedValue + "'";
            textSoLuong.Text = function.GetFieldValues(str);
        }

        private void comBoxMaDN_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str;
            if (comBoxMaDN.Text == "")
            {
                comBoxMaCN.SelectedValue = "";
            }
            str = "Select MA_CN from CHI_NHANH where MaDN = N'" + comBoxMaDN.SelectedValue + "'";
            function.FillCombo(str, comBoxMaCN, "MA_CN", "MA_CN");
            comBoxMaCN.SelectedIndex = -1;
        }

        private void comBoxMaCN_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str;
            if (comBoxMaCN.Text == "")
            {
                comBoxMaSP.SelectedValue = "";
            }
            str = "SELECT MA_SP FROM CHINHANH_SANPHAM WHERE MA_CN = N'" + comBoxMaCN.SelectedValue + "'";
            function.FillCombo(str, comBoxMaSP, "MA_SP", "MA_SP");
            comBoxMaSP.SelectedIndex = -1;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string query;
            if (comBoxMaSP.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn mã sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comBoxMaSP.Focus();
                return;
            }
            if (textTenSP.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textTenSP.Focus();
                return;
            }
            if (textGiaSP.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập giá sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textGiaSP.Focus();
                return;
            }
            if (textSoLuong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textSoLuong.Focus();
                return;
            }
            query = "CAPNHAT_TTIN_SP N'" + comBoxMaSP.SelectedValue + "', N'" + textTenSP.Text + "', N'" + textGiaSP.Text + "', N'" + textSoLuong.Text + "'";

            function.RunSQL(query);
            MessageBox.Show("Bạn đã cập nhật thành công sản phẩm ^.^", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ResetValueCapNhat();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (comBoxMaSP.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn mã sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comBoxMaSP.Focus();
                return;
            }
            if (textTenSP.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textTenSP.Focus();
                return;
            }
            if (textGiaSP.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập giá sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textGiaSP.Focus();
                return;
            }
            if (textSoLuong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textSoLuong.Focus();
                return;
            }
            string query = "CAPNHAT_TTIN_SP_ROLLBACK N'" + comBoxMaSP.SelectedValue + "', N'" + textTenSP.Text + "', N'" + textGiaSP.Text + "', N'" + textSoLuong.Text + "'";
            function.RunSQL(query);
            MessageBox.Show("Bạn đã cập nhật thành công sản phẩm ^.^", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ResetValueCapNhat();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string query1 = "Delete FROM SAN_PHAM WHERE MA_SP = N'" + comBoxMaSP.SelectedValue + "'";
            string query2 = "Delete FROM CHINHANH_SANPHAM WHERE MA_SP = N'" + comBoxMaSP.SelectedValue + "'";
            function.RunSQL(query2);
            function.RunSQL(query1);
            MessageBox.Show("Bạn đã xóa thành công sản phẩm ^.^", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ResetValueXoa();
        }
    }
}
