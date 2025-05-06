using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL.DAL;
using PBL.Model;

namespace PBL.BLL
{

    public class CartItemBLL
    {   
        CartItemDAL ciDAL = new CartItemDAL();
        GioHangDAL ghDAL = new GioHangDAL();
        private static CartItemBLL _Instance;
        public static CartItemBLL Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new CartItemBLL();
                return _Instance;
            }
        }

        public void AddCart(string cartId, string SPID, int soluong)
        {
            CartItem cartItem = new CartItem();
            cartItem.Ma_gio_hang = cartId;
            cartItem.Ma_san_pham = SPID;
            cartItem.Quantity = soluong;
            ciDAL.Add(cartItem);
            ciDAL.Save();
        }

        public void UpdateCart(string cartId, string SPID, int soluong)
        {
            CartItem cartItem = ciDAL.GetAll().FirstOrDefault(x => x.Ma_gio_hang == cartId && x.Ma_san_pham == SPID);
            if (cartItem != null)
            {
                cartItem.Quantity = soluong;
                ciDAL.Update(cartItem);
                ciDAL.Save();
            }
        }

        public void DeleteIteminCart(string magiohang, string masp)
        {
            CartItem cartItem = ciDAL.GetAll().FirstOrDefault(x => x.Ma_gio_hang == magiohang && x.Ma_san_pham == masp);
            if (cartItem != null)
            {
                ciDAL.Delete(cartItem);
                ciDAL.Save();
            }
        }

        public List<CartItem> GetAllCart(string manguoidung)
        {
            return ciDAL.GetAll().Where(x => x.Ma_gio_hang == manguoidung).ToList();
        }
    }
}
