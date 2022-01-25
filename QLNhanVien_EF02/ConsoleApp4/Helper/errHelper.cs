using System;
using System.Collections.Generic;
using System.Text;

namespace HVIT_EF_QLNhanVien.Helper
{
    enum errType
    {
        NhanVienKhongTonTai,
        NhanVienDaTonTai,
        DuAnKhongTonTai,
        DaTonTai,
        ThanhCong
    }
    class errHelper
    {
        public static void log(errType errType)
        {
            switch (errType)
            {
                case errType.NhanVienKhongTonTai:
                    {
                        Console.WriteLine("Nhan vien khong ton tai!");
                    }
                    break;
                case errType.DuAnKhongTonTai:
                    {
                        Console.WriteLine("Du an khong ton tai!");
                    }
                    break;
                case errType.DaTonTai:
                    {
                        Console.WriteLine("Da ton tai!");
                    }
                    break;
                case errType.ThanhCong:
                    {
                        Console.WriteLine("Thuc hien thanh cong!");
                    }
                    break;
                case errType.NhanVienDaTonTai:
                    {
                        Console.WriteLine("Nhan vien da ton tai!");
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
