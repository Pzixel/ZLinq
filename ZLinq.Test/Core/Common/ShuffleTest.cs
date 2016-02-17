
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ZLinq.Test.Core.Common
{
    [TestClass]
    public class Shuffle
    {          
        
        [TestMethod]
        public void TestSelectToArrayFromArray()
        {
			const int seed = 10;
            int[] source = Enumerable.Range(1, 100).ToArray();

            var shuffled = source.GetShuffle(seed);
			int[] shuffled2 = source.ToArray();
			shuffled2.Shuffle(seed);

            Assert.IsFalse(source.SequenceEqual(shuffled));
			Assert.IsTrue(shuffled2.SequenceEqual(shuffled));
        }
        
        [TestMethod]
        public void TestSelectToArrayFromList()
        {
			const int seed = 10;
            List<int> source = Enumerable.Range(1, 100).ToList();

            var shuffled = source.GetShuffle(seed);
			List<int> shuffled2 = source.ToList();
			shuffled2.Shuffle(seed);

            Assert.IsFalse(source.SequenceEqual(shuffled));
			Assert.IsTrue(shuffled2.SequenceEqual(shuffled));
        }
        
        [TestMethod]
        public void TestSelectToArrayFromIList()
        {
			const int seed = 10;
            IList<int> source = Enumerable.Range(1, 100).ToList();

            var shuffled = source.GetShuffle(seed);
			IList<int> shuffled2 = source.ToList();
			shuffled2.Shuffle(seed);

            Assert.IsFalse(source.SequenceEqual(shuffled));
			Assert.IsTrue(shuffled2.SequenceEqual(shuffled));
        }
        
    }
}
