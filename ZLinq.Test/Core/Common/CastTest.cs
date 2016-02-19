using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ZLinq.Test.Core.Unfold
{
    [TestClass]
    public class CastTest
    {
        [TestMethod]
        public void CastEnum()
        {
            var source = Enumerable.Range(1, 100).ToArray();
            var zsource = ZEnumerable.Range(1, 100);

            Assert.IsTrue(source.Length == zsource.Length);
            Assert.IsTrue(source.SequenceEqual(zsource));
        }
    }
}
