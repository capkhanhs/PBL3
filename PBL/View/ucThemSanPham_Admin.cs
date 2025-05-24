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
using PBL.BLL;
using PBL.Model;

namespace PBL.View
{
    public partial class ucThemSanPham_Admin : UserControl
    {
        string selectedFilePath;
        bool isEdit = false;
        San_Pham sp;
        public ucThemSanPham_Admin()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = -1;
        }

        public ucThemSanPham_Admin(San_Pham sp)
        {
            InitializeComponent();
            LoadSP(sp);
            isEdit = true;
            this.sp = sp;
        }

        public void LoadSP(San_Pham sp)
        {
            txtTen.Text = sp.Ten_sp;
            txtGia.Text = sp.Gia_sp;
            txtChiTiet.Text = sp.Chi_tiet_san_pham;
            txtMota.Text = sp.Mo_ta_sp;
            comboBox1.SelectedItem = sp.Ten_danh_muc;
            string imagePath = Path.Combine(Application.StartupPath, "Resources", sp.PictureFileName);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            if (File.Exists(imagePath))
            {
                pictureBox1.Image = Image.FromFile(imagePath);
            }
            else
            {
                MessageBox.Show("Không tìm thấy ảnh tại: " + imagePath);
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnChonhinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.png)|*.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedFilePath = openFileDialog.FileName;
                pictureBox1.Image = Image.FromFile(selectedFilePath);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        public void clear()
        {
            txtTen.Clear();
            txtGia.Clear();
            txtChiTiet.Clear();
            txtMota.Clear();
            comboBox1.SelectedIndex = -1;
            pictureBox1.Image = null;
        }

        private void btnXacnhan_Click(object sender, EventArgs e)
        {
            if (!isEdit)
            {
                if (string.IsNullOrEmpty(txtTen.Text) || string.IsNullOrEmpty(txtGia.Text) || string.IsNullOrEmpty(txtChiTiet.Text) || string.IsNullOrEmpty(txtMota.Text) || string.IsNullOrEmpty(selectedFilePath) || comboBox1.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin sản phẩm.");
                }
                else
                {
                    try
                    {
                            string fileName = Path.GetFileName(selectedFilePath);
                            string destPath = Path.Combine(Application.StartupPath, "Resources", fileName);
                            // Copy ảnh (nếu chưa tồn tại)
                            if (!File.Exists(destPath))
                            {
                                File.Copy(selectedFilePath, destPath);
                                MessageBox.Show("Copy thanh cong");
                            }
                        
                        if (SanphamBLL.Instance.ThemSP(txtTen.Text, comboBox1.SelectedItem.ToString(), txtGia.Text, txtMota.Text, txtChiTiet.Text, fileName))
                        {
                            clear();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Thêm sp lỗi " + ex.Message);
                    }
                }
            }
            else
            {
                if (string.IsNullOrEmpty(txtTen.Text) || string.IsNullOrEmpty(txtGia.Text) || string.IsNullOrEmpty(txtChiTiet.Text) || string.IsNullOrEmpty(txtMota.Text) || comboBox1.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin sản phẩm.");
                }
                else
                {
                    try
                    {
                        string fileName;
                        if (selectedFilePath == null)
                        {
                            fileName = Path.GetFileName(sp.PictureFileName);
                        }
                        else
                        {
                            fileName = Path.GetFileName(selectedFilePath);
                            string destPath = Path.Combine(Application.StartupPath, "Resources", fileName);

                            // Copy ảnh (nếu chưa tồn tại)
                            if (!File.Exists(destPath))
                            {
                                File.Copy(selectedFilePath, destPath);
                            }
                        }
                        if (SanphamBLL.Instance.SuaSP(sp.Ma_san_pham ,txtTen.Text, comboBox1.SelectedItem.ToString(), txtGia.Text, txtMota.Text, txtChiTiet.Text, fileName))
                        {
                            clear();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }    
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn hủy không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                clear();
            }
        }
    }
}
