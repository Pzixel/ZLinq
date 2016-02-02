
using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZLinq.Test.Helpers;

namespace ZLinq.Test.Core.Fold
{
    [TestClass]
    public class Single
    {    
                

#region Array
        [TestMethod]
        public void SingleArray()
        {
            var x = Enumerable.Range(1, 1).ToArray();
            var y = Enumerable.Range(1, 1).Select(a => new Tuple<int, int>(a,a)).ToArray();
            var z = Enumerable.Range(1, 1).Select(a => new { A = a}).ToArray();

            Assert.AreEqual(ZEnumerable.Single(x), Enumerable.Single(x));
            Assert.AreEqual(ZEnumerable.Single(y), Enumerable.Single(y));
            Assert.AreEqual(ZEnumerable.Single(z), Enumerable.Single(z));
        }

        [TestMethod]
        public void SingleArrayOrDefault()
        {
            var x = Enumerable.Range(1, 1).ToArray();
            var y = Enumerable.Range(1, 1).Select(a => new Tuple<int, int>(a,a)).ToArray();
            var z = new int[0].ToArray();

            Assert.AreEqual(ZEnumerable.SingleOrDefault(x), Enumerable.SingleOrDefault(x));
            Assert.AreEqual(ZEnumerable.SingleOrDefault(y), Enumerable.SingleOrDefault(y));
            Assert.AreEqual(ZEnumerable.SingleOrDefault(z), Enumerable.SingleOrDefault(z));
        }

        [TestMethod]
        public void SingleArrayPredicate()
        {
            var x = Enumerable.Range(1, 5).ToArray();
            var y = Enumerable.Range(1, 5).Select(a => new Tuple<int, int>(a,a)).ToArray();
            var z = Enumerable.Range(1, 5).Select(a => new { A = a}).ToArray();

            Assert.AreEqual(ZEnumerable.Single(x, val => val%3 == 0), Enumerable.Single(x, val => val%3 == 0));
            Assert.AreEqual(ZEnumerable.Single(y, val => val.Item1%3 == 0), Enumerable.Single(y, val => val.Item1%3 == 0));
            Assert.AreEqual(ZEnumerable.Single(z, val => val.A%3 == 0), Enumerable.Single(z, val => val.A%3 == 0));
        }

        [TestMethod]
        public void SingleArrayOrDefaultPredicate()
        {
            var x = Enumerable.Range(1, 5).ToArray();
            var y = Enumerable.Range(1, 5).Select(a => new Tuple<int, int>(a,a)).ToArray();
            var z = new int[0].ToArray();

            Assert.AreEqual(ZEnumerable.SingleOrDefault(x, val => val%3 == 0), Enumerable.SingleOrDefault(x, val => val%3 == 0));
            Assert.AreEqual(ZEnumerable.SingleOrDefault(y, val => val.Item1%3 == 0), Enumerable.SingleOrDefault(y, val => val.Item1%3 == 0));
            Assert.AreEqual(ZEnumerable.SingleOrDefault(z, val => val%3 == 0), Enumerable.SingleOrDefault(z, val => val%3 == 0));
        }
        
