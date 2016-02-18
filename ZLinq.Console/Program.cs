using System;
using System.Collections.Generic;
using BenchmarkDotNet.Running;
using System.Linq;

namespace ZLinq.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //var summary = BenchmarkRunner.Run<OrderByBench>();

            double[] arr = {double.MaxValue, double.MaxValue};
            var average = Enumerable.Average(arr);
            System.Console.WriteLine(double.PositiveInfinity + double.NegativeInfinity);
            System.Console.WriteLine(DateTime.Now.ToString("O"));
        }

        static T FirstOrDefault<T>(IEnumerable<T> source)
        {
            if (source == null)
                return default(T);
            using (var enumer = source.GetEnumerator())
            {
                enumer.MoveNext();
                return enumer.Current;
            }
        }
    }
}
