namespace PBL.View
{
    partial class ucXemChiTietDonHang
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
            this.txt_TrangThaiDonHang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_TongSP = new System.Windows.Forms.Label();
            this.lb_TongDonHang = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.flpn_HienThiDonHang = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_CapNhatTrangThai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_TrangThaiDonHang
            // 
            this.txt_TrangThaiDonHang.Location = new System.Drawing.Point(458, 401);
            this.txt_TrangThaiDonHang.Name = "txt_TrangThaiDonHang";
            this.txt_TrangThaiDonHang.Size = new System.Drawing.Size(171, 22);
            this.txt_TrangThaiDonHang.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(370, 408);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Trạng thái:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 408);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Tổng sản phẩm:";
            // 
            // lb_TongSP
            // 
            this.lb_TongSP.AutoSize = true;
            this.lb_TongSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TongSP.Location = new System.Drawing.Point(114, 408);
            this.lb_TongSP.Name = "lb_TongSP";
            this.lb_TongSP.Size = new System.Drawing.Size(15, 16);
            this.lb_TongSP.TabIndex = 16;
            this.lb_TongSP.Text = "4";
            // 
            // lb_TongDonHang
            // 
            this.lb_TongDonHang.AutoSize = true;
            this.lb_TongDonHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TongDonHang.Location = new System.Drawing.Point(274, 407);
            this.lb_TongDonHang.Name = "lb_TongDonHang";
            this.lb_TongDonHang.Size = new System.Drawing.Size(79, 16);
            this.lb_TongDonHang.TabIndex = 18;
            this.lb_TongDonHang.Text = "30.000.000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(174, 407);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Tổng đơn hàng:";
            // 
            // flpn_HienThiDonHang
            // 
            this.flpn_HienThiDonHang.BackColor = System.Drawing.Color.White;
            this.flpn_HienThiDonHang.Location = new System.Drawing.Point(4, 4);
            this.flpn_HienThiDonHang.Name = "flpn_HienThiDonHang";
            this.flpn_HienThiDonHang.Size = new System.Drawing.Size(829, 391);
            this.flpn_HienThiDonHang.TabIndex = 19;
            // 
            // btn_CapNhatTrangThai
            // 
            this.btn_CapNhatTrangThai.BackColor = System.Drawing.Color.Red;
            this.btn_CapNhatTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CapNhatTrangThai.ForeColor = System.Drawing.Color.White;
            this.btn_CapNhatTrangThai.Location = new System.Drawing.Point(660, 401);
            this.btn_CapNhatTrangThai.Name = "btn_CapNhatTrangThai";
            this.btn_CapNhatTrangThai.Size = new System.Drawing.Size(173, 28);
            this.btn_CapNhatTrangThai.TabIndex = 20;
            this.btn_CapNhatTrangThai.Text = "Cập nhật";
            this.btn_CapNhatTrangThai.UseVisualStyleBackColor = false;
            // 
            // ucXemChiTietDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_CapNhatTrangThai);
            this.Controls.Add(this.flpn_HienThiDonHang);
            this.Controls.Add(this.lb_TongDonHang);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lb_TongSP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_TrangThaiDonHang);
            this.Controls.Add(this.label2);
            this.Name = "ucXemChiTietDonHang";
            this.Size = new System.Drawing.Size(851, 438);
            this.Load += new System.EventHandler(this.ucXemChiTietDonHang_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_TrangThaiDonHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_TongSP;
        private System.Windows.Forms.Label lb_TongDonHang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FlowLayoutPanel flpn_HienThiDonHang;
        private System.Windows.Forms.Button btn_CapNhatTrangThai;
    }
}
