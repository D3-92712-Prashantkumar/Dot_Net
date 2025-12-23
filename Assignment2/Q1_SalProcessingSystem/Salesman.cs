using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1_SalProcessingSystem
{
    internal class Salesman:Emp
    {
        public int comm { get; set; }
        public Salesman(): this("labourDefault", 0, 0, 0.0, 0)
        { }
        public Salesman(string name, int age, int id, double sal, int comm) : base(name, age, id, sal)
        {
            this.comm = comm;
        }


        public void Accept()
        {
            base.Accept();
            Console.Write("Enter Comm: ");
            comm = Convert.ToInt32(Console.ReadLine());
        }
        public void Display()
        {
            base.Display();
            Console.WriteLine($"SalesMan : [ Comm:{comm} ]");
            Console.WriteLine();
        }
        public override void CalcSal()
        {
            sal += comm;
            Console.WriteLine("Salary of SalesMan: " + sal);
        }
    }
}
