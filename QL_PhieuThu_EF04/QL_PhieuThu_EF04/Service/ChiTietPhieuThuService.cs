using QL_PhieuThu_EF04.Entities;
using QL_PhieuThu_EF04.Helper;
using QL_PhieuThu_EF04.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QL_PhieuThu_EF04.Service
{
    class ChiTietPhieuThuService : IChiTietPhieuThuService
    {
        private QLPhieuThuDbContext dbContext { get; }
        public ChiTietPhieuThuService()
        {
            dbContext = new QLPhieuThuDbContext();
        }
        public ErrType ThemChiTietPhieuThu(PhieuThu phieuThu)
        {
            var lstChiTietPhieuThu = phieuThu.ChiTietPhieuThus;
            if (dbContext.phieuThus.Any(x => x.PhieuthuID == phieuThu.PhieuthuID))
            {
                foreach (var item in lstChiTietPhieuThu)
                {
                    if (dbContext.nguyenLieus.Any(x => x.NguyenlieuID == item.NguyenlieuID)) 
                    {
                        item.PhieuthuID = phieuThu.PhieuthuID;
                        dbContext.chiTietPhieuThus.Add(item);
                    }
                    else return ErrType.NguyenLieuKhongTonTai;
                }
                dbContext.SaveChanges();
                return ErrType.ThanhCong;
            }
            return ErrType.PhieuThuKhongTonTai;
        }
    }
}
