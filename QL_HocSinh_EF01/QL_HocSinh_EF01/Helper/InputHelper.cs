using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_HocSinh_EF01.Helper
{
    enum InputType
    {
        ThemHocSinh,
        SuaHocSinh,
        XoaHocSinh,
        ChuyenLop,
        XemDanhSachHS
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
                ok = name.Length <= 20 && arrStr.Length >= 2;
                if (!ok)
                {
                    Console.WriteLine(err);
                }
            } while (!ok);
            return name.Trim();
        }
    }
}
