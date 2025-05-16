using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL.BLL;

namespace PBL.View
{
    public partial class ucHienThiSanPham_Admin: UserControl
    {
        public ucHienThiSanPham_Admin()
        {
            InitializeComponent();
            Load();
        }
        private void Load()
        {
            flpn_HienThiSanPham.Controls.Clear();
            // thay đổi dòng for theo database
            foreach(var i in SanphamBLL.Instance.GetAll())
            {
                ucSanPham_Admin uc = new ucSanPham_Admin(i);
                flpn_HienThiSanPham.Controls.Add(uc);
            }    
        }
    }
}
