using System;
using System.Linq;

namespace TakeSkipWhileLab
{
    internal class Program
    {
        private static int[] data = { 1, 3, 2, 4, 9 };

        private static void TakeWhile2()
        {
            foreach (var item in data.TakeWhile((a, index) => a >= 1 && a < 5 && index < 2))
            {
                Console.WriteLine(item);
            }
        }

        private static void SkipWhile2()
        {
            foreach (var item in data.SkipWhile((a, index) => a >= 1 && a < 5 && index < 2))
            {
                Console.WriteLine(item);
            }
        }

        private static void Main(string[] args)
        {
            TakeWhile2();
            Console.WriteLine("Hello World!");
            SkipWhile2();
        }
    }
}