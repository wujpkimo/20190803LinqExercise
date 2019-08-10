using System;
using System.Linq;

namespace ToLoopUp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            TestLab();
        }

        private static void ToLookup()
        {
            Person[] data1 = {
                new Person() { Name = "code6421", Age = 10 },
                new Person() { Name = "code6423", Age = 10 },
                new Person() { Name = "xxxx", Age = 10 },
                new Person() { Name = "mary", Age = 11 },
                new Person() { Name = "mark", Age = 12 } };
            var result = data1.ToLookup((a) => a.Age);
            foreach (var item in result)
            {
                Console.WriteLine($"---- {item.Key} -----");
                foreach (var detail in item)
                {
                    Console.WriteLine($"---- {detail.Name} -----");
                }
            }
        }

        public static void TestLab()
        {
            var data = new Person[]
            {
                new Person() { Name = "code6421", Age = 10 },
                new Person() { Name = "xxx1", Age = 12 },
                new Person() { Name = "fff1", Age = 13 },
                new Person() { Name = "code6421", Age = 13 },
                new Person() { Name = "code6421", Age = 13 },
                new Person() { Name = "code6421", Age = 14 },
                new Person() { Name = "code6421", Age = 14 }
            };

            var data2 = data
                .ToLookup(a => a.Name[0]);
            //.Select(a => new { FName = a.Name.Substring(0, 1), a.Name, a.Age })

            //foreach (var item in data2.SelectMany(a => a))
            foreach (var item in data2['c'])
            {
                //Console.WriteLine($"-key--- {item.Key} -----");
                //foreach (var detail in item)
                //{
                Console.WriteLine($"---value- {item.Name} {item.Age} -----");
                //}
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