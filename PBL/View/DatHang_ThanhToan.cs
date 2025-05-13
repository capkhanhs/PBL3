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
    public partial class DatHang_ThanhToan : UserControl
    {
        private string manguoidung;
        private string madiachi;
        private string phuongthucnhanhang;
        public DatHang_ThanhToan(string manguoidung, string madiachi, string phuongthucnhanhang)
        {
            InitializeComponent();
            this.madiachi = madiachi;
            this.manguoidung = manguoidung;
            this.phuongthucnhanhang = phuongthucnhanhang;
            Load();
        }

        public void Load()
        {
            lbl_gia.Text = string.Format("{0:0,0}", GioHangBLL.Instance.Tinhtong(manguoidung)) + " VNĐ";
            lbl_tong.Text = string.Format("{0:0,0}", GioHangBLL.Instance.Tinhtong(manguoidung)) + " VNĐ";
        }

        private void btnDatHang_Click(object sender, EventArgs e)
        {
            DonHangBLL.Instance.DatHang(manguoidung, madiachi, phuongthucnhanhang);
        }
    }
}
