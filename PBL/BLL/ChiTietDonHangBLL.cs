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

        //Lấy danh sách chi tiết đơn hàng theo mã đơn hàng và đã gom theo danh mục
        public List<Model.Chi_Tiet_Don_Hang> GetByMaDH(List<Don_Hang> dh)
        {
                List<Model.Chi_Tiet_Don_Hang> list_ctdh = new List<Model.Chi_Tiet_Don_Hang>();
                foreach (var item in dh)
                {
                    var li = ChiTietDonHangDAL.GetAll().Where(x => x.Ma_don_hang == item.Ma_don_hang).ToList();
                    if (li.Count > 0)
                    {
                        list_ctdh.AddRange(li);
                    }
                }

                //List<San_Pham> listSP = new List<San_Pham>();   
                //List<Danh_Muc> listDM = new List<Danh_Muc>();

                var li_gr = list_ctdh.GroupBy(x => x.San_Pham.Danh_Muc.Ten_danh_muc)
                .Select(g => new Chi_Tiet_Don_Hang()
                {
                    Ma_don_hang = g.FirstOrDefault().Ma_don_hang,
                    Ma_san_pham = g.FirstOrDefault().Ma_san_pham,
                    So_luong = g.Sum(x => x.So_luong),
                    Gia_ban = g.FirstOrDefault().Gia_ban,
                   
                })
                .ToList();

        
            return li_gr;
        }

    }
}
