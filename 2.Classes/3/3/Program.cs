using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter title: ");
            string title = Console.ReadLine();
            Console.WriteLine("Enter author: ");
            string author = Console.ReadLine();
            Console.WriteLine("Enter content: ");
            string content = Console.ReadLine();

            Book book = new Book(title, author, content);
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Blue;
            book.BookTitle.Show();
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            book.BookAuthor.Show();
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Magenta;
            book.BookContent.Show();
            Console.ResetColor();

            Console.ReadKey();
        }
    }
}
