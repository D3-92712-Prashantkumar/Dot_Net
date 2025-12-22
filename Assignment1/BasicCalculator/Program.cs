using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculator
{
    internal class Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Calculator Console App!");
            string toContinue = "y";
            while (toContinue=="y")
            {
                int num1, num2;
                Console.Write("Enter first num  : ");
                string n1 = Console.ReadLine();
                num1 = int.Parse(n1);
                Console.Write("Enter second num : ");
                string n2 = Console.ReadLine();
                num2 = int.Parse(n2);
                Console.Write("Select Operation to perform\n1) +\t2) - \t3) *\t4) /\nEnter Choice: ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Result: "+(num1+num2));
                        break;
                    case 2:
                        Console.WriteLine("Result: "+(num1-num2));
                        break;
                    case 3:
                        Console.WriteLine("Result: "+(num1*num2));
                        break;
                    case 4:
                        Console.WriteLine("Result: "+(num1/num2));
                        break;
                    default:
                        Console.WriteLine("Invalid Choice!");
                        break;
                }
                Console.WriteLine("Do you want to continue (y/n) : ");
                toContinue = Console.ReadLine();
            }
           /* Environment.Exit(0);*/
        }
    }
}
