using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input A(int)");
            if (!int.TryParse(Console.ReadLine(), out int a))
            {
                Console.WriteLine("Please input correct data!");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Input B(int)");
            if (!int.TryParse(Console.ReadLine(), out int b))
            {
                Console.WriteLine("Please input correct data!");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("What you want to do?('+','-','*','/')");
            
            string operation = Console.ReadLine();
            switch (operation)
            {
                case "+":
                    {
                        Console.WriteLine(Calculator.Sum(a,b));
                        break;
                    }
                case "-":
                    {
                        Console.WriteLine(Calculator.Diff(a, b));
                        break;
                    }
                case "*":
                    {
                        Console.WriteLine(Calculator.Mult(a, b));
                        break;
                    }
                case "/":
                    {
                        Console.WriteLine(Calculator.Div(a, b));
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Please input correct data!");
                        break;
                    }

            }
            Console.ReadKey();
        }
        static class Calculator
        {
            public static int Sum(int a, int b)
            {
                return a + b;
            }
            public static int Diff(int a, int b)
            {
                return a - b;
            }
            public static int Mult(int a, int b)
            {
                return a * b;
            }
            public static double Div(int a, int b)
            {
                return Convert.ToDouble(a) / Convert.ToDouble(b);
            }
        }
        
    }
}
