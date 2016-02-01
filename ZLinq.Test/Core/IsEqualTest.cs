
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ZLinq.Test.Core
{
    [TestClass]
    public class IsEqual
    {	
				
		[TestMethod]
        public void IsEqualArray()
        {
            var x = (int[]) Enumerable.Range(1, 1024).ToArray();
            var y = (int[]) Enumerable.Range(1, 1024).ToArray();
            var a = (int[]) Enumerable.Range(2, 1024).ToArray();
            var b = (int[]) Enumerable.Range(1, 1000).ToArray();

            Assert.IsTrue(x.IsEqual(y));
            Assert.IsTrue(y.IsEqual(x));

			Assert.IsTrue(x.IsEqual(x));
            Assert.IsTrue(y.IsEqual(y));

            Assert.IsFalse(x.IsEqual(a));
            Assert.IsFalse(x.IsEqual(b));

            Assert.IsFalse(y.IsEqual(a));
            Assert.IsFalse(y.IsEqual(b));
        }
				
		[TestMethod]
        public void IsEqualList()
        {
            var x = (List<int>) Enumerable.Range(1, 1024).ToList();
            var y = (List<int>) Enumerable.Range(1, 1024).ToList();
            var a = (List<int>) Enumerable.Range(2, 1024).ToList();
            var b = (List<int>) Enumerable.Range(1, 1000).ToList();

            Assert.IsTrue(x.IsEqual(y));
            Assert.IsTrue(y.IsEqual(x));

			Assert.IsTrue(x.IsEqual(x));
            Assert.IsTrue(y.IsEqual(y));

            Assert.IsFalse(x.IsEqual(a));
            Assert.IsFalse(x.IsEqual(b));

            Assert.IsFalse(y.IsEqual(a));
            Assert.IsFalse(y.IsEqual(b));
        }
				
		[TestMethod]
        public void IsEqualIList()
        {
            var x = (IList<int>) Enumerable.Range(1, 1024).ToList();
            var y = (IList<int>) Enumerable.Range(1, 1024).ToList();
            var a = (IList<int>) Enumerable.Range(2, 1024).ToList();
            var b = (IList<int>) Enumerable.Range(1, 1000).ToList();

            Assert.IsTrue(x.IsEqual(y));
            Assert.IsTrue(y.IsEqual(x));

			Assert.IsTrue(x.IsEqual(x));
            Assert.IsTrue(y.IsEqual(y));

            Assert.IsFalse(x.IsEqual(a));
            Assert.IsFalse(x.IsEqual(b));

            Assert.IsFalse(y.IsEqual(a));
            Assert.IsFalse(y.IsEqual(b));
        }
				
		[TestMethod]
        public void IsEqualICollection()
        {
            var x = (ICollection<int>) Enumerable.Range(1, 1024).ToList();
            var y = (ICollection<int>) Enumerable.Range(1, 1024).ToList();
            var a = (ICollection<int>) Enumerable.Range(2, 1024).ToList();
            var b = (ICollection<int>) Enumerable.Range(1, 1000).ToList();

            Assert.IsTrue(x.IsEqual(y));
            Assert.IsTrue(y.IsEqual(x));

			Assert.IsTrue(x.IsEqual(x));
            Assert.IsTrue(y.IsEqual(y));

            Assert.IsFalse(x.IsEqual(a));
            Assert.IsFalse(x.IsEqual(b));

            Assert.IsFalse(y.IsEqual(a));
            Assert.IsFalse(y.IsEqual(b));
        }
			

				
		[TestMethod]
        public void IsEqualMemberwiseArray()
        {
            var x = new object[1024].ToArray();
            var y = new object[1024].ToArray();
			var a = Enumerable.Range(1, 1024).Select(t => (object) t).ToArray();
			var b = Enumerable.Range(1, 1023).Select(t => (object) t).ToArray();
			for (int i = 0; i < y.Length; i++)
				y[i] = x[i] = new object();

            Assert.IsTrue(x.IsEqualMemberwise(y));
            Assert.IsTrue(y.IsEqualMemberwise(x));

			Assert.IsTrue(x.IsEqualMemberwise(x));
            Assert.IsTrue(y.IsEqualMemberwise(y));

            Assert.IsFalse(x.IsEqualMemberwise(a));
            Assert.IsFalse(x.IsEqualMemberwise(b));

            Assert.IsFalse(y.IsEqualMemberwise(a));
            Assert.IsFalse(y.IsEqualMemberwise(b));
        }
				
		[TestMethod]
        public void IsEqualMemberwiseList()
        {
            var x = new object[1024].ToList();
            var y = new object[1024].ToList();
			var a = Enumerable.Range(1, 1024).Select(t => (object) t).ToList();
			var b = Enumerable.Range(1, 1023).Select(t => (object) t).ToList();
			for (int i = 0; i < y.Count; i++)
				y[i] = x[i] = new object();

            Assert.IsTrue(x.IsEqualMemberwise(y));
            Assert.IsTrue(y.IsEqualMemberwise(x));

			Assert.IsTrue(x.IsEqualMemberwise(x));
            Assert.IsTrue(y.IsEqualMemberwise(y));

            Assert.IsFalse(x.IsEqualMemberwise(a));
            Assert.IsFalse(x.IsEqualMemberwise(b));

            Assert.IsFalse(y.IsEqualMemberwise(a));
            Assert.IsFalse(y.IsEqualMemberwise(b));
        }
				
		[TestMethod]
        public void IsEqualMemberwiseIList()
        {
            var x = new object[1024].ToList();
            var y = new object[1024].ToList();
			var a = Enumerable.Range(1, 1024).Select(t => (object) t).ToList();
			var b = Enumerable.Range(1, 1023).Select(t => (object) t).ToList();
			for (int i = 0; i < y.Count; i++)
				y[i] = x[i] = new object();

            Assert.IsTrue(x.IsEqualMemberwise(y));
            Assert.IsTrue(y.IsEqualMemberwise(x));

			Assert.IsTrue(x.IsEqualMemberwise(x));
            Assert.IsTrue(y.IsEqualMemberwise(y));

            Assert.IsFalse(x.IsEqualMemberwise(a));
            Assert.IsFalse(x.IsEqualMemberwise(b));

            Assert.IsFalse(y.IsEqualMemberwise(a));
            Assert.IsFalse(y.IsEqualMemberwise(b));
        }
				
		[TestMethod]
        public void IsEqualMemberwiseICollection()
        {
            var x = new object[1024].ToList();
            var y = new object[1024].ToList();
			var a = Enumerable.Range(1, 1024).Select(t => (object) t).ToList();
			var b = Enumerable.Range(1, 1023).Select(t => (object) t).ToList();
			for (int i = 0; i < y.Count; i++)
				y[i] = x[i] = new object();

            Assert.IsTrue(x.IsEqualMemberwise(y));
            Assert.IsTrue(y.IsEqualMemberwise(x));

			Assert.IsTrue(x.IsEqualMemberwise(x));
            Assert.IsTrue(y.IsEqualMemberwise(y));

            Assert.IsFalse(x.IsEqualMemberwise(a));
            Assert.IsFalse(x.IsEqualMemberwise(b));

            Assert.IsFalse(y.IsEqualMemberwise(a));
            Assert.IsFalse(y.IsEqualMemberwise(b));
        }
			

    }
}
