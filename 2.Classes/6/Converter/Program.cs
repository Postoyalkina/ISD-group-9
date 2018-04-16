using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Converter C = new Converter(usd: 26.1249, eur: 32.1781 ,rus: 0.4253);
            int command, sum;
            do
            {
                Console.Clear();
                Console.WriteLine("1.Перевести из UAH");
                Console.WriteLine("2.Перевести в UAH");
                Console.WriteLine("3.Выход");
                while (!int.TryParse(Console.ReadLine(),out command)) { Console.WriteLine("Повторите попытку"); }
                Console.Clear();
                if (command == 1)
                {
                    
                    Console.WriteLine((int)Converter.currencies.RUS + ". В RUS");
                    Console.WriteLine((int)Converter.currencies.USD + ". В USD");
                    Console.WriteLine((int)Converter.currencies.EUR + ". В EUR");
                    while (!int.TryParse(Console.ReadLine(), out command)) { Console.WriteLine("Повторите попытку"); }
                    if (command >= 0 && command < 3)
                    {
                        Console.WriteLine("Введите сумму");
                        while (!int.TryParse(Console.ReadLine(), out sum)) { Console.WriteLine("Повторите попытку"); }
                        Console.WriteLine("Переводим из UAH ..." + C.ConvertFromUAH((Converter.currencies)command, sum));
                    }

                }
                else if (command == 2)
                {
                    Console.WriteLine((int)Converter.currencies.RUS + ". Из RUS");
                    Console.WriteLine((int)Converter.currencies.USD + ". Из USD");
                    Console.WriteLine((int)Converter.currencies.EUR + ". Из EUR");
                    while (!int.TryParse(Console.ReadLine(), out command)) { Console.WriteLine("Повторите попытку"); }
                    if (command >= 0 && command < 3)
                    {
                        Console.WriteLine("Введите сумму");
                        while (!int.TryParse(Console.ReadLine(), out sum)) { Console.WriteLine("Повторите попытку"); }
                        Console.WriteLine("Переводим в UAH ..." + C.ConvertToUAH((Converter.currencies)command, sum));
                    }
                }
                else if (command == 3)
                    break;
                Console.ReadKey();
            } while (true);
            Console.WriteLine("Выходим");

            Console.ReadKey();
        }
    }

    class Converter
    {
        public enum currencies : byte { RUS, USD, EUR };
        double RUS, USD, EUR;
        public Converter(double rus, double usd, double eur)
        {
            RUS = rus;
            USD = usd;
            EUR = eur;
        }
        public double ConvertToUAH(currencies c, double sum)
        {
            switch (c)
            {
                case currencies.EUR:
                    {
                        return Math.Round(sum * EUR, 2);
                    }
                case currencies.RUS:
                    {
                        return Math.Round(sum * RUS, 2);
                    }
                case currencies.USD:
                    {
                        return Math.Round(sum * USD, 2);
                    }
            }
            return 0;
        }
        public double ConvertFromUAH(currencies c, double sum)
        {
            switch (c)
            {
                case currencies.EUR:
                    {
                        return Math.Round(sum / EUR, 2);
                    }
                case currencies.RUS:
                    {
                        return Math.Round(sum / RUS, 2);
                    }
                case currencies.USD:
                    {
                        return Math.Round(sum / USD, 2);
                    }
            }
            return 0;
        }

    }
}
