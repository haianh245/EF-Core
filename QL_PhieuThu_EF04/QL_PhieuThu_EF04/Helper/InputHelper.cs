using QL_PhieuThu_EF04.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QL_PhieuThu_EF04.Helper
{
    enum InputType
    {
        ThemNguyenLieu,
        ThemDSChiTietPhieuThu,
        ThemPhieuThu,
        XoaPhieuThu,
        LayThongTinPhieuThuTheoTG
    }
    class InputHelper
    {
        public static int InputInt(string msg, string err, int minValue = int.MinValue, int maxValue = int.MaxValue)
        {
            int ret;
            bool ok;
            do
            {
                Console.Write(msg);
                string str = Console.ReadLine();
                ok = int.TryParse(str, out ret);
                ok = ok && (ret >= minValue && ret <= maxValue);
                if (!ok)
                {
                    Console.WriteLine(err);
                }
            } while (!ok);
            return ret;
        }
        public static string InputString(string msg, string err, int minLength = int.MinValue, int maxLength = int.MaxValue)
        {
            string str;
            bool ok;
            do
            {
                Console.Write(msg);
                str = Console.ReadLine();
                ok = !string.IsNullOrEmpty(str);
                ok = ok && str.Length >= minLength && str.Length <= maxLength;
                if (!ok)
                {
                    Console.WriteLine(err);
                }
            } while (!ok);
            return str;
        }
        public static DateTime InputDT(string msg, string err, DateTime min, DateTime max)
        {
            bool ok = true;
            DateTime ret;
            do
            {
                Console.Write(msg);
                ok = DateTime.TryParse(Console.ReadLine(), out ret);
                ok = ok && ret >= min && ret <= max;
                if (!ok)
                    Console.WriteLine(err);
            } while (!ok);
            return ret;
        }
        public static string NhapTen(string msg, string err)
        {
            string name = "";
            bool ok;
            string str;
            do
            {
                str = InputString(msg, err);
                str = str.ToLower().Trim();
                while (str.Contains("  "))
                {
                    str = str.Replace("  ", " ");
                }
                string[] arrStr = str.Split(' ');
                for (int i = 0; i < arrStr.Length; i++)
                {
                    name += arrStr[i].First().ToString().ToUpper() + arrStr[i].Substring(1) + " ";
                }
                ok = name.Length <= 20;
                if (!ok)
                {
                    Console.WriteLine(err);
                }
            } while (!ok);
            return name.Trim();
        }
        public static List<ChiTietPhieuThu> NhapDSCTPhieuThu(string msg)
        {
            List<ChiTietPhieuThu> lst = new List<ChiTietPhieuThu>();
            Console.Write("Nhap so luong cua danh sach chi tiet phieu thu: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                ChiTietPhieuThu chiTietPhieuThu = new ChiTietPhieuThu();
                Console.WriteLine($"{msg}[{i + 1}]: ");
                chiTietPhieuThu.NguyenlieuID = InputInt(res.InpNguyenLieuID, res.ErrNguyenLieuID);
                chiTietPhieuThu.Soluongban = InputInt(res.InpSoLuongBan, res.ErrSoLuongBan);
                lst.Add(chiTietPhieuThu);
            }
            return lst;
        }
    }
}
