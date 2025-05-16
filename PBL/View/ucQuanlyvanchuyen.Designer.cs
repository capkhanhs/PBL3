namespace PBL.View
{
    partial class ucQuanlyvanchuyen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_HuyDonHang = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDanggiao = new System.Windows.Forms.Button();
            this.btnDaxacnhan = new System.Windows.Forms.Button();
            this.pn_DonHang = new System.Windows.Forms.Panel();
            this.btn_XemChiTiet = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DTP_NgayHienTai = new System.Windows.Forms.DateTimePicker();
            this.lb_SoLuongDonHang = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_HuyDonHang
            // 
            this.btn_HuyDonHang.BackColor = System.Drawing.Color.Red;
            this.btn_HuyDonHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HuyDonHang.ForeColor = System.Drawing.Color.White;
            this.btn_HuyDonHang.Location = new System.Drawing.Point(945, 120);
            this.btn_HuyDonHang.Name = "btn_HuyDonHang";
            this.btn_HuyDonHang.Size = new System.Drawing.Size(184, 43);
            this.btn_HuyDonHang.TabIndex = 4;
            this.btn_HuyDonHang.Text = "Hủy đơn hàng";
            this.btn_HuyDonHang.UseVisualStyleBackColor = false;
            this.btn_HuyDonHang.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(67, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(872, 443);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnDanggiao
            // 
            this.btnDanggiao.BackColor = System.Drawing.Color.Silver;
            this.btnDanggiao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanggiao.ForeColor = System.Drawing.Color.Black;
            this.btnDanggiao.Location = new System.Drawing.Point(257, 25);
            this.btnDanggiao.Name = "btnDanggiao";
            this.btnDanggiao.Size = new System.Drawing.Size(184, 43);
            this.btnDanggiao.TabIndex = 9;
            this.btnDanggiao.Text = "Đang giao hàng";
            this.btnDanggiao.UseVisualStyleBackColor = false;
            this.btnDanggiao.Click += new System.EventHandler(this.btnDanggiao_Click);
            // 
            // btnDaxacnhan
            // 
            this.btnDaxacnhan.BackColor = System.Drawing.Color.Silver;
            this.btnDaxacnhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDaxacnhan.ForeColor = System.Drawing.Color.Black;
            this.btnDaxacnhan.Location = new System.Drawing.Point(67, 25);
            this.btnDaxacnhan.Name = "btnDaxacnhan";
            this.btnDaxacnhan.Size = new System.Drawing.Size(184, 43);
            this.btnDaxacnhan.TabIndex = 8;
            this.btnDaxacnhan.Text = "Đã xác nhận";
            this.btnDaxacnhan.UseVisualStyleBackColor = false;
            this.btnDaxacnhan.Click += new System.EventHandler(this.btnDaxacnhan_Click);
            // 
            // pn_DonHang
            // 
            this.pn_DonHang.Location = new System.Drawing.Point(67, 70);
            this.pn_DonHang.Name = "pn_DonHang";
            this.pn_DonHang.Size = new System.Drawing.Size(875, 450);
            this.pn_DonHang.TabIndex = 7;
            // 
            // btn_XemChiTiet
            // 
            this.btn_XemChiTiet.BackColor = System.Drawing.Color.Red;
            this.btn_XemChiTiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XemChiTiet.ForeColor = System.Drawing.Color.White;
            this.btn_XemChiTiet.Location = new System.Drawing.Point(945, 71);
            this.btn_XemChiTiet.Name = "btn_XemChiTiet";
            this.btn_XemChiTiet.Size = new System.Drawing.Size(184, 43);
            this.btn_XemChiTiet.TabIndex = 3;
            this.btn_XemChiTiet.Text = "Xem chi tiết";
            this.btn_XemChiTiet.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.DTP_NgayHienTai);
            this.panel2.Controls.Add(this.lb_SoLuongDonHang);
            this.panel2.Controls.Add(this.btn_HuyDonHang);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btn_XemChiTiet);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1159, 602);
            this.panel2.TabIndex = 10;
            // 
            // DTP_NgayHienTai
            // 
            this.DTP_NgayHienTai.Location = new System.Drawing.Point(736, 39);
            this.DTP_NgayHienTai.Name = "DTP_NgayHienTai";
            this.DTP_NgayHienTai.Size = new System.Drawing.Size(200, 22);
            this.DTP_NgayHienTai.TabIndex = 5;
            // 
            // lb_SoLuongDonHang
            // 
            this.lb_SoLuongDonHang.AutoSize = true;
            this.lb_SoLuongDonHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SoLuongDonHang.Location = new System.Drawing.Point(251, 534);
            this.lb_SoLuongDonHang.Name = "lb_SoLuongDonHang";
            this.lb_SoLuongDonHang.Size = new System.Drawing.Size(35, 18);
            this.lb_SoLuongDonHang.TabIndex = 2;
            this.lb_SoLuongDonHang.Text = "100";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(429, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tổng số lượng đơn hàng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 534);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tổng số lượng đơn hàng:";
            // 
            // ucQuanlyvanchuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDanggiao);
            this.Controls.Add(this.btnDaxacnhan);
            this.Controls.Add(this.pn_DonHang);
            this.Controls.Add(this.panel2);
            this.Name = "ucQuanlyvanchuyen";
            this.Size = new System.Drawing.Size(1169, 611);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_HuyDonHang;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDanggiao;
        private System.Windows.Forms.Button btnDaxacnhan;
        private System.Windows.Forms.Panel pn_DonHang;
        private System.Windows.Forms.Button btn_XemChiTiet;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker DTP_NgayHienTai;
        private System.Windows.Forms.Label lb_SoLuongDonHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
