using PBL.DAL;
using PBL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public List<Model.San_Pham> GetByMaDH(List<Don_Hang> dh, DateTime start, DateTime end)
        {
                List<Model.Chi_Tiet_Don_Hang> list_ctdh = new List<Model.Chi_Tiet_Don_Hang>();
                foreach (var item in dh)
                {
                    if (item.Ngay_dat_hang >= start && item.Ngay_dat_hang <= end)
                    {    
                    var li = ChiTietDonHangDAL.GetAll().Where(x => x.Ma_don_hang == item.Ma_don_hang).ToList();
                        if (li.Count > 0)
                        {
                            list_ctdh.AddRange(li);
                        }
                    }
                }

                List<San_Pham> li_sp = new List<San_Pham>();
                li_sp = list_ctdh.GroupBy(x => x.San_Pham.Ma_san_pham).Select(g => 
                {
                    //mỗi nhóm g là tập hợp các chi tiết đơn hàng có mã sản phẩm giống nhau
                    var sp = g.First().San_Pham; //Lấy 1 sản phẩm làm đại diện
                    //Tạo sản phẩm mới với thông tin từ nhóm g
                    return new San_Pham
                    {
                        Ma_san_pham = sp.Ma_san_pham,
                        Ten_danh_muc = sp.Ten_danh_muc,
                        Ten_sp = sp.Ten_sp,
                        Gia_sp = g.First().Gia_ban,
                        Mo_ta_sp = sp.Mo_ta_sp,
                        Chi_tiet_san_pham = sp.Chi_tiet_san_pham,
                        So_luong = g.Sum(x => x.So_luong),
                        PictureFileName = sp.PictureFileName
                    };
                }).ToList();

            return li_sp;
        }

    }
}
