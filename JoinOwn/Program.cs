using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace JoinOwn
{
    internal static class MyHelper
    {
        /// <summary>
        /// 自行撰寫join
        /// </summary>
        /// <typeparam name="TInner">來源泛型</typeparam>
        /// <typeparam name="TOuter">join泛型</typeparam>
        /// <typeparam name="TKey">key</typeparam>
        /// <typeparam name="TResult">輸出泛型</typeparam>
        /// <param name="inner">來源</param>
        /// <param name="outer">join</param>
        /// <param name="innerKeySelector">來源key</param>
        /// <param name="outerKeySelector">join key</param>
        /// <param name="resultSelector">輸出欄位</param>
        /// <returns></returns>
        public static IEnumerable<TResult> MyJoin<TInner, TOuter, TKey, TResult>(this IEnumerable<TInner> inner
            , IEnumerable<TOuter> outer
            , Func<TInner, TKey> innerKeySelector
            , Func<TOuter, TKey> outerKeySelector
            , Func<TInner, TOuter, TResult> resultSelector)
        {
            foreach (var innerItem in inner)
            {
                var key = innerKeySelector(innerItem);
                foreach (var outerItem in outer)
                {
                    if (key.Equals(outerKeySelector(outerItem)))
                        yield return resultSelector(innerItem, outerItem);
                }
            }
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            JoinVer2();
        }

        private static void JoinVer2()
        {
            Department[] deps ={
                new Department() { ID = 1, Name = "Developer" },
                new Department() { ID = 2, Name = "Sales" },
                new Department() { ID = 3, Name = "Support" }
            };
            Employee[] emps = {
                new Employee() { ID = 1, Name = "code6421", Department_ID = 1 },
                new Employee() { ID = 1, Name = "tom", Department_ID = 1 },
                new Employee() { ID = 1, Name = "mary", Department_ID = 2 },
                new Employee() { ID = 1, Name = "jack", Department_ID = 2 },
            };
            var result = emps.MyJoin(deps, (a) => a.Department_ID, (b) => b.ID, (a, b) =>
            new
            {
                EmployeeID = a.ID,
                DepartmentName = b.Name,
                EmployeeName = a.Name
            });
            var result1 = emps.Join(deps, (a) => a.Department_ID, (b) => b.ID, (a, b) =>
           new
           {
               EmployeeID = a.ID,
               DepartmentName = b.Name,
               EmployeeName = a.Name
           });
            foreach (var item in result)
            {
                Console.WriteLine($"Name : {item.EmployeeName}, Department: {item.DepartmentName}");
            }
        }
    }

    internal class Employee
    {
        public Employee()
        {
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public int Department_ID { get; set; }
    }

    internal class Department
    {
        public Department()
        {
        }

        public int ID { get; set; }
        public string Name { get; set; }
    }
}