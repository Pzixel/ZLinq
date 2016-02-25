using BenchmarkDotNet.Running;

namespace ZLinq.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //var summary = BenchmarkRunner.Run<OrderByBench>();
            System.Console.WriteLine(new OrderByBench().ZLinqParallel());
        }
    }


}
