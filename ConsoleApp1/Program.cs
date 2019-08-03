using System;

namespace ConsoleApp1
{
    class Myclass
    {
    }
    class Program
    {


        struct mystruce
        {

        }
        static void Main(string[] args)
        {
            //var s = ConcatOrDefault(1, 2, (x, y) => (x + y).ToString());

            //Console.ReadLine();
            //LimitType(new myclass());

            //LimitTypeInterface(new myclass());

            //LimitTypeStruct(12);

            LimitTypeBaseClassMustDefaultNew(new Myclass());
        }

        public TResult ConcatOrDefault<T, T1, TResult>(T x, T1 y, Func<T, T1, TResult> selector)
        {
            if (x == null || y == null)
                return default(TResult);
            return selector(x, y);
        }

        public static void LimitType<T>(T source) where T : class
        {
        }

        public static void LimitTypeInterface<T>(T source) where T : IComparable
        {
        }
        public static void LimitTypeStruct<T>(T source) where T : struct
        {
        }

        public static void LimitTypeBaseClassMustDefaultNew<T>(T source) where T : Myclass, new()
        {
        }
    }
}
