﻿namespace PBL.View
{
    partial class ucAdmin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_DonHang = new System.Windows.Forms.Button();
            this.btn_KhoHang = new System.Windows.Forms.Button();
            this.btn_SanPham = new System.Windows.Forms.Button();
            this.btn_DoanhSo = new System.Windows.Forms.Button();
            this.btn_TaiKhoan = new System.Windows.Forms.Button();
            this.flpn_HienThi = new System.Windows.Forms.FlowLayoutPanel();
            this.btnThemSP = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.btnThemSP);
            this.panel1.Controls.Add(this.btn_DonHang);
            this.panel1.Controls.Add(this.btn_KhoHang);
            this.panel1.Controls.Add(this.btn_SanPham);
            this.panel1.Controls.Add(this.btn_DoanhSo);
            this.panel1.Controls.Add(this.btn_TaiKhoan);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 609);
            this.panel1.TabIndex = 0;
            // 
            // btn_DonHang
            // 
            this.btn_DonHang.Location = new System.Drawing.Point(0, 205);
            this.btn_DonHang.Name = "btn_DonHang";
            this.btn_DonHang.Size = new System.Drawing.Size(238, 46);
            this.btn_DonHang.TabIndex = 13;
            this.btn_DonHang.Text = "Đơn hàng";
            this.btn_DonHang.UseVisualStyleBackColor = true;
            this.btn_DonHang.Click += new System.EventHandler(this.btn_DonHang_Click);
            // 
            // btn_KhoHang
            // 
            this.btn_KhoHang.Location = new System.Drawing.Point(0, 153);
            this.btn_KhoHang.Name = "btn_KhoHang";
            this.btn_KhoHang.Size = new System.Drawing.Size(238, 46);
            this.btn_KhoHang.TabIndex = 12;
            this.btn_KhoHang.Text = "Kho hàng";
            this.btn_KhoHang.UseVisualStyleBackColor = true;
            this.btn_KhoHang.Click += new System.EventHandler(this.btn_KhoHang_Click);
            // 
            // btn_SanPham
            // 
            this.btn_SanPham.Location = new System.Drawing.Point(0, 3);
            this.btn_SanPham.Name = "btn_SanPham";
            this.btn_SanPham.Size = new System.Drawing.Size(238, 44);
            this.btn_SanPham.TabIndex = 9;
            this.btn_SanPham.Text = "Sản phẩm";
            this.btn_SanPham.UseVisualStyleBackColor = true;
            this.btn_SanPham.Click += new System.EventHandler(this.btn_SanPham_Click);
            // 
            // btn_DoanhSo
            // 
            this.btn_DoanhSo.Location = new System.Drawing.Point(0, 257);
            this.btn_DoanhSo.Name = "btn_DoanhSo";
            this.btn_DoanhSo.Size = new System.Drawing.Size(238, 46);
            this.btn_DoanhSo.TabIndex = 11;
            this.btn_DoanhSo.Text = "Doanh số";
            this.btn_DoanhSo.UseVisualStyleBackColor = true;
            this.btn_DoanhSo.Click += new System.EventHandler(this.btn_DoanhSo_Click);
            // 
            // btn_TaiKhoan
            // 
            this.btn_TaiKhoan.Location = new System.Drawing.Point(0, 103);
            this.btn_TaiKhoan.Name = "btn_TaiKhoan";
            this.btn_TaiKhoan.Size = new System.Drawing.Size(238, 44);
            this.btn_TaiKhoan.TabIndex = 10;
            this.btn_TaiKhoan.Text = "Tài khoản";
            this.btn_TaiKhoan.UseVisualStyleBackColor = true;
            this.btn_TaiKhoan.Click += new System.EventHandler(this.btn_TaiKhoan_Click);
            // 
            // flpn_HienThi
            // 
            this.flpn_HienThi.Location = new System.Drawing.Point(244, 0);
            this.flpn_HienThi.Name = "flpn_HienThi";
            this.flpn_HienThi.Size = new System.Drawing.Size(1144, 609);
            this.flpn_HienThi.TabIndex = 1;
            // 
            // btnThemSP
            // 
            this.btnThemSP.Location = new System.Drawing.Point(0, 53);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(238, 44);
            this.btnThemSP.TabIndex = 14;
            this.btnThemSP.Text = "Thêm Sản Phẩm";
            this.btnThemSP.UseVisualStyleBackColor = true;
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);
            // 
            // ucAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flpn_HienThi);
            this.Controls.Add(this.panel1);
            this.Name = "ucAdmin";
            this.Size = new System.Drawing.Size(1388, 609);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flpn_HienThi;
        private System.Windows.Forms.Button btn_DonHang;
        private System.Windows.Forms.Button btn_KhoHang;
        private System.Windows.Forms.Button btn_SanPham;
        private System.Windows.Forms.Button btn_DoanhSo;
        private System.Windows.Forms.Button btn_TaiKhoan;
        private System.Windows.Forms.Button btnThemSP;
    }
}
