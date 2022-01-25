using QL_HocSinh_EF01.View;
using System;

namespace QL_HocSinh_EF01
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            do
            {
                QLHocSinhView qLHocSinhView = new QLHocSinhView();
                qLHocSinhView.Menu();
                Console.ReadKey();
            } while (!exit);
        }
    }
}
