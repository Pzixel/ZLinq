
using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ZLinq.Test.Core.Folding
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
            var z = new int[0];

            Assert.IsTrue(ZEnumerable.FirstOrDefault(x, i => i%3 == 0) == Enumerable.FirstOrDefault(x, i => i%3 == 0));
            Assert.IsTrue(ZEnumerable.FirstOrDefault(y, i => i.Item1%3 == 0) == Enumerable.FirstOrDefault(y, i => i.Item1%3 == 0));
            Assert.IsTrue(ZEnumerable.FirstOrDefault(z, i => i%3 == 0) == Enumerable.FirstOrDefault(z, i => i%3 == 0));
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
            var z = new int[0];

            Assert.IsTrue(ZEnumerable.FirstOrDefault(x, i => i%3 == 0) == Enumerable.FirstOrDefault(x, i => i%3 == 0));
            Assert.IsTrue(ZEnumerable.FirstOrDefault(y, i => i.Item1%3 == 0) == Enumerable.FirstOrDefault(y, i => i.Item1%3 == 0));
            Assert.IsTrue(ZEnumerable.FirstOrDefault(z, i => i%3 == 0) == Enumerable.FirstOrDefault(z, i => i%3 == 0));
        }

				
		[TestMethod]
        public void FirstIList()
        {
            var x = Enumerable.Range(1, 1024).ToList();
            var y = Enumerable.Range(1, 1024).Select(a => new Tuple<int, int>(a,a)).ToList();
            var z = Enumerable.Range(1, 1024).Select(a => new { A = a}).ToList();

            Assert.IsTrue(ZEnumerable.First(x) == Enumerable.First(x));
			Assert.IsTrue(ZEnumerable.First(y) == Enumerable.First(y));
			Assert.IsTrue(ZEnumerable.First(z) == Enumerable.First(z));
        }

		[TestMethod]
        public void FirstIListOrDefault()
        {
            var x = Enumerable.Range(1, 1024).ToList();
            var y = Enumerable.Range(1, 1024).Select(a => new Tuple<int, int>(a,a)).ToList();
            var z = new int[0];

            Assert.IsTrue(ZEnumerable.FirstOrDefault(x, i => i%3 == 0) == Enumerable.FirstOrDefault(x, i => i%3 == 0));
            Assert.IsTrue(ZEnumerable.FirstOrDefault(y, i => i.Item1%3 == 0) == Enumerable.FirstOrDefault(y, i => i.Item1%3 == 0));
            Assert.IsTrue(ZEnumerable.FirstOrDefault(z, i => i%3 == 0) == Enumerable.FirstOrDefault(z, i => i%3 == 0));
        }

				
		[TestMethod]
        public void FirstICollection()
        {
            var x = Enumerable.Range(1, 1024).ToList();
            var y = Enumerable.Range(1, 1024).Select(a => new Tuple<int, int>(a,a)).ToList();
            var z = Enumerable.Range(1, 1024).Select(a => new { A = a}).ToList();

            Assert.IsTrue(ZEnumerable.First(x) == Enumerable.First(x));
			Assert.IsTrue(ZEnumerable.First(y) == Enumerable.First(y));
			Assert.IsTrue(ZEnumerable.First(z) == Enumerable.First(z));
        }

		[TestMethod]
        public void FirstICollectionOrDefault()
        {
            var x = Enumerable.Range(1, 1024).ToList();
            var y = Enumerable.Range(1, 1024).Select(a => new Tuple<int, int>(a,a)).ToList();
            var z = new int[0];

            Assert.IsTrue(ZEnumerable.FirstOrDefault(x, i => i%3 == 0) == Enumerable.FirstOrDefault(x, i => i%3 == 0));
            Assert.IsTrue(ZEnumerable.FirstOrDefault(y, i => i.Item1%3 == 0) == Enumerable.FirstOrDefault(y, i => i.Item1%3 == 0));
            Assert.IsTrue(ZEnumerable.FirstOrDefault(z, i => i%3 == 0) == Enumerable.FirstOrDefault(z, i => i%3 == 0));
        }

			


    }
}
