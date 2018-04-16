using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длинну первой стороны:");
            double side1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите длинну второй стороны:");
            double side2 = Convert.ToDouble(Console.ReadLine());
            Rectangle rectangle = new Rectangle(side1, side2);
            Console.WriteLine("Площадь прямоугольника ={0} \nПериметр прямоугольника = {1}",rectangle.AreaCalculator(),rectangle.PerimetrCalculator());
            Console.ReadLine();
            

        }
    }
}
