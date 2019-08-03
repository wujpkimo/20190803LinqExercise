using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
    class Program
    {
        static IEnumerable<int> Forever()
        {
            while (true)
            {
                yield return 1;
            }
        }
        static void Main(string[] args)
        {
            foreach (var item in Forever())
            {
                Console.WriteLine(item);
            }
        }
    }
}
