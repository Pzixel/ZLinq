using System;
using System.Collections.Concurrent;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using JetBrains.Annotations;
using ZLinq.Common;

namespace ZLinq.Console
{
    public class SumParallelismTresholdMap
    {
        [Params(200, 400, 600, 800)]
        public int Treshold { get; set; }

        [Params("Simple", "Complex")]
        public string FuncType { get; set; }

        private int[] _data1;
        private int[] _data2;

        private Func<int, int> _func;

        [Setup]
        public void SetupData()
        {
            _data1 = Enumerable.Range(1, Treshold).ToArray();
            _data2 = Enumerable.Range(1, Treshold).ToArray();
            _func = FuncType == "Simple" ? SimpleFunc : new Func<int, int>(ComplexFunc);
        }

        [Benchmark]
        public object SumParallel()
        {
            return Sum(_data1, _func, true);
        }

        [Benchmark]
        public object SumSequental()
        {
            return Sum(_data2, _func, false);
        }

        private static int SimpleFunc(int arg)
        {
            return arg*arg & byte.MaxValue;
        }

        private static int ComplexFunc(int arg)
        {
            return Fact(arg%50) & byte.MaxValue;
        }

        static int Fact(int n)
        {
            if (n <= 1)
                return 1;
            return n*Fact(n - 1);
        }

        public static int Sum<T>([NotNull] T[] source, [NotNull] Func<T, int> mapFunc, bool parallel)
        {
            if (!parallel)
                return Sum(source, mapFunc, 0, source.Length);
            int result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                             range =>
                             {
                                 var x = Sum(source, mapFunc, range.Item1, range.Item2);
                                 checked
                                 {
                                     lock (syncRoot)
                                         result += x;
                                 }
                             });

            return result;
        }

        [Pure]
        private static int Sum<T>(T[] source, [NotNull] Func<T, int> mapFunc, int startIndex, int endIndex)
        {
            int sum0 = 0;
            int sum1 = 0;
            int sum2 = 0;
            int sum3 = 0;

            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += mapFunc(source[i + 0]);
                    sum1 += mapFunc(source[i + 1]);
                    sum2 += mapFunc(source[i + 2]);
                    sum3 += mapFunc(source[i + 3]);

                }
                if (i == endIndex)
                    return (int) (sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return (int) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]));
                if (i == endIndex - 2)
                    return (int) (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]) + mapFunc(source[i + 1]));
                return
                    (int)
                    (sum0 + sum1 + sum2 + sum3 + mapFunc(source[i]) + mapFunc(source[i + 1]) + mapFunc(source[i + 2]));
            }
        }
    }
}