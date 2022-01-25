using System;
using System.Collections.Generic;
using System.Text;

namespace QL_KhoaHoc_EF03.Helper
{
    enum ErrType
    {
        NgayHocDaTonTai,
        NgayHocKhongTonTai,
        KhoaHocKhongTonTai,
        KhoaHocDuLoTrinhHoc,
        HocVienKhongTonTai,
        ThanhCong
    }
    class ErrHelper
    {
        public static void Log(ErrType et)
        {
            switch (et)
            {
                case ErrType.ThanhCong:
                    Console.WriteLine("Thanh Cong!");
                    break;
                case ErrType.NgayHocDaTonTai:
                    Console.WriteLine("Ngay hoc da ton tai!");
                    break;
                case ErrType.NgayHocKhongTonTai:
                    Console.WriteLine("Ngay hoc khong ton tai!");
                    break;
                case ErrType.KhoaHocKhongTonTai:
                    Console.WriteLine("Khoa hoc chua ton tai!");
                    break;
                case ErrType.KhoaHocDuLoTrinhHoc:
                    Console.WriteLine("Khoa hoc da du lo trinh hoc da day!");
                    break;
                case ErrType.HocVienKhongTonTai:
                    Console.WriteLine("Hoc vien khong ton tai!");
                    break;
                default:
                    break;
            }
        }
    }
}
