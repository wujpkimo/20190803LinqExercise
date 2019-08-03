using System;
using System.Linq;

namespace LinqToObjectExcept
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Person))
                return false;
            var o = obj as Person;
            if (o.Name == Name && o.Age == Age)
                return true;
            return false;
        }

        public override int GetHashCode()
        {
            int hash = 13 * 7;
            if (Name != null)
                hash += Name.GetHashCode();
            hash += Age.GetHashCode();
            return hash;
        }
    }

    internal class Program
    {
        private static void ExceptWithComplexType()
        {
            Person[] data1 = {
                new Person() { Name = "code6421", Age = 15 },
                new Person() { Name = "mary", Age = 11 },
                new Person() { Name = "jack", Age = 35 } };
            Person[] data2 = {
                new Person() { Name = "mary", Age = 11 },
                new Person() { Name = "jack", Age = 35 } };
            foreach (var item in data1.Except(data2))
            {
                Console.WriteLine(item.Name);
            }
        }

        private static void Main(string[] args)
        {
            ExceptWithComplexType();
        }
    }
}