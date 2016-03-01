using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using ZConsole.Configs;
using ZConsole.General;
using ZLinq;
using ZLinq.Comparers;

namespace ZConsole.Comparisions
{
    [Config(typeof(X64))]
    public class OrderByMerge
    {
        IComparer<Point> comparer = ZComparer<Point>.New(t => t.X).Add(t => t.Y).ToComparer();
        internal Range[] Ranges;
        public const int N = 1024*1024*64;
        private static readonly Point[] SourceData = Enumerable.Range(1, N).Select(x => new Point(x % 10, x % 397)).ToArray();
        private Point[] _data;
        private Point[] _zdata;
        private Point[] _zdatap;

        [Params(1024, 1024*512, 1024*1024*4, N)]
        public int ArarayLength { get; set; }

        [Setup]
        public void Setup()
        {
            _data = new Point[ArarayLength];
            _zdata = new Point[ArarayLength];
            _zdatap = new Point[ArarayLength];
            Array.Copy(SourceData, _data, ArarayLength);
            Array.Copy(SourceData, _zdata, ArarayLength);
            Array.Copy(SourceData, _zdatap, ArarayLength);

            Ranges = Range.FromArray(_zdatap);
        }

        [Benchmark]
        public object PLinq()
        {
            return _data.AsParallel().OrderBy(tuple => tuple.X).ThenBy(t => t.Y).ToArray();
        }

        [Benchmark]
        public object MergeSort()
        {
            Sort(_zdata, comparer);
            return _zdata;
        }

        [Benchmark]
        public object MergeParallelSort()
        {
            SortParallel(_zdata, comparer);
            return _zdata;
        }

        public void Sort<T>(T[] arr, IComparer<T> comparer)
        {
            ZParallel.Foreach(Ranges, rr => Array.Sort(arr, rr.StartIndex, rr.Length, comparer));
        }

        public void SortParallel<T>(T[] arr, IComparer<T> comparer)
        {
            Parallel.ForEach(Ranges, rr => Array.Sort(arr, rr.StartIndex, rr.Length, comparer));
        }
    }
}
