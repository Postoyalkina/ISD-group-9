using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int day, month, year;
            Console.WriteLine("Введите дату своего рождения\nДень: ");
            day = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Месяц: ");
            month = Int32.Parse(Console.ReadLine());

            if ((DateTime.Now.Month > month) || (DateTime.Now.Month == month && DateTime.Now.Day > day))
            {
                year = DateTime.Now.Year + 1;
            }
            else
            {
                year = DateTime.Now.Year;
            }

            DateTime birthday = new DateTime(year, month, day);
            TimeSpan left = birthday - DateTime.Now;
            int days = (int)left.TotalDays;
       
            Console.WriteLine("Still to your birthday " + days + " days");

            Console.ReadKey();
        }
    }
}
