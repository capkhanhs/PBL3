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
    public partial class TestTK : Form
    {
        public TestTK()
        {
            InitializeComponent();
            test();
        }

        public void test()
        {
            ucThongKeDoanhSo_Main uc = new ucThongKeDoanhSo_Main();
            uc.Dock = DockStyle.Fill;
            this.Controls.Clear();
            this.Controls.Add(uc);
            uc.BringToFront();
            uc.Show();
        }
    }
}
