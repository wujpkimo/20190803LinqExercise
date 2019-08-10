using System;
using System.Linq;

namespace Join
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ComplexJoin1();
            //SimpleJoin1();
        }

        private static void SimpleJoin1()
        {
            int[] data1 = { 1, 3, 5, 7, 9 };
            int[] data2 = { 1, 2, 3, 4, 5 };
            var result = from s1 in data1 join s2 in data2 on s1 equals s2 select s1;
            data1.Join(data2, s1 => s1, s2 => s2, (s1, s2) => new { v1 = s1, v2 = s2 });
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        private static void ComplexJoin1()
        {
            var data1 = new Person[]
            {
                new Person(){ name  = "code6421", age = 11 },
                new Person(){ name  = "tome", age = 12 },
                new Person(){ name  = "jeff", age = 13 },
            };

            var data2 = new Person[]
           {
                new Person(){ name  = "mary", age = 12 },
                new Person(){ name  = "jerk", age = 12 },
                new Person(){ name  = "john", age = 13 },
           };

            var r = data1.Join(data2
                , s1 => s1.age
                , s2 => s2.age
                , (s1, s2) =>
                new
                {
                    joinName = s1.name + " " + s2.age,
                    v1 = s1,
                    v2 = s2
                });
            foreach (var item in r)
            {
                Console.WriteLine(item.joinName + " " + item.v1.name + " " + item.v2.name);
            }
        }
    }

    internal class Person
    {
        public Person()
        {
        }

        public string name { get; set; }
        public int age { get; set; }
    }
}