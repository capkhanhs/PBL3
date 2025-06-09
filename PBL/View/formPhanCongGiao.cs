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
    public partial class formPhanCongGiao : Form
    {
        Don_Hang donHang;
        public formPhanCongGiao(Don_Hang dh)
        {
            InitializeComponent();
            donHang = dh;
            LoadData();
            comboBox1.SelectedIndex = 0;
        }

        public void LoadData()
        {
            List<Nguoi_Dung> nd = NguoidungBLL.Instance.Nguoidungtheovaitro("NVVC");
            foreach (var item in VanChuyenBLL.Instance.GetAll())
            {
                if(item.Trang_thai == "Đang giao hàng")
                    nd.Remove(NguoidungBLL.Instance.Find(item.Ma_nguoi_dung));
            }    
            if (nd.Count == 0)
            {
                MessageBox.Show("Không có nhân viên vận chuyển nào để phân công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.Cancel;
            }
            comboBox1.DataSource = nd;
            comboBox1.DisplayMember = "Ho_va_ten";
            comboBox1.ValueMember = "Ma_nguoi_dung";
            label2.Text = donHang.Ma_don_hang;
            comboBox1.SelectedIndex = -1; // Đặt giá trị mặc định là không chọn gì
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                VanChuyenBLL.Instance.themVanchuyen(donHang.Ma_don_hang, dateTimePicker1.Value, richTextBox1.Text, comboBox1.SelectedValue.ToString());
                MessageBox.Show("Phân công giao hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
