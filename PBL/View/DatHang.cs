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
        public DatHang_ThanhToan dh;
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
            if (diachi.Count > 0)
            {
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

                cbbDiaChi.DataSource = diachiView; //Dùng danh sách đã định dạng
                cbbDiaChi.DisplayMember = "DiaChiDayDu";
                cbbDiaChi.ValueMember = "Ma_dia_chi";
            }
            else
            {
                MessageBox.Show("Bạn chưa có địa chỉ nào, hãy thêm địa chỉ mới");
                CapNhatDiaChi cn = new CapNhatDiaChi(manguoidung);
                cn.ShowDialog();
                if(cn.DialogResult == DialogResult.OK)
                {
                    LoadData();
                }
                else
                {
                    this.Close();
                    return;
                }
            }

            var cartItems = CartItemBLL.Instance.GetAllCart(manguoidung);
            foreach (var item in cartItems)
            {
                ucDonHangItem_DatHang uc = new ucDonHangItem_DatHang(item);
                flpnmain.Controls.Add(uc);
            }
            string pttt = null;
            try
            {
                dh = new DatHang_ThanhToan(manguoidung, cbbDiaChi.SelectedValue.ToString(), pttt);
                dh.btnDatHangClick += DatHangThanhCong;
                flpnmain.Controls.Add(dh);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        public void DatHangThanhCong(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void rdbThanhtoankhinhan_CheckedChanged(object sender, EventArgs e)
        {
            string pttt = "Thanh toán khi nhận hàng";
            dh.Loadpttt(pttt);
        }

        private void rdbThanhtoanonline_CheckedChanged(object sender, EventArgs e)
        {
            string pttt = "Thanh toán online";
            dh.Loadpttt(pttt);
        }
    }
}
