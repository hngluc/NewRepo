using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HinhTron
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 1000;
            NhapSL(n);
            Console.WriteLine("n = " + n);
            Console.ReadLine();
        }

        private static void NhapSL(int n)
        {
            n = int.Parse(Console.ReadLine()) + n;
        }
    }
}
