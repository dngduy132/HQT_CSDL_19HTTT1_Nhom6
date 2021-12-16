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


namespace HeThongVanChuyenHangOnl.QuanTri
{
    public partial class QT_XemThongTinDoanhNghiep : Form
    {
        public QT_XemThongTinDoanhNghiep()
        {
            InitializeComponent();
        }

        private void QT_XemThongTinDoanhNghiep_Load(object sender, EventArgs e)
        {
            dataGridViewXemThongTinDN.DataSource = GetAllXemThongTinDN().Tables[0];
        }

        DataSet GetAllXemThongTinDN()
        {
            DataSet data = new DataSet();
            string query = "AD_XEM_DN_FIX";
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
