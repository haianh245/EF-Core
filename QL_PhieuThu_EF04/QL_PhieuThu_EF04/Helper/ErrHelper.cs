using System;
using System.Collections.Generic;
using System.Text;

namespace QL_PhieuThu_EF04.Helper
{
    enum ErrType
    {
        ThanhCong,
        LoaiNguyenLieuKhongTonTai,
        PhieuThuKhongTonTai,
        NguyenLieuKhongTonTai
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
                case ErrType.LoaiNguyenLieuKhongTonTai:
                    Console.WriteLine("Loai nguyen lieu khong ton tai !");
                    break;
                case ErrType.PhieuThuKhongTonTai:
                    Console.WriteLine("Phieu thu khong ton tai !");
                    break;
                case ErrType.NguyenLieuKhongTonTai:
                    Console.WriteLine("Nguyen lieu khong ton tai !");
                    break;
                default:
                    break;
            }
        }
    }
}
