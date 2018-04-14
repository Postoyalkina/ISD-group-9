using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string userPassword, correctPassword = "root";

            do
            {
                Console.WriteLine("Введите пароль");
                userPassword = Console.ReadLine();
                if (userPassword != correctPassword)
                {
                    Console.WriteLine("Неверный пароль!");
                }
            } while (userPassword != correctPassword);

            Console.WriteLine("Верный пароль =)");
            Console.ReadKey();
        }
    }
}
