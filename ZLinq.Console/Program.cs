using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZLinq.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = ZEnumerable.Range(1, 128*1024*1024);

            double res = 0;
            for (int i = 0; i < 100; i++)
            {
                res += arr.Max();
            }
            System.Console.WriteLine(res);
        }
    }
}
