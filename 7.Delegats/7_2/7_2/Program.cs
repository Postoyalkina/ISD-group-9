using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_2
{
    class Program
    {
        delegate double Operation(double x, double y);
        static Operation Add = (double x, double y) => { return x + y; };
        static Operation Sub = (double x, double y) => { return x - y; };
        static Operation Mul = (double x, double y) => { return x * y; };
        static Operation Div = (double x, double y) => { if (y == 0) throw new DivideByZeroException("\nПопытка деления на 0");else return x/y; };

        static void Main()
        {
            Console.Write("Введите х:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nВведите y:");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.Write("Выберите операцию: \n'+' для сложения\n'-' для разности\n'*' для умножения\n'/' для деления \nВыбранная операция:");
            char operation = Convert.ToChar(Console.Read());
            Console.Write("{0} {1} {2} = ", x, operation, y);
            try {
                
                   if (operation== '+')
                        Console.WriteLine(Add(x, y));
                   else if (operation== '-')
                        Console.WriteLine(Sub(x, y));
                   else if (operation == '*')
                        Console.WriteLine(Mul(x, y));
                   else if (operation == '/')
                        Console.WriteLine(Div(x, y));
                else Console.WriteLine("Такой операции наш калькулятор не имеет");
            }
            
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                
            }
            Console.ReadLine();
            Console.ReadLine();
        }
    }
}
