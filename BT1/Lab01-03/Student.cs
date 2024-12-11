using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_03
{
    internal class Student: Person
    {
        float AvgScore;
        string Faculty;

        public float AvgScore1 { get => AvgScore; set => AvgScore = value; }
        public string Faculty1 { get => Faculty; set => Faculty = value; }

        public Student(float avgScore, string faculty)
        {
            AvgScore1 = avgScore;
            Faculty1 = faculty;
        }
        public Student() { }

        public override void Input()
        {
            base.Input();
            Console.WriteLine("Nhap diem tb: ");
            AvgScore1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap khoa: ");
            Faculty1 = Console.ReadLine();
        }

        public override void Output()
        {
            base.Output();
            Console.WriteLine($"Diem tb: {AvgScore1}");
            Console.WriteLine($"Khoa: {Faculty1}");
        }
    }
}
