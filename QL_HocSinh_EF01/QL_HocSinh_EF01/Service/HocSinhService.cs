using QL_HocSinh_EF01.Entities;
using QL_HocSinh_EF01.Helper;
using QL_HocSinh_EF01.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_HocSinh_EF01.Service
{
    class HocSinhService : IHocSinhService
    {
        private QLHocSinhDbContext dbContext = new QLHocSinhDbContext();
        public void XemDanhSachHocSinh()
        {
            List<HocSinh> hocSinhs = dbContext.hocSinhs.AsQueryable().ToList();
            foreach (var item in hocSinhs)
            {
                Console.WriteLine("-------------------");
                Console.WriteLine($"Ma hoc Sinh: {item.HocSinhID}\nTen hoc sinh: {item.HoTen}\nLop: {item.LopID}\nNgay sinh: {item.NgaySinh}\nQue quan: {item.QueQuan}");
            }
        }
        public ErrType ChuyenLop(HocSinh hocSinh)
        {
            if (dbContext.hocSinhs.Any(x => x.HocSinhID == hocSinh.HocSinhID))
            {
                if(dbContext.lops.Any(x=>x.LopID==hocSinh.LopID))
                {
                    var hocSinhChuyenLop = dbContext.hocSinhs.Find(hocSinh.HocSinhID);
                    var lop1 = dbContext.lops.Find(hocSinh.LopID);
                    var lop2 = dbContext.lops.Find(hocSinhChuyenLop.LopID);
                    lop1.SiSo += 1;
                    lop2.SiSo -= 1;
                    dbContext.lops.Update(lop1);
                    dbContext.lops.Update(lop2);
                    hocSinhChuyenLop.LopID = hocSinh.LopID;
                    dbContext.hocSinhs.Update(hocSinhChuyenLop);
                    dbContext.SaveChanges();
                    return ErrType.ThanhCong;
                }
                else return ErrType.LopKhongTonTai;
            }
            return ErrType.HocSinhChuaTonTai;
        }

        public ErrType SuaHocSinh(HocSinh hocSinh)
        {
            if (dbContext.hocSinhs.Any(x => x.HocSinhID == hocSinh.HocSinhID))
            {
                var hocSinhNew = dbContext.hocSinhs.Find(hocSinh.HocSinhID);
                hocSinhNew.HoTen = hocSinh.HoTen;
                hocSinhNew.NgaySinh = hocSinh.NgaySinh;
                hocSinhNew.QueQuan = hocSinh.QueQuan;
                dbContext.hocSinhs.Update(hocSinhNew);
                dbContext.SaveChanges();
                return ErrType.ThanhCong;
            }
            return ErrType.HocSinhChuaTonTai;
        }

        public ErrType ThemHocSinh(HocSinh hocSinh)
        {
            if (dbContext.lops.Any(x => x.LopID == hocSinh.LopID))
            {
                hocSinh.HocSinhID = 0;
                dbContext.hocSinhs.Add(hocSinh);
                //Cap nhat si so:
                var lop = dbContext.lops.Find(hocSinh.LopID);
                lop.SiSo += 1;
                dbContext.lops.Update(lop);
                dbContext.SaveChanges();
                return ErrType.ThanhCong;
            }
            return ErrType.LopKhongTonTai;
        }

        public ErrType XoaHocSinh(HocSinh hocSinh)
        {
            if (dbContext.hocSinhs.Any(x => x.HocSinhID == hocSinh.HocSinhID))
            {
                var hocSinhDel = dbContext.hocSinhs.Find(hocSinh.HocSinhID);
                var lop = dbContext.lops.Find(hocSinhDel.LopID);
                lop.SiSo -= 1;
                dbContext.lops.Update(lop);
                dbContext.hocSinhs.Remove(hocSinhDel);
                dbContext.SaveChanges();
                return ErrType.ThanhCong;
            }
            return ErrType.HocSinhChuaTonTai;
        }
    }
}
