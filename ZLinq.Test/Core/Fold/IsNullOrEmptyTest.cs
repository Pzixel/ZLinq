
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZLinq.Test.Helpers;

namespace ZLinq.Test.Core.Fold
{
    [TestClass]
    public class IsNullOrEmptyTest
	{        
				
		[TestMethod]
        public void IsNullOrEmptyArray()
        {
            int[] sourceA = new int[0].ToArray();
			int[] sourceB = null;
			int[] sourceC = new[] {1,2,3}.ToArray();

			Assert.IsTrue(sourceA.IsNullOrEmpty());
			Assert.IsTrue(sourceB.IsNullOrEmpty());
			Assert.IsFalse(sourceC.IsNullOrEmpty());
        }

				
		[TestMethod]
        public void IsNullOrEmptyList()
        {
            List<int> sourceA = new int[0].ToList();
			List<int> sourceB = null;
			List<int> sourceC = new[] {1,2,3}.ToList();

			Assert.IsTrue(sourceA.IsNullOrEmpty());
			Assert.IsTrue(sourceB.IsNullOrEmpty());
			Assert.IsFalse(sourceC.IsNullOrEmpty());
        }

				
		[TestMethod]
        public void IsNullOrEmptyIList()
        {
            IList<int> sourceA = new int[0].ToIList();
			IList<int> sourceB = null;
			IList<int> sourceC = new[] {1,2,3}.ToIList();

			Assert.IsTrue(sourceA.IsNullOrEmpty());
			Assert.IsTrue(sourceB.IsNullOrEmpty());
			Assert.IsFalse(sourceC.IsNullOrEmpty());
        }

				
		[TestMethod]
        public void IsNullOrEmptyICollection()
        {
            ICollection<int> sourceA = new int[0].ToICollection();
			ICollection<int> sourceB = null;
			ICollection<int> sourceC = new[] {1,2,3}.ToICollection();

			Assert.IsTrue(sourceA.IsNullOrEmpty());
			Assert.IsTrue(sourceB.IsNullOrEmpty());
			Assert.IsFalse(sourceC.IsNullOrEmpty());
        }

				
		[TestMethod]
        public void IsNullOrEmptyIEnumerable()
        {
            IEnumerable<int> sourceA = new int[0].ToIEnumerable();
			IEnumerable<int> sourceB = null;
			IEnumerable<int> sourceC = new[] {1,2,3}.ToIEnumerable();

			Assert.IsTrue(sourceA.IsNullOrEmpty());
			Assert.IsTrue(sourceB.IsNullOrEmpty());
			Assert.IsFalse(sourceC.IsNullOrEmpty());
        }

				
		[TestMethod]
        public void IsNullOrEmptyIListNonGen()
        {
            IList sourceA = new int[0].ToIListNonGen();
			IList sourceB = null;
			IList sourceC = new[] {1,2,3}.ToIListNonGen();

			Assert.IsTrue(sourceA.IsNullOrEmpty());
			Assert.IsTrue(sourceB.IsNullOrEmpty());
			Assert.IsFalse(sourceC.IsNullOrEmpty());
        }

				
		[TestMethod]
        public void IsNullOrEmptyICollectionNonGen()
        {
            ICollection sourceA = new int[0].ToICollectionNonGen();
			ICollection sourceB = null;
			ICollection sourceC = new[] {1,2,3}.ToICollectionNonGen();

			Assert.IsTrue(sourceA.IsNullOrEmpty());
			Assert.IsTrue(sourceB.IsNullOrEmpty());
			Assert.IsFalse(sourceC.IsNullOrEmpty());
        }

				
		[TestMethod]
        public void IsNullOrEmptyIEnumerableNonGen()
        {
            IEnumerable sourceA = new int[0].ToIEnumerableNonGen();
			IEnumerable sourceB = null;
			IEnumerable sourceC = new[] {1,2,3}.ToIEnumerableNonGen();

			Assert.IsTrue(sourceA.IsNullOrEmpty());
			Assert.IsTrue(sourceB.IsNullOrEmpty());
			Assert.IsFalse(sourceC.IsNullOrEmpty());
        }

		
		[TestMethod]
        public void IsNullOrEmptyString()
        {
            string sourceA = string.Empty;
            string sourceB = null;
            string sourceC = "Hello world!";

            Assert.IsTrue(sourceA.IsNullOrEmpty());
            Assert.IsTrue(sourceB.IsNullOrEmpty());
            Assert.IsFalse(sourceC.IsNullOrEmpty());
        }
    }
}
