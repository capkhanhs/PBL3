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
    public partial class ucNhanVienBanHang: UserControl
    {
        public ucNhanVienBanHang()
        {
            InitializeComponent();
        }

        private void ucNhanVienBanHang_Load(object sender, EventArgs e)
        {
            DTP_NgayHienTai.Value = DateTime.Now;
            btn_DonHangChoXuLy.Text = "Chưa xử lý " + "3"; //trạng thái đơn hàng chờ xử lý trong database
            btn_DonHangDaXuLy.Text = "Đã xử lý " + "10"; //trạng thái đơn hàng không phải chờ xử lý và không phải đã giao thành công 
        }

        private void btn_HuyDonHang_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Bạn chắc chắn muốn hủy đơn hàng này không?",     // Nội dung
                "Xác nhận",                          // Tiêu đề
                MessageBoxButtons.OKCancel,           // Các nút: OK và Cancel
                MessageBoxIcon.Question               // Icon hình dấu hỏi
            );
        }
    }
}
