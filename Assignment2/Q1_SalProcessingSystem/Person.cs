using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1_SalProcessingSystem
{
    internal class Person
    {
        private string _name;
        private int _age;
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int age
        {
            get { return _age;}
            set { _age = value; }
        }

        public Person() : this("defaultName",0)
        {        }

        public Person(string name, int age)
        {
            _name = name;
            _age = age;
        }
        public void Accept()
        {
            Console.Write("Enter Name: ");
            _name = Console.ReadLine();
            Console.Write("Enter Age: ");
            _age = Convert.ToInt32(Console.ReadLine());
        }
        public void Display()
        {
            Console.WriteLine($"Person : [Name:{_name}, Age:{_age}]");
        }
    }
}
