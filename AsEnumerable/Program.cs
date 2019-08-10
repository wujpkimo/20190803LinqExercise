using System;
using System.Collections.Generic;
using System.Linq;

namespace AsEnumerable
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var d = new MyPersons();
            var e = d.AsEnumerable().Where(s => s == null);
        }
    }

    internal class MyPersons : List<Person>
    {
        public List<Person> Where(Func<Person, bool> predicate)
        {
            var result = new List<Person>();
            foreach (var item in this)
            {
                if (predicate(item))
                    result.Add(item);
            }
            return result;
        }
    }

    public class Person
    {
    }
}