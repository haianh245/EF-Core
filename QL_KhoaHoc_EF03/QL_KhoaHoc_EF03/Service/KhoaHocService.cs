using QL_KhoaHoc_EF03.Entities;
using QL_KhoaHoc_EF03.Helper;
using QL_KhoaHoc_EF03.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QL_KhoaHoc_EF03.Service
{
    class KhoaHocService : IKhoaHocService
    {
        private QLKhoaHocDbContext dbContext { get; }
        public KhoaHocService()
        {
            dbContext = new QLKhoaHocDbContext();
        }
        public ErrType XoaKhoaHoc(KhoaHoc khoaHoc)
        {
            if (dbContext.khoaHocs.Any(x => x.KhoaHocID == khoaHoc.KhoaHocID))
            {
                var kh = dbContext.khoaHocs.Find(khoaHoc.KhoaHocID);
                dbContext.Remove(kh);
                dbContext.SaveChanges();
                return ErrType.ThanhCong;
            }
            return ErrType.KhoaHocKhongTonTai;
        }
        public int TinhDoanhThuTheoThang(int month, int year)
        {
            int doanhThu = 0;
            var query = (from kh in dbContext.khoaHocs
                        join hs in dbContext.hocViens on kh.KhoaHocID equals hs.KhoaHocID
                        where kh.NgayBatDau.Month == month && kh.NgayBatDau.Year == year
                        group kh by kh.KhoaHocID into g
                        select new
                        {
                            KhoaHocID = g.Key,
                            CountHv = g.Count() 
                        }).ToList();
            foreach( var i in query)
            {
                var khoaHoc = dbContext.khoaHocs.Find(i.KhoaHocID);
                doanhThu += i.CountHv * khoaHoc.HocPhi;
            }
            return doanhThu;
            //var kh = dbContext.khoaHocs.AsQueryable();
           // IEnumerable<KhoaHoc> kh = dbContext.khoaHocs.Where(x => x.NgayBatDau.Month == month && x.NgayBatDau.Year == year);
            //var hv = dbContext.hocViens.AsQueryable();
            //foreach(KhoaHoc item in kh)
            //{
            //    int dem = 0;
            //    IEnumerable<HocVien> hv = dbContext.hocViens.Where(x => x.KhoaHocID == item.KhoaHocID);
            //    foreach (HocVien hocVien in hv)
            //        dem++;
            //    doanhThu += item.HocPhi * dem;
            //}
          //  Console.WriteLine($"Doanh thu cua trung tam trong thang {month}, nam {year} la: {doanhThu}");
        }
    }
}
