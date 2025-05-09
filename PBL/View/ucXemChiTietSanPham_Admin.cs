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
    public partial class ucXemChiTietSanPham_Admin: UserControl
    {
        public ucXemChiTietSanPham_Admin()
        {
            InitializeComponent();
        }

        
        private void btn_Chinhsua_Click(object sender, EventArgs e)
        {
            ChinhSua_ThemSanPham_Admin ad = (ChinhSua_ThemSanPham_Admin)this.ParentForm;
            ad.LoadPanel(ad.pn_SanPham, new ucChinhSua_ThemSanPham());
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            ChinhSua_ThemSanPham_Admin ad = (ChinhSua_ThemSanPham_Admin)this.ParentForm;
            ad.Close();
        }
    }
}
