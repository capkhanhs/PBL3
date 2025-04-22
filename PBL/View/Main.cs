using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        public void Load_page()
        {

        }

        private void btn_dn_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.ShowDialog();
        }

        private void mni_mb_Click(object sender, EventArgs e)
        {
            pn_main.Controls.Clear();
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

        }

        private void mni_lh_Click(object sender, EventArgs e)
        {

        }
    }
}
