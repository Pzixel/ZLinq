
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZLinq.Test.Helpers;

namespace ZLinq.Test.Core.Fold
{
    [TestClass]
    public class HasSeveralItems
    {    
                
        [TestMethod]
        public void HasSeveralItemsArray()
        {
            var x = Enumerable.Range(1, 1024).ToArray();
            var y = Enumerable.Range(1, 1024).Select(a => new Tuple<int, int>(a,a)).ToArray();
            var z = Enumerable.Range(1, 1024).Select(a => new { A = a}).ToArray();
            var dict = new SortedDictionary<int, int>(x.ToDictionary(a => a, a => a));

            Assert.IsTrue(x.HasSeveralItems(10));
			Assert.IsTrue(x.HasSeveralItems(1000));
			Assert.IsFalse(x.HasSeveralItems(1025));			
			Assert.IsTrue(y.HasSeveralItems(10));
			Assert.IsTrue(y.HasSeveralItems(1000));
			Assert.IsFalse(y.HasSeveralItems(1025));
			Assert.IsTrue(z.HasSeveralItems(10));
			Assert.IsTrue(z.HasSeveralItems(1000));
			Assert.IsFalse(z.HasSeveralItems(1025));
			Assert.IsTrue(dict.HasSeveralItems(10));
			Assert.IsTrue(dict.HasSeveralItems(1000));
			Assert.IsFalse(dict.HasSeveralItems(1025));
        }

        [TestMethod]
        public void HasSeveralItemsArrayPredicate()
        {
            var x = Enumerable.Range(1, 1024).ToArray();
            var y = Enumerable.Range(1, 1024).Select(a => new Tuple<int, int>(a,a)).ToArray();
            var z = Enumerable.Range(1, 1024).Select(a => new { A = a}).ToArray();
            var dict = new SortedDictionary<int, int>(x.ToDictionary(a => a, a => a));
			Assert.IsTrue(x.HasSeveralItems(10, val => val%3 == 0));
			Assert.IsTrue(x.HasSeveralItems(300, val => val%3 == 0));
			Assert.IsFalse(x.HasSeveralItems(1025, val => val%3 == 0));			
			Assert.IsTrue(y.HasSeveralItems(10, val => val.Item1%3 == 0));
			Assert.IsTrue(y.HasSeveralItems(300, val => val.Item1%3 == 0));
			Assert.IsFalse(y.HasSeveralItems(1025, val => val.Item1%3 == 0));
			Assert.IsTrue(z.HasSeveralItems(10, val => val.A%3 == 0));
			Assert.IsTrue(z.HasSeveralItems(300, val => val.A%3 == 0));
			Assert.IsFalse(z.HasSeveralItems(1025, val => val.A%3 == 0));
			Assert.IsTrue(dict.HasSeveralItems(10, val => val.Key%3 == 0));
			Assert.IsTrue(dict.HasSeveralItems(300, val => val.Key%3 == 0));
			Assert.IsFalse(dict.HasSeveralItems(1025, val => val.Key%3 == 0));
        }

		[TestMethod]
        public void HasSeveralItemsArrayInvalidInput()
        {
			int[] x = null;
			try
			{
				x.HasSeveralItems(0);
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
			}
        }

		
		[TestMethod]
        public void HasSeveralItemsArrayInvalidInputPredicate()
        {
			int[] x = null;
			try
			{
				x.HasSeveralItems(0);
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
			}

			var z = Enumerable.Range(1, 1).Select(a => new Tuple<int, int>(a, a)).ToArray();

			try
			{
				z.HasSeveralItems(0, null);
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
			}
        }

                
        [TestMethod]
        public void HasSeveralItemsList()
        {
            var x = Enumerable.Range(1, 1024).ToList();
            var y = Enumerable.Range(1, 1024).Select(a => new Tuple<int, int>(a,a)).ToList();
            var z = Enumerable.Range(1, 1024).Select(a => new { A = a}).ToList();
            var dict = new SortedDictionary<int, int>(x.ToDictionary(a => a, a => a));

            Assert.IsTrue(x.HasSeveralItems(10));
			Assert.IsTrue(x.HasSeveralItems(1000));
			Assert.IsFalse(x.HasSeveralItems(1025));			
			Assert.IsTrue(y.HasSeveralItems(10));
			Assert.IsTrue(y.HasSeveralItems(1000));
			Assert.IsFalse(y.HasSeveralItems(1025));
			Assert.IsTrue(z.HasSeveralItems(10));
			Assert.IsTrue(z.HasSeveralItems(1000));
			Assert.IsFalse(z.HasSeveralItems(1025));
			Assert.IsTrue(dict.HasSeveralItems(10));
			Assert.IsTrue(dict.HasSeveralItems(1000));
			Assert.IsFalse(dict.HasSeveralItems(1025));
        }

