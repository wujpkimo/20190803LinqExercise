using System;
using System.Linq;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = { 1, 3, 5, 6, 7, 8 };
            var r = from s1 in data where s1 == 3 select s1;
            Console.WriteLine(r.FirstOrDefault());
        }
    }
}
