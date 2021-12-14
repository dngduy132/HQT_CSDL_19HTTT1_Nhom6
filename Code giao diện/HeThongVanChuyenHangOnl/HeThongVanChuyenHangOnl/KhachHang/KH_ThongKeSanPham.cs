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
    public partial class KH_ThongKeSanPham : Form
    {
        public KH_ThongKeSanPham()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void KH_ThongKeSanPham_Load(object sender, EventArgs e)
        {
            function.FillCombo("SELECT MADN FROM DOANH_NGHIEP", comBoxMaDN, "MADN", "MADN");
            comBoxMaDN.SelectedIndex = -1;
        }

        //private void LoadDataSL()
        //{
        //    dataGridViewTKSP.DataSource = GetAllThongKeSL().Tables[1];
        //}

        //DataSet GetAllThongKeSL()
        //{
        //    DataSet data = new DataSet();
        //    string query = "KH_THONGKE_SP_SLUONG N'" + comBoxMaDN.SelectedValue + "',N'" + textSoLuongSP.Text + "'";
        //    using (SqlConnection connection = new SqlConnection(conect_data.connectionString))
        //    {
        //        connection.Open();
        //        SqlDataAdapter dap = new SqlDataAdapter(query, connection);
        //        dap.Fill(data);
        //        connection.Close();
        //    }
        //    return data;
        //}

        private void btnTKSoLuong_Click(object sender, EventArgs e)
        {
            if (comBoxMaDN.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn mã doanh nghiệp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comBoxMaDN.Focus();
                return;
            }
            if (textSoLuongSP.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textSoLuongSP.Focus();
                return;
            }
            
            string query = "KH_THONGKE_SP_SLUONG N'" + comBoxMaDN.SelectedValue + "',N'" + textSoLuongSP.Text + "'";
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
            dataGridViewTKSP.DataSource = data.Tables[1];
        }

        private void LoadDataGia()
        {
            dataGridViewTKSP.DataSource = GetAllThongKeGia().Tables[1];
        }

        DataSet GetAllThongKeGia()
        {
            DataSet data = new DataSet();
            string query = "KH_THONGKE_SP_SLUONG N'" + comBoxMaDN.SelectedValue + "',N'" + textSoLuongSP.Text + "'";
            using (SqlConnection connection = new SqlConnection(conect_data.connectionString))
            {
                connection.Open();
                SqlDataAdapter dap = new SqlDataAdapter(query, connection);
                dap.Fill(data);
                connection.Close();
            }
            return data;
        }

        private void btnTKGia_Click(object sender, EventArgs e)
        {
            if (comBoxMaDN.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn mã doanh nghiệp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comBoxMaDN.Focus();
                return;
            }
            if (textGiaSP.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn mã doanh nghiệp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textGiaSP.Focus();
                return;
            }
            string query = "KH_THONGKE_SP_GIA N'" + comBoxMaDN.SelectedValue + "',N'" + textSoLuongSP.Text + "'";
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
            dataGridViewTKSP.DataSource = data.Tables[1];
            

        }
    }
}
