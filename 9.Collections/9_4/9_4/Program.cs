using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_4
{
    class Program
    {
        static void Main(string[] args)
        {
            myList<string> ML = new myList<string>(new string[] { "Hello", "my", "name" , "is" , "human"});
            string []A = ML.GetArray<string>();
            foreach (var item in A)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }


    }


    static class myArrayExtention
    {
        public static T[] GetArray<T>(this IEnumerable<T> list)
        {
            T [] Array = new T[list.Count<T>()];
            int i = 0;
            foreach (T item in list)
            {
                Array[i] = item;
                i++;
            }
            return Array;
        }
    }
}
