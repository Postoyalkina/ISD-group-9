using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _10_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory(@"C:\test");
            string path = @"C:\test\Folder_";
            for (int i = 0; i < 100; i++)
            {
                Directory.CreateDirectory(path + i);
            }
            Console.WriteLine("Check C:");
            Console.ReadKey();
            for (int i = 0; i < 100; i++)
            {
                Directory.Delete(path + i);
            }
            Directory.Delete(@"C:\test");
            Console.WriteLine("And now)");
            Console.ReadKey();
        }
    }
}
