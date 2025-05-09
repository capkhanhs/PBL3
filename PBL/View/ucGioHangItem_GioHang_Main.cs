using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL.BLL;

namespace PBL.View
{
    public partial class ucGioHangItem_GioHang_Main : UserControl
    {
        private string masanpham;
        private int soluong;
        public ucGioHangItem_GioHang_Main(int soluong, string masanpham)
        {
            InitializeComponent();
            this.masanpham = masanpham;
            this.soluong = soluong;
            LoadData();
        }

        public void LoadData()
        {
            var sp = SanphamBLL.Instance.Find(masanpham);
            if (sp != null)
            {
                lblTenSanPham.Text = sp.Ten_sp;
                lblGiaSP.Text = string.Format("{0:0,0}", int.Parse(sp.Gia_sp)) + " VNĐ";
                lblMoTa.Text = sp.Mo_ta_sp;
                txt_soluong.Text = soluong.ToString();
                string imagePath = Path.Combine(Application.StartupPath, "Resources", sp.PictureFileName);
                picboxSP.SizeMode = PictureBoxSizeMode.StretchImage;
                if (File.Exists(imagePath))
                {
                    picboxSP.Image = Image.FromFile(imagePath);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy ảnh tại: " + imagePath);
                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void txtSoluong_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTang_Click(object sender, EventArgs e)
        {

        }
    }
}
