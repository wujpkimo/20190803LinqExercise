using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp10
{
    internal class KVComparer<T, Tkey> : IComparer<KeyValuePair<T, Tkey>>
    {
        public int Compare(KeyValuePair<T, Tkey> x, KeyValuePair<T, Tkey> y)
        {
            if (x.Value is IComparable)
            {
                return ((IComparable)x.Value).CompareTo(y.Value);
            }
            else
            {
                int hashX = x.GetHashCode();
                int hashY = y.GetHashCode();
                if (hashX == hashY)
                {
                    return 0;
                }
                else if (hashX > hashY)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
        }
    }

    internal static class Helper
    {
        public static IEnumerable<T> Oby<T, Tresult>(this IEnumerable<T> source, Func<T, Tresult> selector)
        {
            var result = new List<KeyValuePair<T, Tresult>>();
            foreach (var item in source)
            {
                result.Add(new KeyValuePair<T, Tresult>(item, selector(item)));
            }
            result.Sort(new KVComparer<T, Tresult>());
            foreach (var item in result)
                yield return item.Key;
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Person[] data = {
                new Person() { Name = "jeff", Age = 25 },
                new Person() { Name = "code6421", Age = 15 },
                new Person() { Name = "mary", Age = 12 },
                new Person() { Name = "judy", Age = 15 }
            };
            var result = data.Oby(a => a.Name);

            foreach (var item in result)
            {
                Console.WriteLine(item.Name);
            }
        }
    }

    internal class PersonOddComparer : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            throw new NotImplementedException();
        }
    }
}