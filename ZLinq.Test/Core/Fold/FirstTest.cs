
using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZLinq.Test.Helpers;

namespace ZLinq.Test.Core.Fold
{
    [TestClass]
    public class First
    {	
				
		[TestMethod]
        public void FirstArray()
        {
            var x = Enumerable.Range(1, 1024).ToArray();
            var y = Enumerable.Range(1, 1024).Select(a => new Tuple<int, int>(a,a)).ToArray();
            var z = Enumerable.Range(1, 1024).Select(a => new { A = a}).ToArray();

            Assert.IsTrue(ZEnumerable.First(x) == Enumerable.First(x));
			Assert.IsTrue(ZEnumerable.First(y) == Enumerable.First(y));
			Assert.IsTrue(ZEnumerable.First(z) == Enumerable.First(z));
        }

		[TestMethod]
        public void FirstArrayOrDefault()
        {
            var x = Enumerable.Range(1, 1024).ToArray();
            var y = Enumerable.Range(1, 1024).Select(a => new Tuple<int, int>(a,a)).ToArray();
            var z = new int[0].ToArray();

            Assert.IsTrue(ZEnumerable.FirstOrDefault(x) == Enumerable.FirstOrDefault(x));
            Assert.IsTrue(ZEnumerable.FirstOrDefault(y) == Enumerable.FirstOrDefault(y));
            Assert.IsTrue(ZEnumerable.FirstOrDefault(z) == Enumerable.FirstOrDefault(z));
        }

		[TestMethod]
        public void FirstArrayPredicate()
        {
            var x = Enumerable.Range(1, 1024).ToArray();
            var y = Enumerable.Range(1, 1024).Select(a => new Tuple<int, int>(a,a)).ToArray();
            var z = Enumerable.Range(1, 1024).Select(a => new { A = a}).ToArray();

            Assert.IsTrue(ZEnumerable.First(x, val => val%3 == 0) == Enumerable.First(x, val => val%3 == 0));
			Assert.IsTrue(ZEnumerable.First(y, val => val.Item1%3 == 0) == Enumerable.First(y, val => val.Item1%3 == 0));
			Assert.IsTrue(ZEnumerable.First(z, val => val.A%3 == 0) == Enumerable.First(z, val => val.A%3 == 0));
        }

		[TestMethod]
        public void FirstArrayOrDefaultPredicate()
        {
            var x = Enumerable.Range(1, 1024).ToArray();
            var y = Enumerable.Range(1, 1024).Select(a => new Tuple<int, int>(a,a)).ToArray();
            var z = new int[0].ToArray();

            Assert.IsTrue(ZEnumerable.FirstOrDefault(x, val => val%3 == 0) == Enumerable.FirstOrDefault(x, val => val%3 == 0));
            Assert.IsTrue(ZEnumerable.FirstOrDefault(y, val => val.Item1%3 == 0) == Enumerable.FirstOrDefault(y, val => val.Item1%3 == 0));
            Assert.IsTrue(ZEnumerable.FirstOrDefault(z, val => val%3 == 0) == Enumerable.FirstOrDefault(z, val => val%3 == 0));
        }

				
		[TestMethod]
        public void FirstList()
        {
            var x = Enumerable.Range(1, 1024).ToList();
            var y = Enumerable.Range(1, 1024).Select(a => new Tuple<int, int>(a,a)).ToList();
            var z = Enumerable.Range(1, 1024).Select(a => new { A = a}).ToList();

            Assert.IsTrue(ZEnumerable.First(x) == Enumerable.First(x));
			Assert.IsTrue(ZEnumerable.First(y) == Enumerable.First(y));
			Assert.IsTrue(ZEnumerable.First(z) == Enumerable.First(z));
        }

