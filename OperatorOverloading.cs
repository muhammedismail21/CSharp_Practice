using System;
namespace OOPs
{
    class OperatorOverloading
    {


        public static void Main()
        {
            /*
            int num1 = 10;
            int num2 = 20;
            int res = num1 + num2;            
            Console.WriteLine("Sum: " + res);
            */
            Number num1 = new Number();
            num1.x = 1;
            num1.y = 2;
            Number num2 = new Number();
            num2.x = 2;
            num2.y = 1;
            Number res = new Number();

            res = num1 + num2;
            Console.WriteLine("res.x= " + res.x + " " + "res.y= " + res.y);
            Console.ReadLine();
        }
    }

    class Number
    {
        public int x;
        public int y;
        public static Number operator +(Number num1, Number num2)
        {
            Number res = new Number();
            res.x = num1.x + num2.x;
            res.y = num1.y + num2.y;

            return res;
        }
    }
}
