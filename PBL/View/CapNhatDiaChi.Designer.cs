namespace PBL.View
{
    partial class CapNhatDiaChi
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_ChiTiet = new System.Windows.Forms.TextBox();
            this.CBB_QH = new System.Windows.Forms.ComboBox();
            this.CBB_TinhThanh = new System.Windows.Forms.ComboBox();
            this.CBB_PX = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Update = new System.Windows.Forms.Button();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel7, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.44898F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(755, 211);
            this.tableLayoutPanel5.TabIndex = 3;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.txt_ChiTiet, 1, 1);
            this.tableLayoutPanel7.Controls.Add(this.CBB_QH, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.CBB_TinhThanh, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.CBB_PX, 0, 1);
            this.tableLayoutPanel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(749, 102);
            this.tableLayoutPanel7.TabIndex = 0;
            // 
            // txt_ChiTiet
            // 
            this.txt_ChiTiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ChiTiet.Location = new System.Drawing.Point(377, 54);
            this.txt_ChiTiet.Name = "txt_ChiTiet";
            this.txt_ChiTiet.Size = new System.Drawing.Size(369, 30);
            this.txt_ChiTiet.TabIndex = 3;
            // 
            // CBB_QH
            // 
            this.CBB_QH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBB_QH.ForeColor = System.Drawing.Color.Red;
            this.CBB_QH.FormattingEnabled = true;
            this.CBB_QH.Location = new System.Drawing.Point(377, 3);
            this.CBB_QH.Name = "CBB_QH";
            this.CBB_QH.Size = new System.Drawing.Size(369, 33);
            this.CBB_QH.TabIndex = 5;
            this.CBB_QH.Text = "Quận/ Huyện";
            this.CBB_QH.SelectedIndexChanged += new System.EventHandler(this.CBB_QH_SelectedIndexChanged_1);
            // 
            // CBB_TinhThanh
            // 
            this.CBB_TinhThanh.CausesValidation = false;
            this.CBB_TinhThanh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CBB_TinhThanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBB_TinhThanh.ForeColor = System.Drawing.Color.Red;
            this.CBB_TinhThanh.FormattingEnabled = true;
            this.CBB_TinhThanh.IntegralHeight = false;
            this.CBB_TinhThanh.Location = new System.Drawing.Point(3, 3);
            this.CBB_TinhThanh.Name = "CBB_TinhThanh";
            this.CBB_TinhThanh.Size = new System.Drawing.Size(368, 33);
            this.CBB_TinhThanh.TabIndex = 4;
            this.CBB_TinhThanh.Text = "Tỉnh/ Thành phố";
            this.CBB_TinhThanh.SelectedIndexChanged += new System.EventHandler(this.CBB_TinhThanh_SelectedIndexChanged_1);
            // 
            // CBB_PX
            // 
            this.CBB_PX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBB_PX.ForeColor = System.Drawing.Color.Red;
            this.CBB_PX.FormattingEnabled = true;
            this.CBB_PX.Location = new System.Drawing.Point(3, 54);
            this.CBB_PX.Name = "CBB_PX";
            this.CBB_PX.Size = new System.Drawing.Size(368, 33);
            this.CBB_PX.TabIndex = 2;
            this.CBB_PX.Text = "Phường/ Xã";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.97268F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.02732F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 211F));
            this.tableLayoutPanel1.Controls.Add(this.btn_Update, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 120);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(749, 88);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.Red;
            this.btn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.ForeColor = System.Drawing.Color.White;
            this.btn_Update.Location = new System.Drawing.Point(191, 3);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(343, 60);
            this.btn_Update.TabIndex = 1;
            this.btn_Update.Text = "CẬP NHẬT";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click_1);
            // 
            // CapNhatDiaChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 215);
            this.Controls.Add(this.tableLayoutPanel5);
            this.Name = "CapNhatDiaChi";
            this.Text = "Cập nhật địa chỉ";
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TextBox txt_ChiTiet;
        private System.Windows.Forms.ComboBox CBB_QH;
        private System.Windows.Forms.ComboBox CBB_TinhThanh;
        private System.Windows.Forms.ComboBox CBB_PX;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_Update;
    }
}