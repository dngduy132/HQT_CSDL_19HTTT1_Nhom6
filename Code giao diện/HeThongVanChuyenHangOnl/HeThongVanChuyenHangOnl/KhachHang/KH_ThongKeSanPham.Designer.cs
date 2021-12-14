
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
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTKSP)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 49);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(239, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thống kê sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã doanh nghiệp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số lượng sản phẩm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giá sản phẩm";
            // 
            // comBoxMaDN
            // 
            this.comBoxMaDN.FormattingEnabled = true;
            this.comBoxMaDN.Location = new System.Drawing.Point(206, 65);
            this.comBoxMaDN.Name = "comBoxMaDN";
            this.comBoxMaDN.Size = new System.Drawing.Size(121, 24);
            this.comBoxMaDN.TabIndex = 4;
            // 
            // textSoLuongSP
            // 
            this.textSoLuongSP.Location = new System.Drawing.Point(206, 103);
            this.textSoLuongSP.Name = "textSoLuongSP";
            this.textSoLuongSP.Size = new System.Drawing.Size(121, 22);
            this.textSoLuongSP.TabIndex = 5;
            // 
            // textGiaSP
            // 
            this.textGiaSP.Location = new System.Drawing.Point(206, 145);
            this.textGiaSP.Name = "textGiaSP";
            this.textGiaSP.Size = new System.Drawing.Size(121, 22);
            this.textGiaSP.TabIndex = 6;
            // 
            // btnTKSoLuong
            // 
            this.btnTKSoLuong.Location = new System.Drawing.Point(415, 65);
            this.btnTKSoLuong.Name = "btnTKSoLuong";
            this.btnTKSoLuong.Size = new System.Drawing.Size(200, 32);
            this.btnTKSoLuong.TabIndex = 7;
            this.btnTKSoLuong.Text = "Thống kê theo số lượng";
            this.btnTKSoLuong.UseVisualStyleBackColor = true;
            this.btnTKSoLuong.Click += new System.EventHandler(this.btnTKSoLuong_Click);
            // 
            // dataGridViewTKSP
            // 
            this.dataGridViewTKSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            this.label5.Location = new System.Drawing.Point(412, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Kết quả";
            // 
            // textKetQua
            // 
            this.textKetQua.Location = new System.Drawing.Point(494, 150);
            this.textKetQua.Name = "textKetQua";
            this.textKetQua.Size = new System.Drawing.Size(121, 22);
            this.textKetQua.TabIndex = 10;
            // 
            // btnTKGia
            // 
            this.btnTKGia.Location = new System.Drawing.Point(415, 112);
            this.btnTKGia.Name = "btnTKGia";
            this.btnTKGia.Size = new System.Drawing.Size(200, 32);
            this.btnTKGia.TabIndex = 11;
            this.btnTKGia.Text = "Thống kê theo giá";
            this.btnTKGia.UseVisualStyleBackColor = true;
            this.btnTKGia.Click += new System.EventHandler(this.btnTKGia_Click);
            // 
            // KH_ThongKeSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Controls.Add(this.panel1);
            this.Name = "KH_ThongKeSanPham";
            this.Text = "KH_ThongKeSanPham";
            this.Load += new System.EventHandler(this.KH_ThongKeSanPham_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTKSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
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
    }
}