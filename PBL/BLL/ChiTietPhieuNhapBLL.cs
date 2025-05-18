using PBL.DAL;
using PBL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PBL.BLL
{
    public class ChiTietPhieuNhapBLL
    {
        private ChiTietPhieuNhapDAL chiTietPhieuNhapDAL = new ChiTietPhieuNhapDAL();
        private static ChiTietPhieuNhapBLL _Instance;
        public static ChiTietPhieuNhapBLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new ChiTietPhieuNhapBLL();
                }
                return _Instance;
            }
        }

        public List<Chi_Tiet_Phieu_Nhap> GetAll()
        {
            return chiTietPhieuNhapDAL.GetAll().ToList();
        }

        public string TaoMaChiTietPhieuNhapMoi()
        {
            int maxSo = 0;
            List<Chi_Tiet_Phieu_Nhap> list = this.GetAll();

            if (list != null && list.Count > 0)
            {
                foreach (var i in list)
                {
                    string maPN = i.Ma_ctpn;
                    if (!string.IsNullOrEmpty(maPN) && maPN.StartsWith("CTPN") && maPN.Length >= 6)
                    {
                        string numberPart = maPN.Substring(4);
                        if (int.TryParse(numberPart, out int so))
                        {
                            if (so > maxSo) maxSo = so;
                        }
                    }
                }
            }

            int newSo = maxSo + 1;
            return "CTPN" + newSo.ToString("D2"); //Lấy 2 số đuôi
        }

        //Hàm tạo CTPN
        public Chi_Tiet_Phieu_Nhap tao_CTPN(Phieu_Nhap_Kho pnk, String maSP, String soLuong, String giaNhap)
        {
            Chi_Tiet_Phieu_Nhap ct = new Chi_Tiet_Phieu_Nhap();
            ct.Ma_ctpn = this.TaoMaChiTietPhieuNhapMoi();
            ct.Ma_phieu = pnk.Ma_phieu;
            ct.Ma_san_pham = maSP;
            ct.So_luong = int.Parse(soLuong);
            ct.Gia_nhap = giaNhap;
            ct.Thanh_tien = (int.Parse(soLuong) * int.Parse(giaNhap)).ToString();

            return ct;
        }

        public void them_ChiTietPhieuNhap(Chi_Tiet_Phieu_Nhap item)
        {
            chiTietPhieuNhapDAL.Add(item);
            chiTietPhieuNhapDAL.Save();
        }

        //Lấy CTPN theo phiếu nhập kho
        public List<Chi_Tiet_Phieu_Nhap> getCTPN_byMPN(String ma_PNK)
        {
            return chiTietPhieuNhapDAL.GetAll().Where(x => x.Ma_phieu == ma_PNK).ToList();
        }

        //Vì các giá nhập là như nhau cho mỗi sản phẩm
        public String get_giaNhap(string maSP)
        {
            if (string.IsNullOrEmpty(maSP))
                throw new Exception("Mã sản phẩm trống!");

            var item = this.GetAll().FirstOrDefault(x => x.Ma_san_pham == maSP);
            if (item == null)
                throw new Exception("Không có sản phẩm nào có mã sp: " + maSP);

            return item.Gia_nhap;
        }
    }
}
