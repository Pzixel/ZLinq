
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

			sbyte maxActual = source.Max();
            const sbyte maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxsbyteArrayMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (sbyte)arg }).ToArray();

			sbyte maxActual = source.Max(arg => arg.X);
            const sbyte maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxsbyteArrayNull()
        {		
			sbyte[] nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }

		[TestMethod]
        public void TestMaxsbyteArrayMapNull()
        {
			sbyte[] nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<sbyte,sbyte>((sbyte) arg, (sbyte) arg)).ToArray();
			try
			{
				source.Max<KeyValuePair<sbyte,sbyte>, sbyte>(null);				
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

			sbyte maxActual = source.Max();
            const sbyte maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxsbyteListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (sbyte)arg }).ToList();

			sbyte maxActual = source.Max(arg => arg.X);
            const sbyte maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxsbyteListNull()
        {		
			List<sbyte> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }

		[TestMethod]
        public void TestMaxsbyteListMapNull()
        {
			List<sbyte> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<sbyte,sbyte>((sbyte) arg, (sbyte) arg)).ToList();
			try
			{
				source.Max<KeyValuePair<sbyte,sbyte>, sbyte>(null);				
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

			sbyte maxActual = source.Max();
            const sbyte maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxsbyteIListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (sbyte)arg }).ToList();

			sbyte maxActual = source.Max(arg => arg.X);
            const sbyte maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxsbyteIListNull()
        {		
			IList<sbyte> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }

		[TestMethod]
        public void TestMaxsbyteIListMapNull()
        {
			IList<sbyte> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<sbyte,sbyte>((sbyte) arg, (sbyte) arg)).ToList();
			try
			{
				source.Max<KeyValuePair<sbyte,sbyte>, sbyte>(null);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }
					
        [TestMethod]
        public void TestMaxsbyteICollection()
        {
            var source = Enumerable.Range(1, 100).Select(x => (sbyte)x).ToList();

			sbyte maxActual = source.Max();
            const sbyte maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxsbyteICollectionMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (sbyte)arg }).ToList();

			sbyte maxActual = source.Max(arg => arg.X);
            const sbyte maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxsbyteICollectionNull()
        {		
			ICollection<sbyte> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }

		[TestMethod]
        public void TestMaxsbyteICollectionMapNull()
        {
			ICollection<sbyte> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<sbyte,sbyte>((sbyte) arg, (sbyte) arg)).ToList();
			try
			{
				source.Max<KeyValuePair<sbyte,sbyte>, sbyte>(null);				
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

			byte maxActual = source.Max();
            const byte maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxbyteArrayMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (byte)arg }).ToArray();

			byte maxActual = source.Max(arg => arg.X);
            const byte maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxbyteArrayNull()
        {		
			byte[] nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }

		[TestMethod]
        public void TestMaxbyteArrayMapNull()
        {
			byte[] nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<byte,byte>((byte) arg, (byte) arg)).ToArray();
			try
			{
				source.Max<KeyValuePair<byte,byte>, byte>(null);				
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

			byte maxActual = source.Max();
            const byte maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxbyteListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (byte)arg }).ToList();

			byte maxActual = source.Max(arg => arg.X);
            const byte maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxbyteListNull()
        {		
			List<byte> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }

		[TestMethod]
        public void TestMaxbyteListMapNull()
        {
			List<byte> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<byte,byte>((byte) arg, (byte) arg)).ToList();
			try
			{
				source.Max<KeyValuePair<byte,byte>, byte>(null);				
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

			byte maxActual = source.Max();
            const byte maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxbyteIListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (byte)arg }).ToList();

			byte maxActual = source.Max(arg => arg.X);
            const byte maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxbyteIListNull()
        {		
			IList<byte> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }

		[TestMethod]
        public void TestMaxbyteIListMapNull()
        {
			IList<byte> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<byte,byte>((byte) arg, (byte) arg)).ToList();
			try
			{
				source.Max<KeyValuePair<byte,byte>, byte>(null);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }
					
        [TestMethod]
        public void TestMaxbyteICollection()
        {
            var source = Enumerable.Range(1, 100).Select(x => (byte)x).ToList();

			byte maxActual = source.Max();
            const byte maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxbyteICollectionMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (byte)arg }).ToList();

			byte maxActual = source.Max(arg => arg.X);
            const byte maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxbyteICollectionNull()
        {		
			ICollection<byte> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }

		[TestMethod]
        public void TestMaxbyteICollectionMapNull()
        {
			ICollection<byte> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<byte,byte>((byte) arg, (byte) arg)).ToList();
			try
			{
				source.Max<KeyValuePair<byte,byte>, byte>(null);				
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

			short maxActual = source.Max();
            const short maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxshortArrayMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (short)arg }).ToArray();

			short maxActual = source.Max(arg => arg.X);
            const short maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxshortArrayNull()
        {		
			short[] nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }

		[TestMethod]
        public void TestMaxshortArrayMapNull()
        {
			short[] nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<short,short>((short) arg, (short) arg)).ToArray();
			try
			{
				source.Max<KeyValuePair<short,short>, short>(null);				
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

			short maxActual = source.Max();
            const short maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxshortListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (short)arg }).ToList();

			short maxActual = source.Max(arg => arg.X);
            const short maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxshortListNull()
        {		
			List<short> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }

		[TestMethod]
        public void TestMaxshortListMapNull()
        {
			List<short> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<short,short>((short) arg, (short) arg)).ToList();
			try
			{
				source.Max<KeyValuePair<short,short>, short>(null);				
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

			short maxActual = source.Max();
            const short maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxshortIListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (short)arg }).ToList();

			short maxActual = source.Max(arg => arg.X);
            const short maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxshortIListNull()
        {		
			IList<short> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }

		[TestMethod]
        public void TestMaxshortIListMapNull()
        {
			IList<short> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<short,short>((short) arg, (short) arg)).ToList();
			try
			{
				source.Max<KeyValuePair<short,short>, short>(null);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }
					
        [TestMethod]
        public void TestMaxshortICollection()
        {
            var source = Enumerable.Range(1, 100).Select(x => (short)x).ToList();

			short maxActual = source.Max();
            const short maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxshortICollectionMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (short)arg }).ToList();

			short maxActual = source.Max(arg => arg.X);
            const short maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxshortICollectionNull()
        {		
			ICollection<short> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }

		[TestMethod]
        public void TestMaxshortICollectionMapNull()
        {
			ICollection<short> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<short,short>((short) arg, (short) arg)).ToList();
			try
			{
				source.Max<KeyValuePair<short,short>, short>(null);				
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

			ushort maxActual = source.Max();
            const ushort maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxushortArrayMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (ushort)arg }).ToArray();

			ushort maxActual = source.Max(arg => arg.X);
            const ushort maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxushortArrayNull()
        {		
			ushort[] nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }

		[TestMethod]
        public void TestMaxushortArrayMapNull()
        {
			ushort[] nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<ushort,ushort>((ushort) arg, (ushort) arg)).ToArray();
			try
			{
				source.Max<KeyValuePair<ushort,ushort>, ushort>(null);				
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

			ushort maxActual = source.Max();
            const ushort maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxushortListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (ushort)arg }).ToList();

			ushort maxActual = source.Max(arg => arg.X);
            const ushort maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxushortListNull()
        {		
			List<ushort> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }

		[TestMethod]
        public void TestMaxushortListMapNull()
        {
			List<ushort> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<ushort,ushort>((ushort) arg, (ushort) arg)).ToList();
			try
			{
				source.Max<KeyValuePair<ushort,ushort>, ushort>(null);				
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

			ushort maxActual = source.Max();
            const ushort maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxushortIListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (ushort)arg }).ToList();

			ushort maxActual = source.Max(arg => arg.X);
            const ushort maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxushortIListNull()
        {		
			IList<ushort> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }

		[TestMethod]
        public void TestMaxushortIListMapNull()
        {
			IList<ushort> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<ushort,ushort>((ushort) arg, (ushort) arg)).ToList();
			try
			{
				source.Max<KeyValuePair<ushort,ushort>, ushort>(null);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }
					
        [TestMethod]
        public void TestMaxushortICollection()
        {
            var source = Enumerable.Range(1, 100).Select(x => (ushort)x).ToList();

			ushort maxActual = source.Max();
            const ushort maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxushortICollectionMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (ushort)arg }).ToList();

			ushort maxActual = source.Max(arg => arg.X);
            const ushort maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxushortICollectionNull()
        {		
			ICollection<ushort> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }

		[TestMethod]
        public void TestMaxushortICollectionMapNull()
        {
			ICollection<ushort> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<ushort,ushort>((ushort) arg, (ushort) arg)).ToList();
			try
			{
				source.Max<KeyValuePair<ushort,ushort>, ushort>(null);				
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

			int maxActual = source.Max();
            const int maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxintArrayMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (int)arg }).ToArray();

			int maxActual = source.Max(arg => arg.X);
            const int maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxintArrayNull()
        {		
			int[] nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }

		[TestMethod]
        public void TestMaxintArrayMapNull()
        {
			int[] nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<int,int>((int) arg, (int) arg)).ToArray();
			try
			{
				source.Max<KeyValuePair<int,int>, int>(null);				
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

			int maxActual = source.Max();
            const int maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxintListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (int)arg }).ToList();

			int maxActual = source.Max(arg => arg.X);
            const int maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxintListNull()
        {		
			List<int> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }

		[TestMethod]
        public void TestMaxintListMapNull()
        {
			List<int> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<int,int>((int) arg, (int) arg)).ToList();
			try
			{
				source.Max<KeyValuePair<int,int>, int>(null);				
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

			int maxActual = source.Max();
            const int maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxintIListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (int)arg }).ToList();

			int maxActual = source.Max(arg => arg.X);
            const int maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxintIListNull()
        {		
			IList<int> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }

		[TestMethod]
        public void TestMaxintIListMapNull()
        {
			IList<int> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<int,int>((int) arg, (int) arg)).ToList();
			try
			{
				source.Max<KeyValuePair<int,int>, int>(null);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }
					
        [TestMethod]
        public void TestMaxintICollection()
        {
            var source = Enumerable.Range(1, 100).Select(x => (int)x).ToList();

			int maxActual = source.Max();
            const int maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxintICollectionMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (int)arg }).ToList();

			int maxActual = source.Max(arg => arg.X);
            const int maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxintICollectionNull()
        {		
			ICollection<int> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }

		[TestMethod]
        public void TestMaxintICollectionMapNull()
        {
			ICollection<int> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<int,int>((int) arg, (int) arg)).ToList();
			try
			{
				source.Max<KeyValuePair<int,int>, int>(null);				
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

			uint maxActual = source.Max();
            const uint maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxuintArrayMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (uint)arg }).ToArray();

			uint maxActual = source.Max(arg => arg.X);
            const uint maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxuintArrayNull()
        {		
			uint[] nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }

		[TestMethod]
        public void TestMaxuintArrayMapNull()
        {
			uint[] nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<uint,uint>((uint) arg, (uint) arg)).ToArray();
			try
			{
				source.Max<KeyValuePair<uint,uint>, uint>(null);				
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

			uint maxActual = source.Max();
            const uint maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxuintListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (uint)arg }).ToList();

			uint maxActual = source.Max(arg => arg.X);
            const uint maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxuintListNull()
        {		
			List<uint> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }

		[TestMethod]
        public void TestMaxuintListMapNull()
        {
			List<uint> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<uint,uint>((uint) arg, (uint) arg)).ToList();
			try
			{
				source.Max<KeyValuePair<uint,uint>, uint>(null);				
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

			uint maxActual = source.Max();
            const uint maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxuintIListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (uint)arg }).ToList();

			uint maxActual = source.Max(arg => arg.X);
            const uint maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxuintIListNull()
        {		
			IList<uint> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }

		[TestMethod]
        public void TestMaxuintIListMapNull()
        {
			IList<uint> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<uint,uint>((uint) arg, (uint) arg)).ToList();
			try
			{
				source.Max<KeyValuePair<uint,uint>, uint>(null);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }
					
        [TestMethod]
        public void TestMaxuintICollection()
        {
            var source = Enumerable.Range(1, 100).Select(x => (uint)x).ToList();

			uint maxActual = source.Max();
            const uint maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxuintICollectionMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (uint)arg }).ToList();

			uint maxActual = source.Max(arg => arg.X);
            const uint maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxuintICollectionNull()
        {		
			ICollection<uint> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }

		[TestMethod]
        public void TestMaxuintICollectionMapNull()
        {
			ICollection<uint> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<uint,uint>((uint) arg, (uint) arg)).ToList();
			try
			{
				source.Max<KeyValuePair<uint,uint>, uint>(null);				
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

			long maxActual = source.Max();
            const long maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxlongArrayMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (long)arg }).ToArray();

			long maxActual = source.Max(arg => arg.X);
            const long maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxlongArrayNull()
        {		
			long[] nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }

		[TestMethod]
        public void TestMaxlongArrayMapNull()
        {
			long[] nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<long,long>((long) arg, (long) arg)).ToArray();
			try
			{
				source.Max<KeyValuePair<long,long>, long>(null);				
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

			long maxActual = source.Max();
            const long maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxlongListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (long)arg }).ToList();

			long maxActual = source.Max(arg => arg.X);
            const long maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxlongListNull()
        {		
			List<long> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }

		[TestMethod]
        public void TestMaxlongListMapNull()
        {
			List<long> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<long,long>((long) arg, (long) arg)).ToList();
			try
			{
				source.Max<KeyValuePair<long,long>, long>(null);				
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

			long maxActual = source.Max();
            const long maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxlongIListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (long)arg }).ToList();

			long maxActual = source.Max(arg => arg.X);
            const long maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxlongIListNull()
        {		
			IList<long> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }

		[TestMethod]
        public void TestMaxlongIListMapNull()
        {
			IList<long> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<long,long>((long) arg, (long) arg)).ToList();
			try
			{
				source.Max<KeyValuePair<long,long>, long>(null);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }
					
        [TestMethod]
        public void TestMaxlongICollection()
        {
            var source = Enumerable.Range(1, 100).Select(x => (long)x).ToList();

			long maxActual = source.Max();
            const long maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxlongICollectionMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (long)arg }).ToList();

			long maxActual = source.Max(arg => arg.X);
            const long maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxlongICollectionNull()
        {		
			ICollection<long> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }

		[TestMethod]
        public void TestMaxlongICollectionMapNull()
        {
			ICollection<long> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<long,long>((long) arg, (long) arg)).ToList();
			try
			{
				source.Max<KeyValuePair<long,long>, long>(null);				
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

			float maxActual = source.Max();
            const float maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxfloatArrayMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (float)arg }).ToArray();

			float maxActual = source.Max(arg => arg.X);
            const float maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

							
        [TestMethod]
        public void TestMaxfloatList()
        {
            var source = Enumerable.Range(1, 100).Select(x => (float)x).ToList();

			float maxActual = source.Max();
            const float maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxfloatListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (float)arg }).ToList();

			float maxActual = source.Max(arg => arg.X);
            const float maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

							
        [TestMethod]
        public void TestMaxfloatIList()
        {
            var source = Enumerable.Range(1, 100).Select(x => (float)x).ToList();

			float maxActual = source.Max();
            const float maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxfloatIListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (float)arg }).ToList();

			float maxActual = source.Max(arg => arg.X);
            const float maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

							
        [TestMethod]
        public void TestMaxfloatICollection()
        {
            var source = Enumerable.Range(1, 100).Select(x => (float)x).ToList();

			float maxActual = source.Max();
            const float maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxfloatICollectionMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (float)arg }).ToList();

			float maxActual = source.Max(arg => arg.X);
            const float maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

								
		#endregion
	
		#region double	 		
			
        [TestMethod]
        public void TestMaxdoubleArray()
        {
            var source = Enumerable.Range(1, 100).Select(x => (double)x).ToArray();

			double maxActual = source.Max();
            const double maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxdoubleArrayMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (double)arg }).ToArray();

			double maxActual = source.Max(arg => arg.X);
            const double maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

							
        [TestMethod]
        public void TestMaxdoubleList()
        {
            var source = Enumerable.Range(1, 100).Select(x => (double)x).ToList();

			double maxActual = source.Max();
            const double maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxdoubleListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (double)arg }).ToList();

			double maxActual = source.Max(arg => arg.X);
            const double maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

							
        [TestMethod]
        public void TestMaxdoubleIList()
        {
            var source = Enumerable.Range(1, 100).Select(x => (double)x).ToList();

			double maxActual = source.Max();
            const double maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxdoubleIListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (double)arg }).ToList();

			double maxActual = source.Max(arg => arg.X);
            const double maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

							
        [TestMethod]
        public void TestMaxdoubleICollection()
        {
            var source = Enumerable.Range(1, 100).Select(x => (double)x).ToList();

			double maxActual = source.Max();
            const double maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxdoubleICollectionMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (double)arg }).ToList();

			double maxActual = source.Max(arg => arg.X);
            const double maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

								
		#endregion
	
		#region decimal	 		
			
        [TestMethod]
        public void TestMaxdecimalArray()
        {
            var source = Enumerable.Range(1, 100).Select(x => (decimal)x).ToArray();

			decimal maxActual = source.Max();
            const decimal maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxdecimalArrayMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (decimal)arg }).ToArray();

			decimal maxActual = source.Max(arg => arg.X);
            const decimal maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

							
        [TestMethod]
        public void TestMaxdecimalList()
        {
            var source = Enumerable.Range(1, 100).Select(x => (decimal)x).ToList();

			decimal maxActual = source.Max();
            const decimal maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxdecimalListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (decimal)arg }).ToList();

			decimal maxActual = source.Max(arg => arg.X);
            const decimal maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

							
        [TestMethod]
        public void TestMaxdecimalIList()
        {
            var source = Enumerable.Range(1, 100).Select(x => (decimal)x).ToList();

			decimal maxActual = source.Max();
            const decimal maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxdecimalIListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (decimal)arg }).ToList();

			decimal maxActual = source.Max(arg => arg.X);
            const decimal maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

							
        [TestMethod]
        public void TestMaxdecimalICollection()
        {
            var source = Enumerable.Range(1, 100).Select(x => (decimal)x).ToList();

			decimal maxActual = source.Max();
            const decimal maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxdecimalICollectionMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (decimal)arg }).ToList();

			decimal maxActual = source.Max(arg => arg.X);
            const decimal maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

								
		#endregion
	
		#region ulong	 		
			
        [TestMethod]
        public void TestMaxulongArray()
        {
            var source = Enumerable.Range(1, 100).Select(x => (ulong)x).ToArray();

			ulong maxActual = source.Max();
            const ulong maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxulongArrayMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (ulong)arg }).ToArray();

			ulong maxActual = source.Max(arg => arg.X);
            const ulong maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxulongArrayNull()
        {		
			ulong[] nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }

		[TestMethod]
        public void TestMaxulongArrayMapNull()
        {
			ulong[] nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<ulong,ulong>((ulong) arg, (ulong) arg)).ToArray();
			try
			{
				source.Max<KeyValuePair<ulong,ulong>, ulong>(null);				
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

			ulong maxActual = source.Max();
            const ulong maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxulongListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (ulong)arg }).ToList();

			ulong maxActual = source.Max(arg => arg.X);
            const ulong maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxulongListNull()
        {		
			List<ulong> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }

		[TestMethod]
        public void TestMaxulongListMapNull()
        {
			List<ulong> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<ulong,ulong>((ulong) arg, (ulong) arg)).ToList();
			try
			{
				source.Max<KeyValuePair<ulong,ulong>, ulong>(null);				
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

			ulong maxActual = source.Max();
            const ulong maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxulongIListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (ulong)arg }).ToList();

			ulong maxActual = source.Max(arg => arg.X);
            const ulong maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxulongIListNull()
        {		
			IList<ulong> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }

		[TestMethod]
        public void TestMaxulongIListMapNull()
        {
			IList<ulong> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<ulong,ulong>((ulong) arg, (ulong) arg)).ToList();
			try
			{
				source.Max<KeyValuePair<ulong,ulong>, ulong>(null);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }
					
        [TestMethod]
        public void TestMaxulongICollection()
        {
            var source = Enumerable.Range(1, 100).Select(x => (ulong)x).ToList();

			ulong maxActual = source.Max();
            const ulong maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxulongICollectionMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (ulong)arg }).ToList();

			ulong maxActual = source.Max(arg => arg.X);
            const ulong maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxulongICollectionNull()
        {		
			ICollection<ulong> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}
        }

		[TestMethod]
        public void TestMaxulongICollectionMapNull()
        {
			ICollection<ulong> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<ulong,ulong>((ulong) arg, (ulong) arg)).ToList();
			try
			{
				source.Max<KeyValuePair<ulong,ulong>, ulong>(null);				
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

			sbyte? maxActual = source.Max();
            sbyte? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxsbyteNullableNullableArrayMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (sbyte?)arg }).ToArray();

			sbyte? maxActual = source.Max(arg => arg.X);
            sbyte? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxsbyteNullableNullableArrayNull()
        {		
			sbyte?[] nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			sbyte?[] sourceOfNulls = new sbyte?[] {null}.ToArray();
			var max = sourceOfNulls.Max();
			Assert.AreEqual(default(sbyte?), max);
        }

		[TestMethod]
        public void TestMaxsbyteNullableNullableArrayMapNull()
        {
			sbyte?[] nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<sbyte?,sbyte?>((sbyte?) arg, (sbyte?) arg)).ToArray();
			try
			{
				source.Max<KeyValuePair<sbyte?,sbyte?>, sbyte?>(null);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			object[] sourceForNulls = { new Stack<int>() };
			var sourceOfNulls = sourceForNulls.Select(x => (sbyte?) null).ToArray();
			var max = sourceOfNulls.Max();
			Assert.AreEqual(default(sbyte?), max);
        }
					
        [TestMethod]
        public void TestMaxsbyteNullableNullableList()
        {
            var source = Enumerable.Range(1, 100).Select(x => (sbyte?)x).ToList();

			sbyte? maxActual = source.Max();
            sbyte? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxsbyteNullableNullableListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (sbyte?)arg }).ToList();

			sbyte? maxActual = source.Max(arg => arg.X);
            sbyte? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxsbyteNullableNullableListNull()
        {		
			List<sbyte?> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			List<sbyte?> sourceOfNulls = new sbyte?[] {null}.ToList();
			var max = sourceOfNulls.Max();
			Assert.AreEqual(default(sbyte?), max);
        }

		[TestMethod]
        public void TestMaxsbyteNullableNullableListMapNull()
        {
			List<sbyte?> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<sbyte?,sbyte?>((sbyte?) arg, (sbyte?) arg)).ToList();
			try
			{
				source.Max<KeyValuePair<sbyte?,sbyte?>, sbyte?>(null);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			object[] sourceForNulls = { new Stack<int>() };
			var sourceOfNulls = sourceForNulls.Select(x => (sbyte?) null).ToList();
			var max = sourceOfNulls.Max();
			Assert.AreEqual(default(sbyte?), max);
        }
					
        [TestMethod]
        public void TestMaxsbyteNullableNullableIList()
        {
            var source = Enumerable.Range(1, 100).Select(x => (sbyte?)x).ToList();

			sbyte? maxActual = source.Max();
            sbyte? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxsbyteNullableNullableIListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (sbyte?)arg }).ToList();

			sbyte? maxActual = source.Max(arg => arg.X);
            sbyte? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxsbyteNullableNullableIListNull()
        {		
			IList<sbyte?> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			IList<sbyte?> sourceOfNulls = new sbyte?[] {null}.ToList();
			var max = sourceOfNulls.Max();
			Assert.AreEqual(default(sbyte?), max);
        }

		[TestMethod]
        public void TestMaxsbyteNullableNullableIListMapNull()
        {
			IList<sbyte?> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<sbyte?,sbyte?>((sbyte?) arg, (sbyte?) arg)).ToList();
			try
			{
				source.Max<KeyValuePair<sbyte?,sbyte?>, sbyte?>(null);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			object[] sourceForNulls = { new Stack<int>() };
			var sourceOfNulls = sourceForNulls.Select(x => (sbyte?) null).ToList();
			var max = sourceOfNulls.Max();
			Assert.AreEqual(default(sbyte?), max);
        }
					
        [TestMethod]
        public void TestMaxsbyteNullableNullableICollection()
        {
            var source = Enumerable.Range(1, 100).Select(x => (sbyte?)x).ToList();

			sbyte? maxActual = source.Max();
            sbyte? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxsbyteNullableNullableICollectionMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (sbyte?)arg }).ToList();

			sbyte? maxActual = source.Max(arg => arg.X);
            sbyte? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxsbyteNullableNullableICollectionNull()
        {		
			ICollection<sbyte?> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			ICollection<sbyte?> sourceOfNulls = new sbyte?[] {null}.ToList();
			var max = sourceOfNulls.Max();
			Assert.AreEqual(default(sbyte?), max);
        }

		[TestMethod]
        public void TestMaxsbyteNullableNullableICollectionMapNull()
        {
			ICollection<sbyte?> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<sbyte?,sbyte?>((sbyte?) arg, (sbyte?) arg)).ToList();
			try
			{
				source.Max<KeyValuePair<sbyte?,sbyte?>, sbyte?>(null);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			object[] sourceForNulls = { new Stack<int>() };
			var sourceOfNulls = sourceForNulls.Select(x => (sbyte?) null).ToList();
			var max = sourceOfNulls.Max();
			Assert.AreEqual(default(sbyte?), max);
        }
						
		#endregion
	
		#region byte?	 		
			
        [TestMethod]
        public void TestMaxbyteNullableNullableArray()
        {
            var source = Enumerable.Range(1, 100).Select(x => (byte?)x).ToArray();

			byte? maxActual = source.Max();
            byte? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxbyteNullableNullableArrayMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (byte?)arg }).ToArray();

			byte? maxActual = source.Max(arg => arg.X);
            byte? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxbyteNullableNullableArrayNull()
        {		
			byte?[] nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			byte?[] sourceOfNulls = new byte?[] {null}.ToArray();
			var max = sourceOfNulls.Max();
			Assert.AreEqual(default(byte?), max);
        }

		[TestMethod]
        public void TestMaxbyteNullableNullableArrayMapNull()
        {
			byte?[] nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<byte?,byte?>((byte?) arg, (byte?) arg)).ToArray();
			try
			{
				source.Max<KeyValuePair<byte?,byte?>, byte?>(null);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			object[] sourceForNulls = { new Stack<int>() };
			var sourceOfNulls = sourceForNulls.Select(x => (byte?) null).ToArray();
			var max = sourceOfNulls.Max();
			Assert.AreEqual(default(byte?), max);
        }
					
        [TestMethod]
        public void TestMaxbyteNullableNullableList()
        {
            var source = Enumerable.Range(1, 100).Select(x => (byte?)x).ToList();

			byte? maxActual = source.Max();
            byte? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxbyteNullableNullableListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (byte?)arg }).ToList();

			byte? maxActual = source.Max(arg => arg.X);
            byte? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxbyteNullableNullableListNull()
        {		
			List<byte?> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			List<byte?> sourceOfNulls = new byte?[] {null}.ToList();
			var max = sourceOfNulls.Max();
			Assert.AreEqual(default(byte?), max);
        }

		[TestMethod]
        public void TestMaxbyteNullableNullableListMapNull()
        {
			List<byte?> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<byte?,byte?>((byte?) arg, (byte?) arg)).ToList();
			try
			{
				source.Max<KeyValuePair<byte?,byte?>, byte?>(null);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			object[] sourceForNulls = { new Stack<int>() };
			var sourceOfNulls = sourceForNulls.Select(x => (byte?) null).ToList();
			var max = sourceOfNulls.Max();
			Assert.AreEqual(default(byte?), max);
        }
					
        [TestMethod]
        public void TestMaxbyteNullableNullableIList()
        {
            var source = Enumerable.Range(1, 100).Select(x => (byte?)x).ToList();

			byte? maxActual = source.Max();
            byte? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxbyteNullableNullableIListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (byte?)arg }).ToList();

			byte? maxActual = source.Max(arg => arg.X);
            byte? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxbyteNullableNullableIListNull()
        {		
			IList<byte?> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			IList<byte?> sourceOfNulls = new byte?[] {null}.ToList();
			var max = sourceOfNulls.Max();
			Assert.AreEqual(default(byte?), max);
        }

		[TestMethod]
        public void TestMaxbyteNullableNullableIListMapNull()
        {
			IList<byte?> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<byte?,byte?>((byte?) arg, (byte?) arg)).ToList();
			try
			{
				source.Max<KeyValuePair<byte?,byte?>, byte?>(null);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			object[] sourceForNulls = { new Stack<int>() };
			var sourceOfNulls = sourceForNulls.Select(x => (byte?) null).ToList();
			var max = sourceOfNulls.Max();
			Assert.AreEqual(default(byte?), max);
        }
					
        [TestMethod]
        public void TestMaxbyteNullableNullableICollection()
        {
            var source = Enumerable.Range(1, 100).Select(x => (byte?)x).ToList();

			byte? maxActual = source.Max();
            byte? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxbyteNullableNullableICollectionMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (byte?)arg }).ToList();

			byte? maxActual = source.Max(arg => arg.X);
            byte? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxbyteNullableNullableICollectionNull()
        {		
			ICollection<byte?> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			ICollection<byte?> sourceOfNulls = new byte?[] {null}.ToList();
			var max = sourceOfNulls.Max();
			Assert.AreEqual(default(byte?), max);
        }

		[TestMethod]
        public void TestMaxbyteNullableNullableICollectionMapNull()
        {
			ICollection<byte?> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<byte?,byte?>((byte?) arg, (byte?) arg)).ToList();
			try
			{
				source.Max<KeyValuePair<byte?,byte?>, byte?>(null);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			object[] sourceForNulls = { new Stack<int>() };
			var sourceOfNulls = sourceForNulls.Select(x => (byte?) null).ToList();
			var max = sourceOfNulls.Max();
			Assert.AreEqual(default(byte?), max);
        }
						
		#endregion
	
		#region short?	 		
			
        [TestMethod]
        public void TestMaxshortNullableNullableArray()
        {
            var source = Enumerable.Range(1, 100).Select(x => (short?)x).ToArray();

			short? maxActual = source.Max();
            short? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxshortNullableNullableArrayMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (short?)arg }).ToArray();

			short? maxActual = source.Max(arg => arg.X);
            short? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxshortNullableNullableArrayNull()
        {		
			short?[] nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			short?[] sourceOfNulls = new short?[] {null}.ToArray();
			var max = sourceOfNulls.Max();
			Assert.AreEqual(default(short?), max);
        }

		[TestMethod]
        public void TestMaxshortNullableNullableArrayMapNull()
        {
			short?[] nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<short?,short?>((short?) arg, (short?) arg)).ToArray();
			try
			{
				source.Max<KeyValuePair<short?,short?>, short?>(null);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			object[] sourceForNulls = { new Stack<int>() };
			var sourceOfNulls = sourceForNulls.Select(x => (short?) null).ToArray();
			var max = sourceOfNulls.Max();
			Assert.AreEqual(default(short?), max);
        }
					
        [TestMethod]
        public void TestMaxshortNullableNullableList()
        {
            var source = Enumerable.Range(1, 100).Select(x => (short?)x).ToList();

			short? maxActual = source.Max();
            short? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxshortNullableNullableListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (short?)arg }).ToList();

			short? maxActual = source.Max(arg => arg.X);
            short? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxshortNullableNullableListNull()
        {		
			List<short?> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			List<short?> sourceOfNulls = new short?[] {null}.ToList();
			var max = sourceOfNulls.Max();
			Assert.AreEqual(default(short?), max);
        }

		[TestMethod]
        public void TestMaxshortNullableNullableListMapNull()
        {
			List<short?> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<short?,short?>((short?) arg, (short?) arg)).ToList();
			try
			{
				source.Max<KeyValuePair<short?,short?>, short?>(null);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			object[] sourceForNulls = { new Stack<int>() };
			var sourceOfNulls = sourceForNulls.Select(x => (short?) null).ToList();
			var max = sourceOfNulls.Max();
			Assert.AreEqual(default(short?), max);
        }
					
        [TestMethod]
        public void TestMaxshortNullableNullableIList()
        {
            var source = Enumerable.Range(1, 100).Select(x => (short?)x).ToList();

			short? maxActual = source.Max();
            short? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxshortNullableNullableIListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (short?)arg }).ToList();

			short? maxActual = source.Max(arg => arg.X);
            short? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxshortNullableNullableIListNull()
        {		
			IList<short?> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			IList<short?> sourceOfNulls = new short?[] {null}.ToList();
			var max = sourceOfNulls.Max();
			Assert.AreEqual(default(short?), max);
        }

		[TestMethod]
        public void TestMaxshortNullableNullableIListMapNull()
        {
			IList<short?> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<short?,short?>((short?) arg, (short?) arg)).ToList();
			try
			{
				source.Max<KeyValuePair<short?,short?>, short?>(null);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			object[] sourceForNulls = { new Stack<int>() };
			var sourceOfNulls = sourceForNulls.Select(x => (short?) null).ToList();
			var max = sourceOfNulls.Max();
			Assert.AreEqual(default(short?), max);
        }
					
        [TestMethod]
        public void TestMaxshortNullableNullableICollection()
        {
            var source = Enumerable.Range(1, 100).Select(x => (short?)x).ToList();

			short? maxActual = source.Max();
            short? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxshortNullableNullableICollectionMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (short?)arg }).ToList();

			short? maxActual = source.Max(arg => arg.X);
            short? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxshortNullableNullableICollectionNull()
        {		
			ICollection<short?> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			ICollection<short?> sourceOfNulls = new short?[] {null}.ToList();
			var max = sourceOfNulls.Max();
			Assert.AreEqual(default(short?), max);
        }

		[TestMethod]
        public void TestMaxshortNullableNullableICollectionMapNull()
        {
			ICollection<short?> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<short?,short?>((short?) arg, (short?) arg)).ToList();
			try
			{
				source.Max<KeyValuePair<short?,short?>, short?>(null);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			object[] sourceForNulls = { new Stack<int>() };
			var sourceOfNulls = sourceForNulls.Select(x => (short?) null).ToList();
			var max = sourceOfNulls.Max();
			Assert.AreEqual(default(short?), max);
        }
						
		#endregion
	
		#region ushort?	 		
			
        [TestMethod]
        public void TestMaxushortNullableNullableArray()
        {
            var source = Enumerable.Range(1, 100).Select(x => (ushort?)x).ToArray();

			ushort? maxActual = source.Max();
            ushort? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxushortNullableNullableArrayMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (ushort?)arg }).ToArray();

			ushort? maxActual = source.Max(arg => arg.X);
            ushort? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxushortNullableNullableArrayNull()
        {		
			ushort?[] nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			ushort?[] sourceOfNulls = new ushort?[] {null}.ToArray();
			var max = sourceOfNulls.Max();
			Assert.AreEqual(default(ushort?), max);
        }

		[TestMethod]
        public void TestMaxushortNullableNullableArrayMapNull()
        {
			ushort?[] nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<ushort?,ushort?>((ushort?) arg, (ushort?) arg)).ToArray();
			try
			{
				source.Max<KeyValuePair<ushort?,ushort?>, ushort?>(null);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			object[] sourceForNulls = { new Stack<int>() };
			var sourceOfNulls = sourceForNulls.Select(x => (ushort?) null).ToArray();
			var max = sourceOfNulls.Max();
			Assert.AreEqual(default(ushort?), max);
        }
					
        [TestMethod]
        public void TestMaxushortNullableNullableList()
        {
            var source = Enumerable.Range(1, 100).Select(x => (ushort?)x).ToList();

			ushort? maxActual = source.Max();
            ushort? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxushortNullableNullableListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (ushort?)arg }).ToList();

			ushort? maxActual = source.Max(arg => arg.X);
            ushort? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxushortNullableNullableListNull()
        {		
			List<ushort?> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			List<ushort?> sourceOfNulls = new ushort?[] {null}.ToList();
			var max = sourceOfNulls.Max();
			Assert.AreEqual(default(ushort?), max);
        }

		[TestMethod]
        public void TestMaxushortNullableNullableListMapNull()
        {
			List<ushort?> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<ushort?,ushort?>((ushort?) arg, (ushort?) arg)).ToList();
			try
			{
				source.Max<KeyValuePair<ushort?,ushort?>, ushort?>(null);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			object[] sourceForNulls = { new Stack<int>() };
			var sourceOfNulls = sourceForNulls.Select(x => (ushort?) null).ToList();
			var max = sourceOfNulls.Max();
			Assert.AreEqual(default(ushort?), max);
        }
					
        [TestMethod]
        public void TestMaxushortNullableNullableIList()
        {
            var source = Enumerable.Range(1, 100).Select(x => (ushort?)x).ToList();

			ushort? maxActual = source.Max();
            ushort? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxushortNullableNullableIListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (ushort?)arg }).ToList();

			ushort? maxActual = source.Max(arg => arg.X);
            ushort? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxushortNullableNullableIListNull()
        {		
			IList<ushort?> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			IList<ushort?> sourceOfNulls = new ushort?[] {null}.ToList();
			var max = sourceOfNulls.Max();
			Assert.AreEqual(default(ushort?), max);
        }

		[TestMethod]
        public void TestMaxushortNullableNullableIListMapNull()
        {
			IList<ushort?> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<ushort?,ushort?>((ushort?) arg, (ushort?) arg)).ToList();
			try
			{
				source.Max<KeyValuePair<ushort?,ushort?>, ushort?>(null);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			object[] sourceForNulls = { new Stack<int>() };
			var sourceOfNulls = sourceForNulls.Select(x => (ushort?) null).ToList();
			var max = sourceOfNulls.Max();
			Assert.AreEqual(default(ushort?), max);
        }
					
        [TestMethod]
        public void TestMaxushortNullableNullableICollection()
        {
            var source = Enumerable.Range(1, 100).Select(x => (ushort?)x).ToList();

			ushort? maxActual = source.Max();
            ushort? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxushortNullableNullableICollectionMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (ushort?)arg }).ToList();

			ushort? maxActual = source.Max(arg => arg.X);
            ushort? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxushortNullableNullableICollectionNull()
        {		
			ICollection<ushort?> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			ICollection<ushort?> sourceOfNulls = new ushort?[] {null}.ToList();
			var max = sourceOfNulls.Max();
			Assert.AreEqual(default(ushort?), max);
        }

		[TestMethod]
        public void TestMaxushortNullableNullableICollectionMapNull()
        {
			ICollection<ushort?> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<ushort?,ushort?>((ushort?) arg, (ushort?) arg)).ToList();
			try
			{
				source.Max<KeyValuePair<ushort?,ushort?>, ushort?>(null);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			object[] sourceForNulls = { new Stack<int>() };
			var sourceOfNulls = sourceForNulls.Select(x => (ushort?) null).ToList();
			var max = sourceOfNulls.Max();
			Assert.AreEqual(default(ushort?), max);
        }
						
		#endregion
	
		#region int?	 		
			
        [TestMethod]
        public void TestMaxintNullableNullableArray()
        {
            var source = Enumerable.Range(1, 100).Select(x => (int?)x).ToArray();

			int? maxActual = source.Max();
            int? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxintNullableNullableArrayMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (int?)arg }).ToArray();

			int? maxActual = source.Max(arg => arg.X);
            int? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxintNullableNullableArrayNull()
        {		
			int?[] nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			int?[] sourceOfNulls = new int?[] {null}.ToArray();
			var max = sourceOfNulls.Max();
			Assert.AreEqual(default(int?), max);
        }

		[TestMethod]
        public void TestMaxintNullableNullableArrayMapNull()
        {
			int?[] nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<int?,int?>((int?) arg, (int?) arg)).ToArray();
			try
			{
				source.Max<KeyValuePair<int?,int?>, int?>(null);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			object[] sourceForNulls = { new Stack<int>() };
			var sourceOfNulls = sourceForNulls.Select(x => (int?) null).ToArray();
			var max = sourceOfNulls.Max();
			Assert.AreEqual(default(int?), max);
        }
					
        [TestMethod]
        public void TestMaxintNullableNullableList()
        {
            var source = Enumerable.Range(1, 100).Select(x => (int?)x).ToList();

			int? maxActual = source.Max();
            int? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxintNullableNullableListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (int?)arg }).ToList();

			int? maxActual = source.Max(arg => arg.X);
            int? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxintNullableNullableListNull()
        {		
			List<int?> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			List<int?> sourceOfNulls = new int?[] {null}.ToList();
			var max = sourceOfNulls.Max();
			Assert.AreEqual(default(int?), max);
        }

		[TestMethod]
        public void TestMaxintNullableNullableListMapNull()
        {
			List<int?> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<int?,int?>((int?) arg, (int?) arg)).ToList();
			try
			{
				source.Max<KeyValuePair<int?,int?>, int?>(null);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			object[] sourceForNulls = { new Stack<int>() };
			var sourceOfNulls = sourceForNulls.Select(x => (int?) null).ToList();
			var max = sourceOfNulls.Max();
			Assert.AreEqual(default(int?), max);
        }
					
        [TestMethod]
        public void TestMaxintNullableNullableIList()
        {
            var source = Enumerable.Range(1, 100).Select(x => (int?)x).ToList();

			int? maxActual = source.Max();
            int? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxintNullableNullableIListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (int?)arg }).ToList();

			int? maxActual = source.Max(arg => arg.X);
            int? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxintNullableNullableIListNull()
        {		
			IList<int?> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			IList<int?> sourceOfNulls = new int?[] {null}.ToList();
			var max = sourceOfNulls.Max();
			Assert.AreEqual(default(int?), max);
        }

		[TestMethod]
        public void TestMaxintNullableNullableIListMapNull()
        {
			IList<int?> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<int?,int?>((int?) arg, (int?) arg)).ToList();
			try
			{
				source.Max<KeyValuePair<int?,int?>, int?>(null);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			object[] sourceForNulls = { new Stack<int>() };
			var sourceOfNulls = sourceForNulls.Select(x => (int?) null).ToList();
			var max = sourceOfNulls.Max();
			Assert.AreEqual(default(int?), max);
        }
					
        [TestMethod]
        public void TestMaxintNullableNullableICollection()
        {
            var source = Enumerable.Range(1, 100).Select(x => (int?)x).ToList();

			int? maxActual = source.Max();
            int? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxintNullableNullableICollectionMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (int?)arg }).ToList();

			int? maxActual = source.Max(arg => arg.X);
            int? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxintNullableNullableICollectionNull()
        {		
			ICollection<int?> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			ICollection<int?> sourceOfNulls = new int?[] {null}.ToList();
			var max = sourceOfNulls.Max();
			Assert.AreEqual(default(int?), max);
        }

		[TestMethod]
        public void TestMaxintNullableNullableICollectionMapNull()
        {
			ICollection<int?> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<int?,int?>((int?) arg, (int?) arg)).ToList();
			try
			{
				source.Max<KeyValuePair<int?,int?>, int?>(null);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			object[] sourceForNulls = { new Stack<int>() };
			var sourceOfNulls = sourceForNulls.Select(x => (int?) null).ToList();
			var max = sourceOfNulls.Max();
			Assert.AreEqual(default(int?), max);
        }
						
		#endregion
	
		#region uint?	 		
			
        [TestMethod]
        public void TestMaxuintNullableNullableArray()
        {
            var source = Enumerable.Range(1, 100).Select(x => (uint?)x).ToArray();

			uint? maxActual = source.Max();
            uint? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxuintNullableNullableArrayMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (uint?)arg }).ToArray();

			uint? maxActual = source.Max(arg => arg.X);
            uint? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxuintNullableNullableArrayNull()
        {		
			uint?[] nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			uint?[] sourceOfNulls = new uint?[] {null}.ToArray();
			var max = sourceOfNulls.Max();
			Assert.AreEqual(default(uint?), max);
        }

		[TestMethod]
        public void TestMaxuintNullableNullableArrayMapNull()
        {
			uint?[] nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<uint?,uint?>((uint?) arg, (uint?) arg)).ToArray();
			try
			{
				source.Max<KeyValuePair<uint?,uint?>, uint?>(null);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			object[] sourceForNulls = { new Stack<int>() };
			var sourceOfNulls = sourceForNulls.Select(x => (uint?) null).ToArray();
			var max = sourceOfNulls.Max();
			Assert.AreEqual(default(uint?), max);
        }
					
        [TestMethod]
        public void TestMaxuintNullableNullableList()
        {
            var source = Enumerable.Range(1, 100).Select(x => (uint?)x).ToList();

			uint? maxActual = source.Max();
            uint? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxuintNullableNullableListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (uint?)arg }).ToList();

			uint? maxActual = source.Max(arg => arg.X);
            uint? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxuintNullableNullableListNull()
        {		
			List<uint?> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			List<uint?> sourceOfNulls = new uint?[] {null}.ToList();
			var max = sourceOfNulls.Max();
			Assert.AreEqual(default(uint?), max);
        }

		[TestMethod]
        public void TestMaxuintNullableNullableListMapNull()
        {
			List<uint?> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<uint?,uint?>((uint?) arg, (uint?) arg)).ToList();
			try
			{
				source.Max<KeyValuePair<uint?,uint?>, uint?>(null);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			object[] sourceForNulls = { new Stack<int>() };
			var sourceOfNulls = sourceForNulls.Select(x => (uint?) null).ToList();
			var max = sourceOfNulls.Max();
			Assert.AreEqual(default(uint?), max);
        }
					
        [TestMethod]
        public void TestMaxuintNullableNullableIList()
        {
            var source = Enumerable.Range(1, 100).Select(x => (uint?)x).ToList();

			uint? maxActual = source.Max();
            uint? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxuintNullableNullableIListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (uint?)arg }).ToList();

			uint? maxActual = source.Max(arg => arg.X);
            uint? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxuintNullableNullableIListNull()
        {		
			IList<uint?> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			IList<uint?> sourceOfNulls = new uint?[] {null}.ToList();
			var max = sourceOfNulls.Max();
			Assert.AreEqual(default(uint?), max);
        }

		[TestMethod]
        public void TestMaxuintNullableNullableIListMapNull()
        {
			IList<uint?> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<uint?,uint?>((uint?) arg, (uint?) arg)).ToList();
			try
			{
				source.Max<KeyValuePair<uint?,uint?>, uint?>(null);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			object[] sourceForNulls = { new Stack<int>() };
			var sourceOfNulls = sourceForNulls.Select(x => (uint?) null).ToList();
			var max = sourceOfNulls.Max();
			Assert.AreEqual(default(uint?), max);
        }
					
        [TestMethod]
        public void TestMaxuintNullableNullableICollection()
        {
            var source = Enumerable.Range(1, 100).Select(x => (uint?)x).ToList();

			uint? maxActual = source.Max();
            uint? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxuintNullableNullableICollectionMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (uint?)arg }).ToList();

			uint? maxActual = source.Max(arg => arg.X);
            uint? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxuintNullableNullableICollectionNull()
        {		
			ICollection<uint?> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			ICollection<uint?> sourceOfNulls = new uint?[] {null}.ToList();
			var max = sourceOfNulls.Max();
			Assert.AreEqual(default(uint?), max);
        }

		[TestMethod]
        public void TestMaxuintNullableNullableICollectionMapNull()
        {
			ICollection<uint?> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<uint?,uint?>((uint?) arg, (uint?) arg)).ToList();
			try
			{
				source.Max<KeyValuePair<uint?,uint?>, uint?>(null);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			object[] sourceForNulls = { new Stack<int>() };
			var sourceOfNulls = sourceForNulls.Select(x => (uint?) null).ToList();
			var max = sourceOfNulls.Max();
			Assert.AreEqual(default(uint?), max);
        }
						
		#endregion
	
		#region long?	 		
			
        [TestMethod]
        public void TestMaxlongNullableNullableArray()
        {
            var source = Enumerable.Range(1, 100).Select(x => (long?)x).ToArray();

			long? maxActual = source.Max();
            long? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxlongNullableNullableArrayMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (long?)arg }).ToArray();

			long? maxActual = source.Max(arg => arg.X);
            long? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxlongNullableNullableArrayNull()
        {		
			long?[] nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			long?[] sourceOfNulls = new long?[] {null}.ToArray();
			var max = sourceOfNulls.Max();
			Assert.AreEqual(default(long?), max);
        }

		[TestMethod]
        public void TestMaxlongNullableNullableArrayMapNull()
        {
			long?[] nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<long?,long?>((long?) arg, (long?) arg)).ToArray();
			try
			{
				source.Max<KeyValuePair<long?,long?>, long?>(null);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			object[] sourceForNulls = { new Stack<int>() };
			var sourceOfNulls = sourceForNulls.Select(x => (long?) null).ToArray();
			var max = sourceOfNulls.Max();
			Assert.AreEqual(default(long?), max);
        }
					
        [TestMethod]
        public void TestMaxlongNullableNullableList()
        {
            var source = Enumerable.Range(1, 100).Select(x => (long?)x).ToList();

			long? maxActual = source.Max();
            long? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxlongNullableNullableListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (long?)arg }).ToList();

			long? maxActual = source.Max(arg => arg.X);
            long? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxlongNullableNullableListNull()
        {		
			List<long?> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			List<long?> sourceOfNulls = new long?[] {null}.ToList();
			var max = sourceOfNulls.Max();
			Assert.AreEqual(default(long?), max);
        }

		[TestMethod]
        public void TestMaxlongNullableNullableListMapNull()
        {
			List<long?> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<long?,long?>((long?) arg, (long?) arg)).ToList();
			try
			{
				source.Max<KeyValuePair<long?,long?>, long?>(null);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			object[] sourceForNulls = { new Stack<int>() };
			var sourceOfNulls = sourceForNulls.Select(x => (long?) null).ToList();
			var max = sourceOfNulls.Max();
			Assert.AreEqual(default(long?), max);
        }
					
        [TestMethod]
        public void TestMaxlongNullableNullableIList()
        {
            var source = Enumerable.Range(1, 100).Select(x => (long?)x).ToList();

			long? maxActual = source.Max();
            long? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxlongNullableNullableIListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (long?)arg }).ToList();

			long? maxActual = source.Max(arg => arg.X);
            long? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxlongNullableNullableIListNull()
        {		
			IList<long?> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			IList<long?> sourceOfNulls = new long?[] {null}.ToList();
			var max = sourceOfNulls.Max();
			Assert.AreEqual(default(long?), max);
        }

		[TestMethod]
        public void TestMaxlongNullableNullableIListMapNull()
        {
			IList<long?> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<long?,long?>((long?) arg, (long?) arg)).ToList();
			try
			{
				source.Max<KeyValuePair<long?,long?>, long?>(null);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			object[] sourceForNulls = { new Stack<int>() };
			var sourceOfNulls = sourceForNulls.Select(x => (long?) null).ToList();
			var max = sourceOfNulls.Max();
			Assert.AreEqual(default(long?), max);
        }
					
        [TestMethod]
        public void TestMaxlongNullableNullableICollection()
        {
            var source = Enumerable.Range(1, 100).Select(x => (long?)x).ToList();

			long? maxActual = source.Max();
            long? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxlongNullableNullableICollectionMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (long?)arg }).ToList();

			long? maxActual = source.Max(arg => arg.X);
            long? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxlongNullableNullableICollectionNull()
        {		
			ICollection<long?> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			ICollection<long?> sourceOfNulls = new long?[] {null}.ToList();
			var max = sourceOfNulls.Max();
			Assert.AreEqual(default(long?), max);
        }

		[TestMethod]
        public void TestMaxlongNullableNullableICollectionMapNull()
        {
			ICollection<long?> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<long?,long?>((long?) arg, (long?) arg)).ToList();
			try
			{
				source.Max<KeyValuePair<long?,long?>, long?>(null);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			object[] sourceForNulls = { new Stack<int>() };
			var sourceOfNulls = sourceForNulls.Select(x => (long?) null).ToList();
			var max = sourceOfNulls.Max();
			Assert.AreEqual(default(long?), max);
        }
						
		#endregion
	
		#region float?	 		
			
        [TestMethod]
        public void TestMaxfloatNullableNullableArray()
        {
            var source = Enumerable.Range(1, 100).Select(x => (float?)x).ToArray();

			float? maxActual = source.Max();
            float? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxfloatNullableNullableArrayMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (float?)arg }).ToArray();

			float? maxActual = source.Max(arg => arg.X);
            float? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxfloatNullableNullableArrayNull()
        {		
			float?[] nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			float?[] sourceOfNulls = new float?[] {null}.ToArray();
			var max = sourceOfNulls.Max();
			Assert.AreEqual(default(float?), max);
        }

		[TestMethod]
        public void TestMaxfloatNullableNullableArrayMapNull()
        {
			float?[] nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<float?,float?>((float?) arg, (float?) arg)).ToArray();
			try
			{
				source.Max<KeyValuePair<float?,float?>, float?>(null);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			object[] sourceForNulls = { new Stack<int>() };
			var sourceOfNulls = sourceForNulls.Select(x => (float?) null).ToArray();
			var max = sourceOfNulls.Max();
			Assert.AreEqual(default(float?), max);
        }
					
        [TestMethod]
        public void TestMaxfloatNullableNullableList()
        {
            var source = Enumerable.Range(1, 100).Select(x => (float?)x).ToList();

			float? maxActual = source.Max();
            float? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxfloatNullableNullableListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (float?)arg }).ToList();

			float? maxActual = source.Max(arg => arg.X);
            float? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxfloatNullableNullableListNull()
        {		
			List<float?> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			List<float?> sourceOfNulls = new float?[] {null}.ToList();
			var max = sourceOfNulls.Max();
			Assert.AreEqual(default(float?), max);
        }

		[TestMethod]
        public void TestMaxfloatNullableNullableListMapNull()
        {
			List<float?> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<float?,float?>((float?) arg, (float?) arg)).ToList();
			try
			{
				source.Max<KeyValuePair<float?,float?>, float?>(null);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			object[] sourceForNulls = { new Stack<int>() };
			var sourceOfNulls = sourceForNulls.Select(x => (float?) null).ToList();
			var max = sourceOfNulls.Max();
			Assert.AreEqual(default(float?), max);
        }
					
        [TestMethod]
        public void TestMaxfloatNullableNullableIList()
        {
            var source = Enumerable.Range(1, 100).Select(x => (float?)x).ToList();

			float? maxActual = source.Max();
            float? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxfloatNullableNullableIListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (float?)arg }).ToList();

			float? maxActual = source.Max(arg => arg.X);
            float? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxfloatNullableNullableIListNull()
        {		
			IList<float?> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			IList<float?> sourceOfNulls = new float?[] {null}.ToList();
			var max = sourceOfNulls.Max();
			Assert.AreEqual(default(float?), max);
        }

		[TestMethod]
        public void TestMaxfloatNullableNullableIListMapNull()
        {
			IList<float?> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<float?,float?>((float?) arg, (float?) arg)).ToList();
			try
			{
				source.Max<KeyValuePair<float?,float?>, float?>(null);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			object[] sourceForNulls = { new Stack<int>() };
			var sourceOfNulls = sourceForNulls.Select(x => (float?) null).ToList();
			var max = sourceOfNulls.Max();
			Assert.AreEqual(default(float?), max);
        }
					
        [TestMethod]
        public void TestMaxfloatNullableNullableICollection()
        {
            var source = Enumerable.Range(1, 100).Select(x => (float?)x).ToList();

			float? maxActual = source.Max();
            float? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxfloatNullableNullableICollectionMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (float?)arg }).ToList();

			float? maxActual = source.Max(arg => arg.X);
            float? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxfloatNullableNullableICollectionNull()
        {		
			ICollection<float?> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			ICollection<float?> sourceOfNulls = new float?[] {null}.ToList();
			var max = sourceOfNulls.Max();
			Assert.AreEqual(default(float?), max);
        }

		[TestMethod]
        public void TestMaxfloatNullableNullableICollectionMapNull()
        {
			ICollection<float?> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<float?,float?>((float?) arg, (float?) arg)).ToList();
			try
			{
				source.Max<KeyValuePair<float?,float?>, float?>(null);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			object[] sourceForNulls = { new Stack<int>() };
			var sourceOfNulls = sourceForNulls.Select(x => (float?) null).ToList();
			var max = sourceOfNulls.Max();
			Assert.AreEqual(default(float?), max);
        }
						
		#endregion
	
		#region double?	 		
			
        [TestMethod]
        public void TestMaxdoubleNullableNullableArray()
        {
            var source = Enumerable.Range(1, 100).Select(x => (double?)x).ToArray();

			double? maxActual = source.Max();
            double? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxdoubleNullableNullableArrayMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (double?)arg }).ToArray();

			double? maxActual = source.Max(arg => arg.X);
            double? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxdoubleNullableNullableArrayNull()
        {		
			double?[] nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			double?[] sourceOfNulls = new double?[] {null}.ToArray();
			var max = sourceOfNulls.Max();
			Assert.AreEqual(default(double?), max);
        }

		[TestMethod]
        public void TestMaxdoubleNullableNullableArrayMapNull()
        {
			double?[] nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<double?,double?>((double?) arg, (double?) arg)).ToArray();
			try
			{
				source.Max<KeyValuePair<double?,double?>, double?>(null);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			object[] sourceForNulls = { new Stack<int>() };
			var sourceOfNulls = sourceForNulls.Select(x => (double?) null).ToArray();
			var max = sourceOfNulls.Max();
			Assert.AreEqual(default(double?), max);
        }
					
        [TestMethod]
        public void TestMaxdoubleNullableNullableList()
        {
            var source = Enumerable.Range(1, 100).Select(x => (double?)x).ToList();

			double? maxActual = source.Max();
            double? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxdoubleNullableNullableListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (double?)arg }).ToList();

			double? maxActual = source.Max(arg => arg.X);
            double? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxdoubleNullableNullableListNull()
        {		
			List<double?> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			List<double?> sourceOfNulls = new double?[] {null}.ToList();
			var max = sourceOfNulls.Max();
			Assert.AreEqual(default(double?), max);
        }

		[TestMethod]
        public void TestMaxdoubleNullableNullableListMapNull()
        {
			List<double?> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<double?,double?>((double?) arg, (double?) arg)).ToList();
			try
			{
				source.Max<KeyValuePair<double?,double?>, double?>(null);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			object[] sourceForNulls = { new Stack<int>() };
			var sourceOfNulls = sourceForNulls.Select(x => (double?) null).ToList();
			var max = sourceOfNulls.Max();
			Assert.AreEqual(default(double?), max);
        }
					
        [TestMethod]
        public void TestMaxdoubleNullableNullableIList()
        {
            var source = Enumerable.Range(1, 100).Select(x => (double?)x).ToList();

			double? maxActual = source.Max();
            double? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxdoubleNullableNullableIListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (double?)arg }).ToList();

			double? maxActual = source.Max(arg => arg.X);
            double? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxdoubleNullableNullableIListNull()
        {		
			IList<double?> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			IList<double?> sourceOfNulls = new double?[] {null}.ToList();
			var max = sourceOfNulls.Max();
			Assert.AreEqual(default(double?), max);
        }

		[TestMethod]
        public void TestMaxdoubleNullableNullableIListMapNull()
        {
			IList<double?> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<double?,double?>((double?) arg, (double?) arg)).ToList();
			try
			{
				source.Max<KeyValuePair<double?,double?>, double?>(null);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			object[] sourceForNulls = { new Stack<int>() };
			var sourceOfNulls = sourceForNulls.Select(x => (double?) null).ToList();
			var max = sourceOfNulls.Max();
			Assert.AreEqual(default(double?), max);
        }
					
        [TestMethod]
        public void TestMaxdoubleNullableNullableICollection()
        {
            var source = Enumerable.Range(1, 100).Select(x => (double?)x).ToList();

			double? maxActual = source.Max();
            double? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxdoubleNullableNullableICollectionMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (double?)arg }).ToList();

			double? maxActual = source.Max(arg => arg.X);
            double? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxdoubleNullableNullableICollectionNull()
        {		
			ICollection<double?> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			ICollection<double?> sourceOfNulls = new double?[] {null}.ToList();
			var max = sourceOfNulls.Max();
			Assert.AreEqual(default(double?), max);
        }

		[TestMethod]
        public void TestMaxdoubleNullableNullableICollectionMapNull()
        {
			ICollection<double?> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<double?,double?>((double?) arg, (double?) arg)).ToList();
			try
			{
				source.Max<KeyValuePair<double?,double?>, double?>(null);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			object[] sourceForNulls = { new Stack<int>() };
			var sourceOfNulls = sourceForNulls.Select(x => (double?) null).ToList();
			var max = sourceOfNulls.Max();
			Assert.AreEqual(default(double?), max);
        }
						
		#endregion
	
		#region decimal?	 		
			
        [TestMethod]
        public void TestMaxdecimalNullableNullableArray()
        {
            var source = Enumerable.Range(1, 100).Select(x => (decimal?)x).ToArray();

			decimal? maxActual = source.Max();
            decimal? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxdecimalNullableNullableArrayMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (decimal?)arg }).ToArray();

			decimal? maxActual = source.Max(arg => arg.X);
            decimal? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxdecimalNullableNullableArrayNull()
        {		
			decimal?[] nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			decimal?[] sourceOfNulls = new decimal?[] {null}.ToArray();
			var max = sourceOfNulls.Max();
			Assert.AreEqual(default(decimal?), max);
        }

		[TestMethod]
        public void TestMaxdecimalNullableNullableArrayMapNull()
        {
			decimal?[] nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<decimal?,decimal?>((decimal?) arg, (decimal?) arg)).ToArray();
			try
			{
				source.Max<KeyValuePair<decimal?,decimal?>, decimal?>(null);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			object[] sourceForNulls = { new Stack<int>() };
			var sourceOfNulls = sourceForNulls.Select(x => (decimal?) null).ToArray();
			var max = sourceOfNulls.Max();
			Assert.AreEqual(default(decimal?), max);
        }
					
        [TestMethod]
        public void TestMaxdecimalNullableNullableList()
        {
            var source = Enumerable.Range(1, 100).Select(x => (decimal?)x).ToList();

			decimal? maxActual = source.Max();
            decimal? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxdecimalNullableNullableListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (decimal?)arg }).ToList();

			decimal? maxActual = source.Max(arg => arg.X);
            decimal? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxdecimalNullableNullableListNull()
        {		
			List<decimal?> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			List<decimal?> sourceOfNulls = new decimal?[] {null}.ToList();
			var max = sourceOfNulls.Max();
			Assert.AreEqual(default(decimal?), max);
        }

		[TestMethod]
        public void TestMaxdecimalNullableNullableListMapNull()
        {
			List<decimal?> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<decimal?,decimal?>((decimal?) arg, (decimal?) arg)).ToList();
			try
			{
				source.Max<KeyValuePair<decimal?,decimal?>, decimal?>(null);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			object[] sourceForNulls = { new Stack<int>() };
			var sourceOfNulls = sourceForNulls.Select(x => (decimal?) null).ToList();
			var max = sourceOfNulls.Max();
			Assert.AreEqual(default(decimal?), max);
        }
					
        [TestMethod]
        public void TestMaxdecimalNullableNullableIList()
        {
            var source = Enumerable.Range(1, 100).Select(x => (decimal?)x).ToList();

			decimal? maxActual = source.Max();
            decimal? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxdecimalNullableNullableIListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (decimal?)arg }).ToList();

			decimal? maxActual = source.Max(arg => arg.X);
            decimal? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxdecimalNullableNullableIListNull()
        {		
			IList<decimal?> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			IList<decimal?> sourceOfNulls = new decimal?[] {null}.ToList();
			var max = sourceOfNulls.Max();
			Assert.AreEqual(default(decimal?), max);
        }

		[TestMethod]
        public void TestMaxdecimalNullableNullableIListMapNull()
        {
			IList<decimal?> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<decimal?,decimal?>((decimal?) arg, (decimal?) arg)).ToList();
			try
			{
				source.Max<KeyValuePair<decimal?,decimal?>, decimal?>(null);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			object[] sourceForNulls = { new Stack<int>() };
			var sourceOfNulls = sourceForNulls.Select(x => (decimal?) null).ToList();
			var max = sourceOfNulls.Max();
			Assert.AreEqual(default(decimal?), max);
        }
					
        [TestMethod]
        public void TestMaxdecimalNullableNullableICollection()
        {
            var source = Enumerable.Range(1, 100).Select(x => (decimal?)x).ToList();

			decimal? maxActual = source.Max();
            decimal? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxdecimalNullableNullableICollectionMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (decimal?)arg }).ToList();

			decimal? maxActual = source.Max(arg => arg.X);
            decimal? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxdecimalNullableNullableICollectionNull()
        {		
			ICollection<decimal?> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			ICollection<decimal?> sourceOfNulls = new decimal?[] {null}.ToList();
			var max = sourceOfNulls.Max();
			Assert.AreEqual(default(decimal?), max);
        }

		[TestMethod]
        public void TestMaxdecimalNullableNullableICollectionMapNull()
        {
			ICollection<decimal?> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<decimal?,decimal?>((decimal?) arg, (decimal?) arg)).ToList();
			try
			{
				source.Max<KeyValuePair<decimal?,decimal?>, decimal?>(null);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			object[] sourceForNulls = { new Stack<int>() };
			var sourceOfNulls = sourceForNulls.Select(x => (decimal?) null).ToList();
			var max = sourceOfNulls.Max();
			Assert.AreEqual(default(decimal?), max);
        }
						
		#endregion
	
		#region ulong?	 		
			
        [TestMethod]
        public void TestMaxulongNullableNullableArray()
        {
            var source = Enumerable.Range(1, 100).Select(x => (ulong?)x).ToArray();

			ulong? maxActual = source.Max();
            ulong? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxulongNullableNullableArrayMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (ulong?)arg }).ToArray();

			ulong? maxActual = source.Max(arg => arg.X);
            ulong? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxulongNullableNullableArrayNull()
        {		
			ulong?[] nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			ulong?[] sourceOfNulls = new ulong?[] {null}.ToArray();
			var max = sourceOfNulls.Max();
			Assert.AreEqual(default(ulong?), max);
        }

		[TestMethod]
        public void TestMaxulongNullableNullableArrayMapNull()
        {
			ulong?[] nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<ulong?,ulong?>((ulong?) arg, (ulong?) arg)).ToArray();
			try
			{
				source.Max<KeyValuePair<ulong?,ulong?>, ulong?>(null);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			object[] sourceForNulls = { new Stack<int>() };
			var sourceOfNulls = sourceForNulls.Select(x => (ulong?) null).ToArray();
			var max = sourceOfNulls.Max();
			Assert.AreEqual(default(ulong?), max);
        }
					
        [TestMethod]
        public void TestMaxulongNullableNullableList()
        {
            var source = Enumerable.Range(1, 100).Select(x => (ulong?)x).ToList();

			ulong? maxActual = source.Max();
            ulong? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxulongNullableNullableListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (ulong?)arg }).ToList();

			ulong? maxActual = source.Max(arg => arg.X);
            ulong? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxulongNullableNullableListNull()
        {		
			List<ulong?> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			List<ulong?> sourceOfNulls = new ulong?[] {null}.ToList();
			var max = sourceOfNulls.Max();
			Assert.AreEqual(default(ulong?), max);
        }

		[TestMethod]
        public void TestMaxulongNullableNullableListMapNull()
        {
			List<ulong?> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<ulong?,ulong?>((ulong?) arg, (ulong?) arg)).ToList();
			try
			{
				source.Max<KeyValuePair<ulong?,ulong?>, ulong?>(null);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			object[] sourceForNulls = { new Stack<int>() };
			var sourceOfNulls = sourceForNulls.Select(x => (ulong?) null).ToList();
			var max = sourceOfNulls.Max();
			Assert.AreEqual(default(ulong?), max);
        }
					
        [TestMethod]
        public void TestMaxulongNullableNullableIList()
        {
            var source = Enumerable.Range(1, 100).Select(x => (ulong?)x).ToList();

			ulong? maxActual = source.Max();
            ulong? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxulongNullableNullableIListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (ulong?)arg }).ToList();

			ulong? maxActual = source.Max(arg => arg.X);
            ulong? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxulongNullableNullableIListNull()
        {		
			IList<ulong?> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			IList<ulong?> sourceOfNulls = new ulong?[] {null}.ToList();
			var max = sourceOfNulls.Max();
			Assert.AreEqual(default(ulong?), max);
        }

		[TestMethod]
        public void TestMaxulongNullableNullableIListMapNull()
        {
			IList<ulong?> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<ulong?,ulong?>((ulong?) arg, (ulong?) arg)).ToList();
			try
			{
				source.Max<KeyValuePair<ulong?,ulong?>, ulong?>(null);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			object[] sourceForNulls = { new Stack<int>() };
			var sourceOfNulls = sourceForNulls.Select(x => (ulong?) null).ToList();
			var max = sourceOfNulls.Max();
			Assert.AreEqual(default(ulong?), max);
        }
					
        [TestMethod]
        public void TestMaxulongNullableNullableICollection()
        {
            var source = Enumerable.Range(1, 100).Select(x => (ulong?)x).ToList();

			ulong? maxActual = source.Max();
            ulong? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxulongNullableNullableICollectionMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (ulong?)arg }).ToList();

			ulong? maxActual = source.Max(arg => arg.X);
            ulong? maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxulongNullableNullableICollectionNull()
        {		
			ICollection<ulong?> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			ICollection<ulong?> sourceOfNulls = new ulong?[] {null}.ToList();
			var max = sourceOfNulls.Max();
			Assert.AreEqual(default(ulong?), max);
        }

		[TestMethod]
        public void TestMaxulongNullableNullableICollectionMapNull()
        {
			ICollection<ulong?> nullSource = null;

            try
			{
				nullSource.Max();				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<ulong?,ulong?>((ulong?) arg, (ulong?) arg)).ToList();
			try
			{
				source.Max<KeyValuePair<ulong?,ulong?>, ulong?>(null);				
				Assert.Fail();
			}
			catch (ArgumentNullException)
			{
				
			}

			object[] sourceForNulls = { new Stack<int>() };
			var sourceOfNulls = sourceForNulls.Select(x => (ulong?) null).ToList();
			var max = sourceOfNulls.Max();
			Assert.AreEqual(default(ulong?), max);
        }
						
		#endregion
		

	#endregion
    }
}