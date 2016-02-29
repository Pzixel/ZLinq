using System;
using System.Threading;
using BenchmarkDotNet.Running;

namespace ZLinq.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //     var summary = BenchmarkRunner.Run<OrderByBench>();
               var orderByBench = new OrderByBench {ArarayLength = OrderByBench.N};
               orderByBench.Setup();
                 System.Console.WriteLine(orderByBench.ZLinqParallel());
        }
    }


}
