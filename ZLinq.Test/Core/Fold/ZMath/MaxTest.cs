
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZLinq.Test.Helpers;

namespace ZLinq.Test.ZMath
{
    [TestClass]
    public class Max
    {            
       

        #region sbyte 
             
            
        [TestMethod]
        public void TestMaxsbyteArrayNullOrEmpty()
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

            sbyte[] emptySource = new sbyte[0].ToArray();
            try
            {
                ZEnumerable.Max(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestMaxsbyteArrayMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<sbyte,sbyte>((sbyte) arg, (sbyte) arg)).ToArray();
            Func<KeyValuePair<sbyte, sbyte>, sbyte> nullMap = null;
            try
            {
                ZEnumerable.Max(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToArray();
            try
            {
                ZEnumerable.Max(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Max(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

                     
                
        [TestMethod]
        public void TestMaxsbyteArray1()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (sbyte) r.Next(sbyte.MaxValue), 1).ToArray();
            sbyte maxActual = ZEnumerable.Max(source);
            sbyte maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxsbyteArray1Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (sbyte) r.Next(sbyte.MaxValue) } , 1).ToArray();
            sbyte maxActual = ZEnumerable.Max(source, arg => arg.X);
            sbyte maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxsbyteArray2()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (sbyte) r.Next(sbyte.MaxValue), 2).ToArray();
            sbyte maxActual = ZEnumerable.Max(source);
            sbyte maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxsbyteArray2Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (sbyte) r.Next(sbyte.MaxValue) } , 2).ToArray();
            sbyte maxActual = ZEnumerable.Max(source, arg => arg.X);
            sbyte maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxsbyteArray3()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (sbyte) r.Next(sbyte.MaxValue), 3).ToArray();
            sbyte maxActual = ZEnumerable.Max(source);
            sbyte maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxsbyteArray3Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (sbyte) r.Next(sbyte.MaxValue) } , 3).ToArray();
            sbyte maxActual = ZEnumerable.Max(source, arg => arg.X);
            sbyte maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxsbyteArray4()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (sbyte) r.Next(sbyte.MaxValue), 4).ToArray();
            sbyte maxActual = ZEnumerable.Max(source);
            sbyte maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxsbyteArray4Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (sbyte) r.Next(sbyte.MaxValue) } , 4).ToArray();
            sbyte maxActual = ZEnumerable.Max(source, arg => arg.X);
            sbyte maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxsbyteArray100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (sbyte) r.Next(sbyte.MaxValue), 100).ToArray();
            sbyte maxActual = ZEnumerable.Max(source);
            sbyte maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxsbyteArray100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (sbyte) r.Next(sbyte.MaxValue) } , 100).ToArray();
            sbyte maxActual = ZEnumerable.Max(source, arg => arg.X);
            sbyte maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxsbyteArray2048()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (sbyte) r.Next(sbyte.MaxValue), 2048).ToArray();
            sbyte maxActual = ZEnumerable.Max(source);
            sbyte maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxsbyteArray2048Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (sbyte) r.Next(sbyte.MaxValue) } , 2048).ToArray();
            sbyte maxActual = ZEnumerable.Max(source, arg => arg.X);
            sbyte maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
            
        [TestMethod]
        public void TestMaxsbyteListNullOrEmpty()
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

            List<sbyte> emptySource = new sbyte[0].ToList();
            try
            {
                ZEnumerable.Max(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestMaxsbyteListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<sbyte,sbyte>((sbyte) arg, (sbyte) arg)).ToList();
            Func<KeyValuePair<sbyte, sbyte>, sbyte> nullMap = null;
            try
            {
                ZEnumerable.Max(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToList();
            try
            {
                ZEnumerable.Max(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Max(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

                     
                
        [TestMethod]
        public void TestMaxsbyteList1()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (sbyte) r.Next(sbyte.MaxValue), 1).ToList();
            sbyte maxActual = ZEnumerable.Max(source);
            sbyte maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxsbyteList1Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (sbyte) r.Next(sbyte.MaxValue) } , 1).ToList();
            sbyte maxActual = ZEnumerable.Max(source, arg => arg.X);
            sbyte maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxsbyteList2()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (sbyte) r.Next(sbyte.MaxValue), 2).ToList();
            sbyte maxActual = ZEnumerable.Max(source);
            sbyte maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxsbyteList2Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (sbyte) r.Next(sbyte.MaxValue) } , 2).ToList();
            sbyte maxActual = ZEnumerable.Max(source, arg => arg.X);
            sbyte maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxsbyteList3()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (sbyte) r.Next(sbyte.MaxValue), 3).ToList();
            sbyte maxActual = ZEnumerable.Max(source);
            sbyte maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxsbyteList3Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (sbyte) r.Next(sbyte.MaxValue) } , 3).ToList();
            sbyte maxActual = ZEnumerable.Max(source, arg => arg.X);
            sbyte maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxsbyteList4()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (sbyte) r.Next(sbyte.MaxValue), 4).ToList();
            sbyte maxActual = ZEnumerable.Max(source);
            sbyte maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxsbyteList4Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (sbyte) r.Next(sbyte.MaxValue) } , 4).ToList();
            sbyte maxActual = ZEnumerable.Max(source, arg => arg.X);
            sbyte maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxsbyteList100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (sbyte) r.Next(sbyte.MaxValue), 100).ToList();
            sbyte maxActual = ZEnumerable.Max(source);
            sbyte maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxsbyteList100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (sbyte) r.Next(sbyte.MaxValue) } , 100).ToList();
            sbyte maxActual = ZEnumerable.Max(source, arg => arg.X);
            sbyte maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxsbyteList2048()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (sbyte) r.Next(sbyte.MaxValue), 2048).ToList();
            sbyte maxActual = ZEnumerable.Max(source);
            sbyte maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxsbyteList2048Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (sbyte) r.Next(sbyte.MaxValue) } , 2048).ToList();
            sbyte maxActual = ZEnumerable.Max(source, arg => arg.X);
            sbyte maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
            
        [TestMethod]
        public void TestMaxsbyteIListNullOrEmpty()
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

            IList<sbyte> emptySource = new sbyte[0].ToIList();
            try
            {
                ZEnumerable.Max(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestMaxsbyteIListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<sbyte,sbyte>((sbyte) arg, (sbyte) arg)).ToIList();
            Func<KeyValuePair<sbyte, sbyte>, sbyte> nullMap = null;
            try
            {
                ZEnumerable.Max(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToIList();
            try
            {
                ZEnumerable.Max(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Max(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

                     
                
        [TestMethod]
        public void TestMaxsbyteIList1()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (sbyte) r.Next(sbyte.MaxValue), 1).ToIList();
            sbyte maxActual = ZEnumerable.Max(source);
            sbyte maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxsbyteIList1Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (sbyte) r.Next(sbyte.MaxValue) } , 1).ToIList();
            sbyte maxActual = ZEnumerable.Max(source, arg => arg.X);
            sbyte maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxsbyteIList2()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (sbyte) r.Next(sbyte.MaxValue), 2).ToIList();
            sbyte maxActual = ZEnumerable.Max(source);
            sbyte maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxsbyteIList2Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (sbyte) r.Next(sbyte.MaxValue) } , 2).ToIList();
            sbyte maxActual = ZEnumerable.Max(source, arg => arg.X);
            sbyte maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxsbyteIList3()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (sbyte) r.Next(sbyte.MaxValue), 3).ToIList();
            sbyte maxActual = ZEnumerable.Max(source);
            sbyte maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxsbyteIList3Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (sbyte) r.Next(sbyte.MaxValue) } , 3).ToIList();
            sbyte maxActual = ZEnumerable.Max(source, arg => arg.X);
            sbyte maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxsbyteIList4()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (sbyte) r.Next(sbyte.MaxValue), 4).ToIList();
            sbyte maxActual = ZEnumerable.Max(source);
            sbyte maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxsbyteIList4Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (sbyte) r.Next(sbyte.MaxValue) } , 4).ToIList();
            sbyte maxActual = ZEnumerable.Max(source, arg => arg.X);
            sbyte maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxsbyteIList100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (sbyte) r.Next(sbyte.MaxValue), 100).ToIList();
            sbyte maxActual = ZEnumerable.Max(source);
            sbyte maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxsbyteIList100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (sbyte) r.Next(sbyte.MaxValue) } , 100).ToIList();
            sbyte maxActual = ZEnumerable.Max(source, arg => arg.X);
            sbyte maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxsbyteIList2048()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (sbyte) r.Next(sbyte.MaxValue), 2048).ToIList();
            sbyte maxActual = ZEnumerable.Max(source);
            sbyte maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxsbyteIList2048Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (sbyte) r.Next(sbyte.MaxValue) } , 2048).ToIList();
            sbyte maxActual = ZEnumerable.Max(source, arg => arg.X);
            sbyte maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                        
               
        #endregion

      

        #region byte 
             
            
        [TestMethod]
        public void TestMaxbyteArrayNullOrEmpty()
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

            byte[] emptySource = new byte[0].ToArray();
            try
            {
                ZEnumerable.Max(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestMaxbyteArrayMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<byte,byte>((byte) arg, (byte) arg)).ToArray();
            Func<KeyValuePair<byte, byte>, byte> nullMap = null;
            try
            {
                ZEnumerable.Max(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToArray();
            try
            {
                ZEnumerable.Max(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Max(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

                     
                
        [TestMethod]
        public void TestMaxbyteArray1()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (byte) r.Next(byte.MaxValue), 1).ToArray();
            byte maxActual = ZEnumerable.Max(source);
            byte maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxbyteArray1Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (byte) r.Next(byte.MaxValue) } , 1).ToArray();
            byte maxActual = ZEnumerable.Max(source, arg => arg.X);
            byte maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxbyteArray2()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (byte) r.Next(byte.MaxValue), 2).ToArray();
            byte maxActual = ZEnumerable.Max(source);
            byte maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxbyteArray2Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (byte) r.Next(byte.MaxValue) } , 2).ToArray();
            byte maxActual = ZEnumerable.Max(source, arg => arg.X);
            byte maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxbyteArray3()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (byte) r.Next(byte.MaxValue), 3).ToArray();
            byte maxActual = ZEnumerable.Max(source);
            byte maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxbyteArray3Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (byte) r.Next(byte.MaxValue) } , 3).ToArray();
            byte maxActual = ZEnumerable.Max(source, arg => arg.X);
            byte maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxbyteArray4()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (byte) r.Next(byte.MaxValue), 4).ToArray();
            byte maxActual = ZEnumerable.Max(source);
            byte maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxbyteArray4Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (byte) r.Next(byte.MaxValue) } , 4).ToArray();
            byte maxActual = ZEnumerable.Max(source, arg => arg.X);
            byte maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxbyteArray100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (byte) r.Next(byte.MaxValue), 100).ToArray();
            byte maxActual = ZEnumerable.Max(source);
            byte maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxbyteArray100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (byte) r.Next(byte.MaxValue) } , 100).ToArray();
            byte maxActual = ZEnumerable.Max(source, arg => arg.X);
            byte maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxbyteArray2048()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (byte) r.Next(byte.MaxValue), 2048).ToArray();
            byte maxActual = ZEnumerable.Max(source);
            byte maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxbyteArray2048Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (byte) r.Next(byte.MaxValue) } , 2048).ToArray();
            byte maxActual = ZEnumerable.Max(source, arg => arg.X);
            byte maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
            
        [TestMethod]
        public void TestMaxbyteListNullOrEmpty()
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

            List<byte> emptySource = new byte[0].ToList();
            try
            {
                ZEnumerable.Max(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestMaxbyteListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<byte,byte>((byte) arg, (byte) arg)).ToList();
            Func<KeyValuePair<byte, byte>, byte> nullMap = null;
            try
            {
                ZEnumerable.Max(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToList();
            try
            {
                ZEnumerable.Max(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Max(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

                     
                
        [TestMethod]
        public void TestMaxbyteList1()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (byte) r.Next(byte.MaxValue), 1).ToList();
            byte maxActual = ZEnumerable.Max(source);
            byte maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxbyteList1Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (byte) r.Next(byte.MaxValue) } , 1).ToList();
            byte maxActual = ZEnumerable.Max(source, arg => arg.X);
            byte maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxbyteList2()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (byte) r.Next(byte.MaxValue), 2).ToList();
            byte maxActual = ZEnumerable.Max(source);
            byte maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxbyteList2Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (byte) r.Next(byte.MaxValue) } , 2).ToList();
            byte maxActual = ZEnumerable.Max(source, arg => arg.X);
            byte maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxbyteList3()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (byte) r.Next(byte.MaxValue), 3).ToList();
            byte maxActual = ZEnumerable.Max(source);
            byte maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxbyteList3Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (byte) r.Next(byte.MaxValue) } , 3).ToList();
            byte maxActual = ZEnumerable.Max(source, arg => arg.X);
            byte maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxbyteList4()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (byte) r.Next(byte.MaxValue), 4).ToList();
            byte maxActual = ZEnumerable.Max(source);
            byte maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxbyteList4Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (byte) r.Next(byte.MaxValue) } , 4).ToList();
            byte maxActual = ZEnumerable.Max(source, arg => arg.X);
            byte maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxbyteList100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (byte) r.Next(byte.MaxValue), 100).ToList();
            byte maxActual = ZEnumerable.Max(source);
            byte maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxbyteList100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (byte) r.Next(byte.MaxValue) } , 100).ToList();
            byte maxActual = ZEnumerable.Max(source, arg => arg.X);
            byte maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxbyteList2048()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (byte) r.Next(byte.MaxValue), 2048).ToList();
            byte maxActual = ZEnumerable.Max(source);
            byte maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxbyteList2048Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (byte) r.Next(byte.MaxValue) } , 2048).ToList();
            byte maxActual = ZEnumerable.Max(source, arg => arg.X);
            byte maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
            
        [TestMethod]
        public void TestMaxbyteIListNullOrEmpty()
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

            IList<byte> emptySource = new byte[0].ToIList();
            try
            {
                ZEnumerable.Max(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestMaxbyteIListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<byte,byte>((byte) arg, (byte) arg)).ToIList();
            Func<KeyValuePair<byte, byte>, byte> nullMap = null;
            try
            {
                ZEnumerable.Max(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToIList();
            try
            {
                ZEnumerable.Max(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Max(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

                     
                
        [TestMethod]
        public void TestMaxbyteIList1()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (byte) r.Next(byte.MaxValue), 1).ToIList();
            byte maxActual = ZEnumerable.Max(source);
            byte maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxbyteIList1Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (byte) r.Next(byte.MaxValue) } , 1).ToIList();
            byte maxActual = ZEnumerable.Max(source, arg => arg.X);
            byte maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxbyteIList2()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (byte) r.Next(byte.MaxValue), 2).ToIList();
            byte maxActual = ZEnumerable.Max(source);
            byte maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxbyteIList2Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (byte) r.Next(byte.MaxValue) } , 2).ToIList();
            byte maxActual = ZEnumerable.Max(source, arg => arg.X);
            byte maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxbyteIList3()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (byte) r.Next(byte.MaxValue), 3).ToIList();
            byte maxActual = ZEnumerable.Max(source);
            byte maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxbyteIList3Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (byte) r.Next(byte.MaxValue) } , 3).ToIList();
            byte maxActual = ZEnumerable.Max(source, arg => arg.X);
            byte maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxbyteIList4()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (byte) r.Next(byte.MaxValue), 4).ToIList();
            byte maxActual = ZEnumerable.Max(source);
            byte maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxbyteIList4Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (byte) r.Next(byte.MaxValue) } , 4).ToIList();
            byte maxActual = ZEnumerable.Max(source, arg => arg.X);
            byte maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxbyteIList100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (byte) r.Next(byte.MaxValue), 100).ToIList();
            byte maxActual = ZEnumerable.Max(source);
            byte maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxbyteIList100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (byte) r.Next(byte.MaxValue) } , 100).ToIList();
            byte maxActual = ZEnumerable.Max(source, arg => arg.X);
            byte maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxbyteIList2048()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (byte) r.Next(byte.MaxValue), 2048).ToIList();
            byte maxActual = ZEnumerable.Max(source);
            byte maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxbyteIList2048Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (byte) r.Next(byte.MaxValue) } , 2048).ToIList();
            byte maxActual = ZEnumerable.Max(source, arg => arg.X);
            byte maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                        
               
        #endregion

      

        #region short 
             
            
        [TestMethod]
        public void TestMaxshortArrayNullOrEmpty()
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

            short[] emptySource = new short[0].ToArray();
            try
            {
                ZEnumerable.Max(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestMaxshortArrayMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<short,short>((short) arg, (short) arg)).ToArray();
            Func<KeyValuePair<short, short>, short> nullMap = null;
            try
            {
                ZEnumerable.Max(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToArray();
            try
            {
                ZEnumerable.Max(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Max(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

                     
                
        [TestMethod]
        public void TestMaxshortArray1()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (short) r.Next(short.MaxValue), 1).ToArray();
            short maxActual = ZEnumerable.Max(source);
            short maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxshortArray1Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (short) r.Next(short.MaxValue) } , 1).ToArray();
            short maxActual = ZEnumerable.Max(source, arg => arg.X);
            short maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxshortArray2()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (short) r.Next(short.MaxValue), 2).ToArray();
            short maxActual = ZEnumerable.Max(source);
            short maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxshortArray2Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (short) r.Next(short.MaxValue) } , 2).ToArray();
            short maxActual = ZEnumerable.Max(source, arg => arg.X);
            short maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxshortArray3()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (short) r.Next(short.MaxValue), 3).ToArray();
            short maxActual = ZEnumerable.Max(source);
            short maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxshortArray3Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (short) r.Next(short.MaxValue) } , 3).ToArray();
            short maxActual = ZEnumerable.Max(source, arg => arg.X);
            short maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxshortArray4()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (short) r.Next(short.MaxValue), 4).ToArray();
            short maxActual = ZEnumerable.Max(source);
            short maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxshortArray4Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (short) r.Next(short.MaxValue) } , 4).ToArray();
            short maxActual = ZEnumerable.Max(source, arg => arg.X);
            short maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxshortArray100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (short) r.Next(short.MaxValue), 100).ToArray();
            short maxActual = ZEnumerable.Max(source);
            short maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxshortArray100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (short) r.Next(short.MaxValue) } , 100).ToArray();
            short maxActual = ZEnumerable.Max(source, arg => arg.X);
            short maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxshortArray2048()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (short) r.Next(short.MaxValue), 2048).ToArray();
            short maxActual = ZEnumerable.Max(source);
            short maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxshortArray2048Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (short) r.Next(short.MaxValue) } , 2048).ToArray();
            short maxActual = ZEnumerable.Max(source, arg => arg.X);
            short maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
            
        [TestMethod]
        public void TestMaxshortListNullOrEmpty()
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

            List<short> emptySource = new short[0].ToList();
            try
            {
                ZEnumerable.Max(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestMaxshortListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<short,short>((short) arg, (short) arg)).ToList();
            Func<KeyValuePair<short, short>, short> nullMap = null;
            try
            {
                ZEnumerable.Max(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToList();
            try
            {
                ZEnumerable.Max(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Max(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

                     
                
        [TestMethod]
        public void TestMaxshortList1()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (short) r.Next(short.MaxValue), 1).ToList();
            short maxActual = ZEnumerable.Max(source);
            short maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxshortList1Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (short) r.Next(short.MaxValue) } , 1).ToList();
            short maxActual = ZEnumerable.Max(source, arg => arg.X);
            short maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxshortList2()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (short) r.Next(short.MaxValue), 2).ToList();
            short maxActual = ZEnumerable.Max(source);
            short maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxshortList2Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (short) r.Next(short.MaxValue) } , 2).ToList();
            short maxActual = ZEnumerable.Max(source, arg => arg.X);
            short maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxshortList3()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (short) r.Next(short.MaxValue), 3).ToList();
            short maxActual = ZEnumerable.Max(source);
            short maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxshortList3Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (short) r.Next(short.MaxValue) } , 3).ToList();
            short maxActual = ZEnumerable.Max(source, arg => arg.X);
            short maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxshortList4()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (short) r.Next(short.MaxValue), 4).ToList();
            short maxActual = ZEnumerable.Max(source);
            short maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxshortList4Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (short) r.Next(short.MaxValue) } , 4).ToList();
            short maxActual = ZEnumerable.Max(source, arg => arg.X);
            short maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxshortList100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (short) r.Next(short.MaxValue), 100).ToList();
            short maxActual = ZEnumerable.Max(source);
            short maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxshortList100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (short) r.Next(short.MaxValue) } , 100).ToList();
            short maxActual = ZEnumerable.Max(source, arg => arg.X);
            short maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxshortList2048()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (short) r.Next(short.MaxValue), 2048).ToList();
            short maxActual = ZEnumerable.Max(source);
            short maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxshortList2048Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (short) r.Next(short.MaxValue) } , 2048).ToList();
            short maxActual = ZEnumerable.Max(source, arg => arg.X);
            short maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
            
        [TestMethod]
        public void TestMaxshortIListNullOrEmpty()
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

            IList<short> emptySource = new short[0].ToIList();
            try
            {
                ZEnumerable.Max(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestMaxshortIListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<short,short>((short) arg, (short) arg)).ToIList();
            Func<KeyValuePair<short, short>, short> nullMap = null;
            try
            {
                ZEnumerable.Max(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToIList();
            try
            {
                ZEnumerable.Max(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Max(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

                     
                
        [TestMethod]
        public void TestMaxshortIList1()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (short) r.Next(short.MaxValue), 1).ToIList();
            short maxActual = ZEnumerable.Max(source);
            short maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxshortIList1Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (short) r.Next(short.MaxValue) } , 1).ToIList();
            short maxActual = ZEnumerable.Max(source, arg => arg.X);
            short maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxshortIList2()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (short) r.Next(short.MaxValue), 2).ToIList();
            short maxActual = ZEnumerable.Max(source);
            short maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxshortIList2Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (short) r.Next(short.MaxValue) } , 2).ToIList();
            short maxActual = ZEnumerable.Max(source, arg => arg.X);
            short maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxshortIList3()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (short) r.Next(short.MaxValue), 3).ToIList();
            short maxActual = ZEnumerable.Max(source);
            short maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxshortIList3Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (short) r.Next(short.MaxValue) } , 3).ToIList();
            short maxActual = ZEnumerable.Max(source, arg => arg.X);
            short maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxshortIList4()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (short) r.Next(short.MaxValue), 4).ToIList();
            short maxActual = ZEnumerable.Max(source);
            short maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxshortIList4Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (short) r.Next(short.MaxValue) } , 4).ToIList();
            short maxActual = ZEnumerable.Max(source, arg => arg.X);
            short maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxshortIList100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (short) r.Next(short.MaxValue), 100).ToIList();
            short maxActual = ZEnumerable.Max(source);
            short maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxshortIList100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (short) r.Next(short.MaxValue) } , 100).ToIList();
            short maxActual = ZEnumerable.Max(source, arg => arg.X);
            short maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxshortIList2048()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (short) r.Next(short.MaxValue), 2048).ToIList();
            short maxActual = ZEnumerable.Max(source);
            short maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxshortIList2048Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (short) r.Next(short.MaxValue) } , 2048).ToIList();
            short maxActual = ZEnumerable.Max(source, arg => arg.X);
            short maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                        
               
        #endregion

      

        #region ushort 
             
            
        [TestMethod]
        public void TestMaxushortArrayNullOrEmpty()
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

            ushort[] emptySource = new ushort[0].ToArray();
            try
            {
                ZEnumerable.Max(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestMaxushortArrayMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<ushort,ushort>((ushort) arg, (ushort) arg)).ToArray();
            Func<KeyValuePair<ushort, ushort>, ushort> nullMap = null;
            try
            {
                ZEnumerable.Max(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToArray();
            try
            {
                ZEnumerable.Max(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Max(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

                     
                
        [TestMethod]
        public void TestMaxushortArray1()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ushort) r.Next(ushort.MaxValue), 1).ToArray();
            ushort maxActual = ZEnumerable.Max(source);
            ushort maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxushortArray1Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ushort) r.Next(ushort.MaxValue) } , 1).ToArray();
            ushort maxActual = ZEnumerable.Max(source, arg => arg.X);
            ushort maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxushortArray2()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ushort) r.Next(ushort.MaxValue), 2).ToArray();
            ushort maxActual = ZEnumerable.Max(source);
            ushort maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxushortArray2Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ushort) r.Next(ushort.MaxValue) } , 2).ToArray();
            ushort maxActual = ZEnumerable.Max(source, arg => arg.X);
            ushort maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxushortArray3()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ushort) r.Next(ushort.MaxValue), 3).ToArray();
            ushort maxActual = ZEnumerable.Max(source);
            ushort maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxushortArray3Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ushort) r.Next(ushort.MaxValue) } , 3).ToArray();
            ushort maxActual = ZEnumerable.Max(source, arg => arg.X);
            ushort maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxushortArray4()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ushort) r.Next(ushort.MaxValue), 4).ToArray();
            ushort maxActual = ZEnumerable.Max(source);
            ushort maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxushortArray4Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ushort) r.Next(ushort.MaxValue) } , 4).ToArray();
            ushort maxActual = ZEnumerable.Max(source, arg => arg.X);
            ushort maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxushortArray100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ushort) r.Next(ushort.MaxValue), 100).ToArray();
            ushort maxActual = ZEnumerable.Max(source);
            ushort maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxushortArray100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ushort) r.Next(ushort.MaxValue) } , 100).ToArray();
            ushort maxActual = ZEnumerable.Max(source, arg => arg.X);
            ushort maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxushortArray2048()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ushort) r.Next(ushort.MaxValue), 2048).ToArray();
            ushort maxActual = ZEnumerable.Max(source);
            ushort maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxushortArray2048Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ushort) r.Next(ushort.MaxValue) } , 2048).ToArray();
            ushort maxActual = ZEnumerable.Max(source, arg => arg.X);
            ushort maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
            
        [TestMethod]
        public void TestMaxushortListNullOrEmpty()
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

            List<ushort> emptySource = new ushort[0].ToList();
            try
            {
                ZEnumerable.Max(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestMaxushortListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<ushort,ushort>((ushort) arg, (ushort) arg)).ToList();
            Func<KeyValuePair<ushort, ushort>, ushort> nullMap = null;
            try
            {
                ZEnumerable.Max(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToList();
            try
            {
                ZEnumerable.Max(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Max(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

                     
                
        [TestMethod]
        public void TestMaxushortList1()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ushort) r.Next(ushort.MaxValue), 1).ToList();
            ushort maxActual = ZEnumerable.Max(source);
            ushort maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxushortList1Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ushort) r.Next(ushort.MaxValue) } , 1).ToList();
            ushort maxActual = ZEnumerable.Max(source, arg => arg.X);
            ushort maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxushortList2()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ushort) r.Next(ushort.MaxValue), 2).ToList();
            ushort maxActual = ZEnumerable.Max(source);
            ushort maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxushortList2Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ushort) r.Next(ushort.MaxValue) } , 2).ToList();
            ushort maxActual = ZEnumerable.Max(source, arg => arg.X);
            ushort maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxushortList3()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ushort) r.Next(ushort.MaxValue), 3).ToList();
            ushort maxActual = ZEnumerable.Max(source);
            ushort maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxushortList3Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ushort) r.Next(ushort.MaxValue) } , 3).ToList();
            ushort maxActual = ZEnumerable.Max(source, arg => arg.X);
            ushort maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxushortList4()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ushort) r.Next(ushort.MaxValue), 4).ToList();
            ushort maxActual = ZEnumerable.Max(source);
            ushort maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxushortList4Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ushort) r.Next(ushort.MaxValue) } , 4).ToList();
            ushort maxActual = ZEnumerable.Max(source, arg => arg.X);
            ushort maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxushortList100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ushort) r.Next(ushort.MaxValue), 100).ToList();
            ushort maxActual = ZEnumerable.Max(source);
            ushort maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxushortList100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ushort) r.Next(ushort.MaxValue) } , 100).ToList();
            ushort maxActual = ZEnumerable.Max(source, arg => arg.X);
            ushort maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxushortList2048()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ushort) r.Next(ushort.MaxValue), 2048).ToList();
            ushort maxActual = ZEnumerable.Max(source);
            ushort maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxushortList2048Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ushort) r.Next(ushort.MaxValue) } , 2048).ToList();
            ushort maxActual = ZEnumerable.Max(source, arg => arg.X);
            ushort maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
            
        [TestMethod]
        public void TestMaxushortIListNullOrEmpty()
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

            IList<ushort> emptySource = new ushort[0].ToIList();
            try
            {
                ZEnumerable.Max(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestMaxushortIListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<ushort,ushort>((ushort) arg, (ushort) arg)).ToIList();
            Func<KeyValuePair<ushort, ushort>, ushort> nullMap = null;
            try
            {
                ZEnumerable.Max(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToIList();
            try
            {
                ZEnumerable.Max(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Max(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

                     
                
        [TestMethod]
        public void TestMaxushortIList1()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ushort) r.Next(ushort.MaxValue), 1).ToIList();
            ushort maxActual = ZEnumerable.Max(source);
            ushort maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxushortIList1Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ushort) r.Next(ushort.MaxValue) } , 1).ToIList();
            ushort maxActual = ZEnumerable.Max(source, arg => arg.X);
            ushort maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxushortIList2()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ushort) r.Next(ushort.MaxValue), 2).ToIList();
            ushort maxActual = ZEnumerable.Max(source);
            ushort maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxushortIList2Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ushort) r.Next(ushort.MaxValue) } , 2).ToIList();
            ushort maxActual = ZEnumerable.Max(source, arg => arg.X);
            ushort maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxushortIList3()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ushort) r.Next(ushort.MaxValue), 3).ToIList();
            ushort maxActual = ZEnumerable.Max(source);
            ushort maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxushortIList3Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ushort) r.Next(ushort.MaxValue) } , 3).ToIList();
            ushort maxActual = ZEnumerable.Max(source, arg => arg.X);
            ushort maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxushortIList4()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ushort) r.Next(ushort.MaxValue), 4).ToIList();
            ushort maxActual = ZEnumerable.Max(source);
            ushort maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxushortIList4Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ushort) r.Next(ushort.MaxValue) } , 4).ToIList();
            ushort maxActual = ZEnumerable.Max(source, arg => arg.X);
            ushort maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxushortIList100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ushort) r.Next(ushort.MaxValue), 100).ToIList();
            ushort maxActual = ZEnumerable.Max(source);
            ushort maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxushortIList100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ushort) r.Next(ushort.MaxValue) } , 100).ToIList();
            ushort maxActual = ZEnumerable.Max(source, arg => arg.X);
            ushort maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxushortIList2048()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ushort) r.Next(ushort.MaxValue), 2048).ToIList();
            ushort maxActual = ZEnumerable.Max(source);
            ushort maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxushortIList2048Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ushort) r.Next(ushort.MaxValue) } , 2048).ToIList();
            ushort maxActual = ZEnumerable.Max(source, arg => arg.X);
            ushort maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                        
               
        #endregion

      

        #region int 
             
            
        [TestMethod]
        public void TestMaxintArrayNullOrEmpty()
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

            int[] emptySource = new int[0].ToArray();
            try
            {
                ZEnumerable.Max(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestMaxintArrayMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<int,int>((int) arg, (int) arg)).ToArray();
            Func<KeyValuePair<int, int>, int> nullMap = null;
            try
            {
                ZEnumerable.Max(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToArray();
            try
            {
                ZEnumerable.Max(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Max(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

                     
                
        [TestMethod]
        public void TestMaxintArray1()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (int) r.Next(int.MaxValue), 1).ToArray();
            int maxActual = ZEnumerable.Max(source);
            int maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxintArray1Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (int) r.Next(int.MaxValue) } , 1).ToArray();
            int maxActual = ZEnumerable.Max(source, arg => arg.X);
            int maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxintArray2()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (int) r.Next(int.MaxValue), 2).ToArray();
            int maxActual = ZEnumerable.Max(source);
            int maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxintArray2Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (int) r.Next(int.MaxValue) } , 2).ToArray();
            int maxActual = ZEnumerable.Max(source, arg => arg.X);
            int maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxintArray3()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (int) r.Next(int.MaxValue), 3).ToArray();
            int maxActual = ZEnumerable.Max(source);
            int maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxintArray3Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (int) r.Next(int.MaxValue) } , 3).ToArray();
            int maxActual = ZEnumerable.Max(source, arg => arg.X);
            int maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxintArray4()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (int) r.Next(int.MaxValue), 4).ToArray();
            int maxActual = ZEnumerable.Max(source);
            int maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxintArray4Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (int) r.Next(int.MaxValue) } , 4).ToArray();
            int maxActual = ZEnumerable.Max(source, arg => arg.X);
            int maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxintArray100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (int) r.Next(int.MaxValue), 100).ToArray();
            int maxActual = ZEnumerable.Max(source);
            int maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxintArray100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (int) r.Next(int.MaxValue) } , 100).ToArray();
            int maxActual = ZEnumerable.Max(source, arg => arg.X);
            int maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxintArray2048()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (int) r.Next(int.MaxValue), 2048).ToArray();
            int maxActual = ZEnumerable.Max(source);
            int maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxintArray2048Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (int) r.Next(int.MaxValue) } , 2048).ToArray();
            int maxActual = ZEnumerable.Max(source, arg => arg.X);
            int maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
            
        [TestMethod]
        public void TestMaxintListNullOrEmpty()
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

            List<int> emptySource = new int[0].ToList();
            try
            {
                ZEnumerable.Max(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestMaxintListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<int,int>((int) arg, (int) arg)).ToList();
            Func<KeyValuePair<int, int>, int> nullMap = null;
            try
            {
                ZEnumerable.Max(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToList();
            try
            {
                ZEnumerable.Max(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Max(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

                     
                
        [TestMethod]
        public void TestMaxintList1()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (int) r.Next(int.MaxValue), 1).ToList();
            int maxActual = ZEnumerable.Max(source);
            int maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxintList1Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (int) r.Next(int.MaxValue) } , 1).ToList();
            int maxActual = ZEnumerable.Max(source, arg => arg.X);
            int maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxintList2()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (int) r.Next(int.MaxValue), 2).ToList();
            int maxActual = ZEnumerable.Max(source);
            int maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxintList2Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (int) r.Next(int.MaxValue) } , 2).ToList();
            int maxActual = ZEnumerable.Max(source, arg => arg.X);
            int maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxintList3()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (int) r.Next(int.MaxValue), 3).ToList();
            int maxActual = ZEnumerable.Max(source);
            int maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxintList3Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (int) r.Next(int.MaxValue) } , 3).ToList();
            int maxActual = ZEnumerable.Max(source, arg => arg.X);
            int maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxintList4()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (int) r.Next(int.MaxValue), 4).ToList();
            int maxActual = ZEnumerable.Max(source);
            int maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxintList4Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (int) r.Next(int.MaxValue) } , 4).ToList();
            int maxActual = ZEnumerable.Max(source, arg => arg.X);
            int maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxintList100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (int) r.Next(int.MaxValue), 100).ToList();
            int maxActual = ZEnumerable.Max(source);
            int maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxintList100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (int) r.Next(int.MaxValue) } , 100).ToList();
            int maxActual = ZEnumerable.Max(source, arg => arg.X);
            int maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxintList2048()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (int) r.Next(int.MaxValue), 2048).ToList();
            int maxActual = ZEnumerable.Max(source);
            int maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxintList2048Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (int) r.Next(int.MaxValue) } , 2048).ToList();
            int maxActual = ZEnumerable.Max(source, arg => arg.X);
            int maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
            
        [TestMethod]
        public void TestMaxintIListNullOrEmpty()
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

            IList<int> emptySource = new int[0].ToIList();
            try
            {
                ZEnumerable.Max(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestMaxintIListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<int,int>((int) arg, (int) arg)).ToIList();
            Func<KeyValuePair<int, int>, int> nullMap = null;
            try
            {
                ZEnumerable.Max(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToIList();
            try
            {
                ZEnumerable.Max(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Max(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

                     
                
        [TestMethod]
        public void TestMaxintIList1()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (int) r.Next(int.MaxValue), 1).ToIList();
            int maxActual = ZEnumerable.Max(source);
            int maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxintIList1Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (int) r.Next(int.MaxValue) } , 1).ToIList();
            int maxActual = ZEnumerable.Max(source, arg => arg.X);
            int maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxintIList2()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (int) r.Next(int.MaxValue), 2).ToIList();
            int maxActual = ZEnumerable.Max(source);
            int maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxintIList2Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (int) r.Next(int.MaxValue) } , 2).ToIList();
            int maxActual = ZEnumerable.Max(source, arg => arg.X);
            int maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxintIList3()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (int) r.Next(int.MaxValue), 3).ToIList();
            int maxActual = ZEnumerable.Max(source);
            int maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxintIList3Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (int) r.Next(int.MaxValue) } , 3).ToIList();
            int maxActual = ZEnumerable.Max(source, arg => arg.X);
            int maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxintIList4()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (int) r.Next(int.MaxValue), 4).ToIList();
            int maxActual = ZEnumerable.Max(source);
            int maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxintIList4Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (int) r.Next(int.MaxValue) } , 4).ToIList();
            int maxActual = ZEnumerable.Max(source, arg => arg.X);
            int maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxintIList100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (int) r.Next(int.MaxValue), 100).ToIList();
            int maxActual = ZEnumerable.Max(source);
            int maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxintIList100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (int) r.Next(int.MaxValue) } , 100).ToIList();
            int maxActual = ZEnumerable.Max(source, arg => arg.X);
            int maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxintIList2048()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (int) r.Next(int.MaxValue), 2048).ToIList();
            int maxActual = ZEnumerable.Max(source);
            int maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxintIList2048Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (int) r.Next(int.MaxValue) } , 2048).ToIList();
            int maxActual = ZEnumerable.Max(source, arg => arg.X);
            int maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                        
               
        #endregion

      

        #region uint 
             
            
        [TestMethod]
        public void TestMaxuintArrayNullOrEmpty()
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

            uint[] emptySource = new uint[0].ToArray();
            try
            {
                ZEnumerable.Max(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestMaxuintArrayMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<uint,uint>((uint) arg, (uint) arg)).ToArray();
            Func<KeyValuePair<uint, uint>, uint> nullMap = null;
            try
            {
                ZEnumerable.Max(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToArray();
            try
            {
                ZEnumerable.Max(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Max(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

                     
                
        [TestMethod]
        public void TestMaxuintArray1()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (uint) r.Next(int.MaxValue), 1).ToArray();
            uint maxActual = ZEnumerable.Max(source);
            uint maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxuintArray1Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (uint) r.Next(int.MaxValue) } , 1).ToArray();
            uint maxActual = ZEnumerable.Max(source, arg => arg.X);
            uint maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxuintArray2()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (uint) r.Next(int.MaxValue), 2).ToArray();
            uint maxActual = ZEnumerable.Max(source);
            uint maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxuintArray2Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (uint) r.Next(int.MaxValue) } , 2).ToArray();
            uint maxActual = ZEnumerable.Max(source, arg => arg.X);
            uint maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxuintArray3()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (uint) r.Next(int.MaxValue), 3).ToArray();
            uint maxActual = ZEnumerable.Max(source);
            uint maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxuintArray3Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (uint) r.Next(int.MaxValue) } , 3).ToArray();
            uint maxActual = ZEnumerable.Max(source, arg => arg.X);
            uint maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxuintArray4()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (uint) r.Next(int.MaxValue), 4).ToArray();
            uint maxActual = ZEnumerable.Max(source);
            uint maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxuintArray4Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (uint) r.Next(int.MaxValue) } , 4).ToArray();
            uint maxActual = ZEnumerable.Max(source, arg => arg.X);
            uint maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxuintArray100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (uint) r.Next(int.MaxValue), 100).ToArray();
            uint maxActual = ZEnumerable.Max(source);
            uint maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxuintArray100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (uint) r.Next(int.MaxValue) } , 100).ToArray();
            uint maxActual = ZEnumerable.Max(source, arg => arg.X);
            uint maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxuintArray2048()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (uint) r.Next(int.MaxValue), 2048).ToArray();
            uint maxActual = ZEnumerable.Max(source);
            uint maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxuintArray2048Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (uint) r.Next(int.MaxValue) } , 2048).ToArray();
            uint maxActual = ZEnumerable.Max(source, arg => arg.X);
            uint maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
            
        [TestMethod]
        public void TestMaxuintListNullOrEmpty()
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

            List<uint> emptySource = new uint[0].ToList();
            try
            {
                ZEnumerable.Max(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestMaxuintListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<uint,uint>((uint) arg, (uint) arg)).ToList();
            Func<KeyValuePair<uint, uint>, uint> nullMap = null;
            try
            {
                ZEnumerable.Max(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToList();
            try
            {
                ZEnumerable.Max(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Max(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

                     
                
        [TestMethod]
        public void TestMaxuintList1()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (uint) r.Next(int.MaxValue), 1).ToList();
            uint maxActual = ZEnumerable.Max(source);
            uint maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxuintList1Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (uint) r.Next(int.MaxValue) } , 1).ToList();
            uint maxActual = ZEnumerable.Max(source, arg => arg.X);
            uint maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxuintList2()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (uint) r.Next(int.MaxValue), 2).ToList();
            uint maxActual = ZEnumerable.Max(source);
            uint maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxuintList2Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (uint) r.Next(int.MaxValue) } , 2).ToList();
            uint maxActual = ZEnumerable.Max(source, arg => arg.X);
            uint maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxuintList3()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (uint) r.Next(int.MaxValue), 3).ToList();
            uint maxActual = ZEnumerable.Max(source);
            uint maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxuintList3Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (uint) r.Next(int.MaxValue) } , 3).ToList();
            uint maxActual = ZEnumerable.Max(source, arg => arg.X);
            uint maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxuintList4()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (uint) r.Next(int.MaxValue), 4).ToList();
            uint maxActual = ZEnumerable.Max(source);
            uint maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxuintList4Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (uint) r.Next(int.MaxValue) } , 4).ToList();
            uint maxActual = ZEnumerable.Max(source, arg => arg.X);
            uint maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxuintList100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (uint) r.Next(int.MaxValue), 100).ToList();
            uint maxActual = ZEnumerable.Max(source);
            uint maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxuintList100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (uint) r.Next(int.MaxValue) } , 100).ToList();
            uint maxActual = ZEnumerable.Max(source, arg => arg.X);
            uint maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxuintList2048()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (uint) r.Next(int.MaxValue), 2048).ToList();
            uint maxActual = ZEnumerable.Max(source);
            uint maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxuintList2048Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (uint) r.Next(int.MaxValue) } , 2048).ToList();
            uint maxActual = ZEnumerable.Max(source, arg => arg.X);
            uint maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
            
        [TestMethod]
        public void TestMaxuintIListNullOrEmpty()
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

            IList<uint> emptySource = new uint[0].ToIList();
            try
            {
                ZEnumerable.Max(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestMaxuintIListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<uint,uint>((uint) arg, (uint) arg)).ToIList();
            Func<KeyValuePair<uint, uint>, uint> nullMap = null;
            try
            {
                ZEnumerable.Max(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToIList();
            try
            {
                ZEnumerable.Max(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Max(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

                     
                
        [TestMethod]
        public void TestMaxuintIList1()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (uint) r.Next(int.MaxValue), 1).ToIList();
            uint maxActual = ZEnumerable.Max(source);
            uint maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxuintIList1Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (uint) r.Next(int.MaxValue) } , 1).ToIList();
            uint maxActual = ZEnumerable.Max(source, arg => arg.X);
            uint maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxuintIList2()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (uint) r.Next(int.MaxValue), 2).ToIList();
            uint maxActual = ZEnumerable.Max(source);
            uint maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxuintIList2Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (uint) r.Next(int.MaxValue) } , 2).ToIList();
            uint maxActual = ZEnumerable.Max(source, arg => arg.X);
            uint maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxuintIList3()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (uint) r.Next(int.MaxValue), 3).ToIList();
            uint maxActual = ZEnumerable.Max(source);
            uint maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxuintIList3Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (uint) r.Next(int.MaxValue) } , 3).ToIList();
            uint maxActual = ZEnumerable.Max(source, arg => arg.X);
            uint maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxuintIList4()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (uint) r.Next(int.MaxValue), 4).ToIList();
            uint maxActual = ZEnumerable.Max(source);
            uint maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxuintIList4Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (uint) r.Next(int.MaxValue) } , 4).ToIList();
            uint maxActual = ZEnumerable.Max(source, arg => arg.X);
            uint maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxuintIList100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (uint) r.Next(int.MaxValue), 100).ToIList();
            uint maxActual = ZEnumerable.Max(source);
            uint maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxuintIList100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (uint) r.Next(int.MaxValue) } , 100).ToIList();
            uint maxActual = ZEnumerable.Max(source, arg => arg.X);
            uint maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxuintIList2048()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (uint) r.Next(int.MaxValue), 2048).ToIList();
            uint maxActual = ZEnumerable.Max(source);
            uint maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxuintIList2048Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (uint) r.Next(int.MaxValue) } , 2048).ToIList();
            uint maxActual = ZEnumerable.Max(source, arg => arg.X);
            uint maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                        
               
        #endregion

      

        #region long 
             
            
        [TestMethod]
        public void TestMaxlongArrayNullOrEmpty()
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

            long[] emptySource = new long[0].ToArray();
            try
            {
                ZEnumerable.Max(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestMaxlongArrayMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<long,long>((long) arg, (long) arg)).ToArray();
            Func<KeyValuePair<long, long>, long> nullMap = null;
            try
            {
                ZEnumerable.Max(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToArray();
            try
            {
                ZEnumerable.Max(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Max(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

                     
                
        [TestMethod]
        public void TestMaxlongArray1()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (long) r.Next(int.MaxValue), 1).ToArray();
            long maxActual = ZEnumerable.Max(source);
            long maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxlongArray1Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (long) r.Next(int.MaxValue) } , 1).ToArray();
            long maxActual = ZEnumerable.Max(source, arg => arg.X);
            long maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxlongArray2()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (long) r.Next(int.MaxValue), 2).ToArray();
            long maxActual = ZEnumerable.Max(source);
            long maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxlongArray2Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (long) r.Next(int.MaxValue) } , 2).ToArray();
            long maxActual = ZEnumerable.Max(source, arg => arg.X);
            long maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxlongArray3()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (long) r.Next(int.MaxValue), 3).ToArray();
            long maxActual = ZEnumerable.Max(source);
            long maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxlongArray3Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (long) r.Next(int.MaxValue) } , 3).ToArray();
            long maxActual = ZEnumerable.Max(source, arg => arg.X);
            long maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxlongArray4()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (long) r.Next(int.MaxValue), 4).ToArray();
            long maxActual = ZEnumerable.Max(source);
            long maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxlongArray4Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (long) r.Next(int.MaxValue) } , 4).ToArray();
            long maxActual = ZEnumerable.Max(source, arg => arg.X);
            long maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxlongArray100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (long) r.Next(int.MaxValue), 100).ToArray();
            long maxActual = ZEnumerable.Max(source);
            long maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxlongArray100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (long) r.Next(int.MaxValue) } , 100).ToArray();
            long maxActual = ZEnumerable.Max(source, arg => arg.X);
            long maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxlongArray2048()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (long) r.Next(int.MaxValue), 2048).ToArray();
            long maxActual = ZEnumerable.Max(source);
            long maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxlongArray2048Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (long) r.Next(int.MaxValue) } , 2048).ToArray();
            long maxActual = ZEnumerable.Max(source, arg => arg.X);
            long maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
            
        [TestMethod]
        public void TestMaxlongListNullOrEmpty()
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

            List<long> emptySource = new long[0].ToList();
            try
            {
                ZEnumerable.Max(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestMaxlongListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<long,long>((long) arg, (long) arg)).ToList();
            Func<KeyValuePair<long, long>, long> nullMap = null;
            try
            {
                ZEnumerable.Max(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToList();
            try
            {
                ZEnumerable.Max(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Max(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

                     
                
        [TestMethod]
        public void TestMaxlongList1()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (long) r.Next(int.MaxValue), 1).ToList();
            long maxActual = ZEnumerable.Max(source);
            long maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxlongList1Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (long) r.Next(int.MaxValue) } , 1).ToList();
            long maxActual = ZEnumerable.Max(source, arg => arg.X);
            long maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxlongList2()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (long) r.Next(int.MaxValue), 2).ToList();
            long maxActual = ZEnumerable.Max(source);
            long maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxlongList2Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (long) r.Next(int.MaxValue) } , 2).ToList();
            long maxActual = ZEnumerable.Max(source, arg => arg.X);
            long maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxlongList3()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (long) r.Next(int.MaxValue), 3).ToList();
            long maxActual = ZEnumerable.Max(source);
            long maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxlongList3Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (long) r.Next(int.MaxValue) } , 3).ToList();
            long maxActual = ZEnumerable.Max(source, arg => arg.X);
            long maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxlongList4()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (long) r.Next(int.MaxValue), 4).ToList();
            long maxActual = ZEnumerable.Max(source);
            long maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxlongList4Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (long) r.Next(int.MaxValue) } , 4).ToList();
            long maxActual = ZEnumerable.Max(source, arg => arg.X);
            long maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxlongList100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (long) r.Next(int.MaxValue), 100).ToList();
            long maxActual = ZEnumerable.Max(source);
            long maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxlongList100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (long) r.Next(int.MaxValue) } , 100).ToList();
            long maxActual = ZEnumerable.Max(source, arg => arg.X);
            long maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxlongList2048()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (long) r.Next(int.MaxValue), 2048).ToList();
            long maxActual = ZEnumerable.Max(source);
            long maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxlongList2048Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (long) r.Next(int.MaxValue) } , 2048).ToList();
            long maxActual = ZEnumerable.Max(source, arg => arg.X);
            long maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
            
        [TestMethod]
        public void TestMaxlongIListNullOrEmpty()
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

            IList<long> emptySource = new long[0].ToIList();
            try
            {
                ZEnumerable.Max(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestMaxlongIListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<long,long>((long) arg, (long) arg)).ToIList();
            Func<KeyValuePair<long, long>, long> nullMap = null;
            try
            {
                ZEnumerable.Max(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToIList();
            try
            {
                ZEnumerable.Max(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Max(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

                     
                
        [TestMethod]
        public void TestMaxlongIList1()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (long) r.Next(int.MaxValue), 1).ToIList();
            long maxActual = ZEnumerable.Max(source);
            long maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxlongIList1Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (long) r.Next(int.MaxValue) } , 1).ToIList();
            long maxActual = ZEnumerable.Max(source, arg => arg.X);
            long maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxlongIList2()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (long) r.Next(int.MaxValue), 2).ToIList();
            long maxActual = ZEnumerable.Max(source);
            long maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxlongIList2Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (long) r.Next(int.MaxValue) } , 2).ToIList();
            long maxActual = ZEnumerable.Max(source, arg => arg.X);
            long maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxlongIList3()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (long) r.Next(int.MaxValue), 3).ToIList();
            long maxActual = ZEnumerable.Max(source);
            long maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxlongIList3Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (long) r.Next(int.MaxValue) } , 3).ToIList();
            long maxActual = ZEnumerable.Max(source, arg => arg.X);
            long maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxlongIList4()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (long) r.Next(int.MaxValue), 4).ToIList();
            long maxActual = ZEnumerable.Max(source);
            long maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxlongIList4Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (long) r.Next(int.MaxValue) } , 4).ToIList();
            long maxActual = ZEnumerable.Max(source, arg => arg.X);
            long maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxlongIList100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (long) r.Next(int.MaxValue), 100).ToIList();
            long maxActual = ZEnumerable.Max(source);
            long maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxlongIList100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (long) r.Next(int.MaxValue) } , 100).ToIList();
            long maxActual = ZEnumerable.Max(source, arg => arg.X);
            long maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxlongIList2048()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (long) r.Next(int.MaxValue), 2048).ToIList();
            long maxActual = ZEnumerable.Max(source);
            long maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxlongIList2048Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (long) r.Next(int.MaxValue) } , 2048).ToIList();
            long maxActual = ZEnumerable.Max(source, arg => arg.X);
            long maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                        
               
        #endregion

      

        #region ulong 
             
            
        [TestMethod]
        public void TestMaxulongArrayNullOrEmpty()
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

            ulong[] emptySource = new ulong[0].ToArray();
            try
            {
                ZEnumerable.Max(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestMaxulongArrayMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<ulong,ulong>((ulong) arg, (ulong) arg)).ToArray();
            Func<KeyValuePair<ulong, ulong>, ulong> nullMap = null;
            try
            {
                ZEnumerable.Max(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToArray();
            try
            {
                ZEnumerable.Max(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Max(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

                     
                
        [TestMethod]
        public void TestMaxulongArray1()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ulong) r.Next(int.MaxValue), 1).ToArray();
            ulong maxActual = ZEnumerable.Max(source);
            ulong maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxulongArray1Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ulong) r.Next(int.MaxValue) } , 1).ToArray();
            ulong maxActual = ZEnumerable.Max(source, arg => arg.X);
            ulong maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxulongArray2()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ulong) r.Next(int.MaxValue), 2).ToArray();
            ulong maxActual = ZEnumerable.Max(source);
            ulong maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxulongArray2Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ulong) r.Next(int.MaxValue) } , 2).ToArray();
            ulong maxActual = ZEnumerable.Max(source, arg => arg.X);
            ulong maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxulongArray3()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ulong) r.Next(int.MaxValue), 3).ToArray();
            ulong maxActual = ZEnumerable.Max(source);
            ulong maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxulongArray3Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ulong) r.Next(int.MaxValue) } , 3).ToArray();
            ulong maxActual = ZEnumerable.Max(source, arg => arg.X);
            ulong maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxulongArray4()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ulong) r.Next(int.MaxValue), 4).ToArray();
            ulong maxActual = ZEnumerable.Max(source);
            ulong maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxulongArray4Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ulong) r.Next(int.MaxValue) } , 4).ToArray();
            ulong maxActual = ZEnumerable.Max(source, arg => arg.X);
            ulong maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxulongArray100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ulong) r.Next(int.MaxValue), 100).ToArray();
            ulong maxActual = ZEnumerable.Max(source);
            ulong maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxulongArray100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ulong) r.Next(int.MaxValue) } , 100).ToArray();
            ulong maxActual = ZEnumerable.Max(source, arg => arg.X);
            ulong maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxulongArray2048()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ulong) r.Next(int.MaxValue), 2048).ToArray();
            ulong maxActual = ZEnumerable.Max(source);
            ulong maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxulongArray2048Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ulong) r.Next(int.MaxValue) } , 2048).ToArray();
            ulong maxActual = ZEnumerable.Max(source, arg => arg.X);
            ulong maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
            
        [TestMethod]
        public void TestMaxulongListNullOrEmpty()
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

            List<ulong> emptySource = new ulong[0].ToList();
            try
            {
                ZEnumerable.Max(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestMaxulongListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<ulong,ulong>((ulong) arg, (ulong) arg)).ToList();
            Func<KeyValuePair<ulong, ulong>, ulong> nullMap = null;
            try
            {
                ZEnumerable.Max(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToList();
            try
            {
                ZEnumerable.Max(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Max(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

                     
                
        [TestMethod]
        public void TestMaxulongList1()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ulong) r.Next(int.MaxValue), 1).ToList();
            ulong maxActual = ZEnumerable.Max(source);
            ulong maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxulongList1Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ulong) r.Next(int.MaxValue) } , 1).ToList();
            ulong maxActual = ZEnumerable.Max(source, arg => arg.X);
            ulong maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxulongList2()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ulong) r.Next(int.MaxValue), 2).ToList();
            ulong maxActual = ZEnumerable.Max(source);
            ulong maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxulongList2Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ulong) r.Next(int.MaxValue) } , 2).ToList();
            ulong maxActual = ZEnumerable.Max(source, arg => arg.X);
            ulong maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxulongList3()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ulong) r.Next(int.MaxValue), 3).ToList();
            ulong maxActual = ZEnumerable.Max(source);
            ulong maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxulongList3Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ulong) r.Next(int.MaxValue) } , 3).ToList();
            ulong maxActual = ZEnumerable.Max(source, arg => arg.X);
            ulong maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxulongList4()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ulong) r.Next(int.MaxValue), 4).ToList();
            ulong maxActual = ZEnumerable.Max(source);
            ulong maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxulongList4Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ulong) r.Next(int.MaxValue) } , 4).ToList();
            ulong maxActual = ZEnumerable.Max(source, arg => arg.X);
            ulong maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxulongList100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ulong) r.Next(int.MaxValue), 100).ToList();
            ulong maxActual = ZEnumerable.Max(source);
            ulong maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxulongList100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ulong) r.Next(int.MaxValue) } , 100).ToList();
            ulong maxActual = ZEnumerable.Max(source, arg => arg.X);
            ulong maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxulongList2048()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ulong) r.Next(int.MaxValue), 2048).ToList();
            ulong maxActual = ZEnumerable.Max(source);
            ulong maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxulongList2048Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ulong) r.Next(int.MaxValue) } , 2048).ToList();
            ulong maxActual = ZEnumerable.Max(source, arg => arg.X);
            ulong maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
            
        [TestMethod]
        public void TestMaxulongIListNullOrEmpty()
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

            IList<ulong> emptySource = new ulong[0].ToIList();
            try
            {
                ZEnumerable.Max(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestMaxulongIListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<ulong,ulong>((ulong) arg, (ulong) arg)).ToIList();
            Func<KeyValuePair<ulong, ulong>, ulong> nullMap = null;
            try
            {
                ZEnumerable.Max(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToIList();
            try
            {
                ZEnumerable.Max(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Max(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

                     
                
        [TestMethod]
        public void TestMaxulongIList1()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ulong) r.Next(int.MaxValue), 1).ToIList();
            ulong maxActual = ZEnumerable.Max(source);
            ulong maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxulongIList1Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ulong) r.Next(int.MaxValue) } , 1).ToIList();
            ulong maxActual = ZEnumerable.Max(source, arg => arg.X);
            ulong maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxulongIList2()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ulong) r.Next(int.MaxValue), 2).ToIList();
            ulong maxActual = ZEnumerable.Max(source);
            ulong maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxulongIList2Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ulong) r.Next(int.MaxValue) } , 2).ToIList();
            ulong maxActual = ZEnumerable.Max(source, arg => arg.X);
            ulong maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxulongIList3()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ulong) r.Next(int.MaxValue), 3).ToIList();
            ulong maxActual = ZEnumerable.Max(source);
            ulong maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxulongIList3Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ulong) r.Next(int.MaxValue) } , 3).ToIList();
            ulong maxActual = ZEnumerable.Max(source, arg => arg.X);
            ulong maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxulongIList4()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ulong) r.Next(int.MaxValue), 4).ToIList();
            ulong maxActual = ZEnumerable.Max(source);
            ulong maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxulongIList4Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ulong) r.Next(int.MaxValue) } , 4).ToIList();
            ulong maxActual = ZEnumerable.Max(source, arg => arg.X);
            ulong maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxulongIList100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ulong) r.Next(int.MaxValue), 100).ToIList();
            ulong maxActual = ZEnumerable.Max(source);
            ulong maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxulongIList100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ulong) r.Next(int.MaxValue) } , 100).ToIList();
            ulong maxActual = ZEnumerable.Max(source, arg => arg.X);
            ulong maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxulongIList2048()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ulong) r.Next(int.MaxValue), 2048).ToIList();
            ulong maxActual = ZEnumerable.Max(source);
            ulong maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxulongIList2048Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ulong) r.Next(int.MaxValue) } , 2048).ToIList();
            ulong maxActual = ZEnumerable.Max(source, arg => arg.X);
            ulong maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                        
               
        #endregion

      

        #region float 
             
            
        [TestMethod]
        public void TestMaxfloatArrayNullOrEmpty()
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

            float[] emptySource = new float[0].ToArray();
            try
            {
                ZEnumerable.Max(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestMaxfloatArrayMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<float,float>((float) arg, (float) arg)).ToArray();
            Func<KeyValuePair<float, float>, float> nullMap = null;
            try
            {
                ZEnumerable.Max(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToArray();
            try
            {
                ZEnumerable.Max(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Max(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

                     
                
        [TestMethod]
        public void TestMaxfloatArray1()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (float) r.Next(int.MaxValue), 1).ToArray();
            float maxActual = ZEnumerable.Max(source);
            float maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxfloatArray1Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (float) r.Next(int.MaxValue) } , 1).ToArray();
            float maxActual = ZEnumerable.Max(source, arg => arg.X);
            float maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxfloatArray2()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (float) r.Next(int.MaxValue), 2).ToArray();
            float maxActual = ZEnumerable.Max(source);
            float maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxfloatArray2Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (float) r.Next(int.MaxValue) } , 2).ToArray();
            float maxActual = ZEnumerable.Max(source, arg => arg.X);
            float maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxfloatArray3()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (float) r.Next(int.MaxValue), 3).ToArray();
            float maxActual = ZEnumerable.Max(source);
            float maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxfloatArray3Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (float) r.Next(int.MaxValue) } , 3).ToArray();
            float maxActual = ZEnumerable.Max(source, arg => arg.X);
            float maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxfloatArray4()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (float) r.Next(int.MaxValue), 4).ToArray();
            float maxActual = ZEnumerable.Max(source);
            float maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxfloatArray4Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (float) r.Next(int.MaxValue) } , 4).ToArray();
            float maxActual = ZEnumerable.Max(source, arg => arg.X);
            float maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxfloatArray100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (float) r.Next(int.MaxValue), 100).ToArray();
            float maxActual = ZEnumerable.Max(source);
            float maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxfloatArray100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (float) r.Next(int.MaxValue) } , 100).ToArray();
            float maxActual = ZEnumerable.Max(source, arg => arg.X);
            float maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxfloatArray2048()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (float) r.Next(int.MaxValue), 2048).ToArray();
            float maxActual = ZEnumerable.Max(source);
            float maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxfloatArray2048Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (float) r.Next(int.MaxValue) } , 2048).ToArray();
            float maxActual = ZEnumerable.Max(source, arg => arg.X);
            float maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
            
        [TestMethod]
        public void TestMaxfloatListNullOrEmpty()
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

            List<float> emptySource = new float[0].ToList();
            try
            {
                ZEnumerable.Max(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestMaxfloatListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<float,float>((float) arg, (float) arg)).ToList();
            Func<KeyValuePair<float, float>, float> nullMap = null;
            try
            {
                ZEnumerable.Max(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToList();
            try
            {
                ZEnumerable.Max(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Max(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

                     
                
        [TestMethod]
        public void TestMaxfloatList1()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (float) r.Next(int.MaxValue), 1).ToList();
            float maxActual = ZEnumerable.Max(source);
            float maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxfloatList1Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (float) r.Next(int.MaxValue) } , 1).ToList();
            float maxActual = ZEnumerable.Max(source, arg => arg.X);
            float maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxfloatList2()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (float) r.Next(int.MaxValue), 2).ToList();
            float maxActual = ZEnumerable.Max(source);
            float maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxfloatList2Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (float) r.Next(int.MaxValue) } , 2).ToList();
            float maxActual = ZEnumerable.Max(source, arg => arg.X);
            float maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxfloatList3()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (float) r.Next(int.MaxValue), 3).ToList();
            float maxActual = ZEnumerable.Max(source);
            float maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxfloatList3Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (float) r.Next(int.MaxValue) } , 3).ToList();
            float maxActual = ZEnumerable.Max(source, arg => arg.X);
            float maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxfloatList4()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (float) r.Next(int.MaxValue), 4).ToList();
            float maxActual = ZEnumerable.Max(source);
            float maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxfloatList4Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (float) r.Next(int.MaxValue) } , 4).ToList();
            float maxActual = ZEnumerable.Max(source, arg => arg.X);
            float maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxfloatList100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (float) r.Next(int.MaxValue), 100).ToList();
            float maxActual = ZEnumerable.Max(source);
            float maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxfloatList100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (float) r.Next(int.MaxValue) } , 100).ToList();
            float maxActual = ZEnumerable.Max(source, arg => arg.X);
            float maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxfloatList2048()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (float) r.Next(int.MaxValue), 2048).ToList();
            float maxActual = ZEnumerable.Max(source);
            float maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxfloatList2048Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (float) r.Next(int.MaxValue) } , 2048).ToList();
            float maxActual = ZEnumerable.Max(source, arg => arg.X);
            float maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
            
        [TestMethod]
        public void TestMaxfloatIListNullOrEmpty()
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

            IList<float> emptySource = new float[0].ToIList();
            try
            {
                ZEnumerable.Max(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestMaxfloatIListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<float,float>((float) arg, (float) arg)).ToIList();
            Func<KeyValuePair<float, float>, float> nullMap = null;
            try
            {
                ZEnumerable.Max(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToIList();
            try
            {
                ZEnumerable.Max(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Max(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

                     
                
        [TestMethod]
        public void TestMaxfloatIList1()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (float) r.Next(int.MaxValue), 1).ToIList();
            float maxActual = ZEnumerable.Max(source);
            float maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxfloatIList1Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (float) r.Next(int.MaxValue) } , 1).ToIList();
            float maxActual = ZEnumerable.Max(source, arg => arg.X);
            float maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxfloatIList2()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (float) r.Next(int.MaxValue), 2).ToIList();
            float maxActual = ZEnumerable.Max(source);
            float maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxfloatIList2Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (float) r.Next(int.MaxValue) } , 2).ToIList();
            float maxActual = ZEnumerable.Max(source, arg => arg.X);
            float maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxfloatIList3()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (float) r.Next(int.MaxValue), 3).ToIList();
            float maxActual = ZEnumerable.Max(source);
            float maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxfloatIList3Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (float) r.Next(int.MaxValue) } , 3).ToIList();
            float maxActual = ZEnumerable.Max(source, arg => arg.X);
            float maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxfloatIList4()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (float) r.Next(int.MaxValue), 4).ToIList();
            float maxActual = ZEnumerable.Max(source);
            float maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxfloatIList4Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (float) r.Next(int.MaxValue) } , 4).ToIList();
            float maxActual = ZEnumerable.Max(source, arg => arg.X);
            float maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxfloatIList100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (float) r.Next(int.MaxValue), 100).ToIList();
            float maxActual = ZEnumerable.Max(source);
            float maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxfloatIList100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (float) r.Next(int.MaxValue) } , 100).ToIList();
            float maxActual = ZEnumerable.Max(source, arg => arg.X);
            float maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxfloatIList2048()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (float) r.Next(int.MaxValue), 2048).ToIList();
            float maxActual = ZEnumerable.Max(source);
            float maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxfloatIList2048Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (float) r.Next(int.MaxValue) } , 2048).ToIList();
            float maxActual = ZEnumerable.Max(source, arg => arg.X);
            float maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                        
               
        #endregion

      

        #region double 
             
            
        [TestMethod]
        public void TestMaxdoubleArrayNullOrEmpty()
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

            double[] emptySource = new double[0].ToArray();
            try
            {
                ZEnumerable.Max(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestMaxdoubleArrayMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<double,double>((double) arg, (double) arg)).ToArray();
            Func<KeyValuePair<double, double>, double> nullMap = null;
            try
            {
                ZEnumerable.Max(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToArray();
            try
            {
                ZEnumerable.Max(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Max(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

                     
                
        [TestMethod]
        public void TestMaxdoubleArray1()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (double) r.Next(int.MaxValue), 1).ToArray();
            double maxActual = ZEnumerable.Max(source);
            double maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdoubleArray1Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (double) r.Next(int.MaxValue) } , 1).ToArray();
            double maxActual = ZEnumerable.Max(source, arg => arg.X);
            double maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxdoubleArray2()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (double) r.Next(int.MaxValue), 2).ToArray();
            double maxActual = ZEnumerable.Max(source);
            double maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdoubleArray2Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (double) r.Next(int.MaxValue) } , 2).ToArray();
            double maxActual = ZEnumerable.Max(source, arg => arg.X);
            double maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxdoubleArray3()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (double) r.Next(int.MaxValue), 3).ToArray();
            double maxActual = ZEnumerable.Max(source);
            double maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdoubleArray3Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (double) r.Next(int.MaxValue) } , 3).ToArray();
            double maxActual = ZEnumerable.Max(source, arg => arg.X);
            double maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxdoubleArray4()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (double) r.Next(int.MaxValue), 4).ToArray();
            double maxActual = ZEnumerable.Max(source);
            double maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdoubleArray4Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (double) r.Next(int.MaxValue) } , 4).ToArray();
            double maxActual = ZEnumerable.Max(source, arg => arg.X);
            double maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxdoubleArray100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (double) r.Next(int.MaxValue), 100).ToArray();
            double maxActual = ZEnumerable.Max(source);
            double maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdoubleArray100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (double) r.Next(int.MaxValue) } , 100).ToArray();
            double maxActual = ZEnumerable.Max(source, arg => arg.X);
            double maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxdoubleArray2048()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (double) r.Next(int.MaxValue), 2048).ToArray();
            double maxActual = ZEnumerable.Max(source);
            double maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdoubleArray2048Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (double) r.Next(int.MaxValue) } , 2048).ToArray();
            double maxActual = ZEnumerable.Max(source, arg => arg.X);
            double maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
            
        [TestMethod]
        public void TestMaxdoubleListNullOrEmpty()
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

            List<double> emptySource = new double[0].ToList();
            try
            {
                ZEnumerable.Max(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestMaxdoubleListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<double,double>((double) arg, (double) arg)).ToList();
            Func<KeyValuePair<double, double>, double> nullMap = null;
            try
            {
                ZEnumerable.Max(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToList();
            try
            {
                ZEnumerable.Max(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Max(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

                     
                
        [TestMethod]
        public void TestMaxdoubleList1()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (double) r.Next(int.MaxValue), 1).ToList();
            double maxActual = ZEnumerable.Max(source);
            double maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdoubleList1Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (double) r.Next(int.MaxValue) } , 1).ToList();
            double maxActual = ZEnumerable.Max(source, arg => arg.X);
            double maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxdoubleList2()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (double) r.Next(int.MaxValue), 2).ToList();
            double maxActual = ZEnumerable.Max(source);
            double maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdoubleList2Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (double) r.Next(int.MaxValue) } , 2).ToList();
            double maxActual = ZEnumerable.Max(source, arg => arg.X);
            double maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxdoubleList3()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (double) r.Next(int.MaxValue), 3).ToList();
            double maxActual = ZEnumerable.Max(source);
            double maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdoubleList3Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (double) r.Next(int.MaxValue) } , 3).ToList();
            double maxActual = ZEnumerable.Max(source, arg => arg.X);
            double maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxdoubleList4()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (double) r.Next(int.MaxValue), 4).ToList();
            double maxActual = ZEnumerable.Max(source);
            double maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdoubleList4Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (double) r.Next(int.MaxValue) } , 4).ToList();
            double maxActual = ZEnumerable.Max(source, arg => arg.X);
            double maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxdoubleList100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (double) r.Next(int.MaxValue), 100).ToList();
            double maxActual = ZEnumerable.Max(source);
            double maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdoubleList100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (double) r.Next(int.MaxValue) } , 100).ToList();
            double maxActual = ZEnumerable.Max(source, arg => arg.X);
            double maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxdoubleList2048()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (double) r.Next(int.MaxValue), 2048).ToList();
            double maxActual = ZEnumerable.Max(source);
            double maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdoubleList2048Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (double) r.Next(int.MaxValue) } , 2048).ToList();
            double maxActual = ZEnumerable.Max(source, arg => arg.X);
            double maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
            
        [TestMethod]
        public void TestMaxdoubleIListNullOrEmpty()
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

            IList<double> emptySource = new double[0].ToIList();
            try
            {
                ZEnumerable.Max(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestMaxdoubleIListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<double,double>((double) arg, (double) arg)).ToIList();
            Func<KeyValuePair<double, double>, double> nullMap = null;
            try
            {
                ZEnumerable.Max(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToIList();
            try
            {
                ZEnumerable.Max(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Max(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

                     
                
        [TestMethod]
        public void TestMaxdoubleIList1()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (double) r.Next(int.MaxValue), 1).ToIList();
            double maxActual = ZEnumerable.Max(source);
            double maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdoubleIList1Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (double) r.Next(int.MaxValue) } , 1).ToIList();
            double maxActual = ZEnumerable.Max(source, arg => arg.X);
            double maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxdoubleIList2()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (double) r.Next(int.MaxValue), 2).ToIList();
            double maxActual = ZEnumerable.Max(source);
            double maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdoubleIList2Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (double) r.Next(int.MaxValue) } , 2).ToIList();
            double maxActual = ZEnumerable.Max(source, arg => arg.X);
            double maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxdoubleIList3()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (double) r.Next(int.MaxValue), 3).ToIList();
            double maxActual = ZEnumerable.Max(source);
            double maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdoubleIList3Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (double) r.Next(int.MaxValue) } , 3).ToIList();
            double maxActual = ZEnumerable.Max(source, arg => arg.X);
            double maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxdoubleIList4()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (double) r.Next(int.MaxValue), 4).ToIList();
            double maxActual = ZEnumerable.Max(source);
            double maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdoubleIList4Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (double) r.Next(int.MaxValue) } , 4).ToIList();
            double maxActual = ZEnumerable.Max(source, arg => arg.X);
            double maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxdoubleIList100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (double) r.Next(int.MaxValue), 100).ToIList();
            double maxActual = ZEnumerable.Max(source);
            double maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdoubleIList100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (double) r.Next(int.MaxValue) } , 100).ToIList();
            double maxActual = ZEnumerable.Max(source, arg => arg.X);
            double maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxdoubleIList2048()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (double) r.Next(int.MaxValue), 2048).ToIList();
            double maxActual = ZEnumerable.Max(source);
            double maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdoubleIList2048Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (double) r.Next(int.MaxValue) } , 2048).ToIList();
            double maxActual = ZEnumerable.Max(source, arg => arg.X);
            double maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                        
               
        #endregion

      

        #region decimal 
             
            
        [TestMethod]
        public void TestMaxdecimalArrayNullOrEmpty()
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

            decimal[] emptySource = new decimal[0].ToArray();
            try
            {
                ZEnumerable.Max(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestMaxdecimalArrayMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<decimal,decimal>((decimal) arg, (decimal) arg)).ToArray();
            Func<KeyValuePair<decimal, decimal>, decimal> nullMap = null;
            try
            {
                ZEnumerable.Max(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToArray();
            try
            {
                ZEnumerable.Max(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Max(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

                     
                
        [TestMethod]
        public void TestMaxdecimalArray1()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (decimal) r.Next(int.MaxValue), 1).ToArray();
            decimal maxActual = ZEnumerable.Max(source);
            decimal maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdecimalArray1Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (decimal) r.Next(int.MaxValue) } , 1).ToArray();
            decimal maxActual = ZEnumerable.Max(source, arg => arg.X);
            decimal maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxdecimalArray2()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (decimal) r.Next(int.MaxValue), 2).ToArray();
            decimal maxActual = ZEnumerable.Max(source);
            decimal maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdecimalArray2Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (decimal) r.Next(int.MaxValue) } , 2).ToArray();
            decimal maxActual = ZEnumerable.Max(source, arg => arg.X);
            decimal maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxdecimalArray3()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (decimal) r.Next(int.MaxValue), 3).ToArray();
            decimal maxActual = ZEnumerable.Max(source);
            decimal maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdecimalArray3Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (decimal) r.Next(int.MaxValue) } , 3).ToArray();
            decimal maxActual = ZEnumerable.Max(source, arg => arg.X);
            decimal maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxdecimalArray4()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (decimal) r.Next(int.MaxValue), 4).ToArray();
            decimal maxActual = ZEnumerable.Max(source);
            decimal maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdecimalArray4Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (decimal) r.Next(int.MaxValue) } , 4).ToArray();
            decimal maxActual = ZEnumerable.Max(source, arg => arg.X);
            decimal maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxdecimalArray100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (decimal) r.Next(int.MaxValue), 100).ToArray();
            decimal maxActual = ZEnumerable.Max(source);
            decimal maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdecimalArray100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (decimal) r.Next(int.MaxValue) } , 100).ToArray();
            decimal maxActual = ZEnumerable.Max(source, arg => arg.X);
            decimal maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxdecimalArray2048()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (decimal) r.Next(int.MaxValue), 2048).ToArray();
            decimal maxActual = ZEnumerable.Max(source);
            decimal maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdecimalArray2048Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (decimal) r.Next(int.MaxValue) } , 2048).ToArray();
            decimal maxActual = ZEnumerable.Max(source, arg => arg.X);
            decimal maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
            
        [TestMethod]
        public void TestMaxdecimalListNullOrEmpty()
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

            List<decimal> emptySource = new decimal[0].ToList();
            try
            {
                ZEnumerable.Max(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestMaxdecimalListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<decimal,decimal>((decimal) arg, (decimal) arg)).ToList();
            Func<KeyValuePair<decimal, decimal>, decimal> nullMap = null;
            try
            {
                ZEnumerable.Max(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToList();
            try
            {
                ZEnumerable.Max(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Max(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

                     
                
        [TestMethod]
        public void TestMaxdecimalList1()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (decimal) r.Next(int.MaxValue), 1).ToList();
            decimal maxActual = ZEnumerable.Max(source);
            decimal maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdecimalList1Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (decimal) r.Next(int.MaxValue) } , 1).ToList();
            decimal maxActual = ZEnumerable.Max(source, arg => arg.X);
            decimal maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxdecimalList2()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (decimal) r.Next(int.MaxValue), 2).ToList();
            decimal maxActual = ZEnumerable.Max(source);
            decimal maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdecimalList2Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (decimal) r.Next(int.MaxValue) } , 2).ToList();
            decimal maxActual = ZEnumerable.Max(source, arg => arg.X);
            decimal maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxdecimalList3()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (decimal) r.Next(int.MaxValue), 3).ToList();
            decimal maxActual = ZEnumerable.Max(source);
            decimal maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdecimalList3Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (decimal) r.Next(int.MaxValue) } , 3).ToList();
            decimal maxActual = ZEnumerable.Max(source, arg => arg.X);
            decimal maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxdecimalList4()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (decimal) r.Next(int.MaxValue), 4).ToList();
            decimal maxActual = ZEnumerable.Max(source);
            decimal maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdecimalList4Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (decimal) r.Next(int.MaxValue) } , 4).ToList();
            decimal maxActual = ZEnumerable.Max(source, arg => arg.X);
            decimal maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxdecimalList100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (decimal) r.Next(int.MaxValue), 100).ToList();
            decimal maxActual = ZEnumerable.Max(source);
            decimal maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdecimalList100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (decimal) r.Next(int.MaxValue) } , 100).ToList();
            decimal maxActual = ZEnumerable.Max(source, arg => arg.X);
            decimal maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxdecimalList2048()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (decimal) r.Next(int.MaxValue), 2048).ToList();
            decimal maxActual = ZEnumerable.Max(source);
            decimal maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdecimalList2048Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (decimal) r.Next(int.MaxValue) } , 2048).ToList();
            decimal maxActual = ZEnumerable.Max(source, arg => arg.X);
            decimal maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
            
        [TestMethod]
        public void TestMaxdecimalIListNullOrEmpty()
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

            IList<decimal> emptySource = new decimal[0].ToIList();
            try
            {
                ZEnumerable.Max(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestMaxdecimalIListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<decimal,decimal>((decimal) arg, (decimal) arg)).ToIList();
            Func<KeyValuePair<decimal, decimal>, decimal> nullMap = null;
            try
            {
                ZEnumerable.Max(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToIList();
            try
            {
                ZEnumerable.Max(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Max(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

                     
                
        [TestMethod]
        public void TestMaxdecimalIList1()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (decimal) r.Next(int.MaxValue), 1).ToIList();
            decimal maxActual = ZEnumerable.Max(source);
            decimal maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdecimalIList1Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (decimal) r.Next(int.MaxValue) } , 1).ToIList();
            decimal maxActual = ZEnumerable.Max(source, arg => arg.X);
            decimal maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxdecimalIList2()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (decimal) r.Next(int.MaxValue), 2).ToIList();
            decimal maxActual = ZEnumerable.Max(source);
            decimal maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdecimalIList2Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (decimal) r.Next(int.MaxValue) } , 2).ToIList();
            decimal maxActual = ZEnumerable.Max(source, arg => arg.X);
            decimal maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxdecimalIList3()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (decimal) r.Next(int.MaxValue), 3).ToIList();
            decimal maxActual = ZEnumerable.Max(source);
            decimal maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdecimalIList3Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (decimal) r.Next(int.MaxValue) } , 3).ToIList();
            decimal maxActual = ZEnumerable.Max(source, arg => arg.X);
            decimal maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxdecimalIList4()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (decimal) r.Next(int.MaxValue), 4).ToIList();
            decimal maxActual = ZEnumerable.Max(source);
            decimal maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdecimalIList4Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (decimal) r.Next(int.MaxValue) } , 4).ToIList();
            decimal maxActual = ZEnumerable.Max(source, arg => arg.X);
            decimal maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxdecimalIList100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (decimal) r.Next(int.MaxValue), 100).ToIList();
            decimal maxActual = ZEnumerable.Max(source);
            decimal maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdecimalIList100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (decimal) r.Next(int.MaxValue) } , 100).ToIList();
            decimal maxActual = ZEnumerable.Max(source, arg => arg.X);
            decimal maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                         
                
        [TestMethod]
        public void TestMaxdecimalIList2048()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (decimal) r.Next(int.MaxValue), 2048).ToIList();
            decimal maxActual = ZEnumerable.Max(source);
            decimal maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdecimalIList2048Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (decimal) r.Next(int.MaxValue) } , 2048).ToIList();
            decimal maxActual = ZEnumerable.Max(source, arg => arg.X);
            decimal maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
                
                        
               
        #endregion

      

        #region sbyte? 
             
            
        [TestMethod]
        public void TestMaxsbyteNullableArrayNullOrEmpty()
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

            sbyte?[] emptySource = new sbyte?[0].ToArray();
            try
            {
                ZEnumerable.Max(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestMaxsbyteNullableArrayMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<sbyte?,sbyte?>((sbyte?) arg, (sbyte?) arg)).ToArray();
            Func<KeyValuePair<sbyte?, sbyte?>, sbyte?> nullMap = null;
            try
            {
                ZEnumerable.Max(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToArray();
            try
            {
                ZEnumerable.Max(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Max(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

                     
                
        [TestMethod]
        public void TestMaxsbyteNullableArray1()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (sbyte?) r.Next(sbyte.MaxValue), 1).ToArray();
            sbyte? maxActual = ZEnumerable.Max(source);
            sbyte? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxsbyteNullableArray1Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (sbyte?) r.Next(sbyte.MaxValue) } , 1).ToArray();
            sbyte? maxActual = ZEnumerable.Max(source, arg => arg.X);
            sbyte? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxsbyteNullableArray1ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (sbyte?) r.Next(sbyte.MaxValue), 1).Select(x=>x%2==0 ? x : null).ToArray();
            sbyte? maxActual = ZEnumerable.Max(source);
            sbyte? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxsbyteNullableArray1ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (sbyte?) r.Next(sbyte.MaxValue), 1).Select(x=>x%2==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X =  x } ).ToArray();
            sbyte? maxActual = ZEnumerable.Max(source, arg => arg.X);
            sbyte? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxsbyteNullableArray2()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (sbyte?) r.Next(sbyte.MaxValue), 2).ToArray();
            sbyte? maxActual = ZEnumerable.Max(source);
            sbyte? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxsbyteNullableArray2Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (sbyte?) r.Next(sbyte.MaxValue) } , 2).ToArray();
            sbyte? maxActual = ZEnumerable.Max(source, arg => arg.X);
            sbyte? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxsbyteNullableArray2ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (sbyte?) r.Next(sbyte.MaxValue), 2).Select(x=>x%2==0 ? x : null).ToArray();
            sbyte? maxActual = ZEnumerable.Max(source);
            sbyte? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxsbyteNullableArray2ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (sbyte?) r.Next(sbyte.MaxValue), 2).Select(x=>x%2==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X =  x } ).ToArray();
            sbyte? maxActual = ZEnumerable.Max(source, arg => arg.X);
            sbyte? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxsbyteNullableArray3()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (sbyte?) r.Next(sbyte.MaxValue), 3).ToArray();
            sbyte? maxActual = ZEnumerable.Max(source);
            sbyte? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxsbyteNullableArray3Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (sbyte?) r.Next(sbyte.MaxValue) } , 3).ToArray();
            sbyte? maxActual = ZEnumerable.Max(source, arg => arg.X);
            sbyte? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxsbyteNullableArray3ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (sbyte?) r.Next(sbyte.MaxValue), 3).Select(x=>x%2==0 ? x : null).ToArray();
            sbyte? maxActual = ZEnumerable.Max(source);
            sbyte? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxsbyteNullableArray3ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (sbyte?) r.Next(sbyte.MaxValue), 3).Select(x=>x%2==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X =  x } ).ToArray();
            sbyte? maxActual = ZEnumerable.Max(source, arg => arg.X);
            sbyte? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxsbyteNullableArray4()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (sbyte?) r.Next(sbyte.MaxValue), 4).ToArray();
            sbyte? maxActual = ZEnumerable.Max(source);
            sbyte? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxsbyteNullableArray4Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (sbyte?) r.Next(sbyte.MaxValue) } , 4).ToArray();
            sbyte? maxActual = ZEnumerable.Max(source, arg => arg.X);
            sbyte? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxsbyteNullableArray4ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (sbyte?) r.Next(sbyte.MaxValue), 4).Select(x=>x%2==0 ? x : null).ToArray();
            sbyte? maxActual = ZEnumerable.Max(source);
            sbyte? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxsbyteNullableArray4ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (sbyte?) r.Next(sbyte.MaxValue), 4).Select(x=>x%2==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X =  x } ).ToArray();
            sbyte? maxActual = ZEnumerable.Max(source, arg => arg.X);
            sbyte? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxsbyteNullableArray100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (sbyte?) r.Next(sbyte.MaxValue), 100).ToArray();
            sbyte? maxActual = ZEnumerable.Max(source);
            sbyte? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxsbyteNullableArray100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (sbyte?) r.Next(sbyte.MaxValue) } , 100).ToArray();
            sbyte? maxActual = ZEnumerable.Max(source, arg => arg.X);
            sbyte? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxsbyteNullableArray100ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (sbyte?) r.Next(sbyte.MaxValue), 100).Select(x=>x%2==0 ? x : null).ToArray();
            sbyte? maxActual = ZEnumerable.Max(source);
            sbyte? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxsbyteNullableArray100ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (sbyte?) r.Next(sbyte.MaxValue), 100).Select(x=>x%2==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X =  x } ).ToArray();
            sbyte? maxActual = ZEnumerable.Max(source, arg => arg.X);
            sbyte? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxsbyteNullableArray2048()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (sbyte?) r.Next(sbyte.MaxValue), 2048).ToArray();
            sbyte? maxActual = ZEnumerable.Max(source);
            sbyte? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxsbyteNullableArray2048Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (sbyte?) r.Next(sbyte.MaxValue) } , 2048).ToArray();
            sbyte? maxActual = ZEnumerable.Max(source, arg => arg.X);
            sbyte? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxsbyteNullableArray2048ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (sbyte?) r.Next(sbyte.MaxValue), 2048).Select(x=>x%2==0 ? x : null).ToArray();
            sbyte? maxActual = ZEnumerable.Max(source);
            sbyte? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxsbyteNullableArray2048ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (sbyte?) r.Next(sbyte.MaxValue), 2048).Select(x=>x%2==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X =  x } ).ToArray();
            sbyte? maxActual = ZEnumerable.Max(source, arg => arg.X);
            sbyte? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
            
        [TestMethod]
        public void TestMaxsbyteNullableListNullOrEmpty()
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

            List<sbyte?> emptySource = new sbyte?[0].ToList();
            try
            {
                ZEnumerable.Max(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestMaxsbyteNullableListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<sbyte?,sbyte?>((sbyte?) arg, (sbyte?) arg)).ToList();
            Func<KeyValuePair<sbyte?, sbyte?>, sbyte?> nullMap = null;
            try
            {
                ZEnumerable.Max(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToList();
            try
            {
                ZEnumerable.Max(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Max(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

                     
                
        [TestMethod]
        public void TestMaxsbyteNullableList1()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (sbyte?) r.Next(sbyte.MaxValue), 1).ToList();
            sbyte? maxActual = ZEnumerable.Max(source);
            sbyte? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxsbyteNullableList1Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (sbyte?) r.Next(sbyte.MaxValue) } , 1).ToList();
            sbyte? maxActual = ZEnumerable.Max(source, arg => arg.X);
            sbyte? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxsbyteNullableList1ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (sbyte?) r.Next(sbyte.MaxValue), 1).Select(x=>x%2==0 ? x : null).ToList();
            sbyte? maxActual = ZEnumerable.Max(source);
            sbyte? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxsbyteNullableList1ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (sbyte?) r.Next(sbyte.MaxValue), 1).Select(x=>x%2==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X =  x } ).ToList();
            sbyte? maxActual = ZEnumerable.Max(source, arg => arg.X);
            sbyte? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxsbyteNullableList2()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (sbyte?) r.Next(sbyte.MaxValue), 2).ToList();
            sbyte? maxActual = ZEnumerable.Max(source);
            sbyte? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxsbyteNullableList2Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (sbyte?) r.Next(sbyte.MaxValue) } , 2).ToList();
            sbyte? maxActual = ZEnumerable.Max(source, arg => arg.X);
            sbyte? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxsbyteNullableList2ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (sbyte?) r.Next(sbyte.MaxValue), 2).Select(x=>x%2==0 ? x : null).ToList();
            sbyte? maxActual = ZEnumerable.Max(source);
            sbyte? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxsbyteNullableList2ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (sbyte?) r.Next(sbyte.MaxValue), 2).Select(x=>x%2==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X =  x } ).ToList();
            sbyte? maxActual = ZEnumerable.Max(source, arg => arg.X);
            sbyte? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxsbyteNullableList3()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (sbyte?) r.Next(sbyte.MaxValue), 3).ToList();
            sbyte? maxActual = ZEnumerable.Max(source);
            sbyte? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxsbyteNullableList3Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (sbyte?) r.Next(sbyte.MaxValue) } , 3).ToList();
            sbyte? maxActual = ZEnumerable.Max(source, arg => arg.X);
            sbyte? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxsbyteNullableList3ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (sbyte?) r.Next(sbyte.MaxValue), 3).Select(x=>x%2==0 ? x : null).ToList();
            sbyte? maxActual = ZEnumerable.Max(source);
            sbyte? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxsbyteNullableList3ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (sbyte?) r.Next(sbyte.MaxValue), 3).Select(x=>x%2==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X =  x } ).ToList();
            sbyte? maxActual = ZEnumerable.Max(source, arg => arg.X);
            sbyte? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxsbyteNullableList4()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (sbyte?) r.Next(sbyte.MaxValue), 4).ToList();
            sbyte? maxActual = ZEnumerable.Max(source);
            sbyte? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxsbyteNullableList4Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (sbyte?) r.Next(sbyte.MaxValue) } , 4).ToList();
            sbyte? maxActual = ZEnumerable.Max(source, arg => arg.X);
            sbyte? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxsbyteNullableList4ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (sbyte?) r.Next(sbyte.MaxValue), 4).Select(x=>x%2==0 ? x : null).ToList();
            sbyte? maxActual = ZEnumerable.Max(source);
            sbyte? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxsbyteNullableList4ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (sbyte?) r.Next(sbyte.MaxValue), 4).Select(x=>x%2==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X =  x } ).ToList();
            sbyte? maxActual = ZEnumerable.Max(source, arg => arg.X);
            sbyte? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxsbyteNullableList100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (sbyte?) r.Next(sbyte.MaxValue), 100).ToList();
            sbyte? maxActual = ZEnumerable.Max(source);
            sbyte? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxsbyteNullableList100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (sbyte?) r.Next(sbyte.MaxValue) } , 100).ToList();
            sbyte? maxActual = ZEnumerable.Max(source, arg => arg.X);
            sbyte? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxsbyteNullableList100ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (sbyte?) r.Next(sbyte.MaxValue), 100).Select(x=>x%2==0 ? x : null).ToList();
            sbyte? maxActual = ZEnumerable.Max(source);
            sbyte? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxsbyteNullableList100ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (sbyte?) r.Next(sbyte.MaxValue), 100).Select(x=>x%2==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X =  x } ).ToList();
            sbyte? maxActual = ZEnumerable.Max(source, arg => arg.X);
            sbyte? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxsbyteNullableList2048()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (sbyte?) r.Next(sbyte.MaxValue), 2048).ToList();
            sbyte? maxActual = ZEnumerable.Max(source);
            sbyte? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxsbyteNullableList2048Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (sbyte?) r.Next(sbyte.MaxValue) } , 2048).ToList();
            sbyte? maxActual = ZEnumerable.Max(source, arg => arg.X);
            sbyte? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxsbyteNullableList2048ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (sbyte?) r.Next(sbyte.MaxValue), 2048).Select(x=>x%2==0 ? x : null).ToList();
            sbyte? maxActual = ZEnumerable.Max(source);
            sbyte? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxsbyteNullableList2048ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (sbyte?) r.Next(sbyte.MaxValue), 2048).Select(x=>x%2==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X =  x } ).ToList();
            sbyte? maxActual = ZEnumerable.Max(source, arg => arg.X);
            sbyte? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
            
        [TestMethod]
        public void TestMaxsbyteNullableIListNullOrEmpty()
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

            IList<sbyte?> emptySource = new sbyte?[0].ToIList();
            try
            {
                ZEnumerable.Max(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestMaxsbyteNullableIListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<sbyte?,sbyte?>((sbyte?) arg, (sbyte?) arg)).ToIList();
            Func<KeyValuePair<sbyte?, sbyte?>, sbyte?> nullMap = null;
            try
            {
                ZEnumerable.Max(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToIList();
            try
            {
                ZEnumerable.Max(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Max(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

                     
                
        [TestMethod]
        public void TestMaxsbyteNullableIList1()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (sbyte?) r.Next(sbyte.MaxValue), 1).ToIList();
            sbyte? maxActual = ZEnumerable.Max(source);
            sbyte? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxsbyteNullableIList1Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (sbyte?) r.Next(sbyte.MaxValue) } , 1).ToIList();
            sbyte? maxActual = ZEnumerable.Max(source, arg => arg.X);
            sbyte? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxsbyteNullableIList1ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (sbyte?) r.Next(sbyte.MaxValue), 1).Select(x=>x%2==0 ? x : null).ToIList();
            sbyte? maxActual = ZEnumerable.Max(source);
            sbyte? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxsbyteNullableIList1ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (sbyte?) r.Next(sbyte.MaxValue), 1).Select(x=>x%2==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X =  x } ).ToIList();
            sbyte? maxActual = ZEnumerable.Max(source, arg => arg.X);
            sbyte? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxsbyteNullableIList2()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (sbyte?) r.Next(sbyte.MaxValue), 2).ToIList();
            sbyte? maxActual = ZEnumerable.Max(source);
            sbyte? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxsbyteNullableIList2Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (sbyte?) r.Next(sbyte.MaxValue) } , 2).ToIList();
            sbyte? maxActual = ZEnumerable.Max(source, arg => arg.X);
            sbyte? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxsbyteNullableIList2ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (sbyte?) r.Next(sbyte.MaxValue), 2).Select(x=>x%2==0 ? x : null).ToIList();
            sbyte? maxActual = ZEnumerable.Max(source);
            sbyte? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxsbyteNullableIList2ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (sbyte?) r.Next(sbyte.MaxValue), 2).Select(x=>x%2==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X =  x } ).ToIList();
            sbyte? maxActual = ZEnumerable.Max(source, arg => arg.X);
            sbyte? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxsbyteNullableIList3()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (sbyte?) r.Next(sbyte.MaxValue), 3).ToIList();
            sbyte? maxActual = ZEnumerable.Max(source);
            sbyte? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxsbyteNullableIList3Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (sbyte?) r.Next(sbyte.MaxValue) } , 3).ToIList();
            sbyte? maxActual = ZEnumerable.Max(source, arg => arg.X);
            sbyte? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxsbyteNullableIList3ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (sbyte?) r.Next(sbyte.MaxValue), 3).Select(x=>x%2==0 ? x : null).ToIList();
            sbyte? maxActual = ZEnumerable.Max(source);
            sbyte? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxsbyteNullableIList3ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (sbyte?) r.Next(sbyte.MaxValue), 3).Select(x=>x%2==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X =  x } ).ToIList();
            sbyte? maxActual = ZEnumerable.Max(source, arg => arg.X);
            sbyte? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxsbyteNullableIList4()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (sbyte?) r.Next(sbyte.MaxValue), 4).ToIList();
            sbyte? maxActual = ZEnumerable.Max(source);
            sbyte? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxsbyteNullableIList4Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (sbyte?) r.Next(sbyte.MaxValue) } , 4).ToIList();
            sbyte? maxActual = ZEnumerable.Max(source, arg => arg.X);
            sbyte? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxsbyteNullableIList4ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (sbyte?) r.Next(sbyte.MaxValue), 4).Select(x=>x%2==0 ? x : null).ToIList();
            sbyte? maxActual = ZEnumerable.Max(source);
            sbyte? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxsbyteNullableIList4ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (sbyte?) r.Next(sbyte.MaxValue), 4).Select(x=>x%2==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X =  x } ).ToIList();
            sbyte? maxActual = ZEnumerable.Max(source, arg => arg.X);
            sbyte? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxsbyteNullableIList100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (sbyte?) r.Next(sbyte.MaxValue), 100).ToIList();
            sbyte? maxActual = ZEnumerable.Max(source);
            sbyte? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxsbyteNullableIList100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (sbyte?) r.Next(sbyte.MaxValue) } , 100).ToIList();
            sbyte? maxActual = ZEnumerable.Max(source, arg => arg.X);
            sbyte? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxsbyteNullableIList100ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (sbyte?) r.Next(sbyte.MaxValue), 100).Select(x=>x%2==0 ? x : null).ToIList();
            sbyte? maxActual = ZEnumerable.Max(source);
            sbyte? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxsbyteNullableIList100ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (sbyte?) r.Next(sbyte.MaxValue), 100).Select(x=>x%2==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X =  x } ).ToIList();
            sbyte? maxActual = ZEnumerable.Max(source, arg => arg.X);
            sbyte? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxsbyteNullableIList2048()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (sbyte?) r.Next(sbyte.MaxValue), 2048).ToIList();
            sbyte? maxActual = ZEnumerable.Max(source);
            sbyte? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxsbyteNullableIList2048Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (sbyte?) r.Next(sbyte.MaxValue) } , 2048).ToIList();
            sbyte? maxActual = ZEnumerable.Max(source, arg => arg.X);
            sbyte? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxsbyteNullableIList2048ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (sbyte?) r.Next(sbyte.MaxValue), 2048).Select(x=>x%2==0 ? x : null).ToIList();
            sbyte? maxActual = ZEnumerable.Max(source);
            sbyte? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxsbyteNullableIList2048ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (sbyte?) r.Next(sbyte.MaxValue), 2048).Select(x=>x%2==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X =  x } ).ToIList();
            sbyte? maxActual = ZEnumerable.Max(source, arg => arg.X);
            sbyte? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                        
               
        #endregion

      

        #region byte? 
             
            
        [TestMethod]
        public void TestMaxbyteNullableArrayNullOrEmpty()
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

            byte?[] emptySource = new byte?[0].ToArray();
            try
            {
                ZEnumerable.Max(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestMaxbyteNullableArrayMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<byte?,byte?>((byte?) arg, (byte?) arg)).ToArray();
            Func<KeyValuePair<byte?, byte?>, byte?> nullMap = null;
            try
            {
                ZEnumerable.Max(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToArray();
            try
            {
                ZEnumerable.Max(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Max(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

                     
                
        [TestMethod]
        public void TestMaxbyteNullableArray1()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (byte?) r.Next(byte.MaxValue), 1).ToArray();
            byte? maxActual = ZEnumerable.Max(source);
            byte? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxbyteNullableArray1Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (byte?) r.Next(byte.MaxValue) } , 1).ToArray();
            byte? maxActual = ZEnumerable.Max(source, arg => arg.X);
            byte? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxbyteNullableArray1ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (byte?) r.Next(byte.MaxValue), 1).Select(x=>x%2==0 ? x : null).ToArray();
            byte? maxActual = ZEnumerable.Max(source);
            byte? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxbyteNullableArray1ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (byte?) r.Next(byte.MaxValue), 1).Select(x=>x%2==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X =  x } ).ToArray();
            byte? maxActual = ZEnumerable.Max(source, arg => arg.X);
            byte? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxbyteNullableArray2()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (byte?) r.Next(byte.MaxValue), 2).ToArray();
            byte? maxActual = ZEnumerable.Max(source);
            byte? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxbyteNullableArray2Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (byte?) r.Next(byte.MaxValue) } , 2).ToArray();
            byte? maxActual = ZEnumerable.Max(source, arg => arg.X);
            byte? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxbyteNullableArray2ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (byte?) r.Next(byte.MaxValue), 2).Select(x=>x%2==0 ? x : null).ToArray();
            byte? maxActual = ZEnumerable.Max(source);
            byte? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxbyteNullableArray2ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (byte?) r.Next(byte.MaxValue), 2).Select(x=>x%2==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X =  x } ).ToArray();
            byte? maxActual = ZEnumerable.Max(source, arg => arg.X);
            byte? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxbyteNullableArray3()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (byte?) r.Next(byte.MaxValue), 3).ToArray();
            byte? maxActual = ZEnumerable.Max(source);
            byte? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxbyteNullableArray3Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (byte?) r.Next(byte.MaxValue) } , 3).ToArray();
            byte? maxActual = ZEnumerable.Max(source, arg => arg.X);
            byte? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxbyteNullableArray3ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (byte?) r.Next(byte.MaxValue), 3).Select(x=>x%2==0 ? x : null).ToArray();
            byte? maxActual = ZEnumerable.Max(source);
            byte? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxbyteNullableArray3ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (byte?) r.Next(byte.MaxValue), 3).Select(x=>x%2==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X =  x } ).ToArray();
            byte? maxActual = ZEnumerable.Max(source, arg => arg.X);
            byte? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxbyteNullableArray4()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (byte?) r.Next(byte.MaxValue), 4).ToArray();
            byte? maxActual = ZEnumerable.Max(source);
            byte? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxbyteNullableArray4Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (byte?) r.Next(byte.MaxValue) } , 4).ToArray();
            byte? maxActual = ZEnumerable.Max(source, arg => arg.X);
            byte? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxbyteNullableArray4ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (byte?) r.Next(byte.MaxValue), 4).Select(x=>x%2==0 ? x : null).ToArray();
            byte? maxActual = ZEnumerable.Max(source);
            byte? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxbyteNullableArray4ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (byte?) r.Next(byte.MaxValue), 4).Select(x=>x%2==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X =  x } ).ToArray();
            byte? maxActual = ZEnumerable.Max(source, arg => arg.X);
            byte? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxbyteNullableArray100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (byte?) r.Next(byte.MaxValue), 100).ToArray();
            byte? maxActual = ZEnumerable.Max(source);
            byte? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxbyteNullableArray100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (byte?) r.Next(byte.MaxValue) } , 100).ToArray();
            byte? maxActual = ZEnumerable.Max(source, arg => arg.X);
            byte? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxbyteNullableArray100ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (byte?) r.Next(byte.MaxValue), 100).Select(x=>x%2==0 ? x : null).ToArray();
            byte? maxActual = ZEnumerable.Max(source);
            byte? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxbyteNullableArray100ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (byte?) r.Next(byte.MaxValue), 100).Select(x=>x%2==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X =  x } ).ToArray();
            byte? maxActual = ZEnumerable.Max(source, arg => arg.X);
            byte? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxbyteNullableArray2048()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (byte?) r.Next(byte.MaxValue), 2048).ToArray();
            byte? maxActual = ZEnumerable.Max(source);
            byte? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxbyteNullableArray2048Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (byte?) r.Next(byte.MaxValue) } , 2048).ToArray();
            byte? maxActual = ZEnumerable.Max(source, arg => arg.X);
            byte? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxbyteNullableArray2048ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (byte?) r.Next(byte.MaxValue), 2048).Select(x=>x%2==0 ? x : null).ToArray();
            byte? maxActual = ZEnumerable.Max(source);
            byte? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxbyteNullableArray2048ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (byte?) r.Next(byte.MaxValue), 2048).Select(x=>x%2==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X =  x } ).ToArray();
            byte? maxActual = ZEnumerable.Max(source, arg => arg.X);
            byte? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
            
        [TestMethod]
        public void TestMaxbyteNullableListNullOrEmpty()
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

            List<byte?> emptySource = new byte?[0].ToList();
            try
            {
                ZEnumerable.Max(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestMaxbyteNullableListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<byte?,byte?>((byte?) arg, (byte?) arg)).ToList();
            Func<KeyValuePair<byte?, byte?>, byte?> nullMap = null;
            try
            {
                ZEnumerable.Max(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToList();
            try
            {
                ZEnumerable.Max(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Max(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

                     
                
        [TestMethod]
        public void TestMaxbyteNullableList1()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (byte?) r.Next(byte.MaxValue), 1).ToList();
            byte? maxActual = ZEnumerable.Max(source);
            byte? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxbyteNullableList1Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (byte?) r.Next(byte.MaxValue) } , 1).ToList();
            byte? maxActual = ZEnumerable.Max(source, arg => arg.X);
            byte? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxbyteNullableList1ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (byte?) r.Next(byte.MaxValue), 1).Select(x=>x%2==0 ? x : null).ToList();
            byte? maxActual = ZEnumerable.Max(source);
            byte? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxbyteNullableList1ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (byte?) r.Next(byte.MaxValue), 1).Select(x=>x%2==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X =  x } ).ToList();
            byte? maxActual = ZEnumerable.Max(source, arg => arg.X);
            byte? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxbyteNullableList2()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (byte?) r.Next(byte.MaxValue), 2).ToList();
            byte? maxActual = ZEnumerable.Max(source);
            byte? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxbyteNullableList2Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (byte?) r.Next(byte.MaxValue) } , 2).ToList();
            byte? maxActual = ZEnumerable.Max(source, arg => arg.X);
            byte? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxbyteNullableList2ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (byte?) r.Next(byte.MaxValue), 2).Select(x=>x%2==0 ? x : null).ToList();
            byte? maxActual = ZEnumerable.Max(source);
            byte? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxbyteNullableList2ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (byte?) r.Next(byte.MaxValue), 2).Select(x=>x%2==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X =  x } ).ToList();
            byte? maxActual = ZEnumerable.Max(source, arg => arg.X);
            byte? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxbyteNullableList3()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (byte?) r.Next(byte.MaxValue), 3).ToList();
            byte? maxActual = ZEnumerable.Max(source);
            byte? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxbyteNullableList3Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (byte?) r.Next(byte.MaxValue) } , 3).ToList();
            byte? maxActual = ZEnumerable.Max(source, arg => arg.X);
            byte? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxbyteNullableList3ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (byte?) r.Next(byte.MaxValue), 3).Select(x=>x%2==0 ? x : null).ToList();
            byte? maxActual = ZEnumerable.Max(source);
            byte? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxbyteNullableList3ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (byte?) r.Next(byte.MaxValue), 3).Select(x=>x%2==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X =  x } ).ToList();
            byte? maxActual = ZEnumerable.Max(source, arg => arg.X);
            byte? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxbyteNullableList4()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (byte?) r.Next(byte.MaxValue), 4).ToList();
            byte? maxActual = ZEnumerable.Max(source);
            byte? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxbyteNullableList4Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (byte?) r.Next(byte.MaxValue) } , 4).ToList();
            byte? maxActual = ZEnumerable.Max(source, arg => arg.X);
            byte? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxbyteNullableList4ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (byte?) r.Next(byte.MaxValue), 4).Select(x=>x%2==0 ? x : null).ToList();
            byte? maxActual = ZEnumerable.Max(source);
            byte? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxbyteNullableList4ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (byte?) r.Next(byte.MaxValue), 4).Select(x=>x%2==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X =  x } ).ToList();
            byte? maxActual = ZEnumerable.Max(source, arg => arg.X);
            byte? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxbyteNullableList100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (byte?) r.Next(byte.MaxValue), 100).ToList();
            byte? maxActual = ZEnumerable.Max(source);
            byte? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxbyteNullableList100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (byte?) r.Next(byte.MaxValue) } , 100).ToList();
            byte? maxActual = ZEnumerable.Max(source, arg => arg.X);
            byte? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxbyteNullableList100ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (byte?) r.Next(byte.MaxValue), 100).Select(x=>x%2==0 ? x : null).ToList();
            byte? maxActual = ZEnumerable.Max(source);
            byte? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxbyteNullableList100ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (byte?) r.Next(byte.MaxValue), 100).Select(x=>x%2==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X =  x } ).ToList();
            byte? maxActual = ZEnumerable.Max(source, arg => arg.X);
            byte? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxbyteNullableList2048()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (byte?) r.Next(byte.MaxValue), 2048).ToList();
            byte? maxActual = ZEnumerable.Max(source);
            byte? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxbyteNullableList2048Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (byte?) r.Next(byte.MaxValue) } , 2048).ToList();
            byte? maxActual = ZEnumerable.Max(source, arg => arg.X);
            byte? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxbyteNullableList2048ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (byte?) r.Next(byte.MaxValue), 2048).Select(x=>x%2==0 ? x : null).ToList();
            byte? maxActual = ZEnumerable.Max(source);
            byte? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxbyteNullableList2048ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (byte?) r.Next(byte.MaxValue), 2048).Select(x=>x%2==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X =  x } ).ToList();
            byte? maxActual = ZEnumerable.Max(source, arg => arg.X);
            byte? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
            
        [TestMethod]
        public void TestMaxbyteNullableIListNullOrEmpty()
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

            IList<byte?> emptySource = new byte?[0].ToIList();
            try
            {
                ZEnumerable.Max(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestMaxbyteNullableIListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<byte?,byte?>((byte?) arg, (byte?) arg)).ToIList();
            Func<KeyValuePair<byte?, byte?>, byte?> nullMap = null;
            try
            {
                ZEnumerable.Max(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToIList();
            try
            {
                ZEnumerable.Max(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Max(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

                     
                
        [TestMethod]
        public void TestMaxbyteNullableIList1()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (byte?) r.Next(byte.MaxValue), 1).ToIList();
            byte? maxActual = ZEnumerable.Max(source);
            byte? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxbyteNullableIList1Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (byte?) r.Next(byte.MaxValue) } , 1).ToIList();
            byte? maxActual = ZEnumerable.Max(source, arg => arg.X);
            byte? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxbyteNullableIList1ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (byte?) r.Next(byte.MaxValue), 1).Select(x=>x%2==0 ? x : null).ToIList();
            byte? maxActual = ZEnumerable.Max(source);
            byte? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxbyteNullableIList1ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (byte?) r.Next(byte.MaxValue), 1).Select(x=>x%2==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X =  x } ).ToIList();
            byte? maxActual = ZEnumerable.Max(source, arg => arg.X);
            byte? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxbyteNullableIList2()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (byte?) r.Next(byte.MaxValue), 2).ToIList();
            byte? maxActual = ZEnumerable.Max(source);
            byte? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxbyteNullableIList2Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (byte?) r.Next(byte.MaxValue) } , 2).ToIList();
            byte? maxActual = ZEnumerable.Max(source, arg => arg.X);
            byte? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxbyteNullableIList2ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (byte?) r.Next(byte.MaxValue), 2).Select(x=>x%2==0 ? x : null).ToIList();
            byte? maxActual = ZEnumerable.Max(source);
            byte? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxbyteNullableIList2ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (byte?) r.Next(byte.MaxValue), 2).Select(x=>x%2==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X =  x } ).ToIList();
            byte? maxActual = ZEnumerable.Max(source, arg => arg.X);
            byte? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxbyteNullableIList3()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (byte?) r.Next(byte.MaxValue), 3).ToIList();
            byte? maxActual = ZEnumerable.Max(source);
            byte? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxbyteNullableIList3Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (byte?) r.Next(byte.MaxValue) } , 3).ToIList();
            byte? maxActual = ZEnumerable.Max(source, arg => arg.X);
            byte? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxbyteNullableIList3ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (byte?) r.Next(byte.MaxValue), 3).Select(x=>x%2==0 ? x : null).ToIList();
            byte? maxActual = ZEnumerable.Max(source);
            byte? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxbyteNullableIList3ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (byte?) r.Next(byte.MaxValue), 3).Select(x=>x%2==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X =  x } ).ToIList();
            byte? maxActual = ZEnumerable.Max(source, arg => arg.X);
            byte? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxbyteNullableIList4()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (byte?) r.Next(byte.MaxValue), 4).ToIList();
            byte? maxActual = ZEnumerable.Max(source);
            byte? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxbyteNullableIList4Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (byte?) r.Next(byte.MaxValue) } , 4).ToIList();
            byte? maxActual = ZEnumerable.Max(source, arg => arg.X);
            byte? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxbyteNullableIList4ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (byte?) r.Next(byte.MaxValue), 4).Select(x=>x%2==0 ? x : null).ToIList();
            byte? maxActual = ZEnumerable.Max(source);
            byte? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxbyteNullableIList4ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (byte?) r.Next(byte.MaxValue), 4).Select(x=>x%2==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X =  x } ).ToIList();
            byte? maxActual = ZEnumerable.Max(source, arg => arg.X);
            byte? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxbyteNullableIList100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (byte?) r.Next(byte.MaxValue), 100).ToIList();
            byte? maxActual = ZEnumerable.Max(source);
            byte? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxbyteNullableIList100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (byte?) r.Next(byte.MaxValue) } , 100).ToIList();
            byte? maxActual = ZEnumerable.Max(source, arg => arg.X);
            byte? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxbyteNullableIList100ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (byte?) r.Next(byte.MaxValue), 100).Select(x=>x%2==0 ? x : null).ToIList();
            byte? maxActual = ZEnumerable.Max(source);
            byte? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxbyteNullableIList100ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (byte?) r.Next(byte.MaxValue), 100).Select(x=>x%2==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X =  x } ).ToIList();
            byte? maxActual = ZEnumerable.Max(source, arg => arg.X);
            byte? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxbyteNullableIList2048()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (byte?) r.Next(byte.MaxValue), 2048).ToIList();
            byte? maxActual = ZEnumerable.Max(source);
            byte? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxbyteNullableIList2048Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (byte?) r.Next(byte.MaxValue) } , 2048).ToIList();
            byte? maxActual = ZEnumerable.Max(source, arg => arg.X);
            byte? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxbyteNullableIList2048ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (byte?) r.Next(byte.MaxValue), 2048).Select(x=>x%2==0 ? x : null).ToIList();
            byte? maxActual = ZEnumerable.Max(source);
            byte? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxbyteNullableIList2048ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (byte?) r.Next(byte.MaxValue), 2048).Select(x=>x%2==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X =  x } ).ToIList();
            byte? maxActual = ZEnumerable.Max(source, arg => arg.X);
            byte? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                        
               
        #endregion

      

        #region short? 
             
            
        [TestMethod]
        public void TestMaxshortNullableArrayNullOrEmpty()
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

            short?[] emptySource = new short?[0].ToArray();
            try
            {
                ZEnumerable.Max(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestMaxshortNullableArrayMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<short?,short?>((short?) arg, (short?) arg)).ToArray();
            Func<KeyValuePair<short?, short?>, short?> nullMap = null;
            try
            {
                ZEnumerable.Max(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToArray();
            try
            {
                ZEnumerable.Max(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Max(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

                     
                
        [TestMethod]
        public void TestMaxshortNullableArray1()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (short?) r.Next(short.MaxValue), 1).ToArray();
            short? maxActual = ZEnumerable.Max(source);
            short? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxshortNullableArray1Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (short?) r.Next(short.MaxValue) } , 1).ToArray();
            short? maxActual = ZEnumerable.Max(source, arg => arg.X);
            short? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxshortNullableArray1ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (short?) r.Next(short.MaxValue), 1).Select(x=>x%2==0 ? x : null).ToArray();
            short? maxActual = ZEnumerable.Max(source);
            short? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxshortNullableArray1ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (short?) r.Next(short.MaxValue), 1).Select(x=>x%2==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X =  x } ).ToArray();
            short? maxActual = ZEnumerable.Max(source, arg => arg.X);
            short? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxshortNullableArray2()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (short?) r.Next(short.MaxValue), 2).ToArray();
            short? maxActual = ZEnumerable.Max(source);
            short? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxshortNullableArray2Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (short?) r.Next(short.MaxValue) } , 2).ToArray();
            short? maxActual = ZEnumerable.Max(source, arg => arg.X);
            short? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxshortNullableArray2ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (short?) r.Next(short.MaxValue), 2).Select(x=>x%2==0 ? x : null).ToArray();
            short? maxActual = ZEnumerable.Max(source);
            short? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxshortNullableArray2ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (short?) r.Next(short.MaxValue), 2).Select(x=>x%2==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X =  x } ).ToArray();
            short? maxActual = ZEnumerable.Max(source, arg => arg.X);
            short? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxshortNullableArray3()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (short?) r.Next(short.MaxValue), 3).ToArray();
            short? maxActual = ZEnumerable.Max(source);
            short? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxshortNullableArray3Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (short?) r.Next(short.MaxValue) } , 3).ToArray();
            short? maxActual = ZEnumerable.Max(source, arg => arg.X);
            short? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxshortNullableArray3ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (short?) r.Next(short.MaxValue), 3).Select(x=>x%2==0 ? x : null).ToArray();
            short? maxActual = ZEnumerable.Max(source);
            short? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxshortNullableArray3ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (short?) r.Next(short.MaxValue), 3).Select(x=>x%2==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X =  x } ).ToArray();
            short? maxActual = ZEnumerable.Max(source, arg => arg.X);
            short? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxshortNullableArray4()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (short?) r.Next(short.MaxValue), 4).ToArray();
            short? maxActual = ZEnumerable.Max(source);
            short? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxshortNullableArray4Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (short?) r.Next(short.MaxValue) } , 4).ToArray();
            short? maxActual = ZEnumerable.Max(source, arg => arg.X);
            short? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxshortNullableArray4ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (short?) r.Next(short.MaxValue), 4).Select(x=>x%2==0 ? x : null).ToArray();
            short? maxActual = ZEnumerable.Max(source);
            short? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxshortNullableArray4ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (short?) r.Next(short.MaxValue), 4).Select(x=>x%2==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X =  x } ).ToArray();
            short? maxActual = ZEnumerable.Max(source, arg => arg.X);
            short? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxshortNullableArray100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (short?) r.Next(short.MaxValue), 100).ToArray();
            short? maxActual = ZEnumerable.Max(source);
            short? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxshortNullableArray100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (short?) r.Next(short.MaxValue) } , 100).ToArray();
            short? maxActual = ZEnumerable.Max(source, arg => arg.X);
            short? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxshortNullableArray100ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (short?) r.Next(short.MaxValue), 100).Select(x=>x%2==0 ? x : null).ToArray();
            short? maxActual = ZEnumerable.Max(source);
            short? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxshortNullableArray100ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (short?) r.Next(short.MaxValue), 100).Select(x=>x%2==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X =  x } ).ToArray();
            short? maxActual = ZEnumerable.Max(source, arg => arg.X);
            short? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxshortNullableArray2048()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (short?) r.Next(short.MaxValue), 2048).ToArray();
            short? maxActual = ZEnumerable.Max(source);
            short? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxshortNullableArray2048Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (short?) r.Next(short.MaxValue) } , 2048).ToArray();
            short? maxActual = ZEnumerable.Max(source, arg => arg.X);
            short? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxshortNullableArray2048ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (short?) r.Next(short.MaxValue), 2048).Select(x=>x%2==0 ? x : null).ToArray();
            short? maxActual = ZEnumerable.Max(source);
            short? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxshortNullableArray2048ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (short?) r.Next(short.MaxValue), 2048).Select(x=>x%2==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X =  x } ).ToArray();
            short? maxActual = ZEnumerable.Max(source, arg => arg.X);
            short? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
            
        [TestMethod]
        public void TestMaxshortNullableListNullOrEmpty()
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

            List<short?> emptySource = new short?[0].ToList();
            try
            {
                ZEnumerable.Max(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestMaxshortNullableListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<short?,short?>((short?) arg, (short?) arg)).ToList();
            Func<KeyValuePair<short?, short?>, short?> nullMap = null;
            try
            {
                ZEnumerable.Max(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToList();
            try
            {
                ZEnumerable.Max(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Max(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

                     
                
        [TestMethod]
        public void TestMaxshortNullableList1()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (short?) r.Next(short.MaxValue), 1).ToList();
            short? maxActual = ZEnumerable.Max(source);
            short? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxshortNullableList1Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (short?) r.Next(short.MaxValue) } , 1).ToList();
            short? maxActual = ZEnumerable.Max(source, arg => arg.X);
            short? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxshortNullableList1ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (short?) r.Next(short.MaxValue), 1).Select(x=>x%2==0 ? x : null).ToList();
            short? maxActual = ZEnumerable.Max(source);
            short? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxshortNullableList1ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (short?) r.Next(short.MaxValue), 1).Select(x=>x%2==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X =  x } ).ToList();
            short? maxActual = ZEnumerable.Max(source, arg => arg.X);
            short? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxshortNullableList2()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (short?) r.Next(short.MaxValue), 2).ToList();
            short? maxActual = ZEnumerable.Max(source);
            short? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxshortNullableList2Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (short?) r.Next(short.MaxValue) } , 2).ToList();
            short? maxActual = ZEnumerable.Max(source, arg => arg.X);
            short? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxshortNullableList2ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (short?) r.Next(short.MaxValue), 2).Select(x=>x%2==0 ? x : null).ToList();
            short? maxActual = ZEnumerable.Max(source);
            short? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxshortNullableList2ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (short?) r.Next(short.MaxValue), 2).Select(x=>x%2==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X =  x } ).ToList();
            short? maxActual = ZEnumerable.Max(source, arg => arg.X);
            short? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxshortNullableList3()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (short?) r.Next(short.MaxValue), 3).ToList();
            short? maxActual = ZEnumerable.Max(source);
            short? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxshortNullableList3Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (short?) r.Next(short.MaxValue) } , 3).ToList();
            short? maxActual = ZEnumerable.Max(source, arg => arg.X);
            short? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxshortNullableList3ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (short?) r.Next(short.MaxValue), 3).Select(x=>x%2==0 ? x : null).ToList();
            short? maxActual = ZEnumerable.Max(source);
            short? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxshortNullableList3ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (short?) r.Next(short.MaxValue), 3).Select(x=>x%2==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X =  x } ).ToList();
            short? maxActual = ZEnumerable.Max(source, arg => arg.X);
            short? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxshortNullableList4()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (short?) r.Next(short.MaxValue), 4).ToList();
            short? maxActual = ZEnumerable.Max(source);
            short? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxshortNullableList4Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (short?) r.Next(short.MaxValue) } , 4).ToList();
            short? maxActual = ZEnumerable.Max(source, arg => arg.X);
            short? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxshortNullableList4ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (short?) r.Next(short.MaxValue), 4).Select(x=>x%2==0 ? x : null).ToList();
            short? maxActual = ZEnumerable.Max(source);
            short? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxshortNullableList4ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (short?) r.Next(short.MaxValue), 4).Select(x=>x%2==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X =  x } ).ToList();
            short? maxActual = ZEnumerable.Max(source, arg => arg.X);
            short? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxshortNullableList100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (short?) r.Next(short.MaxValue), 100).ToList();
            short? maxActual = ZEnumerable.Max(source);
            short? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxshortNullableList100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (short?) r.Next(short.MaxValue) } , 100).ToList();
            short? maxActual = ZEnumerable.Max(source, arg => arg.X);
            short? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxshortNullableList100ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (short?) r.Next(short.MaxValue), 100).Select(x=>x%2==0 ? x : null).ToList();
            short? maxActual = ZEnumerable.Max(source);
            short? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxshortNullableList100ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (short?) r.Next(short.MaxValue), 100).Select(x=>x%2==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X =  x } ).ToList();
            short? maxActual = ZEnumerable.Max(source, arg => arg.X);
            short? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxshortNullableList2048()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (short?) r.Next(short.MaxValue), 2048).ToList();
            short? maxActual = ZEnumerable.Max(source);
            short? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxshortNullableList2048Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (short?) r.Next(short.MaxValue) } , 2048).ToList();
            short? maxActual = ZEnumerable.Max(source, arg => arg.X);
            short? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxshortNullableList2048ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (short?) r.Next(short.MaxValue), 2048).Select(x=>x%2==0 ? x : null).ToList();
            short? maxActual = ZEnumerable.Max(source);
            short? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxshortNullableList2048ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (short?) r.Next(short.MaxValue), 2048).Select(x=>x%2==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X =  x } ).ToList();
            short? maxActual = ZEnumerable.Max(source, arg => arg.X);
            short? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
            
        [TestMethod]
        public void TestMaxshortNullableIListNullOrEmpty()
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

            IList<short?> emptySource = new short?[0].ToIList();
            try
            {
                ZEnumerable.Max(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestMaxshortNullableIListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<short?,short?>((short?) arg, (short?) arg)).ToIList();
            Func<KeyValuePair<short?, short?>, short?> nullMap = null;
            try
            {
                ZEnumerable.Max(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToIList();
            try
            {
                ZEnumerable.Max(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Max(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

                     
                
        [TestMethod]
        public void TestMaxshortNullableIList1()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (short?) r.Next(short.MaxValue), 1).ToIList();
            short? maxActual = ZEnumerable.Max(source);
            short? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxshortNullableIList1Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (short?) r.Next(short.MaxValue) } , 1).ToIList();
            short? maxActual = ZEnumerable.Max(source, arg => arg.X);
            short? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxshortNullableIList1ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (short?) r.Next(short.MaxValue), 1).Select(x=>x%2==0 ? x : null).ToIList();
            short? maxActual = ZEnumerable.Max(source);
            short? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxshortNullableIList1ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (short?) r.Next(short.MaxValue), 1).Select(x=>x%2==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X =  x } ).ToIList();
            short? maxActual = ZEnumerable.Max(source, arg => arg.X);
            short? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxshortNullableIList2()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (short?) r.Next(short.MaxValue), 2).ToIList();
            short? maxActual = ZEnumerable.Max(source);
            short? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxshortNullableIList2Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (short?) r.Next(short.MaxValue) } , 2).ToIList();
            short? maxActual = ZEnumerable.Max(source, arg => arg.X);
            short? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxshortNullableIList2ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (short?) r.Next(short.MaxValue), 2).Select(x=>x%2==0 ? x : null).ToIList();
            short? maxActual = ZEnumerable.Max(source);
            short? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxshortNullableIList2ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (short?) r.Next(short.MaxValue), 2).Select(x=>x%2==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X =  x } ).ToIList();
            short? maxActual = ZEnumerable.Max(source, arg => arg.X);
            short? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxshortNullableIList3()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (short?) r.Next(short.MaxValue), 3).ToIList();
            short? maxActual = ZEnumerable.Max(source);
            short? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxshortNullableIList3Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (short?) r.Next(short.MaxValue) } , 3).ToIList();
            short? maxActual = ZEnumerable.Max(source, arg => arg.X);
            short? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxshortNullableIList3ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (short?) r.Next(short.MaxValue), 3).Select(x=>x%2==0 ? x : null).ToIList();
            short? maxActual = ZEnumerable.Max(source);
            short? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxshortNullableIList3ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (short?) r.Next(short.MaxValue), 3).Select(x=>x%2==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X =  x } ).ToIList();
            short? maxActual = ZEnumerable.Max(source, arg => arg.X);
            short? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxshortNullableIList4()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (short?) r.Next(short.MaxValue), 4).ToIList();
            short? maxActual = ZEnumerable.Max(source);
            short? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxshortNullableIList4Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (short?) r.Next(short.MaxValue) } , 4).ToIList();
            short? maxActual = ZEnumerable.Max(source, arg => arg.X);
            short? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxshortNullableIList4ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (short?) r.Next(short.MaxValue), 4).Select(x=>x%2==0 ? x : null).ToIList();
            short? maxActual = ZEnumerable.Max(source);
            short? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxshortNullableIList4ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (short?) r.Next(short.MaxValue), 4).Select(x=>x%2==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X =  x } ).ToIList();
            short? maxActual = ZEnumerable.Max(source, arg => arg.X);
            short? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxshortNullableIList100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (short?) r.Next(short.MaxValue), 100).ToIList();
            short? maxActual = ZEnumerable.Max(source);
            short? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxshortNullableIList100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (short?) r.Next(short.MaxValue) } , 100).ToIList();
            short? maxActual = ZEnumerable.Max(source, arg => arg.X);
            short? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxshortNullableIList100ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (short?) r.Next(short.MaxValue), 100).Select(x=>x%2==0 ? x : null).ToIList();
            short? maxActual = ZEnumerable.Max(source);
            short? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxshortNullableIList100ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (short?) r.Next(short.MaxValue), 100).Select(x=>x%2==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X =  x } ).ToIList();
            short? maxActual = ZEnumerable.Max(source, arg => arg.X);
            short? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxshortNullableIList2048()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (short?) r.Next(short.MaxValue), 2048).ToIList();
            short? maxActual = ZEnumerable.Max(source);
            short? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxshortNullableIList2048Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (short?) r.Next(short.MaxValue) } , 2048).ToIList();
            short? maxActual = ZEnumerable.Max(source, arg => arg.X);
            short? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxshortNullableIList2048ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (short?) r.Next(short.MaxValue), 2048).Select(x=>x%2==0 ? x : null).ToIList();
            short? maxActual = ZEnumerable.Max(source);
            short? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxshortNullableIList2048ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (short?) r.Next(short.MaxValue), 2048).Select(x=>x%2==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X =  x } ).ToIList();
            short? maxActual = ZEnumerable.Max(source, arg => arg.X);
            short? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                        
               
        #endregion

      

        #region ushort? 
             
            
        [TestMethod]
        public void TestMaxushortNullableArrayNullOrEmpty()
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

            ushort?[] emptySource = new ushort?[0].ToArray();
            try
            {
                ZEnumerable.Max(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestMaxushortNullableArrayMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<ushort?,ushort?>((ushort?) arg, (ushort?) arg)).ToArray();
            Func<KeyValuePair<ushort?, ushort?>, ushort?> nullMap = null;
            try
            {
                ZEnumerable.Max(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToArray();
            try
            {
                ZEnumerable.Max(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Max(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

                     
                
        [TestMethod]
        public void TestMaxushortNullableArray1()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ushort?) r.Next(ushort.MaxValue), 1).ToArray();
            ushort? maxActual = ZEnumerable.Max(source);
            ushort? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxushortNullableArray1Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ushort?) r.Next(ushort.MaxValue) } , 1).ToArray();
            ushort? maxActual = ZEnumerable.Max(source, arg => arg.X);
            ushort? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxushortNullableArray1ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ushort?) r.Next(ushort.MaxValue), 1).Select(x=>x%2==0 ? x : null).ToArray();
            ushort? maxActual = ZEnumerable.Max(source);
            ushort? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxushortNullableArray1ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (ushort?) r.Next(ushort.MaxValue), 1).Select(x=>x%2==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X =  x } ).ToArray();
            ushort? maxActual = ZEnumerable.Max(source, arg => arg.X);
            ushort? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxushortNullableArray2()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ushort?) r.Next(ushort.MaxValue), 2).ToArray();
            ushort? maxActual = ZEnumerable.Max(source);
            ushort? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxushortNullableArray2Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ushort?) r.Next(ushort.MaxValue) } , 2).ToArray();
            ushort? maxActual = ZEnumerable.Max(source, arg => arg.X);
            ushort? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxushortNullableArray2ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ushort?) r.Next(ushort.MaxValue), 2).Select(x=>x%2==0 ? x : null).ToArray();
            ushort? maxActual = ZEnumerable.Max(source);
            ushort? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxushortNullableArray2ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (ushort?) r.Next(ushort.MaxValue), 2).Select(x=>x%2==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X =  x } ).ToArray();
            ushort? maxActual = ZEnumerable.Max(source, arg => arg.X);
            ushort? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxushortNullableArray3()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ushort?) r.Next(ushort.MaxValue), 3).ToArray();
            ushort? maxActual = ZEnumerable.Max(source);
            ushort? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxushortNullableArray3Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ushort?) r.Next(ushort.MaxValue) } , 3).ToArray();
            ushort? maxActual = ZEnumerable.Max(source, arg => arg.X);
            ushort? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxushortNullableArray3ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ushort?) r.Next(ushort.MaxValue), 3).Select(x=>x%2==0 ? x : null).ToArray();
            ushort? maxActual = ZEnumerable.Max(source);
            ushort? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxushortNullableArray3ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (ushort?) r.Next(ushort.MaxValue), 3).Select(x=>x%2==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X =  x } ).ToArray();
            ushort? maxActual = ZEnumerable.Max(source, arg => arg.X);
            ushort? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxushortNullableArray4()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ushort?) r.Next(ushort.MaxValue), 4).ToArray();
            ushort? maxActual = ZEnumerable.Max(source);
            ushort? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxushortNullableArray4Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ushort?) r.Next(ushort.MaxValue) } , 4).ToArray();
            ushort? maxActual = ZEnumerable.Max(source, arg => arg.X);
            ushort? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxushortNullableArray4ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ushort?) r.Next(ushort.MaxValue), 4).Select(x=>x%2==0 ? x : null).ToArray();
            ushort? maxActual = ZEnumerable.Max(source);
            ushort? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxushortNullableArray4ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (ushort?) r.Next(ushort.MaxValue), 4).Select(x=>x%2==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X =  x } ).ToArray();
            ushort? maxActual = ZEnumerable.Max(source, arg => arg.X);
            ushort? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxushortNullableArray100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ushort?) r.Next(ushort.MaxValue), 100).ToArray();
            ushort? maxActual = ZEnumerable.Max(source);
            ushort? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxushortNullableArray100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ushort?) r.Next(ushort.MaxValue) } , 100).ToArray();
            ushort? maxActual = ZEnumerable.Max(source, arg => arg.X);
            ushort? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxushortNullableArray100ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ushort?) r.Next(ushort.MaxValue), 100).Select(x=>x%2==0 ? x : null).ToArray();
            ushort? maxActual = ZEnumerable.Max(source);
            ushort? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxushortNullableArray100ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (ushort?) r.Next(ushort.MaxValue), 100).Select(x=>x%2==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X =  x } ).ToArray();
            ushort? maxActual = ZEnumerable.Max(source, arg => arg.X);
            ushort? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxushortNullableArray2048()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ushort?) r.Next(ushort.MaxValue), 2048).ToArray();
            ushort? maxActual = ZEnumerable.Max(source);
            ushort? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxushortNullableArray2048Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ushort?) r.Next(ushort.MaxValue) } , 2048).ToArray();
            ushort? maxActual = ZEnumerable.Max(source, arg => arg.X);
            ushort? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxushortNullableArray2048ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ushort?) r.Next(ushort.MaxValue), 2048).Select(x=>x%2==0 ? x : null).ToArray();
            ushort? maxActual = ZEnumerable.Max(source);
            ushort? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxushortNullableArray2048ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (ushort?) r.Next(ushort.MaxValue), 2048).Select(x=>x%2==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X =  x } ).ToArray();
            ushort? maxActual = ZEnumerable.Max(source, arg => arg.X);
            ushort? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
            
        [TestMethod]
        public void TestMaxushortNullableListNullOrEmpty()
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

            List<ushort?> emptySource = new ushort?[0].ToList();
            try
            {
                ZEnumerable.Max(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestMaxushortNullableListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<ushort?,ushort?>((ushort?) arg, (ushort?) arg)).ToList();
            Func<KeyValuePair<ushort?, ushort?>, ushort?> nullMap = null;
            try
            {
                ZEnumerable.Max(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToList();
            try
            {
                ZEnumerable.Max(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Max(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

                     
                
        [TestMethod]
        public void TestMaxushortNullableList1()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ushort?) r.Next(ushort.MaxValue), 1).ToList();
            ushort? maxActual = ZEnumerable.Max(source);
            ushort? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxushortNullableList1Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ushort?) r.Next(ushort.MaxValue) } , 1).ToList();
            ushort? maxActual = ZEnumerable.Max(source, arg => arg.X);
            ushort? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxushortNullableList1ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ushort?) r.Next(ushort.MaxValue), 1).Select(x=>x%2==0 ? x : null).ToList();
            ushort? maxActual = ZEnumerable.Max(source);
            ushort? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxushortNullableList1ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (ushort?) r.Next(ushort.MaxValue), 1).Select(x=>x%2==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X =  x } ).ToList();
            ushort? maxActual = ZEnumerable.Max(source, arg => arg.X);
            ushort? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxushortNullableList2()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ushort?) r.Next(ushort.MaxValue), 2).ToList();
            ushort? maxActual = ZEnumerable.Max(source);
            ushort? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxushortNullableList2Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ushort?) r.Next(ushort.MaxValue) } , 2).ToList();
            ushort? maxActual = ZEnumerable.Max(source, arg => arg.X);
            ushort? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxushortNullableList2ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ushort?) r.Next(ushort.MaxValue), 2).Select(x=>x%2==0 ? x : null).ToList();
            ushort? maxActual = ZEnumerable.Max(source);
            ushort? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxushortNullableList2ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (ushort?) r.Next(ushort.MaxValue), 2).Select(x=>x%2==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X =  x } ).ToList();
            ushort? maxActual = ZEnumerable.Max(source, arg => arg.X);
            ushort? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxushortNullableList3()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ushort?) r.Next(ushort.MaxValue), 3).ToList();
            ushort? maxActual = ZEnumerable.Max(source);
            ushort? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxushortNullableList3Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ushort?) r.Next(ushort.MaxValue) } , 3).ToList();
            ushort? maxActual = ZEnumerable.Max(source, arg => arg.X);
            ushort? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxushortNullableList3ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ushort?) r.Next(ushort.MaxValue), 3).Select(x=>x%2==0 ? x : null).ToList();
            ushort? maxActual = ZEnumerable.Max(source);
            ushort? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxushortNullableList3ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (ushort?) r.Next(ushort.MaxValue), 3).Select(x=>x%2==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X =  x } ).ToList();
            ushort? maxActual = ZEnumerable.Max(source, arg => arg.X);
            ushort? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxushortNullableList4()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ushort?) r.Next(ushort.MaxValue), 4).ToList();
            ushort? maxActual = ZEnumerable.Max(source);
            ushort? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxushortNullableList4Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ushort?) r.Next(ushort.MaxValue) } , 4).ToList();
            ushort? maxActual = ZEnumerable.Max(source, arg => arg.X);
            ushort? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxushortNullableList4ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ushort?) r.Next(ushort.MaxValue), 4).Select(x=>x%2==0 ? x : null).ToList();
            ushort? maxActual = ZEnumerable.Max(source);
            ushort? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxushortNullableList4ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (ushort?) r.Next(ushort.MaxValue), 4).Select(x=>x%2==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X =  x } ).ToList();
            ushort? maxActual = ZEnumerable.Max(source, arg => arg.X);
            ushort? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxushortNullableList100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ushort?) r.Next(ushort.MaxValue), 100).ToList();
            ushort? maxActual = ZEnumerable.Max(source);
            ushort? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxushortNullableList100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ushort?) r.Next(ushort.MaxValue) } , 100).ToList();
            ushort? maxActual = ZEnumerable.Max(source, arg => arg.X);
            ushort? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxushortNullableList100ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ushort?) r.Next(ushort.MaxValue), 100).Select(x=>x%2==0 ? x : null).ToList();
            ushort? maxActual = ZEnumerable.Max(source);
            ushort? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxushortNullableList100ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (ushort?) r.Next(ushort.MaxValue), 100).Select(x=>x%2==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X =  x } ).ToList();
            ushort? maxActual = ZEnumerable.Max(source, arg => arg.X);
            ushort? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxushortNullableList2048()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ushort?) r.Next(ushort.MaxValue), 2048).ToList();
            ushort? maxActual = ZEnumerable.Max(source);
            ushort? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxushortNullableList2048Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ushort?) r.Next(ushort.MaxValue) } , 2048).ToList();
            ushort? maxActual = ZEnumerable.Max(source, arg => arg.X);
            ushort? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxushortNullableList2048ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ushort?) r.Next(ushort.MaxValue), 2048).Select(x=>x%2==0 ? x : null).ToList();
            ushort? maxActual = ZEnumerable.Max(source);
            ushort? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxushortNullableList2048ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (ushort?) r.Next(ushort.MaxValue), 2048).Select(x=>x%2==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X =  x } ).ToList();
            ushort? maxActual = ZEnumerable.Max(source, arg => arg.X);
            ushort? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
            
        [TestMethod]
        public void TestMaxushortNullableIListNullOrEmpty()
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

            IList<ushort?> emptySource = new ushort?[0].ToIList();
            try
            {
                ZEnumerable.Max(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestMaxushortNullableIListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<ushort?,ushort?>((ushort?) arg, (ushort?) arg)).ToIList();
            Func<KeyValuePair<ushort?, ushort?>, ushort?> nullMap = null;
            try
            {
                ZEnumerable.Max(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToIList();
            try
            {
                ZEnumerable.Max(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Max(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

                     
                
        [TestMethod]
        public void TestMaxushortNullableIList1()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ushort?) r.Next(ushort.MaxValue), 1).ToIList();
            ushort? maxActual = ZEnumerable.Max(source);
            ushort? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxushortNullableIList1Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ushort?) r.Next(ushort.MaxValue) } , 1).ToIList();
            ushort? maxActual = ZEnumerable.Max(source, arg => arg.X);
            ushort? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxushortNullableIList1ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ushort?) r.Next(ushort.MaxValue), 1).Select(x=>x%2==0 ? x : null).ToIList();
            ushort? maxActual = ZEnumerable.Max(source);
            ushort? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxushortNullableIList1ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (ushort?) r.Next(ushort.MaxValue), 1).Select(x=>x%2==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X =  x } ).ToIList();
            ushort? maxActual = ZEnumerable.Max(source, arg => arg.X);
            ushort? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxushortNullableIList2()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ushort?) r.Next(ushort.MaxValue), 2).ToIList();
            ushort? maxActual = ZEnumerable.Max(source);
            ushort? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxushortNullableIList2Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ushort?) r.Next(ushort.MaxValue) } , 2).ToIList();
            ushort? maxActual = ZEnumerable.Max(source, arg => arg.X);
            ushort? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxushortNullableIList2ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ushort?) r.Next(ushort.MaxValue), 2).Select(x=>x%2==0 ? x : null).ToIList();
            ushort? maxActual = ZEnumerable.Max(source);
            ushort? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxushortNullableIList2ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (ushort?) r.Next(ushort.MaxValue), 2).Select(x=>x%2==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X =  x } ).ToIList();
            ushort? maxActual = ZEnumerable.Max(source, arg => arg.X);
            ushort? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxushortNullableIList3()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ushort?) r.Next(ushort.MaxValue), 3).ToIList();
            ushort? maxActual = ZEnumerable.Max(source);
            ushort? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxushortNullableIList3Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ushort?) r.Next(ushort.MaxValue) } , 3).ToIList();
            ushort? maxActual = ZEnumerable.Max(source, arg => arg.X);
            ushort? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxushortNullableIList3ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ushort?) r.Next(ushort.MaxValue), 3).Select(x=>x%2==0 ? x : null).ToIList();
            ushort? maxActual = ZEnumerable.Max(source);
            ushort? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxushortNullableIList3ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (ushort?) r.Next(ushort.MaxValue), 3).Select(x=>x%2==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X =  x } ).ToIList();
            ushort? maxActual = ZEnumerable.Max(source, arg => arg.X);
            ushort? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxushortNullableIList4()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ushort?) r.Next(ushort.MaxValue), 4).ToIList();
            ushort? maxActual = ZEnumerable.Max(source);
            ushort? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxushortNullableIList4Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ushort?) r.Next(ushort.MaxValue) } , 4).ToIList();
            ushort? maxActual = ZEnumerable.Max(source, arg => arg.X);
            ushort? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxushortNullableIList4ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ushort?) r.Next(ushort.MaxValue), 4).Select(x=>x%2==0 ? x : null).ToIList();
            ushort? maxActual = ZEnumerable.Max(source);
            ushort? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxushortNullableIList4ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (ushort?) r.Next(ushort.MaxValue), 4).Select(x=>x%2==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X =  x } ).ToIList();
            ushort? maxActual = ZEnumerable.Max(source, arg => arg.X);
            ushort? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxushortNullableIList100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ushort?) r.Next(ushort.MaxValue), 100).ToIList();
            ushort? maxActual = ZEnumerable.Max(source);
            ushort? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxushortNullableIList100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ushort?) r.Next(ushort.MaxValue) } , 100).ToIList();
            ushort? maxActual = ZEnumerable.Max(source, arg => arg.X);
            ushort? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxushortNullableIList100ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ushort?) r.Next(ushort.MaxValue), 100).Select(x=>x%2==0 ? x : null).ToIList();
            ushort? maxActual = ZEnumerable.Max(source);
            ushort? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxushortNullableIList100ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (ushort?) r.Next(ushort.MaxValue), 100).Select(x=>x%2==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X =  x } ).ToIList();
            ushort? maxActual = ZEnumerable.Max(source, arg => arg.X);
            ushort? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxushortNullableIList2048()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ushort?) r.Next(ushort.MaxValue), 2048).ToIList();
            ushort? maxActual = ZEnumerable.Max(source);
            ushort? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxushortNullableIList2048Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ushort?) r.Next(ushort.MaxValue) } , 2048).ToIList();
            ushort? maxActual = ZEnumerable.Max(source, arg => arg.X);
            ushort? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxushortNullableIList2048ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ushort?) r.Next(ushort.MaxValue), 2048).Select(x=>x%2==0 ? x : null).ToIList();
            ushort? maxActual = ZEnumerable.Max(source);
            ushort? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxushortNullableIList2048ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (ushort?) r.Next(ushort.MaxValue), 2048).Select(x=>x%2==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X =  x } ).ToIList();
            ushort? maxActual = ZEnumerable.Max(source, arg => arg.X);
            ushort? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                        
               
        #endregion

      

        #region int? 
             
            
        [TestMethod]
        public void TestMaxintNullableArrayNullOrEmpty()
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

            int?[] emptySource = new int?[0].ToArray();
            try
            {
                ZEnumerable.Max(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestMaxintNullableArrayMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<int?,int?>((int?) arg, (int?) arg)).ToArray();
            Func<KeyValuePair<int?, int?>, int?> nullMap = null;
            try
            {
                ZEnumerable.Max(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToArray();
            try
            {
                ZEnumerable.Max(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Max(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

                     
                
        [TestMethod]
        public void TestMaxintNullableArray1()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (int?) r.Next(int.MaxValue), 1).ToArray();
            int? maxActual = ZEnumerable.Max(source);
            int? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxintNullableArray1Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (int?) r.Next(int.MaxValue) } , 1).ToArray();
            int? maxActual = ZEnumerable.Max(source, arg => arg.X);
            int? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxintNullableArray1ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (int?) r.Next(int.MaxValue), 1).Select(x=>x%2==0 ? x : null).ToArray();
            int? maxActual = ZEnumerable.Max(source);
            int? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxintNullableArray1ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (int?) r.Next(int.MaxValue), 1).Select(x=>x%2==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X =  x } ).ToArray();
            int? maxActual = ZEnumerable.Max(source, arg => arg.X);
            int? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxintNullableArray2()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (int?) r.Next(int.MaxValue), 2).ToArray();
            int? maxActual = ZEnumerable.Max(source);
            int? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxintNullableArray2Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (int?) r.Next(int.MaxValue) } , 2).ToArray();
            int? maxActual = ZEnumerable.Max(source, arg => arg.X);
            int? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxintNullableArray2ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (int?) r.Next(int.MaxValue), 2).Select(x=>x%2==0 ? x : null).ToArray();
            int? maxActual = ZEnumerable.Max(source);
            int? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxintNullableArray2ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (int?) r.Next(int.MaxValue), 2).Select(x=>x%2==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X =  x } ).ToArray();
            int? maxActual = ZEnumerable.Max(source, arg => arg.X);
            int? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxintNullableArray3()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (int?) r.Next(int.MaxValue), 3).ToArray();
            int? maxActual = ZEnumerable.Max(source);
            int? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxintNullableArray3Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (int?) r.Next(int.MaxValue) } , 3).ToArray();
            int? maxActual = ZEnumerable.Max(source, arg => arg.X);
            int? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxintNullableArray3ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (int?) r.Next(int.MaxValue), 3).Select(x=>x%2==0 ? x : null).ToArray();
            int? maxActual = ZEnumerable.Max(source);
            int? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxintNullableArray3ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (int?) r.Next(int.MaxValue), 3).Select(x=>x%2==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X =  x } ).ToArray();
            int? maxActual = ZEnumerable.Max(source, arg => arg.X);
            int? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxintNullableArray4()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (int?) r.Next(int.MaxValue), 4).ToArray();
            int? maxActual = ZEnumerable.Max(source);
            int? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxintNullableArray4Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (int?) r.Next(int.MaxValue) } , 4).ToArray();
            int? maxActual = ZEnumerable.Max(source, arg => arg.X);
            int? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxintNullableArray4ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (int?) r.Next(int.MaxValue), 4).Select(x=>x%2==0 ? x : null).ToArray();
            int? maxActual = ZEnumerable.Max(source);
            int? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxintNullableArray4ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (int?) r.Next(int.MaxValue), 4).Select(x=>x%2==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X =  x } ).ToArray();
            int? maxActual = ZEnumerable.Max(source, arg => arg.X);
            int? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxintNullableArray100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (int?) r.Next(int.MaxValue), 100).ToArray();
            int? maxActual = ZEnumerable.Max(source);
            int? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxintNullableArray100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (int?) r.Next(int.MaxValue) } , 100).ToArray();
            int? maxActual = ZEnumerable.Max(source, arg => arg.X);
            int? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxintNullableArray100ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (int?) r.Next(int.MaxValue), 100).Select(x=>x%2==0 ? x : null).ToArray();
            int? maxActual = ZEnumerable.Max(source);
            int? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxintNullableArray100ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (int?) r.Next(int.MaxValue), 100).Select(x=>x%2==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X =  x } ).ToArray();
            int? maxActual = ZEnumerable.Max(source, arg => arg.X);
            int? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxintNullableArray2048()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (int?) r.Next(int.MaxValue), 2048).ToArray();
            int? maxActual = ZEnumerable.Max(source);
            int? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxintNullableArray2048Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (int?) r.Next(int.MaxValue) } , 2048).ToArray();
            int? maxActual = ZEnumerable.Max(source, arg => arg.X);
            int? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxintNullableArray2048ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (int?) r.Next(int.MaxValue), 2048).Select(x=>x%2==0 ? x : null).ToArray();
            int? maxActual = ZEnumerable.Max(source);
            int? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxintNullableArray2048ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (int?) r.Next(int.MaxValue), 2048).Select(x=>x%2==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X =  x } ).ToArray();
            int? maxActual = ZEnumerable.Max(source, arg => arg.X);
            int? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
            
        [TestMethod]
        public void TestMaxintNullableListNullOrEmpty()
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

            List<int?> emptySource = new int?[0].ToList();
            try
            {
                ZEnumerable.Max(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestMaxintNullableListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<int?,int?>((int?) arg, (int?) arg)).ToList();
            Func<KeyValuePair<int?, int?>, int?> nullMap = null;
            try
            {
                ZEnumerable.Max(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToList();
            try
            {
                ZEnumerable.Max(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Max(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

                     
                
        [TestMethod]
        public void TestMaxintNullableList1()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (int?) r.Next(int.MaxValue), 1).ToList();
            int? maxActual = ZEnumerable.Max(source);
            int? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxintNullableList1Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (int?) r.Next(int.MaxValue) } , 1).ToList();
            int? maxActual = ZEnumerable.Max(source, arg => arg.X);
            int? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxintNullableList1ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (int?) r.Next(int.MaxValue), 1).Select(x=>x%2==0 ? x : null).ToList();
            int? maxActual = ZEnumerable.Max(source);
            int? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxintNullableList1ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (int?) r.Next(int.MaxValue), 1).Select(x=>x%2==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X =  x } ).ToList();
            int? maxActual = ZEnumerable.Max(source, arg => arg.X);
            int? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxintNullableList2()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (int?) r.Next(int.MaxValue), 2).ToList();
            int? maxActual = ZEnumerable.Max(source);
            int? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxintNullableList2Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (int?) r.Next(int.MaxValue) } , 2).ToList();
            int? maxActual = ZEnumerable.Max(source, arg => arg.X);
            int? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxintNullableList2ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (int?) r.Next(int.MaxValue), 2).Select(x=>x%2==0 ? x : null).ToList();
            int? maxActual = ZEnumerable.Max(source);
            int? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxintNullableList2ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (int?) r.Next(int.MaxValue), 2).Select(x=>x%2==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X =  x } ).ToList();
            int? maxActual = ZEnumerable.Max(source, arg => arg.X);
            int? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxintNullableList3()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (int?) r.Next(int.MaxValue), 3).ToList();
            int? maxActual = ZEnumerable.Max(source);
            int? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxintNullableList3Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (int?) r.Next(int.MaxValue) } , 3).ToList();
            int? maxActual = ZEnumerable.Max(source, arg => arg.X);
            int? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxintNullableList3ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (int?) r.Next(int.MaxValue), 3).Select(x=>x%2==0 ? x : null).ToList();
            int? maxActual = ZEnumerable.Max(source);
            int? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxintNullableList3ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (int?) r.Next(int.MaxValue), 3).Select(x=>x%2==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X =  x } ).ToList();
            int? maxActual = ZEnumerable.Max(source, arg => arg.X);
            int? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxintNullableList4()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (int?) r.Next(int.MaxValue), 4).ToList();
            int? maxActual = ZEnumerable.Max(source);
            int? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxintNullableList4Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (int?) r.Next(int.MaxValue) } , 4).ToList();
            int? maxActual = ZEnumerable.Max(source, arg => arg.X);
            int? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxintNullableList4ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (int?) r.Next(int.MaxValue), 4).Select(x=>x%2==0 ? x : null).ToList();
            int? maxActual = ZEnumerable.Max(source);
            int? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxintNullableList4ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (int?) r.Next(int.MaxValue), 4).Select(x=>x%2==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X =  x } ).ToList();
            int? maxActual = ZEnumerable.Max(source, arg => arg.X);
            int? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxintNullableList100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (int?) r.Next(int.MaxValue), 100).ToList();
            int? maxActual = ZEnumerable.Max(source);
            int? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxintNullableList100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (int?) r.Next(int.MaxValue) } , 100).ToList();
            int? maxActual = ZEnumerable.Max(source, arg => arg.X);
            int? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxintNullableList100ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (int?) r.Next(int.MaxValue), 100).Select(x=>x%2==0 ? x : null).ToList();
            int? maxActual = ZEnumerable.Max(source);
            int? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxintNullableList100ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (int?) r.Next(int.MaxValue), 100).Select(x=>x%2==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X =  x } ).ToList();
            int? maxActual = ZEnumerable.Max(source, arg => arg.X);
            int? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxintNullableList2048()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (int?) r.Next(int.MaxValue), 2048).ToList();
            int? maxActual = ZEnumerable.Max(source);
            int? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxintNullableList2048Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (int?) r.Next(int.MaxValue) } , 2048).ToList();
            int? maxActual = ZEnumerable.Max(source, arg => arg.X);
            int? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxintNullableList2048ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (int?) r.Next(int.MaxValue), 2048).Select(x=>x%2==0 ? x : null).ToList();
            int? maxActual = ZEnumerable.Max(source);
            int? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxintNullableList2048ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (int?) r.Next(int.MaxValue), 2048).Select(x=>x%2==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X =  x } ).ToList();
            int? maxActual = ZEnumerable.Max(source, arg => arg.X);
            int? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
            
        [TestMethod]
        public void TestMaxintNullableIListNullOrEmpty()
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

            IList<int?> emptySource = new int?[0].ToIList();
            try
            {
                ZEnumerable.Max(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestMaxintNullableIListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<int?,int?>((int?) arg, (int?) arg)).ToIList();
            Func<KeyValuePair<int?, int?>, int?> nullMap = null;
            try
            {
                ZEnumerable.Max(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToIList();
            try
            {
                ZEnumerable.Max(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Max(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

                     
                
        [TestMethod]
        public void TestMaxintNullableIList1()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (int?) r.Next(int.MaxValue), 1).ToIList();
            int? maxActual = ZEnumerable.Max(source);
            int? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxintNullableIList1Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (int?) r.Next(int.MaxValue) } , 1).ToIList();
            int? maxActual = ZEnumerable.Max(source, arg => arg.X);
            int? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxintNullableIList1ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (int?) r.Next(int.MaxValue), 1).Select(x=>x%2==0 ? x : null).ToIList();
            int? maxActual = ZEnumerable.Max(source);
            int? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxintNullableIList1ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (int?) r.Next(int.MaxValue), 1).Select(x=>x%2==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X =  x } ).ToIList();
            int? maxActual = ZEnumerable.Max(source, arg => arg.X);
            int? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxintNullableIList2()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (int?) r.Next(int.MaxValue), 2).ToIList();
            int? maxActual = ZEnumerable.Max(source);
            int? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxintNullableIList2Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (int?) r.Next(int.MaxValue) } , 2).ToIList();
            int? maxActual = ZEnumerable.Max(source, arg => arg.X);
            int? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxintNullableIList2ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (int?) r.Next(int.MaxValue), 2).Select(x=>x%2==0 ? x : null).ToIList();
            int? maxActual = ZEnumerable.Max(source);
            int? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxintNullableIList2ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (int?) r.Next(int.MaxValue), 2).Select(x=>x%2==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X =  x } ).ToIList();
            int? maxActual = ZEnumerable.Max(source, arg => arg.X);
            int? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxintNullableIList3()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (int?) r.Next(int.MaxValue), 3).ToIList();
            int? maxActual = ZEnumerable.Max(source);
            int? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxintNullableIList3Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (int?) r.Next(int.MaxValue) } , 3).ToIList();
            int? maxActual = ZEnumerable.Max(source, arg => arg.X);
            int? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxintNullableIList3ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (int?) r.Next(int.MaxValue), 3).Select(x=>x%2==0 ? x : null).ToIList();
            int? maxActual = ZEnumerable.Max(source);
            int? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxintNullableIList3ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (int?) r.Next(int.MaxValue), 3).Select(x=>x%2==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X =  x } ).ToIList();
            int? maxActual = ZEnumerable.Max(source, arg => arg.X);
            int? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxintNullableIList4()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (int?) r.Next(int.MaxValue), 4).ToIList();
            int? maxActual = ZEnumerable.Max(source);
            int? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxintNullableIList4Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (int?) r.Next(int.MaxValue) } , 4).ToIList();
            int? maxActual = ZEnumerable.Max(source, arg => arg.X);
            int? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxintNullableIList4ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (int?) r.Next(int.MaxValue), 4).Select(x=>x%2==0 ? x : null).ToIList();
            int? maxActual = ZEnumerable.Max(source);
            int? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxintNullableIList4ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (int?) r.Next(int.MaxValue), 4).Select(x=>x%2==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X =  x } ).ToIList();
            int? maxActual = ZEnumerable.Max(source, arg => arg.X);
            int? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxintNullableIList100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (int?) r.Next(int.MaxValue), 100).ToIList();
            int? maxActual = ZEnumerable.Max(source);
            int? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxintNullableIList100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (int?) r.Next(int.MaxValue) } , 100).ToIList();
            int? maxActual = ZEnumerable.Max(source, arg => arg.X);
            int? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxintNullableIList100ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (int?) r.Next(int.MaxValue), 100).Select(x=>x%2==0 ? x : null).ToIList();
            int? maxActual = ZEnumerable.Max(source);
            int? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxintNullableIList100ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (int?) r.Next(int.MaxValue), 100).Select(x=>x%2==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X =  x } ).ToIList();
            int? maxActual = ZEnumerable.Max(source, arg => arg.X);
            int? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxintNullableIList2048()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (int?) r.Next(int.MaxValue), 2048).ToIList();
            int? maxActual = ZEnumerable.Max(source);
            int? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxintNullableIList2048Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (int?) r.Next(int.MaxValue) } , 2048).ToIList();
            int? maxActual = ZEnumerable.Max(source, arg => arg.X);
            int? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxintNullableIList2048ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (int?) r.Next(int.MaxValue), 2048).Select(x=>x%2==0 ? x : null).ToIList();
            int? maxActual = ZEnumerable.Max(source);
            int? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxintNullableIList2048ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (int?) r.Next(int.MaxValue), 2048).Select(x=>x%2==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X =  x } ).ToIList();
            int? maxActual = ZEnumerable.Max(source, arg => arg.X);
            int? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                        
               
        #endregion

      

        #region uint? 
             
            
        [TestMethod]
        public void TestMaxuintNullableArrayNullOrEmpty()
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

            uint?[] emptySource = new uint?[0].ToArray();
            try
            {
                ZEnumerable.Max(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestMaxuintNullableArrayMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<uint?,uint?>((uint?) arg, (uint?) arg)).ToArray();
            Func<KeyValuePair<uint?, uint?>, uint?> nullMap = null;
            try
            {
                ZEnumerable.Max(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToArray();
            try
            {
                ZEnumerable.Max(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Max(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

                     
                
        [TestMethod]
        public void TestMaxuintNullableArray1()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (uint?) r.Next(int.MaxValue), 1).ToArray();
            uint? maxActual = ZEnumerable.Max(source);
            uint? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxuintNullableArray1Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (uint?) r.Next(int.MaxValue) } , 1).ToArray();
            uint? maxActual = ZEnumerable.Max(source, arg => arg.X);
            uint? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxuintNullableArray1ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (uint?) r.Next(int.MaxValue), 1).Select(x=>x%2==0 ? x : null).ToArray();
            uint? maxActual = ZEnumerable.Max(source);
            uint? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxuintNullableArray1ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (uint?) r.Next(int.MaxValue), 1).Select(x=>x%2==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X =  x } ).ToArray();
            uint? maxActual = ZEnumerable.Max(source, arg => arg.X);
            uint? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxuintNullableArray2()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (uint?) r.Next(int.MaxValue), 2).ToArray();
            uint? maxActual = ZEnumerable.Max(source);
            uint? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxuintNullableArray2Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (uint?) r.Next(int.MaxValue) } , 2).ToArray();
            uint? maxActual = ZEnumerable.Max(source, arg => arg.X);
            uint? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxuintNullableArray2ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (uint?) r.Next(int.MaxValue), 2).Select(x=>x%2==0 ? x : null).ToArray();
            uint? maxActual = ZEnumerable.Max(source);
            uint? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxuintNullableArray2ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (uint?) r.Next(int.MaxValue), 2).Select(x=>x%2==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X =  x } ).ToArray();
            uint? maxActual = ZEnumerable.Max(source, arg => arg.X);
            uint? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxuintNullableArray3()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (uint?) r.Next(int.MaxValue), 3).ToArray();
            uint? maxActual = ZEnumerable.Max(source);
            uint? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxuintNullableArray3Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (uint?) r.Next(int.MaxValue) } , 3).ToArray();
            uint? maxActual = ZEnumerable.Max(source, arg => arg.X);
            uint? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxuintNullableArray3ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (uint?) r.Next(int.MaxValue), 3).Select(x=>x%2==0 ? x : null).ToArray();
            uint? maxActual = ZEnumerable.Max(source);
            uint? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxuintNullableArray3ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (uint?) r.Next(int.MaxValue), 3).Select(x=>x%2==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X =  x } ).ToArray();
            uint? maxActual = ZEnumerable.Max(source, arg => arg.X);
            uint? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxuintNullableArray4()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (uint?) r.Next(int.MaxValue), 4).ToArray();
            uint? maxActual = ZEnumerable.Max(source);
            uint? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxuintNullableArray4Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (uint?) r.Next(int.MaxValue) } , 4).ToArray();
            uint? maxActual = ZEnumerable.Max(source, arg => arg.X);
            uint? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxuintNullableArray4ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (uint?) r.Next(int.MaxValue), 4).Select(x=>x%2==0 ? x : null).ToArray();
            uint? maxActual = ZEnumerable.Max(source);
            uint? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxuintNullableArray4ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (uint?) r.Next(int.MaxValue), 4).Select(x=>x%2==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X =  x } ).ToArray();
            uint? maxActual = ZEnumerable.Max(source, arg => arg.X);
            uint? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxuintNullableArray100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (uint?) r.Next(int.MaxValue), 100).ToArray();
            uint? maxActual = ZEnumerable.Max(source);
            uint? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxuintNullableArray100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (uint?) r.Next(int.MaxValue) } , 100).ToArray();
            uint? maxActual = ZEnumerable.Max(source, arg => arg.X);
            uint? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxuintNullableArray100ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (uint?) r.Next(int.MaxValue), 100).Select(x=>x%2==0 ? x : null).ToArray();
            uint? maxActual = ZEnumerable.Max(source);
            uint? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxuintNullableArray100ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (uint?) r.Next(int.MaxValue), 100).Select(x=>x%2==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X =  x } ).ToArray();
            uint? maxActual = ZEnumerable.Max(source, arg => arg.X);
            uint? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxuintNullableArray2048()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (uint?) r.Next(int.MaxValue), 2048).ToArray();
            uint? maxActual = ZEnumerable.Max(source);
            uint? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxuintNullableArray2048Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (uint?) r.Next(int.MaxValue) } , 2048).ToArray();
            uint? maxActual = ZEnumerable.Max(source, arg => arg.X);
            uint? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxuintNullableArray2048ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (uint?) r.Next(int.MaxValue), 2048).Select(x=>x%2==0 ? x : null).ToArray();
            uint? maxActual = ZEnumerable.Max(source);
            uint? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxuintNullableArray2048ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (uint?) r.Next(int.MaxValue), 2048).Select(x=>x%2==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X =  x } ).ToArray();
            uint? maxActual = ZEnumerable.Max(source, arg => arg.X);
            uint? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
            
        [TestMethod]
        public void TestMaxuintNullableListNullOrEmpty()
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

            List<uint?> emptySource = new uint?[0].ToList();
            try
            {
                ZEnumerable.Max(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestMaxuintNullableListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<uint?,uint?>((uint?) arg, (uint?) arg)).ToList();
            Func<KeyValuePair<uint?, uint?>, uint?> nullMap = null;
            try
            {
                ZEnumerable.Max(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToList();
            try
            {
                ZEnumerable.Max(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Max(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

                     
                
        [TestMethod]
        public void TestMaxuintNullableList1()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (uint?) r.Next(int.MaxValue), 1).ToList();
            uint? maxActual = ZEnumerable.Max(source);
            uint? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxuintNullableList1Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (uint?) r.Next(int.MaxValue) } , 1).ToList();
            uint? maxActual = ZEnumerable.Max(source, arg => arg.X);
            uint? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxuintNullableList1ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (uint?) r.Next(int.MaxValue), 1).Select(x=>x%2==0 ? x : null).ToList();
            uint? maxActual = ZEnumerable.Max(source);
            uint? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxuintNullableList1ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (uint?) r.Next(int.MaxValue), 1).Select(x=>x%2==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X =  x } ).ToList();
            uint? maxActual = ZEnumerable.Max(source, arg => arg.X);
            uint? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxuintNullableList2()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (uint?) r.Next(int.MaxValue), 2).ToList();
            uint? maxActual = ZEnumerable.Max(source);
            uint? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxuintNullableList2Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (uint?) r.Next(int.MaxValue) } , 2).ToList();
            uint? maxActual = ZEnumerable.Max(source, arg => arg.X);
            uint? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxuintNullableList2ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (uint?) r.Next(int.MaxValue), 2).Select(x=>x%2==0 ? x : null).ToList();
            uint? maxActual = ZEnumerable.Max(source);
            uint? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxuintNullableList2ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (uint?) r.Next(int.MaxValue), 2).Select(x=>x%2==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X =  x } ).ToList();
            uint? maxActual = ZEnumerable.Max(source, arg => arg.X);
            uint? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxuintNullableList3()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (uint?) r.Next(int.MaxValue), 3).ToList();
            uint? maxActual = ZEnumerable.Max(source);
            uint? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxuintNullableList3Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (uint?) r.Next(int.MaxValue) } , 3).ToList();
            uint? maxActual = ZEnumerable.Max(source, arg => arg.X);
            uint? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxuintNullableList3ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (uint?) r.Next(int.MaxValue), 3).Select(x=>x%2==0 ? x : null).ToList();
            uint? maxActual = ZEnumerable.Max(source);
            uint? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxuintNullableList3ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (uint?) r.Next(int.MaxValue), 3).Select(x=>x%2==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X =  x } ).ToList();
            uint? maxActual = ZEnumerable.Max(source, arg => arg.X);
            uint? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxuintNullableList4()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (uint?) r.Next(int.MaxValue), 4).ToList();
            uint? maxActual = ZEnumerable.Max(source);
            uint? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxuintNullableList4Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (uint?) r.Next(int.MaxValue) } , 4).ToList();
            uint? maxActual = ZEnumerable.Max(source, arg => arg.X);
            uint? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxuintNullableList4ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (uint?) r.Next(int.MaxValue), 4).Select(x=>x%2==0 ? x : null).ToList();
            uint? maxActual = ZEnumerable.Max(source);
            uint? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxuintNullableList4ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (uint?) r.Next(int.MaxValue), 4).Select(x=>x%2==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X =  x } ).ToList();
            uint? maxActual = ZEnumerable.Max(source, arg => arg.X);
            uint? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxuintNullableList100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (uint?) r.Next(int.MaxValue), 100).ToList();
            uint? maxActual = ZEnumerable.Max(source);
            uint? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxuintNullableList100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (uint?) r.Next(int.MaxValue) } , 100).ToList();
            uint? maxActual = ZEnumerable.Max(source, arg => arg.X);
            uint? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxuintNullableList100ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (uint?) r.Next(int.MaxValue), 100).Select(x=>x%2==0 ? x : null).ToList();
            uint? maxActual = ZEnumerable.Max(source);
            uint? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxuintNullableList100ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (uint?) r.Next(int.MaxValue), 100).Select(x=>x%2==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X =  x } ).ToList();
            uint? maxActual = ZEnumerable.Max(source, arg => arg.X);
            uint? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxuintNullableList2048()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (uint?) r.Next(int.MaxValue), 2048).ToList();
            uint? maxActual = ZEnumerable.Max(source);
            uint? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxuintNullableList2048Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (uint?) r.Next(int.MaxValue) } , 2048).ToList();
            uint? maxActual = ZEnumerable.Max(source, arg => arg.X);
            uint? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxuintNullableList2048ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (uint?) r.Next(int.MaxValue), 2048).Select(x=>x%2==0 ? x : null).ToList();
            uint? maxActual = ZEnumerable.Max(source);
            uint? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxuintNullableList2048ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (uint?) r.Next(int.MaxValue), 2048).Select(x=>x%2==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X =  x } ).ToList();
            uint? maxActual = ZEnumerable.Max(source, arg => arg.X);
            uint? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
            
        [TestMethod]
        public void TestMaxuintNullableIListNullOrEmpty()
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

            IList<uint?> emptySource = new uint?[0].ToIList();
            try
            {
                ZEnumerable.Max(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestMaxuintNullableIListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<uint?,uint?>((uint?) arg, (uint?) arg)).ToIList();
            Func<KeyValuePair<uint?, uint?>, uint?> nullMap = null;
            try
            {
                ZEnumerable.Max(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToIList();
            try
            {
                ZEnumerable.Max(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Max(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

                     
                
        [TestMethod]
        public void TestMaxuintNullableIList1()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (uint?) r.Next(int.MaxValue), 1).ToIList();
            uint? maxActual = ZEnumerable.Max(source);
            uint? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxuintNullableIList1Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (uint?) r.Next(int.MaxValue) } , 1).ToIList();
            uint? maxActual = ZEnumerable.Max(source, arg => arg.X);
            uint? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxuintNullableIList1ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (uint?) r.Next(int.MaxValue), 1).Select(x=>x%2==0 ? x : null).ToIList();
            uint? maxActual = ZEnumerable.Max(source);
            uint? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxuintNullableIList1ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (uint?) r.Next(int.MaxValue), 1).Select(x=>x%2==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X =  x } ).ToIList();
            uint? maxActual = ZEnumerable.Max(source, arg => arg.X);
            uint? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxuintNullableIList2()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (uint?) r.Next(int.MaxValue), 2).ToIList();
            uint? maxActual = ZEnumerable.Max(source);
            uint? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxuintNullableIList2Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (uint?) r.Next(int.MaxValue) } , 2).ToIList();
            uint? maxActual = ZEnumerable.Max(source, arg => arg.X);
            uint? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxuintNullableIList2ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (uint?) r.Next(int.MaxValue), 2).Select(x=>x%2==0 ? x : null).ToIList();
            uint? maxActual = ZEnumerable.Max(source);
            uint? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxuintNullableIList2ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (uint?) r.Next(int.MaxValue), 2).Select(x=>x%2==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X =  x } ).ToIList();
            uint? maxActual = ZEnumerable.Max(source, arg => arg.X);
            uint? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxuintNullableIList3()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (uint?) r.Next(int.MaxValue), 3).ToIList();
            uint? maxActual = ZEnumerable.Max(source);
            uint? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxuintNullableIList3Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (uint?) r.Next(int.MaxValue) } , 3).ToIList();
            uint? maxActual = ZEnumerable.Max(source, arg => arg.X);
            uint? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxuintNullableIList3ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (uint?) r.Next(int.MaxValue), 3).Select(x=>x%2==0 ? x : null).ToIList();
            uint? maxActual = ZEnumerable.Max(source);
            uint? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxuintNullableIList3ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (uint?) r.Next(int.MaxValue), 3).Select(x=>x%2==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X =  x } ).ToIList();
            uint? maxActual = ZEnumerable.Max(source, arg => arg.X);
            uint? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxuintNullableIList4()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (uint?) r.Next(int.MaxValue), 4).ToIList();
            uint? maxActual = ZEnumerable.Max(source);
            uint? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxuintNullableIList4Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (uint?) r.Next(int.MaxValue) } , 4).ToIList();
            uint? maxActual = ZEnumerable.Max(source, arg => arg.X);
            uint? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxuintNullableIList4ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (uint?) r.Next(int.MaxValue), 4).Select(x=>x%2==0 ? x : null).ToIList();
            uint? maxActual = ZEnumerable.Max(source);
            uint? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxuintNullableIList4ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (uint?) r.Next(int.MaxValue), 4).Select(x=>x%2==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X =  x } ).ToIList();
            uint? maxActual = ZEnumerable.Max(source, arg => arg.X);
            uint? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxuintNullableIList100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (uint?) r.Next(int.MaxValue), 100).ToIList();
            uint? maxActual = ZEnumerable.Max(source);
            uint? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxuintNullableIList100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (uint?) r.Next(int.MaxValue) } , 100).ToIList();
            uint? maxActual = ZEnumerable.Max(source, arg => arg.X);
            uint? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxuintNullableIList100ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (uint?) r.Next(int.MaxValue), 100).Select(x=>x%2==0 ? x : null).ToIList();
            uint? maxActual = ZEnumerable.Max(source);
            uint? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxuintNullableIList100ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (uint?) r.Next(int.MaxValue), 100).Select(x=>x%2==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X =  x } ).ToIList();
            uint? maxActual = ZEnumerable.Max(source, arg => arg.X);
            uint? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxuintNullableIList2048()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (uint?) r.Next(int.MaxValue), 2048).ToIList();
            uint? maxActual = ZEnumerable.Max(source);
            uint? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxuintNullableIList2048Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (uint?) r.Next(int.MaxValue) } , 2048).ToIList();
            uint? maxActual = ZEnumerable.Max(source, arg => arg.X);
            uint? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxuintNullableIList2048ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (uint?) r.Next(int.MaxValue), 2048).Select(x=>x%2==0 ? x : null).ToIList();
            uint? maxActual = ZEnumerable.Max(source);
            uint? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxuintNullableIList2048ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (uint?) r.Next(int.MaxValue), 2048).Select(x=>x%2==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X =  x } ).ToIList();
            uint? maxActual = ZEnumerable.Max(source, arg => arg.X);
            uint? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                        
               
        #endregion

      

        #region long? 
             
            
        [TestMethod]
        public void TestMaxlongNullableArrayNullOrEmpty()
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

            long?[] emptySource = new long?[0].ToArray();
            try
            {
                ZEnumerable.Max(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestMaxlongNullableArrayMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<long?,long?>((long?) arg, (long?) arg)).ToArray();
            Func<KeyValuePair<long?, long?>, long?> nullMap = null;
            try
            {
                ZEnumerable.Max(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToArray();
            try
            {
                ZEnumerable.Max(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Max(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

                     
                
        [TestMethod]
        public void TestMaxlongNullableArray1()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (long?) r.Next(int.MaxValue), 1).ToArray();
            long? maxActual = ZEnumerable.Max(source);
            long? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxlongNullableArray1Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (long?) r.Next(int.MaxValue) } , 1).ToArray();
            long? maxActual = ZEnumerable.Max(source, arg => arg.X);
            long? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxlongNullableArray1ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (long?) r.Next(int.MaxValue), 1).Select(x=>x%2==0 ? x : null).ToArray();
            long? maxActual = ZEnumerable.Max(source);
            long? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxlongNullableArray1ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (long?) r.Next(int.MaxValue), 1).Select(x=>x%2==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X =  x } ).ToArray();
            long? maxActual = ZEnumerable.Max(source, arg => arg.X);
            long? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxlongNullableArray2()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (long?) r.Next(int.MaxValue), 2).ToArray();
            long? maxActual = ZEnumerable.Max(source);
            long? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxlongNullableArray2Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (long?) r.Next(int.MaxValue) } , 2).ToArray();
            long? maxActual = ZEnumerable.Max(source, arg => arg.X);
            long? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxlongNullableArray2ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (long?) r.Next(int.MaxValue), 2).Select(x=>x%2==0 ? x : null).ToArray();
            long? maxActual = ZEnumerable.Max(source);
            long? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxlongNullableArray2ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (long?) r.Next(int.MaxValue), 2).Select(x=>x%2==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X =  x } ).ToArray();
            long? maxActual = ZEnumerable.Max(source, arg => arg.X);
            long? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxlongNullableArray3()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (long?) r.Next(int.MaxValue), 3).ToArray();
            long? maxActual = ZEnumerable.Max(source);
            long? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxlongNullableArray3Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (long?) r.Next(int.MaxValue) } , 3).ToArray();
            long? maxActual = ZEnumerable.Max(source, arg => arg.X);
            long? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxlongNullableArray3ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (long?) r.Next(int.MaxValue), 3).Select(x=>x%2==0 ? x : null).ToArray();
            long? maxActual = ZEnumerable.Max(source);
            long? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxlongNullableArray3ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (long?) r.Next(int.MaxValue), 3).Select(x=>x%2==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X =  x } ).ToArray();
            long? maxActual = ZEnumerable.Max(source, arg => arg.X);
            long? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxlongNullableArray4()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (long?) r.Next(int.MaxValue), 4).ToArray();
            long? maxActual = ZEnumerable.Max(source);
            long? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxlongNullableArray4Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (long?) r.Next(int.MaxValue) } , 4).ToArray();
            long? maxActual = ZEnumerable.Max(source, arg => arg.X);
            long? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxlongNullableArray4ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (long?) r.Next(int.MaxValue), 4).Select(x=>x%2==0 ? x : null).ToArray();
            long? maxActual = ZEnumerable.Max(source);
            long? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxlongNullableArray4ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (long?) r.Next(int.MaxValue), 4).Select(x=>x%2==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X =  x } ).ToArray();
            long? maxActual = ZEnumerable.Max(source, arg => arg.X);
            long? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxlongNullableArray100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (long?) r.Next(int.MaxValue), 100).ToArray();
            long? maxActual = ZEnumerable.Max(source);
            long? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxlongNullableArray100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (long?) r.Next(int.MaxValue) } , 100).ToArray();
            long? maxActual = ZEnumerable.Max(source, arg => arg.X);
            long? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxlongNullableArray100ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (long?) r.Next(int.MaxValue), 100).Select(x=>x%2==0 ? x : null).ToArray();
            long? maxActual = ZEnumerable.Max(source);
            long? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxlongNullableArray100ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (long?) r.Next(int.MaxValue), 100).Select(x=>x%2==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X =  x } ).ToArray();
            long? maxActual = ZEnumerable.Max(source, arg => arg.X);
            long? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxlongNullableArray2048()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (long?) r.Next(int.MaxValue), 2048).ToArray();
            long? maxActual = ZEnumerable.Max(source);
            long? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxlongNullableArray2048Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (long?) r.Next(int.MaxValue) } , 2048).ToArray();
            long? maxActual = ZEnumerable.Max(source, arg => arg.X);
            long? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxlongNullableArray2048ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (long?) r.Next(int.MaxValue), 2048).Select(x=>x%2==0 ? x : null).ToArray();
            long? maxActual = ZEnumerable.Max(source);
            long? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxlongNullableArray2048ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (long?) r.Next(int.MaxValue), 2048).Select(x=>x%2==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X =  x } ).ToArray();
            long? maxActual = ZEnumerable.Max(source, arg => arg.X);
            long? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
            
        [TestMethod]
        public void TestMaxlongNullableListNullOrEmpty()
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

            List<long?> emptySource = new long?[0].ToList();
            try
            {
                ZEnumerable.Max(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestMaxlongNullableListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<long?,long?>((long?) arg, (long?) arg)).ToList();
            Func<KeyValuePair<long?, long?>, long?> nullMap = null;
            try
            {
                ZEnumerable.Max(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToList();
            try
            {
                ZEnumerable.Max(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Max(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

                     
                
        [TestMethod]
        public void TestMaxlongNullableList1()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (long?) r.Next(int.MaxValue), 1).ToList();
            long? maxActual = ZEnumerable.Max(source);
            long? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxlongNullableList1Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (long?) r.Next(int.MaxValue) } , 1).ToList();
            long? maxActual = ZEnumerable.Max(source, arg => arg.X);
            long? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxlongNullableList1ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (long?) r.Next(int.MaxValue), 1).Select(x=>x%2==0 ? x : null).ToList();
            long? maxActual = ZEnumerable.Max(source);
            long? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxlongNullableList1ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (long?) r.Next(int.MaxValue), 1).Select(x=>x%2==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X =  x } ).ToList();
            long? maxActual = ZEnumerable.Max(source, arg => arg.X);
            long? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxlongNullableList2()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (long?) r.Next(int.MaxValue), 2).ToList();
            long? maxActual = ZEnumerable.Max(source);
            long? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxlongNullableList2Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (long?) r.Next(int.MaxValue) } , 2).ToList();
            long? maxActual = ZEnumerable.Max(source, arg => arg.X);
            long? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxlongNullableList2ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (long?) r.Next(int.MaxValue), 2).Select(x=>x%2==0 ? x : null).ToList();
            long? maxActual = ZEnumerable.Max(source);
            long? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxlongNullableList2ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (long?) r.Next(int.MaxValue), 2).Select(x=>x%2==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X =  x } ).ToList();
            long? maxActual = ZEnumerable.Max(source, arg => arg.X);
            long? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxlongNullableList3()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (long?) r.Next(int.MaxValue), 3).ToList();
            long? maxActual = ZEnumerable.Max(source);
            long? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxlongNullableList3Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (long?) r.Next(int.MaxValue) } , 3).ToList();
            long? maxActual = ZEnumerable.Max(source, arg => arg.X);
            long? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxlongNullableList3ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (long?) r.Next(int.MaxValue), 3).Select(x=>x%2==0 ? x : null).ToList();
            long? maxActual = ZEnumerable.Max(source);
            long? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxlongNullableList3ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (long?) r.Next(int.MaxValue), 3).Select(x=>x%2==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X =  x } ).ToList();
            long? maxActual = ZEnumerable.Max(source, arg => arg.X);
            long? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxlongNullableList4()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (long?) r.Next(int.MaxValue), 4).ToList();
            long? maxActual = ZEnumerable.Max(source);
            long? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxlongNullableList4Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (long?) r.Next(int.MaxValue) } , 4).ToList();
            long? maxActual = ZEnumerable.Max(source, arg => arg.X);
            long? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxlongNullableList4ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (long?) r.Next(int.MaxValue), 4).Select(x=>x%2==0 ? x : null).ToList();
            long? maxActual = ZEnumerable.Max(source);
            long? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxlongNullableList4ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (long?) r.Next(int.MaxValue), 4).Select(x=>x%2==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X =  x } ).ToList();
            long? maxActual = ZEnumerable.Max(source, arg => arg.X);
            long? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxlongNullableList100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (long?) r.Next(int.MaxValue), 100).ToList();
            long? maxActual = ZEnumerable.Max(source);
            long? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxlongNullableList100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (long?) r.Next(int.MaxValue) } , 100).ToList();
            long? maxActual = ZEnumerable.Max(source, arg => arg.X);
            long? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxlongNullableList100ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (long?) r.Next(int.MaxValue), 100).Select(x=>x%2==0 ? x : null).ToList();
            long? maxActual = ZEnumerable.Max(source);
            long? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxlongNullableList100ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (long?) r.Next(int.MaxValue), 100).Select(x=>x%2==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X =  x } ).ToList();
            long? maxActual = ZEnumerable.Max(source, arg => arg.X);
            long? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxlongNullableList2048()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (long?) r.Next(int.MaxValue), 2048).ToList();
            long? maxActual = ZEnumerable.Max(source);
            long? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxlongNullableList2048Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (long?) r.Next(int.MaxValue) } , 2048).ToList();
            long? maxActual = ZEnumerable.Max(source, arg => arg.X);
            long? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxlongNullableList2048ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (long?) r.Next(int.MaxValue), 2048).Select(x=>x%2==0 ? x : null).ToList();
            long? maxActual = ZEnumerable.Max(source);
            long? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxlongNullableList2048ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (long?) r.Next(int.MaxValue), 2048).Select(x=>x%2==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X =  x } ).ToList();
            long? maxActual = ZEnumerable.Max(source, arg => arg.X);
            long? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
            
        [TestMethod]
        public void TestMaxlongNullableIListNullOrEmpty()
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

            IList<long?> emptySource = new long?[0].ToIList();
            try
            {
                ZEnumerable.Max(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestMaxlongNullableIListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<long?,long?>((long?) arg, (long?) arg)).ToIList();
            Func<KeyValuePair<long?, long?>, long?> nullMap = null;
            try
            {
                ZEnumerable.Max(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToIList();
            try
            {
                ZEnumerable.Max(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Max(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

                     
                
        [TestMethod]
        public void TestMaxlongNullableIList1()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (long?) r.Next(int.MaxValue), 1).ToIList();
            long? maxActual = ZEnumerable.Max(source);
            long? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxlongNullableIList1Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (long?) r.Next(int.MaxValue) } , 1).ToIList();
            long? maxActual = ZEnumerable.Max(source, arg => arg.X);
            long? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxlongNullableIList1ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (long?) r.Next(int.MaxValue), 1).Select(x=>x%2==0 ? x : null).ToIList();
            long? maxActual = ZEnumerable.Max(source);
            long? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxlongNullableIList1ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (long?) r.Next(int.MaxValue), 1).Select(x=>x%2==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X =  x } ).ToIList();
            long? maxActual = ZEnumerable.Max(source, arg => arg.X);
            long? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxlongNullableIList2()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (long?) r.Next(int.MaxValue), 2).ToIList();
            long? maxActual = ZEnumerable.Max(source);
            long? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxlongNullableIList2Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (long?) r.Next(int.MaxValue) } , 2).ToIList();
            long? maxActual = ZEnumerable.Max(source, arg => arg.X);
            long? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxlongNullableIList2ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (long?) r.Next(int.MaxValue), 2).Select(x=>x%2==0 ? x : null).ToIList();
            long? maxActual = ZEnumerable.Max(source);
            long? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxlongNullableIList2ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (long?) r.Next(int.MaxValue), 2).Select(x=>x%2==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X =  x } ).ToIList();
            long? maxActual = ZEnumerable.Max(source, arg => arg.X);
            long? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxlongNullableIList3()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (long?) r.Next(int.MaxValue), 3).ToIList();
            long? maxActual = ZEnumerable.Max(source);
            long? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxlongNullableIList3Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (long?) r.Next(int.MaxValue) } , 3).ToIList();
            long? maxActual = ZEnumerable.Max(source, arg => arg.X);
            long? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxlongNullableIList3ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (long?) r.Next(int.MaxValue), 3).Select(x=>x%2==0 ? x : null).ToIList();
            long? maxActual = ZEnumerable.Max(source);
            long? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxlongNullableIList3ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (long?) r.Next(int.MaxValue), 3).Select(x=>x%2==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X =  x } ).ToIList();
            long? maxActual = ZEnumerable.Max(source, arg => arg.X);
            long? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxlongNullableIList4()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (long?) r.Next(int.MaxValue), 4).ToIList();
            long? maxActual = ZEnumerable.Max(source);
            long? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxlongNullableIList4Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (long?) r.Next(int.MaxValue) } , 4).ToIList();
            long? maxActual = ZEnumerable.Max(source, arg => arg.X);
            long? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxlongNullableIList4ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (long?) r.Next(int.MaxValue), 4).Select(x=>x%2==0 ? x : null).ToIList();
            long? maxActual = ZEnumerable.Max(source);
            long? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxlongNullableIList4ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (long?) r.Next(int.MaxValue), 4).Select(x=>x%2==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X =  x } ).ToIList();
            long? maxActual = ZEnumerable.Max(source, arg => arg.X);
            long? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxlongNullableIList100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (long?) r.Next(int.MaxValue), 100).ToIList();
            long? maxActual = ZEnumerable.Max(source);
            long? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxlongNullableIList100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (long?) r.Next(int.MaxValue) } , 100).ToIList();
            long? maxActual = ZEnumerable.Max(source, arg => arg.X);
            long? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxlongNullableIList100ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (long?) r.Next(int.MaxValue), 100).Select(x=>x%2==0 ? x : null).ToIList();
            long? maxActual = ZEnumerable.Max(source);
            long? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxlongNullableIList100ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (long?) r.Next(int.MaxValue), 100).Select(x=>x%2==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X =  x } ).ToIList();
            long? maxActual = ZEnumerable.Max(source, arg => arg.X);
            long? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxlongNullableIList2048()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (long?) r.Next(int.MaxValue), 2048).ToIList();
            long? maxActual = ZEnumerable.Max(source);
            long? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxlongNullableIList2048Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (long?) r.Next(int.MaxValue) } , 2048).ToIList();
            long? maxActual = ZEnumerable.Max(source, arg => arg.X);
            long? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxlongNullableIList2048ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (long?) r.Next(int.MaxValue), 2048).Select(x=>x%2==0 ? x : null).ToIList();
            long? maxActual = ZEnumerable.Max(source);
            long? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxlongNullableIList2048ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (long?) r.Next(int.MaxValue), 2048).Select(x=>x%2==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X =  x } ).ToIList();
            long? maxActual = ZEnumerable.Max(source, arg => arg.X);
            long? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                        
               
        #endregion

      

        #region ulong? 
             
            
        [TestMethod]
        public void TestMaxulongNullableArrayNullOrEmpty()
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

            ulong?[] emptySource = new ulong?[0].ToArray();
            try
            {
                ZEnumerable.Max(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestMaxulongNullableArrayMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<ulong?,ulong?>((ulong?) arg, (ulong?) arg)).ToArray();
            Func<KeyValuePair<ulong?, ulong?>, ulong?> nullMap = null;
            try
            {
                ZEnumerable.Max(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToArray();
            try
            {
                ZEnumerable.Max(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Max(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

                     
                
        [TestMethod]
        public void TestMaxulongNullableArray1()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ulong?) r.Next(int.MaxValue), 1).ToArray();
            ulong? maxActual = ZEnumerable.Max(source);
            ulong? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxulongNullableArray1Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ulong?) r.Next(int.MaxValue) } , 1).ToArray();
            ulong? maxActual = ZEnumerable.Max(source, arg => arg.X);
            ulong? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxulongNullableArray1ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ulong?) r.Next(int.MaxValue), 1).Select(x=>x%2==0 ? x : null).ToArray();
            ulong? maxActual = ZEnumerable.Max(source);
            ulong? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxulongNullableArray1ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (ulong?) r.Next(int.MaxValue), 1).Select(x=>x%2==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X =  x } ).ToArray();
            ulong? maxActual = ZEnumerable.Max(source, arg => arg.X);
            ulong? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxulongNullableArray2()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ulong?) r.Next(int.MaxValue), 2).ToArray();
            ulong? maxActual = ZEnumerable.Max(source);
            ulong? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxulongNullableArray2Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ulong?) r.Next(int.MaxValue) } , 2).ToArray();
            ulong? maxActual = ZEnumerable.Max(source, arg => arg.X);
            ulong? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxulongNullableArray2ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ulong?) r.Next(int.MaxValue), 2).Select(x=>x%2==0 ? x : null).ToArray();
            ulong? maxActual = ZEnumerable.Max(source);
            ulong? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxulongNullableArray2ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (ulong?) r.Next(int.MaxValue), 2).Select(x=>x%2==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X =  x } ).ToArray();
            ulong? maxActual = ZEnumerable.Max(source, arg => arg.X);
            ulong? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxulongNullableArray3()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ulong?) r.Next(int.MaxValue), 3).ToArray();
            ulong? maxActual = ZEnumerable.Max(source);
            ulong? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxulongNullableArray3Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ulong?) r.Next(int.MaxValue) } , 3).ToArray();
            ulong? maxActual = ZEnumerable.Max(source, arg => arg.X);
            ulong? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxulongNullableArray3ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ulong?) r.Next(int.MaxValue), 3).Select(x=>x%2==0 ? x : null).ToArray();
            ulong? maxActual = ZEnumerable.Max(source);
            ulong? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxulongNullableArray3ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (ulong?) r.Next(int.MaxValue), 3).Select(x=>x%2==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X =  x } ).ToArray();
            ulong? maxActual = ZEnumerable.Max(source, arg => arg.X);
            ulong? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxulongNullableArray4()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ulong?) r.Next(int.MaxValue), 4).ToArray();
            ulong? maxActual = ZEnumerable.Max(source);
            ulong? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxulongNullableArray4Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ulong?) r.Next(int.MaxValue) } , 4).ToArray();
            ulong? maxActual = ZEnumerable.Max(source, arg => arg.X);
            ulong? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxulongNullableArray4ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ulong?) r.Next(int.MaxValue), 4).Select(x=>x%2==0 ? x : null).ToArray();
            ulong? maxActual = ZEnumerable.Max(source);
            ulong? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxulongNullableArray4ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (ulong?) r.Next(int.MaxValue), 4).Select(x=>x%2==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X =  x } ).ToArray();
            ulong? maxActual = ZEnumerable.Max(source, arg => arg.X);
            ulong? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxulongNullableArray100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ulong?) r.Next(int.MaxValue), 100).ToArray();
            ulong? maxActual = ZEnumerable.Max(source);
            ulong? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxulongNullableArray100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ulong?) r.Next(int.MaxValue) } , 100).ToArray();
            ulong? maxActual = ZEnumerable.Max(source, arg => arg.X);
            ulong? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxulongNullableArray100ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ulong?) r.Next(int.MaxValue), 100).Select(x=>x%2==0 ? x : null).ToArray();
            ulong? maxActual = ZEnumerable.Max(source);
            ulong? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxulongNullableArray100ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (ulong?) r.Next(int.MaxValue), 100).Select(x=>x%2==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X =  x } ).ToArray();
            ulong? maxActual = ZEnumerable.Max(source, arg => arg.X);
            ulong? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxulongNullableArray2048()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ulong?) r.Next(int.MaxValue), 2048).ToArray();
            ulong? maxActual = ZEnumerable.Max(source);
            ulong? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxulongNullableArray2048Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ulong?) r.Next(int.MaxValue) } , 2048).ToArray();
            ulong? maxActual = ZEnumerable.Max(source, arg => arg.X);
            ulong? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxulongNullableArray2048ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ulong?) r.Next(int.MaxValue), 2048).Select(x=>x%2==0 ? x : null).ToArray();
            ulong? maxActual = ZEnumerable.Max(source);
            ulong? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxulongNullableArray2048ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (ulong?) r.Next(int.MaxValue), 2048).Select(x=>x%2==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X =  x } ).ToArray();
            ulong? maxActual = ZEnumerable.Max(source, arg => arg.X);
            ulong? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
            
        [TestMethod]
        public void TestMaxulongNullableListNullOrEmpty()
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

            List<ulong?> emptySource = new ulong?[0].ToList();
            try
            {
                ZEnumerable.Max(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestMaxulongNullableListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<ulong?,ulong?>((ulong?) arg, (ulong?) arg)).ToList();
            Func<KeyValuePair<ulong?, ulong?>, ulong?> nullMap = null;
            try
            {
                ZEnumerable.Max(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToList();
            try
            {
                ZEnumerable.Max(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Max(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

                     
                
        [TestMethod]
        public void TestMaxulongNullableList1()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ulong?) r.Next(int.MaxValue), 1).ToList();
            ulong? maxActual = ZEnumerable.Max(source);
            ulong? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxulongNullableList1Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ulong?) r.Next(int.MaxValue) } , 1).ToList();
            ulong? maxActual = ZEnumerable.Max(source, arg => arg.X);
            ulong? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxulongNullableList1ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ulong?) r.Next(int.MaxValue), 1).Select(x=>x%2==0 ? x : null).ToList();
            ulong? maxActual = ZEnumerable.Max(source);
            ulong? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxulongNullableList1ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (ulong?) r.Next(int.MaxValue), 1).Select(x=>x%2==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X =  x } ).ToList();
            ulong? maxActual = ZEnumerable.Max(source, arg => arg.X);
            ulong? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxulongNullableList2()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ulong?) r.Next(int.MaxValue), 2).ToList();
            ulong? maxActual = ZEnumerable.Max(source);
            ulong? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxulongNullableList2Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ulong?) r.Next(int.MaxValue) } , 2).ToList();
            ulong? maxActual = ZEnumerable.Max(source, arg => arg.X);
            ulong? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxulongNullableList2ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ulong?) r.Next(int.MaxValue), 2).Select(x=>x%2==0 ? x : null).ToList();
            ulong? maxActual = ZEnumerable.Max(source);
            ulong? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxulongNullableList2ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (ulong?) r.Next(int.MaxValue), 2).Select(x=>x%2==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X =  x } ).ToList();
            ulong? maxActual = ZEnumerable.Max(source, arg => arg.X);
            ulong? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxulongNullableList3()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ulong?) r.Next(int.MaxValue), 3).ToList();
            ulong? maxActual = ZEnumerable.Max(source);
            ulong? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxulongNullableList3Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ulong?) r.Next(int.MaxValue) } , 3).ToList();
            ulong? maxActual = ZEnumerable.Max(source, arg => arg.X);
            ulong? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxulongNullableList3ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ulong?) r.Next(int.MaxValue), 3).Select(x=>x%2==0 ? x : null).ToList();
            ulong? maxActual = ZEnumerable.Max(source);
            ulong? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxulongNullableList3ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (ulong?) r.Next(int.MaxValue), 3).Select(x=>x%2==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X =  x } ).ToList();
            ulong? maxActual = ZEnumerable.Max(source, arg => arg.X);
            ulong? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxulongNullableList4()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ulong?) r.Next(int.MaxValue), 4).ToList();
            ulong? maxActual = ZEnumerable.Max(source);
            ulong? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxulongNullableList4Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ulong?) r.Next(int.MaxValue) } , 4).ToList();
            ulong? maxActual = ZEnumerable.Max(source, arg => arg.X);
            ulong? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxulongNullableList4ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ulong?) r.Next(int.MaxValue), 4).Select(x=>x%2==0 ? x : null).ToList();
            ulong? maxActual = ZEnumerable.Max(source);
            ulong? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxulongNullableList4ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (ulong?) r.Next(int.MaxValue), 4).Select(x=>x%2==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X =  x } ).ToList();
            ulong? maxActual = ZEnumerable.Max(source, arg => arg.X);
            ulong? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxulongNullableList100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ulong?) r.Next(int.MaxValue), 100).ToList();
            ulong? maxActual = ZEnumerable.Max(source);
            ulong? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxulongNullableList100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ulong?) r.Next(int.MaxValue) } , 100).ToList();
            ulong? maxActual = ZEnumerable.Max(source, arg => arg.X);
            ulong? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxulongNullableList100ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ulong?) r.Next(int.MaxValue), 100).Select(x=>x%2==0 ? x : null).ToList();
            ulong? maxActual = ZEnumerable.Max(source);
            ulong? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxulongNullableList100ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (ulong?) r.Next(int.MaxValue), 100).Select(x=>x%2==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X =  x } ).ToList();
            ulong? maxActual = ZEnumerable.Max(source, arg => arg.X);
            ulong? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxulongNullableList2048()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ulong?) r.Next(int.MaxValue), 2048).ToList();
            ulong? maxActual = ZEnumerable.Max(source);
            ulong? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxulongNullableList2048Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ulong?) r.Next(int.MaxValue) } , 2048).ToList();
            ulong? maxActual = ZEnumerable.Max(source, arg => arg.X);
            ulong? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxulongNullableList2048ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ulong?) r.Next(int.MaxValue), 2048).Select(x=>x%2==0 ? x : null).ToList();
            ulong? maxActual = ZEnumerable.Max(source);
            ulong? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxulongNullableList2048ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (ulong?) r.Next(int.MaxValue), 2048).Select(x=>x%2==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X =  x } ).ToList();
            ulong? maxActual = ZEnumerable.Max(source, arg => arg.X);
            ulong? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
            
        [TestMethod]
        public void TestMaxulongNullableIListNullOrEmpty()
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

            IList<ulong?> emptySource = new ulong?[0].ToIList();
            try
            {
                ZEnumerable.Max(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestMaxulongNullableIListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<ulong?,ulong?>((ulong?) arg, (ulong?) arg)).ToIList();
            Func<KeyValuePair<ulong?, ulong?>, ulong?> nullMap = null;
            try
            {
                ZEnumerable.Max(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToIList();
            try
            {
                ZEnumerable.Max(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Max(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

                     
                
        [TestMethod]
        public void TestMaxulongNullableIList1()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ulong?) r.Next(int.MaxValue), 1).ToIList();
            ulong? maxActual = ZEnumerable.Max(source);
            ulong? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxulongNullableIList1Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ulong?) r.Next(int.MaxValue) } , 1).ToIList();
            ulong? maxActual = ZEnumerable.Max(source, arg => arg.X);
            ulong? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxulongNullableIList1ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ulong?) r.Next(int.MaxValue), 1).Select(x=>x%2==0 ? x : null).ToIList();
            ulong? maxActual = ZEnumerable.Max(source);
            ulong? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxulongNullableIList1ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (ulong?) r.Next(int.MaxValue), 1).Select(x=>x%2==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X =  x } ).ToIList();
            ulong? maxActual = ZEnumerable.Max(source, arg => arg.X);
            ulong? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxulongNullableIList2()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ulong?) r.Next(int.MaxValue), 2).ToIList();
            ulong? maxActual = ZEnumerable.Max(source);
            ulong? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxulongNullableIList2Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ulong?) r.Next(int.MaxValue) } , 2).ToIList();
            ulong? maxActual = ZEnumerable.Max(source, arg => arg.X);
            ulong? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxulongNullableIList2ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ulong?) r.Next(int.MaxValue), 2).Select(x=>x%2==0 ? x : null).ToIList();
            ulong? maxActual = ZEnumerable.Max(source);
            ulong? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxulongNullableIList2ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (ulong?) r.Next(int.MaxValue), 2).Select(x=>x%2==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X =  x } ).ToIList();
            ulong? maxActual = ZEnumerable.Max(source, arg => arg.X);
            ulong? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxulongNullableIList3()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ulong?) r.Next(int.MaxValue), 3).ToIList();
            ulong? maxActual = ZEnumerable.Max(source);
            ulong? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxulongNullableIList3Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ulong?) r.Next(int.MaxValue) } , 3).ToIList();
            ulong? maxActual = ZEnumerable.Max(source, arg => arg.X);
            ulong? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxulongNullableIList3ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ulong?) r.Next(int.MaxValue), 3).Select(x=>x%2==0 ? x : null).ToIList();
            ulong? maxActual = ZEnumerable.Max(source);
            ulong? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxulongNullableIList3ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (ulong?) r.Next(int.MaxValue), 3).Select(x=>x%2==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X =  x } ).ToIList();
            ulong? maxActual = ZEnumerable.Max(source, arg => arg.X);
            ulong? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxulongNullableIList4()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ulong?) r.Next(int.MaxValue), 4).ToIList();
            ulong? maxActual = ZEnumerable.Max(source);
            ulong? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxulongNullableIList4Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ulong?) r.Next(int.MaxValue) } , 4).ToIList();
            ulong? maxActual = ZEnumerable.Max(source, arg => arg.X);
            ulong? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxulongNullableIList4ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ulong?) r.Next(int.MaxValue), 4).Select(x=>x%2==0 ? x : null).ToIList();
            ulong? maxActual = ZEnumerable.Max(source);
            ulong? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxulongNullableIList4ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (ulong?) r.Next(int.MaxValue), 4).Select(x=>x%2==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X =  x } ).ToIList();
            ulong? maxActual = ZEnumerable.Max(source, arg => arg.X);
            ulong? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxulongNullableIList100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ulong?) r.Next(int.MaxValue), 100).ToIList();
            ulong? maxActual = ZEnumerable.Max(source);
            ulong? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxulongNullableIList100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ulong?) r.Next(int.MaxValue) } , 100).ToIList();
            ulong? maxActual = ZEnumerable.Max(source, arg => arg.X);
            ulong? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxulongNullableIList100ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ulong?) r.Next(int.MaxValue), 100).Select(x=>x%2==0 ? x : null).ToIList();
            ulong? maxActual = ZEnumerable.Max(source);
            ulong? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxulongNullableIList100ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (ulong?) r.Next(int.MaxValue), 100).Select(x=>x%2==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X =  x } ).ToIList();
            ulong? maxActual = ZEnumerable.Max(source, arg => arg.X);
            ulong? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxulongNullableIList2048()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ulong?) r.Next(int.MaxValue), 2048).ToIList();
            ulong? maxActual = ZEnumerable.Max(source);
            ulong? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxulongNullableIList2048Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (ulong?) r.Next(int.MaxValue) } , 2048).ToIList();
            ulong? maxActual = ZEnumerable.Max(source, arg => arg.X);
            ulong? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxulongNullableIList2048ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (ulong?) r.Next(int.MaxValue), 2048).Select(x=>x%2==0 ? x : null).ToIList();
            ulong? maxActual = ZEnumerable.Max(source);
            ulong? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxulongNullableIList2048ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (ulong?) r.Next(int.MaxValue), 2048).Select(x=>x%2==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X =  x } ).ToIList();
            ulong? maxActual = ZEnumerable.Max(source, arg => arg.X);
            ulong? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                        
               
        #endregion

      

        #region float? 
             
            
        [TestMethod]
        public void TestMaxfloatNullableArrayNullOrEmpty()
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

            float?[] emptySource = new float?[0].ToArray();
            try
            {
                ZEnumerable.Max(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestMaxfloatNullableArrayMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<float?,float?>((float?) arg, (float?) arg)).ToArray();
            Func<KeyValuePair<float?, float?>, float?> nullMap = null;
            try
            {
                ZEnumerable.Max(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToArray();
            try
            {
                ZEnumerable.Max(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Max(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

                     
                
        [TestMethod]
        public void TestMaxfloatNullableArray1()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (float?) r.Next(int.MaxValue), 1).ToArray();
            float? maxActual = ZEnumerable.Max(source);
            float? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxfloatNullableArray1Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (float?) r.Next(int.MaxValue) } , 1).ToArray();
            float? maxActual = ZEnumerable.Max(source, arg => arg.X);
            float? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxfloatNullableArray1ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (float?) r.Next(int.MaxValue), 1).Select(x=>x%2==0 ? x : null).ToArray();
            float? maxActual = ZEnumerable.Max(source);
            float? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxfloatNullableArray1ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (float?) r.Next(int.MaxValue), 1).Select(x=>x%2==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X =  x } ).ToArray();
            float? maxActual = ZEnumerable.Max(source, arg => arg.X);
            float? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxfloatNullableArray2()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (float?) r.Next(int.MaxValue), 2).ToArray();
            float? maxActual = ZEnumerable.Max(source);
            float? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxfloatNullableArray2Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (float?) r.Next(int.MaxValue) } , 2).ToArray();
            float? maxActual = ZEnumerable.Max(source, arg => arg.X);
            float? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxfloatNullableArray2ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (float?) r.Next(int.MaxValue), 2).Select(x=>x%2==0 ? x : null).ToArray();
            float? maxActual = ZEnumerable.Max(source);
            float? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxfloatNullableArray2ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (float?) r.Next(int.MaxValue), 2).Select(x=>x%2==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X =  x } ).ToArray();
            float? maxActual = ZEnumerable.Max(source, arg => arg.X);
            float? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxfloatNullableArray3()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (float?) r.Next(int.MaxValue), 3).ToArray();
            float? maxActual = ZEnumerable.Max(source);
            float? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxfloatNullableArray3Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (float?) r.Next(int.MaxValue) } , 3).ToArray();
            float? maxActual = ZEnumerable.Max(source, arg => arg.X);
            float? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxfloatNullableArray3ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (float?) r.Next(int.MaxValue), 3).Select(x=>x%2==0 ? x : null).ToArray();
            float? maxActual = ZEnumerable.Max(source);
            float? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxfloatNullableArray3ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (float?) r.Next(int.MaxValue), 3).Select(x=>x%2==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X =  x } ).ToArray();
            float? maxActual = ZEnumerable.Max(source, arg => arg.X);
            float? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxfloatNullableArray4()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (float?) r.Next(int.MaxValue), 4).ToArray();
            float? maxActual = ZEnumerable.Max(source);
            float? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxfloatNullableArray4Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (float?) r.Next(int.MaxValue) } , 4).ToArray();
            float? maxActual = ZEnumerable.Max(source, arg => arg.X);
            float? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxfloatNullableArray4ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (float?) r.Next(int.MaxValue), 4).Select(x=>x%2==0 ? x : null).ToArray();
            float? maxActual = ZEnumerable.Max(source);
            float? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxfloatNullableArray4ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (float?) r.Next(int.MaxValue), 4).Select(x=>x%2==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X =  x } ).ToArray();
            float? maxActual = ZEnumerable.Max(source, arg => arg.X);
            float? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxfloatNullableArray100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (float?) r.Next(int.MaxValue), 100).ToArray();
            float? maxActual = ZEnumerable.Max(source);
            float? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxfloatNullableArray100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (float?) r.Next(int.MaxValue) } , 100).ToArray();
            float? maxActual = ZEnumerable.Max(source, arg => arg.X);
            float? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxfloatNullableArray100ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (float?) r.Next(int.MaxValue), 100).Select(x=>x%2==0 ? x : null).ToArray();
            float? maxActual = ZEnumerable.Max(source);
            float? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxfloatNullableArray100ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (float?) r.Next(int.MaxValue), 100).Select(x=>x%2==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X =  x } ).ToArray();
            float? maxActual = ZEnumerable.Max(source, arg => arg.X);
            float? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxfloatNullableArray2048()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (float?) r.Next(int.MaxValue), 2048).ToArray();
            float? maxActual = ZEnumerable.Max(source);
            float? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxfloatNullableArray2048Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (float?) r.Next(int.MaxValue) } , 2048).ToArray();
            float? maxActual = ZEnumerable.Max(source, arg => arg.X);
            float? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxfloatNullableArray2048ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (float?) r.Next(int.MaxValue), 2048).Select(x=>x%2==0 ? x : null).ToArray();
            float? maxActual = ZEnumerable.Max(source);
            float? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxfloatNullableArray2048ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (float?) r.Next(int.MaxValue), 2048).Select(x=>x%2==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X =  x } ).ToArray();
            float? maxActual = ZEnumerable.Max(source, arg => arg.X);
            float? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
            
        [TestMethod]
        public void TestMaxfloatNullableListNullOrEmpty()
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

            List<float?> emptySource = new float?[0].ToList();
            try
            {
                ZEnumerable.Max(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestMaxfloatNullableListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<float?,float?>((float?) arg, (float?) arg)).ToList();
            Func<KeyValuePair<float?, float?>, float?> nullMap = null;
            try
            {
                ZEnumerable.Max(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToList();
            try
            {
                ZEnumerable.Max(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Max(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

                     
                
        [TestMethod]
        public void TestMaxfloatNullableList1()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (float?) r.Next(int.MaxValue), 1).ToList();
            float? maxActual = ZEnumerable.Max(source);
            float? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxfloatNullableList1Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (float?) r.Next(int.MaxValue) } , 1).ToList();
            float? maxActual = ZEnumerable.Max(source, arg => arg.X);
            float? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxfloatNullableList1ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (float?) r.Next(int.MaxValue), 1).Select(x=>x%2==0 ? x : null).ToList();
            float? maxActual = ZEnumerable.Max(source);
            float? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxfloatNullableList1ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (float?) r.Next(int.MaxValue), 1).Select(x=>x%2==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X =  x } ).ToList();
            float? maxActual = ZEnumerable.Max(source, arg => arg.X);
            float? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxfloatNullableList2()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (float?) r.Next(int.MaxValue), 2).ToList();
            float? maxActual = ZEnumerable.Max(source);
            float? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxfloatNullableList2Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (float?) r.Next(int.MaxValue) } , 2).ToList();
            float? maxActual = ZEnumerable.Max(source, arg => arg.X);
            float? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxfloatNullableList2ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (float?) r.Next(int.MaxValue), 2).Select(x=>x%2==0 ? x : null).ToList();
            float? maxActual = ZEnumerable.Max(source);
            float? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxfloatNullableList2ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (float?) r.Next(int.MaxValue), 2).Select(x=>x%2==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X =  x } ).ToList();
            float? maxActual = ZEnumerable.Max(source, arg => arg.X);
            float? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxfloatNullableList3()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (float?) r.Next(int.MaxValue), 3).ToList();
            float? maxActual = ZEnumerable.Max(source);
            float? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxfloatNullableList3Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (float?) r.Next(int.MaxValue) } , 3).ToList();
            float? maxActual = ZEnumerable.Max(source, arg => arg.X);
            float? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxfloatNullableList3ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (float?) r.Next(int.MaxValue), 3).Select(x=>x%2==0 ? x : null).ToList();
            float? maxActual = ZEnumerable.Max(source);
            float? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxfloatNullableList3ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (float?) r.Next(int.MaxValue), 3).Select(x=>x%2==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X =  x } ).ToList();
            float? maxActual = ZEnumerable.Max(source, arg => arg.X);
            float? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxfloatNullableList4()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (float?) r.Next(int.MaxValue), 4).ToList();
            float? maxActual = ZEnumerable.Max(source);
            float? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxfloatNullableList4Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (float?) r.Next(int.MaxValue) } , 4).ToList();
            float? maxActual = ZEnumerable.Max(source, arg => arg.X);
            float? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxfloatNullableList4ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (float?) r.Next(int.MaxValue), 4).Select(x=>x%2==0 ? x : null).ToList();
            float? maxActual = ZEnumerable.Max(source);
            float? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxfloatNullableList4ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (float?) r.Next(int.MaxValue), 4).Select(x=>x%2==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X =  x } ).ToList();
            float? maxActual = ZEnumerable.Max(source, arg => arg.X);
            float? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxfloatNullableList100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (float?) r.Next(int.MaxValue), 100).ToList();
            float? maxActual = ZEnumerable.Max(source);
            float? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxfloatNullableList100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (float?) r.Next(int.MaxValue) } , 100).ToList();
            float? maxActual = ZEnumerable.Max(source, arg => arg.X);
            float? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxfloatNullableList100ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (float?) r.Next(int.MaxValue), 100).Select(x=>x%2==0 ? x : null).ToList();
            float? maxActual = ZEnumerable.Max(source);
            float? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxfloatNullableList100ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (float?) r.Next(int.MaxValue), 100).Select(x=>x%2==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X =  x } ).ToList();
            float? maxActual = ZEnumerable.Max(source, arg => arg.X);
            float? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxfloatNullableList2048()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (float?) r.Next(int.MaxValue), 2048).ToList();
            float? maxActual = ZEnumerable.Max(source);
            float? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxfloatNullableList2048Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (float?) r.Next(int.MaxValue) } , 2048).ToList();
            float? maxActual = ZEnumerable.Max(source, arg => arg.X);
            float? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxfloatNullableList2048ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (float?) r.Next(int.MaxValue), 2048).Select(x=>x%2==0 ? x : null).ToList();
            float? maxActual = ZEnumerable.Max(source);
            float? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxfloatNullableList2048ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (float?) r.Next(int.MaxValue), 2048).Select(x=>x%2==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X =  x } ).ToList();
            float? maxActual = ZEnumerable.Max(source, arg => arg.X);
            float? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
            
        [TestMethod]
        public void TestMaxfloatNullableIListNullOrEmpty()
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

            IList<float?> emptySource = new float?[0].ToIList();
            try
            {
                ZEnumerable.Max(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestMaxfloatNullableIListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<float?,float?>((float?) arg, (float?) arg)).ToIList();
            Func<KeyValuePair<float?, float?>, float?> nullMap = null;
            try
            {
                ZEnumerable.Max(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToIList();
            try
            {
                ZEnumerable.Max(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Max(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

                     
                
        [TestMethod]
        public void TestMaxfloatNullableIList1()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (float?) r.Next(int.MaxValue), 1).ToIList();
            float? maxActual = ZEnumerable.Max(source);
            float? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxfloatNullableIList1Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (float?) r.Next(int.MaxValue) } , 1).ToIList();
            float? maxActual = ZEnumerable.Max(source, arg => arg.X);
            float? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxfloatNullableIList1ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (float?) r.Next(int.MaxValue), 1).Select(x=>x%2==0 ? x : null).ToIList();
            float? maxActual = ZEnumerable.Max(source);
            float? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxfloatNullableIList1ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (float?) r.Next(int.MaxValue), 1).Select(x=>x%2==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X =  x } ).ToIList();
            float? maxActual = ZEnumerable.Max(source, arg => arg.X);
            float? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxfloatNullableIList2()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (float?) r.Next(int.MaxValue), 2).ToIList();
            float? maxActual = ZEnumerable.Max(source);
            float? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxfloatNullableIList2Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (float?) r.Next(int.MaxValue) } , 2).ToIList();
            float? maxActual = ZEnumerable.Max(source, arg => arg.X);
            float? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxfloatNullableIList2ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (float?) r.Next(int.MaxValue), 2).Select(x=>x%2==0 ? x : null).ToIList();
            float? maxActual = ZEnumerable.Max(source);
            float? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxfloatNullableIList2ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (float?) r.Next(int.MaxValue), 2).Select(x=>x%2==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X =  x } ).ToIList();
            float? maxActual = ZEnumerable.Max(source, arg => arg.X);
            float? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxfloatNullableIList3()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (float?) r.Next(int.MaxValue), 3).ToIList();
            float? maxActual = ZEnumerable.Max(source);
            float? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxfloatNullableIList3Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (float?) r.Next(int.MaxValue) } , 3).ToIList();
            float? maxActual = ZEnumerable.Max(source, arg => arg.X);
            float? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxfloatNullableIList3ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (float?) r.Next(int.MaxValue), 3).Select(x=>x%2==0 ? x : null).ToIList();
            float? maxActual = ZEnumerable.Max(source);
            float? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxfloatNullableIList3ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (float?) r.Next(int.MaxValue), 3).Select(x=>x%2==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X =  x } ).ToIList();
            float? maxActual = ZEnumerable.Max(source, arg => arg.X);
            float? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxfloatNullableIList4()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (float?) r.Next(int.MaxValue), 4).ToIList();
            float? maxActual = ZEnumerable.Max(source);
            float? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxfloatNullableIList4Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (float?) r.Next(int.MaxValue) } , 4).ToIList();
            float? maxActual = ZEnumerable.Max(source, arg => arg.X);
            float? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxfloatNullableIList4ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (float?) r.Next(int.MaxValue), 4).Select(x=>x%2==0 ? x : null).ToIList();
            float? maxActual = ZEnumerable.Max(source);
            float? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxfloatNullableIList4ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (float?) r.Next(int.MaxValue), 4).Select(x=>x%2==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X =  x } ).ToIList();
            float? maxActual = ZEnumerable.Max(source, arg => arg.X);
            float? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxfloatNullableIList100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (float?) r.Next(int.MaxValue), 100).ToIList();
            float? maxActual = ZEnumerable.Max(source);
            float? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxfloatNullableIList100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (float?) r.Next(int.MaxValue) } , 100).ToIList();
            float? maxActual = ZEnumerable.Max(source, arg => arg.X);
            float? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxfloatNullableIList100ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (float?) r.Next(int.MaxValue), 100).Select(x=>x%2==0 ? x : null).ToIList();
            float? maxActual = ZEnumerable.Max(source);
            float? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxfloatNullableIList100ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (float?) r.Next(int.MaxValue), 100).Select(x=>x%2==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X =  x } ).ToIList();
            float? maxActual = ZEnumerable.Max(source, arg => arg.X);
            float? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxfloatNullableIList2048()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (float?) r.Next(int.MaxValue), 2048).ToIList();
            float? maxActual = ZEnumerable.Max(source);
            float? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxfloatNullableIList2048Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (float?) r.Next(int.MaxValue) } , 2048).ToIList();
            float? maxActual = ZEnumerable.Max(source, arg => arg.X);
            float? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxfloatNullableIList2048ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (float?) r.Next(int.MaxValue), 2048).Select(x=>x%2==0 ? x : null).ToIList();
            float? maxActual = ZEnumerable.Max(source);
            float? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxfloatNullableIList2048ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (float?) r.Next(int.MaxValue), 2048).Select(x=>x%2==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X =  x } ).ToIList();
            float? maxActual = ZEnumerable.Max(source, arg => arg.X);
            float? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                        
               
        #endregion

      

        #region double? 
             
            
        [TestMethod]
        public void TestMaxdoubleNullableArrayNullOrEmpty()
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

            double?[] emptySource = new double?[0].ToArray();
            try
            {
                ZEnumerable.Max(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestMaxdoubleNullableArrayMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<double?,double?>((double?) arg, (double?) arg)).ToArray();
            Func<KeyValuePair<double?, double?>, double?> nullMap = null;
            try
            {
                ZEnumerable.Max(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToArray();
            try
            {
                ZEnumerable.Max(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Max(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

                     
                
        [TestMethod]
        public void TestMaxdoubleNullableArray1()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (double?) r.Next(int.MaxValue), 1).ToArray();
            double? maxActual = ZEnumerable.Max(source);
            double? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdoubleNullableArray1Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (double?) r.Next(int.MaxValue) } , 1).ToArray();
            double? maxActual = ZEnumerable.Max(source, arg => arg.X);
            double? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxdoubleNullableArray1ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (double?) r.Next(int.MaxValue), 1).Select(x=>x%2==0 ? x : null).ToArray();
            double? maxActual = ZEnumerable.Max(source);
            double? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdoubleNullableArray1ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (double?) r.Next(int.MaxValue), 1).Select(x=>x%2==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X =  x } ).ToArray();
            double? maxActual = ZEnumerable.Max(source, arg => arg.X);
            double? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxdoubleNullableArray2()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (double?) r.Next(int.MaxValue), 2).ToArray();
            double? maxActual = ZEnumerable.Max(source);
            double? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdoubleNullableArray2Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (double?) r.Next(int.MaxValue) } , 2).ToArray();
            double? maxActual = ZEnumerable.Max(source, arg => arg.X);
            double? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxdoubleNullableArray2ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (double?) r.Next(int.MaxValue), 2).Select(x=>x%2==0 ? x : null).ToArray();
            double? maxActual = ZEnumerable.Max(source);
            double? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdoubleNullableArray2ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (double?) r.Next(int.MaxValue), 2).Select(x=>x%2==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X =  x } ).ToArray();
            double? maxActual = ZEnumerable.Max(source, arg => arg.X);
            double? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxdoubleNullableArray3()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (double?) r.Next(int.MaxValue), 3).ToArray();
            double? maxActual = ZEnumerable.Max(source);
            double? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdoubleNullableArray3Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (double?) r.Next(int.MaxValue) } , 3).ToArray();
            double? maxActual = ZEnumerable.Max(source, arg => arg.X);
            double? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxdoubleNullableArray3ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (double?) r.Next(int.MaxValue), 3).Select(x=>x%2==0 ? x : null).ToArray();
            double? maxActual = ZEnumerable.Max(source);
            double? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdoubleNullableArray3ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (double?) r.Next(int.MaxValue), 3).Select(x=>x%2==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X =  x } ).ToArray();
            double? maxActual = ZEnumerable.Max(source, arg => arg.X);
            double? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxdoubleNullableArray4()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (double?) r.Next(int.MaxValue), 4).ToArray();
            double? maxActual = ZEnumerable.Max(source);
            double? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdoubleNullableArray4Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (double?) r.Next(int.MaxValue) } , 4).ToArray();
            double? maxActual = ZEnumerable.Max(source, arg => arg.X);
            double? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxdoubleNullableArray4ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (double?) r.Next(int.MaxValue), 4).Select(x=>x%2==0 ? x : null).ToArray();
            double? maxActual = ZEnumerable.Max(source);
            double? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdoubleNullableArray4ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (double?) r.Next(int.MaxValue), 4).Select(x=>x%2==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X =  x } ).ToArray();
            double? maxActual = ZEnumerable.Max(source, arg => arg.X);
            double? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxdoubleNullableArray100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (double?) r.Next(int.MaxValue), 100).ToArray();
            double? maxActual = ZEnumerable.Max(source);
            double? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdoubleNullableArray100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (double?) r.Next(int.MaxValue) } , 100).ToArray();
            double? maxActual = ZEnumerable.Max(source, arg => arg.X);
            double? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxdoubleNullableArray100ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (double?) r.Next(int.MaxValue), 100).Select(x=>x%2==0 ? x : null).ToArray();
            double? maxActual = ZEnumerable.Max(source);
            double? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdoubleNullableArray100ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (double?) r.Next(int.MaxValue), 100).Select(x=>x%2==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X =  x } ).ToArray();
            double? maxActual = ZEnumerable.Max(source, arg => arg.X);
            double? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxdoubleNullableArray2048()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (double?) r.Next(int.MaxValue), 2048).ToArray();
            double? maxActual = ZEnumerable.Max(source);
            double? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdoubleNullableArray2048Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (double?) r.Next(int.MaxValue) } , 2048).ToArray();
            double? maxActual = ZEnumerable.Max(source, arg => arg.X);
            double? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxdoubleNullableArray2048ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (double?) r.Next(int.MaxValue), 2048).Select(x=>x%2==0 ? x : null).ToArray();
            double? maxActual = ZEnumerable.Max(source);
            double? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdoubleNullableArray2048ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (double?) r.Next(int.MaxValue), 2048).Select(x=>x%2==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X =  x } ).ToArray();
            double? maxActual = ZEnumerable.Max(source, arg => arg.X);
            double? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
            
        [TestMethod]
        public void TestMaxdoubleNullableListNullOrEmpty()
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

            List<double?> emptySource = new double?[0].ToList();
            try
            {
                ZEnumerable.Max(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestMaxdoubleNullableListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<double?,double?>((double?) arg, (double?) arg)).ToList();
            Func<KeyValuePair<double?, double?>, double?> nullMap = null;
            try
            {
                ZEnumerable.Max(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToList();
            try
            {
                ZEnumerable.Max(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Max(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

                     
                
        [TestMethod]
        public void TestMaxdoubleNullableList1()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (double?) r.Next(int.MaxValue), 1).ToList();
            double? maxActual = ZEnumerable.Max(source);
            double? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdoubleNullableList1Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (double?) r.Next(int.MaxValue) } , 1).ToList();
            double? maxActual = ZEnumerable.Max(source, arg => arg.X);
            double? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxdoubleNullableList1ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (double?) r.Next(int.MaxValue), 1).Select(x=>x%2==0 ? x : null).ToList();
            double? maxActual = ZEnumerable.Max(source);
            double? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdoubleNullableList1ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (double?) r.Next(int.MaxValue), 1).Select(x=>x%2==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X =  x } ).ToList();
            double? maxActual = ZEnumerable.Max(source, arg => arg.X);
            double? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxdoubleNullableList2()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (double?) r.Next(int.MaxValue), 2).ToList();
            double? maxActual = ZEnumerable.Max(source);
            double? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdoubleNullableList2Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (double?) r.Next(int.MaxValue) } , 2).ToList();
            double? maxActual = ZEnumerable.Max(source, arg => arg.X);
            double? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxdoubleNullableList2ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (double?) r.Next(int.MaxValue), 2).Select(x=>x%2==0 ? x : null).ToList();
            double? maxActual = ZEnumerable.Max(source);
            double? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdoubleNullableList2ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (double?) r.Next(int.MaxValue), 2).Select(x=>x%2==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X =  x } ).ToList();
            double? maxActual = ZEnumerable.Max(source, arg => arg.X);
            double? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxdoubleNullableList3()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (double?) r.Next(int.MaxValue), 3).ToList();
            double? maxActual = ZEnumerable.Max(source);
            double? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdoubleNullableList3Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (double?) r.Next(int.MaxValue) } , 3).ToList();
            double? maxActual = ZEnumerable.Max(source, arg => arg.X);
            double? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxdoubleNullableList3ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (double?) r.Next(int.MaxValue), 3).Select(x=>x%2==0 ? x : null).ToList();
            double? maxActual = ZEnumerable.Max(source);
            double? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdoubleNullableList3ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (double?) r.Next(int.MaxValue), 3).Select(x=>x%2==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X =  x } ).ToList();
            double? maxActual = ZEnumerable.Max(source, arg => arg.X);
            double? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxdoubleNullableList4()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (double?) r.Next(int.MaxValue), 4).ToList();
            double? maxActual = ZEnumerable.Max(source);
            double? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdoubleNullableList4Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (double?) r.Next(int.MaxValue) } , 4).ToList();
            double? maxActual = ZEnumerable.Max(source, arg => arg.X);
            double? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxdoubleNullableList4ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (double?) r.Next(int.MaxValue), 4).Select(x=>x%2==0 ? x : null).ToList();
            double? maxActual = ZEnumerable.Max(source);
            double? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdoubleNullableList4ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (double?) r.Next(int.MaxValue), 4).Select(x=>x%2==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X =  x } ).ToList();
            double? maxActual = ZEnumerable.Max(source, arg => arg.X);
            double? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxdoubleNullableList100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (double?) r.Next(int.MaxValue), 100).ToList();
            double? maxActual = ZEnumerable.Max(source);
            double? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdoubleNullableList100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (double?) r.Next(int.MaxValue) } , 100).ToList();
            double? maxActual = ZEnumerable.Max(source, arg => arg.X);
            double? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxdoubleNullableList100ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (double?) r.Next(int.MaxValue), 100).Select(x=>x%2==0 ? x : null).ToList();
            double? maxActual = ZEnumerable.Max(source);
            double? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdoubleNullableList100ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (double?) r.Next(int.MaxValue), 100).Select(x=>x%2==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X =  x } ).ToList();
            double? maxActual = ZEnumerable.Max(source, arg => arg.X);
            double? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxdoubleNullableList2048()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (double?) r.Next(int.MaxValue), 2048).ToList();
            double? maxActual = ZEnumerable.Max(source);
            double? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdoubleNullableList2048Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (double?) r.Next(int.MaxValue) } , 2048).ToList();
            double? maxActual = ZEnumerable.Max(source, arg => arg.X);
            double? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxdoubleNullableList2048ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (double?) r.Next(int.MaxValue), 2048).Select(x=>x%2==0 ? x : null).ToList();
            double? maxActual = ZEnumerable.Max(source);
            double? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdoubleNullableList2048ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (double?) r.Next(int.MaxValue), 2048).Select(x=>x%2==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X =  x } ).ToList();
            double? maxActual = ZEnumerable.Max(source, arg => arg.X);
            double? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
            
        [TestMethod]
        public void TestMaxdoubleNullableIListNullOrEmpty()
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

            IList<double?> emptySource = new double?[0].ToIList();
            try
            {
                ZEnumerable.Max(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestMaxdoubleNullableIListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<double?,double?>((double?) arg, (double?) arg)).ToIList();
            Func<KeyValuePair<double?, double?>, double?> nullMap = null;
            try
            {
                ZEnumerable.Max(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToIList();
            try
            {
                ZEnumerable.Max(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Max(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

                     
                
        [TestMethod]
        public void TestMaxdoubleNullableIList1()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (double?) r.Next(int.MaxValue), 1).ToIList();
            double? maxActual = ZEnumerable.Max(source);
            double? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdoubleNullableIList1Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (double?) r.Next(int.MaxValue) } , 1).ToIList();
            double? maxActual = ZEnumerable.Max(source, arg => arg.X);
            double? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxdoubleNullableIList1ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (double?) r.Next(int.MaxValue), 1).Select(x=>x%2==0 ? x : null).ToIList();
            double? maxActual = ZEnumerable.Max(source);
            double? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdoubleNullableIList1ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (double?) r.Next(int.MaxValue), 1).Select(x=>x%2==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X =  x } ).ToIList();
            double? maxActual = ZEnumerable.Max(source, arg => arg.X);
            double? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxdoubleNullableIList2()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (double?) r.Next(int.MaxValue), 2).ToIList();
            double? maxActual = ZEnumerable.Max(source);
            double? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdoubleNullableIList2Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (double?) r.Next(int.MaxValue) } , 2).ToIList();
            double? maxActual = ZEnumerable.Max(source, arg => arg.X);
            double? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxdoubleNullableIList2ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (double?) r.Next(int.MaxValue), 2).Select(x=>x%2==0 ? x : null).ToIList();
            double? maxActual = ZEnumerable.Max(source);
            double? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdoubleNullableIList2ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (double?) r.Next(int.MaxValue), 2).Select(x=>x%2==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X =  x } ).ToIList();
            double? maxActual = ZEnumerable.Max(source, arg => arg.X);
            double? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxdoubleNullableIList3()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (double?) r.Next(int.MaxValue), 3).ToIList();
            double? maxActual = ZEnumerable.Max(source);
            double? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdoubleNullableIList3Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (double?) r.Next(int.MaxValue) } , 3).ToIList();
            double? maxActual = ZEnumerable.Max(source, arg => arg.X);
            double? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxdoubleNullableIList3ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (double?) r.Next(int.MaxValue), 3).Select(x=>x%2==0 ? x : null).ToIList();
            double? maxActual = ZEnumerable.Max(source);
            double? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdoubleNullableIList3ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (double?) r.Next(int.MaxValue), 3).Select(x=>x%2==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X =  x } ).ToIList();
            double? maxActual = ZEnumerable.Max(source, arg => arg.X);
            double? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxdoubleNullableIList4()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (double?) r.Next(int.MaxValue), 4).ToIList();
            double? maxActual = ZEnumerable.Max(source);
            double? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdoubleNullableIList4Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (double?) r.Next(int.MaxValue) } , 4).ToIList();
            double? maxActual = ZEnumerable.Max(source, arg => arg.X);
            double? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxdoubleNullableIList4ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (double?) r.Next(int.MaxValue), 4).Select(x=>x%2==0 ? x : null).ToIList();
            double? maxActual = ZEnumerable.Max(source);
            double? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdoubleNullableIList4ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (double?) r.Next(int.MaxValue), 4).Select(x=>x%2==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X =  x } ).ToIList();
            double? maxActual = ZEnumerable.Max(source, arg => arg.X);
            double? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxdoubleNullableIList100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (double?) r.Next(int.MaxValue), 100).ToIList();
            double? maxActual = ZEnumerable.Max(source);
            double? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdoubleNullableIList100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (double?) r.Next(int.MaxValue) } , 100).ToIList();
            double? maxActual = ZEnumerable.Max(source, arg => arg.X);
            double? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxdoubleNullableIList100ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (double?) r.Next(int.MaxValue), 100).Select(x=>x%2==0 ? x : null).ToIList();
            double? maxActual = ZEnumerable.Max(source);
            double? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdoubleNullableIList100ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (double?) r.Next(int.MaxValue), 100).Select(x=>x%2==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X =  x } ).ToIList();
            double? maxActual = ZEnumerable.Max(source, arg => arg.X);
            double? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxdoubleNullableIList2048()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (double?) r.Next(int.MaxValue), 2048).ToIList();
            double? maxActual = ZEnumerable.Max(source);
            double? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdoubleNullableIList2048Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (double?) r.Next(int.MaxValue) } , 2048).ToIList();
            double? maxActual = ZEnumerable.Max(source, arg => arg.X);
            double? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxdoubleNullableIList2048ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (double?) r.Next(int.MaxValue), 2048).Select(x=>x%2==0 ? x : null).ToIList();
            double? maxActual = ZEnumerable.Max(source);
            double? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdoubleNullableIList2048ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (double?) r.Next(int.MaxValue), 2048).Select(x=>x%2==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X =  x } ).ToIList();
            double? maxActual = ZEnumerable.Max(source, arg => arg.X);
            double? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                        
               
        #endregion

      

        #region decimal? 
             
            
        [TestMethod]
        public void TestMaxdecimalNullableArrayNullOrEmpty()
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

            decimal?[] emptySource = new decimal?[0].ToArray();
            try
            {
                ZEnumerable.Max(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestMaxdecimalNullableArrayMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<decimal?,decimal?>((decimal?) arg, (decimal?) arg)).ToArray();
            Func<KeyValuePair<decimal?, decimal?>, decimal?> nullMap = null;
            try
            {
                ZEnumerable.Max(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToArray();
            try
            {
                ZEnumerable.Max(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Max(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

                     
                
        [TestMethod]
        public void TestMaxdecimalNullableArray1()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (decimal?) r.Next(int.MaxValue), 1).ToArray();
            decimal? maxActual = ZEnumerable.Max(source);
            decimal? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdecimalNullableArray1Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (decimal?) r.Next(int.MaxValue) } , 1).ToArray();
            decimal? maxActual = ZEnumerable.Max(source, arg => arg.X);
            decimal? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxdecimalNullableArray1ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (decimal?) r.Next(int.MaxValue), 1).Select(x=>x%2==0 ? x : null).ToArray();
            decimal? maxActual = ZEnumerable.Max(source);
            decimal? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdecimalNullableArray1ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (decimal?) r.Next(int.MaxValue), 1).Select(x=>x%2==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X =  x } ).ToArray();
            decimal? maxActual = ZEnumerable.Max(source, arg => arg.X);
            decimal? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxdecimalNullableArray2()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (decimal?) r.Next(int.MaxValue), 2).ToArray();
            decimal? maxActual = ZEnumerable.Max(source);
            decimal? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdecimalNullableArray2Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (decimal?) r.Next(int.MaxValue) } , 2).ToArray();
            decimal? maxActual = ZEnumerable.Max(source, arg => arg.X);
            decimal? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxdecimalNullableArray2ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (decimal?) r.Next(int.MaxValue), 2).Select(x=>x%2==0 ? x : null).ToArray();
            decimal? maxActual = ZEnumerable.Max(source);
            decimal? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdecimalNullableArray2ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (decimal?) r.Next(int.MaxValue), 2).Select(x=>x%2==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X =  x } ).ToArray();
            decimal? maxActual = ZEnumerable.Max(source, arg => arg.X);
            decimal? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxdecimalNullableArray3()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (decimal?) r.Next(int.MaxValue), 3).ToArray();
            decimal? maxActual = ZEnumerable.Max(source);
            decimal? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdecimalNullableArray3Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (decimal?) r.Next(int.MaxValue) } , 3).ToArray();
            decimal? maxActual = ZEnumerable.Max(source, arg => arg.X);
            decimal? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxdecimalNullableArray3ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (decimal?) r.Next(int.MaxValue), 3).Select(x=>x%2==0 ? x : null).ToArray();
            decimal? maxActual = ZEnumerable.Max(source);
            decimal? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdecimalNullableArray3ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (decimal?) r.Next(int.MaxValue), 3).Select(x=>x%2==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X =  x } ).ToArray();
            decimal? maxActual = ZEnumerable.Max(source, arg => arg.X);
            decimal? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxdecimalNullableArray4()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (decimal?) r.Next(int.MaxValue), 4).ToArray();
            decimal? maxActual = ZEnumerable.Max(source);
            decimal? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdecimalNullableArray4Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (decimal?) r.Next(int.MaxValue) } , 4).ToArray();
            decimal? maxActual = ZEnumerable.Max(source, arg => arg.X);
            decimal? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxdecimalNullableArray4ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (decimal?) r.Next(int.MaxValue), 4).Select(x=>x%2==0 ? x : null).ToArray();
            decimal? maxActual = ZEnumerable.Max(source);
            decimal? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdecimalNullableArray4ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (decimal?) r.Next(int.MaxValue), 4).Select(x=>x%2==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X =  x } ).ToArray();
            decimal? maxActual = ZEnumerable.Max(source, arg => arg.X);
            decimal? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxdecimalNullableArray100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (decimal?) r.Next(int.MaxValue), 100).ToArray();
            decimal? maxActual = ZEnumerable.Max(source);
            decimal? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdecimalNullableArray100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (decimal?) r.Next(int.MaxValue) } , 100).ToArray();
            decimal? maxActual = ZEnumerable.Max(source, arg => arg.X);
            decimal? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxdecimalNullableArray100ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (decimal?) r.Next(int.MaxValue), 100).Select(x=>x%2==0 ? x : null).ToArray();
            decimal? maxActual = ZEnumerable.Max(source);
            decimal? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdecimalNullableArray100ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (decimal?) r.Next(int.MaxValue), 100).Select(x=>x%2==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X =  x } ).ToArray();
            decimal? maxActual = ZEnumerable.Max(source, arg => arg.X);
            decimal? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxdecimalNullableArray2048()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (decimal?) r.Next(int.MaxValue), 2048).ToArray();
            decimal? maxActual = ZEnumerable.Max(source);
            decimal? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdecimalNullableArray2048Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (decimal?) r.Next(int.MaxValue) } , 2048).ToArray();
            decimal? maxActual = ZEnumerable.Max(source, arg => arg.X);
            decimal? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxdecimalNullableArray2048ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (decimal?) r.Next(int.MaxValue), 2048).Select(x=>x%2==0 ? x : null).ToArray();
            decimal? maxActual = ZEnumerable.Max(source);
            decimal? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdecimalNullableArray2048ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (decimal?) r.Next(int.MaxValue), 2048).Select(x=>x%2==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X =  x } ).ToArray();
            decimal? maxActual = ZEnumerable.Max(source, arg => arg.X);
            decimal? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
            
        [TestMethod]
        public void TestMaxdecimalNullableListNullOrEmpty()
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

            List<decimal?> emptySource = new decimal?[0].ToList();
            try
            {
                ZEnumerable.Max(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestMaxdecimalNullableListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<decimal?,decimal?>((decimal?) arg, (decimal?) arg)).ToList();
            Func<KeyValuePair<decimal?, decimal?>, decimal?> nullMap = null;
            try
            {
                ZEnumerable.Max(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToList();
            try
            {
                ZEnumerable.Max(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Max(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

                     
                
        [TestMethod]
        public void TestMaxdecimalNullableList1()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (decimal?) r.Next(int.MaxValue), 1).ToList();
            decimal? maxActual = ZEnumerable.Max(source);
            decimal? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdecimalNullableList1Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (decimal?) r.Next(int.MaxValue) } , 1).ToList();
            decimal? maxActual = ZEnumerable.Max(source, arg => arg.X);
            decimal? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxdecimalNullableList1ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (decimal?) r.Next(int.MaxValue), 1).Select(x=>x%2==0 ? x : null).ToList();
            decimal? maxActual = ZEnumerable.Max(source);
            decimal? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdecimalNullableList1ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (decimal?) r.Next(int.MaxValue), 1).Select(x=>x%2==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X =  x } ).ToList();
            decimal? maxActual = ZEnumerable.Max(source, arg => arg.X);
            decimal? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxdecimalNullableList2()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (decimal?) r.Next(int.MaxValue), 2).ToList();
            decimal? maxActual = ZEnumerable.Max(source);
            decimal? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdecimalNullableList2Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (decimal?) r.Next(int.MaxValue) } , 2).ToList();
            decimal? maxActual = ZEnumerable.Max(source, arg => arg.X);
            decimal? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxdecimalNullableList2ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (decimal?) r.Next(int.MaxValue), 2).Select(x=>x%2==0 ? x : null).ToList();
            decimal? maxActual = ZEnumerable.Max(source);
            decimal? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdecimalNullableList2ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (decimal?) r.Next(int.MaxValue), 2).Select(x=>x%2==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X =  x } ).ToList();
            decimal? maxActual = ZEnumerable.Max(source, arg => arg.X);
            decimal? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxdecimalNullableList3()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (decimal?) r.Next(int.MaxValue), 3).ToList();
            decimal? maxActual = ZEnumerable.Max(source);
            decimal? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdecimalNullableList3Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (decimal?) r.Next(int.MaxValue) } , 3).ToList();
            decimal? maxActual = ZEnumerable.Max(source, arg => arg.X);
            decimal? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxdecimalNullableList3ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (decimal?) r.Next(int.MaxValue), 3).Select(x=>x%2==0 ? x : null).ToList();
            decimal? maxActual = ZEnumerable.Max(source);
            decimal? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdecimalNullableList3ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (decimal?) r.Next(int.MaxValue), 3).Select(x=>x%2==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X =  x } ).ToList();
            decimal? maxActual = ZEnumerable.Max(source, arg => arg.X);
            decimal? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxdecimalNullableList4()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (decimal?) r.Next(int.MaxValue), 4).ToList();
            decimal? maxActual = ZEnumerable.Max(source);
            decimal? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdecimalNullableList4Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (decimal?) r.Next(int.MaxValue) } , 4).ToList();
            decimal? maxActual = ZEnumerable.Max(source, arg => arg.X);
            decimal? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxdecimalNullableList4ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (decimal?) r.Next(int.MaxValue), 4).Select(x=>x%2==0 ? x : null).ToList();
            decimal? maxActual = ZEnumerable.Max(source);
            decimal? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdecimalNullableList4ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (decimal?) r.Next(int.MaxValue), 4).Select(x=>x%2==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X =  x } ).ToList();
            decimal? maxActual = ZEnumerable.Max(source, arg => arg.X);
            decimal? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxdecimalNullableList100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (decimal?) r.Next(int.MaxValue), 100).ToList();
            decimal? maxActual = ZEnumerable.Max(source);
            decimal? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdecimalNullableList100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (decimal?) r.Next(int.MaxValue) } , 100).ToList();
            decimal? maxActual = ZEnumerable.Max(source, arg => arg.X);
            decimal? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxdecimalNullableList100ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (decimal?) r.Next(int.MaxValue), 100).Select(x=>x%2==0 ? x : null).ToList();
            decimal? maxActual = ZEnumerable.Max(source);
            decimal? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdecimalNullableList100ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (decimal?) r.Next(int.MaxValue), 100).Select(x=>x%2==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X =  x } ).ToList();
            decimal? maxActual = ZEnumerable.Max(source, arg => arg.X);
            decimal? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxdecimalNullableList2048()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (decimal?) r.Next(int.MaxValue), 2048).ToList();
            decimal? maxActual = ZEnumerable.Max(source);
            decimal? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdecimalNullableList2048Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (decimal?) r.Next(int.MaxValue) } , 2048).ToList();
            decimal? maxActual = ZEnumerable.Max(source, arg => arg.X);
            decimal? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxdecimalNullableList2048ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (decimal?) r.Next(int.MaxValue), 2048).Select(x=>x%2==0 ? x : null).ToList();
            decimal? maxActual = ZEnumerable.Max(source);
            decimal? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdecimalNullableList2048ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (decimal?) r.Next(int.MaxValue), 2048).Select(x=>x%2==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X =  x } ).ToList();
            decimal? maxActual = ZEnumerable.Max(source, arg => arg.X);
            decimal? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
            
        [TestMethod]
        public void TestMaxdecimalNullableIListNullOrEmpty()
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

            IList<decimal?> emptySource = new decimal?[0].ToIList();
            try
            {
                ZEnumerable.Max(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestMaxdecimalNullableIListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<decimal?,decimal?>((decimal?) arg, (decimal?) arg)).ToIList();
            Func<KeyValuePair<decimal?, decimal?>, decimal?> nullMap = null;
            try
            {
                ZEnumerable.Max(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToIList();
            try
            {
                ZEnumerable.Max(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Max(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

                     
                
        [TestMethod]
        public void TestMaxdecimalNullableIList1()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (decimal?) r.Next(int.MaxValue), 1).ToIList();
            decimal? maxActual = ZEnumerable.Max(source);
            decimal? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdecimalNullableIList1Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (decimal?) r.Next(int.MaxValue) } , 1).ToIList();
            decimal? maxActual = ZEnumerable.Max(source, arg => arg.X);
            decimal? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxdecimalNullableIList1ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (decimal?) r.Next(int.MaxValue), 1).Select(x=>x%2==0 ? x : null).ToIList();
            decimal? maxActual = ZEnumerable.Max(source);
            decimal? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdecimalNullableIList1ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (decimal?) r.Next(int.MaxValue), 1).Select(x=>x%2==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X =  x } ).ToIList();
            decimal? maxActual = ZEnumerable.Max(source, arg => arg.X);
            decimal? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxdecimalNullableIList2()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (decimal?) r.Next(int.MaxValue), 2).ToIList();
            decimal? maxActual = ZEnumerable.Max(source);
            decimal? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdecimalNullableIList2Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (decimal?) r.Next(int.MaxValue) } , 2).ToIList();
            decimal? maxActual = ZEnumerable.Max(source, arg => arg.X);
            decimal? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxdecimalNullableIList2ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (decimal?) r.Next(int.MaxValue), 2).Select(x=>x%2==0 ? x : null).ToIList();
            decimal? maxActual = ZEnumerable.Max(source);
            decimal? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdecimalNullableIList2ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (decimal?) r.Next(int.MaxValue), 2).Select(x=>x%2==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X =  x } ).ToIList();
            decimal? maxActual = ZEnumerable.Max(source, arg => arg.X);
            decimal? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxdecimalNullableIList3()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (decimal?) r.Next(int.MaxValue), 3).ToIList();
            decimal? maxActual = ZEnumerable.Max(source);
            decimal? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdecimalNullableIList3Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (decimal?) r.Next(int.MaxValue) } , 3).ToIList();
            decimal? maxActual = ZEnumerable.Max(source, arg => arg.X);
            decimal? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxdecimalNullableIList3ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (decimal?) r.Next(int.MaxValue), 3).Select(x=>x%2==0 ? x : null).ToIList();
            decimal? maxActual = ZEnumerable.Max(source);
            decimal? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdecimalNullableIList3ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (decimal?) r.Next(int.MaxValue), 3).Select(x=>x%2==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X =  x } ).ToIList();
            decimal? maxActual = ZEnumerable.Max(source, arg => arg.X);
            decimal? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxdecimalNullableIList4()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (decimal?) r.Next(int.MaxValue), 4).ToIList();
            decimal? maxActual = ZEnumerable.Max(source);
            decimal? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdecimalNullableIList4Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (decimal?) r.Next(int.MaxValue) } , 4).ToIList();
            decimal? maxActual = ZEnumerable.Max(source, arg => arg.X);
            decimal? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxdecimalNullableIList4ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (decimal?) r.Next(int.MaxValue), 4).Select(x=>x%2==0 ? x : null).ToIList();
            decimal? maxActual = ZEnumerable.Max(source);
            decimal? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdecimalNullableIList4ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (decimal?) r.Next(int.MaxValue), 4).Select(x=>x%2==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X =  x } ).ToIList();
            decimal? maxActual = ZEnumerable.Max(source, arg => arg.X);
            decimal? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxdecimalNullableIList100()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (decimal?) r.Next(int.MaxValue), 100).ToIList();
            decimal? maxActual = ZEnumerable.Max(source);
            decimal? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdecimalNullableIList100Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (decimal?) r.Next(int.MaxValue) } , 100).ToIList();
            decimal? maxActual = ZEnumerable.Max(source, arg => arg.X);
            decimal? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxdecimalNullableIList100ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (decimal?) r.Next(int.MaxValue), 100).Select(x=>x%2==0 ? x : null).ToIList();
            decimal? maxActual = ZEnumerable.Max(source);
            decimal? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdecimalNullableIList100ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (decimal?) r.Next(int.MaxValue), 100).Select(x=>x%2==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X =  x } ).ToIList();
            decimal? maxActual = ZEnumerable.Max(source, arg => arg.X);
            decimal? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                         
                
        [TestMethod]
        public void TestMaxdecimalNullableIList2048()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (decimal?) r.Next(int.MaxValue), 2048).ToIList();
            decimal? maxActual = ZEnumerable.Max(source);
            decimal? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdecimalNullableIList2048Map()
        {
            var source = ZEnumerable.Repeat(new Random(), r => new { X =  (decimal?) r.Next(int.MaxValue) } , 2048).ToIList();
            decimal? maxActual = ZEnumerable.Max(source, arg => arg.X);
            decimal? maxExpected =  Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }
    
        
        [TestMethod]
        public void TestMaxdecimalNullableIList2048ThreatNulls()
        {
            var source = ZEnumerable.Repeat(new Random(), r => (decimal?) r.Next(int.MaxValue), 2048).Select(x=>x%2==0 ? x : null).ToIList();
            decimal? maxActual = ZEnumerable.Max(source);
            decimal? maxExpected = Maxer.GetMax(source);
            Assert.AreEqual(maxExpected, maxActual);
        }
           
        [TestMethod]
        public void TestMaxdecimalNullableIList2048ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat(new Random(), r => (decimal?) r.Next(int.MaxValue), 2048).Select(x=>x%2==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X =  x } ).ToIList();
            decimal? maxActual = ZEnumerable.Max(source, arg => arg.X);
            decimal? maxExpected = Maxer.GetMax(source.Select(arg => arg.X)); 
            Assert.AreEqual(maxExpected, maxActual);
        }

                    
                        
               
        #endregion

    
    }
}