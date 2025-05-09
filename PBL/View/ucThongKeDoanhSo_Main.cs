using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL.BLL;
using PBL.Model;

namespace PBL.View
{
    public partial class ucThongKeDoanhSo_Main : UserControl
    {
        public ucThongKeDoanhSo_Main()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Don_Hang> donHang = PBL.BLL.DonHangBLL.Instance.Get_DH_ThanhCong();
            List<Chi_Tiet_Don_Hang> chiTietDonHang = PBL.BLL.ChiTietDonHangBLL.Instance.GetByMaDH(donHang);

            List<dynamic> data = new List<dynamic>();
            foreach (var i in chiTietDonHang)
            {
                
                int giaBan = Convert.ToInt32(i.Gia_ban);
                int soLuong = i.So_luong ?? 0;

                // Calculate LoiNhuan
                var loiNhuan = giaBan * soLuong * 0.1m;

                data.Add(new
                {
                    DanhMucSanPham = i.San_Pham.Ten_danh_muc,
                    DoanhSo = soLuong,
                    ChiPhi = giaBan,
                    LoiNhuan = loiNhuan
                });
            }

            // Xóa các cột hiện có
            dataGridView1.Columns.Clear();

            // Thêm chỉ các cột bạn muốn
            dataGridView1.Columns.Add("DanhMucSanPham", "Danh Mục Sản phẩm");
            dataGridView1.Columns.Add("DoanhSo", "Doanh số");
            dataGridView1.Columns.Add("ChiPhi", "Chi phí");
            dataGridView1.Columns.Add("LoiNhuan", "Lợi nhuận");

            // Xóa các hàng
            dataGridView1.Rows.Clear();

            // Thêm dữ liệu thủ công
            foreach (var item in data)
            {
                dataGridView1.Rows.Add(item.DanhMucSanPham, item.DoanhSo, item.ChiPhi, item.LoiNhuan);
            }
        }
    }
}
