using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL.DAL;
using PBL.Model;

namespace PBL.BLL
{
    public class SanphamBLL
    {
        SanPhamDAL spDAL = new SanPhamDAL();
        private static SanphamBLL _Instance;
        public static SanphamBLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new SanphamBLL();
                }
                return _Instance;
            }
        }
        public List<San_Pham> GetAll()
        {
            return spDAL.GetAll();
        }

        public List<San_Pham> Search(string tenSP)
        {
            List<San_Pham> list = new List<San_Pham>();
            foreach (var item in spDAL.GetAll())
            {
                if (item.Ten_sp.ToLower().Contains(tenSP.ToLower()))
                {
                    list.Add(item);
                }
            }
            return list;
        }

        public List<San_Pham> LocTheoDanhMuc(string tenDM)
        {
            List<San_Pham> list = new List<San_Pham>();
            foreach (var item in spDAL.GetAll())
            {
                if (item.Danh_Muc.Ten_danh_muc.ToLower().Contains(tenDM.ToLower()))
                {
                    list.Add(item);
                }
            }
            return list;
        }

        public San_Pham Find(string masp)
        {
            if (string.IsNullOrEmpty(masp))
            {
                throw new Exception("Mã sản phẩm không được để trống");
            }
            else
            {
                San_Pham sp = spDAL.GetById(masp);
                if (sp == null)
                {
                    throw new Exception("Sản phẩm không tồn tại");
                }
                return spDAL.GetById(sp.Ma_san_pham);

            }
        }
        public void ThemSP(string masp, string tensp, string mancc, string tenDM, string giaSP, string Mo_ta_sp, string chi_tiet_sp, string picfilename)
        {
            if (string.IsNullOrEmpty(masp) || string.IsNullOrEmpty(tensp) || string.IsNullOrEmpty(mancc) || string.IsNullOrEmpty(tenDM) || string.IsNullOrEmpty(giaSP))
            {
                throw new Exception("Thông tin sản phẩm không được để trống");
            }

            if (decimal.TryParse(giaSP, out decimal gia))
            {
                if (gia < 0)
                {
                    throw new Exception("Giá sản phẩm không hợp lệ");
                }
            }
            else
            {
                throw new Exception("Giá sản phẩm không hợp lệ");
            }
            if (spDAL.GetById(masp) == null)
            {
                San_Pham sp = new San_Pham();
                sp.Ma_san_pham = masp;
                sp.Ten_sp = tensp;
                sp.Ten_danh_muc = tenDM;
                sp.Gia_sp = giaSP;
                sp.Mo_ta_sp = Mo_ta_sp;
                sp.Chi_tiet_san_pham = chi_tiet_sp;
                sp.So_luong = 0;
                spDAL.Add(sp);
                spDAL.Save();
            }
            else
            {
                throw new Exception("Mã sản phẩm đã tồn tại");
            }
        }

        //Hàm nhận vào 1 List sản phẩm và đưa ra tên sản phẩm bán chạy nhất -> sử dụng bên thống kê
        public string GetSPBanChay(List<San_Pham> list)
        {
            if (list == null || list.Count == 0)
            {
                return "";
            }
            try
            {
                //Sx ds theo số lượng giảm dần, lấy sản phẩm đầu tiên
                var spBanChay = list.OrderByDescending(x => x.So_luong).FirstOrDefault();
                if (spBanChay != null && !string.IsNullOrWhiteSpace(spBanChay.Ten_sp))
                {
                    return spBanChay.Ten_sp;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lấy sản phẩm bán chạy: " + ex.Message);
            }
            return "";
        }
    }
}
