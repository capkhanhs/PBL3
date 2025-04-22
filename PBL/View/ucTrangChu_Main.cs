using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL.View
{
    public partial class ucTrangChu_Main : UserControl
    {
        public ucTrangChu_Main()
        {
            InitializeComponent();
            ucTrangChu_Load();
        }
        
        private void ucTrangChu_Load()
        {
            flpnLoadSanPham.Controls.Clear();
            for (int i = 0; i < 10; i++)
            {
                ucSanPhamItem_TrangChu_Main ucspit = new ucSanPhamItem_TrangChu_Main();
                flpnLoadSanPham.Controls.Add(ucspit);
            }
        }

        private void flpnLoadSanPham_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
