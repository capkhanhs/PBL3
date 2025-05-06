using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL.BLL;

namespace PBL.View
{
    public partial class Login : Form
    {
        public string Username { get; set; }
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.ShowDialog();
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            try
            {
                if (NguoidungBLL.Instance.Dang_nhap(txtUsername.Text, txtPassword.Text))
                {
                    Username = txtUsername.Text;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_hienmk_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '\0') // đang hiện mật khẩu
            {
                txtPassword.PasswordChar = '*';   // ẩn mật khẩu
                btn_hienmk.Text = "Hiện";         // đổi chữ nút nếu muốn
            }
            else
            {
                txtPassword.PasswordChar = '\0';  // hiện mật khẩu
                btn_hienmk.Text = "Ẩn";           // đổi chữ nút nếu muốn
            }
        }
    }
}
