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
        private NguoiDungDiaChiBLL _Instace;
        public NguoiDungDiaChiBLL Instace
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
    }
}
