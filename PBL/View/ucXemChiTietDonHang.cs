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
    public partial class ucXemChiTietDonHang: UserControl
    {
        public ucXemChiTietDonHang()
        {
            InitializeComponent();
        }
        private void LoadPanel(Panel pn, UserControl uc)
        {
            pn.Controls.Clear();
            pn.Controls.Add(uc);
        }
        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ucXemChiTietDonHang_Load(object sender, EventArgs e)
        {
            LoadPanel(flpn_HienThiDonHang, new ucSanPhamDonHang());
        }
    }
}
