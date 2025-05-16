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
        string manguoidung;
        public ucTrangChu_Main(string manguoidung)
        {
            InitializeComponent();
            this.manguoidung = manguoidung;
            ucTrangChu_Load();

        }
        
        private void ucTrangChu_Load()
        {
            flpnLoadSanPham.Controls.Clear();
            foreach (var item in sp.GetAll().Where(x => x.So_luong > 0).ToList())
            {
                ucSanPhamItem_TrangChu_Main a = new ucSanPhamItem_TrangChu_Main(item.Ma_san_pham, manguoidung);
                flpnLoadSanPham.Controls.Add(a);
            }    
        }

        private void flpnLoadSanPham_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
