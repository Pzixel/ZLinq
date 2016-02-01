
using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZLinq.Test.Helpers;

namespace ZLinq.Test.Core.Fold
{
    [TestClass]
    public class Single
    {	
				
		[TestMethod]
        public void SingleArray()
        {
            var x = Enumerable.Range(1, 1).ToArray();
            var y = Enumerable.Range(1, 1).Select(a => new Tuple<int, int>(a,a)).ToArray();
            var z = Enumerable.Range(1, 1).Select(a => new { A = a}).ToArray();

            Assert.IsTrue(ZEnumerable.Single(x) == Enumerable.Single(x));
			Assert.IsTrue(ZEnumerable.Single(y) == Enumerable.Single(y));
			Assert.IsTrue(ZEnumerable.Single(z) == Enumerable.Single(z));
        }

		[TestMethod]
        public void SingleArrayOrDefault()
        {
            var x = Enumerable.Range(1, 1).ToArray();
            var y = Enumerable.Range(1, 1).Select(a => new Tuple<int, int>(a,a)).ToArray();
            var z = new int[0].ToArray();

            Assert.IsTrue(ZEnumerable.SingleOrDefault(x) == Enumerable.SingleOrDefault(x));
            Assert.IsTrue(ZEnumerable.SingleOrDefault(y) == Enumerable.SingleOrDefault(y));
            Assert.IsTrue(ZEnumerable.SingleOrDefault(z) == Enumerable.SingleOrDefault(z));
        }

		[TestMethod]
        public void SingleArrayPredicate()
        {
            var x = Enumerable.Range(1, 5).ToArray();
            var y = Enumerable.Range(1, 5).Select(a => new Tuple<int, int>(a,a)).ToArray();
            var z = Enumerable.Range(1, 5).Select(a => new { A = a}).ToArray();

            Assert.IsTrue(ZEnumerable.Single(x, val => val%3 == 0) == Enumerable.Single(x, val => val%3 == 0));
			Assert.IsTrue(ZEnumerable.Single(y, val => val.Item1%3 == 0) == Enumerable.Single(y, val => val.Item1%3 == 0));
			Assert.IsTrue(ZEnumerable.Single(z, val => val.A%3 == 0) == Enumerable.Single(z, val => val.A%3 == 0));
        }

		[TestMethod]
        public void SingleArrayOrDefaultPredicate()
        {
            var x = Enumerable.Range(1, 5).ToArray();
            var y = Enumerable.Range(1, 5).Select(a => new Tuple<int, int>(a,a)).ToArray();
            var z = new int[0].ToArray();

            Assert.IsTrue(ZEnumerable.SingleOrDefault(x, val => val%3 == 0) == Enumerable.SingleOrDefault(x, val => val%3 == 0));
            Assert.IsTrue(ZEnumerable.SingleOrDefault(y, val => val.Item1%3 == 0) == Enumerable.SingleOrDefault(y, val => val.Item1%3 == 0));
            Assert.IsTrue(ZEnumerable.SingleOrDefault(z, val => val%3 == 0) == Enumerable.SingleOrDefault(z, val => val%3 == 0));
        }

				
		[TestMethod]
        public void SingleList()
        {
            var x = Enumerable.Range(1, 1).ToList();
            var y = Enumerable.Range(1, 1).Select(a => new Tuple<int, int>(a,a)).ToList();
            var z = Enumerable.Range(1, 1).Select(a => new { A = a}).ToList();

            Assert.IsTrue(ZEnumerable.Single(x) == Enumerable.Single(x));
			Assert.IsTrue(ZEnumerable.Single(y) == Enumerable.Single(y));
			Assert.IsTrue(ZEnumerable.Single(z) == Enumerable.Single(z));
        }

