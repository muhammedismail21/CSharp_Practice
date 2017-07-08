using System;
using System.Collections;

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
