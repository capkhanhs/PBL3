namespace PBL.View
{
    partial class ucSanPhamItem_TrangChu_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucSanPhamItem_TrangChu_Main));
            this.ptbox_sp = new System.Windows.Forms.PictureBox();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.lblGiaSP = new System.Windows.Forms.Label();
            this.lbl_Mota = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btn_themvaogio = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_soluong = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptbox_sp)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // ptbox_sp
            // 
            this.ptbox_sp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptbox_sp.Dock = System.Windows.Forms.DockStyle.Top;
            this.ptbox_sp.Image = global::PBL.Properties.Resources.laptopnitrotest;
            this.ptbox_sp.Location = new System.Drawing.Point(0, 0);
            this.ptbox_sp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptbox_sp.Name = "ptbox_sp";
            this.ptbox_sp.Size = new System.Drawing.Size(419, 264);
            this.ptbox_sp.TabIndex = 0;
            this.ptbox_sp.TabStop = false;
            this.ptbox_sp.Click += new System.EventHandler(this.ptbox_sp_Click);
            // 
            // lblTenSP
            // 
            this.lblTenSP.AutoSize = true;
            this.lblTenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSP.Location = new System.Drawing.Point(29, 281);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(79, 25);
            this.lblTenSP.TabIndex = 1;
            this.lblTenSP.Text = "Tên SP";
            this.lblTenSP.Click += new System.EventHandler(this.lblTenSP_Click);
            // 
            // lblGiaSP
            // 
            this.lblGiaSP.AutoSize = true;
            this.lblGiaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaSP.ForeColor = System.Drawing.Color.Red;
            this.lblGiaSP.Location = new System.Drawing.Point(29, 452);
            this.lblGiaSP.Name = "lblGiaSP";
            this.lblGiaSP.Size = new System.Drawing.Size(121, 25);
            this.lblGiaSP.TabIndex = 2;
            this.lblGiaSP.Text = "25.990.000đ";
            this.lblGiaSP.Click += new System.EventHandler(this.lblGiaSP_Click);
            // 
            // lbl_Mota
            // 
            this.lbl_Mota.AutoSize = true;
            this.lbl_Mota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mota.Location = new System.Drawing.Point(29, 338);
            this.lbl_Mota.Name = "lbl_Mota";
            this.lbl_Mota.Size = new System.Drawing.Size(152, 25);
            this.lbl_Mota.TabIndex = 3;
            this.lbl_Mota.Text = "Mô tả sản phẩm";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(29, 395);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 25);
            this.label14.TabIndex = 5;
            this.label14.Text = "Sale:";
            // 
            // btn_themvaogio
            // 
            this.btn_themvaogio.BackColor = System.Drawing.Color.Transparent;
            this.btn_themvaogio.Image = ((System.Drawing.Image)(resources.GetObject("btn_themvaogio.Image")));
            this.btn_themvaogio.Location = new System.Drawing.Point(341, 427);
            this.btn_themvaogio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_themvaogio.Name = "btn_themvaogio";
            this.btn_themvaogio.Size = new System.Drawing.Size(58, 50);
            this.btn_themvaogio.TabIndex = 6;
            this.btn_themvaogio.UseVisualStyleBackColor = false;
            this.btn_themvaogio.Click += new System.EventHandler(this.button3_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(93, 395);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 25);
            this.label13.TabIndex = 7;
            this.label13.Text = "10%";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // panel5
            // 
            this.panel5.AutoScroll = true;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.lbl_soluong);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.btn_themvaogio);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.lbl_Mota);
            this.panel5.Controls.Add(this.lblGiaSP);
            this.panel5.Controls.Add(this.lblTenSP);
            this.panel5.Controls.Add(this.ptbox_sp);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(421, 499);
            this.panel5.TabIndex = 4;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 461);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Số lượng:";
            // 
            // lbl_soluong
            // 
            this.lbl_soluong.AutoSize = true;
            this.lbl_soluong.Location = new System.Drawing.Point(264, 461);
            this.lbl_soluong.Name = "lbl_soluong";
            this.lbl_soluong.Size = new System.Drawing.Size(44, 16);
            this.lbl_soluong.TabIndex = 9;
            this.lbl_soluong.Text = "label2";
            // 
            // ucSanPhamItem_TrangChu_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel5);
            this.Name = "ucSanPhamItem_TrangChu_Main";
            this.Size = new System.Drawing.Size(421, 499);
            ((System.ComponentModel.ISupportInitialize)(this.ptbox_sp)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbox_sp;
        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.Label lblGiaSP;
        private System.Windows.Forms.Label lbl_Mota;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btn_themvaogio;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_soluong;
    }
}
