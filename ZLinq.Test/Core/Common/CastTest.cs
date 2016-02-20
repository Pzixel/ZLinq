using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ZLinq.Test.Core.Unfold
{
    [TestClass]
    public class CastTest
    {
        [TestMethod]
        public void CastArray()
        {
            var array = new int[1, 2];
            for (int a = 0; a < array.GetLength(0); a++)
                for (int b = 0; b < array.GetLength(1); b++)

                    unchecked
                    {
                        array[a, b] = a + b;
                    }
            var x = Enumerable.Cast<int>(array).ToList();
            var y = array.Cast<int>();
            var z = array.CastSeq<int>().ToList();

            Assert.IsTrue(x.Count == y.Count);
            Assert.IsTrue(x.SequenceEqual(y));
            Assert.IsTrue(x.Count == z.Count);
            Assert.IsTrue(x.SequenceEqual(z));
        }

        [TestMethod]
        public void CastArrayList()
        {
            var array = new ArrayList();
            for (int i = 0; i < 5; i++)
            {
                array.Add(i);
            }

            var x = Enumerable.Cast<int>(array).ToList();
            var y = array.Cast<int>();
            var z = array.CastSeq<int>().ToList();

            Assert.IsTrue(x.Count == y.Count);
            Assert.IsTrue(x.SequenceEqual(y));
            Assert.IsTrue(x.Count == z.Count);
            Assert.IsTrue(x.SequenceEqual(z));
        }

        [TestMethod]
        public void CastMethods()
        {
            var array = new ArrayList();
            for (int i = 0; i < 5; i++)
            {
                array.Add(i);
            }
            var result = array.Cast<int>();

            Assert.AreEqual(result.Count, 5);
            Assert.AreEqual(result.IndexOf(3), 3);
            Assert.AreEqual(result.Contains(4), true);
        }

        [TestMethod]
        public void CastMethodsClass()
        {
            var array = new List<TestClass>();
            for (int i = 0; i < 5; i++)
            {
                array.Add(new TestClass(i));
            }
            var result = array.Cast<TestClass>();

            Assert.AreEqual(result.Count, 5);
            Assert.AreEqual(result.Contains(new TestClass(4)), true);
        }

        class TestClass : IEquatable<TestClass>
        {
            public int X { get; }
            public TestClass(int x)
            {
                X = x;
            }

            public bool Equals(TestClass other)
            {
                return X == other.X;
            }
        }
    }
}
