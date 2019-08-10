using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            UnionComplex();
        }

        public static void UnionComplex()
        {
            Person[] data1 = {
            new Person() { Name = "code6421", Age = 15 },
            new Person() { Name = "mary", Age = 11 },
            new Person() { Name = "jack", Age = 35 }
        };
            Person[] data2 = {
            new Person() { Name = "mary", Age = 11 },
            new Person() { Name = "jack", Age = 35 }
        };
            foreach (var item in data1.Union(data2, new PersonEqualComparer()))
            {
                Console.WriteLine(item.Name);
            }
        }
    }

    internal class PersonEqualComparer : IEqualityComparer<Person>
    {
        public bool Equals(Person x, Person y)
        {
            if (x == null && y == null)
                return true;
            if (x == null || y == null)
                return false;
            if (x.Name == y.Name && x.Age == y.Age)
                return true;
            return false;
        }

        public int GetHashCode(Person obj)
        {
            return obj.Name.GetHashCode() + obj.Age.GetHashCode() + 100;
        }
    }

    internal class Person
    {
        public Person()
        {
        }

        public string Name { get; set; }
        public int Age { get; set; }
    }
}