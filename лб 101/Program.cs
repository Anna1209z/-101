using System;
using System.Collections.Generic;
using System.Collections;

namespace лб_101
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> my = new MyList<int>();
            my.array = new int[5] { 7, 5, 4, 2, 8 };
            my.Add();
            my.Output();
            Console.WriteLine($"Number of elements:{my.num}");
            try
            {
                Console.WriteLine("Choose number of elements:");
                int index = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Number of index {index} = {my[index]}");
                Console.WriteLine("Extension method: ");
                for (int i = 0; i < my.mylist.Count; i++)
                {
                    Console.WriteLine(my.mylist.GetArray1()[i]);
                    Console.WriteLine();
                }

            }
            catch (Exception a)
            {

                Console.WriteLine(a.Message);
            }


            Console.ReadKey();
        }
    }
    class MyList<T>
    {
        public List<T> mylist = new List<T>();
        public T[] array;
        public T this[int index]
        {
            get => mylist[index];
        }
        public void Add()
        {
            mylist.AddRange(array);
        }
        public int num { get => mylist.Count; }
        public void Output()
        {
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
    static class GetArray
    {
        public static T[] GetArray1<T>(this List<T> mylist)
        {
            int i = 0; T[] array = new T[i];
            foreach (T item in mylist)
            {
                T[] array2 = new T[array.Length + 1];
                array.CopyTo(array2, 0);
                array2[array.Length] = item;
                array = array2;
            }
            return array;
        }
    }
}
