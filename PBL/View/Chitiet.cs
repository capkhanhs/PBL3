using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL.Model;

namespace PBL.View
{
    public partial class Chitiet : Form
    {
        public Chitiet(San_Pham sp)
        {
            InitializeComponent();
            txt_TenSP.Text = sp.Ten_sp;
            txt_TenDanhMuc.Text = sp.Danh_Muc.Ten_danh_muc;
            txt_SoLuong.Text = sp.So_luong.ToString();
            txt_MaSP.Text = sp.Ma_san_pham;
            textBox2.Text = string.Format("{0:0,0}", long.Parse(sp.Gia_sp)) + " VNĐ";
            textBox1.Text = sp.Da_ban.ToString();
            richTextBox1.Text = sp.Chi_tiet_san_pham;
            string imagePath = Path.Combine(Application.StartupPath, "Resources", sp.PictureFileName);
            pic_AnhSP.SizeMode = PictureBoxSizeMode.StretchImage;
            if (File.Exists(imagePath))
            {
                pic_AnhSP.Image = Image.FromFile(imagePath);
            }
            else
            {
                MessageBox.Show("Không tìm thấy ảnh tại: " + imagePath);
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close(); // Đóng form hiện tại
        }

        private void lb_ThongTinSP_Click(object sender, EventArgs e)
        {

        }

        private void txt_TenSP_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
