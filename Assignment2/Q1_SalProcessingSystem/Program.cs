namespace Q1_SalProcessingSystem
{
    internal class Program
    {
        enum Menu
        {
            exit,labour, manager, salesman, cleark, getTotalSalExpense
        }
        static int Choose()
        {
            Array arr = Enum.GetValues(typeof(Menu));
            Console.WriteLine("================================================================================================");
            foreach (Menu m in arr)
            {
                Console.Write($"{(int)m}) {m}    ");
            }
            Console.WriteLine("\nEnter Choice:");
            return Convert.ToInt32(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To XYZ!!, Salary Management System!");
            Console.WriteLine("===========================================");

            List<Emp> ls = new List<Emp>();

            int choice;
            while ((choice = Choose()) != 0)
            {
                Menu op = (Menu)choice;
                switch (op)
                {
                    case Menu.labour:
                        Labour l = new Labour();
                        l.Accept();
                        l.CalcSal();
                        l.Display();
                        ls.Add((Emp)l);
                        break;
                    case Menu.manager:
                        Manager m = new Manager();
                        m.Accept();
                        m.CalcSal();
                        m.Display();
                        ls.Add((Emp)m);
                        break;
                    case Menu.salesman:
                        Salesman s = new Salesman();
                        s.Accept();
                        s.CalcSal();
                        s.Display();
                        ls.Add((Emp)s);
                        break;
                    case Menu.cleark:
                        Clerk c = new Clerk();
                        c.Accept();
                        c.CalcSal();
                        c.Display();
                        ls.Add((Emp)c);
                        break;
                    case Menu.getTotalSalExpense:
                        double totalSalary = 0.0;
                        foreach (Emp e in ls)
                            totalSalary += e.sal;
                        Console.WriteLine("Total Salary of All Employees = " + totalSalary);
                        break;
                    default:
                        Console.WriteLine("Invalid Choice !!\n ADIOS!!");
                        break;
                }
            }
        }
    }
}
