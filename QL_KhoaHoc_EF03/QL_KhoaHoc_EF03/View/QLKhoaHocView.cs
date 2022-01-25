using QL_KhoaHoc_EF03.Entities;
using QL_KhoaHoc_EF03.Helper;
using QL_KhoaHoc_EF03.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace QL_KhoaHoc_EF03.View
{
    class QLKhoaHocView
    {
        public void Menu()
        {
            Console.Clear();
            Console.WriteLine("" +
                "--------- QL Hoc Sinh ---------\n" +
                "1. Them 1 ngay hoc vao 1 khoa hoc da ton tai\n" +
                "2. Sua thong tin hoc vien\n" +
                "3. Xoa khoa hoc\n" +
                "4. Tim kiem hoc vien theo ten va khoa hoc ma hoc vien do dang hoc\n" +
                "5. Tinh doanh thu cua trung tam trong thang\n" +
                "6. Thoat.");
            Console.Write("Chon tac vu: ");
            char c = Console.ReadKey().KeyChar;
            Console.WriteLine();
            DoAction(c);
        }
        private void DoAction(char c)
        {
            HocVienService hocVienService = new HocVienService();
            NgayHocService ngayHocService = new NgayHocService();
            KhoaHocService khoaHocService = new KhoaHocService();
            switch (c)
            {
                case '1':
                    {
                        ErrHelper.Log(ngayHocService.ThemNgayHocVaoKhoaHoc(new NgayHoc(InputType.ThemNgayHocVaoKhoaHoc)));
                    }
                    break;
                case '2':
                    {
                        ErrHelper.Log(hocVienService.SuaThongTinHocVien(new HocVien(InputType.SuaThongTinHocVien)));
                    }
                    break;
                case '3':
                    {
                        ErrHelper.Log(khoaHocService.XoaKhoaHoc(new KhoaHoc(InputType.XoaKhoaHoc)));
                    }
                    break;
                case '4':
                    {
                        string tenHV = InputHelper.NhapTen(res.InpHoTen, res.ErrHoTen);
                        int maKH = InputHelper.InputInt(res.InpKhoaHocID, res.ErrKHoaHocID);
                        var DSHV = hocVienService.TimKiemHocVienTheoTen(tenHV,maKH);
                        foreach (var val in DSHV)
                        {
                            Console.WriteLine($"Ma hoc vien: {val.HocVienID}, ma khoa hoc: {val.KhoaHocID}, ho ten: {val.HoTen}, ngay sinh: {val.NgaySinh.ToShortDateString()}, dia chi: {val.DiaChi}, que quan: {val.QueQuan}, so dien thoai: {val.SoDienThoai}");
                        }
                    }
                    break;
                case '5':
                    {
                        Console.Write("Nhap thang: ");
                        int month = int.Parse(Console.ReadLine());
                        Console.Write("Nhap nam: ");
                        int year = int.Parse(Console.ReadLine());
                        int doanhThu = khoaHocService.TinhDoanhThuTheoThang(month, year);
                        Console.WriteLine($"Doanh thu thang {month}, nam {year} la: {doanhThu}");
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
