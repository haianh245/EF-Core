using QL_MonAn_EF_05.Entities;
using QL_MonAn_EF_05.Helper;
using QL_MonAn_EF_05.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QL_MonAn_EF_05.Service
{
    class CongThucService:ICongThucService
    {
        private static QLMonAnDbContext dbContext = new QLMonAnDbContext();

        public ErrType ThemCongThucChoMonAn(MonAn monAn)
        {
            if (dbContext.monAns.Any(x => x.MonAnID == monAn.MonAnID))
            {
                string cachLam = "";
                var monAnUpdate = dbContext.monAns.Find(monAn.MonAnID);
                var lstCongThuc = monAn.CongThucs;
                foreach (var congThuc in lstCongThuc)
                {
                    if (dbContext.nguyenLieus.Any(x => x.NguyenLieuID == congThuc.NguyenLieuID))
                    {
                        var nguyenLieu = dbContext.nguyenLieus.Find(congThuc.NguyenLieuID);
                        congThuc.MonAnID = monAn.MonAnID;
                        dbContext.congThucs.Add(congThuc);
                        cachLam += nguyenLieu.TenNguyenLieu + ": " + congThuc.SoLuong.ToString() + congThuc.DonViTinh + "\n";
                    }
                    else return ErrType.NguyenLieuKhongTonTai;
                }
                monAnUpdate.CachLam = cachLam;
                dbContext.monAns.Update(monAnUpdate);
                dbContext.SaveChanges();
                return ErrType.ThanhCong;
            }
            return ErrType.MonAnKhongTonTai;
        }
    }
}
