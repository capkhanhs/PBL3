using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL.BLL;

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
            foreach(var item in NguoidungBLL.Instance.GetAll())
            {
                ucTaiKhoan_Admin uc = new ucTaiKhoan_Admin(item);
                flpn_HienThiTaiKhoan.Controls.Add(uc);  
            }    
        }
    }
}
