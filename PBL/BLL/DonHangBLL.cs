 using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL.DAL;
using PBL.Model;

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
                if(_Instance == null)
                
                    _Instance = new DonHangBLL();
                                 return _Instance;
            }
        }

        public List<Don_Hang> Get_DH_ThanhCong()
        {
            return dhdal.GetAll().Where(dh => dh.Trang_thai_don_hang == "Thành công").ToList();
        }

        //Hàm tạo mã đơn hàng từ động
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
            if(string.Compare(trangthai, "Tất cả") > 0)
            {
                return dhdal.GetAll();
            }    
            return dhdal.GetAll().Where(dh => dh.Trang_thai_don_hang == trangthai).ToList();
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

    }
}
