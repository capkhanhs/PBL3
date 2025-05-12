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
using PBL.Model;

namespace PBL.View
{
    public partial class ucGioHangItem_GioHang_Main : UserControl
    {
        private CartItem cartitem;
        public ucGioHangItem_GioHang_Main(CartItem cartitem)
        {
            InitializeComponent();
            this.cartitem = cartitem;
            LoadData();
        }

        public void LoadData()
        {
            var sp = SanphamBLL.Instance.Find(cartitem.Ma_san_pham);
            if (sp != null)
            {
                lblTenSanPham.Text = sp.Ten_sp;
                int giaban = (int)(int.Parse(sp.Gia_sp) * cartitem.Quantity.GetValueOrDefault(1));
                label1.Text = string.Format("{0:0,0}", int.Parse(sp.Gia_sp)) + " VNĐ";
                lblMoTa.Text = sp.Mo_ta_sp;
                txt_soluong.Text = cartitem.Quantity.GetValueOrDefault(1).ToString();
                string imagePath = Path.Combine(Application.StartupPath, "Resources", sp.PictureFileName);
                picboxSP.SizeMode = PictureBoxSizeMode.StretchImage;
                if (File.Exists(imagePath))
                {
                    picboxSP.Image = Image.FromFile(imagePath);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy ảnh tại: " + imagePath);
                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void txtSoluong_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTang_Click(object sender, EventArgs e)
        {
            var sp = SanphamBLL.Instance.Find(cartitem.Ma_san_pham);

            cartitem.Quantity++;
            txt_soluong.Text = cartitem.Quantity.ToString();
            int giaban = (int)(int.Parse(sp.Gia_sp) * cartitem.Quantity.GetValueOrDefault(1));
            label1.Text = string.Format("{0:0,0}", int.Parse(sp.Gia_sp)) + " VNĐ";
        }

        private void btnGiam_Click(object sender, EventArgs e)
        {
            var sp = SanphamBLL.Instance.Find(cartitem.Ma_san_pham);
            cartitem.Quantity--;
            if (cartitem.Quantity < 1)
            {
                cartitem.Quantity = 1;
            }
            txt_soluong.Text = cartitem.Quantity.ToString();
            txt_soluong.Text = cartitem.Quantity.ToString();
            int giaban = (int)(int.Parse(sp.Gia_sp) * cartitem.Quantity.GetValueOrDefault(1));
            label1.Text = string.Format("{0:0,0}", int.Parse(sp.Gia_sp)) + " VNĐ";
        }
    }
}
