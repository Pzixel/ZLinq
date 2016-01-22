using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ZLinq.Test.Core
{
    [TestClass]
    public class WhereInPlaceTest
    {
        [TestMethod]
        public void TestWhereInPlaceToArray()
        {
            var source = Enumerable.Range(1, 100).ToArray();

            var linqArr = source.Where(x => x % 3 == 0).ToArray();
            ZEnumerable.WhereInPlace(ref source, x => x % 3 == 0);

            Assert.IsTrue(source.Length == linqArr.Length);
            Assert.IsTrue(source.SequenceEqual(linqArr));
        }

        [TestMethod]
        public void TestWhereInPlaceToList()
        {
            var source = Enumerable.Range(1, 100).ToList();

            var linqArr = source.Where(x => x % 3 == 0).ToArray();
            source.WhereInPlace(x => x % 3 == 0);

            Assert.IsTrue(source.Count == linqArr.Length);
            Assert.IsTrue(source.SequenceEqual(linqArr));
        }

        [TestMethod]
        public void TestWhereInPlaceToIList()
        {
            var source = (IList<int>) Enumerable.Range(1, 100).ToList();

            var linqArr = source.Where(x => x % 3 == 0).ToArray();
            source.WhereInPlace(x => x % 3 == 0);

            Assert.IsTrue(source.Count == linqArr.Length);
            Assert.IsTrue(source.SequenceEqual(linqArr));
        }
    }
}
