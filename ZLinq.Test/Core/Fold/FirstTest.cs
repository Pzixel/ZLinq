
using System;
using System.Collections.Generic;
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
            var dict = new SortedDictionary<int, int>(x.ToDictionary(a => a, a => a));

            Assert.AreEqual(ZEnumerable.First(x), Enumerable.First(x));
            Assert.AreEqual(ZEnumerable.First(y), Enumerable.First(y));
            Assert.AreEqual(ZEnumerable.First(z), Enumerable.First(z));
            Assert.AreEqual(ZEnumerable.First(dict), Enumerable.First(dict));
        }

        [TestMethod]
        public void FirstArrayOrDefault()
        {
            var x = Enumerable.Range(1, 1024).ToArray();
            var y = Enumerable.Range(1, 1024).Select(a => new Tuple<int, int>(a,a)).ToArray();
            var z = new int[0].ToArray();
            var dict = new SortedDictionary<int, int>(x.ToDictionary(a => a, a => a));

            Assert.AreEqual(ZEnumerable.FirstOrDefault(x), Enumerable.FirstOrDefault(x));
            Assert.AreEqual(ZEnumerable.FirstOrDefault(y), Enumerable.FirstOrDefault(y));
            Assert.AreEqual(ZEnumerable.FirstOrDefault(z), Enumerable.FirstOrDefault(z));
            Assert.AreEqual(ZEnumerable.FirstOrDefault(dict), Enumerable.FirstOrDefault(dict));
        }

        [TestMethod]
        public void FirstArrayPredicate()
        {
            var x = Enumerable.Range(1, 1024).ToArray();
            var y = Enumerable.Range(1, 1024).Select(a => new Tuple<int, int>(a,a)).ToArray();
            var z = Enumerable.Range(1, 1024).Select(a => new { A = a}).ToArray();
            var dict = new SortedDictionary<int, int>(x.ToDictionary(a => a, a => a));

            Assert.AreEqual(ZEnumerable.First(x, val => val%3 == 0), Enumerable.First(x, val => val%3 == 0));
            Assert.AreEqual(ZEnumerable.First(y, val => val.Item1%3 == 0), Enumerable.First(y, val => val.Item1%3 == 0));
            Assert.AreEqual(ZEnumerable.First(z, val => val.A%3 == 0), Enumerable.First(z, val => val.A%3 == 0));
            Assert.AreEqual(ZEnumerable.First(dict, val => val.Key%3 == 0), Enumerable.First(dict, val => val.Key%3 == 0));
        }

        [TestMethod]
        public void FirstArrayOrDefaultPredicate()
        {
            var x = Enumerable.Range(1, 1024).ToArray();
            var y = Enumerable.Range(1, 1024).Select(a => new Tuple<int, int>(a,a)).ToArray();
            var z = new Tuple<int, int>[0].ToArray();
            var dict = new SortedDictionary<int, int>(x.ToDictionary(a => a, a => a));

            Assert.AreEqual(ZEnumerable.FirstOrDefault(x, val => val%3 == 0), Enumerable.FirstOrDefault(x, val => val%3 == 0));
            Assert.AreEqual(ZEnumerable.FirstOrDefault(y, val => val.Item1%3 == 0), Enumerable.FirstOrDefault(y, val => val.Item1%3 == 0));
            Assert.AreEqual(ZEnumerable.FirstOrDefault(z, val => val.Item1%3 == 0), Enumerable.FirstOrDefault(z, val => val.Item1%3 == 0));
            Assert.AreEqual(ZEnumerable.FirstOrDefault(dict, val => val.Key%3 == 0), Enumerable.FirstOrDefault(dict, val => val.Key%3 == 0));
        }

		[TestMethod]
        public void FirstArrayInvalidInput()
        {
			int[] x = null;
			try
			{
				ZEnumerable.First(x);
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
			}

            var y = new int[0].ToArray();
			try
			{
				ZEnumerable.First(y);
				Assert.Fail();
			}
			catch (InvalidOperationException)
			{
			}

			var z = Enumerable.Range(1, 1).Select(a => new Tuple<int, int>(a, a)).ToArray();
			try
			{
				ZEnumerable.First(z, null);
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
			}

			try
			{
				ZEnumerable.First(z, _ => false);
				Assert.Fail();
			}
			catch (InvalidOperationException)
			{
			}
        }

		
		[TestMethod]
        public void FirstOrDefaultArrayInvalidInput()
        {
			int[] x = null;
			try
			{
				ZEnumerable.FirstOrDefault(x);
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
			}

			var z = Enumerable.Range(1, 1).Select(a => new Tuple<int, int>(a, a)).ToArray();

			try
			{
				ZEnumerable.FirstOrDefault(z, null);
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
			}
        }

                
        [TestMethod]
        public void FirstList()
        {
            var x = Enumerable.Range(1, 1024).ToList();
            var y = Enumerable.Range(1, 1024).Select(a => new Tuple<int, int>(a,a)).ToList();
            var z = Enumerable.Range(1, 1024).Select(a => new { A = a}).ToList();
            var dict = new SortedDictionary<int, int>(x.ToDictionary(a => a, a => a));

            Assert.AreEqual(ZEnumerable.First(x), Enumerable.First(x));
            Assert.AreEqual(ZEnumerable.First(y), Enumerable.First(y));
            Assert.AreEqual(ZEnumerable.First(z), Enumerable.First(z));
            Assert.AreEqual(ZEnumerable.First(dict), Enumerable.First(dict));
        }

        [TestMethod]
        public void FirstListOrDefault()
        {
            var x = Enumerable.Range(1, 1024).ToList();
            var y = Enumerable.Range(1, 1024).Select(a => new Tuple<int, int>(a,a)).ToList();
            var z = new int[0].ToList();
            var dict = new SortedDictionary<int, int>(x.ToDictionary(a => a, a => a));

            Assert.AreEqual(ZEnumerable.FirstOrDefault(x), Enumerable.FirstOrDefault(x));
            Assert.AreEqual(ZEnumerable.FirstOrDefault(y), Enumerable.FirstOrDefault(y));
            Assert.AreEqual(ZEnumerable.FirstOrDefault(z), Enumerable.FirstOrDefault(z));
            Assert.AreEqual(ZEnumerable.FirstOrDefault(dict), Enumerable.FirstOrDefault(dict));
        }

        [TestMethod]
        public void FirstListPredicate()
        {
            var x = Enumerable.Range(1, 1024).ToList();
            var y = Enumerable.Range(1, 1024).Select(a => new Tuple<int, int>(a,a)).ToList();
            var z = Enumerable.Range(1, 1024).Select(a => new { A = a}).ToList();
            var dict = new SortedDictionary<int, int>(x.ToDictionary(a => a, a => a));

            Assert.AreEqual(ZEnumerable.First(x, val => val%3 == 0), Enumerable.First(x, val => val%3 == 0));
            Assert.AreEqual(ZEnumerable.First(y, val => val.Item1%3 == 0), Enumerable.First(y, val => val.Item1%3 == 0));
            Assert.AreEqual(ZEnumerable.First(z, val => val.A%3 == 0), Enumerable.First(z, val => val.A%3 == 0));
            Assert.AreEqual(ZEnumerable.First(dict, val => val.Key%3 == 0), Enumerable.First(dict, val => val.Key%3 == 0));
        }

        [TestMethod]
        public void FirstListOrDefaultPredicate()
        {
            var x = Enumerable.Range(1, 1024).ToList();
            var y = Enumerable.Range(1, 1024).Select(a => new Tuple<int, int>(a,a)).ToList();
            var z = new Tuple<int, int>[0].ToList();
            var dict = new SortedDictionary<int, int>(x.ToDictionary(a => a, a => a));

            Assert.AreEqual(ZEnumerable.FirstOrDefault(x, val => val%3 == 0), Enumerable.FirstOrDefault(x, val => val%3 == 0));
            Assert.AreEqual(ZEnumerable.FirstOrDefault(y, val => val.Item1%3 == 0), Enumerable.FirstOrDefault(y, val => val.Item1%3 == 0));
            Assert.AreEqual(ZEnumerable.FirstOrDefault(z, val => val.Item1%3 == 0), Enumerable.FirstOrDefault(z, val => val.Item1%3 == 0));
            Assert.AreEqual(ZEnumerable.FirstOrDefault(dict, val => val.Key%3 == 0), Enumerable.FirstOrDefault(dict, val => val.Key%3 == 0));
        }

		[TestMethod]
        public void FirstListInvalidInput()
        {
			List<int> x = null;
			try
			{
				ZEnumerable.First(x);
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
			}

            var y = new int[0].ToList();
			try
			{
				ZEnumerable.First(y);
				Assert.Fail();
			}
			catch (InvalidOperationException)
			{
			}

			var z = Enumerable.Range(1, 1).Select(a => new Tuple<int, int>(a, a)).ToList();
			try
			{
				ZEnumerable.First(z, null);
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
			}

			try
			{
				ZEnumerable.First(z, _ => false);
				Assert.Fail();
			}
			catch (InvalidOperationException)
			{
			}
        }

		
		[TestMethod]
        public void FirstOrDefaultListInvalidInput()
        {
			List<int> x = null;
			try
			{
				ZEnumerable.FirstOrDefault(x);
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
			}

			var z = Enumerable.Range(1, 1).Select(a => new Tuple<int, int>(a, a)).ToList();

			try
			{
				ZEnumerable.FirstOrDefault(z, null);
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
			}
        }

                
        [TestMethod]
        public void FirstIList()
        {
            var x = Enumerable.Range(1, 1024).ToIList();
            var y = Enumerable.Range(1, 1024).Select(a => new Tuple<int, int>(a,a)).ToIList();
            var z = Enumerable.Range(1, 1024).Select(a => new { A = a}).ToIList();
            var dict = new SortedDictionary<int, int>(x.ToDictionary(a => a, a => a));

            Assert.AreEqual(ZEnumerable.First(x), Enumerable.First(x));
            Assert.AreEqual(ZEnumerable.First(y), Enumerable.First(y));
            Assert.AreEqual(ZEnumerable.First(z), Enumerable.First(z));
            Assert.AreEqual(ZEnumerable.First(dict), Enumerable.First(dict));
        }

        [TestMethod]
        public void FirstIListOrDefault()
        {
            var x = Enumerable.Range(1, 1024).ToIList();
            var y = Enumerable.Range(1, 1024).Select(a => new Tuple<int, int>(a,a)).ToIList();
            var z = new int[0].ToIList();
            var dict = new SortedDictionary<int, int>(x.ToDictionary(a => a, a => a));

            Assert.AreEqual(ZEnumerable.FirstOrDefault(x), Enumerable.FirstOrDefault(x));
            Assert.AreEqual(ZEnumerable.FirstOrDefault(y), Enumerable.FirstOrDefault(y));
            Assert.AreEqual(ZEnumerable.FirstOrDefault(z), Enumerable.FirstOrDefault(z));
            Assert.AreEqual(ZEnumerable.FirstOrDefault(dict), Enumerable.FirstOrDefault(dict));
        }

        [TestMethod]
        public void FirstIListPredicate()
        {
            var x = Enumerable.Range(1, 1024).ToIList();
            var y = Enumerable.Range(1, 1024).Select(a => new Tuple<int, int>(a,a)).ToIList();
            var z = Enumerable.Range(1, 1024).Select(a => new { A = a}).ToIList();
            var dict = new SortedDictionary<int, int>(x.ToDictionary(a => a, a => a));

            Assert.AreEqual(ZEnumerable.First(x, val => val%3 == 0), Enumerable.First(x, val => val%3 == 0));
            Assert.AreEqual(ZEnumerable.First(y, val => val.Item1%3 == 0), Enumerable.First(y, val => val.Item1%3 == 0));
            Assert.AreEqual(ZEnumerable.First(z, val => val.A%3 == 0), Enumerable.First(z, val => val.A%3 == 0));
            Assert.AreEqual(ZEnumerable.First(dict, val => val.Key%3 == 0), Enumerable.First(dict, val => val.Key%3 == 0));
        }

        [TestMethod]
        public void FirstIListOrDefaultPredicate()
        {
            var x = Enumerable.Range(1, 1024).ToIList();
            var y = Enumerable.Range(1, 1024).Select(a => new Tuple<int, int>(a,a)).ToIList();
            var z = new Tuple<int, int>[0].ToIList();
            var dict = new SortedDictionary<int, int>(x.ToDictionary(a => a, a => a));

            Assert.AreEqual(ZEnumerable.FirstOrDefault(x, val => val%3 == 0), Enumerable.FirstOrDefault(x, val => val%3 == 0));
            Assert.AreEqual(ZEnumerable.FirstOrDefault(y, val => val.Item1%3 == 0), Enumerable.FirstOrDefault(y, val => val.Item1%3 == 0));
            Assert.AreEqual(ZEnumerable.FirstOrDefault(z, val => val.Item1%3 == 0), Enumerable.FirstOrDefault(z, val => val.Item1%3 == 0));
            Assert.AreEqual(ZEnumerable.FirstOrDefault(dict, val => val.Key%3 == 0), Enumerable.FirstOrDefault(dict, val => val.Key%3 == 0));
        }

		[TestMethod]
        public void FirstIListInvalidInput()
        {
			IList<int> x = null;
			try
			{
				ZEnumerable.First(x);
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
			}

            var y = new int[0].ToIList();
			try
			{
				ZEnumerable.First(y);
				Assert.Fail();
			}
			catch (InvalidOperationException)
			{
			}

			var z = Enumerable.Range(1, 1).Select(a => new Tuple<int, int>(a, a)).ToIList();
			try
			{
				ZEnumerable.First(z, null);
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
			}

			try
			{
				ZEnumerable.First(z, _ => false);
				Assert.Fail();
			}
			catch (InvalidOperationException)
			{
			}
        }

		
		[TestMethod]
        public void FirstOrDefaultIListInvalidInput()
        {
			IList<int> x = null;
			try
			{
				ZEnumerable.FirstOrDefault(x);
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
			}

			var z = Enumerable.Range(1, 1).Select(a => new Tuple<int, int>(a, a)).ToIList();

			try
			{
				ZEnumerable.FirstOrDefault(z, null);
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
			}
        }

                
        [TestMethod]
        public void FirstICollection()
        {
            var x = Enumerable.Range(1, 1024).ToICollection();
            var y = Enumerable.Range(1, 1024).Select(a => new Tuple<int, int>(a,a)).ToICollection();
            var z = Enumerable.Range(1, 1024).Select(a => new { A = a}).ToICollection();
            var dict = new SortedDictionary<int, int>(x.ToDictionary(a => a, a => a));

            Assert.AreEqual(ZEnumerable.First(x), Enumerable.First(x));
            Assert.AreEqual(ZEnumerable.First(y), Enumerable.First(y));
            Assert.AreEqual(ZEnumerable.First(z), Enumerable.First(z));
            Assert.AreEqual(ZEnumerable.First(dict), Enumerable.First(dict));
        }

        [TestMethod]
        public void FirstICollectionOrDefault()
        {
            var x = Enumerable.Range(1, 1024).ToICollection();
            var y = Enumerable.Range(1, 1024).Select(a => new Tuple<int, int>(a,a)).ToICollection();
            var z = new int[0].ToICollection();
            var dict = new SortedDictionary<int, int>(x.ToDictionary(a => a, a => a));

            Assert.AreEqual(ZEnumerable.FirstOrDefault(x), Enumerable.FirstOrDefault(x));
            Assert.AreEqual(ZEnumerable.FirstOrDefault(y), Enumerable.FirstOrDefault(y));
            Assert.AreEqual(ZEnumerable.FirstOrDefault(z), Enumerable.FirstOrDefault(z));
            Assert.AreEqual(ZEnumerable.FirstOrDefault(dict), Enumerable.FirstOrDefault(dict));
        }

        [TestMethod]
        public void FirstICollectionPredicate()
        {
            var x = Enumerable.Range(1, 1024).ToICollection();
            var y = Enumerable.Range(1, 1024).Select(a => new Tuple<int, int>(a,a)).ToICollection();
            var z = Enumerable.Range(1, 1024).Select(a => new { A = a}).ToICollection();
            var dict = new SortedDictionary<int, int>(x.ToDictionary(a => a, a => a));

            Assert.AreEqual(ZEnumerable.First(x, val => val%3 == 0), Enumerable.First(x, val => val%3 == 0));
            Assert.AreEqual(ZEnumerable.First(y, val => val.Item1%3 == 0), Enumerable.First(y, val => val.Item1%3 == 0));
            Assert.AreEqual(ZEnumerable.First(z, val => val.A%3 == 0), Enumerable.First(z, val => val.A%3 == 0));
            Assert.AreEqual(ZEnumerable.First(dict, val => val.Key%3 == 0), Enumerable.First(dict, val => val.Key%3 == 0));
        }

        [TestMethod]
        public void FirstICollectionOrDefaultPredicate()
        {
            var x = Enumerable.Range(1, 1024).ToICollection();
            var y = Enumerable.Range(1, 1024).Select(a => new Tuple<int, int>(a,a)).ToICollection();
            var z = new Tuple<int, int>[0].ToICollection();
            var dict = new SortedDictionary<int, int>(x.ToDictionary(a => a, a => a));

            Assert.AreEqual(ZEnumerable.FirstOrDefault(x, val => val%3 == 0), Enumerable.FirstOrDefault(x, val => val%3 == 0));
            Assert.AreEqual(ZEnumerable.FirstOrDefault(y, val => val.Item1%3 == 0), Enumerable.FirstOrDefault(y, val => val.Item1%3 == 0));
            Assert.AreEqual(ZEnumerable.FirstOrDefault(z, val => val.Item1%3 == 0), Enumerable.FirstOrDefault(z, val => val.Item1%3 == 0));
            Assert.AreEqual(ZEnumerable.FirstOrDefault(dict, val => val.Key%3 == 0), Enumerable.FirstOrDefault(dict, val => val.Key%3 == 0));
        }

		[TestMethod]
        public void FirstICollectionInvalidInput()
        {
			ICollection<int> x = null;
			try
			{
				ZEnumerable.First(x);
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
			}

            var y = new int[0].ToICollection();
			try
			{
				ZEnumerable.First(y);
				Assert.Fail();
			}
			catch (InvalidOperationException)
			{
			}

			var z = Enumerable.Range(1, 1).Select(a => new Tuple<int, int>(a, a)).ToICollection();
			try
			{
				ZEnumerable.First(z, null);
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
			}

			try
			{
				ZEnumerable.First(z, _ => false);
				Assert.Fail();
			}
			catch (InvalidOperationException)
			{
			}
        }

		
		[TestMethod]
        public void FirstOrDefaultICollectionInvalidInput()
        {
			ICollection<int> x = null;
			try
			{
				ZEnumerable.FirstOrDefault(x);
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
			}

			var z = Enumerable.Range(1, 1).Select(a => new Tuple<int, int>(a, a)).ToICollection();

			try
			{
				ZEnumerable.FirstOrDefault(z, null);
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
			}
        }

            


    }
}
