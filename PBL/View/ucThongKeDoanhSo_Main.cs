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
using System.Windows.Forms.DataVisualization.Charting;

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
            DateTime dt_bd = dateTimePicker1.Value;
            DateTime dt_kt = dateTimePicker2.Value;

            int tongLoiNhuan = 0;
            int soDonHang = 0;
            int tongDanhSo = 0;

            if(dt_bd > dt_kt)
            {
                MessageBox.Show(
                    "Ngày bắt đầu không được lớn hơn ngày kết thúc",
                    "Thông Báo Lỗi!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                return;
            }    

            List<Don_Hang> donHang = PBL.BLL.DonHangBLL.Instance.Get_DH_ThanhCong();
            List<San_Pham> sanPham = PBL.BLL.ChiTietDonHangBLL.Instance.GetByMaDH(donHang,dt_bd, dt_kt);

            List<dynamic> data = new List<dynamic>();
            foreach (var i in sanPham)
            {
                
                int giaBan = Convert.ToInt32(i.Gia_sp);
                int soLuong = i.So_luong ?? 0;

                // Calculate LoiNhuan
                int loiNhuan = Convert.ToInt32(giaBan * soLuong * 0.1m);

                tongLoiNhuan += loiNhuan;
                soDonHang += 1;
                tongDanhSo += soLuong;

                data.Add(new
                {
                    SanPham = i.Ten_sp,
                    DoanhSo = soLuong,
                    GiaBan = giaBan,
                    LoiNhuan = loiNhuan
                });
            }

            // Xóa các cột hiện có
            dataGridView1.Columns.Clear();

            // Thêm chỉ các cột bạn muốn
            dataGridView1.Columns.Add("SanPham", "Sản phẩm");
            dataGridView1.Columns.Add("DoanhSo", "Doanh số");
            dataGridView1.Columns.Add("GiaBan", "Giá bán lẻ");
            dataGridView1.Columns.Add("LoiNhuan", "Lợi nhuận");

            // Xóa các hàng
            dataGridView1.Rows.Clear();

            // Thêm dữ liệu thủ công
            foreach (var item in data)
            {
                dataGridView1.Rows.Add(item.SanPham, item.DoanhSo, item.GiaBan, item.LoiNhuan);
            }


            
        }
    }
}
