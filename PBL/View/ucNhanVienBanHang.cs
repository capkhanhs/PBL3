using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL.BLL;
using PBL.Model;

namespace PBL.View
{
    public partial class ucNhanVienBanHang: UserControl
    {
        public ucNhanVienBanHang()
        {
            InitializeComponent();
            btn_DonHangChoXuLy.PerformClick(); // Mặc định hiển thị đơn hàng đang xử lý khi load
        }



        private void ucNhanVienBanHang_Load(object sender, EventArgs e)
        {
        }


        private void DTP_NgayHienTai_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_DonHangChoXuLy_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            List<Don_Hang> li = DonHangBLL.Instance.Get_DH_TheoTrangThai("Đang xử lý");
            if( li.Count == 0)
            {
                MessageBox.Show("Không có đơn hàng nào đang xử lý.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            foreach (var item in li)
            {
                ucChitietdonhang uc = new ucChitietdonhang(item,true);
                flowLayoutPanel1.Controls.Add(uc);
            }
        }

        private void btn_DonHangDaXuLy_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            List<Don_Hang> li = DonHangBLL.Instance.Get_DH_TheoTrangThai("Đã xác nhận");
            if (li.Count == 0)
            {
                MessageBox.Show("Không có đơn hàng nào đã xác nhận.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            foreach (var item in li)
            {
                ucChitietdonhang uc = new ucChitietdonhang(item, true);
                flowLayoutPanel1.Controls.Add(uc);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            List<Don_Hang> li = DonHangBLL.Instance.Get_DH_TheoTrangThai("Đang giao hàng");
            if (li.Count == 0)
            {
                MessageBox.Show("Không có đơn hàng nào đang giao.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            foreach (var item in li)
            {
                ucKetThucDonHang_Item uc = new ucKetThucDonHang_Item(item);
                flowLayoutPanel1.Controls.Add(uc);
            }
        }
    }
}
