using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using JetBrains.Annotations;
using ZLinq.Common;

namespace ZLinq.Console
{
    public class SumParallelismTreshold
    {
        [Params("Short", "Int", "Long")]
        public string Type
        {
            get { return _testType.ToString(); }
            set { _testType = (TestType) Enum.Parse(typeof(TestType), value); }
        }

        [Params(3000, 5000, 8000, 10000)]
        public int Treshold { get; set; }

        private short[] _data1Short;
        private short[] _data2Short;
        private int[] _data1Int;
        private int[] _data2Int;
        private long[] _data1Long;
        private long[] _data2Long;
        private TestType _testType;

        [Setup]
        public void SetupData()
        {
            _data1Short = Enumerable.Repeat(1, Treshold).Select(x => (short)x).ToArray();
            _data2Short = Enumerable.Repeat(1, Treshold).Select(x => (short)x).ToArray();

            _data1Int = Enumerable.Repeat(1, Treshold).ToArray();
            _data2Int = Enumerable.Repeat(1, Treshold).ToArray();

            _data1Long = Enumerable.Repeat(1, Treshold).Select(x => (long)x).ToArray();
            _data2Long = Enumerable.Repeat(1, Treshold).Select(x => (long)x).ToArray();
        }

        [Benchmark]
        public object SumParallel()
        {
            switch (_testType)
            {
                case TestType.Short:
                    return Sum(_data1Short, true);
                case TestType.Int:
                    return Sum(_data1Int, true);
                case TestType.Long:
                    return Sum(_data1Long, true);
            }
            return null;
        }

        [Benchmark]
        public object SumSequental()
        {
            switch (_testType)
            {
                case TestType.Short:
                    return Sum(_data2Short, false);
                case TestType.Int:
                    return Sum(_data2Int, false);
                case TestType.Long:
                    return Sum(_data2Long, false);
            }
            return null;
        }

        public static short Sum([NotNull] short[] source, bool parallel)
        {
            if (!parallel)
                return Sum(source, 0, source.Length);
            short result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                             range =>
                             {
                                 var x = Sum(source, range.Item1, range.Item2);
                                 checked
                                 {
                                     lock (syncRoot)
                                         result += x;
                                 }
                             });

            return result;
        }

        private static short Sum([NotNull] short[] source, int startIndex, int endIndex)
        {
            short sum0 = 0;
            short sum1 = 0;
            short sum2 = 0;
            short sum3 = 0;

            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += source[i + 0];
                    sum1 += source[i + 1];
                    sum2 += source[i + 2];
                    sum3 += source[i + 3];

                }
                if (i == endIndex)
                    return (short)(sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return (short)(sum0 + sum1 + sum2 + sum3 + source[i]);
                if (i == endIndex - 2)
                    return (short)(sum0 + sum1 + sum2 + sum3 + source[i] + source[i + 1]);
                return (short)(sum0 + sum1 + sum2 + sum3 + source[i] + source[i + 1] + source[i + 2]);
            }
        }

        public static int Sum([NotNull] int[] source, bool parallel)
        {
            if (!parallel)
                return Sum(source, 0, source.Length);
            int result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                             range =>
                             {
                                 var x = Sum(source, range.Item1, range.Item2);
                                 checked
                                 {
                                     lock (syncRoot)
                                         result += x;
                                 }
                             });

            return result;
        }

        private static int Sum([NotNull] int[] source, int startIndex, int endIndex)
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
                    sum0 += source[i + 0];
                    sum1 += source[i + 1];
                    sum2 += source[i + 2];
                    sum3 += source[i + 3];

                }
                if (i == endIndex)
                    return (int)(sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return (int)(sum0 + sum1 + sum2 + sum3 + source[i]);
                if (i == endIndex - 2)
                    return (int)(sum0 + sum1 + sum2 + sum3 + source[i] + source[i + 1]);
                return (int)(sum0 + sum1 + sum2 + sum3 + source[i] + source[i + 1] + source[i + 2]);
            }
        }

        public static long Sum([NotNull] long[] source, bool parallel)
        {
            if (!parallel)
                return Sum(source, 0, source.Length);
            long result = 0;
            object syncRoot = new object();
            Parallel.ForEach(Partitioner.Create(0, source.Length),
                             range =>
                             {
                                 var x = Sum(source, range.Item1, range.Item2);
                                 checked
                                 {
                                     lock (syncRoot)
                                         result += x;
                                 }
                             });

            return result;
        }

        private static long Sum([NotNull] long[] source, int startIndex, int endIndex)
        {
            long sum0 = 0;
            long sum1 = 0;
            long sum2 = 0;
            long sum3 = 0;

            checked
            {
                int i;
                int loopEnd = endIndex - Constants.Step + 1;
                for (i = startIndex; i < loopEnd; i += Constants.Step)
                {
                    sum0 += source[i + 0];
                    sum1 += source[i + 1];
                    sum2 += source[i + 2];
                    sum3 += source[i + 3];

                }
                if (i == endIndex)
                    return (long)(sum0 + sum1 + sum2 + sum3);
                if (i == endIndex - 1)
                    return (long)(sum0 + sum1 + sum2 + sum3 + source[i]);
                if (i == endIndex - 2)
                    return (long)(sum0 + sum1 + sum2 + sum3 + source[i] + source[i + 1]);
                return (long)(sum0 + sum1 + sum2 + sum3 + source[i] + source[i + 1] + source[i + 2]);
            }
        }
    }
}