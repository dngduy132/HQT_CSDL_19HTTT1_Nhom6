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
    public partial class KH_ThongTinDoanhNghiep : Form
    {
        public KH_ThongTinDoanhNghiep()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void KH_ThongTinDoanhNghiep_Load(object sender, EventArgs e)
        {
            dataGridViewThongTin.DataSource = GetAllThongTin().Tables[0];
        }

        DataSet GetAllThongTin()
        {
            DataSet data = new DataSet();
            string query = "KH_XEM_TATCA_DN";
            using (SqlConnection connection = new SqlConnection(conect_data.connectionString))
            {
                connection.Open();
                SqlDataAdapter dap = new SqlDataAdapter(query, connection);
                dap.Fill(data);
                connection.Close();
            }
            return data;
        }
    }
}
