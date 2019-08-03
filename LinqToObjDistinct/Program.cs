using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqToObjDistinct
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class PersonEqualComparer : IEqualityComparer<Person>
    {
        public bool Equals(Person x, Person y)
        {
            if (x == null && y == null)
                return true;
            if ((x == null && y != null) ||
                (x != null && y == null))
                return false;
            if (x.Name == y.Name && x.Age == y.Age)
                return true;
            return false;
        }

        public int GetHashCode(Person obj)
        {
            int hash = 13 * 7;
            if (obj.Name != null)
                hash += obj.Name.GetHashCode();
            hash += obj.Age.GetHashCode();
            return hash;
        }
    }

    internal class Program
    {
        private static void UseDistinct()
        {
            Person[] data1 = {
                new Person() { Name = "code6421", Age = 15 },
                new Person() { Name = "mary", Age = 11 },
                new Person() { Name = "jack", Age = 35 },
                new Person() { Name = "mary", Age = 11 },
                new Person() { Name = "jack", Age = 35 } };
            foreach (var item in data1.Distinct(new PersonEqualComparer()))
            {
                Console.WriteLine(item.Name);
            }
        }

        private static void Main(string[] args)
        {
            UseDistinct();
        }
    }
}