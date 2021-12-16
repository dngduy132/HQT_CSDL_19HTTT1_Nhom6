
namespace HeThongVanChuyenHangOnl.QuanTri
{
    partial class QT_CapNhatThongTinDoanhNghiep
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
            this.comBoxMaDN = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.dataGridViewCapNhatThongTinDN = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comBoxQuan = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCapNhatThongTinDN)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comBoxMaDN
            // 
            this.comBoxMaDN.FormattingEnabled = true;
            this.comBoxMaDN.Location = new System.Drawing.Point(183, 61);
            this.comBoxMaDN.Name = "comBoxMaDN";
            this.comBoxMaDN.Size = new System.Drawing.Size(160, 24);
            this.comBoxMaDN.TabIndex = 1;
            this.comBoxMaDN.SelectedIndexChanged += new System.EventHandler(this.comBoxMaDN_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã doanh nghiệp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Quận";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(633, 73);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(107, 34);
            this.btnCapNhat.TabIndex = 6;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // dataGridViewCapNhatThongTinDN
            // 
            this.dataGridViewCapNhatThongTinDN.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridViewCapNhatThongTinDN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCapNhatThongTinDN.Location = new System.Drawing.Point(24, 144);
            this.dataGridViewCapNhatThongTinDN.Name = "dataGridViewCapNhatThongTinDN";
            this.dataGridViewCapNhatThongTinDN.RowHeadersWidth = 51;
            this.dataGridViewCapNhatThongTinDN.RowTemplate.Height = 24;
            this.dataGridViewCapNhatThongTinDN.Size = new System.Drawing.Size(764, 294);
            this.dataGridViewCapNhatThongTinDN.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(160, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(479, 37);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cập nhật thông tin doanh nghiệp";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 55);
            this.panel1.TabIndex = 9;
            // 
            // comBoxQuan
            // 
            this.comBoxQuan.FormattingEnabled = true;
            this.comBoxQuan.Location = new System.Drawing.Point(183, 102);
            this.comBoxQuan.Name = "comBoxQuan";
            this.comBoxQuan.Size = new System.Drawing.Size(160, 24);
            this.comBoxQuan.TabIndex = 10;
            // 
            // QT_CapNhatThongTinDoanhNghiep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comBoxQuan);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewCapNhatThongTinDN);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comBoxMaDN);
            this.Name = "QT_CapNhatThongTinDoanhNghiep";
            this.Text = "QT_CapNhatThongTinDoanhNghiep";
            this.Load += new System.EventHandler(this.QT_CapNhatThongTinDoanhNghiep_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCapNhatThongTinDN)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comBoxMaDN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.DataGridView dataGridViewCapNhatThongTinDN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comBoxQuan;
    }
}