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
    public partial class CapNhatDiaChi : Form
    {
        private bool isThem;
        Dictionary<string, Province> provinces;
        Dictionary<string, District> districts;
        Dictionary<string, Ward> wards;
        private string manguoidung;
        private string madiachi;    
        public CapNhatDiaChi(string manguoidung)
        {
            InitializeComponent();
            this.manguoidung = manguoidung;
            isThem = true;
            LoadAllData();
        }

        public CapNhatDiaChi(string madiachi, int i)
        {
            InitializeComponent();
            isThem = false;
            this.madiachi = madiachi;
            LoadAllData();
            LoadDiaChi(madiachi);
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
            CBB_TinhThanh.SelectedIndex = -1; // Đặt giá trị mặc định là không chọn gì
        }

        public void LoadDiaChi(string madiachi)
        {
            Dia_Chi diaChi = DiaChiBLL.Instance.Find(madiachi);
            if (diaChi != null)
            {
                CBB_TinhThanh.SelectedValue = provinces.FirstOrDefault(p => p.Value.name == diaChi.Tinh_ThanhPho).Key;
                CBB_QH.SelectedValue = districts.FirstOrDefault(d => d.Value.name == diaChi.Quan_Huyen).Key;
                CBB_PX.SelectedValue = wards.FirstOrDefault(w => w.Value.name == diaChi.Xa_Phuong).Key;
                txt_ChiTiet.Text = diaChi.Chi_tiet;
            }
        }

        private void CBB_TinhThanh_SelectedIndexChanged_1(object sender, EventArgs e)
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
            CBB_QH.SelectedIndex = -1; // Đặt giá trị mặc định là không chọn gì
        }

        private void CBB_QH_SelectedIndexChanged_1(object sender, EventArgs e)
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
            CBB_PX.SelectedIndex = -1; // Đặt giá trị mặc định là không chọn gì 
        }

        private void btn_Update_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (isThem)
                {
                    Dia_Chi dia_Chi = new Dia_Chi();
                    dia_Chi.Tinh_ThanhPho = ((Province)CBB_TinhThanh.SelectedItem).name;
                    dia_Chi.Quan_Huyen = ((District)CBB_QH.SelectedItem).name;
                    dia_Chi.Xa_Phuong = ((Ward)CBB_PX.SelectedItem).name;
                    dia_Chi.Chi_tiet = txt_ChiTiet.Text;
                    DiaChiBLL.Instance.Add(dia_Chi);
                    NguoiDungDiaChiBLL.Instace.ADD(manguoidung, dia_Chi.Ma_dia_chi);
                    MessageBox.Show("Thêm địa chỉ thành công");
                    this.Close();
                }
                else
                {
                    Dia_Chi dia_Chi = new Dia_Chi();
                    dia_Chi.Tinh_ThanhPho = ((Province)CBB_TinhThanh.SelectedItem).name;
                    dia_Chi.Quan_Huyen = ((District)CBB_QH.SelectedItem).name;
                    dia_Chi.Xa_Phuong = ((Ward)CBB_PX.SelectedItem).name;
                    dia_Chi.Chi_tiet = txt_ChiTiet.Text;
                    DiaChiBLL.Instance.Update(dia_Chi, madiachi);
                    MessageBox.Show("Cập nhật địa chỉ thành công");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }   
        }
    }

}
