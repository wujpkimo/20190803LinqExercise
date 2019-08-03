using System;
using System.Linq;

namespace TakeSkipWhile
{
    internal class Program
    {
        private static void TakeWhile()
        {
            var data = new int[] { 1, 3, 5, 6, 7, 8 };
            foreach (var item in data.TakeWhile(a => a >= 1 && a < 5))
            {
                Console.WriteLine(item);
            }
        }

        private static void SkipWhile()
        {
            var data = new int[] { 1, 3, 5, 6, 7, 1, 8 };

            foreach (var item in data.SkipWhile(a => a >= 1 && a < 5))
            {
                Console.WriteLine(item);
            }
        }

        private static void Main(string[] args)
        {
            SkipWhile();
        }
    }
}