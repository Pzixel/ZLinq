
using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZLinq.Test.Helpers;

namespace ZLinq.Test.Core.Folding
{
    [TestClass]
    public class Last
    {	
				
		[TestMethod]
        public void LastArray()
        {
            var x = Enumerable.Range(1, 1024).ToArray();
            var y = Enumerable.Range(1, 1024).Select(a => new Tuple<int, int>(a,a)).ToArray();
            var z = Enumerable.Range(1, 1024).Select(a => new { A = a}).ToArray();

            Assert.IsTrue(ZEnumerable.Last(x) == Enumerable.Last(x));
			Assert.IsTrue(ZEnumerable.Last(y) == Enumerable.Last(y));
			Assert.IsTrue(ZEnumerable.Last(z) == Enumerable.Last(z));
        }

		[TestMethod]
        public void LastArrayOrDefault()
        {
            var x = Enumerable.Range(1, 1024).ToArray();
            var y = Enumerable.Range(1, 1024).Select(a => new Tuple<int, int>(a,a)).ToArray();
            var z = new int[0].ToArray();

            Assert.IsTrue(ZEnumerable.FirstOrDefault(x) == Enumerable.FirstOrDefault(x));
            Assert.IsTrue(ZEnumerable.FirstOrDefault(y) == Enumerable.FirstOrDefault(y));
            Assert.IsTrue(ZEnumerable.FirstOrDefault(z) == Enumerable.FirstOrDefault(z));
        }

		[TestMethod]
        public void LastArrayPredicate()
        {
            var x = Enumerable.Range(1, 1024).ToArray();
            var y = Enumerable.Range(1, 1024).Select(a => new Tuple<int, int>(a,a)).ToArray();
            var z = Enumerable.Range(1, 1024).Select(a => new { A = a}).ToArray();

            Assert.IsTrue(ZEnumerable.Last(x, val => val%3 == 0) == Enumerable.Last(x, val => val%3 == 0));
			Assert.IsTrue(ZEnumerable.Last(y, val => val.Item1%3 == 0) == Enumerable.Last(y, val => val.Item1%3 == 0));
			Assert.IsTrue(ZEnumerable.Last(z, val => val.A%3 == 0) == Enumerable.Last(z, val => val.A%3 == 0));
        }

		[TestMethod]
        public void LastArrayOrDefaultPredicate()
        {
            var x = Enumerable.Range(1, 1024).ToArray();
            var y = Enumerable.Range(1, 1024).Select(a => new Tuple<int, int>(a,a)).ToArray();
            var z = new int[0].ToArray();

            Assert.IsTrue(ZEnumerable.FirstOrDefault(x, val => val%3 == 0) == Enumerable.FirstOrDefault(x, val => val%3 == 0));
            Assert.IsTrue(ZEnumerable.FirstOrDefault(y, val => val.Item1%3 == 0) == Enumerable.FirstOrDefault(y, val => val.Item1%3 == 0));
            Assert.IsTrue(ZEnumerable.FirstOrDefault(z, val => val%3 == 0) == Enumerable.FirstOrDefault(z, val => val%3 == 0));
        }

				
		[TestMethod]
        public void LastList()
        {
            var x = Enumerable.Range(1, 1024).ToList();
            var y = Enumerable.Range(1, 1024).Select(a => new Tuple<int, int>(a,a)).ToList();
            var z = Enumerable.Range(1, 1024).Select(a => new { A = a}).ToList();

            Assert.IsTrue(ZEnumerable.Last(x) == Enumerable.Last(x));
			Assert.IsTrue(ZEnumerable.Last(y) == Enumerable.Last(y));
			Assert.IsTrue(ZEnumerable.Last(z) == Enumerable.Last(z));
        }

		[TestMethod]
        public void LastListOrDefault()
        {
            var x = Enumerable.Range(1, 1024).ToList();
            var y = Enumerable.Range(1, 1024).Select(a => new Tuple<int, int>(a,a)).ToList();
            var z = new int[0].ToList();

            Assert.IsTrue(ZEnumerable.FirstOrDefault(x) == Enumerable.FirstOrDefault(x));
            Assert.IsTrue(ZEnumerable.FirstOrDefault(y) == Enumerable.FirstOrDefault(y));
            Assert.IsTrue(ZEnumerable.FirstOrDefault(z) == Enumerable.FirstOrDefault(z));
        }

