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
=======
using PBL.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PBL.View
{
    public partial class ucThongTin_TrangCaNhan_Main : UserControl
    {
        Dictionary<string, Province> provinces;
        Dictionary<string, District> districts;
        Dictionary<string, Ward> wards;
        public ucThongTin_TrangCaNhan_Main(string manguoidung)
        {
            InitializeComponent();
            LoadAllData();
        }

        private void LoadAllData()
        {
            // Load tỉnh
            string provinceJson = File.ReadAllText(Path.Combine(Application.StartupPath, "Resources", "tinh_tp.json"));
            provinces = JsonConvert.DeserializeObject<Dictionary<string, Province>>(provinceJson);

            // Load huyện
            string districtJson = File.ReadAllText(Path.Combine(Application.StartupPath, "Resources", "quan_huyen.json"));
            districts = JsonConvert.DeserializeObject<Dictionary<string, District>>(districtJson);

            // Load xã
            string wardJson = File.ReadAllText(Path.Combine(Application.StartupPath, "Resources", "xa_phuong.json"));
            wards = JsonConvert.DeserializeObject<Dictionary<string, Ward>>(wardJson);

            // Đổ dữ liệu tỉnh vào combobox
            CBB_TinhThanh.DataSource = provinces.Values.ToList();
            CBB_TinhThanh.DisplayMember = "name";
            CBB_TinhThanh.ValueMember = "code";
        }

        private void CBB_TinhThanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBB_TinhThanh.SelectedValue == null) return;

            string selectedProvinceCode = CBB_TinhThanh.SelectedValue.ToString();

            // Lọc danh sách quận huyện theo mã tỉnh
            var filteredDistricts = districts.Values
                .Where(d => d.parent_code == selectedProvinceCode)
                .OrderBy(d => d.name)
                .ToList();

            CBB_QH.DataSource = filteredDistricts;
            CBB_QH.DisplayMember = "name";
            CBB_QH.ValueMember = "code";
        }

        private void CBB_QH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBB_QH.SelectedValue == null) return;

            string selectedDistrictCode = CBB_QH.SelectedValue.ToString();

            var filteredWards = wards.Values
                .Where(w => w.parent_code == selectedDistrictCode)
            .OrderBy(w => w.name)
                .ToList();

            CBB_PX.DataSource = filteredWards;
            CBB_PX.DisplayMember = "name";
            CBB_PX.ValueMember = "code";
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Dia_Chi dia_Chi = new Dia_Chi();
            dia_Chi.Tinh_ThanhPho = ((Province)CBB_PX.SelectedItem).name;
            dia_Chi.Quan_Huyen = ((District)CBB_QH.SelectedItem).name;
            dia_Chi.Xa_Phuong = ((Ward)CBB_PX.SelectedItem).name;
            dia_Chi.Chi_tiet = txt_ChiTiet.Text;
            DiaChiBLL.Instance.Add(dia_Chi);

        }
    }
}
