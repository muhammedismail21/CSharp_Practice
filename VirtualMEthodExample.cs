using System;

namespace OOPs
{
    class VirtualMethodExample
    {
        public static void Main()
        {
            Shape shape = new Shape();
            shape.Draw(ConsoleColor.Green);
            shape = new Square();
            shape.Draw(ConsoleColor.Blue);
            shape = new Circle();
            shape.Draw(ConsoleColor.Red);


            Console.ReadLine();
        }
    }
    //Shape is the parent or base class
    class Shape
    {
        public virtual void Draw(ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine("Drawing shape...");
            Console.ResetColor();
        }
    }
    //Square is the child or derived class
    class Square : Shape
    {
        //override means, the child class wants to modify the parent class implementation
        public override void Draw(ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("Drawing square...");
            Console.WriteLine("Area of circle is side * side");
            Console.ResetColor();
        }
    }
    class Circle : Shape
    {
        //override means, the child class wants to modify the parent class implementation
        public override void Draw(ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine("Drawing Circle...");            
            Console.ResetColor();
        }
    }
}
