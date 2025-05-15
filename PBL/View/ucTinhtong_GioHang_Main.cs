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

namespace PBL.View
{
    public partial class ucTinhtong_GioHang_Main : UserControl
    {
        private string _manguoidung;
        public delegate void ThanhToanThanhCong(object sender, EventArgs e);
        public event ThanhToanThanhCong OnThanhToanThanhCong;
        public ucTinhtong_GioHang_Main(string manguoidung)
        {
            InitializeComponent();
            _manguoidung = manguoidung;
            LoadThanhtoan();
        }

        public void LoadThanhtoan()
        {
            lbl_gia.Text = string.Format("{0:0,0}", GioHangBLL.Instance.Tinhtong(_manguoidung)) + " VNĐ";
            lbl_tong.Text = string.Format("{0:0,0}", GioHangBLL.Instance.Tinhtong(_manguoidung)) + " VNĐ";
        }

        private void ucDatHang_GioHang_Main_Load(object sender, EventArgs e)
        {

        }

        private void lbl_phivc_Click(object sender, EventArgs e)
        {

        }

        private void btn_thanhtoan_Click(object sender, EventArgs e)
        {
            DatHang dh = new DatHang(_manguoidung);
            dh.ShowDialog();
            if (dh.DialogResult == DialogResult.OK)
            {
                // Gọi sự kiện khi thanh toán thành công
                OnThanhToanThanhCong?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
