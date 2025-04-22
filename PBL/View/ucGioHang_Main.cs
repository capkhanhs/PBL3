using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL.View
{
    public partial class ucGioHang_Main : UserControl
    {
        public ucGioHang_Main()
        {
            InitializeComponent();
            for(int i = 0; i < 10; i++)
            {
                ucGioHangItem_GioHang_Main ucgh = new ucGioHangItem_GioHang_Main();
                pnMainGioHang.Controls.Add(ucgh);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
