using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ZLinq.Test.Core.Unfold
{
    [TestClass]
    public class RepeatTest
    {
        [TestMethod]
        public void TestRepeat()
        {
            var source = Enumerable.Repeat(1, 100).ToArray();
            var zsource = ZEnumerable.Repeat(1, 100);

            Assert.IsTrue(source.Length == zsource.Length);
            Assert.IsTrue(source.SequenceEqual(zsource));
        }


        [TestMethod]
        public void TestRangeGenerator()
        {
            int[] source = new int[100];
            var r = new Random(1);
            for (int i = 0; i < source.Length; i++)
            {
                source[i] = r.Next();
            }

            var zsource = ZEnumerable.Repeat(new Random(1), random => random.Next(), source.Length);

            Assert.IsTrue(source.Length == zsource.Length);
            Assert.IsTrue(source.SequenceEqual(zsource));
        }

        [TestMethod]
        public void TestRangeGeneratorClosure()
        {
            int[] source = new int[100];
            var r = new Random(1);
            for (int i = 0; i < source.Length; i++)
            {
                source[i] = r.Next();
            }

            var generator = new Random(1);
            var zsource = ZEnumerable.Repeat(() => generator.Next(), source.Length);

            Assert.IsTrue(source.Length == zsource.Length);
            Assert.IsTrue(source.SequenceEqual(zsource));
        }

        [TestMethod]
        public void TestRangeGeneratorSeq()
        {
            int[] source = new int[100];
            var r = new Random(1);
            for (int i = 0; i < source.Length; i++)
            {
                source[i] = r.Next();
            }

            var zsource = ZEnumerable.RepeatSeq(new Random(1), random => random.Next(), source.Length).ToArray();

            Assert.IsTrue(source.Length == zsource.Length);
            Assert.IsTrue(source.SequenceEqual(zsource));
        }

        [TestMethod]
        public void TestRangeGeneratorSeqClosure()
        {
            int[] source = new int[100];
            var r = new Random(1);
            for (int i = 0; i < source.Length; i++)
            {
                source[i] = r.Next();
            }

            var generator = new Random(1);
            var zsource = ZEnumerable.RepeatSeq(() => generator.Next(), source.Length).ToArray();

            Assert.IsTrue(source.Length == zsource.Length);
            Assert.IsTrue(source.SequenceEqual(zsource));
        }
    }
}