		[TestMethod]
        public void FirstListOrDefault()
        {
            var x = Enumerable.Range(1, 1024).ToList();
            var y = Enumerable.Range(1, 1024).Select(a => new Tuple<int, int>(a,a)).ToList();
            var z = new int[0].ToList();

            Assert.IsTrue(ZEnumerable.FirstOrDefault(x) == Enumerable.FirstOrDefault(x));
            Assert.IsTrue(ZEnumerable.FirstOrDefault(y) == Enumerable.FirstOrDefault(y));
            Assert.IsTrue(ZEnumerable.FirstOrDefault(z) == Enumerable.FirstOrDefault(z));
        }

		[TestMethod]
        public void FirstListPredicate()
        {
            var x = Enumerable.Range(1, 1024).ToList();
            var y = Enumerable.Range(1, 1024).Select(a => new Tuple<int, int>(a,a)).ToList();
            var z = Enumerable.Range(1, 1024).Select(a => new { A = a}).ToList();

            Assert.IsTrue(ZEnumerable.First(x, val => val%3 == 0) == Enumerable.First(x, val => val%3 == 0));
			Assert.IsTrue(ZEnumerable.First(y, val => val.Item1%3 == 0) == Enumerable.First(y, val => val.Item1%3 == 0));
			Assert.IsTrue(ZEnumerable.First(z, val => val.A%3 == 0) == Enumerable.First(z, val => val.A%3 == 0));
        }

		[TestMethod]
        public void FirstListOrDefaultPredicate()
        {
            var x = Enumerable.Range(1, 1024).ToList();
            var y = Enumerable.Range(1, 1024).Select(a => new Tuple<int, int>(a,a)).ToList();
            var z = new int[0].ToList();

            Assert.IsTrue(ZEnumerable.FirstOrDefault(x, val => val%3 == 0) == Enumerable.FirstOrDefault(x, val => val%3 == 0));
            Assert.IsTrue(ZEnumerable.FirstOrDefault(y, val => val.Item1%3 == 0) == Enumerable.FirstOrDefault(y, val => val.Item1%3 == 0));
            Assert.IsTrue(ZEnumerable.FirstOrDefault(z, val => val%3 == 0) == Enumerable.FirstOrDefault(z, val => val%3 == 0));
        }

				
		[TestMethod]
        public void FirstIList()
        {
            var x = Enumerable.Range(1, 1024).ToIList();
            var y = Enumerable.Range(1, 1024).Select(a => new Tuple<int, int>(a,a)).ToIList();
            var z = Enumerable.Range(1, 1024).Select(a => new { A = a}).ToIList();

            Assert.IsTrue(ZEnumerable.First(x) == Enumerable.First(x));
			Assert.IsTrue(ZEnumerable.First(y) == Enumerable.First(y));
			Assert.IsTrue(ZEnumerable.First(z) == Enumerable.First(z));
        }

		[TestMethod]
        public void FirstIListOrDefault()
        {
            var x = Enumerable.Range(1, 1024).ToIList();
            var y = Enumerable.Range(1, 1024).Select(a => new Tuple<int, int>(a,a)).ToIList();
            var z = new int[0].ToIList();

            Assert.IsTrue(ZEnumerable.FirstOrDefault(x) == Enumerable.FirstOrDefault(x));
            Assert.IsTrue(ZEnumerable.FirstOrDefault(y) == Enumerable.FirstOrDefault(y));
            Assert.IsTrue(ZEnumerable.FirstOrDefault(z) == Enumerable.FirstOrDefault(z));
        }

		[TestMethod]
        public void FirstIListPredicate()
        {
            var x = Enumerable.Range(1, 1024).ToIList();
            var y = Enumerable.Range(1, 1024).Select(a => new Tuple<int, int>(a,a)).ToIList();
            var z = Enumerable.Range(1, 1024).Select(a => new { A = a}).ToIList();

            Assert.IsTrue(ZEnumerable.First(x, val => val%3 == 0) == Enumerable.First(x, val => val%3 == 0));
			Assert.IsTrue(ZEnumerable.First(y, val => val.Item1%3 == 0) == Enumerable.First(y, val => val.Item1%3 == 0));
			Assert.IsTrue(ZEnumerable.First(z, val => val.A%3 == 0) == Enumerable.First(z, val => val.A%3 == 0));
        }

