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
            this.show_chart();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime dt_bd = dateTimePicker1.Value;
                DateTime dt_kt = dateTimePicker2.Value;

                int tongLoiNhuan = 0;
                int soDonHang = 0;
                int tongDanhSo = 0;

                if (dt_bd > dt_kt)
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
                List<San_Pham> sanPham = PBL.BLL.ChiTietDonHangBLL.Instance.GetSP_grByMaDH(donHang, dt_bd, dt_kt);

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
                if (dataGridView1.Columns.Count > 0)
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

                //Set dữ liệu các thông tin theo tháng
                textBox1.Text = tongDanhSo.ToString();
                textBox2.Text = tongLoiNhuan.ToString();
                textBox3.Text = soDonHang.ToString();
                textBox4.Text = BLL.SanphamBLL.Instance.GetSPBanChay(sanPham);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void show_chart()
        {
            try
            {
                // Cấu hình lại chart
                this.chart.ChartAreas[0].AxisY.Maximum = 10;
                this.chart.ChartAreas[0].AxisY.Minimum = 0;
                this.chart.ChartAreas[0].AxisY.Title = "Doanh số";
                this.chart.ChartAreas[0].AxisX.Title = "Tháng";
                this.chart.ChartAreas[0].AxisX.Minimum = 0;
                this.chart.ChartAreas[0].AxisX.Maximum = 13;
                this.chart.ChartAreas[0].AxisX.Interval = 1;

                // Cấu hình lề biểu đồ
                this.chart.ChartAreas[0].InnerPlotPosition = new ElementPosition(10, 5, 80, 85);
                this.chart.ChartAreas[0].AxisX.IsMarginVisible = false; // Phải để false khi dùng điểm ảo

                // Xóa nhãn cũ nếu có
                this.chart.ChartAreas[0].AxisX.CustomLabels.Clear();

                // Thêm các điểm ảo cho tháng 0 và tháng 13
                foreach (var series in this.chart.Series)
                {
                    series.Points.Clear();
                    series["PointWidth"] = "0.7"; // Rộng cột

                    series.Points.Add(new DataPoint(0, 0));    // Tháng 0
                    for (int i = 1; i <= 12; i++)
                    {
                        series.Points.Add(new DataPoint(i, 0)); // Khởi tạo điểm cho các tháng 1-12 với giá trị 0
                    }
                    series.Points.Add(new DataPoint(13, 0));   // Tháng 13
                }

                // Thêm nhãn tháng từ 1 đến 12
                for (int i = 1; i <= 12; i++)
                {
                    this.chart.ChartAreas[0].AxisX.CustomLabels.Add(i - 0.5, i + 0.5, "T" + i.ToString());
                }

                //bắt đầu set dữ liệu
                DateTime dt_now = DateTime.Now;
                int year_now = dt_now.Year;
                List<Don_Hang> donHang = PBL.BLL.DonHangBLL.Instance.Get_DH_ThanhCong();
                if(donHang == null || donHang.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu đơn hàng nào trong năm " + year_now, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }    
                //Lấy dữ liệu theo tháng
                Dictionary<int, List<San_Pham>> data_byMonth = PBL.BLL.ChiTietDonHangBLL.Instance.GetSP_grByDanhMuc(donHang, year_now);

                String[] danhMucs = { "Điện thoại", "Laptop", "Máy tính bảng", "Tai nghe", "SmartWatch" };

                //Set dữ liệu
                for (int month = 1; month <= 12; month++)
                {
                    //nếu tháng này có dữ liệu
                    if (data_byMonth.ContainsKey(month) && data_byMonth[month].Count > 0)
                    {
                        foreach (String tenDanhMuc in danhMucs)
                        {
                            var found = data_byMonth[month].FirstOrDefault(x => x.Ten_danh_muc == tenDanhMuc);
                            //Tìm kiếm dữ liệu có tên danh mục tương ứng
                            if (found != null)
                            {
                                int giaBan = Convert.ToInt32(found.Gia_sp);
                                int soLuong = Convert.ToInt32(found.So_luong);
                                Double loiNhuan = Convert.ToDouble(giaBan * 0.1m / 1000000); // 10% lợi nhuận, tính trên đơn vị triệu
                                chart.Series[tenDanhMuc].Points[month].SetValueY(loiNhuan);
                            }
                        }
                    }
                }

                // Cập nhật lại thang đo Y nếu có giá trị lớn hơn 100
                double maxValue = 0;
                foreach (var series in chart.Series)
                {
                    foreach (var point in series.Points)
                    {
                        if (point.YValues[0] > maxValue)
                            maxValue = point.YValues[0];
                    }
                }

                if (maxValue > 10)
                {
                    this.chart.ChartAreas[0].AxisY.Maximum = Math.Ceiling(maxValue * 1.1); // Thêm 10% margin
                }
            }
            catch
            (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
