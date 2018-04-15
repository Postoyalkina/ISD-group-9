using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Условные_7
{
    class Program
    {
        static void Main(string[] args)
        {
            bool temp = false;
            Console.Write("Введите число:");
            int N = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= N - 1; i++)
            {
                if (N % i == 0) { temp = true; break; }
            }
            if (temp) Console.WriteLine("Число {0} не является простым", N);
            if (!temp) Console.WriteLine("Число {0} - простое!", N);
            Console.ReadLine();
        }
    }
}
