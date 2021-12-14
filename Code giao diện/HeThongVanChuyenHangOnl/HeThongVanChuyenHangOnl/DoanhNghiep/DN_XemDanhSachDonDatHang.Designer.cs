
namespace HeThongVanChuyenHangOnl.DoanhNghiep
{
    partial class DN_XemDanhSachDonDatHang
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
            this.dataGridViewDonHang = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.Enter_btn = new System.Windows.Forms.Button();
            this.slDonDatHang_tb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDonHang)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã doanh nghiệp";
            // 
            // comBoxMaDN
            // 
            this.comBoxMaDN.FormattingEnabled = true;
            this.comBoxMaDN.Location = new System.Drawing.Point(162, 76);
            this.comBoxMaDN.Name = "comBoxMaDN";
            this.comBoxMaDN.Size = new System.Drawing.Size(173, 24);
            this.comBoxMaDN.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(596, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Thống kê đơn đặt hàng của doanh nghiệp";
            // 
            // dataGridViewDonHang
            // 
            this.dataGridViewDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDonHang.Location = new System.Drawing.Point(12, 122);
            this.dataGridViewDonHang.Name = "dataGridViewDonHang";
            this.dataGridViewDonHang.RowHeadersWidth = 51;
            this.dataGridViewDonHang.RowTemplate.Height = 24;
            this.dataGridViewDonHang.Size = new System.Drawing.Size(823, 360);
            this.dataGridViewDonHang.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(847, 57);
            this.panel1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(592, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số lượng đơn hàng:";
            // 
            // Enter_btn
            // 
            this.Enter_btn.Location = new System.Drawing.Point(429, 76);
            this.Enter_btn.Name = "Enter_btn";
            this.Enter_btn.Size = new System.Drawing.Size(75, 27);
            this.Enter_btn.TabIndex = 6;
            this.Enter_btn.Text = "Enter";
            this.Enter_btn.UseVisualStyleBackColor = true;
            this.Enter_btn.Click += new System.EventHandler(this.Enter_btn_Click);
            // 
            // slDonDatHang_tb
            // 
            this.slDonDatHang_tb.Location = new System.Drawing.Point(730, 76);
            this.slDonDatHang_tb.Name = "slDonDatHang_tb";
            this.slDonDatHang_tb.Size = new System.Drawing.Size(56, 22);
            this.slDonDatHang_tb.TabIndex = 7;
            // 
            // DN_XemDanhSachDonDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 494);
            this.Controls.Add(this.slDonDatHang_tb);
            this.Controls.Add(this.Enter_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewDonHang);
            this.Controls.Add(this.comBoxMaDN);
            this.Controls.Add(this.label1);
            this.Name = "DN_XemDanhSachDonDatHang";
            this.Text = "DN_XemDanhSachDonDatHang";
            this.Load += new System.EventHandler(this.DN_XemDanhSachDonDatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDonHang)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comBoxMaDN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewDonHang;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Enter_btn;
        private System.Windows.Forms.TextBox slDonDatHang_tb;
    }
}