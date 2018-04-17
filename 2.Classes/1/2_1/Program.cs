using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address();
            Console.WriteLine("Введите данные:");
            //Получаем index
            bool interB = false;//Флаг для удобной работы с TryParse. Ибо мы не можем напрямую присвоить значение TryParse полю.
            while (!interB)
            {
                Console.WriteLine("Введите индекс:");
                interB = int.TryParse(Console.ReadLine(), out int index);
                address.Index = index;
            }
            //Получаем country
            Console.WriteLine("Введите страну:");
            address.Country = Console.ReadLine();
            //Получаем city
            Console.WriteLine("Введите город:");
            address.City = Console.ReadLine();
            //Получаем street
            Console.WriteLine("Введите улицу:");
            address.Street = Console.ReadLine();
            //Получаем house
            interB = false;//Флаг для удобной работы с TryParse. Ибо мы не можем напрямую присвоить значение TryParse полю.
            while (!interB)
            {
                Console.WriteLine("Введите номер дома:");
                interB = int.TryParse(Console.ReadLine(), out int house);
                address.House = house;
            }
            //Получаем apartment
            interB = false;//Флаг для удобной работы с TryParse. Ибо мы не можем напрямую присвоить значение TryParse полю.
            while (!interB)
            {
                Console.WriteLine("Введите номер квартиры:");
                interB = int.TryParse(Console.ReadLine(), out int apartment);
                address.Apartment = apartment;
            }
            //Сам вывод
            address.WriteAddress();
            Console.ReadKey();
        }

    }
}
