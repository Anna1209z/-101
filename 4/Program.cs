using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            var vars = MyClass<int>.FactoryMethod();
            var vars2 = MyClass<double>.FactoryMethod();
            Console.WriteLine(vars.Item1.GetType().Name);
            Console.WriteLine(vars2.Item2.GetType().Name);
            Console.ReadKey();
        }

    }
    class MyClass<T>
    where T : new()
    {
        public static (T, T) FactoryMethod()
        {
            return (new T(), new T());
        }
    }
}
