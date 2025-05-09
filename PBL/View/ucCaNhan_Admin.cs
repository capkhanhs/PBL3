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
    public partial class ucCaNhan_Admin: UserControl
    {
        public ucCaNhan_Admin()
        {
            InitializeComponent();
            LoadPanel(pn_HienThiCaNhan, new ucDonHangDaMua_TrangCaNhan_Main());
        }
        private void LoadPanel(Panel pn, UserControl uc)
        {
            pn.Controls.Clear();
            pn.Controls.Add(uc);
        }
        private void btn_DonHang_Click(object sender, EventArgs e)
        {
            LoadPanel(pn_HienThiCaNhan, new ucDonHangDaMua_TrangCaNhan_Main());
        }

        private void btn_TT_DC_Click(object sender, EventArgs e)
        {
            LoadPanel(pn_HienThiCaNhan, new ucThongTin_TrangCaNhan_Main());
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            Main main = (Main)this.ParentForm;
            main.Close();
        }
    }
}
