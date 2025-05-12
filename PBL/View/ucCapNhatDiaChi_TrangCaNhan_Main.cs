using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using PBL.BLL;
using PBL.Model;

namespace PBL.View
{
    public partial class ucCapNhatDiaChi_TrangCaNhan_Main : UserControl
    {
        Dictionary<string, Province> provinces;
        Dictionary<string, District> districts;
        Dictionary<string, Ward> wards;
        private string manguoidung;
        public ucCapNhatDiaChi_TrangCaNhan_Main()
        {
            InitializeComponent();
        }


 
    }
}
