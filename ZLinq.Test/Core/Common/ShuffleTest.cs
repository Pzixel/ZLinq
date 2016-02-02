
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
            var source = (int[]) Enumerable.Range(1, 100).ToArray();

            var shuffled = source.GetShuffle();

            Assert.IsFalse(source.SequenceEqual(shuffled));
        }
        
        [TestMethod]
        public void TestSelectToArrayFromList()
        {
            var source = (List<int>) Enumerable.Range(1, 100).ToList();

            var shuffled = source.GetShuffle();

            Assert.IsFalse(source.SequenceEqual(shuffled));
        }
        
        [TestMethod]
        public void TestSelectToArrayFromIList()
        {
            var source = (IList<int>) Enumerable.Range(1, 100).ToList();

            var shuffled = source.GetShuffle();

            Assert.IsFalse(source.SequenceEqual(shuffled));
        }
        
    }
}
