﻿using PBL.DAL;
using PBL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL.BLL
{
    public class ChiTietDonHangBLL
    {
        ChiTietDonHangDAL ChiTietDonHangDAL = new ChiTietDonHangDAL();
        private static ChiTietDonHangBLL _Instance;
        public static ChiTietDonHangBLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new ChiTietDonHangBLL();
                }
                return _Instance;
            }
            private set { }
        }

        // Lấy danh sách chi tiết đơn hàng
        public List<Model.Chi_Tiet_Don_Hang> GetAll()
        {
                return ChiTietDonHangDAL.GetAll();
        }

        //Lấy danh sách sản phẩm và tổng sản phẩm đó đã bán theo mã đơn hàng thành công và đã gom theo ma SanPham
        public List<Model.San_Pham> GetSP_grByMaDH(List<Don_Hang> dh, DateTime start, DateTime end)
        {
            List<Model.Chi_Tiet_Don_Hang> list_ctdh = new List<Model.Chi_Tiet_Don_Hang>();

            try
            {
                foreach (var item in dh)
                {
                    if (item.Ngay_dat_hang >= start && item.Ngay_dat_hang <= end)
                    {
                        var li = ChiTietDonHangDAL.GetAll().Where(x => x.Ma_don_hang == item.Ma_don_hang).ToList();
                        if (li.Count > 0)
                        {
                            list_ctdh.AddRange(li);
                        }
                    }
                }

                List<San_Pham> li_sp = new List<San_Pham>();
                li_sp = list_ctdh.GroupBy(x => x.San_Pham.Ma_san_pham).Select(g =>
                {
                    //mỗi nhóm g là tập hợp các chi tiết đơn hàng có mã sản phẩm giống nhau
                    var sp = g.First().San_Pham; //Lấy 1 sản phẩm làm đại diện
                    //Tạo sản phẩm mới với thông tin từ nhóm g
                    return new San_Pham
                    {
                        Ma_san_pham = sp.Ma_san_pham,
                        Ten_danh_muc = sp.Ten_danh_muc,
                        Ten_sp = sp.Ten_sp,
                        Gia_sp = g.First().Gia_ban,
                        Mo_ta_sp = sp.Mo_ta_sp,
                        Chi_tiet_san_pham = sp.Chi_tiet_san_pham,
                        So_luong = g.Sum(x => x.So_luong),
                        PictureFileName = sp.PictureFileName
                    };
                }).ToList();

                return li_sp;
            }
            catch(Exception ex)
            {
                Console.WriteLine("Lỗi trong GetSP_grByMaDH: " + ex.Message);
                return null;
            }
        }

        //Lấy danh sách chi tiết đơn hàng theo mã đơn hàng và đã gom theo danh mục
        public Dictionary<int, List<Model.San_Pham>> GetSP_grByDanhMuc(List<Don_Hang> dh, int year)
        {
            try
            {
                Dictionary<int, List<Model.San_Pham>> result = new Dictionary<int, List<Model.San_Pham>>();
                // key: tháng, value: danh sách sản phẩm

                for (int month = 1; month <= 12; month++)
                {
                    DateTime start = new DateTime(year, month, 1);
                    DateTime end = new DateTime(year, month, DateTime.DaysInMonth(year, month)); // Ngày cuối cùng của tháng

                    List<Model.Chi_Tiet_Don_Hang> list_ctdh = new List<Model.Chi_Tiet_Don_Hang>();

                    //lọc đơn hàng trong các tháng
                    foreach (var i in dh)
                    {
                        if (i.Ngay_dat_hang >= start && i.Ngay_dat_hang <= end)
                        {
                            var li = ChiTietDonHangDAL.GetAll().Where(x => x.Ma_don_hang == i.Ma_don_hang).ToList();
                            if (li.Count > 0)
                            {
                                list_ctdh.AddRange(li);
                            }
                        }
                    }

                     //Nhóm lại theo danh mục cho tháng đó
                    List<San_Pham> li_sp = list_ctdh.GroupBy(x => x.San_Pham.Ten_danh_muc).Select(g =>
                    {
                        var first = g.First(); // lấy sản phẩm đầu tiên của nhóm
                        return new San_Pham
                        {
                            Ma_san_pham = first.San_Pham.Ma_san_pham,
                            Ten_danh_muc = first.San_Pham.Ten_danh_muc,
                            Ten_sp = first.San_Pham.Ten_sp, // Tên theo danh mục
                            Gia_sp = g.Sum(x => Convert.ToInt32(x.Gia_ban) * x.So_luong).ToString(),
                            Mo_ta_sp = first.San_Pham.Mo_ta_sp,
                            Chi_tiet_san_pham = first.San_Pham.Chi_tiet_san_pham,
                            So_luong = g.Sum(x => x.So_luong),
                            PictureFileName = first.San_Pham.PictureFileName
                        };
                    }).ToList();

                    //Thêm vào dictionary
                    if (!result.ContainsKey(month))
                        result.Add(month, li_sp); // Không có thì thêm vào
                    else
                        result[month] = li_sp; // hoặc gộp tiếp


                    //In test
                    foreach (var item in li_sp)
                    {
                        Console.WriteLine(item.Ten_danh_muc + " - " + item.Gia_sp);
                    }
                }

                return result;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi lấy danh sách sản phẩm theo danh mục: " + ex.Message);
                return null;
            }
        }

        //Thêm chi tiết đơn hàng mới
        public void AddChiTietDonHang(string madonhang, string masanpham, int soluong, string dongia)
        {
            Chi_Tiet_Don_Hang chiTietDonHang = new Chi_Tiet_Don_Hang();
            chiTietDonHang.Ma_don_hang = madonhang;
            chiTietDonHang.Ma_san_pham = masanpham;
            chiTietDonHang.So_luong = soluong;
            chiTietDonHang.Gia_ban = SanphamBLL.Instance.Find(masanpham).Gia_sp;
            chiTietDonHang.Thanh_tien = (double.Parse(chiTietDonHang.Gia_ban)*soluong).ToString();
            ChiTietDonHangDAL.Add(chiTietDonHang);
            ChiTietDonHangDAL.Save();
        }

        //Lấy chi tiết đơn hàng theo mã đơn hàng
        public List<Chi_Tiet_Don_Hang> GetChiTietDonHangByMaDH(string madonhang)
        {
            try { 
            return ChiTietDonHangDAL.GetAll().Where(x => x.Ma_don_hang == madonhang).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lấy chi tiết đơn hàng theo mã đơn hàng: " + ex.Message);
                return null;
            }
        }

        public void Xoatoanbodonhang(string madonhang)
        {
            try
            {
                foreach (var item in GetChiTietDonHangByMaDH(madonhang)) ;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa chi tiết đơn hàng: " + ex.Message);
            }
        }

        //Hàm nhận vào 1 list các đơn hàng và lấy toàn bộ chi tiết đơn hàng theo thời gian start và end
        public List<Chi_Tiet_Don_Hang> get_ListCTDH_byListDH(List<Don_Hang> li_dh, DateTime start, DateTime end)
        {
            // Lọc các đơn hàng trong khoảng thời gian hợp lệ
            var maDHs = li_dh
                .Where(dh => dh.Ngay_dat_hang >= start && dh.Ngay_dat_hang <= end)
                .Select(dh => dh.Ma_don_hang)
                .ToHashSet();

            // Lấy danh sách CTDH có mã đơn hàng thuộc danh sách trên
            return this.GetAll().Where(ctdh => maDHs.Contains(ctdh.Ma_don_hang)).ToList();
        }

    }
}
