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
using System.Data.Entity.Infrastructure;

namespace PBL.View
{
    public partial class ucQuanLyNhapXuatKho_Main : UserControl
    {
        private Phieu_Nhap_Kho phieu_nhapKho = null;
        private List<Chi_Tiet_Phieu_Nhap> listCTPN = new List<Chi_Tiet_Phieu_Nhap>();

        private bool themSP = true;

        private String tongTien = "0";
        public ucQuanLyNhapXuatKho_Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            themSP = true;
            LoadData();

            //Test
            button5.Visible = true;
            button4.Text = "Hủy phiếu";

            try
            {
                //Tạo 1 phiếu tạm -> để tránh trường hợp mở thêm sản phẩm r hủy -> 1 phiếu tạo kho vô nghĩa đc tạo
                Phieu_Nhap_Kho tmp_PNK = (phieu_nhapKho == null) ? PBL.BLL.PhieuNhapKhoBLL.Instance.tao_PNK() : phieu_nhapKho;


                NhapSanPhamVaoKho nhapSP = new NhapSanPhamVaoKho(tmp_PNK);
                //Xử lí khi nhận thông báo từ form NhanSPVaoKho

                bool dathemSP = false;

                nhapSP.MyEvent += (Chi_Tiet_Phieu_Nhap ctpn) =>
                {
                    dathemSP = true;

                    //Nếu bị trùng lặp thì tăng số lượng
                    foreach (var item in listCTPN)
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


                if (dathemSP)
                {
                    phieu_nhapKho = tmp_PNK;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Hàm load lại dataGridView
        private void LoadData()
        {
            khoiTao_datagridview_CTPN();

            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
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
                    PBL.BLL.SanphamBLL.Instance.update_giaSP(item.Ma_san_pham, item.Gia_nhap);//Test chỉnh giá nhập
                }
                // Reset cả UC
                listCTPN.Clear();
                phieu_nhapKho = null;
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi khi thêm sản phẩm: " + ex.Message,
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!themSP)
            {
                LoadData();
                button4.Text = "Hủy phiếu";
                return;
            }

            if (phieu_nhapKho == null)
            {
                MessageBox.Show(
                    "Chưa có phiếu nhập nào được tạo!",
                    "Thông Báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
                return;
            }

            DialogResult result = MessageBox.Show(
                "Xác Nhận Hủy Phiếu Nhập?\nToàn bộ dữ liệu đã thêm sẽ bị xóa!",
                "Xác Nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
            if (result == DialogResult.Yes)
            {
                listCTPN.Clear();
                phieu_nhapKho = null;
                LoadData();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            themSP = false;
            khoiTao_datagridview_PNK();

            button5.Visible = false;
            button4.Text = "Quay Lại";

            //Add toàn bộ phiếu nhập để hiển thị trên DGV PNK
            try
            {
                List<Phieu_Nhap_Kho> listPNK = PBL.BLL.PhieuNhapKhoBLL.Instance.GetAll();
                dataGridView1.DataSource = listPNK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Hàm xử lí khi doubleClick vào 1 hàng trong DGV ở phần tất cả phiếu nhập -> hiển thị các chi tiết phiếu nhập có trong mã phiếu nhập đó
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (!themSP)
            {
                String maPN = dataGridView1.CurrentRow.Cells["Ma_phieu"].Value.ToString();

                khoiTao_datagridview_CTPN();
                List<Chi_Tiet_Phieu_Nhap> listCTPN = PBL.BLL.ChiTietPhieuNhapBLL.Instance.getCTPN_byMPN(maPN);

                String tongSP = "0";
                tongTien = "0"; // Reset tổng tiền trước khi tính toán

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

                //Cập nhật lại tổng tiền và tổng số lượng sản phẩm
                textBox1.Text = tongTien;
                textBox2.Text = tongSP;
            }
        }

        //Khởi tạo DGV hiển thị phiếu nhập Kho
        public void khoiTao_datagridview_PNK()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = null;
            dataGridView1.AutoGenerateColumns = false;
            //không cho phép sửa dữ liệu trong DataGridView
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;

            // Tạo cột cho danh sách phiếu nhập kho
            DataGridViewTextBoxColumn colMa = new DataGridViewTextBoxColumn();
            colMa.HeaderText = "Mã Phiếu";
            colMa.Name = "Ma_phieu";
            colMa.DataPropertyName = "Ma_phieu";

            DataGridViewTextBoxColumn colMaND = new DataGridViewTextBoxColumn();
            colMaND.HeaderText = "Mã Người Dùng";
            colMaND.Name = "Ma_nguoi_dung";
            colMaND.DataPropertyName = "Ma_nguoi_dung";

            DataGridViewTextBoxColumn colDate = new DataGridViewTextBoxColumn();
            colDate.HeaderText = "Ngày Tạo";
            colDate.Name = "Ngay_tao";
            colDate.DataPropertyName = "Ngay_tao";
            colDate.DefaultCellStyle.Format = "dd/MM/yyyy";

            DataGridViewTextBoxColumn colTongTien = new DataGridViewTextBoxColumn();
            colTongTien.HeaderText = "Tổng Tiền";
            colTongTien.Name = "Tongtien";
            colTongTien.DataPropertyName = "Tongtien";

            // Thêm vào DataGridView
            dataGridView1.Columns.Add(colMa);
            dataGridView1.Columns.Add(colMaND);
            dataGridView1.Columns.Add(colDate);
            dataGridView1.Columns.Add(colTongTien);
        }

        //Khởi tạo DGV hiển thị chi tiết phiếu nhập
        public void khoiTao_datagridview_CTPN()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = null;
            dataGridView1.AutoGenerateColumns = false;
            //không cho phép sửa dữ liệu trong DataGridView
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;

            // Tạo cột cho chi tiết phiếu nhập
            DataGridViewTextBoxColumn colMaSP = new DataGridViewTextBoxColumn();
            colMaSP.HeaderText = "Mã Sản Phẩm";
            colMaSP.Name = "MaSP";
            colMaSP.DataPropertyName = "MaSP";

            DataGridViewTextBoxColumn colTenSP = new DataGridViewTextBoxColumn();
            colTenSP.HeaderText = "Tên Sản Phẩm";
            colTenSP.Name = "TenSP";
            colTenSP.DataPropertyName = "TenSP";

            DataGridViewTextBoxColumn colSoLuong = new DataGridViewTextBoxColumn();
            colSoLuong.HeaderText = "Số Lượng";
            colSoLuong.Name = "SoLuong";
            colSoLuong.DataPropertyName = "SoLuong";

            DataGridViewTextBoxColumn colDonGia = new DataGridViewTextBoxColumn();
            colDonGia.HeaderText = "Đơn Giá";
            colDonGia.Name = "DonGia";
            colDonGia.DataPropertyName = "DonGia";

            // Thêm vào DataGridView
            dataGridView1.Columns.Add(colMaSP);
            dataGridView1.Columns.Add(colTenSP);
            dataGridView1.Columns.Add(colSoLuong);
            dataGridView1.Columns.Add(colDonGia);
        }
    }
}