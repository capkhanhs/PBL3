namespace PBL.View
{
    partial class ucGioHang_Main
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
            this.lbl_diachinhanhang = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnMainGioHang = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_diachinhanhang
            // 
            this.lbl_diachinhanhang.AutoSize = true;
            this.lbl_diachinhanhang.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_diachinhanhang.Location = new System.Drawing.Point(3, 0);
            this.lbl_diachinhanhang.Name = "lbl_diachinhanhang";
            this.lbl_diachinhanhang.Size = new System.Drawing.Size(266, 41);
            this.lbl_diachinhanhang.TabIndex = 0;
            this.lbl_diachinhanhang.Text = "Giỏ hàng của bạn";
            this.lbl_diachinhanhang.Click += new System.EventHandler(this.label1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.lbl_diachinhanhang);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 13);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1383, 37);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // pnMainGioHang
            // 
            this.pnMainGioHang.AutoScroll = true;
            this.pnMainGioHang.BackColor = System.Drawing.Color.White;
            this.pnMainGioHang.Location = new System.Drawing.Point(3, 56);
            this.pnMainGioHang.Name = "pnMainGioHang";
            this.pnMainGioHang.Size = new System.Drawing.Size(1383, 572);
            this.pnMainGioHang.TabIndex = 2;
            // 
            // ucGioHang_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnMainGioHang);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "ucGioHang_Main";
            this.Size = new System.Drawing.Size(1389, 631);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_diachinhanhang;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel pnMainGioHang;
    }
}
