using System;
using System.Collections.Generic;
using System.Text;

namespace QL_MonAn_EF_05.Helper
{
    enum ErrType
    {
        ThanhCong,
        LoaiMonAnKhongTonTai,
        MonAnKhongTonTai,
        NguyenLieuKhongTonTai
    }
    class ErrHelper
    {
        public static void log(ErrType et)
        {
            switch(et)
            {
                case ErrType.ThanhCong:
                    {
                        Console.WriteLine("Thanh cong!");
                    }
                    break;
                case ErrType.LoaiMonAnKhongTonTai:
                    {
                        Console.WriteLine("Loai mon an khong ton tai!");
                    }
                    break;
                case ErrType.MonAnKhongTonTai:
                    {
                        Console.WriteLine("Mon an khong ton tai!");
                    }
                    break;
                case ErrType.NguyenLieuKhongTonTai:
                    {
                        Console.WriteLine("Nguyen lieu khong ton tai!");
                    }
                    break;
            }
        }
    }
}
