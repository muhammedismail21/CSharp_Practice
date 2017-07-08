using System;
using System.Collections.Generic;

namespace CollectionsProject
{
    class ListExample
    {
        public static void Main()
        {
            List<Employee> empList = new List<Employee>();

            Employee emp1 = new Employee { EmpId = 102, EmpName = "scott", Salary = 10000 };
            Employee emp2 = new Employee { EmpId = 101, EmpName = "allen", Salary = 12000 };
            Employee emp3 = new Employee { EmpId = 103, EmpName = "john", Salary = 9000 };
            Employee emp4 = new Employee { EmpId = 105, EmpName = "ben", Salary = 7500 };
            Employee emp5 = new Employee { EmpId = 104, EmpName = "lauren", Salary = 8200 };
            

            empList.Add(emp1);
            empList.Add(emp2);
            empList.Add(emp3);
            empList.Add(emp4);
            empList.Add(emp5);

            foreach (Employee emp in empList)
            {
                Console.WriteLine("{0, -4} {1, -8} {2,-10:C}", emp.EmpId, emp.EmpName, emp.Salary);
            }

            empList.Sort();

            Console.WriteLine("\n");
            foreach (Employee emp in empList)
            {
                Console.WriteLine("{0, -4} {1, -8} {2,-10:C}", emp.EmpId, emp.EmpName, emp.Salary);
            }
            Console.ReadLine();
        }
    }

    class Employee : IComparable<Employee>      
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public double Salary { get; set; }

        public int CompareTo(Employee other)
        {
            return this.EmpName.CompareTo(other.EmpName);
        }
    }
}
