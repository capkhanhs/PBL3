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
            this.btnSignin = new System.Windows.Forms.Button();
            this.lblForgPw = new System.Windows.Forms.LinkLabel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.pic_pw = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.pic_0 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnSignup = new System.Windows.Forms.Button();
            this.pn_login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_pw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_login
            // 
            this.pn_login.BackColor = System.Drawing.Color.Transparent;
            this.pn_login.Controls.Add(this.btn_hienmk);
            this.pn_login.Controls.Add(this.btnSignin);
            this.pn_login.Controls.Add(this.lblForgPw);
            this.pn_login.Controls.Add(this.txtPassword);
            this.pn_login.Controls.Add(this.pic_pw);
            this.pn_login.Controls.Add(this.pictureBox1);
            this.pn_login.Controls.Add(this.txtUsername);
            this.pn_login.Location = new System.Drawing.Point(338, 36);
            this.pn_login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pn_login.Name = "pn_login";
            this.pn_login.Size = new System.Drawing.Size(251, 156);
            this.pn_login.TabIndex = 0;
            // 
            // btn_hienmk
            // 
            this.btn_hienmk.Location = new System.Drawing.Point(197, 68);
            this.btn_hienmk.Name = "btn_hienmk";
            this.btn_hienmk.Size = new System.Drawing.Size(51, 30);
            this.btn_hienmk.TabIndex = 7;
            this.btn_hienmk.Text = "Hiện";
            this.btn_hienmk.UseVisualStyleBackColor = true;
            this.btn_hienmk.Click += new System.EventHandler(this.btn_hienmk_Click);
            // 
            // btnSignin
            // 
            this.btnSignin.BackColor = System.Drawing.Color.Transparent;
            this.btnSignin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignin.Location = new System.Drawing.Point(73, 124);
            this.btnSignin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSignin.Name = "btnSignin";
            this.btnSignin.Size = new System.Drawing.Size(130, 32);
            this.btnSignin.TabIndex = 6;
            this.btnSignin.Text = "Đăng Nhập";
            this.btnSignin.UseVisualStyleBackColor = false;
            this.btnSignin.Click += new System.EventHandler(this.btnSignin_Click);
            // 
            // lblForgPw
            // 
            this.lblForgPw.AutoSize = true;
            this.lblForgPw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForgPw.LinkColor = System.Drawing.Color.AliceBlue;
            this.lblForgPw.Location = new System.Drawing.Point(109, 98);
            this.lblForgPw.Name = "lblForgPw";
            this.lblForgPw.Size = new System.Drawing.Size(130, 18);
            this.lblForgPw.TabIndex = 5;
            this.lblForgPw.TabStop = true;
            this.lblForgPw.Text = "Forget Password?";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(63, 68);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(185, 30);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.Text = "123456";
            // 
            // pic_pw
            // 
            this.pic_pw.BackgroundImage = global::PBL.Properties.Resources.Password;
            this.pic_pw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_pw.Location = new System.Drawing.Point(0, 56);
            this.pic_pw.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic_pw.Name = "pic_pw";
            this.pic_pw.Size = new System.Drawing.Size(58, 40);
            this.pic_pw.TabIndex = 3;
            this.pic_pw.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 34);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(63, 9);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(185, 30);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.Text = "0395471811";
            // 
            // pic_0
            // 
            this.pic_0.BackColor = System.Drawing.Color.Transparent;
            this.pic_0.BackgroundImage = global::PBL.Properties.Resources.Icon;
            this.pic_0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_0.Location = new System.Drawing.Point(-1, -1);
            this.pic_0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic_0.Name = "pic_0";
            this.pic_0.Size = new System.Drawing.Size(348, 219);
            this.pic_0.TabIndex = 1;
            this.pic_0.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::PBL.Properties.Resources.logo1;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(-1, 197);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(384, 81);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // btnSignup
            // 
            this.btnSignup.BackColor = System.Drawing.Color.Transparent;
            this.btnSignup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignup.Location = new System.Drawing.Point(411, 207);
            this.btnSignup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(130, 32);
            this.btnSignup.TabIndex = 7;
            this.btnSignup.Text = "Đăng Ký";
            this.btnSignup.UseVisualStyleBackColor = false;
            this.btnSignup.Visible = false;
            this.btnSignup.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::PBL.Properties.Resources.WallPaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(609, 268);
            this.Controls.Add(this.btnSignup);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pic_0);
            this.Controls.Add(this.pn_login);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Login";
            this.Text = "Đăng Nhập";
            this.pn_login.ResumeLayout(false);
            this.pn_login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_pw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

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
    }
}