﻿using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ZLinq.Test.Core.Unfold
{
    [TestClass]
    public class RepeatTest
    {
        private const int Seed = 1;

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
            var r = new Random(Seed);
            for (int i = 0; i < source.Length; i++)
            {
                source[i] = r.Next();
            }

            var zsource = ZEnumerable.Repeat(new Random(Seed), random => random.Next(), source.Length);

            Assert.IsTrue(source.Length == zsource.Length);
            Assert.IsTrue(source.SequenceEqual(zsource));
        }

        [TestMethod]
        public void TestRangeGeneratorClosure()
        {
            int[] source = new int[100];
            var r = new Random(Seed);
            for (int i = 0; i < source.Length; i++)
            {
                source[i] = r.Next();
            }

            var generator = new Random(Seed);
            var zsource = ZEnumerable.Repeat(() => generator.Next(), source.Length);

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

            var zsource = ZEnumerable.RepeatList(new Random(Seed), random => random.Next(), source.Length);

            Assert.IsTrue(source.Length == zsource.Count);
            Assert.IsTrue(source.SequenceEqual(zsource));
        }

        [TestMethod]
        public void TestRangeGeneratorClosureList()
        {
            int[] source = new int[100];
            var r = new Random(Seed);
            for (int i = 0; i < source.Length; i++)
            {
                source[i] = r.Next();
            }

            var generator = new Random(Seed);
            var zsource = ZEnumerable.RepeatList(() => generator.Next(), source.Length);

            Assert.IsTrue(source.Length == zsource.Count);
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

            var zsource = ZEnumerable.RepeatSeq(new Random(Seed), random => random.Next(), source.Length);

            Assert.IsTrue(source.Length == zsource.Count);
            Assert.IsTrue(source.SequenceEqual(zsource));
        }

        [TestMethod]
        public void TestRangeGeneratorClosureSeq()
        {
            int[] source = new int[100];
            var r = new Random(Seed);
            for (int i = 0; i < source.Length; i++)
            {
                source[i] = r.Next();
            }

            var generator = new Random(Seed);
            var zsource = ZEnumerable.RepeatSeq(() => generator.Next(), source.Length);

            Assert.IsTrue(source.Length == zsource.Count);
            Assert.IsTrue(source.SequenceEqual(zsource));
        }
        
            }
}
