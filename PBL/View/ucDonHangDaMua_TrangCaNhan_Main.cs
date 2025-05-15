using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL.BLL;
using PBL.Model;

namespace PBL.View
{
    public partial class ucDonHangDaMua_TrangCaNhan_Main : UserControl
    {
        string manguoidung;
        public ucDonHangDaMua_TrangCaNhan_Main(string manguoidung)
        {
            InitializeComponent();
            this.manguoidung = manguoidung;
            LoadDHTheoTrangThai("Tất cả");
        }

        public void LoadDHTheoTrangThai(string trangthai)
        {
            flpnMainDonHangDaMua.Controls.Clear();
            List<Don_Hang> donhang = DonHangBLL.Instance.Get_DH_TheoTrangThai(trangthai, manguoidung);
            foreach(var item in donhang)
            {
                ucChitietdonhang uc = new ucChitietdonhang(item);
                uc.LoadData(item);
                flpnMainDonHangDaMua.Controls.Add(uc);
            }
        }

        private void btn_AllDH_Click(object sender, EventArgs e)
        {
            LoadDHTheoTrangThai("Tất cả");
        }
    }
}
