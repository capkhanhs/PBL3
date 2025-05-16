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
    public partial class HoaDonMuaHang : Form
    {
        Don_Hang dh;
        public HoaDonMuaHang(Don_Hang dh)
        {
            InitializeComponent();
            this.dh = dh;
            LoadData();
        }

        public void LoadData()
        {
            var nd = NguoidungBLL.Instance.Find(dh.Ma_nguoi_dung);
            txtB_MaHoaDon.Text = dh.Ma_don_hang;
            dtP_NgayMua.Value = dh.Ngay_dat_hang.HasValue ? dh.Ngay_dat_hang.Value : DateTime.Now;
            textBox1.Text = nd.Ho_va_ten;
            textBox2.Text = nd.Ma_nguoi_dung;
            Dia_Chi diachi = DiaChiBLL.Instance.Find(dh.Ma_dia_chi);
            string diachitxt = "";
            if (!string.IsNullOrEmpty(diachi.Chi_tiet))
            {
                diachitxt = diachi.Chi_tiet + ", ";
            }
            diachitxt += diachi.Xa_Phuong + ", " + diachi.Quan_Huyen + ", " + diachi.Tinh_ThanhPho;
            textBox3.Text = diachitxt;
            textBox6.Text = DonHangBLL.Instance.TinhTongGiaTriDonHang(dh.Ma_don_hang).ToString("C0") + " VNĐ";
            dataGridView1.DataSource = ChiTietDonHangBLL.Instance.GetChiTietDonHangByMaDH(dh.Ma_don_hang);
            textBox7.Text = textBox6.Text;
        }
    }
}
