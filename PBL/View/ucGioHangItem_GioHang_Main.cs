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
        San_Pham sp;
        public delegate void SoLuongThayDoiHandler(object sender, EventArgs e);
        public event SoLuongThayDoiHandler OnSoLuongThayDoi;
        public delegate void XoaItemHandler(object sender, EventArgs e);
        public event XoaItemHandler OnXoaItem;
        private CartItem cartitem;
        public ucGioHangItem_GioHang_Main(CartItem cartitem)
        {
            InitializeComponent();
            this.cartitem = cartitem;
            LoadData();
        }

        public void LoadData()
        {
            sp = SanphamBLL.Instance.Find(cartitem.Ma_san_pham);
            if (sp != null)
            {
                lblTenSanPham.Text = sp.Ten_sp;
                // Ép kiểu sang long để tránh tràn số khi tính toán
                long donGia = long.Parse(sp.Gia_sp);
                int soLuong = cartitem.Quantity.GetValueOrDefault(1);
                long giaban = donGia * soLuong;
                label1.Text = string.Format("{0:0,0}", giaban) + " VNĐ";
                lblMoTa.Text = sp.Mo_ta_sp;
                txt_soluong.Text = soLuong.ToString();
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
            CartItemBLL.Instance.UpdateCart_In_Des(cartitem, true);
            txt_soluong.Text = cartitem.Quantity.ToString();
            OnSoLuongThayDoi?.Invoke(this, EventArgs.Empty);
            long giaban = (long)(long.Parse(sp.Gia_sp) * cartitem.Quantity.GetValueOrDefault(1));
            label1.Text = string.Format("{0:0,0}", giaban) + " VNĐ";
        }

        private void btnGiam_Click(object sender, EventArgs e)
        {
            CartItemBLL.Instance.UpdateCart_In_Des(cartitem, false);
            txt_soluong.Text = cartitem.Quantity.ToString();
            OnSoLuongThayDoi?.Invoke(this, EventArgs.Empty);
            long giaban = (long)(long.Parse(sp.Gia_sp) * cartitem.Quantity.GetValueOrDefault(1));
            label1.Text = string.Format("{0:0,0}", giaban) + " VNĐ";
        }

        private void txt_soluong_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt_soluong_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (int.TryParse(txt_soluong.Text, out int newQuantity))
                {
                    if (newQuantity > 0)
                    {
                        CartItemBLL.Instance.UpdateCart(cartitem, newQuantity);
                        long giaban = (long.Parse(sp.Gia_sp) * newQuantity);
                        label1.Text = string.Format("{0:0,0}", giaban) + " VNĐ";
                        OnSoLuongThayDoi?.Invoke(this, EventArgs.Empty);
                    }
                    else
                    {
                        MessageBox.Show("Số lượng không hợp lệ (phải > 0)");
                        txt_soluong.Text = cartitem.Quantity.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Số lượng không hợp lệ (phải là số nguyên)");
                    txt_soluong.Text = cartitem.Quantity.ToString();
                }

                // Không cho xuống dòng (nếu là multiline textbox)
                e.SuppressKeyPress = true;
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này khỏi giỏ hàng không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                CartItemBLL.Instance.DeleteIteminCart(cartitem);
                OnXoaItem?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
