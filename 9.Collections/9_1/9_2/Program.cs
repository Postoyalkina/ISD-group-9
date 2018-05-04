using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_2
{
   static class Iterator
    {
        static public IEnumerable<int> GetEven(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                    yield return array[i];
            }
        }
    }
    class Program
    {   
        
        static void Main(string[] args)
        {
            int[] array = new int[20];
            for (int i = 0; i < 20; i++)
                array[i] = i+1;
            foreach (int item in Iterator.GetEven(array))
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
