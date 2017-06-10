using System;

namespace OOPs
{
    class VirtualMethodDemo
    {
        static void Main()
        {
            //Employee emp = new Employee(101, "scott allen", 5000);
            //emp.Display(ConsoleColor.Magenta);
            //Manager manager = new Manager(102, "ruth peter", 4000, 1);
            //manager.Display(ConsoleColor.Green);

            Employee emp = new Manager(102, "scott", 4000, 1);
            emp.Display(ConsoleColor.Cyan);

            emp = new Employee(101, "allen", 5000);
            emp.Display(ConsoleColor.DarkGreen);


            Console.ReadLine();
        }
    }

    class Employee
    {
       protected int empID;
       protected string empName;
       protected double salary;
        public Employee(int empID, string empName, double salary)
        {
            this.empID = empID;
            this.empName = empName;
            this.salary = salary;
        }
        public virtual void Display(ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine("Emp ID: " + empID);
            Console.WriteLine("Emp Name: " + empName);
            Console.WriteLine("Salary: " + salary);
            Console.ResetColor();
        }
    }
    class Manager : Employee
    {
        int managerID;
        public Manager(int empID, string empName, double salary, int managerID)
            :base(empID, empName, salary)
        {
            this.managerID = managerID;
        }
        public override void Display(ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine("Manager ID: " + managerID);
            Console.WriteLine("Emp ID: " + empID);
            Console.WriteLine("Emp Name: " + empName);
            Console.WriteLine("Salary: " + salary);
            Console.ResetColor();
        }
    }
}
