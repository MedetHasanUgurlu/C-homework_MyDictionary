﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionaryHomework
{
    class MyDictionary<K,V>
    {
        K[] keys;
        V[] values;

        public MyDictionary()
        {
            keys = new K[0];
            values = new V[0];
        }

        public void Add(K key, V value) 
        {
            K[] tempKey = keys;
            V[] tempValue = values;

            keys = new K[keys.Length + 1];
            values = new V[values.Length + 1];

            

            for (int i = 0; i < tempValue.Length; i++)
            {
                keys[i] = tempKey[i];
                values[i] = tempValue[i];
            }

            keys[values.Length - 1] = key;
            values[values.Length - 1] = value;


        }

        public void yazdır()
        {

            //foreach (K X in keys)
            //{
            //    Console.WriteLine("Key item: " + X);
            
            //}

            //foreach (V Y in values)
            //{
            //    Console.WriteLine("Value item" + Y);
            //}


            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine("Key item: " + keys[i]+"= " + "Value item " + values[i]);
            }

        }

    }
}
