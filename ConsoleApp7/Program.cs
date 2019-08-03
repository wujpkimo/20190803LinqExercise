using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp7
{
    static class Helper
    {
        public static IEnumerable<T> Filter<T>(this IEnumerable<T> source, Func<T, bool> filter)
        {
            var result = new List<T>();
            foreach (var item in source)
            {
                if(filter(item))
                    yield return item;
            }
        }
    }
    class Program
    {


        static void Main(string[] args)
        {
            var list = new int[] { 1, 3, 5, 7, 9 };
            Console.WriteLine(list.Filter(s => s == 3).FirstOrDefault());
        }
    }
}
