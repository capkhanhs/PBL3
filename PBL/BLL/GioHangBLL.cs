using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL.BLL
{
    public class GioHangBLL
    {
        private static GioHangBLL _Instance;
        public static GioHangBLL Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new GioHangBLL();
                return _Instance;
            }
            private set { }
        }

        public long Tinhtong(string manguoidung)
        {
            long total = 0;
            foreach (var item in CartItemBLL.Instance.GetAllCart(manguoidung))
            {
                try
                {
                    var sanpham = SanphamBLL.Instance().GetAll().FirstOrDefault(x => x.Ma_san_pham == item.Ma_san_pham);
                    if (sanpham != null)
                    {
                        total += (long)(item.Quantity * int.Parse(sanpham.Gia_sp));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(item.Ma_san_pham, item.Ma_gio_hang);
                }

            }
            return total;
        }
    }
}
