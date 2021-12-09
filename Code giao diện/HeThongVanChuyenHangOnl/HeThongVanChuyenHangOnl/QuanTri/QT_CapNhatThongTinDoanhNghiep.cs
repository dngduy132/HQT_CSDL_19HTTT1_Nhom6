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
    public partial class QT_CapNhatThongTinDoanhNghiep : Form
    {
        public QT_CapNhatThongTinDoanhNghiep()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void QT_CapNhatThongTinDoanhNghiep_Load(object sender, EventArgs e)
        {
            function.FillCombo("SELECT MADN FROM DOANH_NGHIEP", comBoxMaDN, "MADN", "MADN");
            comBoxMaDN.SelectedIndex = -1;
            function.FillCombo("SELECT DISTINCT TEN_KHU_VUC FROM KHU_VUC", comBoxQuan, "TEN_KHU_VUC", "TEN_KHU_VUC");
            comBoxQuan.SelectedIndex = -1;
            loadData();
        }


        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (comBoxMaDN.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn tên doanh nghiệp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comBoxMaDN.Focus();
                return;
            }
            if (comBoxQuan.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn quận của doanh nghiệp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comBoxQuan.Focus();
                return;
            }
            string query = "CAPNHAT_DN N'" + comBoxMaDN.SelectedValue + "', N'" + comBoxQuan.SelectedValue + "'";
            function.RunSQL(query);
            loadData();
            MessageBox.Show("Bạn đã cập nhật thông tin của doanh nghiệp thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void comBoxMaDN_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str1 = "SELECT QUAN FROM DOANH_NGHIEP WHERE MADN = N'" + comBoxMaDN.SelectedValue + "'";
            comBoxQuan.Text = function.GetFieldValues(str1);
        }

        private void loadData()
        {
            dataGridViewCapNhatThongTinDN.DataSource = GetAllCapNhatThongTinDN().Tables[0];
        }

        DataSet GetAllCapNhatThongTinDN()
        {
            DataSet data = new DataSet();
            string query = "AD_XEM_DN";
            using (SqlConnection connection = new SqlConnection(conect_data.connectionString))
            {
                connection.Open();
                SqlDataAdapter dap = new SqlDataAdapter(query, connection);
                dap.Fill(data);
                connection.Close();
            }
            return data;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
