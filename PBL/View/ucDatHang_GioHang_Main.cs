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
    public partial class ucDatHang_GioHang_Main : UserControl
    {
        private string _manguoidung;
        public ucDatHang_GioHang_Main(string manguoidung)
        {
            InitializeComponent();
            _manguoidung = manguoidung;
            LoadThanhtoan();
        }

        public void LoadThanhtoan()
        {
            lbl_gia.Text = string.Format("{0:0,0}", GioHangBLL.Instance.Tinhtong(_manguoidung)) + " VNĐ";
        }

        private void ucDatHang_GioHang_Main_Load(object sender, EventArgs e)
        {

        }
    }
}
