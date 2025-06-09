namespace PBL.View
{
    partial class ucQuanlydonhang_Admin
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
            this.btn_Huy = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_AllDH = new System.Windows.Forms.Button();
            this.btn_XL = new System.Windows.Forms.Button();
            this.btn_XN = new System.Windows.Forms.Button();
            this.btn_GH = new System.Windows.Forms.Button();
            this.btn_TC = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.flpnMainDonHangDaMua = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Huy
            // 
            this.btn_Huy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Huy.Location = new System.Drawing.Point(616, 3);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(114, 38);
            this.btn_Huy.TabIndex = 6;
            this.btn_Huy.Text = "Đã hủy";
            this.btn_Huy.UseVisualStyleBackColor = true;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btn_AllDH);
            this.flowLayoutPanel1.Controls.Add(this.btn_XL);
            this.flowLayoutPanel1.Controls.Add(this.btn_XN);
            this.flowLayoutPanel1.Controls.Add(this.btn_GH);
            this.flowLayoutPanel1.Controls.Add(this.btn_TC);
            this.flowLayoutPanel1.Controls.Add(this.btn_Huy);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(755, 35);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btn_AllDH
            // 
            this.btn_AllDH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AllDH.Location = new System.Drawing.Point(3, 3);
            this.btn_AllDH.Name = "btn_AllDH";
            this.btn_AllDH.Size = new System.Drawing.Size(91, 38);
            this.btn_AllDH.TabIndex = 0;
            this.btn_AllDH.Text = "Tất cả";
            this.btn_AllDH.UseVisualStyleBackColor = true;
            this.btn_AllDH.Click += new System.EventHandler(this.btn_AllDH_Click);
            // 
            // btn_XL
            // 
            this.btn_XL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XL.Location = new System.Drawing.Point(100, 3);
            this.btn_XL.Name = "btn_XL";
            this.btn_XL.Size = new System.Drawing.Size(110, 38);
            this.btn_XL.TabIndex = 1;
            this.btn_XL.Text = "Chờ xử lý";
            this.btn_XL.UseVisualStyleBackColor = true;
            this.btn_XL.Click += new System.EventHandler(this.btn_XL_Click);
            // 
            // btn_XN
            // 
            this.btn_XN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XN.Location = new System.Drawing.Point(216, 3);
            this.btn_XN.Name = "btn_XN";
            this.btn_XN.Size = new System.Drawing.Size(129, 38);
            this.btn_XN.TabIndex = 2;
            this.btn_XN.Text = "Đã xác nhận";
            this.btn_XN.UseVisualStyleBackColor = true;
            this.btn_XN.Click += new System.EventHandler(this.btn_XN_Click);
            // 
            // btn_GH
            // 
            this.btn_GH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GH.Location = new System.Drawing.Point(351, 3);
            this.btn_GH.Name = "btn_GH";
            this.btn_GH.Size = new System.Drawing.Size(143, 38);
            this.btn_GH.TabIndex = 4;
            this.btn_GH.Text = "Đang giao hàng";
            this.btn_GH.UseVisualStyleBackColor = true;
            this.btn_GH.Click += new System.EventHandler(this.btn_GH_Click);
            // 
            // btn_TC
            // 
            this.btn_TC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TC.Location = new System.Drawing.Point(500, 3);
            this.btn_TC.Name = "btn_TC";
            this.btn_TC.Size = new System.Drawing.Size(110, 38);
            this.btn_TC.TabIndex = 5;
            this.btn_TC.Text = "Thành công";
            this.btn_TC.UseVisualStyleBackColor = true;
            this.btn_TC.Click += new System.EventHandler(this.btn_TC_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.flpnMainDonHangDaMua, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(189, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 565F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(809, 606);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // flpnMainDonHangDaMua
            // 
            this.flpnMainDonHangDaMua.AutoScroll = true;
            this.flpnMainDonHangDaMua.BackColor = System.Drawing.Color.White;
            this.flpnMainDonHangDaMua.Location = new System.Drawing.Point(3, 44);
            this.flpnMainDonHangDaMua.Name = "flpnMainDonHangDaMua";
            this.flpnMainDonHangDaMua.Size = new System.Drawing.Size(803, 559);
            this.flpnMainDonHangDaMua.TabIndex = 2;
            // 
            // ucQuanlydonhang_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "ucQuanlydonhang_Admin";
            this.Size = new System.Drawing.Size(1144, 609);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btn_AllDH;
        private System.Windows.Forms.Button btn_XL;
        private System.Windows.Forms.Button btn_XN;
        private System.Windows.Forms.Button btn_GH;
        private System.Windows.Forms.Button btn_TC;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flpnMainDonHangDaMua;
    }
}
