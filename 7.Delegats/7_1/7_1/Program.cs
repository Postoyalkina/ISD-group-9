using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            Average average = delegate(int dx ,int dy,int dz)
            {
                return Convert.ToDouble(dx + dy + dz) / 3;
            };
            Console.WriteLine("Введите первое число:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите третье число:");
            z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Math.Round(average(x,y,z),2));
            Console.ReadKey();
        }
        delegate double Average(int x, int y, int z);
    }
}
