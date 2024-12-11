using System;

namespace Lab01_02
{
    internal class Student
    {
        string ID;
        string Name;
        float avgScore;
        string faculty;

        public Student()
        {
        }

        public string ID1 { get => ID; set => ID = value; }
        public string Name1 { get => Name; set => Name = value; }
        public float AvgScore { get => avgScore; set => avgScore = value; }
        public string Faculty { get => faculty; set => faculty = value; }

        public Student(string id, string name, float avgScore, string faculty)
        {
            ID = id;
            Name = name;
            this.avgScore = avgScore;
            this.faculty = faculty;
        }

        public void Input()
        {
            Console.Write("Nhap MSSV: ");
            ID = Console.ReadLine();
            Console.Write("Nhap ho ten: ");
            Name = Console.ReadLine();
            Console.Write("Nhap diem tb: ");
            avgScore = float.Parse(Console.ReadLine());
            Console.Write("Nhap ten khoa: ");
            faculty = Console.ReadLine();
        }

        public void Output(string rank)
        {
            Console.WriteLine($"MSSV: {ID}");
            Console.WriteLine($"Ho ten: {Name}");
            Console.WriteLine($"Diem trung binh: {avgScore}");
            Console.WriteLine($"Khoa: {faculty}");
            Console.WriteLine($"Xep loai: {rank}");
        }

    }
}
