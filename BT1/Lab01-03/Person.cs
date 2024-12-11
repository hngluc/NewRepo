using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_03
{
    internal class Person
    {
        string ID;
        string Name;

        public string ID1 { get => ID; set => ID = value; }
        public string Name1 { get => Name; set => Name = value; }

        public Person(string id, string name, string iD1, string name1)
        {
            ID = id;
            Name = name;
        }
        public Person()
        {
        }

        public virtual void Input()
        {
            Console.WriteLine("Nhap vao ma so: ");
            ID = Console.ReadLine();
            Console.WriteLine("Nhap vao ho ten: ");
            Name = Console.ReadLine();
        }
        public virtual void Output()
        {
            Console.WriteLine($"Ma so: {ID}");
            Console.WriteLine($"Ho ten: {Name}");
        }

    }
}