        [TestMethod]
        public void HasSeveralItemsListPredicate()
        {
            var x = Enumerable.Range(1, 1024).ToList();
            var y = Enumerable.Range(1, 1024).Select(a => new Tuple<int, int>(a,a)).ToList();
            var z = Enumerable.Range(1, 1024).Select(a => new { A = a}).ToList();
            var dict = new SortedDictionary<int, int>(x.ToDictionary(a => a, a => a));
			Assert.IsTrue(x.HasSeveralItems(10, val => val%3 == 0));
			Assert.IsTrue(x.HasSeveralItems(300, val => val%3 == 0));
			Assert.IsFalse(x.HasSeveralItems(1025, val => val%3 == 0));			
			Assert.IsTrue(y.HasSeveralItems(10, val => val.Item1%3 == 0));
			Assert.IsTrue(y.HasSeveralItems(300, val => val.Item1%3 == 0));
			Assert.IsFalse(y.HasSeveralItems(1025, val => val.Item1%3 == 0));
			Assert.IsTrue(z.HasSeveralItems(10, val => val.A%3 == 0));
			Assert.IsTrue(z.HasSeveralItems(300, val => val.A%3 == 0));
			Assert.IsFalse(z.HasSeveralItems(1025, val => val.A%3 == 0));
			Assert.IsTrue(dict.HasSeveralItems(10, val => val.Key%3 == 0));
			Assert.IsTrue(dict.HasSeveralItems(300, val => val.Key%3 == 0));
			Assert.IsFalse(dict.HasSeveralItems(1025, val => val.Key%3 == 0));
        }

		[TestMethod]
        public void HasSeveralItemsListInvalidInput()
        {
			List<int> x = null;
			try
			{
				x.HasSeveralItems(0);
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
			}
        }

		
		[TestMethod]
        public void HasSeveralItemsListInvalidInputPredicate()
        {
			List<int> x = null;
			try
			{
				x.HasSeveralItems(0);
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
			}

			var z = Enumerable.Range(1, 1).Select(a => new Tuple<int, int>(a, a)).ToList();

			try
			{
				z.HasSeveralItems(0, null);
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
			}
        }

                
        [TestMethod]
        public void HasSeveralItemsIList()
        {
            var x = Enumerable.Range(1, 1024).ToIList();
            var y = Enumerable.Range(1, 1024).Select(a => new Tuple<int, int>(a,a)).ToIList();
            var z = Enumerable.Range(1, 1024).Select(a => new { A = a}).ToIList();
            var dict = new SortedDictionary<int, int>(x.ToDictionary(a => a, a => a));

            Assert.IsTrue(x.HasSeveralItems(10));
			Assert.IsTrue(x.HasSeveralItems(1000));
			Assert.IsFalse(x.HasSeveralItems(1025));			
			Assert.IsTrue(y.HasSeveralItems(10));
			Assert.IsTrue(y.HasSeveralItems(1000));
			Assert.IsFalse(y.HasSeveralItems(1025));
			Assert.IsTrue(z.HasSeveralItems(10));
			Assert.IsTrue(z.HasSeveralItems(1000));
			Assert.IsFalse(z.HasSeveralItems(1025));
			Assert.IsTrue(dict.HasSeveralItems(10));
			Assert.IsTrue(dict.HasSeveralItems(1000));
			Assert.IsFalse(dict.HasSeveralItems(1025));
        }

