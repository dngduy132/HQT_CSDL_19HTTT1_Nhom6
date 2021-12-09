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
    public partial class KH_ThongTinSanPham : Form
    {
        public KH_ThongTinSanPham()
        {
            InitializeComponent();
        }

        private void KH_ThongTinSanPham_Load(object sender, EventArgs e)
        {
            function.FillCombo("SELECT MADN FROM DOANH_NGHIEP", comBoxMaDN, "MADN", "MADN");
            comBoxMaDN.SelectedIndex = -1;
            //loadData();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void loadData()
        {
            dataGridViewThongTinSP.DataSource = GetAllThongTinSP().Tables[0];
        }
        
        DataSet GetAllThongTinSP()
        {
            DataSet data = new DataSet();
            string query = "KH_XEM_SP_THEO_MADN N'" + comBoxMaDN.SelectedValue + "'";
            using (SqlConnection connection = new SqlConnection(conect_data.connectionString))
            {
                connection.Open();
                SqlDataAdapter dap = new SqlDataAdapter(query, connection);
                dap.Fill(data);
                connection.Close();
            }
            return data;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (comBoxMaDN.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn mã doanh nghiệp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comBoxMaDN.Focus();
                return;
            }
            string query = "KH_XEM_SP_THEO_MADN N'" + comBoxMaDN.SelectedValue + "'";
            function.RunSQL(query);
            loadData();
        }
    }
}
