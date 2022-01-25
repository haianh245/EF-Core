using EFC_01.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EFC_01
{
    class Program
    {
        private static AppDbContext context = new AppDbContext();
        static List<HocSinh> LayDanhSachHocSinh(int? namSinh = null, string tenHocSinh = null)
        {
            var lst = context.HocSinhs.OrderByDescending(x => x.NgayDangKy).ToList();
            if(namSinh.HasValue)
            {
                lst = lst.Where(x => x.NgaySinh.Year == namSinh).ToList();
            }
            if(!string.IsNullOrEmpty(tenHocSinh))
            {
               lst = lst.Where(x => x.HoTen.ToLower().Contains(tenHocSinh.ToLower())).ToList();
            }
            return lst;
        }
        static HocSinh ThemHocSinh(HocSinh hocSinh)
        {
            context.HocSinhs.Add(hocSinh);
            context.SaveChanges();
            return hocSinh;
        }
        static string CapNhatThongTinHocSinh(HocSinh hocSinh)
        {
            if (context.HocSinhs.Any(x => x.HocSinhID == hocSinh.HocSinhID))
            {
                context.HocSinhs.Update(hocSinh);
                context.SaveChanges();
                return "Cap nhat thanh cong";
            }
            else return $"Hoc sinh co id la {hocSinh.HocSinhID} khong ton tai";
        }
        static string XoaHocSinh(int hocSinhId)
        {
            if (context.HocSinhs.Any(x => x.HocSinhID == hocSinhId))
            {
                var hocSinh = context.HocSinhs.Find(hocSinhId);
                context.HocSinhs.Remove(hocSinh);
                context.SaveChanges();
                return "Da xoa thanh cong";
            }
            else return $"Hoc sinh co id la {hocSinhId} khong ton tai";
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            var lstHocSinh = LayDanhSachHocSinh();
            foreach (var item in lstHocSinh)
            {
                Console.WriteLine($"Hoc sinh: {item.HoTen} - Trinh do hien tai: {item.TrinhDoHienTai} - Ngay sinh: {item.NgaySinh} - Ngay dang ky: {item.NgayDangKy}");
            }
            //HocSinh hocSinh = new HocSinh()
            //{
            //    HoTen = "Nguyen Quoc Hung",
            //    Email = "hung@gmail.com",
            //    GioiTinh = true,
            //    SDT = "012345677",
            //    DiaChi = "HN",
            //    NgaySinh = new DateTime(2002,1,1),
            //    TrinhDoHienTai = "9.0",
            //    NgayDangKy = DateTime.Now
            //};
            //var res = ThemHocSinh(hocSinh);
            //Console.WriteLine("Hoc sinh moi co thong tin:");
            //Console.WriteLine($"Hoc sinh: {res.HoTen} - Trinh do hien tai: {res.TrinhDoHienTai} - Ngay sinh: {res.NgaySinh} - Ngay dang ky: {res.NgayDangKy}");
            //var updateHocSinh = context.HocSinhs.Find(4);
            //if (updateHocSinh != null)
            //{
            //    updateHocSinh.HoTen = "Update";
            //    context.HocSinhs.Update(updateHocSinh);
            //    context.SaveChanges();
            //    Console.WriteLine("Da cap nhat thanh cong");
            //}
            //else Console.WriteLine("Hoc sinh co id 4 khong ton tai");
            //var res = XoaHocSinh(4);
            //Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