		[TestMethod]
        public void SingleListOrDefault()
        {
            var x = Enumerable.Range(1, 1).ToList();
            var y = Enumerable.Range(1, 1).Select(a => new Tuple<int, int>(a,a)).ToList();
            var z = new int[0].ToList();

            Assert.IsTrue(ZEnumerable.SingleOrDefault(x) == Enumerable.SingleOrDefault(x));
            Assert.IsTrue(ZEnumerable.SingleOrDefault(y) == Enumerable.SingleOrDefault(y));
            Assert.IsTrue(ZEnumerable.SingleOrDefault(z) == Enumerable.SingleOrDefault(z));
        }

		[TestMethod]
        public void SingleListPredicate()
        {
            var x = Enumerable.Range(1, 5).ToList();
            var y = Enumerable.Range(1, 5).Select(a => new Tuple<int, int>(a,a)).ToList();
            var z = Enumerable.Range(1, 5).Select(a => new { A = a}).ToList();

            Assert.IsTrue(ZEnumerable.Single(x, val => val%3 == 0) == Enumerable.Single(x, val => val%3 == 0));
			Assert.IsTrue(ZEnumerable.Single(y, val => val.Item1%3 == 0) == Enumerable.Single(y, val => val.Item1%3 == 0));
			Assert.IsTrue(ZEnumerable.Single(z, val => val.A%3 == 0) == Enumerable.Single(z, val => val.A%3 == 0));
        }

		[TestMethod]
        public void SingleListOrDefaultPredicate()
        {
            var x = Enumerable.Range(1, 5).ToList();
            var y = Enumerable.Range(1, 5).Select(a => new Tuple<int, int>(a,a)).ToList();
            var z = new int[0].ToList();

            Assert.IsTrue(ZEnumerable.SingleOrDefault(x, val => val%3 == 0) == Enumerable.SingleOrDefault(x, val => val%3 == 0));
            Assert.IsTrue(ZEnumerable.SingleOrDefault(y, val => val.Item1%3 == 0) == Enumerable.SingleOrDefault(y, val => val.Item1%3 == 0));
            Assert.IsTrue(ZEnumerable.SingleOrDefault(z, val => val%3 == 0) == Enumerable.SingleOrDefault(z, val => val%3 == 0));
        }

				
		[TestMethod]
        public void SingleIList()
        {
            var x = Enumerable.Range(1, 1).ToIList();
            var y = Enumerable.Range(1, 1).Select(a => new Tuple<int, int>(a,a)).ToIList();
            var z = Enumerable.Range(1, 1).Select(a => new { A = a}).ToIList();

            Assert.IsTrue(ZEnumerable.Single(x) == Enumerable.Single(x));
			Assert.IsTrue(ZEnumerable.Single(y) == Enumerable.Single(y));
			Assert.IsTrue(ZEnumerable.Single(z) == Enumerable.Single(z));
        }

		[TestMethod]
        public void SingleIListOrDefault()
        {
            var x = Enumerable.Range(1, 1).ToIList();
            var y = Enumerable.Range(1, 1).Select(a => new Tuple<int, int>(a,a)).ToIList();
            var z = new int[0].ToIList();

            Assert.IsTrue(ZEnumerable.SingleOrDefault(x) == Enumerable.SingleOrDefault(x));
            Assert.IsTrue(ZEnumerable.SingleOrDefault(y) == Enumerable.SingleOrDefault(y));
            Assert.IsTrue(ZEnumerable.SingleOrDefault(z) == Enumerable.SingleOrDefault(z));
        }

		[TestMethod]
        public void SingleIListPredicate()
        {
            var x = Enumerable.Range(1, 5).ToIList();
            var y = Enumerable.Range(1, 5).Select(a => new Tuple<int, int>(a,a)).ToIList();
            var z = Enumerable.Range(1, 5).Select(a => new { A = a}).ToIList();

            Assert.IsTrue(ZEnumerable.Single(x, val => val%3 == 0) == Enumerable.Single(x, val => val%3 == 0));
			Assert.IsTrue(ZEnumerable.Single(y, val => val.Item1%3 == 0) == Enumerable.Single(y, val => val.Item1%3 == 0));
			Assert.IsTrue(ZEnumerable.Single(z, val => val.A%3 == 0) == Enumerable.Single(z, val => val.A%3 == 0));
        }

