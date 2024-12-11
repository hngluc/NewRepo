using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab01_02
{
    internal class Program
    {
        public static string rank { get; private set; }

        static void Main(string[] args)
        {
            //var studentList = new List<Student>();
            var studentList = new List<Student>
                {
                    new Student { ID1 = "S12345", Name1 = "Nguyen A", AvgScore = 7.5f, Faculty = "CNTT" },
                    new Student { ID1 = "S23456", Name1 = "Tran B", AvgScore = 8.9f, Faculty = "CNTT" },
                    new Student { ID1 = "S34567", Name1 = "Le C", AvgScore = 6.0f, Faculty = "KT" },
                    new Student { ID1 = "S45678", Name1 = "Ho D", AvgScore = 9.0f, Faculty = "CNTT" },
                    new Student { ID1 = "S56789", Name1 = "Pham E", AvgScore = 4.5f, Faculty = "CNTT" }
                };
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("============================");
                Console.WriteLine("Cac chuc nang menu: ");
                Console.WriteLine("1. Them sinh vien");
                Console.WriteLine("2. Xuat danh sach sinh vien");
                Console.WriteLine("3. Xuat sinh vien thuoc khoa CNTT");
                Console.WriteLine("4. Xuat sinh vien co diem tb >= 5");
                Console.WriteLine("5. Xuat sinh vien co diem tb tang dan");
                Console.WriteLine("6. Xuat sinh vien co diem tb >= 5 va thuoc khoa CNTT");
                Console.WriteLine("7. Xuat sinh vien co diem cao nhat va thuoc khoa CNTT");
                Console.WriteLine("8. Xep loai sinh vien");
                Console.WriteLine("0. Thoat");

                Console.Write("Nhap lua chon cua ban: ");

                var choice = Console.ReadLine();


                switch (choice)
                {
                    case "1":
                        AddStudent(studentList);
                        break;
                    case "2":
                        DisplayStudentList(studentList);
                        break;
                    case "3":
                        DisplayFaculty(studentList, "CNTT");
                        break;
                    case "4":
                        DisplayAVG(studentList);
                        break;
                    case "5":
                        Displayorderby(studentList);
                        break;
                    case "6":
                        Displaydiemvakhoa(studentList);
                        break;
                    case "7":
                        DisplayMaxAVGvakhoa(studentList, "CNTT");
                        break;
                    case "8":
                        Xeploai(studentList);
                        break;
                    case "0":
                        exit = true;
                        Console.WriteLine("Chuong trinh ket thuc!");
                        break;
                    default:
                        Console.WriteLine("Tuy chon khong hop le!. CHon lai!");
                        break;
                }
                Console.WriteLine();
            }
        }

        private static void Xeploai(List<Student> studentList)
        {
            var danhgia = studentList.OrderByDescending(student => student.AvgScore).ToList();

            foreach (var student in danhgia)
            {
                string rank = getrank(student.AvgScore);
                student.Output(rank);
            }
        }

        private static string getrank(float avgScore)
        {
            if (avgScore >= 9)
                return "Xuat sac";
            else if (avgScore >= 8)
                return "Gioi";
            else if (avgScore >= 7)
                return "Kha";
            else if (avgScore >= 5)
                return "Trung binh";
            else if (avgScore >= 4)
                return "Yeu";
            else return "Kem";
        }

        private static void DisplayMaxAVGvakhoa(List<Student> studentList, string faculty)
        {
            var filteredStudent = studentList.Where(student => student.Faculty.Equals(faculty, StringComparison.OrdinalIgnoreCase)).ToList();

            var studentMaxavg = filteredStudent.OrderByDescending(student => student.AvgScore).First();
            Console.WriteLine("==== Danh sach sinh vien co diem tb max va thuoc khoa cntt ====");
            var rank = getrank(studentMaxavg.AvgScore);
            studentMaxavg.Output(rank);
        }

        private static void Displaydiemvakhoa(List<Student> studentList)
        {
            var filteredStudent = studentList.Where(student => student.AvgScore >= 5 && student.Faculty.Equals("CNTT", StringComparison.OrdinalIgnoreCase)).ToList();
            Console.WriteLine("==== Danh sach sinh vien co diem >= 5 va thuoc khoa CNTT ====");
            foreach (var student in filteredStudent)
            {
                var rank = getrank(student.AvgScore);
                student.Output(rank);
            }
        }

        private static void Displayorderby(List<Student> studentList)
        {
            var filteredStudent = studentList.OrderBy(student => student.AvgScore).ToList();
            Console.WriteLine("==== Danh sach tang dan theo diem ====");

            foreach (Student student in filteredStudent)
            {
                var rank = getrank(student.AvgScore);
                student.Output(rank);
            }
        }

        private static void DisplayAVG(List<Student> studentList)
        {
            var avg = studentList.Where(student => student.AvgScore >= 5).ToList();
            Console.WriteLine("==== Danh sach sinh vien co diem tb >= 5 ====");
            foreach (Student student in avg)
            {
                var rank = getrank(student.AvgScore);
                student.Output(rank);
            }

        }

        private static void DisplayFaculty(List<Student> studentList, string facultyName)
        {
            var byFaculty = studentList.Where(student => student.Faculty.Equals(facultyName, StringComparison.OrdinalIgnoreCase)).ToList();

            Console.WriteLine($"==== Danh sach sinh vien thuoc khoa {facultyName}");
            foreach (var student in byFaculty)
            {
                var rank = getrank(student.AvgScore);
                student.Output(rank);
            }
        }

        private static void DisplayStudentList(List<Student> studentList)
        {
            Console.WriteLine("==== Danh sach sinh vien ====");
            Console.WriteLine("+------------+----------------------+------------+-----------------+");
            Console.WriteLine("| {0,-10} | {1,-20} | {2,-10} | {3,-15} |", "ID", "Name", "AvgScore", "Faculty");
            Console.WriteLine("+------------+----------------------+------------+-----------------+");
            foreach (var student in studentList)
            {
                student.Output(rank);
            }
        }

        private static void AddStudent(List<Student> studentList)
        {
            Console.WriteLine("===== Nhap thong tin sinh vien =====");
            var student = new Student();
            student.Input();
            studentList.Add(student);
        }
    }
}
