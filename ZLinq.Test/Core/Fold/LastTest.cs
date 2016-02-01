
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZLinq.Test.Helpers;

namespace ZLinq.Test.Core.Fold
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
		    var dict = new SortedDictionary<int, int>(x.ToDictionary(a => a, a => a));

            Assert.IsTrue(ZEnumerable.Last(x) == Enumerable.Last(x));
			Assert.IsTrue(ZEnumerable.Last(y) == Enumerable.Last(y));
			Assert.IsTrue(ZEnumerable.Last(z) == Enumerable.Last(z));
			Assert.IsTrue(ZEnumerable.Last(dict).Equals(Enumerable.Last(dict)));
        }

		[TestMethod]
        public void LastArrayOrDefault()
        {
            var x = Enumerable.Range(1, 1024).ToArray();
            var y = Enumerable.Range(1, 1024).Select(a => new Tuple<int, int>(a,a)).ToArray();
            var z = new int[0].ToArray();
		    var dict = new SortedDictionary<int, int>(x.ToDictionary(a => a, a => a));

            Assert.IsTrue(ZEnumerable.LastOrDefault(x) == Enumerable.LastOrDefault(x));
			Assert.IsTrue(ZEnumerable.LastOrDefault(y) == Enumerable.LastOrDefault(y));
			Assert.IsTrue(ZEnumerable.LastOrDefault(z) == Enumerable.LastOrDefault(z));
			Assert.IsTrue(ZEnumerable.LastOrDefault(dict).Equals(Enumerable.LastOrDefault(dict)));
        }

		[TestMethod]
        public void LastArrayPredicate()
        {
            var x = Enumerable.Range(1, 1024).ToArray();
            var y = Enumerable.Range(1, 1024).Select(a => new Tuple<int, int>(a,a)).ToArray();
            var z = Enumerable.Range(1, 1024).Select(a => new { A = a}).ToArray();
			var dict = new SortedDictionary<int, int>(x.ToDictionary(a => a, a => a));

            Assert.IsTrue(ZEnumerable.Last(x, val => val%3 == 0) == Enumerable.Last(x, val => val%3 == 0));
			Assert.IsTrue(ZEnumerable.Last(y, val => val.Item1%3 == 0) == Enumerable.Last(y, val => val.Item1%3 == 0));
			Assert.IsTrue(ZEnumerable.Last(z, val => val.A%3 == 0) == Enumerable.Last(z, val => val.A%3 == 0));
			Assert.IsTrue(ZEnumerable.Last(dict, val => val.Key%3 == 0).Equals(Enumerable.Last(dict, val => val.Key%3 == 0)));
        }

		[TestMethod]
        public void LastArrayOrDefaultPredicate()
        {
            var x = Enumerable.Range(1, 1024).ToArray();
            var y = Enumerable.Range(1, 1024).Select(a => new Tuple<int, int>(a,a)).ToArray();
            var z = new int[0].ToArray();
			var dict = new SortedDictionary<int, int>(x.ToDictionary(a => a, a => a));

            Assert.IsTrue(ZEnumerable.LastOrDefault(x, val => val%3 == 0) == Enumerable.LastOrDefault(x, val => val%3 == 0));
            Assert.IsTrue(ZEnumerable.LastOrDefault(y, val => val.Item1%3 == 0) == Enumerable.LastOrDefault(y, val => val.Item1%3 == 0));
            Assert.IsTrue(ZEnumerable.LastOrDefault(z, val => val%3 == 0) == Enumerable.LastOrDefault(z, val => val%3 == 0));
			Assert.IsTrue(ZEnumerable.LastOrDefault(dict, val => val.Key%3 == 0).Equals(Enumerable.LastOrDefault(dict, val => val.Key%3 == 0)));
        }

				
		[TestMethod]
        public void LastList()
        {
            var x = Enumerable.Range(1, 1024).ToList();
            var y = Enumerable.Range(1, 1024).Select(a => new Tuple<int, int>(a,a)).ToList();
            var z = Enumerable.Range(1, 1024).Select(a => new { A = a}).ToList();
		    var dict = new SortedDictionary<int, int>(x.ToDictionary(a => a, a => a));

            Assert.IsTrue(ZEnumerable.Last(x) == Enumerable.Last(x));
			Assert.IsTrue(ZEnumerable.Last(y) == Enumerable.Last(y));
			Assert.IsTrue(ZEnumerable.Last(z) == Enumerable.Last(z));
			Assert.IsTrue(ZEnumerable.Last(dict).Equals(Enumerable.Last(dict)));
        }

		[TestMethod]
        public void LastListOrDefault()
        {
            var x = Enumerable.Range(1, 1024).ToList();
            var y = Enumerable.Range(1, 1024).Select(a => new Tuple<int, int>(a,a)).ToList();
            var z = new int[0].ToList();
		    var dict = new SortedDictionary<int, int>(x.ToDictionary(a => a, a => a));

            Assert.IsTrue(ZEnumerable.LastOrDefault(x) == Enumerable.LastOrDefault(x));
			Assert.IsTrue(ZEnumerable.LastOrDefault(y) == Enumerable.LastOrDefault(y));
			Assert.IsTrue(ZEnumerable.LastOrDefault(z) == Enumerable.LastOrDefault(z));
			Assert.IsTrue(ZEnumerable.LastOrDefault(dict).Equals(Enumerable.LastOrDefault(dict)));
        }

		[TestMethod]
        public void LastListPredicate()
        {
            var x = Enumerable.Range(1, 1024).ToList();
            var y = Enumerable.Range(1, 1024).Select(a => new Tuple<int, int>(a,a)).ToList();
            var z = Enumerable.Range(1, 1024).Select(a => new { A = a}).ToList();
			var dict = new SortedDictionary<int, int>(x.ToDictionary(a => a, a => a));

            Assert.IsTrue(ZEnumerable.Last(x, val => val%3 == 0) == Enumerable.Last(x, val => val%3 == 0));
			Assert.IsTrue(ZEnumerable.Last(y, val => val.Item1%3 == 0) == Enumerable.Last(y, val => val.Item1%3 == 0));
			Assert.IsTrue(ZEnumerable.Last(z, val => val.A%3 == 0) == Enumerable.Last(z, val => val.A%3 == 0));
			Assert.IsTrue(ZEnumerable.Last(dict, val => val.Key%3 == 0).Equals(Enumerable.Last(dict, val => val.Key%3 == 0)));
        }

		[TestMethod]
        public void LastListOrDefaultPredicate()
        {
            var x = Enumerable.Range(1, 1024).ToList();
            var y = Enumerable.Range(1, 1024).Select(a => new Tuple<int, int>(a,a)).ToList();
            var z = new int[0].ToList();
			var dict = new SortedDictionary<int, int>(x.ToDictionary(a => a, a => a));

            Assert.IsTrue(ZEnumerable.LastOrDefault(x, val => val%3 == 0) == Enumerable.LastOrDefault(x, val => val%3 == 0));
            Assert.IsTrue(ZEnumerable.LastOrDefault(y, val => val.Item1%3 == 0) == Enumerable.LastOrDefault(y, val => val.Item1%3 == 0));
            Assert.IsTrue(ZEnumerable.LastOrDefault(z, val => val%3 == 0) == Enumerable.LastOrDefault(z, val => val%3 == 0));
			Assert.IsTrue(ZEnumerable.LastOrDefault(dict, val => val.Key%3 == 0).Equals(Enumerable.LastOrDefault(dict, val => val.Key%3 == 0)));
        }

				
		[TestMethod]
        public void LastIList()
        {
            var x = Enumerable.Range(1, 1024).ToIList();
            var y = Enumerable.Range(1, 1024).Select(a => new Tuple<int, int>(a,a)).ToIList();
            var z = Enumerable.Range(1, 1024).Select(a => new { A = a}).ToIList();
		    var dict = new SortedDictionary<int, int>(x.ToDictionary(a => a, a => a));

            Assert.IsTrue(ZEnumerable.Last(x) == Enumerable.Last(x));
			Assert.IsTrue(ZEnumerable.Last(y) == Enumerable.Last(y));
			Assert.IsTrue(ZEnumerable.Last(z) == Enumerable.Last(z));
			Assert.IsTrue(ZEnumerable.Last(dict).Equals(Enumerable.Last(dict)));
        }

		[TestMethod]
        public void LastIListOrDefault()
        {
            var x = Enumerable.Range(1, 1024).ToIList();
            var y = Enumerable.Range(1, 1024).Select(a => new Tuple<int, int>(a,a)).ToIList();
            var z = new int[0].ToIList();
		    var dict = new SortedDictionary<int, int>(x.ToDictionary(a => a, a => a));

            Assert.IsTrue(ZEnumerable.LastOrDefault(x) == Enumerable.LastOrDefault(x));
			Assert.IsTrue(ZEnumerable.LastOrDefault(y) == Enumerable.LastOrDefault(y));
			Assert.IsTrue(ZEnumerable.LastOrDefault(z) == Enumerable.LastOrDefault(z));
			Assert.IsTrue(ZEnumerable.LastOrDefault(dict).Equals(Enumerable.LastOrDefault(dict)));
        }

		[TestMethod]
        public void LastIListPredicate()
        {
            var x = Enumerable.Range(1, 1024).ToIList();
            var y = Enumerable.Range(1, 1024).Select(a => new Tuple<int, int>(a,a)).ToIList();
            var z = Enumerable.Range(1, 1024).Select(a => new { A = a}).ToIList();
			var dict = new SortedDictionary<int, int>(x.ToDictionary(a => a, a => a));

            Assert.IsTrue(ZEnumerable.Last(x, val => val%3 == 0) == Enumerable.Last(x, val => val%3 == 0));
			Assert.IsTrue(ZEnumerable.Last(y, val => val.Item1%3 == 0) == Enumerable.Last(y, val => val.Item1%3 == 0));
			Assert.IsTrue(ZEnumerable.Last(z, val => val.A%3 == 0) == Enumerable.Last(z, val => val.A%3 == 0));
			Assert.IsTrue(ZEnumerable.Last(dict, val => val.Key%3 == 0).Equals(Enumerable.Last(dict, val => val.Key%3 == 0)));
        }

		[TestMethod]
        public void LastIListOrDefaultPredicate()
        {
            var x = Enumerable.Range(1, 1024).ToIList();
            var y = Enumerable.Range(1, 1024).Select(a => new Tuple<int, int>(a,a)).ToIList();
            var z = new int[0].ToIList();
			var dict = new SortedDictionary<int, int>(x.ToDictionary(a => a, a => a));

            Assert.IsTrue(ZEnumerable.LastOrDefault(x, val => val%3 == 0) == Enumerable.LastOrDefault(x, val => val%3 == 0));
            Assert.IsTrue(ZEnumerable.LastOrDefault(y, val => val.Item1%3 == 0) == Enumerable.LastOrDefault(y, val => val.Item1%3 == 0));
            Assert.IsTrue(ZEnumerable.LastOrDefault(z, val => val%3 == 0) == Enumerable.LastOrDefault(z, val => val%3 == 0));
			Assert.IsTrue(ZEnumerable.LastOrDefault(dict, val => val.Key%3 == 0).Equals(Enumerable.LastOrDefault(dict, val => val.Key%3 == 0)));
        }

				
		[TestMethod]
        public void LastICollection()
        {
            var x = Enumerable.Range(1, 1024).ToICollection();
            var y = Enumerable.Range(1, 1024).Select(a => new Tuple<int, int>(a,a)).ToICollection();
            var z = Enumerable.Range(1, 1024).Select(a => new { A = a}).ToICollection();
		    var dict = new SortedDictionary<int, int>(x.ToDictionary(a => a, a => a));

            Assert.IsTrue(ZEnumerable.Last(x) == Enumerable.Last(x));
			Assert.IsTrue(ZEnumerable.Last(y) == Enumerable.Last(y));
			Assert.IsTrue(ZEnumerable.Last(z) == Enumerable.Last(z));
			Assert.IsTrue(ZEnumerable.Last(dict).Equals(Enumerable.Last(dict)));
        }

		[TestMethod]
        public void LastICollectionOrDefault()
        {
            var x = Enumerable.Range(1, 1024).ToICollection();
            var y = Enumerable.Range(1, 1024).Select(a => new Tuple<int, int>(a,a)).ToICollection();
            var z = new int[0].ToICollection();
		    var dict = new SortedDictionary<int, int>(x.ToDictionary(a => a, a => a));

            Assert.IsTrue(ZEnumerable.LastOrDefault(x) == Enumerable.LastOrDefault(x));
			Assert.IsTrue(ZEnumerable.LastOrDefault(y) == Enumerable.LastOrDefault(y));
			Assert.IsTrue(ZEnumerable.LastOrDefault(z) == Enumerable.LastOrDefault(z));
			Assert.IsTrue(ZEnumerable.LastOrDefault(dict).Equals(Enumerable.LastOrDefault(dict)));
        }

		[TestMethod]
        public void LastICollectionPredicate()
        {
            var x = Enumerable.Range(1, 1024).ToICollection();
            var y = Enumerable.Range(1, 1024).Select(a => new Tuple<int, int>(a,a)).ToICollection();
            var z = Enumerable.Range(1, 1024).Select(a => new { A = a}).ToICollection();
			var dict = new SortedDictionary<int, int>(x.ToDictionary(a => a, a => a));

            Assert.IsTrue(ZEnumerable.Last(x, val => val%3 == 0) == Enumerable.Last(x, val => val%3 == 0));
			Assert.IsTrue(ZEnumerable.Last(y, val => val.Item1%3 == 0) == Enumerable.Last(y, val => val.Item1%3 == 0));
			Assert.IsTrue(ZEnumerable.Last(z, val => val.A%3 == 0) == Enumerable.Last(z, val => val.A%3 == 0));
			Assert.IsTrue(ZEnumerable.Last(dict, val => val.Key%3 == 0).Equals(Enumerable.Last(dict, val => val.Key%3 == 0)));
        }

		[TestMethod]
        public void LastICollectionOrDefaultPredicate()
        {
            var x = Enumerable.Range(1, 1024).ToICollection();
            var y = Enumerable.Range(1, 1024).Select(a => new Tuple<int, int>(a,a)).ToICollection();
            var z = new int[0].ToICollection();
			var dict = new SortedDictionary<int, int>(x.ToDictionary(a => a, a => a));

            Assert.IsTrue(ZEnumerable.LastOrDefault(x, val => val%3 == 0) == Enumerable.LastOrDefault(x, val => val%3 == 0));
            Assert.IsTrue(ZEnumerable.LastOrDefault(y, val => val.Item1%3 == 0) == Enumerable.LastOrDefault(y, val => val.Item1%3 == 0));
            Assert.IsTrue(ZEnumerable.LastOrDefault(z, val => val%3 == 0) == Enumerable.LastOrDefault(z, val => val%3 == 0));
			Assert.IsTrue(ZEnumerable.LastOrDefault(dict, val => val.Key%3 == 0).Equals(Enumerable.LastOrDefault(dict, val => val.Key%3 == 0)));
        }

			


    }
}
