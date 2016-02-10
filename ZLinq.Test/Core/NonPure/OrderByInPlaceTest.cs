using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ZLinq.Test.Core.NonPure
{
    [TestClass]
    public class OrderByTest
    {
        
        [TestMethod]
        public void TestWhereInPlaceToArray()
        {
            var source = Enumerable.Range(1, 100).Select(x => new Tuple<int, int>(x / 10, x % 10)).ToArray();
            var zArr = (Tuple<int, int>[]) source.Clone();

            var linqArr = Enumerable.OrderBy(source, tuple => tuple.Item2).ThenBy(tuple => tuple.Item1).ToArray();
            zArr.OrderByInPlace(tuple => tuple.Item2).ThenBy(tuple => tuple.Item1).Sort();

            Assert.IsTrue(zArr.Length == linqArr.Length);
            Assert.IsTrue(zArr.SequenceEqual(linqArr));
        }

        [TestMethod]
        public void TestWhereInPlaceToList()
        {
            var source = Enumerable.Range(1, 100).Select(x => new Tuple<int, int>(x / 10, x % 10)).ToList();
            var zArr = source.ToList();

            var linqArr = Enumerable.OrderBy(source, tuple => tuple.Item2).ThenBy(tuple => tuple.Item1).ToList();
            zArr.OrderByInPlace(tuple => tuple.Item2).ThenBy(tuple => tuple.Item1).Sort();

            Assert.IsTrue(zArr.Count == linqArr.Count);
            Assert.IsTrue(zArr.SequenceEqual(linqArr));
        }
        
        [TestMethod]
        public void TestWhereInPlaceToArrayDescending()
        {
            var source = Enumerable.Range(1, 100).Select(x => new Tuple<int, int>(x / 10, x % 10)).ToArray();
            var zArr = (Tuple<int, int>[]) source.Clone();

            var linqArr = Enumerable.OrderByDescending(source, tuple => tuple.Item2).ThenByDescending(tuple => tuple.Item1).ToArray();
            zArr.OrderByInPlaceDescending(tuple => tuple.Item2).ThenByDescending(tuple => tuple.Item1).Sort();

            Assert.IsTrue(zArr.Length == linqArr.Length);
            Assert.IsTrue(zArr.SequenceEqual(linqArr));
        }

        [TestMethod]
        public void TestWhereInPlaceToListDescending()
        {
            var source = Enumerable.Range(1, 100).Select(x => new Tuple<int, int>(x / 10, x % 10)).ToList();
            var zArr = source.ToList();

            var linqArr = Enumerable.OrderByDescending(source, tuple => tuple.Item2).ThenByDescending(tuple => tuple.Item1).ToList();
            zArr.OrderByInPlaceDescending(tuple => tuple.Item2).ThenByDescending(tuple => tuple.Item1).Sort();

            Assert.IsTrue(zArr.Count == linqArr.Count);
            Assert.IsTrue(zArr.SequenceEqual(linqArr));
        }
        
    }
}
