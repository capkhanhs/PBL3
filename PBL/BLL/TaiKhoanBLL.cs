using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL.DAL;

namespace PBL.BLL
{
    public class TaiKhoanBLL
    {
        TaiKhoanDAL tkDAL = new TaiKhoanDAL();
        private static TaiKhoanBLL _Instance;
        public static TaiKhoanBLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new TaiKhoanBLL();
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
            if (tkDAL.GetById(username) != null) 
            {
                if (tkDAL.GetById(username).Mat_khau == password)
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
        public void Register(string username, string password)
        {
            // Implement your registration logic here
            // For example, save the user to a database or a list of users
        }
    }
}
