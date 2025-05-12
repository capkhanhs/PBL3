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
    public partial class ucDiaChi : UserControl
    {
        private string madiachi;
        public ucDiaChi(string madiachi)
        {
            InitializeComponent();
            this.madiachi = madiachi;
            Dia_Chi diachi = DiaChiBLL.Instance.Find(madiachi);
            string diachitxt = diachi.Chi_tiet + ", " + diachi.Xa_Phuong + ", " + diachi.Quan_Huyen + ", " + diachi.Tinh_ThanhPho;
            lblDiaChi.Text = diachitxt;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            CapNhatDiaChi uc = new CapNhatDiaChi(madiachi, 2);
            uc.ShowDialog();
        }
    }
}
