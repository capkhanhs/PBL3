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
    public partial class ucKetThucDonHang_Item : UserControl
    {
        Don_Hang dh;
        public ucKetThucDonHang_Item(Don_Hang donhang)
        {
            InitializeComponent();
            this.dh = donhang;
            LoadData();
            SetPlaceholder(richTextBox1, "Nhập lí do giao thất bại");
        }

        public void LoadData()
        {
            lblMaDonHang.Text = dh.Ma_don_hang;
            if (dh.Ngay_dat_hang.HasValue)
            {
                label1.Text = dh.Ngay_dat_hang.Value.ToString("dd/MM/yyyy");
            }
            else
            {
                label1.Text = "N/A"; // Handle null case  
            }
            label3.Text = NguoidungBLL.Instance.Find(dh.Ma_nguoi_dung).Ho_va_ten;
            label2.Text = NguoidungBLL.Instance.Find(dh.Ma_nguoi_dung).Ma_nguoi_dung;
            label4.Text = DonHangBLL.Instance.TinhSoLuongSanPham(dh.Ma_don_hang).ToString();
            label5.Text = string.Format("{0:0,0}", DonHangBLL.Instance.TinhTongGiaTriDonHang(dh.Ma_don_hang)) + " VNĐ";
            label6.Text = dh.Trang_thai_don_hang;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            XemChitietdonhang uc = new XemChitietdonhang(dh);
            uc.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Chắc chắn xác nhận đơn hàng đã được giao thành công?", "Thông báo", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                VanChuyenBLL.Instance.capNhatTrangThaiGiao(dh.Ma_don_hang, "", "Giao thành công");
                DonHangBLL.Instance.ChuyenTrangThai(dh);
                MessageBox.Show("Đơn hàng đã được xác nhận giao thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Parent.Controls.Remove(this);
            }
        }

        private void SetPlaceholder(RichTextBox textBox, string placeholder)
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

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;
            richTextBox1.Enabled = true;
            button3.Enabled = false;
            button4.Enabled = true;
            button4.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(richTextBox1.Text) || richTextBox1.Text == "Nhập lí do giao thất bại")
            {
                MessageBox.Show("Vui lòng nhập lí do giao thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(MessageBox.Show("Bạn có chắc chắn muốn đánh dấu đơn hàng này là giao thất bại?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DonHangBLL.Instance.Thaydoitrangthai(dh.Ma_don_hang, "Giao hàng thất bại");
                VanChuyenBLL.Instance.capNhatTrangThaiGiao(dh.Ma_don_hang, richTextBox1.Text, "Giao thất bại");
                MessageBox.Show("Đơn hàng đã được đánh dấu là giao thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Parent.Controls.Remove(this);
            }

        }
    }
}
