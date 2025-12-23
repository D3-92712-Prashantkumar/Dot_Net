using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1_SalProcessingSystem
{
    internal class Clerk:Emp
    {
        public Clerk():this("labourDefault",0,0,0.0)
        { }
        public Clerk(string name, int age, int id, double sal) : base(name, age, id, sal)
        {  }
        public void Accept()
        {
            base.Accept();
        }
        public void Display()
        {
            base.Display();
            Console.WriteLine();
        }
    }
}
