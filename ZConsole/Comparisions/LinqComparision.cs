using System;
using System.Linq;
using BenchmarkDotNet.Attributes;
using ZConsole.Configs;
using ZLinq;

namespace ZConsole.Comparisions
{
    [Config(typeof(X64))]
    public class LinqComparision
    {
        //[Params()]
        public int Length { get; set; } = 1000 * 1000;

        private int[] _data;
        private Tuple<int, int>[] _tuples1;
        private Tuple<int, int>[] _tuples2;
        static Func<int, int> converter = i => (int)(Math.BigMul(int.MaxValue, 100) / 1000);
        static Func<int, bool> predicate = i => (int)(Math.BigMul(int.MaxValue, 100) / 1000) % 3 == 0;
        static Predicate<int> zPredicate = new Predicate<int>(predicate);

        [Setup]
        public void Setup()
        {
            _data = Enumerable.Repeat(1, Length).ToArray();
            _tuples1 = _data.Select(x => new Tuple<int, int>(x / 10, x % 10)).ToArray();
            _tuples2 = _data.Select(x => new Tuple<int, int>(x / 10, x % 10)).ToArray();
        }

        [Benchmark]
        public object SelectLinq()
        {
            return _data.Select(converter).ToArray();
        }

        [Benchmark]
        public object SelectPLinq()
        {
            return _data.AsParallel().Select(converter).ToArray();
        }

        [Benchmark]
        public object SelectZLinq()
        {
            return _data.SelectToArray(converter);
        }

        [Benchmark]
        public object WhereLinq()
        {
            return _data.Where(predicate).ToArray();
        }

        [Benchmark]
        public object WherePLinq()
        {
            return _data.AsParallel().Where(predicate).ToArray();
        }

        [Benchmark]
        public object WhereZLinq()
        {
            return _data.WhereToArray(zPredicate);
        }

        [Benchmark]
        public object OrderByLinq()
        {
            return _tuples2.OrderBy(x => x.Item1).ThenBy(x => x.Item2).ToArray();
        }

        [Benchmark]
        public object OrderByPLinq()
        {
            return _tuples2.AsParallel().OrderBy(x => x.Item1).ThenBy(x => x.Item2).ToArray();
        }

        [Benchmark]
        public object OrderByZLinq()
        {
            _tuples1.OrderByInPlace(x => x.Item1).ThenBy(x => x.Item2).Sort();
            return _tuples1;
        }

        [Benchmark]
        public object MaxLinq()
        {
            return Enumerable.Max(_data);
        }

        [Benchmark]
        public object MaxPLinq()
        {
            return _data.AsParallel().Max();
        }

        [Benchmark]
        public object MaxZLinq()
        {
            return ZEnumerable.Max(_data);
        }

        [Benchmark]
        public object AverageLinq()
        {
            return Enumerable.Average(_data);
        }

        [Benchmark]
        public object AveragePLinq()
        {
            return _data.AsParallel().Average();
        }

        [Benchmark]
        public object AverageZLinq()
        {
            return ZEnumerable.Average(_data);
        }

        [Benchmark]
        public object SumLinq()
        {
            return Enumerable.Sum(_data);
        }

        [Benchmark]
        public object SumPLinq()
        {
            return _data.AsParallel().Sum();
        }

        [Benchmark]
        public object SumZLinq()
        {
            return ZEnumerable.Sum(_data);
        }
    }
}
