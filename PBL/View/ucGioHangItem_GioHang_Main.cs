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
    public partial class ucGioHangItem_GioHang_Main : UserControl
    {
        SanphamBLL sanphamBLL = new SanphamBLL();
        CartItemBLL cartItemBLL = new CartItemBLL();
        private string masanpham;
        private int soluong;
        public ucGioHangItem_GioHang_Main(int soluong, string masanpham)
        {
            InitializeComponent();
            this.masanpham = masanpham;
            this.soluong = soluong;
            LoadData();
        }

        public void LoadData()
        {
            var sp = sanphamBLL.GetAll().FirstOrDefault(x => x.Ma_san_pham == masanpham);
            if (sp != null)
            {
                lblTenSanPham.Text = sp.Ten_sp;
                lblGiaSP.Text = sp.Gia_sp.ToString();
                lblMoTa.Text = sp.Mo_ta_sp;
                txtSoluong.Text = soluong.ToString();
            }
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }
    }
}
