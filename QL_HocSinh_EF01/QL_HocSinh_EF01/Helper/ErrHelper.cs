using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_HocSinh_EF01.Helper
{
    enum ErrType
    {
        ThanhCong,
        HocSinhDaTonTai,
        HocSinhChuaTonTai,
        LopKhongTonTai,
    }
    class ErrHelper
    {
        public static void log(ErrType et)
        {
            switch (et)
            {
                case ErrType.ThanhCong:
                    Console.WriteLine("Thanh cong !");
                    break;
                case ErrType.HocSinhDaTonTai:
                    Console.WriteLine("Hoc sinh da ton tai !");
                    break;
                case ErrType.HocSinhChuaTonTai:
                    Console.WriteLine("hoc sinh chua ton tai !");
                    break;
                case ErrType.LopKhongTonTai:
                    Console.WriteLine("lop khong ton tai !");
                    break;
                default:
                    break;
            }
        }
    }
}
