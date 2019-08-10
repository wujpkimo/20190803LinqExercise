using System;
using System.Linq;

namespace ConsoleApp12
{
    //程式執行成本的差異
    //多層linq or 單層linq差異(多次deleget)
    //原因：linq為延遲執行
    internal class Program
    {
        private static void Main(string[] args)
        {
            var data = new int[] { 1, 3, 5, 7, 9 };
            var d2 = data.Where(a => a > 3);
            var result = from s in d2
                         where s > 9
                         select s;
            var result2 = data.Where(a => a > 3 && a > 9);
            foreach (var item in result)
            {
            }
            //若要執行多次，先tolist取得凍結結果，才不會多次執行where
        }
    }
}