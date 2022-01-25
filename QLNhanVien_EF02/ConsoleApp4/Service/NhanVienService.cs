using HVIT_EF_QLNhanVien.Helper;
using QLNhanVienEF.Entitis;
using QLNhanVienEF.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLNhanVienEF.Service
{
    class NhanVienService : INhanVienService
    {
        private QLNhanVienDbContext dbContext { get; }
        public NhanVienService()
        {
            dbContext = new QLNhanVienDbContext();
        }
        public IEnumerable<NhanVien> HienThiDSNhanVien(string keyword = null)
        {
            var query = dbContext.nhanViens.AsQueryable();
            if (!string.IsNullOrEmpty(keyword))
            {
                query = query.Where(x => x.HoTen.Contains(keyword));
            }
            return query;
        }
        public errType ThemNhanVien(NhanVien nv)
        {
            nv.NhanVienId = 0;
            dbContext.nhanViens.Add(nv);
            dbContext.SaveChanges();
            return errType.ThanhCong;
        }
        public errType XoaNhanVien(NhanVien nv)
        {
            if (dbContext.nhanViens.Any(x => x.NhanVienId == nv.NhanVienId)) 
            {
                var nvRemove = dbContext.nhanViens.Find(nv.NhanVienId);
                dbContext.Remove(nvRemove);
                dbContext.SaveChanges();
                return errType.ThanhCong;
            }
            return errType.NhanVienKhongTonTai;
        }
        public errType ThemNhanVienVaoDuAn(DuAn da, NhanVien nv, PhanCong pc)
        {
            if (dbContext.duAns.Any(x => x.DuAnId == da.DuAnId))
            {
                if (dbContext.nhanViens.Any(x => x.NhanVienId == nv.NhanVienId))
                {                  
                    pc.PhanCongId = 0;
                    pc.NhanVienId = nv.NhanVienId;
                    pc.DuAnId = da.DuAnId;
                    dbContext.phanCongs.Add(pc);
                    dbContext.SaveChanges();
                    return errType.ThanhCong;
                }
                return errType.NhanVienKhongTonTai;
            }
            return errType.DuAnKhongTonTai;
        }
        public errType TinhLuongChoNhanVien(NhanVien nv)
        {
            if (dbContext.nhanViens.Any(x => x.NhanVienId == nv.NhanVienId))
            {
                float luong = 0;
                var nhanVien = dbContext.nhanViens.Find(nv.NhanVienId);
                var phanCong = dbContext.phanCongs.AsEnumerable().Where(x => x.NhanVienId == nhanVien.NhanVienId);
                foreach(PhanCong item in phanCong)
                {
                    luong += item.SoGioLam * 15 * nhanVien.HeSoLuong;
                }
                return errType.ThanhCong;
                Console.WriteLine($"Luong cua nhan vien la: {luong}");
            }
            return errType.NhanVienKhongTonTai;
        }
    }
}
