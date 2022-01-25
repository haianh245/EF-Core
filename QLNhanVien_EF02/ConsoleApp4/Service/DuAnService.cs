using HVIT_EF_QLNhanVien.Helper;
using QLNhanVienEF.Entitis;
using QLNhanVienEF.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLNhanVienEF.Service
{
    class DuAnService : IDuAnService
    {
        private QLNhanVienDbContext dbContext { get; }
        public DuAnService()
        {
            dbContext = new QLNhanVienDbContext();
        }
        public IEnumerable<DuAn> HienThiDSDuAn(string keyword = null)
        {
            var query = dbContext.duAns.AsQueryable();
            if (!string.IsNullOrEmpty(keyword))
            {
                query = query.Where(x => x.TenDuAn.Contains(keyword));
            }
            return query;
        }
        public errType SuaThongTinDuAn(DuAn da)
        {
            if(dbContext.duAns.Any(x=>x.DuAnId==da.DuAnId))
            {
                var daUpdate = dbContext.duAns.Find(da.DuAnId);
                daUpdate.TenDuAn = da.TenDuAn;
                daUpdate.GhiChu = da.GhiChu;
                daUpdate.MoTa = da.MoTa;
                dbContext.Update(daUpdate);
                dbContext.SaveChanges();
                return errType.ThanhCong;
            }
            return errType.DuAnKhongTonTai;
        }
    }
}
