using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ZLinq.Test.Core
{    
	[TestClass]
    public class Split
    {
		 

        [TestMethod]
        public void TestSplit()
        {
            int[] source = {1, 2, 3, 4, 5};
            var split = source.Split(2).ToArray();

            Assert.AreEqual(3, split.Length, "Array length mismatch");
            Assert.AreEqual(source[0], split[0][0]);
            Assert.AreEqual(source[1], split[0][1]);
            Assert.AreEqual(source[2], split[1][0]);
            Assert.AreEqual(source[3], split[1][1]);
            Assert.AreEqual(source[4], split[2][0]);
        }
		
		
        [TestMethod]
        public void TestSplitList()
        {
            var source = (List<int>) new List<int> { 1, 2, 3, 4, 5 };
            var split = source.Split(2).ToArray();

			var sourceArr = source.ToArray();
            Assert.AreEqual(3, split.Length, "Array length mismatch");
            Assert.AreEqual(sourceArr[0], split[0][0]);
            Assert.AreEqual(sourceArr[1], split[0][1]);
            Assert.AreEqual(sourceArr[2], split[1][0]);
            Assert.AreEqual(sourceArr[3], split[1][1]);
            Assert.AreEqual(sourceArr[4], split[2][0]);
        }

		[TestMethod]
        public void TestSplitListInvalidArguments()
        {
            List<int> nullSource = null;

            try
			{
				nullSource.Split(2).ToArray();			
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			var source = (List<int>) new List<int> { 1, 2, 3, 4, 5 };
			try
			{
				source.Split(0).ToArray();				
				Assert.Fail();
			}
			catch (ArgumentException)
			{
				
			}
        }	
		
        [TestMethod]
        public void TestSplitIList()
        {
            var source = (IList<int>) new List<int> { 1, 2, 3, 4, 5 };
            var split = source.Split(2).ToArray();

			var sourceArr = source.ToArray();
            Assert.AreEqual(3, split.Length, "Array length mismatch");
            Assert.AreEqual(sourceArr[0], split[0][0]);
            Assert.AreEqual(sourceArr[1], split[0][1]);
            Assert.AreEqual(sourceArr[2], split[1][0]);
            Assert.AreEqual(sourceArr[3], split[1][1]);
            Assert.AreEqual(sourceArr[4], split[2][0]);
        }

		[TestMethod]
        public void TestSplitIListInvalidArguments()
        {
            IList<int> nullSource = null;

            try
			{
				nullSource.Split(2).ToArray();			
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			var source = (IList<int>) new List<int> { 1, 2, 3, 4, 5 };
			try
			{
				source.Split(0).ToArray();				
				Assert.Fail();
			}
			catch (ArgumentException)
			{
				
			}
        }	
		
        [TestMethod]
        public void TestSplitICollection()
        {
            var source = (ICollection<int>) new List<int> { 1, 2, 3, 4, 5 };
            var split = source.Split(2).ToArray();

			var sourceArr = source.ToArray();
            Assert.AreEqual(3, split.Length, "Array length mismatch");
            Assert.AreEqual(sourceArr[0], split[0][0]);
            Assert.AreEqual(sourceArr[1], split[0][1]);
            Assert.AreEqual(sourceArr[2], split[1][0]);
            Assert.AreEqual(sourceArr[3], split[1][1]);
            Assert.AreEqual(sourceArr[4], split[2][0]);
        }

		[TestMethod]
        public void TestSplitICollectionInvalidArguments()
        {
            ICollection<int> nullSource = null;

            try
			{
				nullSource.Split(2).ToArray();			
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			var source = (ICollection<int>) new List<int> { 1, 2, 3, 4, 5 };
			try
			{
				source.Split(0).ToArray();				
				Assert.Fail();
			}
			catch (ArgumentException)
			{
				
			}
        }	
		
        [TestMethod]
        public void TestSplitIEnumerable()
        {
            var source = (IEnumerable<int>) new List<int> { 1, 2, 3, 4, 5 };
            var split = source.Split(2).ToArray();

			var sourceArr = source.ToArray();
            Assert.AreEqual(3, split.Length, "Array length mismatch");
            Assert.AreEqual(sourceArr[0], split[0][0]);
            Assert.AreEqual(sourceArr[1], split[0][1]);
            Assert.AreEqual(sourceArr[2], split[1][0]);
            Assert.AreEqual(sourceArr[3], split[1][1]);
            Assert.AreEqual(sourceArr[4], split[2][0]);
        }

		[TestMethod]
        public void TestSplitIEnumerableInvalidArguments()
        {
            IEnumerable<int> nullSource = null;

            try
			{
				nullSource.Split(2).ToArray();			
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			var source = (IEnumerable<int>) new List<int> { 1, 2, 3, 4, 5 };
			try
			{
				source.Split(0).ToArray();				
				Assert.Fail();
			}
			catch (ArgumentException)
			{
				
			}
        }	
		 

        [TestMethod]
        public void TestSplitToArray()
        {
            int[] source = {1, 2, 3, 4, 5};
            var split = source.SplitToArray(2).ToArray();

            Assert.AreEqual(3, split.Length, "Array length mismatch");
            Assert.AreEqual(source[0], split[0][0]);
            Assert.AreEqual(source[1], split[0][1]);
            Assert.AreEqual(source[2], split[1][0]);
            Assert.AreEqual(source[3], split[1][1]);
            Assert.AreEqual(source[4], split[2][0]);
        }
		
		
        [TestMethod]
        public void TestSplitListToArray()
        {
            var source = (List<int>) new List<int> { 1, 2, 3, 4, 5 };
            var split = source.SplitToArray(2).ToArray();

			var sourceArr = source.ToArray();
            Assert.AreEqual(3, split.Length, "Array length mismatch");
            Assert.AreEqual(sourceArr[0], split[0][0]);
            Assert.AreEqual(sourceArr[1], split[0][1]);
            Assert.AreEqual(sourceArr[2], split[1][0]);
            Assert.AreEqual(sourceArr[3], split[1][1]);
            Assert.AreEqual(sourceArr[4], split[2][0]);
        }

		[TestMethod]
        public void TestSplitListToArrayInvalidArguments()
        {
            List<int> nullSource = null;

            try
			{
				nullSource.SplitToArray(2).ToArray();			
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			var source = (List<int>) new List<int> { 1, 2, 3, 4, 5 };
			try
			{
				source.SplitToArray(0).ToArray();				
				Assert.Fail();
			}
			catch (ArgumentException)
			{
				
			}
        }	
		
        [TestMethod]
        public void TestSplitIListToArray()
        {
            var source = (IList<int>) new List<int> { 1, 2, 3, 4, 5 };
            var split = source.SplitToArray(2).ToArray();

			var sourceArr = source.ToArray();
            Assert.AreEqual(3, split.Length, "Array length mismatch");
            Assert.AreEqual(sourceArr[0], split[0][0]);
            Assert.AreEqual(sourceArr[1], split[0][1]);
            Assert.AreEqual(sourceArr[2], split[1][0]);
            Assert.AreEqual(sourceArr[3], split[1][1]);
            Assert.AreEqual(sourceArr[4], split[2][0]);
        }

		[TestMethod]
        public void TestSplitIListToArrayInvalidArguments()
        {
            IList<int> nullSource = null;

            try
			{
				nullSource.SplitToArray(2).ToArray();			
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			var source = (IList<int>) new List<int> { 1, 2, 3, 4, 5 };
			try
			{
				source.SplitToArray(0).ToArray();				
				Assert.Fail();
			}
			catch (ArgumentException)
			{
				
			}
        }	
		
        [TestMethod]
        public void TestSplitICollectionToArray()
        {
            var source = (ICollection<int>) new List<int> { 1, 2, 3, 4, 5 };
            var split = source.SplitToArray(2).ToArray();

			var sourceArr = source.ToArray();
            Assert.AreEqual(3, split.Length, "Array length mismatch");
            Assert.AreEqual(sourceArr[0], split[0][0]);
            Assert.AreEqual(sourceArr[1], split[0][1]);
            Assert.AreEqual(sourceArr[2], split[1][0]);
            Assert.AreEqual(sourceArr[3], split[1][1]);
            Assert.AreEqual(sourceArr[4], split[2][0]);
        }

		[TestMethod]
        public void TestSplitICollectionToArrayInvalidArguments()
        {
            ICollection<int> nullSource = null;

            try
			{
				nullSource.SplitToArray(2).ToArray();			
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			var source = (ICollection<int>) new List<int> { 1, 2, 3, 4, 5 };
			try
			{
				source.SplitToArray(0).ToArray();				
				Assert.Fail();
			}
			catch (ArgumentException)
			{
				
			}
        }	
		
        [TestMethod]
        public void TestSplitIEnumerableToArray()
        {
            var source = (IEnumerable<int>) new List<int> { 1, 2, 3, 4, 5 };
            var split = source.SplitToArray(2).ToArray();

			var sourceArr = source.ToArray();
            Assert.AreEqual(3, split.Length, "Array length mismatch");
            Assert.AreEqual(sourceArr[0], split[0][0]);
            Assert.AreEqual(sourceArr[1], split[0][1]);
            Assert.AreEqual(sourceArr[2], split[1][0]);
            Assert.AreEqual(sourceArr[3], split[1][1]);
            Assert.AreEqual(sourceArr[4], split[2][0]);
        }

		[TestMethod]
        public void TestSplitIEnumerableToArrayInvalidArguments()
        {
            IEnumerable<int> nullSource = null;

            try
			{
				nullSource.SplitToArray(2).ToArray();			
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			var source = (IEnumerable<int>) new List<int> { 1, 2, 3, 4, 5 };
			try
			{
				source.SplitToArray(0).ToArray();				
				Assert.Fail();
			}
			catch (ArgumentException)
			{
				
			}
        }	
		
    }
}