using System;
using System.Linq;

namespace ToDictionary
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ToDictionary();
        }

        private static void ToDictionary()
        {
            Person[] data1 = {
                new Person() { Name = "code6421", Age = 10 },
                new Person() { Name = "mary", Age = 11 },
                new Person() { Name = "mark", Age = 12 }
            };
            var result = data1.ToDictionary((a) => a.Name.Substring(0, 4));
            foreach (var item in result)
            {
                Console.WriteLine($"Key : {item.Key}, Name :{item.Value.Name}");
            }
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