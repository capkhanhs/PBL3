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
            LoadData();
        }

        private void ucNhanVienBanHang_Load(object sender, EventArgs e)
        {
            DTP_NgayHienTai.Value = DateTime.Now;
        }

        public void LoadData()
        {
            dataGridView1.DataSource = DonHangBLL.Instance.Get_DH_TheoTrangThai("Đang xử lý");
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

        private void btn_XemChiTiet_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn xác nhận đơn hàng này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                DonHangBLL.Instance.ChuyenTrangThai(row.DataBoundItem as Don_Hang); 
                LoadData(); // Tải lại dữ liệu sau khi xác nhận đơn hàng
            } 
                

        }
    }
}
