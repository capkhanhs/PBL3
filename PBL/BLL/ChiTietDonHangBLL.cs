using PBL.DAL;
using PBL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL.BLL
{
    public class ChiTietDonHangBLL
    {
        ChiTietDonHangDAL ChiTietDonHangDAL = new ChiTietDonHangDAL();
        private static ChiTietDonHangBLL _Instance;
        public static ChiTietDonHangBLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new ChiTietDonHangBLL();
                }
                return _Instance;
            }
            private set { }
        }

        // Lấy danh sách chi tiết đơn hàng
        public List<Model.Chi_Tiet_Don_Hang> GetAll()
        {
                return ChiTietDonHangDAL.GetAll();
        }

        //Lấy danh sách chi tiết đơn hàng theo mã đơn hàng
        public List<Model.Chi_Tiet_Don_Hang> GetByMaDH(List<Don_Hang> dh)
        {
            List<Model.Chi_Tiet_Don_Hang> list = new List<Model.Chi_Tiet_Don_Hang>();
            foreach (var item in dh)
            {
                var list1 = ChiTietDonHangDAL.GetAll().Where(x => x.Ma_don_hang == item.Ma_don_hang).ToList();
                if (list1.Count > 0)
                {
                    list.AddRange(list1);
                }
            }
            return list;
        }
    }
}
