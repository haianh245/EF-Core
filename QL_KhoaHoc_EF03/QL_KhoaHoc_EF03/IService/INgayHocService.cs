using QL_KhoaHoc_EF03.Entities;
using QL_KhoaHoc_EF03.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace QL_KhoaHoc_EF03.IService
{
    interface INgayHocService
    {
        public ErrType ThemNgayHocVaoKhoaHoc(NgayHoc ngayHoc);
    }
}
