using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<Keys, Values>

    {
        Keys[] keys;
        Values[] values;

        public MyDictionary()
        {
            keys = new Keys[0];
            values = new Values[0];

        }

        public void Add(Keys key, Values value)
        {
            Keys[] tempKeys = keys;
            Values[] tempValues = values;

            keys = new Keys[keys.Length + 1];
            values = new Values[values.Length + 1];
            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
                values[i] = tempValues[i];

            }

            keys[tempKeys.Length] = key;
            values[tempValues.Length] = value;
        }


        public void Print()
        {
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine("Key : " + keys[i]);
                Console.WriteLine("Value : " + values[i]);

            }
        }

    }
}

