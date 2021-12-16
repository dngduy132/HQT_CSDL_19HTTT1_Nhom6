
namespace HeThongVanChuyenHangOnl.KhachHang
{
    partial class KH_TimKiemDoanhNghiep
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
            this.label2 = new System.Windows.Forms.Label();
            this.comBoxTenDN = new System.Windows.Forms.ComboBox();
            this.comBoxQuan = new System.Windows.Forms.ComboBox();
            this.dataGridViewTimKiemDN = new System.Windows.Forms.DataGridView();
            this.btnTim = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textKetQua = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTimKiemDN)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên doanh nghiệp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quận";
            // 
            // comBoxTenDN
            // 
            this.comBoxTenDN.FormattingEnabled = true;
            this.comBoxTenDN.Location = new System.Drawing.Point(139, 66);
            this.comBoxTenDN.Name = "comBoxTenDN";
            this.comBoxTenDN.Size = new System.Drawing.Size(182, 24);
            this.comBoxTenDN.TabIndex = 2;
            // 
            // comBoxQuan
            // 
            this.comBoxQuan.FormattingEnabled = true;
            this.comBoxQuan.Location = new System.Drawing.Point(139, 102);
            this.comBoxQuan.Name = "comBoxQuan";
            this.comBoxQuan.Size = new System.Drawing.Size(182, 24);
            this.comBoxQuan.TabIndex = 2;
            // 
            // dataGridViewTimKiemDN
            // 
            this.dataGridViewTimKiemDN.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewTimKiemDN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTimKiemDN.Location = new System.Drawing.Point(12, 145);
            this.dataGridViewTimKiemDN.Name = "dataGridViewTimKiemDN";
            this.dataGridViewTimKiemDN.RowHeadersWidth = 51;
            this.dataGridViewTimKiemDN.RowTemplate.Height = 24;
            this.dataGridViewTimKiemDN.Size = new System.Drawing.Size(776, 293);
            this.dataGridViewTimKiemDN.TabIndex = 3;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(504, 69);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.TabIndex = 4;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 56);
            this.panel1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(206, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(349, 37);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tìm kiếm doanh nghiệp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(411, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kết quả";
            // 
            // textKetQua
            // 
            this.textKetQua.Location = new System.Drawing.Point(504, 103);
            this.textKetQua.Name = "textKetQua";
            this.textKetQua.Size = new System.Drawing.Size(100, 22);
            this.textKetQua.TabIndex = 7;
            // 
            // KH_TimKiemDoanhNghiep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textKetQua);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.dataGridViewTimKiemDN);
            this.Controls.Add(this.comBoxQuan);
            this.Controls.Add(this.comBoxTenDN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "KH_TimKiemDoanhNghiep";
            this.Text = "KH_TimKiemDoanhNghiep";
            this.Load += new System.EventHandler(this.KH_TimKiemDoanhNghiep_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTimKiemDN)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comBoxTenDN;
        private System.Windows.Forms.ComboBox comBoxQuan;
        private System.Windows.Forms.DataGridView dataGridViewTimKiemDN;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textKetQua;
    }
}