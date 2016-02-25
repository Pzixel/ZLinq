using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using BenchmarkDotNet.Attributes;
using ZLinq.Common;
using ZLinq.Comparers;

namespace ZLinq.Console
{
    [Config(typeof (MyConfig))]
    public class OrderByBench
    {
        struct Point
        {
            public int X { get; }
            public int Y { get; }

            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }
        }

        private const int N = 1024*1024;
        private static readonly Point[] SourceData = Enumerable.Range(1, N).Select(x => new Point(x % 10, x % 397)).ToArray();
        private Point[] _data1 = new Point[SourceData.Length];
        private Point[] _data2 = new Point[SourceData.Length];
        private Point[] _data3 = new Point[SourceData.Length];

        [Setup]
        public void Setup()
        {
            Array.Copy(SourceData, _data1, SourceData.Length);
            Array.Copy(SourceData, _data2, SourceData.Length);
            Array.Copy(SourceData, _data3, SourceData.Length);
        }

        [Benchmark]
        public object PLinq()
        {
            return _data1.AsParallel().OrderBy(tuple => tuple.X).ThenBy(t => t.Y).ToArray();
        }

        [Benchmark]
        public object ZLinq()
        {
            var comparer = ZComparer<Point>.New(t => t.X).Add(t => t.Y).ToComparer();
            Array.Sort(_data2, comparer);
            return _data2;
        }

        [Benchmark]
        public object ZLinqParallel()
        {
            var comparer = ZComparer<Point>.New(t => t.X).Add(t => t.Y).ToComparer();
            var my = new MySort<Point>(comparer);
            my.QuicksortParallelOptimised(_data3, 0, _data3.Length - 1);
            return _data3;
        }


        class MySort<T>
        {
            private IComparer<T> _comparer;

            public MySort(IComparer<T> comparer)
            {
                _comparer = comparer;
            }

            public void QuicksortParallelOptimised(T[] arr, int left, int right)
            {
                if (right - left < Constants.SingleThreadExecutionThreshold)
                {
                    Array.Sort(arr, left, right - left + 1, _comparer);
                    return;
                }

                int pivot = Partition(arr, left, right);
                var mseLeft = new ManualResetEventSlim(false);
                var mseRight = new ManualResetEventSlim(false);
                int newRight = pivot - 1;
                bool leftStarted = newRight > left;
                if (leftStarted)
                {
                    ThreadPool.QueueUserWorkItem(mse =>
                                                 {
                                                     QuicksortParallelOptimised(arr, left, newRight);
                                                     ((ManualResetEventSlim)mse).Set();
                                                 }, mseLeft);
                }
                int newLeft = pivot + 1;
                bool rightStarted = right > newLeft;
                if (rightStarted)
                {
                    ThreadPool.QueueUserWorkItem(mse =>
                                                 {
                                                     QuicksortParallelOptimised(arr, newLeft, right);
                                                     ((ManualResetEventSlim)mse).Set();
                                                 }, mseRight);
                }
                if (leftStarted)
                {
                    mseLeft.Wait();
                }
                if (rightStarted)
                {
                    mseRight.Wait();
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            private static void Swap(T[] arr, int i, int j)
            {
                T tmp = arr[i];
                arr[i] = arr[j];
                arr[j] = tmp;
            }

            private int Partition(T[] arr, int low, int high)
            {
                // Simple partitioning implementation
                int pivotPos = (high + low) / 2;
                T pivot = arr[pivotPos];
                Swap(arr, low, pivotPos);

                int left = low;
                for (int i = low + 1; i <= high; i++)
                {
                    if (_comparer.Compare(arr[i], pivot) < 0)
                    {
                        left++;
                        Swap(arr, i, left);
                    }
                }

                Swap(arr, low, left);
                return left;
            }
        }
    }
}