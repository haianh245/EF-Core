using HVIT_EF_QLNhanVien.Helper;
using QLNhanVienEF.Entitis;
using QLNhanVienEF.Helper;
using QLNhanVienEF.Service;
using System;

namespace HVIT_EF_QLNhanVien.View
{
    class QLNhanVienView
    {
        public void Menu()
        {
            Console.Clear();
            Console.WriteLine("" +
                "--------- QL Nhan Vien ---------\n" +
                "1. Them moi nhan vien\n" +
                "2. Them 1 nhan vien vao du an da ton tai\n" +
                "3. Sua thong tin du an\n" +
                "4. Xoa 1 nhan vien\n" +
                "5. Tinh luong cho nhan vien\n" +
                "6. Xem danh sach nhan vien\n" +
                "7. Xem danh sach du an\n" +
                "8. Thoat.");
            Console.Write("Chon nhiem vu: ");
            char c = Console.ReadKey().KeyChar;
            Console.WriteLine();
            DoAction(c);
        }
        private void DoAction(char c)
        {
            NhanVienService nhanVienService = new NhanVienService();
            DuAnService duAnService = new DuAnService();
            PhanCongService phanCongService = new PhanCongService();
            switch (c)
            {
                case '1':
                    {
                        errHelper.log(nhanVienService.ThemNhanVien(new NhanVien(inputType.ThemNhanVien)));
                    }
                    break;
                case '2':
                    {
                        errHelper.log(nhanVienService.ThemNhanVienVaoDuAn(new DuAn(inputType.ThemNhanVienVaoDuAn), new NhanVien(inputType.ThemNhanVienVaoDuAn), new PhanCong(inputType.ThemNhanVienVaoDuAn)));
                    }
                    break;
                case '3':
                    {
                        errHelper.log(duAnService.SuaThongTinDuAn(new DuAn(inputType.SuaThongTinDuAn)));
                    }
                    break;
                case '4':
                    {
                        errHelper.log(nhanVienService.XoaNhanVien(new NhanVien(inputType.XoaNhanVien)));
                    }
                    break;
                case '5':
                    {
                        errHelper.log(nhanVienService.TinhLuongChoNhanVien(new NhanVien(inputType.TinhLuongChoNhanVien)));
                    }
                    break;
                case '6':
                    {
                        Console.Write("Nhap ten nhan vien: ");
                        string keyword = Console.ReadLine();
                        var DSHS = nhanVienService.HienThiDSNhanVien(keyword);
                        foreach (var val in DSHS)
                        {
                            Console.WriteLine($"Ma nhan vien: {val.NhanVienId}, ho ten: {val.HoTen}, so dien thoai: {val.Sdt}, Dia chi: {val.DiaChi}, Email: {val.Email}, He so luong: {val.HeSoLuong}");
                        }
                    }
                    break;
                case '7':
                    {
                        Console.Write("Nhap ten du an: ");
                        string keyword = Console.ReadLine();                      
                        var DSDuAn = duAnService.HienThiDSDuAn(keyword);
                        foreach (var val in DSDuAn)
                        {
                            Console.WriteLine($"Ma du an: {val.DuAnId}, ten du an: {val.TenDuAn}, mo ta: {val.MoTa}, ghi chu: {val.GhiChu}");
                        }
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
