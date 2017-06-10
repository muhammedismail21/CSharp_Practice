using System;

namespace ConsoleApplication1
{
    class InheritanceExample
    {
        static void Main()
        {
            Employee emp = new Employee(101, "scott", 10000.00);
            emp.DisplayEmployeeDetails();

            Manager manager = new Manager(102, "allen", 8000.00, 1);
            manager.DisplayManagerDetails();

            Console.ReadLine();
        }
    }

    class Employee
    {
        // Employee class fields or class members
        protected int EmpId;
        protected string EmpName;
        protected double Salary;

        public Employee(int EmpId, string EmpName, double Salary)
        {
            this.EmpId = EmpId;
            this.EmpName = EmpName;
            this.Salary = Salary;
        }
        public void DisplayEmployeeDetails()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nEmp Id: " + this.EmpId);
            Console.WriteLine("Name: " + this.EmpName);
            Console.WriteLine("Salary: " + this.Salary);
            Console.ResetColor();
        }
    }

    class Manager : Employee
    {
        int ManagerId;
        public Manager(int EmpId, string EmpName, double Salary,int ManagerId):base(EmpId, EmpName, Salary)
        {
            this.ManagerId = ManagerId;
            //this.EmpId = EmpId;
            //this.EmpName = EmpName;
            //this.Salary = Salary;
        }
        public void DisplayManagerDetails()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nManager Id: " + this.ManagerId);
            Console.WriteLine("Emp Id: " + this.EmpId);
            Console.WriteLine("Name: " + this.EmpName);
            Console.WriteLine("Salary: " + this.Salary);
            Console.ResetColor();
        }
    }
}
