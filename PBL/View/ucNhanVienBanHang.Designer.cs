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
            this.btn_DonHangChoXuLy = new System.Windows.Forms.Button();
            this.btn_DonHangDaXuLy = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_DonHangChoXuLy
            // 
            this.btn_DonHangChoXuLy.BackColor = System.Drawing.Color.Silver;
            this.btn_DonHangChoXuLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DonHangChoXuLy.ForeColor = System.Drawing.Color.Black;
            this.btn_DonHangChoXuLy.Location = new System.Drawing.Point(183, 3);
            this.btn_DonHangChoXuLy.Name = "btn_DonHangChoXuLy";
            this.btn_DonHangChoXuLy.Size = new System.Drawing.Size(112, 43);
            this.btn_DonHangChoXuLy.TabIndex = 1;
            this.btn_DonHangChoXuLy.Text = "Chưa xử lý";
            this.btn_DonHangChoXuLy.UseVisualStyleBackColor = false;
            this.btn_DonHangChoXuLy.Click += new System.EventHandler(this.btn_DonHangChoXuLy_Click);
            // 
            // btn_DonHangDaXuLy
            // 
            this.btn_DonHangDaXuLy.BackColor = System.Drawing.Color.Silver;
            this.btn_DonHangDaXuLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DonHangDaXuLy.ForeColor = System.Drawing.Color.Black;
            this.btn_DonHangDaXuLy.Location = new System.Drawing.Point(301, 3);
            this.btn_DonHangDaXuLy.Name = "btn_DonHangDaXuLy";
            this.btn_DonHangDaXuLy.Size = new System.Drawing.Size(118, 43);
            this.btn_DonHangDaXuLy.TabIndex = 2;
            this.btn_DonHangDaXuLy.Text = "Đã xử lý";
            this.btn_DonHangDaXuLy.UseVisualStyleBackColor = false;
            this.btn_DonHangDaXuLy.Click += new System.EventHandler(this.btn_DonHangDaXuLy_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btn_DonHangDaXuLy);
            this.panel2.Controls.Add(this.btn_DonHangChoXuLy);
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Location = new System.Drawing.Point(129, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1101, 602);
            this.panel2.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(425, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 43);
            this.button1.TabIndex = 7;
            this.button1.Text = "Đang vận chuyển";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(183, 52);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(755, 550);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // ucNhanVienBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Name = "ucNhanVienBanHang";
            this.Size = new System.Drawing.Size(1388, 609);
            this.Load += new System.EventHandler(this.ucNhanVienBanHang_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_DonHangChoXuLy;
        private System.Windows.Forms.Button btn_DonHangDaXuLy;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
    }
}