        [TestMethod]
        public void HasSeveralItemsIListPredicate()
        {
            var x = Enumerable.Range(1, 1024).ToIList();
            var y = Enumerable.Range(1, 1024).Select(a => new Tuple<int, int>(a,a)).ToIList();
            var z = Enumerable.Range(1, 1024).Select(a => new { A = a}).ToIList();
            var dict = new SortedDictionary<int, int>(x.ToDictionary(a => a, a => a));
			Assert.IsTrue(x.HasSeveralItems(10, val => val%3 == 0));
			Assert.IsTrue(x.HasSeveralItems(300, val => val%3 == 0));
			Assert.IsFalse(x.HasSeveralItems(1025, val => val%3 == 0));			
			Assert.IsTrue(y.HasSeveralItems(10, val => val.Item1%3 == 0));
			Assert.IsTrue(y.HasSeveralItems(300, val => val.Item1%3 == 0));
			Assert.IsFalse(y.HasSeveralItems(1025, val => val.Item1%3 == 0));
			Assert.IsTrue(z.HasSeveralItems(10, val => val.A%3 == 0));
			Assert.IsTrue(z.HasSeveralItems(300, val => val.A%3 == 0));
			Assert.IsFalse(z.HasSeveralItems(1025, val => val.A%3 == 0));
			Assert.IsTrue(dict.HasSeveralItems(10, val => val.Key%3 == 0));
			Assert.IsTrue(dict.HasSeveralItems(300, val => val.Key%3 == 0));
			Assert.IsFalse(dict.HasSeveralItems(1025, val => val.Key%3 == 0));
        }

		[TestMethod]
        public void HasSeveralItemsIListInvalidInput()
        {
			IList<int> x = null;
			try
			{
				x.HasSeveralItems(0);
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
			}
        }

		
		[TestMethod]
        public void HasSeveralItemsIListInvalidInputPredicate()
        {
			IList<int> x = null;
			try
			{
				x.HasSeveralItems(0);
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
			}

			var z = Enumerable.Range(1, 1).Select(a => new Tuple<int, int>(a, a)).ToIList();

			try
			{
				z.HasSeveralItems(0, null);
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
			}
        }

                
        [TestMethod]
        public void HasSeveralItemsICollection()
        {
            var x = Enumerable.Range(1, 1024).ToICollection();
            var y = Enumerable.Range(1, 1024).Select(a => new Tuple<int, int>(a,a)).ToICollection();
            var z = Enumerable.Range(1, 1024).Select(a => new { A = a}).ToICollection();
            var dict = new SortedDictionary<int, int>(x.ToDictionary(a => a, a => a));

            Assert.IsTrue(x.HasSeveralItems(10));
			Assert.IsTrue(x.HasSeveralItems(1000));
			Assert.IsFalse(x.HasSeveralItems(1025));			
			Assert.IsTrue(y.HasSeveralItems(10));
			Assert.IsTrue(y.HasSeveralItems(1000));
			Assert.IsFalse(y.HasSeveralItems(1025));
			Assert.IsTrue(z.HasSeveralItems(10));
			Assert.IsTrue(z.HasSeveralItems(1000));
			Assert.IsFalse(z.HasSeveralItems(1025));
			Assert.IsTrue(dict.HasSeveralItems(10));
			Assert.IsTrue(dict.HasSeveralItems(1000));
			Assert.IsFalse(dict.HasSeveralItems(1025));
        }

        [TestMethod]
        public void HasSeveralItemsICollectionPredicate()
        {
            var x = Enumerable.Range(1, 1024).ToICollection();
            var y = Enumerable.Range(1, 1024).Select(a => new Tuple<int, int>(a,a)).ToICollection();
            var z = Enumerable.Range(1, 1024).Select(a => new { A = a}).ToICollection();
            var dict = new SortedDictionary<int, int>(x.ToDictionary(a => a, a => a));
			Assert.IsTrue(x.HasSeveralItems(10, val => val%3 == 0));
			Assert.IsTrue(x.HasSeveralItems(300, val => val%3 == 0));
			Assert.IsFalse(x.HasSeveralItems(1025, val => val%3 == 0));			
			Assert.IsTrue(y.HasSeveralItems(10, val => val.Item1%3 == 0));
			Assert.IsTrue(y.HasSeveralItems(300, val => val.Item1%3 == 0));
			Assert.IsFalse(y.HasSeveralItems(1025, val => val.Item1%3 == 0));
			Assert.IsTrue(z.HasSeveralItems(10, val => val.A%3 == 0));
			Assert.IsTrue(z.HasSeveralItems(300, val => val.A%3 == 0));
			Assert.IsFalse(z.HasSeveralItems(1025, val => val.A%3 == 0));
			Assert.IsTrue(dict.HasSeveralItems(10, val => val.Key%3 == 0));
			Assert.IsTrue(dict.HasSeveralItems(300, val => val.Key%3 == 0));
			Assert.IsFalse(dict.HasSeveralItems(1025, val => val.Key%3 == 0));
        }

