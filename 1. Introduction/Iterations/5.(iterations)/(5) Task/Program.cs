using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5__Task
{
    class Program
    {
        const int count = 5;
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 0; i < count; i++)
            {
                if (int.TryParse(Console.ReadLine(), out int yt))
                {
                    sum += yt;
                    Console.WriteLine("Отлично");
                }
                else
                {
                    i--;
                    Console.WriteLine("Ошибка, повторите попытку");
                }

            }

            Console.WriteLine("Среднее: " +  sum / count);
            Console.ReadKey();
        }
    }
}
