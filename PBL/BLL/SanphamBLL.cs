using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL.DAL;
using PBL.Model;

namespace PBL.BLL
{
    public class SanphamBLL
    {
        SanPhamDAL spDAL = new SanPhamDAL();
        private static SanphamBLL _Instance;
        public static SanphamBLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new SanphamBLL();
                }
                return _Instance;
            }
        }

        public List<San_Pham> GetAll()
        {
            return spDAL.GetAll();
        }

        public List<San_Pham> Search(string tenSP)
        {
            List<San_Pham> list = new List<San_Pham>();
            foreach (var item in spDAL.GetAll())
            {
                if (item.Ten_sp.ToLower().Contains(tenSP.ToLower()))
                {
                    list.Add(item);
                }
            }
            return list;
        }

        //Lấy all SP theo danh mục
        public List<San_Pham> LocTheoDanhMuc(string tenDM)
        {
            List<San_Pham> list = new List<San_Pham>();
            foreach (var item in spDAL.GetAll())
            {
                if (item.Danh_Muc.Ten_danh_muc.ToLower().Contains(tenDM.ToLower()))
                {
                    list.Add(item);
                }
            }
            return list;
        }

        //Tìm kiếm sản phẩm theo mã sp
        public San_Pham Find(string masp)
        {
            if (string.IsNullOrEmpty(masp))
            {
                throw new Exception("Mã sản phẩm không được để trống");
            }
            else
            {
                San_Pham sp = spDAL.GetById(masp);
                if (sp == null)
                {
                    throw new Exception("Sản phẩm không tồn tại");
                }
                return spDAL.GetById(sp.Ma_san_pham);

            }
        }

        //Tìm kiếm sản phẩm theo tên
        public San_Pham Find_byName(string Name)
        {
            if (string.IsNullOrEmpty(Name))
            {
                throw new Exception("Mã sản phẩm không được để trống");
            }
            else
            {
                San_Pham sp = spDAL.GetAll().FirstOrDefault(x => x.Ten_sp.ToLower() == Name.ToLower());
                if (sp == null)
                {
                    throw new Exception("Sản phẩm không tồn tại");
                }
                return spDAL.GetById(sp.Ma_san_pham);

            }
        }

        public List<San_Pham> TimKiemGanDung(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
            {
                throw new Exception("Từ khóa tìm kiếm không được để trống");
            }

            // Lấy danh sách tất cả sản phẩm
            var ds = spDAL.GetAll();

            // Lọc theo tên gần đúng (không phân biệt hoa thường)
            var ketQua = ds
                .Where(sp => sp.Ten_sp != null && sp.Ten_sp.ToLower().Contains(keyword.Trim().ToLower()))
                .ToList();

            if (ketQua.Count == 0)
            {
                throw new Exception("Không tìm thấy sản phẩm nào phù hợp");
            }

            return ketQua;
        }


        //Hàm tạo mã sản phẩm tự động
        private string GenerateNewMaSP(List<San_Pham> list)
        {
            int maxNumber = 0;
            foreach (var sp in list)
            {
                if (sp.Ma_san_pham != null && sp.Ma_san_pham.StartsWith("SP"))
                {
                    string numPart = sp.Ma_san_pham.Substring(2);
                    if (int.TryParse(numPart, out int number))
                    {
                        if (number > maxNumber)
                            maxNumber = number;
                    }
                }
            }
            return "SP" + (maxNumber + 1).ToString("D2");
        }
        //Thêm sản phẩm mới
        public bool ThemSP( string tensp, string tenDM, string giaSP, string Mo_ta_sp, string chi_tiet_sp, string picfilename)
        {
            if ( string.IsNullOrEmpty(tensp) || string.IsNullOrEmpty(tenDM) || string.IsNullOrEmpty(giaSP) || string.IsNullOrEmpty(picfilename))
            {
                throw new Exception("Thông tin sản phẩm không được để trống");
            }

            if (decimal.TryParse(giaSP, out decimal gia))
            {
                if (gia < 0)
                {
                    throw new Exception("Giá sản phẩm không hợp lệ");
                }
            }
            else
            {
                throw new Exception("Giá sản phẩm không hợp lệ");
            }
                San_Pham sp = new San_Pham();
                sp.Ma_san_pham = GenerateNewMaSP(GetAll());
                sp.Ten_sp = tensp;
                sp.Ten_danh_muc = tenDM;
                sp.Gia_sp = giaSP;
                sp.Mo_ta_sp = Mo_ta_sp;
                sp.Chi_tiet_san_pham = chi_tiet_sp;
                sp.So_luong = 0;
                sp.PictureFileName = picfilename;
                spDAL.Add(sp);
                spDAL.Save();
                MessageBox.Show("Thêm sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
        }

        //Hàm sửa sản phẩm
        public bool SuaSP(string maSP, string tensp, string tenDM, string giaSP, string mo_ta_sp, string chi_tiet_sp, string picfilename)
        {
            if (string.IsNullOrEmpty(maSP) || string.IsNullOrEmpty(tensp) || string.IsNullOrEmpty(tenDM) || string.IsNullOrEmpty(giaSP) || string.IsNullOrEmpty(picfilename))
            {
                throw new Exception("Thông tin sản phẩm không được để trống");
            }

            if (!decimal.TryParse(giaSP, out decimal gia) || gia < 0)
            {
                throw new Exception("Giá sản phẩm không hợp lệ");
            }

            // Tìm sản phẩm theo mã
            San_Pham sp = spDAL.GetById(maSP); // Giả sử bạn có hàm GetById trong DAL

            if (sp == null)
            {
                throw new Exception("Không tìm thấy sản phẩm cần sửa");
            }

            // Cập nhật thông tin
            sp.Ten_sp = tensp;
            sp.Ten_danh_muc = tenDM;
            sp.Gia_sp = giaSP;
            sp.Mo_ta_sp = mo_ta_sp;
            sp.Chi_tiet_san_pham = chi_tiet_sp;
            sp.PictureFileName = picfilename;

            spDAL.Update(sp);  // Hoặc nếu dùng Entity Framework thì không cần gọi Update, chỉ cần Save()
            spDAL.Save();

            MessageBox.Show("Cập nhật sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }

        //Hàm thêm số lượng tùy theo mã sản phẩm
        public void themSoLuong(String maSP, int soLuong)
        {
            if (string.IsNullOrEmpty(maSP))
            {
                throw new Exception("Mã sản phẩm trống");
            }
            else
            {
                San_Pham sp = spDAL.GetById(maSP);
                if (sp == null)
                {
                    throw new Exception("Sản phẩm không tồn tại");
                }
                else
                {
                    sp.So_luong += soLuong;
                    spDAL.Update(sp);
                    spDAL.Save();
                }
            }
        }

        //Dùng để update giá sản phẩm theo mã sản phẩm khi nhập hàng -> tùy thuộc vào giá nhập sản phẩm
        public void update_giaSP(String maSP, String Gia)
        {
            if (string.IsNullOrEmpty(Gia))
            {
                throw new Exception("Giá sản phẩm trống");
            }
            else
            {
                San_Pham sp = spDAL.GetById(maSP);
                sp.Gia_sp = set_giaBan(Gia);
                spDAL.Update(sp);
                spDAL.Save();
            }
        }

        public String set_giaBan(String giaNhap)
        {
            if(string.IsNullOrEmpty(giaNhap))
            {
                throw new Exception("Giá nhập trống");
            }

            double tileLai = 120.0;

            long giaBan = Convert.ToInt64((Convert.ToDouble(giaNhap) * tileLai / 100.0));
            giaBan = ((giaBan + 99999 ) / 100000 ) * 100000;

            return giaBan.ToString();  
        }

        //Hàm lọc sản phẩm theo giá
        public List<San_Pham> locSPTheoGia(string dau, string cuoi)
        {

            long a = string.IsNullOrEmpty(dau) ? 0 : long.Parse(dau);
            long b = string.IsNullOrEmpty(cuoi) ? long.MaxValue : long.Parse(cuoi);
            if(a <= 0)
                throw new Exception("Giá không hợp lệ");
            if(a > b)
            {
                throw new Exception("Giá không hợp lệ");
            }
            List<San_Pham> list = new List<San_Pham>();
            foreach (var item in spDAL.GetAll())
            {
                if (item.Gia_sp != null && long.Parse(item.Gia_sp) >= a && long.Parse(item.Gia_sp) <= b)
                {
                    list.Add(item);
                }
            }
            if (list.Count == 0)
            {
                throw new Exception("Không có sản phẩm nào trong khoảng giá này");
            }
            return list;
        }

        //Ham sap xep san pham theo gia
        public List<San_Pham> SapXepSPTheoGia(List<San_Pham> list , bool tangDan)
        {
            if (tangDan)
            {
                return list.OrderBy(sp => long.Parse(sp.Gia_sp)).ToList();
            }
            else
            {
                return list.OrderByDescending(sp => long.Parse(sp.Gia_sp)).ToList();
            }
        }
    }
}
