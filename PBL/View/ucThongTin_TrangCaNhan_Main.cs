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
using Newtonsoft.Json;
using PBL.BLL;
using PBL.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PBL.View
{
    public partial class ucThongTin_TrangCaNhan_Main : UserControl
    {

        private string manguoidung;
        public ucThongTin_TrangCaNhan_Main(string manguoidung)
        {
            InitializeComponent();
            Nguoi_Dung nguoi_Dung = NguoidungBLL.Instance.Find(manguoidung);
            string thongtin = nguoi_Dung.Ho_va_ten + " - " + nguoi_Dung.Ma_nguoi_dung;
            lbl_thongtincanhan.Text = thongtin;
            this.manguoidung = manguoidung;
            if (NguoiDungDiaChiBLL.Instace.CheckHaveAddress(manguoidung))
            {
                List<Dia_Chi> diachi = NguoiDungDiaChiBLL.Instace.LoadAddress(manguoidung);
                foreach (Dia_Chi item in diachi)
                {
                    ucDiaChi uc = new ucDiaChi(item.Ma_dia_chi);
                    uc.Dock = DockStyle.Top;
                    pndiachi.Controls.Add(uc);
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa có địa chỉ nào, hãy thêm địa chỉ mới");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnthemdiachi_Click(object sender, EventArgs e)
        {
            CapNhatDiaChi uc = new CapNhatDiaChi(manguoidung);
            uc.ShowDialog();
        }
    }
}
