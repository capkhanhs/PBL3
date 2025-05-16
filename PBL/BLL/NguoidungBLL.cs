using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using PBL.DAL;
using PBL.Model;

namespace PBL.BLL
{
    public class NguoidungBLL
    {
        UserDAL usDAL = new UserDAL();
        private static NguoidungBLL _Instance;
        public static NguoidungBLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new NguoidungBLL();
                }
                return _Instance;
            }
        }

        //Ham lấy tất cả người dùng
        public List<Nguoi_Dung> GetAll()
        {
            try
            {
                return usDAL.GetAll();
            }
            catch (Exception ex)
            {
                throw new Exception("Error fetching all users: " + ex.Message);
            }
        }

        //Hàm tìm kiếm người dùng theo tên
        public List<Nguoi_Dung> Search(string name)
        {
            try
            {
                List<Nguoi_Dung> list = new List<Nguoi_Dung>();
                foreach (var item in usDAL.GetAll())
                {
                    if (item.Ho_va_ten.ToLower().Contains(name.ToLower()))
                    {
                        list.Add(item);
                    }
                }
                return list;
            }
            catch (Exception ex)
            {
                throw new Exception("Error searching users: " + ex.Message);
            }
        }

        //Hàm tìm kiếm người dùng theo mã
        public Nguoi_Dung Find(string ma)
        {
            try
            {
                if (string.IsNullOrEmpty(ma))
                {
                    throw new ArgumentException("User ID cannot be empty.");
                }
                return usDAL.GetById(ma);
            }
            catch (Exception ex)
            {
                throw new Exception("Error finding user: " + ex.Message);
            }
        }

        //Hàm đăng nhập
        public bool Dang_nhap(string username, string password)
        {
            try
            {
                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    throw new ArgumentException("Username and password cannot be empty.");
                }
                bool isValid = false;
                var user = usDAL.GetById(username);
                if (user != null)
                {

                    bool passwordMatch = BCrypt.Net.BCrypt.Verify(password, user.password);
                    if (passwordMatch)
                        //if (user.password == password)
                    {
                        isValid = true;
                    }
                }
                else
                {
                    throw new KeyNotFoundException("User not found.");
                }
                if (!isValid)
                {
                    throw new UnauthorizedAccessException("Wrong password.");
                }
                return isValid;
            }
            catch (Exception ex)
            {
                throw new Exception("Login failed: " + ex.Message);
            }
        }

        public static bool IsValidPhoneNumber(string phone)
        {
            // Kiểm tra có đúng định dạng: bắt đầu bằng 0 và đủ 10 chữ số
            return Regex.IsMatch(phone, @"^0\d{9}$");
        }

        //Hàm đăng ký
        public void Register(string username, string password, string mavaitro, string HovaTen, bool gioitinh)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(HovaTen) || string.IsNullOrEmpty(mavaitro))
            {
                throw new ArgumentException("Vui lòng nhập đầy đủ thông tin");
            }
            if(password.Length < 6)
            {
                throw new ArgumentException("Mật khẩu phải có ít nhất 6 ký tự");
            }
            if (!IsValidPhoneNumber(username))
            {
                throw new ArgumentException("Số điện thoại không hợp lệ");
            }
            var user = usDAL.GetById(username);
            if (user != null)
            {
                throw new InvalidOperationException("Username already exists.");
            }
            string salt = BCrypt.Net.BCrypt.GenerateSalt();
            string hash = BCrypt.Net.BCrypt.HashPassword(password, salt);
            Nguoi_Dung newUser = new Nguoi_Dung
            {
                Ma_nguoi_dung = username,
                password = hash,
                Ma_vai_tro = mavaitro,
                Gioi_tinh = gioitinh,
                Ho_va_ten = HovaTen
            };
            usDAL.Add(newUser);
            usDAL.Save();
        }

        //Hàm đổi mật khẩu người dùng
        public void Doimatkhau(string matkhaucu, string matkhaumoi, string manguoidung)
        {
            if (string.IsNullOrEmpty(matkhaucu) || string.IsNullOrEmpty(matkhaumoi))
            {
                throw new ArgumentException("Vui lòng nhập đầy đủ thông tin");
            }
            var user = usDAL.GetById(manguoidung);
            bool passwordMatch = BCrypt.Net.BCrypt.Verify(matkhaucu, user.password);
            if (!passwordMatch)
            {
                throw new UnauthorizedAccessException("Mật khẩu không đúng");
            }
            else
            {
                if (matkhaumoi.Length < 6)
                {
                    throw new ArgumentException("Mật khẩu mới phải có ít nhất 6 ký tự");
                }
                string salt = BCrypt.Net.BCrypt.GenerateSalt();
                string hash = BCrypt.Net.BCrypt.HashPassword(matkhaumoi, salt);
                user.password = hash;
                usDAL.Update(user);
                usDAL.Save();
            }
        }

        //Hàm cập nhật vai trò người dùng
        public void UpdateRole(string ma, string mavaitro)
        {
            if (string.IsNullOrEmpty(ma) || string.IsNullOrEmpty(mavaitro))
            {
                throw new ArgumentException("Vui lòng nhập đầy đủ thông tin");
            }
            var user = usDAL.GetById(ma);
            if (user == null)
            {
                throw new KeyNotFoundException("User not found.");
            }
            user.Ma_vai_tro = mavaitro;
            usDAL.Update(user);
            usDAL.Save();
        }
    }
}
