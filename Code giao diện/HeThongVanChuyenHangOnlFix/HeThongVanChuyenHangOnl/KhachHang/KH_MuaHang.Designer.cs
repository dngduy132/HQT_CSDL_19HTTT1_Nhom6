
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KH_MuaHang));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridMuaSP = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.comBoxHTTT = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comBoxMaKH = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comBoxKV = new System.Windows.Forms.ComboBox();
            this.btnDatHang = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textSoLuong = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comBoxMaDN = new System.Windows.Forms.ComboBox();
            this.comBoxMaSP = new System.Windows.Forms.ComboBox();
            this.bntXemSP = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textTongTien = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMuaSP)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(293, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mua sản phẩm";
            // 
            // dataGridMuaSP
            // 
            this.dataGridMuaSP.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(243)))), ((int)(((byte)(224)))));
            this.dataGridMuaSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridMuaSP.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridMuaSP.Location = new System.Drawing.Point(24, 202);
            this.dataGridMuaSP.Name = "dataGridMuaSP";
            this.dataGridMuaSP.RowHeadersWidth = 51;
            this.dataGridMuaSP.RowTemplate.Height = 24;
            this.dataGridMuaSP.Size = new System.Drawing.Size(754, 236);
            this.dataGridMuaSP.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(299, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "HT thanh toán";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // comBoxHTTT
            // 
            this.comBoxHTTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBoxHTTT.FormattingEnabled = true;
            this.comBoxHTTT.Location = new System.Drawing.Point(430, 71);
            this.comBoxHTTT.Name = "comBoxHTTT";
            this.comBoxHTTT.Size = new System.Drawing.Size(139, 28);
            this.comBoxHTTT.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mã DNghiệp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mã khách hàng";
            // 
            // comBoxMaKH
            // 
            this.comBoxMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBoxMaKH.FormattingEnabled = true;
            this.comBoxMaKH.Location = new System.Drawing.Point(157, 71);
            this.comBoxMaKH.Name = "comBoxMaKH";
            this.comBoxMaKH.Size = new System.Drawing.Size(136, 28);
            this.comBoxMaKH.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(299, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tên khu vực";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // comBoxKV
            // 
            this.comBoxKV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBoxKV.FormattingEnabled = true;
            this.comBoxKV.Location = new System.Drawing.Point(430, 110);
            this.comBoxKV.Name = "comBoxKV";
            this.comBoxKV.Size = new System.Drawing.Size(139, 28);
            this.comBoxKV.TabIndex = 10;
            // 
            // btnDatHang
            // 
            this.btnDatHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(84)))), ((int)(((byte)(3)))));
            this.btnDatHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatHang.ForeColor = System.Drawing.Color.White;
            this.btnDatHang.Location = new System.Drawing.Point(586, 64);
            this.btnDatHang.Name = "btnDatHang";
            this.btnDatHang.Size = new System.Drawing.Size(192, 36);
            this.btnDatHang.TabIndex = 12;
            this.btnDatHang.Text = "Đặt hàng";
            this.btnDatHang.UseVisualStyleBackColor = false;
            this.btnDatHang.Click += new System.EventHandler(this.btnDatHang_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Mã sản phẩm";
            // 
            // textSoLuong
            // 
            this.textSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSoLuong.Location = new System.Drawing.Point(430, 152);
            this.textSoLuong.Name = "textSoLuong";
            this.textSoLuong.Size = new System.Drawing.Size(139, 27);
            this.textSoLuong.TabIndex = 17;
            this.textSoLuong.TextChanged += new System.EventHandler(this.textSoLuong_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(299, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Số lượng";
            // 
            // comBoxMaDN
            // 
            this.comBoxMaDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBoxMaDN.FormattingEnabled = true;
            this.comBoxMaDN.Location = new System.Drawing.Point(157, 115);
            this.comBoxMaDN.Name = "comBoxMaDN";
            this.comBoxMaDN.Size = new System.Drawing.Size(136, 28);
            this.comBoxMaDN.TabIndex = 19;
            this.comBoxMaDN.SelectedIndexChanged += new System.EventHandler(this.comBoxMaDN_SelectedIndexChanged);
            // 
            // comBoxMaSP
            // 
            this.comBoxMaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBoxMaSP.FormattingEnabled = true;
            this.comBoxMaSP.Location = new System.Drawing.Point(157, 152);
            this.comBoxMaSP.Name = "comBoxMaSP";
            this.comBoxMaSP.Size = new System.Drawing.Size(136, 28);
            this.comBoxMaSP.TabIndex = 20;
            // 
            // bntXemSP
            // 
            this.bntXemSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(84)))), ((int)(((byte)(3)))));
            this.bntXemSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntXemSP.ForeColor = System.Drawing.Color.White;
            this.bntXemSP.Location = new System.Drawing.Point(586, 105);
            this.bntXemSP.Name = "bntXemSP";
            this.bntXemSP.Size = new System.Drawing.Size(192, 38);
            this.bntXemSP.TabIndex = 21;
            this.bntXemSP.Text = "Xem sản phẩm";
            this.bntXemSP.UseVisualStyleBackColor = false;
            this.bntXemSP.Click += new System.EventHandler(this.bntXemSP_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(573, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Tổng tiền";
            // 
            // textTongTien
            // 
            this.textTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTongTien.Location = new System.Drawing.Point(657, 155);
            this.textTongTien.Name = "textTongTien";
            this.textTongTien.Size = new System.Drawing.Size(121, 27);
            this.textTongTien.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(147)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 57);
            this.panel1.TabIndex = 24;
            // 
            // KH_MuaHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(243)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textTongTien);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bntXemSP);
            this.Controls.Add(this.comBoxMaSP);
            this.Controls.Add(this.comBoxMaDN);
            this.Controls.Add(this.textSoLuong);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnDatHang);
            this.Controls.Add(this.comBoxKV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comBoxMaKH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comBoxHTTT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridMuaSP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Button btnDatHang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textSoLuong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comBoxMaDN;
        private System.Windows.Forms.ComboBox comBoxMaSP;
        private System.Windows.Forms.Button bntXemSP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textTongTien;
        private System.Windows.Forms.Panel panel1;
    }
}