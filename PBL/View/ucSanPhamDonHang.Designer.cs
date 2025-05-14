namespace PBL.View
{
    partial class ucSanPhamDonHang
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.lb_SoLuongSP = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.lblGiaSP = new System.Windows.Forms.Label();
            this.lblTenSanPham = new System.Windows.Forms.Label();
            this.picboxSP = new System.Windows.Forms.PictureBox();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxSP)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.lb_SoLuongSP);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.lblMoTa);
            this.panel4.Controls.Add(this.lblGiaSP);
            this.panel4.Controls.Add(this.lblTenSanPham);
            this.panel4.Controls.Add(this.picboxSP);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(837, 129);
            this.panel4.TabIndex = 11;
            // 
            // lb_SoLuongSP
            // 
            this.lb_SoLuongSP.AutoSize = true;
            this.lb_SoLuongSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SoLuongSP.Location = new System.Drawing.Point(762, 27);
            this.lb_SoLuongSP.Name = "lb_SoLuongSP";
            this.lb_SoLuongSP.Size = new System.Drawing.Size(62, 16);
            this.lb_SoLuongSP.TabIndex = 10;
            this.lb_SoLuongSP.Text = "soluong";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(701, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Số lượng:";
            // 
            // lblMoTa
            // 
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.Location = new System.Drawing.Point(157, 41);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(40, 16);
            this.lblMoTa.TabIndex = 8;
            this.lblMoTa.Text = "Mô tả";
            // 
            // lblGiaSP
            // 
            this.lblGiaSP.AutoSize = true;
            this.lblGiaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaSP.Location = new System.Drawing.Point(699, 3);
            this.lblGiaSP.Name = "lblGiaSP";
            this.lblGiaSP.Size = new System.Drawing.Size(120, 25);
            this.lblGiaSP.TabIndex = 7;
            this.lblGiaSP.Text = "25.999.000";
            // 
            // lblTenSanPham
            // 
            this.lblTenSanPham.AutoSize = true;
            this.lblTenSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSanPham.Location = new System.Drawing.Point(155, 3);
            this.lblTenSanPham.Name = "lblTenSanPham";
            this.lblTenSanPham.Size = new System.Drawing.Size(156, 25);
            this.lblTenSanPham.TabIndex = 1;
            this.lblTenSanPham.Text = "Tên Sản Phẩm";
            // 
            // picboxSP
            // 
            this.picboxSP.ErrorImage = null;
            this.picboxSP.Image = global::PBL.Properties.Resources.user_avatar;
            this.picboxSP.Location = new System.Drawing.Point(3, 3);
            this.picboxSP.Name = "picboxSP";
            this.picboxSP.Size = new System.Drawing.Size(146, 123);
            this.picboxSP.TabIndex = 0;
            this.picboxSP.TabStop = false;
            // 
            // ucSanPhamDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel4);
            this.Name = "ucSanPhamDonHang";
            this.Size = new System.Drawing.Size(844, 134);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxSP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lb_SoLuongSP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.Label lblGiaSP;
        private System.Windows.Forms.Label lblTenSanPham;
        private System.Windows.Forms.PictureBox picboxSP;
    }
}
