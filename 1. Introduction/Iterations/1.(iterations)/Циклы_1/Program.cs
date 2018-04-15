using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Циклы_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число - ");
            int N = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 20; i++)
                Console.WriteLine("{0} * {1} = {2}", N, i, i * N);
            Console.ReadLine();
        }
    }
}
