using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_2
{
    class Program
    {
        //С отловом ошибок возникли некоторые проблемы
        static void Main(string[] args)
        {
            int gyear = 2019, gmonth = 4, gday = 0, ghour =0, gminute=0;
            Train[] trains = new Train[8];
            for (int i = 0; i < 8; i++)
            {
                //DateTime dateTime = new DateTime();
                Console.WriteLine("Введите пункт назначения для рейса: " + (i + 1).ToString());
                trains[i].nameOfDestination = Console.ReadLine();
                Console.WriteLine("Введите номер поезда для рейса: " + (i + 1).ToString());
                trains[i].numberOfTrain = Convert.ToInt32(Console.ReadLine());
                //while (!int.TryParse(Console.ReadLine(), out int number))
                //{
                //    Console.WriteLine("Введите номер поезда для рейса: " + (i + 1).ToString());
                //    trains[i].numberOfTrain = number;
                //}
                Console.WriteLine("Введите день рейса: " + (i + 1).ToString());
                gday = Convert.ToInt32(Console.ReadLine());
                //while (!int.TryParse(Console.ReadLine(), out int day) || day > 31)
                //{
                //    Console.WriteLine("Введите день рейса: " + (i + 1).ToString());
                //    //trains[i].departureTime = trains[i].departureTime.AddDays(day - 1);
                //    gday = day;
                //}
                Console.WriteLine("Введите час рейса: " + (i + 1).ToString());
                ghour = Convert.ToInt32(Console.ReadLine());
                //while (!int.TryParse(Console.ReadLine(), out int hour) || hour > 24)
                //{
                //    Console.WriteLine("Введите час рейса: " + (i + 1).ToString());
                //    ghour = hour;
                //}
                Console.WriteLine("Введите минуту рейса: " + (i + 1).ToString());
                gminute = Convert.ToInt32(Console.ReadLine());
                //while (!int.TryParse(Console.ReadLine(), out int minute) || minute > 60)
                //{
                //    Console.WriteLine("Введите минуту рейса: " + (i + 1).ToString());
                //    gminute = minute;
                //}
                trains[i].departureTime = new DateTime(gyear,gmonth,gday,ghour,gminute,0);
            }
            Console.WriteLine("Для того что-бы прекратить тестировку введите значение не являющееся целым числом");
            while (int.TryParse(Console.ReadLine(),out int numberOfTrain))
            {
                Console.WriteLine(trains[numberOfTrain - 1].nameOfDestination.ToString());
                Console.WriteLine(trains[numberOfTrain -1 ].numberOfTrain.ToString());
                Console.WriteLine(trains[numberOfTrain-1].departureTime.ToString());
            }
            
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
