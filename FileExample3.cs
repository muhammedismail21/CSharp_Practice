using System;
using System.IO;

namespace ConsoleApplication1
{
    class FileExample3
    {
        static void Main()
        {
            DirectoryInfo dir = new DirectoryInfo(@"c:\windows");
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                if (file.Extension == ".exe" || file.Extension == ".dll")
                {
                    Console.WriteLine("{0,-25}   {1,-6} kb   {2,-15}", file.Name, (file.Length / (1024)), file.CreationTime);
                }
            }

            Console.ReadLine();
        }
    }
}
