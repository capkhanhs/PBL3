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
            if (string.IsNullOrEmpty(cartId) || string.IsNullOrEmpty(SPID))
            {
                throw new ArgumentException("Cart ID and Product ID cannot be null or empty.");
            }
            if (ciDAL.GetAll().Any(x => x.Ma_gio_hang == cartId && x.Ma_san_pham == SPID))
            {
                UpdateCart_In_Des(cartId, SPID, true);
                ciDAL.Save();
                return;
            }
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

        public void UpdateCart_In_Des(string magiohang, string masp, bool tang)
        {
            CartItem cartItem = ciDAL.GetAll().FirstOrDefault(x => x.Ma_gio_hang == magiohang && x.Ma_san_pham == masp);
            if (cartItem != null)
            {
                if (tang)
                {
                    cartItem.Quantity++;
                }
                else
                {
                    if (cartItem.Quantity > 1)
                    {
                        cartItem.Quantity--;
                    }
                    else
                    {
                        DeleteIteminCart(magiohang, masp);
                        return;
                    }
                    ciDAL.Update(cartItem);
                }
            }
            ciDAL.Save();
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
