using System;
using System.Collections.Generic;
using System.Linq;

namespace ToDictionaryComparer
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ToDictionary3();
        }

        private static void ToDictionary3()
        {
            Person[] data1 = {
                new Person() { Name = "code6421", Age = 10,
                    Address = new Address() { City = "Taipei", Detail = "123" } },
                new Person() { Name = "mary", Age = 11 ,
                    Address = new Address() { City = "LA", Detail = "123" } },
                new Person() { Name = "tomm", Age = 12,
                    Address = new Address() { City = "NY", Detail = "123" } }
            };
            var result = data1.ToDictionary((a) => a.Address, new AddressEqualComparer());
            foreach (var item in result)
            {
                Console.WriteLine($"Key : {item.Key.City}, Name :{item.Value.Name}");
            }
        }
    }

    internal class AddressEqualComparer : IEqualityComparer<Address>
    {
        public bool Equals(Address x, Address y)
        {
            if (x == y)
                return true;
            if (x is null || y is null)
                return false;
            if (x.City == y.City && x.Detail == y.Detail)
                return true;
            return false;
        }

        public int GetHashCode(Address obj)
        {
            return obj.City.GetHashCode() + obj.Detail.GetHashCode() + 5;
        }
    }

    internal class Person
    {
        public Person()
        {
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public Address Address { get; set; }
    }

    internal class Address
    {
        public Address()
        {
        }

        public string City { get; set; }
        public string Detail { get; set; }
    }
}