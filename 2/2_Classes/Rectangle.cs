using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Classes
{
    class Rectangle
    {
        double side1, side2;
        double area, perimeter;
        double Area { get { return area; } }
        double Perimeter { get { return perimeter; } }

        public Rectangle()
        {

        }

        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        public double AreaCalculator()
        {
            area = side2 * side2;
            return Area;
        }

        public double PerimetrCalculator()
        {
            perimeter = side2 * 2 + side1 * 2;
            return Perimeter;
        }
    }
}
