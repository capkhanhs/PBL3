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

        //Tạo 1 chi tiết giỏ hàng mới, nếu đã có thì tăng số lượng lên 1
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

        //Cập nhật số lượng sản phẩm trong giỏ hàng
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

        //Cập nhật số lượng sản phẩm trong giỏ hàng với đối tượng CartItem
        public void UpdateCart(CartItem cartItem, int soluong)
        {
            if (cartItem != null)
            {
                cartItem.Quantity = soluong;
                ciDAL.Update(cartItem);
                ciDAL.Save();
            }
        }

        //Tăng giảm số lượng 1 đơn vị
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

        //Cũng là tăng giảm số lượng 1 đơn vị nhưng Overloading
        public void UpdateCart_In_Des(CartItem cartItem, bool tang)
        {
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
                    ciDAL.Update(cartItem);
                }
            }
            ciDAL.Save();
        }

        //Xóa 1 chi tiết giỏ hàng
        public void DeleteIteminCart(string magiohang, string masp)
        {
            CartItem cartItem = ciDAL.GetAll().FirstOrDefault(x => x.Ma_gio_hang == magiohang && x.Ma_san_pham == masp);
            if (cartItem != null)
            {
                ciDAL.Delete(cartItem.Ma_san_pham, cartItem.Ma_gio_hang);
                ciDAL.Save();
            }
        }

        //Xóa 1 chi tiết giỏ hàng với đối tượng CartItem
        public void DeleteIteminCart(CartItem cartItem)
        {
            if (cartItem != null)
            {
                ciDAL.Delete(cartItem.Ma_gio_hang,cartItem.Ma_san_pham);
                ciDAL.Save();
            }
        }

        //Lấy tất cả chi tiết giỏ hàng của 1 người dùng 
        public List<CartItem> GetAllCart(string manguoidung)
        {
            return ciDAL.GetAll().Where(x => x.Ma_gio_hang == manguoidung).ToList();
        }

        //Lấy 1 chi tiết giỏ hàng theo khóa chính (mã giỏ hàng, mã sản phẩm)
        public CartItem GetById (List<string> id)
        {
            try
            {
                if (id == null || id.Count == 0)
                {
                    throw new ArgumentException("ID list cannot be null or empty.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error getting cart item by ID: " + ex.Message);
            }
            return ciDAL.GetById(id);
        }

        //Xóa tất cả các sản phẩm trong giỏ hàng
        public void DeleteRange(List<CartItem> ci)
        {
            foreach(var i in ci)
            {
                ciDAL.Delete(i.Ma_gio_hang, i.Ma_san_pham);
            }
            ciDAL.Save();
        }
    }
}
