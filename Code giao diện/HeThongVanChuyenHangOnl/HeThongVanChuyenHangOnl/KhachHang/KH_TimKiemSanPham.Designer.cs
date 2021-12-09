
namespace HeThongVanChuyenHangOnl.KhachHang
{
    partial class KH_TimKiemSanPham
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
            this.comBoxTenDN = new System.Windows.Forms.ComboBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.dataGridViewTimSP = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.textKetQua = new System.Windows.Forms.TextBox();
            this.textTenSP = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTimSP)).BeginInit();
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
            this.label1.Location = new System.Drawing.Point(245, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm kiếm sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên doanh nghiệp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên sản phẩm";
            // 
            // comBoxTenDN
            // 
            this.comBoxTenDN.FormattingEnabled = true;
            this.comBoxTenDN.Location = new System.Drawing.Point(178, 76);
            this.comBoxTenDN.Name = "comBoxTenDN";
            this.comBoxTenDN.Size = new System.Drawing.Size(150, 24);
            this.comBoxTenDN.TabIndex = 3;
            this.comBoxTenDN.SelectedIndexChanged += new System.EventHandler(this.comBoxTenDN_SelectedIndexChanged);
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(590, 74);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 27);
            this.btnTim.TabIndex = 5;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // dataGridViewTimSP
            // 
            this.dataGridViewTimSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTimSP.Location = new System.Drawing.Point(12, 154);
            this.dataGridViewTimSP.Name = "dataGridViewTimSP";
            this.dataGridViewTimSP.RowHeadersWidth = 51;
            this.dataGridViewTimSP.RowTemplate.Height = 24;
            this.dataGridViewTimSP.Size = new System.Drawing.Size(776, 284);
            this.dataGridViewTimSP.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(431, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Số lượng sản phẩm";
            // 
            // textKetQua
            // 
            this.textKetQua.Location = new System.Drawing.Point(590, 111);
            this.textKetQua.Name = "textKetQua";
            this.textKetQua.Size = new System.Drawing.Size(100, 22);
            this.textKetQua.TabIndex = 8;
            // 
            // textTenSP
            // 
            this.textTenSP.Location = new System.Drawing.Point(178, 114);
            this.textTenSP.Name = "textTenSP";
            this.textTenSP.Size = new System.Drawing.Size(150, 22);
            this.textTenSP.TabIndex = 9;
            // 
            // KH_TimKiemSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textTenSP);
            this.Controls.Add(this.textKetQua);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridViewTimSP);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.comBoxTenDN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "KH_TimKiemSanPham";
            this.Text = "KH_TimKiemSanPham";
            this.Load += new System.EventHandler(this.KH_TimKiemSanPham_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTimSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comBoxTenDN;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.DataGridView dataGridViewTimSP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textKetQua;
        private System.Windows.Forms.TextBox textTenSP;
    }
}