		[TestMethod]
        public void HasSeveralItemsICollectionInvalidInput()
        {
			ICollection<int> x = null;
			try
			{
				x.HasSeveralItems(0);
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
			}
        }

		
		[TestMethod]
        public void HasSeveralItemsICollectionInvalidInputPredicate()
        {
			ICollection<int> x = null;
			try
			{
				x.HasSeveralItems(0);
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
			}

			var z = Enumerable.Range(1, 1).Select(a => new Tuple<int, int>(a, a)).ToICollection();

			try
			{
				z.HasSeveralItems(0, null);
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
			}
        }

                
        [TestMethod]
        public void HasSeveralItemsIEnumerable()
        {
            var x = Enumerable.Range(1, 1024).ToIEnumerable();
            var y = Enumerable.Range(1, 1024).Select(a => new Tuple<int, int>(a,a)).ToIEnumerable();
            var z = Enumerable.Range(1, 1024).Select(a => new { A = a}).ToIEnumerable();
            var dict = new SortedDictionary<int, int>(x.ToDictionary(a => a, a => a));

            Assert.IsTrue(x.HasSeveralItems(10));
			Assert.IsTrue(x.HasSeveralItems(1000));
			Assert.IsFalse(x.HasSeveralItems(1025));			
			Assert.IsTrue(y.HasSeveralItems(10));
			Assert.IsTrue(y.HasSeveralItems(1000));
			Assert.IsFalse(y.HasSeveralItems(1025));
			Assert.IsTrue(z.HasSeveralItems(10));
			Assert.IsTrue(z.HasSeveralItems(1000));
			Assert.IsFalse(z.HasSeveralItems(1025));
			Assert.IsTrue(dict.HasSeveralItems(10));
			Assert.IsTrue(dict.HasSeveralItems(1000));
			Assert.IsFalse(dict.HasSeveralItems(1025));
        }

        [TestMethod]
        public void HasSeveralItemsIEnumerablePredicate()
        {
            var x = Enumerable.Range(1, 1024).ToIEnumerable();
            var y = Enumerable.Range(1, 1024).Select(a => new Tuple<int, int>(a,a)).ToIEnumerable();
            var z = Enumerable.Range(1, 1024).Select(a => new { A = a}).ToIEnumerable();
            var dict = new SortedDictionary<int, int>(x.ToDictionary(a => a, a => a));
			Assert.IsTrue(x.HasSeveralItems(10, val => val%3 == 0));
			Assert.IsTrue(x.HasSeveralItems(300, val => val%3 == 0));
			Assert.IsFalse(x.HasSeveralItems(1025, val => val%3 == 0));			
			Assert.IsTrue(y.HasSeveralItems(10, val => val.Item1%3 == 0));
			Assert.IsTrue(y.HasSeveralItems(300, val => val.Item1%3 == 0));
			Assert.IsFalse(y.HasSeveralItems(1025, val => val.Item1%3 == 0));
			Assert.IsTrue(z.HasSeveralItems(10, val => val.A%3 == 0));
			Assert.IsTrue(z.HasSeveralItems(300, val => val.A%3 == 0));
			Assert.IsFalse(z.HasSeveralItems(1025, val => val.A%3 == 0));
			Assert.IsTrue(dict.HasSeveralItems(10, val => val.Key%3 == 0));
			Assert.IsTrue(dict.HasSeveralItems(300, val => val.Key%3 == 0));
			Assert.IsFalse(dict.HasSeveralItems(1025, val => val.Key%3 == 0));
        }

		[TestMethod]
        public void HasSeveralItemsIEnumerableInvalidInput()
        {
			IEnumerable<int> x = null;
			try
			{
				x.HasSeveralItems(0);
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
			}
        }

		
		[TestMethod]
        public void HasSeveralItemsIEnumerableInvalidInputPredicate()
        {
			IEnumerable<int> x = null;
			try
			{
				x.HasSeveralItems(0);
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
			}

			var z = Enumerable.Range(1, 1).Select(a => new Tuple<int, int>(a, a)).ToIEnumerable();

			try
			{
				z.HasSeveralItems(0, null);
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
			}
        }

            


    }
}
