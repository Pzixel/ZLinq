using System;
using System.Linq;
using BenchmarkDotNet.Attributes;
using ZConsole.Configs;
using ZLinq;

namespace ZConsole.Comparisions
{
    [Config(typeof(X64))]
    public class SelectBench
    {
        private const int N = 1024 * 1024 * 4;
        private readonly Tuple<int, int>[] _data1 = Enumerable.Range(1, N).Select(x => new Tuple<int, int>(x / 10, x % 10)).ToArray();
        private readonly Tuple<int, int>[] _data2 = Enumerable.Range(1, N).Select(x => new Tuple<int, int>(x / 10, x % 10)).ToArray();

        [Benchmark]
        public object Linq()
        {
            return _data1.Select(tuple => tuple.Item1 * tuple.Item2).ToArray();
        }

        [Benchmark]
        public object ZLinq()
        {
            return _data2.SelectToArray(tuple => tuple.Item1 * tuple.Item2);
        }
    }
}
