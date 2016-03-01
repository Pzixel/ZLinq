using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using JetBrains.Annotations;
using ZConsole.General;
using ZLinq.Common;

namespace ZConsole.ParallelismTreshold
{
    public class Select
    {
        [Params("Short", "Int", "Long")]
        public string Type
        {
            get { return _testType.ToString(); }
            set { _testType = (TestType)Enum.Parse(typeof(TestType), value); }
        }

        [Params(3000, 5000, 8000, 10000)]
        public int Treshold { get; set; }

        [Params("Simple", "Complex")]
        public string FuncType { get; set; }

        private short[] _data1Short;
        private short[] _data2Short;
        private int[] _data1Int;
        private int[] _data2Int;
        private long[] _data1Long;
        private long[] _data2Long;
        private TestType _testType;

        private Func<short, short> _func1;
        private Func<int, int> _func2;
        private Func<long, long> _func3;

        [Setup]
        public void SetupData()
        {
            _data1Short = Enumerable.Repeat(1, Treshold).Select(x => (short)x).ToArray();
            _data2Short = Enumerable.Repeat(1, Treshold).Select(x => (short)x).ToArray();

            _data1Int = Enumerable.Repeat(1, Treshold).ToArray();
            _data2Int = Enumerable.Repeat(1, Treshold).ToArray();

            _data1Long = Enumerable.Repeat(1, Treshold).Select(x => (long)x).ToArray();
            _data2Long = Enumerable.Repeat(1, Treshold).Select(x => (long)x).ToArray();

            _func1 = FuncType == "Simple" ? (arg => (short)(arg * arg & byte.MaxValue)) : new Func<short, short>(arg1 => (short)(Fact(arg1 % 50) & byte.MaxValue));
            _func2 = FuncType == "Simple" ? (arg => arg * arg & byte.MaxValue) : new Func<int, int>(arg1 => Fact(arg1 % 50) & byte.MaxValue);
            _func3 = FuncType == "Simple" ? (arg => arg * arg & byte.MaxValue) : new Func<long, long>(arg1 => Fact((int)(arg1 % 50)) & byte.MaxValue);
        }

        [Benchmark]
        public object SelectParallel()
        {
            switch (_testType)
            {
                case TestType.Short:
                    return SelectToArray(_data1Short, _func1, true);
                case TestType.Int:
                    return SelectToArray(_data1Int, _func2, true);
                case TestType.Long:
                    return SelectToArray(_data1Long, _func3, true);
            }
            return null;
        }

        [Benchmark]
        public object SelectSequental()
        {
            switch (_testType)
            {
                case TestType.Short:
                    return SelectToArray(_data2Short, _func1, false);
                case TestType.Int:
                    return SelectToArray(_data2Int, _func2, false);
                case TestType.Long:
                    return SelectToArray(_data2Long, _func3, false);
            }
            return null;
        }

        public static TResult[] SelectToArray<T, TResult>([NotNull] T[] source, [NotNull] Func<T, TResult> func, bool parallel)
        {
            var result = new TResult[source.Length];
            if (parallel)
            {
                Parallel.ForEach(Partitioner.Create(0, source.Length),
                                 range => { SelectToArray(source, result, func, range.Item1, range.Item2); });
            }
            else
            {
                SelectToArray(source, result, func, 0, result.Length);
            }
            return result;
        }

        public static void SelectToArray<T, TResult>(T[] source, TResult[] result, [NotNull] Func<T, TResult> func, int start, int end)
        {
            int i;
            for (i = start; i < end - Constants.Step + 1; i += Constants.Step)
            {
                result[i] = func(source[i]);
                result[i + 1] = func(source[i + 1]);
                result[i + 2] = func(source[i + 2]);
                result[i + 3] = func(source[i + 3]);
            }

            if (i <= end - 1)
            {
                if (i <= end - 2)
                {
                    if (i <= end - 3)
                    {
                        result[end - 3] = func(source[end - 3]);
                    }
                    result[end - 2] = func(source[end - 2]);
                }
                result[end - 1] = func(source[end - 1]);
            }
        }

        static int Fact(int n)
        {
            if (n <= 1)
                return 1;
            return n * Fact(n - 1);
        }
    }
}
