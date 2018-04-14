using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EugeneFIO
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Жорняк Евгений Дмитриевич";
            int length = name.Length;
            Console.Write("+");
            for (int i = 0; i < length; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("+");
            Console.WriteLine("|" + name + "|");
            Console.Write("+");
            for (int i = 0; i < length; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("+");
            Console.ReadKey();
        }
    }
}
