using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_3
{
    class MyDictionary<TKey, TValue>
    {
        TKey[] keys;
        TValue[] values;
        public MyDictionary()
        {
            keys = new TKey[0];
            values = new TValue[0];
        }

        public MyDictionary(int size)
        {
            keys = new TKey[size];
            values = new TValue[size];
        }

        public TValue this[TKey key]
        { 
            get
            {   for (int i = 0; i < keys.Length; i++)
                    if (key.Equals(keys[i])) return values[i];
                    return default(TValue);
            }
        }

        public int Count { get => values.Length; }

        public void Add(TKey key, TValue value)
        {
            for (int i = 0; i < keys.Length; i++)
                if (key.Equals(keys[i])) throw new Exception("Такой ключ уже существует");
            TKey[] temp_of_keys = new TKey[keys.Length + 1];
            TValue[] temp_of_values = new TValue[values.Length + 1];
            Array.Copy(keys, temp_of_keys, keys.Length);
            Array.Copy(values, temp_of_values, values.Length);
            temp_of_keys[keys.Length] = key;
            temp_of_values[values.Length] = value;
            keys = temp_of_keys;
            values = temp_of_values;
        }

    }
}
