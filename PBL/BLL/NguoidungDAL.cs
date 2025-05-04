using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL.DAL;
using PBL.Model;

namespace PBL.BLL
{
    public class NguoidungDAL
    {
        UserDAL usDAL = new UserDAL();
        private static NguoidungDAL _Instance;
        public static NguoidungDAL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new NguoidungDAL();
                }
                return _Instance;
            }
        }

        public bool Dang_nhap(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                throw new ArgumentException("Username and password cannot be empty.");
            }
            bool isValid = false;
            var user = usDAL.GetById(username);
            if (user != null) 
            {
                if (user.password == password)
                {
                    isValid = true;
                }
            }
            if (!isValid)
            {
                throw new UnauthorizedAccessException("Invalid username or password.");
            }
            return isValid;
        }
        public string GetMaNguoiDung(string username)
        {
            if (string.IsNullOrEmpty(username))
            {
                throw new ArgumentException("Username cannot be empty.");
            }
            var user = usDAL.GetById(username);
            if (user == null)
            {
                throw new KeyNotFoundException("User not found.");
            }
            return user.Ma_nguoi_dung;
        }
        public void Register(string username, string password, string mavaitro, string sdt, string HovaTen, bool gioitinh)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                throw new ArgumentException("Username and password cannot be empty.");
            }
            var user = usDAL.GetById(username);
            if (user != null)
            {
                throw new InvalidOperationException("Username already exists.");
            }
            Nguoi_Dung newUser = new Nguoi_Dung
            {
                Ma_nguoi_dung = username,
                password = password,
                Ma_vai_tro = mavaitro,
                Gioi_tinh = gioitinh,
                Sdt = sdt,
                Ho_va_ten = HovaTen,

            };
            usDAL.Add(newUser);
        }
    }
}
