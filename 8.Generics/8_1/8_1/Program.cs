using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MyClass<Account>.FactoryMethod().SetId(225).id.ToString());
            Console.ReadKey();
        }
        
    }
    class MyClass<T> where T : new()
    {
        public static T FactoryMethod()
        {
            T r = new T();
            return r;
        }
    }
    class Account
    {
        public int id;

        public Account SetId(int p)
        {
            id = p;
            return this;
        }
    }
}
