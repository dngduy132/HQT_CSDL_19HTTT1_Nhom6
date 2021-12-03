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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void loadData()
        {
            dataGridViewDonHang.DataSource = GetAllDonDatHang().Tables[0];
        }
        private void DN_XemDanhSachDonDatHang_Load(object sender, EventArgs e)
        {
            function.FillCombo("SELECT MADN FROM DOANH_NGHIEP", comboBoxMaDN, "MADN", "MADN");
            comboBoxMaDN.SelectedIndex = -1;
            loadData();
        }
        DataSet GetAllDonDatHang()
        {
            DataSet data = new DataSet();
            string query = "Select * from DON_DAT_HANG WHERE MADN =N'" + comboBoxMaDN.SelectedValue + "'";
            using (SqlConnection connection = new SqlConnection(conect_data.connectionString))
            {
                connection.Open();
                SqlDataAdapter dap = new SqlDataAdapter(query, connection);
                dap.Fill(data);
                connection.Close();
            }
            return data;
        }

        private void comboBoxMaDN_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Enter_btn_Click(object sender, EventArgs e)
        {
            string query;
            query = "SELECT MADN FROM DOANH_NGHIEP WHERE MADN = N'" + comboBoxMaDN.SelectedValue + "'";
            if (comboBoxMaDN.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn mã doanh nghiệp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBoxMaDN.Focus();
                return;
            }
            function.RunSQL(query);
            loadData();
        }
    }
}

