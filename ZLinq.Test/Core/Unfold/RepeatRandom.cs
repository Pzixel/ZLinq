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

            var zsource = new Random(Seed).Repeat(source.Length);

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

            var zsource = new Random(Seed).Repeat(source.Length, max);

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
                source[i] = new Random(Seed).Next(min, max);
            }

            var zsource = r.Repeat(source.Length, min, max);

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
                source[i] = r.Next();
            }

            var zsource = new Random(Seed).RepeatDouble(source.Length);

            Assert.IsTrue(source.Length == zsource.Length);
            Assert.IsTrue(source.SequenceEqual(zsource));
        }
    }
}
