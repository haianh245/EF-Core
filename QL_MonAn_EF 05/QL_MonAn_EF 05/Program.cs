using QL_MonAn_EF_05.View;
using System;

namespace QL_MonAn_EF_05
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            do
            {
                QLMonAnView qLMonAnView = new QLMonAnView();
                qLMonAnView.Menu();
                Console.ReadKey();
            } while (!exit);
        }
    }
}
