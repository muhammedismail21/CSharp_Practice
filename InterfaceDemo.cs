using System;

namespace OOPs
{
    class InterfaceDemo
    {
        public static void Main()
        {
            ICalc calc = new Calculator();
            IMath math = new Calculator();

            Console.WriteLine("Squareroot: " + calc.Squareroot(5));
            Console.WriteLine("5 power 3: " + calc.XpowerY(5,3));
            Console.WriteLine("Sum: " + math.Add(1,2));
            Console.WriteLine("Product: " + math.Mul(3,3));
            Console.ReadLine();

        }
    }

    interface ICalc
    {
        //by default the methods in interface are public and abstract
        double Squareroot(int number);
        double XpowerY(int x, int y);
    }
    interface IMath
    {
        int Add(int x, int y);
        int Mul(int x, int y);
    }
    class Calculator : ICalc, IMath
    {
        public int Add(int x, int y)
        {
            return (x + y);
        }

        public int Mul(int x, int y)
        {
            return (x * y);
        }

        public double Squareroot(int number)
        {
            return Math.Sqrt(number);
        }

        public double XpowerY(int x, int y)
        {
            return Math.Pow(x, y);
        }
    }

}
