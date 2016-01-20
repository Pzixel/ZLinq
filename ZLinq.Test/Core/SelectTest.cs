
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZLinq;

namespace ZLinq.Test.Core
{
    [TestClass]
    public class Select
    {		    
		[TestMethod]
	    public void TestSelectToArrayFromICollection()
        {
            var source = (ICollection<int>) Enumerable.Range(1, 100).ToArray();

            var xArr = source.SelectToArray(x => x * x);
            var linqArr = source.Select(x => x * x).ToArray();

            Assert.IsTrue(xArr.Length == linqArr.Length);
            Assert.IsTrue(xArr.SequenceEqual(linqArr));      
        }		
		
		[TestMethod]
        public void TestSelectToArrayFromICollectionInvalidArguments()
        {
            ICollection<int> nullSource = null;

            try
			{
				nullSource.SelectToArray(x => x * x);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			var source = (ICollection<int>) Enumerable.Range(1, 100).ToArray();
			try
			{
				source.SelectToArray<int, int>(null);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }	

		
		[TestMethod]
        public void TestSelectToArrayFromArray()
        {
            var source = (int[]) Enumerable.Range(1, 100).ToArray();

            var xArr = source.SelectToArray(x => x * x);
            var linqArr = source.Select(x => x * x).ToArray();

            Assert.IsTrue(xArr.Length == linqArr.Length);
            Assert.IsTrue(xArr.SequenceEqual(linqArr));
        }

		[TestMethod]
        public void TestSelectToArrayFromArrayInvalidArguments()
        {
            int[] nullSource = null;

            try
			{
				nullSource.SelectToArray(x => x * x);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			var source = (int[]) Enumerable.Range(1, 100).ToArray();
			try
			{
				source.SelectToArray<int, int>(null);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }

		
		[TestMethod]
        public void TestSelectToArrayFromList()
        {
            var source = (List<int>) Enumerable.Range(1, 100).ToList();

            var xArr = source.SelectToArray(x => x * x);
            var linqArr = source.Select(x => x * x).ToArray();

            Assert.IsTrue(xArr.Length == linqArr.Length);
            Assert.IsTrue(xArr.SequenceEqual(linqArr));
        }

		[TestMethod]
        public void TestSelectToArrayFromListInvalidArguments()
        {
            List<int> nullSource = null;

            try
			{
				nullSource.SelectToArray(x => x * x);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			var source = (List<int>) Enumerable.Range(1, 100).ToList();
			try
			{
				source.SelectToArray<int, int>(null);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }

		
		[TestMethod]
        public void TestSelectToArrayFromIList()
        {
            var source = (IList<int>) Enumerable.Range(1, 100).ToList();

            var xArr = source.SelectToArray(x => x * x);
            var linqArr = source.Select(x => x * x).ToArray();

            Assert.IsTrue(xArr.Length == linqArr.Length);
            Assert.IsTrue(xArr.SequenceEqual(linqArr));
        }

		[TestMethod]
        public void TestSelectToArrayFromIListInvalidArguments()
        {
            IList<int> nullSource = null;

            try
			{
				nullSource.SelectToArray(x => x * x);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			var source = (IList<int>) Enumerable.Range(1, 100).ToList();
			try
			{
				source.SelectToArray<int, int>(null);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }

			

		[TestMethod]
        public void TestSelectToListFromICollection()
        {
            var source = (ICollection<int>) Enumerable.Range(1, 100).ToList();

            var xArr = source.SelectToList(x => x * x);
            var linqArr = source.Select(x => x * x).ToList();

            Assert.IsTrue(xArr.Count == linqArr.Count);
            Assert.IsTrue(xArr.SequenceEqual(linqArr));
        }

		[TestMethod]
        public void TestSelectToListFromICollectionInvalidArguments()
        {
            ICollection<int> nullSource = null;

            try
			{
				nullSource.SelectToList(x => x * x);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			var source = (ICollection<int>) Enumerable.Range(1, 100).ToList();
			try
			{
				source.SelectToList<int, int>(null);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }

        [TestMethod]
        public void TestSelectToListFromIEnumerable()
        {
            var source = (IEnumerable<int>) Enumerable.Range(1, 100).ToList();

            var xArr = source.SelectToList(x => x * x);
            var linqArr = source.Select(x => x * x).ToList();

            Assert.IsTrue(xArr.Count == linqArr.Count);
            Assert.IsTrue(xArr.SequenceEqual(linqArr));
        }

		[TestMethod]
        public void TestSelectToListFromIEnumerableInvalidArguments()
        {
            IEnumerable<int> nullSource = null;

            try
			{
				nullSource.SelectToList(x => x * x);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			var source = (IEnumerable<int>) Enumerable.Range(1, 100).ToList();
			try
			{
				source.SelectToList<int, int>(null);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }
    }
}
