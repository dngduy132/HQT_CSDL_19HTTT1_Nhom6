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
    public partial class KH_TimKiemDoanhNghiep : Form
    {
        public KH_TimKiemDoanhNghiep()
        {
            InitializeComponent();
        }

        private void KH_TimKiemDoanhNghiep_Load(object sender, EventArgs e)
        {
            function.FillCombo("SELECT TEN_DN FROM DOANH_NGHIEP", comBoxTenDN, "TEN_DN", "TEN_DN");
            comBoxTenDN.SelectedIndex = -1;
            function.FillCombo("SELECT QUAN FROM DOANH_NGHIEP", comBoxQuan, "QUAN", "QUAN");
            comBoxQuan.SelectedIndex = -1;
        }

        private void loadData()
        {
            dataGridViewTimKiemDN.DataSource = GetAllTimKiemDN().Tables[1];
        }

        DataSet GetAllTimKiemDN()
        {
            DataSet data = new DataSet();
            string query = "TIMDN_THEO_TEN_QUAN_FIX N'" + comBoxTenDN.SelectedValue + "', N'" + comBoxQuan.SelectedValue + "'";
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
            if (comBoxQuan.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn quận của doanh nghiệp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comBoxQuan.Focus();
                return;
            }
            string query = "TIMDN_THEO_TEN_QUAN_FIX N'" + comBoxTenDN.SelectedValue + "', N'" + comBoxQuan.SelectedValue + "'";
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
            loadData();
            MessageBox.Show("Tìm kiếm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
