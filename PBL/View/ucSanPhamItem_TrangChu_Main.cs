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
using PBL.BLL;

namespace PBL.View
{
    public partial class ucSanPhamItem_TrangChu_Main : UserControl
    {
        string msp;
        string mnd;
        public ucSanPhamItem_TrangChu_Main(string MaSanPham, string MaNguoiDung)
        {
            InitializeComponent();
            msp = MaSanPham;
            this.mnd = MaNguoiDung;
            LoadSP();
        }

        public void LoadSP()
        {
            var sp = SanphamBLL.Instance.GetAll().FirstOrDefault(x => x.Ma_san_pham == msp);
            if (sp != null)
            {
                lblTenSP.Text = sp.Ten_sp;
                lblGiaSP.Text = sp.Gia_sp.ToString();
                lbl_Mota.Text = sp.Mo_ta_sp;
                lbl_soluong.Text = sp.So_luong.ToString();
                string imagePath = Path.Combine(Application.StartupPath, "Resources", sp.PictureFileName);
                ptbox_sp.SizeMode = PictureBoxSizeMode.StretchImage;
                if (File.Exists(imagePath))
                {
                    ptbox_sp.Image = Image.FromFile(imagePath);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy ảnh tại: " + imagePath);
                }
            }
        }

        private void lblGiaSP_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                CartItemBLL.Instance.AddCart(mnd, msp, 1);
                MessageBox.Show("Thêm vào giỏ hàng thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lblTenSP_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ptbox_sp_Click(object sender, EventArgs e)
        {

        }
    }
}
