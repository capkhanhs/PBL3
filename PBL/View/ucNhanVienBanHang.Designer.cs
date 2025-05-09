namespace PBL.View
{
    partial class ucNhanVienBanHang
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
            this.pn_DonHang = new System.Windows.Forms.Panel();
            this.btn_DonHangChoXuLy = new System.Windows.Forms.Button();
            this.btn_DonHangDaXuLy = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_XemChiTiet = new System.Windows.Forms.Button();
            this.btn_HuyDonHang = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_SoLuongDonHang = new System.Windows.Forms.Label();
            this.cl_MaDH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_GiaTri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_NgayDatHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTP_NgayHienTai = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_DonHang
            // 
            this.pn_DonHang.Location = new System.Drawing.Point(135, 71);
            this.pn_DonHang.Name = "pn_DonHang";
            this.pn_DonHang.Size = new System.Drawing.Size(875, 450);
            this.pn_DonHang.TabIndex = 0;
            // 
            // btn_DonHangChoXuLy
            // 
            this.btn_DonHangChoXuLy.BackColor = System.Drawing.Color.Silver;
            this.btn_DonHangChoXuLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DonHangChoXuLy.ForeColor = System.Drawing.Color.Black;
            this.btn_DonHangChoXuLy.Location = new System.Drawing.Point(135, 26);
            this.btn_DonHangChoXuLy.Name = "btn_DonHangChoXuLy";
            this.btn_DonHangChoXuLy.Size = new System.Drawing.Size(184, 43);
            this.btn_DonHangChoXuLy.TabIndex = 1;
            this.btn_DonHangChoXuLy.Text = "Chưa xử lý";
            this.btn_DonHangChoXuLy.UseVisualStyleBackColor = false;
            // 
            // btn_DonHangDaXuLy
            // 
            this.btn_DonHangDaXuLy.BackColor = System.Drawing.Color.Silver;
            this.btn_DonHangDaXuLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DonHangDaXuLy.ForeColor = System.Drawing.Color.Black;
            this.btn_DonHangDaXuLy.Location = new System.Drawing.Point(325, 26);
            this.btn_DonHangDaXuLy.Name = "btn_DonHangDaXuLy";
            this.btn_DonHangDaXuLy.Size = new System.Drawing.Size(184, 43);
            this.btn_DonHangDaXuLy.TabIndex = 2;
            this.btn_DonHangDaXuLy.Text = "Đã xử lý";
            this.btn_DonHangDaXuLy.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_MaDH,
            this.cl_MaKH,
            this.cl_GiaTri,
            this.cl_NgayDatHang,
            this.cl_TrangThai});
            this.dataGridView1.Location = new System.Drawing.Point(135, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(872, 443);
            this.dataGridView1.TabIndex = 0;
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
            this.btn_HuyDonHang.Click += new System.EventHandler(this.btn_HuyDonHang_Click);
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
            this.panel2.Location = new System.Drawing.Point(71, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1159, 602);
            this.panel2.TabIndex = 5;
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
            // cl_MaDH
            // 
            this.cl_MaDH.HeaderText = "Mã đơn hàng";
            this.cl_MaDH.MinimumWidth = 6;
            this.cl_MaDH.Name = "cl_MaDH";
            this.cl_MaDH.ReadOnly = true;
            this.cl_MaDH.Width = 125;
            // 
            // cl_MaKH
            // 
            this.cl_MaKH.HeaderText = "Mã khách hàng";
            this.cl_MaKH.MinimumWidth = 6;
            this.cl_MaKH.Name = "cl_MaKH";
            this.cl_MaKH.ReadOnly = true;
            this.cl_MaKH.Width = 125;
            // 
            // cl_GiaTri
            // 
            this.cl_GiaTri.HeaderText = "Tổng đơn hàng";
            this.cl_GiaTri.MinimumWidth = 6;
            this.cl_GiaTri.Name = "cl_GiaTri";
            this.cl_GiaTri.ReadOnly = true;
            this.cl_GiaTri.Width = 125;
            // 
            // cl_NgayDatHang
            // 
            this.cl_NgayDatHang.HeaderText = "Ngày đặt hàng";
            this.cl_NgayDatHang.MinimumWidth = 6;
            this.cl_NgayDatHang.Name = "cl_NgayDatHang";
            this.cl_NgayDatHang.ReadOnly = true;
            this.cl_NgayDatHang.Width = 125;
            // 
            // cl_TrangThai
            // 
            this.cl_TrangThai.HeaderText = "Trạng thái";
            this.cl_TrangThai.MinimumWidth = 6;
            this.cl_TrangThai.Name = "cl_TrangThai";
            this.cl_TrangThai.ReadOnly = true;
            this.cl_TrangThai.Width = 125;
            // 
            // DTP_NgayHienTai
            // 
            this.DTP_NgayHienTai.Location = new System.Drawing.Point(736, 39);
            this.DTP_NgayHienTai.Name = "DTP_NgayHienTai";
            this.DTP_NgayHienTai.Size = new System.Drawing.Size(200, 22);
            this.DTP_NgayHienTai.TabIndex = 5;
            // 
            // ucNhanVienBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_DonHangDaXuLy);
            this.Controls.Add(this.btn_DonHangChoXuLy);
            this.Controls.Add(this.pn_DonHang);
            this.Controls.Add(this.panel2);
            this.Name = "ucNhanVienBanHang";
            this.Size = new System.Drawing.Size(1388, 609);
            this.Load += new System.EventHandler(this.ucNhanVienBanHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_DonHang;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_DonHangChoXuLy;
        private System.Windows.Forms.Button btn_DonHangDaXuLy;
        private System.Windows.Forms.Button btn_XemChiTiet;
        private System.Windows.Forms.Button btn_HuyDonHang;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lb_SoLuongDonHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_MaDH;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_GiaTri;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_NgayDatHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_TrangThai;
        private System.Windows.Forms.DateTimePicker DTP_NgayHienTai;
    }
}
