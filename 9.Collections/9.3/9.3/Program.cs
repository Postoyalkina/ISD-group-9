using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionaty<string, string> dictionaty = new MyDictionaty<string, string>();
            dictionaty.Add("Hello", "World");
            dictionaty.Add("Hi", "Nastya");
            foreach(KeyValuePair<string,string> kv in dictionaty)
            {
                Console.WriteLine(kv.Key + " " + kv.Value);
            }
            Console.ReadKey();
        }
    }
}
