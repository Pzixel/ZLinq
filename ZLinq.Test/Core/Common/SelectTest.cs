
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZLinq.Test.Helpers;

namespace ZLinq.Test.Core.Common
{
    [TestClass]
    public class Select
	{

        
		
        [TestMethod]
        public void TestSelectToArrayFromArray()
        {
            var source = Enumerable.Range(1, 100).ToArray();

            var xArr = source.SelectToArray(x => x * x).ToArray();
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

            var source = Enumerable.Range(1, 100).ToArray();
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
            var source = Enumerable.Range(1, 100).ToList();

            var xArr = source.SelectToArray(x => x * x).ToArray();
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

            var source = Enumerable.Range(1, 100).ToList();
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
            var source = Enumerable.Range(1, 100).ToIList();

            var xArr = source.SelectToArray(x => x * x).ToArray();
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

            var source = Enumerable.Range(1, 100).ToIList();
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
        public void TestSelectToArrayFromICollection()
        {
            var source = Enumerable.Range(1, 100).ToICollection();

            var xArr = source.SelectToArray(x => x * x).ToArray();
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

            var source = Enumerable.Range(1, 100).ToICollection();
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
            var source = Enumerable.Range(1, 100).ToICollection();

            var xArr = source.SelectToList(x => x * x).ToArray();
            var linqArr = source.Select(x => x * x).ToArray();

            Assert.IsTrue(xArr.Length == linqArr.Length);
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

            var source = Enumerable.Range(1, 100).ToICollection();
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
