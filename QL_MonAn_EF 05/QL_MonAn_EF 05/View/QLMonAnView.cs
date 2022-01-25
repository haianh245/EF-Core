using QL_MonAn_EF_05.Entities;
using QL_MonAn_EF_05.Helper;
using QL_MonAn_EF_05.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_MonAn_EF_05.View
{
    class QLMonAnView
    {
        public void Menu()
        {
            Console.Clear();
            Console.WriteLine("" +
                "--------- QL Mon An ---------\n" +
                "1. Them mot mon an thuoc loai mon an da ton tai\n" +
                "2. Them cac cong thuc cho mon an\n" +
                "3. Xoa mon an\n" +
                "4. Tim kiem mon an theo ten mon va nguyen lieu\n" +
                "5. Hien thi danh sach mon an\n" +
                "6. \n" +
                "7. \n" +
                "8. Thoat.");
            Console.Write("Chon nhiem vu: ");
            char c = Console.ReadKey().KeyChar;
            Console.WriteLine();
            DoAction(c);
        }
        private void DoAction(char c)
        {
            MonAnService monAnService = new MonAnService();
            CongThucService congThucService = new CongThucService();
            switch (c)
            {
                case '1':
                    {
                        ErrHelper.log(monAnService.ThemMonAnThuocLoaiMonAnDaTonTai(new MonAn(InputType.ThemMonAn)));
                    }
                    break;
                case '2':
                    {
                        ErrHelper.log(congThucService.ThemCongThucChoMonAn(new MonAn(InputType.ThemCongThucChoMonAn)));
                    }
                    break;
                case '3':
                    {
                        ErrHelper.log(monAnService.XoaMonAn(new MonAn(InputType.XoaMonAn)));
                    }
                    break;
                case '4':
                    {
                        Console.Write("Nhap ten mon: ");
                        string tenMon = Console.ReadLine();
                        Console.Write("Nhap ten nguyen lieu: ");
                        string tenNguyenLieu = Console.ReadLine();
                        var res = monAnService.TimKiemMonAn(tenMon, tenNguyenLieu);
                        foreach (var item in res)
                        {
                            Console.WriteLine($"Mon an {item.TenMon}:\n{item.CachLam}");
                        }
                        if (res.Count == 0) Console.WriteLine("Khong co mon can tim !");
                    }
                    break;
                case '5':
                    {
                        //monAnService.HienThiMonAn().ForEach(item => Console.WriteLine(item.CachLam));
                    }
                    break;
                case '6':
                    {
                        
                    }
                    break;
                case '7':
                    {
                        
                    }
                    break;
                default:
                    break;
            }
            Console.ReadKey();
            Menu();
        }
    }
}
