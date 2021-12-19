
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KH_TimKiemSanPham));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comBoxTenDN = new System.Windows.Forms.ComboBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.dataGridViewTimSP = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.textKetQua = new System.Windows.Forms.TextBox();
            this.comBoxTenSP = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTimSP)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(242, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm kiếm sản phẩm";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên doanh nghiệp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên sản phẩm";
            // 
            // comBoxTenDN
            // 
            this.comBoxTenDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBoxTenDN.FormattingEnabled = true;
            this.comBoxTenDN.Location = new System.Drawing.Point(193, 68);
            this.comBoxTenDN.Name = "comBoxTenDN";
            this.comBoxTenDN.Size = new System.Drawing.Size(150, 28);
            this.comBoxTenDN.TabIndex = 3;
            this.comBoxTenDN.SelectedIndexChanged += new System.EventHandler(this.comBoxTenDN_SelectedIndexChanged);
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(84)))), ((int)(((byte)(3)))));
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.ForeColor = System.Drawing.Color.White;
            this.btnTim.Location = new System.Drawing.Point(610, 63);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(100, 38);
            this.btnTim.TabIndex = 5;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // dataGridViewTimSP
            // 
            this.dataGridViewTimSP.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(243)))), ((int)(((byte)(224)))));
            this.dataGridViewTimSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTimSP.DefaultCellStyle = dataGridViewCellStyle1;
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
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(431, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Số lượng sản phẩm";
            // 
            // textKetQua
            // 
            this.textKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textKetQua.Location = new System.Drawing.Point(610, 110);
            this.textKetQua.Name = "textKetQua";
            this.textKetQua.Size = new System.Drawing.Size(100, 27);
            this.textKetQua.TabIndex = 8;
            // 
            // comBoxTenSP
            // 
            this.comBoxTenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBoxTenSP.FormattingEnabled = true;
            this.comBoxTenSP.Location = new System.Drawing.Point(193, 111);
            this.comBoxTenSP.Name = "comBoxTenSP";
            this.comBoxTenSP.Size = new System.Drawing.Size(150, 28);
            this.comBoxTenSP.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(147)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 57);
            this.panel2.TabIndex = 20;
            // 
            // KH_TimKiemSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(243)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.comBoxTenSP);
            this.Controls.Add(this.textKetQua);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridViewTimSP);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.comBoxTenDN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KH_TimKiemSanPham";
            this.Text = "KH_TimKiemSanPham";
            this.Load += new System.EventHandler(this.KH_TimKiemSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTimSP)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comBoxTenDN;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.DataGridView dataGridViewTimSP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textKetQua;
        private System.Windows.Forms.ComboBox comBoxTenSP;
        private System.Windows.Forms.Panel panel2;
    }
}