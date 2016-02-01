
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZLinq.Test.Helpers;

namespace ZLinq.Test.Core.Fold
{
    [TestClass]
    public class IsEqual
    {	
				
		[TestMethod]
        public void IsEqualArray()
        {
            var x = Enumerable.Range(1, 1024).ToArray();
            var y = Enumerable.Range(1, 1024).ToArray();
            var a = Enumerable.Range(2, 1024).ToArray();
            var b = Enumerable.Range(1, 1000).ToArray();

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
            var x = Enumerable.Range(1, 1024).ToList();
            var y = Enumerable.Range(1, 1024).ToList();
            var a = Enumerable.Range(2, 1024).ToList();
            var b = Enumerable.Range(1, 1000).ToList();

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
            var x = Enumerable.Range(1, 1024).ToIList();
            var y = Enumerable.Range(1, 1024).ToIList();
            var a = Enumerable.Range(2, 1024).ToIList();
            var b = Enumerable.Range(1, 1000).ToIList();

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
            var x = Enumerable.Range(1, 1024).ToICollection();
            var y = Enumerable.Range(1, 1024).ToICollection();
            var a = Enumerable.Range(2, 1024).ToICollection();
            var b = Enumerable.Range(1, 1000).ToICollection();

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
			var source1 = new object[1024];
			var source2 = new object[source1.Length];

			for (int i = 0; i < source1.Length; i++)
				source1[i] = source2[i] = new object();

            var x = source1.ToArray();
            var y = source2.ToArray();
			var a = Enumerable.Range(1, 1024).Select(t => (object) t).ToArray();
			var b = Enumerable.Range(1, 1023).Select(t => (object) t).ToArray();


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
			var source1 = new object[1024];
			var source2 = new object[source1.Length];

			for (int i = 0; i < source1.Length; i++)
				source1[i] = source2[i] = new object();

            var x = source1.ToList();
            var y = source2.ToList();
			var a = Enumerable.Range(1, 1024).Select(t => (object) t).ToList();
			var b = Enumerable.Range(1, 1023).Select(t => (object) t).ToList();


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
			var source1 = new object[1024];
			var source2 = new object[source1.Length];

			for (int i = 0; i < source1.Length; i++)
				source1[i] = source2[i] = new object();

            var x = source1.ToIList();
            var y = source2.ToIList();
			var a = Enumerable.Range(1, 1024).Select(t => (object) t).ToIList();
			var b = Enumerable.Range(1, 1023).Select(t => (object) t).ToIList();


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
			var source1 = new object[1024];
			var source2 = new object[source1.Length];

			for (int i = 0; i < source1.Length; i++)
				source1[i] = source2[i] = new object();

            var x = source1.ToICollection();
            var y = source2.ToICollection();
			var a = Enumerable.Range(1, 1024).Select(t => (object) t).ToICollection();
			var b = Enumerable.Range(1, 1023).Select(t => (object) t).ToICollection();


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
