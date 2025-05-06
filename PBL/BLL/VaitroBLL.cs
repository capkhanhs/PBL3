using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL.DAL;
using PBL.Model;

namespace PBL.BLL
{
    public class VaitroBLL
    {
        VaitroDAL vaitroDAL = new VaitroDAL();
        private static VaitroBLL _Instance;
        public static VaitroBLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new VaitroBLL();
                }
                return _Instance;
            }
        }

        public List<Vai_Tro> GetAll()
        {
            return vaitroDAL.GetAll();
        }
    }
}
