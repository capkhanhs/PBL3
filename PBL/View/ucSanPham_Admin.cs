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
    public partial class ucSanPham_Admin: UserControl
    {
        public ucSanPham_Admin()
        {
            InitializeComponent();
            this.Paint += ucSanPham_Admin_Paint;
        }

        private void ucSanPham_Admin_Paint(object sender, PaintEventArgs e)
        {
            Pen p = new Pen(Color.Gray, 1);
            e.Graphics.DrawLine(p, 20, 40, 830, 40);
        }

        private void btn_Chinhsua_Click(object sender, EventArgs e)
        {
            ChinhSua_ThemSanPham_Admin f = new ChinhSua_ThemSanPham_Admin(Reload);
            f.Show();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Bạn chắc chắn muốn xóa sản phẩm?",     // Nội dung
                "Xác nhận",                          // Tiêu đề
                MessageBoxButtons.OKCancel,           // Các nút: OK và Cancel
                MessageBoxIcon.Question               // Icon hình dấu hỏi
            );
        }
        public void Reload ()
        {

        }
        private void btn_XemChiTiet_Click(object sender, EventArgs e)
        {
            ChinhSua_ThemSanPham_Admin f = new ChinhSua_ThemSanPham_Admin(Reload);
            f.Show();
        }
    }
}
