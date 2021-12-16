
namespace HeThongVanChuyenHangOnl.TaiXe
{
    partial class TX_NhanGiaoHang
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
            this.comBoxMaTX = new System.Windows.Forms.ComboBox();
            this.btnTimDonHang = new System.Windows.Forms.Button();
            this.btnNhanDonHang = new System.Windows.Forms.Button();
            this.dataGridViewNhanGiaoHang = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.comBoxMaDon = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhanGiaoHang)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 55);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(264, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhận giao hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã tài xế";
            // 
            // comBoxMaTX
            // 
            this.comBoxMaTX.FormattingEnabled = true;
            this.comBoxMaTX.Location = new System.Drawing.Point(121, 82);
            this.comBoxMaTX.Name = "comBoxMaTX";
            this.comBoxMaTX.Size = new System.Drawing.Size(132, 24);
            this.comBoxMaTX.TabIndex = 2;
            // 
            // btnTimDonHang
            // 
            this.btnTimDonHang.Location = new System.Drawing.Point(121, 112);
            this.btnTimDonHang.Name = "btnTimDonHang";
            this.btnTimDonHang.Size = new System.Drawing.Size(144, 33);
            this.btnTimDonHang.TabIndex = 3;
            this.btnTimDonHang.Text = "Tìm đơn hàng";
            this.btnTimDonHang.UseVisualStyleBackColor = true;
            this.btnTimDonHang.Click += new System.EventHandler(this.btnTimDonHang_Click);
            // 
            // btnNhanDonHang
            // 
            this.btnNhanDonHang.Location = new System.Drawing.Point(532, 112);
            this.btnNhanDonHang.Name = "btnNhanDonHang";
            this.btnNhanDonHang.Size = new System.Drawing.Size(151, 33);
            this.btnNhanDonHang.TabIndex = 4;
            this.btnNhanDonHang.Text = "Nhận đơn hàng";
            this.btnNhanDonHang.UseVisualStyleBackColor = true;
            this.btnNhanDonHang.Click += new System.EventHandler(this.btnNhanDonHang_Click);
            // 
            // dataGridViewNhanGiaoHang
            // 
            this.dataGridViewNhanGiaoHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNhanGiaoHang.Location = new System.Drawing.Point(13, 161);
            this.dataGridViewNhanGiaoHang.Name = "dataGridViewNhanGiaoHang";
            this.dataGridViewNhanGiaoHang.RowHeadersWidth = 51;
            this.dataGridViewNhanGiaoHang.RowTemplate.Height = 24;
            this.dataGridViewNhanGiaoHang.Size = new System.Drawing.Size(775, 277);
            this.dataGridViewNhanGiaoHang.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(424, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mã đơn hàng";
            // 
            // comBoxMaDon
            // 
            this.comBoxMaDon.FormattingEnabled = true;
            this.comBoxMaDon.Location = new System.Drawing.Point(532, 79);
            this.comBoxMaDon.Name = "comBoxMaDon";
            this.comBoxMaDon.Size = new System.Drawing.Size(132, 24);
            this.comBoxMaDon.TabIndex = 7;
            // 
            // TX_NhanGiaoHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comBoxMaDon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewNhanGiaoHang);
            this.Controls.Add(this.btnNhanDonHang);
            this.Controls.Add(this.btnTimDonHang);
            this.Controls.Add(this.comBoxMaTX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "TX_NhanGiaoHang";
            this.Text = "TX_NhanGiaoHang";
            this.Load += new System.EventHandler(this.TX_NhanGiaoHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhanGiaoHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comBoxMaTX;
        private System.Windows.Forms.Button btnTimDonHang;
        private System.Windows.Forms.Button btnNhanDonHang;
        private System.Windows.Forms.DataGridView dataGridViewNhanGiaoHang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comBoxMaDon;
    }
}