		[TestMethod]
        public void SingleIListOrDefaultPredicate()
        {
            var x = Enumerable.Range(1, 5).ToIList();
            var y = Enumerable.Range(1, 5).Select(a => new Tuple<int, int>(a,a)).ToIList();
            var z = new int[0].ToIList();

            Assert.IsTrue(ZEnumerable.SingleOrDefault(x, val => val%3 == 0) == Enumerable.SingleOrDefault(x, val => val%3 == 0));
            Assert.IsTrue(ZEnumerable.SingleOrDefault(y, val => val.Item1%3 == 0) == Enumerable.SingleOrDefault(y, val => val.Item1%3 == 0));
            Assert.IsTrue(ZEnumerable.SingleOrDefault(z, val => val%3 == 0) == Enumerable.SingleOrDefault(z, val => val%3 == 0));
        }

				
		[TestMethod]
        public void SingleICollection()
        {
            var x = Enumerable.Range(1, 1).ToICollection();
            var y = Enumerable.Range(1, 1).Select(a => new Tuple<int, int>(a,a)).ToICollection();
            var z = Enumerable.Range(1, 1).Select(a => new { A = a}).ToICollection();

            Assert.IsTrue(ZEnumerable.Single(x) == Enumerable.Single(x));
			Assert.IsTrue(ZEnumerable.Single(y) == Enumerable.Single(y));
			Assert.IsTrue(ZEnumerable.Single(z) == Enumerable.Single(z));
        }

		[TestMethod]
        public void SingleICollectionOrDefault()
        {
            var x = Enumerable.Range(1, 1).ToICollection();
            var y = Enumerable.Range(1, 1).Select(a => new Tuple<int, int>(a,a)).ToICollection();
            var z = new int[0].ToICollection();

            Assert.IsTrue(ZEnumerable.SingleOrDefault(x) == Enumerable.SingleOrDefault(x));
            Assert.IsTrue(ZEnumerable.SingleOrDefault(y) == Enumerable.SingleOrDefault(y));
            Assert.IsTrue(ZEnumerable.SingleOrDefault(z) == Enumerable.SingleOrDefault(z));
        }

		[TestMethod]
        public void SingleICollectionPredicate()
        {
            var x = Enumerable.Range(1, 5).ToICollection();
            var y = Enumerable.Range(1, 5).Select(a => new Tuple<int, int>(a,a)).ToICollection();
            var z = Enumerable.Range(1, 5).Select(a => new { A = a}).ToICollection();

            Assert.IsTrue(ZEnumerable.Single(x, val => val%3 == 0) == Enumerable.Single(x, val => val%3 == 0));
			Assert.IsTrue(ZEnumerable.Single(y, val => val.Item1%3 == 0) == Enumerable.Single(y, val => val.Item1%3 == 0));
			Assert.IsTrue(ZEnumerable.Single(z, val => val.A%3 == 0) == Enumerable.Single(z, val => val.A%3 == 0));
        }

		[TestMethod]
        public void SingleICollectionOrDefaultPredicate()
        {
            var x = Enumerable.Range(1, 5).ToICollection();
            var y = Enumerable.Range(1, 5).Select(a => new Tuple<int, int>(a,a)).ToICollection();
            var z = new int[0].ToICollection();

            Assert.IsTrue(ZEnumerable.SingleOrDefault(x, val => val%3 == 0) == Enumerable.SingleOrDefault(x, val => val%3 == 0));
            Assert.IsTrue(ZEnumerable.SingleOrDefault(y, val => val.Item1%3 == 0) == Enumerable.SingleOrDefault(y, val => val.Item1%3 == 0));
            Assert.IsTrue(ZEnumerable.SingleOrDefault(z, val => val%3 == 0) == Enumerable.SingleOrDefault(z, val => val%3 == 0));
        }

			


    }
}