        [TestMethod]
        public void SingleArrayNegative()
        {
            var x = Enumerable.Range(1, 10).ToArray();
            var y = Enumerable.Range(1, 10).Select(a => new Tuple<int, int>(a,a)).ToArray();
            var z = Enumerable.Range(1, 10).Select(a => new { A = a}).ToArray();

            try
            {
                var res = ZEnumerable.Single(x);
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {

            }
            
            try
            {
                var res = ZEnumerable.Single(y);
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {

            }

            try
            {
                var res = ZEnumerable.Single(z);
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {

            }
        }

        [TestMethod]
        public void SingleArrayOrDefaultNegative()
        {
            var x = Enumerable.Range(1, 10).ToArray();
            var y = Enumerable.Range(1, 10).Select(a => new Tuple<int, int>(a,a)).ToArray();
            var z = Enumerable.Range(1, 10).Select(a => new { A = a}).ToArray();

            try
            {
                var res = ZEnumerable.SingleOrDefault(x);
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {

            }
            
            try
            {
                var res = ZEnumerable.SingleOrDefault(y);
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {

            }

            try
            {
                var res = ZEnumerable.SingleOrDefault(z);
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {

            }
        }

        [TestMethod]
        public void SingleArrayPredicateNegative()
        {
            var x = Enumerable.Range(1, 15).ToArray();
            var y = Enumerable.Range(1, 15).Select(a => new Tuple<int, int>(a,a)).ToArray();
            var z = Enumerable.Range(1, 15).Select(a => new { A = a}).ToArray();

            try
            {
                var res = ZEnumerable.Single(x, val => val%3 == 0);
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {

            }
            
            try
            {
                var res = ZEnumerable.Single(y, val => val.Item1%3 == 0);
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {

            }

            try
            {
                var res = ZEnumerable.Single(z, val => val.A%3 == 0);
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {

            }
        }

        [TestMethod]
        public void SingleArrayOrDefaultPredicateNegative()
        {
            var x = Enumerable.Range(1, 15).ToArray();
            var y = Enumerable.Range(1, 15).Select(a => new Tuple<int, int>(a,a)).ToArray();
            var z = Enumerable.Range(1, 15).Select(a => new { A = a}).ToArray();

            try
            {
                var res = ZEnumerable.SingleOrDefault(x, val => val%3 == 0);
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {

            }
            
            try
            {
                var res = ZEnumerable.SingleOrDefault(y, val => val.Item1%3 == 0);
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {

            }

            try
            {
                var res = ZEnumerable.SingleOrDefault(z, val => val.A%3 == 0);
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {

            }
        }

#endregion        


                

#region List
        [TestMethod]
        public void SingleList()
        {
            var x = Enumerable.Range(1, 1).ToList();
            var y = Enumerable.Range(1, 1).Select(a => new Tuple<int, int>(a,a)).ToList();
            var z = Enumerable.Range(1, 1).Select(a => new { A = a}).ToList();

            Assert.AreEqual(ZEnumerable.Single(x), Enumerable.Single(x));
            Assert.AreEqual(ZEnumerable.Single(y), Enumerable.Single(y));
            Assert.AreEqual(ZEnumerable.Single(z), Enumerable.Single(z));
        }

        [TestMethod]
        public void SingleListOrDefault()
        {
            var x = Enumerable.Range(1, 1).ToList();
            var y = Enumerable.Range(1, 1).Select(a => new Tuple<int, int>(a,a)).ToList();
            var z = new int[0].ToList();

            Assert.AreEqual(ZEnumerable.SingleOrDefault(x), Enumerable.SingleOrDefault(x));
            Assert.AreEqual(ZEnumerable.SingleOrDefault(y), Enumerable.SingleOrDefault(y));
            Assert.AreEqual(ZEnumerable.SingleOrDefault(z), Enumerable.SingleOrDefault(z));
        }

        [TestMethod]
        public void SingleListPredicate()
        {
            var x = Enumerable.Range(1, 5).ToList();
            var y = Enumerable.Range(1, 5).Select(a => new Tuple<int, int>(a,a)).ToList();
            var z = Enumerable.Range(1, 5).Select(a => new { A = a}).ToList();

            Assert.AreEqual(ZEnumerable.Single(x, val => val%3 == 0), Enumerable.Single(x, val => val%3 == 0));
            Assert.AreEqual(ZEnumerable.Single(y, val => val.Item1%3 == 0), Enumerable.Single(y, val => val.Item1%3 == 0));
            Assert.AreEqual(ZEnumerable.Single(z, val => val.A%3 == 0), Enumerable.Single(z, val => val.A%3 == 0));
        }

        [TestMethod]
        public void SingleListOrDefaultPredicate()
        {
            var x = Enumerable.Range(1, 5).ToList();
            var y = Enumerable.Range(1, 5).Select(a => new Tuple<int, int>(a,a)).ToList();
            var z = new int[0].ToList();

            Assert.AreEqual(ZEnumerable.SingleOrDefault(x, val => val%3 == 0), Enumerable.SingleOrDefault(x, val => val%3 == 0));
            Assert.AreEqual(ZEnumerable.SingleOrDefault(y, val => val.Item1%3 == 0), Enumerable.SingleOrDefault(y, val => val.Item1%3 == 0));
            Assert.AreEqual(ZEnumerable.SingleOrDefault(z, val => val%3 == 0), Enumerable.SingleOrDefault(z, val => val%3 == 0));
        }
        
        [TestMethod]
        public void SingleListNegative()
        {
            var x = Enumerable.Range(1, 10).ToList();
            var y = Enumerable.Range(1, 10).Select(a => new Tuple<int, int>(a,a)).ToList();
            var z = Enumerable.Range(1, 10).Select(a => new { A = a}).ToList();

            try
            {
                var res = ZEnumerable.Single(x);
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {

            }
            
            try
            {
                var res = ZEnumerable.Single(y);
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {

            }

            try
            {
                var res = ZEnumerable.Single(z);
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {

            }
        }

        [TestMethod]
        public void SingleListOrDefaultNegative()
        {
            var x = Enumerable.Range(1, 10).ToList();
            var y = Enumerable.Range(1, 10).Select(a => new Tuple<int, int>(a,a)).ToList();
            var z = Enumerable.Range(1, 10).Select(a => new { A = a}).ToList();

            try
            {
                var res = ZEnumerable.SingleOrDefault(x);
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {

            }
            
            try
            {
                var res = ZEnumerable.SingleOrDefault(y);
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {

            }

            try
            {
                var res = ZEnumerable.SingleOrDefault(z);
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {

            }
        }

        [TestMethod]
        public void SingleListPredicateNegative()
        {
            var x = Enumerable.Range(1, 15).ToList();
            var y = Enumerable.Range(1, 15).Select(a => new Tuple<int, int>(a,a)).ToList();
            var z = Enumerable.Range(1, 15).Select(a => new { A = a}).ToList();

            try
            {
                var res = ZEnumerable.Single(x, val => val%3 == 0);
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {

            }
            
            try
            {
                var res = ZEnumerable.Single(y, val => val.Item1%3 == 0);
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {

            }

            try
            {
                var res = ZEnumerable.Single(z, val => val.A%3 == 0);
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {

            }
        }

        [TestMethod]
        public void SingleListOrDefaultPredicateNegative()
        {
            var x = Enumerable.Range(1, 15).ToList();
            var y = Enumerable.Range(1, 15).Select(a => new Tuple<int, int>(a,a)).ToList();
            var z = Enumerable.Range(1, 15).Select(a => new { A = a}).ToList();

            try
            {
                var res = ZEnumerable.SingleOrDefault(x, val => val%3 == 0);
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {

            }
            
            try
            {
                var res = ZEnumerable.SingleOrDefault(y, val => val.Item1%3 == 0);
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {

            }

            try
            {
                var res = ZEnumerable.SingleOrDefault(z, val => val.A%3 == 0);
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {

            }
        }

#endregion        


                

#region IList
        [TestMethod]
        public void SingleIList()
        {
            var x = Enumerable.Range(1, 1).ToIList();
            var y = Enumerable.Range(1, 1).Select(a => new Tuple<int, int>(a,a)).ToIList();
            var z = Enumerable.Range(1, 1).Select(a => new { A = a}).ToIList();

            Assert.AreEqual(ZEnumerable.Single(x), Enumerable.Single(x));
            Assert.AreEqual(ZEnumerable.Single(y), Enumerable.Single(y));
            Assert.AreEqual(ZEnumerable.Single(z), Enumerable.Single(z));
        }

        [TestMethod]
        public void SingleIListOrDefault()
        {
            var x = Enumerable.Range(1, 1).ToIList();
            var y = Enumerable.Range(1, 1).Select(a => new Tuple<int, int>(a,a)).ToIList();
            var z = new int[0].ToIList();

            Assert.AreEqual(ZEnumerable.SingleOrDefault(x), Enumerable.SingleOrDefault(x));
            Assert.AreEqual(ZEnumerable.SingleOrDefault(y), Enumerable.SingleOrDefault(y));
            Assert.AreEqual(ZEnumerable.SingleOrDefault(z), Enumerable.SingleOrDefault(z));
        }

        [TestMethod]
        public void SingleIListPredicate()
        {
            var x = Enumerable.Range(1, 5).ToIList();
            var y = Enumerable.Range(1, 5).Select(a => new Tuple<int, int>(a,a)).ToIList();
            var z = Enumerable.Range(1, 5).Select(a => new { A = a}).ToIList();

            Assert.AreEqual(ZEnumerable.Single(x, val => val%3 == 0), Enumerable.Single(x, val => val%3 == 0));
            Assert.AreEqual(ZEnumerable.Single(y, val => val.Item1%3 == 0), Enumerable.Single(y, val => val.Item1%3 == 0));
            Assert.AreEqual(ZEnumerable.Single(z, val => val.A%3 == 0), Enumerable.Single(z, val => val.A%3 == 0));
        }

        [TestMethod]
        public void SingleIListOrDefaultPredicate()
        {
            var x = Enumerable.Range(1, 5).ToIList();
            var y = Enumerable.Range(1, 5).Select(a => new Tuple<int, int>(a,a)).ToIList();
            var z = new int[0].ToIList();

            Assert.AreEqual(ZEnumerable.SingleOrDefault(x, val => val%3 == 0), Enumerable.SingleOrDefault(x, val => val%3 == 0));
            Assert.AreEqual(ZEnumerable.SingleOrDefault(y, val => val.Item1%3 == 0), Enumerable.SingleOrDefault(y, val => val.Item1%3 == 0));
            Assert.AreEqual(ZEnumerable.SingleOrDefault(z, val => val%3 == 0), Enumerable.SingleOrDefault(z, val => val%3 == 0));
        }
        
        [TestMethod]
        public void SingleIListNegative()
        {
            var x = Enumerable.Range(1, 10).ToIList();
            var y = Enumerable.Range(1, 10).Select(a => new Tuple<int, int>(a,a)).ToIList();
            var z = Enumerable.Range(1, 10).Select(a => new { A = a}).ToIList();

            try
            {
                var res = ZEnumerable.Single(x);
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {

            }
            
            try
            {
                var res = ZEnumerable.Single(y);
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {

            }

            try
            {
                var res = ZEnumerable.Single(z);
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {

            }
        }

        [TestMethod]
        public void SingleIListOrDefaultNegative()
        {
            var x = Enumerable.Range(1, 10).ToIList();
            var y = Enumerable.Range(1, 10).Select(a => new Tuple<int, int>(a,a)).ToIList();
            var z = Enumerable.Range(1, 10).Select(a => new { A = a}).ToIList();

            try
            {
                var res = ZEnumerable.SingleOrDefault(x);
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {

            }
            
            try
            {
                var res = ZEnumerable.SingleOrDefault(y);
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {

            }

            try
            {
                var res = ZEnumerable.SingleOrDefault(z);
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {

            }
        }

        [TestMethod]
        public void SingleIListPredicateNegative()
        {
            var x = Enumerable.Range(1, 15).ToIList();
            var y = Enumerable.Range(1, 15).Select(a => new Tuple<int, int>(a,a)).ToIList();
            var z = Enumerable.Range(1, 15).Select(a => new { A = a}).ToIList();

            try
            {
                var res = ZEnumerable.Single(x, val => val%3 == 0);
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {

            }
            
            try
            {
                var res = ZEnumerable.Single(y, val => val.Item1%3 == 0);
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {

            }

            try
            {
                var res = ZEnumerable.Single(z, val => val.A%3 == 0);
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {

            }
        }

        [TestMethod]
        public void SingleIListOrDefaultPredicateNegative()
        {
            var x = Enumerable.Range(1, 15).ToIList();
            var y = Enumerable.Range(1, 15).Select(a => new Tuple<int, int>(a,a)).ToIList();
            var z = Enumerable.Range(1, 15).Select(a => new { A = a}).ToIList();

            try
            {
                var res = ZEnumerable.SingleOrDefault(x, val => val%3 == 0);
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {

            }
            
            try
            {
                var res = ZEnumerable.SingleOrDefault(y, val => val.Item1%3 == 0);
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {

            }

            try
            {
                var res = ZEnumerable.SingleOrDefault(z, val => val.A%3 == 0);
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {

            }
        }

#endregion        


                

#region ICollection
        [TestMethod]
        public void SingleICollection()
        {
            var x = Enumerable.Range(1, 1).ToICollection();
            var y = Enumerable.Range(1, 1).Select(a => new Tuple<int, int>(a,a)).ToICollection();
            var z = Enumerable.Range(1, 1).Select(a => new { A = a}).ToICollection();

            Assert.AreEqual(ZEnumerable.Single(x), Enumerable.Single(x));
            Assert.AreEqual(ZEnumerable.Single(y), Enumerable.Single(y));
            Assert.AreEqual(ZEnumerable.Single(z), Enumerable.Single(z));
        }

        [TestMethod]
        public void SingleICollectionOrDefault()
        {
            var x = Enumerable.Range(1, 1).ToICollection();
            var y = Enumerable.Range(1, 1).Select(a => new Tuple<int, int>(a,a)).ToICollection();
            var z = new int[0].ToICollection();

            Assert.AreEqual(ZEnumerable.SingleOrDefault(x), Enumerable.SingleOrDefault(x));
            Assert.AreEqual(ZEnumerable.SingleOrDefault(y), Enumerable.SingleOrDefault(y));
            Assert.AreEqual(ZEnumerable.SingleOrDefault(z), Enumerable.SingleOrDefault(z));
        }

        [TestMethod]
        public void SingleICollectionPredicate()
        {
            var x = Enumerable.Range(1, 5).ToICollection();
            var y = Enumerable.Range(1, 5).Select(a => new Tuple<int, int>(a,a)).ToICollection();
            var z = Enumerable.Range(1, 5).Select(a => new { A = a}).ToICollection();

            Assert.AreEqual(ZEnumerable.Single(x, val => val%3 == 0), Enumerable.Single(x, val => val%3 == 0));
            Assert.AreEqual(ZEnumerable.Single(y, val => val.Item1%3 == 0), Enumerable.Single(y, val => val.Item1%3 == 0));
            Assert.AreEqual(ZEnumerable.Single(z, val => val.A%3 == 0), Enumerable.Single(z, val => val.A%3 == 0));
        }

        [TestMethod]
        public void SingleICollectionOrDefaultPredicate()
        {
            var x = Enumerable.Range(1, 5).ToICollection();
            var y = Enumerable.Range(1, 5).Select(a => new Tuple<int, int>(a,a)).ToICollection();
            var z = new int[0].ToICollection();

            Assert.AreEqual(ZEnumerable.SingleOrDefault(x, val => val%3 == 0), Enumerable.SingleOrDefault(x, val => val%3 == 0));
            Assert.AreEqual(ZEnumerable.SingleOrDefault(y, val => val.Item1%3 == 0), Enumerable.SingleOrDefault(y, val => val.Item1%3 == 0));
            Assert.AreEqual(ZEnumerable.SingleOrDefault(z, val => val%3 == 0), Enumerable.SingleOrDefault(z, val => val%3 == 0));
        }
        
        [TestMethod]
        public void SingleICollectionNegative()
        {
            var x = Enumerable.Range(1, 10).ToICollection();
            var y = Enumerable.Range(1, 10).Select(a => new Tuple<int, int>(a,a)).ToICollection();
            var z = Enumerable.Range(1, 10).Select(a => new { A = a}).ToICollection();

            try
            {
                var res = ZEnumerable.Single(x);
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {

            }
            
            try
            {
                var res = ZEnumerable.Single(y);
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {

            }

            try
            {
                var res = ZEnumerable.Single(z);
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {

            }
        }

        [TestMethod]
        public void SingleICollectionOrDefaultNegative()
        {
            var x = Enumerable.Range(1, 10).ToICollection();
            var y = Enumerable.Range(1, 10).Select(a => new Tuple<int, int>(a,a)).ToICollection();
            var z = Enumerable.Range(1, 10).Select(a => new { A = a}).ToICollection();

            try
            {
                var res = ZEnumerable.SingleOrDefault(x);
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {

            }
            
            try
            {
                var res = ZEnumerable.SingleOrDefault(y);
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {

            }

            try
            {
                var res = ZEnumerable.SingleOrDefault(z);
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {

            }
        }

        [TestMethod]
        public void SingleICollectionPredicateNegative()
        {
            var x = Enumerable.Range(1, 15).ToICollection();
            var y = Enumerable.Range(1, 15).Select(a => new Tuple<int, int>(a,a)).ToICollection();
            var z = Enumerable.Range(1, 15).Select(a => new { A = a}).ToICollection();

            try
            {
                var res = ZEnumerable.Single(x, val => val%3 == 0);
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {

            }
            
            try
            {
                var res = ZEnumerable.Single(y, val => val.Item1%3 == 0);
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {

            }

            try
            {
                var res = ZEnumerable.Single(z, val => val.A%3 == 0);
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {

            }
        }

        [TestMethod]
        public void SingleICollectionOrDefaultPredicateNegative()
        {
            var x = Enumerable.Range(1, 15).ToICollection();
            var y = Enumerable.Range(1, 15).Select(a => new Tuple<int, int>(a,a)).ToICollection();
            var z = Enumerable.Range(1, 15).Select(a => new { A = a}).ToICollection();

            try
            {
                var res = ZEnumerable.SingleOrDefault(x, val => val%3 == 0);
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {

            }
            
            try
            {
                var res = ZEnumerable.SingleOrDefault(y, val => val.Item1%3 == 0);
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {

            }

            try
            {
                var res = ZEnumerable.SingleOrDefault(z, val => val.A%3 == 0);
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {

            }
        }

#endregion        


            


    }
}
