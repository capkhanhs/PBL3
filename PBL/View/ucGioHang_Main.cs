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
    public partial class ucGioHang_Main : UserControl
    {
        private string manguoidung;
        private ucTinhtong_GioHang_Main uctt;
        public ucGioHang_Main(string manguoidung)
        {
            InitializeComponent();
            this.manguoidung = manguoidung;
            LoadCart();
        }


        public void LoadCart()
        {

            pnMainGioHang.Controls.Clear();
            var cartItems = CartItemBLL.Instance.GetAllCart(manguoidung);
            foreach (var item in cartItems)
            {
                ucGioHangItem_GioHang_Main ucGioHangItem = new ucGioHangItem_GioHang_Main(item);
                ucGioHangItem.OnSoLuongThayDoi += UcCT_OnSoLuongThayDoi;
                ucGioHangItem.OnXoaItem += UcCT_OnXoaItem;
                pnMainGioHang.Controls.Add(ucGioHangItem);
            }
            if (GioHangBLL.Instance.CheckGioHang(manguoidung) == false)
            {
                MessageBox.Show("Giỏ hàng trống");
                return;
            }
            uctt = new ucTinhtong_GioHang_Main(manguoidung);
            uctt.OnThanhToanThanhCong += UcCT_OnXoaItem;
            pnMainGioHang.Controls.Add(uctt);
        }

        private void UcCT_OnXoaItem(object sender, EventArgs e)
        {
            LoadCart();
        }

        private void UcCT_OnSoLuongThayDoi(object sender, EventArgs e)
        {
            uctt.LoadThanhtoan();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
