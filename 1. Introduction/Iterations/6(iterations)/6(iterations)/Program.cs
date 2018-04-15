using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_iterations_
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            double average;
            int intermediate, sum = 0;
            for (int i = 0; i < 5; i++)
            {
                intermediate = r.Next(-100,100);
                Console.WriteLine(intermediate);
                sum += intermediate;
            }
            average = Convert.ToDouble(sum) / 5;
            Console.WriteLine(average);
            Console.ReadKey();
        }
    }
}
