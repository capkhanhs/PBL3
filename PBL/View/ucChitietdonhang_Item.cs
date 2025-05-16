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
using PBL.Model;

namespace PBL.View
{
    public partial class ucChitietdonhang_Item : UserControl
    {
        public ucChitietdonhang_Item(Chi_Tiet_Don_Hang ctdh)
        {
            InitializeComponent();
            LoadData(ctdh );
        }

        public void LoadData(Chi_Tiet_Don_Hang ct)
        {
            var sp = SanphamBLL.Instance.Find(ct.Ma_san_pham);
            label3.Text = sp.Ten_sp;
            label5.Text = sp.Mo_ta_sp;
            label1.Text = "x" + ct.So_luong;
            label2.Text = string.Format("{0:0,0}", long.Parse(ct.Thanh_tien)) + " VNĐ";
            string imagePath = Path.Combine(Application.StartupPath, "Resources", sp.PictureFileName);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            if (File.Exists(imagePath))
            {
                pictureBox1.Image = Image.FromFile(imagePath);
            }
            else
            {
                MessageBox.Show("Không tìm thấy ảnh tại: " + imagePath);
            }
        }
    }
}
