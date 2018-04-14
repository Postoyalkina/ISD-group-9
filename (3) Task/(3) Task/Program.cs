using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3__Task
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            while (!int.TryParse(Console.ReadLine(), out a)){ Console.WriteLine("Повторите попытку"); }
            Print(a);
            
            Console.ReadKey();
            
        }
        static void Print(int a)
        {
            if (a > 12 || a < 1)
            {
                Console.WriteLine("На этой планете такого месяца нет");
            }
            else
            {
                if (a == 12)
                    a = 1;
                else
                    a++;
                if (a > 9)
                    Console.WriteLine("Осень");
                else if (a > 6)
                    Console.WriteLine("Лето");
                else if (a > 3)
                    Console.WriteLine("Весна");
                else
                    Console.WriteLine("Зима");
            }
        }
    }
}
