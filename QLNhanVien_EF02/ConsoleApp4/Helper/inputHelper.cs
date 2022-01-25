using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HVIT_EF_QLNhanVien.Helper
{
    enum inputType
    {
        ThemNhanVien,
        ThemNhanVienVaoDuAn,
        SuaThongTinDuAn,
        XoaNhanVien,
        TinhLuongChoNhanVien
    }
    class inputHelper
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
                ok = arrStr.Length >= 2 && name.Length <= 20;
                if (!ok)
                {
                    Console.WriteLine(err);
                }
            } while (!ok);
            return name.Trim();
        }
        public static string NhapTenDuAn(string msg, string err)
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
                ok = name.Length <= 10;
                if (!ok)
                {
                    Console.WriteLine(err);
                }
            } while (!ok);
            return name.Trim();
        }
    }
}
