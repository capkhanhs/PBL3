using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL.Model;

namespace PBL.View
{
    public partial class ChinhSua_ThemSanPham_Admin: Form
    {

        public ChinhSua_ThemSanPham_Admin(San_Pham sp)
        {
            InitializeComponent();
            pn_SanPham.Controls.Clear();
            pn_SanPham.Controls.Add(new ucThemSanPham_Admin(sp));
        }
        public void LoadPanel(Panel pn, UserControl uc)
        {
            pn.Controls.Clear();
            pn.Controls.Add(uc);
        }
        private void ChinhSua_ThemSanPham_Admin_Load(object sender, EventArgs e)
        {

        }

    }
}
