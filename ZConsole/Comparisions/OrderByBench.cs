//using System;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.Diagnostics.CodeAnalysis;
//using System.Linq;
//using System.Runtime.CompilerServices;
//using System.Threading.Tasks;
//using BenchmarkDotNet.Attributes;
//using ZConsole.Configs;
//using ZConsole.General;
//using ZLinq;
//using ZLinq.Comparers;

//namespace ZConsole.Comparisions
//{
//    [Config(typeof(X64))]
//    public class OrderByBench
//    {
//        public const int N = 1024 * 512;
//        private static readonly Point[] SourceData = Enumerable.Range(1, N).Select(x => new Point(x % 10, x % 397)).ToArray();
//        private Point[] _data1;
//        private Point[] _data2;
//        private Point[] _data3;

//        [Params(1024, N)]//, 1024*512, 1024*1024*4, N)]
//        public int ArarayLength { get; set; }

//        [Setup]
//        public void Setup()
//        {
//            _data1 = new Point[ArarayLength];
//            _data2 = new Point[ArarayLength];
//            _data3 = new Point[ArarayLength];
//            Array.Copy(SourceData, _data1, ArarayLength);
//            Array.Copy(SourceData, _data2, ArarayLength);
//            Array.Copy(SourceData, _data3, ArarayLength);
//        }

//        [Benchmark]
//        public object PLinq()
//        {
//            return _data1.AsParallel().OrderBy(tuple => tuple.X).ThenBy(t => t.Y)
//                .ToArray();
//        }

//        [Benchmark]
//        public object ZLinq()
//        {
//            var comparer = ZComparer<Point>.New(t => t.X).Add(t => t.Y).ToComparer();
//            Array.Sort(_data2, comparer);
//            return _data2;
//        }

//        [Benchmark]
//        public object ZLinqParallel()
//        {
//            var comparer = ZComparer<Point>.New(t => t.X).Add(t => t.Y).ToComparer();
//            var my = new MySort<Point>(_data3, comparer);
//            my.QuicksortParallelOptimised(0, _data3.Length - 1).GetAwaiter().GetResult();
//            return _data3;
//        }


//        [SuppressMessage("ReSharper", "FieldCanBeMadeReadOnly.Local")]
//        class MySort<T>
//        {
//            private T[] _source;
//            private IComparer<T> _comparer;

//            public MySort(T[] source, IComparer<T> comparer)
//            {
//                _source = source;
//                _comparer = comparer;
//            }

//            public async Task QuicksortParallelOptimised(int left, int right)
//            {
//                int diff = right - left;
//                if (diff < 32)
//                {
//                    InsertionSort(left, right);
//                    return;
//                }

//                int pivot = Partition(_source, left, right);
//                var taskLeft = Task.Run(() => QuicksortParallelOptimised(left, pivot - 1));
//                var taskRight = Task.Run(() => QuicksortParallelOptimised(pivot + 1, right));
//                await Task.WhenAll(taskLeft, taskRight);
//            }

//            [MethodImpl(MethodImplOptions.AggressiveInlining)]
//            private static void Swap(T[] arr, int i, int j)
//            {
//                T tmp = arr[i];
//                arr[i] = arr[j];
//                arr[j] = tmp;
//            }

//            private int Partition(T[] arr, int low, int high)
//            {
//                // Simple partitioning implementation
//                int pivotPos = (high + low) / 2;
//                T pivot = arr[pivotPos];
//                Swap(arr, low, pivotPos);

//                int left = low;
//                for (int i = low + 1; i <= high; i++)
//                {
//                    if (_comparer.Compare(arr[i], pivot) < 0)
//                    {
//                        left++;
//                        Swap(arr, i, left);
//                    }
//                }

//                Swap(arr, low, left);
//                return left;
//            }

//            private void InsertionSort(int startIndex, int endIndex)
//            {
//                for (var counter = startIndex; counter < endIndex; counter++)
//                {
//                    var index = counter + 1;
//                    while (index > startIndex)
//                    {
//                        if (_comparer.Compare(_source[index - 1], _source[index]) > 0)
//                        {
//                            Swap(_source, index - 1, index);
//                        }
//                        index--;
//                    }
//                }
//            }
//        }
//    }
//}