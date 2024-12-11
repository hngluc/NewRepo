using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab01_03
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            //var studentList = new List<Student>();
            var studentList = new List<Student>
                {
                    new Student { ID1 = "S12345", Name1 = "Nguyen A", AvgScore1 = 7.5f, Faculty1 = "CNTT" },
                    new Student { ID1 = "S23456", Name1 = "Tran B", AvgScore1 = 8.9f, Faculty1 = "CNTT" },
                    new Student { ID1 = "S34567", Name1 = "Le C", AvgScore1 = 6.0f, Faculty1 = "KT" },
                    new Student { ID1 = "S45678", Name1 = "Ho D", AvgScore1 = 9.0f, Faculty1 = "CNTT" },
                    new Student { ID1 = "S56789", Name1 = "Pham E", AvgScore1 = 4.5f, Faculty1 = "CNTT" }
                };
            //var teacherList = new List<Teacher>();
            List<Teacher> teacherList = new List<Teacher>
            {
                new Teacher { ID1 = "S657899", Name1 = "Tran Van E", DiaChi1 = "Quan Thu Duc"},
                new Teacher { ID1 = "S657239", Name1 = "Nguyen Thi F", DiaChi1 = "Quan 9" },
                new Teacher { ID1 = "S456234", Name1 = "Le Van G", DiaChi1 = "Quan 2" },
                new Teacher { ID1 = "S126547", Name1 = "Pham Thi H", DiaChi1 = "Quan 9" }
            };
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("============================");
                Console.WriteLine("Cac chuc nang menu: ");
                Console.WriteLine("1. Them sinh vien");
                Console.WriteLine("2. Them giao vien");
                Console.WriteLine("3. Xuat sinh vien");
                Console.WriteLine("4. Xuat giao vien");
                Console.WriteLine("5. So luong sinh vien va giao vien");
                Console.WriteLine("6. Xuat sinh vien thuoc khoa CNTT");
                Console.WriteLine("7. Xuat giao vien co dia chi Quan 9");
                Console.WriteLine("8. Xuat sinh vien DTB cao nhat va thuoc khoa CNTT");
                Console.WriteLine("9. Xuat so luong xep loai cua tung loai");
                Console.WriteLine("0. Thoat");

                Console.Write("Nhap lua chon cua ban: ");

                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddStudent(studentList);
                        break;
                    case "2":
                        AddTeacher(teacherList);
                        break;
                    case"3":
                        DisplayStudent(studentList);
                        break;
                    case"4":
                        DisplayTeacher(teacherList);
                        break;
                    case "5":
                        DisplaySoLuong(studentList, teacherList);
                        break;
                    case "6":
                        DisplayByFaculty(studentList);
                        break;
                    case "7":
                        DisplayByAdress(teacherList);
                        break;
                    case "8":
                        DisplayMaxAVGvakhoa(studentList);
                        break;
                    case "9":
                        DisplaySoLuongRank(studentList);
                        break;
                    case "0":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Thoat chuong trinh!!");
                        break;
                }
                Console.WriteLine();
            }
        }

        private static void DisplaySoLuongRank(List<Student> studentList)
        {
            int excellent = studentList.Count(s => s.AvgScore1 >= 9);
            int good = studentList.Count(s => s.AvgScore1 >= 7 && s.AvgScore1 < 9);
            int average = studentList.Count(s => s.AvgScore1 >= 5 && s.AvgScore1 < 7);
            int weak = studentList.Count(s => s.AvgScore1 < 5);

            
            Console.WriteLine($"Xep loai xuat sac: {excellent}");
            Console.WriteLine($"Xep loai gioi: {good}");
            Console.WriteLine($"Xep loai trung binh: {average}");
            Console.WriteLine($"Xep loai yeu: {weak}");
        }

        private static void DisplayMaxAVGvakhoa(List<Student> studentList)
        {
            var filteredStudent = studentList.Where(student => student.Faculty1.Equals("CNTT", StringComparison.OrdinalIgnoreCase)).ToList();

            var studentMaxavg = filteredStudent.OrderByDescending(student => student.AvgScore1).First();
            Console.WriteLine("==== Danh sach sinh vien co diem tb max va thuoc khoa cntt ====");
            studentMaxavg.Output();
        }
        private static void DisplayByAdress(List<Teacher> teacherList)
        {
            var filteredTeacher = teacherList.Where(teacher => teacher.DiaChi1.Equals("Quan 9", StringComparison.OrdinalIgnoreCase)).ToList();

            Console.WriteLine("==== Danh sach giao vien co dia chi ====");
            foreach(var teacher in filteredTeacher)
            {
                teacher.Output();
            }
        }

        private static void DisplayByFaculty(List<Student> studentList)
        {
            var filteredStudent = studentList.Where(student => student.Faculty1.Equals("CNTT", StringComparison.OrdinalIgnoreCase)).ToList();

            Console.WriteLine($"==== Danh sach sinh vien thuoc khoa {filteredStudent}");
            foreach (var student in filteredStudent)
            {
                student.Output();
            }
        }

        private static void DisplaySoLuong(List<Student> studentList, List<Teacher> teacherList)
        {
            var studentcountList = studentList.Count;

            var teachercountList = teacherList.Count;

            Console.WriteLine($"So luong sinh vien {studentcountList}");
            Console.WriteLine($"So luong giao vien {teachercountList}");
        }

        private static void DisplayTeacher(List<Teacher> teacherList)
        {
            Console.WriteLine("==== Danh sach giao vien ====");
            foreach (var teacher in teacherList)
            {
                teacher.Output();
            }
        }

        private static void DisplayStudent(List<Student> studentList)
        {
            Console.WriteLine("==== Danh sach sinh vien ====");
            foreach (var student in studentList)
            {
                student.Output();
            }
        }

        private static void AddTeacher(List<Teacher> teacherList)
        {
            Console.WriteLine("===== Nhap thong tin sinh vien =====");
            var teacher = new Teacher();
            teacher.Input();
            teacherList.Add(teacher);
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
