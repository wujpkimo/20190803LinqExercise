using System;
using System.IO;
using System.Linq;

namespace FindInFiles
{
    internal class Program
    {
        private static void FindAllInFiles()
        {
            var result = from s1 in Directory.GetFiles(@"C:\Windows", "*.ini")
                         let content = File.ReadAllText(s1)
                         where content.Contains("drivers")
                         select s1;
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        private static void Main(string[] args)
        {
            FindAllInFiles();
        }
    }
}