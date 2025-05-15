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

namespace PBL.View
{
    public partial class Main : Form
    {
        string Manguoidung;
        string Vaitro;
        public Main(string username)
        {
            InitializeComponent();
            Manguoidung = username;
            pnMain.Controls.Add(new ucAdmin());

            //pnMain.Controls.Add(new ucTrangChu_Main(Manguoidung));
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
            LoadpnMain(new ucTrangCaNhan_Main(Manguoidung));
        }
    }
}
