 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL.DAL;
using PBL.Model;

namespace PBL.BLL
{
    public class DonHangBLL
    {
        DonHangDAL dhdal = new DonHangDAL();
        private static DonHangBLL _Instance;
        public static DonHangBLL Instance
        {
            get
            {
                if(_Instance == null)
                
                    _Instance = new DonHangBLL();
                                 return _Instance;
            }
        }

        public List<Don_Hang> Get_DH_ThanhCong()
        {
            return dhdal.GetAll().Where(dh => dh.Trang_thai_don_hang == "Thành công").ToList();
        }
    }
}
