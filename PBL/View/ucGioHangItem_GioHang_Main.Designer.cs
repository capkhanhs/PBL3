namespace PBL.View
{
    partial class ucGioHangItem_GioHang_Main
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
            this.lblMoTa = new System.Windows.Forms.Label();
            this.lblGiaSP = new System.Windows.Forms.Label();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.lblTenSanPham = new System.Windows.Forms.Label();
            this.picboxSP = new System.Windows.Forms.PictureBox();
            this.btnTang = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnGiam = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxSP)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.lblMoTa);
            this.panel4.Controls.Add(this.lblGiaSP);
            this.panel4.Controls.Add(this.txtSoluong);
            this.panel4.Controls.Add(this.lblTenSanPham);
            this.panel4.Controls.Add(this.picboxSP);
            this.panel4.Controls.Add(this.btnTang);
            this.panel4.Controls.Add(this.btnXoa);
            this.panel4.Controls.Add(this.btnGiam);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1354, 129);
            this.panel4.TabIndex = 9;
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
            this.lblGiaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaSP.Location = new System.Drawing.Point(1166, 3);
            this.lblGiaSP.Name = "lblGiaSP";
            this.lblGiaSP.Size = new System.Drawing.Size(139, 29);
            this.lblGiaSP.TabIndex = 7;
            this.lblGiaSP.Text = "25.999.000";
            this.lblGiaSP.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtSoluong
            // 
            this.txtSoluong.Location = new System.Drawing.Point(1245, 99);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(22, 22);
            this.txtSoluong.TabIndex = 6;
            this.txtSoluong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTenSanPham
            // 
            this.lblTenSanPham.AutoSize = true;
            this.lblTenSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSanPham.Location = new System.Drawing.Point(155, 3);
            this.lblTenSanPham.Name = "lblTenSanPham";
            this.lblTenSanPham.Size = new System.Drawing.Size(184, 29);
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
            // btnTang
            // 
            this.btnTang.Location = new System.Drawing.Point(1273, 99);
            this.btnTang.Name = "btnTang";
            this.btnTang.Size = new System.Drawing.Size(22, 22);
            this.btnTang.TabIndex = 5;
            this.btnTang.Text = "+";
            this.btnTang.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.Control;
            this.btnXoa.Location = new System.Drawing.Point(1120, 98);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(91, 23);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.button11_Click);
            // 
            // btnGiam
            // 
            this.btnGiam.Location = new System.Drawing.Point(1217, 98);
            this.btnGiam.Name = "btnGiam";
            this.btnGiam.Size = new System.Drawing.Size(22, 22);
            this.btnGiam.TabIndex = 3;
            this.btnGiam.Text = "-";
            this.btnGiam.UseVisualStyleBackColor = true;
            // 
            // ucGioHangItem_GioHang_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel4);
            this.Name = "ucGioHangItem_GioHang_Main";
            this.Size = new System.Drawing.Size(1360, 138);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxSP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblGiaSP;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.Button btnTang;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnGiam;
        private System.Windows.Forms.Label lblTenSanPham;
        private System.Windows.Forms.PictureBox picboxSP;
        private System.Windows.Forms.Label lblMoTa;
    }
}
