using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Условные_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 2 числа а и в:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            if (a > b) Console.WriteLine("{0}>{1}", a, b);
            else if (a == b) Console.WriteLine("{0}={1}", a, b);
            else Console.WriteLine("{0}<{1}", a, b);
            Console.ReadLine();
        }
    }
}
