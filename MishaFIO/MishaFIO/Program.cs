using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MishaFIO
{
    class Program
    {
        static void Main(string[] args)
        {
            string fio = "Крыгин Михаил Олегович";
            int l = fio.Length;
            Console.Write("+");
            for (int i = 0; i < l; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("+");
            Console.Write("|");
            Console.Write(fio);
            Console.WriteLine("|");
            Console.Write("+");
            for (int i = 0; i < l; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("+");
            Console.ReadKey();
        }
    }
}
