using QL_PhieuThu_EF04.Entities;
using QL_PhieuThu_EF04.Helper;
using QL_PhieuThu_EF04.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QL_PhieuThu_EF04.Service
{
    class NguyenLieuService : INguyenLieuService
    {
        private QLPhieuThuDbContext dbContext { get; }
        public NguyenLieuService()
        {
            dbContext = new QLPhieuThuDbContext();
        }
        public ErrType ThemNguyenLieu(NguyenLieu nguyenLieu)
        {
            if (dbContext.loaiNguyenLieus.Any(x => x.LoainguyenlieuID == nguyenLieu.LoainguyenlieuID))
            {
                nguyenLieu.NguyenlieuID = 0;
                dbContext.nguyenLieus.Add(nguyenLieu);
                dbContext.SaveChanges();
                return ErrType.ThanhCong;
            }
            return ErrType.LoaiNguyenLieuKhongTonTai;
        }
    }
}
