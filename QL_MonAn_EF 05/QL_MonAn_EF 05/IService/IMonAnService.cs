using QL_MonAn_EF_05.Entities;
using QL_MonAn_EF_05.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace QL_MonAn_EF_05.IService
{
    interface IMonAnService
    {
        public ErrType ThemMonAnThuocLoaiMonAnDaTonTai(MonAn monAn);
        public ErrType XoaMonAn(MonAn monAn);
        public List<MonAn> TimKiemMonAn(string tenMonAn = null, string tenNguyenLieu = null);
    }
}
