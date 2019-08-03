using System;
using System.IO;
using System.Linq;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = from s1 in Directory.GetFiles(@"C:\\Windows")
                         where s1.EndsWith(".exe")
                         select s1;
            Console.WriteLine(result.FirstOrDefault());
        }
    }
}
