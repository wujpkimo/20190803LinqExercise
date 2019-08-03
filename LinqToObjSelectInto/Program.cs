using System;
using System.Linq;

namespace LinqToObjSelectInto
{
    public class Person2
    {
        public int ID;
        public string Name;
        public int Age;
    }

    internal class Program
    {
        private static void DemoSelectInto()
        {
            Person2[] data1 = {
                new Person2() { ID = 1, Name = "code6421", Age = 10 },
                new Person2() { ID = 2, Name = "mary", Age = 11 },
                new Person2() { ID = 3, Name = "mark", Age = 12 }
            };
            //you want know how many 'a' in the collection
            var result = (from s in data1
                          where s.Name.Contains('a')
                          select s.Name into p
                          from m in p
                          where m == 'a'
                          select m).Count();
            Console.WriteLine(result);
        }

        private static void Main(string[] args)
        {
            DemoSelectInto();
        }
    }
}