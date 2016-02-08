using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ZLinq.Test.Core.Unfold
{
    [TestClass]
    public class RepeatRandomTest
    {
        private const int Seed = 1;
         

        [TestMethod]
        public void TestRangeGenerator()
        {
            int[] source = new int[100];
            var r = new Random(Seed);
            for (int i = 0; i < source.Length; i++)
            {
                source[i] = r.Next();
            }

            var zsource = new Random(Seed).Repeat(source.Length).ToArray();

            Assert.IsTrue(source.Length == zsource.Length);
            Assert.IsTrue(source.SequenceEqual(zsource));
        }

        [TestMethod]
        public void TestRangeGeneratorMax()
        {
            const int max = 100;
            int[] source = new int[100];
            var r = new Random(Seed);
            for (int i = 0; i < source.Length; i++)
            {
                source[i] = r.Next(max);
            }

            var zsource = new Random(Seed).Repeat(source.Length, max).ToArray();

            Assert.IsTrue(source.Length == zsource.Length);
            Assert.IsTrue(source.SequenceEqual(zsource));
        }

        [TestMethod]
        public void TestRangeGeneratorMinMax()
        {
            const int min = 10;
            const int max = 100;
            int[] source = new int[100];
            var r = new Random(Seed);
            for (int i = 0; i < source.Length; i++)
            {
                source[i] = r.Next(min, max);
            }

            var zsource = new Random(Seed).Repeat(source.Length, min, max).ToArray();

            Assert.IsTrue(source.Length == zsource.Length);
            Assert.IsTrue(source.SequenceEqual(zsource));
        }

        [TestMethod]
        public void TestRangeGeneratorDouble()
        {
            double[] source = new double[100];
            var r = new Random(Seed);
            for (int i = 0; i < source.Length; i++)
            {
                source[i] = r.NextDouble();
            }

            var zsource = new Random(Seed).RepeatDouble(source.Length).ToArray();

            Assert.IsTrue(source.Length == zsource.Length);
            Assert.IsTrue(source.SequenceEqual(zsource));
        }
         

        [TestMethod]
        public void TestRangeGeneratorList()
        {
            int[] source = new int[100];
            var r = new Random(Seed);
            for (int i = 0; i < source.Length; i++)
            {
                source[i] = r.Next();
            }

            var zsource = new Random(Seed).RepeatList(source.Length).ToArray();

            Assert.IsTrue(source.Length == zsource.Length);
            Assert.IsTrue(source.SequenceEqual(zsource));
        }

        [TestMethod]
        public void TestRangeGeneratorMaxList()
        {
            const int max = 100;
            int[] source = new int[100];
            var r = new Random(Seed);
            for (int i = 0; i < source.Length; i++)
            {
                source[i] = r.Next(max);
            }

            var zsource = new Random(Seed).RepeatList(source.Length, max).ToArray();

            Assert.IsTrue(source.Length == zsource.Length);
            Assert.IsTrue(source.SequenceEqual(zsource));
        }

        [TestMethod]
        public void TestRangeGeneratorMinMaxList()
        {
            const int min = 10;
            const int max = 100;
            int[] source = new int[100];
            var r = new Random(Seed);
            for (int i = 0; i < source.Length; i++)
            {
                source[i] = r.Next(min, max);
            }

            var zsource = new Random(Seed).RepeatList(source.Length, min, max).ToArray();

            Assert.IsTrue(source.Length == zsource.Length);
            Assert.IsTrue(source.SequenceEqual(zsource));
        }

        [TestMethod]
        public void TestRangeGeneratorDoubleList()
        {
            double[] source = new double[100];
            var r = new Random(Seed);
            for (int i = 0; i < source.Length; i++)
            {
                source[i] = r.NextDouble();
            }

            var zsource = new Random(Seed).RepeatDoubleList(source.Length).ToArray();

            Assert.IsTrue(source.Length == zsource.Length);
            Assert.IsTrue(source.SequenceEqual(zsource));
        }
         

        [TestMethod]
        public void TestRangeGeneratorSeq()
        {
            int[] source = new int[100];
            var r = new Random(Seed);
            for (int i = 0; i < source.Length; i++)
            {
                source[i] = r.Next();
            }

            var zsource = new Random(Seed).RepeatSeq(source.Length).ToArray();

            Assert.IsTrue(source.Length == zsource.Length);
            Assert.IsTrue(source.SequenceEqual(zsource));
        }

        [TestMethod]
        public void TestRangeGeneratorMaxSeq()
        {
            const int max = 100;
            int[] source = new int[100];
            var r = new Random(Seed);
            for (int i = 0; i < source.Length; i++)
            {
                source[i] = r.Next(max);
            }

            var zsource = new Random(Seed).RepeatSeq(source.Length, max).ToArray();

            Assert.IsTrue(source.Length == zsource.Length);
            Assert.IsTrue(source.SequenceEqual(zsource));
        }

        [TestMethod]
        public void TestRangeGeneratorMinMaxSeq()
        {
            const int min = 10;
            const int max = 100;
            int[] source = new int[100];
            var r = new Random(Seed);
            for (int i = 0; i < source.Length; i++)
            {
                source[i] = r.Next(min, max);
            }

            var zsource = new Random(Seed).RepeatSeq(source.Length, min, max).ToArray();

            Assert.IsTrue(source.Length == zsource.Length);
            Assert.IsTrue(source.SequenceEqual(zsource));
        }

        [TestMethod]
        public void TestRangeGeneratorDoubleSeq()
        {
            double[] source = new double[100];
            var r = new Random(Seed);
            for (int i = 0; i < source.Length; i++)
            {
                source[i] = r.NextDouble();
            }

            var zsource = new Random(Seed).RepeatDoubleSeq(source.Length).ToArray();

            Assert.IsTrue(source.Length == zsource.Length);
            Assert.IsTrue(source.SequenceEqual(zsource));
        }
        
    }
}
