using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Q1_SalProcessingSystem
{
    internal class Labour :Emp
    {
        public int hours { get; set; }
        public int rate { get; set; }

        public Labour():this("labourDefault",0,0,0.0,0,0)
        {  }

        public Labour(string name, int age, int id, double sal, int hours, int rate) : base(name, age, id, sal)
        {
            this.hours = hours;
            this.rate = rate;
        }
        public void Accept()
        {
            base.Accept();
            Console.Write("Enter Hours: ");
            hours = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Rate: ");
            rate = Convert.ToInt32(Console.ReadLine());
        }
        public void Display()
        {
            base.Display();
            Console.WriteLine($"Labour : [Hours:{hours}, Rate:{rate}]");
            Console.WriteLine();
        }
        public override void CalcSal()
        {
            sal += hours* rate;
            Console.WriteLine("Salary of Labour: "+sal);
        }
    }
}
