using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> list = new MyList<int>();
            list.Add(1);
            list.Add(-2);
            list.Add(10);
            int[] arrList = ListExtension.GetArray<int>(list);
            foreach(int element in arrList)
            {
                Console.WriteLine(element);
            }
            Console.ReadKey();
        }
    }
}
