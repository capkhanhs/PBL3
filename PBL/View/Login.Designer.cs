namespace PBL.View
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pn_login = new System.Windows.Forms.Panel();
            this.btn_hienmk = new System.Windows.Forms.Button();
            this.lblForgPw = new System.Windows.Forms.LinkLabel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnSignin = new System.Windows.Forms.Button();
            this.btnSignup = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pic_0 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pic_pw = new System.Windows.Forms.PictureBox();
            this.pn_login.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_pw)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_login
            // 
            this.pn_login.BackColor = System.Drawing.Color.Transparent;
            this.pn_login.Controls.Add(this.btn_hienmk);
            this.pn_login.Controls.Add(this.lblForgPw);
            this.pn_login.Controls.Add(this.txtPassword);
            this.pn_login.Controls.Add(this.txtUsername);
            this.pn_login.Location = new System.Drawing.Point(806, 191);
            this.pn_login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pn_login.Name = "pn_login";
            this.pn_login.Size = new System.Drawing.Size(351, 156);
            this.pn_login.TabIndex = 0;
            // 
            // btn_hienmk
            // 
            this.btn_hienmk.BackColor = System.Drawing.SystemColors.Control;
            this.btn_hienmk.FlatAppearance.BorderSize = 0;
            this.btn_hienmk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hienmk.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hienmk.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_hienmk.Location = new System.Drawing.Point(279, 77);
            this.btn_hienmk.Name = "btn_hienmk";
            this.btn_hienmk.Size = new System.Drawing.Size(69, 27);
            this.btn_hienmk.TabIndex = 7;
            this.btn_hienmk.Text = "Hiện";
            this.btn_hienmk.UseVisualStyleBackColor = false;
            this.btn_hienmk.Click += new System.EventHandler(this.btn_hienmk_Click);
            // 
            // lblForgPw
            // 
            this.lblForgPw.AutoSize = true;
            this.lblForgPw.BackColor = System.Drawing.Color.Transparent;
            this.lblForgPw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForgPw.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblForgPw.LinkColor = System.Drawing.Color.Blue;
            this.lblForgPw.Location = new System.Drawing.Point(218, 122);
            this.lblForgPw.Name = "lblForgPw";
            this.lblForgPw.Size = new System.Drawing.Size(119, 18);
            this.lblForgPw.TabIndex = 5;
            this.lblForgPw.TabStop = true;
            this.lblForgPw.Text = "Quên Mật Khẩu?";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.Control;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(3, 76);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(345, 34);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.Text = "123456";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.SystemColors.Control;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(3, 21);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(345, 34);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.Text = "0395471811";
            // 
            // btnSignin
            // 
            this.btnSignin.BackColor = System.Drawing.Color.OrangeRed;
            this.btnSignin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignin.Location = new System.Drawing.Point(809, 422);
            this.btnSignin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSignin.Name = "btnSignin";
            this.btnSignin.Size = new System.Drawing.Size(345, 46);
            this.btnSignin.TabIndex = 6;
            this.btnSignin.Text = "Đăng Nhập";
            this.btnSignin.UseVisualStyleBackColor = false;
            this.btnSignin.Click += new System.EventHandler(this.btnSignin_Click);
            // 
            // btnSignup
            // 
            this.btnSignup.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSignup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignup.Location = new System.Drawing.Point(809, 472);
            this.btnSignup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(345, 45);
            this.btnSignup.TabIndex = 7;
            this.btnSignup.Text = "Đăng Ký";
            this.btnSignup.UseVisualStyleBackColor = false;
            this.btnSignup.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pic_0);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(734, 565);
            this.panel1.TabIndex = 9;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Gold;
            this.pictureBox3.Image = global::PBL.Properties.Resources.anh_nen_dang_nhap;
            this.pictureBox3.Location = new System.Drawing.Point(-76, -27);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(807, 386);
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(283, 472);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(389, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mua dễ dàng - thanh toán thuận tiện - sở hữu nhanh chóng";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Gold;
            this.pictureBox2.BackgroundImage = global::PBL.Properties.Resources.logo1;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(286, 387);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(384, 81);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pic_0
            // 
            this.pic_0.BackColor = System.Drawing.Color.Gold;
            this.pic_0.BackgroundImage = global::PBL.Properties.Resources.Icon;
            this.pic_0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_0.Location = new System.Drawing.Point(-24, 337);
            this.pic_0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic_0.Name = "pic_0";
            this.pic_0.Size = new System.Drawing.Size(348, 219);
            this.pic_0.TabIndex = 1;
            this.pic_0.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(895, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "Đăng Nhập";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(755, 219);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 27);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pic_pw
            // 
            this.pic_pw.BackgroundImage = global::PBL.Properties.Resources.Password;
            this.pic_pw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_pw.Location = new System.Drawing.Point(755, 273);
            this.pic_pw.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic_pw.Name = "pic_pw";
            this.pic_pw.Size = new System.Drawing.Size(45, 28);
            this.pic_pw.TabIndex = 3;
            this.pic_pw.TabStop = false;
            // 
            // Login
            // 
            this.AcceptButton = this.btnSignin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1206, 567);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSignin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pic_pw);
            this.Controls.Add(this.btnSignup);
            this.Controls.Add(this.pn_login);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Login";
            this.Text = "Đăng Nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.pn_login.ResumeLayout(false);
            this.pn_login.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_pw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pn_login;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pic_pw;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.PictureBox pic_0;
        private System.Windows.Forms.LinkLabel lblForgPw;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnSignin;
        private System.Windows.Forms.Button btnSignup;
        private System.Windows.Forms.Button btn_hienmk;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}