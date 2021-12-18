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


namespace HeThongVanChuyenHangOnl.TaiXe
{
    public partial class TX_NhanGiaoHang : Form
    {
        public TX_NhanGiaoHang()
        {
            InitializeComponent();
        }

        private void TX_NhanGiaoHang_Load(object sender, EventArgs e)
        {
            function.FillCombo("SELECT MA_TX FROM TAI_XE", comBoxMaTX, "MA_TX", "MA_TX");
            comBoxMaTX.SelectedIndex = -1;
        }

        private void loadData()
        {
            dataGridViewNhanGiaoHang.DataSource = GetAllNhanGiaoHang().Tables[0];
        }

        DataSet GetAllNhanGiaoHang()
        {
            DataSet data = new DataSet();
            string query = "TX_XEM_DH_FIX N'" + comBoxMaTX.SelectedValue + "'";
            using (SqlConnection connection = new SqlConnection(conect_data.connectionString))
            {
                connection.Open();
                SqlDataAdapter dap = new SqlDataAdapter(query, connection);
                dap.Fill(data);
                connection.Close();
            }
            return data;
        }

        private void btnTimDonHang_Click(object sender, EventArgs e)
        {
            string query;
            query = "TX_XEM_DH_FIX N'" + comBoxMaTX.SelectedValue + "'";
            function.RunSQL(query);
            loadData();
            function.FillCombo("TX_XEM_MAHD_FIX N'" + comBoxMaTX.SelectedValue + "'", comBoxMaDon, "MA_DON", "MA_DON");
            comBoxMaDon.SelectedIndex = -1;
        }

        private void btnNhanDonHang_Click(object sender, EventArgs e)
        {
            string query;
            query = "TX_NHAN_DH_DEADLOCK_FIX N'" + comBoxMaTX.SelectedValue + "', N'" + comBoxMaDon.SelectedValue + "'";
            function.RunSQL(query);
            loadData();
            MessageBox.Show("Bạn đã nhận đơn hàng thành công ^.^", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
