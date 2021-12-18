
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TX_NhanGiaoHang));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comBoxMaTX = new System.Windows.Forms.ComboBox();
            this.btnTimDonHang = new System.Windows.Forms.Button();
            this.btnNhanDonHang = new System.Windows.Forms.Button();
            this.dataGridViewNhanGiaoHang = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.comBoxMaDon = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhanGiaoHang)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(278, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhận giao hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã tài xế";
            // 
            // comBoxMaTX
            // 
            this.comBoxMaTX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBoxMaTX.FormattingEnabled = true;
            this.comBoxMaTX.Location = new System.Drawing.Point(187, 75);
            this.comBoxMaTX.Name = "comBoxMaTX";
            this.comBoxMaTX.Size = new System.Drawing.Size(174, 28);
            this.comBoxMaTX.TabIndex = 2;
            // 
            // btnTimDonHang
            // 
            this.btnTimDonHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(84)))), ((int)(((byte)(3)))));
            this.btnTimDonHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimDonHang.ForeColor = System.Drawing.Color.White;
            this.btnTimDonHang.Location = new System.Drawing.Point(187, 112);
            this.btnTimDonHang.Name = "btnTimDonHang";
            this.btnTimDonHang.Size = new System.Drawing.Size(174, 43);
            this.btnTimDonHang.TabIndex = 3;
            this.btnTimDonHang.Text = "Tìm đơn hàng";
            this.btnTimDonHang.UseVisualStyleBackColor = false;
            this.btnTimDonHang.Click += new System.EventHandler(this.btnTimDonHang_Click);
            // 
            // btnNhanDonHang
            // 
            this.btnNhanDonHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(84)))), ((int)(((byte)(3)))));
            this.btnNhanDonHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanDonHang.ForeColor = System.Drawing.Color.White;
            this.btnNhanDonHang.Location = new System.Drawing.Point(532, 112);
            this.btnNhanDonHang.Name = "btnNhanDonHang";
            this.btnNhanDonHang.Size = new System.Drawing.Size(189, 43);
            this.btnNhanDonHang.TabIndex = 4;
            this.btnNhanDonHang.Text = "Nhận đơn hàng";
            this.btnNhanDonHang.UseVisualStyleBackColor = false;
            this.btnNhanDonHang.Click += new System.EventHandler(this.btnNhanDonHang_Click);
            // 
            // dataGridViewNhanGiaoHang
            // 
            this.dataGridViewNhanGiaoHang.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(243)))), ((int)(((byte)(224)))));
            this.dataGridViewNhanGiaoHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewNhanGiaoHang.DefaultCellStyle = dataGridViewCellStyle1;
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
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(424, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mã đơn hàng";
            // 
            // comBoxMaDon
            // 
            this.comBoxMaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBoxMaDon.FormattingEnabled = true;
            this.comBoxMaDon.Location = new System.Drawing.Point(532, 79);
            this.comBoxMaDon.Name = "comBoxMaDon";
            this.comBoxMaDon.Size = new System.Drawing.Size(189, 28);
            this.comBoxMaDon.TabIndex = 7;
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
            this.panel1.TabIndex = 15;
            // 
            // TX_NhanGiaoHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(243)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comBoxMaDon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewNhanGiaoHang);
            this.Controls.Add(this.btnNhanDonHang);
            this.Controls.Add(this.btnTimDonHang);
            this.Controls.Add(this.comBoxMaTX);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TX_NhanGiaoHang";
            this.Text = "TX_NhanGiaoHang";
            this.Load += new System.EventHandler(this.TX_NhanGiaoHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhanGiaoHang)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comBoxMaTX;
        private System.Windows.Forms.Button btnTimDonHang;
        private System.Windows.Forms.Button btnNhanDonHang;
        private System.Windows.Forms.DataGridView dataGridViewNhanGiaoHang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comBoxMaDon;
        private System.Windows.Forms.Panel panel1;
    }
}