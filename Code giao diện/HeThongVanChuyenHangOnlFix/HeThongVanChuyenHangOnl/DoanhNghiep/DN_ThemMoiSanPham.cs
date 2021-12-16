using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeThongVanChuyenHangOnl.DoanhNghiep
{
    public partial class DN_ThemMoiSanPham : Form
    {
        public DN_ThemMoiSanPham()
        {
            InitializeComponent();
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

        private void DN_ThemMoiSanPham_Load(object sender, EventArgs e)
        {
            textMaSP.ReadOnly = true;
            Random rand1 = new Random();
            int num1 = rand1.Next(10000000, 99999999);
            string a = num1.ToString();
            string n = "SP" + a;
            textMaSP.Text = n;
            function.FillCombo("SELECT MADN FROM DOANH_NGHIEP", comBoxMaDN, "MADN", "MADN");
            comBoxMaDN.SelectedIndex = -1;
        }

        private void ResetValueCapNhat()
        {
            comBoxMaDN.Text = "";
            comBoxMaCN.Text = "";
            textMaSP.Text = "";
            textTenSP.Text = "";
            textGiaSP.Text = "";
            textSoLuong.Text = "";
            textMoTa.Text = "";
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string query;
            if (comBoxMaDN.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn mã doanh nghiệp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comBoxMaDN.Focus();
                return;
            }
            if (comBoxMaCN.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn mã chi nhánh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comBoxMaCN.Focus();
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
            if (textMoTa.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mô tả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textMoTa.Focus();
                return;
            }
            query = "THEM_SP_FIX N'" + comBoxMaCN.SelectedValue + "', N'" + textMaSP.Text + "', N'" + textTenSP.Text + "', N'" + textGiaSP.Text + "', N'" + textSoLuong.Text + "', N'" + textMoTa.Text + "'";
            function.RunSQL(query);
            MessageBox.Show("Bạn đã thêm thành công sản phẩm ^.^", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ResetValueCapNhat();
        }
    }
}
