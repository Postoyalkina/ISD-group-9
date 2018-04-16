using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Figure
{
    class Program
    {
        static void Main(string[] args)
        {
            Point []A = new Point [] 
            {
                new Point(0,0,""),
                new Point(4,0,""),
                new Point(3,1,""),
                new Point(6,1,"")
            };
            Figure F = new Figure(A[0],A[1],A[2],A[3]);
            Console.WriteLine(F.PerimetrCalculator().ToString());
            Console.ReadKey();
        }
    }
    class Point
    {
        public int X { get; }
        public int Y { get; }
        public string Name { get; }

        public Point(int x, int y, string name)
        {
            X = x;
            Y = y;
            Name = name;
        }
    }
    class Figure
    {
        Point[] A;
        public Figure(Point A1, Point A2, Point A3, Point A4 = null, Point A5 = null)
        {
            A = new Point[5];
            A[0] = A1;
            A[1] = A2;
            A[2] = A3;
            A[3] = A4;
            A[4] = A5;


        }
        public double LengthSide(Point A, Point B)
        {
            return Math.Round( Math.Sqrt((A.X - B.X)* (A.X - B.X) + (A.Y - B.Y)* (A.Y - B.Y)),4);
        }
        public double PerimetrCalculator()
        {
            double sum=0;
            for (int i = 0; i < A.Length-1; i++)
            {
                if (A[i + 1] == null)                
                    return sum += LengthSide(A[i], A[0]);                 
                sum += LengthSide(A[i], A[i + 1]);
            }
            return sum;
        }
    }
}
