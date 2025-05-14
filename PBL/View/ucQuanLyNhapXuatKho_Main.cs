using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL.Model;
using System.Security.Cryptography;

namespace PBL.View
{
    public partial class ucQuanLyNhapXuatKho_Main: UserControl
    {
        private Phieu_Nhap_Kho phieu_nhapKho = null;
        private List<Chi_Tiet_Phieu_Nhap> listCTPN = new List<Chi_Tiet_Phieu_Nhap>();

        private String tongTien = "0";
        public ucQuanLyNhapXuatKho_Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (phieu_nhapKho == null)
            {
                phieu_nhapKho = PBL.BLL.PhieuNhapKhoBLL.Instance.tao_PNK();
            }

            NhapSanPhamVaoKho nhapSP = new NhapSanPhamVaoKho(phieu_nhapKho);
            //Xử lí khi nhận thông báo từ form NhanSPVaoKho
            nhapSP.MyEvent += (Chi_Tiet_Phieu_Nhap ctpn) =>
            {
                //Nếu bị trùng lặp thì tăng số lượng
                foreach(var item in listCTPN)
                {
                    if (item.Ma_san_pham == ctpn.Ma_san_pham)
                    {
                        item.So_luong += ctpn.So_luong;
                        //Cập nhật lại data
                        LoadData();
                        return;
                    }
                }

                listCTPN.Add(ctpn);
                // Cập nhật lại data
                LoadData();
            };
            nhapSP.ShowDialog();
            
        }

        //Hàm load lại dataGridView
        private void LoadData()
        {
            dataGridView1.DataSource = null;
            dataGridView1.AutoGenerateColumns = false;

            tongTien = "0";
            String tongSP = "0";

            if (listCTPN != null)
            {
                dataGridView1.DataSource = listCTPN.Select(ctpn => new
                {
                    MaSP = ctpn.Ma_san_pham,
                    TenSP = PBL.BLL.SanphamBLL.Instance.Find(ctpn.Ma_san_pham).Ten_sp.ToString(),
                    SoLuong = ctpn.So_luong,
                    DonGia = ctpn.Gia_nhap,
                }).ToList();

                foreach (var item in listCTPN)
                {
                    //Tính tổng tiền
                    tongTien = (int.Parse(tongTien) + int.Parse(item.Gia_nhap) * item.So_luong).ToString();
                    //Tính tổng số lượng sản phẩm
                    tongSP = (int.Parse(tongSP) + item.So_luong).ToString();
                }
            } 

            //Cập nhật lại tổng tiền và tổng số lượng sản phẩm
            textBox1.Text = tongTien;
            textBox2.Text = tongSP;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listCTPN.Count == 0)
            {
                MessageBox.Show(
                    "Chưa có sản phẩm nào được thêm vào phiếu nhập!",
                    "Thông Báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
                return;
            }

            phieu_nhapKho.Tongtien = tongTien;
            //Add vào Phiếu Nhập
            PBL.BLL.PhieuNhapKhoBLL.Instance.them_phieuNhapKho(phieu_nhapKho);
            //Add chi tiết phiếu nhập và số lượng vào sản phẩm
            foreach (var item in listCTPN)
            {
                PBL.BLL.ChiTietPhieuNhapBLL.Instance.them_ChiTietPhieuNhap(item);
                PBL.BLL.SanphamBLL.Instance.themSoLuong(item.Ma_san_pham, Convert.ToInt32(item.So_luong));
            }
            // Reset cả UC
            listCTPN.Clear();
            phieu_nhapKho = null;
            LoadData();

            MessageBox.Show(
                "Nhập kho thành công!",
                "Thông Báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Xác Nhận Hủy Phiếu Nhập?\nToàn bộ dữ liệu đã thêm sẽ bị xóa!",
                "Xác Nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
            if(result == DialogResult.Yes)
            {
                listCTPN.Clear();
                phieu_nhapKho = null;
                LoadData();
            }    
        }
    }
}
