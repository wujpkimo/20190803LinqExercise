using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Reverse
{
    public static class MyHelper
    {
        //自訂reverse
        public static IEnumerable<T> MyReverse<T>(this IEnumerable<T> source)
        {
            var result = new List<T>();
            foreach (var item in source)
            {
                result.Add(item);
            }

            for (int i = result.Count - 1; i >= 0; i--)
            {
                yield return result[i];
            }
        }

        public static IEnumerable<T> MyReverse2<T>(this IEnumerable<T> source)
        {
            if (source is IList)
            {
                var list = (IList)source;
                for (int i = list.Count - 1; i >= 0; i--)
                {
                    yield return (T)list[i];
                }
            }
            else
            {
                var result = new List<T>();
                foreach (var item in source)
                {
                    result.Add(item);
                }

                for (int i = result.Count - 1; i >= 0; i--)
                {
                    yield return result[i];
                }
            }
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            var data = new int[] { 1, 3, 5, 7, 9 };
            var data2 = data.Where(a => a > 3);
            foreach (var item in data2.MyReverse2())
            {
                Console.WriteLine(item);
            }
        }
    }
}