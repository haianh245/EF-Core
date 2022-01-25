using QL_KhoaHoc_EF03.Entities;
using QL_KhoaHoc_EF03.Helper;
using QL_KhoaHoc_EF03.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QL_KhoaHoc_EF03.Service
{
    class NgayHocService : INgayHocService
    {
        private QLKhoaHocDbContext dbContext { get; }
        public NgayHocService()
        {
            dbContext = new QLKhoaHocDbContext();
        }
        public ErrType ThemNgayHocVaoKhoaHoc(NgayHoc ngayHoc)
        {
            if (dbContext.khoaHocs.Any(x => x.KhoaHocID == ngayHoc.KhoaHocID))
            {
                var ktraKH = dbContext.khoaHocs.Find(ngayHoc.KhoaHocID);
                if ((ktraKH.NgayKetThuc - ktraKH.NgayBatDau).Days < 15)
                {
                    ktraKH.NgayKetThuc = ktraKH.NgayKetThuc.AddDays(+1);
                    dbContext.khoaHocs.Update(ktraKH);
                    ngayHoc.NgayHocID = 0;
                    dbContext.ngayHocs.Add(ngayHoc);
                    dbContext.SaveChanges();
                    return ErrType.ThanhCong;
                }
                return ErrType.KhoaHocDuLoTrinhHoc;
            }
            return ErrType.KhoaHocKhongTonTai;
        }
    }
}
