using QL_KhoaHoc_EF03.Entities;
using QL_KhoaHoc_EF03.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace QL_KhoaHoc_EF03.IService
{
    interface IKhoaHocService
    {
        public ErrType XoaKhoaHoc(KhoaHoc khoaHoc);
        public int TinhDoanhThuTheoThang(int month, int year);
    }
}
