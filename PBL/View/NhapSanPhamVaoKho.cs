using PBL.BLL;
using PBL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL.View
{
    public partial class NhapSanPhamVaoKho : Form
    {
        private Phieu_Nhap_Kho phieuNhapKho = null;
        private ChiTietPhieuNhapBLL chiTietPhieuNhapBLL = new ChiTietPhieuNhapBLL();
        
        public delegate void MyDel(Chi_Tiet_Phieu_Nhap ctpn);
        public event MyDel MyEvent;

        public NhapSanPhamVaoKho(Phieu_Nhap_Kho PNK)
        {
            InitializeComponent();
            // Load danh mục vào ComboBox
            PBL.BLL.DanhMucBLL.Instance.loadCBB_DanhMuc(comboBox1);
            this.comboBox1.SelectedIndex = 0;  
            this.comboBox1_SelectedIndexChanged(comboBox1, EventArgs.Empty);
            this.phieuNhapKho = PNK;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                comboBox2.DataSource = null;
                comboBox2.Items.Clear();

                var selectedDM = comboBox1.SelectedItem as Danh_Muc; // Lấy đối tượng danh mục được chọn
                if (selectedDM != null)
                {
                    string tenDM = selectedDM.Ten_danh_muc;
                    List<San_Pham> li_sp = PBL.BLL.SanphamBLL.Instance.LocTheoDanhMuc(tenDM);

                    comboBox2.DisplayMember = "Ten_sp";
                    comboBox2.ValueMember = "Ma_sp";
                    comboBox2.DataSource = li_sp; // Gán danh sách sản phẩm vào ComboBox
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var selectedSP = comboBox2.SelectedItem as San_Pham; // Lấy tên sản phẩm được chọn

                if (selectedSP != null)
                {
                    San_Pham sp = PBL.BLL.SanphamBLL.Instance.Find_byName(selectedSP.Ten_sp);
                    if (sp != null && sp.So_luong == 0) //Khi sản phẩm trong kho hết thì có thể chỉnh lại giá toàn bộ trong cửa hàng!
                    {
                        textBox1.Enabled = true;
                        textBox1.Text = sp.Gia_sp.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Danh_Muc dm = comboBox1.SelectedItem as Danh_Muc;
                String danhMuc = dm.Ten_danh_muc.ToString();
                San_Pham sp = comboBox2.SelectedItem as San_Pham;
                String tenSP = sp.Ten_sp.ToString();
                String giaSP = textBox1.Text;
                String soLuong = textBox2.Text;

                if (dm == null || sp == null || !check_daySo(giaSP) || !check_daySo(soLuong))
                {
                    throw new Exception("Vui lòng chọn đầy đủ và chính xác thông tin sản phẩm!");
                }

                Chi_Tiet_Phieu_Nhap ctpn = chiTietPhieuNhapBLL.tao_CTPN(
                    phieuNhapKho,
                    sp.Ma_san_pham,
                    soLuong,
                    giaSP
                );

                MyEvent?.Invoke(ctpn); // Gọi sự kiện để thông báo và truyền 1 ctpn về cho form cha

                //PBL.BLL.SanphamBLL.Instance.themSoLuong(sp.Ma_san_pham, int.Parse(soLuong));

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public bool check_daySo(String s)
        {
            if(String.IsNullOrEmpty(s))
            {
                throw new Exception("Không được để trống!");
            }    
            
            foreach(char c in s)
            {
                if(!char.IsDigit(c)) //c không phải là số
                {
                    throw new Exception(s + " phải là các chữ số!");
                }
            }

            return true;
        }
    }
}
