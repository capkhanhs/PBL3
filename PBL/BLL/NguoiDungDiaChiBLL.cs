using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL.DAL;
using PBL.Model;

namespace PBL.BLL
{
    public class NguoiDungDiaChiBLL
    {
        NguoiDungDiaChiDAL NguoiDungDiaChiDAL = new NguoiDungDiaChiDAL();
        private static NguoiDungDiaChiBLL _Instace;
        public static NguoiDungDiaChiBLL Instace
        {
            get
            {
                if (_Instace == null)
                {
                    _Instace = new NguoiDungDiaChiBLL();
                }
                return _Instace;
            }
        }

        public List<nguoiDung_diaChi> GetAll()
        {
            try
            {
                return NguoiDungDiaChiDAL.GetAll();
            }
            catch (Exception ex)
            {
                throw new Exception("Error fetching all addresses: " + ex.Message);
            }
        }

        //Ham them dia chi cho nguoi dung
        public void ADD(string manguoidung, string madiachi)
        {
            try
            {
                nguoiDung_diaChi nguoidungdiachi = new nguoiDung_diaChi();
                nguoidungdiachi.Ma_nguoi_dung = manguoidung;
                nguoidungdiachi.Ma_dia_chi = madiachi;
                NguoiDungDiaChiDAL.Add(nguoidungdiachi);
                NguoiDungDiaChiDAL.Save();
            }
            catch (Exception ex)
            {
                throw new Exception("Error adding address: " + ex.Message);
            }

        }

        //Ham cap nhat dia chi nguoi dung
        public void Update(string tinhthanh, string quanhuyen, string phuongxa, string chitiet, string madiachi)
        {
            try
            {
                Dia_Chi diachi = new Dia_Chi();
                diachi.Tinh_ThanhPho = tinhthanh;
                diachi.Quan_Huyen = quanhuyen;
                diachi.Xa_Phuong = phuongxa;
                diachi.Chi_tiet = chitiet;
                DiaChiBLL.Instance.Update(diachi, madiachi);
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating address: " + ex.Message);
            }
        }

        //Ham kiem tra nguoi dung da co dia chi chua
        public bool CheckHaveAddress(string manguoidung)
        {
            try
            {
                var nguoidungdiachi = NguoiDungDiaChiDAL.GetAll().Where(x => x.Ma_nguoi_dung == manguoidung).ToList();
                if (nguoidungdiachi.Count > 0)
                    return true;
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("Error checking address existence: " + ex.Message);
            }
        }

        //Ham lay dia chi nguoi dung  
        public List<Dia_Chi> LoadAddress(string manguoidung)
        {
            try
            {
                List<nguoiDung_diaChi> nguoidungdiachi = NguoiDungDiaChiDAL.GetAll().Where(x => x.Ma_nguoi_dung == manguoidung).ToList();
                if (nguoidungdiachi != null)
                {
                    return DiaChiBLL.Instance.GetDiaChiByMaNguoiDung(nguoidungdiachi);
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Error loading address: " + ex.Message);
            }
        }

    }
}
