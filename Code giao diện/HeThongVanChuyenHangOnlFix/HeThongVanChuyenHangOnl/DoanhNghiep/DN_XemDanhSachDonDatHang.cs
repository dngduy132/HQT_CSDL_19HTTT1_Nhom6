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
    public partial class DN_XemDanhSachDonDatHang : Form
    {
        public DN_XemDanhSachDonDatHang()
        {
            InitializeComponent();
        }

        private void loadData()
        {
            dataGridViewDonHang.DataSource = GetAllDonDatHang().Tables[2];
        }

        private void DN_XemDanhSachDonDatHang_Load(object sender, EventArgs e)
        {
            function.FillCombo("SELECT MADN FROM DOANH_NGHIEP", comBoxMaDN, "MADN", "MADN");
            comBoxMaDN.SelectedIndex = -1;
            loadData();
        }

        DataSet GetAllDonDatHang()
        {
            DataSet data = new DataSet();
            string query = "DN_TKE_DON_DAT_HANG_FIX N'" + comBoxMaDN.SelectedValue + "'";
            using (SqlConnection connection = new SqlConnection(conect_data.connectionString))
            {
                connection.Open();
                SqlDataAdapter dap = new SqlDataAdapter(query, connection);
                dap.Fill(data);
                connection.Close();
            }
            return data;
        }

        private void Enter_btn_Click(object sender, EventArgs e)
        {
            string query;
            query = "DN_TKE_DON_DAT_HANG_FIX N'" + comBoxMaDN.SelectedValue + "'";
            if (comBoxMaDN.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn mã doanh nghiệp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comBoxMaDN.Focus();
                return;
            }
            function.RunSQL(query);
            DataSet data = new DataSet();
            using (SqlConnection connection = new SqlConnection(conect_data.connectionString))
            {
                connection.Open();
                SqlDataAdapter dap = new SqlDataAdapter(query, connection);
                dap.Fill(data);
                connection.Close();
            }
            slDonDatHang_tb.Text = data.Tables[1].Rows[0][0].ToString();
            loadData();
            MessageBox.Show("Thống kê thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

