using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Циклы_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число N:");
            int N = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; Math.Pow(i, 2) < N; i++)
                Console.WriteLine(Math.Pow(i, 2));
            Console.ReadLine();
        }
    }
}
