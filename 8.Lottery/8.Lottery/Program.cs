using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Lottery
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int rate, cubeValue, minCubeValue = 1, maxCubeValue = 12;
            
            Console.WriteLine("Введите вашу ставку");
            rate = int.Parse(Console.ReadLine());
            cubeValue = random.Next(minCubeValue, maxCubeValue + 1);

            if(cubeValue <= 5)
            {
                rate = 0;
            }
            else if(cubeValue >=9 && cubeValue <= 11)
            {
                rate *= 2;
            }
            else if (cubeValue == 12)
            {
                rate *= 10;
            }

            Console.WriteLine("Вы выиграли: " + rate);
            Console.ReadKey();
        }
    }
}
