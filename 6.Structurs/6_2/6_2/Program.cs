using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Train[] trains = new Train[8];
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine("Введите пункт назначения для рейса: " + (i + 1).ToString());
                trains[i].nameOfDestination = Console.ReadLine();
                Console.WriteLine("Введите номер поезда для рейса: " + (i + 1).ToString());
                while (!int.TryParse(Console.ReadLine(), out int number))
                {
                    Console.WriteLine("Введите номер поезда для рейса: " + (i + 1).ToString());
                    trains[i].numberOfTrain = number;
                }
                while (!int.TryParse(Console.ReadLine(), out int hour) && hour < 24)
                {
                    Console.WriteLine("Введите час для рейса: " + (i + 1).ToString());
                    trains[i].departureTime.AddHours(Convert.ToDouble(hour));
                }
            }
            Console.WriteLine(trains[0].departureTime.ToString());
            Console.ReadKey();
        }
    }
    struct Train
    {
        public string nameOfDestination;
        public int numberOfTrain;
        public DateTime departureTime;
    }
}
