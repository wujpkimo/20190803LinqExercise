using System;
using System.Linq;

namespace ConsoleApp9
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string[] data = { "aaaa", "bbbb", "cccc" };

            string[] infilter = { "bbbb", "cccc" };
            //var result = from s1 in data
            //             where s1.Contains("b")
            //             select s1;
            var result = data.Where(s1 => infilter.Contains(s1));
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}