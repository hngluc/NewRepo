
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HinhChuNhat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var listhcn = NhapNHCN();
            xuat(listhcn);
            Console.WriteLine("---------------------------------------------");
            listhcn = sortHCN(listhcn);
            Console.WriteLine("Hinh chu nhat da sap xep!");
            xuat(listhcn);
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine($"So hinh chu nhat co dien tich khac nhau: {HCNkhacnhau(listhcn)}");
            Console.ReadLine();
        }

        private static object HCNkhacnhau(List<HCN> listhcn)
        {
            return listhcn.Select(hcn => hcn.dientich(hcn.Chieudai, hcn.Chieurong)).Distinct().ToList().Count();
        }

        private static List<HCN> sortHCN(List<HCN> listhcn)
        {
            return (List<HCN>)listhcn.OrderBy(x => x.dientich(x.Chieudai, x.Chieurong)).ToList();
        }

        private static List<HCN> NhapNHCN()
        {
            var listhcn = new List<HCN>();
            Console.WriteLine("======Nhap vao so luong hinh chu nhat=======");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                listhcn.Add(NhapMotHCN());
            }
            return listhcn;
        }

        private static void xuat(List<HCN> listhcn)
        {
            listhcn.ForEach(hcn => Console.WriteLine($"Ma So: {hcn.Maso}, Chieu dai: {hcn.Chieudai}, Chieu rong: {hcn.Chieurong}"));
        }
        
        private static HCN NhapMotHCN()
        {
            var hcn = new HCN();
            Console.WriteLine("============================");
            Console.WriteLine("Nhap vao ma so HCN: ");
            hcn.Maso = Console.ReadLine();

            Console.WriteLine("Nhap vao Chieu dai: ");
            hcn.Chieudai = double.Parse(Console.ReadLine());

            Console.WriteLine("Nhap vao chieu rong: ");
            hcn.Chieurong = double.Parse(Console.ReadLine());

            return hcn;
        }
    }
}
