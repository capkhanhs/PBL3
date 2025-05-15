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
    public partial class DatHang : Form
    {
        private string manguoidung;
        public DatHang(string manguoidung)
        {
            InitializeComponent();
            this.manguoidung = manguoidung;
            LoadData();
        }
        public void LoadData()
        {
            Nguoi_Dung user = NguoidungBLL.Instance.Find(manguoidung);
            txtHoTen.Text = user.Ho_va_ten;
            txtSDT.Text = user.Ma_nguoi_dung;
            List<Dia_Chi> diachi = NguoiDungDiaChiBLL.Instace.LoadAddress(manguoidung);
            var diachiView = diachi.Select(d => new
            {
                Ma_dia_chi = d.Ma_dia_chi,
                DiaChiDayDu = string.Join(", ", new string[] {
                d.Chi_tiet,
                d.Xa_Phuong,
                d.Quan_Huyen,
                d.Tinh_ThanhPho
            }.Where(s => !string.IsNullOrWhiteSpace(s)))
            }).ToList();
            if (diachi.Count > 0)
            {
                cbbDiaChi.DataSource = diachi;
                cbbDiaChi.DisplayMember = "DiaChiDayDu";
                cbbDiaChi.ValueMember = "Ma_dia_chi";
            }
            else
            {
                MessageBox.Show("Bạn chưa có địa chỉ nào, hãy thêm địa chỉ mới");
            }
            var cartItems = CartItemBLL.Instance.GetAllCart(manguoidung);
            foreach (var item in cartItems)
            {
                ucGioHangItem_GioHang_Main ucGioHangItem = new ucGioHangItem_GioHang_Main(item);
                flpnmain.Controls.Add(ucGioHangItem);
            }
            string pttt;
            if(rdbThanhtoanonline.Checked)
            {
                 pttt = "Thanh toán online";
            }
            else
            {
                 pttt = "Thanh toán khi nhận hàng";
            }

            //DatHang_ThanhToan dh = new DatHang_ThanhToan(manguoidung, cbbDiaChi.SelectedValue.ToString(), pttt);
            //flpnmain.Controls.Add(dh);
        }
    }
}
