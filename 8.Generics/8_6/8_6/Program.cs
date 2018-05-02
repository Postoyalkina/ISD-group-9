using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> myDictionary = new Dictionary<string,int> ();
            myDictionary.Add("age",25);
            myDictionary.Add("height", 185);
            myDictionary.Add("weight", 78);
            Console.WriteLine(myDictionary.GetValue("age"));
            Console.WriteLine(myDictionary.GetValue(0));
            Console.WriteLine(myDictionary.GetKey(0));
            Console.ReadKey();
        }
        class Dictionary<TKey,TValue>
        {
            int numberOfElements;
            List<TValue> listOfValues;
            List<TKey> listOfKeys;
            public Dictionary()
            {
                listOfValues = new List<TValue>();
                listOfKeys = new List<TKey>();
            }
            public void Add(TKey key,TValue value)
            {
                listOfValues.Add(value);
                listOfKeys.Add(key);
            }
            public TValue GetValue(TKey key)
            {
                int index = listOfKeys.IndexOf(key);
                return listOfValues[index];
            }
            public TValue GetValue(int index)
            {
                return listOfValues[index];
            }
            public TKey GetKey(int index)
            {
                return listOfKeys[index];
            }
        }
    }
}
