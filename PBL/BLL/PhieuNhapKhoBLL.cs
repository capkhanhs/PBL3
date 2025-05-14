using PBL.DAL;
using PBL.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PBL.BLL
{
    public class PhieuNhapKhoBLL
    {
        private PhieuNhapKhoDAL phieuNhapKhoDAL = new PhieuNhapKhoDAL();
        private static PhieuNhapKhoBLL _Instance;
        public static PhieuNhapKhoBLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new PhieuNhapKhoBLL();
                }
                return _Instance;
            }
        }

        public List<Phieu_Nhap_Kho> GetAll()
        {
            return phieuNhapKhoDAL.GetAll().ToList();
        }

        public string TaoMaPhieuNhapMoi()
        {
            int maxSo = 0;
            List<Phieu_Nhap_Kho> list = this.GetAll();

            if (list != null && list.Count > 0)
            {
                foreach (var i in list)
                {
                    string maPN = i.Ma_phieu;
                    if (!string.IsNullOrEmpty(maPN) && maPN.StartsWith("PN") && maPN.Length >= 4)
                    {
                        string numberPart = maPN.Substring(2);
                        if (int.TryParse(numberPart, out int so))
                        {
                            if (so > maxSo) maxSo = so;
                        }
                    }
                }
            }

            int newSo = maxSo + 1;
            return "PN" + newSo.ToString("D2"); //Lấy 2 số đuôi
        }

        public Phieu_Nhap_Kho tao_PNK()
        {
            Phieu_Nhap_Kho new_pmk = new Phieu_Nhap_Kho();
            String maPNK = TaoMaPhieuNhapMoi();
            String maND = "ND01"; //Tạo cố định, phải sửa khi merge form
            DateTime dateTime = DateTime.Now;
            String tongTien = "0"; //tăng theo số lượng sản phẩm add vào 

            new_pmk.Ma_phieu = maPNK;
            new_pmk.Ma_nguoi_dung = maND;
            new_pmk.Ngay_tao = dateTime;
            new_pmk.Tongtien = tongTien;
            
            return new_pmk;
        }

        public void them_phieuNhapKho(Phieu_Nhap_Kho pnk)
        {
            phieuNhapKhoDAL.Add(pnk);
            phieuNhapKhoDAL.Save();
        }
    }
}
