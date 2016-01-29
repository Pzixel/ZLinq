using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZLinq.Comparers;

namespace ZLinq.Test.Comparers
{
    [TestClass]
    public class CustomComparerTest
    {
        private class Test
        {
            public int A;
            public double B;
            public string C;
            public byte D;
        }

        // For objects A, B and C, the following must be true:
        // A.CompareTo(A) must return zero.
        // If A.CompareTo(B) returns zero, then B.CompareTo(A) must return zero.
        // If A.CompareTo(B) returns zero and B.CompareTo(C) returns zero, then A.CompareTo(C) must return zero.
        // If A.CompareTo(B) returns a value other than zero, then B.CompareTo(A) must return a value of the opposite sign.
        // If A.CompareTo(B) returns a value x not equal to zero, and B.CompareTo(C) returns a value y of the same sign as x, then A.CompareTo(C) must return a value of the same sign as x and y.
        // https://msdn.microsoft.com/en-us/library/system.icomparable.compareto%28v=vs.110%29.aspx

        [TestMethod]
        public void TestComparerPartial()
        {
            var objA = new Test { A = 1, B = 19, C = "H", D = 10 };
            var objB = new Test { A = 1, B = 20, C = "H", D = 0 };
            var objC = new Test { A = 1, B = 0, C = "H", D = 20 };

            var comparer = CustomComparer<Test>.New(t => t.A).Add(t => t.C).CreateDelegate();

            Assert.AreEqual(0, comparer(objA, objB));
            Assert.AreEqual(0, comparer(objB, objA));

            Assert.AreEqual(0, comparer(objB, objC));
            Assert.AreEqual(0, comparer(objA, objC));
        }

        [TestMethod]
        public void TestComparerFull1()
        {
            var objA = new Test { A = 1, B = 19, C = "H", D = 10 };
            var objB = new Test { A = 1, B = 19, C = "H", D = 10 };
            var objC = new Test { A = 1, B = 19, C = "H", D = 10 };

            var customComparer = CustomComparer<Test>.New(t => t.A).Add(t => t.B).Add(t => t.C).Add(t => t.D);
            var comparer = customComparer.CreateDelegate();

            Assert.AreEqual(0, comparer(objA, objB));
            Assert.AreEqual(0, comparer(objB, objA));

            Assert.AreEqual(0, comparer(objB, objC));
            Assert.AreEqual(0, comparer(objA, objC));
        }

        [TestMethod]
        public void TestComparerFull2()
        {
            var objA = new Test { A = 1, B = 20, C = "H", D = 0 };
            var objB = new Test { A = 1, B = 20, C = "H", D = 10 };
            var objC = new Test { A = 1, B = 30, C = "H", D = 10 };

            var customComparer = CustomComparer<Test>.New(t => t.A).Add(t => t.B).Add(t => t.C).Add(t => t.D);
            var compFull = customComparer.CreateDelegate();

            Assert.IsTrue(compFull(objA, objB) < 0);
            Assert.IsTrue(compFull(objB, objA) > 0);

            Assert.IsTrue(compFull(objB, objC) < 0);
            Assert.IsTrue(compFull(objA, objC) < 0);
        }

        [TestMethod]
        public void TestComparerFull4()
        {
            Tuple<string, int> a = new Tuple<string, int>("1", 2), b = new Tuple<string, int>("2", 4);
            Tuple<string, int> x = new Tuple<string, int>("2", 2), y = new Tuple<string, int>("2", 4);
            var comparer = CustomComparer<Tuple<string, int>>.New(t => t.Item1).Add(t => t.Item2).CreateDelegate();
            var comparerNeg = CustomComparer<Tuple<string, int>>.NewNeg(t => t.Item1).Add(t => -t.Item2).CreateDelegate();

            Assert.AreEqual(-1, comparer(a, b));
            Assert.AreEqual(1, comparer(b, a));

            Assert.AreEqual(1, comparerNeg(x, y));
            Assert.AreEqual(-1, comparerNeg(y, x));
        }
    }
}
