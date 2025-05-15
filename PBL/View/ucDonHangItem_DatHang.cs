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
    public partial class ucDonHangItem_DatHang : UserControl
    {
        public ucDonHangItem_DatHang(CartItem ci)
        {
            InitializeComponent();
            Load(ci);
        }

        public void Load(CartItem item)
        {
            San_Pham sp = SanphamBLL.Instance.Find(item.Ma_san_pham);
            if(sp ==  null)
            {
                throw new Exception("Không tìm thấy sản phẩm");
            }
            lblTenSP.Text = sp.Ten_sp;
            lblMoTa.Text = sp.Mo_ta_sp;
            lblGia.Text = string.Format("{0:0,0}", int.Parse(sp.Gia_sp) * item.Quantity) + " VNĐ";
            lblSoluong.Text = item.Quantity.ToString();
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
