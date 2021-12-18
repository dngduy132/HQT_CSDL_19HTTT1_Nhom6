
namespace HeThongVanChuyenHangOnl.KhachHang
{
    partial class KH_ThongTinSanPham
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
            this.dataGridViewThongTinSP = new System.Windows.Forms.DataGridView();
            this.btn_Enter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThongTinSP)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã doanh nghiệp";
            // 
            // comBoxMaDN
            // 
            this.comBoxMaDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBoxMaDN.FormattingEnabled = true;
            this.comBoxMaDN.Location = new System.Drawing.Point(175, 81);
            this.comBoxMaDN.Name = "comBoxMaDN";
            this.comBoxMaDN.Size = new System.Drawing.Size(247, 28);
            this.comBoxMaDN.TabIndex = 1;
            // 
            // dataGridViewThongTinSP
            // 
            this.dataGridViewThongTinSP.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(243)))), ((int)(((byte)(224)))));
            this.dataGridViewThongTinSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewThongTinSP.Location = new System.Drawing.Point(12, 123);
            this.dataGridViewThongTinSP.Name = "dataGridViewThongTinSP";
            this.dataGridViewThongTinSP.RowHeadersWidth = 51;
            this.dataGridViewThongTinSP.RowTemplate.Height = 24;
            this.dataGridViewThongTinSP.Size = new System.Drawing.Size(776, 315);
            this.dataGridViewThongTinSP.TabIndex = 2;
            // 
            // btn_Enter
            // 
            this.btn_Enter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(84)))), ((int)(((byte)(3)))));
            this.btn_Enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Enter.ForeColor = System.Drawing.Color.White;
            this.btn_Enter.Location = new System.Drawing.Point(609, 71);
            this.btn_Enter.Name = "btn_Enter";
            this.btn_Enter.Size = new System.Drawing.Size(92, 43);
            this.btn_Enter.TabIndex = 3;
            this.btn_Enter.Text = "Enter";
            this.btn_Enter.UseVisualStyleBackColor = false;
            this.btn_Enter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(225, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(360, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "Xem thông tin sản phẩm";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(147)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 57);
            this.panel2.TabIndex = 18;
            // 
            // KH_ThongTinSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(243)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_Enter);
            this.Controls.Add(this.dataGridViewThongTinSP);
            this.Controls.Add(this.comBoxMaDN);
            this.Controls.Add(this.label1);
            this.Name = "KH_ThongTinSanPham";
            this.Text = "KH_ThongTinSanPham";
            this.Load += new System.EventHandler(this.KH_ThongTinSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThongTinSP)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comBoxMaDN;
        private System.Windows.Forms.DataGridView dataGridViewThongTinSP;
        private System.Windows.Forms.Button btn_Enter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
    }
}