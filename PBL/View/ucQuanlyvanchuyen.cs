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
    public partial class ucQuanlyvanchuyen : UserControl
    {
        public ucQuanlyvanchuyen()
        {
            InitializeComponent();
        }

        private void btnDaxacnhan_Click(object sender, EventArgs e)
        {
            btnDaxacnhan.BackColor = Color.Red;
            btnDanggiao.BackColor = Color.White;
            dataGridView1.DataSource = DonHangBLL.Instance.Get_DH_TheoTrangThai("Đã xác nhận");
        }

        private void btnDanggiao_Click(object sender, EventArgs e)
        {
            btnDanggiao.BackColor = Color.Red;
            btnDaxacnhan.BackColor = Color.White;
            dataGridView1.DataSource = DonHangBLL.Instance.Get_DH_TheoTrangThai("Đang giao hàng");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy dòng được click
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Lấy đối tượng Don_Hang nếu đã gán DataSource là List<Don_Hang>
                Don_Hang dh = row.DataBoundItem as Don_Hang;

                if (dh != null)
                {
                    string tt = dh.Trang_thai_don_hang;

                    if (tt == "Đã xác nhận")
                    {
                        DialogResult result = MessageBox.Show(
                            "Xác nhận chuyển đơn hàng sang trạng thái: Đang giao hàng?",
                            "Xác nhận trạng thái",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question
                        );

                        if (result == DialogResult.Yes)
                        {
                            DonHangBLL.Instance.ChuyenTrangThai(dh);
                            dataGridView1.Refresh(); // Cập nhật lại lưới nếu cần
                        }
                    }
                    else if (tt == "Đang giao hàng")
                    {
                        DialogResult result = MessageBox.Show(
                            "Xác nhận chuyển đơn hàng sang trạng thái: Đã giao?",
                            "Xác nhận trạng thái",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question
                        );

                        if (result == DialogResult.Yes)
                        {
                            DonHangBLL.Instance.ChuyenTrangThai(dh);
                            dataGridView1.Refresh();
                        }
                    }
                }
            }
        }
    }
}
