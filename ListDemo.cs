using System;
using System.Collections.Generic;

namespace CollectionsProject
{
    class ListDemo
    {
        public static void Main()
        {
            List<int> rankList = new List<int>();
            rankList.Add(21);
            rankList.Add(35);
            rankList.Add(43);
            rankList.Add(79);
            rankList.Add(15);

            Console.Write("List elements: ");
            foreach (int item in rankList)
            {
                Console.Write(item + " ");
            }

            rankList.Sort();

            Console.Write("\nList elements: ");
            foreach (int item in rankList)
            {
                Console.Write(item + " ");
            }

            Console.ReadLine();
        }
    }
}
