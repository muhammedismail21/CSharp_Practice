using System;
using System.Collections;

namespace ConsoleApplication1
{
    class Program
    {        
        static void Main(string[] args)
        {
            Child c = new Child();
            c.Method1(); // calling inherited method
            c.Method2();
           // c.Method5(); // error: private members are not accessible to child class

            Console.ReadLine();
        }
    }
    class Parent
    {
        public void Method1()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Parent.Method1()");
            Console.ResetColor();
            Method5();
        }
        protected void Method3()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Protected.Method3()");
            Console.ResetColor();
        }
        internal void Method4()
        {
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Internal.Method4()");
                Console.ResetColor();
            }
        }
        private void Method5()
        {
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Private.Method5()");
                Console.ResetColor();
            }
        }
    }

    class Child : Parent // Child class inherits the Parent class
    {
        public void Method2()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Child.Method2()");
            Console.ResetColor();

            Method3(); //protected method
            Method4(); // internal method
           // Method5(); // error: private method
        }
    }


namespace CollectionsProject
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList alist = new ArrayList();

            Console.WriteLine("No of elements: " + alist.Count);
            Console.WriteLine("Capacity: " + alist.Capacity);

            alist.Add("one");
            alist.Add("two");

            Console.WriteLine("\nElements: ");
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < alist.Count; i++)
            {
                Console.WriteLine(alist[i]);
            }
            Console.ResetColor();
            Console.WriteLine("No of elements: " + alist.Count);
            Console.WriteLine("Capacity: " + alist.Capacity);


            alist.Add("three");
            alist.Add("four");

            Console.WriteLine("\nElements: ");
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < alist.Count; i++)
            {
                Console.WriteLine(alist[i]);
            }
            Console.ResetColor();
            Console.WriteLine("No of elements: " + alist.Count);
            Console.WriteLine("Capacity: " + alist.Capacity);

            alist.Add("five");

            Console.WriteLine("\nElements: ");
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < alist.Count; i++)
            {
                Console.WriteLine(alist[i]);
            }
            Console.ResetColor();
            Console.WriteLine("No of elements: " + alist.Count);
            Console.WriteLine("Capacity: " + alist.Capacity);

            Console.ReadLine();
        }
    }
}
