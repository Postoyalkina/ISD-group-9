using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_1
{
    class Printer
    {
        public virtual void Print(string value)
        {
            Console.WriteLine(value);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
    class GreenPrinter:Printer
    {
        public override void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            base.Print(value);
        }
    }
    class BluePrinter : Printer
    {
        public override void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            base.Print(value);
        }
    }
}
