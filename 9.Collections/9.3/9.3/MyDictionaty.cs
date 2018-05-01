using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._3
{
    class MyDictionaty<Tkey,Tvalue>
    {
        private Tkey[] keysArray;
        private Tvalue[] valsArray;
        public int Count { get => keysArray.Length; }

        public MyDictionaty()
        {
            keysArray = new Tkey[0];
            valsArray = new Tvalue[0];
        }

        public Tvalue this[Tkey key]
        {
            get
            {
                int ind = 0;
                for (int i = 0; i < keysArray.Length; i++)
                {
                    if (key.Equals(keysArray[i]))
                        ind = i;
                }
                return valsArray[ind];
            }
        }

        public void Add(Tkey key, Tvalue value)
        {
            Tkey[] tempK = new Tkey[keysArray.Length + 1];
            Array.Copy(keysArray, tempK, keysArray.Length);
            tempK[keysArray.Length] = key;
            keysArray = tempK;

            Tvalue[] tempV = new Tvalue[valsArray.Length + 1];
            Array.Copy(valsArray, tempV, valsArray.Length);
            tempV[valsArray.Length] = value;
            valsArray = tempV;
        }

        public IEnumerator<KeyValuePair<Tkey, Tvalue>> GetEnumerator()
        {
            for (int i = 0; i < keysArray.Length; i++)
                yield return new KeyValuePair<Tkey, Tvalue>(keysArray[i], valsArray[i]);
        }

    }
}
