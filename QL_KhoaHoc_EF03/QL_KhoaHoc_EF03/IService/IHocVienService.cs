using QL_KhoaHoc_EF03.Entities;
using QL_KhoaHoc_EF03.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace QL_KhoaHoc_EF03.IService
{
    interface IHocVienService
    {
        public IEnumerable<HocVien> TimKiemHocVienTheoTen(string tenHV,int maKH);
        public ErrType SuaThongTinHocVien(HocVien hocVien);
    }
}
