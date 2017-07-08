using System;
using System.Collections.Generic;

namespace CollectionsProject
{
    class IterationDemo
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

            IEnumerator<Employee> enu = empList.GetEnumerator();

            while (enu.MoveNext())
            {
                Console.WriteLine("{0, -4} {1, -8} {2,-10:C}", enu.Current.EmpId, enu.Current.EmpName, enu.Current.Salary);
            }
            Console.ReadLine();
        }
    }
}
