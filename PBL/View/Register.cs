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
            LoadCbbVaitro();
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

                MessageBox.Show("Đăng ký thành công");
                GioHangBLL.Instance.CreateGioHang(txtusername.Text);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbb_vaitro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
                    }

    }
}
