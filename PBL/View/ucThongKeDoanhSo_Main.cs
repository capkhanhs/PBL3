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
using PBL.DAL;
using System.Security.Cryptography;

namespace PBL.View
{
    public partial class ucThongKeDoanhSo_Main : UserControl
    {
        private ChiTietDonHangDAL ctdhDAL = new ChiTietDonHangDAL();
        public ucThongKeDoanhSo_Main()
        {
            InitializeComponent();  
            this.show_chart();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime dt_bd = dateTimePicker1.Value;
                DateTime dt_kt = dateTimePicker2.Value;

                long tongLoiNhuan = 0;
                long soDonHang = 0;
                long tongDanhSo = 0;

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

                soDonHang = PBL.BLL.DonHangBLL.Instance.Count_DH_inTime(donHang, dt_bd, dt_kt);

                List<Chi_Tiet_Don_Hang> ctdh = PBL.BLL.ChiTietDonHangBLL.Instance.get_ListCTDH_byListDH(donHang, dt_bd, dt_kt);

                Dictionary<string, ThongKeSanPham> sanPhamDict = new Dictionary<string, ThongKeSanPham>();

                foreach (var i in ctdh)
                {
                    San_Pham sp = PBL.BLL.SanphamBLL.Instance.Find(i.Ma_san_pham);
                    long soLuong = Convert.ToInt64(i.So_luong);
                    long giaBan = Convert.ToInt64(i.Gia_ban);
                    long giaNhap = Convert.ToInt64(PBL.BLL.ChiTietPhieuNhapBLL.Instance.get_giaNhap(sp.Ma_san_pham));
                    long loiNhuanSP = soLuong * (giaBan - giaNhap);

                    // Cập nhật tổng doanh số và lợi nhuận
                    tongDanhSo += (long)soLuong;
                    tongLoiNhuan += (long)loiNhuanSP;

                    // Kiểm tra xem sản phẩm đã có trong dictionary chưa
                    if (sanPhamDict.ContainsKey(sp.Ten_sp))
                    {
                        // Nếu có rồi thì cập nhật thông tin
                        sanPhamDict[sp.Ten_sp].DoanhSo += soLuong;
                        sanPhamDict[sp.Ten_sp].LoiNhuan += loiNhuanSP;
                        // Không cập nhật GiaBan vì chúng ta muốn giữ giá bán hiện tại
                    }
                    else
                    {
                        // Nếu chưa có thì thêm mới
                        sanPhamDict[sp.Ten_sp] = new ThongKeSanPham
                        {
                            SanPham = sp.Ten_sp,
                            DoanhSo = soLuong,
                            GiaBan = Convert.ToInt64(sp.Gia_sp), // Lấy giá bán lẻ hiện tại của sản phẩm
                            LoiNhuan = loiNhuanSP
                        };
                    }
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

                // Thêm dữ liệu từ dictionary
                foreach (var item in sanPhamDict.Values)
                {
                    dataGridView1.Rows.Add(item.SanPham, item.DoanhSo, item.GiaBan, item.LoiNhuan);
                }

                // Set dữ liệu các thông tin theo tháng
                textBox1.Text = tongDanhSo.ToString();
                textBox2.Text = tongLoiNhuan.ToString();
                textBox3.Text = soDonHang.ToString();
                if (sanPhamDict.Count > 0)
                {
                    var spBanChayNhat = sanPhamDict.Values.OrderByDescending(x => x.DoanhSo).First();
                    textBox4.Text = spBanChayNhat.SanPham;
                }
                else
                {
                    textBox4.Text = "Không có dữ liệu";
                }
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

                //Lấy dữ liệu theo tháng -> key là tháng, value là danh sách chi tiết đơn hàng
                Dictionary<int, List<Chi_Tiet_Don_Hang>> ctdh_byMonth = new Dictionary<int, List<Chi_Tiet_Don_Hang>>();

                String[] danhMucs = { "Điện thoại", "Laptop", "Máy tính bảng", "Tai nghe", "SmartWatch" };

                for (int month = 1; month <= 12; month++)
                {
                    DateTime start = new DateTime(year_now, month, 1);
                    DateTime end = new DateTime(year_now, month, DateTime.DaysInMonth(year_now, month));

                    //Lọc chi tiết đơn hàng theo tháng
                    List<Don_Hang> dh_inMonth = donHang.Where(dh => dh.Ngay_dat_hang >= start && dh.Ngay_dat_hang <= end).ToList();
                    List<Chi_Tiet_Don_Hang> ctdh_inMonth = new List<Chi_Tiet_Don_Hang>();

                    foreach (var dh in dh_inMonth)
                    {
                        var ctdh = ctdhDAL.GetAll()
                            .Where(x => x.Ma_don_hang == dh.Ma_don_hang)
                            .ToList();
                        if (ctdh != null && ctdh.Count > 0)
                        {
                            ctdh_inMonth.AddRange(ctdh);
                        }
                    }

                    // Lưu vào dictionary
                    ctdh_byMonth[month] = ctdh_inMonth;
                }

                //Tạo kết quả thống kê theo tháng và danh mục -> int là key tháng, String là key danh mục, value là đối tượng thống kê sản phẩm
                Dictionary<int, Dictionary<String, ThongKeSanPham>> thongke_theoThangvaDanhMuc = new Dictionary<int, Dictionary<string, ThongKeSanPham>>();

                for (int month = 1; month <= 12; month++)
                {
                    thongke_theoThangvaDanhMuc[month] = new Dictionary<string, ThongKeSanPham>();

                    foreach (String tenDanhMuc in danhMucs)
                    {
                        thongke_theoThangvaDanhMuc[month][tenDanhMuc] = new ThongKeSanPham
                        {
                            SanPham = tenDanhMuc,
                            DoanhSo = 0,
                            GiaBan = 0,
                            LoiNhuan = 0
                        };
                    }


                    //Nếu tháng này có dữ liệu
                    if(ctdh_byMonth.ContainsKey(month) && ctdh_byMonth[month].Count > 0)
                    {
                        var tongloinhuan_DanhMuc = new Dictionary<string, long>(); // Key là tên danh mục, value là tổng lợi nhuận
                        var tongSoLuong_DanhMuc = new Dictionary<String, long>(); //Key là tên danh mục, value là tổng số lượng

                        // Duyệt qua từng chi tiết đơn hàng để tính lợi nhuận riêng lẻ
                        foreach (var ctdh in ctdh_byMonth[month])
                        {
                            San_Pham sp = PBL.BLL.SanphamBLL.Instance.Find(ctdh.Ma_san_pham);
                            if(sp == null)
                            {
                                throw new Exception("Sản phẩm không tồn tại trong danh sách sản phẩm");
                            }

                            String tenDanhMuc = sp.Ten_danh_muc;
                            long soLuong = Convert.ToInt64(ctdh.So_luong);
                            long giaBan = Convert.ToInt64(ctdh.Gia_ban);
                            long giaNhap = Convert.ToInt64(PBL.BLL.ChiTietPhieuNhapBLL.Instance.get_giaNhap(sp.Ma_san_pham));
                            long loiNhuanSP = soLuong * (giaBan - giaNhap);

                            //Cộng dồn theo danh mục
                            if (!tongloinhuan_DanhMuc.ContainsKey(tenDanhMuc))
                            {
                                tongloinhuan_DanhMuc[tenDanhMuc] = 0;
                                tongSoLuong_DanhMuc[tenDanhMuc] = 0;
                            }

                            tongloinhuan_DanhMuc[tenDanhMuc] += loiNhuanSP;
                            tongSoLuong_DanhMuc[tenDanhMuc] += soLuong;
                        }
                        
                        //Xử lí cho từng danh mục
                        foreach(String tenDanhMuc in danhMucs)
                        {
                            if (tongloinhuan_DanhMuc.ContainsKey(tenDanhMuc))
                            {
                                thongke_theoThangvaDanhMuc[month][tenDanhMuc].DoanhSo = tongSoLuong_DanhMuc[tenDanhMuc];
                                thongke_theoThangvaDanhMuc[month][tenDanhMuc].LoiNhuan = tongloinhuan_DanhMuc[tenDanhMuc];
                                thongke_theoThangvaDanhMuc[month][tenDanhMuc].GiaBan = 0;   //Không cần thiết đối với thống kê theo danh mục

                                double loiNhuanTrieu = tongloinhuan_DanhMuc[tenDanhMuc] / 1000000.0;
                                chart.Series[tenDanhMuc].Points[month - 1].SetValueY(loiNhuanTrieu);
                            }
                            else
                            {
                                // Nếu không có dữ liệu cho danh mục này thì giữ nguyên giá trị 0
                                chart.Series[tenDanhMuc].Points[month - 1].SetValueY(0);
                            }
                        }    
                    }
                    else
                    {
                        // Nếu không có dữ liệu chi tiết đơn hàng trong tháng này, đặt giá trị 0 cho tất cả danh mục
                        foreach (String tenDanhMuc in danhMucs)
                        {
                            chart.Series[tenDanhMuc].Points[month - 1].SetValueY(0);
                        }
                    }
                }    


                // Cập nhật lại thang đo Y nếu có giá trị lớn hơn 10
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
