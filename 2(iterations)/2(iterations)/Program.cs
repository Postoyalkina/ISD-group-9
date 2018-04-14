using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_iterations_
{
    class Program
    {
        static void Main(string[] args)
        {

            double number;
            while (!double.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Incorrect data!");
            }
            int i;
            for (i = 1; number > 10; i++)
            {
                number /= 10;
            }
            Console.WriteLine(i);
            Console.ReadKey();

        }
    }
}
