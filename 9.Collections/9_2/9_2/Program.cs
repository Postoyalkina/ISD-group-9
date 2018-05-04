using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_2
{
    class Program
    {
        static void Main(string[] args)
        {

            myList<int> mylist = new myList<int>(new int[] { 23, 34, 987, 425, 246, 57764, 246, 75324, 6, 796758 });
            Console.WriteLine(mylist[3]);
            mylist.Add(14);
            Console.WriteLine("Lenght: " + mylist.Length);
            foreach (var item in mylist)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
        class myList<T> : IEnumerable<T>
        {
            T[] Array;

            #region constructors
            public myList()
            {
                Array = new T[0];
            }
            public myList(T[] N)
            {
                Array = N;
            }

            #endregion

            public void Add(T value)
            {
                T[] array = new T[Array.Length + 1];
                for (int i = 0; i < Array.Length; i++)
                {
                    array[i] = Array[i];
                }
                array[Array.Length] = value;
                Array = array;
            }

            public T this[int i]
            {
                get { return Array[i]; }
                set { Array[i] = value; }
            }
            public int Length
            {
                get { return Array.Length; }
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }

            public IEnumerator<T> GetEnumerator()
            {
                for (int i = 0; i < Array.Length; i++)
                {
                    yield return Array[i];
                }
            }
        }
    }
}
