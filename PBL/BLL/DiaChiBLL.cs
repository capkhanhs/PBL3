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

        private string GenerateNewMaDC(List<Dia_Chi> list)
        {
            int maxNumber = 0;
            foreach (var dc in list)
            {
                if (dc.Ma_dia_chi != null && dc.Ma_dia_chi.StartsWith("DC"))
                {
                    string numPart = dc.Ma_dia_chi.Substring(2);
                    if (int.TryParse(numPart, out int number))
                    {
                        if (number > maxNumber)
                            maxNumber = number;
                    }
                }
            }
            return "DC" + (maxNumber + 1).ToString("D2");
        }


        public void Add(Dia_Chi diaChi)
        {
            try
            {
                List<Dia_Chi> list = diachidal.GetAll(); // hoặc dùng GetLast() nếu có
                string newID = GenerateNewMaDC(list);
                diaChi.Ma_dia_chi = newID;
                diachidal.Add(diaChi);
                diachidal.Save();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi thêm địa chỉ: " + ex.Message);
            }
        }



    }
}
