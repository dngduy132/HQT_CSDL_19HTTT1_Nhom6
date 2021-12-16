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


namespace HeThongVanChuyenHangOnl.KhachHang
{
    public partial class KH_TimKiemSanPham : Form
    {
        public KH_TimKiemSanPham()
        {
            InitializeComponent();
        }

        private void KH_TimKiemSanPham_Load(object sender, EventArgs e)
        {
            textKetQua.ReadOnly = true;
            function.FillCombo("SELECT TEN_DN FROM DOANH_NGHIEP", comBoxTenDN, "TEN_DN", "TEN_DN");
            comBoxTenDN.SelectedIndex = -1;
        }

        private void comBoxTenDN_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = "KH_XEM_TEN_SP_THEO_MADN_FIX N'" + comBoxTenDN.SelectedValue+"'";
            
            function.FillCombo(str, comBoxTenSP, "TEN_SP", "TEN_SP");
            comBoxTenSP.SelectedIndex = -1;
        }

        private void LoadDataSL()
        {
            dataGridViewTimSP.DataSource = GetAllTimKiemSP().Tables[1];
        }

        DataSet GetAllTimKiemSP()
        {
            DataSet data = new DataSet();
            string query = "KH_TIM_SP_THEO_TENDN_TENSP_FIX N'" + comBoxTenDN.SelectedValue + "',N'" + comBoxTenSP.SelectedValue + "'";
            using (SqlConnection connection = new SqlConnection(conect_data.connectionString))
            {
                connection.Open();
                SqlDataAdapter dap = new SqlDataAdapter(query, connection);
                dap.Fill(data);
                connection.Close();
            }
            return data;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (comBoxTenDN.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn tên doanh nghiệp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comBoxTenDN.Focus();
                return;
            }
            if (comBoxTenSP.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên sản phẩm cần tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comBoxTenSP.Focus();
                return;
            }
            string query = "KH_TIM_SP_THEO_TENDN_TENSP_FIX N'" + comBoxTenDN.SelectedValue + "',N'" + comBoxTenSP.SelectedValue + "'";
            function.RunSQL(query);
            DataSet data = new DataSet();
            using (SqlConnection connection = new SqlConnection(conect_data.connectionString))
            {
                connection.Open();
                SqlDataAdapter dap = new SqlDataAdapter(query, connection);
                dap.Fill(data);
                connection.Close();
            }
            textKetQua.Text = data.Tables[0].Rows[0][0].ToString();
            LoadDataSL();
            MessageBox.Show("Tìm kiếm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
