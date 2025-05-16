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
    public partial class ucTaiKhoan_Admin : UserControl
    {
        public ucTaiKhoan_Admin(Nguoi_Dung nd)
        {
            InitializeComponent();
            LoadDM();
            LoadData(nd);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void LoadDM()
        {
            comboBox1.DataSource = VaitroBLL.Instance.GetAll();
            comboBox1.DisplayMember = "Ten_vai_tro";
            comboBox1.ValueMember = "Ma_vai_tro";
        }

        public void LoadData(Nguoi_Dung nd)
        {
            txtName.Text = nd.Ho_va_ten;
            label7.Text = nd.Gioi_tinh ? "Nam" : "Nữ";
            label3.Text = nd.Ma_nguoi_dung;
            var diaChiObj = NguoiDungDiaChiBLL.Instace
                .LoadAddress(nd.Ma_nguoi_dung)
                .FirstOrDefault();

            string madiachi = diaChiObj != null ? diaChiObj.Ma_dia_chi : null;
            Dia_Chi diachi = DiaChiBLL.Instance.Find(madiachi);
            string diachitxt = "";
            if (diachi != null)
            {
                if (!string.IsNullOrEmpty(diachi.Chi_tiet))
                {
                    diachitxt = diachi.Chi_tiet;
                }

                diachitxt += " " + diachi.Xa_Phuong + ", " + diachi.Quan_Huyen + ", " + diachi.Tinh_ThanhPho;
            }
            label8.Text = diachitxt;
            comboBox1.SelectedValue = nd.Ma_vai_tro;
        }

        private void btn_Chinhsua_Click(object sender, EventArgs e)
        {
            if (comboBox1.Enabled == false)
            {
                comboBox1.Enabled = true;
                btn_Chinhsua.Text = "Lưu";
                btn_Chinhsua.BackColor = Color.FromArgb(255, 128, 0);
                btn_Chinhsua.ForeColor = Color.White;
            }
            else
            {
                if (comboBox1.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn vai trò", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (MessageBox.Show("Bạn có muốn thay đổi vai trò không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    NguoidungBLL.Instance.UpdateRole(label3.Text, comboBox1.SelectedValue.ToString());
                    MessageBox.Show("Thay đổi vai trò thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    comboBox1.Enabled = false;
                    btn_Chinhsua.Text = "Chỉnh sửa";
                    btn_Chinhsua.BackColor = Color.FromArgb(255, 255, 0, 0);
                    btn_Chinhsua.ForeColor = Color.White;
                }
            }
        }
    }
}
