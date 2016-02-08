﻿using System;
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
        public void TestComparerZeroPartial()
        {
            var objA = new Test { A = 1, B = 19, C = "H", D = 10 };
            var objB = new Test { A = 1, B = 20, C = "H", D = 0 };
            var objC = new Test { A = 1, B = 0, C = "H", D = 20 };

            var customComparer = CustomComparer<Test>.New(t => t.A).Add(t => t.C);
            var comparison = customComparer.ToDelegate();
            var comparer = customComparer.ToComparer();

            Assert.AreEqual(0, comparison(objA, objB));
            Assert.AreEqual(0, comparison(objB, objA));
            Assert.AreEqual(0, comparison(objB, objC));
            Assert.AreEqual(0, comparison(objA, objC));

            Assert.AreEqual(0, comparer.Compare(objA, objB));
            Assert.AreEqual(0, comparer.Compare(objB, objA));
            Assert.AreEqual(0, comparer.Compare(objB, objC));
            Assert.AreEqual(0, comparer.Compare(objA, objC));
        }

        [TestMethod]
        public void TestComparerZeroFull()
        {
            var objA = new Test { A = 1, B = 19, C = "H", D = 10 };
            var objB = new Test { A = 1, B = 19, C = "H", D = 10 };
            var objC = new Test { A = 1, B = 19, C = "H", D = 10 };

            var customComparer = CustomComparer<Test>.New(t => t.A).Add(t => t.B).Add(t => t.C).Add(t => t.D);
            var comparison = customComparer.ToDelegate();
            var comparer = customComparer.ToComparer();

            Assert.AreEqual(0, comparison(objA, objB));
            Assert.AreEqual(0, comparison(objB, objA));
            Assert.AreEqual(0, comparison(objB, objC));
            Assert.AreEqual(0, comparison(objA, objC));

            Assert.AreEqual(0, comparer.Compare(objA, objB));
            Assert.AreEqual(0, comparer.Compare(objB, objA));
            Assert.AreEqual(0, comparer.Compare(objB, objC));
            Assert.AreEqual(0, comparer.Compare(objA, objC));
        }



        [TestMethod]
        public void TestComparerOppositeSign()
        {
            var objA = new Test { A = 1, B = 20, C = "H", D = 0 };
            var objB = new Test { A = 1, B = 20, C = "H", D = 10 };
            var objC = new Test { A = 1, B = 30, C = "H", D = 10 };

            var customComparer = CustomComparer<Test>.New(t => t.A).Add(t => t.B).Add(t => t.C).Add(t => t.D);
            var comparison = customComparer.ToDelegate();
            var comparer = customComparer.ToComparer();


            Assert.IsTrue(comparison(objA, objB) < 0);
            Assert.IsTrue(comparison(objB, objA) > 0);
            Assert.IsTrue(comparison(objB, objC) < 0);
            Assert.IsTrue(comparison(objA, objC) < 0);

            Assert.IsTrue(comparer.Compare(objA, objB) < 0);
            Assert.IsTrue(comparer.Compare(objB, objA) > 0);
            Assert.IsTrue(comparer.Compare(objB, objC) < 0);
            Assert.IsTrue(comparer.Compare(objA, objC) < 0);
        }

        [TestMethod]
        public void TestComparerLastRule()
        {
            Tuple<string, int> a = new Tuple<string, int>("1", 2), b = new Tuple<string, int>("2", 4);
            Tuple<string, int> x = new Tuple<string, int>("2", 2), y = new Tuple<string, int>("2", 4);
            var customComparer = CustomComparer<Tuple<string, int>>.New(t => t.Item1).Add(t => t.Item2);
            var customComparerNeg = CustomComparer<Tuple<string, int>>.NewNeg(t => t.Item1).Add(t => -t.Item2);

            var comparison = customComparer.ToDelegate();
            var comparasionNeg = customComparerNeg.ToDelegate();

            var comparer = customComparer.ToComparer();
            var comparerNeg = customComparerNeg.ToComparer();

            Assert.AreEqual(-1, comparison(a, b));
            Assert.AreEqual(1, comparison(b, a));
            Assert.AreEqual(1, comparasionNeg(x, y));
            Assert.AreEqual(-1, comparasionNeg(y, x));

            Assert.AreEqual(-1, comparer.Compare(a, b));
            Assert.AreEqual(1, comparer.Compare(b, a));
            Assert.AreEqual(1, comparerNeg.Compare(x, y));
            Assert.AreEqual(-1, comparerNeg.Compare(y, x));
        }

        [TestMethod]
        public void TestComparerBuilding()
        {
            Tuple<string, int> x = new Tuple<string, int>("2", 2), y = new Tuple<string, int>("2", 4);
            var customComparer = CustomComparer<Tuple<string, int>>.New(t => t.Item1);

            var comparison = customComparer.ToDelegate();
            var comparer = customComparer.ToComparer();

            Assert.AreEqual(0, comparison(x, y));
            Assert.AreEqual(0, comparison(y, x));
            Assert.AreEqual(0, comparer.Compare(x, y));
            Assert.AreEqual(0, comparer.Compare(y, x));

            customComparer.Add(t => t.Item2);
            comparison = customComparer.ToDelegate();
            comparer = customComparer.ToComparer();

            Assert.AreEqual(-1, comparison(x, y));
            Assert.AreEqual(1, comparison(y, x));
            Assert.AreEqual(-1, comparer.Compare(x, y));
            Assert.AreEqual(1, comparer.Compare(y, x));
        }
    }
}
