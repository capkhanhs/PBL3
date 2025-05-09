using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL.View
{
    public partial class ucHienThiTaiKhoan: UserControl
    {
        public ucHienThiTaiKhoan()
        {
            InitializeComponent();
        }

        private void ucHienThiTaiKhoan_Load(object sender, EventArgs e)
        {
            flpn_HienThiTaiKhoan.Controls.Clear();
            // thay đổi dòng for theo database
            for (int i = 0; i < 10; i++)
            {
                ucTaiKhoan_Admin ucsp = new ucTaiKhoan_Admin();
                flpn_HienThiTaiKhoan.Controls.Add(ucsp);
            }
        }
    }
}
