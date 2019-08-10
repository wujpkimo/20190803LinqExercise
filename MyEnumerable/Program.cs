using System;
using System.Collections;
using System.Linq;

namespace MyEnumerable
{
    internal class Program
    {
        public class MyEnumerable : IEnumerator
        {
            public object Current => throw new NotImplementedException();

            public bool MoveNext()
            {
                throw new NotImplementedException();
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }
        }

        private static void Main(string[] args)
        {
            var data = new int[] { 1, 3, 5, 7, 9 };
            foreach (var item in data.Reverse())
            {
            }
        }
    }
}