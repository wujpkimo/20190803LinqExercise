using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqToObjSelect
{
    public static class MyExt
    {
        public static IEnumerable<Tresult> Sel<T, Tresult>(this IEnumerable<T> source,
            Func<T, Tresult> selector)
        {
            foreach (var item in source)
                yield return selector(item);
        }
    }

    internal class Program
    {
        private class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }

        private static void SelectNew2()
        {
            Person[] data1 = {
                new Person() { Name = "code6421", Age = 10 },
                new Person() { Name = "mary", Age = 11 },
                new Person() { Name = "mark", Age = 12 }
            };
            //var result = data1.Select((a, idx) => new { Value = a.Name + "," + a.Age + "," + idx });
            var result = data1.Sel(a => a.Age);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        private static void Main(string[] args)
        {
            SelectNew2();
        }
    }
}