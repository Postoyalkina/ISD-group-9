using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new GreenPrinter();
            printer.Print("Green grass");
            printer = new BluePrinter();
            printer.Print("Blue sky");
            printer = new Printer();
            printer.Print("Base functional");
            Console.ReadKey();
        }
    }
}
