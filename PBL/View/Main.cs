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
    public partial class Main : Form
    {
        string Manguoidung;
        string maVaitro;
        List<San_Pham> spHienTai = new List<San_Pham>();
        public Main(string username)
        {
            InitializeComponent();
            Manguoidung = username;
            SetPlaceholder(txt_search, "Tìm kiếm sản phẩm...");
            if (NguoidungBLL.Instance.Find(Manguoidung).Ma_vai_tro == "AD")
            {
                quảnTrịViênToolStripMenuItem.Enabled = true;
                quảnTrịViênToolStripMenuItem.Visible = true;
            }
            else if(NguoidungBLL.Instance.Find(Manguoidung).Ma_vai_tro == "QLK")
            {
                quảnLýKhoToolStripMenuItem.Enabled = true;
                quảnLýKhoToolStripMenuItem.Visible = true;
            }    
            else if(NguoidungBLL.Instance.Find(Manguoidung).Ma_vai_tro == "NVBH")
            {
                nhânViênBánHàngToolStripMenuItem.Enabled = true;
                nhânViênBánHàngToolStripMenuItem.Visible = true;
            }
            else if(NguoidungBLL.Instance.Find(Manguoidung).Ma_vai_tro == "QLVC")
            {
                quảnLýVậnChuyểnToolStripMenuItem.Enabled = true;
                quảnLýVậnChuyểnToolStripMenuItem.Visible = true;
            }    
            LoadTrangChu();
        }

        private void SetPlaceholder(TextBox textBox, string placeholder)
        {
            textBox.ForeColor = Color.Gray;
            textBox.Text = placeholder;

            textBox.GotFocus += (sender, e) =>
            {
                if (textBox.Text == placeholder)
                {
                    textBox.Text = "";
                    textBox.ForeColor = Color.Black;
                }
            };

            textBox.LostFocus += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholder;
                    textBox.ForeColor = Color.Gray;
                }
            };
        }

        private void LoadTrangChu()
        {
            pnMain.Controls.Clear();
            pnMain.Controls.Add(new ucGoiychoban());
            spHienTai = SanphamBLL.Instance.GetAll().Where(x => x.So_luong > 0).ToList();
            foreach (var item in spHienTai)
            {
                ucSanPhamItem_TrangChu_Main uc = new ucSanPhamItem_TrangChu_Main(item.Ma_san_pham, Manguoidung);
                pnMain.Controls.Add(uc);
            }
        }

        public void Loadsp()
        {
            pnMain.Controls.Clear();
            foreach (var item in spHienTai)
            {
                ucSanPhamItem_TrangChu_Main uc = new ucSanPhamItem_TrangChu_Main(item.Ma_san_pham, Manguoidung);
                pnMain.Controls.Add(uc);
            }
        }
        private void LoadpnMain(UserControl uc)
        {
            pnMain.Controls.Clear();
            pnMain.Controls.Add(uc);
        }

        private void btn_dn_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.ShowDialog();
        }

        private void mni_mb_Click(object sender, EventArgs e)
        {
            pnMain.Controls.Clear();
            foreach (var item in SanphamBLL.Instance.LocTheoDanhMuc("Điện thoại").Where(x => x.So_luong > 0))
            {
                ucSanPhamItem_TrangChu_Main uc = new ucSanPhamItem_TrangChu_Main(item.Ma_san_pham, Manguoidung);
                pnMain.Controls.Add(uc);    
            }
        }

        private void pn_0_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_gh_Click(object sender, EventArgs e)
        {
            if(GioHangBLL.Instance.CheckGioHang(Manguoidung) == false)
            {
                MessageBox.Show("Giỏ hàng của bạn đang trống","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            LoadpnMain(new ucGioHang_Main(Manguoidung));
        }

        private void mni_lh_Click(object sender, EventArgs e)
        {

        }

        private void mniTrangChu_Click(object sender, EventArgs e)
        {
            LoadpnMain(new ucTrangChu_Main(Manguoidung));
        }

        private void btn_cn_Click(object sender, EventArgs e)
        {
            LoadpnMain(new ucTrangCaNhan_Main(Manguoidung, this));
        }

        private void lb_name_Click(object sender, EventArgs e)
        {
            LoadTrangChu();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LoadpnMain(new ucTrangChu_Main(Manguoidung));
        }

        private void quảnTrịViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucAdmin ucad = new ucAdmin();
            pnMain.Controls.Clear();
            pnMain.Controls.Add(ucad);
        }

        private void quảnLýKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnMain.Controls.Clear();
            pnMain.Controls.Add(new ucQuanLyNhapXuatKho_Main(Manguoidung));
        }

        private void nhânViênBánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnMain.Controls.Clear();
            pnMain.Controls.Add(new ucNhanVienBanHang());
        }

        private void quảnLýVậnChuyểnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnMain.Controls.Clear();
            pnMain.Controls.Add(new ucQuanlyvanchuyen());
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                spHienTai = SanphamBLL.Instance.TimKiemGanDung(txt_search.Text).Where(x => x.So_luong > 0).ToList();
                Loadsp();
            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mni_tb_Click(object sender, EventArgs e)
        {
            try
            {
                spHienTai = SanphamBLL.Instance.LocTheoDanhMuc("Máy tính bảng").Where(x => x.So_luong > 0).ToList();
                Loadsp();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm: " + ex.Message);
            }
        }

        private void mni_lt_Click(object sender, EventArgs e)
        {
            try
            {
                spHienTai = SanphamBLL.Instance.LocTheoDanhMuc("Laptop").Where(x => x.So_luong > 0).ToList();
                Loadsp();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm: " + ex.Message);
            }
        }

        private void taiNgheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                spHienTai = SanphamBLL.Instance.LocTheoDanhMuc("Tai nghe").Where(x => x.So_luong > 0).ToList();
                Loadsp();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm: " + ex.Message);
            }
        }

        private void mni_sw_Click(object sender, EventArgs e)
        {
            try
            {
                spHienTai = SanphamBLL.Instance.LocTheoDanhMuc("SmartWatch").Where(x => x.So_luong > 0).ToList();
                Loadsp();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm: " + ex.Message);
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.DialogResult = DialogResult.Cancel;
            else { 
                e.Cancel = true;
            }
        }

        private void pnMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tăngDầnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            spHienTai = spHienTai.OrderBy(x => decimal.Parse(x.Gia_sp)).ToList();
            Loadsp();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void giảmDầnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            spHienTai = spHienTai.OrderByDescending(x => decimal.Parse(x.Gia_sp)).ToList();
            Loadsp();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void aZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            spHienTai = spHienTai.OrderBy(x => x.Ten_sp).ToList();
            Loadsp();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            spHienTai = spHienTai.OrderByDescending(x => x.Ten_sp).ToList();
            Loadsp();
        }
    }
}
