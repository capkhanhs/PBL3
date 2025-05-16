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
    public partial class ucSanPham_Admin: UserControl
    {
        San_Pham SP;
        public ucSanPham_Admin(San_Pham sp)
        {
            InitializeComponent();
            LoadData(sp);
            SP = sp;
        }

        public void LoadData(San_Pham sp)
        {
            lb_TenSP.Text = sp.Ten_sp;
            label2.Text = string.Format("{0:0,0}", long.Parse(sp.Gia_sp)) + " VNĐ";
            lb_maSP.Text = sp.Ma_san_pham;
            lb_SL.Text = sp.So_luong.ToString();
            string imagePath = Path.Combine(Application.StartupPath, "Resources", sp.PictureFileName);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            if (File.Exists(imagePath))
            {
                pictureBox1.Image = Image.FromFile(imagePath);
            }
            else
            {
                MessageBox.Show("Không tìm thấy ảnh tại: " + imagePath);
            }
        }

        private void btn_Chinhsua_Click(object sender, EventArgs e)
        {
            ChinhSua_ThemSanPham_Admin f = new ChinhSua_ThemSanPham_Admin(SP);
            f.ShowDialog();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Bạn chắc chắn muốn xóa sản phẩm?",     // Nội dung
                "Xác nhận",                          // Tiêu đề
                MessageBoxButtons.OKCancel,           // Các nút: OK và Cancel
                MessageBoxIcon.Question               // Icon hình dấu hỏi
            );
        }
        public void Reload ()
        {

        }
        private void btn_XemChiTiet_Click(object sender, EventArgs e)
        {
            //ChinhSua_ThemSanPham_Admin f = new ChinhSua_ThemSanPham_Admin(Reload);
            //f.Show();
        }
    }
}
