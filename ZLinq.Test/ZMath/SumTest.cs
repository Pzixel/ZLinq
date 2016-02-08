
using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using ZLinq.Test.Helpers;

namespace ZLinq.Test.ZMath
{
    [TestClass]
    public class Sum
    {            
    
                
            #region sbyte             
            
        
        [TestMethod]
        public void TestSumsbyteArray100()
        {
            var source = ZEnumerable.Repeat((sbyte) 1, 100).ToArray();
            sbyte SumActual = ZEnumerable.Sum(source);
            sbyte SumExpected = (sbyte) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumsbyteArray100Map()
        {
            var source = ZEnumerable.Repeat(new { X = (sbyte) 1 } , 100).ToArray();
            sbyte SumActual = ZEnumerable.Sum(source, arg => arg.X);
            sbyte SumExpected = (sbyte) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumsbyteArray100Null()
        {        
            sbyte[] nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumsbyteArray100MapNull()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<sbyte,sbyte>((sbyte) arg, (sbyte) arg)).ToArray();
            Func<KeyValuePair<sbyte, sbyte>, sbyte> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumsbyteList100()
        {
            var source = ZEnumerable.Repeat((sbyte) 1, 100).ToList();
            sbyte SumActual = ZEnumerable.Sum(source);
            sbyte SumExpected = (sbyte) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumsbyteList100Map()
        {
            var source = ZEnumerable.Repeat(new { X = (sbyte) 1 } , 100).ToList();
            sbyte SumActual = ZEnumerable.Sum(source, arg => arg.X);
            sbyte SumExpected = (sbyte) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumsbyteList100Null()
        {        
            List<sbyte> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumsbyteList100MapNull()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<sbyte,sbyte>((sbyte) arg, (sbyte) arg)).ToList();
            Func<KeyValuePair<sbyte, sbyte>, sbyte> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumsbyteIList100()
        {
            var source = ZEnumerable.Repeat((sbyte) 1, 100).ToIList();
            sbyte SumActual = ZEnumerable.Sum(source);
            sbyte SumExpected = (sbyte) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumsbyteIList100Map()
        {
            var source = ZEnumerable.Repeat(new { X = (sbyte) 1 } , 100).ToIList();
            sbyte SumActual = ZEnumerable.Sum(source, arg => arg.X);
            sbyte SumExpected = (sbyte) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumsbyteIList100Null()
        {        
            IList<sbyte> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumsbyteIList100MapNull()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<sbyte,sbyte>((sbyte) arg, (sbyte) arg)).ToIList();
            Func<KeyValuePair<sbyte, sbyte>, sbyte> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
                
        #endregion
            #region byte             
            
        
        [TestMethod]
        public void TestSumbyteArray100()
        {
            var source = ZEnumerable.Repeat((byte) 1, 100).ToArray();
            byte SumActual = ZEnumerable.Sum(source);
            byte SumExpected = (byte) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumbyteArray100Map()
        {
            var source = ZEnumerable.Repeat(new { X = (byte) 1 } , 100).ToArray();
            byte SumActual = ZEnumerable.Sum(source, arg => arg.X);
            byte SumExpected = (byte) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumbyteArray100Null()
        {        
            byte[] nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumbyteArray100MapNull()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<byte,byte>((byte) arg, (byte) arg)).ToArray();
            Func<KeyValuePair<byte, byte>, byte> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumbyteList100()
        {
            var source = ZEnumerable.Repeat((byte) 1, 100).ToList();
            byte SumActual = ZEnumerable.Sum(source);
            byte SumExpected = (byte) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumbyteList100Map()
        {
            var source = ZEnumerable.Repeat(new { X = (byte) 1 } , 100).ToList();
            byte SumActual = ZEnumerable.Sum(source, arg => arg.X);
            byte SumExpected = (byte) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumbyteList100Null()
        {        
            List<byte> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumbyteList100MapNull()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<byte,byte>((byte) arg, (byte) arg)).ToList();
            Func<KeyValuePair<byte, byte>, byte> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumbyteIList100()
        {
            var source = ZEnumerable.Repeat((byte) 1, 100).ToIList();
            byte SumActual = ZEnumerable.Sum(source);
            byte SumExpected = (byte) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumbyteIList100Map()
        {
            var source = ZEnumerable.Repeat(new { X = (byte) 1 } , 100).ToIList();
            byte SumActual = ZEnumerable.Sum(source, arg => arg.X);
            byte SumExpected = (byte) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumbyteIList100Null()
        {        
            IList<byte> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumbyteIList100MapNull()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<byte,byte>((byte) arg, (byte) arg)).ToIList();
            Func<KeyValuePair<byte, byte>, byte> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
                
        #endregion
            #region short             
            
        
        [TestMethod]
        public void TestSumshortArray100()
        {
            var source = ZEnumerable.Repeat((short) 1, 100).ToArray();
            short SumActual = ZEnumerable.Sum(source);
            short SumExpected = (short) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumshortArray100Map()
        {
            var source = ZEnumerable.Repeat(new { X = (short) 1 } , 100).ToArray();
            short SumActual = ZEnumerable.Sum(source, arg => arg.X);
            short SumExpected = (short) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumshortArray100Null()
        {        
            short[] nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumshortArray100MapNull()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<short,short>((short) arg, (short) arg)).ToArray();
            Func<KeyValuePair<short, short>, short> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumshortList100()
        {
            var source = ZEnumerable.Repeat((short) 1, 100).ToList();
            short SumActual = ZEnumerable.Sum(source);
            short SumExpected = (short) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumshortList100Map()
        {
            var source = ZEnumerable.Repeat(new { X = (short) 1 } , 100).ToList();
            short SumActual = ZEnumerable.Sum(source, arg => arg.X);
            short SumExpected = (short) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumshortList100Null()
        {        
            List<short> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumshortList100MapNull()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<short,short>((short) arg, (short) arg)).ToList();
            Func<KeyValuePair<short, short>, short> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumshortIList100()
        {
            var source = ZEnumerable.Repeat((short) 1, 100).ToIList();
            short SumActual = ZEnumerable.Sum(source);
            short SumExpected = (short) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumshortIList100Map()
        {
            var source = ZEnumerable.Repeat(new { X = (short) 1 } , 100).ToIList();
            short SumActual = ZEnumerable.Sum(source, arg => arg.X);
            short SumExpected = (short) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumshortIList100Null()
        {        
            IList<short> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumshortIList100MapNull()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<short,short>((short) arg, (short) arg)).ToIList();
            Func<KeyValuePair<short, short>, short> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
                
        #endregion
            #region ushort             
            
        
        [TestMethod]
        public void TestSumushortArray100()
        {
            var source = ZEnumerable.Repeat((ushort) 1, 100).ToArray();
            ushort SumActual = ZEnumerable.Sum(source);
            ushort SumExpected = (ushort) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumushortArray100Map()
        {
            var source = ZEnumerable.Repeat(new { X = (ushort) 1 } , 100).ToArray();
            ushort SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ushort SumExpected = (ushort) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumushortArray100Null()
        {        
            ushort[] nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumushortArray100MapNull()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<ushort,ushort>((ushort) arg, (ushort) arg)).ToArray();
            Func<KeyValuePair<ushort, ushort>, ushort> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumushortList100()
        {
            var source = ZEnumerable.Repeat((ushort) 1, 100).ToList();
            ushort SumActual = ZEnumerable.Sum(source);
            ushort SumExpected = (ushort) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumushortList100Map()
        {
            var source = ZEnumerable.Repeat(new { X = (ushort) 1 } , 100).ToList();
            ushort SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ushort SumExpected = (ushort) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumushortList100Null()
        {        
            List<ushort> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumushortList100MapNull()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<ushort,ushort>((ushort) arg, (ushort) arg)).ToList();
            Func<KeyValuePair<ushort, ushort>, ushort> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumushortIList100()
        {
            var source = ZEnumerable.Repeat((ushort) 1, 100).ToIList();
            ushort SumActual = ZEnumerable.Sum(source);
            ushort SumExpected = (ushort) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumushortIList100Map()
        {
            var source = ZEnumerable.Repeat(new { X = (ushort) 1 } , 100).ToIList();
            ushort SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ushort SumExpected = (ushort) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumushortIList100Null()
        {        
            IList<ushort> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumushortIList100MapNull()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<ushort,ushort>((ushort) arg, (ushort) arg)).ToIList();
            Func<KeyValuePair<ushort, ushort>, ushort> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
                
        #endregion
            #region int             
            
        
        [TestMethod]
        public void TestSumintArray100()
        {
            var source = ZEnumerable.Repeat((int) 1, 100).ToArray();
            int SumActual = ZEnumerable.Sum(source);
            int SumExpected = (int) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumintArray100Map()
        {
            var source = ZEnumerable.Repeat(new { X = (int) 1 } , 100).ToArray();
            int SumActual = ZEnumerable.Sum(source, arg => arg.X);
            int SumExpected = (int) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumintArray100Null()
        {        
            int[] nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumintArray100MapNull()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<int,int>((int) arg, (int) arg)).ToArray();
            Func<KeyValuePair<int, int>, int> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumintList100()
        {
            var source = ZEnumerable.Repeat((int) 1, 100).ToList();
            int SumActual = ZEnumerable.Sum(source);
            int SumExpected = (int) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumintList100Map()
        {
            var source = ZEnumerable.Repeat(new { X = (int) 1 } , 100).ToList();
            int SumActual = ZEnumerable.Sum(source, arg => arg.X);
            int SumExpected = (int) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumintList100Null()
        {        
            List<int> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumintList100MapNull()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<int,int>((int) arg, (int) arg)).ToList();
            Func<KeyValuePair<int, int>, int> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumintIList100()
        {
            var source = ZEnumerable.Repeat((int) 1, 100).ToIList();
            int SumActual = ZEnumerable.Sum(source);
            int SumExpected = (int) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumintIList100Map()
        {
            var source = ZEnumerable.Repeat(new { X = (int) 1 } , 100).ToIList();
            int SumActual = ZEnumerable.Sum(source, arg => arg.X);
            int SumExpected = (int) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumintIList100Null()
        {        
            IList<int> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumintIList100MapNull()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<int,int>((int) arg, (int) arg)).ToIList();
            Func<KeyValuePair<int, int>, int> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
                
        #endregion
            #region uint             
            
        
        [TestMethod]
        public void TestSumuintArray100()
        {
            var source = ZEnumerable.Repeat((uint) 1, 100).ToArray();
            uint SumActual = ZEnumerable.Sum(source);
            uint SumExpected = (uint) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumuintArray100Map()
        {
            var source = ZEnumerable.Repeat(new { X = (uint) 1 } , 100).ToArray();
            uint SumActual = ZEnumerable.Sum(source, arg => arg.X);
            uint SumExpected = (uint) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumuintArray100Null()
        {        
            uint[] nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumuintArray100MapNull()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<uint,uint>((uint) arg, (uint) arg)).ToArray();
            Func<KeyValuePair<uint, uint>, uint> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumuintList100()
        {
            var source = ZEnumerable.Repeat((uint) 1, 100).ToList();
            uint SumActual = ZEnumerable.Sum(source);
            uint SumExpected = (uint) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumuintList100Map()
        {
            var source = ZEnumerable.Repeat(new { X = (uint) 1 } , 100).ToList();
            uint SumActual = ZEnumerable.Sum(source, arg => arg.X);
            uint SumExpected = (uint) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumuintList100Null()
        {        
            List<uint> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumuintList100MapNull()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<uint,uint>((uint) arg, (uint) arg)).ToList();
            Func<KeyValuePair<uint, uint>, uint> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumuintIList100()
        {
            var source = ZEnumerable.Repeat((uint) 1, 100).ToIList();
            uint SumActual = ZEnumerable.Sum(source);
            uint SumExpected = (uint) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumuintIList100Map()
        {
            var source = ZEnumerable.Repeat(new { X = (uint) 1 } , 100).ToIList();
            uint SumActual = ZEnumerable.Sum(source, arg => arg.X);
            uint SumExpected = (uint) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumuintIList100Null()
        {        
            IList<uint> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumuintIList100MapNull()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<uint,uint>((uint) arg, (uint) arg)).ToIList();
            Func<KeyValuePair<uint, uint>, uint> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
                
        #endregion
            #region long             
            
        
        [TestMethod]
        public void TestSumlongArray100()
        {
            var source = ZEnumerable.Repeat((long) 1, 100).ToArray();
            long SumActual = ZEnumerable.Sum(source);
            long SumExpected = (long) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumlongArray100Map()
        {
            var source = ZEnumerable.Repeat(new { X = (long) 1 } , 100).ToArray();
            long SumActual = ZEnumerable.Sum(source, arg => arg.X);
            long SumExpected = (long) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumlongArray100Null()
        {        
            long[] nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumlongArray100MapNull()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<long,long>((long) arg, (long) arg)).ToArray();
            Func<KeyValuePair<long, long>, long> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumlongList100()
        {
            var source = ZEnumerable.Repeat((long) 1, 100).ToList();
            long SumActual = ZEnumerable.Sum(source);
            long SumExpected = (long) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumlongList100Map()
        {
            var source = ZEnumerable.Repeat(new { X = (long) 1 } , 100).ToList();
            long SumActual = ZEnumerable.Sum(source, arg => arg.X);
            long SumExpected = (long) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumlongList100Null()
        {        
            List<long> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumlongList100MapNull()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<long,long>((long) arg, (long) arg)).ToList();
            Func<KeyValuePair<long, long>, long> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumlongIList100()
        {
            var source = ZEnumerable.Repeat((long) 1, 100).ToIList();
            long SumActual = ZEnumerable.Sum(source);
            long SumExpected = (long) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumlongIList100Map()
        {
            var source = ZEnumerable.Repeat(new { X = (long) 1 } , 100).ToIList();
            long SumActual = ZEnumerable.Sum(source, arg => arg.X);
            long SumExpected = (long) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumlongIList100Null()
        {        
            IList<long> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumlongIList100MapNull()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<long,long>((long) arg, (long) arg)).ToIList();
            Func<KeyValuePair<long, long>, long> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
                
        #endregion
            #region float             
            
        
        [TestMethod]
        public void TestSumfloatArray100()
        {
            var source = ZEnumerable.Repeat((float) 1, 100).ToArray();
            float SumActual = ZEnumerable.Sum(source);
            float SumExpected = (float) Enumerable.Sum(source.Select(x=> (double)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumfloatArray100Map()
        {
            var source = ZEnumerable.Repeat(new { X = (float) 1 } , 100).ToArray();
            float SumActual = ZEnumerable.Sum(source, arg => arg.X);
            float SumExpected = (float) Enumerable.Sum(source, arg => (double) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumfloatArray100Null()
        {        
            float[] nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumfloatArray100MapNull()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<float,float>((float) arg, (float) arg)).ToArray();
            Func<KeyValuePair<float, float>, float> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumfloatList100()
        {
            var source = ZEnumerable.Repeat((float) 1, 100).ToList();
            float SumActual = ZEnumerable.Sum(source);
            float SumExpected = (float) Enumerable.Sum(source.Select(x=> (double)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumfloatList100Map()
        {
            var source = ZEnumerable.Repeat(new { X = (float) 1 } , 100).ToList();
            float SumActual = ZEnumerable.Sum(source, arg => arg.X);
            float SumExpected = (float) Enumerable.Sum(source, arg => (double) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumfloatList100Null()
        {        
            List<float> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumfloatList100MapNull()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<float,float>((float) arg, (float) arg)).ToList();
            Func<KeyValuePair<float, float>, float> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumfloatIList100()
        {
            var source = ZEnumerable.Repeat((float) 1, 100).ToIList();
            float SumActual = ZEnumerable.Sum(source);
            float SumExpected = (float) Enumerable.Sum(source.Select(x=> (double)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumfloatIList100Map()
        {
            var source = ZEnumerable.Repeat(new { X = (float) 1 } , 100).ToIList();
            float SumActual = ZEnumerable.Sum(source, arg => arg.X);
            float SumExpected = (float) Enumerable.Sum(source, arg => (double) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumfloatIList100Null()
        {        
            IList<float> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumfloatIList100MapNull()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<float,float>((float) arg, (float) arg)).ToIList();
            Func<KeyValuePair<float, float>, float> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
                
        #endregion
            #region double             
            
        
        [TestMethod]
        public void TestSumdoubleArray100()
        {
            var source = ZEnumerable.Repeat((double) 1, 100).ToArray();
            double SumActual = ZEnumerable.Sum(source);
            double SumExpected = (double) Enumerable.Sum(source.Select(x=> (double)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdoubleArray100Map()
        {
            var source = ZEnumerable.Repeat(new { X = (double) 1 } , 100).ToArray();
            double SumActual = ZEnumerable.Sum(source, arg => arg.X);
            double SumExpected = (double) Enumerable.Sum(source, arg => (double) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumdoubleArray100Null()
        {        
            double[] nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumdoubleArray100MapNull()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<double,double>((double) arg, (double) arg)).ToArray();
            Func<KeyValuePair<double, double>, double> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumdoubleList100()
        {
            var source = ZEnumerable.Repeat((double) 1, 100).ToList();
            double SumActual = ZEnumerable.Sum(source);
            double SumExpected = (double) Enumerable.Sum(source.Select(x=> (double)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdoubleList100Map()
        {
            var source = ZEnumerable.Repeat(new { X = (double) 1 } , 100).ToList();
            double SumActual = ZEnumerable.Sum(source, arg => arg.X);
            double SumExpected = (double) Enumerable.Sum(source, arg => (double) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumdoubleList100Null()
        {        
            List<double> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumdoubleList100MapNull()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<double,double>((double) arg, (double) arg)).ToList();
            Func<KeyValuePair<double, double>, double> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumdoubleIList100()
        {
            var source = ZEnumerable.Repeat((double) 1, 100).ToIList();
            double SumActual = ZEnumerable.Sum(source);
            double SumExpected = (double) Enumerable.Sum(source.Select(x=> (double)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdoubleIList100Map()
        {
            var source = ZEnumerable.Repeat(new { X = (double) 1 } , 100).ToIList();
            double SumActual = ZEnumerable.Sum(source, arg => arg.X);
            double SumExpected = (double) Enumerable.Sum(source, arg => (double) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumdoubleIList100Null()
        {        
            IList<double> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumdoubleIList100MapNull()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<double,double>((double) arg, (double) arg)).ToIList();
            Func<KeyValuePair<double, double>, double> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
                
        #endregion
            #region decimal             
            
        
        [TestMethod]
        public void TestSumdecimalArray100()
        {
            var source = ZEnumerable.Repeat((decimal) 1, 100).ToArray();
            decimal SumActual = ZEnumerable.Sum(source);
            decimal SumExpected = (decimal) Enumerable.Sum(source.Select(x=> (double)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdecimalArray100Map()
        {
            var source = ZEnumerable.Repeat(new { X = (decimal) 1 } , 100).ToArray();
            decimal SumActual = ZEnumerable.Sum(source, arg => arg.X);
            decimal SumExpected = (decimal) Enumerable.Sum(source, arg => (double) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumdecimalArray100Null()
        {        
            decimal[] nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumdecimalArray100MapNull()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<decimal,decimal>((decimal) arg, (decimal) arg)).ToArray();
            Func<KeyValuePair<decimal, decimal>, decimal> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumdecimalList100()
        {
            var source = ZEnumerable.Repeat((decimal) 1, 100).ToList();
            decimal SumActual = ZEnumerable.Sum(source);
            decimal SumExpected = (decimal) Enumerable.Sum(source.Select(x=> (double)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdecimalList100Map()
        {
            var source = ZEnumerable.Repeat(new { X = (decimal) 1 } , 100).ToList();
            decimal SumActual = ZEnumerable.Sum(source, arg => arg.X);
            decimal SumExpected = (decimal) Enumerable.Sum(source, arg => (double) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumdecimalList100Null()
        {        
            List<decimal> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumdecimalList100MapNull()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<decimal,decimal>((decimal) arg, (decimal) arg)).ToList();
            Func<KeyValuePair<decimal, decimal>, decimal> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumdecimalIList100()
        {
            var source = ZEnumerable.Repeat((decimal) 1, 100).ToIList();
            decimal SumActual = ZEnumerable.Sum(source);
            decimal SumExpected = (decimal) Enumerable.Sum(source.Select(x=> (double)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdecimalIList100Map()
        {
            var source = ZEnumerable.Repeat(new { X = (decimal) 1 } , 100).ToIList();
            decimal SumActual = ZEnumerable.Sum(source, arg => arg.X);
            decimal SumExpected = (decimal) Enumerable.Sum(source, arg => (double) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumdecimalIList100Null()
        {        
            IList<decimal> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumdecimalIList100MapNull()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<decimal,decimal>((decimal) arg, (decimal) arg)).ToIList();
            Func<KeyValuePair<decimal, decimal>, decimal> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
                
        #endregion
            #region ulong             
            
        
        [TestMethod]
        public void TestSumulongArray100()
        {
            var source = ZEnumerable.Repeat((ulong) 1, 100).ToArray();
            ulong SumActual = ZEnumerable.Sum(source);
            ulong SumExpected = (ulong) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumulongArray100Map()
        {
            var source = ZEnumerable.Repeat(new { X = (ulong) 1 } , 100).ToArray();
            ulong SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ulong SumExpected = (ulong) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumulongArray100Null()
        {        
            ulong[] nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumulongArray100MapNull()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<ulong,ulong>((ulong) arg, (ulong) arg)).ToArray();
            Func<KeyValuePair<ulong, ulong>, ulong> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumulongList100()
        {
            var source = ZEnumerable.Repeat((ulong) 1, 100).ToList();
            ulong SumActual = ZEnumerable.Sum(source);
            ulong SumExpected = (ulong) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumulongList100Map()
        {
            var source = ZEnumerable.Repeat(new { X = (ulong) 1 } , 100).ToList();
            ulong SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ulong SumExpected = (ulong) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumulongList100Null()
        {        
            List<ulong> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumulongList100MapNull()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<ulong,ulong>((ulong) arg, (ulong) arg)).ToList();
            Func<KeyValuePair<ulong, ulong>, ulong> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumulongIList100()
        {
            var source = ZEnumerable.Repeat((ulong) 1, 100).ToIList();
            ulong SumActual = ZEnumerable.Sum(source);
            ulong SumExpected = (ulong) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumulongIList100Map()
        {
            var source = ZEnumerable.Repeat(new { X = (ulong) 1 } , 100).ToIList();
            ulong SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ulong SumExpected = (ulong) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumulongIList100Null()
        {        
            IList<ulong> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumulongIList100MapNull()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<ulong,ulong>((ulong) arg, (ulong) arg)).ToIList();
            Func<KeyValuePair<ulong, ulong>, ulong> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
                
        #endregion
            #region sbyte?             
            
        
        [TestMethod]
        public void TestSumsbyteNullableArray100()
        {
            var source = ZEnumerable.Repeat((sbyte?) 1, 100).ToArray();
            sbyte? SumActual = ZEnumerable.Sum(source);
            sbyte? SumExpected = (sbyte?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumsbyteNullableArray100Map()
        {
            var source = ZEnumerable.Repeat(new { X = (sbyte?) 1 } , 100).ToArray();
            sbyte? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            sbyte? SumExpected = (sbyte?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumsbyteNullableArray100Null()
        {        
            sbyte?[] nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumsbyteNullableArray100MapNull()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<sbyte?,sbyte?>((sbyte?) arg, (sbyte?) arg)).ToArray();
            Func<KeyValuePair<sbyte?, sbyte?>, sbyte?> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumsbyteNullableList100()
        {
            var source = ZEnumerable.Repeat((sbyte?) 1, 100).ToList();
            sbyte? SumActual = ZEnumerable.Sum(source);
            sbyte? SumExpected = (sbyte?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumsbyteNullableList100Map()
        {
            var source = ZEnumerable.Repeat(new { X = (sbyte?) 1 } , 100).ToList();
            sbyte? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            sbyte? SumExpected = (sbyte?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumsbyteNullableList100Null()
        {        
            List<sbyte?> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumsbyteNullableList100MapNull()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<sbyte?,sbyte?>((sbyte?) arg, (sbyte?) arg)).ToList();
            Func<KeyValuePair<sbyte?, sbyte?>, sbyte?> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumsbyteNullableIList100()
        {
            var source = ZEnumerable.Repeat((sbyte?) 1, 100).ToIList();
            sbyte? SumActual = ZEnumerable.Sum(source);
            sbyte? SumExpected = (sbyte?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumsbyteNullableIList100Map()
        {
            var source = ZEnumerable.Repeat(new { X = (sbyte?) 1 } , 100).ToIList();
            sbyte? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            sbyte? SumExpected = (sbyte?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumsbyteNullableIList100Null()
        {        
            IList<sbyte?> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumsbyteNullableIList100MapNull()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<sbyte?,sbyte?>((sbyte?) arg, (sbyte?) arg)).ToIList();
            Func<KeyValuePair<sbyte?, sbyte?>, sbyte?> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
                
        #endregion
            #region byte?             
            
        
        [TestMethod]
        public void TestSumbyteNullableArray100()
        {
            var source = ZEnumerable.Repeat((byte?) 1, 100).ToArray();
            byte? SumActual = ZEnumerable.Sum(source);
            byte? SumExpected = (byte?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumbyteNullableArray100Map()
        {
            var source = ZEnumerable.Repeat(new { X = (byte?) 1 } , 100).ToArray();
            byte? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            byte? SumExpected = (byte?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumbyteNullableArray100Null()
        {        
            byte?[] nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumbyteNullableArray100MapNull()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<byte?,byte?>((byte?) arg, (byte?) arg)).ToArray();
            Func<KeyValuePair<byte?, byte?>, byte?> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumbyteNullableList100()
        {
            var source = ZEnumerable.Repeat((byte?) 1, 100).ToList();
            byte? SumActual = ZEnumerable.Sum(source);
            byte? SumExpected = (byte?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumbyteNullableList100Map()
        {
            var source = ZEnumerable.Repeat(new { X = (byte?) 1 } , 100).ToList();
            byte? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            byte? SumExpected = (byte?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumbyteNullableList100Null()
        {        
            List<byte?> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumbyteNullableList100MapNull()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<byte?,byte?>((byte?) arg, (byte?) arg)).ToList();
            Func<KeyValuePair<byte?, byte?>, byte?> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumbyteNullableIList100()
        {
            var source = ZEnumerable.Repeat((byte?) 1, 100).ToIList();
            byte? SumActual = ZEnumerable.Sum(source);
            byte? SumExpected = (byte?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumbyteNullableIList100Map()
        {
            var source = ZEnumerable.Repeat(new { X = (byte?) 1 } , 100).ToIList();
            byte? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            byte? SumExpected = (byte?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumbyteNullableIList100Null()
        {        
            IList<byte?> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumbyteNullableIList100MapNull()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<byte?,byte?>((byte?) arg, (byte?) arg)).ToIList();
            Func<KeyValuePair<byte?, byte?>, byte?> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
                
        #endregion
            #region short?             
            
        
        [TestMethod]
        public void TestSumshortNullableArray100()
        {
            var source = ZEnumerable.Repeat((short?) 1, 100).ToArray();
            short? SumActual = ZEnumerable.Sum(source);
            short? SumExpected = (short?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumshortNullableArray100Map()
        {
            var source = ZEnumerable.Repeat(new { X = (short?) 1 } , 100).ToArray();
            short? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            short? SumExpected = (short?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumshortNullableArray100Null()
        {        
            short?[] nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumshortNullableArray100MapNull()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<short?,short?>((short?) arg, (short?) arg)).ToArray();
            Func<KeyValuePair<short?, short?>, short?> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumshortNullableList100()
        {
            var source = ZEnumerable.Repeat((short?) 1, 100).ToList();
            short? SumActual = ZEnumerable.Sum(source);
            short? SumExpected = (short?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumshortNullableList100Map()
        {
            var source = ZEnumerable.Repeat(new { X = (short?) 1 } , 100).ToList();
            short? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            short? SumExpected = (short?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumshortNullableList100Null()
        {        
            List<short?> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumshortNullableList100MapNull()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<short?,short?>((short?) arg, (short?) arg)).ToList();
            Func<KeyValuePair<short?, short?>, short?> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumshortNullableIList100()
        {
            var source = ZEnumerable.Repeat((short?) 1, 100).ToIList();
            short? SumActual = ZEnumerable.Sum(source);
            short? SumExpected = (short?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumshortNullableIList100Map()
        {
            var source = ZEnumerable.Repeat(new { X = (short?) 1 } , 100).ToIList();
            short? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            short? SumExpected = (short?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumshortNullableIList100Null()
        {        
            IList<short?> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumshortNullableIList100MapNull()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<short?,short?>((short?) arg, (short?) arg)).ToIList();
            Func<KeyValuePair<short?, short?>, short?> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
                
        #endregion
            #region ushort?             
            
        
        [TestMethod]
        public void TestSumushortNullableArray100()
        {
            var source = ZEnumerable.Repeat((ushort?) 1, 100).ToArray();
            ushort? SumActual = ZEnumerable.Sum(source);
            ushort? SumExpected = (ushort?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumushortNullableArray100Map()
        {
            var source = ZEnumerable.Repeat(new { X = (ushort?) 1 } , 100).ToArray();
            ushort? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ushort? SumExpected = (ushort?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumushortNullableArray100Null()
        {        
            ushort?[] nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumushortNullableArray100MapNull()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<ushort?,ushort?>((ushort?) arg, (ushort?) arg)).ToArray();
            Func<KeyValuePair<ushort?, ushort?>, ushort?> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumushortNullableList100()
        {
            var source = ZEnumerable.Repeat((ushort?) 1, 100).ToList();
            ushort? SumActual = ZEnumerable.Sum(source);
            ushort? SumExpected = (ushort?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumushortNullableList100Map()
        {
            var source = ZEnumerable.Repeat(new { X = (ushort?) 1 } , 100).ToList();
            ushort? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ushort? SumExpected = (ushort?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumushortNullableList100Null()
        {        
            List<ushort?> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumushortNullableList100MapNull()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<ushort?,ushort?>((ushort?) arg, (ushort?) arg)).ToList();
            Func<KeyValuePair<ushort?, ushort?>, ushort?> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumushortNullableIList100()
        {
            var source = ZEnumerable.Repeat((ushort?) 1, 100).ToIList();
            ushort? SumActual = ZEnumerable.Sum(source);
            ushort? SumExpected = (ushort?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumushortNullableIList100Map()
        {
            var source = ZEnumerable.Repeat(new { X = (ushort?) 1 } , 100).ToIList();
            ushort? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ushort? SumExpected = (ushort?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumushortNullableIList100Null()
        {        
            IList<ushort?> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumushortNullableIList100MapNull()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<ushort?,ushort?>((ushort?) arg, (ushort?) arg)).ToIList();
            Func<KeyValuePair<ushort?, ushort?>, ushort?> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
                
        #endregion
            #region int?             
            
        
        [TestMethod]
        public void TestSumintNullableArray100()
        {
            var source = ZEnumerable.Repeat((int?) 1, 100).ToArray();
            int? SumActual = ZEnumerable.Sum(source);
            int? SumExpected = (int?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumintNullableArray100Map()
        {
            var source = ZEnumerable.Repeat(new { X = (int?) 1 } , 100).ToArray();
            int? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            int? SumExpected = (int?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumintNullableArray100Null()
        {        
            int?[] nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumintNullableArray100MapNull()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<int?,int?>((int?) arg, (int?) arg)).ToArray();
            Func<KeyValuePair<int?, int?>, int?> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumintNullableList100()
        {
            var source = ZEnumerable.Repeat((int?) 1, 100).ToList();
            int? SumActual = ZEnumerable.Sum(source);
            int? SumExpected = (int?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumintNullableList100Map()
        {
            var source = ZEnumerable.Repeat(new { X = (int?) 1 } , 100).ToList();
            int? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            int? SumExpected = (int?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumintNullableList100Null()
        {        
            List<int?> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumintNullableList100MapNull()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<int?,int?>((int?) arg, (int?) arg)).ToList();
            Func<KeyValuePair<int?, int?>, int?> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumintNullableIList100()
        {
            var source = ZEnumerable.Repeat((int?) 1, 100).ToIList();
            int? SumActual = ZEnumerable.Sum(source);
            int? SumExpected = (int?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumintNullableIList100Map()
        {
            var source = ZEnumerable.Repeat(new { X = (int?) 1 } , 100).ToIList();
            int? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            int? SumExpected = (int?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumintNullableIList100Null()
        {        
            IList<int?> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumintNullableIList100MapNull()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<int?,int?>((int?) arg, (int?) arg)).ToIList();
            Func<KeyValuePair<int?, int?>, int?> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
                
        #endregion
            #region uint?             
            
        
        [TestMethod]
        public void TestSumuintNullableArray100()
        {
            var source = ZEnumerable.Repeat((uint?) 1, 100).ToArray();
            uint? SumActual = ZEnumerable.Sum(source);
            uint? SumExpected = (uint?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumuintNullableArray100Map()
        {
            var source = ZEnumerable.Repeat(new { X = (uint?) 1 } , 100).ToArray();
            uint? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            uint? SumExpected = (uint?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumuintNullableArray100Null()
        {        
            uint?[] nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumuintNullableArray100MapNull()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<uint?,uint?>((uint?) arg, (uint?) arg)).ToArray();
            Func<KeyValuePair<uint?, uint?>, uint?> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumuintNullableList100()
        {
            var source = ZEnumerable.Repeat((uint?) 1, 100).ToList();
            uint? SumActual = ZEnumerable.Sum(source);
            uint? SumExpected = (uint?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumuintNullableList100Map()
        {
            var source = ZEnumerable.Repeat(new { X = (uint?) 1 } , 100).ToList();
            uint? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            uint? SumExpected = (uint?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumuintNullableList100Null()
        {        
            List<uint?> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumuintNullableList100MapNull()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<uint?,uint?>((uint?) arg, (uint?) arg)).ToList();
            Func<KeyValuePair<uint?, uint?>, uint?> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumuintNullableIList100()
        {
            var source = ZEnumerable.Repeat((uint?) 1, 100).ToIList();
            uint? SumActual = ZEnumerable.Sum(source);
            uint? SumExpected = (uint?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumuintNullableIList100Map()
        {
            var source = ZEnumerable.Repeat(new { X = (uint?) 1 } , 100).ToIList();
            uint? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            uint? SumExpected = (uint?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumuintNullableIList100Null()
        {        
            IList<uint?> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumuintNullableIList100MapNull()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<uint?,uint?>((uint?) arg, (uint?) arg)).ToIList();
            Func<KeyValuePair<uint?, uint?>, uint?> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
                
        #endregion
            #region long?             
            
        
        [TestMethod]
        public void TestSumlongNullableArray100()
        {
            var source = ZEnumerable.Repeat((long?) 1, 100).ToArray();
            long? SumActual = ZEnumerable.Sum(source);
            long? SumExpected = (long?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumlongNullableArray100Map()
        {
            var source = ZEnumerable.Repeat(new { X = (long?) 1 } , 100).ToArray();
            long? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            long? SumExpected = (long?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumlongNullableArray100Null()
        {        
            long?[] nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumlongNullableArray100MapNull()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<long?,long?>((long?) arg, (long?) arg)).ToArray();
            Func<KeyValuePair<long?, long?>, long?> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumlongNullableList100()
        {
            var source = ZEnumerable.Repeat((long?) 1, 100).ToList();
            long? SumActual = ZEnumerable.Sum(source);
            long? SumExpected = (long?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumlongNullableList100Map()
        {
            var source = ZEnumerable.Repeat(new { X = (long?) 1 } , 100).ToList();
            long? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            long? SumExpected = (long?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumlongNullableList100Null()
        {        
            List<long?> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumlongNullableList100MapNull()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<long?,long?>((long?) arg, (long?) arg)).ToList();
            Func<KeyValuePair<long?, long?>, long?> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumlongNullableIList100()
        {
            var source = ZEnumerable.Repeat((long?) 1, 100).ToIList();
            long? SumActual = ZEnumerable.Sum(source);
            long? SumExpected = (long?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumlongNullableIList100Map()
        {
            var source = ZEnumerable.Repeat(new { X = (long?) 1 } , 100).ToIList();
            long? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            long? SumExpected = (long?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumlongNullableIList100Null()
        {        
            IList<long?> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumlongNullableIList100MapNull()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<long?,long?>((long?) arg, (long?) arg)).ToIList();
            Func<KeyValuePair<long?, long?>, long?> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
                
        #endregion
            #region float?             
            
        
        [TestMethod]
        public void TestSumfloatNullableArray100()
        {
            var source = ZEnumerable.Repeat((float?) 1, 100).ToArray();
            float? SumActual = ZEnumerable.Sum(source);
            float? SumExpected = (float?) Enumerable.Sum(source.Select(x=> (double?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumfloatNullableArray100Map()
        {
            var source = ZEnumerable.Repeat(new { X = (float?) 1 } , 100).ToArray();
            float? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            float? SumExpected = (float?) Enumerable.Sum(source, arg => (double?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumfloatNullableArray100Null()
        {        
            float?[] nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumfloatNullableArray100MapNull()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<float?,float?>((float?) arg, (float?) arg)).ToArray();
            Func<KeyValuePair<float?, float?>, float?> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumfloatNullableList100()
        {
            var source = ZEnumerable.Repeat((float?) 1, 100).ToList();
            float? SumActual = ZEnumerable.Sum(source);
            float? SumExpected = (float?) Enumerable.Sum(source.Select(x=> (double?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumfloatNullableList100Map()
        {
            var source = ZEnumerable.Repeat(new { X = (float?) 1 } , 100).ToList();
            float? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            float? SumExpected = (float?) Enumerable.Sum(source, arg => (double?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumfloatNullableList100Null()
        {        
            List<float?> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumfloatNullableList100MapNull()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<float?,float?>((float?) arg, (float?) arg)).ToList();
            Func<KeyValuePair<float?, float?>, float?> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumfloatNullableIList100()
        {
            var source = ZEnumerable.Repeat((float?) 1, 100).ToIList();
            float? SumActual = ZEnumerable.Sum(source);
            float? SumExpected = (float?) Enumerable.Sum(source.Select(x=> (double?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumfloatNullableIList100Map()
        {
            var source = ZEnumerable.Repeat(new { X = (float?) 1 } , 100).ToIList();
            float? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            float? SumExpected = (float?) Enumerable.Sum(source, arg => (double?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumfloatNullableIList100Null()
        {        
            IList<float?> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumfloatNullableIList100MapNull()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<float?,float?>((float?) arg, (float?) arg)).ToIList();
            Func<KeyValuePair<float?, float?>, float?> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
                
        #endregion
            #region double?             
            
        
        [TestMethod]
        public void TestSumdoubleNullableArray100()
        {
            var source = ZEnumerable.Repeat((double?) 1, 100).ToArray();
            double? SumActual = ZEnumerable.Sum(source);
            double? SumExpected = (double?) Enumerable.Sum(source.Select(x=> (double?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdoubleNullableArray100Map()
        {
            var source = ZEnumerable.Repeat(new { X = (double?) 1 } , 100).ToArray();
            double? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            double? SumExpected = (double?) Enumerable.Sum(source, arg => (double?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumdoubleNullableArray100Null()
        {        
            double?[] nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumdoubleNullableArray100MapNull()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<double?,double?>((double?) arg, (double?) arg)).ToArray();
            Func<KeyValuePair<double?, double?>, double?> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumdoubleNullableList100()
        {
            var source = ZEnumerable.Repeat((double?) 1, 100).ToList();
            double? SumActual = ZEnumerable.Sum(source);
            double? SumExpected = (double?) Enumerable.Sum(source.Select(x=> (double?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdoubleNullableList100Map()
        {
            var source = ZEnumerable.Repeat(new { X = (double?) 1 } , 100).ToList();
            double? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            double? SumExpected = (double?) Enumerable.Sum(source, arg => (double?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumdoubleNullableList100Null()
        {        
            List<double?> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumdoubleNullableList100MapNull()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<double?,double?>((double?) arg, (double?) arg)).ToList();
            Func<KeyValuePair<double?, double?>, double?> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumdoubleNullableIList100()
        {
            var source = ZEnumerable.Repeat((double?) 1, 100).ToIList();
            double? SumActual = ZEnumerable.Sum(source);
            double? SumExpected = (double?) Enumerable.Sum(source.Select(x=> (double?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdoubleNullableIList100Map()
        {
            var source = ZEnumerable.Repeat(new { X = (double?) 1 } , 100).ToIList();
            double? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            double? SumExpected = (double?) Enumerable.Sum(source, arg => (double?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumdoubleNullableIList100Null()
        {        
            IList<double?> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumdoubleNullableIList100MapNull()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<double?,double?>((double?) arg, (double?) arg)).ToIList();
            Func<KeyValuePair<double?, double?>, double?> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
                
        #endregion
            #region decimal?             
            
        
        [TestMethod]
        public void TestSumdecimalNullableArray100()
        {
            var source = ZEnumerable.Repeat((decimal?) 1, 100).ToArray();
            decimal? SumActual = ZEnumerable.Sum(source);
            decimal? SumExpected = (decimal?) Enumerable.Sum(source.Select(x=> (double?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdecimalNullableArray100Map()
        {
            var source = ZEnumerable.Repeat(new { X = (decimal?) 1 } , 100).ToArray();
            decimal? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            decimal? SumExpected = (decimal?) Enumerable.Sum(source, arg => (double?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumdecimalNullableArray100Null()
        {        
            decimal?[] nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumdecimalNullableArray100MapNull()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<decimal?,decimal?>((decimal?) arg, (decimal?) arg)).ToArray();
            Func<KeyValuePair<decimal?, decimal?>, decimal?> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumdecimalNullableList100()
        {
            var source = ZEnumerable.Repeat((decimal?) 1, 100).ToList();
            decimal? SumActual = ZEnumerable.Sum(source);
            decimal? SumExpected = (decimal?) Enumerable.Sum(source.Select(x=> (double?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdecimalNullableList100Map()
        {
            var source = ZEnumerable.Repeat(new { X = (decimal?) 1 } , 100).ToList();
            decimal? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            decimal? SumExpected = (decimal?) Enumerable.Sum(source, arg => (double?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumdecimalNullableList100Null()
        {        
            List<decimal?> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumdecimalNullableList100MapNull()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<decimal?,decimal?>((decimal?) arg, (decimal?) arg)).ToList();
            Func<KeyValuePair<decimal?, decimal?>, decimal?> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumdecimalNullableIList100()
        {
            var source = ZEnumerable.Repeat((decimal?) 1, 100).ToIList();
            decimal? SumActual = ZEnumerable.Sum(source);
            decimal? SumExpected = (decimal?) Enumerable.Sum(source.Select(x=> (double?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdecimalNullableIList100Map()
        {
            var source = ZEnumerable.Repeat(new { X = (decimal?) 1 } , 100).ToIList();
            decimal? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            decimal? SumExpected = (decimal?) Enumerable.Sum(source, arg => (double?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumdecimalNullableIList100Null()
        {        
            IList<decimal?> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumdecimalNullableIList100MapNull()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<decimal?,decimal?>((decimal?) arg, (decimal?) arg)).ToIList();
            Func<KeyValuePair<decimal?, decimal?>, decimal?> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
                
        #endregion
            #region ulong?             
            
        
        [TestMethod]
        public void TestSumulongNullableArray100()
        {
            var source = ZEnumerable.Repeat((ulong?) 1, 100).ToArray();
            ulong? SumActual = ZEnumerable.Sum(source);
            ulong? SumExpected = (ulong?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumulongNullableArray100Map()
        {
            var source = ZEnumerable.Repeat(new { X = (ulong?) 1 } , 100).ToArray();
            ulong? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ulong? SumExpected = (ulong?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumulongNullableArray100Null()
        {        
            ulong?[] nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumulongNullableArray100MapNull()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<ulong?,ulong?>((ulong?) arg, (ulong?) arg)).ToArray();
            Func<KeyValuePair<ulong?, ulong?>, ulong?> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumulongNullableList100()
        {
            var source = ZEnumerable.Repeat((ulong?) 1, 100).ToList();
            ulong? SumActual = ZEnumerable.Sum(source);
            ulong? SumExpected = (ulong?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumulongNullableList100Map()
        {
            var source = ZEnumerable.Repeat(new { X = (ulong?) 1 } , 100).ToList();
            ulong? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ulong? SumExpected = (ulong?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumulongNullableList100Null()
        {        
            List<ulong?> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumulongNullableList100MapNull()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<ulong?,ulong?>((ulong?) arg, (ulong?) arg)).ToList();
            Func<KeyValuePair<ulong?, ulong?>, ulong?> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumulongNullableIList100()
        {
            var source = ZEnumerable.Repeat((ulong?) 1, 100).ToIList();
            ulong? SumActual = ZEnumerable.Sum(source);
            ulong? SumExpected = (ulong?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumulongNullableIList100Map()
        {
            var source = ZEnumerable.Repeat(new { X = (ulong?) 1 } , 100).ToIList();
            ulong? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ulong? SumExpected = (ulong?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumulongNullableIList100Null()
        {        
            IList<ulong?> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumulongNullableIList100MapNull()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<ulong?,ulong?>((ulong?) arg, (ulong?) arg)).ToIList();
            Func<KeyValuePair<ulong?, ulong?>, ulong?> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
                
        #endregion
        


    
                
            #region sbyte             
            
            
        [TestMethod]
        public void TestSumsbyteArray2049Null()
        {        
            sbyte[] nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumsbyteArray2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<sbyte,sbyte>((sbyte) arg, (sbyte) arg)).ToArray();
            Func<KeyValuePair<sbyte, sbyte>, sbyte> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
            
        [TestMethod]
        public void TestSumsbyteList2049Null()
        {        
            List<sbyte> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumsbyteList2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<sbyte,sbyte>((sbyte) arg, (sbyte) arg)).ToList();
            Func<KeyValuePair<sbyte, sbyte>, sbyte> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
            
        [TestMethod]
        public void TestSumsbyteIList2049Null()
        {        
            IList<sbyte> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumsbyteIList2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<sbyte,sbyte>((sbyte) arg, (sbyte) arg)).ToIList();
            Func<KeyValuePair<sbyte, sbyte>, sbyte> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
                
        #endregion
            #region byte             
            
            
        [TestMethod]
        public void TestSumbyteArray2049Null()
        {        
            byte[] nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumbyteArray2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<byte,byte>((byte) arg, (byte) arg)).ToArray();
            Func<KeyValuePair<byte, byte>, byte> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
            
        [TestMethod]
        public void TestSumbyteList2049Null()
        {        
            List<byte> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumbyteList2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<byte,byte>((byte) arg, (byte) arg)).ToList();
            Func<KeyValuePair<byte, byte>, byte> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
            
        [TestMethod]
        public void TestSumbyteIList2049Null()
        {        
            IList<byte> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumbyteIList2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<byte,byte>((byte) arg, (byte) arg)).ToIList();
            Func<KeyValuePair<byte, byte>, byte> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
                
        #endregion
            #region short             
            
        
        [TestMethod]
        public void TestSumshortArray2049()
        {
            var source = ZEnumerable.Repeat((short) 1, 2049).ToArray();
            short SumActual = ZEnumerable.Sum(source);
            short SumExpected = (short) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumshortArray2049Map()
        {
            var source = ZEnumerable.Repeat(new { X = (short) 1 } , 2049).ToArray();
            short SumActual = ZEnumerable.Sum(source, arg => arg.X);
            short SumExpected = (short) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumshortArray2049Null()
        {        
            short[] nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumshortArray2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<short,short>((short) arg, (short) arg)).ToArray();
            Func<KeyValuePair<short, short>, short> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumshortList2049()
        {
            var source = ZEnumerable.Repeat((short) 1, 2049).ToList();
            short SumActual = ZEnumerable.Sum(source);
            short SumExpected = (short) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumshortList2049Map()
        {
            var source = ZEnumerable.Repeat(new { X = (short) 1 } , 2049).ToList();
            short SumActual = ZEnumerable.Sum(source, arg => arg.X);
            short SumExpected = (short) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumshortList2049Null()
        {        
            List<short> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumshortList2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<short,short>((short) arg, (short) arg)).ToList();
            Func<KeyValuePair<short, short>, short> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumshortIList2049()
        {
            var source = ZEnumerable.Repeat((short) 1, 2049).ToIList();
            short SumActual = ZEnumerable.Sum(source);
            short SumExpected = (short) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumshortIList2049Map()
        {
            var source = ZEnumerable.Repeat(new { X = (short) 1 } , 2049).ToIList();
            short SumActual = ZEnumerable.Sum(source, arg => arg.X);
            short SumExpected = (short) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumshortIList2049Null()
        {        
            IList<short> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumshortIList2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<short,short>((short) arg, (short) arg)).ToIList();
            Func<KeyValuePair<short, short>, short> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
                
        #endregion
            #region ushort             
            
        
        [TestMethod]
        public void TestSumushortArray2049()
        {
            var source = ZEnumerable.Repeat((ushort) 1, 2049).ToArray();
            ushort SumActual = ZEnumerable.Sum(source);
            ushort SumExpected = (ushort) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumushortArray2049Map()
        {
            var source = ZEnumerable.Repeat(new { X = (ushort) 1 } , 2049).ToArray();
            ushort SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ushort SumExpected = (ushort) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumushortArray2049Null()
        {        
            ushort[] nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumushortArray2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<ushort,ushort>((ushort) arg, (ushort) arg)).ToArray();
            Func<KeyValuePair<ushort, ushort>, ushort> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumushortList2049()
        {
            var source = ZEnumerable.Repeat((ushort) 1, 2049).ToList();
            ushort SumActual = ZEnumerable.Sum(source);
            ushort SumExpected = (ushort) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumushortList2049Map()
        {
            var source = ZEnumerable.Repeat(new { X = (ushort) 1 } , 2049).ToList();
            ushort SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ushort SumExpected = (ushort) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumushortList2049Null()
        {        
            List<ushort> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumushortList2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<ushort,ushort>((ushort) arg, (ushort) arg)).ToList();
            Func<KeyValuePair<ushort, ushort>, ushort> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumushortIList2049()
        {
            var source = ZEnumerable.Repeat((ushort) 1, 2049).ToIList();
            ushort SumActual = ZEnumerable.Sum(source);
            ushort SumExpected = (ushort) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumushortIList2049Map()
        {
            var source = ZEnumerable.Repeat(new { X = (ushort) 1 } , 2049).ToIList();
            ushort SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ushort SumExpected = (ushort) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumushortIList2049Null()
        {        
            IList<ushort> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumushortIList2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<ushort,ushort>((ushort) arg, (ushort) arg)).ToIList();
            Func<KeyValuePair<ushort, ushort>, ushort> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
                
        #endregion
            #region int             
            
        
        [TestMethod]
        public void TestSumintArray2049()
        {
            var source = ZEnumerable.Repeat((int) 1, 2049).ToArray();
            int SumActual = ZEnumerable.Sum(source);
            int SumExpected = (int) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumintArray2049Map()
        {
            var source = ZEnumerable.Repeat(new { X = (int) 1 } , 2049).ToArray();
            int SumActual = ZEnumerable.Sum(source, arg => arg.X);
            int SumExpected = (int) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumintArray2049Null()
        {        
            int[] nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumintArray2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<int,int>((int) arg, (int) arg)).ToArray();
            Func<KeyValuePair<int, int>, int> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumintList2049()
        {
            var source = ZEnumerable.Repeat((int) 1, 2049).ToList();
            int SumActual = ZEnumerable.Sum(source);
            int SumExpected = (int) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumintList2049Map()
        {
            var source = ZEnumerable.Repeat(new { X = (int) 1 } , 2049).ToList();
            int SumActual = ZEnumerable.Sum(source, arg => arg.X);
            int SumExpected = (int) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumintList2049Null()
        {        
            List<int> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumintList2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<int,int>((int) arg, (int) arg)).ToList();
            Func<KeyValuePair<int, int>, int> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumintIList2049()
        {
            var source = ZEnumerable.Repeat((int) 1, 2049).ToIList();
            int SumActual = ZEnumerable.Sum(source);
            int SumExpected = (int) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumintIList2049Map()
        {
            var source = ZEnumerable.Repeat(new { X = (int) 1 } , 2049).ToIList();
            int SumActual = ZEnumerable.Sum(source, arg => arg.X);
            int SumExpected = (int) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumintIList2049Null()
        {        
            IList<int> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumintIList2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<int,int>((int) arg, (int) arg)).ToIList();
            Func<KeyValuePair<int, int>, int> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
                
        #endregion
            #region uint             
            
        
        [TestMethod]
        public void TestSumuintArray2049()
        {
            var source = ZEnumerable.Repeat((uint) 1, 2049).ToArray();
            uint SumActual = ZEnumerable.Sum(source);
            uint SumExpected = (uint) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumuintArray2049Map()
        {
            var source = ZEnumerable.Repeat(new { X = (uint) 1 } , 2049).ToArray();
            uint SumActual = ZEnumerable.Sum(source, arg => arg.X);
            uint SumExpected = (uint) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumuintArray2049Null()
        {        
            uint[] nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumuintArray2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<uint,uint>((uint) arg, (uint) arg)).ToArray();
            Func<KeyValuePair<uint, uint>, uint> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumuintList2049()
        {
            var source = ZEnumerable.Repeat((uint) 1, 2049).ToList();
            uint SumActual = ZEnumerable.Sum(source);
            uint SumExpected = (uint) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumuintList2049Map()
        {
            var source = ZEnumerable.Repeat(new { X = (uint) 1 } , 2049).ToList();
            uint SumActual = ZEnumerable.Sum(source, arg => arg.X);
            uint SumExpected = (uint) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumuintList2049Null()
        {        
            List<uint> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumuintList2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<uint,uint>((uint) arg, (uint) arg)).ToList();
            Func<KeyValuePair<uint, uint>, uint> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumuintIList2049()
        {
            var source = ZEnumerable.Repeat((uint) 1, 2049).ToIList();
            uint SumActual = ZEnumerable.Sum(source);
            uint SumExpected = (uint) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumuintIList2049Map()
        {
            var source = ZEnumerable.Repeat(new { X = (uint) 1 } , 2049).ToIList();
            uint SumActual = ZEnumerable.Sum(source, arg => arg.X);
            uint SumExpected = (uint) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumuintIList2049Null()
        {        
            IList<uint> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumuintIList2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<uint,uint>((uint) arg, (uint) arg)).ToIList();
            Func<KeyValuePair<uint, uint>, uint> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
                
        #endregion
            #region long             
            
        
        [TestMethod]
        public void TestSumlongArray2049()
        {
            var source = ZEnumerable.Repeat((long) 1, 2049).ToArray();
            long SumActual = ZEnumerable.Sum(source);
            long SumExpected = (long) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumlongArray2049Map()
        {
            var source = ZEnumerable.Repeat(new { X = (long) 1 } , 2049).ToArray();
            long SumActual = ZEnumerable.Sum(source, arg => arg.X);
            long SumExpected = (long) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumlongArray2049Null()
        {        
            long[] nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumlongArray2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<long,long>((long) arg, (long) arg)).ToArray();
            Func<KeyValuePair<long, long>, long> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumlongList2049()
        {
            var source = ZEnumerable.Repeat((long) 1, 2049).ToList();
            long SumActual = ZEnumerable.Sum(source);
            long SumExpected = (long) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumlongList2049Map()
        {
            var source = ZEnumerable.Repeat(new { X = (long) 1 } , 2049).ToList();
            long SumActual = ZEnumerable.Sum(source, arg => arg.X);
            long SumExpected = (long) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumlongList2049Null()
        {        
            List<long> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumlongList2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<long,long>((long) arg, (long) arg)).ToList();
            Func<KeyValuePair<long, long>, long> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumlongIList2049()
        {
            var source = ZEnumerable.Repeat((long) 1, 2049).ToIList();
            long SumActual = ZEnumerable.Sum(source);
            long SumExpected = (long) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumlongIList2049Map()
        {
            var source = ZEnumerable.Repeat(new { X = (long) 1 } , 2049).ToIList();
            long SumActual = ZEnumerable.Sum(source, arg => arg.X);
            long SumExpected = (long) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumlongIList2049Null()
        {        
            IList<long> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumlongIList2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<long,long>((long) arg, (long) arg)).ToIList();
            Func<KeyValuePair<long, long>, long> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
                
        #endregion
            #region float             
            
        
        [TestMethod]
        public void TestSumfloatArray2049()
        {
            var source = ZEnumerable.Repeat((float) 1, 2049).ToArray();
            float SumActual = ZEnumerable.Sum(source);
            float SumExpected = (float) Enumerable.Sum(source.Select(x=> (double)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumfloatArray2049Map()
        {
            var source = ZEnumerable.Repeat(new { X = (float) 1 } , 2049).ToArray();
            float SumActual = ZEnumerable.Sum(source, arg => arg.X);
            float SumExpected = (float) Enumerable.Sum(source, arg => (double) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumfloatArray2049Null()
        {        
            float[] nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumfloatArray2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<float,float>((float) arg, (float) arg)).ToArray();
            Func<KeyValuePair<float, float>, float> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumfloatList2049()
        {
            var source = ZEnumerable.Repeat((float) 1, 2049).ToList();
            float SumActual = ZEnumerable.Sum(source);
            float SumExpected = (float) Enumerable.Sum(source.Select(x=> (double)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumfloatList2049Map()
        {
            var source = ZEnumerable.Repeat(new { X = (float) 1 } , 2049).ToList();
            float SumActual = ZEnumerable.Sum(source, arg => arg.X);
            float SumExpected = (float) Enumerable.Sum(source, arg => (double) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumfloatList2049Null()
        {        
            List<float> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumfloatList2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<float,float>((float) arg, (float) arg)).ToList();
            Func<KeyValuePair<float, float>, float> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumfloatIList2049()
        {
            var source = ZEnumerable.Repeat((float) 1, 2049).ToIList();
            float SumActual = ZEnumerable.Sum(source);
            float SumExpected = (float) Enumerable.Sum(source.Select(x=> (double)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumfloatIList2049Map()
        {
            var source = ZEnumerable.Repeat(new { X = (float) 1 } , 2049).ToIList();
            float SumActual = ZEnumerable.Sum(source, arg => arg.X);
            float SumExpected = (float) Enumerable.Sum(source, arg => (double) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumfloatIList2049Null()
        {        
            IList<float> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumfloatIList2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<float,float>((float) arg, (float) arg)).ToIList();
            Func<KeyValuePair<float, float>, float> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
                
        #endregion
            #region double             
            
        
        [TestMethod]
        public void TestSumdoubleArray2049()
        {
            var source = ZEnumerable.Repeat((double) 1, 2049).ToArray();
            double SumActual = ZEnumerable.Sum(source);
            double SumExpected = (double) Enumerable.Sum(source.Select(x=> (double)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdoubleArray2049Map()
        {
            var source = ZEnumerable.Repeat(new { X = (double) 1 } , 2049).ToArray();
            double SumActual = ZEnumerable.Sum(source, arg => arg.X);
            double SumExpected = (double) Enumerable.Sum(source, arg => (double) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumdoubleArray2049Null()
        {        
            double[] nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumdoubleArray2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<double,double>((double) arg, (double) arg)).ToArray();
            Func<KeyValuePair<double, double>, double> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumdoubleList2049()
        {
            var source = ZEnumerable.Repeat((double) 1, 2049).ToList();
            double SumActual = ZEnumerable.Sum(source);
            double SumExpected = (double) Enumerable.Sum(source.Select(x=> (double)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdoubleList2049Map()
        {
            var source = ZEnumerable.Repeat(new { X = (double) 1 } , 2049).ToList();
            double SumActual = ZEnumerable.Sum(source, arg => arg.X);
            double SumExpected = (double) Enumerable.Sum(source, arg => (double) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumdoubleList2049Null()
        {        
            List<double> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumdoubleList2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<double,double>((double) arg, (double) arg)).ToList();
            Func<KeyValuePair<double, double>, double> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumdoubleIList2049()
        {
            var source = ZEnumerable.Repeat((double) 1, 2049).ToIList();
            double SumActual = ZEnumerable.Sum(source);
            double SumExpected = (double) Enumerable.Sum(source.Select(x=> (double)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdoubleIList2049Map()
        {
            var source = ZEnumerable.Repeat(new { X = (double) 1 } , 2049).ToIList();
            double SumActual = ZEnumerable.Sum(source, arg => arg.X);
            double SumExpected = (double) Enumerable.Sum(source, arg => (double) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumdoubleIList2049Null()
        {        
            IList<double> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumdoubleIList2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<double,double>((double) arg, (double) arg)).ToIList();
            Func<KeyValuePair<double, double>, double> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
                
        #endregion
            #region decimal             
            
        
        [TestMethod]
        public void TestSumdecimalArray2049()
        {
            var source = ZEnumerable.Repeat((decimal) 1, 2049).ToArray();
            decimal SumActual = ZEnumerable.Sum(source);
            decimal SumExpected = (decimal) Enumerable.Sum(source.Select(x=> (double)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdecimalArray2049Map()
        {
            var source = ZEnumerable.Repeat(new { X = (decimal) 1 } , 2049).ToArray();
            decimal SumActual = ZEnumerable.Sum(source, arg => arg.X);
            decimal SumExpected = (decimal) Enumerable.Sum(source, arg => (double) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumdecimalArray2049Null()
        {        
            decimal[] nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumdecimalArray2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<decimal,decimal>((decimal) arg, (decimal) arg)).ToArray();
            Func<KeyValuePair<decimal, decimal>, decimal> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumdecimalList2049()
        {
            var source = ZEnumerable.Repeat((decimal) 1, 2049).ToList();
            decimal SumActual = ZEnumerable.Sum(source);
            decimal SumExpected = (decimal) Enumerable.Sum(source.Select(x=> (double)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdecimalList2049Map()
        {
            var source = ZEnumerable.Repeat(new { X = (decimal) 1 } , 2049).ToList();
            decimal SumActual = ZEnumerable.Sum(source, arg => arg.X);
            decimal SumExpected = (decimal) Enumerable.Sum(source, arg => (double) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumdecimalList2049Null()
        {        
            List<decimal> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumdecimalList2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<decimal,decimal>((decimal) arg, (decimal) arg)).ToList();
            Func<KeyValuePair<decimal, decimal>, decimal> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumdecimalIList2049()
        {
            var source = ZEnumerable.Repeat((decimal) 1, 2049).ToIList();
            decimal SumActual = ZEnumerable.Sum(source);
            decimal SumExpected = (decimal) Enumerable.Sum(source.Select(x=> (double)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdecimalIList2049Map()
        {
            var source = ZEnumerable.Repeat(new { X = (decimal) 1 } , 2049).ToIList();
            decimal SumActual = ZEnumerable.Sum(source, arg => arg.X);
            decimal SumExpected = (decimal) Enumerable.Sum(source, arg => (double) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumdecimalIList2049Null()
        {        
            IList<decimal> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumdecimalIList2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<decimal,decimal>((decimal) arg, (decimal) arg)).ToIList();
            Func<KeyValuePair<decimal, decimal>, decimal> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
                
        #endregion
            #region ulong             
            
        
        [TestMethod]
        public void TestSumulongArray2049()
        {
            var source = ZEnumerable.Repeat((ulong) 1, 2049).ToArray();
            ulong SumActual = ZEnumerable.Sum(source);
            ulong SumExpected = (ulong) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumulongArray2049Map()
        {
            var source = ZEnumerable.Repeat(new { X = (ulong) 1 } , 2049).ToArray();
            ulong SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ulong SumExpected = (ulong) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumulongArray2049Null()
        {        
            ulong[] nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumulongArray2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<ulong,ulong>((ulong) arg, (ulong) arg)).ToArray();
            Func<KeyValuePair<ulong, ulong>, ulong> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumulongList2049()
        {
            var source = ZEnumerable.Repeat((ulong) 1, 2049).ToList();
            ulong SumActual = ZEnumerable.Sum(source);
            ulong SumExpected = (ulong) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumulongList2049Map()
        {
            var source = ZEnumerable.Repeat(new { X = (ulong) 1 } , 2049).ToList();
            ulong SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ulong SumExpected = (ulong) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumulongList2049Null()
        {        
            List<ulong> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumulongList2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<ulong,ulong>((ulong) arg, (ulong) arg)).ToList();
            Func<KeyValuePair<ulong, ulong>, ulong> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumulongIList2049()
        {
            var source = ZEnumerable.Repeat((ulong) 1, 2049).ToIList();
            ulong SumActual = ZEnumerable.Sum(source);
            ulong SumExpected = (ulong) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumulongIList2049Map()
        {
            var source = ZEnumerable.Repeat(new { X = (ulong) 1 } , 2049).ToIList();
            ulong SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ulong SumExpected = (ulong) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumulongIList2049Null()
        {        
            IList<ulong> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumulongIList2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<ulong,ulong>((ulong) arg, (ulong) arg)).ToIList();
            Func<KeyValuePair<ulong, ulong>, ulong> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
                
        #endregion
            #region sbyte?             
            
            
        [TestMethod]
        public void TestSumsbyteNullableArray2049Null()
        {        
            sbyte?[] nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumsbyteNullableArray2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<sbyte?,sbyte?>((sbyte?) arg, (sbyte?) arg)).ToArray();
            Func<KeyValuePair<sbyte?, sbyte?>, sbyte?> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
            
        [TestMethod]
        public void TestSumsbyteNullableList2049Null()
        {        
            List<sbyte?> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumsbyteNullableList2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<sbyte?,sbyte?>((sbyte?) arg, (sbyte?) arg)).ToList();
            Func<KeyValuePair<sbyte?, sbyte?>, sbyte?> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
            
        [TestMethod]
        public void TestSumsbyteNullableIList2049Null()
        {        
            IList<sbyte?> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumsbyteNullableIList2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<sbyte?,sbyte?>((sbyte?) arg, (sbyte?) arg)).ToIList();
            Func<KeyValuePair<sbyte?, sbyte?>, sbyte?> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
                
        #endregion
            #region byte?             
            
            
        [TestMethod]
        public void TestSumbyteNullableArray2049Null()
        {        
            byte?[] nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumbyteNullableArray2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<byte?,byte?>((byte?) arg, (byte?) arg)).ToArray();
            Func<KeyValuePair<byte?, byte?>, byte?> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
            
        [TestMethod]
        public void TestSumbyteNullableList2049Null()
        {        
            List<byte?> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumbyteNullableList2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<byte?,byte?>((byte?) arg, (byte?) arg)).ToList();
            Func<KeyValuePair<byte?, byte?>, byte?> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
            
        [TestMethod]
        public void TestSumbyteNullableIList2049Null()
        {        
            IList<byte?> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumbyteNullableIList2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<byte?,byte?>((byte?) arg, (byte?) arg)).ToIList();
            Func<KeyValuePair<byte?, byte?>, byte?> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
                
        #endregion
            #region short?             
            
        
        [TestMethod]
        public void TestSumshortNullableArray2049()
        {
            var source = ZEnumerable.Repeat((short?) 1, 2049).ToArray();
            short? SumActual = ZEnumerable.Sum(source);
            short? SumExpected = (short?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumshortNullableArray2049Map()
        {
            var source = ZEnumerable.Repeat(new { X = (short?) 1 } , 2049).ToArray();
            short? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            short? SumExpected = (short?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumshortNullableArray2049Null()
        {        
            short?[] nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumshortNullableArray2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<short?,short?>((short?) arg, (short?) arg)).ToArray();
            Func<KeyValuePair<short?, short?>, short?> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumshortNullableList2049()
        {
            var source = ZEnumerable.Repeat((short?) 1, 2049).ToList();
            short? SumActual = ZEnumerable.Sum(source);
            short? SumExpected = (short?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumshortNullableList2049Map()
        {
            var source = ZEnumerable.Repeat(new { X = (short?) 1 } , 2049).ToList();
            short? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            short? SumExpected = (short?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumshortNullableList2049Null()
        {        
            List<short?> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumshortNullableList2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<short?,short?>((short?) arg, (short?) arg)).ToList();
            Func<KeyValuePair<short?, short?>, short?> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumshortNullableIList2049()
        {
            var source = ZEnumerable.Repeat((short?) 1, 2049).ToIList();
            short? SumActual = ZEnumerable.Sum(source);
            short? SumExpected = (short?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumshortNullableIList2049Map()
        {
            var source = ZEnumerable.Repeat(new { X = (short?) 1 } , 2049).ToIList();
            short? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            short? SumExpected = (short?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumshortNullableIList2049Null()
        {        
            IList<short?> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumshortNullableIList2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<short?,short?>((short?) arg, (short?) arg)).ToIList();
            Func<KeyValuePair<short?, short?>, short?> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
                
        #endregion
            #region ushort?             
            
        
        [TestMethod]
        public void TestSumushortNullableArray2049()
        {
            var source = ZEnumerable.Repeat((ushort?) 1, 2049).ToArray();
            ushort? SumActual = ZEnumerable.Sum(source);
            ushort? SumExpected = (ushort?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumushortNullableArray2049Map()
        {
            var source = ZEnumerable.Repeat(new { X = (ushort?) 1 } , 2049).ToArray();
            ushort? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ushort? SumExpected = (ushort?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumushortNullableArray2049Null()
        {        
            ushort?[] nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumushortNullableArray2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<ushort?,ushort?>((ushort?) arg, (ushort?) arg)).ToArray();
            Func<KeyValuePair<ushort?, ushort?>, ushort?> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumushortNullableList2049()
        {
            var source = ZEnumerable.Repeat((ushort?) 1, 2049).ToList();
            ushort? SumActual = ZEnumerable.Sum(source);
            ushort? SumExpected = (ushort?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumushortNullableList2049Map()
        {
            var source = ZEnumerable.Repeat(new { X = (ushort?) 1 } , 2049).ToList();
            ushort? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ushort? SumExpected = (ushort?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumushortNullableList2049Null()
        {        
            List<ushort?> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumushortNullableList2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<ushort?,ushort?>((ushort?) arg, (ushort?) arg)).ToList();
            Func<KeyValuePair<ushort?, ushort?>, ushort?> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumushortNullableIList2049()
        {
            var source = ZEnumerable.Repeat((ushort?) 1, 2049).ToIList();
            ushort? SumActual = ZEnumerable.Sum(source);
            ushort? SumExpected = (ushort?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumushortNullableIList2049Map()
        {
            var source = ZEnumerable.Repeat(new { X = (ushort?) 1 } , 2049).ToIList();
            ushort? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ushort? SumExpected = (ushort?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumushortNullableIList2049Null()
        {        
            IList<ushort?> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumushortNullableIList2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<ushort?,ushort?>((ushort?) arg, (ushort?) arg)).ToIList();
            Func<KeyValuePair<ushort?, ushort?>, ushort?> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
                
        #endregion
            #region int?             
            
        
        [TestMethod]
        public void TestSumintNullableArray2049()
        {
            var source = ZEnumerable.Repeat((int?) 1, 2049).ToArray();
            int? SumActual = ZEnumerable.Sum(source);
            int? SumExpected = (int?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumintNullableArray2049Map()
        {
            var source = ZEnumerable.Repeat(new { X = (int?) 1 } , 2049).ToArray();
            int? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            int? SumExpected = (int?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumintNullableArray2049Null()
        {        
            int?[] nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumintNullableArray2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<int?,int?>((int?) arg, (int?) arg)).ToArray();
            Func<KeyValuePair<int?, int?>, int?> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumintNullableList2049()
        {
            var source = ZEnumerable.Repeat((int?) 1, 2049).ToList();
            int? SumActual = ZEnumerable.Sum(source);
            int? SumExpected = (int?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumintNullableList2049Map()
        {
            var source = ZEnumerable.Repeat(new { X = (int?) 1 } , 2049).ToList();
            int? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            int? SumExpected = (int?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumintNullableList2049Null()
        {        
            List<int?> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumintNullableList2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<int?,int?>((int?) arg, (int?) arg)).ToList();
            Func<KeyValuePair<int?, int?>, int?> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumintNullableIList2049()
        {
            var source = ZEnumerable.Repeat((int?) 1, 2049).ToIList();
            int? SumActual = ZEnumerable.Sum(source);
            int? SumExpected = (int?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumintNullableIList2049Map()
        {
            var source = ZEnumerable.Repeat(new { X = (int?) 1 } , 2049).ToIList();
            int? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            int? SumExpected = (int?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumintNullableIList2049Null()
        {        
            IList<int?> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumintNullableIList2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<int?,int?>((int?) arg, (int?) arg)).ToIList();
            Func<KeyValuePair<int?, int?>, int?> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
                
        #endregion
            #region uint?             
            
        
        [TestMethod]
        public void TestSumuintNullableArray2049()
        {
            var source = ZEnumerable.Repeat((uint?) 1, 2049).ToArray();
            uint? SumActual = ZEnumerable.Sum(source);
            uint? SumExpected = (uint?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumuintNullableArray2049Map()
        {
            var source = ZEnumerable.Repeat(new { X = (uint?) 1 } , 2049).ToArray();
            uint? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            uint? SumExpected = (uint?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumuintNullableArray2049Null()
        {        
            uint?[] nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumuintNullableArray2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<uint?,uint?>((uint?) arg, (uint?) arg)).ToArray();
            Func<KeyValuePair<uint?, uint?>, uint?> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumuintNullableList2049()
        {
            var source = ZEnumerable.Repeat((uint?) 1, 2049).ToList();
            uint? SumActual = ZEnumerable.Sum(source);
            uint? SumExpected = (uint?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumuintNullableList2049Map()
        {
            var source = ZEnumerable.Repeat(new { X = (uint?) 1 } , 2049).ToList();
            uint? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            uint? SumExpected = (uint?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumuintNullableList2049Null()
        {        
            List<uint?> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumuintNullableList2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<uint?,uint?>((uint?) arg, (uint?) arg)).ToList();
            Func<KeyValuePair<uint?, uint?>, uint?> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumuintNullableIList2049()
        {
            var source = ZEnumerable.Repeat((uint?) 1, 2049).ToIList();
            uint? SumActual = ZEnumerable.Sum(source);
            uint? SumExpected = (uint?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumuintNullableIList2049Map()
        {
            var source = ZEnumerable.Repeat(new { X = (uint?) 1 } , 2049).ToIList();
            uint? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            uint? SumExpected = (uint?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumuintNullableIList2049Null()
        {        
            IList<uint?> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumuintNullableIList2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<uint?,uint?>((uint?) arg, (uint?) arg)).ToIList();
            Func<KeyValuePair<uint?, uint?>, uint?> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
                
        #endregion
            #region long?             
            
        
        [TestMethod]
        public void TestSumlongNullableArray2049()
        {
            var source = ZEnumerable.Repeat((long?) 1, 2049).ToArray();
            long? SumActual = ZEnumerable.Sum(source);
            long? SumExpected = (long?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumlongNullableArray2049Map()
        {
            var source = ZEnumerable.Repeat(new { X = (long?) 1 } , 2049).ToArray();
            long? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            long? SumExpected = (long?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumlongNullableArray2049Null()
        {        
            long?[] nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumlongNullableArray2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<long?,long?>((long?) arg, (long?) arg)).ToArray();
            Func<KeyValuePair<long?, long?>, long?> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumlongNullableList2049()
        {
            var source = ZEnumerable.Repeat((long?) 1, 2049).ToList();
            long? SumActual = ZEnumerable.Sum(source);
            long? SumExpected = (long?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumlongNullableList2049Map()
        {
            var source = ZEnumerable.Repeat(new { X = (long?) 1 } , 2049).ToList();
            long? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            long? SumExpected = (long?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumlongNullableList2049Null()
        {        
            List<long?> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumlongNullableList2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<long?,long?>((long?) arg, (long?) arg)).ToList();
            Func<KeyValuePair<long?, long?>, long?> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumlongNullableIList2049()
        {
            var source = ZEnumerable.Repeat((long?) 1, 2049).ToIList();
            long? SumActual = ZEnumerable.Sum(source);
            long? SumExpected = (long?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumlongNullableIList2049Map()
        {
            var source = ZEnumerable.Repeat(new { X = (long?) 1 } , 2049).ToIList();
            long? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            long? SumExpected = (long?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumlongNullableIList2049Null()
        {        
            IList<long?> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumlongNullableIList2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<long?,long?>((long?) arg, (long?) arg)).ToIList();
            Func<KeyValuePair<long?, long?>, long?> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
                
        #endregion
            #region float?             
            
        
        [TestMethod]
        public void TestSumfloatNullableArray2049()
        {
            var source = ZEnumerable.Repeat((float?) 1, 2049).ToArray();
            float? SumActual = ZEnumerable.Sum(source);
            float? SumExpected = (float?) Enumerable.Sum(source.Select(x=> (double?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumfloatNullableArray2049Map()
        {
            var source = ZEnumerable.Repeat(new { X = (float?) 1 } , 2049).ToArray();
            float? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            float? SumExpected = (float?) Enumerable.Sum(source, arg => (double?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumfloatNullableArray2049Null()
        {        
            float?[] nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumfloatNullableArray2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<float?,float?>((float?) arg, (float?) arg)).ToArray();
            Func<KeyValuePair<float?, float?>, float?> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumfloatNullableList2049()
        {
            var source = ZEnumerable.Repeat((float?) 1, 2049).ToList();
            float? SumActual = ZEnumerable.Sum(source);
            float? SumExpected = (float?) Enumerable.Sum(source.Select(x=> (double?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumfloatNullableList2049Map()
        {
            var source = ZEnumerable.Repeat(new { X = (float?) 1 } , 2049).ToList();
            float? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            float? SumExpected = (float?) Enumerable.Sum(source, arg => (double?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumfloatNullableList2049Null()
        {        
            List<float?> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumfloatNullableList2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<float?,float?>((float?) arg, (float?) arg)).ToList();
            Func<KeyValuePair<float?, float?>, float?> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumfloatNullableIList2049()
        {
            var source = ZEnumerable.Repeat((float?) 1, 2049).ToIList();
            float? SumActual = ZEnumerable.Sum(source);
            float? SumExpected = (float?) Enumerable.Sum(source.Select(x=> (double?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumfloatNullableIList2049Map()
        {
            var source = ZEnumerable.Repeat(new { X = (float?) 1 } , 2049).ToIList();
            float? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            float? SumExpected = (float?) Enumerable.Sum(source, arg => (double?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumfloatNullableIList2049Null()
        {        
            IList<float?> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumfloatNullableIList2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<float?,float?>((float?) arg, (float?) arg)).ToIList();
            Func<KeyValuePair<float?, float?>, float?> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
                
        #endregion
            #region double?             
            
        
        [TestMethod]
        public void TestSumdoubleNullableArray2049()
        {
            var source = ZEnumerable.Repeat((double?) 1, 2049).ToArray();
            double? SumActual = ZEnumerable.Sum(source);
            double? SumExpected = (double?) Enumerable.Sum(source.Select(x=> (double?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdoubleNullableArray2049Map()
        {
            var source = ZEnumerable.Repeat(new { X = (double?) 1 } , 2049).ToArray();
            double? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            double? SumExpected = (double?) Enumerable.Sum(source, arg => (double?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumdoubleNullableArray2049Null()
        {        
            double?[] nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumdoubleNullableArray2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<double?,double?>((double?) arg, (double?) arg)).ToArray();
            Func<KeyValuePair<double?, double?>, double?> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumdoubleNullableList2049()
        {
            var source = ZEnumerable.Repeat((double?) 1, 2049).ToList();
            double? SumActual = ZEnumerable.Sum(source);
            double? SumExpected = (double?) Enumerable.Sum(source.Select(x=> (double?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdoubleNullableList2049Map()
        {
            var source = ZEnumerable.Repeat(new { X = (double?) 1 } , 2049).ToList();
            double? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            double? SumExpected = (double?) Enumerable.Sum(source, arg => (double?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumdoubleNullableList2049Null()
        {        
            List<double?> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumdoubleNullableList2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<double?,double?>((double?) arg, (double?) arg)).ToList();
            Func<KeyValuePair<double?, double?>, double?> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumdoubleNullableIList2049()
        {
            var source = ZEnumerable.Repeat((double?) 1, 2049).ToIList();
            double? SumActual = ZEnumerable.Sum(source);
            double? SumExpected = (double?) Enumerable.Sum(source.Select(x=> (double?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdoubleNullableIList2049Map()
        {
            var source = ZEnumerable.Repeat(new { X = (double?) 1 } , 2049).ToIList();
            double? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            double? SumExpected = (double?) Enumerable.Sum(source, arg => (double?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumdoubleNullableIList2049Null()
        {        
            IList<double?> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumdoubleNullableIList2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<double?,double?>((double?) arg, (double?) arg)).ToIList();
            Func<KeyValuePair<double?, double?>, double?> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
                
        #endregion
            #region decimal?             
            
        
        [TestMethod]
        public void TestSumdecimalNullableArray2049()
        {
            var source = ZEnumerable.Repeat((decimal?) 1, 2049).ToArray();
            decimal? SumActual = ZEnumerable.Sum(source);
            decimal? SumExpected = (decimal?) Enumerable.Sum(source.Select(x=> (double?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdecimalNullableArray2049Map()
        {
            var source = ZEnumerable.Repeat(new { X = (decimal?) 1 } , 2049).ToArray();
            decimal? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            decimal? SumExpected = (decimal?) Enumerable.Sum(source, arg => (double?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumdecimalNullableArray2049Null()
        {        
            decimal?[] nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumdecimalNullableArray2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<decimal?,decimal?>((decimal?) arg, (decimal?) arg)).ToArray();
            Func<KeyValuePair<decimal?, decimal?>, decimal?> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumdecimalNullableList2049()
        {
            var source = ZEnumerable.Repeat((decimal?) 1, 2049).ToList();
            decimal? SumActual = ZEnumerable.Sum(source);
            decimal? SumExpected = (decimal?) Enumerable.Sum(source.Select(x=> (double?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdecimalNullableList2049Map()
        {
            var source = ZEnumerable.Repeat(new { X = (decimal?) 1 } , 2049).ToList();
            decimal? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            decimal? SumExpected = (decimal?) Enumerable.Sum(source, arg => (double?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumdecimalNullableList2049Null()
        {        
            List<decimal?> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumdecimalNullableList2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<decimal?,decimal?>((decimal?) arg, (decimal?) arg)).ToList();
            Func<KeyValuePair<decimal?, decimal?>, decimal?> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumdecimalNullableIList2049()
        {
            var source = ZEnumerable.Repeat((decimal?) 1, 2049).ToIList();
            decimal? SumActual = ZEnumerable.Sum(source);
            decimal? SumExpected = (decimal?) Enumerable.Sum(source.Select(x=> (double?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdecimalNullableIList2049Map()
        {
            var source = ZEnumerable.Repeat(new { X = (decimal?) 1 } , 2049).ToIList();
            decimal? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            decimal? SumExpected = (decimal?) Enumerable.Sum(source, arg => (double?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumdecimalNullableIList2049Null()
        {        
            IList<decimal?> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumdecimalNullableIList2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<decimal?,decimal?>((decimal?) arg, (decimal?) arg)).ToIList();
            Func<KeyValuePair<decimal?, decimal?>, decimal?> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
                
        #endregion
            #region ulong?             
            
        
        [TestMethod]
        public void TestSumulongNullableArray2049()
        {
            var source = ZEnumerable.Repeat((ulong?) 1, 2049).ToArray();
            ulong? SumActual = ZEnumerable.Sum(source);
            ulong? SumExpected = (ulong?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumulongNullableArray2049Map()
        {
            var source = ZEnumerable.Repeat(new { X = (ulong?) 1 } , 2049).ToArray();
            ulong? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ulong? SumExpected = (ulong?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumulongNullableArray2049Null()
        {        
            ulong?[] nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumulongNullableArray2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<ulong?,ulong?>((ulong?) arg, (ulong?) arg)).ToArray();
            Func<KeyValuePair<ulong?, ulong?>, ulong?> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumulongNullableList2049()
        {
            var source = ZEnumerable.Repeat((ulong?) 1, 2049).ToList();
            ulong? SumActual = ZEnumerable.Sum(source);
            ulong? SumExpected = (ulong?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumulongNullableList2049Map()
        {
            var source = ZEnumerable.Repeat(new { X = (ulong?) 1 } , 2049).ToList();
            ulong? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ulong? SumExpected = (ulong?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumulongNullableList2049Null()
        {        
            List<ulong?> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumulongNullableList2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<ulong?,ulong?>((ulong?) arg, (ulong?) arg)).ToList();
            Func<KeyValuePair<ulong?, ulong?>, ulong?> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumulongNullableIList2049()
        {
            var source = ZEnumerable.Repeat((ulong?) 1, 2049).ToIList();
            ulong? SumActual = ZEnumerable.Sum(source);
            ulong? SumExpected = (ulong?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumulongNullableIList2049Map()
        {
            var source = ZEnumerable.Repeat(new { X = (ulong?) 1 } , 2049).ToIList();
            ulong? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ulong? SumExpected = (ulong?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumulongNullableIList2049Null()
        {        
            IList<ulong?> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumulongNullableIList2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<ulong?,ulong?>((ulong?) arg, (ulong?) arg)).ToIList();
            Func<KeyValuePair<ulong?, ulong?>, ulong?> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
                
        #endregion
        


    
                
            #region sbyte             
            
            
        [TestMethod]
        public void TestSumsbyteArray2051Null()
        {        
            sbyte[] nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumsbyteArray2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<sbyte,sbyte>((sbyte) arg, (sbyte) arg)).ToArray();
            Func<KeyValuePair<sbyte, sbyte>, sbyte> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
            
        [TestMethod]
        public void TestSumsbyteList2051Null()
        {        
            List<sbyte> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumsbyteList2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<sbyte,sbyte>((sbyte) arg, (sbyte) arg)).ToList();
            Func<KeyValuePair<sbyte, sbyte>, sbyte> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
            
        [TestMethod]
        public void TestSumsbyteIList2051Null()
        {        
            IList<sbyte> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumsbyteIList2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<sbyte,sbyte>((sbyte) arg, (sbyte) arg)).ToIList();
            Func<KeyValuePair<sbyte, sbyte>, sbyte> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
                
        #endregion
            #region byte             
            
            
        [TestMethod]
        public void TestSumbyteArray2051Null()
        {        
            byte[] nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumbyteArray2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<byte,byte>((byte) arg, (byte) arg)).ToArray();
            Func<KeyValuePair<byte, byte>, byte> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
            
        [TestMethod]
        public void TestSumbyteList2051Null()
        {        
            List<byte> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumbyteList2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<byte,byte>((byte) arg, (byte) arg)).ToList();
            Func<KeyValuePair<byte, byte>, byte> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
            
        [TestMethod]
        public void TestSumbyteIList2051Null()
        {        
            IList<byte> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumbyteIList2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<byte,byte>((byte) arg, (byte) arg)).ToIList();
            Func<KeyValuePair<byte, byte>, byte> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
                
        #endregion
            #region short             
            
        
        [TestMethod]
        public void TestSumshortArray2051()
        {
            var source = ZEnumerable.Repeat((short) 1, 2051).ToArray();
            short SumActual = ZEnumerable.Sum(source);
            short SumExpected = (short) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumshortArray2051Map()
        {
            var source = ZEnumerable.Repeat(new { X = (short) 1 } , 2051).ToArray();
            short SumActual = ZEnumerable.Sum(source, arg => arg.X);
            short SumExpected = (short) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumshortArray2051Null()
        {        
            short[] nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumshortArray2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<short,short>((short) arg, (short) arg)).ToArray();
            Func<KeyValuePair<short, short>, short> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumshortList2051()
        {
            var source = ZEnumerable.Repeat((short) 1, 2051).ToList();
            short SumActual = ZEnumerable.Sum(source);
            short SumExpected = (short) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumshortList2051Map()
        {
            var source = ZEnumerable.Repeat(new { X = (short) 1 } , 2051).ToList();
            short SumActual = ZEnumerable.Sum(source, arg => arg.X);
            short SumExpected = (short) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumshortList2051Null()
        {        
            List<short> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumshortList2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<short,short>((short) arg, (short) arg)).ToList();
            Func<KeyValuePair<short, short>, short> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumshortIList2051()
        {
            var source = ZEnumerable.Repeat((short) 1, 2051).ToIList();
            short SumActual = ZEnumerable.Sum(source);
            short SumExpected = (short) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumshortIList2051Map()
        {
            var source = ZEnumerable.Repeat(new { X = (short) 1 } , 2051).ToIList();
            short SumActual = ZEnumerable.Sum(source, arg => arg.X);
            short SumExpected = (short) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumshortIList2051Null()
        {        
            IList<short> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumshortIList2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<short,short>((short) arg, (short) arg)).ToIList();
            Func<KeyValuePair<short, short>, short> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
                
        #endregion
            #region ushort             
            
        
        [TestMethod]
        public void TestSumushortArray2051()
        {
            var source = ZEnumerable.Repeat((ushort) 1, 2051).ToArray();
            ushort SumActual = ZEnumerable.Sum(source);
            ushort SumExpected = (ushort) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumushortArray2051Map()
        {
            var source = ZEnumerable.Repeat(new { X = (ushort) 1 } , 2051).ToArray();
            ushort SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ushort SumExpected = (ushort) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumushortArray2051Null()
        {        
            ushort[] nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumushortArray2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<ushort,ushort>((ushort) arg, (ushort) arg)).ToArray();
            Func<KeyValuePair<ushort, ushort>, ushort> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumushortList2051()
        {
            var source = ZEnumerable.Repeat((ushort) 1, 2051).ToList();
            ushort SumActual = ZEnumerable.Sum(source);
            ushort SumExpected = (ushort) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumushortList2051Map()
        {
            var source = ZEnumerable.Repeat(new { X = (ushort) 1 } , 2051).ToList();
            ushort SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ushort SumExpected = (ushort) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumushortList2051Null()
        {        
            List<ushort> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumushortList2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<ushort,ushort>((ushort) arg, (ushort) arg)).ToList();
            Func<KeyValuePair<ushort, ushort>, ushort> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumushortIList2051()
        {
            var source = ZEnumerable.Repeat((ushort) 1, 2051).ToIList();
            ushort SumActual = ZEnumerable.Sum(source);
            ushort SumExpected = (ushort) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumushortIList2051Map()
        {
            var source = ZEnumerable.Repeat(new { X = (ushort) 1 } , 2051).ToIList();
            ushort SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ushort SumExpected = (ushort) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumushortIList2051Null()
        {        
            IList<ushort> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumushortIList2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<ushort,ushort>((ushort) arg, (ushort) arg)).ToIList();
            Func<KeyValuePair<ushort, ushort>, ushort> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
                
        #endregion
            #region int             
            
        
        [TestMethod]
        public void TestSumintArray2051()
        {
            var source = ZEnumerable.Repeat((int) 1, 2051).ToArray();
            int SumActual = ZEnumerable.Sum(source);
            int SumExpected = (int) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumintArray2051Map()
        {
            var source = ZEnumerable.Repeat(new { X = (int) 1 } , 2051).ToArray();
            int SumActual = ZEnumerable.Sum(source, arg => arg.X);
            int SumExpected = (int) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumintArray2051Null()
        {        
            int[] nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumintArray2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<int,int>((int) arg, (int) arg)).ToArray();
            Func<KeyValuePair<int, int>, int> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumintList2051()
        {
            var source = ZEnumerable.Repeat((int) 1, 2051).ToList();
            int SumActual = ZEnumerable.Sum(source);
            int SumExpected = (int) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumintList2051Map()
        {
            var source = ZEnumerable.Repeat(new { X = (int) 1 } , 2051).ToList();
            int SumActual = ZEnumerable.Sum(source, arg => arg.X);
            int SumExpected = (int) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumintList2051Null()
        {        
            List<int> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumintList2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<int,int>((int) arg, (int) arg)).ToList();
            Func<KeyValuePair<int, int>, int> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumintIList2051()
        {
            var source = ZEnumerable.Repeat((int) 1, 2051).ToIList();
            int SumActual = ZEnumerable.Sum(source);
            int SumExpected = (int) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumintIList2051Map()
        {
            var source = ZEnumerable.Repeat(new { X = (int) 1 } , 2051).ToIList();
            int SumActual = ZEnumerable.Sum(source, arg => arg.X);
            int SumExpected = (int) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumintIList2051Null()
        {        
            IList<int> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumintIList2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<int,int>((int) arg, (int) arg)).ToIList();
            Func<KeyValuePair<int, int>, int> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
                
        #endregion
            #region uint             
            
        
        [TestMethod]
        public void TestSumuintArray2051()
        {
            var source = ZEnumerable.Repeat((uint) 1, 2051).ToArray();
            uint SumActual = ZEnumerable.Sum(source);
            uint SumExpected = (uint) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumuintArray2051Map()
        {
            var source = ZEnumerable.Repeat(new { X = (uint) 1 } , 2051).ToArray();
            uint SumActual = ZEnumerable.Sum(source, arg => arg.X);
            uint SumExpected = (uint) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumuintArray2051Null()
        {        
            uint[] nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumuintArray2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<uint,uint>((uint) arg, (uint) arg)).ToArray();
            Func<KeyValuePair<uint, uint>, uint> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumuintList2051()
        {
            var source = ZEnumerable.Repeat((uint) 1, 2051).ToList();
            uint SumActual = ZEnumerable.Sum(source);
            uint SumExpected = (uint) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumuintList2051Map()
        {
            var source = ZEnumerable.Repeat(new { X = (uint) 1 } , 2051).ToList();
            uint SumActual = ZEnumerable.Sum(source, arg => arg.X);
            uint SumExpected = (uint) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumuintList2051Null()
        {        
            List<uint> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumuintList2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<uint,uint>((uint) arg, (uint) arg)).ToList();
            Func<KeyValuePair<uint, uint>, uint> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumuintIList2051()
        {
            var source = ZEnumerable.Repeat((uint) 1, 2051).ToIList();
            uint SumActual = ZEnumerable.Sum(source);
            uint SumExpected = (uint) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumuintIList2051Map()
        {
            var source = ZEnumerable.Repeat(new { X = (uint) 1 } , 2051).ToIList();
            uint SumActual = ZEnumerable.Sum(source, arg => arg.X);
            uint SumExpected = (uint) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumuintIList2051Null()
        {        
            IList<uint> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumuintIList2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<uint,uint>((uint) arg, (uint) arg)).ToIList();
            Func<KeyValuePair<uint, uint>, uint> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
                
        #endregion
            #region long             
            
        
        [TestMethod]
        public void TestSumlongArray2051()
        {
            var source = ZEnumerable.Repeat((long) 1, 2051).ToArray();
            long SumActual = ZEnumerable.Sum(source);
            long SumExpected = (long) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumlongArray2051Map()
        {
            var source = ZEnumerable.Repeat(new { X = (long) 1 } , 2051).ToArray();
            long SumActual = ZEnumerable.Sum(source, arg => arg.X);
            long SumExpected = (long) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumlongArray2051Null()
        {        
            long[] nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumlongArray2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<long,long>((long) arg, (long) arg)).ToArray();
            Func<KeyValuePair<long, long>, long> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumlongList2051()
        {
            var source = ZEnumerable.Repeat((long) 1, 2051).ToList();
            long SumActual = ZEnumerable.Sum(source);
            long SumExpected = (long) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumlongList2051Map()
        {
            var source = ZEnumerable.Repeat(new { X = (long) 1 } , 2051).ToList();
            long SumActual = ZEnumerable.Sum(source, arg => arg.X);
            long SumExpected = (long) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumlongList2051Null()
        {        
            List<long> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumlongList2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<long,long>((long) arg, (long) arg)).ToList();
            Func<KeyValuePair<long, long>, long> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumlongIList2051()
        {
            var source = ZEnumerable.Repeat((long) 1, 2051).ToIList();
            long SumActual = ZEnumerable.Sum(source);
            long SumExpected = (long) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumlongIList2051Map()
        {
            var source = ZEnumerable.Repeat(new { X = (long) 1 } , 2051).ToIList();
            long SumActual = ZEnumerable.Sum(source, arg => arg.X);
            long SumExpected = (long) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumlongIList2051Null()
        {        
            IList<long> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumlongIList2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<long,long>((long) arg, (long) arg)).ToIList();
            Func<KeyValuePair<long, long>, long> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
                
        #endregion
            #region float             
            
        
        [TestMethod]
        public void TestSumfloatArray2051()
        {
            var source = ZEnumerable.Repeat((float) 1, 2051).ToArray();
            float SumActual = ZEnumerable.Sum(source);
            float SumExpected = (float) Enumerable.Sum(source.Select(x=> (double)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumfloatArray2051Map()
        {
            var source = ZEnumerable.Repeat(new { X = (float) 1 } , 2051).ToArray();
            float SumActual = ZEnumerable.Sum(source, arg => arg.X);
            float SumExpected = (float) Enumerable.Sum(source, arg => (double) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumfloatArray2051Null()
        {        
            float[] nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumfloatArray2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<float,float>((float) arg, (float) arg)).ToArray();
            Func<KeyValuePair<float, float>, float> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumfloatList2051()
        {
            var source = ZEnumerable.Repeat((float) 1, 2051).ToList();
            float SumActual = ZEnumerable.Sum(source);
            float SumExpected = (float) Enumerable.Sum(source.Select(x=> (double)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumfloatList2051Map()
        {
            var source = ZEnumerable.Repeat(new { X = (float) 1 } , 2051).ToList();
            float SumActual = ZEnumerable.Sum(source, arg => arg.X);
            float SumExpected = (float) Enumerable.Sum(source, arg => (double) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumfloatList2051Null()
        {        
            List<float> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumfloatList2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<float,float>((float) arg, (float) arg)).ToList();
            Func<KeyValuePair<float, float>, float> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumfloatIList2051()
        {
            var source = ZEnumerable.Repeat((float) 1, 2051).ToIList();
            float SumActual = ZEnumerable.Sum(source);
            float SumExpected = (float) Enumerable.Sum(source.Select(x=> (double)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumfloatIList2051Map()
        {
            var source = ZEnumerable.Repeat(new { X = (float) 1 } , 2051).ToIList();
            float SumActual = ZEnumerable.Sum(source, arg => arg.X);
            float SumExpected = (float) Enumerable.Sum(source, arg => (double) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumfloatIList2051Null()
        {        
            IList<float> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumfloatIList2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<float,float>((float) arg, (float) arg)).ToIList();
            Func<KeyValuePair<float, float>, float> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
                
        #endregion
            #region double             
            
        
        [TestMethod]
        public void TestSumdoubleArray2051()
        {
            var source = ZEnumerable.Repeat((double) 1, 2051).ToArray();
            double SumActual = ZEnumerable.Sum(source);
            double SumExpected = (double) Enumerable.Sum(source.Select(x=> (double)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdoubleArray2051Map()
        {
            var source = ZEnumerable.Repeat(new { X = (double) 1 } , 2051).ToArray();
            double SumActual = ZEnumerable.Sum(source, arg => arg.X);
            double SumExpected = (double) Enumerable.Sum(source, arg => (double) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumdoubleArray2051Null()
        {        
            double[] nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumdoubleArray2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<double,double>((double) arg, (double) arg)).ToArray();
            Func<KeyValuePair<double, double>, double> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumdoubleList2051()
        {
            var source = ZEnumerable.Repeat((double) 1, 2051).ToList();
            double SumActual = ZEnumerable.Sum(source);
            double SumExpected = (double) Enumerable.Sum(source.Select(x=> (double)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdoubleList2051Map()
        {
            var source = ZEnumerable.Repeat(new { X = (double) 1 } , 2051).ToList();
            double SumActual = ZEnumerable.Sum(source, arg => arg.X);
            double SumExpected = (double) Enumerable.Sum(source, arg => (double) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumdoubleList2051Null()
        {        
            List<double> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumdoubleList2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<double,double>((double) arg, (double) arg)).ToList();
            Func<KeyValuePair<double, double>, double> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumdoubleIList2051()
        {
            var source = ZEnumerable.Repeat((double) 1, 2051).ToIList();
            double SumActual = ZEnumerable.Sum(source);
            double SumExpected = (double) Enumerable.Sum(source.Select(x=> (double)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdoubleIList2051Map()
        {
            var source = ZEnumerable.Repeat(new { X = (double) 1 } , 2051).ToIList();
            double SumActual = ZEnumerable.Sum(source, arg => arg.X);
            double SumExpected = (double) Enumerable.Sum(source, arg => (double) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumdoubleIList2051Null()
        {        
            IList<double> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumdoubleIList2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<double,double>((double) arg, (double) arg)).ToIList();
            Func<KeyValuePair<double, double>, double> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
                
        #endregion
            #region decimal             
            
        
        [TestMethod]
        public void TestSumdecimalArray2051()
        {
            var source = ZEnumerable.Repeat((decimal) 1, 2051).ToArray();
            decimal SumActual = ZEnumerable.Sum(source);
            decimal SumExpected = (decimal) Enumerable.Sum(source.Select(x=> (double)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdecimalArray2051Map()
        {
            var source = ZEnumerable.Repeat(new { X = (decimal) 1 } , 2051).ToArray();
            decimal SumActual = ZEnumerable.Sum(source, arg => arg.X);
            decimal SumExpected = (decimal) Enumerable.Sum(source, arg => (double) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumdecimalArray2051Null()
        {        
            decimal[] nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumdecimalArray2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<decimal,decimal>((decimal) arg, (decimal) arg)).ToArray();
            Func<KeyValuePair<decimal, decimal>, decimal> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumdecimalList2051()
        {
            var source = ZEnumerable.Repeat((decimal) 1, 2051).ToList();
            decimal SumActual = ZEnumerable.Sum(source);
            decimal SumExpected = (decimal) Enumerable.Sum(source.Select(x=> (double)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdecimalList2051Map()
        {
            var source = ZEnumerable.Repeat(new { X = (decimal) 1 } , 2051).ToList();
            decimal SumActual = ZEnumerable.Sum(source, arg => arg.X);
            decimal SumExpected = (decimal) Enumerable.Sum(source, arg => (double) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumdecimalList2051Null()
        {        
            List<decimal> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumdecimalList2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<decimal,decimal>((decimal) arg, (decimal) arg)).ToList();
            Func<KeyValuePair<decimal, decimal>, decimal> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumdecimalIList2051()
        {
            var source = ZEnumerable.Repeat((decimal) 1, 2051).ToIList();
            decimal SumActual = ZEnumerable.Sum(source);
            decimal SumExpected = (decimal) Enumerable.Sum(source.Select(x=> (double)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdecimalIList2051Map()
        {
            var source = ZEnumerable.Repeat(new { X = (decimal) 1 } , 2051).ToIList();
            decimal SumActual = ZEnumerable.Sum(source, arg => arg.X);
            decimal SumExpected = (decimal) Enumerable.Sum(source, arg => (double) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumdecimalIList2051Null()
        {        
            IList<decimal> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumdecimalIList2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<decimal,decimal>((decimal) arg, (decimal) arg)).ToIList();
            Func<KeyValuePair<decimal, decimal>, decimal> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
                
        #endregion
            #region ulong             
            
        
        [TestMethod]
        public void TestSumulongArray2051()
        {
            var source = ZEnumerable.Repeat((ulong) 1, 2051).ToArray();
            ulong SumActual = ZEnumerable.Sum(source);
            ulong SumExpected = (ulong) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumulongArray2051Map()
        {
            var source = ZEnumerable.Repeat(new { X = (ulong) 1 } , 2051).ToArray();
            ulong SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ulong SumExpected = (ulong) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumulongArray2051Null()
        {        
            ulong[] nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumulongArray2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<ulong,ulong>((ulong) arg, (ulong) arg)).ToArray();
            Func<KeyValuePair<ulong, ulong>, ulong> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumulongList2051()
        {
            var source = ZEnumerable.Repeat((ulong) 1, 2051).ToList();
            ulong SumActual = ZEnumerable.Sum(source);
            ulong SumExpected = (ulong) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumulongList2051Map()
        {
            var source = ZEnumerable.Repeat(new { X = (ulong) 1 } , 2051).ToList();
            ulong SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ulong SumExpected = (ulong) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumulongList2051Null()
        {        
            List<ulong> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumulongList2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<ulong,ulong>((ulong) arg, (ulong) arg)).ToList();
            Func<KeyValuePair<ulong, ulong>, ulong> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumulongIList2051()
        {
            var source = ZEnumerable.Repeat((ulong) 1, 2051).ToIList();
            ulong SumActual = ZEnumerable.Sum(source);
            ulong SumExpected = (ulong) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumulongIList2051Map()
        {
            var source = ZEnumerable.Repeat(new { X = (ulong) 1 } , 2051).ToIList();
            ulong SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ulong SumExpected = (ulong) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumulongIList2051Null()
        {        
            IList<ulong> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumulongIList2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<ulong,ulong>((ulong) arg, (ulong) arg)).ToIList();
            Func<KeyValuePair<ulong, ulong>, ulong> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
                
        #endregion
            #region sbyte?             
            
            
        [TestMethod]
        public void TestSumsbyteNullableArray2051Null()
        {        
            sbyte?[] nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumsbyteNullableArray2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<sbyte?,sbyte?>((sbyte?) arg, (sbyte?) arg)).ToArray();
            Func<KeyValuePair<sbyte?, sbyte?>, sbyte?> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
            
        [TestMethod]
        public void TestSumsbyteNullableList2051Null()
        {        
            List<sbyte?> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumsbyteNullableList2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<sbyte?,sbyte?>((sbyte?) arg, (sbyte?) arg)).ToList();
            Func<KeyValuePair<sbyte?, sbyte?>, sbyte?> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
            
        [TestMethod]
        public void TestSumsbyteNullableIList2051Null()
        {        
            IList<sbyte?> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumsbyteNullableIList2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<sbyte?,sbyte?>((sbyte?) arg, (sbyte?) arg)).ToIList();
            Func<KeyValuePair<sbyte?, sbyte?>, sbyte?> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
                
        #endregion
            #region byte?             
            
            
        [TestMethod]
        public void TestSumbyteNullableArray2051Null()
        {        
            byte?[] nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumbyteNullableArray2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<byte?,byte?>((byte?) arg, (byte?) arg)).ToArray();
            Func<KeyValuePair<byte?, byte?>, byte?> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
            
        [TestMethod]
        public void TestSumbyteNullableList2051Null()
        {        
            List<byte?> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumbyteNullableList2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<byte?,byte?>((byte?) arg, (byte?) arg)).ToList();
            Func<KeyValuePair<byte?, byte?>, byte?> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
            
        [TestMethod]
        public void TestSumbyteNullableIList2051Null()
        {        
            IList<byte?> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumbyteNullableIList2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<byte?,byte?>((byte?) arg, (byte?) arg)).ToIList();
            Func<KeyValuePair<byte?, byte?>, byte?> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
                
        #endregion
            #region short?             
            
        
        [TestMethod]
        public void TestSumshortNullableArray2051()
        {
            var source = ZEnumerable.Repeat((short?) 1, 2051).ToArray();
            short? SumActual = ZEnumerable.Sum(source);
            short? SumExpected = (short?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumshortNullableArray2051Map()
        {
            var source = ZEnumerable.Repeat(new { X = (short?) 1 } , 2051).ToArray();
            short? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            short? SumExpected = (short?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumshortNullableArray2051Null()
        {        
            short?[] nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumshortNullableArray2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<short?,short?>((short?) arg, (short?) arg)).ToArray();
            Func<KeyValuePair<short?, short?>, short?> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumshortNullableList2051()
        {
            var source = ZEnumerable.Repeat((short?) 1, 2051).ToList();
            short? SumActual = ZEnumerable.Sum(source);
            short? SumExpected = (short?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumshortNullableList2051Map()
        {
            var source = ZEnumerable.Repeat(new { X = (short?) 1 } , 2051).ToList();
            short? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            short? SumExpected = (short?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumshortNullableList2051Null()
        {        
            List<short?> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumshortNullableList2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<short?,short?>((short?) arg, (short?) arg)).ToList();
            Func<KeyValuePair<short?, short?>, short?> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumshortNullableIList2051()
        {
            var source = ZEnumerable.Repeat((short?) 1, 2051).ToIList();
            short? SumActual = ZEnumerable.Sum(source);
            short? SumExpected = (short?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumshortNullableIList2051Map()
        {
            var source = ZEnumerable.Repeat(new { X = (short?) 1 } , 2051).ToIList();
            short? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            short? SumExpected = (short?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumshortNullableIList2051Null()
        {        
            IList<short?> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumshortNullableIList2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<short?,short?>((short?) arg, (short?) arg)).ToIList();
            Func<KeyValuePair<short?, short?>, short?> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
                
        #endregion
            #region ushort?             
            
        
        [TestMethod]
        public void TestSumushortNullableArray2051()
        {
            var source = ZEnumerable.Repeat((ushort?) 1, 2051).ToArray();
            ushort? SumActual = ZEnumerable.Sum(source);
            ushort? SumExpected = (ushort?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumushortNullableArray2051Map()
        {
            var source = ZEnumerable.Repeat(new { X = (ushort?) 1 } , 2051).ToArray();
            ushort? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ushort? SumExpected = (ushort?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumushortNullableArray2051Null()
        {        
            ushort?[] nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumushortNullableArray2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<ushort?,ushort?>((ushort?) arg, (ushort?) arg)).ToArray();
            Func<KeyValuePair<ushort?, ushort?>, ushort?> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumushortNullableList2051()
        {
            var source = ZEnumerable.Repeat((ushort?) 1, 2051).ToList();
            ushort? SumActual = ZEnumerable.Sum(source);
            ushort? SumExpected = (ushort?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumushortNullableList2051Map()
        {
            var source = ZEnumerable.Repeat(new { X = (ushort?) 1 } , 2051).ToList();
            ushort? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ushort? SumExpected = (ushort?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumushortNullableList2051Null()
        {        
            List<ushort?> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumushortNullableList2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<ushort?,ushort?>((ushort?) arg, (ushort?) arg)).ToList();
            Func<KeyValuePair<ushort?, ushort?>, ushort?> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumushortNullableIList2051()
        {
            var source = ZEnumerable.Repeat((ushort?) 1, 2051).ToIList();
            ushort? SumActual = ZEnumerable.Sum(source);
            ushort? SumExpected = (ushort?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumushortNullableIList2051Map()
        {
            var source = ZEnumerable.Repeat(new { X = (ushort?) 1 } , 2051).ToIList();
            ushort? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ushort? SumExpected = (ushort?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumushortNullableIList2051Null()
        {        
            IList<ushort?> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumushortNullableIList2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<ushort?,ushort?>((ushort?) arg, (ushort?) arg)).ToIList();
            Func<KeyValuePair<ushort?, ushort?>, ushort?> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
                
        #endregion
            #region int?             
            
        
        [TestMethod]
        public void TestSumintNullableArray2051()
        {
            var source = ZEnumerable.Repeat((int?) 1, 2051).ToArray();
            int? SumActual = ZEnumerable.Sum(source);
            int? SumExpected = (int?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumintNullableArray2051Map()
        {
            var source = ZEnumerable.Repeat(new { X = (int?) 1 } , 2051).ToArray();
            int? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            int? SumExpected = (int?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumintNullableArray2051Null()
        {        
            int?[] nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumintNullableArray2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<int?,int?>((int?) arg, (int?) arg)).ToArray();
            Func<KeyValuePair<int?, int?>, int?> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumintNullableList2051()
        {
            var source = ZEnumerable.Repeat((int?) 1, 2051).ToList();
            int? SumActual = ZEnumerable.Sum(source);
            int? SumExpected = (int?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumintNullableList2051Map()
        {
            var source = ZEnumerable.Repeat(new { X = (int?) 1 } , 2051).ToList();
            int? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            int? SumExpected = (int?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumintNullableList2051Null()
        {        
            List<int?> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumintNullableList2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<int?,int?>((int?) arg, (int?) arg)).ToList();
            Func<KeyValuePair<int?, int?>, int?> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumintNullableIList2051()
        {
            var source = ZEnumerable.Repeat((int?) 1, 2051).ToIList();
            int? SumActual = ZEnumerable.Sum(source);
            int? SumExpected = (int?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumintNullableIList2051Map()
        {
            var source = ZEnumerable.Repeat(new { X = (int?) 1 } , 2051).ToIList();
            int? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            int? SumExpected = (int?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumintNullableIList2051Null()
        {        
            IList<int?> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumintNullableIList2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<int?,int?>((int?) arg, (int?) arg)).ToIList();
            Func<KeyValuePair<int?, int?>, int?> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
                
        #endregion
            #region uint?             
            
        
        [TestMethod]
        public void TestSumuintNullableArray2051()
        {
            var source = ZEnumerable.Repeat((uint?) 1, 2051).ToArray();
            uint? SumActual = ZEnumerable.Sum(source);
            uint? SumExpected = (uint?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumuintNullableArray2051Map()
        {
            var source = ZEnumerable.Repeat(new { X = (uint?) 1 } , 2051).ToArray();
            uint? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            uint? SumExpected = (uint?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumuintNullableArray2051Null()
        {        
            uint?[] nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumuintNullableArray2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<uint?,uint?>((uint?) arg, (uint?) arg)).ToArray();
            Func<KeyValuePair<uint?, uint?>, uint?> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumuintNullableList2051()
        {
            var source = ZEnumerable.Repeat((uint?) 1, 2051).ToList();
            uint? SumActual = ZEnumerable.Sum(source);
            uint? SumExpected = (uint?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumuintNullableList2051Map()
        {
            var source = ZEnumerable.Repeat(new { X = (uint?) 1 } , 2051).ToList();
            uint? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            uint? SumExpected = (uint?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumuintNullableList2051Null()
        {        
            List<uint?> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumuintNullableList2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<uint?,uint?>((uint?) arg, (uint?) arg)).ToList();
            Func<KeyValuePair<uint?, uint?>, uint?> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumuintNullableIList2051()
        {
            var source = ZEnumerable.Repeat((uint?) 1, 2051).ToIList();
            uint? SumActual = ZEnumerable.Sum(source);
            uint? SumExpected = (uint?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumuintNullableIList2051Map()
        {
            var source = ZEnumerable.Repeat(new { X = (uint?) 1 } , 2051).ToIList();
            uint? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            uint? SumExpected = (uint?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumuintNullableIList2051Null()
        {        
            IList<uint?> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumuintNullableIList2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<uint?,uint?>((uint?) arg, (uint?) arg)).ToIList();
            Func<KeyValuePair<uint?, uint?>, uint?> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
                
        #endregion
            #region long?             
            
        
        [TestMethod]
        public void TestSumlongNullableArray2051()
        {
            var source = ZEnumerable.Repeat((long?) 1, 2051).ToArray();
            long? SumActual = ZEnumerable.Sum(source);
            long? SumExpected = (long?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumlongNullableArray2051Map()
        {
            var source = ZEnumerable.Repeat(new { X = (long?) 1 } , 2051).ToArray();
            long? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            long? SumExpected = (long?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumlongNullableArray2051Null()
        {        
            long?[] nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumlongNullableArray2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<long?,long?>((long?) arg, (long?) arg)).ToArray();
            Func<KeyValuePair<long?, long?>, long?> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumlongNullableList2051()
        {
            var source = ZEnumerable.Repeat((long?) 1, 2051).ToList();
            long? SumActual = ZEnumerable.Sum(source);
            long? SumExpected = (long?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumlongNullableList2051Map()
        {
            var source = ZEnumerable.Repeat(new { X = (long?) 1 } , 2051).ToList();
            long? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            long? SumExpected = (long?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumlongNullableList2051Null()
        {        
            List<long?> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumlongNullableList2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<long?,long?>((long?) arg, (long?) arg)).ToList();
            Func<KeyValuePair<long?, long?>, long?> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumlongNullableIList2051()
        {
            var source = ZEnumerable.Repeat((long?) 1, 2051).ToIList();
            long? SumActual = ZEnumerable.Sum(source);
            long? SumExpected = (long?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumlongNullableIList2051Map()
        {
            var source = ZEnumerable.Repeat(new { X = (long?) 1 } , 2051).ToIList();
            long? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            long? SumExpected = (long?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumlongNullableIList2051Null()
        {        
            IList<long?> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumlongNullableIList2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<long?,long?>((long?) arg, (long?) arg)).ToIList();
            Func<KeyValuePair<long?, long?>, long?> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
                
        #endregion
            #region float?             
            
        
        [TestMethod]
        public void TestSumfloatNullableArray2051()
        {
            var source = ZEnumerable.Repeat((float?) 1, 2051).ToArray();
            float? SumActual = ZEnumerable.Sum(source);
            float? SumExpected = (float?) Enumerable.Sum(source.Select(x=> (double?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumfloatNullableArray2051Map()
        {
            var source = ZEnumerable.Repeat(new { X = (float?) 1 } , 2051).ToArray();
            float? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            float? SumExpected = (float?) Enumerable.Sum(source, arg => (double?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumfloatNullableArray2051Null()
        {        
            float?[] nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumfloatNullableArray2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<float?,float?>((float?) arg, (float?) arg)).ToArray();
            Func<KeyValuePair<float?, float?>, float?> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumfloatNullableList2051()
        {
            var source = ZEnumerable.Repeat((float?) 1, 2051).ToList();
            float? SumActual = ZEnumerable.Sum(source);
            float? SumExpected = (float?) Enumerable.Sum(source.Select(x=> (double?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumfloatNullableList2051Map()
        {
            var source = ZEnumerable.Repeat(new { X = (float?) 1 } , 2051).ToList();
            float? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            float? SumExpected = (float?) Enumerable.Sum(source, arg => (double?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumfloatNullableList2051Null()
        {        
            List<float?> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumfloatNullableList2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<float?,float?>((float?) arg, (float?) arg)).ToList();
            Func<KeyValuePair<float?, float?>, float?> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumfloatNullableIList2051()
        {
            var source = ZEnumerable.Repeat((float?) 1, 2051).ToIList();
            float? SumActual = ZEnumerable.Sum(source);
            float? SumExpected = (float?) Enumerable.Sum(source.Select(x=> (double?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumfloatNullableIList2051Map()
        {
            var source = ZEnumerable.Repeat(new { X = (float?) 1 } , 2051).ToIList();
            float? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            float? SumExpected = (float?) Enumerable.Sum(source, arg => (double?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumfloatNullableIList2051Null()
        {        
            IList<float?> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumfloatNullableIList2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<float?,float?>((float?) arg, (float?) arg)).ToIList();
            Func<KeyValuePair<float?, float?>, float?> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
                
        #endregion
            #region double?             
            
        
        [TestMethod]
        public void TestSumdoubleNullableArray2051()
        {
            var source = ZEnumerable.Repeat((double?) 1, 2051).ToArray();
            double? SumActual = ZEnumerable.Sum(source);
            double? SumExpected = (double?) Enumerable.Sum(source.Select(x=> (double?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdoubleNullableArray2051Map()
        {
            var source = ZEnumerable.Repeat(new { X = (double?) 1 } , 2051).ToArray();
            double? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            double? SumExpected = (double?) Enumerable.Sum(source, arg => (double?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumdoubleNullableArray2051Null()
        {        
            double?[] nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumdoubleNullableArray2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<double?,double?>((double?) arg, (double?) arg)).ToArray();
            Func<KeyValuePair<double?, double?>, double?> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumdoubleNullableList2051()
        {
            var source = ZEnumerable.Repeat((double?) 1, 2051).ToList();
            double? SumActual = ZEnumerable.Sum(source);
            double? SumExpected = (double?) Enumerable.Sum(source.Select(x=> (double?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdoubleNullableList2051Map()
        {
            var source = ZEnumerable.Repeat(new { X = (double?) 1 } , 2051).ToList();
            double? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            double? SumExpected = (double?) Enumerable.Sum(source, arg => (double?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumdoubleNullableList2051Null()
        {        
            List<double?> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumdoubleNullableList2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<double?,double?>((double?) arg, (double?) arg)).ToList();
            Func<KeyValuePair<double?, double?>, double?> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumdoubleNullableIList2051()
        {
            var source = ZEnumerable.Repeat((double?) 1, 2051).ToIList();
            double? SumActual = ZEnumerable.Sum(source);
            double? SumExpected = (double?) Enumerable.Sum(source.Select(x=> (double?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdoubleNullableIList2051Map()
        {
            var source = ZEnumerable.Repeat(new { X = (double?) 1 } , 2051).ToIList();
            double? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            double? SumExpected = (double?) Enumerable.Sum(source, arg => (double?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumdoubleNullableIList2051Null()
        {        
            IList<double?> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumdoubleNullableIList2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<double?,double?>((double?) arg, (double?) arg)).ToIList();
            Func<KeyValuePair<double?, double?>, double?> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
                
        #endregion
            #region decimal?             
            
        
        [TestMethod]
        public void TestSumdecimalNullableArray2051()
        {
            var source = ZEnumerable.Repeat((decimal?) 1, 2051).ToArray();
            decimal? SumActual = ZEnumerable.Sum(source);
            decimal? SumExpected = (decimal?) Enumerable.Sum(source.Select(x=> (double?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdecimalNullableArray2051Map()
        {
            var source = ZEnumerable.Repeat(new { X = (decimal?) 1 } , 2051).ToArray();
            decimal? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            decimal? SumExpected = (decimal?) Enumerable.Sum(source, arg => (double?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumdecimalNullableArray2051Null()
        {        
            decimal?[] nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumdecimalNullableArray2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<decimal?,decimal?>((decimal?) arg, (decimal?) arg)).ToArray();
            Func<KeyValuePair<decimal?, decimal?>, decimal?> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumdecimalNullableList2051()
        {
            var source = ZEnumerable.Repeat((decimal?) 1, 2051).ToList();
            decimal? SumActual = ZEnumerable.Sum(source);
            decimal? SumExpected = (decimal?) Enumerable.Sum(source.Select(x=> (double?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdecimalNullableList2051Map()
        {
            var source = ZEnumerable.Repeat(new { X = (decimal?) 1 } , 2051).ToList();
            decimal? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            decimal? SumExpected = (decimal?) Enumerable.Sum(source, arg => (double?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumdecimalNullableList2051Null()
        {        
            List<decimal?> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumdecimalNullableList2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<decimal?,decimal?>((decimal?) arg, (decimal?) arg)).ToList();
            Func<KeyValuePair<decimal?, decimal?>, decimal?> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumdecimalNullableIList2051()
        {
            var source = ZEnumerable.Repeat((decimal?) 1, 2051).ToIList();
            decimal? SumActual = ZEnumerable.Sum(source);
            decimal? SumExpected = (decimal?) Enumerable.Sum(source.Select(x=> (double?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdecimalNullableIList2051Map()
        {
            var source = ZEnumerable.Repeat(new { X = (decimal?) 1 } , 2051).ToIList();
            decimal? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            decimal? SumExpected = (decimal?) Enumerable.Sum(source, arg => (double?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumdecimalNullableIList2051Null()
        {        
            IList<decimal?> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumdecimalNullableIList2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<decimal?,decimal?>((decimal?) arg, (decimal?) arg)).ToIList();
            Func<KeyValuePair<decimal?, decimal?>, decimal?> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
                
        #endregion
            #region ulong?             
            
        
        [TestMethod]
        public void TestSumulongNullableArray2051()
        {
            var source = ZEnumerable.Repeat((ulong?) 1, 2051).ToArray();
            ulong? SumActual = ZEnumerable.Sum(source);
            ulong? SumExpected = (ulong?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumulongNullableArray2051Map()
        {
            var source = ZEnumerable.Repeat(new { X = (ulong?) 1 } , 2051).ToArray();
            ulong? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ulong? SumExpected = (ulong?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumulongNullableArray2051Null()
        {        
            ulong?[] nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumulongNullableArray2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<ulong?,ulong?>((ulong?) arg, (ulong?) arg)).ToArray();
            Func<KeyValuePair<ulong?, ulong?>, ulong?> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumulongNullableList2051()
        {
            var source = ZEnumerable.Repeat((ulong?) 1, 2051).ToList();
            ulong? SumActual = ZEnumerable.Sum(source);
            ulong? SumExpected = (ulong?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumulongNullableList2051Map()
        {
            var source = ZEnumerable.Repeat(new { X = (ulong?) 1 } , 2051).ToList();
            ulong? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ulong? SumExpected = (ulong?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumulongNullableList2051Null()
        {        
            List<ulong?> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumulongNullableList2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<ulong?,ulong?>((ulong?) arg, (ulong?) arg)).ToList();
            Func<KeyValuePair<ulong?, ulong?>, ulong?> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
            
        
        [TestMethod]
        public void TestSumulongNullableIList2051()
        {
            var source = ZEnumerable.Repeat((ulong?) 1, 2051).ToIList();
            ulong? SumActual = ZEnumerable.Sum(source);
            ulong? SumExpected = (ulong?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumulongNullableIList2051Map()
        {
            var source = ZEnumerable.Repeat(new { X = (ulong?) 1 } , 2051).ToIList();
            ulong? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ulong? SumExpected = (ulong?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

            
        [TestMethod]
        public void TestSumulongNullableIList2051Null()
        {        
            IList<ulong?> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        [TestMethod]
        public void TestSumulongNullableIList2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<ulong?,ulong?>((ulong?) arg, (ulong?) arg)).ToIList();
            Func<KeyValuePair<ulong?, ulong?>, ulong?> map = null;
            try
            {
                ZEnumerable.Sum(source, map);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
        }
                
        #endregion
        


    
    }
}