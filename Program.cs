using System;

namespace ConsoleApplication1
{
    class Sample
    {
        public Sample()
        {
            Console.WriteLine("Sample() ...");
        }
        public Sample(string name)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hi, " + name + "!");
            Console.ResetColor();
        }

    }
    class Program
    {
        public Program()
        {

        }

        static void Main(string[] args)
        {
            Sample obj = new Sample();
            Sample obj2 = new Sample("Mohammed");

            Console.ReadLine();
        }
    }
}
