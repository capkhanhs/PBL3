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
using PBL.Model;

namespace PBL.View
{
    public partial class ucThongtingiaohang : UserControl
    {
        public ucThongtingiaohang(Don_Hang dh)
        {
            InitializeComponent();
            Van_Chuyen vc = VanChuyenBLL.Instance.GetAll().Where(x => x.Ma_don_hang == dh.Ma_don_hang).FirstOrDefault();
            if (vc!= null)
            {
                label3.Text = vc.Ngay_du_kien.ToString();
                label6.Text = vc.Ngay_bat_dau.ToString();
                Nguoi_Dung nd = vc.Nguoi_Dung;
                if (nd != null)
                {
                    label4.Text = nd.Ho_va_ten;
                    label5.Text = nd.Ma_nguoi_dung;
                }
            }    
        }
    }
}
