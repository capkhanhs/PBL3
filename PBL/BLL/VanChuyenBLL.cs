using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL.DAL;
using PBL.Model;

namespace PBL.BLL
{
    public class VanChuyenBLL
    {
        VanChuyenDAL dAL = new VanChuyenDAL();
        private static VanChuyenBLL _Instance;
        public static VanChuyenBLL Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new VanChuyenBLL();
                return _Instance;
            }
            set { }
        }

        // Hàm lấy tất cả vận chuyển
        public List<Van_Chuyen> GetAll()
        {
            try
            {
                return dAL.GetAll();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách vận chuyển: " + ex.Message);
            }
        }

        private string GenerateNewMaVD(List<Van_Chuyen> list)
        {
            int maxNumber = 0;
            foreach (var vc in list)
            {
                if (vc.Ma_van_don != null && vc.Ma_van_don.StartsWith("MVD"))
                {
                    string numPart = vc.Ma_van_don.Substring(3);
                    if (int.TryParse(numPart, out int number))
                    {
                        if (number > maxNumber)
                            maxNumber = number;
                    }
                }
            }
            return "MVD" + (maxNumber + 1).ToString("D2");
        }

        public void themVanchuyen(string madon, DateTime ngaydukien, string ghichu, string manguoigiao)
        {
            if (string.IsNullOrEmpty(madon) || string.IsNullOrEmpty(manguoigiao))
            {
                throw new ArgumentException("Mã đơn hàng và mã người giao không được để trống.");
            }
            if(ngaydukien < DateTime.Now)
            {
                throw new ArgumentException("Ngày dự kiến giao hàng không được nhỏ hơn ngày hiện tại.");
            }
            Van_Chuyen vc = new Van_Chuyen
            {
                Ma_van_don = GenerateNewMaVD(dAL.GetAll()),
                Ma_don_hang = madon,
                Ngay_du_kien = ngaydukien,
                Ghi_chu = ghichu,
                Ma_nguoi_dung = manguoigiao,
                Ngay_bat_dau = DateTime.Now,
                Trang_thai = "Đang giao hàng"
            };
            dAL.Add(vc);
            dAL.Save();
            DonHangBLL.Instance.ChuyenTrangThai(DonHangBLL.Instance.GetDonHangById(madon));
        }

        public void capNhatTrangThaiGiao(string mdh, string ghichu, string trangthai)
        {
            Van_Chuyen vc = dAL.GetAll().FirstOrDefault(x => x.Ma_don_hang == mdh);
            if (vc == null)
            {
                throw new Exception("Không tìm thấy vận chuyển cho đơn hàng: " + mdh);
            }
            vc.Trang_thai = trangthai;
            vc.Ngay_ket_thuc = DateTime.Now;
            vc.Ghi_chu = ghichu;
            dAL.Update(vc);
            dAL.Save();
        }
    }
}
