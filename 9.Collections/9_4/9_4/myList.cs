using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_4
{
    class myList<T> : IEnumerable<T>
    {
        T[] Array;

        #region constructors
        public myList() { }
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
