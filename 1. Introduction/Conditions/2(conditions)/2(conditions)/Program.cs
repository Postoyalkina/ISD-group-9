using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_conditions_
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            Console.WriteLine("Введите 'мяу' или 'гав'!");
            s = Console.ReadLine();
            if (s == "мяу")
                Console.WriteLine("Покорми кота");
            else if (s == "гав")
                Console.WriteLine("Погуляй с собакой");
            else
                Console.WriteLine("Некорректно введены данные");
            Console.ReadKey();
        }
    }
}
