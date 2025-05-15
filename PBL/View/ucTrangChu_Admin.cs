using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL.DAL;

namespace PBL.View
{
    public partial class ucTrangChu_Admin: UserControl
    {
        SanPhamDAL sp = new SanPhamDAL();
        string manguoidung;
        public ucTrangChu_Admin(string manguoidung)
        {
            InitializeComponent();
            this.manguoidung = manguoidung;
            ucTrangChu_Load();

        }
        private void ScaleControl(Control control, float scale)
        {
            // Scale kích thước và vị trí
            control.Width = (int)(control.Width * scale);
            control.Height = (int)(control.Height * scale);
            control.Left = (int)(control.Left * scale);
            control.Top = (int)(control.Top * scale);

            // Scale font
            control.Font = new Font(control.Font.FontFamily, control.Font.Size * scale, control.Font.Style);

            // Đệ quy: scale các control con
            foreach (Control child in control.Controls)
            {
                ScaleControl(child, scale);
            }
        }

        private void ucTrangChu_Load()
        {
            flpn_hienthi.Controls.Clear();
            sp.GetAll().ForEach(x =>
            {
                ucSanPhamItem_TrangChu_Main item = new ucSanPhamItem_TrangChu_Main(x.Ma_san_pham, manguoidung);
                ScaleControl(item, 0.85f);
                //item.Size = new Size((int)(item.Size.Width * 0.75), (int)(item.Size.Height * 0.85));
                
                flpn_hienthi.Controls.Add(item);
            });
        }
    }
}
