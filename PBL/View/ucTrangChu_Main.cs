using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL.DAL;

namespace PBL.View
{
    public partial class ucTrangChu_Main : UserControl
    {
        SanPhamDAL sp = new SanPhamDAL();
        public ucTrangChu_Main()
        {
            InitializeComponent();
            ucTrangChu_Load();
        }
        
        private void ucTrangChu_Load()
        {
            flpnLoadSanPham.Controls.Clear();
            sp.GetAll().ForEach(x =>
            {
                ucSanPhamItem_TrangChu_Main item = new ucSanPhamItem_TrangChu_Main(x.Ten_sp, x.Gia_sp.ToString());
                flpnLoadSanPham.Controls.Add(item);
            });
        }

        private void flpnLoadSanPham_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
