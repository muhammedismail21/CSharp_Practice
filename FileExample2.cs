using System;
using System.IO;
namespace ConsoleApplication1
{
    class FileExample2
    {
        static void Main()
        {
            FileStream fs = new FileStream(@"E:\Training\MS .NET\Week - 9\data.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(fs);

            Console.WriteLine(reader.ReadToEnd());

            reader.Close();
            fs.Close();

            Console.ReadLine();
        }
    }
}
