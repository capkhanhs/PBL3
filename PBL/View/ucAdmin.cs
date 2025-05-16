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
    public partial class ucAdmin: UserControl
    {
        public ucAdmin()
        {
            InitializeComponent();
        }
        private void LoadPanel(Panel pn, UserControl uc)
        {
            pn.Controls.Clear();
            pn.Controls.Add(uc);
        }
        public Panel GetPanel ()
        {
            return flpn_HienThi;
        }

        private void btn_SanPham_Click(object sender, EventArgs e)
        {
            LoadPanel(flpn_HienThi, new ucHienThiSanPham_Admin());
        }

        private void btn_TaiKhoan_Click(object sender, EventArgs e)
        {
            LoadPanel(flpn_HienThi, new ucHienThiTaiKhoan());
        }

        private void btn_KhoHang_Click(object sender, EventArgs e)
        {
            LoadPanel(flpn_HienThi, new ucHienThiKhoHang());
        }

        private void btn_DonHang_Click(object sender, EventArgs e)
        {
            LoadPanel(flpn_HienThi, new ucDonHangHeThong_Admin());
        }

        private void btn_DoanhSo_Click(object sender, EventArgs e)
        {
            flpn_HienThi.Controls.Clear();
            ucThongKeDoanhSo_Main uc = new ucThongKeDoanhSo_Main();
            flpn_HienThi.Controls.Add(uc);
        }

        private void btn_CaNhan_Click(object sender, EventArgs e)
        {
            LoadPanel(flpn_HienThi, new ucCaNhan_Admin());
        }

        private void btn_TrangChu_Click(object sender, EventArgs e)
        {
            //flpn_HienThi.Controls.Add();
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            ucThemSanPham_Admin uc = new ucThemSanPham_Admin();
            flpn_HienThi.Controls.Add(uc);
        }
    }
}
