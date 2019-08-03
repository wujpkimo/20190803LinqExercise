using System;
using System.Linq;

namespace ConsoleApp8
{
    internal class Program
    {
        private static void UseWhere2()
        {
            var data = new int[] { 1, 3, 5, 7, 2 };
            var result = data.Where((a, idx) => idx > 3 && a < 7);
            foreach (var item in result)
                Console.WriteLine(item);
        }

        private static void Main(string[] args)
        {
            UseWhere2();
            Console.ReadLine();
        }
    }
}