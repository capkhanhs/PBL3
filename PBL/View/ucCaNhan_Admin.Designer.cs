namespace PBL.View
{
    partial class ucCaNhan_Admin
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.pn_HienThiCaNhan = new System.Windows.Forms.Panel();
            this.btn_DonHang = new System.Windows.Forms.Button();
            this.btn_TT_DC = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_Logout, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(30, 65);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.19149F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.80851F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 161F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(281, 350);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Bạn";
            // 
            // btn_Logout
            // 
            this.btn_Logout.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.ForeColor = System.Drawing.Color.Red;
            this.btn_Logout.Location = new System.Drawing.Point(3, 191);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(275, 53);
            this.btn_Logout.TabIndex = 16;
            this.btn_Logout.Text = "Đăng Xuất";
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.btn_DonHang, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_TT_DC, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 56);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.51163F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.48837F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(275, 129);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // pn_HienThiCaNhan
            // 
            this.pn_HienThiCaNhan.BackColor = System.Drawing.Color.White;
            this.pn_HienThiCaNhan.Location = new System.Drawing.Point(336, 65);
            this.pn_HienThiCaNhan.Name = "pn_HienThiCaNhan";
            this.pn_HienThiCaNhan.Size = new System.Drawing.Size(761, 459);
            this.pn_HienThiCaNhan.TabIndex = 5;
            // 
            // btn_DonHang
            // 
            this.btn_DonHang.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_DonHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DonHang.Image = global::PBL.Properties.Resources.Erix_Subyarko_Medical_Invoice_Bill_Payment_Billing_Hospital_32;
            this.btn_DonHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DonHang.Location = new System.Drawing.Point(3, 3);
            this.btn_DonHang.Name = "btn_DonHang";
            this.btn_DonHang.Padding = new System.Windows.Forms.Padding(1);
            this.btn_DonHang.Size = new System.Drawing.Size(269, 45);
            this.btn_DonHang.TabIndex = 14;
            this.btn_DonHang.Text = "Đơn hàng đã mua";
            this.btn_DonHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DonHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_DonHang.UseMnemonic = false;
            this.btn_DonHang.UseVisualStyleBackColor = true;
            this.btn_DonHang.Click += new System.EventHandler(this.btn_DonHang_Click);
            // 
            // btn_TT_DC
            // 
            this.btn_TT_DC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_TT_DC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TT_DC.Image = global::PBL.Properties.Resources.thongtin;
            this.btn_TT_DC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TT_DC.Location = new System.Drawing.Point(3, 63);
            this.btn_TT_DC.Name = "btn_TT_DC";
            this.btn_TT_DC.Padding = new System.Windows.Forms.Padding(1);
            this.btn_TT_DC.Size = new System.Drawing.Size(269, 48);
            this.btn_TT_DC.TabIndex = 15;
            this.btn_TT_DC.Text = "Thông tin và sổ địa chỉ";
            this.btn_TT_DC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TT_DC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_TT_DC.UseVisualStyleBackColor = true;
            this.btn_TT_DC.Click += new System.EventHandler(this.btn_TT_DC_Click);
            // 
            // ucCaNhan_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pn_HienThiCaNhan);
            this.Name = "ucCaNhan_Admin";
            this.Size = new System.Drawing.Size(1144, 609);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btn_DonHang;
        private System.Windows.Forms.Button btn_TT_DC;
        private System.Windows.Forms.Panel pn_HienThiCaNhan;
    }
}
