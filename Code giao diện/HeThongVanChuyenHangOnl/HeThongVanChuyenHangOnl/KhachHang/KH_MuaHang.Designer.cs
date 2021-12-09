
namespace HeThongVanChuyenHangOnl.KhachHang
{
    partial class KH_MuaHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridMuaSP = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.comBoxHTTT = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comBoxMaKH = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comBoxKV = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDatHang = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textSoLuong = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comBoxMaDN = new System.Windows.Forms.ComboBox();
            this.comBoxMaSP = new System.Windows.Forms.ComboBox();
            this.bntXemSP = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textTongTien = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMuaSP)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(265, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mua sản phẩm";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridMuaSP
            // 
            this.dataGridMuaSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMuaSP.Location = new System.Drawing.Point(27, 247);
            this.dataGridMuaSP.Name = "dataGridMuaSP";
            this.dataGridMuaSP.RowHeadersWidth = 51;
            this.dataGridMuaSP.RowTemplate.Height = 24;
            this.dataGridMuaSP.Size = new System.Drawing.Size(742, 191);
            this.dataGridMuaSP.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hình thức thanh toán";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // comBoxHTTT
            // 
            this.comBoxHTTT.FormattingEnabled = true;
            this.comBoxHTTT.Location = new System.Drawing.Point(407, 65);
            this.comBoxHTTT.Name = "comBoxHTTT";
            this.comBoxHTTT.Size = new System.Drawing.Size(121, 24);
            this.comBoxHTTT.TabIndex = 4;
            this.comBoxHTTT.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mã DNghiệp";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mã khách hàng";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // comBoxMaKH
            // 
            this.comBoxMaKH.FormattingEnabled = true;
            this.comBoxMaKH.Location = new System.Drawing.Point(119, 65);
            this.comBoxMaKH.Name = "comBoxMaKH";
            this.comBoxMaKH.Size = new System.Drawing.Size(121, 24);
            this.comBoxMaKH.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(549, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tên khu vực";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // comBoxKV
            // 
            this.comBoxKV.FormattingEnabled = true;
            this.comBoxKV.Location = new System.Drawing.Point(646, 65);
            this.comBoxKV.Name = "comBoxKV";
            this.comBoxKV.Size = new System.Drawing.Size(121, 24);
            this.comBoxKV.TabIndex = 10;
            this.comBoxKV.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 50);
            this.panel1.TabIndex = 11;
            // 
            // btnDatHang
            // 
            this.btnDatHang.Location = new System.Drawing.Point(603, 107);
            this.btnDatHang.Name = "btnDatHang";
            this.btnDatHang.Size = new System.Drawing.Size(123, 29);
            this.btnDatHang.TabIndex = 12;
            this.btnDatHang.Text = "Đặt hàng";
            this.btnDatHang.UseVisualStyleBackColor = true;
            this.btnDatHang.Click += new System.EventHandler(this.btnDatHang_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Mã sản phẩm";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // textSoLuong
            // 
            this.textSoLuong.Location = new System.Drawing.Point(119, 194);
            this.textSoLuong.Name = "textSoLuong";
            this.textSoLuong.Size = new System.Drawing.Size(121, 22);
            this.textSoLuong.TabIndex = 17;
            this.textSoLuong.TextChanged += new System.EventHandler(this.textSoLuong_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Số lượng";
            // 
            // comBoxMaDN
            // 
            this.comBoxMaDN.FormattingEnabled = true;
            this.comBoxMaDN.Location = new System.Drawing.Point(119, 105);
            this.comBoxMaDN.Name = "comBoxMaDN";
            this.comBoxMaDN.Size = new System.Drawing.Size(121, 24);
            this.comBoxMaDN.TabIndex = 19;
            this.comBoxMaDN.SelectedIndexChanged += new System.EventHandler(this.comBoxMaDN_SelectedIndexChanged);
            // 
            // comBoxMaSP
            // 
            this.comBoxMaSP.FormattingEnabled = true;
            this.comBoxMaSP.Location = new System.Drawing.Point(119, 148);
            this.comBoxMaSP.Name = "comBoxMaSP";
            this.comBoxMaSP.Size = new System.Drawing.Size(121, 24);
            this.comBoxMaSP.TabIndex = 20;
            // 
            // bntXemSP
            // 
            this.bntXemSP.Location = new System.Drawing.Point(405, 107);
            this.bntXemSP.Name = "bntXemSP";
            this.bntXemSP.Size = new System.Drawing.Size(123, 31);
            this.bntXemSP.TabIndex = 21;
            this.bntXemSP.Text = "Xem sản phẩm";
            this.bntXemSP.UseVisualStyleBackColor = true;
            this.bntXemSP.Click += new System.EventHandler(this.bntXemSP_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(422, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Tổng tiền";
            // 
            // textTongTien
            // 
            this.textTongTien.Location = new System.Drawing.Point(539, 191);
            this.textTongTien.Name = "textTongTien";
            this.textTongTien.Size = new System.Drawing.Size(121, 22);
            this.textTongTien.TabIndex = 23;
            // 
            // KH_MuaHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textTongTien);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bntXemSP);
            this.Controls.Add(this.comBoxMaSP);
            this.Controls.Add(this.comBoxMaDN);
            this.Controls.Add(this.textSoLuong);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnDatHang);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comBoxKV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comBoxMaKH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comBoxHTTT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridMuaSP);
            this.Name = "KH_MuaHang";
            this.Text = "KH_MuaHang";
            this.Load += new System.EventHandler(this.KH_MuaHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMuaSP)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridMuaSP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comBoxHTTT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comBoxMaKH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comBoxKV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDatHang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textSoLuong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comBoxMaDN;
        private System.Windows.Forms.ComboBox comBoxMaSP;
        private System.Windows.Forms.Button bntXemSP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textTongTien;
    }
}