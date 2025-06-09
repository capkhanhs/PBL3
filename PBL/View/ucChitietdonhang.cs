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
using PBL.Model;

namespace PBL.View
{
    public partial class ucChitietdonhang : UserControl
    {
        Don_Hang dh;
        public ucChitietdonhang(Don_Hang dh, bool nvbh)
        {
            InitializeComponent();
            this.dh = dh;
            LoadData(dh);
            if (dh.Trang_thai_don_hang != "Đang xử lý")
            {
                button1.Visible = false;
                button1.Enabled = false;
            }
            if (dh.Trang_thai_don_hang == "Thành công")
            {
                button3.Visible = true;
                button3.Enabled = true;
            }
            if (nvbh && dh.Trang_thai_don_hang == "Đã xác nhận")
            {
                button4.Visible = true;
                button4.Enabled = true;
            }
            if(nvbh && dh.Trang_thai_don_hang == "Đang xử lý")
            {
                button5.Visible = true;
                button5.Enabled = true;
            }
        }

        public void LoadData(Don_Hang dh)
        {
            lblMaDonHang.Text = dh.Ma_don_hang;
            if (dh.Ngay_dat_hang.HasValue)
            {
                label1.Text = dh.Ngay_dat_hang.Value.ToString("dd/MM/yyyy");
            }
            else
            {
                label1.Text = "N/A"; // Handle null case  
            }
            label3.Text = NguoidungBLL.Instance.Find(dh.Ma_nguoi_dung).Ho_va_ten;
            label2.Text = NguoidungBLL.Instance.Find(dh.Ma_nguoi_dung).Ma_nguoi_dung;
            label4.Text = DonHangBLL.Instance.TinhSoLuongSanPham(dh.Ma_don_hang).ToString();
            label5.Text = string.Format("{0:0,0}", DonHangBLL.Instance.TinhTongGiaTriDonHang(dh.Ma_don_hang)) + " VNĐ";
            label6.Text = dh.Trang_thai_don_hang;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            XemChitietdonhang uc = new XemChitietdonhang(dh);
            uc.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HoaDonMuaHang uc = new HoaDonMuaHang(dh);
            uc.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn hủy đơn hàng này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DonHangBLL.Instance.HuyDonHang(dh.Ma_don_hang);
                MessageBox.Show("Đơn hàng đã được hủy thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Parent.Controls.Remove(this); // Xóa điều khiển khỏi bố cục cha
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            formPhanCongGiao f = new formPhanCongGiao(dh);
            if (f.ShowDialog() == DialogResult.OK)
            {
                this.Parent.Controls.Remove(this); // Xóa điều khiển khỏi bố cục cha
            }
            f.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn xác nhận đơn hàng này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DonHangBLL.Instance.ChuyenTrangThai(dh);
                this.Parent.Controls.Remove(this); // Xóa điều khiển khỏi bố cục cha
            }
        }
    }
}
