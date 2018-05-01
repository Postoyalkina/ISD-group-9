using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MyDictionary<int, int> dictionary = new MyDictionary<int, int>(5);
                dictionary.Add(1, 10);
                dictionary.Add(2, 20);
                dictionary.Add(3, 30);

                Console.WriteLine(dictionary[3]);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message); 
            }
            Console.ReadLine();
        }
    }
}
