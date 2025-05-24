using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL.BLL;
using PBL.Model;

namespace PBL.View
{
    public partial class DatHang_ThanhToan : UserControl
    {
        public delegate void btnDatHangClickHandler(object sender, EventArgs e);
        public event btnDatHangClickHandler btnDatHangClick;
        private string manguoidung;
        private string madiachi;
        private string phuongthucnhanhang;
        public DatHang_ThanhToan(string manguoidung, string madiachi, string phuongthucnhanhang)
        {
            InitializeComponent();
            this.madiachi = madiachi;
            this.manguoidung = manguoidung;
            this.phuongthucnhanhang = phuongthucnhanhang;
            Load();
        }

        public void Load()
        {
            lbl_gia.Text = string.Format("{0:0,0}", GioHangBLL.Instance.Tinhtong(manguoidung)) + " VNĐ";
            lbl_tong.Text = string.Format("{0:0,0}", GioHangBLL.Instance.Tinhtong(manguoidung)) + " VNĐ";
        }
        public void Loadpttt(string pttt)
        {
            this.phuongthucnhanhang = pttt; 
        }

        private void btnDatHang_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(phuongthucnhanhang))
            {
                MessageBox.Show("Bạn chưa chọn phương thức thanh toán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            if (MessageBox.Show("Bạn có chắc chắn muốn đặt hàng không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                btnDatHangClick?.Invoke(this, EventArgs.Empty);
                DonHangBLL.Instance.DatHang(manguoidung, madiachi, phuongthucnhanhang);
                foreach (var item in CartItemBLL.Instance.GetAllCart(manguoidung))
                {
                    SanphamBLL.Instance.themSoLuong(item.Ma_san_pham, Convert.ToInt32(-item.Quantity));
                }
            }
        }

        private void DatHang_ThanhToan_Load(object sender, EventArgs e)
        {

        }
    }
}
