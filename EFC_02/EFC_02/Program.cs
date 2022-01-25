using EFC_02.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EFC_02
{
    class Program
    {
        private static AppDbContext context = new AppDbContext();
        public static List<MonAn> LayDanhSachMonAn(string tenNguyenLieu = null)
        {
            var lst = context.monAns.Include(x => x.CongThucs).ThenInclude(x => x.NguyenLieu).ToList();
            if(!string.IsNullOrEmpty(tenNguyenLieu))
            {
                lst = lst.Where(x => x.CongThucs.Any(y => y.NguyenLieu.TenNguyenLieu.ToLower().Contains(tenNguyenLieu.ToLower()))).ToList();
            }
            return lst;
        }
        public static MonAn LayMonAnTheoID(int monAnID)
        {
            return context.monAns.Include(x => x.CongThucs).ThenInclude(x => x.NguyenLieu).FirstOrDefault(x => x.MonAnID == monAnID);
        }
        public static string ThemMonAn(MonAn monAn)
        {
            using(var transaction = context.Database.BeginTransaction())
            {
                var lstCongThuc = monAn.CongThucs;
                monAn.CongThucs = null;
                context.monAns.Add(monAn);
                context.SaveChanges();
                if(lstCongThuc.Count>0)
                {
                    foreach(var congThuc in lstCongThuc)
                    {
                        if (context.nguyenLieus.Any(x => x.NguyenLieuID == congThuc.NguyenLieuID))
                        {
                            congThuc.MonAnID = monAn.MonAnID;
                            context.congThucs.Add(congThuc);
                        }
                        else return $"Nguyen lieu co id la {congThuc.NguyenLieuID} khong ton tai";
                    }
                    context.SaveChanges();
                }
                transaction.Commit();
            }
            return "Da them thanh cong";
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Hien thi danh sach mon an:
            //var res = LayDanhSachMonAn();
            //foreach (var item in res)
            //{
            //    Console.WriteLine($"Mon an {item.TenMon}");
            //    foreach (var congThuc in item.CongThucs)
            //    {
            //        Console.WriteLine($"[{congThuc.NguyenLieu.TenNguyenLieu}] - [{congThuc.SoLuong}] - [{congThuc.DonViTinh}]");
            //    }
            //}
            //Tim kiem mon an theo ten "Hanh hoac Toi":
            //Them moi mon an kem cong thuc mon an:
            var monAnMoi = new MonAn()
            {
                TenMon = "Com rang dua bo",
                LoaiMonAn = new LoaiMonAn() { TenLoai = "Com" },
                CongThucs = new List<CongThuc>
                {
                    new CongThuc()
                    {
                        NguyenLieuID = 7,
                        SoLuong = 200,
                        DonViTinh = "G"
                    },
                    new CongThuc()
                    {
                        NguyenLieuID = 1,
                        SoLuong = 100,
                        DonViTinh = "G"
                    },
                    new CongThuc()
                    {
                        NguyenLieuID = 2,
                        SoLuong = 150,
                        DonViTinh = "G"
                    },
                }
            };
            var noti = ThemMonAn(monAnMoi);
            Console.WriteLine(noti);
            var res = LayMonAnTheoID(monAnMoi.MonAnID);
            if (res != null)
            {
                Console.WriteLine($"Mon an {res.TenMon}");
                foreach (var congThuc in monAnMoi.CongThucs)
                {
                    Console.WriteLine($"[{congThuc.NguyenLieu.TenNguyenLieu}] - [{congThuc.SoLuong}] - [{congThuc.DonViTinh}]");
                }
            }
            else Console.WriteLine("Them moi that bai");
        }
    }
}
