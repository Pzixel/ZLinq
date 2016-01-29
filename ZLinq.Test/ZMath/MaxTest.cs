
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

		
		#region sbyte	 		
			
        [TestMethod]
        public void TestMaxsbyteNullableArray()
        {
            var source = Enumerable.Range(1, 100).Select(x => (sbyte?)x).ToArray();

			sbyte maxActual = source.Max();
            const sbyte maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxsbyteNullableArrayMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (sbyte?)arg }).ToArray();

			sbyte maxActual = source.Max(arg => arg.X);
            const sbyte maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxsbyteNullableArrayNull()
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
			Assert.AreEqual((sbyte)0, max);
        }

		[TestMethod]
        public void TestMaxsbyteNullableArrayMapNull()
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
			Assert.AreEqual((sbyte)0, max);
        }
					
        [TestMethod]
        public void TestMaxsbyteNullableList()
        {
            var source = Enumerable.Range(1, 100).Select(x => (sbyte?)x).ToList();

			sbyte maxActual = source.Max();
            const sbyte maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxsbyteNullableListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (sbyte?)arg }).ToList();

			sbyte maxActual = source.Max(arg => arg.X);
            const sbyte maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxsbyteNullableListNull()
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
			Assert.AreEqual((sbyte)0, max);
        }

		[TestMethod]
        public void TestMaxsbyteNullableListMapNull()
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
			Assert.AreEqual((sbyte)0, max);
        }
					
        [TestMethod]
        public void TestMaxsbyteNullableIList()
        {
            var source = Enumerable.Range(1, 100).Select(x => (sbyte?)x).ToList();

			sbyte maxActual = source.Max();
            const sbyte maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxsbyteNullableIListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (sbyte?)arg }).ToList();

			sbyte maxActual = source.Max(arg => arg.X);
            const sbyte maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxsbyteNullableIListNull()
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
			Assert.AreEqual((sbyte)0, max);
        }

		[TestMethod]
        public void TestMaxsbyteNullableIListMapNull()
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
			Assert.AreEqual((sbyte)0, max);
        }
					
        [TestMethod]
        public void TestMaxsbyteNullableICollection()
        {
            var source = Enumerable.Range(1, 100).Select(x => (sbyte?)x).ToList();

			sbyte maxActual = source.Max();
            const sbyte maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxsbyteNullableICollectionMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (sbyte?)arg }).ToList();

			sbyte maxActual = source.Max(arg => arg.X);
            const sbyte maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxsbyteNullableICollectionNull()
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
			Assert.AreEqual((sbyte)0, max);
        }

		[TestMethod]
        public void TestMaxsbyteNullableICollectionMapNull()
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
			Assert.AreEqual((sbyte)0, max);
        }
						
		#endregion
	
		#region byte	 		
			
        [TestMethod]
        public void TestMaxbyteNullableArray()
        {
            var source = Enumerable.Range(1, 100).Select(x => (byte?)x).ToArray();

			byte maxActual = source.Max();
            const byte maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxbyteNullableArrayMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (byte?)arg }).ToArray();

			byte maxActual = source.Max(arg => arg.X);
            const byte maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxbyteNullableArrayNull()
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
			Assert.AreEqual((byte)0, max);
        }

		[TestMethod]
        public void TestMaxbyteNullableArrayMapNull()
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
			Assert.AreEqual((byte)0, max);
        }
					
        [TestMethod]
        public void TestMaxbyteNullableList()
        {
            var source = Enumerable.Range(1, 100).Select(x => (byte?)x).ToList();

			byte maxActual = source.Max();
            const byte maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxbyteNullableListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (byte?)arg }).ToList();

			byte maxActual = source.Max(arg => arg.X);
            const byte maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxbyteNullableListNull()
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
			Assert.AreEqual((byte)0, max);
        }

		[TestMethod]
        public void TestMaxbyteNullableListMapNull()
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
			Assert.AreEqual((byte)0, max);
        }
					
        [TestMethod]
        public void TestMaxbyteNullableIList()
        {
            var source = Enumerable.Range(1, 100).Select(x => (byte?)x).ToList();

			byte maxActual = source.Max();
            const byte maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxbyteNullableIListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (byte?)arg }).ToList();

			byte maxActual = source.Max(arg => arg.X);
            const byte maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxbyteNullableIListNull()
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
			Assert.AreEqual((byte)0, max);
        }

		[TestMethod]
        public void TestMaxbyteNullableIListMapNull()
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
			Assert.AreEqual((byte)0, max);
        }
					
        [TestMethod]
        public void TestMaxbyteNullableICollection()
        {
            var source = Enumerable.Range(1, 100).Select(x => (byte?)x).ToList();

			byte maxActual = source.Max();
            const byte maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxbyteNullableICollectionMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (byte?)arg }).ToList();

			byte maxActual = source.Max(arg => arg.X);
            const byte maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxbyteNullableICollectionNull()
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
			Assert.AreEqual((byte)0, max);
        }

		[TestMethod]
        public void TestMaxbyteNullableICollectionMapNull()
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
			Assert.AreEqual((byte)0, max);
        }
						
		#endregion
	
		#region short	 		
			
        [TestMethod]
        public void TestMaxshortNullableArray()
        {
            var source = Enumerable.Range(1, 100).Select(x => (short?)x).ToArray();

			short maxActual = source.Max();
            const short maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxshortNullableArrayMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (short?)arg }).ToArray();

			short maxActual = source.Max(arg => arg.X);
            const short maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxshortNullableArrayNull()
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
			Assert.AreEqual((short)0, max);
        }

		[TestMethod]
        public void TestMaxshortNullableArrayMapNull()
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
			Assert.AreEqual((short)0, max);
        }
					
        [TestMethod]
        public void TestMaxshortNullableList()
        {
            var source = Enumerable.Range(1, 100).Select(x => (short?)x).ToList();

			short maxActual = source.Max();
            const short maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxshortNullableListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (short?)arg }).ToList();

			short maxActual = source.Max(arg => arg.X);
            const short maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxshortNullableListNull()
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
			Assert.AreEqual((short)0, max);
        }

		[TestMethod]
        public void TestMaxshortNullableListMapNull()
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
			Assert.AreEqual((short)0, max);
        }
					
        [TestMethod]
        public void TestMaxshortNullableIList()
        {
            var source = Enumerable.Range(1, 100).Select(x => (short?)x).ToList();

			short maxActual = source.Max();
            const short maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxshortNullableIListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (short?)arg }).ToList();

			short maxActual = source.Max(arg => arg.X);
            const short maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxshortNullableIListNull()
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
			Assert.AreEqual((short)0, max);
        }

		[TestMethod]
        public void TestMaxshortNullableIListMapNull()
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
			Assert.AreEqual((short)0, max);
        }
					
        [TestMethod]
        public void TestMaxshortNullableICollection()
        {
            var source = Enumerable.Range(1, 100).Select(x => (short?)x).ToList();

			short maxActual = source.Max();
            const short maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxshortNullableICollectionMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (short?)arg }).ToList();

			short maxActual = source.Max(arg => arg.X);
            const short maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxshortNullableICollectionNull()
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
			Assert.AreEqual((short)0, max);
        }

		[TestMethod]
        public void TestMaxshortNullableICollectionMapNull()
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
			Assert.AreEqual((short)0, max);
        }
						
		#endregion
	
		#region ushort	 		
			
        [TestMethod]
        public void TestMaxushortNullableArray()
        {
            var source = Enumerable.Range(1, 100).Select(x => (ushort?)x).ToArray();

			ushort maxActual = source.Max();
            const ushort maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxushortNullableArrayMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (ushort?)arg }).ToArray();

			ushort maxActual = source.Max(arg => arg.X);
            const ushort maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxushortNullableArrayNull()
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
			Assert.AreEqual((ushort)0, max);
        }

		[TestMethod]
        public void TestMaxushortNullableArrayMapNull()
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
			Assert.AreEqual((ushort)0, max);
        }
					
        [TestMethod]
        public void TestMaxushortNullableList()
        {
            var source = Enumerable.Range(1, 100).Select(x => (ushort?)x).ToList();

			ushort maxActual = source.Max();
            const ushort maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxushortNullableListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (ushort?)arg }).ToList();

			ushort maxActual = source.Max(arg => arg.X);
            const ushort maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxushortNullableListNull()
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
			Assert.AreEqual((ushort)0, max);
        }

		[TestMethod]
        public void TestMaxushortNullableListMapNull()
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
			Assert.AreEqual((ushort)0, max);
        }
					
        [TestMethod]
        public void TestMaxushortNullableIList()
        {
            var source = Enumerable.Range(1, 100).Select(x => (ushort?)x).ToList();

			ushort maxActual = source.Max();
            const ushort maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxushortNullableIListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (ushort?)arg }).ToList();

			ushort maxActual = source.Max(arg => arg.X);
            const ushort maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxushortNullableIListNull()
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
			Assert.AreEqual((ushort)0, max);
        }

		[TestMethod]
        public void TestMaxushortNullableIListMapNull()
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
			Assert.AreEqual((ushort)0, max);
        }
					
        [TestMethod]
        public void TestMaxushortNullableICollection()
        {
            var source = Enumerable.Range(1, 100).Select(x => (ushort?)x).ToList();

			ushort maxActual = source.Max();
            const ushort maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxushortNullableICollectionMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (ushort?)arg }).ToList();

			ushort maxActual = source.Max(arg => arg.X);
            const ushort maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxushortNullableICollectionNull()
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
			Assert.AreEqual((ushort)0, max);
        }

		[TestMethod]
        public void TestMaxushortNullableICollectionMapNull()
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
			Assert.AreEqual((ushort)0, max);
        }
						
		#endregion
	
		#region int	 		
			
        [TestMethod]
        public void TestMaxintNullableArray()
        {
            var source = Enumerable.Range(1, 100).Select(x => (int?)x).ToArray();

			int maxActual = source.Max();
            const int maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxintNullableArrayMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (int?)arg }).ToArray();

			int maxActual = source.Max(arg => arg.X);
            const int maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxintNullableArrayNull()
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
			Assert.AreEqual((int)0, max);
        }

		[TestMethod]
        public void TestMaxintNullableArrayMapNull()
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
			Assert.AreEqual((int)0, max);
        }
					
        [TestMethod]
        public void TestMaxintNullableList()
        {
            var source = Enumerable.Range(1, 100).Select(x => (int?)x).ToList();

			int maxActual = source.Max();
            const int maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxintNullableListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (int?)arg }).ToList();

			int maxActual = source.Max(arg => arg.X);
            const int maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxintNullableListNull()
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
			Assert.AreEqual((int)0, max);
        }

		[TestMethod]
        public void TestMaxintNullableListMapNull()
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
			Assert.AreEqual((int)0, max);
        }
					
        [TestMethod]
        public void TestMaxintNullableIList()
        {
            var source = Enumerable.Range(1, 100).Select(x => (int?)x).ToList();

			int maxActual = source.Max();
            const int maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxintNullableIListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (int?)arg }).ToList();

			int maxActual = source.Max(arg => arg.X);
            const int maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxintNullableIListNull()
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
			Assert.AreEqual((int)0, max);
        }

		[TestMethod]
        public void TestMaxintNullableIListMapNull()
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
			Assert.AreEqual((int)0, max);
        }
					
        [TestMethod]
        public void TestMaxintNullableICollection()
        {
            var source = Enumerable.Range(1, 100).Select(x => (int?)x).ToList();

			int maxActual = source.Max();
            const int maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxintNullableICollectionMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (int?)arg }).ToList();

			int maxActual = source.Max(arg => arg.X);
            const int maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxintNullableICollectionNull()
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
			Assert.AreEqual((int)0, max);
        }

		[TestMethod]
        public void TestMaxintNullableICollectionMapNull()
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
			Assert.AreEqual((int)0, max);
        }
						
		#endregion
	
		#region uint	 		
			
        [TestMethod]
        public void TestMaxuintNullableArray()
        {
            var source = Enumerable.Range(1, 100).Select(x => (uint?)x).ToArray();

			uint maxActual = source.Max();
            const uint maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxuintNullableArrayMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (uint?)arg }).ToArray();

			uint maxActual = source.Max(arg => arg.X);
            const uint maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxuintNullableArrayNull()
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
			Assert.AreEqual((uint)0, max);
        }

		[TestMethod]
        public void TestMaxuintNullableArrayMapNull()
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
			Assert.AreEqual((uint)0, max);
        }
					
        [TestMethod]
        public void TestMaxuintNullableList()
        {
            var source = Enumerable.Range(1, 100).Select(x => (uint?)x).ToList();

			uint maxActual = source.Max();
            const uint maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxuintNullableListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (uint?)arg }).ToList();

			uint maxActual = source.Max(arg => arg.X);
            const uint maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxuintNullableListNull()
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
			Assert.AreEqual((uint)0, max);
        }

		[TestMethod]
        public void TestMaxuintNullableListMapNull()
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
			Assert.AreEqual((uint)0, max);
        }
					
        [TestMethod]
        public void TestMaxuintNullableIList()
        {
            var source = Enumerable.Range(1, 100).Select(x => (uint?)x).ToList();

			uint maxActual = source.Max();
            const uint maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxuintNullableIListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (uint?)arg }).ToList();

			uint maxActual = source.Max(arg => arg.X);
            const uint maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxuintNullableIListNull()
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
			Assert.AreEqual((uint)0, max);
        }

		[TestMethod]
        public void TestMaxuintNullableIListMapNull()
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
			Assert.AreEqual((uint)0, max);
        }
					
        [TestMethod]
        public void TestMaxuintNullableICollection()
        {
            var source = Enumerable.Range(1, 100).Select(x => (uint?)x).ToList();

			uint maxActual = source.Max();
            const uint maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxuintNullableICollectionMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (uint?)arg }).ToList();

			uint maxActual = source.Max(arg => arg.X);
            const uint maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxuintNullableICollectionNull()
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
			Assert.AreEqual((uint)0, max);
        }

		[TestMethod]
        public void TestMaxuintNullableICollectionMapNull()
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
			Assert.AreEqual((uint)0, max);
        }
						
		#endregion
	
		#region long	 		
			
        [TestMethod]
        public void TestMaxlongNullableArray()
        {
            var source = Enumerable.Range(1, 100).Select(x => (long?)x).ToArray();

			long maxActual = source.Max();
            const long maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxlongNullableArrayMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (long?)arg }).ToArray();

			long maxActual = source.Max(arg => arg.X);
            const long maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxlongNullableArrayNull()
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
			Assert.AreEqual((long)0, max);
        }

		[TestMethod]
        public void TestMaxlongNullableArrayMapNull()
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
			Assert.AreEqual((long)0, max);
        }
					
        [TestMethod]
        public void TestMaxlongNullableList()
        {
            var source = Enumerable.Range(1, 100).Select(x => (long?)x).ToList();

			long maxActual = source.Max();
            const long maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxlongNullableListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (long?)arg }).ToList();

			long maxActual = source.Max(arg => arg.X);
            const long maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxlongNullableListNull()
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
			Assert.AreEqual((long)0, max);
        }

		[TestMethod]
        public void TestMaxlongNullableListMapNull()
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
			Assert.AreEqual((long)0, max);
        }
					
        [TestMethod]
        public void TestMaxlongNullableIList()
        {
            var source = Enumerable.Range(1, 100).Select(x => (long?)x).ToList();

			long maxActual = source.Max();
            const long maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxlongNullableIListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (long?)arg }).ToList();

			long maxActual = source.Max(arg => arg.X);
            const long maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxlongNullableIListNull()
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
			Assert.AreEqual((long)0, max);
        }

		[TestMethod]
        public void TestMaxlongNullableIListMapNull()
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
			Assert.AreEqual((long)0, max);
        }
					
        [TestMethod]
        public void TestMaxlongNullableICollection()
        {
            var source = Enumerable.Range(1, 100).Select(x => (long?)x).ToList();

			long maxActual = source.Max();
            const long maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxlongNullableICollectionMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (long?)arg }).ToList();

			long maxActual = source.Max(arg => arg.X);
            const long maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxlongNullableICollectionNull()
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
			Assert.AreEqual((long)0, max);
        }

		[TestMethod]
        public void TestMaxlongNullableICollectionMapNull()
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
			Assert.AreEqual((long)0, max);
        }
						
		#endregion
	
		#region float	 		
			
        [TestMethod]
        public void TestMaxfloatNullableArray()
        {
            var source = Enumerable.Range(1, 100).Select(x => (float?)x).ToArray();

			float maxActual = source.Max();
            const float maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxfloatNullableArrayMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (float?)arg }).ToArray();

			float maxActual = source.Max(arg => arg.X);
            const float maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

							
        [TestMethod]
        public void TestMaxfloatNullableList()
        {
            var source = Enumerable.Range(1, 100).Select(x => (float?)x).ToList();

			float maxActual = source.Max();
            const float maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxfloatNullableListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (float?)arg }).ToList();

			float maxActual = source.Max(arg => arg.X);
            const float maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

							
        [TestMethod]
        public void TestMaxfloatNullableIList()
        {
            var source = Enumerable.Range(1, 100).Select(x => (float?)x).ToList();

			float maxActual = source.Max();
            const float maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxfloatNullableIListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (float?)arg }).ToList();

			float maxActual = source.Max(arg => arg.X);
            const float maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

							
        [TestMethod]
        public void TestMaxfloatNullableICollection()
        {
            var source = Enumerable.Range(1, 100).Select(x => (float?)x).ToList();

			float maxActual = source.Max();
            const float maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxfloatNullableICollectionMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (float?)arg }).ToList();

			float maxActual = source.Max(arg => arg.X);
            const float maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

								
		#endregion
	
		#region double	 		
			
        [TestMethod]
        public void TestMaxdoubleNullableArray()
        {
            var source = Enumerable.Range(1, 100).Select(x => (double?)x).ToArray();

			double maxActual = source.Max();
            const double maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxdoubleNullableArrayMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (double?)arg }).ToArray();

			double maxActual = source.Max(arg => arg.X);
            const double maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

							
        [TestMethod]
        public void TestMaxdoubleNullableList()
        {
            var source = Enumerable.Range(1, 100).Select(x => (double?)x).ToList();

			double maxActual = source.Max();
            const double maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxdoubleNullableListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (double?)arg }).ToList();

			double maxActual = source.Max(arg => arg.X);
            const double maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

							
        [TestMethod]
        public void TestMaxdoubleNullableIList()
        {
            var source = Enumerable.Range(1, 100).Select(x => (double?)x).ToList();

			double maxActual = source.Max();
            const double maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxdoubleNullableIListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (double?)arg }).ToList();

			double maxActual = source.Max(arg => arg.X);
            const double maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

							
        [TestMethod]
        public void TestMaxdoubleNullableICollection()
        {
            var source = Enumerable.Range(1, 100).Select(x => (double?)x).ToList();

			double maxActual = source.Max();
            const double maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxdoubleNullableICollectionMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (double?)arg }).ToList();

			double maxActual = source.Max(arg => arg.X);
            const double maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

								
		#endregion
	
		#region decimal	 		
			
        [TestMethod]
        public void TestMaxdecimalNullableArray()
        {
            var source = Enumerable.Range(1, 100).Select(x => (decimal?)x).ToArray();

			decimal maxActual = source.Max();
            const decimal maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxdecimalNullableArrayMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (decimal?)arg }).ToArray();

			decimal maxActual = source.Max(arg => arg.X);
            const decimal maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

							
        [TestMethod]
        public void TestMaxdecimalNullableList()
        {
            var source = Enumerable.Range(1, 100).Select(x => (decimal?)x).ToList();

			decimal maxActual = source.Max();
            const decimal maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxdecimalNullableListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (decimal?)arg }).ToList();

			decimal maxActual = source.Max(arg => arg.X);
            const decimal maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

							
        [TestMethod]
        public void TestMaxdecimalNullableIList()
        {
            var source = Enumerable.Range(1, 100).Select(x => (decimal?)x).ToList();

			decimal maxActual = source.Max();
            const decimal maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxdecimalNullableIListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (decimal?)arg }).ToList();

			decimal maxActual = source.Max(arg => arg.X);
            const decimal maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

							
        [TestMethod]
        public void TestMaxdecimalNullableICollection()
        {
            var source = Enumerable.Range(1, 100).Select(x => (decimal?)x).ToList();

			decimal maxActual = source.Max();
            const decimal maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxdecimalNullableICollectionMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (decimal?)arg }).ToList();

			decimal maxActual = source.Max(arg => arg.X);
            const decimal maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

								
		#endregion
	
		#region ulong	 		
			
        [TestMethod]
        public void TestMaxulongNullableArray()
        {
            var source = Enumerable.Range(1, 100).Select(x => (ulong?)x).ToArray();

			ulong maxActual = source.Max();
            const ulong maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxulongNullableArrayMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (ulong?)arg }).ToArray();

			ulong maxActual = source.Max(arg => arg.X);
            const ulong maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxulongNullableArrayNull()
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
			Assert.AreEqual((ulong)0, max);
        }

		[TestMethod]
        public void TestMaxulongNullableArrayMapNull()
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
			Assert.AreEqual((ulong)0, max);
        }
					
        [TestMethod]
        public void TestMaxulongNullableList()
        {
            var source = Enumerable.Range(1, 100).Select(x => (ulong?)x).ToList();

			ulong maxActual = source.Max();
            const ulong maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxulongNullableListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (ulong?)arg }).ToList();

			ulong maxActual = source.Max(arg => arg.X);
            const ulong maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxulongNullableListNull()
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
			Assert.AreEqual((ulong)0, max);
        }

		[TestMethod]
        public void TestMaxulongNullableListMapNull()
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
			Assert.AreEqual((ulong)0, max);
        }
					
        [TestMethod]
        public void TestMaxulongNullableIList()
        {
            var source = Enumerable.Range(1, 100).Select(x => (ulong?)x).ToList();

			ulong maxActual = source.Max();
            const ulong maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxulongNullableIListMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (ulong?)arg }).ToList();

			ulong maxActual = source.Max(arg => arg.X);
            const ulong maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxulongNullableIListNull()
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
			Assert.AreEqual((ulong)0, max);
        }

		[TestMethod]
        public void TestMaxulongNullableIListMapNull()
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
			Assert.AreEqual((ulong)0, max);
        }
					
        [TestMethod]
        public void TestMaxulongNullableICollection()
        {
            var source = Enumerable.Range(1, 100).Select(x => (ulong?)x).ToList();

			ulong maxActual = source.Max();
            const ulong maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

		[TestMethod]
        public void TestMaxulongNullableICollectionMap()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new { X = (ulong?)arg }).ToList();

			ulong maxActual = source.Max(arg => arg.X);
            const ulong maxExpected = 100;

            Assert.AreEqual(maxExpected, maxActual);
        }

						
		[TestMethod]
        public void TestMaxulongNullableICollectionNull()
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
			Assert.AreEqual((ulong)0, max);
        }

		[TestMethod]
        public void TestMaxulongNullableICollectionMapNull()
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
			Assert.AreEqual((ulong)0, max);
        }
						
		#endregion
		

	#endregion
    }
}