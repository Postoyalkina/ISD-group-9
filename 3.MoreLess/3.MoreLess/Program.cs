using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.MoreLess
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int number, userValue, min = 1, max = 146;

            number = random.Next(min, max + 1);

            do
            {
                Console.WriteLine("Введите число");
                userValue = int.Parse(Console.ReadLine());

                if (userValue < number)
                {
                    Console.WriteLine("Больше");
                }
                if (userValue > number)
                {
                    Console.WriteLine("Меньше");
                }
            } while (userValue != number);

            Console.WriteLine("Вы угадали!");
            Console.ReadKey();
        }
    }
}
