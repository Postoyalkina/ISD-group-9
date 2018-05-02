using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._7
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList R = new ArrayList();
            MyArrayList Mr = new MyArrayList();
            
            Console.ReadKey();

        }
    }

    class MyArrayList : IEnumerable
    {
        List<object> Lis;

        public MyArrayList(object[] A = null)
        {
            if (A != null)
                Lis = new List<object>(A);
            else
                Lis = new List<object>();
        }
        public void remove(object value)
        {
            Lis.Remove(value);
        }
        public void Add(object value)
        {
            Lis.Add(value);
        }
        public void AddRange(ICollection T)
        {
            foreach (var item in T)
            {
                Lis.Add(item);
            }
        }
        public void Reverse()
        {
            Lis.Reverse();
        }

        public object this [int i] 
        {
            get
            {
                return Lis[i];
            }
            set
            {
                Lis[i] = value;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return Lis.GetEnumerator();
        }
    }
}


