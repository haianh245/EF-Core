using QL_MonAn_EF_05.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QL_MonAn_EF_05.Helper
{
    enum InputType
    {
        ThemMonAn,
        ThemCongThucChoMonAn,
        XoaMonAn,
        TimKiemMonAn
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
        public static List<CongThuc> NhapCongThuc(string msg, string err)
        {
            List<CongThuc> lst = new List<CongThuc>();
            Console.Write("Nhap so luong cong thuc: ");
            int a = int.Parse(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                CongThuc congThuc = new CongThuc();
                Console.WriteLine($"{msg} [{i+1}]: ");
                congThuc.NguyenLieuID = InputInt(res.inpNguyenLieuID, res.errNguyenLieuID);
                congThuc.SoLuong = InputInt(res.inpSoLuong, res.errSoLuong);
                congThuc.DonViTinh = InputString(res.inpDonViTinh, res.errDonViTinh);
                lst.Add(congThuc);
            }
            return lst;
        }
    }
}
