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
    public partial class ucTrangCaNhan_Main : UserControl
    {
        private string manguoidung;
        Main ma;
        public ucTrangCaNhan_Main(string manguoidung, Main ma)
        {
            InitializeComponent();
            this.ma = ma;
            this.manguoidung = manguoidung;
            Load_Page(new ucDonHangDaMua_TrangCaNhan_Main(manguoidung));
        }

        public void Load_Page(UserControl uc)
        {
            pnMainCaNhan.Controls.Clear(); // Xóa trang cũ
            uc.Dock = DockStyle.Fill; // Tự động căng panel
            pnMainCaNhan.Controls.Add(uc);
        }

        private void btn_DonHang_Click(object sender, EventArgs e)
        {
            Load_Page(new ucDonHangDaMua_TrangCaNhan_Main(manguoidung));
        }

        private void btn_TT_DC_Click(object sender, EventArgs e)
        {
            Load_Page(new ucThongTin_TrangCaNhan_Main(manguoidung));
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                ma.DialogResult = DialogResult.Cancel;
        }
    }
}
