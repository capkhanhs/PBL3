using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL.DAL;

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
    }
}
