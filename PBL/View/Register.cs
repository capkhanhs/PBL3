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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            //cbb_vaitro.SelectedIndex = 0;
        }

        public void LoadCbbVaitro()
        {
            //cbb_vaitro.DataSource = VaitroBLL.Instance.GetAll();
            //cbb_vaitro.DisplayMember = "Ten_vai_tro";
            //cbb_vaitro.ValueMember = "Ma_vai_tro";
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            try
            {
                if(hide_rdb.Checked)
                {
                    throw new Exception("Vui lòng nhập đầy đủ thông tin!");
                }    
                NguoidungBLL.Instance.Register(txtusername.Text, txtpassword.Text,"KH", txtname.Text, rdb_male.Checked);

                MessageBox.Show("Đăng ký thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Question);
                GioHangBLL.Instance.CreateGioHang(txtusername.Text);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        // Trong form Register:

        private void cbb_vaitro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.KeyPreview = false; 
    }
    }
}
