using QL_HocSinh_EF01.Entities;
using QL_HocSinh_EF01.Helper;
using QL_HocSinh_EF01.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_HocSinh_EF01.View
{
    class QLHocSinhView
    {
        public void Menu()
        {
            Console.Clear();
            Console.WriteLine("" +
                "-----------QL Hoc Sinh -----------\n" +
                "1.Them hoc sinh vao lop\n" +
                "2.Sua thong tin hoc sinh\n" +
                "3.Xoa hoc sinh\n" +
                "4.Chuyen lop cho hoc sinh\n" +
                "5.Xem danh sach hoc sinh\n" +
                "6.Thoat.");
            Console.Write("Chon nhiem vu: ");
            char c = Console.ReadKey().KeyChar;
            Console.WriteLine();
            DoAction(c);
        }
        private void DoAction(char c)
        {
            HocSinhService hocSinhService = new HocSinhService();
            switch (c)
            {
                case '1':
                    {
                        ErrHelper.log(hocSinhService.ThemHocSinh(new HocSinh(InputType.ThemHocSinh)));
                    }
                    break;
                case '2':
                    {
                        ErrHelper.log(hocSinhService.SuaHocSinh(new HocSinh(InputType.SuaHocSinh)));
                    }
                    break;
                case '3':
                    {
                        ErrHelper.log(hocSinhService.XoaHocSinh(new HocSinh(InputType.XoaHocSinh)));
                    }
                    break;
                case '4':
                    {
                        ErrHelper.log(hocSinhService.ChuyenLop(new HocSinh(InputType.ChuyenLop)));
                    }
                    break;
                case '5':
                    {
                        hocSinhService.XemDanhSachHocSinh();
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
