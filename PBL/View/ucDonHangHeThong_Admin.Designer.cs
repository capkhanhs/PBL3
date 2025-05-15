namespace PBL.View
{
    partial class ucDonHangHeThong_Admin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pn_DonHang = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cl_MaDH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_MaDC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_NgayDatHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_PhuongThucTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_GiaoThanhCong = new System.Windows.Forms.Button();
            this.btn_ChoXL = new System.Windows.Forms.Button();
            this.btn_DaXacNhan = new System.Windows.Forms.Button();
            this.btn_DangGH = new System.Windows.Forms.Button();
            this.btn_XemChiTietDonHang = new System.Windows.Forms.Button();
            this.btn_TatCaDH = new System.Windows.Forms.Button();
            this.pn_DonHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_DonHang
            // 
            this.pn_DonHang.BackColor = System.Drawing.Color.White;
            this.pn_DonHang.Controls.Add(this.dataGridView1);
            this.pn_DonHang.Location = new System.Drawing.Point(17, 85);
            this.pn_DonHang.Name = "pn_DonHang";
            this.pn_DonHang.Size = new System.Drawing.Size(1107, 509);
            this.pn_DonHang.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_MaDH,
            this.cl_MaKH,
            this.cl_MaDC,
            this.cl_NgayDatHang,
            this.cl_TrangThai,
            this.cl_PhuongThucTT});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1085, 502);
            this.dataGridView1.TabIndex = 1;
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
            this.cl_MaKH.Width = 140;
            // 
            // cl_MaDC
            // 
            this.cl_MaDC.HeaderText = "Mã địa chỉ";
            this.cl_MaDC.MinimumWidth = 6;
            this.cl_MaDC.Name = "cl_MaDC";
            this.cl_MaDC.ReadOnly = true;
            this.cl_MaDC.Width = 107;
            // 
            // cl_NgayDatHang
            // 
            this.cl_NgayDatHang.HeaderText = "Ngày đặt hàng";
            this.cl_NgayDatHang.MinimumWidth = 6;
            this.cl_NgayDatHang.Name = "cl_NgayDatHang";
            this.cl_NgayDatHang.ReadOnly = true;
            this.cl_NgayDatHang.Width = 137;
            // 
            // cl_TrangThai
            // 
            this.cl_TrangThai.HeaderText = "Trạng thái đơn hàng";
            this.cl_TrangThai.MinimumWidth = 6;
            this.cl_TrangThai.Name = "cl_TrangThai";
            this.cl_TrangThai.ReadOnly = true;
            this.cl_TrangThai.Width = 174;
            // 
            // cl_PhuongThucTT
            // 
            this.cl_PhuongThucTT.HeaderText = "Phương thức thanh toán";
            this.cl_PhuongThucTT.MinimumWidth = 6;
            this.cl_PhuongThucTT.Name = "cl_PhuongThucTT";
            this.cl_PhuongThucTT.ReadOnly = true;
            this.cl_PhuongThucTT.Width = 195;
            // 
            // btn_GiaoThanhCong
            // 
            this.btn_GiaoThanhCong.BackColor = System.Drawing.SystemColors.Control;
            this.btn_GiaoThanhCong.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_GiaoThanhCong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GiaoThanhCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GiaoThanhCong.ForeColor = System.Drawing.Color.Red;
            this.btn_GiaoThanhCong.Location = new System.Drawing.Point(615, 41);
            this.btn_GiaoThanhCong.Name = "btn_GiaoThanhCong";
            this.btn_GiaoThanhCong.Size = new System.Drawing.Size(139, 38);
            this.btn_GiaoThanhCong.TabIndex = 16;
            this.btn_GiaoThanhCong.Text = "Thành công";
            this.btn_GiaoThanhCong.UseVisualStyleBackColor = false;
            // 
            // btn_ChoXL
            // 
            this.btn_ChoXL.BackColor = System.Drawing.SystemColors.Control;
            this.btn_ChoXL.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_ChoXL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ChoXL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChoXL.ForeColor = System.Drawing.Color.Red;
            this.btn_ChoXL.Location = new System.Drawing.Point(165, 41);
            this.btn_ChoXL.Name = "btn_ChoXL";
            this.btn_ChoXL.Size = new System.Drawing.Size(139, 38);
            this.btn_ChoXL.TabIndex = 15;
            this.btn_ChoXL.Text = "Chờ xử lý";
            this.btn_ChoXL.UseVisualStyleBackColor = false;
            // 
            // btn_DaXacNhan
            // 
            this.btn_DaXacNhan.BackColor = System.Drawing.SystemColors.Control;
            this.btn_DaXacNhan.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_DaXacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DaXacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DaXacNhan.ForeColor = System.Drawing.Color.Red;
            this.btn_DaXacNhan.Location = new System.Drawing.Point(310, 41);
            this.btn_DaXacNhan.Name = "btn_DaXacNhan";
            this.btn_DaXacNhan.Size = new System.Drawing.Size(139, 38);
            this.btn_DaXacNhan.TabIndex = 14;
            this.btn_DaXacNhan.Text = "Đã xác nhận";
            this.btn_DaXacNhan.UseVisualStyleBackColor = false;
            // 
            // btn_DangGH
            // 
            this.btn_DangGH.BackColor = System.Drawing.SystemColors.Control;
            this.btn_DangGH.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_DangGH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DangGH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangGH.ForeColor = System.Drawing.Color.Red;
            this.btn_DangGH.Location = new System.Drawing.Point(455, 41);
            this.btn_DangGH.Name = "btn_DangGH";
            this.btn_DangGH.Size = new System.Drawing.Size(154, 38);
            this.btn_DangGH.TabIndex = 13;
            this.btn_DangGH.Text = "Đang giao hàng";
            this.btn_DangGH.UseVisualStyleBackColor = false;
            // 
            // btn_XemChiTietDonHang
            // 
            this.btn_XemChiTietDonHang.BackColor = System.Drawing.Color.Red;
            this.btn_XemChiTietDonHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XemChiTietDonHang.ForeColor = System.Drawing.Color.White;
            this.btn_XemChiTietDonHang.Location = new System.Drawing.Point(901, 41);
            this.btn_XemChiTietDonHang.Name = "btn_XemChiTietDonHang";
            this.btn_XemChiTietDonHang.Size = new System.Drawing.Size(220, 38);
            this.btn_XemChiTietDonHang.TabIndex = 12;
            this.btn_XemChiTietDonHang.Text = "Xem chi tiết đơn hàng";
            this.btn_XemChiTietDonHang.UseVisualStyleBackColor = false;
            // 
            // btn_TatCaDH
            // 
            this.btn_TatCaDH.BackColor = System.Drawing.SystemColors.Control;
            this.btn_TatCaDH.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_TatCaDH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TatCaDH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TatCaDH.ForeColor = System.Drawing.Color.Red;
            this.btn_TatCaDH.Location = new System.Drawing.Point(20, 41);
            this.btn_TatCaDH.Name = "btn_TatCaDH";
            this.btn_TatCaDH.Size = new System.Drawing.Size(139, 38);
            this.btn_TatCaDH.TabIndex = 11;
            this.btn_TatCaDH.Text = "Tất cả";
            this.btn_TatCaDH.UseVisualStyleBackColor = false;
            // 
            // ucDonHangHeThong_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_GiaoThanhCong);
            this.Controls.Add(this.btn_ChoXL);
            this.Controls.Add(this.btn_DaXacNhan);
            this.Controls.Add(this.btn_DangGH);
            this.Controls.Add(this.btn_XemChiTietDonHang);
            this.Controls.Add(this.btn_TatCaDH);
            this.Controls.Add(this.pn_DonHang);
            this.Name = "ucDonHangHeThong_Admin";
            this.Size = new System.Drawing.Size(1144, 609);
            this.pn_DonHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_DonHang;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_MaDH;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_MaDC;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_NgayDatHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_TrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_PhuongThucTT;
        private System.Windows.Forms.Button btn_GiaoThanhCong;
        private System.Windows.Forms.Button btn_ChoXL;
        private System.Windows.Forms.Button btn_DaXacNhan;
        private System.Windows.Forms.Button btn_DangGH;
        private System.Windows.Forms.Button btn_XemChiTietDonHang;
        private System.Windows.Forms.Button btn_TatCaDH;
    }
}
