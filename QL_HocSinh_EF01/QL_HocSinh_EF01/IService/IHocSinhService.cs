using QL_HocSinh_EF01.Entities;
using QL_HocSinh_EF01.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_HocSinh_EF01.IService
{
    interface IHocSinhService
    {
        public ErrType ThemHocSinh(HocSinh hocSinh);
        public ErrType SuaHocSinh(HocSinh hocSinh);
        public ErrType XoaHocSinh(HocSinh hocSinh);
        public ErrType ChuyenLop(HocSinh hocSinh);
    }
}
