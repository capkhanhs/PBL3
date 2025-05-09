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
    public partial class ChinhSua_ThemSanPham_Admin: Form
    {
        public delegate void MyDel();
        public MyDel d { get; set; }
        public ChinhSua_ThemSanPham_Admin(MyDel d)
        {
            InitializeComponent();
            this.d = d;
        }
        public void LoadPanel(Panel pn, UserControl uc)
        {
            pn.Controls.Clear();
            pn.Controls.Add(uc);
        }
        private void ChinhSua_ThemSanPham_Admin_Load(object sender, EventArgs e)
        {
            pn_SanPham.Controls.Clear();
            pn_SanPham.Controls.Add( new ucXemChiTietSanPham_Admin());
        }

    }
}
