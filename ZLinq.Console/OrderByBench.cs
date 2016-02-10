using System;
using System.Linq;
using BenchmarkDotNet.Attributes;
using ZLinq.Comparers;

namespace ZLinq.Console
{
    public class OrderByBench
    {
        private const int N = 1024*1024*4;
        private readonly Tuple<int, int>[] _data1 = Enumerable.Range(1, N).Select(x => new Tuple<int, int>(x / 10, x % 10)).ToArray();
        private readonly Tuple<int, int>[] _data2 = Enumerable.Range(1, N).Select(x => new Tuple<int, int>(x / 10, x % 10)).ToArray();

        [Benchmark]
        public object Linq()
        {
            return Enumerable.OrderBy(_data1, tuple => tuple.Item1).ThenBy(t => t.Item2).ToArray();
        }

        [Benchmark]
        public object ZLinq()
        {
            var comparer = ZComparer<Tuple<int, int>>.New(t => t.Item1).Add(t => t.Item2).ToComparer();
            Array.Sort(_data2, comparer);
            return _data2;
        }
    }
}