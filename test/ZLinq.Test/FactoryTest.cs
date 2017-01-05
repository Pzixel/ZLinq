using System;
using System.Linq;
using Xunit;
using ZLinq.Core;

namespace ZLinq.Test
{
    public class FactoryTest
    {
        [Fact]
        public void TestIdentity()
        {
            var source = Enumerable.Range(1, 10).ToArray();

            var foo = QueryFactory.Create<int>().Compile();
            var result = foo(source);

            Assert.Equal(source, result);
        }
    }
}
