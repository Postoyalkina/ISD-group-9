using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4__Task
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            while (!int.TryParse(Console.ReadLine(), out a)) { Console.WriteLine("Повторите попытку"); }
            if (a == 0)
                Console.WriteLine("Плохо");
            else if (a == 1)
                Console.WriteLine("Хорошо");
            Console.ReadKey();
            
        }
    }
}
