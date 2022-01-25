using QL_PhieuThu_EF04.View;
using System;

namespace QL_PhieuThu_EF04
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            do
            {
                QLPhieuThuView qLPhieuThuView = new QLPhieuThuView();
                qLPhieuThuView.Menu();
                Console.ReadKey();
            } while (!exit);
        }
    }
}
