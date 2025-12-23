using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Q1_SalProcessingSystem
{
    internal class Manager:Emp
    {
        public int bonus { get; set; }
        public Manager():this("labourDefault",0,0,0.0,0)
        {        }
        public Manager(string name, int age, int id, double sal, int bonus) : base(name, age, id, sal)
        {
            this.bonus = bonus;
        }

        
        public void Accept()
        {
            base.Accept();
            Console.Write("Enter Bonus: ");
            bonus = Convert.ToInt32(Console.ReadLine());
        }
        public void Display()
        {
            base.Display();
            Console.WriteLine($"Manager : [ Bonus:{bonus} ]");
            Console.WriteLine();
        }
        public override void CalcSal()
        {
            sal += bonus;
            Console.WriteLine("Salary of Manager: " + sal);
        }
    }
}
