using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_03
{
    internal class Teacher: Person
    {
        string DiaChi;

        public Teacher()
        {
        }

        public string DiaChi1 { get => DiaChi; set => DiaChi = value; }

        public Teacher(string diachi, string diaChi1)
        {
            DiaChi = diachi;
        }

        public override void Input()
        {
            base.Input();
            Console.WriteLine("Nhap Dia chi: ");
            DiaChi = Console.ReadLine();
        }

        public override void Output()
        {
            base.Output();
            Console.WriteLine($"Dia chi: {DiaChi}");
        }
    }
}
