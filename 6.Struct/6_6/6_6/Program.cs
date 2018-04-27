using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_6
{
    enum Post : int
    {
        Junior = 80,
        Middle = 120,
        Senior = 160,

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{Post.Junior} Должен проработать {(int)Post.Junior} часов");
            Console.WriteLine($"{Post.Middle} Должен проработать {(int)Post.Middle} часов");
            Console.WriteLine($"{Post.Senior} Должен проработать {(int)Post.Senior} часов");

            Console.Write("Введите должность: ");
            string a = Console.ReadLine();

            Console.Write("Введите кол-во часов: ");
            int b;
            while (!int.TryParse(Console.ReadLine(), out b)) { }

            if (a == Post.Junior.ToString())
            {
                Console.WriteLine($"Начислить бонусы в этом месяце? - {Accauntant.AskForBonus(Post.Junior,b)}");
            }
           else if(a == Post.Middle.ToString())
            {
                Console.WriteLine($"Начислить бонусы в этом месяце? - {Accauntant.AskForBonus(Post.Middle, b)}");
            }
           else if(a == Post.Senior.ToString())
            {
                Console.WriteLine($"Начислить бонусы в этом месяце? - {Accauntant.AskForBonus(Post.Senior, b)}");
            }
            else
            {
                Console.WriteLine("Нет такой должности");
            }

            Console.ReadKey();
        }
    }

    static class Accauntant
    {
      public static bool AskForBonus(Post worker, int hours)
        {
            if ((int)worker < hours)
                return true;
            else
                return false;
        }
    }
}
