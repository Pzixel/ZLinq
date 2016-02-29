using BenchmarkDotNet.Running;
using ZConsole.ParallelismTreshold;

namespace ZConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<Sum>();
        }
    }
}
