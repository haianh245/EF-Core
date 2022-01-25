using QL_KhoaHoc_EF03.Entities;
using QL_KhoaHoc_EF03.Helper;
using QL_KhoaHoc_EF03.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QL_KhoaHoc_EF03.Service
{
    class HocVienService : IHocVienService
    {
        private QLKhoaHocDbContext dbContext { get; }
        public HocVienService()
        {
            dbContext = new QLKhoaHocDbContext();
        }
        public ErrType SuaThongTinHocVien(HocVien hocVien)
        {
            if (dbContext.hocViens.Any(x => x.HocVienID == hocVien.HocVienID))
            {
                var hv = dbContext.hocViens.Find(hocVien.HocVienID);
                hv.HoTen = hocVien.HoTen;
                hv.NgaySinh = hocVien.NgaySinh;
                hv.DiaChi = hocVien.DiaChi;
                hv.QueQuan = hocVien.QueQuan;
                hv.SoDienThoai = hocVien.SoDienThoai;
                dbContext.Update(hv);
                dbContext.SaveChanges();
                return ErrType.ThanhCong;
            }
            return ErrType.HocVienKhongTonTai;
        }

        public IEnumerable<HocVien> TimKiemHocVienTheoTen(string tenHV, int maKH)
        {
            var query = dbContext.hocViens.AsQueryable();
            if (!string.IsNullOrEmpty(tenHV))
            {
                query = query.Where(x => x.HoTen.Contains(tenHV));
            }
            query = query.Where(x => x.KhoaHocID == maKH);
            IEnumerable<HocVien> kt = query;
            int dem = 0;
            foreach(HocVien item in query)
            {
                dem++;
            }
            if (dem == 0) Console.WriteLine("Khong tim thay!");
            return query;
        }
    }
}
