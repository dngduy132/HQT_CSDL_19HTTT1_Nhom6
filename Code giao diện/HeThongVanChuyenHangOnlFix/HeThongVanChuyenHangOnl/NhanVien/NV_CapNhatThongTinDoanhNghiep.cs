using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeThongVanChuyenHangOnl.NhanVien
{
    public partial class NV_CapNhatThongTinDoanhNghiep : Form
    {
        public NV_CapNhatThongTinDoanhNghiep()
        {
            InitializeComponent();
        }

        private void NV_CapNhatThongTinDoanhNghiep_Load(object sender, EventArgs e)
        {
            textTenDN.ReadOnly = true;
            function.FillCombo("SELECT MADN FROM DOANH_NGHIEP", comBoxMaDN, "MADN", "MaDN");
            comBoxMaDN.SelectedIndex = -1;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (comBoxMaDN.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn mã doanh nghiệp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comBoxMaDN.Focus();
                return;
            }
            if (textNguoiDaiDien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập người đại diện của doanh nghiệp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textNguoiDaiDien.Focus();
                return;
            }
            string query = "CAPNHAT_DN_NGUOIDAIDIEN_FIX N'" + comBoxMaDN.SelectedValue + "', N'" + textNguoiDaiDien.Text + "'";
            function.RunSQL(query);
            MessageBox.Show("Bạn đã cập nhật thông tin của doanh nghiệp thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void comBoxMaDN_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "SELECT NGUOI_DAI_DIEN FROM DOANH_NGHIEP WHERE MADN = N'" + comBoxMaDN.SelectedValue + "'";
            textNguoiDaiDien.Text = function.GetFieldValues(sql);
            string str = "SELECT TEN_DN FROM DOANH_NGHIEP WHERE MADN = N'" + comBoxMaDN.SelectedValue + "'";
            textTenDN.Text = function.GetFieldValues(str);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
