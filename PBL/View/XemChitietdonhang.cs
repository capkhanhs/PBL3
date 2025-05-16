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
    public partial class XemChitietdonhang : Form
    {
        Don_Hang dh;
        public XemChitietdonhang(Don_Hang dh)
        {
            InitializeComponent();
            this.dh = dh;
            LoadData();
        }


        public void LoadData()
        {
            var nd = NguoidungBLL.Instance.Find(dh.Ma_nguoi_dung);
            label10.Text = dh.Ma_don_hang;
            label14.Text = dh.Ngay_dat_hang.HasValue ? dh.Ngay_dat_hang.Value.ToString("dd/MM/yyyy") : "N/A";
            label4.Text = nd.Ho_va_ten;
            label5.Text = nd.Ma_nguoi_dung;
            label15.Text = dh.Trang_thai_don_hang;
            Dia_Chi diachi = DiaChiBLL.Instance.Find(dh.Ma_dia_chi);
            string diachitxt = "";
            if (!string.IsNullOrEmpty(diachi.Chi_tiet))
            {
                diachitxt = diachi.Chi_tiet + ", ";
            }
            diachitxt += diachi.Xa_Phuong + ", " + diachi.Quan_Huyen + ", " + diachi.Tinh_ThanhPho;
            label6.Text = diachitxt;
            foreach (var item in ChiTietDonHangBLL.Instance.GetChiTietDonHangByMaDH(dh.Ma_don_hang))
            {
                ucChitietdonhang_Item uc = new ucChitietdonhang_Item(item);
                uc.LoadData(item);
                flowLayoutPanel2.Controls.Add(uc);
            }
            label9.Text = string.Format("{0:0,0}", DonHangBLL.Instance.TinhTongGiaTriDonHang(dh.Ma_don_hang)) + " VNĐ";
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
