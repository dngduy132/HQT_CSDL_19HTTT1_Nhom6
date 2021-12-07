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
    public partial class KH_MuaHang : Form
    {
        public KH_MuaHang()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void KH_MuaHang_Load(object sender, EventArgs e)
        {
            function.FillCombo("SELECT MA_KH FROM KHACH_HANG", comBoxMaKH, "MA_KH", "MA_KH");
            comBoxMaKH.SelectedIndex = -1;
            function.FillCombo("SELECT DISTINCT HINH_THUC_THANH_TOAN FROM DON_DAT_HANG", comBoxHTTT, "HINH_THUC_THANH_TOAN", "HINH_THUC_THANH_TOAN");
            comBoxHTTT.SelectedIndex = -1;
            function.FillCombo("SELECT TEN_KHU_VUC FROM KHU_VUC", comBoxKV, "TEN_KHU_VUC", "TEN_KHU_VUC");
            comBoxKV.SelectedIndex = -1;
            function.FillCombo("SELECT MADN FROM DOANH_NGHIEP", comBoxMaDN, "MADN", "MADN");
            comBoxMaDN.SelectedIndex = -1;
            

        }
        
        private void LoadData()
        {
            dataGridMuaSP.DataSource = GetAllMuaSP().Tables[0];
        }

        DataSet GetAllMuaSP()
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

        private void comBoxMaDN_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str;
            if (comBoxMaDN.Text == "")
            {
                comBoxMaSP.SelectedValue = "";

            }
            str = "SELECT SP.MA_SP FROM  DOANH_NGHIEP DN JOIN CHI_NHANH CN  ON(DN.MADN = CN.MADN)  JOIN CHINHANH_SANPHAM CN_SP  ON(CN.MA_CN = CN_SP.MA_CN)  JOIN SAN_PHAM SP ON(CN_SP.MA_SP = SP.MA_SP) WHERE DN.MADN = N'" + comBoxMaDN.SelectedValue + "'";

            
            function.FillCombo(str, comBoxMaSP, "MA_SP", "MA_SP");
            comBoxMaSP.SelectedIndex = -1;
        }

        private void bntXemSP_Click(object sender, EventArgs e)
        {
            string query;
            query = "KH_XEM_SP_THEO_MADN N'" + comBoxMaDN.SelectedValue + "'";
            if (comBoxMaDN.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn mã doanh nghiệp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comBoxMaDN.Focus();
                return;
            }
            function.RunSQL(query);
            LoadData();
           
        }

        private void ResetValueHoaDon()
        {
            comBoxMaDN.Text = "";
            comBoxMaKH.Text = "";
            comBoxHTTT.Text = "";
            comBoxKV.Text = "";
            comBoxMaSP.Text = "";
            textSoLuong.Text = "";
        }

        private void btnDatHang_Click(object sender, EventArgs e)
        {
            string query;
            Random rand1 = new Random();
            int num1 = rand1.Next(10000000, 99999999);
            string a = num1.ToString();
            string n = "SP" + a;

            if (comBoxMaKH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn mã khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comBoxMaKH.Focus();
                return;
            }
            if (comBoxHTTT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn hình thức thanh toán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comBoxHTTT.Focus();
                return;
            }
            if (comBoxKV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn mã khu vực", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comBoxKV.Focus();
                return;
            }
            if (comBoxMaDN.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn mã doanh nghiep", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comBoxMaDN.Focus();
                return;
            }
            if (comBoxMaSP.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn mã sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comBoxMaSP.Focus();
                return;
            }
            
            query = "KH_MUA_HANG N'" + n + "', N'"+ comBoxKV.SelectedValue +"', N'" + comBoxMaDN.SelectedValue + "', N'" + comBoxMaKH.SelectedValue + "', N'" + comBoxHTTT.SelectedValue + "', N'" + textSoLuong.Text + "', N'" + comBoxMaSP.SelectedValue + "'";
            function.RunSQL(query);
            //string sql = ("SELECT ");
            //UPDATE SO_LUONG, TONG_TIEN
            MessageBox.Show("Bạn đã thêm thành công sản phẩm ^.^", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ResetValueHoaDon();
            //LoadData();
        }
    }
}
