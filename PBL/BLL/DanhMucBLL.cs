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
    public class DanhMucBLL
    {
        private DanhMucDAL DanhMucDAL = new DanhMucDAL();
        private static DanhMucBLL _Instance;

        public static DanhMucBLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DanhMucBLL();
                }
                return _Instance;
            }
        }
        //Lấy toàn bộ danh mụch
        public List<Danh_Muc> GetAll()
        {
            return DanhMucDAL.GetAll();
        }

        public void loadCBB_DanhMuc(ComboBox cbb)
        {
            cbb.DataSource = GetAll();
            cbb.DisplayMember = "Ten_danh_muc";
            cbb.ValueMember = "Ten_danh_muc";
        }
    }
}
