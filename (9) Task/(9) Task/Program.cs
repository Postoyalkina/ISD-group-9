using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9__Task
{
    class Program
    {
        const float UAHtoUSD = 26.17f;
        const float UAHtoEUR = 31.9f;
        
        static void Main(string[] args)
        {
            int sum, number;

            Console.WriteLine("Введите сумму");
            while (!int.TryParse(Console.ReadLine(), out sum))
            {
                Console.WriteLine("Повторите попытку");
            }

            Console.WriteLine("Выберите валюту: \n 1. Гривны (UAH) \n 2. Доллар (USD) \n 3. Евро (EUR)");
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                
                Console.WriteLine("Повторите попытку");
            }

            if (number > 0 && number < 4)
            {
                switch (number)
                {
                    case 1:
                        {
                            Print(sum,sum / UAHtoUSD, sum / UAHtoEUR);
                        }break;
                    case 2:
                        {
                            Print(sum * UAHtoUSD , sum, sum *UAHtoUSD /UAHtoEUR);
                        }break;
                    case 3:
                        {
                            Print(sum * UAHtoEUR, sum * UAHtoEUR/UAHtoUSD, sum);
                        }break;
                }
            }
            else
            {
                Console.WriteLine("Вы не выбрали валюту");
            }
                Console.ReadKey();

        }
        private static void Print(float UAH , float USD , float EUR)
        {
            Console.WriteLine("UAH - " + Math.Round( UAH));
            Console.WriteLine("USD - " + Math.Round( USD));
            Console.WriteLine("EUR - " + Math.Round( EUR));
        }
    }
}
