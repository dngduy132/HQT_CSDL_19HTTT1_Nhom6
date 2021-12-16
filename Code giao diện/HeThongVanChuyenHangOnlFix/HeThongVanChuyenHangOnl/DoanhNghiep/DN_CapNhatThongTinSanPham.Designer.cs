
namespace HeThongVanChuyenHangOnl.DoanhNghiep
{
    partial class DN_CapNhatThongTinSanPham
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
            this.comBoxMaDN = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comBoxMaSP = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textSoLuong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textTenSP = new System.Windows.Forms.TextBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comBoxMaCN = new System.Windows.Forms.ComboBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.textGiaSP = new System.Windows.Forms.TextBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã doanh nghiệp";
            // 
            // comBoxMaDN
            // 
            this.comBoxMaDN.FormattingEnabled = true;
            this.comBoxMaDN.Location = new System.Drawing.Point(168, 89);
            this.comBoxMaDN.Name = "comBoxMaDN";
            this.comBoxMaDN.Size = new System.Drawing.Size(160, 24);
            this.comBoxMaDN.TabIndex = 1;
            this.comBoxMaDN.SelectedIndexChanged += new System.EventHandler(this.comBoxMaDN_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã sản phẩm";
            // 
            // comBoxMaSP
            // 
            this.comBoxMaSP.FormattingEnabled = true;
            this.comBoxMaSP.Location = new System.Drawing.Point(168, 200);
            this.comBoxMaSP.Name = "comBoxMaSP";
            this.comBoxMaSP.Size = new System.Drawing.Size(160, 24);
            this.comBoxMaSP.TabIndex = 3;
            this.comBoxMaSP.SelectedIndexChanged += new System.EventHandler(this.comBoxMaSP_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(455, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số lượng";
            // 
            // textSoLuong
            // 
            this.textSoLuong.Location = new System.Drawing.Point(604, 140);
            this.textSoLuong.Name = "textSoLuong";
            this.textSoLuong.Size = new System.Drawing.Size(160, 22);
            this.textSoLuong.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(455, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tên Sản Phẩm";
            // 
            // textTenSP
            // 
            this.textTenSP.AcceptsTab = true;
            this.textTenSP.Location = new System.Drawing.Point(604, 91);
            this.textTenSP.Name = "textTenSP";
            this.textTenSP.Size = new System.Drawing.Size(160, 22);
            this.textTenSP.TabIndex = 7;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(616, 246);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(132, 33);
            this.btnCapNhat.TabIndex = 8;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(204, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(423, 37);
            this.label5.TabIndex = 9;
            this.label5.Text = "Cập nhật thông tin sản phẩm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Mã chi nhánh";
            // 
            // comBoxMaCN
            // 
            this.comBoxMaCN.FormattingEnabled = true;
            this.comBoxMaCN.Location = new System.Drawing.Point(168, 140);
            this.comBoxMaCN.Name = "comBoxMaCN";
            this.comBoxMaCN.Size = new System.Drawing.Size(160, 24);
            this.comBoxMaCN.TabIndex = 11;
            this.comBoxMaCN.SelectedIndexChanged += new System.EventHandler(this.comBoxMaCN_SelectedIndexChanged);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(616, 376);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(132, 33);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa sản phẩm";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 57);
            this.panel1.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(455, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Giá sản phẩm";
            // 
            // textGiaSP
            // 
            this.textGiaSP.Location = new System.Drawing.Point(604, 200);
            this.textGiaSP.Name = "textGiaSP";
            this.textGiaSP.Size = new System.Drawing.Size(160, 22);
            this.textGiaSP.TabIndex = 7;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(616, 310);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(132, 36);
            this.btnHuy.TabIndex = 14;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // DN_CapNhatThongTinSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.comBoxMaCN);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.textGiaSP);
            this.Controls.Add(this.textTenSP);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textSoLuong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comBoxMaSP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comBoxMaDN);
            this.Controls.Add(this.label1);
            this.Name = "DN_CapNhatThongTinSanPham";
            this.Text = "DN_CapNhatThongTinSanPham";
            this.Load += new System.EventHandler(this.DN_CapNhatThongTinSanPham_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comBoxMaDN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comBoxMaSP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textSoLuong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textTenSP;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comBoxMaCN;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textGiaSP;
        private System.Windows.Forms.Button btnHuy;
    }
}