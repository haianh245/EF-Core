using QL_PhieuThu_EF04.Entities;
using QL_PhieuThu_EF04.Helper;
using QL_PhieuThu_EF04.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace QL_PhieuThu_EF04.View
{
    class QLPhieuThuView
    {
        public void Menu()
        {
            Console.Clear();
            Console.WriteLine("" +
                "--------- QL Phieu Thu ---------\n" +
                "1. Them 1 nguyen lieu thuoc 1 loai nguyen lieu da ton tai\n" +
                "2. Them 1 danh sach phieu cho 1 phieu thu cu the\n" +
                "3. Them 1 phieu thu\n" +
                "4. Xoa 1 phieu thu\n" +
                "5. Lay thong tin cac phieu thu theo thoi gian\n" +
                "6. Thoat.");
            Console.Write("Chon tac vu: ");
            char c = Console.ReadKey().KeyChar;
            Console.WriteLine();
            DoAction(c);
        }
        private void DoAction(char c)
        {
            ChiTietPhieuThuService chiTietPhieuThuService = new ChiTietPhieuThuService();
            NguyenLieuService nguyenLieuService = new NguyenLieuService();
            PhieuThuService phieuThuService = new PhieuThuService();
            switch (c)
            {
                case '1':
                    {
                        ErrHelper.Log(nguyenLieuService.ThemNguyenLieu(new NguyenLieu(InputType.ThemNguyenLieu)));
                    }
                    break;
                case '2':
                    {
                        ErrHelper.Log(chiTietPhieuThuService.ThemChiTietPhieuThu(new PhieuThu(InputType.ThemDSChiTietPhieuThu)));
                    }
                    break;
                case '3':
                    {
                        ErrHelper.Log(phieuThuService.ThemPhieuThu(new PhieuThu(InputType.ThemPhieuThu)));
                    }
                    break;
                case '4':
                    {
                        ErrHelper.Log(phieuThuService.XoaPhieuThu(new PhieuThu(InputType.XoaPhieuThu)));
                    }
                    break;
                case '5':
                    {
                        DateTime min = InputHelper.InputDT("Nhap ngay bat dau: ", "Phai la kieu ngay thang !", new DateTime(2000 - 1 - 1), DateTime.Now);
                        DateTime max = InputHelper.InputDT("Nhap ngay ket thuc: ", "Phai la kieu ngay thang !", new DateTime(2000 - 1 - 1), DateTime.Now);
                        phieuThuService.LayThongTinPhieuThuTheoThoiGian(min,max);
                    }
                    break;
                case '6':
                    return;
                default:
                    break;
            }
            Console.ReadKey();
            Menu();
        }
    }
}
