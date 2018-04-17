using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice i = new Invoice(345,"TransAir","UkrTechInvest");
            Console.WriteLine("TAX:");
            i.PriceOfOrder(29000,40,"Engine");
            Console.WriteLine("Without TAX:");
            i.PriceOfOrderWithoutTax(29000, 40, "Engine");
            Console.ReadKey();
        }
    }
}
