
using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace ZLinq.Test.ZMath
{
    [TestClass]
    public class Max
    {		    
			
	
		#region sbyte	 		
			
        [TestMethod]
        public void TestMaxsbyteArray()
        {
            var source = Enumerable.Range(1, 100).Select(x => (sbyte)x).ToArray();

			sbyte maxActual = ZEnumerable.Max(source);
            const sbyte maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxsbyteArrayMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (sbyte)arg }).ToArray();

			sbyte maxActual = ZEnumerable.Max(source, arg => arg.X);
            const sbyte maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }
	
		[TestMethod]
        public void TestMaxsbyteArrayNull()
        {		
			sbyte[] nullSource = null;

            try
			{
				ZEnumerable.Max(nullSource);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }

		[TestMethod]
        public void TestMaxsbyteArrayMapNull()
        {
			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<sbyte,sbyte>((sbyte) arg, (sbyte) arg)).ToArray();
			Func<KeyValuePair<sbyte, sbyte>, sbyte> map = null;
			try
			{
				ZEnumerable.Max(source, map);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }
			
        [TestMethod]
        public void TestMaxsbyteList()
        {
            var source = Enumerable.Range(1, 100).Select(x => (sbyte)x).ToList();

			sbyte maxActual = ZEnumerable.Max(source);
            const sbyte maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxsbyteListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (sbyte)arg }).ToList();

			sbyte maxActual = ZEnumerable.Max(source, arg => arg.X);
            const sbyte maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }
	
		[TestMethod]
        public void TestMaxsbyteListNull()
        {		
			List<sbyte> nullSource = null;

            try
			{
				ZEnumerable.Max(nullSource);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }

		[TestMethod]
        public void TestMaxsbyteListMapNull()
        {
			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<sbyte,sbyte>((sbyte) arg, (sbyte) arg)).ToList();
			Func<KeyValuePair<sbyte, sbyte>, sbyte> map = null;
			try
			{
				ZEnumerable.Max(source, map);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }
			
        [TestMethod]
        public void TestMaxsbyteIList()
        {
            var source = Enumerable.Range(1, 100).Select(x => (sbyte)x).ToList();

			sbyte maxActual = ZEnumerable.Max(source);
            const sbyte maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxsbyteIListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (sbyte)arg }).ToList();

			sbyte maxActual = ZEnumerable.Max(source, arg => arg.X);
            const sbyte maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }
	
		[TestMethod]
        public void TestMaxsbyteIListNull()
        {		
			IList<sbyte> nullSource = null;

            try
			{
				ZEnumerable.Max(nullSource);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }

		[TestMethod]
        public void TestMaxsbyteIListMapNull()
        {
			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<sbyte,sbyte>((sbyte) arg, (sbyte) arg)).ToList();
			Func<KeyValuePair<sbyte, sbyte>, sbyte> map = null;
			try
			{
				ZEnumerable.Max(source, map);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }
				
		#endregion
	
		#region byte	 		
			
        [TestMethod]
        public void TestMaxbyteArray()
        {
            var source = Enumerable.Range(1, 100).Select(x => (byte)x).ToArray();

			byte maxActual = ZEnumerable.Max(source);
            const byte maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxbyteArrayMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (byte)arg }).ToArray();

			byte maxActual = ZEnumerable.Max(source, arg => arg.X);
            const byte maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }
	
		[TestMethod]
        public void TestMaxbyteArrayNull()
        {		
			byte[] nullSource = null;

            try
			{
				ZEnumerable.Max(nullSource);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }

		[TestMethod]
        public void TestMaxbyteArrayMapNull()
        {
			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<byte,byte>((byte) arg, (byte) arg)).ToArray();
			Func<KeyValuePair<byte, byte>, byte> map = null;
			try
			{
				ZEnumerable.Max(source, map);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }
			
        [TestMethod]
        public void TestMaxbyteList()
        {
            var source = Enumerable.Range(1, 100).Select(x => (byte)x).ToList();

			byte maxActual = ZEnumerable.Max(source);
            const byte maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxbyteListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (byte)arg }).ToList();

			byte maxActual = ZEnumerable.Max(source, arg => arg.X);
            const byte maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }
	
		[TestMethod]
        public void TestMaxbyteListNull()
        {		
			List<byte> nullSource = null;

            try
			{
				ZEnumerable.Max(nullSource);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }

		[TestMethod]
        public void TestMaxbyteListMapNull()
        {
			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<byte,byte>((byte) arg, (byte) arg)).ToList();
			Func<KeyValuePair<byte, byte>, byte> map = null;
			try
			{
				ZEnumerable.Max(source, map);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }
			
        [TestMethod]
        public void TestMaxbyteIList()
        {
            var source = Enumerable.Range(1, 100).Select(x => (byte)x).ToList();

			byte maxActual = ZEnumerable.Max(source);
            const byte maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxbyteIListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (byte)arg }).ToList();

			byte maxActual = ZEnumerable.Max(source, arg => arg.X);
            const byte maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }
	
		[TestMethod]
        public void TestMaxbyteIListNull()
        {		
			IList<byte> nullSource = null;

            try
			{
				ZEnumerable.Max(nullSource);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }

		[TestMethod]
        public void TestMaxbyteIListMapNull()
        {
			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<byte,byte>((byte) arg, (byte) arg)).ToList();
			Func<KeyValuePair<byte, byte>, byte> map = null;
			try
			{
				ZEnumerable.Max(source, map);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }
				
		#endregion
	
		#region short	 		
			
        [TestMethod]
        public void TestMaxshortArray()
        {
            var source = Enumerable.Range(1, 100).Select(x => (short)x).ToArray();

			short maxActual = ZEnumerable.Max(source);
            const short maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxshortArrayMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (short)arg }).ToArray();

			short maxActual = ZEnumerable.Max(source, arg => arg.X);
            const short maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }
	
		[TestMethod]
        public void TestMaxshortArrayNull()
        {		
			short[] nullSource = null;

            try
			{
				ZEnumerable.Max(nullSource);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }

		[TestMethod]
        public void TestMaxshortArrayMapNull()
        {
			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<short,short>((short) arg, (short) arg)).ToArray();
			Func<KeyValuePair<short, short>, short> map = null;
			try
			{
				ZEnumerable.Max(source, map);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }
			
        [TestMethod]
        public void TestMaxshortList()
        {
            var source = Enumerable.Range(1, 100).Select(x => (short)x).ToList();

			short maxActual = ZEnumerable.Max(source);
            const short maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxshortListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (short)arg }).ToList();

			short maxActual = ZEnumerable.Max(source, arg => arg.X);
            const short maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }
	
		[TestMethod]
        public void TestMaxshortListNull()
        {		
			List<short> nullSource = null;

            try
			{
				ZEnumerable.Max(nullSource);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }

		[TestMethod]
        public void TestMaxshortListMapNull()
        {
			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<short,short>((short) arg, (short) arg)).ToList();
			Func<KeyValuePair<short, short>, short> map = null;
			try
			{
				ZEnumerable.Max(source, map);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }
			
        [TestMethod]
        public void TestMaxshortIList()
        {
            var source = Enumerable.Range(1, 100).Select(x => (short)x).ToList();

			short maxActual = ZEnumerable.Max(source);
            const short maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxshortIListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (short)arg }).ToList();

			short maxActual = ZEnumerable.Max(source, arg => arg.X);
            const short maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }
	
		[TestMethod]
        public void TestMaxshortIListNull()
        {		
			IList<short> nullSource = null;

            try
			{
				ZEnumerable.Max(nullSource);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }

		[TestMethod]
        public void TestMaxshortIListMapNull()
        {
			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<short,short>((short) arg, (short) arg)).ToList();
			Func<KeyValuePair<short, short>, short> map = null;
			try
			{
				ZEnumerable.Max(source, map);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }
				
		#endregion
	
		#region ushort	 		
			
        [TestMethod]
        public void TestMaxushortArray()
        {
            var source = Enumerable.Range(1, 100).Select(x => (ushort)x).ToArray();

			ushort maxActual = ZEnumerable.Max(source);
            const ushort maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxushortArrayMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (ushort)arg }).ToArray();

			ushort maxActual = ZEnumerable.Max(source, arg => arg.X);
            const ushort maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }
	
		[TestMethod]
        public void TestMaxushortArrayNull()
        {		
			ushort[] nullSource = null;

            try
			{
				ZEnumerable.Max(nullSource);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }

		[TestMethod]
        public void TestMaxushortArrayMapNull()
        {
			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<ushort,ushort>((ushort) arg, (ushort) arg)).ToArray();
			Func<KeyValuePair<ushort, ushort>, ushort> map = null;
			try
			{
				ZEnumerable.Max(source, map);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }
			
        [TestMethod]
        public void TestMaxushortList()
        {
            var source = Enumerable.Range(1, 100).Select(x => (ushort)x).ToList();

			ushort maxActual = ZEnumerable.Max(source);
            const ushort maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxushortListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (ushort)arg }).ToList();

			ushort maxActual = ZEnumerable.Max(source, arg => arg.X);
            const ushort maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }
	
		[TestMethod]
        public void TestMaxushortListNull()
        {		
			List<ushort> nullSource = null;

            try
			{
				ZEnumerable.Max(nullSource);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }

		[TestMethod]
        public void TestMaxushortListMapNull()
        {
			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<ushort,ushort>((ushort) arg, (ushort) arg)).ToList();
			Func<KeyValuePair<ushort, ushort>, ushort> map = null;
			try
			{
				ZEnumerable.Max(source, map);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }
			
        [TestMethod]
        public void TestMaxushortIList()
        {
            var source = Enumerable.Range(1, 100).Select(x => (ushort)x).ToList();

			ushort maxActual = ZEnumerable.Max(source);
            const ushort maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxushortIListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (ushort)arg }).ToList();

			ushort maxActual = ZEnumerable.Max(source, arg => arg.X);
            const ushort maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }
	
		[TestMethod]
        public void TestMaxushortIListNull()
        {		
			IList<ushort> nullSource = null;

            try
			{
				ZEnumerable.Max(nullSource);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }

		[TestMethod]
        public void TestMaxushortIListMapNull()
        {
			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<ushort,ushort>((ushort) arg, (ushort) arg)).ToList();
			Func<KeyValuePair<ushort, ushort>, ushort> map = null;
			try
			{
				ZEnumerable.Max(source, map);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }
				
		#endregion
	
		#region int	 		
			
        [TestMethod]
        public void TestMaxintArray()
        {
            var source = Enumerable.Range(1, 100).Select(x => (int)x).ToArray();

			int maxActual = ZEnumerable.Max(source);
            const int maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxintArrayMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (int)arg }).ToArray();

			int maxActual = ZEnumerable.Max(source, arg => arg.X);
            const int maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }
	
		[TestMethod]
        public void TestMaxintArrayNull()
        {		
			int[] nullSource = null;

            try
			{
				ZEnumerable.Max(nullSource);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }

		[TestMethod]
        public void TestMaxintArrayMapNull()
        {
			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<int,int>((int) arg, (int) arg)).ToArray();
			Func<KeyValuePair<int, int>, int> map = null;
			try
			{
				ZEnumerable.Max(source, map);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }
			
        [TestMethod]
        public void TestMaxintList()
        {
            var source = Enumerable.Range(1, 100).Select(x => (int)x).ToList();

			int maxActual = ZEnumerable.Max(source);
            const int maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxintListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (int)arg }).ToList();

			int maxActual = ZEnumerable.Max(source, arg => arg.X);
            const int maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }
	
		[TestMethod]
        public void TestMaxintListNull()
        {		
			List<int> nullSource = null;

            try
			{
				ZEnumerable.Max(nullSource);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }

		[TestMethod]
        public void TestMaxintListMapNull()
        {
			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<int,int>((int) arg, (int) arg)).ToList();
			Func<KeyValuePair<int, int>, int> map = null;
			try
			{
				ZEnumerable.Max(source, map);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }
			
        [TestMethod]
        public void TestMaxintIList()
        {
            var source = Enumerable.Range(1, 100).Select(x => (int)x).ToList();

			int maxActual = ZEnumerable.Max(source);
            const int maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxintIListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (int)arg }).ToList();

			int maxActual = ZEnumerable.Max(source, arg => arg.X);
            const int maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }
	
		[TestMethod]
        public void TestMaxintIListNull()
        {		
			IList<int> nullSource = null;

            try
			{
				ZEnumerable.Max(nullSource);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }

		[TestMethod]
        public void TestMaxintIListMapNull()
        {
			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<int,int>((int) arg, (int) arg)).ToList();
			Func<KeyValuePair<int, int>, int> map = null;
			try
			{
				ZEnumerable.Max(source, map);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }
				
		#endregion
	
		#region uint	 		
			
        [TestMethod]
        public void TestMaxuintArray()
        {
            var source = Enumerable.Range(1, 100).Select(x => (uint)x).ToArray();

			uint maxActual = ZEnumerable.Max(source);
            const uint maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxuintArrayMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (uint)arg }).ToArray();

			uint maxActual = ZEnumerable.Max(source, arg => arg.X);
            const uint maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }
	
		[TestMethod]
        public void TestMaxuintArrayNull()
        {		
			uint[] nullSource = null;

            try
			{
				ZEnumerable.Max(nullSource);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }

		[TestMethod]
        public void TestMaxuintArrayMapNull()
        {
			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<uint,uint>((uint) arg, (uint) arg)).ToArray();
			Func<KeyValuePair<uint, uint>, uint> map = null;
			try
			{
				ZEnumerable.Max(source, map);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }
			
        [TestMethod]
        public void TestMaxuintList()
        {
            var source = Enumerable.Range(1, 100).Select(x => (uint)x).ToList();

			uint maxActual = ZEnumerable.Max(source);
            const uint maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxuintListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (uint)arg }).ToList();

			uint maxActual = ZEnumerable.Max(source, arg => arg.X);
            const uint maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }
	
		[TestMethod]
        public void TestMaxuintListNull()
        {		
			List<uint> nullSource = null;

            try
			{
				ZEnumerable.Max(nullSource);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }

		[TestMethod]
        public void TestMaxuintListMapNull()
        {
			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<uint,uint>((uint) arg, (uint) arg)).ToList();
			Func<KeyValuePair<uint, uint>, uint> map = null;
			try
			{
				ZEnumerable.Max(source, map);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }
			
        [TestMethod]
        public void TestMaxuintIList()
        {
            var source = Enumerable.Range(1, 100).Select(x => (uint)x).ToList();

			uint maxActual = ZEnumerable.Max(source);
            const uint maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxuintIListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (uint)arg }).ToList();

			uint maxActual = ZEnumerable.Max(source, arg => arg.X);
            const uint maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }
	
		[TestMethod]
        public void TestMaxuintIListNull()
        {		
			IList<uint> nullSource = null;

            try
			{
				ZEnumerable.Max(nullSource);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }

		[TestMethod]
        public void TestMaxuintIListMapNull()
        {
			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<uint,uint>((uint) arg, (uint) arg)).ToList();
			Func<KeyValuePair<uint, uint>, uint> map = null;
			try
			{
				ZEnumerable.Max(source, map);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }
				
		#endregion
	
		#region long	 		
			
        [TestMethod]
        public void TestMaxlongArray()
        {
            var source = Enumerable.Range(1, 100).Select(x => (long)x).ToArray();

			long maxActual = ZEnumerable.Max(source);
            const long maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxlongArrayMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (long)arg }).ToArray();

			long maxActual = ZEnumerable.Max(source, arg => arg.X);
            const long maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }
	
		[TestMethod]
        public void TestMaxlongArrayNull()
        {		
			long[] nullSource = null;

            try
			{
				ZEnumerable.Max(nullSource);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }

		[TestMethod]
        public void TestMaxlongArrayMapNull()
        {
			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<long,long>((long) arg, (long) arg)).ToArray();
			Func<KeyValuePair<long, long>, long> map = null;
			try
			{
				ZEnumerable.Max(source, map);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }
			
        [TestMethod]
        public void TestMaxlongList()
        {
            var source = Enumerable.Range(1, 100).Select(x => (long)x).ToList();

			long maxActual = ZEnumerable.Max(source);
            const long maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxlongListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (long)arg }).ToList();

			long maxActual = ZEnumerable.Max(source, arg => arg.X);
            const long maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }
	
		[TestMethod]
        public void TestMaxlongListNull()
        {		
			List<long> nullSource = null;

            try
			{
				ZEnumerable.Max(nullSource);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }

		[TestMethod]
        public void TestMaxlongListMapNull()
        {
			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<long,long>((long) arg, (long) arg)).ToList();
			Func<KeyValuePair<long, long>, long> map = null;
			try
			{
				ZEnumerable.Max(source, map);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }
			
        [TestMethod]
        public void TestMaxlongIList()
        {
            var source = Enumerable.Range(1, 100).Select(x => (long)x).ToList();

			long maxActual = ZEnumerable.Max(source);
            const long maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxlongIListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (long)arg }).ToList();

			long maxActual = ZEnumerable.Max(source, arg => arg.X);
            const long maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }
	
		[TestMethod]
        public void TestMaxlongIListNull()
        {		
			IList<long> nullSource = null;

            try
			{
				ZEnumerable.Max(nullSource);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }

		[TestMethod]
        public void TestMaxlongIListMapNull()
        {
			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<long,long>((long) arg, (long) arg)).ToList();
			Func<KeyValuePair<long, long>, long> map = null;
			try
			{
				ZEnumerable.Max(source, map);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }
				
		#endregion
	
		#region float	 		
			
        [TestMethod]
        public void TestMaxfloatArray()
        {
            var source = Enumerable.Range(1, 100).Select(x => (float)x).ToArray();

			float maxActual = ZEnumerable.Max(source);
            const float maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxfloatArrayMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (float)arg }).ToArray();

			float maxActual = ZEnumerable.Max(source, arg => arg.X);
            const float maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }
	
		[TestMethod]
        public void TestMaxfloatArrayNull()
        {		
			float[] nullSource = null;

            try
			{
				ZEnumerable.Max(nullSource);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }

		[TestMethod]
        public void TestMaxfloatArrayMapNull()
        {
			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<float,float>((float) arg, (float) arg)).ToArray();
			Func<KeyValuePair<float, float>, float> map = null;
			try
			{
				ZEnumerable.Max(source, map);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }
			
        [TestMethod]
        public void TestMaxfloatList()
        {
            var source = Enumerable.Range(1, 100).Select(x => (float)x).ToList();

			float maxActual = ZEnumerable.Max(source);
            const float maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxfloatListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (float)arg }).ToList();

			float maxActual = ZEnumerable.Max(source, arg => arg.X);
            const float maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }
	
		[TestMethod]
        public void TestMaxfloatListNull()
        {		
			List<float> nullSource = null;

            try
			{
				ZEnumerable.Max(nullSource);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }

		[TestMethod]
        public void TestMaxfloatListMapNull()
        {
			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<float,float>((float) arg, (float) arg)).ToList();
			Func<KeyValuePair<float, float>, float> map = null;
			try
			{
				ZEnumerable.Max(source, map);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }
			
        [TestMethod]
        public void TestMaxfloatIList()
        {
            var source = Enumerable.Range(1, 100).Select(x => (float)x).ToList();

			float maxActual = ZEnumerable.Max(source);
            const float maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxfloatIListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (float)arg }).ToList();

			float maxActual = ZEnumerable.Max(source, arg => arg.X);
            const float maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }
	
		[TestMethod]
        public void TestMaxfloatIListNull()
        {		
			IList<float> nullSource = null;

            try
			{
				ZEnumerable.Max(nullSource);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }

		[TestMethod]
        public void TestMaxfloatIListMapNull()
        {
			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<float,float>((float) arg, (float) arg)).ToList();
			Func<KeyValuePair<float, float>, float> map = null;
			try
			{
				ZEnumerable.Max(source, map);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }
				
		#endregion
	
		#region double	 		
			
        [TestMethod]
        public void TestMaxdoubleArray()
        {
            var source = Enumerable.Range(1, 100).Select(x => (double)x).ToArray();

			double maxActual = ZEnumerable.Max(source);
            const double maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxdoubleArrayMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (double)arg }).ToArray();

			double maxActual = ZEnumerable.Max(source, arg => arg.X);
            const double maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }
	
		[TestMethod]
        public void TestMaxdoubleArrayNull()
        {		
			double[] nullSource = null;

            try
			{
				ZEnumerable.Max(nullSource);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }

		[TestMethod]
        public void TestMaxdoubleArrayMapNull()
        {
			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<double,double>((double) arg, (double) arg)).ToArray();
			Func<KeyValuePair<double, double>, double> map = null;
			try
			{
				ZEnumerable.Max(source, map);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }
			
        [TestMethod]
        public void TestMaxdoubleList()
        {
            var source = Enumerable.Range(1, 100).Select(x => (double)x).ToList();

			double maxActual = ZEnumerable.Max(source);
            const double maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxdoubleListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (double)arg }).ToList();

			double maxActual = ZEnumerable.Max(source, arg => arg.X);
            const double maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }
	
		[TestMethod]
        public void TestMaxdoubleListNull()
        {		
			List<double> nullSource = null;

            try
			{
				ZEnumerable.Max(nullSource);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }

		[TestMethod]
        public void TestMaxdoubleListMapNull()
        {
			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<double,double>((double) arg, (double) arg)).ToList();
			Func<KeyValuePair<double, double>, double> map = null;
			try
			{
				ZEnumerable.Max(source, map);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }
			
        [TestMethod]
        public void TestMaxdoubleIList()
        {
            var source = Enumerable.Range(1, 100).Select(x => (double)x).ToList();

			double maxActual = ZEnumerable.Max(source);
            const double maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxdoubleIListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (double)arg }).ToList();

			double maxActual = ZEnumerable.Max(source, arg => arg.X);
            const double maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }
	
		[TestMethod]
        public void TestMaxdoubleIListNull()
        {		
			IList<double> nullSource = null;

            try
			{
				ZEnumerable.Max(nullSource);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }

		[TestMethod]
        public void TestMaxdoubleIListMapNull()
        {
			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<double,double>((double) arg, (double) arg)).ToList();
			Func<KeyValuePair<double, double>, double> map = null;
			try
			{
				ZEnumerable.Max(source, map);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }
				
		#endregion
	
		#region decimal	 		
			
        [TestMethod]
        public void TestMaxdecimalArray()
        {
            var source = Enumerable.Range(1, 100).Select(x => (decimal)x).ToArray();

			decimal maxActual = ZEnumerable.Max(source);
            const decimal maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxdecimalArrayMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (decimal)arg }).ToArray();

			decimal maxActual = ZEnumerable.Max(source, arg => arg.X);
            const decimal maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }
	
		[TestMethod]
        public void TestMaxdecimalArrayNull()
        {		
			decimal[] nullSource = null;

            try
			{
				ZEnumerable.Max(nullSource);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }

		[TestMethod]
        public void TestMaxdecimalArrayMapNull()
        {
			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<decimal,decimal>((decimal) arg, (decimal) arg)).ToArray();
			Func<KeyValuePair<decimal, decimal>, decimal> map = null;
			try
			{
				ZEnumerable.Max(source, map);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }
			
        [TestMethod]
        public void TestMaxdecimalList()
        {
            var source = Enumerable.Range(1, 100).Select(x => (decimal)x).ToList();

			decimal maxActual = ZEnumerable.Max(source);
            const decimal maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxdecimalListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (decimal)arg }).ToList();

			decimal maxActual = ZEnumerable.Max(source, arg => arg.X);
            const decimal maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }
	
		[TestMethod]
        public void TestMaxdecimalListNull()
        {		
			List<decimal> nullSource = null;

            try
			{
				ZEnumerable.Max(nullSource);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }

		[TestMethod]
        public void TestMaxdecimalListMapNull()
        {
			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<decimal,decimal>((decimal) arg, (decimal) arg)).ToList();
			Func<KeyValuePair<decimal, decimal>, decimal> map = null;
			try
			{
				ZEnumerable.Max(source, map);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }
			
        [TestMethod]
        public void TestMaxdecimalIList()
        {
            var source = Enumerable.Range(1, 100).Select(x => (decimal)x).ToList();

			decimal maxActual = ZEnumerable.Max(source);
            const decimal maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxdecimalIListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (decimal)arg }).ToList();

			decimal maxActual = ZEnumerable.Max(source, arg => arg.X);
            const decimal maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }
	
		[TestMethod]
        public void TestMaxdecimalIListNull()
        {		
			IList<decimal> nullSource = null;

            try
			{
				ZEnumerable.Max(nullSource);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }

		[TestMethod]
        public void TestMaxdecimalIListMapNull()
        {
			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<decimal,decimal>((decimal) arg, (decimal) arg)).ToList();
			Func<KeyValuePair<decimal, decimal>, decimal> map = null;
			try
			{
				ZEnumerable.Max(source, map);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }
				
		#endregion
	
		#region ulong	 		
			
        [TestMethod]
        public void TestMaxulongArray()
        {
            var source = Enumerable.Range(1, 100).Select(x => (ulong)x).ToArray();

			ulong maxActual = ZEnumerable.Max(source);
            const ulong maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxulongArrayMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (ulong)arg }).ToArray();

			ulong maxActual = ZEnumerable.Max(source, arg => arg.X);
            const ulong maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }
	
		[TestMethod]
        public void TestMaxulongArrayNull()
        {		
			ulong[] nullSource = null;

            try
			{
				ZEnumerable.Max(nullSource);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }

		[TestMethod]
        public void TestMaxulongArrayMapNull()
        {
			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<ulong,ulong>((ulong) arg, (ulong) arg)).ToArray();
			Func<KeyValuePair<ulong, ulong>, ulong> map = null;
			try
			{
				ZEnumerable.Max(source, map);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }
			
        [TestMethod]
        public void TestMaxulongList()
        {
            var source = Enumerable.Range(1, 100).Select(x => (ulong)x).ToList();

			ulong maxActual = ZEnumerable.Max(source);
            const ulong maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxulongListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (ulong)arg }).ToList();

			ulong maxActual = ZEnumerable.Max(source, arg => arg.X);
            const ulong maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }
	
		[TestMethod]
        public void TestMaxulongListNull()
        {		
			List<ulong> nullSource = null;

            try
			{
				ZEnumerable.Max(nullSource);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }

		[TestMethod]
        public void TestMaxulongListMapNull()
        {
			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<ulong,ulong>((ulong) arg, (ulong) arg)).ToList();
			Func<KeyValuePair<ulong, ulong>, ulong> map = null;
			try
			{
				ZEnumerable.Max(source, map);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }
			
        [TestMethod]
        public void TestMaxulongIList()
        {
            var source = Enumerable.Range(1, 100).Select(x => (ulong)x).ToList();

			ulong maxActual = ZEnumerable.Max(source);
            const ulong maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxulongIListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (ulong)arg }).ToList();

			ulong maxActual = ZEnumerable.Max(source, arg => arg.X);
            const ulong maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }
	
		[TestMethod]
        public void TestMaxulongIListNull()
        {		
			IList<ulong> nullSource = null;

            try
			{
				ZEnumerable.Max(nullSource);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }

		[TestMethod]
        public void TestMaxulongIListMapNull()
        {
			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<ulong,ulong>((ulong) arg, (ulong) arg)).ToList();
			Func<KeyValuePair<ulong, ulong>, ulong> map = null;
			try
			{
				ZEnumerable.Max(source, map);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }
				
		#endregion
		

	#region Nullables

		
		#region sbyte?	 		
			
        [TestMethod]
        public void TestMaxsbyteNullableNullableArray()
        {
            var source = Enumerable.Range(1, 100).Select(x => (sbyte?)x).ToArray();

			sbyte? maxActual = ZEnumerable.Max(source);
            sbyte? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxsbyteNullableNullableArrayMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (sbyte?)arg }).ToArray();

			sbyte? maxActual = ZEnumerable.Max(source, arg => arg.X);
            sbyte? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }
	
		[TestMethod]
        public void TestMaxsbyteNullableNullableArrayNull()
        {		
			sbyte?[] nullSource = null;

            try
			{
				ZEnumerable.Max(nullSource);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			sbyte?[] sourceOfNulls = new sbyte?[] {null}.ToArray();
			var max = ZEnumerable.Max(sourceOfNulls);
			Assert.AreEqual(default(sbyte?), max);
        }

		[TestMethod]
        public void TestMaxsbyteNullableNullableArrayMapNull()
        {
			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<sbyte?,sbyte?>((sbyte?) arg, (sbyte?) arg)).ToArray();
			Func<KeyValuePair<sbyte?, sbyte?>, sbyte?> map = null;
			try
			{
				ZEnumerable.Max(source, map);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			object[] sourceForNulls = { new Stack<int>() };
			var sourceOfNulls = sourceForNulls.Select(x => (sbyte?) null).ToArray();
			var max = ZEnumerable.Max(sourceOfNulls);
			Assert.AreEqual(default(sbyte?), max);
        }
			
        [TestMethod]
        public void TestMaxsbyteNullableNullableList()
        {
            var source = Enumerable.Range(1, 100).Select(x => (sbyte?)x).ToList();

			sbyte? maxActual = ZEnumerable.Max(source);
            sbyte? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxsbyteNullableNullableListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (sbyte?)arg }).ToList();

			sbyte? maxActual = ZEnumerable.Max(source, arg => arg.X);
            sbyte? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }
	
		[TestMethod]
        public void TestMaxsbyteNullableNullableListNull()
        {		
			List<sbyte?> nullSource = null;

            try
			{
				ZEnumerable.Max(nullSource);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			List<sbyte?> sourceOfNulls = new sbyte?[] {null}.ToList();
			var max = ZEnumerable.Max(sourceOfNulls);
			Assert.AreEqual(default(sbyte?), max);
        }

		[TestMethod]
        public void TestMaxsbyteNullableNullableListMapNull()
        {
			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<sbyte?,sbyte?>((sbyte?) arg, (sbyte?) arg)).ToList();
			Func<KeyValuePair<sbyte?, sbyte?>, sbyte?> map = null;
			try
			{
				ZEnumerable.Max(source, map);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			object[] sourceForNulls = { new Stack<int>() };
			var sourceOfNulls = sourceForNulls.Select(x => (sbyte?) null).ToList();
			var max = ZEnumerable.Max(sourceOfNulls);
			Assert.AreEqual(default(sbyte?), max);
        }
			
        [TestMethod]
        public void TestMaxsbyteNullableNullableIList()
        {
            var source = Enumerable.Range(1, 100).Select(x => (sbyte?)x).ToList();

			sbyte? maxActual = ZEnumerable.Max(source);
            sbyte? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxsbyteNullableNullableIListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (sbyte?)arg }).ToList();

			sbyte? maxActual = ZEnumerable.Max(source, arg => arg.X);
            sbyte? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }
	
		[TestMethod]
        public void TestMaxsbyteNullableNullableIListNull()
        {		
			IList<sbyte?> nullSource = null;

            try
			{
				ZEnumerable.Max(nullSource);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			IList<sbyte?> sourceOfNulls = new sbyte?[] {null}.ToList();
			var max = ZEnumerable.Max(sourceOfNulls);
			Assert.AreEqual(default(sbyte?), max);
        }

		[TestMethod]
        public void TestMaxsbyteNullableNullableIListMapNull()
        {
			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<sbyte?,sbyte?>((sbyte?) arg, (sbyte?) arg)).ToList();
			Func<KeyValuePair<sbyte?, sbyte?>, sbyte?> map = null;
			try
			{
				ZEnumerable.Max(source, map);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			object[] sourceForNulls = { new Stack<int>() };
			var sourceOfNulls = sourceForNulls.Select(x => (sbyte?) null).ToList();
			var max = ZEnumerable.Max(sourceOfNulls);
			Assert.AreEqual(default(sbyte?), max);
        }
				
		#endregion
	
		#region byte?	 		
			
        [TestMethod]
        public void TestMaxbyteNullableNullableArray()
        {
            var source = Enumerable.Range(1, 100).Select(x => (byte?)x).ToArray();

			byte? maxActual = ZEnumerable.Max(source);
            byte? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxbyteNullableNullableArrayMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (byte?)arg }).ToArray();

			byte? maxActual = ZEnumerable.Max(source, arg => arg.X);
            byte? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }
	
		[TestMethod]
        public void TestMaxbyteNullableNullableArrayNull()
        {		
			byte?[] nullSource = null;

            try
			{
				ZEnumerable.Max(nullSource);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			byte?[] sourceOfNulls = new byte?[] {null}.ToArray();
			var max = ZEnumerable.Max(sourceOfNulls);
			Assert.AreEqual(default(byte?), max);
        }

		[TestMethod]
        public void TestMaxbyteNullableNullableArrayMapNull()
        {
			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<byte?,byte?>((byte?) arg, (byte?) arg)).ToArray();
			Func<KeyValuePair<byte?, byte?>, byte?> map = null;
			try
			{
				ZEnumerable.Max(source, map);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			object[] sourceForNulls = { new Stack<int>() };
			var sourceOfNulls = sourceForNulls.Select(x => (byte?) null).ToArray();
			var max = ZEnumerable.Max(sourceOfNulls);
			Assert.AreEqual(default(byte?), max);
        }
			
        [TestMethod]
        public void TestMaxbyteNullableNullableList()
        {
            var source = Enumerable.Range(1, 100).Select(x => (byte?)x).ToList();

			byte? maxActual = ZEnumerable.Max(source);
            byte? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxbyteNullableNullableListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (byte?)arg }).ToList();

			byte? maxActual = ZEnumerable.Max(source, arg => arg.X);
            byte? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }
	
		[TestMethod]
        public void TestMaxbyteNullableNullableListNull()
        {		
			List<byte?> nullSource = null;

            try
			{
				ZEnumerable.Max(nullSource);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			List<byte?> sourceOfNulls = new byte?[] {null}.ToList();
			var max = ZEnumerable.Max(sourceOfNulls);
			Assert.AreEqual(default(byte?), max);
        }

		[TestMethod]
        public void TestMaxbyteNullableNullableListMapNull()
        {
			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<byte?,byte?>((byte?) arg, (byte?) arg)).ToList();
			Func<KeyValuePair<byte?, byte?>, byte?> map = null;
			try
			{
				ZEnumerable.Max(source, map);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			object[] sourceForNulls = { new Stack<int>() };
			var sourceOfNulls = sourceForNulls.Select(x => (byte?) null).ToList();
			var max = ZEnumerable.Max(sourceOfNulls);
			Assert.AreEqual(default(byte?), max);
        }
			
        [TestMethod]
        public void TestMaxbyteNullableNullableIList()
        {
            var source = Enumerable.Range(1, 100).Select(x => (byte?)x).ToList();

			byte? maxActual = ZEnumerable.Max(source);
            byte? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxbyteNullableNullableIListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (byte?)arg }).ToList();

			byte? maxActual = ZEnumerable.Max(source, arg => arg.X);
            byte? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }
	
		[TestMethod]
        public void TestMaxbyteNullableNullableIListNull()
        {		
			IList<byte?> nullSource = null;

            try
			{
				ZEnumerable.Max(nullSource);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			IList<byte?> sourceOfNulls = new byte?[] {null}.ToList();
			var max = ZEnumerable.Max(sourceOfNulls);
			Assert.AreEqual(default(byte?), max);
        }

		[TestMethod]
        public void TestMaxbyteNullableNullableIListMapNull()
        {
			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<byte?,byte?>((byte?) arg, (byte?) arg)).ToList();
			Func<KeyValuePair<byte?, byte?>, byte?> map = null;
			try
			{
				ZEnumerable.Max(source, map);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			object[] sourceForNulls = { new Stack<int>() };
			var sourceOfNulls = sourceForNulls.Select(x => (byte?) null).ToList();
			var max = ZEnumerable.Max(sourceOfNulls);
			Assert.AreEqual(default(byte?), max);
        }
				
		#endregion
	
		#region short?	 		
			
        [TestMethod]
        public void TestMaxshortNullableNullableArray()
        {
            var source = Enumerable.Range(1, 100).Select(x => (short?)x).ToArray();

			short? maxActual = ZEnumerable.Max(source);
            short? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxshortNullableNullableArrayMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (short?)arg }).ToArray();

			short? maxActual = ZEnumerable.Max(source, arg => arg.X);
            short? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }
	
		[TestMethod]
        public void TestMaxshortNullableNullableArrayNull()
        {		
			short?[] nullSource = null;

            try
			{
				ZEnumerable.Max(nullSource);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			short?[] sourceOfNulls = new short?[] {null}.ToArray();
			var max = ZEnumerable.Max(sourceOfNulls);
			Assert.AreEqual(default(short?), max);
        }

		[TestMethod]
        public void TestMaxshortNullableNullableArrayMapNull()
        {
			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<short?,short?>((short?) arg, (short?) arg)).ToArray();
			Func<KeyValuePair<short?, short?>, short?> map = null;
			try
			{
				ZEnumerable.Max(source, map);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			object[] sourceForNulls = { new Stack<int>() };
			var sourceOfNulls = sourceForNulls.Select(x => (short?) null).ToArray();
			var max = ZEnumerable.Max(sourceOfNulls);
			Assert.AreEqual(default(short?), max);
        }
			
        [TestMethod]
        public void TestMaxshortNullableNullableList()
        {
            var source = Enumerable.Range(1, 100).Select(x => (short?)x).ToList();

			short? maxActual = ZEnumerable.Max(source);
            short? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxshortNullableNullableListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (short?)arg }).ToList();

			short? maxActual = ZEnumerable.Max(source, arg => arg.X);
            short? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }
	
		[TestMethod]
        public void TestMaxshortNullableNullableListNull()
        {		
			List<short?> nullSource = null;

            try
			{
				ZEnumerable.Max(nullSource);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			List<short?> sourceOfNulls = new short?[] {null}.ToList();
			var max = ZEnumerable.Max(sourceOfNulls);
			Assert.AreEqual(default(short?), max);
        }

		[TestMethod]
        public void TestMaxshortNullableNullableListMapNull()
        {
			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<short?,short?>((short?) arg, (short?) arg)).ToList();
			Func<KeyValuePair<short?, short?>, short?> map = null;
			try
			{
				ZEnumerable.Max(source, map);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			object[] sourceForNulls = { new Stack<int>() };
			var sourceOfNulls = sourceForNulls.Select(x => (short?) null).ToList();
			var max = ZEnumerable.Max(sourceOfNulls);
			Assert.AreEqual(default(short?), max);
        }
			
        [TestMethod]
        public void TestMaxshortNullableNullableIList()
        {
            var source = Enumerable.Range(1, 100).Select(x => (short?)x).ToList();

			short? maxActual = ZEnumerable.Max(source);
            short? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxshortNullableNullableIListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (short?)arg }).ToList();

			short? maxActual = ZEnumerable.Max(source, arg => arg.X);
            short? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }
	
		[TestMethod]
        public void TestMaxshortNullableNullableIListNull()
        {		
			IList<short?> nullSource = null;

            try
			{
				ZEnumerable.Max(nullSource);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			IList<short?> sourceOfNulls = new short?[] {null}.ToList();
			var max = ZEnumerable.Max(sourceOfNulls);
			Assert.AreEqual(default(short?), max);
        }

		[TestMethod]
        public void TestMaxshortNullableNullableIListMapNull()
        {
			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<short?,short?>((short?) arg, (short?) arg)).ToList();
			Func<KeyValuePair<short?, short?>, short?> map = null;
			try
			{
				ZEnumerable.Max(source, map);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			object[] sourceForNulls = { new Stack<int>() };
			var sourceOfNulls = sourceForNulls.Select(x => (short?) null).ToList();
			var max = ZEnumerable.Max(sourceOfNulls);
			Assert.AreEqual(default(short?), max);
        }
				
		#endregion
	
		#region ushort?	 		
			
        [TestMethod]
        public void TestMaxushortNullableNullableArray()
        {
            var source = Enumerable.Range(1, 100).Select(x => (ushort?)x).ToArray();

			ushort? maxActual = ZEnumerable.Max(source);
            ushort? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxushortNullableNullableArrayMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (ushort?)arg }).ToArray();

			ushort? maxActual = ZEnumerable.Max(source, arg => arg.X);
            ushort? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }
	
		[TestMethod]
        public void TestMaxushortNullableNullableArrayNull()
        {		
			ushort?[] nullSource = null;

            try
			{
				ZEnumerable.Max(nullSource);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			ushort?[] sourceOfNulls = new ushort?[] {null}.ToArray();
			var max = ZEnumerable.Max(sourceOfNulls);
			Assert.AreEqual(default(ushort?), max);
        }

		[TestMethod]
        public void TestMaxushortNullableNullableArrayMapNull()
        {
			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<ushort?,ushort?>((ushort?) arg, (ushort?) arg)).ToArray();
			Func<KeyValuePair<ushort?, ushort?>, ushort?> map = null;
			try
			{
				ZEnumerable.Max(source, map);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			object[] sourceForNulls = { new Stack<int>() };
			var sourceOfNulls = sourceForNulls.Select(x => (ushort?) null).ToArray();
			var max = ZEnumerable.Max(sourceOfNulls);
			Assert.AreEqual(default(ushort?), max);
        }
			
        [TestMethod]
        public void TestMaxushortNullableNullableList()
        {
            var source = Enumerable.Range(1, 100).Select(x => (ushort?)x).ToList();

			ushort? maxActual = ZEnumerable.Max(source);
            ushort? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxushortNullableNullableListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (ushort?)arg }).ToList();

			ushort? maxActual = ZEnumerable.Max(source, arg => arg.X);
            ushort? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }
	
		[TestMethod]
        public void TestMaxushortNullableNullableListNull()
        {		
			List<ushort?> nullSource = null;

            try
			{
				ZEnumerable.Max(nullSource);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			List<ushort?> sourceOfNulls = new ushort?[] {null}.ToList();
			var max = ZEnumerable.Max(sourceOfNulls);
			Assert.AreEqual(default(ushort?), max);
        }

		[TestMethod]
        public void TestMaxushortNullableNullableListMapNull()
        {
			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<ushort?,ushort?>((ushort?) arg, (ushort?) arg)).ToList();
			Func<KeyValuePair<ushort?, ushort?>, ushort?> map = null;
			try
			{
				ZEnumerable.Max(source, map);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			object[] sourceForNulls = { new Stack<int>() };
			var sourceOfNulls = sourceForNulls.Select(x => (ushort?) null).ToList();
			var max = ZEnumerable.Max(sourceOfNulls);
			Assert.AreEqual(default(ushort?), max);
        }
			
        [TestMethod]
        public void TestMaxushortNullableNullableIList()
        {
            var source = Enumerable.Range(1, 100).Select(x => (ushort?)x).ToList();

			ushort? maxActual = ZEnumerable.Max(source);
            ushort? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxushortNullableNullableIListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (ushort?)arg }).ToList();

			ushort? maxActual = ZEnumerable.Max(source, arg => arg.X);
            ushort? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }
	
		[TestMethod]
        public void TestMaxushortNullableNullableIListNull()
        {		
			IList<ushort?> nullSource = null;

            try
			{
				ZEnumerable.Max(nullSource);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			IList<ushort?> sourceOfNulls = new ushort?[] {null}.ToList();
			var max = ZEnumerable.Max(sourceOfNulls);
			Assert.AreEqual(default(ushort?), max);
        }

		[TestMethod]
        public void TestMaxushortNullableNullableIListMapNull()
        {
			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<ushort?,ushort?>((ushort?) arg, (ushort?) arg)).ToList();
			Func<KeyValuePair<ushort?, ushort?>, ushort?> map = null;
			try
			{
				ZEnumerable.Max(source, map);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			object[] sourceForNulls = { new Stack<int>() };
			var sourceOfNulls = sourceForNulls.Select(x => (ushort?) null).ToList();
			var max = ZEnumerable.Max(sourceOfNulls);
			Assert.AreEqual(default(ushort?), max);
        }
				
		#endregion
	
		#region int?	 		
			
        [TestMethod]
        public void TestMaxintNullableNullableArray()
        {
            var source = Enumerable.Range(1, 100).Select(x => (int?)x).ToArray();

			int? maxActual = ZEnumerable.Max(source);
            int? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxintNullableNullableArrayMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (int?)arg }).ToArray();

			int? maxActual = ZEnumerable.Max(source, arg => arg.X);
            int? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }
	
		[TestMethod]
        public void TestMaxintNullableNullableArrayNull()
        {		
			int?[] nullSource = null;

            try
			{
				ZEnumerable.Max(nullSource);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			int?[] sourceOfNulls = new int?[] {null}.ToArray();
			var max = ZEnumerable.Max(sourceOfNulls);
			Assert.AreEqual(default(int?), max);
        }

		[TestMethod]
        public void TestMaxintNullableNullableArrayMapNull()
        {
			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<int?,int?>((int?) arg, (int?) arg)).ToArray();
			Func<KeyValuePair<int?, int?>, int?> map = null;
			try
			{
				ZEnumerable.Max(source, map);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			object[] sourceForNulls = { new Stack<int>() };
			var sourceOfNulls = sourceForNulls.Select(x => (int?) null).ToArray();
			var max = ZEnumerable.Max(sourceOfNulls);
			Assert.AreEqual(default(int?), max);
        }
			
        [TestMethod]
        public void TestMaxintNullableNullableList()
        {
            var source = Enumerable.Range(1, 100).Select(x => (int?)x).ToList();

			int? maxActual = ZEnumerable.Max(source);
            int? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxintNullableNullableListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (int?)arg }).ToList();

			int? maxActual = ZEnumerable.Max(source, arg => arg.X);
            int? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }
	
		[TestMethod]
        public void TestMaxintNullableNullableListNull()
        {		
			List<int?> nullSource = null;

            try
			{
				ZEnumerable.Max(nullSource);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			List<int?> sourceOfNulls = new int?[] {null}.ToList();
			var max = ZEnumerable.Max(sourceOfNulls);
			Assert.AreEqual(default(int?), max);
        }

		[TestMethod]
        public void TestMaxintNullableNullableListMapNull()
        {
			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<int?,int?>((int?) arg, (int?) arg)).ToList();
			Func<KeyValuePair<int?, int?>, int?> map = null;
			try
			{
				ZEnumerable.Max(source, map);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			object[] sourceForNulls = { new Stack<int>() };
			var sourceOfNulls = sourceForNulls.Select(x => (int?) null).ToList();
			var max = ZEnumerable.Max(sourceOfNulls);
			Assert.AreEqual(default(int?), max);
        }
			
        [TestMethod]
        public void TestMaxintNullableNullableIList()
        {
            var source = Enumerable.Range(1, 100).Select(x => (int?)x).ToList();

			int? maxActual = ZEnumerable.Max(source);
            int? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxintNullableNullableIListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (int?)arg }).ToList();

			int? maxActual = ZEnumerable.Max(source, arg => arg.X);
            int? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }
	
		[TestMethod]
        public void TestMaxintNullableNullableIListNull()
        {		
			IList<int?> nullSource = null;

            try
			{
				ZEnumerable.Max(nullSource);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			IList<int?> sourceOfNulls = new int?[] {null}.ToList();
			var max = ZEnumerable.Max(sourceOfNulls);
			Assert.AreEqual(default(int?), max);
        }

		[TestMethod]
        public void TestMaxintNullableNullableIListMapNull()
        {
			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<int?,int?>((int?) arg, (int?) arg)).ToList();
			Func<KeyValuePair<int?, int?>, int?> map = null;
			try
			{
				ZEnumerable.Max(source, map);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			object[] sourceForNulls = { new Stack<int>() };
			var sourceOfNulls = sourceForNulls.Select(x => (int?) null).ToList();
			var max = ZEnumerable.Max(sourceOfNulls);
			Assert.AreEqual(default(int?), max);
        }
				
		#endregion
	
		#region uint?	 		
			
        [TestMethod]
        public void TestMaxuintNullableNullableArray()
        {
            var source = Enumerable.Range(1, 100).Select(x => (uint?)x).ToArray();

			uint? maxActual = ZEnumerable.Max(source);
            uint? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxuintNullableNullableArrayMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (uint?)arg }).ToArray();

			uint? maxActual = ZEnumerable.Max(source, arg => arg.X);
            uint? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }
	
		[TestMethod]
        public void TestMaxuintNullableNullableArrayNull()
        {		
			uint?[] nullSource = null;

            try
			{
				ZEnumerable.Max(nullSource);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			uint?[] sourceOfNulls = new uint?[] {null}.ToArray();
			var max = ZEnumerable.Max(sourceOfNulls);
			Assert.AreEqual(default(uint?), max);
        }

		[TestMethod]
        public void TestMaxuintNullableNullableArrayMapNull()
        {
			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<uint?,uint?>((uint?) arg, (uint?) arg)).ToArray();
			Func<KeyValuePair<uint?, uint?>, uint?> map = null;
			try
			{
				ZEnumerable.Max(source, map);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			object[] sourceForNulls = { new Stack<int>() };
			var sourceOfNulls = sourceForNulls.Select(x => (uint?) null).ToArray();
			var max = ZEnumerable.Max(sourceOfNulls);
			Assert.AreEqual(default(uint?), max);
        }
			
        [TestMethod]
        public void TestMaxuintNullableNullableList()
        {
            var source = Enumerable.Range(1, 100).Select(x => (uint?)x).ToList();

			uint? maxActual = ZEnumerable.Max(source);
            uint? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxuintNullableNullableListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (uint?)arg }).ToList();

			uint? maxActual = ZEnumerable.Max(source, arg => arg.X);
            uint? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }
	
		[TestMethod]
        public void TestMaxuintNullableNullableListNull()
        {		
			List<uint?> nullSource = null;

            try
			{
				ZEnumerable.Max(nullSource);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			List<uint?> sourceOfNulls = new uint?[] {null}.ToList();
			var max = ZEnumerable.Max(sourceOfNulls);
			Assert.AreEqual(default(uint?), max);
        }

		[TestMethod]
        public void TestMaxuintNullableNullableListMapNull()
        {
			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<uint?,uint?>((uint?) arg, (uint?) arg)).ToList();
			Func<KeyValuePair<uint?, uint?>, uint?> map = null;
			try
			{
				ZEnumerable.Max(source, map);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			object[] sourceForNulls = { new Stack<int>() };
			var sourceOfNulls = sourceForNulls.Select(x => (uint?) null).ToList();
			var max = ZEnumerable.Max(sourceOfNulls);
			Assert.AreEqual(default(uint?), max);
        }
			
        [TestMethod]
        public void TestMaxuintNullableNullableIList()
        {
            var source = Enumerable.Range(1, 100).Select(x => (uint?)x).ToList();

			uint? maxActual = ZEnumerable.Max(source);
            uint? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxuintNullableNullableIListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (uint?)arg }).ToList();

			uint? maxActual = ZEnumerable.Max(source, arg => arg.X);
            uint? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }
	
		[TestMethod]
        public void TestMaxuintNullableNullableIListNull()
        {		
			IList<uint?> nullSource = null;

            try
			{
				ZEnumerable.Max(nullSource);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			IList<uint?> sourceOfNulls = new uint?[] {null}.ToList();
			var max = ZEnumerable.Max(sourceOfNulls);
			Assert.AreEqual(default(uint?), max);
        }

		[TestMethod]
        public void TestMaxuintNullableNullableIListMapNull()
        {
			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<uint?,uint?>((uint?) arg, (uint?) arg)).ToList();
			Func<KeyValuePair<uint?, uint?>, uint?> map = null;
			try
			{
				ZEnumerable.Max(source, map);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			object[] sourceForNulls = { new Stack<int>() };
			var sourceOfNulls = sourceForNulls.Select(x => (uint?) null).ToList();
			var max = ZEnumerable.Max(sourceOfNulls);
			Assert.AreEqual(default(uint?), max);
        }
				
		#endregion
	
		#region long?	 		
			
        [TestMethod]
        public void TestMaxlongNullableNullableArray()
        {
            var source = Enumerable.Range(1, 100).Select(x => (long?)x).ToArray();

			long? maxActual = ZEnumerable.Max(source);
            long? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxlongNullableNullableArrayMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (long?)arg }).ToArray();

			long? maxActual = ZEnumerable.Max(source, arg => arg.X);
            long? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }
	
		[TestMethod]
        public void TestMaxlongNullableNullableArrayNull()
        {		
			long?[] nullSource = null;

            try
			{
				ZEnumerable.Max(nullSource);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			long?[] sourceOfNulls = new long?[] {null}.ToArray();
			var max = ZEnumerable.Max(sourceOfNulls);
			Assert.AreEqual(default(long?), max);
        }

		[TestMethod]
        public void TestMaxlongNullableNullableArrayMapNull()
        {
			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<long?,long?>((long?) arg, (long?) arg)).ToArray();
			Func<KeyValuePair<long?, long?>, long?> map = null;
			try
			{
				ZEnumerable.Max(source, map);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			object[] sourceForNulls = { new Stack<int>() };
			var sourceOfNulls = sourceForNulls.Select(x => (long?) null).ToArray();
			var max = ZEnumerable.Max(sourceOfNulls);
			Assert.AreEqual(default(long?), max);
        }
			
        [TestMethod]
        public void TestMaxlongNullableNullableList()
        {
            var source = Enumerable.Range(1, 100).Select(x => (long?)x).ToList();

			long? maxActual = ZEnumerable.Max(source);
            long? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxlongNullableNullableListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (long?)arg }).ToList();

			long? maxActual = ZEnumerable.Max(source, arg => arg.X);
            long? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }
	
		[TestMethod]
        public void TestMaxlongNullableNullableListNull()
        {		
			List<long?> nullSource = null;

            try
			{
				ZEnumerable.Max(nullSource);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			List<long?> sourceOfNulls = new long?[] {null}.ToList();
			var max = ZEnumerable.Max(sourceOfNulls);
			Assert.AreEqual(default(long?), max);
        }

		[TestMethod]
        public void TestMaxlongNullableNullableListMapNull()
        {
			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<long?,long?>((long?) arg, (long?) arg)).ToList();
			Func<KeyValuePair<long?, long?>, long?> map = null;
			try
			{
				ZEnumerable.Max(source, map);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			object[] sourceForNulls = { new Stack<int>() };
			var sourceOfNulls = sourceForNulls.Select(x => (long?) null).ToList();
			var max = ZEnumerable.Max(sourceOfNulls);
			Assert.AreEqual(default(long?), max);
        }
			
        [TestMethod]
        public void TestMaxlongNullableNullableIList()
        {
            var source = Enumerable.Range(1, 100).Select(x => (long?)x).ToList();

			long? maxActual = ZEnumerable.Max(source);
            long? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxlongNullableNullableIListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (long?)arg }).ToList();

			long? maxActual = ZEnumerable.Max(source, arg => arg.X);
            long? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }
	
		[TestMethod]
        public void TestMaxlongNullableNullableIListNull()
        {		
			IList<long?> nullSource = null;

            try
			{
				ZEnumerable.Max(nullSource);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			IList<long?> sourceOfNulls = new long?[] {null}.ToList();
			var max = ZEnumerable.Max(sourceOfNulls);
			Assert.AreEqual(default(long?), max);
        }

		[TestMethod]
        public void TestMaxlongNullableNullableIListMapNull()
        {
			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<long?,long?>((long?) arg, (long?) arg)).ToList();
			Func<KeyValuePair<long?, long?>, long?> map = null;
			try
			{
				ZEnumerable.Max(source, map);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			object[] sourceForNulls = { new Stack<int>() };
			var sourceOfNulls = sourceForNulls.Select(x => (long?) null).ToList();
			var max = ZEnumerable.Max(sourceOfNulls);
			Assert.AreEqual(default(long?), max);
        }
				
		#endregion
	
		#region float?	 		
			
        [TestMethod]
        public void TestMaxfloatNullableNullableArray()
        {
            var source = Enumerable.Range(1, 100).Select(x => (float?)x).ToArray();

			float? maxActual = ZEnumerable.Max(source);
            float? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxfloatNullableNullableArrayMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (float?)arg }).ToArray();

			float? maxActual = ZEnumerable.Max(source, arg => arg.X);
            float? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }
	
		[TestMethod]
        public void TestMaxfloatNullableNullableArrayNull()
        {		
			float?[] nullSource = null;

            try
			{
				ZEnumerable.Max(nullSource);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			float?[] sourceOfNulls = new float?[] {null}.ToArray();
			var max = ZEnumerable.Max(sourceOfNulls);
			Assert.AreEqual(default(float?), max);
        }

		[TestMethod]
        public void TestMaxfloatNullableNullableArrayMapNull()
        {
			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<float?,float?>((float?) arg, (float?) arg)).ToArray();
			Func<KeyValuePair<float?, float?>, float?> map = null;
			try
			{
				ZEnumerable.Max(source, map);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			object[] sourceForNulls = { new Stack<int>() };
			var sourceOfNulls = sourceForNulls.Select(x => (float?) null).ToArray();
			var max = ZEnumerable.Max(sourceOfNulls);
			Assert.AreEqual(default(float?), max);
        }
			
        [TestMethod]
        public void TestMaxfloatNullableNullableList()
        {
            var source = Enumerable.Range(1, 100).Select(x => (float?)x).ToList();

			float? maxActual = ZEnumerable.Max(source);
            float? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxfloatNullableNullableListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (float?)arg }).ToList();

			float? maxActual = ZEnumerable.Max(source, arg => arg.X);
            float? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }
	
		[TestMethod]
        public void TestMaxfloatNullableNullableListNull()
        {		
			List<float?> nullSource = null;

            try
			{
				ZEnumerable.Max(nullSource);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			List<float?> sourceOfNulls = new float?[] {null}.ToList();
			var max = ZEnumerable.Max(sourceOfNulls);
			Assert.AreEqual(default(float?), max);
        }

		[TestMethod]
        public void TestMaxfloatNullableNullableListMapNull()
        {
			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<float?,float?>((float?) arg, (float?) arg)).ToList();
			Func<KeyValuePair<float?, float?>, float?> map = null;
			try
			{
				ZEnumerable.Max(source, map);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			object[] sourceForNulls = { new Stack<int>() };
			var sourceOfNulls = sourceForNulls.Select(x => (float?) null).ToList();
			var max = ZEnumerable.Max(sourceOfNulls);
			Assert.AreEqual(default(float?), max);
        }
			
        [TestMethod]
        public void TestMaxfloatNullableNullableIList()
        {
            var source = Enumerable.Range(1, 100).Select(x => (float?)x).ToList();

			float? maxActual = ZEnumerable.Max(source);
            float? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxfloatNullableNullableIListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (float?)arg }).ToList();

			float? maxActual = ZEnumerable.Max(source, arg => arg.X);
            float? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }
	
		[TestMethod]
        public void TestMaxfloatNullableNullableIListNull()
        {		
			IList<float?> nullSource = null;

            try
			{
				ZEnumerable.Max(nullSource);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			IList<float?> sourceOfNulls = new float?[] {null}.ToList();
			var max = ZEnumerable.Max(sourceOfNulls);
			Assert.AreEqual(default(float?), max);
        }

		[TestMethod]
        public void TestMaxfloatNullableNullableIListMapNull()
        {
			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<float?,float?>((float?) arg, (float?) arg)).ToList();
			Func<KeyValuePair<float?, float?>, float?> map = null;
			try
			{
				ZEnumerable.Max(source, map);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			object[] sourceForNulls = { new Stack<int>() };
			var sourceOfNulls = sourceForNulls.Select(x => (float?) null).ToList();
			var max = ZEnumerable.Max(sourceOfNulls);
			Assert.AreEqual(default(float?), max);
        }
				
		#endregion
	
		#region double?	 		
			
        [TestMethod]
        public void TestMaxdoubleNullableNullableArray()
        {
            var source = Enumerable.Range(1, 100).Select(x => (double?)x).ToArray();

			double? maxActual = ZEnumerable.Max(source);
            double? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxdoubleNullableNullableArrayMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (double?)arg }).ToArray();

			double? maxActual = ZEnumerable.Max(source, arg => arg.X);
            double? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }
	
		[TestMethod]
        public void TestMaxdoubleNullableNullableArrayNull()
        {		
			double?[] nullSource = null;

            try
			{
				ZEnumerable.Max(nullSource);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			double?[] sourceOfNulls = new double?[] {null}.ToArray();
			var max = ZEnumerable.Max(sourceOfNulls);
			Assert.AreEqual(default(double?), max);
        }

		[TestMethod]
        public void TestMaxdoubleNullableNullableArrayMapNull()
        {
			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<double?,double?>((double?) arg, (double?) arg)).ToArray();
			Func<KeyValuePair<double?, double?>, double?> map = null;
			try
			{
				ZEnumerable.Max(source, map);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			object[] sourceForNulls = { new Stack<int>() };
			var sourceOfNulls = sourceForNulls.Select(x => (double?) null).ToArray();
			var max = ZEnumerable.Max(sourceOfNulls);
			Assert.AreEqual(default(double?), max);
        }
			
        [TestMethod]
        public void TestMaxdoubleNullableNullableList()
        {
            var source = Enumerable.Range(1, 100).Select(x => (double?)x).ToList();

			double? maxActual = ZEnumerable.Max(source);
            double? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxdoubleNullableNullableListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (double?)arg }).ToList();

			double? maxActual = ZEnumerable.Max(source, arg => arg.X);
            double? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }
	
		[TestMethod]
        public void TestMaxdoubleNullableNullableListNull()
        {		
			List<double?> nullSource = null;

            try
			{
				ZEnumerable.Max(nullSource);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			List<double?> sourceOfNulls = new double?[] {null}.ToList();
			var max = ZEnumerable.Max(sourceOfNulls);
			Assert.AreEqual(default(double?), max);
        }

		[TestMethod]
        public void TestMaxdoubleNullableNullableListMapNull()
        {
			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<double?,double?>((double?) arg, (double?) arg)).ToList();
			Func<KeyValuePair<double?, double?>, double?> map = null;
			try
			{
				ZEnumerable.Max(source, map);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			object[] sourceForNulls = { new Stack<int>() };
			var sourceOfNulls = sourceForNulls.Select(x => (double?) null).ToList();
			var max = ZEnumerable.Max(sourceOfNulls);
			Assert.AreEqual(default(double?), max);
        }
			
        [TestMethod]
        public void TestMaxdoubleNullableNullableIList()
        {
            var source = Enumerable.Range(1, 100).Select(x => (double?)x).ToList();

			double? maxActual = ZEnumerable.Max(source);
            double? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxdoubleNullableNullableIListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (double?)arg }).ToList();

			double? maxActual = ZEnumerable.Max(source, arg => arg.X);
            double? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }
	
		[TestMethod]
        public void TestMaxdoubleNullableNullableIListNull()
        {		
			IList<double?> nullSource = null;

            try
			{
				ZEnumerable.Max(nullSource);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			IList<double?> sourceOfNulls = new double?[] {null}.ToList();
			var max = ZEnumerable.Max(sourceOfNulls);
			Assert.AreEqual(default(double?), max);
        }

		[TestMethod]
        public void TestMaxdoubleNullableNullableIListMapNull()
        {
			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<double?,double?>((double?) arg, (double?) arg)).ToList();
			Func<KeyValuePair<double?, double?>, double?> map = null;
			try
			{
				ZEnumerable.Max(source, map);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			object[] sourceForNulls = { new Stack<int>() };
			var sourceOfNulls = sourceForNulls.Select(x => (double?) null).ToList();
			var max = ZEnumerable.Max(sourceOfNulls);
			Assert.AreEqual(default(double?), max);
        }
				
		#endregion
	
		#region decimal?	 		
			
        [TestMethod]
        public void TestMaxdecimalNullableNullableArray()
        {
            var source = Enumerable.Range(1, 100).Select(x => (decimal?)x).ToArray();

			decimal? maxActual = ZEnumerable.Max(source);
            decimal? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxdecimalNullableNullableArrayMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (decimal?)arg }).ToArray();

			decimal? maxActual = ZEnumerable.Max(source, arg => arg.X);
            decimal? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }
	
		[TestMethod]
        public void TestMaxdecimalNullableNullableArrayNull()
        {		
			decimal?[] nullSource = null;

            try
			{
				ZEnumerable.Max(nullSource);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			decimal?[] sourceOfNulls = new decimal?[] {null}.ToArray();
			var max = ZEnumerable.Max(sourceOfNulls);
			Assert.AreEqual(default(decimal?), max);
        }

		[TestMethod]
        public void TestMaxdecimalNullableNullableArrayMapNull()
        {
			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<decimal?,decimal?>((decimal?) arg, (decimal?) arg)).ToArray();
			Func<KeyValuePair<decimal?, decimal?>, decimal?> map = null;
			try
			{
				ZEnumerable.Max(source, map);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			object[] sourceForNulls = { new Stack<int>() };
			var sourceOfNulls = sourceForNulls.Select(x => (decimal?) null).ToArray();
			var max = ZEnumerable.Max(sourceOfNulls);
			Assert.AreEqual(default(decimal?), max);
        }
			
        [TestMethod]
        public void TestMaxdecimalNullableNullableList()
        {
            var source = Enumerable.Range(1, 100).Select(x => (decimal?)x).ToList();

			decimal? maxActual = ZEnumerable.Max(source);
            decimal? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxdecimalNullableNullableListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (decimal?)arg }).ToList();

			decimal? maxActual = ZEnumerable.Max(source, arg => arg.X);
            decimal? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }
	
		[TestMethod]
        public void TestMaxdecimalNullableNullableListNull()
        {		
			List<decimal?> nullSource = null;

            try
			{
				ZEnumerable.Max(nullSource);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			List<decimal?> sourceOfNulls = new decimal?[] {null}.ToList();
			var max = ZEnumerable.Max(sourceOfNulls);
			Assert.AreEqual(default(decimal?), max);
        }

		[TestMethod]
        public void TestMaxdecimalNullableNullableListMapNull()
        {
			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<decimal?,decimal?>((decimal?) arg, (decimal?) arg)).ToList();
			Func<KeyValuePair<decimal?, decimal?>, decimal?> map = null;
			try
			{
				ZEnumerable.Max(source, map);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			object[] sourceForNulls = { new Stack<int>() };
			var sourceOfNulls = sourceForNulls.Select(x => (decimal?) null).ToList();
			var max = ZEnumerable.Max(sourceOfNulls);
			Assert.AreEqual(default(decimal?), max);
        }
			
        [TestMethod]
        public void TestMaxdecimalNullableNullableIList()
        {
            var source = Enumerable.Range(1, 100).Select(x => (decimal?)x).ToList();

			decimal? maxActual = ZEnumerable.Max(source);
            decimal? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxdecimalNullableNullableIListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (decimal?)arg }).ToList();

			decimal? maxActual = ZEnumerable.Max(source, arg => arg.X);
            decimal? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }
	
		[TestMethod]
        public void TestMaxdecimalNullableNullableIListNull()
        {		
			IList<decimal?> nullSource = null;

            try
			{
				ZEnumerable.Max(nullSource);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			IList<decimal?> sourceOfNulls = new decimal?[] {null}.ToList();
			var max = ZEnumerable.Max(sourceOfNulls);
			Assert.AreEqual(default(decimal?), max);
        }

		[TestMethod]
        public void TestMaxdecimalNullableNullableIListMapNull()
        {
			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<decimal?,decimal?>((decimal?) arg, (decimal?) arg)).ToList();
			Func<KeyValuePair<decimal?, decimal?>, decimal?> map = null;
			try
			{
				ZEnumerable.Max(source, map);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			object[] sourceForNulls = { new Stack<int>() };
			var sourceOfNulls = sourceForNulls.Select(x => (decimal?) null).ToList();
			var max = ZEnumerable.Max(sourceOfNulls);
			Assert.AreEqual(default(decimal?), max);
        }
				
		#endregion
	
		#region ulong?	 		
			
        [TestMethod]
        public void TestMaxulongNullableNullableArray()
        {
            var source = Enumerable.Range(1, 100).Select(x => (ulong?)x).ToArray();

			ulong? maxActual = ZEnumerable.Max(source);
            ulong? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxulongNullableNullableArrayMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (ulong?)arg }).ToArray();

			ulong? maxActual = ZEnumerable.Max(source, arg => arg.X);
            ulong? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }
	
		[TestMethod]
        public void TestMaxulongNullableNullableArrayNull()
        {		
			ulong?[] nullSource = null;

            try
			{
				ZEnumerable.Max(nullSource);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			ulong?[] sourceOfNulls = new ulong?[] {null}.ToArray();
			var max = ZEnumerable.Max(sourceOfNulls);
			Assert.AreEqual(default(ulong?), max);
        }

		[TestMethod]
        public void TestMaxulongNullableNullableArrayMapNull()
        {
			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<ulong?,ulong?>((ulong?) arg, (ulong?) arg)).ToArray();
			Func<KeyValuePair<ulong?, ulong?>, ulong?> map = null;
			try
			{
				ZEnumerable.Max(source, map);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			object[] sourceForNulls = { new Stack<int>() };
			var sourceOfNulls = sourceForNulls.Select(x => (ulong?) null).ToArray();
			var max = ZEnumerable.Max(sourceOfNulls);
			Assert.AreEqual(default(ulong?), max);
        }
			
        [TestMethod]
        public void TestMaxulongNullableNullableList()
        {
            var source = Enumerable.Range(1, 100).Select(x => (ulong?)x).ToList();

			ulong? maxActual = ZEnumerable.Max(source);
            ulong? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxulongNullableNullableListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (ulong?)arg }).ToList();

			ulong? maxActual = ZEnumerable.Max(source, arg => arg.X);
            ulong? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }
	
		[TestMethod]
        public void TestMaxulongNullableNullableListNull()
        {		
			List<ulong?> nullSource = null;

            try
			{
				ZEnumerable.Max(nullSource);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			List<ulong?> sourceOfNulls = new ulong?[] {null}.ToList();
			var max = ZEnumerable.Max(sourceOfNulls);
			Assert.AreEqual(default(ulong?), max);
        }

		[TestMethod]
        public void TestMaxulongNullableNullableListMapNull()
        {
			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<ulong?,ulong?>((ulong?) arg, (ulong?) arg)).ToList();
			Func<KeyValuePair<ulong?, ulong?>, ulong?> map = null;
			try
			{
				ZEnumerable.Max(source, map);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			object[] sourceForNulls = { new Stack<int>() };
			var sourceOfNulls = sourceForNulls.Select(x => (ulong?) null).ToList();
			var max = ZEnumerable.Max(sourceOfNulls);
			Assert.AreEqual(default(ulong?), max);
        }
			
        [TestMethod]
        public void TestMaxulongNullableNullableIList()
        {
            var source = Enumerable.Range(1, 100).Select(x => (ulong?)x).ToList();

			ulong? maxActual = ZEnumerable.Max(source);
            ulong? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxulongNullableNullableIListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (ulong?)arg }).ToList();

			ulong? maxActual = ZEnumerable.Max(source, arg => arg.X);
            ulong? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }
	
		[TestMethod]
        public void TestMaxulongNullableNullableIListNull()
        {		
			IList<ulong?> nullSource = null;

            try
			{
				ZEnumerable.Max(nullSource);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			IList<ulong?> sourceOfNulls = new ulong?[] {null}.ToList();
			var max = ZEnumerable.Max(sourceOfNulls);
			Assert.AreEqual(default(ulong?), max);
        }

		[TestMethod]
        public void TestMaxulongNullableNullableIListMapNull()
        {
			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<ulong?,ulong?>((ulong?) arg, (ulong?) arg)).ToList();
			Func<KeyValuePair<ulong?, ulong?>, ulong?> map = null;
			try
			{
				ZEnumerable.Max(source, map);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			object[] sourceForNulls = { new Stack<int>() };
			var sourceOfNulls = sourceForNulls.Select(x => (ulong?) null).ToList();
			var max = ZEnumerable.Max(sourceOfNulls);
			Assert.AreEqual(default(ulong?), max);
        }
				
		#endregion
		

	#endregion
    }
}