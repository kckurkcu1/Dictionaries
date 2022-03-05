using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionaries
{
    class MyDictionary<Tkey, Tvalue>
    {
        Tkey[] dictionaryKey;
        Tvalue[] dictionaryValue;

        public MyDictionary()
        {
            dictionaryKey = new Tkey[0];
            dictionaryValue = new Tvalue[0];
        }

        public void Add(Tkey key, Tvalue value)
        {
            Tkey[] tempKey = dictionaryKey;
            Tvalue[] tempValue = dictionaryValue;

            dictionaryKey = new Tkey[dictionaryKey.Length + 1];
            dictionaryValue = new Tvalue[dictionaryValue.Length + 1];

            for (int i = 0; i < tempKey.Length; i++)
            {
                dictionaryKey[i] = tempKey[i];
                dictionaryValue[i] = tempValue[i];
            }

            dictionaryKey[dictionaryKey.Length - 1] = key;
            dictionaryValue[dictionaryValue.Length - 1] = value;
        }

        public void Write()
        {
            for (int i = 0; i < dictionaryKey.Length; i++)
            {
                Console.WriteLine("Key : " + dictionaryKey[i] + "= " + "Değer: " + dictionaryValue[i]);
            }
        }

    }
}