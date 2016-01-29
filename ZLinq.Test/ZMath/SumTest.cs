
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace ZLinq.Test.ZMath
{
    [TestClass]
    public class Sum
    {		    
			
	
		#region sbyte	 		
			
        [TestMethod]
        public void TestSumsbyteArray()
        {
			const sbyte a = 10;
			const int n = 10;
            var source = Enumerable.Repeat(a, n).ToArray();

			sbyte sumActual = source.Sum();
            const sbyte sumExpected = (sbyte) a*n;

            Assert.AreEqual(sumExpected, sumActual);
        }

		[TestMethod]
        public void TestSumsbyteArrayMap()
        {
            var source = Enumerable.Repeat(new { X = (sbyte) 10}, 10).ToArray();

			sbyte sumActual = source.Sum(arg => arg.X);
            const sbyte sumExpected = 100;

            Assert.AreEqual(sumExpected, sumActual);
        }

						
		[TestMethod]
        public void TestSumsbyteArrayOverflow()
        {
            var source = (new[] { sbyte.MaxValue, sbyte.MaxValue }).ToArray();

            try
            {
                sbyte sumActual = source.Sum();
                Assert.Fail("Expected overflow but value is {0}", sumActual);
            }
            catch (OverflowException)
            {

            }

			var source2 = new sbyte[] {1, 2}.ToArray();
			var sum = source2.Sum();
			Assert.AreEqual((sbyte)3, sum);
        }

		[TestMethod]
        public void TestSumsbyteArrayMapOverflow()
        {
			var source = Enumerable.Repeat(new { X = sbyte.MaxValue}, 2).ToArray();
            try
            {
                sbyte sumActual = source.Sum(arg => arg.X);
                Assert.Fail("Expected overflow but value is {0}", sumActual);
            }
            catch (OverflowException)
            {

            }

			var source2 = new sbyte[] {1, 2}.ToArray();
			var sum = source2.Sum(x => x);
			Assert.AreEqual((sbyte)3, sum);
        }
					
        [TestMethod]
        public void TestSumsbyteList()
        {
			const sbyte a = 10;
			const int n = 10;
            var source = Enumerable.Repeat(a, n).ToList();

			sbyte sumActual = source.Sum();
            const sbyte sumExpected = (sbyte) a*n;

            Assert.AreEqual(sumExpected, sumActual);
        }

		[TestMethod]
        public void TestSumsbyteListMap()
        {
            var source = Enumerable.Repeat(new { X = (sbyte) 10}, 10).ToList();

			sbyte sumActual = source.Sum(arg => arg.X);
            const sbyte sumExpected = 100;

            Assert.AreEqual(sumExpected, sumActual);
        }

						
		[TestMethod]
        public void TestSumsbyteListOverflow()
        {
            var source = (new[] { sbyte.MaxValue, sbyte.MaxValue }).ToList();

            try
            {
                sbyte sumActual = source.Sum();
                Assert.Fail("Expected overflow but value is {0}", sumActual);
            }
            catch (OverflowException)
            {

            }

			var source2 = new sbyte[] {1, 2}.ToList();
			var sum = source2.Sum();
			Assert.AreEqual((sbyte)3, sum);
        }

		[TestMethod]
        public void TestSumsbyteListMapOverflow()
        {
			var source = Enumerable.Repeat(new { X = sbyte.MaxValue}, 2).ToList();
            try
            {
                sbyte sumActual = source.Sum(arg => arg.X);
                Assert.Fail("Expected overflow but value is {0}", sumActual);
            }
            catch (OverflowException)
            {

            }

			var source2 = new sbyte[] {1, 2}.ToList();
			var sum = source2.Sum(x => x);
			Assert.AreEqual((sbyte)3, sum);
        }
					
        [TestMethod]
        public void TestSumsbyteIList()
        {
			const sbyte a = 10;
			const int n = 10;
            var source = Enumerable.Repeat(a, n).ToList();

			sbyte sumActual = source.Sum();
            const sbyte sumExpected = (sbyte) a*n;

            Assert.AreEqual(sumExpected, sumActual);
        }

		[TestMethod]
        public void TestSumsbyteIListMap()
        {
            var source = Enumerable.Repeat(new { X = (sbyte) 10}, 10).ToList();

			sbyte sumActual = source.Sum(arg => arg.X);
            const sbyte sumExpected = 100;

            Assert.AreEqual(sumExpected, sumActual);
        }

						
		[TestMethod]
        public void TestSumsbyteIListOverflow()
        {
            var source = (new[] { sbyte.MaxValue, sbyte.MaxValue }).ToList();

            try
            {
                sbyte sumActual = source.Sum();
                Assert.Fail("Expected overflow but value is {0}", sumActual);
            }
            catch (OverflowException)
            {

            }

			var source2 = new sbyte[] {1, 2}.ToList();
			var sum = source2.Sum();
			Assert.AreEqual((sbyte)3, sum);
        }

		[TestMethod]
        public void TestSumsbyteIListMapOverflow()
        {
			var source = Enumerable.Repeat(new { X = sbyte.MaxValue}, 2).ToList();
            try
            {
                sbyte sumActual = source.Sum(arg => arg.X);
                Assert.Fail("Expected overflow but value is {0}", sumActual);
            }
            catch (OverflowException)
            {

            }

			var source2 = new sbyte[] {1, 2}.ToList();
			var sum = source2.Sum(x => x);
			Assert.AreEqual((sbyte)3, sum);
        }
					
        [TestMethod]
        public void TestSumsbyteICollection()
        {
			const sbyte a = 10;
			const int n = 10;
            var source = Enumerable.Repeat(a, n).ToList();

			sbyte sumActual = source.Sum();
            const sbyte sumExpected = (sbyte) a*n;

            Assert.AreEqual(sumExpected, sumActual);
        }

		[TestMethod]
        public void TestSumsbyteICollectionMap()
        {
            var source = Enumerable.Repeat(new { X = (sbyte) 10}, 10).ToList();

			sbyte sumActual = source.Sum(arg => arg.X);
            const sbyte sumExpected = 100;

            Assert.AreEqual(sumExpected, sumActual);
        }

						
		[TestMethod]
        public void TestSumsbyteICollectionOverflow()
        {
            var source = (new[] { sbyte.MaxValue, sbyte.MaxValue }).ToList();

            try
            {
                sbyte sumActual = source.Sum();
                Assert.Fail("Expected overflow but value is {0}", sumActual);
            }
            catch (OverflowException)
            {

            }

			var source2 = new sbyte[] {1, 2}.ToList();
			var sum = source2.Sum();
			Assert.AreEqual((sbyte)3, sum);
        }

		[TestMethod]
        public void TestSumsbyteICollectionMapOverflow()
        {
			var source = Enumerable.Repeat(new { X = sbyte.MaxValue}, 2).ToList();
            try
            {
                sbyte sumActual = source.Sum(arg => arg.X);
                Assert.Fail("Expected overflow but value is {0}", sumActual);
            }
            catch (OverflowException)
            {

            }

			var source2 = new sbyte[] {1, 2}.ToList();
			var sum = source2.Sum(x => x);
			Assert.AreEqual((sbyte)3, sum);
        }
						
		#endregion
	
		#region byte	 		
			
        [TestMethod]
        public void TestSumbyteArray()
        {
			const byte a = 10;
			const int n = 10;
            var source = Enumerable.Repeat(a, n).ToArray();

			byte sumActual = source.Sum();
            const byte sumExpected = (byte) a*n;

            Assert.AreEqual(sumExpected, sumActual);
        }

		[TestMethod]
        public void TestSumbyteArrayMap()
        {
            var source = Enumerable.Repeat(new { X = (byte) 10}, 10).ToArray();

			byte sumActual = source.Sum(arg => arg.X);
            const byte sumExpected = 100;

            Assert.AreEqual(sumExpected, sumActual);
        }

						
		[TestMethod]
        public void TestSumbyteArrayOverflow()
        {
            var source = (new[] { byte.MaxValue, byte.MaxValue }).ToArray();

            try
            {
                byte sumActual = source.Sum();
                Assert.Fail("Expected overflow but value is {0}", sumActual);
            }
            catch (OverflowException)
            {

            }

			var source2 = new byte[] {1, 2}.ToArray();
			var sum = source2.Sum();
			Assert.AreEqual((byte)3, sum);
        }

		[TestMethod]
        public void TestSumbyteArrayMapOverflow()
        {
			var source = Enumerable.Repeat(new { X = byte.MaxValue}, 2).ToArray();
            try
            {
                byte sumActual = source.Sum(arg => arg.X);
                Assert.Fail("Expected overflow but value is {0}", sumActual);
            }
            catch (OverflowException)
            {

            }

			var source2 = new byte[] {1, 2}.ToArray();
			var sum = source2.Sum(x => x);
			Assert.AreEqual((byte)3, sum);
        }
					
        [TestMethod]
        public void TestSumbyteList()
        {
			const byte a = 10;
			const int n = 10;
            var source = Enumerable.Repeat(a, n).ToList();

			byte sumActual = source.Sum();
            const byte sumExpected = (byte) a*n;

            Assert.AreEqual(sumExpected, sumActual);
        }

		[TestMethod]
        public void TestSumbyteListMap()
        {
            var source = Enumerable.Repeat(new { X = (byte) 10}, 10).ToList();

			byte sumActual = source.Sum(arg => arg.X);
            const byte sumExpected = 100;

            Assert.AreEqual(sumExpected, sumActual);
        }

						
		[TestMethod]
        public void TestSumbyteListOverflow()
        {
            var source = (new[] { byte.MaxValue, byte.MaxValue }).ToList();

            try
            {
                byte sumActual = source.Sum();
                Assert.Fail("Expected overflow but value is {0}", sumActual);
            }
            catch (OverflowException)
            {

            }

			var source2 = new byte[] {1, 2}.ToList();
			var sum = source2.Sum();
			Assert.AreEqual((byte)3, sum);
        }

		[TestMethod]
        public void TestSumbyteListMapOverflow()
        {
			var source = Enumerable.Repeat(new { X = byte.MaxValue}, 2).ToList();
            try
            {
                byte sumActual = source.Sum(arg => arg.X);
                Assert.Fail("Expected overflow but value is {0}", sumActual);
            }
            catch (OverflowException)
            {

            }

			var source2 = new byte[] {1, 2}.ToList();
			var sum = source2.Sum(x => x);
			Assert.AreEqual((byte)3, sum);
        }
					
        [TestMethod]
        public void TestSumbyteIList()
        {
			const byte a = 10;
			const int n = 10;
            var source = Enumerable.Repeat(a, n).ToList();

			byte sumActual = source.Sum();
            const byte sumExpected = (byte) a*n;

            Assert.AreEqual(sumExpected, sumActual);
        }

		[TestMethod]
        public void TestSumbyteIListMap()
        {
            var source = Enumerable.Repeat(new { X = (byte) 10}, 10).ToList();

			byte sumActual = source.Sum(arg => arg.X);
            const byte sumExpected = 100;

            Assert.AreEqual(sumExpected, sumActual);
        }

						
		[TestMethod]
        public void TestSumbyteIListOverflow()
        {
            var source = (new[] { byte.MaxValue, byte.MaxValue }).ToList();

            try
            {
                byte sumActual = source.Sum();
                Assert.Fail("Expected overflow but value is {0}", sumActual);
            }
            catch (OverflowException)
            {

            }

			var source2 = new byte[] {1, 2}.ToList();
			var sum = source2.Sum();
			Assert.AreEqual((byte)3, sum);
        }

		[TestMethod]
        public void TestSumbyteIListMapOverflow()
        {
			var source = Enumerable.Repeat(new { X = byte.MaxValue}, 2).ToList();
            try
            {
                byte sumActual = source.Sum(arg => arg.X);
                Assert.Fail("Expected overflow but value is {0}", sumActual);
            }
            catch (OverflowException)
            {

            }

			var source2 = new byte[] {1, 2}.ToList();
			var sum = source2.Sum(x => x);
			Assert.AreEqual((byte)3, sum);
        }
					
        [TestMethod]
        public void TestSumbyteICollection()
        {
			const byte a = 10;
			const int n = 10;
            var source = Enumerable.Repeat(a, n).ToList();

			byte sumActual = source.Sum();
            const byte sumExpected = (byte) a*n;

            Assert.AreEqual(sumExpected, sumActual);
        }

		[TestMethod]
        public void TestSumbyteICollectionMap()
        {
            var source = Enumerable.Repeat(new { X = (byte) 10}, 10).ToList();

			byte sumActual = source.Sum(arg => arg.X);
            const byte sumExpected = 100;

            Assert.AreEqual(sumExpected, sumActual);
        }

						
		[TestMethod]
        public void TestSumbyteICollectionOverflow()
        {
            var source = (new[] { byte.MaxValue, byte.MaxValue }).ToList();

            try
            {
                byte sumActual = source.Sum();
                Assert.Fail("Expected overflow but value is {0}", sumActual);
            }
            catch (OverflowException)
            {

            }

			var source2 = new byte[] {1, 2}.ToList();
			var sum = source2.Sum();
			Assert.AreEqual((byte)3, sum);
        }

		[TestMethod]
        public void TestSumbyteICollectionMapOverflow()
        {
			var source = Enumerable.Repeat(new { X = byte.MaxValue}, 2).ToList();
            try
            {
                byte sumActual = source.Sum(arg => arg.X);
                Assert.Fail("Expected overflow but value is {0}", sumActual);
            }
            catch (OverflowException)
            {

            }

			var source2 = new byte[] {1, 2}.ToList();
			var sum = source2.Sum(x => x);
			Assert.AreEqual((byte)3, sum);
        }
						
		#endregion
	
		#region short	 		
			
        [TestMethod]
        public void TestSumshortArray()
        {
			const short a = 10;
			const int n = 10;
            var source = Enumerable.Repeat(a, n).ToArray();

			short sumActual = source.Sum();
            const short sumExpected = (short) a*n;

            Assert.AreEqual(sumExpected, sumActual);
        }

		[TestMethod]
        public void TestSumshortArrayMap()
        {
            var source = Enumerable.Repeat(new { X = (short) 10}, 10).ToArray();

			short sumActual = source.Sum(arg => arg.X);
            const short sumExpected = 100;

            Assert.AreEqual(sumExpected, sumActual);
        }

						
		[TestMethod]
        public void TestSumshortArrayOverflow()
        {
            var source = (new[] { short.MaxValue, short.MaxValue }).ToArray();

            try
            {
                short sumActual = source.Sum();
                Assert.Fail("Expected overflow but value is {0}", sumActual);
            }
            catch (OverflowException)
            {

            }

			var source2 = new short[] {1, 2}.ToArray();
			var sum = source2.Sum();
			Assert.AreEqual((short)3, sum);
        }

		[TestMethod]
        public void TestSumshortArrayMapOverflow()
        {
			var source = Enumerable.Repeat(new { X = short.MaxValue}, 2).ToArray();
            try
            {
                short sumActual = source.Sum(arg => arg.X);
                Assert.Fail("Expected overflow but value is {0}", sumActual);
            }
            catch (OverflowException)
            {

            }

			var source2 = new short[] {1, 2}.ToArray();
			var sum = source2.Sum(x => x);
			Assert.AreEqual((short)3, sum);
        }
					
        [TestMethod]
        public void TestSumshortList()
        {
			const short a = 10;
			const int n = 10;
            var source = Enumerable.Repeat(a, n).ToList();

			short sumActual = source.Sum();
            const short sumExpected = (short) a*n;

            Assert.AreEqual(sumExpected, sumActual);
        }

		[TestMethod]
        public void TestSumshortListMap()
        {
            var source = Enumerable.Repeat(new { X = (short) 10}, 10).ToList();

			short sumActual = source.Sum(arg => arg.X);
            const short sumExpected = 100;

            Assert.AreEqual(sumExpected, sumActual);
        }

						
		[TestMethod]
        public void TestSumshortListOverflow()
        {
            var source = (new[] { short.MaxValue, short.MaxValue }).ToList();

            try
            {
                short sumActual = source.Sum();
                Assert.Fail("Expected overflow but value is {0}", sumActual);
            }
            catch (OverflowException)
            {

            }

			var source2 = new short[] {1, 2}.ToList();
			var sum = source2.Sum();
			Assert.AreEqual((short)3, sum);
        }

		[TestMethod]
        public void TestSumshortListMapOverflow()
        {
			var source = Enumerable.Repeat(new { X = short.MaxValue}, 2).ToList();
            try
            {
                short sumActual = source.Sum(arg => arg.X);
                Assert.Fail("Expected overflow but value is {0}", sumActual);
            }
            catch (OverflowException)
            {

            }

			var source2 = new short[] {1, 2}.ToList();
			var sum = source2.Sum(x => x);
			Assert.AreEqual((short)3, sum);
        }
					
        [TestMethod]
        public void TestSumshortIList()
        {
			const short a = 10;
			const int n = 10;
            var source = Enumerable.Repeat(a, n).ToList();

			short sumActual = source.Sum();
            const short sumExpected = (short) a*n;

            Assert.AreEqual(sumExpected, sumActual);
        }

		[TestMethod]
        public void TestSumshortIListMap()
        {
            var source = Enumerable.Repeat(new { X = (short) 10}, 10).ToList();

			short sumActual = source.Sum(arg => arg.X);
            const short sumExpected = 100;

            Assert.AreEqual(sumExpected, sumActual);
        }

						
		[TestMethod]
        public void TestSumshortIListOverflow()
        {
            var source = (new[] { short.MaxValue, short.MaxValue }).ToList();

            try
            {
                short sumActual = source.Sum();
                Assert.Fail("Expected overflow but value is {0}", sumActual);
            }
            catch (OverflowException)
            {

            }

			var source2 = new short[] {1, 2}.ToList();
			var sum = source2.Sum();
			Assert.AreEqual((short)3, sum);
        }

		[TestMethod]
        public void TestSumshortIListMapOverflow()
        {
			var source = Enumerable.Repeat(new { X = short.MaxValue}, 2).ToList();
            try
            {
                short sumActual = source.Sum(arg => arg.X);
                Assert.Fail("Expected overflow but value is {0}", sumActual);
            }
            catch (OverflowException)
            {

            }

			var source2 = new short[] {1, 2}.ToList();
			var sum = source2.Sum(x => x);
			Assert.AreEqual((short)3, sum);
        }
					
        [TestMethod]
        public void TestSumshortICollection()
        {
			const short a = 10;
			const int n = 10;
            var source = Enumerable.Repeat(a, n).ToList();

			short sumActual = source.Sum();
            const short sumExpected = (short) a*n;

            Assert.AreEqual(sumExpected, sumActual);
        }

		[TestMethod]
        public void TestSumshortICollectionMap()
        {
            var source = Enumerable.Repeat(new { X = (short) 10}, 10).ToList();

			short sumActual = source.Sum(arg => arg.X);
            const short sumExpected = 100;

            Assert.AreEqual(sumExpected, sumActual);
        }

						
		[TestMethod]
        public void TestSumshortICollectionOverflow()
        {
            var source = (new[] { short.MaxValue, short.MaxValue }).ToList();

            try
            {
                short sumActual = source.Sum();
                Assert.Fail("Expected overflow but value is {0}", sumActual);
            }
            catch (OverflowException)
            {

            }

			var source2 = new short[] {1, 2}.ToList();
			var sum = source2.Sum();
			Assert.AreEqual((short)3, sum);
        }

		[TestMethod]
        public void TestSumshortICollectionMapOverflow()
        {
			var source = Enumerable.Repeat(new { X = short.MaxValue}, 2).ToList();
            try
            {
                short sumActual = source.Sum(arg => arg.X);
                Assert.Fail("Expected overflow but value is {0}", sumActual);
            }
            catch (OverflowException)
            {

            }

			var source2 = new short[] {1, 2}.ToList();
			var sum = source2.Sum(x => x);
			Assert.AreEqual((short)3, sum);
        }
						
		#endregion
	
		#region ushort	 		
			
        [TestMethod]
        public void TestSumushortArray()
        {
			const ushort a = 10;
			const int n = 10;
            var source = Enumerable.Repeat(a, n).ToArray();

			ushort sumActual = source.Sum();
            const ushort sumExpected = (ushort) a*n;

            Assert.AreEqual(sumExpected, sumActual);
        }

		[TestMethod]
        public void TestSumushortArrayMap()
        {
            var source = Enumerable.Repeat(new { X = (ushort) 10}, 10).ToArray();

			ushort sumActual = source.Sum(arg => arg.X);
            const ushort sumExpected = 100;

            Assert.AreEqual(sumExpected, sumActual);
        }

						
		[TestMethod]
        public void TestSumushortArrayOverflow()
        {
            var source = (new[] { ushort.MaxValue, ushort.MaxValue }).ToArray();

            try
            {
                ushort sumActual = source.Sum();
                Assert.Fail("Expected overflow but value is {0}", sumActual);
            }
            catch (OverflowException)
            {

            }

			var source2 = new ushort[] {1, 2}.ToArray();
			var sum = source2.Sum();
			Assert.AreEqual((ushort)3, sum);
        }

		[TestMethod]
        public void TestSumushortArrayMapOverflow()
        {
			var source = Enumerable.Repeat(new { X = ushort.MaxValue}, 2).ToArray();
            try
            {
                ushort sumActual = source.Sum(arg => arg.X);
                Assert.Fail("Expected overflow but value is {0}", sumActual);
            }
            catch (OverflowException)
            {

            }

			var source2 = new ushort[] {1, 2}.ToArray();
			var sum = source2.Sum(x => x);
			Assert.AreEqual((ushort)3, sum);
        }
					
        [TestMethod]
        public void TestSumushortList()
        {
			const ushort a = 10;
			const int n = 10;
            var source = Enumerable.Repeat(a, n).ToList();

			ushort sumActual = source.Sum();
            const ushort sumExpected = (ushort) a*n;

            Assert.AreEqual(sumExpected, sumActual);
        }

		[TestMethod]
        public void TestSumushortListMap()
        {
            var source = Enumerable.Repeat(new { X = (ushort) 10}, 10).ToList();

			ushort sumActual = source.Sum(arg => arg.X);
            const ushort sumExpected = 100;

            Assert.AreEqual(sumExpected, sumActual);
        }

						
		[TestMethod]
        public void TestSumushortListOverflow()
        {
            var source = (new[] { ushort.MaxValue, ushort.MaxValue }).ToList();

            try
            {
                ushort sumActual = source.Sum();
                Assert.Fail("Expected overflow but value is {0}", sumActual);
            }
            catch (OverflowException)
            {

            }

			var source2 = new ushort[] {1, 2}.ToList();
			var sum = source2.Sum();
			Assert.AreEqual((ushort)3, sum);
        }

		[TestMethod]
        public void TestSumushortListMapOverflow()
        {
			var source = Enumerable.Repeat(new { X = ushort.MaxValue}, 2).ToList();
            try
            {
                ushort sumActual = source.Sum(arg => arg.X);
                Assert.Fail("Expected overflow but value is {0}", sumActual);
            }
            catch (OverflowException)
            {

            }

			var source2 = new ushort[] {1, 2}.ToList();
			var sum = source2.Sum(x => x);
			Assert.AreEqual((ushort)3, sum);
        }
					
        [TestMethod]
        public void TestSumushortIList()
        {
			const ushort a = 10;
			const int n = 10;
            var source = Enumerable.Repeat(a, n).ToList();

			ushort sumActual = source.Sum();
            const ushort sumExpected = (ushort) a*n;

            Assert.AreEqual(sumExpected, sumActual);
        }

		[TestMethod]
        public void TestSumushortIListMap()
        {
            var source = Enumerable.Repeat(new { X = (ushort) 10}, 10).ToList();

			ushort sumActual = source.Sum(arg => arg.X);
            const ushort sumExpected = 100;

            Assert.AreEqual(sumExpected, sumActual);
        }

						
		[TestMethod]
        public void TestSumushortIListOverflow()
        {
            var source = (new[] { ushort.MaxValue, ushort.MaxValue }).ToList();

            try
            {
                ushort sumActual = source.Sum();
                Assert.Fail("Expected overflow but value is {0}", sumActual);
            }
            catch (OverflowException)
            {

            }

			var source2 = new ushort[] {1, 2}.ToList();
			var sum = source2.Sum();
			Assert.AreEqual((ushort)3, sum);
        }

		[TestMethod]
        public void TestSumushortIListMapOverflow()
        {
			var source = Enumerable.Repeat(new { X = ushort.MaxValue}, 2).ToList();
            try
            {
                ushort sumActual = source.Sum(arg => arg.X);
                Assert.Fail("Expected overflow but value is {0}", sumActual);
            }
            catch (OverflowException)
            {

            }

			var source2 = new ushort[] {1, 2}.ToList();
			var sum = source2.Sum(x => x);
			Assert.AreEqual((ushort)3, sum);
        }
					
        [TestMethod]
        public void TestSumushortICollection()
        {
			const ushort a = 10;
			const int n = 10;
            var source = Enumerable.Repeat(a, n).ToList();

			ushort sumActual = source.Sum();
            const ushort sumExpected = (ushort) a*n;

            Assert.AreEqual(sumExpected, sumActual);
        }

		[TestMethod]
        public void TestSumushortICollectionMap()
        {
            var source = Enumerable.Repeat(new { X = (ushort) 10}, 10).ToList();

			ushort sumActual = source.Sum(arg => arg.X);
            const ushort sumExpected = 100;

            Assert.AreEqual(sumExpected, sumActual);
        }

						
		[TestMethod]
        public void TestSumushortICollectionOverflow()
        {
            var source = (new[] { ushort.MaxValue, ushort.MaxValue }).ToList();

            try
            {
                ushort sumActual = source.Sum();
                Assert.Fail("Expected overflow but value is {0}", sumActual);
            }
            catch (OverflowException)
            {

            }

			var source2 = new ushort[] {1, 2}.ToList();
			var sum = source2.Sum();
			Assert.AreEqual((ushort)3, sum);
        }

		[TestMethod]
        public void TestSumushortICollectionMapOverflow()
        {
			var source = Enumerable.Repeat(new { X = ushort.MaxValue}, 2).ToList();
            try
            {
                ushort sumActual = source.Sum(arg => arg.X);
                Assert.Fail("Expected overflow but value is {0}", sumActual);
            }
            catch (OverflowException)
            {

            }

			var source2 = new ushort[] {1, 2}.ToList();
			var sum = source2.Sum(x => x);
			Assert.AreEqual((ushort)3, sum);
        }
						
		#endregion
	
		#region int	 		
			
        [TestMethod]
        public void TestSumintArray()
        {
			const int a = 10;
			const int n = 10;
            var source = Enumerable.Repeat(a, n).ToArray();

			int sumActual = source.Sum();
            const int sumExpected = (int) a*n;

            Assert.AreEqual(sumExpected, sumActual);
        }

		[TestMethod]
        public void TestSumintArrayMap()
        {
            var source = Enumerable.Repeat(new { X = (int) 10}, 10).ToArray();

			int sumActual = source.Sum(arg => arg.X);
            const int sumExpected = 100;

            Assert.AreEqual(sumExpected, sumActual);
        }

						
		[TestMethod]
        public void TestSumintArrayOverflow()
        {
            var source = (new[] { int.MaxValue, int.MaxValue }).ToArray();

            try
            {
                int sumActual = source.Sum();
                Assert.Fail("Expected overflow but value is {0}", sumActual);
            }
            catch (OverflowException)
            {

            }

			var source2 = new int[] {1, 2}.ToArray();
			var sum = source2.Sum();
			Assert.AreEqual((int)3, sum);
        }

		[TestMethod]
        public void TestSumintArrayMapOverflow()
        {
			var source = Enumerable.Repeat(new { X = int.MaxValue}, 2).ToArray();
            try
            {
                int sumActual = source.Sum(arg => arg.X);
                Assert.Fail("Expected overflow but value is {0}", sumActual);
            }
            catch (OverflowException)
            {

            }

			var source2 = new int[] {1, 2}.ToArray();
			var sum = source2.Sum(x => x);
			Assert.AreEqual((int)3, sum);
        }
					
        [TestMethod]
        public void TestSumintList()
        {
			const int a = 10;
			const int n = 10;
            var source = Enumerable.Repeat(a, n).ToList();

			int sumActual = source.Sum();
            const int sumExpected = (int) a*n;

            Assert.AreEqual(sumExpected, sumActual);
        }

		[TestMethod]
        public void TestSumintListMap()
        {
            var source = Enumerable.Repeat(new { X = (int) 10}, 10).ToList();

			int sumActual = source.Sum(arg => arg.X);
            const int sumExpected = 100;

            Assert.AreEqual(sumExpected, sumActual);
        }

						
		[TestMethod]
        public void TestSumintListOverflow()
        {
            var source = (new[] { int.MaxValue, int.MaxValue }).ToList();

            try
            {
                int sumActual = source.Sum();
                Assert.Fail("Expected overflow but value is {0}", sumActual);
            }
            catch (OverflowException)
            {

            }

			var source2 = new int[] {1, 2}.ToList();
			var sum = source2.Sum();
			Assert.AreEqual((int)3, sum);
        }

		[TestMethod]
        public void TestSumintListMapOverflow()
        {
			var source = Enumerable.Repeat(new { X = int.MaxValue}, 2).ToList();
            try
            {
                int sumActual = source.Sum(arg => arg.X);
                Assert.Fail("Expected overflow but value is {0}", sumActual);
            }
            catch (OverflowException)
            {

            }

			var source2 = new int[] {1, 2}.ToList();
			var sum = source2.Sum(x => x);
			Assert.AreEqual((int)3, sum);
        }
					
        [TestMethod]
        public void TestSumintIList()
        {
			const int a = 10;
			const int n = 10;
            var source = Enumerable.Repeat(a, n).ToList();

			int sumActual = source.Sum();
            const int sumExpected = (int) a*n;

            Assert.AreEqual(sumExpected, sumActual);
        }

		[TestMethod]
        public void TestSumintIListMap()
        {
            var source = Enumerable.Repeat(new { X = (int) 10}, 10).ToList();

			int sumActual = source.Sum(arg => arg.X);
            const int sumExpected = 100;

            Assert.AreEqual(sumExpected, sumActual);
        }

						
		[TestMethod]
        public void TestSumintIListOverflow()
        {
            var source = (new[] { int.MaxValue, int.MaxValue }).ToList();

            try
            {
                int sumActual = source.Sum();
                Assert.Fail("Expected overflow but value is {0}", sumActual);
            }
            catch (OverflowException)
            {

            }

			var source2 = new int[] {1, 2}.ToList();
			var sum = source2.Sum();
			Assert.AreEqual((int)3, sum);
        }

		[TestMethod]
        public void TestSumintIListMapOverflow()
        {
			var source = Enumerable.Repeat(new { X = int.MaxValue}, 2).ToList();
            try
            {
                int sumActual = source.Sum(arg => arg.X);
                Assert.Fail("Expected overflow but value is {0}", sumActual);
            }
            catch (OverflowException)
            {

            }

			var source2 = new int[] {1, 2}.ToList();
			var sum = source2.Sum(x => x);
			Assert.AreEqual((int)3, sum);
        }
					
        [TestMethod]
        public void TestSumintICollection()
        {
			const int a = 10;
			const int n = 10;
            var source = Enumerable.Repeat(a, n).ToList();

			int sumActual = source.Sum();
            const int sumExpected = (int) a*n;

            Assert.AreEqual(sumExpected, sumActual);
        }

		[TestMethod]
        public void TestSumintICollectionMap()
        {
            var source = Enumerable.Repeat(new { X = (int) 10}, 10).ToList();

			int sumActual = source.Sum(arg => arg.X);
            const int sumExpected = 100;

            Assert.AreEqual(sumExpected, sumActual);
        }

						
		[TestMethod]
        public void TestSumintICollectionOverflow()
        {
            var source = (new[] { int.MaxValue, int.MaxValue }).ToList();

            try
            {
                int sumActual = source.Sum();
                Assert.Fail("Expected overflow but value is {0}", sumActual);
            }
            catch (OverflowException)
            {

            }

			var source2 = new int[] {1, 2}.ToList();
			var sum = source2.Sum();
			Assert.AreEqual((int)3, sum);
        }

		[TestMethod]
        public void TestSumintICollectionMapOverflow()
        {
			var source = Enumerable.Repeat(new { X = int.MaxValue}, 2).ToList();
            try
            {
                int sumActual = source.Sum(arg => arg.X);
                Assert.Fail("Expected overflow but value is {0}", sumActual);
            }
            catch (OverflowException)
            {

            }

			var source2 = new int[] {1, 2}.ToList();
			var sum = source2.Sum(x => x);
			Assert.AreEqual((int)3, sum);
        }
						
		#endregion
	
		#region uint	 		
			
        [TestMethod]
        public void TestSumuintArray()
        {
			const uint a = 10;
			const int n = 10;
            var source = Enumerable.Repeat(a, n).ToArray();

			uint sumActual = source.Sum();
            const uint sumExpected = (uint) a*n;

            Assert.AreEqual(sumExpected, sumActual);
        }

		[TestMethod]
        public void TestSumuintArrayMap()
        {
            var source = Enumerable.Repeat(new { X = (uint) 10}, 10).ToArray();

			uint sumActual = source.Sum(arg => arg.X);
            const uint sumExpected = 100;

            Assert.AreEqual(sumExpected, sumActual);
        }

						
		[TestMethod]
        public void TestSumuintArrayOverflow()
        {
            var source = (new[] { uint.MaxValue, uint.MaxValue }).ToArray();

            try
            {
                uint sumActual = source.Sum();
                Assert.Fail("Expected overflow but value is {0}", sumActual);
            }
            catch (OverflowException)
            {

            }

			var source2 = new uint[] {1, 2}.ToArray();
			var sum = source2.Sum();
			Assert.AreEqual((uint)3, sum);
        }

		[TestMethod]
        public void TestSumuintArrayMapOverflow()
        {
			var source = Enumerable.Repeat(new { X = uint.MaxValue}, 2).ToArray();
            try
            {
                uint sumActual = source.Sum(arg => arg.X);
                Assert.Fail("Expected overflow but value is {0}", sumActual);
            }
            catch (OverflowException)
            {

            }

			var source2 = new uint[] {1, 2}.ToArray();
			var sum = source2.Sum(x => x);
			Assert.AreEqual((uint)3, sum);
        }
					
        [TestMethod]
        public void TestSumuintList()
        {
			const uint a = 10;
			const int n = 10;
            var source = Enumerable.Repeat(a, n).ToList();

			uint sumActual = source.Sum();
            const uint sumExpected = (uint) a*n;

            Assert.AreEqual(sumExpected, sumActual);
        }

		[TestMethod]
        public void TestSumuintListMap()
        {
            var source = Enumerable.Repeat(new { X = (uint) 10}, 10).ToList();

			uint sumActual = source.Sum(arg => arg.X);
            const uint sumExpected = 100;

            Assert.AreEqual(sumExpected, sumActual);
        }

						
		[TestMethod]
        public void TestSumuintListOverflow()
        {
            var source = (new[] { uint.MaxValue, uint.MaxValue }).ToList();

            try
            {
                uint sumActual = source.Sum();
                Assert.Fail("Expected overflow but value is {0}", sumActual);
            }
            catch (OverflowException)
            {

            }

			var source2 = new uint[] {1, 2}.ToList();
			var sum = source2.Sum();
			Assert.AreEqual((uint)3, sum);
        }

		[TestMethod]
        public void TestSumuintListMapOverflow()
        {
			var source = Enumerable.Repeat(new { X = uint.MaxValue}, 2).ToList();
            try
            {
                uint sumActual = source.Sum(arg => arg.X);
                Assert.Fail("Expected overflow but value is {0}", sumActual);
            }
            catch (OverflowException)
            {

            }

			var source2 = new uint[] {1, 2}.ToList();
			var sum = source2.Sum(x => x);
			Assert.AreEqual((uint)3, sum);
        }
					
        [TestMethod]
        public void TestSumuintIList()
        {
			const uint a = 10;
			const int n = 10;
            var source = Enumerable.Repeat(a, n).ToList();

			uint sumActual = source.Sum();
            const uint sumExpected = (uint) a*n;

            Assert.AreEqual(sumExpected, sumActual);
        }

		[TestMethod]
        public void TestSumuintIListMap()
        {
            var source = Enumerable.Repeat(new { X = (uint) 10}, 10).ToList();

			uint sumActual = source.Sum(arg => arg.X);
            const uint sumExpected = 100;

            Assert.AreEqual(sumExpected, sumActual);
        }

						
		[TestMethod]
        public void TestSumuintIListOverflow()
        {
            var source = (new[] { uint.MaxValue, uint.MaxValue }).ToList();

            try
            {
                uint sumActual = source.Sum();
                Assert.Fail("Expected overflow but value is {0}", sumActual);
            }
            catch (OverflowException)
            {

            }

			var source2 = new uint[] {1, 2}.ToList();
			var sum = source2.Sum();
			Assert.AreEqual((uint)3, sum);
        }

		[TestMethod]
        public void TestSumuintIListMapOverflow()
        {
			var source = Enumerable.Repeat(new { X = uint.MaxValue}, 2).ToList();
            try
            {
                uint sumActual = source.Sum(arg => arg.X);
                Assert.Fail("Expected overflow but value is {0}", sumActual);
            }
            catch (OverflowException)
            {

            }

			var source2 = new uint[] {1, 2}.ToList();
			var sum = source2.Sum(x => x);
			Assert.AreEqual((uint)3, sum);
        }
					
        [TestMethod]
        public void TestSumuintICollection()
        {
			const uint a = 10;
			const int n = 10;
            var source = Enumerable.Repeat(a, n).ToList();

			uint sumActual = source.Sum();
            const uint sumExpected = (uint) a*n;

            Assert.AreEqual(sumExpected, sumActual);
        }

		[TestMethod]
        public void TestSumuintICollectionMap()
        {
            var source = Enumerable.Repeat(new { X = (uint) 10}, 10).ToList();

			uint sumActual = source.Sum(arg => arg.X);
            const uint sumExpected = 100;

            Assert.AreEqual(sumExpected, sumActual);
        }

						
		[TestMethod]
        public void TestSumuintICollectionOverflow()
        {
            var source = (new[] { uint.MaxValue, uint.MaxValue }).ToList();

            try
            {
                uint sumActual = source.Sum();
                Assert.Fail("Expected overflow but value is {0}", sumActual);
            }
            catch (OverflowException)
            {

            }

			var source2 = new uint[] {1, 2}.ToList();
			var sum = source2.Sum();
			Assert.AreEqual((uint)3, sum);
        }

		[TestMethod]
        public void TestSumuintICollectionMapOverflow()
        {
			var source = Enumerable.Repeat(new { X = uint.MaxValue}, 2).ToList();
            try
            {
                uint sumActual = source.Sum(arg => arg.X);
                Assert.Fail("Expected overflow but value is {0}", sumActual);
            }
            catch (OverflowException)
            {

            }

			var source2 = new uint[] {1, 2}.ToList();
			var sum = source2.Sum(x => x);
			Assert.AreEqual((uint)3, sum);
        }
						
		#endregion
	
		#region long	 		
			
        [TestMethod]
        public void TestSumlongArray()
        {
			const long a = 10;
			const int n = 10;
            var source = Enumerable.Repeat(a, n).ToArray();

			long sumActual = source.Sum();
            const long sumExpected = (long) a*n;

            Assert.AreEqual(sumExpected, sumActual);
        }

		[TestMethod]
        public void TestSumlongArrayMap()
        {
            var source = Enumerable.Repeat(new { X = (long) 10}, 10).ToArray();

			long sumActual = source.Sum(arg => arg.X);
            const long sumExpected = 100;

            Assert.AreEqual(sumExpected, sumActual);
        }

						
		[TestMethod]
        public void TestSumlongArrayOverflow()
        {
            var source = (new[] { long.MaxValue, long.MaxValue }).ToArray();

            try
            {
                long sumActual = source.Sum();
                Assert.Fail("Expected overflow but value is {0}", sumActual);
            }
            catch (OverflowException)
            {

            }

			var source2 = new long[] {1, 2}.ToArray();
			var sum = source2.Sum();
			Assert.AreEqual((long)3, sum);
        }

		[TestMethod]
        public void TestSumlongArrayMapOverflow()
        {
			var source = Enumerable.Repeat(new { X = long.MaxValue}, 2).ToArray();
            try
            {
                long sumActual = source.Sum(arg => arg.X);
                Assert.Fail("Expected overflow but value is {0}", sumActual);
            }
            catch (OverflowException)
            {

            }

			var source2 = new long[] {1, 2}.ToArray();
			var sum = source2.Sum(x => x);
			Assert.AreEqual((long)3, sum);
        }
					
        [TestMethod]
        public void TestSumlongList()
        {
			const long a = 10;
			const int n = 10;
            var source = Enumerable.Repeat(a, n).ToList();

			long sumActual = source.Sum();
            const long sumExpected = (long) a*n;

            Assert.AreEqual(sumExpected, sumActual);
        }

		[TestMethod]
        public void TestSumlongListMap()
        {
            var source = Enumerable.Repeat(new { X = (long) 10}, 10).ToList();

			long sumActual = source.Sum(arg => arg.X);
            const long sumExpected = 100;

            Assert.AreEqual(sumExpected, sumActual);
        }

						
		[TestMethod]
        public void TestSumlongListOverflow()
        {
            var source = (new[] { long.MaxValue, long.MaxValue }).ToList();

            try
            {
                long sumActual = source.Sum();
                Assert.Fail("Expected overflow but value is {0}", sumActual);
            }
            catch (OverflowException)
            {

            }

			var source2 = new long[] {1, 2}.ToList();
			var sum = source2.Sum();
			Assert.AreEqual((long)3, sum);
        }

		[TestMethod]
        public void TestSumlongListMapOverflow()
        {
			var source = Enumerable.Repeat(new { X = long.MaxValue}, 2).ToList();
            try
            {
                long sumActual = source.Sum(arg => arg.X);
                Assert.Fail("Expected overflow but value is {0}", sumActual);
            }
            catch (OverflowException)
            {

            }

			var source2 = new long[] {1, 2}.ToList();
			var sum = source2.Sum(x => x);
			Assert.AreEqual((long)3, sum);
        }
					
        [TestMethod]
        public void TestSumlongIList()
        {
			const long a = 10;
			const int n = 10;
            var source = Enumerable.Repeat(a, n).ToList();

			long sumActual = source.Sum();
            const long sumExpected = (long) a*n;

            Assert.AreEqual(sumExpected, sumActual);
        }

		[TestMethod]
        public void TestSumlongIListMap()
        {
            var source = Enumerable.Repeat(new { X = (long) 10}, 10).ToList();

			long sumActual = source.Sum(arg => arg.X);
            const long sumExpected = 100;

            Assert.AreEqual(sumExpected, sumActual);
        }

						
		[TestMethod]
        public void TestSumlongIListOverflow()
        {
            var source = (new[] { long.MaxValue, long.MaxValue }).ToList();

            try
            {
                long sumActual = source.Sum();
                Assert.Fail("Expected overflow but value is {0}", sumActual);
            }
            catch (OverflowException)
            {

            }

			var source2 = new long[] {1, 2}.ToList();
			var sum = source2.Sum();
			Assert.AreEqual((long)3, sum);
        }

		[TestMethod]
        public void TestSumlongIListMapOverflow()
        {
			var source = Enumerable.Repeat(new { X = long.MaxValue}, 2).ToList();
            try
            {
                long sumActual = source.Sum(arg => arg.X);
                Assert.Fail("Expected overflow but value is {0}", sumActual);
            }
            catch (OverflowException)
            {

            }

			var source2 = new long[] {1, 2}.ToList();
			var sum = source2.Sum(x => x);
			Assert.AreEqual((long)3, sum);
        }
					
        [TestMethod]
        public void TestSumlongICollection()
        {
			const long a = 10;
			const int n = 10;
            var source = Enumerable.Repeat(a, n).ToList();

			long sumActual = source.Sum();
            const long sumExpected = (long) a*n;

            Assert.AreEqual(sumExpected, sumActual);
        }

		[TestMethod]
        public void TestSumlongICollectionMap()
        {
            var source = Enumerable.Repeat(new { X = (long) 10}, 10).ToList();

			long sumActual = source.Sum(arg => arg.X);
            const long sumExpected = 100;

            Assert.AreEqual(sumExpected, sumActual);
        }

						
		[TestMethod]
        public void TestSumlongICollectionOverflow()
        {
            var source = (new[] { long.MaxValue, long.MaxValue }).ToList();

            try
            {
                long sumActual = source.Sum();
                Assert.Fail("Expected overflow but value is {0}", sumActual);
            }
            catch (OverflowException)
            {

            }

			var source2 = new long[] {1, 2}.ToList();
			var sum = source2.Sum();
			Assert.AreEqual((long)3, sum);
        }

		[TestMethod]
        public void TestSumlongICollectionMapOverflow()
        {
			var source = Enumerable.Repeat(new { X = long.MaxValue}, 2).ToList();
            try
            {
                long sumActual = source.Sum(arg => arg.X);
                Assert.Fail("Expected overflow but value is {0}", sumActual);
            }
            catch (OverflowException)
            {

            }

			var source2 = new long[] {1, 2}.ToList();
			var sum = source2.Sum(x => x);
			Assert.AreEqual((long)3, sum);
        }
						
		#endregion
	
		#region float	 		
			
        [TestMethod]
        public void TestSumfloatArray()
        {
			const float a = 10;
			const int n = 10;
            var source = Enumerable.Repeat(a, n).ToArray();

			float sumActual = source.Sum();
            const float sumExpected = (float) a*n;

            Assert.AreEqual(sumExpected, sumActual);
        }

		[TestMethod]
        public void TestSumfloatArrayMap()
        {
            var source = Enumerable.Repeat(new { X = (float) 10}, 10).ToArray();

			float sumActual = source.Sum(arg => arg.X);
            const float sumExpected = 100;

            Assert.AreEqual(sumExpected, sumActual);
        }

							
        [TestMethod]
        public void TestSumfloatList()
        {
			const float a = 10;
			const int n = 10;
            var source = Enumerable.Repeat(a, n).ToList();

			float sumActual = source.Sum();
            const float sumExpected = (float) a*n;

            Assert.AreEqual(sumExpected, sumActual);
        }

		[TestMethod]
        public void TestSumfloatListMap()
        {
            var source = Enumerable.Repeat(new { X = (float) 10}, 10).ToList();

			float sumActual = source.Sum(arg => arg.X);
            const float sumExpected = 100;

            Assert.AreEqual(sumExpected, sumActual);
        }

							
        [TestMethod]
        public void TestSumfloatIList()
        {
			const float a = 10;
			const int n = 10;
            var source = Enumerable.Repeat(a, n).ToList();

			float sumActual = source.Sum();
            const float sumExpected = (float) a*n;

            Assert.AreEqual(sumExpected, sumActual);
        }

		[TestMethod]
        public void TestSumfloatIListMap()
        {
            var source = Enumerable.Repeat(new { X = (float) 10}, 10).ToList();

			float sumActual = source.Sum(arg => arg.X);
            const float sumExpected = 100;

            Assert.AreEqual(sumExpected, sumActual);
        }

							
        [TestMethod]
        public void TestSumfloatICollection()
        {
			const float a = 10;
			const int n = 10;
            var source = Enumerable.Repeat(a, n).ToList();

			float sumActual = source.Sum();
            const float sumExpected = (float) a*n;

            Assert.AreEqual(sumExpected, sumActual);
        }

		[TestMethod]
        public void TestSumfloatICollectionMap()
        {
            var source = Enumerable.Repeat(new { X = (float) 10}, 10).ToList();

			float sumActual = source.Sum(arg => arg.X);
            const float sumExpected = 100;

            Assert.AreEqual(sumExpected, sumActual);
        }

								
		#endregion
	
		#region double	 		
			
        [TestMethod]
        public void TestSumdoubleArray()
        {
			const double a = 10;
			const int n = 10;
            var source = Enumerable.Repeat(a, n).ToArray();

			double sumActual = source.Sum();
            const double sumExpected = (double) a*n;

            Assert.AreEqual(sumExpected, sumActual);
        }

		[TestMethod]
        public void TestSumdoubleArrayMap()
        {
            var source = Enumerable.Repeat(new { X = (double) 10}, 10).ToArray();

			double sumActual = source.Sum(arg => arg.X);
            const double sumExpected = 100;

            Assert.AreEqual(sumExpected, sumActual);
        }

							
        [TestMethod]
        public void TestSumdoubleList()
        {
			const double a = 10;
			const int n = 10;
            var source = Enumerable.Repeat(a, n).ToList();

			double sumActual = source.Sum();
            const double sumExpected = (double) a*n;

            Assert.AreEqual(sumExpected, sumActual);
        }

		[TestMethod]
        public void TestSumdoubleListMap()
        {
            var source = Enumerable.Repeat(new { X = (double) 10}, 10).ToList();

			double sumActual = source.Sum(arg => arg.X);
            const double sumExpected = 100;

            Assert.AreEqual(sumExpected, sumActual);
        }

							
        [TestMethod]
        public void TestSumdoubleIList()
        {
			const double a = 10;
			const int n = 10;
            var source = Enumerable.Repeat(a, n).ToList();

			double sumActual = source.Sum();
            const double sumExpected = (double) a*n;

            Assert.AreEqual(sumExpected, sumActual);
        }

		[TestMethod]
        public void TestSumdoubleIListMap()
        {
            var source = Enumerable.Repeat(new { X = (double) 10}, 10).ToList();

			double sumActual = source.Sum(arg => arg.X);
            const double sumExpected = 100;

            Assert.AreEqual(sumExpected, sumActual);
        }

							
        [TestMethod]
        public void TestSumdoubleICollection()
        {
			const double a = 10;
			const int n = 10;
            var source = Enumerable.Repeat(a, n).ToList();

			double sumActual = source.Sum();
            const double sumExpected = (double) a*n;

            Assert.AreEqual(sumExpected, sumActual);
        }

		[TestMethod]
        public void TestSumdoubleICollectionMap()
        {
            var source = Enumerable.Repeat(new { X = (double) 10}, 10).ToList();

			double sumActual = source.Sum(arg => arg.X);
            const double sumExpected = 100;

            Assert.AreEqual(sumExpected, sumActual);
        }

								
		#endregion
	
		#region decimal	 		
			
        [TestMethod]
        public void TestSumdecimalArray()
        {
			const decimal a = 10;
			const int n = 10;
            var source = Enumerable.Repeat(a, n).ToArray();

			decimal sumActual = source.Sum();
            const decimal sumExpected = (decimal) a*n;

            Assert.AreEqual(sumExpected, sumActual);
        }

		[TestMethod]
        public void TestSumdecimalArrayMap()
        {
            var source = Enumerable.Repeat(new { X = (decimal) 10}, 10).ToArray();

			decimal sumActual = source.Sum(arg => arg.X);
            const decimal sumExpected = 100;

            Assert.AreEqual(sumExpected, sumActual);
        }

							
        [TestMethod]
        public void TestSumdecimalList()
        {
			const decimal a = 10;
			const int n = 10;
            var source = Enumerable.Repeat(a, n).ToList();

			decimal sumActual = source.Sum();
            const decimal sumExpected = (decimal) a*n;

            Assert.AreEqual(sumExpected, sumActual);
        }

		[TestMethod]
        public void TestSumdecimalListMap()
        {
            var source = Enumerable.Repeat(new { X = (decimal) 10}, 10).ToList();

			decimal sumActual = source.Sum(arg => arg.X);
            const decimal sumExpected = 100;

            Assert.AreEqual(sumExpected, sumActual);
        }

							
        [TestMethod]
        public void TestSumdecimalIList()
        {
			const decimal a = 10;
			const int n = 10;
            var source = Enumerable.Repeat(a, n).ToList();

			decimal sumActual = source.Sum();
            const decimal sumExpected = (decimal) a*n;

            Assert.AreEqual(sumExpected, sumActual);
        }

		[TestMethod]
        public void TestSumdecimalIListMap()
        {
            var source = Enumerable.Repeat(new { X = (decimal) 10}, 10).ToList();

			decimal sumActual = source.Sum(arg => arg.X);
            const decimal sumExpected = 100;

            Assert.AreEqual(sumExpected, sumActual);
        }

							
        [TestMethod]
        public void TestSumdecimalICollection()
        {
			const decimal a = 10;
			const int n = 10;
            var source = Enumerable.Repeat(a, n).ToList();

			decimal sumActual = source.Sum();
            const decimal sumExpected = (decimal) a*n;

            Assert.AreEqual(sumExpected, sumActual);
        }

		[TestMethod]
        public void TestSumdecimalICollectionMap()
        {
            var source = Enumerable.Repeat(new { X = (decimal) 10}, 10).ToList();

			decimal sumActual = source.Sum(arg => arg.X);
            const decimal sumExpected = 100;

            Assert.AreEqual(sumExpected, sumActual);
        }

								
		#endregion
	
		#region ulong	 		
			
        [TestMethod]
        public void TestSumulongArray()
        {
			const ulong a = 10;
			const int n = 10;
            var source = Enumerable.Repeat(a, n).ToArray();

			ulong sumActual = source.Sum();
            const ulong sumExpected = (ulong) a*n;

            Assert.AreEqual(sumExpected, sumActual);
        }

		[TestMethod]
        public void TestSumulongArrayMap()
        {
            var source = Enumerable.Repeat(new { X = (ulong) 10}, 10).ToArray();

			ulong sumActual = source.Sum(arg => arg.X);
            const ulong sumExpected = 100;

            Assert.AreEqual(sumExpected, sumActual);
        }

						
		[TestMethod]
        public void TestSumulongArrayOverflow()
        {
            var source = (new[] { ulong.MaxValue, ulong.MaxValue }).ToArray();

            try
            {
                ulong sumActual = source.Sum();
                Assert.Fail("Expected overflow but value is {0}", sumActual);
            }
            catch (OverflowException)
            {

            }

			var source2 = new ulong[] {1, 2}.ToArray();
			var sum = source2.Sum();
			Assert.AreEqual((ulong)3, sum);
        }

		[TestMethod]
        public void TestSumulongArrayMapOverflow()
        {
			var source = Enumerable.Repeat(new { X = ulong.MaxValue}, 2).ToArray();
            try
            {
                ulong sumActual = source.Sum(arg => arg.X);
                Assert.Fail("Expected overflow but value is {0}", sumActual);
            }
            catch (OverflowException)
            {

            }

			var source2 = new ulong[] {1, 2}.ToArray();
			var sum = source2.Sum(x => x);
			Assert.AreEqual((ulong)3, sum);
        }
					
        [TestMethod]
        public void TestSumulongList()
        {
			const ulong a = 10;
			const int n = 10;
            var source = Enumerable.Repeat(a, n).ToList();

			ulong sumActual = source.Sum();
            const ulong sumExpected = (ulong) a*n;

            Assert.AreEqual(sumExpected, sumActual);
        }

		[TestMethod]
        public void TestSumulongListMap()
        {
            var source = Enumerable.Repeat(new { X = (ulong) 10}, 10).ToList();

			ulong sumActual = source.Sum(arg => arg.X);
            const ulong sumExpected = 100;

            Assert.AreEqual(sumExpected, sumActual);
        }

						
		[TestMethod]
        public void TestSumulongListOverflow()
        {
            var source = (new[] { ulong.MaxValue, ulong.MaxValue }).ToList();

            try
            {
                ulong sumActual = source.Sum();
                Assert.Fail("Expected overflow but value is {0}", sumActual);
            }
            catch (OverflowException)
            {

            }

			var source2 = new ulong[] {1, 2}.ToList();
			var sum = source2.Sum();
			Assert.AreEqual((ulong)3, sum);
        }

		[TestMethod]
        public void TestSumulongListMapOverflow()
        {
			var source = Enumerable.Repeat(new { X = ulong.MaxValue}, 2).ToList();
            try
            {
                ulong sumActual = source.Sum(arg => arg.X);
                Assert.Fail("Expected overflow but value is {0}", sumActual);
            }
            catch (OverflowException)
            {

            }

			var source2 = new ulong[] {1, 2}.ToList();
			var sum = source2.Sum(x => x);
			Assert.AreEqual((ulong)3, sum);
        }
					
        [TestMethod]
        public void TestSumulongIList()
        {
			const ulong a = 10;
			const int n = 10;
            var source = Enumerable.Repeat(a, n).ToList();

			ulong sumActual = source.Sum();
            const ulong sumExpected = (ulong) a*n;

            Assert.AreEqual(sumExpected, sumActual);
        }

		[TestMethod]
        public void TestSumulongIListMap()
        {
            var source = Enumerable.Repeat(new { X = (ulong) 10}, 10).ToList();

			ulong sumActual = source.Sum(arg => arg.X);
            const ulong sumExpected = 100;

            Assert.AreEqual(sumExpected, sumActual);
        }

						
		[TestMethod]
        public void TestSumulongIListOverflow()
        {
            var source = (new[] { ulong.MaxValue, ulong.MaxValue }).ToList();

            try
            {
                ulong sumActual = source.Sum();
                Assert.Fail("Expected overflow but value is {0}", sumActual);
            }
            catch (OverflowException)
            {

            }

			var source2 = new ulong[] {1, 2}.ToList();
			var sum = source2.Sum();
			Assert.AreEqual((ulong)3, sum);
        }

		[TestMethod]
        public void TestSumulongIListMapOverflow()
        {
			var source = Enumerable.Repeat(new { X = ulong.MaxValue}, 2).ToList();
            try
            {
                ulong sumActual = source.Sum(arg => arg.X);
                Assert.Fail("Expected overflow but value is {0}", sumActual);
            }
            catch (OverflowException)
            {

            }

			var source2 = new ulong[] {1, 2}.ToList();
			var sum = source2.Sum(x => x);
			Assert.AreEqual((ulong)3, sum);
        }
					
        [TestMethod]
        public void TestSumulongICollection()
        {
			const ulong a = 10;
			const int n = 10;
            var source = Enumerable.Repeat(a, n).ToList();

			ulong sumActual = source.Sum();
            const ulong sumExpected = (ulong) a*n;

            Assert.AreEqual(sumExpected, sumActual);
        }

		[TestMethod]
        public void TestSumulongICollectionMap()
        {
            var source = Enumerable.Repeat(new { X = (ulong) 10}, 10).ToList();

			ulong sumActual = source.Sum(arg => arg.X);
            const ulong sumExpected = 100;

            Assert.AreEqual(sumExpected, sumActual);
        }

						
		[TestMethod]
        public void TestSumulongICollectionOverflow()
        {
            var source = (new[] { ulong.MaxValue, ulong.MaxValue }).ToList();

            try
            {
                ulong sumActual = source.Sum();
                Assert.Fail("Expected overflow but value is {0}", sumActual);
            }
            catch (OverflowException)
            {

            }

			var source2 = new ulong[] {1, 2}.ToList();
			var sum = source2.Sum();
			Assert.AreEqual((ulong)3, sum);
        }

		[TestMethod]
        public void TestSumulongICollectionMapOverflow()
        {
			var source = Enumerable.Repeat(new { X = ulong.MaxValue}, 2).ToList();
            try
            {
                ulong sumActual = source.Sum(arg => arg.X);
                Assert.Fail("Expected overflow but value is {0}", sumActual);
            }
            catch (OverflowException)
            {

            }

			var source2 = new ulong[] {1, 2}.ToList();
			var sum = source2.Sum(x => x);
			Assert.AreEqual((ulong)3, sum);
        }
						
		#endregion
		
    }
}