using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_4
{
    class MyList<T>
    {
        T[] arr;
        public int Count { get => arr.Length; }
        public T this[int i] => arr[i];

        public MyList()
        {
            arr = new T[0];
        }

        public MyList(int size)
        {
            arr = new T[size];
        }

        public MyList(T[] arr)
        {
            this.arr = arr;
        }

        

        public void Add(T value)
        {
            T[] temp = new T[arr.Length + 1];
            Array.Copy(arr, temp, arr.Length);
            temp[arr.Length] = value;
            arr = temp;
        }

    }

    static class ListExtension
    {
        public static T[] GetArray<T>(this MyList<T> list)
        {
            T[] temp = new T[list.Count];
            for(int i = 0; i < list.Count; i++)
            {
                temp[i] = list[i];
            }
            return temp;
        }
    }
}
