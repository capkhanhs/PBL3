namespace PBL.View
{
    partial class Register
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.cbb_vaitro = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grb_giotinh = new System.Windows.Forms.GroupBox();
            this.hide_rdb = new System.Windows.Forms.RadioButton();
            this.rdb_female = new System.Windows.Forms.RadioButton();
            this.rdb_male = new System.Windows.Forms.RadioButton();
            this.btnregister = new System.Windows.Forms.Button();
            this.grb_giotinh.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tạo tài khoản mới";
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(146, 161);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(179, 22);
            this.txtusername.TabIndex = 1;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(146, 278);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(179, 22);
            this.txtname.TabIndex = 4;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(146, 219);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(179, 22);
            this.txtpassword.TabIndex = 5;
            // 
            // cbb_vaitro
            // 
            this.cbb_vaitro.FormattingEnabled = true;
            this.cbb_vaitro.Items.AddRange(new object[] {
            "Khách hàng",
            "Nhân viên bán hàng",
            "Quản lý kho",
            "Quản lý vận chuyển"});
            this.cbb_vaitro.Location = new System.Drawing.Point(146, 344);
            this.cbb_vaitro.Name = "cbb_vaitro";
            this.cbb_vaitro.Size = new System.Drawing.Size(179, 24);
            this.cbb_vaitro.TabIndex = 6;
            this.cbb_vaitro.SelectedIndexChanged += new System.EventHandler(this.cbb_vaitro_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Sđt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mật khẩu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Họ Và tên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Vai trò";
            // 
            // grb_giotinh
            // 
            this.grb_giotinh.Controls.Add(this.hide_rdb);
            this.grb_giotinh.Controls.Add(this.rdb_female);
            this.grb_giotinh.Controls.Add(this.rdb_male);
            this.grb_giotinh.Location = new System.Drawing.Point(370, 164);
            this.grb_giotinh.Name = "grb_giotinh";
            this.grb_giotinh.Size = new System.Drawing.Size(174, 56);
            this.grb_giotinh.TabIndex = 13;
            this.grb_giotinh.TabStop = false;
            this.grb_giotinh.Text = "Giới tính";
            // 
            // hide_rdb
            // 
            this.hide_rdb.AutoSize = true;
            this.hide_rdb.Checked = true;
            this.hide_rdb.Location = new System.Drawing.Point(82, 36);
            this.hide_rdb.Name = "hide_rdb";
            this.hide_rdb.Size = new System.Drawing.Size(31, 20);
            this.hide_rdb.TabIndex = 2;
            this.hide_rdb.TabStop = true;
            this.hide_rdb.Text = ".";
            this.hide_rdb.UseVisualStyleBackColor = true;
            this.hide_rdb.Visible = false;
            // 
            // rdb_female
            // 
            this.rdb_female.AutoSize = true;
            this.rdb_female.Location = new System.Drawing.Point(112, 18);
            this.rdb_female.Name = "rdb_female";
            this.rdb_female.Size = new System.Drawing.Size(45, 20);
            this.rdb_female.TabIndex = 1;
            this.rdb_female.Text = "Nữ";
            this.rdb_female.UseVisualStyleBackColor = true;
            // 
            // rdb_male
            // 
            this.rdb_male.AutoSize = true;
            this.rdb_male.Location = new System.Drawing.Point(3, 18);
            this.rdb_male.Name = "rdb_male";
            this.rdb_male.Size = new System.Drawing.Size(57, 20);
            this.rdb_male.TabIndex = 0;
            this.rdb_male.Text = "Nam";
            this.rdb_male.UseVisualStyleBackColor = true;
            // 
            // btnregister
            // 
            this.btnregister.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregister.Location = new System.Drawing.Point(146, 476);
            this.btnregister.Name = "btnregister";
            this.btnregister.Size = new System.Drawing.Size(130, 58);
            this.btnregister.TabIndex = 14;
            this.btnregister.Text = "Đăng ký";
            this.btnregister.UseVisualStyleBackColor = true;
            this.btnregister.Click += new System.EventHandler(this.btnregister_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 596);
            this.Controls.Add(this.btnregister);
            this.Controls.Add(this.grb_giotinh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbb_vaitro);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.label1);
            this.Name = "Register";
            this.Text = "Resigter";
            this.grb_giotinh.ResumeLayout(false);
            this.grb_giotinh.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.ComboBox cbb_vaitro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grb_giotinh;
        private System.Windows.Forms.RadioButton hide_rdb;
        private System.Windows.Forms.RadioButton rdb_female;
        private System.Windows.Forms.RadioButton rdb_male;
        private System.Windows.Forms.Button btnregister;
    }
}