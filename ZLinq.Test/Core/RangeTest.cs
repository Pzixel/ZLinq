using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ZLinq.Test.Core
{
    [TestClass]
    public class RangeTest
    {
        [TestMethod]
        public void TestRange()
        {
            var source = Enumerable.Range(1, 100).ToArray();
            var zsource = ZEnumerable.Range(1, 100);

            Assert.IsTrue(source.Length == zsource.Length);
            Assert.IsTrue(source.SequenceEqual(zsource));
        }


        [TestMethod]
        public void TestRangeGenerator()
        {
            var source = Enumerable.Range(1, 100).Select(i => i*i).ToArray();
            var zsource = ZEnumerable.Range(1, 100, i => i*i);

            Assert.IsTrue(source.Length == zsource.Length);
            Assert.IsTrue(source.SequenceEqual(zsource));
        }
    }
}
