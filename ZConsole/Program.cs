using System;
using System.Collections;
using System.Collections.Generic;
using BenchmarkDotNet.Running;
using ZConsole.Comparisions;
using ZConsole.General;
using ZLinq;

namespace ZConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<OrderByMerge>();
            //Test();
        }

        private static void Test()
        {
            var r = new Random(10);
            int[] arr = r.Repeat(1024*1024*128);
           // Console.WriteLine(arr.ToStr());
            var orderByMerge = new OrderByMerge {Ranges = Range.FromArray(arr)};
            orderByMerge.Sort(arr, MyComparer<int>.Default);
            Console.WriteLine(arr[0]);
            //Console.WriteLine(arr.ToStr());
        }
    }

    class MyComparer<T> : IComparer<T> where T : IComparable<T>
    {
        public static readonly MyComparer<T> Default = new MyComparer<T>();

        public int Compare(T x, T y)
        {
            return x.CompareTo(y);
        }
    }
}