		[TestMethod]
        public void LastListPredicate()
        {
            var x = Enumerable.Range(1, 1024).ToList();
            var y = Enumerable.Range(1, 1024).Select(a => new Tuple<int, int>(a,a)).ToList();
            var z = Enumerable.Range(1, 1024).Select(a => new { A = a}).ToList();

            Assert.IsTrue(ZEnumerable.Last(x, val => val%3 == 0) == Enumerable.Last(x, val => val%3 == 0));
			Assert.IsTrue(ZEnumerable.Last(y, val => val.Item1%3 == 0) == Enumerable.Last(y, val => val.Item1%3 == 0));
			Assert.IsTrue(ZEnumerable.Last(z, val => val.A%3 == 0) == Enumerable.Last(z, val => val.A%3 == 0));
        }

		[TestMethod]
        public void LastListOrDefaultPredicate()
        {
            var x = Enumerable.Range(1, 1024).ToList();
            var y = Enumerable.Range(1, 1024).Select(a => new Tuple<int, int>(a,a)).ToList();
            var z = new int[0].ToList();

            Assert.IsTrue(ZEnumerable.FirstOrDefault(x, val => val%3 == 0) == Enumerable.FirstOrDefault(x, val => val%3 == 0));
            Assert.IsTrue(ZEnumerable.FirstOrDefault(y, val => val.Item1%3 == 0) == Enumerable.FirstOrDefault(y, val => val.Item1%3 == 0));
            Assert.IsTrue(ZEnumerable.FirstOrDefault(z, val => val%3 == 0) == Enumerable.FirstOrDefault(z, val => val%3 == 0));
        }

				
		[TestMethod]
        public void LastIList()
        {
            var x = Enumerable.Range(1, 1024).ToIList();
            var y = Enumerable.Range(1, 1024).Select(a => new Tuple<int, int>(a,a)).ToIList();
            var z = Enumerable.Range(1, 1024).Select(a => new { A = a}).ToIList();

            Assert.IsTrue(ZEnumerable.Last(x) == Enumerable.Last(x));
			Assert.IsTrue(ZEnumerable.Last(y) == Enumerable.Last(y));
			Assert.IsTrue(ZEnumerable.Last(z) == Enumerable.Last(z));
        }

		[TestMethod]
        public void LastIListOrDefault()
        {
            var x = Enumerable.Range(1, 1024).ToIList();
            var y = Enumerable.Range(1, 1024).Select(a => new Tuple<int, int>(a,a)).ToIList();
            var z = new int[0].ToIList();

            Assert.IsTrue(ZEnumerable.FirstOrDefault(x) == Enumerable.FirstOrDefault(x));
            Assert.IsTrue(ZEnumerable.FirstOrDefault(y) == Enumerable.FirstOrDefault(y));
            Assert.IsTrue(ZEnumerable.FirstOrDefault(z) == Enumerable.FirstOrDefault(z));
        }

		[TestMethod]
        public void LastIListPredicate()
        {
            var x = Enumerable.Range(1, 1024).ToIList();
            var y = Enumerable.Range(1, 1024).Select(a => new Tuple<int, int>(a,a)).ToIList();
            var z = Enumerable.Range(1, 1024).Select(a => new { A = a}).ToIList();

            Assert.IsTrue(ZEnumerable.Last(x, val => val%3 == 0) == Enumerable.Last(x, val => val%3 == 0));
			Assert.IsTrue(ZEnumerable.Last(y, val => val.Item1%3 == 0) == Enumerable.Last(y, val => val.Item1%3 == 0));
			Assert.IsTrue(ZEnumerable.Last(z, val => val.A%3 == 0) == Enumerable.Last(z, val => val.A%3 == 0));
        }

		[TestMethod]
        public void LastIListOrDefaultPredicate()
        {
            var x = Enumerable.Range(1, 1024).ToIList();
            var y = Enumerable.Range(1, 1024).Select(a => new Tuple<int, int>(a,a)).ToIList();
            var z = new int[0].ToIList();

            Assert.IsTrue(ZEnumerable.FirstOrDefault(x, val => val%3 == 0) == Enumerable.FirstOrDefault(x, val => val%3 == 0));
            Assert.IsTrue(ZEnumerable.FirstOrDefault(y, val => val.Item1%3 == 0) == Enumerable.FirstOrDefault(y, val => val.Item1%3 == 0));
            Assert.IsTrue(ZEnumerable.FirstOrDefault(z, val => val%3 == 0) == Enumerable.FirstOrDefault(z, val => val%3 == 0));
        }

			


    }
}
