
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ZLinq.Test.Core.Common
{
    [TestClass]
    public class Where
    {        
                    
        [TestMethod]
        public void TestWhereToArrayArray()
        {
            var source = (int[]) Enumerable.Range(1, 100).ToArray();

            var xArr = source.WhereToArray(x => x%3 == 0);
            var linqArr = source.Where(x => x%3 == 0).ToArray();

            Assert.IsTrue(xArr.Length == linqArr.Length);
            Assert.IsTrue(xArr.SequenceEqual(linqArr));
        }

        [TestMethod]
        public void TestWhereToListArray()
        {
            var source = (int[]) Enumerable.Range(1, 100).ToArray();

            var xArr = source.WhereToList(x => x%3 == 0);
            var linqArr = source.Where(x => x%3 == 0).ToList();

            Assert.IsTrue(xArr.Count == linqArr.Count);
            Assert.IsTrue(xArr.SequenceEqual(linqArr));
        }
                    
        [TestMethod]
        public void TestWhereToArrayList()
        {
            var source = (List<int>) Enumerable.Range(1, 100).ToList();

            var xArr = source.WhereToArray(x => x%3 == 0);
            var linqArr = source.Where(x => x%3 == 0).ToArray();

            Assert.IsTrue(xArr.Length == linqArr.Length);
            Assert.IsTrue(xArr.SequenceEqual(linqArr));
        }

        [TestMethod]
        public void TestWhereToListList()
        {
            var source = (List<int>) Enumerable.Range(1, 100).ToList();

            var xArr = source.WhereToList(x => x%3 == 0);
            var linqArr = source.Where(x => x%3 == 0).ToList();

            Assert.IsTrue(xArr.Count == linqArr.Count);
            Assert.IsTrue(xArr.SequenceEqual(linqArr));
        }
                    
        [TestMethod]
        public void TestWhereToArrayIList()
        {
            var source = (IList<int>) Enumerable.Range(1, 100).ToList();

            var xArr = source.WhereToArray(x => x%3 == 0);
            var linqArr = source.Where(x => x%3 == 0).ToArray();

            Assert.IsTrue(xArr.Length == linqArr.Length);
            Assert.IsTrue(xArr.SequenceEqual(linqArr));
        }

        [TestMethod]
        public void TestWhereToListIList()
        {
            var source = (IList<int>) Enumerable.Range(1, 100).ToList();

            var xArr = source.WhereToList(x => x%3 == 0);
            var linqArr = source.Where(x => x%3 == 0).ToList();

            Assert.IsTrue(xArr.Count == linqArr.Count);
            Assert.IsTrue(xArr.SequenceEqual(linqArr));
        }
                    
        [TestMethod]
        public void TestWhereToArrayICollection()
        {
            var source = (ICollection<int>) Enumerable.Range(1, 100).ToList();

            var xArr = source.WhereToArray(x => x%3 == 0);
            var linqArr = source.Where(x => x%3 == 0).ToArray();

            Assert.IsTrue(xArr.Length == linqArr.Length);
            Assert.IsTrue(xArr.SequenceEqual(linqArr));
        }

        [TestMethod]
        public void TestWhereToListICollection()
        {
            var source = (ICollection<int>) Enumerable.Range(1, 100).ToList();

            var xArr = source.WhereToList(x => x%3 == 0);
            var linqArr = source.Where(x => x%3 == 0).ToList();

            Assert.IsTrue(xArr.Count == linqArr.Count);
            Assert.IsTrue(xArr.SequenceEqual(linqArr));
        }
            }
}
