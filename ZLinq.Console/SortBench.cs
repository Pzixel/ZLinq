using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;

namespace ZLinq.Console
{
    public class SortBench
    {
        private static Random R = new Random();
        private static int[] DataSource = Enumerable.Range(1, 1024*1024*64).Select(x => R.Next()).ToArray();

        private int[] Data1 = new int[DataSource.Length];

        [Setup]
        public void Setup()
        {
            Array.Copy(DataSource, Data1, DataSource.Length);
        }

        [Benchmark]
        public object ParallelSort()
        {
            PartitionSorter.Sort(Data1);
            return Data1;
        }


    public class PartitionSorter
    {
        public static void Sort(int[] arr)
        {
            var ranges = Range.FromArray(arr);
            var allDone = new ManualResetEventSlim(false, ranges.Length*2);
            int completed = 0;
            foreach (var range in ranges)
            {
                ThreadPool.QueueUserWorkItem(r =>
                                                {
                                                    var rr = (Range) r;
                                                    Array.Sort(arr, rr.StartIndex, rr.Length);
                                                    if (Interlocked.Increment(ref completed) == ranges.Length)
                                                        allDone.Set();
                                                }, range);
            }
            allDone.Wait();
            Array.Sort(arr);
        }
    }

    public class Range
    {
        public int StartIndex { get; }
        public int Length { get; }

        public Range(int startIndex, int endIndex)
        {
            StartIndex = startIndex;
            Length = endIndex;
        }

        public static Range[] FromArray<T>(T[] source)
        {
            int processorCount = Environment.ProcessorCount;
            int partitionLength = (int) (source.Length/(double) processorCount);
            var result = new Range[processorCount];
            int start = 0;
            for (int i = 0; i < result.Length - 1; i++)
            {
                result[i] = new Range(start, partitionLength);
                start += partitionLength;
            }
            result[result.Length - 1] = new Range(start, source.Length - start);
            return result;
        }
    }
    }
}
