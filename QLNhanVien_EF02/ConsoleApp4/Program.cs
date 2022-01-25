using HVIT_EF_QLNhanVien.View;
using System;

namespace QLNhanVienEF
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            do
            {
                QLNhanVienView qLNhanVienView = new QLNhanVienView();
                qLNhanVienView.Menu();
                Console.ReadKey();
            } while (!exit);
        }
    }
}
