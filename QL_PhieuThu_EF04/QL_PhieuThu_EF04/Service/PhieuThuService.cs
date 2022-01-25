using Microsoft.EntityFrameworkCore;
using QL_PhieuThu_EF04.Entities;
using QL_PhieuThu_EF04.Helper;
using QL_PhieuThu_EF04.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QL_PhieuThu_EF04.Service
{
    class PhieuThuService : IPhieuThuService
    {
        private QLPhieuThuDbContext dbContext { get; }
        public PhieuThuService()
        {
            dbContext = new QLPhieuThuDbContext();
        }
        public ErrType ThemPhieuThu(PhieuThu phieuThu)
        {
            phieuThu.PhieuthuID = 0;
            var lstChiTietPhieuThu = phieuThu.ChiTietPhieuThus;
            foreach (var item in lstChiTietPhieuThu)
            {
                if (dbContext.nguyenLieus.Any(x => x.NguyenlieuID == item.NguyenlieuID))
                {
                    //add chi tiet phieu thu vao database:
                    item.PhieuthuID = phieuThu.PhieuthuID;
                    dbContext.chiTietPhieuThus.Add(item);
                    //cap nhat lai so luong kho cua nguyen lieu sau khi xuat kho:
                    NguyenLieu nguyenLieu = dbContext.nguyenLieus.Find(item.NguyenlieuID);
                    nguyenLieu.Soluongkho = nguyenLieu.Soluongkho - item.Soluongban;
                    dbContext.nguyenLieus.Update(nguyenLieu);
                    //cap nhat thanh tien cua phieu thu:
                    phieuThu.Thanhtien += item.Soluongban * nguyenLieu.Giaban;
                }
                else return ErrType.NguyenLieuKhongTonTai;
            }
            dbContext.phieuThus.Add(phieuThu);
            dbContext.SaveChanges();
            return ErrType.ThanhCong;
        }

        public ErrType XoaPhieuThu(PhieuThu phieuThu)
        {
            if (dbContext.phieuThus.Any(x => x.PhieuthuID == phieuThu.PhieuthuID))
            {
                var phieuThuRemove = dbContext.phieuThus.Find(phieuThu.PhieuthuID);
                dbContext.phieuThus.Remove(phieuThuRemove);
                dbContext.SaveChanges();
                return ErrType.ThanhCong;
            }
            return ErrType.PhieuThuKhongTonTai;
        }

        public void LayThongTinPhieuThuTheoThoiGian(DateTime min, DateTime max)
        {
            var lstPhieuThu = dbContext.phieuThus.Include(x => x.ChiTietPhieuThus).ThenInclude(x => x.NguyenLieu).ToList();
            lstPhieuThu = lstPhieuThu.Where(x => x.Ngaylap >= min && x.Ngaylap <= max).ToList();
            if (lstPhieuThu.Count > 0)
            {
                foreach (var item in lstPhieuThu)
                {
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine($"Ma Phieu Thu: {item.PhieuthuID}\nNgay lap: {item.Ngaylap}\nNhan vien lap: {item.Nhanvienlap}\nGhi chu: {item.Ghichu}\nThanh tien: {item.Thanhtien}");
                    List<ChiTietPhieuThu> lstChiTietPhieuThu = item.ChiTietPhieuThus;
                    foreach (var chiTietPhieu in lstChiTietPhieuThu)
                    {
                        int i = 1;
                        NguyenLieu nguyenLieu = dbContext.nguyenLieus.Find(chiTietPhieu.NguyenlieuID);
                        Console.WriteLine($"San pham {1}: {nguyenLieu.Tennguyenlieu} - So luong: {chiTietPhieu.Soluongban} {nguyenLieu.Donvitinh} - Gia ban: {nguyenLieu.Giaban}");
                        i += 1;
                    }
                }
            }
            else
                Console.WriteLine("Khong tim duoc phieu thu nao trong khoang thoi gian da chon !");
        }
    }
}
