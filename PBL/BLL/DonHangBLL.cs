 using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL.DAL;
using PBL.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace PBL.BLL
{
    public class DonHangBLL
    {
        DonHangDAL dhdal = new DonHangDAL();
        private static DonHangBLL _Instance;
        public static DonHangBLL Instance
        {
            get
            {
                if (_Instance == null)

                    _Instance = new DonHangBLL();
                return _Instance;
            }
        }

        //Lấy danh sách đơn hàng thành công
        public List<Don_Hang> Get_DH_ThanhCong()
        {
            return dhdal.GetAll().Where(dh => dh.Trang_thai_don_hang == "Thành công").ToList();
        }

        //Hàm tạo mã đơn hàng tự động
        private string GenerateNewMaDH(List<Don_Hang> list)
        {
            int maxNumber = 0;
            foreach (var dh in list)
            {
                if (dh.Ma_don_hang != null && dh.Ma_don_hang.StartsWith("DH"))
                {
                    string numPart = dh.Ma_don_hang.Substring(2);
                    if (int.TryParse(numPart, out int number))
                    {
                        if (number > maxNumber)
                            maxNumber = number;
                    }
                }
            }
            return "DH" + (maxNumber + 1).ToString("D2");
        }

        //Hàm tạo đơn hàng mới
        public void TaoDonHang(string manguoidung, string madiachi, DateTime ngaydathang, string phuongthucthanhtoan)
        {
            Don_Hang don_Hang = new Don_Hang();
            don_Hang.Ma_don_hang = GenerateNewMaDH(dhdal.GetAll());
            don_Hang.Ma_nguoi_dung = manguoidung;
            don_Hang.Ma_dia_chi = madiachi;
            don_Hang.Ngay_dat_hang = ngaydathang;
            don_Hang.Trang_thai_don_hang = "Đang xử lý";
            don_Hang.Phuong_thuc_thanh_toan = phuongthucthanhtoan;
        }

        //Hàm lấy đơn hàng theo trạng thái
        public List<Don_Hang> Get_DH_TheoTrangThai(string trangthai)
        {
            if (string.Compare(trangthai, "Tất cả") > 0)
            {
                return dhdal.GetAll();
            }
            return dhdal.GetAll().Where(dh => dh.Trang_thai_don_hang == trangthai).ToList();
        }

        //Hàm lấy đơn hàng theo trạng thái của 1 người dùng
        public List<Don_Hang> Get_DH_TheoTrangThai(string trangthai, string manguoidung)
        {
            try
            {
                if (trangthai == "Tất cả")
                {
                    return dhdal.GetAll().Where(dh => dh.Ma_nguoi_dung == manguoidung).ToList();
                }
                return dhdal.GetAll().Where(dh => dh.Trang_thai_don_hang == trangthai && dh.Ma_nguoi_dung == manguoidung).ToList();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lấy danh sách đơn hàng theo trạng thái: " + ex.Message);
                return null;
            }
        }


        public void Thaydoitrangthai(string madonhang, string trangthai)
        {
            Don_Hang don_Hang = dhdal.GetById(madonhang);
            if (don_Hang != null)
            {
                don_Hang.Trang_thai_don_hang = trangthai;
                dhdal.Update(don_Hang);
            }
            else
            {
                throw new Exception("Đơn hàng không tồn tại");
            }
        }

        //Hàm xóa đơn hàng
        public void XoaDonHang(string madonhang)
        {
            Don_Hang don_Hang = dhdal.GetById(madonhang);
            if (don_Hang != null)
            {
                dhdal.Delete(don_Hang);
            }
            else
            {
                throw new Exception("Đơn hàng không tồn tại");
            }
        }

        //Hàm đặt hàng
        public void DatHang(string manguoidung, string madiachi, string phuongthucthanhtoan)
        {
            try
            {
                Don_Hang don_Hang = new Don_Hang();
                don_Hang.Ma_don_hang = GenerateNewMaDH(dhdal.GetAll());
                don_Hang.Ma_nguoi_dung = manguoidung;
                don_Hang.Ngay_dat_hang = DateTime.Now;
                don_Hang.Ma_dia_chi = madiachi;
                don_Hang.Trang_thai_don_hang = "Đang xử lý";
                don_Hang.Phuong_thuc_thanh_toan = phuongthucthanhtoan;
                dhdal.Add(don_Hang);
                dhdal.Save();
                var item = CartItemBLL.Instance.GetAllCart(manguoidung);
                foreach (var i in item)
                {
                    int giaban = (int)(int.Parse(SanphamBLL.Instance.Find(i.Ma_san_pham).Gia_sp) * i.Quantity.GetValueOrDefault(1));
                    ChiTietDonHangBLL.Instance.AddChiTietDonHang(
                        don_Hang.Ma_don_hang,
                        i.Ma_san_pham,
                        i.Quantity.GetValueOrDefault(1),
                        giaban.ToString()
                    );
                }
                MessageBox.Show("Đặt hàng thành công");
                CartItemBLL.Instance.DeleteRange(CartItemBLL.Instance.GetAllCart(manguoidung));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đặt hàng: " + ex.Message);
            }
        }

        //Hàm tính tổng giá trị đơn hàng
        public long TinhTongGiaTriDonHang(string madonhang)
        {
            var donHang = dhdal.GetById(madonhang);
            if (donHang != null)
            {
                var chiTietDonHang = ChiTietDonHangBLL.Instance.GetChiTietDonHangByMaDH(madonhang);
                long tongGiaTri = 0;
                foreach (var item in chiTietDonHang)
                {
                    tongGiaTri += long.Parse(item.Thanh_tien);
                }
                return tongGiaTri;
            }
            else
            {
                throw new Exception("Đơn hàng không tồn tại");
            }
        }

        //Hàm tính số lượng sản phẩm trong đơn hàng
        public int TinhSoLuongSanPham(string madonhang)
        {
            var donHang = dhdal.GetById(madonhang);
            if (donHang != null)
            {
                var chiTietDonHang = ChiTietDonHangBLL.Instance.GetChiTietDonHangByMaDH(madonhang);
                int soLuong = 0;
                foreach (var item in chiTietDonHang)
                {
                    soLuong++;
                }
                return soLuong;
            }
            else
            {
                throw new Exception("Đơn hàng không tồn tại");
            }
        }

    }
}
