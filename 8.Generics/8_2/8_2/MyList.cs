using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_2
{
    class MyList<T>
    {
        T[] arr;
        public int Count { get => arr.Length; }
        public T this[int i]=>arr[i];

        public MyList()
        {
           arr = new T[0];
        }

        public MyList(int size)
        {
            arr = new T[size];
        }

        public void Add(T value)
        {
            T[] temp = new T[arr.Length + 1];
            Array.Copy(arr, temp, arr.Length);
            temp[arr.Length] = value;
            arr = temp;
        }

    }
}
