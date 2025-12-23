using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
     public class MyClass
    {
        private string _name;
        private bool _gender;
        private int _age;
        private int _std;
        private char _div;
        private double _marks;

        public string name { get { return _name; } set { _name = value; } }
        public bool gender { get { return _gender; } set { _gender = value; } }
        public int age { get { return _age; } set { _age = value; } }
        public int std { get { return _std; } set { _std = value; } }
        public char div { get { return _div; } set { _div = value; } }
        public double marks { get { return _marks; } set { _marks = value; } }


        public MyClass() : this("",false,0,0,'a',0.0)
        {}
       public MyClass(string name,bool gender,int age,int std,char div,double marks) {
            this.name = name;
            this.gender = gender;
            this.age = age;
            this.std = std;
            this.div = div;
            this.marks = marks;
        }

        public void AcceptDetails()
        {
            Console.Write("Enter Name: ");
            _name = Console.ReadLine();
            Console.Write("Choose Gender 1)Male 2)Female");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1) _gender = true;
            else _gender = false;

            Console.Write("Enter Age: ");
            _age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Std: ");
            _std = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Div: ");
            _div = Convert.ToChar(Console.ReadLine());
            Console.Write("Enter Marks: ");
            _marks = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Accepting Details Method DONE!");
        }
        public void Display()
        {
            Console.WriteLine("MyClass: [Name:{0},Gender:{1},Age:{2},std:{3},div:{4},marks:{5}]",this.name,this.gender?"Male":"Female",this.age,this.std,this.div,this.marks);
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass m1 = new MyClass();
            m1.AcceptDetails();
            m1.Display();

        }
    }
}
