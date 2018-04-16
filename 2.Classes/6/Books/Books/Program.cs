using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books
{
    class Program
    {
        static void Main(string[] args)
        {
            Book B = new Book();
            B.A = new Author();
            B.C = new Content();
            B.T = new Title();

            B.A.author = "Bill";
            B.C.text =  "Today is a good day";
            B.T.title = "My day";

            B.Show();
            Console.ReadKey();
        }
    }

    class Book
    {
        public Title T { get; set; }
        public Author A { get; set; }
        public Content C { get; set; }

        public void Show()
        {
            if (T != null)
                T.show();
            if (A != null)
                A.show();
            if (C != null)
                C.show();
        }
    }
    class Title
    {
        public string title;
        public void show()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Title: " + title);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
    class Author
    {
        public string author;
        public void show()
        {

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Author: " + author);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
    class Content
    {
        public string text;
        public void show()
        {

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
