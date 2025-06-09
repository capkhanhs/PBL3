using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL.View
{
    public partial class changePassword : Form
    {
        string mnd;
        public changePassword(string ma)
        {
            InitializeComponent();
            mnd = ma;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }
            if (textBox2.Text != textBox3.Text)
            {
                MessageBox.Show("Mật khẩu mới không khớp!");
                return;
            }
            try
            {
                PBL.BLL.NguoidungBLL.Instance.Doimatkhau(textBox1.Text, textBox2.Text, mnd);
                MessageBox.Show("Đổi mật khẩu thành công!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_hienmk_Click(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '\0') // đang hiện mật khẩu
            {
                textBox2.PasswordChar = '*';   // ẩn mật khẩu
                btn_hienmk.Text = "Hiện";         // đổi chữ nút nếu muốn
            }
            else
            {
                textBox2.PasswordChar = '\0';  // hiện mật khẩu
                btn_hienmk.Text = "Ẩn";           // đổi chữ nút nếu muốn
            }
        }
    }
}
