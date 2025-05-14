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
    public partial class ucChinhSua_ThemSanPham: UserControl
    {
        public ucChinhSua_ThemSanPham()
        {
            InitializeComponent();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            ChinhSua_ThemSanPham_Admin ad = (ChinhSua_ThemSanPham_Admin)this.ParentForm;
            ad.LoadPanel(ad.pn_SanPham, new ucXemChiTietSanPham_Admin());
        }

        private void btn_ChonAnhThayThe_Click(object sender, EventArgs e)
        {
            if (dialog_ChonAnh.ShowDialog() == DialogResult.OK)
            {
                pic_AnhSP.Image = Image.FromFile(dialog_ChonAnh.FileName);
            }
        }
    }
}
