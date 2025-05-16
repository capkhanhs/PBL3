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
        public ucChitietdonhang(Don_Hang dh)
        {
            InitializeComponent();
            this.dh = dh;
            LoadData(dh);
            if (dh.Trang_thai_don_hang != "Đang xử lý")
            {
                button1.Visible = false;
                button1.Enabled = false;
            }
            if(dh.Trang_thai_don_hang == "Thành công")
            {
                button3.Visible = true;
                button3.Enabled = true;
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
    }
}
