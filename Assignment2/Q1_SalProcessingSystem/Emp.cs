using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Q1_SalProcessingSystem
{
    internal class Emp : Person
    {
        private int _Id;
        private double _sal;
        public int Id { get { return _Id; } set { _Id = value; } }
        public double sal { get { return _sal; } set { _sal = value; } }

        public Emp():this("default",0,0,0.0)
        {
        }
        public Emp(string name, int age,int id,double sal) : base(name, age)
        {
            this._Id = id;
            this._sal = sal;
        }
        public void Accept()
        {
            base.Accept();
            Console.Write("Enter Id: ");
            _Id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Sal: ");
            _sal = Convert.ToDouble(Console.ReadLine());
        }
        public void Display()
        {
            base.Display();
            Console.WriteLine($"Emp : [Id:{_Id}, Sal:{_sal}]");
        }

        virtual public void CalcSal() { }

    }
}
