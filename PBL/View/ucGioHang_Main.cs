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
                ucGioHangItem_GioHang_Main ucGioHangItem = new ucGioHangItem_GioHang_Main((int)item.Quantity, item.Ma_san_pham);
                pnMainGioHang.Controls.Add(ucGioHangItem);
            }
            ucDatHang_GioHang_Main ucDatHang = new ucDatHang_GioHang_Main(manguoidung);
            pnMainGioHang.Controls.Add(ucDatHang);
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
