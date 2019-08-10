using System;
using System.Linq;

namespace Zip
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Zip();
        }

        private static void Zip()
        {
            int[] data1 = { 1, 3, 5, 7, 9 };
            int[] data2 = { 2, 3, 7 };
            foreach (var item in data1.Zip(data2, (x, y) => x + "," + y))
            {
                Console.WriteLine(item);
            }
        }
    }
}