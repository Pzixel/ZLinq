
using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using ZLinq.Test.Helpers;

namespace ZLinq.Test.ZMath
{
    [TestClass]
    public class Max
    {            
    
                
    
        #region sbyte             
            
        
        [TestMethod]
        public void TestMaxsbyteArray100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (sbyte) r.Next(sbyte.MaxValue), 100).ToArray();
            sbyte maxActual = ZEnumerable.Max(source);
            sbyte maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxsbyteArray100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (sbyte) r.Next(sbyte.MaxValue) } , 100).ToArray();
            sbyte maxActual = ZEnumerable.Max(source, arg => arg.X);
            sbyte maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxsbyteArray100Null()
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
        public void TestMaxsbyteArray100MapNull()
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
        public void TestMaxsbyteList100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (sbyte) r.Next(sbyte.MaxValue), 100).ToList();
            sbyte maxActual = ZEnumerable.Max(source);
            sbyte maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxsbyteList100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (sbyte) r.Next(sbyte.MaxValue) } , 100).ToList();
            sbyte maxActual = ZEnumerable.Max(source, arg => arg.X);
            sbyte maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxsbyteList100Null()
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
        public void TestMaxsbyteList100MapNull()
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
        public void TestMaxsbyteIList100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (sbyte) r.Next(sbyte.MaxValue), 100).ToIList();
            sbyte maxActual = ZEnumerable.Max(source);
            sbyte maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxsbyteIList100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (sbyte) r.Next(sbyte.MaxValue) } , 100).ToIList();
            sbyte maxActual = ZEnumerable.Max(source, arg => arg.X);
            sbyte maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxsbyteIList100Null()
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
        public void TestMaxsbyteIList100MapNull()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<sbyte,sbyte>((sbyte) arg, (sbyte) arg)).ToIList();
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
        public void TestMaxbyteArray100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (byte) r.Next(byte.MaxValue), 100).ToArray();
            byte maxActual = ZEnumerable.Max(source);
            byte maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxbyteArray100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (byte) r.Next(byte.MaxValue) } , 100).ToArray();
            byte maxActual = ZEnumerable.Max(source, arg => arg.X);
            byte maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxbyteArray100Null()
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
        public void TestMaxbyteArray100MapNull()
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
        public void TestMaxbyteList100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (byte) r.Next(byte.MaxValue), 100).ToList();
            byte maxActual = ZEnumerable.Max(source);
            byte maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxbyteList100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (byte) r.Next(byte.MaxValue) } , 100).ToList();
            byte maxActual = ZEnumerable.Max(source, arg => arg.X);
            byte maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxbyteList100Null()
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
        public void TestMaxbyteList100MapNull()
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
        public void TestMaxbyteIList100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (byte) r.Next(byte.MaxValue), 100).ToIList();
            byte maxActual = ZEnumerable.Max(source);
            byte maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxbyteIList100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (byte) r.Next(byte.MaxValue) } , 100).ToIList();
            byte maxActual = ZEnumerable.Max(source, arg => arg.X);
            byte maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxbyteIList100Null()
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
        public void TestMaxbyteIList100MapNull()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<byte,byte>((byte) arg, (byte) arg)).ToIList();
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
        public void TestMaxshortArray100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (short) r.Next(short.MaxValue), 100).ToArray();
            short maxActual = ZEnumerable.Max(source);
            short maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxshortArray100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (short) r.Next(short.MaxValue) } , 100).ToArray();
            short maxActual = ZEnumerable.Max(source, arg => arg.X);
            short maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxshortArray100Null()
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
        public void TestMaxshortArray100MapNull()
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
        public void TestMaxshortList100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (short) r.Next(short.MaxValue), 100).ToList();
            short maxActual = ZEnumerable.Max(source);
            short maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxshortList100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (short) r.Next(short.MaxValue) } , 100).ToList();
            short maxActual = ZEnumerable.Max(source, arg => arg.X);
            short maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxshortList100Null()
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
        public void TestMaxshortList100MapNull()
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
        public void TestMaxshortIList100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (short) r.Next(short.MaxValue), 100).ToIList();
            short maxActual = ZEnumerable.Max(source);
            short maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxshortIList100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (short) r.Next(short.MaxValue) } , 100).ToIList();
            short maxActual = ZEnumerable.Max(source, arg => arg.X);
            short maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxshortIList100Null()
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
        public void TestMaxshortIList100MapNull()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<short,short>((short) arg, (short) arg)).ToIList();
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
        public void TestMaxushortArray100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ushort) r.Next(ushort.MaxValue), 100).ToArray();
            ushort maxActual = ZEnumerable.Max(source);
            ushort maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxushortArray100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ushort) r.Next(ushort.MaxValue) } , 100).ToArray();
            ushort maxActual = ZEnumerable.Max(source, arg => arg.X);
            ushort maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxushortArray100Null()
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
        public void TestMaxushortArray100MapNull()
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
        public void TestMaxushortList100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ushort) r.Next(ushort.MaxValue), 100).ToList();
            ushort maxActual = ZEnumerable.Max(source);
            ushort maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxushortList100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ushort) r.Next(ushort.MaxValue) } , 100).ToList();
            ushort maxActual = ZEnumerable.Max(source, arg => arg.X);
            ushort maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxushortList100Null()
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
        public void TestMaxushortList100MapNull()
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
        public void TestMaxushortIList100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ushort) r.Next(ushort.MaxValue), 100).ToIList();
            ushort maxActual = ZEnumerable.Max(source);
            ushort maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxushortIList100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ushort) r.Next(ushort.MaxValue) } , 100).ToIList();
            ushort maxActual = ZEnumerable.Max(source, arg => arg.X);
            ushort maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxushortIList100Null()
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
        public void TestMaxushortIList100MapNull()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<ushort,ushort>((ushort) arg, (ushort) arg)).ToIList();
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
        public void TestMaxintArray100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (int) r.Next(int.MaxValue), 100).ToArray();
            int maxActual = ZEnumerable.Max(source);
            int maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxintArray100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (int) r.Next(int.MaxValue) } , 100).ToArray();
            int maxActual = ZEnumerable.Max(source, arg => arg.X);
            int maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxintArray100Null()
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
        public void TestMaxintArray100MapNull()
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
        public void TestMaxintList100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (int) r.Next(int.MaxValue), 100).ToList();
            int maxActual = ZEnumerable.Max(source);
            int maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxintList100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (int) r.Next(int.MaxValue) } , 100).ToList();
            int maxActual = ZEnumerable.Max(source, arg => arg.X);
            int maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxintList100Null()
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
        public void TestMaxintList100MapNull()
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
        public void TestMaxintIList100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (int) r.Next(int.MaxValue), 100).ToIList();
            int maxActual = ZEnumerable.Max(source);
            int maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxintIList100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (int) r.Next(int.MaxValue) } , 100).ToIList();
            int maxActual = ZEnumerable.Max(source, arg => arg.X);
            int maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxintIList100Null()
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
        public void TestMaxintIList100MapNull()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<int,int>((int) arg, (int) arg)).ToIList();
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
        public void TestMaxuintArray100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (uint) r.Next(int.MaxValue), 100).ToArray();
            uint maxActual = ZEnumerable.Max(source);
            uint maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxuintArray100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (uint) r.Next(int.MaxValue) } , 100).ToArray();
            uint maxActual = ZEnumerable.Max(source, arg => arg.X);
            uint maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxuintArray100Null()
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
        public void TestMaxuintArray100MapNull()
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
        public void TestMaxuintList100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (uint) r.Next(int.MaxValue), 100).ToList();
            uint maxActual = ZEnumerable.Max(source);
            uint maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxuintList100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (uint) r.Next(int.MaxValue) } , 100).ToList();
            uint maxActual = ZEnumerable.Max(source, arg => arg.X);
            uint maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxuintList100Null()
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
        public void TestMaxuintList100MapNull()
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
        public void TestMaxuintIList100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (uint) r.Next(int.MaxValue), 100).ToIList();
            uint maxActual = ZEnumerable.Max(source);
            uint maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxuintIList100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (uint) r.Next(int.MaxValue) } , 100).ToIList();
            uint maxActual = ZEnumerable.Max(source, arg => arg.X);
            uint maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxuintIList100Null()
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
        public void TestMaxuintIList100MapNull()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<uint,uint>((uint) arg, (uint) arg)).ToIList();
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
        public void TestMaxlongArray100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (long) r.Next(int.MaxValue), 100).ToArray();
            long maxActual = ZEnumerable.Max(source);
            long maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxlongArray100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (long) r.Next(int.MaxValue) } , 100).ToArray();
            long maxActual = ZEnumerable.Max(source, arg => arg.X);
            long maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxlongArray100Null()
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
        public void TestMaxlongArray100MapNull()
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
        public void TestMaxlongList100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (long) r.Next(int.MaxValue), 100).ToList();
            long maxActual = ZEnumerable.Max(source);
            long maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxlongList100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (long) r.Next(int.MaxValue) } , 100).ToList();
            long maxActual = ZEnumerable.Max(source, arg => arg.X);
            long maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxlongList100Null()
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
        public void TestMaxlongList100MapNull()
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
        public void TestMaxlongIList100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (long) r.Next(int.MaxValue), 100).ToIList();
            long maxActual = ZEnumerable.Max(source);
            long maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxlongIList100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (long) r.Next(int.MaxValue) } , 100).ToIList();
            long maxActual = ZEnumerable.Max(source, arg => arg.X);
            long maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxlongIList100Null()
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
        public void TestMaxlongIList100MapNull()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<long,long>((long) arg, (long) arg)).ToIList();
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
        public void TestMaxfloatArray100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (float) r.Next(int.MaxValue), 100).ToArray();
            float maxActual = ZEnumerable.Max(source);
            float maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxfloatArray100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (float) r.Next(int.MaxValue) } , 100).ToArray();
            float maxActual = ZEnumerable.Max(source, arg => arg.X);
            float maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxfloatArray100Null()
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
        public void TestMaxfloatArray100MapNull()
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
        public void TestMaxfloatList100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (float) r.Next(int.MaxValue), 100).ToList();
            float maxActual = ZEnumerable.Max(source);
            float maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxfloatList100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (float) r.Next(int.MaxValue) } , 100).ToList();
            float maxActual = ZEnumerable.Max(source, arg => arg.X);
            float maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxfloatList100Null()
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
        public void TestMaxfloatList100MapNull()
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
        public void TestMaxfloatIList100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (float) r.Next(int.MaxValue), 100).ToIList();
            float maxActual = ZEnumerable.Max(source);
            float maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxfloatIList100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (float) r.Next(int.MaxValue) } , 100).ToIList();
            float maxActual = ZEnumerable.Max(source, arg => arg.X);
            float maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxfloatIList100Null()
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
        public void TestMaxfloatIList100MapNull()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<float,float>((float) arg, (float) arg)).ToIList();
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
        public void TestMaxdoubleArray100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (double) r.Next(int.MaxValue), 100).ToArray();
            double maxActual = ZEnumerable.Max(source);
            double maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdoubleArray100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (double) r.Next(int.MaxValue) } , 100).ToArray();
            double maxActual = ZEnumerable.Max(source, arg => arg.X);
            double maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxdoubleArray100Null()
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
        public void TestMaxdoubleArray100MapNull()
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
        public void TestMaxdoubleList100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (double) r.Next(int.MaxValue), 100).ToList();
            double maxActual = ZEnumerable.Max(source);
            double maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdoubleList100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (double) r.Next(int.MaxValue) } , 100).ToList();
            double maxActual = ZEnumerable.Max(source, arg => arg.X);
            double maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxdoubleList100Null()
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
        public void TestMaxdoubleList100MapNull()
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
        public void TestMaxdoubleIList100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (double) r.Next(int.MaxValue), 100).ToIList();
            double maxActual = ZEnumerable.Max(source);
            double maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdoubleIList100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (double) r.Next(int.MaxValue) } , 100).ToIList();
            double maxActual = ZEnumerable.Max(source, arg => arg.X);
            double maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxdoubleIList100Null()
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
        public void TestMaxdoubleIList100MapNull()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<double,double>((double) arg, (double) arg)).ToIList();
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
        public void TestMaxdecimalArray100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (decimal) r.Next(int.MaxValue), 100).ToArray();
            decimal maxActual = ZEnumerable.Max(source);
            decimal maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdecimalArray100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (decimal) r.Next(int.MaxValue) } , 100).ToArray();
            decimal maxActual = ZEnumerable.Max(source, arg => arg.X);
            decimal maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxdecimalArray100Null()
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
        public void TestMaxdecimalArray100MapNull()
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
        public void TestMaxdecimalList100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (decimal) r.Next(int.MaxValue), 100).ToList();
            decimal maxActual = ZEnumerable.Max(source);
            decimal maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdecimalList100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (decimal) r.Next(int.MaxValue) } , 100).ToList();
            decimal maxActual = ZEnumerable.Max(source, arg => arg.X);
            decimal maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxdecimalList100Null()
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
        public void TestMaxdecimalList100MapNull()
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
        public void TestMaxdecimalIList100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (decimal) r.Next(int.MaxValue), 100).ToIList();
            decimal maxActual = ZEnumerable.Max(source);
            decimal maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdecimalIList100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (decimal) r.Next(int.MaxValue) } , 100).ToIList();
            decimal maxActual = ZEnumerable.Max(source, arg => arg.X);
            decimal maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxdecimalIList100Null()
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
        public void TestMaxdecimalIList100MapNull()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<decimal,decimal>((decimal) arg, (decimal) arg)).ToIList();
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
        public void TestMaxulongArray100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ulong) r.Next(int.MaxValue), 100).ToArray();
            ulong maxActual = ZEnumerable.Max(source);
            ulong maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxulongArray100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ulong) r.Next(int.MaxValue) } , 100).ToArray();
            ulong maxActual = ZEnumerable.Max(source, arg => arg.X);
            ulong maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxulongArray100Null()
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
        public void TestMaxulongArray100MapNull()
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
        public void TestMaxulongList100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ulong) r.Next(int.MaxValue), 100).ToList();
            ulong maxActual = ZEnumerable.Max(source);
            ulong maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxulongList100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ulong) r.Next(int.MaxValue) } , 100).ToList();
            ulong maxActual = ZEnumerable.Max(source, arg => arg.X);
            ulong maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxulongList100Null()
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
        public void TestMaxulongList100MapNull()
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
        public void TestMaxulongIList100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ulong) r.Next(int.MaxValue), 100).ToIList();
            ulong maxActual = ZEnumerable.Max(source);
            ulong maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxulongIList100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ulong) r.Next(int.MaxValue) } , 100).ToIList();
            ulong maxActual = ZEnumerable.Max(source, arg => arg.X);
            ulong maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxulongIList100Null()
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
        public void TestMaxulongIList100MapNull()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<ulong,ulong>((ulong) arg, (ulong) arg)).ToIList();
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
    
        #region sbyte?             
            
        
        [TestMethod]
        public void TestMaxsbyteNullableArray100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (sbyte?) r.Next(sbyte.MaxValue), 100).ToArray();
            sbyte? maxActual = ZEnumerable.Max(source);
            sbyte? maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxsbyteNullableArray100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (sbyte?) r.Next(sbyte.MaxValue) } , 100).ToArray();
            sbyte? maxActual = ZEnumerable.Max(source, arg => arg.X);
            sbyte? maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxsbyteNullableArray100Null()
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
        }

        [TestMethod]
        public void TestMaxsbyteNullableArray100MapNull()
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
        }
            
        
        [TestMethod]
        public void TestMaxsbyteNullableList100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (sbyte?) r.Next(sbyte.MaxValue), 100).ToList();
            sbyte? maxActual = ZEnumerable.Max(source);
            sbyte? maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxsbyteNullableList100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (sbyte?) r.Next(sbyte.MaxValue) } , 100).ToList();
            sbyte? maxActual = ZEnumerable.Max(source, arg => arg.X);
            sbyte? maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxsbyteNullableList100Null()
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
        }

        [TestMethod]
        public void TestMaxsbyteNullableList100MapNull()
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
        }
            
        
        [TestMethod]
        public void TestMaxsbyteNullableIList100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (sbyte?) r.Next(sbyte.MaxValue), 100).ToIList();
            sbyte? maxActual = ZEnumerable.Max(source);
            sbyte? maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxsbyteNullableIList100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (sbyte?) r.Next(sbyte.MaxValue) } , 100).ToIList();
            sbyte? maxActual = ZEnumerable.Max(source, arg => arg.X);
            sbyte? maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxsbyteNullableIList100Null()
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
        }

        [TestMethod]
        public void TestMaxsbyteNullableIList100MapNull()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<sbyte?,sbyte?>((sbyte?) arg, (sbyte?) arg)).ToIList();
            Func<KeyValuePair<sbyte?, sbyte?>, sbyte?> map = null;
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
    
        #region byte?             
            
        
        [TestMethod]
        public void TestMaxbyteNullableArray100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (byte?) r.Next(byte.MaxValue), 100).ToArray();
            byte? maxActual = ZEnumerable.Max(source);
            byte? maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxbyteNullableArray100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (byte?) r.Next(byte.MaxValue) } , 100).ToArray();
            byte? maxActual = ZEnumerable.Max(source, arg => arg.X);
            byte? maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxbyteNullableArray100Null()
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
        }

        [TestMethod]
        public void TestMaxbyteNullableArray100MapNull()
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
        }
            
        
        [TestMethod]
        public void TestMaxbyteNullableList100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (byte?) r.Next(byte.MaxValue), 100).ToList();
            byte? maxActual = ZEnumerable.Max(source);
            byte? maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxbyteNullableList100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (byte?) r.Next(byte.MaxValue) } , 100).ToList();
            byte? maxActual = ZEnumerable.Max(source, arg => arg.X);
            byte? maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxbyteNullableList100Null()
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
        }

        [TestMethod]
        public void TestMaxbyteNullableList100MapNull()
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
        }
            
        
        [TestMethod]
        public void TestMaxbyteNullableIList100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (byte?) r.Next(byte.MaxValue), 100).ToIList();
            byte? maxActual = ZEnumerable.Max(source);
            byte? maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxbyteNullableIList100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (byte?) r.Next(byte.MaxValue) } , 100).ToIList();
            byte? maxActual = ZEnumerable.Max(source, arg => arg.X);
            byte? maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxbyteNullableIList100Null()
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
        }

        [TestMethod]
        public void TestMaxbyteNullableIList100MapNull()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<byte?,byte?>((byte?) arg, (byte?) arg)).ToIList();
            Func<KeyValuePair<byte?, byte?>, byte?> map = null;
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
    
        #region short?             
            
        
        [TestMethod]
        public void TestMaxshortNullableArray100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (short?) r.Next(short.MaxValue), 100).ToArray();
            short? maxActual = ZEnumerable.Max(source);
            short? maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxshortNullableArray100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (short?) r.Next(short.MaxValue) } , 100).ToArray();
            short? maxActual = ZEnumerable.Max(source, arg => arg.X);
            short? maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxshortNullableArray100Null()
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
        }

        [TestMethod]
        public void TestMaxshortNullableArray100MapNull()
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
        }
            
        
        [TestMethod]
        public void TestMaxshortNullableList100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (short?) r.Next(short.MaxValue), 100).ToList();
            short? maxActual = ZEnumerable.Max(source);
            short? maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxshortNullableList100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (short?) r.Next(short.MaxValue) } , 100).ToList();
            short? maxActual = ZEnumerable.Max(source, arg => arg.X);
            short? maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxshortNullableList100Null()
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
        }

        [TestMethod]
        public void TestMaxshortNullableList100MapNull()
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
        }
            
        
        [TestMethod]
        public void TestMaxshortNullableIList100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (short?) r.Next(short.MaxValue), 100).ToIList();
            short? maxActual = ZEnumerable.Max(source);
            short? maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxshortNullableIList100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (short?) r.Next(short.MaxValue) } , 100).ToIList();
            short? maxActual = ZEnumerable.Max(source, arg => arg.X);
            short? maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxshortNullableIList100Null()
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
        }

        [TestMethod]
        public void TestMaxshortNullableIList100MapNull()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<short?,short?>((short?) arg, (short?) arg)).ToIList();
            Func<KeyValuePair<short?, short?>, short?> map = null;
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
    
        #region ushort?             
            
        
        [TestMethod]
        public void TestMaxushortNullableArray100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ushort?) r.Next(ushort.MaxValue), 100).ToArray();
            ushort? maxActual = ZEnumerable.Max(source);
            ushort? maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxushortNullableArray100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ushort?) r.Next(ushort.MaxValue) } , 100).ToArray();
            ushort? maxActual = ZEnumerable.Max(source, arg => arg.X);
            ushort? maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxushortNullableArray100Null()
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
        }

        [TestMethod]
        public void TestMaxushortNullableArray100MapNull()
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
        }
            
        
        [TestMethod]
        public void TestMaxushortNullableList100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ushort?) r.Next(ushort.MaxValue), 100).ToList();
            ushort? maxActual = ZEnumerable.Max(source);
            ushort? maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxushortNullableList100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ushort?) r.Next(ushort.MaxValue) } , 100).ToList();
            ushort? maxActual = ZEnumerable.Max(source, arg => arg.X);
            ushort? maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxushortNullableList100Null()
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
        }

        [TestMethod]
        public void TestMaxushortNullableList100MapNull()
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
        }
            
        
        [TestMethod]
        public void TestMaxushortNullableIList100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ushort?) r.Next(ushort.MaxValue), 100).ToIList();
            ushort? maxActual = ZEnumerable.Max(source);
            ushort? maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxushortNullableIList100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ushort?) r.Next(ushort.MaxValue) } , 100).ToIList();
            ushort? maxActual = ZEnumerable.Max(source, arg => arg.X);
            ushort? maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxushortNullableIList100Null()
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
        }

        [TestMethod]
        public void TestMaxushortNullableIList100MapNull()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<ushort?,ushort?>((ushort?) arg, (ushort?) arg)).ToIList();
            Func<KeyValuePair<ushort?, ushort?>, ushort?> map = null;
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
    
        #region int?             
            
        
        [TestMethod]
        public void TestMaxintNullableArray100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (int?) r.Next(int.MaxValue), 100).ToArray();
            int? maxActual = ZEnumerable.Max(source);
            int? maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxintNullableArray100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (int?) r.Next(int.MaxValue) } , 100).ToArray();
            int? maxActual = ZEnumerable.Max(source, arg => arg.X);
            int? maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxintNullableArray100Null()
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
        }

        [TestMethod]
        public void TestMaxintNullableArray100MapNull()
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
        }
            
        
        [TestMethod]
        public void TestMaxintNullableList100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (int?) r.Next(int.MaxValue), 100).ToList();
            int? maxActual = ZEnumerable.Max(source);
            int? maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxintNullableList100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (int?) r.Next(int.MaxValue) } , 100).ToList();
            int? maxActual = ZEnumerable.Max(source, arg => arg.X);
            int? maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxintNullableList100Null()
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
        }

        [TestMethod]
        public void TestMaxintNullableList100MapNull()
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
        }
            
        
        [TestMethod]
        public void TestMaxintNullableIList100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (int?) r.Next(int.MaxValue), 100).ToIList();
            int? maxActual = ZEnumerable.Max(source);
            int? maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxintNullableIList100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (int?) r.Next(int.MaxValue) } , 100).ToIList();
            int? maxActual = ZEnumerable.Max(source, arg => arg.X);
            int? maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxintNullableIList100Null()
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
        }

        [TestMethod]
        public void TestMaxintNullableIList100MapNull()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<int?,int?>((int?) arg, (int?) arg)).ToIList();
            Func<KeyValuePair<int?, int?>, int?> map = null;
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
    
        #region uint?             
            
        
        [TestMethod]
        public void TestMaxuintNullableArray100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (uint?) r.Next(int.MaxValue), 100).ToArray();
            uint? maxActual = ZEnumerable.Max(source);
            uint? maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxuintNullableArray100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (uint?) r.Next(int.MaxValue) } , 100).ToArray();
            uint? maxActual = ZEnumerable.Max(source, arg => arg.X);
            uint? maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxuintNullableArray100Null()
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
        }

        [TestMethod]
        public void TestMaxuintNullableArray100MapNull()
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
        }
            
        
        [TestMethod]
        public void TestMaxuintNullableList100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (uint?) r.Next(int.MaxValue), 100).ToList();
            uint? maxActual = ZEnumerable.Max(source);
            uint? maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxuintNullableList100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (uint?) r.Next(int.MaxValue) } , 100).ToList();
            uint? maxActual = ZEnumerable.Max(source, arg => arg.X);
            uint? maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxuintNullableList100Null()
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
        }

        [TestMethod]
        public void TestMaxuintNullableList100MapNull()
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
        }
            
        
        [TestMethod]
        public void TestMaxuintNullableIList100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (uint?) r.Next(int.MaxValue), 100).ToIList();
            uint? maxActual = ZEnumerable.Max(source);
            uint? maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxuintNullableIList100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (uint?) r.Next(int.MaxValue) } , 100).ToIList();
            uint? maxActual = ZEnumerable.Max(source, arg => arg.X);
            uint? maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxuintNullableIList100Null()
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
        }

        [TestMethod]
        public void TestMaxuintNullableIList100MapNull()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<uint?,uint?>((uint?) arg, (uint?) arg)).ToIList();
            Func<KeyValuePair<uint?, uint?>, uint?> map = null;
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
    
        #region long?             
            
        
        [TestMethod]
        public void TestMaxlongNullableArray100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (long?) r.Next(int.MaxValue), 100).ToArray();
            long? maxActual = ZEnumerable.Max(source);
            long? maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxlongNullableArray100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (long?) r.Next(int.MaxValue) } , 100).ToArray();
            long? maxActual = ZEnumerable.Max(source, arg => arg.X);
            long? maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxlongNullableArray100Null()
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
        }

        [TestMethod]
        public void TestMaxlongNullableArray100MapNull()
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
        }
            
        
        [TestMethod]
        public void TestMaxlongNullableList100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (long?) r.Next(int.MaxValue), 100).ToList();
            long? maxActual = ZEnumerable.Max(source);
            long? maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxlongNullableList100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (long?) r.Next(int.MaxValue) } , 100).ToList();
            long? maxActual = ZEnumerable.Max(source, arg => arg.X);
            long? maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxlongNullableList100Null()
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
        }

        [TestMethod]
        public void TestMaxlongNullableList100MapNull()
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
        }
            
        
        [TestMethod]
        public void TestMaxlongNullableIList100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (long?) r.Next(int.MaxValue), 100).ToIList();
            long? maxActual = ZEnumerable.Max(source);
            long? maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxlongNullableIList100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (long?) r.Next(int.MaxValue) } , 100).ToIList();
            long? maxActual = ZEnumerable.Max(source, arg => arg.X);
            long? maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxlongNullableIList100Null()
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
        }

        [TestMethod]
        public void TestMaxlongNullableIList100MapNull()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<long?,long?>((long?) arg, (long?) arg)).ToIList();
            Func<KeyValuePair<long?, long?>, long?> map = null;
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
    
        #region float?             
            
        
        [TestMethod]
        public void TestMaxfloatNullableArray100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (float?) r.Next(int.MaxValue), 100).ToArray();
            float? maxActual = ZEnumerable.Max(source);
            float? maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxfloatNullableArray100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (float?) r.Next(int.MaxValue) } , 100).ToArray();
            float? maxActual = ZEnumerable.Max(source, arg => arg.X);
            float? maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxfloatNullableArray100Null()
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
        }

        [TestMethod]
        public void TestMaxfloatNullableArray100MapNull()
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
        }
            
        
        [TestMethod]
        public void TestMaxfloatNullableList100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (float?) r.Next(int.MaxValue), 100).ToList();
            float? maxActual = ZEnumerable.Max(source);
            float? maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxfloatNullableList100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (float?) r.Next(int.MaxValue) } , 100).ToList();
            float? maxActual = ZEnumerable.Max(source, arg => arg.X);
            float? maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxfloatNullableList100Null()
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
        }

        [TestMethod]
        public void TestMaxfloatNullableList100MapNull()
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
        }
            
        
        [TestMethod]
        public void TestMaxfloatNullableIList100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (float?) r.Next(int.MaxValue), 100).ToIList();
            float? maxActual = ZEnumerable.Max(source);
            float? maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxfloatNullableIList100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (float?) r.Next(int.MaxValue) } , 100).ToIList();
            float? maxActual = ZEnumerable.Max(source, arg => arg.X);
            float? maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxfloatNullableIList100Null()
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
        }

        [TestMethod]
        public void TestMaxfloatNullableIList100MapNull()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<float?,float?>((float?) arg, (float?) arg)).ToIList();
            Func<KeyValuePair<float?, float?>, float?> map = null;
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
    
        #region double?             
            
        
        [TestMethod]
        public void TestMaxdoubleNullableArray100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (double?) r.Next(int.MaxValue), 100).ToArray();
            double? maxActual = ZEnumerable.Max(source);
            double? maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdoubleNullableArray100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (double?) r.Next(int.MaxValue) } , 100).ToArray();
            double? maxActual = ZEnumerable.Max(source, arg => arg.X);
            double? maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxdoubleNullableArray100Null()
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
        }

        [TestMethod]
        public void TestMaxdoubleNullableArray100MapNull()
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
        }
            
        
        [TestMethod]
        public void TestMaxdoubleNullableList100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (double?) r.Next(int.MaxValue), 100).ToList();
            double? maxActual = ZEnumerable.Max(source);
            double? maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdoubleNullableList100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (double?) r.Next(int.MaxValue) } , 100).ToList();
            double? maxActual = ZEnumerable.Max(source, arg => arg.X);
            double? maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxdoubleNullableList100Null()
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
        }

        [TestMethod]
        public void TestMaxdoubleNullableList100MapNull()
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
        }
            
        
        [TestMethod]
        public void TestMaxdoubleNullableIList100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (double?) r.Next(int.MaxValue), 100).ToIList();
            double? maxActual = ZEnumerable.Max(source);
            double? maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdoubleNullableIList100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (double?) r.Next(int.MaxValue) } , 100).ToIList();
            double? maxActual = ZEnumerable.Max(source, arg => arg.X);
            double? maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxdoubleNullableIList100Null()
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
        }

        [TestMethod]
        public void TestMaxdoubleNullableIList100MapNull()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<double?,double?>((double?) arg, (double?) arg)).ToIList();
            Func<KeyValuePair<double?, double?>, double?> map = null;
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
    
        #region decimal?             
            
        
        [TestMethod]
        public void TestMaxdecimalNullableArray100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (decimal?) r.Next(int.MaxValue), 100).ToArray();
            decimal? maxActual = ZEnumerable.Max(source);
            decimal? maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdecimalNullableArray100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (decimal?) r.Next(int.MaxValue) } , 100).ToArray();
            decimal? maxActual = ZEnumerable.Max(source, arg => arg.X);
            decimal? maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxdecimalNullableArray100Null()
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
        }

        [TestMethod]
        public void TestMaxdecimalNullableArray100MapNull()
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
        }
            
        
        [TestMethod]
        public void TestMaxdecimalNullableList100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (decimal?) r.Next(int.MaxValue), 100).ToList();
            decimal? maxActual = ZEnumerable.Max(source);
            decimal? maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdecimalNullableList100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (decimal?) r.Next(int.MaxValue) } , 100).ToList();
            decimal? maxActual = ZEnumerable.Max(source, arg => arg.X);
            decimal? maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxdecimalNullableList100Null()
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
        }

        [TestMethod]
        public void TestMaxdecimalNullableList100MapNull()
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
        }
            
        
        [TestMethod]
        public void TestMaxdecimalNullableIList100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (decimal?) r.Next(int.MaxValue), 100).ToIList();
            decimal? maxActual = ZEnumerable.Max(source);
            decimal? maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdecimalNullableIList100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (decimal?) r.Next(int.MaxValue) } , 100).ToIList();
            decimal? maxActual = ZEnumerable.Max(source, arg => arg.X);
            decimal? maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxdecimalNullableIList100Null()
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
        }

        [TestMethod]
        public void TestMaxdecimalNullableIList100MapNull()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<decimal?,decimal?>((decimal?) arg, (decimal?) arg)).ToIList();
            Func<KeyValuePair<decimal?, decimal?>, decimal?> map = null;
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
    
        #region ulong?             
            
        
        [TestMethod]
        public void TestMaxulongNullableArray100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ulong?) r.Next(int.MaxValue), 100).ToArray();
            ulong? maxActual = ZEnumerable.Max(source);
            ulong? maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxulongNullableArray100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ulong?) r.Next(int.MaxValue) } , 100).ToArray();
            ulong? maxActual = ZEnumerable.Max(source, arg => arg.X);
            ulong? maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxulongNullableArray100Null()
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
        }

        [TestMethod]
        public void TestMaxulongNullableArray100MapNull()
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
        }
            
        
        [TestMethod]
        public void TestMaxulongNullableList100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ulong?) r.Next(int.MaxValue), 100).ToList();
            ulong? maxActual = ZEnumerable.Max(source);
            ulong? maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxulongNullableList100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ulong?) r.Next(int.MaxValue) } , 100).ToList();
            ulong? maxActual = ZEnumerable.Max(source, arg => arg.X);
            ulong? maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxulongNullableList100Null()
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
        }

        [TestMethod]
        public void TestMaxulongNullableList100MapNull()
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
        }
            
        
        [TestMethod]
        public void TestMaxulongNullableIList100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ulong?) r.Next(int.MaxValue), 100).ToIList();
            ulong? maxActual = ZEnumerable.Max(source);
            ulong? maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxulongNullableIList100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ulong?) r.Next(int.MaxValue) } , 100).ToIList();
            ulong? maxActual = ZEnumerable.Max(source, arg => arg.X);
            ulong? maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxulongNullableIList100Null()
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
        }

        [TestMethod]
        public void TestMaxulongNullableIList100MapNull()
        {
            var source = Enumerable.Range(1, 100).Select(arg => new KeyValuePair<ulong?,ulong?>((ulong?) arg, (ulong?) arg)).ToIList();
            Func<KeyValuePair<ulong?, ulong?>, ulong?> map = null;
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
        


    
                
    
        #region sbyte             
            
            
        [TestMethod]
        public void TestMaxsbyteArray2049Null()
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
        public void TestMaxsbyteArray2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<sbyte,sbyte>((sbyte) arg, (sbyte) arg)).ToArray();
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
        public void TestMaxsbyteList2049Null()
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
        public void TestMaxsbyteList2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<sbyte,sbyte>((sbyte) arg, (sbyte) arg)).ToList();
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
        public void TestMaxsbyteIList2049Null()
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
        public void TestMaxsbyteIList2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<sbyte,sbyte>((sbyte) arg, (sbyte) arg)).ToIList();
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
        public void TestMaxbyteArray2049Null()
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
        public void TestMaxbyteArray2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<byte,byte>((byte) arg, (byte) arg)).ToArray();
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
        public void TestMaxbyteList2049Null()
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
        public void TestMaxbyteList2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<byte,byte>((byte) arg, (byte) arg)).ToList();
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
        public void TestMaxbyteIList2049Null()
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
        public void TestMaxbyteIList2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<byte,byte>((byte) arg, (byte) arg)).ToIList();
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
        public void TestMaxshortArray2049()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (short) r.Next(short.MaxValue), 2049).ToArray();
            short maxActual = ZEnumerable.Max(source);
            short maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxshortArray2049Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (short) r.Next(short.MaxValue) } , 2049).ToArray();
            short maxActual = ZEnumerable.Max(source, arg => arg.X);
            short maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxshortArray2049Null()
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
        public void TestMaxshortArray2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<short,short>((short) arg, (short) arg)).ToArray();
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
        public void TestMaxshortList2049()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (short) r.Next(short.MaxValue), 2049).ToList();
            short maxActual = ZEnumerable.Max(source);
            short maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxshortList2049Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (short) r.Next(short.MaxValue) } , 2049).ToList();
            short maxActual = ZEnumerable.Max(source, arg => arg.X);
            short maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxshortList2049Null()
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
        public void TestMaxshortList2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<short,short>((short) arg, (short) arg)).ToList();
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
        public void TestMaxshortIList2049()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (short) r.Next(short.MaxValue), 2049).ToIList();
            short maxActual = ZEnumerable.Max(source);
            short maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxshortIList2049Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (short) r.Next(short.MaxValue) } , 2049).ToIList();
            short maxActual = ZEnumerable.Max(source, arg => arg.X);
            short maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxshortIList2049Null()
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
        public void TestMaxshortIList2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<short,short>((short) arg, (short) arg)).ToIList();
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
        public void TestMaxushortArray2049()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ushort) r.Next(ushort.MaxValue), 2049).ToArray();
            ushort maxActual = ZEnumerable.Max(source);
            ushort maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxushortArray2049Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ushort) r.Next(ushort.MaxValue) } , 2049).ToArray();
            ushort maxActual = ZEnumerable.Max(source, arg => arg.X);
            ushort maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxushortArray2049Null()
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
        public void TestMaxushortArray2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<ushort,ushort>((ushort) arg, (ushort) arg)).ToArray();
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
        public void TestMaxushortList2049()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ushort) r.Next(ushort.MaxValue), 2049).ToList();
            ushort maxActual = ZEnumerable.Max(source);
            ushort maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxushortList2049Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ushort) r.Next(ushort.MaxValue) } , 2049).ToList();
            ushort maxActual = ZEnumerable.Max(source, arg => arg.X);
            ushort maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxushortList2049Null()
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
        public void TestMaxushortList2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<ushort,ushort>((ushort) arg, (ushort) arg)).ToList();
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
        public void TestMaxushortIList2049()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ushort) r.Next(ushort.MaxValue), 2049).ToIList();
            ushort maxActual = ZEnumerable.Max(source);
            ushort maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxushortIList2049Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ushort) r.Next(ushort.MaxValue) } , 2049).ToIList();
            ushort maxActual = ZEnumerable.Max(source, arg => arg.X);
            ushort maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxushortIList2049Null()
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
        public void TestMaxushortIList2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<ushort,ushort>((ushort) arg, (ushort) arg)).ToIList();
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
        public void TestMaxintArray2049()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (int) r.Next(int.MaxValue), 2049).ToArray();
            int maxActual = ZEnumerable.Max(source);
            int maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxintArray2049Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (int) r.Next(int.MaxValue) } , 2049).ToArray();
            int maxActual = ZEnumerable.Max(source, arg => arg.X);
            int maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxintArray2049Null()
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
        public void TestMaxintArray2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<int,int>((int) arg, (int) arg)).ToArray();
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
        public void TestMaxintList2049()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (int) r.Next(int.MaxValue), 2049).ToList();
            int maxActual = ZEnumerable.Max(source);
            int maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxintList2049Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (int) r.Next(int.MaxValue) } , 2049).ToList();
            int maxActual = ZEnumerable.Max(source, arg => arg.X);
            int maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxintList2049Null()
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
        public void TestMaxintList2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<int,int>((int) arg, (int) arg)).ToList();
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
        public void TestMaxintIList2049()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (int) r.Next(int.MaxValue), 2049).ToIList();
            int maxActual = ZEnumerable.Max(source);
            int maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxintIList2049Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (int) r.Next(int.MaxValue) } , 2049).ToIList();
            int maxActual = ZEnumerable.Max(source, arg => arg.X);
            int maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxintIList2049Null()
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
        public void TestMaxintIList2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<int,int>((int) arg, (int) arg)).ToIList();
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
        public void TestMaxuintArray2049()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (uint) r.Next(int.MaxValue), 2049).ToArray();
            uint maxActual = ZEnumerable.Max(source);
            uint maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxuintArray2049Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (uint) r.Next(int.MaxValue) } , 2049).ToArray();
            uint maxActual = ZEnumerable.Max(source, arg => arg.X);
            uint maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxuintArray2049Null()
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
        public void TestMaxuintArray2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<uint,uint>((uint) arg, (uint) arg)).ToArray();
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
        public void TestMaxuintList2049()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (uint) r.Next(int.MaxValue), 2049).ToList();
            uint maxActual = ZEnumerable.Max(source);
            uint maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxuintList2049Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (uint) r.Next(int.MaxValue) } , 2049).ToList();
            uint maxActual = ZEnumerable.Max(source, arg => arg.X);
            uint maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxuintList2049Null()
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
        public void TestMaxuintList2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<uint,uint>((uint) arg, (uint) arg)).ToList();
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
        public void TestMaxuintIList2049()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (uint) r.Next(int.MaxValue), 2049).ToIList();
            uint maxActual = ZEnumerable.Max(source);
            uint maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxuintIList2049Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (uint) r.Next(int.MaxValue) } , 2049).ToIList();
            uint maxActual = ZEnumerable.Max(source, arg => arg.X);
            uint maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxuintIList2049Null()
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
        public void TestMaxuintIList2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<uint,uint>((uint) arg, (uint) arg)).ToIList();
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
        public void TestMaxlongArray2049()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (long) r.Next(int.MaxValue), 2049).ToArray();
            long maxActual = ZEnumerable.Max(source);
            long maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxlongArray2049Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (long) r.Next(int.MaxValue) } , 2049).ToArray();
            long maxActual = ZEnumerable.Max(source, arg => arg.X);
            long maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxlongArray2049Null()
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
        public void TestMaxlongArray2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<long,long>((long) arg, (long) arg)).ToArray();
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
        public void TestMaxlongList2049()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (long) r.Next(int.MaxValue), 2049).ToList();
            long maxActual = ZEnumerable.Max(source);
            long maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxlongList2049Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (long) r.Next(int.MaxValue) } , 2049).ToList();
            long maxActual = ZEnumerable.Max(source, arg => arg.X);
            long maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxlongList2049Null()
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
        public void TestMaxlongList2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<long,long>((long) arg, (long) arg)).ToList();
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
        public void TestMaxlongIList2049()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (long) r.Next(int.MaxValue), 2049).ToIList();
            long maxActual = ZEnumerable.Max(source);
            long maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxlongIList2049Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (long) r.Next(int.MaxValue) } , 2049).ToIList();
            long maxActual = ZEnumerable.Max(source, arg => arg.X);
            long maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxlongIList2049Null()
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
        public void TestMaxlongIList2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<long,long>((long) arg, (long) arg)).ToIList();
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
        public void TestMaxfloatArray2049()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (float) r.Next(int.MaxValue), 2049).ToArray();
            float maxActual = ZEnumerable.Max(source);
            float maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxfloatArray2049Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (float) r.Next(int.MaxValue) } , 2049).ToArray();
            float maxActual = ZEnumerable.Max(source, arg => arg.X);
            float maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxfloatArray2049Null()
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
        public void TestMaxfloatArray2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<float,float>((float) arg, (float) arg)).ToArray();
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
        public void TestMaxfloatList2049()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (float) r.Next(int.MaxValue), 2049).ToList();
            float maxActual = ZEnumerable.Max(source);
            float maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxfloatList2049Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (float) r.Next(int.MaxValue) } , 2049).ToList();
            float maxActual = ZEnumerable.Max(source, arg => arg.X);
            float maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxfloatList2049Null()
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
        public void TestMaxfloatList2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<float,float>((float) arg, (float) arg)).ToList();
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
        public void TestMaxfloatIList2049()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (float) r.Next(int.MaxValue), 2049).ToIList();
            float maxActual = ZEnumerable.Max(source);
            float maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxfloatIList2049Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (float) r.Next(int.MaxValue) } , 2049).ToIList();
            float maxActual = ZEnumerable.Max(source, arg => arg.X);
            float maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxfloatIList2049Null()
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
        public void TestMaxfloatIList2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<float,float>((float) arg, (float) arg)).ToIList();
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
        public void TestMaxdoubleArray2049()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (double) r.Next(int.MaxValue), 2049).ToArray();
            double maxActual = ZEnumerable.Max(source);
            double maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdoubleArray2049Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (double) r.Next(int.MaxValue) } , 2049).ToArray();
            double maxActual = ZEnumerable.Max(source, arg => arg.X);
            double maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxdoubleArray2049Null()
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
        public void TestMaxdoubleArray2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<double,double>((double) arg, (double) arg)).ToArray();
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
        public void TestMaxdoubleList2049()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (double) r.Next(int.MaxValue), 2049).ToList();
            double maxActual = ZEnumerable.Max(source);
            double maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdoubleList2049Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (double) r.Next(int.MaxValue) } , 2049).ToList();
            double maxActual = ZEnumerable.Max(source, arg => arg.X);
            double maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxdoubleList2049Null()
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
        public void TestMaxdoubleList2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<double,double>((double) arg, (double) arg)).ToList();
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
        public void TestMaxdoubleIList2049()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (double) r.Next(int.MaxValue), 2049).ToIList();
            double maxActual = ZEnumerable.Max(source);
            double maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdoubleIList2049Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (double) r.Next(int.MaxValue) } , 2049).ToIList();
            double maxActual = ZEnumerable.Max(source, arg => arg.X);
            double maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxdoubleIList2049Null()
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
        public void TestMaxdoubleIList2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<double,double>((double) arg, (double) arg)).ToIList();
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
        public void TestMaxdecimalArray2049()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (decimal) r.Next(int.MaxValue), 2049).ToArray();
            decimal maxActual = ZEnumerable.Max(source);
            decimal maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdecimalArray2049Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (decimal) r.Next(int.MaxValue) } , 2049).ToArray();
            decimal maxActual = ZEnumerable.Max(source, arg => arg.X);
            decimal maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxdecimalArray2049Null()
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
        public void TestMaxdecimalArray2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<decimal,decimal>((decimal) arg, (decimal) arg)).ToArray();
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
        public void TestMaxdecimalList2049()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (decimal) r.Next(int.MaxValue), 2049).ToList();
            decimal maxActual = ZEnumerable.Max(source);
            decimal maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdecimalList2049Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (decimal) r.Next(int.MaxValue) } , 2049).ToList();
            decimal maxActual = ZEnumerable.Max(source, arg => arg.X);
            decimal maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxdecimalList2049Null()
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
        public void TestMaxdecimalList2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<decimal,decimal>((decimal) arg, (decimal) arg)).ToList();
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
        public void TestMaxdecimalIList2049()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (decimal) r.Next(int.MaxValue), 2049).ToIList();
            decimal maxActual = ZEnumerable.Max(source);
            decimal maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdecimalIList2049Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (decimal) r.Next(int.MaxValue) } , 2049).ToIList();
            decimal maxActual = ZEnumerable.Max(source, arg => arg.X);
            decimal maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxdecimalIList2049Null()
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
        public void TestMaxdecimalIList2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<decimal,decimal>((decimal) arg, (decimal) arg)).ToIList();
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
        public void TestMaxulongArray2049()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ulong) r.Next(int.MaxValue), 2049).ToArray();
            ulong maxActual = ZEnumerable.Max(source);
            ulong maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxulongArray2049Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ulong) r.Next(int.MaxValue) } , 2049).ToArray();
            ulong maxActual = ZEnumerable.Max(source, arg => arg.X);
            ulong maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxulongArray2049Null()
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
        public void TestMaxulongArray2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<ulong,ulong>((ulong) arg, (ulong) arg)).ToArray();
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
        public void TestMaxulongList2049()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ulong) r.Next(int.MaxValue), 2049).ToList();
            ulong maxActual = ZEnumerable.Max(source);
            ulong maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxulongList2049Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ulong) r.Next(int.MaxValue) } , 2049).ToList();
            ulong maxActual = ZEnumerable.Max(source, arg => arg.X);
            ulong maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxulongList2049Null()
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
        public void TestMaxulongList2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<ulong,ulong>((ulong) arg, (ulong) arg)).ToList();
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
        public void TestMaxulongIList2049()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ulong) r.Next(int.MaxValue), 2049).ToIList();
            ulong maxActual = ZEnumerable.Max(source);
            ulong maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxulongIList2049Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ulong) r.Next(int.MaxValue) } , 2049).ToIList();
            ulong maxActual = ZEnumerable.Max(source, arg => arg.X);
            ulong maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxulongIList2049Null()
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
        public void TestMaxulongIList2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<ulong,ulong>((ulong) arg, (ulong) arg)).ToIList();
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
    
        #region sbyte?             
            
            
        [TestMethod]
        public void TestMaxsbyteNullableArray2049Null()
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
        }

        [TestMethod]
        public void TestMaxsbyteNullableArray2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<sbyte?,sbyte?>((sbyte?) arg, (sbyte?) arg)).ToArray();
            Func<KeyValuePair<sbyte?, sbyte?>, sbyte?> map = null;
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
        public void TestMaxsbyteNullableList2049Null()
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
        }

        [TestMethod]
        public void TestMaxsbyteNullableList2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<sbyte?,sbyte?>((sbyte?) arg, (sbyte?) arg)).ToList();
            Func<KeyValuePair<sbyte?, sbyte?>, sbyte?> map = null;
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
        public void TestMaxsbyteNullableIList2049Null()
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
        }

        [TestMethod]
        public void TestMaxsbyteNullableIList2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<sbyte?,sbyte?>((sbyte?) arg, (sbyte?) arg)).ToIList();
            Func<KeyValuePair<sbyte?, sbyte?>, sbyte?> map = null;
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
    
        #region byte?             
            
            
        [TestMethod]
        public void TestMaxbyteNullableArray2049Null()
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
        }

        [TestMethod]
        public void TestMaxbyteNullableArray2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<byte?,byte?>((byte?) arg, (byte?) arg)).ToArray();
            Func<KeyValuePair<byte?, byte?>, byte?> map = null;
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
        public void TestMaxbyteNullableList2049Null()
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
        }

        [TestMethod]
        public void TestMaxbyteNullableList2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<byte?,byte?>((byte?) arg, (byte?) arg)).ToList();
            Func<KeyValuePair<byte?, byte?>, byte?> map = null;
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
        public void TestMaxbyteNullableIList2049Null()
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
        }

        [TestMethod]
        public void TestMaxbyteNullableIList2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<byte?,byte?>((byte?) arg, (byte?) arg)).ToIList();
            Func<KeyValuePair<byte?, byte?>, byte?> map = null;
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
    
        #region short?             
            
        
        [TestMethod]
        public void TestMaxshortNullableArray2049()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (short?) r.Next(short.MaxValue), 2049).ToArray();
            short? maxActual = ZEnumerable.Max(source);
            short? maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxshortNullableArray2049Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (short?) r.Next(short.MaxValue) } , 2049).ToArray();
            short? maxActual = ZEnumerable.Max(source, arg => arg.X);
            short? maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxshortNullableArray2049Null()
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
        }

        [TestMethod]
        public void TestMaxshortNullableArray2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<short?,short?>((short?) arg, (short?) arg)).ToArray();
            Func<KeyValuePair<short?, short?>, short?> map = null;
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
        public void TestMaxshortNullableList2049()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (short?) r.Next(short.MaxValue), 2049).ToList();
            short? maxActual = ZEnumerable.Max(source);
            short? maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxshortNullableList2049Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (short?) r.Next(short.MaxValue) } , 2049).ToList();
            short? maxActual = ZEnumerable.Max(source, arg => arg.X);
            short? maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxshortNullableList2049Null()
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
        }

        [TestMethod]
        public void TestMaxshortNullableList2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<short?,short?>((short?) arg, (short?) arg)).ToList();
            Func<KeyValuePair<short?, short?>, short?> map = null;
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
        public void TestMaxshortNullableIList2049()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (short?) r.Next(short.MaxValue), 2049).ToIList();
            short? maxActual = ZEnumerable.Max(source);
            short? maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxshortNullableIList2049Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (short?) r.Next(short.MaxValue) } , 2049).ToIList();
            short? maxActual = ZEnumerable.Max(source, arg => arg.X);
            short? maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxshortNullableIList2049Null()
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
        }

        [TestMethod]
        public void TestMaxshortNullableIList2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<short?,short?>((short?) arg, (short?) arg)).ToIList();
            Func<KeyValuePair<short?, short?>, short?> map = null;
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
    
        #region ushort?             
            
        
        [TestMethod]
        public void TestMaxushortNullableArray2049()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ushort?) r.Next(ushort.MaxValue), 2049).ToArray();
            ushort? maxActual = ZEnumerable.Max(source);
            ushort? maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxushortNullableArray2049Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ushort?) r.Next(ushort.MaxValue) } , 2049).ToArray();
            ushort? maxActual = ZEnumerable.Max(source, arg => arg.X);
            ushort? maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxushortNullableArray2049Null()
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
        }

        [TestMethod]
        public void TestMaxushortNullableArray2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<ushort?,ushort?>((ushort?) arg, (ushort?) arg)).ToArray();
            Func<KeyValuePair<ushort?, ushort?>, ushort?> map = null;
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
        public void TestMaxushortNullableList2049()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ushort?) r.Next(ushort.MaxValue), 2049).ToList();
            ushort? maxActual = ZEnumerable.Max(source);
            ushort? maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxushortNullableList2049Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ushort?) r.Next(ushort.MaxValue) } , 2049).ToList();
            ushort? maxActual = ZEnumerable.Max(source, arg => arg.X);
            ushort? maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxushortNullableList2049Null()
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
        }

        [TestMethod]
        public void TestMaxushortNullableList2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<ushort?,ushort?>((ushort?) arg, (ushort?) arg)).ToList();
            Func<KeyValuePair<ushort?, ushort?>, ushort?> map = null;
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
        public void TestMaxushortNullableIList2049()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ushort?) r.Next(ushort.MaxValue), 2049).ToIList();
            ushort? maxActual = ZEnumerable.Max(source);
            ushort? maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxushortNullableIList2049Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ushort?) r.Next(ushort.MaxValue) } , 2049).ToIList();
            ushort? maxActual = ZEnumerable.Max(source, arg => arg.X);
            ushort? maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxushortNullableIList2049Null()
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
        }

        [TestMethod]
        public void TestMaxushortNullableIList2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<ushort?,ushort?>((ushort?) arg, (ushort?) arg)).ToIList();
            Func<KeyValuePair<ushort?, ushort?>, ushort?> map = null;
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
    
        #region int?             
            
        
        [TestMethod]
        public void TestMaxintNullableArray2049()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (int?) r.Next(int.MaxValue), 2049).ToArray();
            int? maxActual = ZEnumerable.Max(source);
            int? maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxintNullableArray2049Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (int?) r.Next(int.MaxValue) } , 2049).ToArray();
            int? maxActual = ZEnumerable.Max(source, arg => arg.X);
            int? maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxintNullableArray2049Null()
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
        }

        [TestMethod]
        public void TestMaxintNullableArray2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<int?,int?>((int?) arg, (int?) arg)).ToArray();
            Func<KeyValuePair<int?, int?>, int?> map = null;
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
        public void TestMaxintNullableList2049()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (int?) r.Next(int.MaxValue), 2049).ToList();
            int? maxActual = ZEnumerable.Max(source);
            int? maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxintNullableList2049Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (int?) r.Next(int.MaxValue) } , 2049).ToList();
            int? maxActual = ZEnumerable.Max(source, arg => arg.X);
            int? maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxintNullableList2049Null()
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
        }

        [TestMethod]
        public void TestMaxintNullableList2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<int?,int?>((int?) arg, (int?) arg)).ToList();
            Func<KeyValuePair<int?, int?>, int?> map = null;
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
        public void TestMaxintNullableIList2049()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (int?) r.Next(int.MaxValue), 2049).ToIList();
            int? maxActual = ZEnumerable.Max(source);
            int? maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxintNullableIList2049Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (int?) r.Next(int.MaxValue) } , 2049).ToIList();
            int? maxActual = ZEnumerable.Max(source, arg => arg.X);
            int? maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxintNullableIList2049Null()
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
        }

        [TestMethod]
        public void TestMaxintNullableIList2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<int?,int?>((int?) arg, (int?) arg)).ToIList();
            Func<KeyValuePair<int?, int?>, int?> map = null;
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
    
        #region uint?             
            
        
        [TestMethod]
        public void TestMaxuintNullableArray2049()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (uint?) r.Next(int.MaxValue), 2049).ToArray();
            uint? maxActual = ZEnumerable.Max(source);
            uint? maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxuintNullableArray2049Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (uint?) r.Next(int.MaxValue) } , 2049).ToArray();
            uint? maxActual = ZEnumerable.Max(source, arg => arg.X);
            uint? maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxuintNullableArray2049Null()
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
        }

        [TestMethod]
        public void TestMaxuintNullableArray2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<uint?,uint?>((uint?) arg, (uint?) arg)).ToArray();
            Func<KeyValuePair<uint?, uint?>, uint?> map = null;
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
        public void TestMaxuintNullableList2049()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (uint?) r.Next(int.MaxValue), 2049).ToList();
            uint? maxActual = ZEnumerable.Max(source);
            uint? maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxuintNullableList2049Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (uint?) r.Next(int.MaxValue) } , 2049).ToList();
            uint? maxActual = ZEnumerable.Max(source, arg => arg.X);
            uint? maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxuintNullableList2049Null()
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
        }

        [TestMethod]
        public void TestMaxuintNullableList2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<uint?,uint?>((uint?) arg, (uint?) arg)).ToList();
            Func<KeyValuePair<uint?, uint?>, uint?> map = null;
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
        public void TestMaxuintNullableIList2049()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (uint?) r.Next(int.MaxValue), 2049).ToIList();
            uint? maxActual = ZEnumerable.Max(source);
            uint? maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxuintNullableIList2049Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (uint?) r.Next(int.MaxValue) } , 2049).ToIList();
            uint? maxActual = ZEnumerable.Max(source, arg => arg.X);
            uint? maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxuintNullableIList2049Null()
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
        }

        [TestMethod]
        public void TestMaxuintNullableIList2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<uint?,uint?>((uint?) arg, (uint?) arg)).ToIList();
            Func<KeyValuePair<uint?, uint?>, uint?> map = null;
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
    
        #region long?             
            
        
        [TestMethod]
        public void TestMaxlongNullableArray2049()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (long?) r.Next(int.MaxValue), 2049).ToArray();
            long? maxActual = ZEnumerable.Max(source);
            long? maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxlongNullableArray2049Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (long?) r.Next(int.MaxValue) } , 2049).ToArray();
            long? maxActual = ZEnumerable.Max(source, arg => arg.X);
            long? maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxlongNullableArray2049Null()
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
        }

        [TestMethod]
        public void TestMaxlongNullableArray2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<long?,long?>((long?) arg, (long?) arg)).ToArray();
            Func<KeyValuePair<long?, long?>, long?> map = null;
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
        public void TestMaxlongNullableList2049()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (long?) r.Next(int.MaxValue), 2049).ToList();
            long? maxActual = ZEnumerable.Max(source);
            long? maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxlongNullableList2049Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (long?) r.Next(int.MaxValue) } , 2049).ToList();
            long? maxActual = ZEnumerable.Max(source, arg => arg.X);
            long? maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxlongNullableList2049Null()
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
        }

        [TestMethod]
        public void TestMaxlongNullableList2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<long?,long?>((long?) arg, (long?) arg)).ToList();
            Func<KeyValuePair<long?, long?>, long?> map = null;
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
        public void TestMaxlongNullableIList2049()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (long?) r.Next(int.MaxValue), 2049).ToIList();
            long? maxActual = ZEnumerable.Max(source);
            long? maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxlongNullableIList2049Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (long?) r.Next(int.MaxValue) } , 2049).ToIList();
            long? maxActual = ZEnumerable.Max(source, arg => arg.X);
            long? maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxlongNullableIList2049Null()
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
        }

        [TestMethod]
        public void TestMaxlongNullableIList2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<long?,long?>((long?) arg, (long?) arg)).ToIList();
            Func<KeyValuePair<long?, long?>, long?> map = null;
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
    
        #region float?             
            
        
        [TestMethod]
        public void TestMaxfloatNullableArray2049()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (float?) r.Next(int.MaxValue), 2049).ToArray();
            float? maxActual = ZEnumerable.Max(source);
            float? maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxfloatNullableArray2049Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (float?) r.Next(int.MaxValue) } , 2049).ToArray();
            float? maxActual = ZEnumerable.Max(source, arg => arg.X);
            float? maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxfloatNullableArray2049Null()
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
        }

        [TestMethod]
        public void TestMaxfloatNullableArray2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<float?,float?>((float?) arg, (float?) arg)).ToArray();
            Func<KeyValuePair<float?, float?>, float?> map = null;
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
        public void TestMaxfloatNullableList2049()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (float?) r.Next(int.MaxValue), 2049).ToList();
            float? maxActual = ZEnumerable.Max(source);
            float? maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxfloatNullableList2049Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (float?) r.Next(int.MaxValue) } , 2049).ToList();
            float? maxActual = ZEnumerable.Max(source, arg => arg.X);
            float? maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxfloatNullableList2049Null()
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
        }

        [TestMethod]
        public void TestMaxfloatNullableList2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<float?,float?>((float?) arg, (float?) arg)).ToList();
            Func<KeyValuePair<float?, float?>, float?> map = null;
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
        public void TestMaxfloatNullableIList2049()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (float?) r.Next(int.MaxValue), 2049).ToIList();
            float? maxActual = ZEnumerable.Max(source);
            float? maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxfloatNullableIList2049Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (float?) r.Next(int.MaxValue) } , 2049).ToIList();
            float? maxActual = ZEnumerable.Max(source, arg => arg.X);
            float? maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxfloatNullableIList2049Null()
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
        }

        [TestMethod]
        public void TestMaxfloatNullableIList2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<float?,float?>((float?) arg, (float?) arg)).ToIList();
            Func<KeyValuePair<float?, float?>, float?> map = null;
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
    
        #region double?             
            
        
        [TestMethod]
        public void TestMaxdoubleNullableArray2049()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (double?) r.Next(int.MaxValue), 2049).ToArray();
            double? maxActual = ZEnumerable.Max(source);
            double? maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdoubleNullableArray2049Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (double?) r.Next(int.MaxValue) } , 2049).ToArray();
            double? maxActual = ZEnumerable.Max(source, arg => arg.X);
            double? maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxdoubleNullableArray2049Null()
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
        }

        [TestMethod]
        public void TestMaxdoubleNullableArray2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<double?,double?>((double?) arg, (double?) arg)).ToArray();
            Func<KeyValuePair<double?, double?>, double?> map = null;
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
        public void TestMaxdoubleNullableList2049()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (double?) r.Next(int.MaxValue), 2049).ToList();
            double? maxActual = ZEnumerable.Max(source);
            double? maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdoubleNullableList2049Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (double?) r.Next(int.MaxValue) } , 2049).ToList();
            double? maxActual = ZEnumerable.Max(source, arg => arg.X);
            double? maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxdoubleNullableList2049Null()
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
        }

        [TestMethod]
        public void TestMaxdoubleNullableList2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<double?,double?>((double?) arg, (double?) arg)).ToList();
            Func<KeyValuePair<double?, double?>, double?> map = null;
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
        public void TestMaxdoubleNullableIList2049()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (double?) r.Next(int.MaxValue), 2049).ToIList();
            double? maxActual = ZEnumerable.Max(source);
            double? maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdoubleNullableIList2049Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (double?) r.Next(int.MaxValue) } , 2049).ToIList();
            double? maxActual = ZEnumerable.Max(source, arg => arg.X);
            double? maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxdoubleNullableIList2049Null()
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
        }

        [TestMethod]
        public void TestMaxdoubleNullableIList2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<double?,double?>((double?) arg, (double?) arg)).ToIList();
            Func<KeyValuePair<double?, double?>, double?> map = null;
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
    
        #region decimal?             
            
        
        [TestMethod]
        public void TestMaxdecimalNullableArray2049()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (decimal?) r.Next(int.MaxValue), 2049).ToArray();
            decimal? maxActual = ZEnumerable.Max(source);
            decimal? maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdecimalNullableArray2049Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (decimal?) r.Next(int.MaxValue) } , 2049).ToArray();
            decimal? maxActual = ZEnumerable.Max(source, arg => arg.X);
            decimal? maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxdecimalNullableArray2049Null()
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
        }

        [TestMethod]
        public void TestMaxdecimalNullableArray2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<decimal?,decimal?>((decimal?) arg, (decimal?) arg)).ToArray();
            Func<KeyValuePair<decimal?, decimal?>, decimal?> map = null;
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
        public void TestMaxdecimalNullableList2049()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (decimal?) r.Next(int.MaxValue), 2049).ToList();
            decimal? maxActual = ZEnumerable.Max(source);
            decimal? maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdecimalNullableList2049Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (decimal?) r.Next(int.MaxValue) } , 2049).ToList();
            decimal? maxActual = ZEnumerable.Max(source, arg => arg.X);
            decimal? maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxdecimalNullableList2049Null()
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
        }

        [TestMethod]
        public void TestMaxdecimalNullableList2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<decimal?,decimal?>((decimal?) arg, (decimal?) arg)).ToList();
            Func<KeyValuePair<decimal?, decimal?>, decimal?> map = null;
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
        public void TestMaxdecimalNullableIList2049()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (decimal?) r.Next(int.MaxValue), 2049).ToIList();
            decimal? maxActual = ZEnumerable.Max(source);
            decimal? maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdecimalNullableIList2049Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (decimal?) r.Next(int.MaxValue) } , 2049).ToIList();
            decimal? maxActual = ZEnumerable.Max(source, arg => arg.X);
            decimal? maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxdecimalNullableIList2049Null()
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
        }

        [TestMethod]
        public void TestMaxdecimalNullableIList2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<decimal?,decimal?>((decimal?) arg, (decimal?) arg)).ToIList();
            Func<KeyValuePair<decimal?, decimal?>, decimal?> map = null;
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
    
        #region ulong?             
            
        
        [TestMethod]
        public void TestMaxulongNullableArray2049()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ulong?) r.Next(int.MaxValue), 2049).ToArray();
            ulong? maxActual = ZEnumerable.Max(source);
            ulong? maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxulongNullableArray2049Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ulong?) r.Next(int.MaxValue) } , 2049).ToArray();
            ulong? maxActual = ZEnumerable.Max(source, arg => arg.X);
            ulong? maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxulongNullableArray2049Null()
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
        }

        [TestMethod]
        public void TestMaxulongNullableArray2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<ulong?,ulong?>((ulong?) arg, (ulong?) arg)).ToArray();
            Func<KeyValuePair<ulong?, ulong?>, ulong?> map = null;
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
        public void TestMaxulongNullableList2049()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ulong?) r.Next(int.MaxValue), 2049).ToList();
            ulong? maxActual = ZEnumerable.Max(source);
            ulong? maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxulongNullableList2049Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ulong?) r.Next(int.MaxValue) } , 2049).ToList();
            ulong? maxActual = ZEnumerable.Max(source, arg => arg.X);
            ulong? maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxulongNullableList2049Null()
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
        }

        [TestMethod]
        public void TestMaxulongNullableList2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<ulong?,ulong?>((ulong?) arg, (ulong?) arg)).ToList();
            Func<KeyValuePair<ulong?, ulong?>, ulong?> map = null;
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
        public void TestMaxulongNullableIList2049()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ulong?) r.Next(int.MaxValue), 2049).ToIList();
            ulong? maxActual = ZEnumerable.Max(source);
            ulong? maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxulongNullableIList2049Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ulong?) r.Next(int.MaxValue) } , 2049).ToIList();
            ulong? maxActual = ZEnumerable.Max(source, arg => arg.X);
            ulong? maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxulongNullableIList2049Null()
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
        }

        [TestMethod]
        public void TestMaxulongNullableIList2049MapNull()
        {
            var source = Enumerable.Range(1, 2049).Select(arg => new KeyValuePair<ulong?,ulong?>((ulong?) arg, (ulong?) arg)).ToIList();
            Func<KeyValuePair<ulong?, ulong?>, ulong?> map = null;
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
        


    
                
    
        #region sbyte             
            
            
        [TestMethod]
        public void TestMaxsbyteArray2051Null()
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
        public void TestMaxsbyteArray2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<sbyte,sbyte>((sbyte) arg, (sbyte) arg)).ToArray();
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
        public void TestMaxsbyteList2051Null()
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
        public void TestMaxsbyteList2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<sbyte,sbyte>((sbyte) arg, (sbyte) arg)).ToList();
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
        public void TestMaxsbyteIList2051Null()
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
        public void TestMaxsbyteIList2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<sbyte,sbyte>((sbyte) arg, (sbyte) arg)).ToIList();
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
        public void TestMaxbyteArray2051Null()
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
        public void TestMaxbyteArray2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<byte,byte>((byte) arg, (byte) arg)).ToArray();
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
        public void TestMaxbyteList2051Null()
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
        public void TestMaxbyteList2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<byte,byte>((byte) arg, (byte) arg)).ToList();
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
        public void TestMaxbyteIList2051Null()
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
        public void TestMaxbyteIList2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<byte,byte>((byte) arg, (byte) arg)).ToIList();
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
        public void TestMaxshortArray2051()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (short) r.Next(short.MaxValue), 2051).ToArray();
            short maxActual = ZEnumerable.Max(source);
            short maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxshortArray2051Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (short) r.Next(short.MaxValue) } , 2051).ToArray();
            short maxActual = ZEnumerable.Max(source, arg => arg.X);
            short maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxshortArray2051Null()
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
        public void TestMaxshortArray2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<short,short>((short) arg, (short) arg)).ToArray();
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
        public void TestMaxshortList2051()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (short) r.Next(short.MaxValue), 2051).ToList();
            short maxActual = ZEnumerable.Max(source);
            short maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxshortList2051Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (short) r.Next(short.MaxValue) } , 2051).ToList();
            short maxActual = ZEnumerable.Max(source, arg => arg.X);
            short maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxshortList2051Null()
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
        public void TestMaxshortList2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<short,short>((short) arg, (short) arg)).ToList();
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
        public void TestMaxshortIList2051()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (short) r.Next(short.MaxValue), 2051).ToIList();
            short maxActual = ZEnumerable.Max(source);
            short maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxshortIList2051Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (short) r.Next(short.MaxValue) } , 2051).ToIList();
            short maxActual = ZEnumerable.Max(source, arg => arg.X);
            short maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxshortIList2051Null()
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
        public void TestMaxshortIList2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<short,short>((short) arg, (short) arg)).ToIList();
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
        public void TestMaxushortArray2051()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ushort) r.Next(ushort.MaxValue), 2051).ToArray();
            ushort maxActual = ZEnumerable.Max(source);
            ushort maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxushortArray2051Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ushort) r.Next(ushort.MaxValue) } , 2051).ToArray();
            ushort maxActual = ZEnumerable.Max(source, arg => arg.X);
            ushort maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxushortArray2051Null()
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
        public void TestMaxushortArray2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<ushort,ushort>((ushort) arg, (ushort) arg)).ToArray();
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
        public void TestMaxushortList2051()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ushort) r.Next(ushort.MaxValue), 2051).ToList();
            ushort maxActual = ZEnumerable.Max(source);
            ushort maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxushortList2051Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ushort) r.Next(ushort.MaxValue) } , 2051).ToList();
            ushort maxActual = ZEnumerable.Max(source, arg => arg.X);
            ushort maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxushortList2051Null()
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
        public void TestMaxushortList2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<ushort,ushort>((ushort) arg, (ushort) arg)).ToList();
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
        public void TestMaxushortIList2051()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ushort) r.Next(ushort.MaxValue), 2051).ToIList();
            ushort maxActual = ZEnumerable.Max(source);
            ushort maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxushortIList2051Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ushort) r.Next(ushort.MaxValue) } , 2051).ToIList();
            ushort maxActual = ZEnumerable.Max(source, arg => arg.X);
            ushort maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxushortIList2051Null()
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
        public void TestMaxushortIList2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<ushort,ushort>((ushort) arg, (ushort) arg)).ToIList();
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
        public void TestMaxintArray2051()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (int) r.Next(int.MaxValue), 2051).ToArray();
            int maxActual = ZEnumerable.Max(source);
            int maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxintArray2051Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (int) r.Next(int.MaxValue) } , 2051).ToArray();
            int maxActual = ZEnumerable.Max(source, arg => arg.X);
            int maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxintArray2051Null()
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
        public void TestMaxintArray2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<int,int>((int) arg, (int) arg)).ToArray();
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
        public void TestMaxintList2051()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (int) r.Next(int.MaxValue), 2051).ToList();
            int maxActual = ZEnumerable.Max(source);
            int maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxintList2051Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (int) r.Next(int.MaxValue) } , 2051).ToList();
            int maxActual = ZEnumerable.Max(source, arg => arg.X);
            int maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxintList2051Null()
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
        public void TestMaxintList2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<int,int>((int) arg, (int) arg)).ToList();
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
        public void TestMaxintIList2051()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (int) r.Next(int.MaxValue), 2051).ToIList();
            int maxActual = ZEnumerable.Max(source);
            int maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxintIList2051Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (int) r.Next(int.MaxValue) } , 2051).ToIList();
            int maxActual = ZEnumerable.Max(source, arg => arg.X);
            int maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxintIList2051Null()
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
        public void TestMaxintIList2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<int,int>((int) arg, (int) arg)).ToIList();
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
        public void TestMaxuintArray2051()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (uint) r.Next(int.MaxValue), 2051).ToArray();
            uint maxActual = ZEnumerable.Max(source);
            uint maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxuintArray2051Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (uint) r.Next(int.MaxValue) } , 2051).ToArray();
            uint maxActual = ZEnumerable.Max(source, arg => arg.X);
            uint maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxuintArray2051Null()
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
        public void TestMaxuintArray2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<uint,uint>((uint) arg, (uint) arg)).ToArray();
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
        public void TestMaxuintList2051()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (uint) r.Next(int.MaxValue), 2051).ToList();
            uint maxActual = ZEnumerable.Max(source);
            uint maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxuintList2051Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (uint) r.Next(int.MaxValue) } , 2051).ToList();
            uint maxActual = ZEnumerable.Max(source, arg => arg.X);
            uint maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxuintList2051Null()
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
        public void TestMaxuintList2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<uint,uint>((uint) arg, (uint) arg)).ToList();
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
        public void TestMaxuintIList2051()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (uint) r.Next(int.MaxValue), 2051).ToIList();
            uint maxActual = ZEnumerable.Max(source);
            uint maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxuintIList2051Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (uint) r.Next(int.MaxValue) } , 2051).ToIList();
            uint maxActual = ZEnumerable.Max(source, arg => arg.X);
            uint maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxuintIList2051Null()
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
        public void TestMaxuintIList2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<uint,uint>((uint) arg, (uint) arg)).ToIList();
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
        public void TestMaxlongArray2051()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (long) r.Next(int.MaxValue), 2051).ToArray();
            long maxActual = ZEnumerable.Max(source);
            long maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxlongArray2051Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (long) r.Next(int.MaxValue) } , 2051).ToArray();
            long maxActual = ZEnumerable.Max(source, arg => arg.X);
            long maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxlongArray2051Null()
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
        public void TestMaxlongArray2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<long,long>((long) arg, (long) arg)).ToArray();
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
        public void TestMaxlongList2051()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (long) r.Next(int.MaxValue), 2051).ToList();
            long maxActual = ZEnumerable.Max(source);
            long maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxlongList2051Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (long) r.Next(int.MaxValue) } , 2051).ToList();
            long maxActual = ZEnumerable.Max(source, arg => arg.X);
            long maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxlongList2051Null()
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
        public void TestMaxlongList2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<long,long>((long) arg, (long) arg)).ToList();
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
        public void TestMaxlongIList2051()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (long) r.Next(int.MaxValue), 2051).ToIList();
            long maxActual = ZEnumerable.Max(source);
            long maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxlongIList2051Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (long) r.Next(int.MaxValue) } , 2051).ToIList();
            long maxActual = ZEnumerable.Max(source, arg => arg.X);
            long maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxlongIList2051Null()
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
        public void TestMaxlongIList2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<long,long>((long) arg, (long) arg)).ToIList();
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
        public void TestMaxfloatArray2051()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (float) r.Next(int.MaxValue), 2051).ToArray();
            float maxActual = ZEnumerable.Max(source);
            float maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxfloatArray2051Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (float) r.Next(int.MaxValue) } , 2051).ToArray();
            float maxActual = ZEnumerable.Max(source, arg => arg.X);
            float maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxfloatArray2051Null()
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
        public void TestMaxfloatArray2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<float,float>((float) arg, (float) arg)).ToArray();
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
        public void TestMaxfloatList2051()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (float) r.Next(int.MaxValue), 2051).ToList();
            float maxActual = ZEnumerable.Max(source);
            float maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxfloatList2051Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (float) r.Next(int.MaxValue) } , 2051).ToList();
            float maxActual = ZEnumerable.Max(source, arg => arg.X);
            float maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxfloatList2051Null()
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
        public void TestMaxfloatList2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<float,float>((float) arg, (float) arg)).ToList();
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
        public void TestMaxfloatIList2051()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (float) r.Next(int.MaxValue), 2051).ToIList();
            float maxActual = ZEnumerable.Max(source);
            float maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxfloatIList2051Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (float) r.Next(int.MaxValue) } , 2051).ToIList();
            float maxActual = ZEnumerable.Max(source, arg => arg.X);
            float maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxfloatIList2051Null()
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
        public void TestMaxfloatIList2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<float,float>((float) arg, (float) arg)).ToIList();
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
        public void TestMaxdoubleArray2051()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (double) r.Next(int.MaxValue), 2051).ToArray();
            double maxActual = ZEnumerable.Max(source);
            double maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdoubleArray2051Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (double) r.Next(int.MaxValue) } , 2051).ToArray();
            double maxActual = ZEnumerable.Max(source, arg => arg.X);
            double maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxdoubleArray2051Null()
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
        public void TestMaxdoubleArray2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<double,double>((double) arg, (double) arg)).ToArray();
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
        public void TestMaxdoubleList2051()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (double) r.Next(int.MaxValue), 2051).ToList();
            double maxActual = ZEnumerable.Max(source);
            double maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdoubleList2051Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (double) r.Next(int.MaxValue) } , 2051).ToList();
            double maxActual = ZEnumerable.Max(source, arg => arg.X);
            double maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxdoubleList2051Null()
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
        public void TestMaxdoubleList2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<double,double>((double) arg, (double) arg)).ToList();
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
        public void TestMaxdoubleIList2051()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (double) r.Next(int.MaxValue), 2051).ToIList();
            double maxActual = ZEnumerable.Max(source);
            double maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdoubleIList2051Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (double) r.Next(int.MaxValue) } , 2051).ToIList();
            double maxActual = ZEnumerable.Max(source, arg => arg.X);
            double maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxdoubleIList2051Null()
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
        public void TestMaxdoubleIList2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<double,double>((double) arg, (double) arg)).ToIList();
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
        public void TestMaxdecimalArray2051()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (decimal) r.Next(int.MaxValue), 2051).ToArray();
            decimal maxActual = ZEnumerable.Max(source);
            decimal maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdecimalArray2051Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (decimal) r.Next(int.MaxValue) } , 2051).ToArray();
            decimal maxActual = ZEnumerable.Max(source, arg => arg.X);
            decimal maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxdecimalArray2051Null()
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
        public void TestMaxdecimalArray2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<decimal,decimal>((decimal) arg, (decimal) arg)).ToArray();
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
        public void TestMaxdecimalList2051()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (decimal) r.Next(int.MaxValue), 2051).ToList();
            decimal maxActual = ZEnumerable.Max(source);
            decimal maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdecimalList2051Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (decimal) r.Next(int.MaxValue) } , 2051).ToList();
            decimal maxActual = ZEnumerable.Max(source, arg => arg.X);
            decimal maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxdecimalList2051Null()
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
        public void TestMaxdecimalList2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<decimal,decimal>((decimal) arg, (decimal) arg)).ToList();
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
        public void TestMaxdecimalIList2051()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (decimal) r.Next(int.MaxValue), 2051).ToIList();
            decimal maxActual = ZEnumerable.Max(source);
            decimal maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdecimalIList2051Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (decimal) r.Next(int.MaxValue) } , 2051).ToIList();
            decimal maxActual = ZEnumerable.Max(source, arg => arg.X);
            decimal maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxdecimalIList2051Null()
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
        public void TestMaxdecimalIList2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<decimal,decimal>((decimal) arg, (decimal) arg)).ToIList();
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
        public void TestMaxulongArray2051()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ulong) r.Next(int.MaxValue), 2051).ToArray();
            ulong maxActual = ZEnumerable.Max(source);
            ulong maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxulongArray2051Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ulong) r.Next(int.MaxValue) } , 2051).ToArray();
            ulong maxActual = ZEnumerable.Max(source, arg => arg.X);
            ulong maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxulongArray2051Null()
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
        public void TestMaxulongArray2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<ulong,ulong>((ulong) arg, (ulong) arg)).ToArray();
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
        public void TestMaxulongList2051()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ulong) r.Next(int.MaxValue), 2051).ToList();
            ulong maxActual = ZEnumerable.Max(source);
            ulong maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxulongList2051Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ulong) r.Next(int.MaxValue) } , 2051).ToList();
            ulong maxActual = ZEnumerable.Max(source, arg => arg.X);
            ulong maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxulongList2051Null()
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
        public void TestMaxulongList2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<ulong,ulong>((ulong) arg, (ulong) arg)).ToList();
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
        public void TestMaxulongIList2051()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ulong) r.Next(int.MaxValue), 2051).ToIList();
            ulong maxActual = ZEnumerable.Max(source);
            ulong maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxulongIList2051Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ulong) r.Next(int.MaxValue) } , 2051).ToIList();
            ulong maxActual = ZEnumerable.Max(source, arg => arg.X);
            ulong maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxulongIList2051Null()
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
        public void TestMaxulongIList2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<ulong,ulong>((ulong) arg, (ulong) arg)).ToIList();
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
    
        #region sbyte?             
            
            
        [TestMethod]
        public void TestMaxsbyteNullableArray2051Null()
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
        }

        [TestMethod]
        public void TestMaxsbyteNullableArray2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<sbyte?,sbyte?>((sbyte?) arg, (sbyte?) arg)).ToArray();
            Func<KeyValuePair<sbyte?, sbyte?>, sbyte?> map = null;
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
        public void TestMaxsbyteNullableList2051Null()
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
        }

        [TestMethod]
        public void TestMaxsbyteNullableList2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<sbyte?,sbyte?>((sbyte?) arg, (sbyte?) arg)).ToList();
            Func<KeyValuePair<sbyte?, sbyte?>, sbyte?> map = null;
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
        public void TestMaxsbyteNullableIList2051Null()
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
        }

        [TestMethod]
        public void TestMaxsbyteNullableIList2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<sbyte?,sbyte?>((sbyte?) arg, (sbyte?) arg)).ToIList();
            Func<KeyValuePair<sbyte?, sbyte?>, sbyte?> map = null;
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
    
        #region byte?             
            
            
        [TestMethod]
        public void TestMaxbyteNullableArray2051Null()
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
        }

        [TestMethod]
        public void TestMaxbyteNullableArray2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<byte?,byte?>((byte?) arg, (byte?) arg)).ToArray();
            Func<KeyValuePair<byte?, byte?>, byte?> map = null;
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
        public void TestMaxbyteNullableList2051Null()
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
        }

        [TestMethod]
        public void TestMaxbyteNullableList2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<byte?,byte?>((byte?) arg, (byte?) arg)).ToList();
            Func<KeyValuePair<byte?, byte?>, byte?> map = null;
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
        public void TestMaxbyteNullableIList2051Null()
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
        }

        [TestMethod]
        public void TestMaxbyteNullableIList2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<byte?,byte?>((byte?) arg, (byte?) arg)).ToIList();
            Func<KeyValuePair<byte?, byte?>, byte?> map = null;
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
    
        #region short?             
            
        
        [TestMethod]
        public void TestMaxshortNullableArray2051()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (short?) r.Next(short.MaxValue), 2051).ToArray();
            short? maxActual = ZEnumerable.Max(source);
            short? maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxshortNullableArray2051Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (short?) r.Next(short.MaxValue) } , 2051).ToArray();
            short? maxActual = ZEnumerable.Max(source, arg => arg.X);
            short? maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxshortNullableArray2051Null()
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
        }

        [TestMethod]
        public void TestMaxshortNullableArray2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<short?,short?>((short?) arg, (short?) arg)).ToArray();
            Func<KeyValuePair<short?, short?>, short?> map = null;
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
        public void TestMaxshortNullableList2051()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (short?) r.Next(short.MaxValue), 2051).ToList();
            short? maxActual = ZEnumerable.Max(source);
            short? maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxshortNullableList2051Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (short?) r.Next(short.MaxValue) } , 2051).ToList();
            short? maxActual = ZEnumerable.Max(source, arg => arg.X);
            short? maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxshortNullableList2051Null()
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
        }

        [TestMethod]
        public void TestMaxshortNullableList2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<short?,short?>((short?) arg, (short?) arg)).ToList();
            Func<KeyValuePair<short?, short?>, short?> map = null;
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
        public void TestMaxshortNullableIList2051()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (short?) r.Next(short.MaxValue), 2051).ToIList();
            short? maxActual = ZEnumerable.Max(source);
            short? maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxshortNullableIList2051Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (short?) r.Next(short.MaxValue) } , 2051).ToIList();
            short? maxActual = ZEnumerable.Max(source, arg => arg.X);
            short? maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxshortNullableIList2051Null()
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
        }

        [TestMethod]
        public void TestMaxshortNullableIList2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<short?,short?>((short?) arg, (short?) arg)).ToIList();
            Func<KeyValuePair<short?, short?>, short?> map = null;
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
    
        #region ushort?             
            
        
        [TestMethod]
        public void TestMaxushortNullableArray2051()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ushort?) r.Next(ushort.MaxValue), 2051).ToArray();
            ushort? maxActual = ZEnumerable.Max(source);
            ushort? maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxushortNullableArray2051Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ushort?) r.Next(ushort.MaxValue) } , 2051).ToArray();
            ushort? maxActual = ZEnumerable.Max(source, arg => arg.X);
            ushort? maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxushortNullableArray2051Null()
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
        }

        [TestMethod]
        public void TestMaxushortNullableArray2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<ushort?,ushort?>((ushort?) arg, (ushort?) arg)).ToArray();
            Func<KeyValuePair<ushort?, ushort?>, ushort?> map = null;
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
        public void TestMaxushortNullableList2051()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ushort?) r.Next(ushort.MaxValue), 2051).ToList();
            ushort? maxActual = ZEnumerable.Max(source);
            ushort? maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxushortNullableList2051Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ushort?) r.Next(ushort.MaxValue) } , 2051).ToList();
            ushort? maxActual = ZEnumerable.Max(source, arg => arg.X);
            ushort? maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxushortNullableList2051Null()
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
        }

        [TestMethod]
        public void TestMaxushortNullableList2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<ushort?,ushort?>((ushort?) arg, (ushort?) arg)).ToList();
            Func<KeyValuePair<ushort?, ushort?>, ushort?> map = null;
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
        public void TestMaxushortNullableIList2051()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ushort?) r.Next(ushort.MaxValue), 2051).ToIList();
            ushort? maxActual = ZEnumerable.Max(source);
            ushort? maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxushortNullableIList2051Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ushort?) r.Next(ushort.MaxValue) } , 2051).ToIList();
            ushort? maxActual = ZEnumerable.Max(source, arg => arg.X);
            ushort? maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxushortNullableIList2051Null()
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
        }

        [TestMethod]
        public void TestMaxushortNullableIList2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<ushort?,ushort?>((ushort?) arg, (ushort?) arg)).ToIList();
            Func<KeyValuePair<ushort?, ushort?>, ushort?> map = null;
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
    
        #region int?             
            
        
        [TestMethod]
        public void TestMaxintNullableArray2051()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (int?) r.Next(int.MaxValue), 2051).ToArray();
            int? maxActual = ZEnumerable.Max(source);
            int? maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxintNullableArray2051Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (int?) r.Next(int.MaxValue) } , 2051).ToArray();
            int? maxActual = ZEnumerable.Max(source, arg => arg.X);
            int? maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxintNullableArray2051Null()
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
        }

        [TestMethod]
        public void TestMaxintNullableArray2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<int?,int?>((int?) arg, (int?) arg)).ToArray();
            Func<KeyValuePair<int?, int?>, int?> map = null;
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
        public void TestMaxintNullableList2051()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (int?) r.Next(int.MaxValue), 2051).ToList();
            int? maxActual = ZEnumerable.Max(source);
            int? maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxintNullableList2051Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (int?) r.Next(int.MaxValue) } , 2051).ToList();
            int? maxActual = ZEnumerable.Max(source, arg => arg.X);
            int? maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxintNullableList2051Null()
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
        }

        [TestMethod]
        public void TestMaxintNullableList2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<int?,int?>((int?) arg, (int?) arg)).ToList();
            Func<KeyValuePair<int?, int?>, int?> map = null;
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
        public void TestMaxintNullableIList2051()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (int?) r.Next(int.MaxValue), 2051).ToIList();
            int? maxActual = ZEnumerable.Max(source);
            int? maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxintNullableIList2051Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (int?) r.Next(int.MaxValue) } , 2051).ToIList();
            int? maxActual = ZEnumerable.Max(source, arg => arg.X);
            int? maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxintNullableIList2051Null()
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
        }

        [TestMethod]
        public void TestMaxintNullableIList2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<int?,int?>((int?) arg, (int?) arg)).ToIList();
            Func<KeyValuePair<int?, int?>, int?> map = null;
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
    
        #region uint?             
            
        
        [TestMethod]
        public void TestMaxuintNullableArray2051()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (uint?) r.Next(int.MaxValue), 2051).ToArray();
            uint? maxActual = ZEnumerable.Max(source);
            uint? maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxuintNullableArray2051Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (uint?) r.Next(int.MaxValue) } , 2051).ToArray();
            uint? maxActual = ZEnumerable.Max(source, arg => arg.X);
            uint? maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxuintNullableArray2051Null()
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
        }

        [TestMethod]
        public void TestMaxuintNullableArray2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<uint?,uint?>((uint?) arg, (uint?) arg)).ToArray();
            Func<KeyValuePair<uint?, uint?>, uint?> map = null;
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
        public void TestMaxuintNullableList2051()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (uint?) r.Next(int.MaxValue), 2051).ToList();
            uint? maxActual = ZEnumerable.Max(source);
            uint? maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxuintNullableList2051Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (uint?) r.Next(int.MaxValue) } , 2051).ToList();
            uint? maxActual = ZEnumerable.Max(source, arg => arg.X);
            uint? maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxuintNullableList2051Null()
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
        }

        [TestMethod]
        public void TestMaxuintNullableList2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<uint?,uint?>((uint?) arg, (uint?) arg)).ToList();
            Func<KeyValuePair<uint?, uint?>, uint?> map = null;
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
        public void TestMaxuintNullableIList2051()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (uint?) r.Next(int.MaxValue), 2051).ToIList();
            uint? maxActual = ZEnumerable.Max(source);
            uint? maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxuintNullableIList2051Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (uint?) r.Next(int.MaxValue) } , 2051).ToIList();
            uint? maxActual = ZEnumerable.Max(source, arg => arg.X);
            uint? maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxuintNullableIList2051Null()
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
        }

        [TestMethod]
        public void TestMaxuintNullableIList2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<uint?,uint?>((uint?) arg, (uint?) arg)).ToIList();
            Func<KeyValuePair<uint?, uint?>, uint?> map = null;
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
    
        #region long?             
            
        
        [TestMethod]
        public void TestMaxlongNullableArray2051()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (long?) r.Next(int.MaxValue), 2051).ToArray();
            long? maxActual = ZEnumerable.Max(source);
            long? maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxlongNullableArray2051Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (long?) r.Next(int.MaxValue) } , 2051).ToArray();
            long? maxActual = ZEnumerable.Max(source, arg => arg.X);
            long? maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxlongNullableArray2051Null()
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
        }

        [TestMethod]
        public void TestMaxlongNullableArray2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<long?,long?>((long?) arg, (long?) arg)).ToArray();
            Func<KeyValuePair<long?, long?>, long?> map = null;
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
        public void TestMaxlongNullableList2051()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (long?) r.Next(int.MaxValue), 2051).ToList();
            long? maxActual = ZEnumerable.Max(source);
            long? maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxlongNullableList2051Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (long?) r.Next(int.MaxValue) } , 2051).ToList();
            long? maxActual = ZEnumerable.Max(source, arg => arg.X);
            long? maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxlongNullableList2051Null()
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
        }

        [TestMethod]
        public void TestMaxlongNullableList2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<long?,long?>((long?) arg, (long?) arg)).ToList();
            Func<KeyValuePair<long?, long?>, long?> map = null;
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
        public void TestMaxlongNullableIList2051()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (long?) r.Next(int.MaxValue), 2051).ToIList();
            long? maxActual = ZEnumerable.Max(source);
            long? maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxlongNullableIList2051Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (long?) r.Next(int.MaxValue) } , 2051).ToIList();
            long? maxActual = ZEnumerable.Max(source, arg => arg.X);
            long? maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxlongNullableIList2051Null()
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
        }

        [TestMethod]
        public void TestMaxlongNullableIList2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<long?,long?>((long?) arg, (long?) arg)).ToIList();
            Func<KeyValuePair<long?, long?>, long?> map = null;
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
    
        #region float?             
            
        
        [TestMethod]
        public void TestMaxfloatNullableArray2051()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (float?) r.Next(int.MaxValue), 2051).ToArray();
            float? maxActual = ZEnumerable.Max(source);
            float? maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxfloatNullableArray2051Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (float?) r.Next(int.MaxValue) } , 2051).ToArray();
            float? maxActual = ZEnumerable.Max(source, arg => arg.X);
            float? maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxfloatNullableArray2051Null()
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
        }

        [TestMethod]
        public void TestMaxfloatNullableArray2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<float?,float?>((float?) arg, (float?) arg)).ToArray();
            Func<KeyValuePair<float?, float?>, float?> map = null;
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
        public void TestMaxfloatNullableList2051()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (float?) r.Next(int.MaxValue), 2051).ToList();
            float? maxActual = ZEnumerable.Max(source);
            float? maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxfloatNullableList2051Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (float?) r.Next(int.MaxValue) } , 2051).ToList();
            float? maxActual = ZEnumerable.Max(source, arg => arg.X);
            float? maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxfloatNullableList2051Null()
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
        }

        [TestMethod]
        public void TestMaxfloatNullableList2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<float?,float?>((float?) arg, (float?) arg)).ToList();
            Func<KeyValuePair<float?, float?>, float?> map = null;
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
        public void TestMaxfloatNullableIList2051()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (float?) r.Next(int.MaxValue), 2051).ToIList();
            float? maxActual = ZEnumerable.Max(source);
            float? maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxfloatNullableIList2051Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (float?) r.Next(int.MaxValue) } , 2051).ToIList();
            float? maxActual = ZEnumerable.Max(source, arg => arg.X);
            float? maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxfloatNullableIList2051Null()
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
        }

        [TestMethod]
        public void TestMaxfloatNullableIList2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<float?,float?>((float?) arg, (float?) arg)).ToIList();
            Func<KeyValuePair<float?, float?>, float?> map = null;
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
    
        #region double?             
            
        
        [TestMethod]
        public void TestMaxdoubleNullableArray2051()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (double?) r.Next(int.MaxValue), 2051).ToArray();
            double? maxActual = ZEnumerable.Max(source);
            double? maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdoubleNullableArray2051Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (double?) r.Next(int.MaxValue) } , 2051).ToArray();
            double? maxActual = ZEnumerable.Max(source, arg => arg.X);
            double? maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxdoubleNullableArray2051Null()
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
        }

        [TestMethod]
        public void TestMaxdoubleNullableArray2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<double?,double?>((double?) arg, (double?) arg)).ToArray();
            Func<KeyValuePair<double?, double?>, double?> map = null;
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
        public void TestMaxdoubleNullableList2051()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (double?) r.Next(int.MaxValue), 2051).ToList();
            double? maxActual = ZEnumerable.Max(source);
            double? maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdoubleNullableList2051Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (double?) r.Next(int.MaxValue) } , 2051).ToList();
            double? maxActual = ZEnumerable.Max(source, arg => arg.X);
            double? maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxdoubleNullableList2051Null()
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
        }

        [TestMethod]
        public void TestMaxdoubleNullableList2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<double?,double?>((double?) arg, (double?) arg)).ToList();
            Func<KeyValuePair<double?, double?>, double?> map = null;
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
        public void TestMaxdoubleNullableIList2051()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (double?) r.Next(int.MaxValue), 2051).ToIList();
            double? maxActual = ZEnumerable.Max(source);
            double? maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdoubleNullableIList2051Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (double?) r.Next(int.MaxValue) } , 2051).ToIList();
            double? maxActual = ZEnumerable.Max(source, arg => arg.X);
            double? maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxdoubleNullableIList2051Null()
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
        }

        [TestMethod]
        public void TestMaxdoubleNullableIList2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<double?,double?>((double?) arg, (double?) arg)).ToIList();
            Func<KeyValuePair<double?, double?>, double?> map = null;
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
    
        #region decimal?             
            
        
        [TestMethod]
        public void TestMaxdecimalNullableArray2051()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (decimal?) r.Next(int.MaxValue), 2051).ToArray();
            decimal? maxActual = ZEnumerable.Max(source);
            decimal? maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdecimalNullableArray2051Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (decimal?) r.Next(int.MaxValue) } , 2051).ToArray();
            decimal? maxActual = ZEnumerable.Max(source, arg => arg.X);
            decimal? maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxdecimalNullableArray2051Null()
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
        }

        [TestMethod]
        public void TestMaxdecimalNullableArray2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<decimal?,decimal?>((decimal?) arg, (decimal?) arg)).ToArray();
            Func<KeyValuePair<decimal?, decimal?>, decimal?> map = null;
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
        public void TestMaxdecimalNullableList2051()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (decimal?) r.Next(int.MaxValue), 2051).ToList();
            decimal? maxActual = ZEnumerable.Max(source);
            decimal? maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdecimalNullableList2051Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (decimal?) r.Next(int.MaxValue) } , 2051).ToList();
            decimal? maxActual = ZEnumerable.Max(source, arg => arg.X);
            decimal? maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxdecimalNullableList2051Null()
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
        }

        [TestMethod]
        public void TestMaxdecimalNullableList2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<decimal?,decimal?>((decimal?) arg, (decimal?) arg)).ToList();
            Func<KeyValuePair<decimal?, decimal?>, decimal?> map = null;
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
        public void TestMaxdecimalNullableIList2051()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (decimal?) r.Next(int.MaxValue), 2051).ToIList();
            decimal? maxActual = ZEnumerable.Max(source);
            decimal? maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdecimalNullableIList2051Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (decimal?) r.Next(int.MaxValue) } , 2051).ToIList();
            decimal? maxActual = ZEnumerable.Max(source, arg => arg.X);
            decimal? maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxdecimalNullableIList2051Null()
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
        }

        [TestMethod]
        public void TestMaxdecimalNullableIList2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<decimal?,decimal?>((decimal?) arg, (decimal?) arg)).ToIList();
            Func<KeyValuePair<decimal?, decimal?>, decimal?> map = null;
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
    
        #region ulong?             
            
        
        [TestMethod]
        public void TestMaxulongNullableArray2051()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ulong?) r.Next(int.MaxValue), 2051).ToArray();
            ulong? maxActual = ZEnumerable.Max(source);
            ulong? maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxulongNullableArray2051Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ulong?) r.Next(int.MaxValue) } , 2051).ToArray();
            ulong? maxActual = ZEnumerable.Max(source, arg => arg.X);
            ulong? maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxulongNullableArray2051Null()
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
        }

        [TestMethod]
        public void TestMaxulongNullableArray2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<ulong?,ulong?>((ulong?) arg, (ulong?) arg)).ToArray();
            Func<KeyValuePair<ulong?, ulong?>, ulong?> map = null;
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
        public void TestMaxulongNullableList2051()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ulong?) r.Next(int.MaxValue), 2051).ToList();
            ulong? maxActual = ZEnumerable.Max(source);
            ulong? maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxulongNullableList2051Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ulong?) r.Next(int.MaxValue) } , 2051).ToList();
            ulong? maxActual = ZEnumerable.Max(source, arg => arg.X);
            ulong? maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxulongNullableList2051Null()
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
        }

        [TestMethod]
        public void TestMaxulongNullableList2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<ulong?,ulong?>((ulong?) arg, (ulong?) arg)).ToList();
            Func<KeyValuePair<ulong?, ulong?>, ulong?> map = null;
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
        public void TestMaxulongNullableIList2051()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ulong?) r.Next(int.MaxValue), 2051).ToIList();
            ulong? maxActual = ZEnumerable.Max(source);
            ulong? maxExpected = Enumerable.Max(source);          
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxulongNullableIList2051Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ulong?) r.Next(int.MaxValue) } , 2051).ToIList();
            ulong? maxActual = ZEnumerable.Max(source, arg => arg.X);
            ulong? maxExpected = Enumerable.Max(source, arg => arg.X);        
            Assert.AreEqual(maxExpected, maxActual);
        }

            
        [TestMethod]
        public void TestMaxulongNullableIList2051Null()
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
        }

        [TestMethod]
        public void TestMaxulongNullableIList2051MapNull()
        {
            var source = Enumerable.Range(1, 2051).Select(arg => new KeyValuePair<ulong?,ulong?>((ulong?) arg, (ulong?) arg)).ToIList();
            Func<KeyValuePair<ulong?, ulong?>, ulong?> map = null;
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
        


    
    }
}