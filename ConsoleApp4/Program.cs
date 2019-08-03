using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Find<T>(T[] source,
                            Func<T,bool> findValue)
        {
            foreach (var item in source)
            {
                if (findValue(item))
                {
                    Console.WriteLine($"found {item}");
                    return;
                }
            }
            Console.WriteLine("not found");
        }

        static bool MyFilterFunc(int value)
        {
            return value > 4;
        }
        static void Main(string[] args)
        {
            //var list = new float[] { 1, 2, 3, 4, 5 };
            //var list = new char[] { '1', '2', '3', '4' };
            var list = new string[] { "1", "2", "3", "4" };
            Find(list, (s) => s =="3");
            Console.ReadLine();
        }
    }
}
