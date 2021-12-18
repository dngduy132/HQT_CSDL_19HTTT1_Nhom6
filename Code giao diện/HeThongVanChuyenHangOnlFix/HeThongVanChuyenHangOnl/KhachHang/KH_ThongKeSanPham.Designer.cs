
namespace HeThongVanChuyenHangOnl.KhachHang
{
    partial class KH_ThongKeSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KH_ThongKeSanPham));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comBoxMaDN = new System.Windows.Forms.ComboBox();
            this.textSoLuongSP = new System.Windows.Forms.TextBox();
            this.textGiaSP = new System.Windows.Forms.TextBox();
            this.btnTKSoLuong = new System.Windows.Forms.Button();
            this.dataGridViewTKSP = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.textKetQua = new System.Windows.Forms.TextBox();
            this.btnTKGia = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTKSP)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(244, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thống kê sản phẩm";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã doanh nghiệp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(74, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số lượng sản phẩm";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(74, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giá sản phẩm";
            // 
            // comBoxMaDN
            // 
            this.comBoxMaDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBoxMaDN.FormattingEnabled = true;
            this.comBoxMaDN.Location = new System.Drawing.Point(251, 72);
            this.comBoxMaDN.Name = "comBoxMaDN";
            this.comBoxMaDN.Size = new System.Drawing.Size(121, 28);
            this.comBoxMaDN.TabIndex = 4;
            // 
            // textSoLuongSP
            // 
            this.textSoLuongSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSoLuongSP.Location = new System.Drawing.Point(251, 112);
            this.textSoLuongSP.Name = "textSoLuongSP";
            this.textSoLuongSP.Size = new System.Drawing.Size(121, 27);
            this.textSoLuongSP.TabIndex = 5;
            // 
            // textGiaSP
            // 
            this.textGiaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textGiaSP.Location = new System.Drawing.Point(251, 150);
            this.textGiaSP.Name = "textGiaSP";
            this.textGiaSP.Size = new System.Drawing.Size(121, 27);
            this.textGiaSP.TabIndex = 6;
            // 
            // btnTKSoLuong
            // 
            this.btnTKSoLuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(84)))), ((int)(((byte)(3)))));
            this.btnTKSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTKSoLuong.ForeColor = System.Drawing.Color.White;
            this.btnTKSoLuong.Location = new System.Drawing.Point(494, 63);
            this.btnTKSoLuong.Name = "btnTKSoLuong";
            this.btnTKSoLuong.Size = new System.Drawing.Size(200, 37);
            this.btnTKSoLuong.TabIndex = 7;
            this.btnTKSoLuong.Text = "Thống kê theo số lượng";
            this.btnTKSoLuong.UseVisualStyleBackColor = false;
            this.btnTKSoLuong.Click += new System.EventHandler(this.btnTKSoLuong_Click);
            // 
            // dataGridViewTKSP
            // 
            this.dataGridViewTKSP.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(243)))), ((int)(((byte)(224)))));
            this.dataGridViewTKSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTKSP.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTKSP.Location = new System.Drawing.Point(27, 189);
            this.dataGridViewTKSP.Name = "dataGridViewTKSP";
            this.dataGridViewTKSP.RowHeadersWidth = 51;
            this.dataGridViewTKSP.RowTemplate.Height = 24;
            this.dataGridViewTKSP.Size = new System.Drawing.Size(749, 249);
            this.dataGridViewTKSP.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(409, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Kết quả";
            // 
            // textKetQua
            // 
            this.textKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textKetQua.Location = new System.Drawing.Point(494, 150);
            this.textKetQua.Name = "textKetQua";
            this.textKetQua.Size = new System.Drawing.Size(200, 27);
            this.textKetQua.TabIndex = 10;
            // 
            // btnTKGia
            // 
            this.btnTKGia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(84)))), ((int)(((byte)(3)))));
            this.btnTKGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTKGia.ForeColor = System.Drawing.Color.White;
            this.btnTKGia.Location = new System.Drawing.Point(494, 106);
            this.btnTKGia.Name = "btnTKGia";
            this.btnTKGia.Size = new System.Drawing.Size(200, 36);
            this.btnTKGia.TabIndex = 11;
            this.btnTKGia.Text = "Thống kê theo giá";
            this.btnTKGia.UseVisualStyleBackColor = false;
            this.btnTKGia.Click += new System.EventHandler(this.btnTKGia_Click);
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
            this.panel1.TabIndex = 14;
            // 
            // KH_ThongKeSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(243)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnTKGia);
            this.Controls.Add(this.textKetQua);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridViewTKSP);
            this.Controls.Add(this.btnTKSoLuong);
            this.Controls.Add(this.textGiaSP);
            this.Controls.Add(this.textSoLuongSP);
            this.Controls.Add(this.comBoxMaDN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KH_ThongKeSanPham";
            this.Text = "KH_ThongKeSanPham";
            this.Load += new System.EventHandler(this.KH_ThongKeSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTKSP)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comBoxMaDN;
        private System.Windows.Forms.TextBox textSoLuongSP;
        private System.Windows.Forms.TextBox textGiaSP;
        private System.Windows.Forms.Button btnTKSoLuong;
        private System.Windows.Forms.DataGridView dataGridViewTKSP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textKetQua;
        private System.Windows.Forms.Button btnTKGia;
        private System.Windows.Forms.Panel panel1;
    }
}