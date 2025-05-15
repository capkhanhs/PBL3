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

        //Ham sua dia chi
        public void Update(Dia_Chi diaChi, string madiachi)
        {
            try
            {
                Dia_Chi existingDiaChi = diachidal.GetById(madiachi);
                if (existingDiaChi != null)
                {
                    existingDiaChi.Tinh_ThanhPho = diaChi.Tinh_ThanhPho;
                    existingDiaChi.Quan_Huyen = diaChi.Quan_Huyen;
                    existingDiaChi.Xa_Phuong = diaChi.Xa_Phuong;
                    existingDiaChi.Chi_tiet = diaChi.Chi_tiet;
                    diachidal.Update(existingDiaChi);
                    diachidal.Save();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi cập nhật địa chỉ: " + ex.Message);
            }
        }

        //Hàm load địa chỉ của 1 người dùng
        public List<Dia_Chi> GetDiaChiByMaNguoiDung(List<nguoiDung_diaChi> nddc)
        {
            try
            {
                List<Dia_Chi> list = new List<Dia_Chi>();
                foreach (var item in nddc)
                {
                    Dia_Chi diaChi = diachidal.GetById(item.Ma_dia_chi);
                    if (diaChi != null)
                    {
                        list.Add(diaChi);
                    }
                }
                return list;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi lấy địa chỉ của người dùng: " + ex.Message);
            }
        }

    }
}
