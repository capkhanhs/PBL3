using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL.View
{
    public partial class ucHienThiSanPham_Admin: UserControl
    {
        public ucHienThiSanPham_Admin()
        {
            InitializeComponent();
        }
        private void ucHienThiSanPham_Admin_Load_1(object sender, EventArgs e)
        {
            flpn_HienThiSanPham.Controls.Clear();
            // thay đổi dòng for theo database
            for (int i = 0; i < 10; i++)
            {
                ucSanPham_Admin ucsp = new ucSanPham_Admin();
                flpn_HienThiSanPham.Controls.Add(ucsp);
            }
        }
    }
}
