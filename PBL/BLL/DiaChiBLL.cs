using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL.DAL;
using PBL.Model;

namespace PBL.BLL
{
    public class DiaChiBLL
    {
        DiaChiDAL diachidal = new DiaChiDAL();
        private static DiaChiBLL _Instance;
        public static DiaChiBLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DiaChiBLL();
                }
                return _Instance;
            }
            private set { }
        }


        public List<Model.Dia_Chi> GetAll()
        {
            try
            {
                return diachidal.GetAll();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi lấy danh sách địa chỉ: " + ex.Message);
            }
        }

        public Dia_Chi Find(string maDiaChi)
        {
            try
            {
                return diachidal.GetById(maDiaChi);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi tìm địa chỉ: " + ex.Message);
            }
        }

        public void Add(Dia_Chi diaChi)
        {
            try
            {
                diachidal.Add(diaChi);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi thêm địa chỉ: " + ex.Message);
            }
        }



    }
}
