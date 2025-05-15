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
            this.btn_xoa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.lblTenSanPham = new System.Windows.Forms.Label();
            this.picboxSP = new System.Windows.Forms.PictureBox();
            this.btnTang = new System.Windows.Forms.Button();
            this.btnGiam = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxSP)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.btn_xoa);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.txt_soluong);
            this.panel4.Controls.Add(this.lblMoTa);
            this.panel4.Controls.Add(this.lblTenSanPham);
            this.panel4.Controls.Add(this.picboxSP);
            this.panel4.Controls.Add(this.btnTang);
            this.panel4.Controls.Add(this.btnGiam);
            this.panel4.Location = new System.Drawing.Point(3, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1354, 129);
            this.panel4.TabIndex = 9;
            // 
            // btn_xoa
            // 
            this.btn_xoa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_xoa.ForeColor = System.Drawing.Color.Red;
            this.btn_xoa.Location = new System.Drawing.Point(1259, 50);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 29);
            this.btn_xoa.TabIndex = 11;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(905, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "25.999.000 VNĐ";
            // 
            // txt_soluong
            // 
            this.txt_soluong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_soluong.BackColor = System.Drawing.Color.White;
            this.txt_soluong.Location = new System.Drawing.Point(646, 53);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(63, 22);
            this.txt_soluong.TabIndex = 9;
            this.txt_soluong.Text = "3";
            this.txt_soluong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_soluong.TextChanged += new System.EventHandler(this.txt_soluong_TextChanged);
            this.txt_soluong.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_soluong_KeyDown);
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
            this.btnTang.BackColor = System.Drawing.SystemColors.Control;
            this.btnTang.Location = new System.Drawing.Point(715, 47);
            this.btnTang.Name = "btnTang";
            this.btnTang.Size = new System.Drawing.Size(35, 35);
            this.btnTang.TabIndex = 5;
            this.btnTang.Text = "+";
            this.btnTang.UseVisualStyleBackColor = false;
            this.btnTang.Click += new System.EventHandler(this.btnTang_Click);
            // 
            // btnGiam
            // 
            this.btnGiam.BackColor = System.Drawing.SystemColors.Control;
            this.btnGiam.Location = new System.Drawing.Point(605, 47);
            this.btnGiam.Name = "btnGiam";
            this.btnGiam.Size = new System.Drawing.Size(35, 35);
            this.btnGiam.TabIndex = 3;
            this.btnGiam.Text = "-";
            this.btnGiam.UseVisualStyleBackColor = false;
            this.btnGiam.Click += new System.EventHandler(this.btnGiam_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 137);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1360, 1);
            this.panel1.TabIndex = 12;
            // 
            // ucGioHangItem_GioHang_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
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
        private System.Windows.Forms.Button btnTang;
        private System.Windows.Forms.Button btnGiam;
        private System.Windows.Forms.Label lblTenSanPham;
        private System.Windows.Forms.PictureBox picboxSP;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.TextBox txt_soluong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Panel panel1;
    }
}
