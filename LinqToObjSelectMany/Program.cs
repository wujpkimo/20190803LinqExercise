using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqToObjSelectMany
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class Department
    {
        public string Name { get; set; }
        public List<Person> Persons { get; set; }
    }

    internal class Program
    {
        private static void DemoSelectManyV1()
        {
            var dep1 = new Department()
            {
                Name = "IT",
                Persons = new List<Person>() {
                new Person() {Name = "code6421", Age = 10 },
                new Person() {Name = "mary", Age = 11 }
            }
            };
            var dep2 = new Department()
            {
                Name = "RD",
                Persons = new List<Person>() {
                new Person() {Name = "mark", Age = 12 }
            }
            };
            List<Department> deps = new List<Department>() { dep1, dep2 };

            foreach (var item in deps.SelectMany(a => a.Persons, (dep, person) =>
                new
                {
                    DepName = dep.Name,
                    PersonName = person.Name
                }
            ))
            {
                Console.WriteLine(item.DepName + " " + item.PersonName);
            }
        }

        private static void Main(string[] args)
        {
            DemoSelectManyV1();
        }
    }
}