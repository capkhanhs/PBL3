using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

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

        public void AddCart(string cartId, string SPID, int soluong)
        {

        }
    }
}
