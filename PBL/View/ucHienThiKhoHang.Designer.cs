namespace PBL.View
{
    partial class ucHienThiKhoHang
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
            this.dgv_KhoHang = new System.Windows.Forms.DataGridView();
            this.CL_MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CL_TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CL_GiaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CL_SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CL_NgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CL_NgayXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KhoHang)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_KhoHang
            // 
            this.dgv_KhoHang.ColumnHeadersHeight = 29;
            this.dgv_KhoHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_KhoHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CL_MaSP,
            this.CL_TenSP,
            this.CL_GiaSP,
            this.CL_SoLuong,
            this.CL_NgayNhap,
            this.CL_NgayXuat});
            this.dgv_KhoHang.Location = new System.Drawing.Point(3, 0);
            this.dgv_KhoHang.Name = "dgv_KhoHang";
            this.dgv_KhoHang.ReadOnly = true;
            this.dgv_KhoHang.RowHeadersWidth = 51;
            this.dgv_KhoHang.RowTemplate.Height = 24;
            this.dgv_KhoHang.Size = new System.Drawing.Size(1138, 603);
            this.dgv_KhoHang.TabIndex = 0;
            // 
            // CL_MaSP
            // 
            this.CL_MaSP.HeaderText = "Mã sản phẩm";
            this.CL_MaSP.MinimumWidth = 6;
            this.CL_MaSP.Name = "CL_MaSP";
            this.CL_MaSP.Width = 125;
            // 
            // CL_TenSP
            // 
            this.CL_TenSP.HeaderText = "Tên sản phẩm";
            this.CL_TenSP.MinimumWidth = 6;
            this.CL_TenSP.Name = "CL_TenSP";
            this.CL_TenSP.ReadOnly = true;
            this.CL_TenSP.Width = 125;
            // 
            // CL_GiaSP
            // 
            this.CL_GiaSP.HeaderText = "Giá sản phẩm";
            this.CL_GiaSP.MinimumWidth = 6;
            this.CL_GiaSP.Name = "CL_GiaSP";
            this.CL_GiaSP.ReadOnly = true;
            this.CL_GiaSP.Width = 125;
            // 
            // CL_SoLuong
            // 
            this.CL_SoLuong.HeaderText = "Số lượng";
            this.CL_SoLuong.MinimumWidth = 6;
            this.CL_SoLuong.Name = "CL_SoLuong";
            this.CL_SoLuong.ReadOnly = true;
            this.CL_SoLuong.Width = 125;
            // 
            // CL_NgayNhap
            // 
            this.CL_NgayNhap.HeaderText = "Ngày nhập kho";
            this.CL_NgayNhap.MinimumWidth = 6;
            this.CL_NgayNhap.Name = "CL_NgayNhap";
            this.CL_NgayNhap.ReadOnly = true;
            this.CL_NgayNhap.Width = 125;
            // 
            // CL_NgayXuat
            // 
            this.CL_NgayXuat.HeaderText = "Ngày xuất kho";
            this.CL_NgayXuat.MinimumWidth = 6;
            this.CL_NgayXuat.Name = "CL_NgayXuat";
            this.CL_NgayXuat.ReadOnly = true;
            this.CL_NgayXuat.Width = 125;
            // 
            // ucHienThiKhoHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_KhoHang);
            this.Name = "ucHienThiKhoHang";
            this.Size = new System.Drawing.Size(1144, 609);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KhoHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn CL_MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn CL_TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn CL_GiaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn CL_SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn CL_NgayNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn CL_NgayXuat;
        internal System.Windows.Forms.DataGridView dgv_KhoHang;
    }
}
