using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_conditions_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во километров:");
            if (!double.TryParse(Console.ReadLine(), out double kilom) || kilom < 0)
            {
                Console.WriteLine("Incorrect data!");
                Console.ReadKey();
            }   
            else
            {
                Console.WriteLine("Введите кол-во минут простоя:");
                if (!double.TryParse(Console.ReadLine(), out double minutes)||minutes < 0)
                {
                    Console.WriteLine("Incorrect data!");
                    Console.ReadKey();
                }   
                else
                {
                    double payment;
                    payment = 20;
                    payment += minutes * 1;
                    if (kilom > 5)
                    {
                        payment += (kilom - 5) * 3;
                    }
                    Console.WriteLine(payment);
                    Console.ReadKey();
                }
            }      
        }
    }
}
