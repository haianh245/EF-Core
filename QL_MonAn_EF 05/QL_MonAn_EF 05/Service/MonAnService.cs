using Microsoft.EntityFrameworkCore;
using QL_MonAn_EF_05.Entities;
using QL_MonAn_EF_05.Helper;
using QL_MonAn_EF_05.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QL_MonAn_EF_05.Service
{
    class MonAnService:IMonAnService
    {
        private static QLMonAnDbContext dbContext = new QLMonAnDbContext();

        public ErrType ThemMonAnThuocLoaiMonAnDaTonTai(MonAn monAn)
        {
            if (dbContext.loaiMonAns.Any(x => x.LoaiMonAnID == monAn.LoaiMonAnID))
            {
                monAn.MonAnID = 0;
                dbContext.monAns.Add(monAn);
                dbContext.SaveChanges();
                return ErrType.ThanhCong;
            }
            return ErrType.LoaiMonAnKhongTonTai;
        }

        public List<MonAn> TimKiemMonAn(string tenMonAn = null, string tenNguyenLieu = null)
        {
            var lst = dbContext.monAns.Include(x => x.CongThucs).ThenInclude(x => x.NguyenLieu).ToList();
            if(!string.IsNullOrEmpty(tenMonAn))
            {
                lst = lst.Where(x => x.TenMon.ToLower().Contains(tenMonAn.ToLower())).ToList();
            }
            if (!string.IsNullOrEmpty(tenNguyenLieu))
            {
                lst = lst.Where(x => x.CongThucs.Any(y => y.NguyenLieu.TenNguyenLieu.ToLower().Contains(tenNguyenLieu.ToLower()))).ToList();
            }
            return lst;
        }

        public ErrType XoaMonAn(MonAn monAn)
        {
            if (dbContext.monAns.Any(x => x.MonAnID == monAn.MonAnID))
            {
                var monAnRemove = dbContext.monAns.Find(monAn.MonAnID);
                dbContext.Remove(monAnRemove);
                dbContext.SaveChanges();
                return ErrType.ThanhCong;
            }
            return ErrType.MonAnKhongTonTai;
        }
        public List<MonAn> HienThiMonAn()
        {
            using(var trans=dbContext.Database.BeginTransaction())
            {
                var query = dbContext.monAns.ToList();
                return query;
            }
        }
    }
}
