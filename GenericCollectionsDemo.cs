using System;
using System.Collections.Generic;

namespace CollectionsProject
{
    class GenericCollectionsDemo
    {
        public static void Main()
        {
            Stack<int> numbers = new Stack<int>();
            numbers.Push(1);
            numbers.Push(2);
            numbers.Push(3);
            // numbers.Push("four");

            Stack<string> names = new Stack<string>();
            names.Push("Ibrahim");
            names.Push("atheek");
            names.Push("vamsi");
            //names.Push(12);

            Console.WriteLine("Numbers: ");
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nNames");
            foreach (string item in names)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
