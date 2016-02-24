
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
        public void TestSelectToArrayFromArray1()
        {
            var source = Enumerable.Range(1, 1).ToArray();

            var xArr = source.SelectToArray(x => x * x).ToArray();
            var linqArr = source.Select(x => x * x).ToArray();

            Assert.IsTrue(xArr.Length == linqArr.Length);
            Assert.IsTrue(xArr.SequenceEqual(linqArr));
        }
		 

        [TestMethod]
        public void TestSelectToArrayFromArray2()
        {
            var source = Enumerable.Range(1, 2).ToArray();

            var xArr = source.SelectToArray(x => x * x).ToArray();
            var linqArr = source.Select(x => x * x).ToArray();

            Assert.IsTrue(xArr.Length == linqArr.Length);
            Assert.IsTrue(xArr.SequenceEqual(linqArr));
        }
		 

        [TestMethod]
        public void TestSelectToArrayFromArray3()
        {
            var source = Enumerable.Range(1, 3).ToArray();

            var xArr = source.SelectToArray(x => x * x).ToArray();
            var linqArr = source.Select(x => x * x).ToArray();

            Assert.IsTrue(xArr.Length == linqArr.Length);
            Assert.IsTrue(xArr.SequenceEqual(linqArr));
        }
		 

        [TestMethod]
        public void TestSelectToArrayFromArray4()
        {
            var source = Enumerable.Range(1, 4).ToArray();

            var xArr = source.SelectToArray(x => x * x).ToArray();
            var linqArr = source.Select(x => x * x).ToArray();

            Assert.IsTrue(xArr.Length == linqArr.Length);
            Assert.IsTrue(xArr.SequenceEqual(linqArr));
        }
		 

        [TestMethod]
        public void TestSelectToArrayFromArray100()
        {
            var source = Enumerable.Range(1, 100).ToArray();

            var xArr = source.SelectToArray(x => x * x).ToArray();
            var linqArr = source.Select(x => x * x).ToArray();

            Assert.IsTrue(xArr.Length == linqArr.Length);
            Assert.IsTrue(xArr.SequenceEqual(linqArr));
        }
		 

        [TestMethod]
        public void TestSelectToArrayFromArray4096()
        {
            var source = Enumerable.Range(1, 4096).ToArray();

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
        public void TestSelectToArrayFromList1()
        {
            var source = Enumerable.Range(1, 1).ToList();

            var xArr = source.SelectToArray(x => x * x).ToArray();
            var linqArr = source.Select(x => x * x).ToArray();

            Assert.IsTrue(xArr.Length == linqArr.Length);
            Assert.IsTrue(xArr.SequenceEqual(linqArr));
        }
		 

        [TestMethod]
        public void TestSelectToArrayFromList2()
        {
            var source = Enumerable.Range(1, 2).ToList();

            var xArr = source.SelectToArray(x => x * x).ToArray();
            var linqArr = source.Select(x => x * x).ToArray();

            Assert.IsTrue(xArr.Length == linqArr.Length);
            Assert.IsTrue(xArr.SequenceEqual(linqArr));
        }
		 

        [TestMethod]
        public void TestSelectToArrayFromList3()
        {
            var source = Enumerable.Range(1, 3).ToList();

            var xArr = source.SelectToArray(x => x * x).ToArray();
            var linqArr = source.Select(x => x * x).ToArray();

            Assert.IsTrue(xArr.Length == linqArr.Length);
            Assert.IsTrue(xArr.SequenceEqual(linqArr));
        }
		 

        [TestMethod]
        public void TestSelectToArrayFromList4()
        {
            var source = Enumerable.Range(1, 4).ToList();

            var xArr = source.SelectToArray(x => x * x).ToArray();
            var linqArr = source.Select(x => x * x).ToArray();

            Assert.IsTrue(xArr.Length == linqArr.Length);
            Assert.IsTrue(xArr.SequenceEqual(linqArr));
        }
		 

        [TestMethod]
        public void TestSelectToArrayFromList100()
        {
            var source = Enumerable.Range(1, 100).ToList();

            var xArr = source.SelectToArray(x => x * x).ToArray();
            var linqArr = source.Select(x => x * x).ToArray();

            Assert.IsTrue(xArr.Length == linqArr.Length);
            Assert.IsTrue(xArr.SequenceEqual(linqArr));
        }
		 

        [TestMethod]
        public void TestSelectToArrayFromList4096()
        {
            var source = Enumerable.Range(1, 4096).ToList();

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
        public void TestSelectToArrayFromIList1()
        {
            var source = Enumerable.Range(1, 1).ToIList();

            var xArr = source.SelectToArray(x => x * x).ToArray();
            var linqArr = source.Select(x => x * x).ToArray();

            Assert.IsTrue(xArr.Length == linqArr.Length);
            Assert.IsTrue(xArr.SequenceEqual(linqArr));
        }
		 

        [TestMethod]
        public void TestSelectToArrayFromIList2()
        {
            var source = Enumerable.Range(1, 2).ToIList();

            var xArr = source.SelectToArray(x => x * x).ToArray();
            var linqArr = source.Select(x => x * x).ToArray();

            Assert.IsTrue(xArr.Length == linqArr.Length);
            Assert.IsTrue(xArr.SequenceEqual(linqArr));
        }
		 

        [TestMethod]
        public void TestSelectToArrayFromIList3()
        {
            var source = Enumerable.Range(1, 3).ToIList();

            var xArr = source.SelectToArray(x => x * x).ToArray();
            var linqArr = source.Select(x => x * x).ToArray();

            Assert.IsTrue(xArr.Length == linqArr.Length);
            Assert.IsTrue(xArr.SequenceEqual(linqArr));
        }
		 

        [TestMethod]
        public void TestSelectToArrayFromIList4()
        {
            var source = Enumerable.Range(1, 4).ToIList();

            var xArr = source.SelectToArray(x => x * x).ToArray();
            var linqArr = source.Select(x => x * x).ToArray();

            Assert.IsTrue(xArr.Length == linqArr.Length);
            Assert.IsTrue(xArr.SequenceEqual(linqArr));
        }
		 

        [TestMethod]
        public void TestSelectToArrayFromIList100()
        {
            var source = Enumerable.Range(1, 100).ToIList();

            var xArr = source.SelectToArray(x => x * x).ToArray();
            var linqArr = source.Select(x => x * x).ToArray();

            Assert.IsTrue(xArr.Length == linqArr.Length);
            Assert.IsTrue(xArr.SequenceEqual(linqArr));
        }
		 

        [TestMethod]
        public void TestSelectToArrayFromIList4096()
        {
            var source = Enumerable.Range(1, 4096).ToIList();

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
        public void TestSelectToArrayFromICollection1()
        {
            var source = Enumerable.Range(1, 1).ToICollection();

            var xArr = source.SelectToArray(x => x * x).ToArray();
            var linqArr = source.Select(x => x * x).ToArray();

            Assert.IsTrue(xArr.Length == linqArr.Length);
            Assert.IsTrue(xArr.SequenceEqual(linqArr));
        }
		 

        [TestMethod]
        public void TestSelectToArrayFromICollection2()
        {
            var source = Enumerable.Range(1, 2).ToICollection();

            var xArr = source.SelectToArray(x => x * x).ToArray();
            var linqArr = source.Select(x => x * x).ToArray();

            Assert.IsTrue(xArr.Length == linqArr.Length);
            Assert.IsTrue(xArr.SequenceEqual(linqArr));
        }
		 

        [TestMethod]
        public void TestSelectToArrayFromICollection3()
        {
            var source = Enumerable.Range(1, 3).ToICollection();

            var xArr = source.SelectToArray(x => x * x).ToArray();
            var linqArr = source.Select(x => x * x).ToArray();

            Assert.IsTrue(xArr.Length == linqArr.Length);
            Assert.IsTrue(xArr.SequenceEqual(linqArr));
        }
		 

        [TestMethod]
        public void TestSelectToArrayFromICollection4()
        {
            var source = Enumerable.Range(1, 4).ToICollection();

            var xArr = source.SelectToArray(x => x * x).ToArray();
            var linqArr = source.Select(x => x * x).ToArray();

            Assert.IsTrue(xArr.Length == linqArr.Length);
            Assert.IsTrue(xArr.SequenceEqual(linqArr));
        }
		 

        [TestMethod]
        public void TestSelectToArrayFromICollection100()
        {
            var source = Enumerable.Range(1, 100).ToICollection();

            var xArr = source.SelectToArray(x => x * x).ToArray();
            var linqArr = source.Select(x => x * x).ToArray();

            Assert.IsTrue(xArr.Length == linqArr.Length);
            Assert.IsTrue(xArr.SequenceEqual(linqArr));
        }
		 

        [TestMethod]
        public void TestSelectToArrayFromICollection4096()
        {
            var source = Enumerable.Range(1, 4096).ToICollection();

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
        public void TestSelectToListFromICollection1()
        {
            var source = Enumerable.Range(1, 1).ToICollection();

            var xArr = source.SelectToList(x => x * x).ToArray();
            var linqArr = source.Select(x => x * x).ToArray();

            Assert.IsTrue(xArr.Length == linqArr.Length);
            Assert.IsTrue(xArr.SequenceEqual(linqArr));
        }
		 

        [TestMethod]
        public void TestSelectToListFromICollection2()
        {
            var source = Enumerable.Range(1, 2).ToICollection();

            var xArr = source.SelectToList(x => x * x).ToArray();
            var linqArr = source.Select(x => x * x).ToArray();

            Assert.IsTrue(xArr.Length == linqArr.Length);
            Assert.IsTrue(xArr.SequenceEqual(linqArr));
        }
		 

        [TestMethod]
        public void TestSelectToListFromICollection3()
        {
            var source = Enumerable.Range(1, 3).ToICollection();

            var xArr = source.SelectToList(x => x * x).ToArray();
            var linqArr = source.Select(x => x * x).ToArray();

            Assert.IsTrue(xArr.Length == linqArr.Length);
            Assert.IsTrue(xArr.SequenceEqual(linqArr));
        }
		 

        [TestMethod]
        public void TestSelectToListFromICollection4()
        {
            var source = Enumerable.Range(1, 4).ToICollection();

            var xArr = source.SelectToList(x => x * x).ToArray();
            var linqArr = source.Select(x => x * x).ToArray();

            Assert.IsTrue(xArr.Length == linqArr.Length);
            Assert.IsTrue(xArr.SequenceEqual(linqArr));
        }
		 

        [TestMethod]
        public void TestSelectToListFromICollection100()
        {
            var source = Enumerable.Range(1, 100).ToICollection();

            var xArr = source.SelectToList(x => x * x).ToArray();
            var linqArr = source.Select(x => x * x).ToArray();

            Assert.IsTrue(xArr.Length == linqArr.Length);
            Assert.IsTrue(xArr.SequenceEqual(linqArr));
        }
		 

        [TestMethod]
        public void TestSelectToListFromICollection4096()
        {
            var source = Enumerable.Range(1, 4096).ToICollection();

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
		        
				 

        [TestMethod]
        public void TestSelectToListFromIEnumerable1()
        {
            var source = Enumerable.Range(1, 1).ToIEnumerable();

            var xArr = source.SelectToList(x => x * x).ToArray();
            var linqArr = source.Select(x => x * x).ToArray();

            Assert.IsTrue(xArr.Length == linqArr.Length);
            Assert.IsTrue(xArr.SequenceEqual(linqArr));
        }
		 

        [TestMethod]
        public void TestSelectToListFromIEnumerable2()
        {
            var source = Enumerable.Range(1, 2).ToIEnumerable();

            var xArr = source.SelectToList(x => x * x).ToArray();
            var linqArr = source.Select(x => x * x).ToArray();

            Assert.IsTrue(xArr.Length == linqArr.Length);
            Assert.IsTrue(xArr.SequenceEqual(linqArr));
        }
		 

        [TestMethod]
        public void TestSelectToListFromIEnumerable3()
        {
            var source = Enumerable.Range(1, 3).ToIEnumerable();

            var xArr = source.SelectToList(x => x * x).ToArray();
            var linqArr = source.Select(x => x * x).ToArray();

            Assert.IsTrue(xArr.Length == linqArr.Length);
            Assert.IsTrue(xArr.SequenceEqual(linqArr));
        }
		 

        [TestMethod]
        public void TestSelectToListFromIEnumerable4()
        {
            var source = Enumerable.Range(1, 4).ToIEnumerable();

            var xArr = source.SelectToList(x => x * x).ToArray();
            var linqArr = source.Select(x => x * x).ToArray();

            Assert.IsTrue(xArr.Length == linqArr.Length);
            Assert.IsTrue(xArr.SequenceEqual(linqArr));
        }
		 

        [TestMethod]
        public void TestSelectToListFromIEnumerable100()
        {
            var source = Enumerable.Range(1, 100).ToIEnumerable();

            var xArr = source.SelectToList(x => x * x).ToArray();
            var linqArr = source.Select(x => x * x).ToArray();

            Assert.IsTrue(xArr.Length == linqArr.Length);
            Assert.IsTrue(xArr.SequenceEqual(linqArr));
        }
		 

        [TestMethod]
        public void TestSelectToListFromIEnumerable4096()
        {
            var source = Enumerable.Range(1, 4096).ToIEnumerable();

            var xArr = source.SelectToList(x => x * x).ToArray();
            var linqArr = source.Select(x => x * x).ToArray();

            Assert.IsTrue(xArr.Length == linqArr.Length);
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

            var source = Enumerable.Range(1, 100).ToIEnumerable();
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