		[TestMethod]
        public void FirstIListOrDefaultPredicate()
        {
            var x = Enumerable.Range(1, 1024).ToIList();
            var y = Enumerable.Range(1, 1024).Select(a => new Tuple<int, int>(a,a)).ToIList();
            var z = new int[0].ToIList();

            Assert.IsTrue(ZEnumerable.FirstOrDefault(x, val => val%3 == 0) == Enumerable.FirstOrDefault(x, val => val%3 == 0));
            Assert.IsTrue(ZEnumerable.FirstOrDefault(y, val => val.Item1%3 == 0) == Enumerable.FirstOrDefault(y, val => val.Item1%3 == 0));
            Assert.IsTrue(ZEnumerable.FirstOrDefault(z, val => val%3 == 0) == Enumerable.FirstOrDefault(z, val => val%3 == 0));
        }

				
		[TestMethod]
        public void FirstICollection()
        {
            var x = Enumerable.Range(1, 1024).ToICollection();
            var y = Enumerable.Range(1, 1024).Select(a => new Tuple<int, int>(a,a)).ToICollection();
            var z = Enumerable.Range(1, 1024).Select(a => new { A = a}).ToICollection();

            Assert.IsTrue(ZEnumerable.First(x) == Enumerable.First(x));
			Assert.IsTrue(ZEnumerable.First(y) == Enumerable.First(y));
			Assert.IsTrue(ZEnumerable.First(z) == Enumerable.First(z));
        }

		[TestMethod]
        public void FirstICollectionOrDefault()
        {
            var x = Enumerable.Range(1, 1024).ToICollection();
            var y = Enumerable.Range(1, 1024).Select(a => new Tuple<int, int>(a,a)).ToICollection();
            var z = new int[0].ToICollection();

            Assert.IsTrue(ZEnumerable.FirstOrDefault(x) == Enumerable.FirstOrDefault(x));
            Assert.IsTrue(ZEnumerable.FirstOrDefault(y) == Enumerable.FirstOrDefault(y));
            Assert.IsTrue(ZEnumerable.FirstOrDefault(z) == Enumerable.FirstOrDefault(z));
        }

		[TestMethod]
        public void FirstICollectionPredicate()
        {
            var x = Enumerable.Range(1, 1024).ToICollection();
            var y = Enumerable.Range(1, 1024).Select(a => new Tuple<int, int>(a,a)).ToICollection();
            var z = Enumerable.Range(1, 1024).Select(a => new { A = a}).ToICollection();

            Assert.IsTrue(ZEnumerable.First(x, val => val%3 == 0) == Enumerable.First(x, val => val%3 == 0));
			Assert.IsTrue(ZEnumerable.First(y, val => val.Item1%3 == 0) == Enumerable.First(y, val => val.Item1%3 == 0));
			Assert.IsTrue(ZEnumerable.First(z, val => val.A%3 == 0) == Enumerable.First(z, val => val.A%3 == 0));
        }

		[TestMethod]
        public void FirstICollectionOrDefaultPredicate()
        {
            var x = Enumerable.Range(1, 1024).ToICollection();
            var y = Enumerable.Range(1, 1024).Select(a => new Tuple<int, int>(a,a)).ToICollection();
            var z = new int[0].ToICollection();

            Assert.IsTrue(ZEnumerable.FirstOrDefault(x, val => val%3 == 0) == Enumerable.FirstOrDefault(x, val => val%3 == 0));
            Assert.IsTrue(ZEnumerable.FirstOrDefault(y, val => val.Item1%3 == 0) == Enumerable.FirstOrDefault(y, val => val.Item1%3 == 0));
            Assert.IsTrue(ZEnumerable.FirstOrDefault(z, val => val%3 == 0) == Enumerable.FirstOrDefault(z, val => val%3 == 0));
        }

			


    }
}
