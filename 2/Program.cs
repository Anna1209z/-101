using System;
using System.Collections.Generic;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> keys = new MyDictionary<int, string>();
            keys.Add(2, "Sveta", 3, "Korovkina", 4, "Ivanova");
            keys.OutPut();
            Console.WriteLine($"Number of elements:{keys.num}");
            try
            {
                Console.WriteLine("Enter number");
                int index = Convert.ToInt32(Console.ReadLine());
                keys.Method(index);
            }
            catch (Exception a)
            {

                Console.WriteLine(a.Message);
            }

            Console.ReadKey();

        }
    }
    class MyDictionary<TKey, TValue>
    {
        Dictionary<TKey, TValue> keys = new Dictionary<TKey, TValue>();
        public void Add(TKey key1, TValue value1, TKey key2, TValue value2, TKey key3, TValue value3)
        {
            keys.Add(key1, value1);
            keys.Add(key2, value2);
            keys.Add(key3, value3);

        }
        public void OutPut()
        {
            foreach (KeyValuePair<TKey, TValue> item in keys)
            {
                Console.WriteLine($"{item.Key} - { item.Value}");
            }
        }
        public int num { get => keys.Count; }
        public void Method(TKey value)
        {
            try
            {
                TValue val = keys[value];
                Console.WriteLine("Value is found:");
                Console.WriteLine($"Value = {val}");
            }
            catch (Exception a)
            {

                Console.WriteLine(a.Message);
            }
        }
    }
}
