using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZLinq.Class;

namespace ZLinq.Test.Core.Common
{
    [TestClass]
    public class OrderByTest
    {
        [TestMethod]
        public void TestWhereInPlaceToArray()
        {
            Test(source => source.ToArray());
        }

        [TestMethod]
        public void TestWhereInPlaceToList()
        {
            Test(source => source.ToList());
        }

        private void Test(Func<IZOrderedEnumerable<Tuple<int, int>>, IList<Tuple<int, int>>> toFunc)
        {
            var source = Enumerable.Range(1, 100).Select(x => new Tuple<int, int>(x / 10, x % 10)).ToArray();

            var linqArr = Enumerable.OrderBy(source, tuple => tuple.Item1).ThenBy(tuple => tuple.Item2).ToArray();
            var zArr = toFunc(ZEnumerable.OrderBy(source, tuple => tuple.Item1).ThenBy(tuple => tuple.Item2));

            Assert.IsTrue(zArr.Count == linqArr.Length);    
            Assert.IsTrue(zArr.SequenceEqual(linqArr));

        }
    }
}
