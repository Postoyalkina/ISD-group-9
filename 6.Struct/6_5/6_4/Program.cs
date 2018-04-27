using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_5
{
    public static class Printer
    {
        enum Colors 
        {
            yellow = 0,
            green = 1,
            blue = 2,
            red = 3
        }

        public static void Print(string stroka, int color)
        {
            Colors choise = (Colors)color;
            switch (choise)
            {
                case Colors.yellow:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(stroka);
                    break;
                case Colors.green:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(stroka);
                    break;
                case Colors.blue:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(stroka);
                    break;
                case Colors.red:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(stroka);
                    break;
                default:
                    Console.WriteLine("Такого цвета в принтере нет, поэтому:");
                    Console.WriteLine(stroka);
                    break;
            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Пожалуйста, введите строку");
            string stroka = Console.ReadLine();
            Console.WriteLine("Выберите цвет (ввести в консоль цифру): \n0 - желтый \n1 - зеленый\n2 - синий\n3 - красный");
            int color = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ваша строка:");
            Printer.Print(stroka, color);
            Console.ReadKey();
        }
    }
}
