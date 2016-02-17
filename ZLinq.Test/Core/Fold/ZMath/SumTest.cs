
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
        public void TestSumsbyteArray1()
        {
            var source = ZEnumerable.Repeat((sbyte) 1, 1).ToArray();
            sbyte SumActual = ZEnumerable.Sum(source);
            sbyte SumExpected = (sbyte) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumsbyteArray1Map()
        {
            var source = ZEnumerable.Repeat(new { X = (sbyte) 1 } , 1).ToArray();
            sbyte SumActual = ZEnumerable.Sum(source, arg => arg.X);
            sbyte SumExpected = (sbyte) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumsbyteArray2()
        {
            var source = ZEnumerable.Repeat((sbyte) 1, 2).ToArray();
            sbyte SumActual = ZEnumerable.Sum(source);
            sbyte SumExpected = (sbyte) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumsbyteArray2Map()
        {
            var source = ZEnumerable.Repeat(new { X = (sbyte) 1 } , 2).ToArray();
            sbyte SumActual = ZEnumerable.Sum(source, arg => arg.X);
            sbyte SumExpected = (sbyte) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumsbyteArray3()
        {
            var source = ZEnumerable.Repeat((sbyte) 1, 3).ToArray();
            sbyte SumActual = ZEnumerable.Sum(source);
            sbyte SumExpected = (sbyte) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumsbyteArray3Map()
        {
            var source = ZEnumerable.Repeat(new { X = (sbyte) 1 } , 3).ToArray();
            sbyte SumActual = ZEnumerable.Sum(source, arg => arg.X);
            sbyte SumExpected = (sbyte) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumsbyteArray4()
        {
            var source = ZEnumerable.Repeat((sbyte) 1, 4).ToArray();
            sbyte SumActual = ZEnumerable.Sum(source);
            sbyte SumExpected = (sbyte) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumsbyteArray4Map()
        {
            var source = ZEnumerable.Repeat(new { X = (sbyte) 1 } , 4).ToArray();
            sbyte SumActual = ZEnumerable.Sum(source, arg => arg.X);
            sbyte SumExpected = (sbyte) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
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
        public void TestSumsbyteArrayNullOrEmpty()
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

            sbyte[] emptySource = new sbyte[0].ToArray();
            var sum = ZEnumerable.Sum(emptySource);
            Assert.AreEqual(sum, (sbyte) 0);
        }

        [TestMethod]
        public void TestSumsbyteArrayMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<sbyte,sbyte>((sbyte) arg, (sbyte) arg)).ToArray();
            Func<KeyValuePair<sbyte, sbyte>, sbyte> nullMap = null;
            sbyte[] nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            try
            {
                ZEnumerable.Sum(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            
            var emptySource = source.Take(0).ToArray();
            var sum = ZEnumerable.Sum(emptySource, x => (sbyte) x.Key);
            Assert.AreEqual(sum, (sbyte) 0);           
        }

            

        
                        
            
        [TestMethod]
        public void TestSumsbyteList1()
        {
            var source = ZEnumerable.Repeat((sbyte) 1, 1).ToList();
            sbyte SumActual = ZEnumerable.Sum(source);
            sbyte SumExpected = (sbyte) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumsbyteList1Map()
        {
            var source = ZEnumerable.Repeat(new { X = (sbyte) 1 } , 1).ToList();
            sbyte SumActual = ZEnumerable.Sum(source, arg => arg.X);
            sbyte SumExpected = (sbyte) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumsbyteList2()
        {
            var source = ZEnumerable.Repeat((sbyte) 1, 2).ToList();
            sbyte SumActual = ZEnumerable.Sum(source);
            sbyte SumExpected = (sbyte) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumsbyteList2Map()
        {
            var source = ZEnumerable.Repeat(new { X = (sbyte) 1 } , 2).ToList();
            sbyte SumActual = ZEnumerable.Sum(source, arg => arg.X);
            sbyte SumExpected = (sbyte) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumsbyteList3()
        {
            var source = ZEnumerable.Repeat((sbyte) 1, 3).ToList();
            sbyte SumActual = ZEnumerable.Sum(source);
            sbyte SumExpected = (sbyte) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumsbyteList3Map()
        {
            var source = ZEnumerable.Repeat(new { X = (sbyte) 1 } , 3).ToList();
            sbyte SumActual = ZEnumerable.Sum(source, arg => arg.X);
            sbyte SumExpected = (sbyte) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumsbyteList4()
        {
            var source = ZEnumerable.Repeat((sbyte) 1, 4).ToList();
            sbyte SumActual = ZEnumerable.Sum(source);
            sbyte SumExpected = (sbyte) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumsbyteList4Map()
        {
            var source = ZEnumerable.Repeat(new { X = (sbyte) 1 } , 4).ToList();
            sbyte SumActual = ZEnumerable.Sum(source, arg => arg.X);
            sbyte SumExpected = (sbyte) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
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
        public void TestSumsbyteListNullOrEmpty()
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

            List<sbyte> emptySource = new sbyte[0].ToList();
            var sum = ZEnumerable.Sum(emptySource);
            Assert.AreEqual(sum, (sbyte) 0);
        }

        [TestMethod]
        public void TestSumsbyteListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<sbyte,sbyte>((sbyte) arg, (sbyte) arg)).ToList();
            Func<KeyValuePair<sbyte, sbyte>, sbyte> nullMap = null;
            List<sbyte> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            try
            {
                ZEnumerable.Sum(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            
            var emptySource = source.Take(0).ToList();
            var sum = ZEnumerable.Sum(emptySource, x => (sbyte) x.Key);
            Assert.AreEqual(sum, (sbyte) 0);           
        }

            

        
                        
            
        [TestMethod]
        public void TestSumsbyteIList1()
        {
            var source = ZEnumerable.Repeat((sbyte) 1, 1).ToIList();
            sbyte SumActual = ZEnumerable.Sum(source);
            sbyte SumExpected = (sbyte) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumsbyteIList1Map()
        {
            var source = ZEnumerable.Repeat(new { X = (sbyte) 1 } , 1).ToIList();
            sbyte SumActual = ZEnumerable.Sum(source, arg => arg.X);
            sbyte SumExpected = (sbyte) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumsbyteIList2()
        {
            var source = ZEnumerable.Repeat((sbyte) 1, 2).ToIList();
            sbyte SumActual = ZEnumerable.Sum(source);
            sbyte SumExpected = (sbyte) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumsbyteIList2Map()
        {
            var source = ZEnumerable.Repeat(new { X = (sbyte) 1 } , 2).ToIList();
            sbyte SumActual = ZEnumerable.Sum(source, arg => arg.X);
            sbyte SumExpected = (sbyte) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumsbyteIList3()
        {
            var source = ZEnumerable.Repeat((sbyte) 1, 3).ToIList();
            sbyte SumActual = ZEnumerable.Sum(source);
            sbyte SumExpected = (sbyte) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumsbyteIList3Map()
        {
            var source = ZEnumerable.Repeat(new { X = (sbyte) 1 } , 3).ToIList();
            sbyte SumActual = ZEnumerable.Sum(source, arg => arg.X);
            sbyte SumExpected = (sbyte) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumsbyteIList4()
        {
            var source = ZEnumerable.Repeat((sbyte) 1, 4).ToIList();
            sbyte SumActual = ZEnumerable.Sum(source);
            sbyte SumExpected = (sbyte) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumsbyteIList4Map()
        {
            var source = ZEnumerable.Repeat(new { X = (sbyte) 1 } , 4).ToIList();
            sbyte SumActual = ZEnumerable.Sum(source, arg => arg.X);
            sbyte SumExpected = (sbyte) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
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
        public void TestSumsbyteIListNullOrEmpty()
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

            IList<sbyte> emptySource = new sbyte[0].ToIList();
            var sum = ZEnumerable.Sum(emptySource);
            Assert.AreEqual(sum, (sbyte) 0);
        }

        [TestMethod]
        public void TestSumsbyteIListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<sbyte,sbyte>((sbyte) arg, (sbyte) arg)).ToIList();
            Func<KeyValuePair<sbyte, sbyte>, sbyte> nullMap = null;
            IList<sbyte> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            try
            {
                ZEnumerable.Sum(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            
            var emptySource = source.Take(0).ToIList();
            var sum = ZEnumerable.Sum(emptySource, x => (sbyte) x.Key);
            Assert.AreEqual(sum, (sbyte) 0);           
        }

                
        #endregion
            #region byte             
            

        
                        
            
        [TestMethod]
        public void TestSumbyteArray1()
        {
            var source = ZEnumerable.Repeat((byte) 1, 1).ToArray();
            byte SumActual = ZEnumerable.Sum(source);
            byte SumExpected = (byte) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumbyteArray1Map()
        {
            var source = ZEnumerable.Repeat(new { X = (byte) 1 } , 1).ToArray();
            byte SumActual = ZEnumerable.Sum(source, arg => arg.X);
            byte SumExpected = (byte) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumbyteArray2()
        {
            var source = ZEnumerable.Repeat((byte) 1, 2).ToArray();
            byte SumActual = ZEnumerable.Sum(source);
            byte SumExpected = (byte) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumbyteArray2Map()
        {
            var source = ZEnumerable.Repeat(new { X = (byte) 1 } , 2).ToArray();
            byte SumActual = ZEnumerable.Sum(source, arg => arg.X);
            byte SumExpected = (byte) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumbyteArray3()
        {
            var source = ZEnumerable.Repeat((byte) 1, 3).ToArray();
            byte SumActual = ZEnumerable.Sum(source);
            byte SumExpected = (byte) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumbyteArray3Map()
        {
            var source = ZEnumerable.Repeat(new { X = (byte) 1 } , 3).ToArray();
            byte SumActual = ZEnumerable.Sum(source, arg => arg.X);
            byte SumExpected = (byte) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumbyteArray4()
        {
            var source = ZEnumerable.Repeat((byte) 1, 4).ToArray();
            byte SumActual = ZEnumerable.Sum(source);
            byte SumExpected = (byte) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumbyteArray4Map()
        {
            var source = ZEnumerable.Repeat(new { X = (byte) 1 } , 4).ToArray();
            byte SumActual = ZEnumerable.Sum(source, arg => arg.X);
            byte SumExpected = (byte) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
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
        public void TestSumbyteArrayNullOrEmpty()
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

            byte[] emptySource = new byte[0].ToArray();
            var sum = ZEnumerable.Sum(emptySource);
            Assert.AreEqual(sum, (byte) 0);
        }

        [TestMethod]
        public void TestSumbyteArrayMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<byte,byte>((byte) arg, (byte) arg)).ToArray();
            Func<KeyValuePair<byte, byte>, byte> nullMap = null;
            byte[] nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            try
            {
                ZEnumerable.Sum(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            
            var emptySource = source.Take(0).ToArray();
            var sum = ZEnumerable.Sum(emptySource, x => (byte) x.Key);
            Assert.AreEqual(sum, (byte) 0);           
        }

            

        
                        
            
        [TestMethod]
        public void TestSumbyteList1()
        {
            var source = ZEnumerable.Repeat((byte) 1, 1).ToList();
            byte SumActual = ZEnumerable.Sum(source);
            byte SumExpected = (byte) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumbyteList1Map()
        {
            var source = ZEnumerable.Repeat(new { X = (byte) 1 } , 1).ToList();
            byte SumActual = ZEnumerable.Sum(source, arg => arg.X);
            byte SumExpected = (byte) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumbyteList2()
        {
            var source = ZEnumerable.Repeat((byte) 1, 2).ToList();
            byte SumActual = ZEnumerable.Sum(source);
            byte SumExpected = (byte) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumbyteList2Map()
        {
            var source = ZEnumerable.Repeat(new { X = (byte) 1 } , 2).ToList();
            byte SumActual = ZEnumerable.Sum(source, arg => arg.X);
            byte SumExpected = (byte) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumbyteList3()
        {
            var source = ZEnumerable.Repeat((byte) 1, 3).ToList();
            byte SumActual = ZEnumerable.Sum(source);
            byte SumExpected = (byte) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumbyteList3Map()
        {
            var source = ZEnumerable.Repeat(new { X = (byte) 1 } , 3).ToList();
            byte SumActual = ZEnumerable.Sum(source, arg => arg.X);
            byte SumExpected = (byte) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumbyteList4()
        {
            var source = ZEnumerable.Repeat((byte) 1, 4).ToList();
            byte SumActual = ZEnumerable.Sum(source);
            byte SumExpected = (byte) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumbyteList4Map()
        {
            var source = ZEnumerable.Repeat(new { X = (byte) 1 } , 4).ToList();
            byte SumActual = ZEnumerable.Sum(source, arg => arg.X);
            byte SumExpected = (byte) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
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
        public void TestSumbyteListNullOrEmpty()
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

            List<byte> emptySource = new byte[0].ToList();
            var sum = ZEnumerable.Sum(emptySource);
            Assert.AreEqual(sum, (byte) 0);
        }

        [TestMethod]
        public void TestSumbyteListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<byte,byte>((byte) arg, (byte) arg)).ToList();
            Func<KeyValuePair<byte, byte>, byte> nullMap = null;
            List<byte> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            try
            {
                ZEnumerable.Sum(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            
            var emptySource = source.Take(0).ToList();
            var sum = ZEnumerable.Sum(emptySource, x => (byte) x.Key);
            Assert.AreEqual(sum, (byte) 0);           
        }

            

        
                        
            
        [TestMethod]
        public void TestSumbyteIList1()
        {
            var source = ZEnumerable.Repeat((byte) 1, 1).ToIList();
            byte SumActual = ZEnumerable.Sum(source);
            byte SumExpected = (byte) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumbyteIList1Map()
        {
            var source = ZEnumerable.Repeat(new { X = (byte) 1 } , 1).ToIList();
            byte SumActual = ZEnumerable.Sum(source, arg => arg.X);
            byte SumExpected = (byte) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumbyteIList2()
        {
            var source = ZEnumerable.Repeat((byte) 1, 2).ToIList();
            byte SumActual = ZEnumerable.Sum(source);
            byte SumExpected = (byte) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumbyteIList2Map()
        {
            var source = ZEnumerable.Repeat(new { X = (byte) 1 } , 2).ToIList();
            byte SumActual = ZEnumerable.Sum(source, arg => arg.X);
            byte SumExpected = (byte) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumbyteIList3()
        {
            var source = ZEnumerable.Repeat((byte) 1, 3).ToIList();
            byte SumActual = ZEnumerable.Sum(source);
            byte SumExpected = (byte) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumbyteIList3Map()
        {
            var source = ZEnumerable.Repeat(new { X = (byte) 1 } , 3).ToIList();
            byte SumActual = ZEnumerable.Sum(source, arg => arg.X);
            byte SumExpected = (byte) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumbyteIList4()
        {
            var source = ZEnumerable.Repeat((byte) 1, 4).ToIList();
            byte SumActual = ZEnumerable.Sum(source);
            byte SumExpected = (byte) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumbyteIList4Map()
        {
            var source = ZEnumerable.Repeat(new { X = (byte) 1 } , 4).ToIList();
            byte SumActual = ZEnumerable.Sum(source, arg => arg.X);
            byte SumExpected = (byte) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
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
        public void TestSumbyteIListNullOrEmpty()
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

            IList<byte> emptySource = new byte[0].ToIList();
            var sum = ZEnumerable.Sum(emptySource);
            Assert.AreEqual(sum, (byte) 0);
        }

        [TestMethod]
        public void TestSumbyteIListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<byte,byte>((byte) arg, (byte) arg)).ToIList();
            Func<KeyValuePair<byte, byte>, byte> nullMap = null;
            IList<byte> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            try
            {
                ZEnumerable.Sum(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            
            var emptySource = source.Take(0).ToIList();
            var sum = ZEnumerable.Sum(emptySource, x => (byte) x.Key);
            Assert.AreEqual(sum, (byte) 0);           
        }

                
        #endregion
            #region short             
            

        
                        
            
        [TestMethod]
        public void TestSumshortArray1()
        {
            var source = ZEnumerable.Repeat((short) 1, 1).ToArray();
            short SumActual = ZEnumerable.Sum(source);
            short SumExpected = (short) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumshortArray1Map()
        {
            var source = ZEnumerable.Repeat(new { X = (short) 1 } , 1).ToArray();
            short SumActual = ZEnumerable.Sum(source, arg => arg.X);
            short SumExpected = (short) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumshortArray2()
        {
            var source = ZEnumerable.Repeat((short) 1, 2).ToArray();
            short SumActual = ZEnumerable.Sum(source);
            short SumExpected = (short) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumshortArray2Map()
        {
            var source = ZEnumerable.Repeat(new { X = (short) 1 } , 2).ToArray();
            short SumActual = ZEnumerable.Sum(source, arg => arg.X);
            short SumExpected = (short) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumshortArray3()
        {
            var source = ZEnumerable.Repeat((short) 1, 3).ToArray();
            short SumActual = ZEnumerable.Sum(source);
            short SumExpected = (short) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumshortArray3Map()
        {
            var source = ZEnumerable.Repeat(new { X = (short) 1 } , 3).ToArray();
            short SumActual = ZEnumerable.Sum(source, arg => arg.X);
            short SumExpected = (short) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumshortArray4()
        {
            var source = ZEnumerable.Repeat((short) 1, 4).ToArray();
            short SumActual = ZEnumerable.Sum(source);
            short SumExpected = (short) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumshortArray4Map()
        {
            var source = ZEnumerable.Repeat(new { X = (short) 1 } , 4).ToArray();
            short SumActual = ZEnumerable.Sum(source, arg => arg.X);
            short SumExpected = (short) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
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
        public void TestSumshortArray2048()
        {
            var source = ZEnumerable.Repeat((short) 1, 2048).ToArray();
            short SumActual = ZEnumerable.Sum(source);
            short SumExpected = (short) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumshortArray2048Map()
        {
            var source = ZEnumerable.Repeat(new { X = (short) 1 } , 2048).ToArray();
            short SumActual = ZEnumerable.Sum(source, arg => arg.X);
            short SumExpected = (short) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
            
        [TestMethod]
        public void TestSumshortArrayNullOrEmpty()
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

            short[] emptySource = new short[0].ToArray();
            var sum = ZEnumerable.Sum(emptySource);
            Assert.AreEqual(sum, (short) 0);
        }

        [TestMethod]
        public void TestSumshortArrayMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<short,short>((short) arg, (short) arg)).ToArray();
            Func<KeyValuePair<short, short>, short> nullMap = null;
            short[] nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            try
            {
                ZEnumerable.Sum(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            
            var emptySource = source.Take(0).ToArray();
            var sum = ZEnumerable.Sum(emptySource, x => (short) x.Key);
            Assert.AreEqual(sum, (short) 0);           
        }

            

        
                        
            
        [TestMethod]
        public void TestSumshortList1()
        {
            var source = ZEnumerable.Repeat((short) 1, 1).ToList();
            short SumActual = ZEnumerable.Sum(source);
            short SumExpected = (short) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumshortList1Map()
        {
            var source = ZEnumerable.Repeat(new { X = (short) 1 } , 1).ToList();
            short SumActual = ZEnumerable.Sum(source, arg => arg.X);
            short SumExpected = (short) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumshortList2()
        {
            var source = ZEnumerable.Repeat((short) 1, 2).ToList();
            short SumActual = ZEnumerable.Sum(source);
            short SumExpected = (short) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumshortList2Map()
        {
            var source = ZEnumerable.Repeat(new { X = (short) 1 } , 2).ToList();
            short SumActual = ZEnumerable.Sum(source, arg => arg.X);
            short SumExpected = (short) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumshortList3()
        {
            var source = ZEnumerable.Repeat((short) 1, 3).ToList();
            short SumActual = ZEnumerable.Sum(source);
            short SumExpected = (short) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumshortList3Map()
        {
            var source = ZEnumerable.Repeat(new { X = (short) 1 } , 3).ToList();
            short SumActual = ZEnumerable.Sum(source, arg => arg.X);
            short SumExpected = (short) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumshortList4()
        {
            var source = ZEnumerable.Repeat((short) 1, 4).ToList();
            short SumActual = ZEnumerable.Sum(source);
            short SumExpected = (short) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumshortList4Map()
        {
            var source = ZEnumerable.Repeat(new { X = (short) 1 } , 4).ToList();
            short SumActual = ZEnumerable.Sum(source, arg => arg.X);
            short SumExpected = (short) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
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
        public void TestSumshortList2048()
        {
            var source = ZEnumerable.Repeat((short) 1, 2048).ToList();
            short SumActual = ZEnumerable.Sum(source);
            short SumExpected = (short) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumshortList2048Map()
        {
            var source = ZEnumerable.Repeat(new { X = (short) 1 } , 2048).ToList();
            short SumActual = ZEnumerable.Sum(source, arg => arg.X);
            short SumExpected = (short) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
            
        [TestMethod]
        public void TestSumshortListNullOrEmpty()
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

            List<short> emptySource = new short[0].ToList();
            var sum = ZEnumerable.Sum(emptySource);
            Assert.AreEqual(sum, (short) 0);
        }

        [TestMethod]
        public void TestSumshortListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<short,short>((short) arg, (short) arg)).ToList();
            Func<KeyValuePair<short, short>, short> nullMap = null;
            List<short> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            try
            {
                ZEnumerable.Sum(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            
            var emptySource = source.Take(0).ToList();
            var sum = ZEnumerable.Sum(emptySource, x => (short) x.Key);
            Assert.AreEqual(sum, (short) 0);           
        }

            

        
                        
            
        [TestMethod]
        public void TestSumshortIList1()
        {
            var source = ZEnumerable.Repeat((short) 1, 1).ToIList();
            short SumActual = ZEnumerable.Sum(source);
            short SumExpected = (short) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumshortIList1Map()
        {
            var source = ZEnumerable.Repeat(new { X = (short) 1 } , 1).ToIList();
            short SumActual = ZEnumerable.Sum(source, arg => arg.X);
            short SumExpected = (short) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumshortIList2()
        {
            var source = ZEnumerable.Repeat((short) 1, 2).ToIList();
            short SumActual = ZEnumerable.Sum(source);
            short SumExpected = (short) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumshortIList2Map()
        {
            var source = ZEnumerable.Repeat(new { X = (short) 1 } , 2).ToIList();
            short SumActual = ZEnumerable.Sum(source, arg => arg.X);
            short SumExpected = (short) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumshortIList3()
        {
            var source = ZEnumerable.Repeat((short) 1, 3).ToIList();
            short SumActual = ZEnumerable.Sum(source);
            short SumExpected = (short) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumshortIList3Map()
        {
            var source = ZEnumerable.Repeat(new { X = (short) 1 } , 3).ToIList();
            short SumActual = ZEnumerable.Sum(source, arg => arg.X);
            short SumExpected = (short) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumshortIList4()
        {
            var source = ZEnumerable.Repeat((short) 1, 4).ToIList();
            short SumActual = ZEnumerable.Sum(source);
            short SumExpected = (short) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumshortIList4Map()
        {
            var source = ZEnumerable.Repeat(new { X = (short) 1 } , 4).ToIList();
            short SumActual = ZEnumerable.Sum(source, arg => arg.X);
            short SumExpected = (short) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
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
        public void TestSumshortIList2048()
        {
            var source = ZEnumerable.Repeat((short) 1, 2048).ToIList();
            short SumActual = ZEnumerable.Sum(source);
            short SumExpected = (short) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumshortIList2048Map()
        {
            var source = ZEnumerable.Repeat(new { X = (short) 1 } , 2048).ToIList();
            short SumActual = ZEnumerable.Sum(source, arg => arg.X);
            short SumExpected = (short) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
            
        [TestMethod]
        public void TestSumshortIListNullOrEmpty()
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

            IList<short> emptySource = new short[0].ToIList();
            var sum = ZEnumerable.Sum(emptySource);
            Assert.AreEqual(sum, (short) 0);
        }

        [TestMethod]
        public void TestSumshortIListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<short,short>((short) arg, (short) arg)).ToIList();
            Func<KeyValuePair<short, short>, short> nullMap = null;
            IList<short> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            try
            {
                ZEnumerable.Sum(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            
            var emptySource = source.Take(0).ToIList();
            var sum = ZEnumerable.Sum(emptySource, x => (short) x.Key);
            Assert.AreEqual(sum, (short) 0);           
        }

                
        #endregion
            #region ushort             
            

        
                        
            
        [TestMethod]
        public void TestSumushortArray1()
        {
            var source = ZEnumerable.Repeat((ushort) 1, 1).ToArray();
            ushort SumActual = ZEnumerable.Sum(source);
            ushort SumExpected = (ushort) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumushortArray1Map()
        {
            var source = ZEnumerable.Repeat(new { X = (ushort) 1 } , 1).ToArray();
            ushort SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ushort SumExpected = (ushort) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumushortArray2()
        {
            var source = ZEnumerable.Repeat((ushort) 1, 2).ToArray();
            ushort SumActual = ZEnumerable.Sum(source);
            ushort SumExpected = (ushort) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumushortArray2Map()
        {
            var source = ZEnumerable.Repeat(new { X = (ushort) 1 } , 2).ToArray();
            ushort SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ushort SumExpected = (ushort) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumushortArray3()
        {
            var source = ZEnumerable.Repeat((ushort) 1, 3).ToArray();
            ushort SumActual = ZEnumerable.Sum(source);
            ushort SumExpected = (ushort) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumushortArray3Map()
        {
            var source = ZEnumerable.Repeat(new { X = (ushort) 1 } , 3).ToArray();
            ushort SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ushort SumExpected = (ushort) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumushortArray4()
        {
            var source = ZEnumerable.Repeat((ushort) 1, 4).ToArray();
            ushort SumActual = ZEnumerable.Sum(source);
            ushort SumExpected = (ushort) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumushortArray4Map()
        {
            var source = ZEnumerable.Repeat(new { X = (ushort) 1 } , 4).ToArray();
            ushort SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ushort SumExpected = (ushort) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
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
        public void TestSumushortArray2048()
        {
            var source = ZEnumerable.Repeat((ushort) 1, 2048).ToArray();
            ushort SumActual = ZEnumerable.Sum(source);
            ushort SumExpected = (ushort) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumushortArray2048Map()
        {
            var source = ZEnumerable.Repeat(new { X = (ushort) 1 } , 2048).ToArray();
            ushort SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ushort SumExpected = (ushort) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
            
        [TestMethod]
        public void TestSumushortArrayNullOrEmpty()
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

            ushort[] emptySource = new ushort[0].ToArray();
            var sum = ZEnumerable.Sum(emptySource);
            Assert.AreEqual(sum, (ushort) 0);
        }

        [TestMethod]
        public void TestSumushortArrayMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<ushort,ushort>((ushort) arg, (ushort) arg)).ToArray();
            Func<KeyValuePair<ushort, ushort>, ushort> nullMap = null;
            ushort[] nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            try
            {
                ZEnumerable.Sum(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            
            var emptySource = source.Take(0).ToArray();
            var sum = ZEnumerable.Sum(emptySource, x => (ushort) x.Key);
            Assert.AreEqual(sum, (ushort) 0);           
        }

            

        
                        
            
        [TestMethod]
        public void TestSumushortList1()
        {
            var source = ZEnumerable.Repeat((ushort) 1, 1).ToList();
            ushort SumActual = ZEnumerable.Sum(source);
            ushort SumExpected = (ushort) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumushortList1Map()
        {
            var source = ZEnumerable.Repeat(new { X = (ushort) 1 } , 1).ToList();
            ushort SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ushort SumExpected = (ushort) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumushortList2()
        {
            var source = ZEnumerable.Repeat((ushort) 1, 2).ToList();
            ushort SumActual = ZEnumerable.Sum(source);
            ushort SumExpected = (ushort) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumushortList2Map()
        {
            var source = ZEnumerable.Repeat(new { X = (ushort) 1 } , 2).ToList();
            ushort SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ushort SumExpected = (ushort) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumushortList3()
        {
            var source = ZEnumerable.Repeat((ushort) 1, 3).ToList();
            ushort SumActual = ZEnumerable.Sum(source);
            ushort SumExpected = (ushort) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumushortList3Map()
        {
            var source = ZEnumerable.Repeat(new { X = (ushort) 1 } , 3).ToList();
            ushort SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ushort SumExpected = (ushort) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumushortList4()
        {
            var source = ZEnumerable.Repeat((ushort) 1, 4).ToList();
            ushort SumActual = ZEnumerable.Sum(source);
            ushort SumExpected = (ushort) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumushortList4Map()
        {
            var source = ZEnumerable.Repeat(new { X = (ushort) 1 } , 4).ToList();
            ushort SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ushort SumExpected = (ushort) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
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
        public void TestSumushortList2048()
        {
            var source = ZEnumerable.Repeat((ushort) 1, 2048).ToList();
            ushort SumActual = ZEnumerable.Sum(source);
            ushort SumExpected = (ushort) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumushortList2048Map()
        {
            var source = ZEnumerable.Repeat(new { X = (ushort) 1 } , 2048).ToList();
            ushort SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ushort SumExpected = (ushort) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
            
        [TestMethod]
        public void TestSumushortListNullOrEmpty()
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

            List<ushort> emptySource = new ushort[0].ToList();
            var sum = ZEnumerable.Sum(emptySource);
            Assert.AreEqual(sum, (ushort) 0);
        }

        [TestMethod]
        public void TestSumushortListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<ushort,ushort>((ushort) arg, (ushort) arg)).ToList();
            Func<KeyValuePair<ushort, ushort>, ushort> nullMap = null;
            List<ushort> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            try
            {
                ZEnumerable.Sum(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            
            var emptySource = source.Take(0).ToList();
            var sum = ZEnumerable.Sum(emptySource, x => (ushort) x.Key);
            Assert.AreEqual(sum, (ushort) 0);           
        }

            

        
                        
            
        [TestMethod]
        public void TestSumushortIList1()
        {
            var source = ZEnumerable.Repeat((ushort) 1, 1).ToIList();
            ushort SumActual = ZEnumerable.Sum(source);
            ushort SumExpected = (ushort) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumushortIList1Map()
        {
            var source = ZEnumerable.Repeat(new { X = (ushort) 1 } , 1).ToIList();
            ushort SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ushort SumExpected = (ushort) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumushortIList2()
        {
            var source = ZEnumerable.Repeat((ushort) 1, 2).ToIList();
            ushort SumActual = ZEnumerable.Sum(source);
            ushort SumExpected = (ushort) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumushortIList2Map()
        {
            var source = ZEnumerable.Repeat(new { X = (ushort) 1 } , 2).ToIList();
            ushort SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ushort SumExpected = (ushort) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumushortIList3()
        {
            var source = ZEnumerable.Repeat((ushort) 1, 3).ToIList();
            ushort SumActual = ZEnumerable.Sum(source);
            ushort SumExpected = (ushort) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumushortIList3Map()
        {
            var source = ZEnumerable.Repeat(new { X = (ushort) 1 } , 3).ToIList();
            ushort SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ushort SumExpected = (ushort) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumushortIList4()
        {
            var source = ZEnumerable.Repeat((ushort) 1, 4).ToIList();
            ushort SumActual = ZEnumerable.Sum(source);
            ushort SumExpected = (ushort) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumushortIList4Map()
        {
            var source = ZEnumerable.Repeat(new { X = (ushort) 1 } , 4).ToIList();
            ushort SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ushort SumExpected = (ushort) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
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
        public void TestSumushortIList2048()
        {
            var source = ZEnumerable.Repeat((ushort) 1, 2048).ToIList();
            ushort SumActual = ZEnumerable.Sum(source);
            ushort SumExpected = (ushort) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumushortIList2048Map()
        {
            var source = ZEnumerable.Repeat(new { X = (ushort) 1 } , 2048).ToIList();
            ushort SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ushort SumExpected = (ushort) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
            
        [TestMethod]
        public void TestSumushortIListNullOrEmpty()
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

            IList<ushort> emptySource = new ushort[0].ToIList();
            var sum = ZEnumerable.Sum(emptySource);
            Assert.AreEqual(sum, (ushort) 0);
        }

        [TestMethod]
        public void TestSumushortIListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<ushort,ushort>((ushort) arg, (ushort) arg)).ToIList();
            Func<KeyValuePair<ushort, ushort>, ushort> nullMap = null;
            IList<ushort> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            try
            {
                ZEnumerable.Sum(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            
            var emptySource = source.Take(0).ToIList();
            var sum = ZEnumerable.Sum(emptySource, x => (ushort) x.Key);
            Assert.AreEqual(sum, (ushort) 0);           
        }

                
        #endregion
            #region int             
            

        
                        
            
        [TestMethod]
        public void TestSumintArray1()
        {
            var source = ZEnumerable.Repeat((int) 1, 1).ToArray();
            int SumActual = ZEnumerable.Sum(source);
            int SumExpected = (int) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumintArray1Map()
        {
            var source = ZEnumerable.Repeat(new { X = (int) 1 } , 1).ToArray();
            int SumActual = ZEnumerable.Sum(source, arg => arg.X);
            int SumExpected = (int) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumintArray2()
        {
            var source = ZEnumerable.Repeat((int) 1, 2).ToArray();
            int SumActual = ZEnumerable.Sum(source);
            int SumExpected = (int) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumintArray2Map()
        {
            var source = ZEnumerable.Repeat(new { X = (int) 1 } , 2).ToArray();
            int SumActual = ZEnumerable.Sum(source, arg => arg.X);
            int SumExpected = (int) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumintArray3()
        {
            var source = ZEnumerable.Repeat((int) 1, 3).ToArray();
            int SumActual = ZEnumerable.Sum(source);
            int SumExpected = (int) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumintArray3Map()
        {
            var source = ZEnumerable.Repeat(new { X = (int) 1 } , 3).ToArray();
            int SumActual = ZEnumerable.Sum(source, arg => arg.X);
            int SumExpected = (int) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumintArray4()
        {
            var source = ZEnumerable.Repeat((int) 1, 4).ToArray();
            int SumActual = ZEnumerable.Sum(source);
            int SumExpected = (int) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumintArray4Map()
        {
            var source = ZEnumerable.Repeat(new { X = (int) 1 } , 4).ToArray();
            int SumActual = ZEnumerable.Sum(source, arg => arg.X);
            int SumExpected = (int) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
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
        public void TestSumintArray2048()
        {
            var source = ZEnumerable.Repeat((int) 1, 2048).ToArray();
            int SumActual = ZEnumerable.Sum(source);
            int SumExpected = (int) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumintArray2048Map()
        {
            var source = ZEnumerable.Repeat(new { X = (int) 1 } , 2048).ToArray();
            int SumActual = ZEnumerable.Sum(source, arg => arg.X);
            int SumExpected = (int) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
            
        [TestMethod]
        public void TestSumintArrayNullOrEmpty()
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

            int[] emptySource = new int[0].ToArray();
            var sum = ZEnumerable.Sum(emptySource);
            Assert.AreEqual(sum, (int) 0);
        }

        [TestMethod]
        public void TestSumintArrayMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<int,int>((int) arg, (int) arg)).ToArray();
            Func<KeyValuePair<int, int>, int> nullMap = null;
            int[] nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            try
            {
                ZEnumerable.Sum(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            
            var emptySource = source.Take(0).ToArray();
            var sum = ZEnumerable.Sum(emptySource, x => (int) x.Key);
            Assert.AreEqual(sum, (int) 0);           
        }

            

        
                        
            
        [TestMethod]
        public void TestSumintList1()
        {
            var source = ZEnumerable.Repeat((int) 1, 1).ToList();
            int SumActual = ZEnumerable.Sum(source);
            int SumExpected = (int) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumintList1Map()
        {
            var source = ZEnumerable.Repeat(new { X = (int) 1 } , 1).ToList();
            int SumActual = ZEnumerable.Sum(source, arg => arg.X);
            int SumExpected = (int) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumintList2()
        {
            var source = ZEnumerable.Repeat((int) 1, 2).ToList();
            int SumActual = ZEnumerable.Sum(source);
            int SumExpected = (int) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumintList2Map()
        {
            var source = ZEnumerable.Repeat(new { X = (int) 1 } , 2).ToList();
            int SumActual = ZEnumerable.Sum(source, arg => arg.X);
            int SumExpected = (int) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumintList3()
        {
            var source = ZEnumerable.Repeat((int) 1, 3).ToList();
            int SumActual = ZEnumerable.Sum(source);
            int SumExpected = (int) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumintList3Map()
        {
            var source = ZEnumerable.Repeat(new { X = (int) 1 } , 3).ToList();
            int SumActual = ZEnumerable.Sum(source, arg => arg.X);
            int SumExpected = (int) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumintList4()
        {
            var source = ZEnumerable.Repeat((int) 1, 4).ToList();
            int SumActual = ZEnumerable.Sum(source);
            int SumExpected = (int) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumintList4Map()
        {
            var source = ZEnumerable.Repeat(new { X = (int) 1 } , 4).ToList();
            int SumActual = ZEnumerable.Sum(source, arg => arg.X);
            int SumExpected = (int) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
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
        public void TestSumintList2048()
        {
            var source = ZEnumerable.Repeat((int) 1, 2048).ToList();
            int SumActual = ZEnumerable.Sum(source);
            int SumExpected = (int) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumintList2048Map()
        {
            var source = ZEnumerable.Repeat(new { X = (int) 1 } , 2048).ToList();
            int SumActual = ZEnumerable.Sum(source, arg => arg.X);
            int SumExpected = (int) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
            
        [TestMethod]
        public void TestSumintListNullOrEmpty()
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

            List<int> emptySource = new int[0].ToList();
            var sum = ZEnumerable.Sum(emptySource);
            Assert.AreEqual(sum, (int) 0);
        }

        [TestMethod]
        public void TestSumintListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<int,int>((int) arg, (int) arg)).ToList();
            Func<KeyValuePair<int, int>, int> nullMap = null;
            List<int> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            try
            {
                ZEnumerable.Sum(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            
            var emptySource = source.Take(0).ToList();
            var sum = ZEnumerable.Sum(emptySource, x => (int) x.Key);
            Assert.AreEqual(sum, (int) 0);           
        }

            

        
                        
            
        [TestMethod]
        public void TestSumintIList1()
        {
            var source = ZEnumerable.Repeat((int) 1, 1).ToIList();
            int SumActual = ZEnumerable.Sum(source);
            int SumExpected = (int) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumintIList1Map()
        {
            var source = ZEnumerable.Repeat(new { X = (int) 1 } , 1).ToIList();
            int SumActual = ZEnumerable.Sum(source, arg => arg.X);
            int SumExpected = (int) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumintIList2()
        {
            var source = ZEnumerable.Repeat((int) 1, 2).ToIList();
            int SumActual = ZEnumerable.Sum(source);
            int SumExpected = (int) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumintIList2Map()
        {
            var source = ZEnumerable.Repeat(new { X = (int) 1 } , 2).ToIList();
            int SumActual = ZEnumerable.Sum(source, arg => arg.X);
            int SumExpected = (int) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumintIList3()
        {
            var source = ZEnumerable.Repeat((int) 1, 3).ToIList();
            int SumActual = ZEnumerable.Sum(source);
            int SumExpected = (int) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumintIList3Map()
        {
            var source = ZEnumerable.Repeat(new { X = (int) 1 } , 3).ToIList();
            int SumActual = ZEnumerable.Sum(source, arg => arg.X);
            int SumExpected = (int) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumintIList4()
        {
            var source = ZEnumerable.Repeat((int) 1, 4).ToIList();
            int SumActual = ZEnumerable.Sum(source);
            int SumExpected = (int) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumintIList4Map()
        {
            var source = ZEnumerable.Repeat(new { X = (int) 1 } , 4).ToIList();
            int SumActual = ZEnumerable.Sum(source, arg => arg.X);
            int SumExpected = (int) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
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
        public void TestSumintIList2048()
        {
            var source = ZEnumerable.Repeat((int) 1, 2048).ToIList();
            int SumActual = ZEnumerable.Sum(source);
            int SumExpected = (int) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumintIList2048Map()
        {
            var source = ZEnumerable.Repeat(new { X = (int) 1 } , 2048).ToIList();
            int SumActual = ZEnumerable.Sum(source, arg => arg.X);
            int SumExpected = (int) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
            
        [TestMethod]
        public void TestSumintIListNullOrEmpty()
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

            IList<int> emptySource = new int[0].ToIList();
            var sum = ZEnumerable.Sum(emptySource);
            Assert.AreEqual(sum, (int) 0);
        }

        [TestMethod]
        public void TestSumintIListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<int,int>((int) arg, (int) arg)).ToIList();
            Func<KeyValuePair<int, int>, int> nullMap = null;
            IList<int> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            try
            {
                ZEnumerable.Sum(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            
            var emptySource = source.Take(0).ToIList();
            var sum = ZEnumerable.Sum(emptySource, x => (int) x.Key);
            Assert.AreEqual(sum, (int) 0);           
        }

                
        #endregion
            #region uint             
            

        
                        
            
        [TestMethod]
        public void TestSumuintArray1()
        {
            var source = ZEnumerable.Repeat((uint) 1, 1).ToArray();
            uint SumActual = ZEnumerable.Sum(source);
            uint SumExpected = (uint) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumuintArray1Map()
        {
            var source = ZEnumerable.Repeat(new { X = (uint) 1 } , 1).ToArray();
            uint SumActual = ZEnumerable.Sum(source, arg => arg.X);
            uint SumExpected = (uint) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumuintArray2()
        {
            var source = ZEnumerable.Repeat((uint) 1, 2).ToArray();
            uint SumActual = ZEnumerable.Sum(source);
            uint SumExpected = (uint) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumuintArray2Map()
        {
            var source = ZEnumerable.Repeat(new { X = (uint) 1 } , 2).ToArray();
            uint SumActual = ZEnumerable.Sum(source, arg => arg.X);
            uint SumExpected = (uint) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumuintArray3()
        {
            var source = ZEnumerable.Repeat((uint) 1, 3).ToArray();
            uint SumActual = ZEnumerable.Sum(source);
            uint SumExpected = (uint) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumuintArray3Map()
        {
            var source = ZEnumerable.Repeat(new { X = (uint) 1 } , 3).ToArray();
            uint SumActual = ZEnumerable.Sum(source, arg => arg.X);
            uint SumExpected = (uint) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumuintArray4()
        {
            var source = ZEnumerable.Repeat((uint) 1, 4).ToArray();
            uint SumActual = ZEnumerable.Sum(source);
            uint SumExpected = (uint) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumuintArray4Map()
        {
            var source = ZEnumerable.Repeat(new { X = (uint) 1 } , 4).ToArray();
            uint SumActual = ZEnumerable.Sum(source, arg => arg.X);
            uint SumExpected = (uint) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
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
        public void TestSumuintArray2048()
        {
            var source = ZEnumerable.Repeat((uint) 1, 2048).ToArray();
            uint SumActual = ZEnumerable.Sum(source);
            uint SumExpected = (uint) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumuintArray2048Map()
        {
            var source = ZEnumerable.Repeat(new { X = (uint) 1 } , 2048).ToArray();
            uint SumActual = ZEnumerable.Sum(source, arg => arg.X);
            uint SumExpected = (uint) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
            
        [TestMethod]
        public void TestSumuintArrayNullOrEmpty()
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

            uint[] emptySource = new uint[0].ToArray();
            var sum = ZEnumerable.Sum(emptySource);
            Assert.AreEqual(sum, (uint) 0);
        }

        [TestMethod]
        public void TestSumuintArrayMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<uint,uint>((uint) arg, (uint) arg)).ToArray();
            Func<KeyValuePair<uint, uint>, uint> nullMap = null;
            uint[] nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            try
            {
                ZEnumerable.Sum(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            
            var emptySource = source.Take(0).ToArray();
            var sum = ZEnumerable.Sum(emptySource, x => (uint) x.Key);
            Assert.AreEqual(sum, (uint) 0);           
        }

            

        
                        
            
        [TestMethod]
        public void TestSumuintList1()
        {
            var source = ZEnumerable.Repeat((uint) 1, 1).ToList();
            uint SumActual = ZEnumerable.Sum(source);
            uint SumExpected = (uint) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumuintList1Map()
        {
            var source = ZEnumerable.Repeat(new { X = (uint) 1 } , 1).ToList();
            uint SumActual = ZEnumerable.Sum(source, arg => arg.X);
            uint SumExpected = (uint) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumuintList2()
        {
            var source = ZEnumerable.Repeat((uint) 1, 2).ToList();
            uint SumActual = ZEnumerable.Sum(source);
            uint SumExpected = (uint) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumuintList2Map()
        {
            var source = ZEnumerable.Repeat(new { X = (uint) 1 } , 2).ToList();
            uint SumActual = ZEnumerable.Sum(source, arg => arg.X);
            uint SumExpected = (uint) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumuintList3()
        {
            var source = ZEnumerable.Repeat((uint) 1, 3).ToList();
            uint SumActual = ZEnumerable.Sum(source);
            uint SumExpected = (uint) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumuintList3Map()
        {
            var source = ZEnumerable.Repeat(new { X = (uint) 1 } , 3).ToList();
            uint SumActual = ZEnumerable.Sum(source, arg => arg.X);
            uint SumExpected = (uint) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumuintList4()
        {
            var source = ZEnumerable.Repeat((uint) 1, 4).ToList();
            uint SumActual = ZEnumerable.Sum(source);
            uint SumExpected = (uint) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumuintList4Map()
        {
            var source = ZEnumerable.Repeat(new { X = (uint) 1 } , 4).ToList();
            uint SumActual = ZEnumerable.Sum(source, arg => arg.X);
            uint SumExpected = (uint) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
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
        public void TestSumuintList2048()
        {
            var source = ZEnumerable.Repeat((uint) 1, 2048).ToList();
            uint SumActual = ZEnumerable.Sum(source);
            uint SumExpected = (uint) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumuintList2048Map()
        {
            var source = ZEnumerable.Repeat(new { X = (uint) 1 } , 2048).ToList();
            uint SumActual = ZEnumerable.Sum(source, arg => arg.X);
            uint SumExpected = (uint) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
            
        [TestMethod]
        public void TestSumuintListNullOrEmpty()
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

            List<uint> emptySource = new uint[0].ToList();
            var sum = ZEnumerable.Sum(emptySource);
            Assert.AreEqual(sum, (uint) 0);
        }

        [TestMethod]
        public void TestSumuintListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<uint,uint>((uint) arg, (uint) arg)).ToList();
            Func<KeyValuePair<uint, uint>, uint> nullMap = null;
            List<uint> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            try
            {
                ZEnumerable.Sum(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            
            var emptySource = source.Take(0).ToList();
            var sum = ZEnumerable.Sum(emptySource, x => (uint) x.Key);
            Assert.AreEqual(sum, (uint) 0);           
        }

            

        
                        
            
        [TestMethod]
        public void TestSumuintIList1()
        {
            var source = ZEnumerable.Repeat((uint) 1, 1).ToIList();
            uint SumActual = ZEnumerable.Sum(source);
            uint SumExpected = (uint) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumuintIList1Map()
        {
            var source = ZEnumerable.Repeat(new { X = (uint) 1 } , 1).ToIList();
            uint SumActual = ZEnumerable.Sum(source, arg => arg.X);
            uint SumExpected = (uint) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumuintIList2()
        {
            var source = ZEnumerable.Repeat((uint) 1, 2).ToIList();
            uint SumActual = ZEnumerable.Sum(source);
            uint SumExpected = (uint) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumuintIList2Map()
        {
            var source = ZEnumerable.Repeat(new { X = (uint) 1 } , 2).ToIList();
            uint SumActual = ZEnumerable.Sum(source, arg => arg.X);
            uint SumExpected = (uint) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumuintIList3()
        {
            var source = ZEnumerable.Repeat((uint) 1, 3).ToIList();
            uint SumActual = ZEnumerable.Sum(source);
            uint SumExpected = (uint) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumuintIList3Map()
        {
            var source = ZEnumerable.Repeat(new { X = (uint) 1 } , 3).ToIList();
            uint SumActual = ZEnumerable.Sum(source, arg => arg.X);
            uint SumExpected = (uint) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumuintIList4()
        {
            var source = ZEnumerable.Repeat((uint) 1, 4).ToIList();
            uint SumActual = ZEnumerable.Sum(source);
            uint SumExpected = (uint) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumuintIList4Map()
        {
            var source = ZEnumerable.Repeat(new { X = (uint) 1 } , 4).ToIList();
            uint SumActual = ZEnumerable.Sum(source, arg => arg.X);
            uint SumExpected = (uint) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
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
        public void TestSumuintIList2048()
        {
            var source = ZEnumerable.Repeat((uint) 1, 2048).ToIList();
            uint SumActual = ZEnumerable.Sum(source);
            uint SumExpected = (uint) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumuintIList2048Map()
        {
            var source = ZEnumerable.Repeat(new { X = (uint) 1 } , 2048).ToIList();
            uint SumActual = ZEnumerable.Sum(source, arg => arg.X);
            uint SumExpected = (uint) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
            
        [TestMethod]
        public void TestSumuintIListNullOrEmpty()
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

            IList<uint> emptySource = new uint[0].ToIList();
            var sum = ZEnumerable.Sum(emptySource);
            Assert.AreEqual(sum, (uint) 0);
        }

        [TestMethod]
        public void TestSumuintIListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<uint,uint>((uint) arg, (uint) arg)).ToIList();
            Func<KeyValuePair<uint, uint>, uint> nullMap = null;
            IList<uint> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            try
            {
                ZEnumerable.Sum(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            
            var emptySource = source.Take(0).ToIList();
            var sum = ZEnumerable.Sum(emptySource, x => (uint) x.Key);
            Assert.AreEqual(sum, (uint) 0);           
        }

                
        #endregion
            #region long             
            

        
                        
            
        [TestMethod]
        public void TestSumlongArray1()
        {
            var source = ZEnumerable.Repeat((long) 1, 1).ToArray();
            long SumActual = ZEnumerable.Sum(source);
            long SumExpected = (long) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumlongArray1Map()
        {
            var source = ZEnumerable.Repeat(new { X = (long) 1 } , 1).ToArray();
            long SumActual = ZEnumerable.Sum(source, arg => arg.X);
            long SumExpected = (long) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumlongArray2()
        {
            var source = ZEnumerable.Repeat((long) 1, 2).ToArray();
            long SumActual = ZEnumerable.Sum(source);
            long SumExpected = (long) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumlongArray2Map()
        {
            var source = ZEnumerable.Repeat(new { X = (long) 1 } , 2).ToArray();
            long SumActual = ZEnumerable.Sum(source, arg => arg.X);
            long SumExpected = (long) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumlongArray3()
        {
            var source = ZEnumerable.Repeat((long) 1, 3).ToArray();
            long SumActual = ZEnumerable.Sum(source);
            long SumExpected = (long) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumlongArray3Map()
        {
            var source = ZEnumerable.Repeat(new { X = (long) 1 } , 3).ToArray();
            long SumActual = ZEnumerable.Sum(source, arg => arg.X);
            long SumExpected = (long) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumlongArray4()
        {
            var source = ZEnumerable.Repeat((long) 1, 4).ToArray();
            long SumActual = ZEnumerable.Sum(source);
            long SumExpected = (long) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumlongArray4Map()
        {
            var source = ZEnumerable.Repeat(new { X = (long) 1 } , 4).ToArray();
            long SumActual = ZEnumerable.Sum(source, arg => arg.X);
            long SumExpected = (long) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
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
        public void TestSumlongArray2048()
        {
            var source = ZEnumerable.Repeat((long) 1, 2048).ToArray();
            long SumActual = ZEnumerable.Sum(source);
            long SumExpected = (long) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumlongArray2048Map()
        {
            var source = ZEnumerable.Repeat(new { X = (long) 1 } , 2048).ToArray();
            long SumActual = ZEnumerable.Sum(source, arg => arg.X);
            long SumExpected = (long) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
            
        [TestMethod]
        public void TestSumlongArrayNullOrEmpty()
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

            long[] emptySource = new long[0].ToArray();
            var sum = ZEnumerable.Sum(emptySource);
            Assert.AreEqual(sum, (long) 0);
        }

        [TestMethod]
        public void TestSumlongArrayMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<long,long>((long) arg, (long) arg)).ToArray();
            Func<KeyValuePair<long, long>, long> nullMap = null;
            long[] nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            try
            {
                ZEnumerable.Sum(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            
            var emptySource = source.Take(0).ToArray();
            var sum = ZEnumerable.Sum(emptySource, x => (long) x.Key);
            Assert.AreEqual(sum, (long) 0);           
        }

            

        
                        
            
        [TestMethod]
        public void TestSumlongList1()
        {
            var source = ZEnumerable.Repeat((long) 1, 1).ToList();
            long SumActual = ZEnumerable.Sum(source);
            long SumExpected = (long) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumlongList1Map()
        {
            var source = ZEnumerable.Repeat(new { X = (long) 1 } , 1).ToList();
            long SumActual = ZEnumerable.Sum(source, arg => arg.X);
            long SumExpected = (long) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumlongList2()
        {
            var source = ZEnumerable.Repeat((long) 1, 2).ToList();
            long SumActual = ZEnumerable.Sum(source);
            long SumExpected = (long) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumlongList2Map()
        {
            var source = ZEnumerable.Repeat(new { X = (long) 1 } , 2).ToList();
            long SumActual = ZEnumerable.Sum(source, arg => arg.X);
            long SumExpected = (long) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumlongList3()
        {
            var source = ZEnumerable.Repeat((long) 1, 3).ToList();
            long SumActual = ZEnumerable.Sum(source);
            long SumExpected = (long) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumlongList3Map()
        {
            var source = ZEnumerable.Repeat(new { X = (long) 1 } , 3).ToList();
            long SumActual = ZEnumerable.Sum(source, arg => arg.X);
            long SumExpected = (long) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumlongList4()
        {
            var source = ZEnumerable.Repeat((long) 1, 4).ToList();
            long SumActual = ZEnumerable.Sum(source);
            long SumExpected = (long) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumlongList4Map()
        {
            var source = ZEnumerable.Repeat(new { X = (long) 1 } , 4).ToList();
            long SumActual = ZEnumerable.Sum(source, arg => arg.X);
            long SumExpected = (long) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
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
        public void TestSumlongList2048()
        {
            var source = ZEnumerable.Repeat((long) 1, 2048).ToList();
            long SumActual = ZEnumerable.Sum(source);
            long SumExpected = (long) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumlongList2048Map()
        {
            var source = ZEnumerable.Repeat(new { X = (long) 1 } , 2048).ToList();
            long SumActual = ZEnumerable.Sum(source, arg => arg.X);
            long SumExpected = (long) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
            
        [TestMethod]
        public void TestSumlongListNullOrEmpty()
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

            List<long> emptySource = new long[0].ToList();
            var sum = ZEnumerable.Sum(emptySource);
            Assert.AreEqual(sum, (long) 0);
        }

        [TestMethod]
        public void TestSumlongListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<long,long>((long) arg, (long) arg)).ToList();
            Func<KeyValuePair<long, long>, long> nullMap = null;
            List<long> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            try
            {
                ZEnumerable.Sum(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            
            var emptySource = source.Take(0).ToList();
            var sum = ZEnumerable.Sum(emptySource, x => (long) x.Key);
            Assert.AreEqual(sum, (long) 0);           
        }

            

        
                        
            
        [TestMethod]
        public void TestSumlongIList1()
        {
            var source = ZEnumerable.Repeat((long) 1, 1).ToIList();
            long SumActual = ZEnumerable.Sum(source);
            long SumExpected = (long) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumlongIList1Map()
        {
            var source = ZEnumerable.Repeat(new { X = (long) 1 } , 1).ToIList();
            long SumActual = ZEnumerable.Sum(source, arg => arg.X);
            long SumExpected = (long) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumlongIList2()
        {
            var source = ZEnumerable.Repeat((long) 1, 2).ToIList();
            long SumActual = ZEnumerable.Sum(source);
            long SumExpected = (long) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumlongIList2Map()
        {
            var source = ZEnumerable.Repeat(new { X = (long) 1 } , 2).ToIList();
            long SumActual = ZEnumerable.Sum(source, arg => arg.X);
            long SumExpected = (long) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumlongIList3()
        {
            var source = ZEnumerable.Repeat((long) 1, 3).ToIList();
            long SumActual = ZEnumerable.Sum(source);
            long SumExpected = (long) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumlongIList3Map()
        {
            var source = ZEnumerable.Repeat(new { X = (long) 1 } , 3).ToIList();
            long SumActual = ZEnumerable.Sum(source, arg => arg.X);
            long SumExpected = (long) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumlongIList4()
        {
            var source = ZEnumerable.Repeat((long) 1, 4).ToIList();
            long SumActual = ZEnumerable.Sum(source);
            long SumExpected = (long) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumlongIList4Map()
        {
            var source = ZEnumerable.Repeat(new { X = (long) 1 } , 4).ToIList();
            long SumActual = ZEnumerable.Sum(source, arg => arg.X);
            long SumExpected = (long) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
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
        public void TestSumlongIList2048()
        {
            var source = ZEnumerable.Repeat((long) 1, 2048).ToIList();
            long SumActual = ZEnumerable.Sum(source);
            long SumExpected = (long) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumlongIList2048Map()
        {
            var source = ZEnumerable.Repeat(new { X = (long) 1 } , 2048).ToIList();
            long SumActual = ZEnumerable.Sum(source, arg => arg.X);
            long SumExpected = (long) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
            
        [TestMethod]
        public void TestSumlongIListNullOrEmpty()
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

            IList<long> emptySource = new long[0].ToIList();
            var sum = ZEnumerable.Sum(emptySource);
            Assert.AreEqual(sum, (long) 0);
        }

        [TestMethod]
        public void TestSumlongIListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<long,long>((long) arg, (long) arg)).ToIList();
            Func<KeyValuePair<long, long>, long> nullMap = null;
            IList<long> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            try
            {
                ZEnumerable.Sum(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            
            var emptySource = source.Take(0).ToIList();
            var sum = ZEnumerable.Sum(emptySource, x => (long) x.Key);
            Assert.AreEqual(sum, (long) 0);           
        }

                
        #endregion
            #region ulong             
            

        
                        
            
        [TestMethod]
        public void TestSumulongArray1()
        {
            var source = ZEnumerable.Repeat((ulong) 1, 1).ToArray();
            ulong SumActual = ZEnumerable.Sum(source);
            ulong SumExpected = (ulong) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumulongArray1Map()
        {
            var source = ZEnumerable.Repeat(new { X = (ulong) 1 } , 1).ToArray();
            ulong SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ulong SumExpected = (ulong) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumulongArray2()
        {
            var source = ZEnumerable.Repeat((ulong) 1, 2).ToArray();
            ulong SumActual = ZEnumerable.Sum(source);
            ulong SumExpected = (ulong) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumulongArray2Map()
        {
            var source = ZEnumerable.Repeat(new { X = (ulong) 1 } , 2).ToArray();
            ulong SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ulong SumExpected = (ulong) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumulongArray3()
        {
            var source = ZEnumerable.Repeat((ulong) 1, 3).ToArray();
            ulong SumActual = ZEnumerable.Sum(source);
            ulong SumExpected = (ulong) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumulongArray3Map()
        {
            var source = ZEnumerable.Repeat(new { X = (ulong) 1 } , 3).ToArray();
            ulong SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ulong SumExpected = (ulong) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumulongArray4()
        {
            var source = ZEnumerable.Repeat((ulong) 1, 4).ToArray();
            ulong SumActual = ZEnumerable.Sum(source);
            ulong SumExpected = (ulong) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumulongArray4Map()
        {
            var source = ZEnumerable.Repeat(new { X = (ulong) 1 } , 4).ToArray();
            ulong SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ulong SumExpected = (ulong) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
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
        public void TestSumulongArray2048()
        {
            var source = ZEnumerable.Repeat((ulong) 1, 2048).ToArray();
            ulong SumActual = ZEnumerable.Sum(source);
            ulong SumExpected = (ulong) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumulongArray2048Map()
        {
            var source = ZEnumerable.Repeat(new { X = (ulong) 1 } , 2048).ToArray();
            ulong SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ulong SumExpected = (ulong) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
            
        [TestMethod]
        public void TestSumulongArrayNullOrEmpty()
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

            ulong[] emptySource = new ulong[0].ToArray();
            var sum = ZEnumerable.Sum(emptySource);
            Assert.AreEqual(sum, (ulong) 0);
        }

        [TestMethod]
        public void TestSumulongArrayMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<ulong,ulong>((ulong) arg, (ulong) arg)).ToArray();
            Func<KeyValuePair<ulong, ulong>, ulong> nullMap = null;
            ulong[] nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            try
            {
                ZEnumerable.Sum(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            
            var emptySource = source.Take(0).ToArray();
            var sum = ZEnumerable.Sum(emptySource, x => (ulong) x.Key);
            Assert.AreEqual(sum, (ulong) 0);           
        }

            

        
                        
            
        [TestMethod]
        public void TestSumulongList1()
        {
            var source = ZEnumerable.Repeat((ulong) 1, 1).ToList();
            ulong SumActual = ZEnumerable.Sum(source);
            ulong SumExpected = (ulong) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumulongList1Map()
        {
            var source = ZEnumerable.Repeat(new { X = (ulong) 1 } , 1).ToList();
            ulong SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ulong SumExpected = (ulong) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumulongList2()
        {
            var source = ZEnumerable.Repeat((ulong) 1, 2).ToList();
            ulong SumActual = ZEnumerable.Sum(source);
            ulong SumExpected = (ulong) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumulongList2Map()
        {
            var source = ZEnumerable.Repeat(new { X = (ulong) 1 } , 2).ToList();
            ulong SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ulong SumExpected = (ulong) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumulongList3()
        {
            var source = ZEnumerable.Repeat((ulong) 1, 3).ToList();
            ulong SumActual = ZEnumerable.Sum(source);
            ulong SumExpected = (ulong) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumulongList3Map()
        {
            var source = ZEnumerable.Repeat(new { X = (ulong) 1 } , 3).ToList();
            ulong SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ulong SumExpected = (ulong) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumulongList4()
        {
            var source = ZEnumerable.Repeat((ulong) 1, 4).ToList();
            ulong SumActual = ZEnumerable.Sum(source);
            ulong SumExpected = (ulong) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumulongList4Map()
        {
            var source = ZEnumerable.Repeat(new { X = (ulong) 1 } , 4).ToList();
            ulong SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ulong SumExpected = (ulong) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
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
        public void TestSumulongList2048()
        {
            var source = ZEnumerable.Repeat((ulong) 1, 2048).ToList();
            ulong SumActual = ZEnumerable.Sum(source);
            ulong SumExpected = (ulong) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumulongList2048Map()
        {
            var source = ZEnumerable.Repeat(new { X = (ulong) 1 } , 2048).ToList();
            ulong SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ulong SumExpected = (ulong) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
            
        [TestMethod]
        public void TestSumulongListNullOrEmpty()
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

            List<ulong> emptySource = new ulong[0].ToList();
            var sum = ZEnumerable.Sum(emptySource);
            Assert.AreEqual(sum, (ulong) 0);
        }

        [TestMethod]
        public void TestSumulongListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<ulong,ulong>((ulong) arg, (ulong) arg)).ToList();
            Func<KeyValuePair<ulong, ulong>, ulong> nullMap = null;
            List<ulong> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            try
            {
                ZEnumerable.Sum(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            
            var emptySource = source.Take(0).ToList();
            var sum = ZEnumerable.Sum(emptySource, x => (ulong) x.Key);
            Assert.AreEqual(sum, (ulong) 0);           
        }

            

        
                        
            
        [TestMethod]
        public void TestSumulongIList1()
        {
            var source = ZEnumerable.Repeat((ulong) 1, 1).ToIList();
            ulong SumActual = ZEnumerable.Sum(source);
            ulong SumExpected = (ulong) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumulongIList1Map()
        {
            var source = ZEnumerable.Repeat(new { X = (ulong) 1 } , 1).ToIList();
            ulong SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ulong SumExpected = (ulong) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumulongIList2()
        {
            var source = ZEnumerable.Repeat((ulong) 1, 2).ToIList();
            ulong SumActual = ZEnumerable.Sum(source);
            ulong SumExpected = (ulong) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumulongIList2Map()
        {
            var source = ZEnumerable.Repeat(new { X = (ulong) 1 } , 2).ToIList();
            ulong SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ulong SumExpected = (ulong) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumulongIList3()
        {
            var source = ZEnumerable.Repeat((ulong) 1, 3).ToIList();
            ulong SumActual = ZEnumerable.Sum(source);
            ulong SumExpected = (ulong) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumulongIList3Map()
        {
            var source = ZEnumerable.Repeat(new { X = (ulong) 1 } , 3).ToIList();
            ulong SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ulong SumExpected = (ulong) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumulongIList4()
        {
            var source = ZEnumerable.Repeat((ulong) 1, 4).ToIList();
            ulong SumActual = ZEnumerable.Sum(source);
            ulong SumExpected = (ulong) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumulongIList4Map()
        {
            var source = ZEnumerable.Repeat(new { X = (ulong) 1 } , 4).ToIList();
            ulong SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ulong SumExpected = (ulong) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
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
        public void TestSumulongIList2048()
        {
            var source = ZEnumerable.Repeat((ulong) 1, 2048).ToIList();
            ulong SumActual = ZEnumerable.Sum(source);
            ulong SumExpected = (ulong) Enumerable.Sum(source.Select(x=> (long)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumulongIList2048Map()
        {
            var source = ZEnumerable.Repeat(new { X = (ulong) 1 } , 2048).ToIList();
            ulong SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ulong SumExpected = (ulong) Enumerable.Sum(source, arg => (long) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
            
        [TestMethod]
        public void TestSumulongIListNullOrEmpty()
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

            IList<ulong> emptySource = new ulong[0].ToIList();
            var sum = ZEnumerable.Sum(emptySource);
            Assert.AreEqual(sum, (ulong) 0);
        }

        [TestMethod]
        public void TestSumulongIListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<ulong,ulong>((ulong) arg, (ulong) arg)).ToIList();
            Func<KeyValuePair<ulong, ulong>, ulong> nullMap = null;
            IList<ulong> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            try
            {
                ZEnumerable.Sum(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            
            var emptySource = source.Take(0).ToIList();
            var sum = ZEnumerable.Sum(emptySource, x => (ulong) x.Key);
            Assert.AreEqual(sum, (ulong) 0);           
        }

                
        #endregion
            #region float             
            

        
                        
            
        [TestMethod]
        public void TestSumfloatArray1()
        {
            var source = ZEnumerable.Repeat((float) 1, 1).ToArray();
            float SumActual = ZEnumerable.Sum(source);
            float SumExpected = (float) Enumerable.Sum(source.Select(x=> (double)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumfloatArray1Map()
        {
            var source = ZEnumerable.Repeat(new { X = (float) 1 } , 1).ToArray();
            float SumActual = ZEnumerable.Sum(source, arg => arg.X);
            float SumExpected = (float) Enumerable.Sum(source, arg => (double) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumfloatArray2()
        {
            var source = ZEnumerable.Repeat((float) 1, 2).ToArray();
            float SumActual = ZEnumerable.Sum(source);
            float SumExpected = (float) Enumerable.Sum(source.Select(x=> (double)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumfloatArray2Map()
        {
            var source = ZEnumerable.Repeat(new { X = (float) 1 } , 2).ToArray();
            float SumActual = ZEnumerable.Sum(source, arg => arg.X);
            float SumExpected = (float) Enumerable.Sum(source, arg => (double) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumfloatArray3()
        {
            var source = ZEnumerable.Repeat((float) 1, 3).ToArray();
            float SumActual = ZEnumerable.Sum(source);
            float SumExpected = (float) Enumerable.Sum(source.Select(x=> (double)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumfloatArray3Map()
        {
            var source = ZEnumerable.Repeat(new { X = (float) 1 } , 3).ToArray();
            float SumActual = ZEnumerable.Sum(source, arg => arg.X);
            float SumExpected = (float) Enumerable.Sum(source, arg => (double) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumfloatArray4()
        {
            var source = ZEnumerable.Repeat((float) 1, 4).ToArray();
            float SumActual = ZEnumerable.Sum(source);
            float SumExpected = (float) Enumerable.Sum(source.Select(x=> (double)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumfloatArray4Map()
        {
            var source = ZEnumerable.Repeat(new { X = (float) 1 } , 4).ToArray();
            float SumActual = ZEnumerable.Sum(source, arg => arg.X);
            float SumExpected = (float) Enumerable.Sum(source, arg => (double) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
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
        public void TestSumfloatArray2048()
        {
            var source = ZEnumerable.Repeat((float) 1, 2048).ToArray();
            float SumActual = ZEnumerable.Sum(source);
            float SumExpected = (float) Enumerable.Sum(source.Select(x=> (double)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumfloatArray2048Map()
        {
            var source = ZEnumerable.Repeat(new { X = (float) 1 } , 2048).ToArray();
            float SumActual = ZEnumerable.Sum(source, arg => arg.X);
            float SumExpected = (float) Enumerable.Sum(source, arg => (double) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
            
        [TestMethod]
        public void TestSumfloatArrayNullOrEmpty()
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

            float[] emptySource = new float[0].ToArray();
            var sum = ZEnumerable.Sum(emptySource);
            Assert.AreEqual(sum, (float) 0);
        }

        [TestMethod]
        public void TestSumfloatArrayMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<float,float>((float) arg, (float) arg)).ToArray();
            Func<KeyValuePair<float, float>, float> nullMap = null;
            float[] nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            try
            {
                ZEnumerable.Sum(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            
            var emptySource = source.Take(0).ToArray();
            var sum = ZEnumerable.Sum(emptySource, x => (float) x.Key);
            Assert.AreEqual(sum, (float) 0);           
        }

            

        
                        
            
        [TestMethod]
        public void TestSumfloatList1()
        {
            var source = ZEnumerable.Repeat((float) 1, 1).ToList();
            float SumActual = ZEnumerable.Sum(source);
            float SumExpected = (float) Enumerable.Sum(source.Select(x=> (double)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumfloatList1Map()
        {
            var source = ZEnumerable.Repeat(new { X = (float) 1 } , 1).ToList();
            float SumActual = ZEnumerable.Sum(source, arg => arg.X);
            float SumExpected = (float) Enumerable.Sum(source, arg => (double) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumfloatList2()
        {
            var source = ZEnumerable.Repeat((float) 1, 2).ToList();
            float SumActual = ZEnumerable.Sum(source);
            float SumExpected = (float) Enumerable.Sum(source.Select(x=> (double)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumfloatList2Map()
        {
            var source = ZEnumerable.Repeat(new { X = (float) 1 } , 2).ToList();
            float SumActual = ZEnumerable.Sum(source, arg => arg.X);
            float SumExpected = (float) Enumerable.Sum(source, arg => (double) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumfloatList3()
        {
            var source = ZEnumerable.Repeat((float) 1, 3).ToList();
            float SumActual = ZEnumerable.Sum(source);
            float SumExpected = (float) Enumerable.Sum(source.Select(x=> (double)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumfloatList3Map()
        {
            var source = ZEnumerable.Repeat(new { X = (float) 1 } , 3).ToList();
            float SumActual = ZEnumerable.Sum(source, arg => arg.X);
            float SumExpected = (float) Enumerable.Sum(source, arg => (double) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumfloatList4()
        {
            var source = ZEnumerable.Repeat((float) 1, 4).ToList();
            float SumActual = ZEnumerable.Sum(source);
            float SumExpected = (float) Enumerable.Sum(source.Select(x=> (double)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumfloatList4Map()
        {
            var source = ZEnumerable.Repeat(new { X = (float) 1 } , 4).ToList();
            float SumActual = ZEnumerable.Sum(source, arg => arg.X);
            float SumExpected = (float) Enumerable.Sum(source, arg => (double) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
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
        public void TestSumfloatList2048()
        {
            var source = ZEnumerable.Repeat((float) 1, 2048).ToList();
            float SumActual = ZEnumerable.Sum(source);
            float SumExpected = (float) Enumerable.Sum(source.Select(x=> (double)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumfloatList2048Map()
        {
            var source = ZEnumerable.Repeat(new { X = (float) 1 } , 2048).ToList();
            float SumActual = ZEnumerable.Sum(source, arg => arg.X);
            float SumExpected = (float) Enumerable.Sum(source, arg => (double) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
            
        [TestMethod]
        public void TestSumfloatListNullOrEmpty()
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

            List<float> emptySource = new float[0].ToList();
            var sum = ZEnumerable.Sum(emptySource);
            Assert.AreEqual(sum, (float) 0);
        }

        [TestMethod]
        public void TestSumfloatListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<float,float>((float) arg, (float) arg)).ToList();
            Func<KeyValuePair<float, float>, float> nullMap = null;
            List<float> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            try
            {
                ZEnumerable.Sum(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            
            var emptySource = source.Take(0).ToList();
            var sum = ZEnumerable.Sum(emptySource, x => (float) x.Key);
            Assert.AreEqual(sum, (float) 0);           
        }

            

        
                        
            
        [TestMethod]
        public void TestSumfloatIList1()
        {
            var source = ZEnumerable.Repeat((float) 1, 1).ToIList();
            float SumActual = ZEnumerable.Sum(source);
            float SumExpected = (float) Enumerable.Sum(source.Select(x=> (double)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumfloatIList1Map()
        {
            var source = ZEnumerable.Repeat(new { X = (float) 1 } , 1).ToIList();
            float SumActual = ZEnumerable.Sum(source, arg => arg.X);
            float SumExpected = (float) Enumerable.Sum(source, arg => (double) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumfloatIList2()
        {
            var source = ZEnumerable.Repeat((float) 1, 2).ToIList();
            float SumActual = ZEnumerable.Sum(source);
            float SumExpected = (float) Enumerable.Sum(source.Select(x=> (double)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumfloatIList2Map()
        {
            var source = ZEnumerable.Repeat(new { X = (float) 1 } , 2).ToIList();
            float SumActual = ZEnumerable.Sum(source, arg => arg.X);
            float SumExpected = (float) Enumerable.Sum(source, arg => (double) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumfloatIList3()
        {
            var source = ZEnumerable.Repeat((float) 1, 3).ToIList();
            float SumActual = ZEnumerable.Sum(source);
            float SumExpected = (float) Enumerable.Sum(source.Select(x=> (double)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumfloatIList3Map()
        {
            var source = ZEnumerable.Repeat(new { X = (float) 1 } , 3).ToIList();
            float SumActual = ZEnumerable.Sum(source, arg => arg.X);
            float SumExpected = (float) Enumerable.Sum(source, arg => (double) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumfloatIList4()
        {
            var source = ZEnumerable.Repeat((float) 1, 4).ToIList();
            float SumActual = ZEnumerable.Sum(source);
            float SumExpected = (float) Enumerable.Sum(source.Select(x=> (double)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumfloatIList4Map()
        {
            var source = ZEnumerable.Repeat(new { X = (float) 1 } , 4).ToIList();
            float SumActual = ZEnumerable.Sum(source, arg => arg.X);
            float SumExpected = (float) Enumerable.Sum(source, arg => (double) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
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
        public void TestSumfloatIList2048()
        {
            var source = ZEnumerable.Repeat((float) 1, 2048).ToIList();
            float SumActual = ZEnumerable.Sum(source);
            float SumExpected = (float) Enumerable.Sum(source.Select(x=> (double)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumfloatIList2048Map()
        {
            var source = ZEnumerable.Repeat(new { X = (float) 1 } , 2048).ToIList();
            float SumActual = ZEnumerable.Sum(source, arg => arg.X);
            float SumExpected = (float) Enumerable.Sum(source, arg => (double) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
            
        [TestMethod]
        public void TestSumfloatIListNullOrEmpty()
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

            IList<float> emptySource = new float[0].ToIList();
            var sum = ZEnumerable.Sum(emptySource);
            Assert.AreEqual(sum, (float) 0);
        }

        [TestMethod]
        public void TestSumfloatIListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<float,float>((float) arg, (float) arg)).ToIList();
            Func<KeyValuePair<float, float>, float> nullMap = null;
            IList<float> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            try
            {
                ZEnumerable.Sum(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            
            var emptySource = source.Take(0).ToIList();
            var sum = ZEnumerable.Sum(emptySource, x => (float) x.Key);
            Assert.AreEqual(sum, (float) 0);           
        }

                
        #endregion
            #region double             
            

        
                        
            
        [TestMethod]
        public void TestSumdoubleArray1()
        {
            var source = ZEnumerable.Repeat((double) 1, 1).ToArray();
            double SumActual = ZEnumerable.Sum(source);
            double SumExpected = (double) Enumerable.Sum(source.Select(x=> (double)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdoubleArray1Map()
        {
            var source = ZEnumerable.Repeat(new { X = (double) 1 } , 1).ToArray();
            double SumActual = ZEnumerable.Sum(source, arg => arg.X);
            double SumExpected = (double) Enumerable.Sum(source, arg => (double) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumdoubleArray2()
        {
            var source = ZEnumerable.Repeat((double) 1, 2).ToArray();
            double SumActual = ZEnumerable.Sum(source);
            double SumExpected = (double) Enumerable.Sum(source.Select(x=> (double)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdoubleArray2Map()
        {
            var source = ZEnumerable.Repeat(new { X = (double) 1 } , 2).ToArray();
            double SumActual = ZEnumerable.Sum(source, arg => arg.X);
            double SumExpected = (double) Enumerable.Sum(source, arg => (double) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumdoubleArray3()
        {
            var source = ZEnumerable.Repeat((double) 1, 3).ToArray();
            double SumActual = ZEnumerable.Sum(source);
            double SumExpected = (double) Enumerable.Sum(source.Select(x=> (double)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdoubleArray3Map()
        {
            var source = ZEnumerable.Repeat(new { X = (double) 1 } , 3).ToArray();
            double SumActual = ZEnumerable.Sum(source, arg => arg.X);
            double SumExpected = (double) Enumerable.Sum(source, arg => (double) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumdoubleArray4()
        {
            var source = ZEnumerable.Repeat((double) 1, 4).ToArray();
            double SumActual = ZEnumerable.Sum(source);
            double SumExpected = (double) Enumerable.Sum(source.Select(x=> (double)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdoubleArray4Map()
        {
            var source = ZEnumerable.Repeat(new { X = (double) 1 } , 4).ToArray();
            double SumActual = ZEnumerable.Sum(source, arg => arg.X);
            double SumExpected = (double) Enumerable.Sum(source, arg => (double) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
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
        public void TestSumdoubleArray2048()
        {
            var source = ZEnumerable.Repeat((double) 1, 2048).ToArray();
            double SumActual = ZEnumerable.Sum(source);
            double SumExpected = (double) Enumerable.Sum(source.Select(x=> (double)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdoubleArray2048Map()
        {
            var source = ZEnumerable.Repeat(new { X = (double) 1 } , 2048).ToArray();
            double SumActual = ZEnumerable.Sum(source, arg => arg.X);
            double SumExpected = (double) Enumerable.Sum(source, arg => (double) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
            
        [TestMethod]
        public void TestSumdoubleArrayNullOrEmpty()
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

            double[] emptySource = new double[0].ToArray();
            var sum = ZEnumerable.Sum(emptySource);
            Assert.AreEqual(sum, (double) 0);
        }

        [TestMethod]
        public void TestSumdoubleArrayMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<double,double>((double) arg, (double) arg)).ToArray();
            Func<KeyValuePair<double, double>, double> nullMap = null;
            double[] nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            try
            {
                ZEnumerable.Sum(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            
            var emptySource = source.Take(0).ToArray();
            var sum = ZEnumerable.Sum(emptySource, x => (double) x.Key);
            Assert.AreEqual(sum, (double) 0);           
        }

            

        
                        
            
        [TestMethod]
        public void TestSumdoubleList1()
        {
            var source = ZEnumerable.Repeat((double) 1, 1).ToList();
            double SumActual = ZEnumerable.Sum(source);
            double SumExpected = (double) Enumerable.Sum(source.Select(x=> (double)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdoubleList1Map()
        {
            var source = ZEnumerable.Repeat(new { X = (double) 1 } , 1).ToList();
            double SumActual = ZEnumerable.Sum(source, arg => arg.X);
            double SumExpected = (double) Enumerable.Sum(source, arg => (double) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumdoubleList2()
        {
            var source = ZEnumerable.Repeat((double) 1, 2).ToList();
            double SumActual = ZEnumerable.Sum(source);
            double SumExpected = (double) Enumerable.Sum(source.Select(x=> (double)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdoubleList2Map()
        {
            var source = ZEnumerable.Repeat(new { X = (double) 1 } , 2).ToList();
            double SumActual = ZEnumerable.Sum(source, arg => arg.X);
            double SumExpected = (double) Enumerable.Sum(source, arg => (double) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumdoubleList3()
        {
            var source = ZEnumerable.Repeat((double) 1, 3).ToList();
            double SumActual = ZEnumerable.Sum(source);
            double SumExpected = (double) Enumerable.Sum(source.Select(x=> (double)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdoubleList3Map()
        {
            var source = ZEnumerable.Repeat(new { X = (double) 1 } , 3).ToList();
            double SumActual = ZEnumerable.Sum(source, arg => arg.X);
            double SumExpected = (double) Enumerable.Sum(source, arg => (double) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumdoubleList4()
        {
            var source = ZEnumerable.Repeat((double) 1, 4).ToList();
            double SumActual = ZEnumerable.Sum(source);
            double SumExpected = (double) Enumerable.Sum(source.Select(x=> (double)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdoubleList4Map()
        {
            var source = ZEnumerable.Repeat(new { X = (double) 1 } , 4).ToList();
            double SumActual = ZEnumerable.Sum(source, arg => arg.X);
            double SumExpected = (double) Enumerable.Sum(source, arg => (double) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
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
        public void TestSumdoubleList2048()
        {
            var source = ZEnumerable.Repeat((double) 1, 2048).ToList();
            double SumActual = ZEnumerable.Sum(source);
            double SumExpected = (double) Enumerable.Sum(source.Select(x=> (double)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdoubleList2048Map()
        {
            var source = ZEnumerable.Repeat(new { X = (double) 1 } , 2048).ToList();
            double SumActual = ZEnumerable.Sum(source, arg => arg.X);
            double SumExpected = (double) Enumerable.Sum(source, arg => (double) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
            
        [TestMethod]
        public void TestSumdoubleListNullOrEmpty()
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

            List<double> emptySource = new double[0].ToList();
            var sum = ZEnumerable.Sum(emptySource);
            Assert.AreEqual(sum, (double) 0);
        }

        [TestMethod]
        public void TestSumdoubleListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<double,double>((double) arg, (double) arg)).ToList();
            Func<KeyValuePair<double, double>, double> nullMap = null;
            List<double> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            try
            {
                ZEnumerable.Sum(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            
            var emptySource = source.Take(0).ToList();
            var sum = ZEnumerable.Sum(emptySource, x => (double) x.Key);
            Assert.AreEqual(sum, (double) 0);           
        }

            

        
                        
            
        [TestMethod]
        public void TestSumdoubleIList1()
        {
            var source = ZEnumerable.Repeat((double) 1, 1).ToIList();
            double SumActual = ZEnumerable.Sum(source);
            double SumExpected = (double) Enumerable.Sum(source.Select(x=> (double)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdoubleIList1Map()
        {
            var source = ZEnumerable.Repeat(new { X = (double) 1 } , 1).ToIList();
            double SumActual = ZEnumerable.Sum(source, arg => arg.X);
            double SumExpected = (double) Enumerable.Sum(source, arg => (double) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumdoubleIList2()
        {
            var source = ZEnumerable.Repeat((double) 1, 2).ToIList();
            double SumActual = ZEnumerable.Sum(source);
            double SumExpected = (double) Enumerable.Sum(source.Select(x=> (double)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdoubleIList2Map()
        {
            var source = ZEnumerable.Repeat(new { X = (double) 1 } , 2).ToIList();
            double SumActual = ZEnumerable.Sum(source, arg => arg.X);
            double SumExpected = (double) Enumerable.Sum(source, arg => (double) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumdoubleIList3()
        {
            var source = ZEnumerable.Repeat((double) 1, 3).ToIList();
            double SumActual = ZEnumerable.Sum(source);
            double SumExpected = (double) Enumerable.Sum(source.Select(x=> (double)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdoubleIList3Map()
        {
            var source = ZEnumerable.Repeat(new { X = (double) 1 } , 3).ToIList();
            double SumActual = ZEnumerable.Sum(source, arg => arg.X);
            double SumExpected = (double) Enumerable.Sum(source, arg => (double) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumdoubleIList4()
        {
            var source = ZEnumerable.Repeat((double) 1, 4).ToIList();
            double SumActual = ZEnumerable.Sum(source);
            double SumExpected = (double) Enumerable.Sum(source.Select(x=> (double)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdoubleIList4Map()
        {
            var source = ZEnumerable.Repeat(new { X = (double) 1 } , 4).ToIList();
            double SumActual = ZEnumerable.Sum(source, arg => arg.X);
            double SumExpected = (double) Enumerable.Sum(source, arg => (double) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
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
        public void TestSumdoubleIList2048()
        {
            var source = ZEnumerable.Repeat((double) 1, 2048).ToIList();
            double SumActual = ZEnumerable.Sum(source);
            double SumExpected = (double) Enumerable.Sum(source.Select(x=> (double)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdoubleIList2048Map()
        {
            var source = ZEnumerable.Repeat(new { X = (double) 1 } , 2048).ToIList();
            double SumActual = ZEnumerable.Sum(source, arg => arg.X);
            double SumExpected = (double) Enumerable.Sum(source, arg => (double) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
            
        [TestMethod]
        public void TestSumdoubleIListNullOrEmpty()
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

            IList<double> emptySource = new double[0].ToIList();
            var sum = ZEnumerable.Sum(emptySource);
            Assert.AreEqual(sum, (double) 0);
        }

        [TestMethod]
        public void TestSumdoubleIListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<double,double>((double) arg, (double) arg)).ToIList();
            Func<KeyValuePair<double, double>, double> nullMap = null;
            IList<double> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            try
            {
                ZEnumerable.Sum(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            
            var emptySource = source.Take(0).ToIList();
            var sum = ZEnumerable.Sum(emptySource, x => (double) x.Key);
            Assert.AreEqual(sum, (double) 0);           
        }

                
        #endregion
            #region decimal             
            

        
                        
            
        [TestMethod]
        public void TestSumdecimalArray1()
        {
            var source = ZEnumerable.Repeat((decimal) 1, 1).ToArray();
            decimal SumActual = ZEnumerable.Sum(source);
            decimal SumExpected = (decimal) Enumerable.Sum(source.Select(x=> (double)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdecimalArray1Map()
        {
            var source = ZEnumerable.Repeat(new { X = (decimal) 1 } , 1).ToArray();
            decimal SumActual = ZEnumerable.Sum(source, arg => arg.X);
            decimal SumExpected = (decimal) Enumerable.Sum(source, arg => (double) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumdecimalArray2()
        {
            var source = ZEnumerable.Repeat((decimal) 1, 2).ToArray();
            decimal SumActual = ZEnumerable.Sum(source);
            decimal SumExpected = (decimal) Enumerable.Sum(source.Select(x=> (double)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdecimalArray2Map()
        {
            var source = ZEnumerable.Repeat(new { X = (decimal) 1 } , 2).ToArray();
            decimal SumActual = ZEnumerable.Sum(source, arg => arg.X);
            decimal SumExpected = (decimal) Enumerable.Sum(source, arg => (double) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumdecimalArray3()
        {
            var source = ZEnumerable.Repeat((decimal) 1, 3).ToArray();
            decimal SumActual = ZEnumerable.Sum(source);
            decimal SumExpected = (decimal) Enumerable.Sum(source.Select(x=> (double)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdecimalArray3Map()
        {
            var source = ZEnumerable.Repeat(new { X = (decimal) 1 } , 3).ToArray();
            decimal SumActual = ZEnumerable.Sum(source, arg => arg.X);
            decimal SumExpected = (decimal) Enumerable.Sum(source, arg => (double) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumdecimalArray4()
        {
            var source = ZEnumerable.Repeat((decimal) 1, 4).ToArray();
            decimal SumActual = ZEnumerable.Sum(source);
            decimal SumExpected = (decimal) Enumerable.Sum(source.Select(x=> (double)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdecimalArray4Map()
        {
            var source = ZEnumerable.Repeat(new { X = (decimal) 1 } , 4).ToArray();
            decimal SumActual = ZEnumerable.Sum(source, arg => arg.X);
            decimal SumExpected = (decimal) Enumerable.Sum(source, arg => (double) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
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
        public void TestSumdecimalArray2048()
        {
            var source = ZEnumerable.Repeat((decimal) 1, 2048).ToArray();
            decimal SumActual = ZEnumerable.Sum(source);
            decimal SumExpected = (decimal) Enumerable.Sum(source.Select(x=> (double)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdecimalArray2048Map()
        {
            var source = ZEnumerable.Repeat(new { X = (decimal) 1 } , 2048).ToArray();
            decimal SumActual = ZEnumerable.Sum(source, arg => arg.X);
            decimal SumExpected = (decimal) Enumerable.Sum(source, arg => (double) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
            
        [TestMethod]
        public void TestSumdecimalArrayNullOrEmpty()
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

            decimal[] emptySource = new decimal[0].ToArray();
            var sum = ZEnumerable.Sum(emptySource);
            Assert.AreEqual(sum, (decimal) 0);
        }

        [TestMethod]
        public void TestSumdecimalArrayMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<decimal,decimal>((decimal) arg, (decimal) arg)).ToArray();
            Func<KeyValuePair<decimal, decimal>, decimal> nullMap = null;
            decimal[] nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            try
            {
                ZEnumerable.Sum(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            
            var emptySource = source.Take(0).ToArray();
            var sum = ZEnumerable.Sum(emptySource, x => (decimal) x.Key);
            Assert.AreEqual(sum, (decimal) 0);           
        }

            

        
                        
            
        [TestMethod]
        public void TestSumdecimalList1()
        {
            var source = ZEnumerable.Repeat((decimal) 1, 1).ToList();
            decimal SumActual = ZEnumerable.Sum(source);
            decimal SumExpected = (decimal) Enumerable.Sum(source.Select(x=> (double)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdecimalList1Map()
        {
            var source = ZEnumerable.Repeat(new { X = (decimal) 1 } , 1).ToList();
            decimal SumActual = ZEnumerable.Sum(source, arg => arg.X);
            decimal SumExpected = (decimal) Enumerable.Sum(source, arg => (double) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumdecimalList2()
        {
            var source = ZEnumerable.Repeat((decimal) 1, 2).ToList();
            decimal SumActual = ZEnumerable.Sum(source);
            decimal SumExpected = (decimal) Enumerable.Sum(source.Select(x=> (double)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdecimalList2Map()
        {
            var source = ZEnumerable.Repeat(new { X = (decimal) 1 } , 2).ToList();
            decimal SumActual = ZEnumerable.Sum(source, arg => arg.X);
            decimal SumExpected = (decimal) Enumerable.Sum(source, arg => (double) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumdecimalList3()
        {
            var source = ZEnumerable.Repeat((decimal) 1, 3).ToList();
            decimal SumActual = ZEnumerable.Sum(source);
            decimal SumExpected = (decimal) Enumerable.Sum(source.Select(x=> (double)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdecimalList3Map()
        {
            var source = ZEnumerable.Repeat(new { X = (decimal) 1 } , 3).ToList();
            decimal SumActual = ZEnumerable.Sum(source, arg => arg.X);
            decimal SumExpected = (decimal) Enumerable.Sum(source, arg => (double) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumdecimalList4()
        {
            var source = ZEnumerable.Repeat((decimal) 1, 4).ToList();
            decimal SumActual = ZEnumerable.Sum(source);
            decimal SumExpected = (decimal) Enumerable.Sum(source.Select(x=> (double)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdecimalList4Map()
        {
            var source = ZEnumerable.Repeat(new { X = (decimal) 1 } , 4).ToList();
            decimal SumActual = ZEnumerable.Sum(source, arg => arg.X);
            decimal SumExpected = (decimal) Enumerable.Sum(source, arg => (double) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
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
        public void TestSumdecimalList2048()
        {
            var source = ZEnumerable.Repeat((decimal) 1, 2048).ToList();
            decimal SumActual = ZEnumerable.Sum(source);
            decimal SumExpected = (decimal) Enumerable.Sum(source.Select(x=> (double)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdecimalList2048Map()
        {
            var source = ZEnumerable.Repeat(new { X = (decimal) 1 } , 2048).ToList();
            decimal SumActual = ZEnumerable.Sum(source, arg => arg.X);
            decimal SumExpected = (decimal) Enumerable.Sum(source, arg => (double) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
            
        [TestMethod]
        public void TestSumdecimalListNullOrEmpty()
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

            List<decimal> emptySource = new decimal[0].ToList();
            var sum = ZEnumerable.Sum(emptySource);
            Assert.AreEqual(sum, (decimal) 0);
        }

        [TestMethod]
        public void TestSumdecimalListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<decimal,decimal>((decimal) arg, (decimal) arg)).ToList();
            Func<KeyValuePair<decimal, decimal>, decimal> nullMap = null;
            List<decimal> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            try
            {
                ZEnumerable.Sum(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            
            var emptySource = source.Take(0).ToList();
            var sum = ZEnumerable.Sum(emptySource, x => (decimal) x.Key);
            Assert.AreEqual(sum, (decimal) 0);           
        }

            

        
                        
            
        [TestMethod]
        public void TestSumdecimalIList1()
        {
            var source = ZEnumerable.Repeat((decimal) 1, 1).ToIList();
            decimal SumActual = ZEnumerable.Sum(source);
            decimal SumExpected = (decimal) Enumerable.Sum(source.Select(x=> (double)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdecimalIList1Map()
        {
            var source = ZEnumerable.Repeat(new { X = (decimal) 1 } , 1).ToIList();
            decimal SumActual = ZEnumerable.Sum(source, arg => arg.X);
            decimal SumExpected = (decimal) Enumerable.Sum(source, arg => (double) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumdecimalIList2()
        {
            var source = ZEnumerable.Repeat((decimal) 1, 2).ToIList();
            decimal SumActual = ZEnumerable.Sum(source);
            decimal SumExpected = (decimal) Enumerable.Sum(source.Select(x=> (double)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdecimalIList2Map()
        {
            var source = ZEnumerable.Repeat(new { X = (decimal) 1 } , 2).ToIList();
            decimal SumActual = ZEnumerable.Sum(source, arg => arg.X);
            decimal SumExpected = (decimal) Enumerable.Sum(source, arg => (double) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumdecimalIList3()
        {
            var source = ZEnumerable.Repeat((decimal) 1, 3).ToIList();
            decimal SumActual = ZEnumerable.Sum(source);
            decimal SumExpected = (decimal) Enumerable.Sum(source.Select(x=> (double)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdecimalIList3Map()
        {
            var source = ZEnumerable.Repeat(new { X = (decimal) 1 } , 3).ToIList();
            decimal SumActual = ZEnumerable.Sum(source, arg => arg.X);
            decimal SumExpected = (decimal) Enumerable.Sum(source, arg => (double) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumdecimalIList4()
        {
            var source = ZEnumerable.Repeat((decimal) 1, 4).ToIList();
            decimal SumActual = ZEnumerable.Sum(source);
            decimal SumExpected = (decimal) Enumerable.Sum(source.Select(x=> (double)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdecimalIList4Map()
        {
            var source = ZEnumerable.Repeat(new { X = (decimal) 1 } , 4).ToIList();
            decimal SumActual = ZEnumerable.Sum(source, arg => arg.X);
            decimal SumExpected = (decimal) Enumerable.Sum(source, arg => (double) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
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
        public void TestSumdecimalIList2048()
        {
            var source = ZEnumerable.Repeat((decimal) 1, 2048).ToIList();
            decimal SumActual = ZEnumerable.Sum(source);
            decimal SumExpected = (decimal) Enumerable.Sum(source.Select(x=> (double)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdecimalIList2048Map()
        {
            var source = ZEnumerable.Repeat(new { X = (decimal) 1 } , 2048).ToIList();
            decimal SumActual = ZEnumerable.Sum(source, arg => arg.X);
            decimal SumExpected = (decimal) Enumerable.Sum(source, arg => (double) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
            
        [TestMethod]
        public void TestSumdecimalIListNullOrEmpty()
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

            IList<decimal> emptySource = new decimal[0].ToIList();
            var sum = ZEnumerable.Sum(emptySource);
            Assert.AreEqual(sum, (decimal) 0);
        }

        [TestMethod]
        public void TestSumdecimalIListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<decimal,decimal>((decimal) arg, (decimal) arg)).ToIList();
            Func<KeyValuePair<decimal, decimal>, decimal> nullMap = null;
            IList<decimal> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            try
            {
                ZEnumerable.Sum(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            
            var emptySource = source.Take(0).ToIList();
            var sum = ZEnumerable.Sum(emptySource, x => (decimal) x.Key);
            Assert.AreEqual(sum, (decimal) 0);           
        }

                
        #endregion
            #region sbyte?             
            

        
                        
            
        [TestMethod]
        public void TestSumsbyteNullableArray1ThreatNulls()
        {
            var source = ZEnumerable.Repeat((sbyte?) 1, 1).Select((x, i) => i%3==0 ? x : null).ToArray();
            sbyte? SumActual = ZEnumerable.Sum(source);
            sbyte? SumExpected = (sbyte?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumsbyteNullableArray1ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((sbyte?) 1, 1).Select((x, i) => i%3==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X = x } ).ToArray();
            sbyte? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            sbyte? SumExpected = (sbyte?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumsbyteNullableArray1()
        {
            var source = ZEnumerable.Repeat((sbyte?) 1, 1).ToArray();
            sbyte? SumActual = ZEnumerable.Sum(source);
            sbyte? SumExpected = (sbyte?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumsbyteNullableArray1Map()
        {
            var source = ZEnumerable.Repeat(new { X = (sbyte?) 1 } , 1).ToArray();
            sbyte? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            sbyte? SumExpected = (sbyte?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumsbyteNullableArray2ThreatNulls()
        {
            var source = ZEnumerable.Repeat((sbyte?) 1, 2).Select((x, i) => i%3==0 ? x : null).ToArray();
            sbyte? SumActual = ZEnumerable.Sum(source);
            sbyte? SumExpected = (sbyte?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumsbyteNullableArray2ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((sbyte?) 1, 2).Select((x, i) => i%3==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X = x } ).ToArray();
            sbyte? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            sbyte? SumExpected = (sbyte?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumsbyteNullableArray2()
        {
            var source = ZEnumerable.Repeat((sbyte?) 1, 2).ToArray();
            sbyte? SumActual = ZEnumerable.Sum(source);
            sbyte? SumExpected = (sbyte?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumsbyteNullableArray2Map()
        {
            var source = ZEnumerable.Repeat(new { X = (sbyte?) 1 } , 2).ToArray();
            sbyte? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            sbyte? SumExpected = (sbyte?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumsbyteNullableArray3ThreatNulls()
        {
            var source = ZEnumerable.Repeat((sbyte?) 1, 3).Select((x, i) => i%3==0 ? x : null).ToArray();
            sbyte? SumActual = ZEnumerable.Sum(source);
            sbyte? SumExpected = (sbyte?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumsbyteNullableArray3ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((sbyte?) 1, 3).Select((x, i) => i%3==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X = x } ).ToArray();
            sbyte? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            sbyte? SumExpected = (sbyte?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumsbyteNullableArray3()
        {
            var source = ZEnumerable.Repeat((sbyte?) 1, 3).ToArray();
            sbyte? SumActual = ZEnumerable.Sum(source);
            sbyte? SumExpected = (sbyte?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumsbyteNullableArray3Map()
        {
            var source = ZEnumerable.Repeat(new { X = (sbyte?) 1 } , 3).ToArray();
            sbyte? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            sbyte? SumExpected = (sbyte?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumsbyteNullableArray4ThreatNulls()
        {
            var source = ZEnumerable.Repeat((sbyte?) 1, 4).Select((x, i) => i%3==0 ? x : null).ToArray();
            sbyte? SumActual = ZEnumerable.Sum(source);
            sbyte? SumExpected = (sbyte?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumsbyteNullableArray4ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((sbyte?) 1, 4).Select((x, i) => i%3==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X = x } ).ToArray();
            sbyte? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            sbyte? SumExpected = (sbyte?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumsbyteNullableArray4()
        {
            var source = ZEnumerable.Repeat((sbyte?) 1, 4).ToArray();
            sbyte? SumActual = ZEnumerable.Sum(source);
            sbyte? SumExpected = (sbyte?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumsbyteNullableArray4Map()
        {
            var source = ZEnumerable.Repeat(new { X = (sbyte?) 1 } , 4).ToArray();
            sbyte? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            sbyte? SumExpected = (sbyte?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumsbyteNullableArray100ThreatNulls()
        {
            var source = ZEnumerable.Repeat((sbyte?) 1, 100).Select((x, i) => i%3==0 ? x : null).ToArray();
            sbyte? SumActual = ZEnumerable.Sum(source);
            sbyte? SumExpected = (sbyte?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumsbyteNullableArray100ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((sbyte?) 1, 100).Select((x, i) => i%3==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X = x } ).ToArray();
            sbyte? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            sbyte? SumExpected = (sbyte?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
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
        public void TestSumsbyteNullableArrayNullOrEmpty()
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

            sbyte?[] emptySource = new sbyte?[0].ToArray();
            var sum = ZEnumerable.Sum(emptySource);
            Assert.AreEqual(sum, (sbyte?) 0);
        }

        [TestMethod]
        public void TestSumsbyteNullableArrayMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<sbyte?,sbyte?>((sbyte?) arg, (sbyte?) arg)).ToArray();
            Func<KeyValuePair<sbyte?, sbyte?>, sbyte?> nullMap = null;
            sbyte?[] nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            try
            {
                ZEnumerable.Sum(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            
            var emptySource = source.Take(0).ToArray();
            var sum = ZEnumerable.Sum(emptySource, x => (sbyte?) x.Key);
            Assert.AreEqual(sum, (sbyte?) 0);           
        }

            

        
                        
            
        [TestMethod]
        public void TestSumsbyteNullableList1ThreatNulls()
        {
            var source = ZEnumerable.Repeat((sbyte?) 1, 1).Select((x, i) => i%3==0 ? x : null).ToList();
            sbyte? SumActual = ZEnumerable.Sum(source);
            sbyte? SumExpected = (sbyte?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumsbyteNullableList1ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((sbyte?) 1, 1).Select((x, i) => i%3==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X = x } ).ToList();
            sbyte? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            sbyte? SumExpected = (sbyte?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumsbyteNullableList1()
        {
            var source = ZEnumerable.Repeat((sbyte?) 1, 1).ToList();
            sbyte? SumActual = ZEnumerable.Sum(source);
            sbyte? SumExpected = (sbyte?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumsbyteNullableList1Map()
        {
            var source = ZEnumerable.Repeat(new { X = (sbyte?) 1 } , 1).ToList();
            sbyte? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            sbyte? SumExpected = (sbyte?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumsbyteNullableList2ThreatNulls()
        {
            var source = ZEnumerable.Repeat((sbyte?) 1, 2).Select((x, i) => i%3==0 ? x : null).ToList();
            sbyte? SumActual = ZEnumerable.Sum(source);
            sbyte? SumExpected = (sbyte?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumsbyteNullableList2ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((sbyte?) 1, 2).Select((x, i) => i%3==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X = x } ).ToList();
            sbyte? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            sbyte? SumExpected = (sbyte?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumsbyteNullableList2()
        {
            var source = ZEnumerable.Repeat((sbyte?) 1, 2).ToList();
            sbyte? SumActual = ZEnumerable.Sum(source);
            sbyte? SumExpected = (sbyte?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumsbyteNullableList2Map()
        {
            var source = ZEnumerable.Repeat(new { X = (sbyte?) 1 } , 2).ToList();
            sbyte? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            sbyte? SumExpected = (sbyte?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumsbyteNullableList3ThreatNulls()
        {
            var source = ZEnumerable.Repeat((sbyte?) 1, 3).Select((x, i) => i%3==0 ? x : null).ToList();
            sbyte? SumActual = ZEnumerable.Sum(source);
            sbyte? SumExpected = (sbyte?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumsbyteNullableList3ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((sbyte?) 1, 3).Select((x, i) => i%3==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X = x } ).ToList();
            sbyte? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            sbyte? SumExpected = (sbyte?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumsbyteNullableList3()
        {
            var source = ZEnumerable.Repeat((sbyte?) 1, 3).ToList();
            sbyte? SumActual = ZEnumerable.Sum(source);
            sbyte? SumExpected = (sbyte?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumsbyteNullableList3Map()
        {
            var source = ZEnumerable.Repeat(new { X = (sbyte?) 1 } , 3).ToList();
            sbyte? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            sbyte? SumExpected = (sbyte?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumsbyteNullableList4ThreatNulls()
        {
            var source = ZEnumerable.Repeat((sbyte?) 1, 4).Select((x, i) => i%3==0 ? x : null).ToList();
            sbyte? SumActual = ZEnumerable.Sum(source);
            sbyte? SumExpected = (sbyte?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumsbyteNullableList4ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((sbyte?) 1, 4).Select((x, i) => i%3==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X = x } ).ToList();
            sbyte? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            sbyte? SumExpected = (sbyte?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumsbyteNullableList4()
        {
            var source = ZEnumerable.Repeat((sbyte?) 1, 4).ToList();
            sbyte? SumActual = ZEnumerable.Sum(source);
            sbyte? SumExpected = (sbyte?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumsbyteNullableList4Map()
        {
            var source = ZEnumerable.Repeat(new { X = (sbyte?) 1 } , 4).ToList();
            sbyte? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            sbyte? SumExpected = (sbyte?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumsbyteNullableList100ThreatNulls()
        {
            var source = ZEnumerable.Repeat((sbyte?) 1, 100).Select((x, i) => i%3==0 ? x : null).ToList();
            sbyte? SumActual = ZEnumerable.Sum(source);
            sbyte? SumExpected = (sbyte?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumsbyteNullableList100ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((sbyte?) 1, 100).Select((x, i) => i%3==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X = x } ).ToList();
            sbyte? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            sbyte? SumExpected = (sbyte?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
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
        public void TestSumsbyteNullableListNullOrEmpty()
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

            List<sbyte?> emptySource = new sbyte?[0].ToList();
            var sum = ZEnumerable.Sum(emptySource);
            Assert.AreEqual(sum, (sbyte?) 0);
        }

        [TestMethod]
        public void TestSumsbyteNullableListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<sbyte?,sbyte?>((sbyte?) arg, (sbyte?) arg)).ToList();
            Func<KeyValuePair<sbyte?, sbyte?>, sbyte?> nullMap = null;
            List<sbyte?> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            try
            {
                ZEnumerable.Sum(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            
            var emptySource = source.Take(0).ToList();
            var sum = ZEnumerable.Sum(emptySource, x => (sbyte?) x.Key);
            Assert.AreEqual(sum, (sbyte?) 0);           
        }

            

        
                        
            
        [TestMethod]
        public void TestSumsbyteNullableIList1ThreatNulls()
        {
            var source = ZEnumerable.Repeat((sbyte?) 1, 1).Select((x, i) => i%3==0 ? x : null).ToIList();
            sbyte? SumActual = ZEnumerable.Sum(source);
            sbyte? SumExpected = (sbyte?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumsbyteNullableIList1ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((sbyte?) 1, 1).Select((x, i) => i%3==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X = x } ).ToIList();
            sbyte? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            sbyte? SumExpected = (sbyte?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumsbyteNullableIList1()
        {
            var source = ZEnumerable.Repeat((sbyte?) 1, 1).ToIList();
            sbyte? SumActual = ZEnumerable.Sum(source);
            sbyte? SumExpected = (sbyte?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumsbyteNullableIList1Map()
        {
            var source = ZEnumerable.Repeat(new { X = (sbyte?) 1 } , 1).ToIList();
            sbyte? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            sbyte? SumExpected = (sbyte?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumsbyteNullableIList2ThreatNulls()
        {
            var source = ZEnumerable.Repeat((sbyte?) 1, 2).Select((x, i) => i%3==0 ? x : null).ToIList();
            sbyte? SumActual = ZEnumerable.Sum(source);
            sbyte? SumExpected = (sbyte?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumsbyteNullableIList2ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((sbyte?) 1, 2).Select((x, i) => i%3==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X = x } ).ToIList();
            sbyte? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            sbyte? SumExpected = (sbyte?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumsbyteNullableIList2()
        {
            var source = ZEnumerable.Repeat((sbyte?) 1, 2).ToIList();
            sbyte? SumActual = ZEnumerable.Sum(source);
            sbyte? SumExpected = (sbyte?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumsbyteNullableIList2Map()
        {
            var source = ZEnumerable.Repeat(new { X = (sbyte?) 1 } , 2).ToIList();
            sbyte? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            sbyte? SumExpected = (sbyte?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumsbyteNullableIList3ThreatNulls()
        {
            var source = ZEnumerable.Repeat((sbyte?) 1, 3).Select((x, i) => i%3==0 ? x : null).ToIList();
            sbyte? SumActual = ZEnumerable.Sum(source);
            sbyte? SumExpected = (sbyte?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumsbyteNullableIList3ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((sbyte?) 1, 3).Select((x, i) => i%3==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X = x } ).ToIList();
            sbyte? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            sbyte? SumExpected = (sbyte?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumsbyteNullableIList3()
        {
            var source = ZEnumerable.Repeat((sbyte?) 1, 3).ToIList();
            sbyte? SumActual = ZEnumerable.Sum(source);
            sbyte? SumExpected = (sbyte?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumsbyteNullableIList3Map()
        {
            var source = ZEnumerable.Repeat(new { X = (sbyte?) 1 } , 3).ToIList();
            sbyte? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            sbyte? SumExpected = (sbyte?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumsbyteNullableIList4ThreatNulls()
        {
            var source = ZEnumerable.Repeat((sbyte?) 1, 4).Select((x, i) => i%3==0 ? x : null).ToIList();
            sbyte? SumActual = ZEnumerable.Sum(source);
            sbyte? SumExpected = (sbyte?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumsbyteNullableIList4ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((sbyte?) 1, 4).Select((x, i) => i%3==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X = x } ).ToIList();
            sbyte? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            sbyte? SumExpected = (sbyte?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumsbyteNullableIList4()
        {
            var source = ZEnumerable.Repeat((sbyte?) 1, 4).ToIList();
            sbyte? SumActual = ZEnumerable.Sum(source);
            sbyte? SumExpected = (sbyte?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumsbyteNullableIList4Map()
        {
            var source = ZEnumerable.Repeat(new { X = (sbyte?) 1 } , 4).ToIList();
            sbyte? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            sbyte? SumExpected = (sbyte?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumsbyteNullableIList100ThreatNulls()
        {
            var source = ZEnumerable.Repeat((sbyte?) 1, 100).Select((x, i) => i%3==0 ? x : null).ToIList();
            sbyte? SumActual = ZEnumerable.Sum(source);
            sbyte? SumExpected = (sbyte?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumsbyteNullableIList100ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((sbyte?) 1, 100).Select((x, i) => i%3==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X = x } ).ToIList();
            sbyte? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            sbyte? SumExpected = (sbyte?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
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
        public void TestSumsbyteNullableIListNullOrEmpty()
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

            IList<sbyte?> emptySource = new sbyte?[0].ToIList();
            var sum = ZEnumerable.Sum(emptySource);
            Assert.AreEqual(sum, (sbyte?) 0);
        }

        [TestMethod]
        public void TestSumsbyteNullableIListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<sbyte?,sbyte?>((sbyte?) arg, (sbyte?) arg)).ToIList();
            Func<KeyValuePair<sbyte?, sbyte?>, sbyte?> nullMap = null;
            IList<sbyte?> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            try
            {
                ZEnumerable.Sum(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            
            var emptySource = source.Take(0).ToIList();
            var sum = ZEnumerable.Sum(emptySource, x => (sbyte?) x.Key);
            Assert.AreEqual(sum, (sbyte?) 0);           
        }

                
        #endregion
            #region byte?             
            

        
                        
            
        [TestMethod]
        public void TestSumbyteNullableArray1ThreatNulls()
        {
            var source = ZEnumerable.Repeat((byte?) 1, 1).Select((x, i) => i%3==0 ? x : null).ToArray();
            byte? SumActual = ZEnumerable.Sum(source);
            byte? SumExpected = (byte?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumbyteNullableArray1ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((byte?) 1, 1).Select((x, i) => i%3==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X = x } ).ToArray();
            byte? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            byte? SumExpected = (byte?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumbyteNullableArray1()
        {
            var source = ZEnumerable.Repeat((byte?) 1, 1).ToArray();
            byte? SumActual = ZEnumerable.Sum(source);
            byte? SumExpected = (byte?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumbyteNullableArray1Map()
        {
            var source = ZEnumerable.Repeat(new { X = (byte?) 1 } , 1).ToArray();
            byte? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            byte? SumExpected = (byte?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumbyteNullableArray2ThreatNulls()
        {
            var source = ZEnumerable.Repeat((byte?) 1, 2).Select((x, i) => i%3==0 ? x : null).ToArray();
            byte? SumActual = ZEnumerable.Sum(source);
            byte? SumExpected = (byte?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumbyteNullableArray2ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((byte?) 1, 2).Select((x, i) => i%3==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X = x } ).ToArray();
            byte? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            byte? SumExpected = (byte?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumbyteNullableArray2()
        {
            var source = ZEnumerable.Repeat((byte?) 1, 2).ToArray();
            byte? SumActual = ZEnumerable.Sum(source);
            byte? SumExpected = (byte?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumbyteNullableArray2Map()
        {
            var source = ZEnumerable.Repeat(new { X = (byte?) 1 } , 2).ToArray();
            byte? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            byte? SumExpected = (byte?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumbyteNullableArray3ThreatNulls()
        {
            var source = ZEnumerable.Repeat((byte?) 1, 3).Select((x, i) => i%3==0 ? x : null).ToArray();
            byte? SumActual = ZEnumerable.Sum(source);
            byte? SumExpected = (byte?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumbyteNullableArray3ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((byte?) 1, 3).Select((x, i) => i%3==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X = x } ).ToArray();
            byte? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            byte? SumExpected = (byte?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumbyteNullableArray3()
        {
            var source = ZEnumerable.Repeat((byte?) 1, 3).ToArray();
            byte? SumActual = ZEnumerable.Sum(source);
            byte? SumExpected = (byte?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumbyteNullableArray3Map()
        {
            var source = ZEnumerable.Repeat(new { X = (byte?) 1 } , 3).ToArray();
            byte? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            byte? SumExpected = (byte?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumbyteNullableArray4ThreatNulls()
        {
            var source = ZEnumerable.Repeat((byte?) 1, 4).Select((x, i) => i%3==0 ? x : null).ToArray();
            byte? SumActual = ZEnumerable.Sum(source);
            byte? SumExpected = (byte?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumbyteNullableArray4ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((byte?) 1, 4).Select((x, i) => i%3==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X = x } ).ToArray();
            byte? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            byte? SumExpected = (byte?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumbyteNullableArray4()
        {
            var source = ZEnumerable.Repeat((byte?) 1, 4).ToArray();
            byte? SumActual = ZEnumerable.Sum(source);
            byte? SumExpected = (byte?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumbyteNullableArray4Map()
        {
            var source = ZEnumerable.Repeat(new { X = (byte?) 1 } , 4).ToArray();
            byte? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            byte? SumExpected = (byte?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumbyteNullableArray100ThreatNulls()
        {
            var source = ZEnumerable.Repeat((byte?) 1, 100).Select((x, i) => i%3==0 ? x : null).ToArray();
            byte? SumActual = ZEnumerable.Sum(source);
            byte? SumExpected = (byte?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumbyteNullableArray100ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((byte?) 1, 100).Select((x, i) => i%3==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X = x } ).ToArray();
            byte? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            byte? SumExpected = (byte?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
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
        public void TestSumbyteNullableArrayNullOrEmpty()
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

            byte?[] emptySource = new byte?[0].ToArray();
            var sum = ZEnumerable.Sum(emptySource);
            Assert.AreEqual(sum, (byte?) 0);
        }

        [TestMethod]
        public void TestSumbyteNullableArrayMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<byte?,byte?>((byte?) arg, (byte?) arg)).ToArray();
            Func<KeyValuePair<byte?, byte?>, byte?> nullMap = null;
            byte?[] nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            try
            {
                ZEnumerable.Sum(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            
            var emptySource = source.Take(0).ToArray();
            var sum = ZEnumerable.Sum(emptySource, x => (byte?) x.Key);
            Assert.AreEqual(sum, (byte?) 0);           
        }

            

        
                        
            
        [TestMethod]
        public void TestSumbyteNullableList1ThreatNulls()
        {
            var source = ZEnumerable.Repeat((byte?) 1, 1).Select((x, i) => i%3==0 ? x : null).ToList();
            byte? SumActual = ZEnumerable.Sum(source);
            byte? SumExpected = (byte?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumbyteNullableList1ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((byte?) 1, 1).Select((x, i) => i%3==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X = x } ).ToList();
            byte? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            byte? SumExpected = (byte?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumbyteNullableList1()
        {
            var source = ZEnumerable.Repeat((byte?) 1, 1).ToList();
            byte? SumActual = ZEnumerable.Sum(source);
            byte? SumExpected = (byte?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumbyteNullableList1Map()
        {
            var source = ZEnumerable.Repeat(new { X = (byte?) 1 } , 1).ToList();
            byte? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            byte? SumExpected = (byte?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumbyteNullableList2ThreatNulls()
        {
            var source = ZEnumerable.Repeat((byte?) 1, 2).Select((x, i) => i%3==0 ? x : null).ToList();
            byte? SumActual = ZEnumerable.Sum(source);
            byte? SumExpected = (byte?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumbyteNullableList2ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((byte?) 1, 2).Select((x, i) => i%3==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X = x } ).ToList();
            byte? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            byte? SumExpected = (byte?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumbyteNullableList2()
        {
            var source = ZEnumerable.Repeat((byte?) 1, 2).ToList();
            byte? SumActual = ZEnumerable.Sum(source);
            byte? SumExpected = (byte?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumbyteNullableList2Map()
        {
            var source = ZEnumerable.Repeat(new { X = (byte?) 1 } , 2).ToList();
            byte? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            byte? SumExpected = (byte?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumbyteNullableList3ThreatNulls()
        {
            var source = ZEnumerable.Repeat((byte?) 1, 3).Select((x, i) => i%3==0 ? x : null).ToList();
            byte? SumActual = ZEnumerable.Sum(source);
            byte? SumExpected = (byte?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumbyteNullableList3ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((byte?) 1, 3).Select((x, i) => i%3==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X = x } ).ToList();
            byte? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            byte? SumExpected = (byte?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumbyteNullableList3()
        {
            var source = ZEnumerable.Repeat((byte?) 1, 3).ToList();
            byte? SumActual = ZEnumerable.Sum(source);
            byte? SumExpected = (byte?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumbyteNullableList3Map()
        {
            var source = ZEnumerable.Repeat(new { X = (byte?) 1 } , 3).ToList();
            byte? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            byte? SumExpected = (byte?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumbyteNullableList4ThreatNulls()
        {
            var source = ZEnumerable.Repeat((byte?) 1, 4).Select((x, i) => i%3==0 ? x : null).ToList();
            byte? SumActual = ZEnumerable.Sum(source);
            byte? SumExpected = (byte?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumbyteNullableList4ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((byte?) 1, 4).Select((x, i) => i%3==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X = x } ).ToList();
            byte? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            byte? SumExpected = (byte?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumbyteNullableList4()
        {
            var source = ZEnumerable.Repeat((byte?) 1, 4).ToList();
            byte? SumActual = ZEnumerable.Sum(source);
            byte? SumExpected = (byte?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumbyteNullableList4Map()
        {
            var source = ZEnumerable.Repeat(new { X = (byte?) 1 } , 4).ToList();
            byte? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            byte? SumExpected = (byte?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumbyteNullableList100ThreatNulls()
        {
            var source = ZEnumerable.Repeat((byte?) 1, 100).Select((x, i) => i%3==0 ? x : null).ToList();
            byte? SumActual = ZEnumerable.Sum(source);
            byte? SumExpected = (byte?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumbyteNullableList100ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((byte?) 1, 100).Select((x, i) => i%3==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X = x } ).ToList();
            byte? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            byte? SumExpected = (byte?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
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
        public void TestSumbyteNullableListNullOrEmpty()
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

            List<byte?> emptySource = new byte?[0].ToList();
            var sum = ZEnumerable.Sum(emptySource);
            Assert.AreEqual(sum, (byte?) 0);
        }

        [TestMethod]
        public void TestSumbyteNullableListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<byte?,byte?>((byte?) arg, (byte?) arg)).ToList();
            Func<KeyValuePair<byte?, byte?>, byte?> nullMap = null;
            List<byte?> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            try
            {
                ZEnumerable.Sum(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            
            var emptySource = source.Take(0).ToList();
            var sum = ZEnumerable.Sum(emptySource, x => (byte?) x.Key);
            Assert.AreEqual(sum, (byte?) 0);           
        }

            

        
                        
            
        [TestMethod]
        public void TestSumbyteNullableIList1ThreatNulls()
        {
            var source = ZEnumerable.Repeat((byte?) 1, 1).Select((x, i) => i%3==0 ? x : null).ToIList();
            byte? SumActual = ZEnumerable.Sum(source);
            byte? SumExpected = (byte?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumbyteNullableIList1ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((byte?) 1, 1).Select((x, i) => i%3==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X = x } ).ToIList();
            byte? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            byte? SumExpected = (byte?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumbyteNullableIList1()
        {
            var source = ZEnumerable.Repeat((byte?) 1, 1).ToIList();
            byte? SumActual = ZEnumerable.Sum(source);
            byte? SumExpected = (byte?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumbyteNullableIList1Map()
        {
            var source = ZEnumerable.Repeat(new { X = (byte?) 1 } , 1).ToIList();
            byte? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            byte? SumExpected = (byte?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumbyteNullableIList2ThreatNulls()
        {
            var source = ZEnumerable.Repeat((byte?) 1, 2).Select((x, i) => i%3==0 ? x : null).ToIList();
            byte? SumActual = ZEnumerable.Sum(source);
            byte? SumExpected = (byte?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumbyteNullableIList2ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((byte?) 1, 2).Select((x, i) => i%3==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X = x } ).ToIList();
            byte? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            byte? SumExpected = (byte?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumbyteNullableIList2()
        {
            var source = ZEnumerable.Repeat((byte?) 1, 2).ToIList();
            byte? SumActual = ZEnumerable.Sum(source);
            byte? SumExpected = (byte?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumbyteNullableIList2Map()
        {
            var source = ZEnumerable.Repeat(new { X = (byte?) 1 } , 2).ToIList();
            byte? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            byte? SumExpected = (byte?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumbyteNullableIList3ThreatNulls()
        {
            var source = ZEnumerable.Repeat((byte?) 1, 3).Select((x, i) => i%3==0 ? x : null).ToIList();
            byte? SumActual = ZEnumerable.Sum(source);
            byte? SumExpected = (byte?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumbyteNullableIList3ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((byte?) 1, 3).Select((x, i) => i%3==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X = x } ).ToIList();
            byte? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            byte? SumExpected = (byte?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumbyteNullableIList3()
        {
            var source = ZEnumerable.Repeat((byte?) 1, 3).ToIList();
            byte? SumActual = ZEnumerable.Sum(source);
            byte? SumExpected = (byte?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumbyteNullableIList3Map()
        {
            var source = ZEnumerable.Repeat(new { X = (byte?) 1 } , 3).ToIList();
            byte? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            byte? SumExpected = (byte?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumbyteNullableIList4ThreatNulls()
        {
            var source = ZEnumerable.Repeat((byte?) 1, 4).Select((x, i) => i%3==0 ? x : null).ToIList();
            byte? SumActual = ZEnumerable.Sum(source);
            byte? SumExpected = (byte?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumbyteNullableIList4ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((byte?) 1, 4).Select((x, i) => i%3==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X = x } ).ToIList();
            byte? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            byte? SumExpected = (byte?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumbyteNullableIList4()
        {
            var source = ZEnumerable.Repeat((byte?) 1, 4).ToIList();
            byte? SumActual = ZEnumerable.Sum(source);
            byte? SumExpected = (byte?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumbyteNullableIList4Map()
        {
            var source = ZEnumerable.Repeat(new { X = (byte?) 1 } , 4).ToIList();
            byte? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            byte? SumExpected = (byte?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumbyteNullableIList100ThreatNulls()
        {
            var source = ZEnumerable.Repeat((byte?) 1, 100).Select((x, i) => i%3==0 ? x : null).ToIList();
            byte? SumActual = ZEnumerable.Sum(source);
            byte? SumExpected = (byte?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumbyteNullableIList100ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((byte?) 1, 100).Select((x, i) => i%3==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X = x } ).ToIList();
            byte? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            byte? SumExpected = (byte?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
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
        public void TestSumbyteNullableIListNullOrEmpty()
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

            IList<byte?> emptySource = new byte?[0].ToIList();
            var sum = ZEnumerable.Sum(emptySource);
            Assert.AreEqual(sum, (byte?) 0);
        }

        [TestMethod]
        public void TestSumbyteNullableIListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<byte?,byte?>((byte?) arg, (byte?) arg)).ToIList();
            Func<KeyValuePair<byte?, byte?>, byte?> nullMap = null;
            IList<byte?> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            try
            {
                ZEnumerable.Sum(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            
            var emptySource = source.Take(0).ToIList();
            var sum = ZEnumerable.Sum(emptySource, x => (byte?) x.Key);
            Assert.AreEqual(sum, (byte?) 0);           
        }

                
        #endregion
            #region short?             
            

        
                        
            
        [TestMethod]
        public void TestSumshortNullableArray1ThreatNulls()
        {
            var source = ZEnumerable.Repeat((short?) 1, 1).Select((x, i) => i%3==0 ? x : null).ToArray();
            short? SumActual = ZEnumerable.Sum(source);
            short? SumExpected = (short?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumshortNullableArray1ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((short?) 1, 1).Select((x, i) => i%3==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X = x } ).ToArray();
            short? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            short? SumExpected = (short?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumshortNullableArray1()
        {
            var source = ZEnumerable.Repeat((short?) 1, 1).ToArray();
            short? SumActual = ZEnumerable.Sum(source);
            short? SumExpected = (short?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumshortNullableArray1Map()
        {
            var source = ZEnumerable.Repeat(new { X = (short?) 1 } , 1).ToArray();
            short? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            short? SumExpected = (short?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumshortNullableArray2ThreatNulls()
        {
            var source = ZEnumerable.Repeat((short?) 1, 2).Select((x, i) => i%3==0 ? x : null).ToArray();
            short? SumActual = ZEnumerable.Sum(source);
            short? SumExpected = (short?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumshortNullableArray2ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((short?) 1, 2).Select((x, i) => i%3==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X = x } ).ToArray();
            short? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            short? SumExpected = (short?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumshortNullableArray2()
        {
            var source = ZEnumerable.Repeat((short?) 1, 2).ToArray();
            short? SumActual = ZEnumerable.Sum(source);
            short? SumExpected = (short?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumshortNullableArray2Map()
        {
            var source = ZEnumerable.Repeat(new { X = (short?) 1 } , 2).ToArray();
            short? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            short? SumExpected = (short?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumshortNullableArray3ThreatNulls()
        {
            var source = ZEnumerable.Repeat((short?) 1, 3).Select((x, i) => i%3==0 ? x : null).ToArray();
            short? SumActual = ZEnumerable.Sum(source);
            short? SumExpected = (short?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumshortNullableArray3ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((short?) 1, 3).Select((x, i) => i%3==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X = x } ).ToArray();
            short? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            short? SumExpected = (short?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumshortNullableArray3()
        {
            var source = ZEnumerable.Repeat((short?) 1, 3).ToArray();
            short? SumActual = ZEnumerable.Sum(source);
            short? SumExpected = (short?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumshortNullableArray3Map()
        {
            var source = ZEnumerable.Repeat(new { X = (short?) 1 } , 3).ToArray();
            short? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            short? SumExpected = (short?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumshortNullableArray4ThreatNulls()
        {
            var source = ZEnumerable.Repeat((short?) 1, 4).Select((x, i) => i%3==0 ? x : null).ToArray();
            short? SumActual = ZEnumerable.Sum(source);
            short? SumExpected = (short?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumshortNullableArray4ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((short?) 1, 4).Select((x, i) => i%3==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X = x } ).ToArray();
            short? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            short? SumExpected = (short?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumshortNullableArray4()
        {
            var source = ZEnumerable.Repeat((short?) 1, 4).ToArray();
            short? SumActual = ZEnumerable.Sum(source);
            short? SumExpected = (short?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumshortNullableArray4Map()
        {
            var source = ZEnumerable.Repeat(new { X = (short?) 1 } , 4).ToArray();
            short? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            short? SumExpected = (short?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumshortNullableArray100ThreatNulls()
        {
            var source = ZEnumerable.Repeat((short?) 1, 100).Select((x, i) => i%3==0 ? x : null).ToArray();
            short? SumActual = ZEnumerable.Sum(source);
            short? SumExpected = (short?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumshortNullableArray100ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((short?) 1, 100).Select((x, i) => i%3==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X = x } ).ToArray();
            short? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            short? SumExpected = (short?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
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
        public void TestSumshortNullableArray2048ThreatNulls()
        {
            var source = ZEnumerable.Repeat((short?) 1, 2048).Select((x, i) => i%3==0 ? x : null).ToArray();
            short? SumActual = ZEnumerable.Sum(source);
            short? SumExpected = (short?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumshortNullableArray2048ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((short?) 1, 2048).Select((x, i) => i%3==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X = x } ).ToArray();
            short? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            short? SumExpected = (short?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumshortNullableArray2048()
        {
            var source = ZEnumerable.Repeat((short?) 1, 2048).ToArray();
            short? SumActual = ZEnumerable.Sum(source);
            short? SumExpected = (short?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumshortNullableArray2048Map()
        {
            var source = ZEnumerable.Repeat(new { X = (short?) 1 } , 2048).ToArray();
            short? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            short? SumExpected = (short?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
            
        [TestMethod]
        public void TestSumshortNullableArrayNullOrEmpty()
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

            short?[] emptySource = new short?[0].ToArray();
            var sum = ZEnumerable.Sum(emptySource);
            Assert.AreEqual(sum, (short?) 0);
        }

        [TestMethod]
        public void TestSumshortNullableArrayMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<short?,short?>((short?) arg, (short?) arg)).ToArray();
            Func<KeyValuePair<short?, short?>, short?> nullMap = null;
            short?[] nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            try
            {
                ZEnumerable.Sum(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            
            var emptySource = source.Take(0).ToArray();
            var sum = ZEnumerable.Sum(emptySource, x => (short?) x.Key);
            Assert.AreEqual(sum, (short?) 0);           
        }

            

        
                        
            
        [TestMethod]
        public void TestSumshortNullableList1ThreatNulls()
        {
            var source = ZEnumerable.Repeat((short?) 1, 1).Select((x, i) => i%3==0 ? x : null).ToList();
            short? SumActual = ZEnumerable.Sum(source);
            short? SumExpected = (short?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumshortNullableList1ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((short?) 1, 1).Select((x, i) => i%3==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X = x } ).ToList();
            short? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            short? SumExpected = (short?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumshortNullableList1()
        {
            var source = ZEnumerable.Repeat((short?) 1, 1).ToList();
            short? SumActual = ZEnumerable.Sum(source);
            short? SumExpected = (short?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumshortNullableList1Map()
        {
            var source = ZEnumerable.Repeat(new { X = (short?) 1 } , 1).ToList();
            short? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            short? SumExpected = (short?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumshortNullableList2ThreatNulls()
        {
            var source = ZEnumerable.Repeat((short?) 1, 2).Select((x, i) => i%3==0 ? x : null).ToList();
            short? SumActual = ZEnumerable.Sum(source);
            short? SumExpected = (short?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumshortNullableList2ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((short?) 1, 2).Select((x, i) => i%3==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X = x } ).ToList();
            short? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            short? SumExpected = (short?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumshortNullableList2()
        {
            var source = ZEnumerable.Repeat((short?) 1, 2).ToList();
            short? SumActual = ZEnumerable.Sum(source);
            short? SumExpected = (short?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumshortNullableList2Map()
        {
            var source = ZEnumerable.Repeat(new { X = (short?) 1 } , 2).ToList();
            short? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            short? SumExpected = (short?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumshortNullableList3ThreatNulls()
        {
            var source = ZEnumerable.Repeat((short?) 1, 3).Select((x, i) => i%3==0 ? x : null).ToList();
            short? SumActual = ZEnumerable.Sum(source);
            short? SumExpected = (short?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumshortNullableList3ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((short?) 1, 3).Select((x, i) => i%3==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X = x } ).ToList();
            short? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            short? SumExpected = (short?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumshortNullableList3()
        {
            var source = ZEnumerable.Repeat((short?) 1, 3).ToList();
            short? SumActual = ZEnumerable.Sum(source);
            short? SumExpected = (short?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumshortNullableList3Map()
        {
            var source = ZEnumerable.Repeat(new { X = (short?) 1 } , 3).ToList();
            short? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            short? SumExpected = (short?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumshortNullableList4ThreatNulls()
        {
            var source = ZEnumerable.Repeat((short?) 1, 4).Select((x, i) => i%3==0 ? x : null).ToList();
            short? SumActual = ZEnumerable.Sum(source);
            short? SumExpected = (short?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumshortNullableList4ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((short?) 1, 4).Select((x, i) => i%3==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X = x } ).ToList();
            short? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            short? SumExpected = (short?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumshortNullableList4()
        {
            var source = ZEnumerable.Repeat((short?) 1, 4).ToList();
            short? SumActual = ZEnumerable.Sum(source);
            short? SumExpected = (short?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumshortNullableList4Map()
        {
            var source = ZEnumerable.Repeat(new { X = (short?) 1 } , 4).ToList();
            short? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            short? SumExpected = (short?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumshortNullableList100ThreatNulls()
        {
            var source = ZEnumerable.Repeat((short?) 1, 100).Select((x, i) => i%3==0 ? x : null).ToList();
            short? SumActual = ZEnumerable.Sum(source);
            short? SumExpected = (short?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumshortNullableList100ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((short?) 1, 100).Select((x, i) => i%3==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X = x } ).ToList();
            short? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            short? SumExpected = (short?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
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
        public void TestSumshortNullableList2048ThreatNulls()
        {
            var source = ZEnumerable.Repeat((short?) 1, 2048).Select((x, i) => i%3==0 ? x : null).ToList();
            short? SumActual = ZEnumerable.Sum(source);
            short? SumExpected = (short?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumshortNullableList2048ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((short?) 1, 2048).Select((x, i) => i%3==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X = x } ).ToList();
            short? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            short? SumExpected = (short?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumshortNullableList2048()
        {
            var source = ZEnumerable.Repeat((short?) 1, 2048).ToList();
            short? SumActual = ZEnumerable.Sum(source);
            short? SumExpected = (short?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumshortNullableList2048Map()
        {
            var source = ZEnumerable.Repeat(new { X = (short?) 1 } , 2048).ToList();
            short? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            short? SumExpected = (short?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
            
        [TestMethod]
        public void TestSumshortNullableListNullOrEmpty()
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

            List<short?> emptySource = new short?[0].ToList();
            var sum = ZEnumerable.Sum(emptySource);
            Assert.AreEqual(sum, (short?) 0);
        }

        [TestMethod]
        public void TestSumshortNullableListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<short?,short?>((short?) arg, (short?) arg)).ToList();
            Func<KeyValuePair<short?, short?>, short?> nullMap = null;
            List<short?> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            try
            {
                ZEnumerable.Sum(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            
            var emptySource = source.Take(0).ToList();
            var sum = ZEnumerable.Sum(emptySource, x => (short?) x.Key);
            Assert.AreEqual(sum, (short?) 0);           
        }

            

        
                        
            
        [TestMethod]
        public void TestSumshortNullableIList1ThreatNulls()
        {
            var source = ZEnumerable.Repeat((short?) 1, 1).Select((x, i) => i%3==0 ? x : null).ToIList();
            short? SumActual = ZEnumerable.Sum(source);
            short? SumExpected = (short?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumshortNullableIList1ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((short?) 1, 1).Select((x, i) => i%3==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X = x } ).ToIList();
            short? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            short? SumExpected = (short?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumshortNullableIList1()
        {
            var source = ZEnumerable.Repeat((short?) 1, 1).ToIList();
            short? SumActual = ZEnumerable.Sum(source);
            short? SumExpected = (short?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumshortNullableIList1Map()
        {
            var source = ZEnumerable.Repeat(new { X = (short?) 1 } , 1).ToIList();
            short? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            short? SumExpected = (short?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumshortNullableIList2ThreatNulls()
        {
            var source = ZEnumerable.Repeat((short?) 1, 2).Select((x, i) => i%3==0 ? x : null).ToIList();
            short? SumActual = ZEnumerable.Sum(source);
            short? SumExpected = (short?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumshortNullableIList2ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((short?) 1, 2).Select((x, i) => i%3==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X = x } ).ToIList();
            short? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            short? SumExpected = (short?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumshortNullableIList2()
        {
            var source = ZEnumerable.Repeat((short?) 1, 2).ToIList();
            short? SumActual = ZEnumerable.Sum(source);
            short? SumExpected = (short?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumshortNullableIList2Map()
        {
            var source = ZEnumerable.Repeat(new { X = (short?) 1 } , 2).ToIList();
            short? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            short? SumExpected = (short?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumshortNullableIList3ThreatNulls()
        {
            var source = ZEnumerable.Repeat((short?) 1, 3).Select((x, i) => i%3==0 ? x : null).ToIList();
            short? SumActual = ZEnumerable.Sum(source);
            short? SumExpected = (short?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumshortNullableIList3ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((short?) 1, 3).Select((x, i) => i%3==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X = x } ).ToIList();
            short? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            short? SumExpected = (short?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumshortNullableIList3()
        {
            var source = ZEnumerable.Repeat((short?) 1, 3).ToIList();
            short? SumActual = ZEnumerable.Sum(source);
            short? SumExpected = (short?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumshortNullableIList3Map()
        {
            var source = ZEnumerable.Repeat(new { X = (short?) 1 } , 3).ToIList();
            short? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            short? SumExpected = (short?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumshortNullableIList4ThreatNulls()
        {
            var source = ZEnumerable.Repeat((short?) 1, 4).Select((x, i) => i%3==0 ? x : null).ToIList();
            short? SumActual = ZEnumerable.Sum(source);
            short? SumExpected = (short?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumshortNullableIList4ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((short?) 1, 4).Select((x, i) => i%3==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X = x } ).ToIList();
            short? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            short? SumExpected = (short?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumshortNullableIList4()
        {
            var source = ZEnumerable.Repeat((short?) 1, 4).ToIList();
            short? SumActual = ZEnumerable.Sum(source);
            short? SumExpected = (short?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumshortNullableIList4Map()
        {
            var source = ZEnumerable.Repeat(new { X = (short?) 1 } , 4).ToIList();
            short? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            short? SumExpected = (short?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumshortNullableIList100ThreatNulls()
        {
            var source = ZEnumerable.Repeat((short?) 1, 100).Select((x, i) => i%3==0 ? x : null).ToIList();
            short? SumActual = ZEnumerable.Sum(source);
            short? SumExpected = (short?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumshortNullableIList100ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((short?) 1, 100).Select((x, i) => i%3==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X = x } ).ToIList();
            short? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            short? SumExpected = (short?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
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
        public void TestSumshortNullableIList2048ThreatNulls()
        {
            var source = ZEnumerable.Repeat((short?) 1, 2048).Select((x, i) => i%3==0 ? x : null).ToIList();
            short? SumActual = ZEnumerable.Sum(source);
            short? SumExpected = (short?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumshortNullableIList2048ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((short?) 1, 2048).Select((x, i) => i%3==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X = x } ).ToIList();
            short? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            short? SumExpected = (short?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumshortNullableIList2048()
        {
            var source = ZEnumerable.Repeat((short?) 1, 2048).ToIList();
            short? SumActual = ZEnumerable.Sum(source);
            short? SumExpected = (short?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumshortNullableIList2048Map()
        {
            var source = ZEnumerable.Repeat(new { X = (short?) 1 } , 2048).ToIList();
            short? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            short? SumExpected = (short?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
            
        [TestMethod]
        public void TestSumshortNullableIListNullOrEmpty()
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

            IList<short?> emptySource = new short?[0].ToIList();
            var sum = ZEnumerable.Sum(emptySource);
            Assert.AreEqual(sum, (short?) 0);
        }

        [TestMethod]
        public void TestSumshortNullableIListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<short?,short?>((short?) arg, (short?) arg)).ToIList();
            Func<KeyValuePair<short?, short?>, short?> nullMap = null;
            IList<short?> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            try
            {
                ZEnumerable.Sum(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            
            var emptySource = source.Take(0).ToIList();
            var sum = ZEnumerable.Sum(emptySource, x => (short?) x.Key);
            Assert.AreEqual(sum, (short?) 0);           
        }

                
        #endregion
            #region ushort?             
            

        
                        
            
        [TestMethod]
        public void TestSumushortNullableArray1ThreatNulls()
        {
            var source = ZEnumerable.Repeat((ushort?) 1, 1).Select((x, i) => i%3==0 ? x : null).ToArray();
            ushort? SumActual = ZEnumerable.Sum(source);
            ushort? SumExpected = (ushort?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumushortNullableArray1ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((ushort?) 1, 1).Select((x, i) => i%3==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X = x } ).ToArray();
            ushort? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ushort? SumExpected = (ushort?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumushortNullableArray1()
        {
            var source = ZEnumerable.Repeat((ushort?) 1, 1).ToArray();
            ushort? SumActual = ZEnumerable.Sum(source);
            ushort? SumExpected = (ushort?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumushortNullableArray1Map()
        {
            var source = ZEnumerable.Repeat(new { X = (ushort?) 1 } , 1).ToArray();
            ushort? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ushort? SumExpected = (ushort?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumushortNullableArray2ThreatNulls()
        {
            var source = ZEnumerable.Repeat((ushort?) 1, 2).Select((x, i) => i%3==0 ? x : null).ToArray();
            ushort? SumActual = ZEnumerable.Sum(source);
            ushort? SumExpected = (ushort?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumushortNullableArray2ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((ushort?) 1, 2).Select((x, i) => i%3==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X = x } ).ToArray();
            ushort? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ushort? SumExpected = (ushort?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumushortNullableArray2()
        {
            var source = ZEnumerable.Repeat((ushort?) 1, 2).ToArray();
            ushort? SumActual = ZEnumerable.Sum(source);
            ushort? SumExpected = (ushort?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumushortNullableArray2Map()
        {
            var source = ZEnumerable.Repeat(new { X = (ushort?) 1 } , 2).ToArray();
            ushort? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ushort? SumExpected = (ushort?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumushortNullableArray3ThreatNulls()
        {
            var source = ZEnumerable.Repeat((ushort?) 1, 3).Select((x, i) => i%3==0 ? x : null).ToArray();
            ushort? SumActual = ZEnumerable.Sum(source);
            ushort? SumExpected = (ushort?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumushortNullableArray3ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((ushort?) 1, 3).Select((x, i) => i%3==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X = x } ).ToArray();
            ushort? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ushort? SumExpected = (ushort?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumushortNullableArray3()
        {
            var source = ZEnumerable.Repeat((ushort?) 1, 3).ToArray();
            ushort? SumActual = ZEnumerable.Sum(source);
            ushort? SumExpected = (ushort?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumushortNullableArray3Map()
        {
            var source = ZEnumerable.Repeat(new { X = (ushort?) 1 } , 3).ToArray();
            ushort? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ushort? SumExpected = (ushort?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumushortNullableArray4ThreatNulls()
        {
            var source = ZEnumerable.Repeat((ushort?) 1, 4).Select((x, i) => i%3==0 ? x : null).ToArray();
            ushort? SumActual = ZEnumerable.Sum(source);
            ushort? SumExpected = (ushort?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumushortNullableArray4ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((ushort?) 1, 4).Select((x, i) => i%3==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X = x } ).ToArray();
            ushort? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ushort? SumExpected = (ushort?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumushortNullableArray4()
        {
            var source = ZEnumerable.Repeat((ushort?) 1, 4).ToArray();
            ushort? SumActual = ZEnumerable.Sum(source);
            ushort? SumExpected = (ushort?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumushortNullableArray4Map()
        {
            var source = ZEnumerable.Repeat(new { X = (ushort?) 1 } , 4).ToArray();
            ushort? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ushort? SumExpected = (ushort?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumushortNullableArray100ThreatNulls()
        {
            var source = ZEnumerable.Repeat((ushort?) 1, 100).Select((x, i) => i%3==0 ? x : null).ToArray();
            ushort? SumActual = ZEnumerable.Sum(source);
            ushort? SumExpected = (ushort?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumushortNullableArray100ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((ushort?) 1, 100).Select((x, i) => i%3==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X = x } ).ToArray();
            ushort? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ushort? SumExpected = (ushort?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
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
        public void TestSumushortNullableArray2048ThreatNulls()
        {
            var source = ZEnumerable.Repeat((ushort?) 1, 2048).Select((x, i) => i%3==0 ? x : null).ToArray();
            ushort? SumActual = ZEnumerable.Sum(source);
            ushort? SumExpected = (ushort?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumushortNullableArray2048ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((ushort?) 1, 2048).Select((x, i) => i%3==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X = x } ).ToArray();
            ushort? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ushort? SumExpected = (ushort?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumushortNullableArray2048()
        {
            var source = ZEnumerable.Repeat((ushort?) 1, 2048).ToArray();
            ushort? SumActual = ZEnumerable.Sum(source);
            ushort? SumExpected = (ushort?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumushortNullableArray2048Map()
        {
            var source = ZEnumerable.Repeat(new { X = (ushort?) 1 } , 2048).ToArray();
            ushort? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ushort? SumExpected = (ushort?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
            
        [TestMethod]
        public void TestSumushortNullableArrayNullOrEmpty()
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

            ushort?[] emptySource = new ushort?[0].ToArray();
            var sum = ZEnumerable.Sum(emptySource);
            Assert.AreEqual(sum, (ushort?) 0);
        }

        [TestMethod]
        public void TestSumushortNullableArrayMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<ushort?,ushort?>((ushort?) arg, (ushort?) arg)).ToArray();
            Func<KeyValuePair<ushort?, ushort?>, ushort?> nullMap = null;
            ushort?[] nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            try
            {
                ZEnumerable.Sum(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            
            var emptySource = source.Take(0).ToArray();
            var sum = ZEnumerable.Sum(emptySource, x => (ushort?) x.Key);
            Assert.AreEqual(sum, (ushort?) 0);           
        }

            

        
                        
            
        [TestMethod]
        public void TestSumushortNullableList1ThreatNulls()
        {
            var source = ZEnumerable.Repeat((ushort?) 1, 1).Select((x, i) => i%3==0 ? x : null).ToList();
            ushort? SumActual = ZEnumerable.Sum(source);
            ushort? SumExpected = (ushort?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumushortNullableList1ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((ushort?) 1, 1).Select((x, i) => i%3==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X = x } ).ToList();
            ushort? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ushort? SumExpected = (ushort?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumushortNullableList1()
        {
            var source = ZEnumerable.Repeat((ushort?) 1, 1).ToList();
            ushort? SumActual = ZEnumerable.Sum(source);
            ushort? SumExpected = (ushort?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumushortNullableList1Map()
        {
            var source = ZEnumerable.Repeat(new { X = (ushort?) 1 } , 1).ToList();
            ushort? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ushort? SumExpected = (ushort?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumushortNullableList2ThreatNulls()
        {
            var source = ZEnumerable.Repeat((ushort?) 1, 2).Select((x, i) => i%3==0 ? x : null).ToList();
            ushort? SumActual = ZEnumerable.Sum(source);
            ushort? SumExpected = (ushort?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumushortNullableList2ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((ushort?) 1, 2).Select((x, i) => i%3==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X = x } ).ToList();
            ushort? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ushort? SumExpected = (ushort?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumushortNullableList2()
        {
            var source = ZEnumerable.Repeat((ushort?) 1, 2).ToList();
            ushort? SumActual = ZEnumerable.Sum(source);
            ushort? SumExpected = (ushort?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumushortNullableList2Map()
        {
            var source = ZEnumerable.Repeat(new { X = (ushort?) 1 } , 2).ToList();
            ushort? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ushort? SumExpected = (ushort?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumushortNullableList3ThreatNulls()
        {
            var source = ZEnumerable.Repeat((ushort?) 1, 3).Select((x, i) => i%3==0 ? x : null).ToList();
            ushort? SumActual = ZEnumerable.Sum(source);
            ushort? SumExpected = (ushort?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumushortNullableList3ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((ushort?) 1, 3).Select((x, i) => i%3==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X = x } ).ToList();
            ushort? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ushort? SumExpected = (ushort?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumushortNullableList3()
        {
            var source = ZEnumerable.Repeat((ushort?) 1, 3).ToList();
            ushort? SumActual = ZEnumerable.Sum(source);
            ushort? SumExpected = (ushort?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumushortNullableList3Map()
        {
            var source = ZEnumerable.Repeat(new { X = (ushort?) 1 } , 3).ToList();
            ushort? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ushort? SumExpected = (ushort?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumushortNullableList4ThreatNulls()
        {
            var source = ZEnumerable.Repeat((ushort?) 1, 4).Select((x, i) => i%3==0 ? x : null).ToList();
            ushort? SumActual = ZEnumerable.Sum(source);
            ushort? SumExpected = (ushort?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumushortNullableList4ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((ushort?) 1, 4).Select((x, i) => i%3==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X = x } ).ToList();
            ushort? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ushort? SumExpected = (ushort?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumushortNullableList4()
        {
            var source = ZEnumerable.Repeat((ushort?) 1, 4).ToList();
            ushort? SumActual = ZEnumerable.Sum(source);
            ushort? SumExpected = (ushort?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumushortNullableList4Map()
        {
            var source = ZEnumerable.Repeat(new { X = (ushort?) 1 } , 4).ToList();
            ushort? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ushort? SumExpected = (ushort?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumushortNullableList100ThreatNulls()
        {
            var source = ZEnumerable.Repeat((ushort?) 1, 100).Select((x, i) => i%3==0 ? x : null).ToList();
            ushort? SumActual = ZEnumerable.Sum(source);
            ushort? SumExpected = (ushort?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumushortNullableList100ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((ushort?) 1, 100).Select((x, i) => i%3==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X = x } ).ToList();
            ushort? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ushort? SumExpected = (ushort?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
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
        public void TestSumushortNullableList2048ThreatNulls()
        {
            var source = ZEnumerable.Repeat((ushort?) 1, 2048).Select((x, i) => i%3==0 ? x : null).ToList();
            ushort? SumActual = ZEnumerable.Sum(source);
            ushort? SumExpected = (ushort?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumushortNullableList2048ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((ushort?) 1, 2048).Select((x, i) => i%3==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X = x } ).ToList();
            ushort? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ushort? SumExpected = (ushort?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumushortNullableList2048()
        {
            var source = ZEnumerable.Repeat((ushort?) 1, 2048).ToList();
            ushort? SumActual = ZEnumerable.Sum(source);
            ushort? SumExpected = (ushort?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumushortNullableList2048Map()
        {
            var source = ZEnumerable.Repeat(new { X = (ushort?) 1 } , 2048).ToList();
            ushort? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ushort? SumExpected = (ushort?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
            
        [TestMethod]
        public void TestSumushortNullableListNullOrEmpty()
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

            List<ushort?> emptySource = new ushort?[0].ToList();
            var sum = ZEnumerable.Sum(emptySource);
            Assert.AreEqual(sum, (ushort?) 0);
        }

        [TestMethod]
        public void TestSumushortNullableListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<ushort?,ushort?>((ushort?) arg, (ushort?) arg)).ToList();
            Func<KeyValuePair<ushort?, ushort?>, ushort?> nullMap = null;
            List<ushort?> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            try
            {
                ZEnumerable.Sum(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            
            var emptySource = source.Take(0).ToList();
            var sum = ZEnumerable.Sum(emptySource, x => (ushort?) x.Key);
            Assert.AreEqual(sum, (ushort?) 0);           
        }

            

        
                        
            
        [TestMethod]
        public void TestSumushortNullableIList1ThreatNulls()
        {
            var source = ZEnumerable.Repeat((ushort?) 1, 1).Select((x, i) => i%3==0 ? x : null).ToIList();
            ushort? SumActual = ZEnumerable.Sum(source);
            ushort? SumExpected = (ushort?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumushortNullableIList1ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((ushort?) 1, 1).Select((x, i) => i%3==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X = x } ).ToIList();
            ushort? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ushort? SumExpected = (ushort?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumushortNullableIList1()
        {
            var source = ZEnumerable.Repeat((ushort?) 1, 1).ToIList();
            ushort? SumActual = ZEnumerable.Sum(source);
            ushort? SumExpected = (ushort?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumushortNullableIList1Map()
        {
            var source = ZEnumerable.Repeat(new { X = (ushort?) 1 } , 1).ToIList();
            ushort? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ushort? SumExpected = (ushort?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumushortNullableIList2ThreatNulls()
        {
            var source = ZEnumerable.Repeat((ushort?) 1, 2).Select((x, i) => i%3==0 ? x : null).ToIList();
            ushort? SumActual = ZEnumerable.Sum(source);
            ushort? SumExpected = (ushort?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumushortNullableIList2ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((ushort?) 1, 2).Select((x, i) => i%3==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X = x } ).ToIList();
            ushort? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ushort? SumExpected = (ushort?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumushortNullableIList2()
        {
            var source = ZEnumerable.Repeat((ushort?) 1, 2).ToIList();
            ushort? SumActual = ZEnumerable.Sum(source);
            ushort? SumExpected = (ushort?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumushortNullableIList2Map()
        {
            var source = ZEnumerable.Repeat(new { X = (ushort?) 1 } , 2).ToIList();
            ushort? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ushort? SumExpected = (ushort?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumushortNullableIList3ThreatNulls()
        {
            var source = ZEnumerable.Repeat((ushort?) 1, 3).Select((x, i) => i%3==0 ? x : null).ToIList();
            ushort? SumActual = ZEnumerable.Sum(source);
            ushort? SumExpected = (ushort?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumushortNullableIList3ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((ushort?) 1, 3).Select((x, i) => i%3==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X = x } ).ToIList();
            ushort? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ushort? SumExpected = (ushort?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumushortNullableIList3()
        {
            var source = ZEnumerable.Repeat((ushort?) 1, 3).ToIList();
            ushort? SumActual = ZEnumerable.Sum(source);
            ushort? SumExpected = (ushort?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumushortNullableIList3Map()
        {
            var source = ZEnumerable.Repeat(new { X = (ushort?) 1 } , 3).ToIList();
            ushort? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ushort? SumExpected = (ushort?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumushortNullableIList4ThreatNulls()
        {
            var source = ZEnumerable.Repeat((ushort?) 1, 4).Select((x, i) => i%3==0 ? x : null).ToIList();
            ushort? SumActual = ZEnumerable.Sum(source);
            ushort? SumExpected = (ushort?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumushortNullableIList4ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((ushort?) 1, 4).Select((x, i) => i%3==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X = x } ).ToIList();
            ushort? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ushort? SumExpected = (ushort?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumushortNullableIList4()
        {
            var source = ZEnumerable.Repeat((ushort?) 1, 4).ToIList();
            ushort? SumActual = ZEnumerable.Sum(source);
            ushort? SumExpected = (ushort?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumushortNullableIList4Map()
        {
            var source = ZEnumerable.Repeat(new { X = (ushort?) 1 } , 4).ToIList();
            ushort? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ushort? SumExpected = (ushort?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumushortNullableIList100ThreatNulls()
        {
            var source = ZEnumerable.Repeat((ushort?) 1, 100).Select((x, i) => i%3==0 ? x : null).ToIList();
            ushort? SumActual = ZEnumerable.Sum(source);
            ushort? SumExpected = (ushort?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumushortNullableIList100ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((ushort?) 1, 100).Select((x, i) => i%3==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X = x } ).ToIList();
            ushort? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ushort? SumExpected = (ushort?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
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
        public void TestSumushortNullableIList2048ThreatNulls()
        {
            var source = ZEnumerable.Repeat((ushort?) 1, 2048).Select((x, i) => i%3==0 ? x : null).ToIList();
            ushort? SumActual = ZEnumerable.Sum(source);
            ushort? SumExpected = (ushort?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumushortNullableIList2048ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((ushort?) 1, 2048).Select((x, i) => i%3==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X = x } ).ToIList();
            ushort? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ushort? SumExpected = (ushort?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumushortNullableIList2048()
        {
            var source = ZEnumerable.Repeat((ushort?) 1, 2048).ToIList();
            ushort? SumActual = ZEnumerable.Sum(source);
            ushort? SumExpected = (ushort?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumushortNullableIList2048Map()
        {
            var source = ZEnumerable.Repeat(new { X = (ushort?) 1 } , 2048).ToIList();
            ushort? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ushort? SumExpected = (ushort?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
            
        [TestMethod]
        public void TestSumushortNullableIListNullOrEmpty()
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

            IList<ushort?> emptySource = new ushort?[0].ToIList();
            var sum = ZEnumerable.Sum(emptySource);
            Assert.AreEqual(sum, (ushort?) 0);
        }

        [TestMethod]
        public void TestSumushortNullableIListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<ushort?,ushort?>((ushort?) arg, (ushort?) arg)).ToIList();
            Func<KeyValuePair<ushort?, ushort?>, ushort?> nullMap = null;
            IList<ushort?> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            try
            {
                ZEnumerable.Sum(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            
            var emptySource = source.Take(0).ToIList();
            var sum = ZEnumerable.Sum(emptySource, x => (ushort?) x.Key);
            Assert.AreEqual(sum, (ushort?) 0);           
        }

                
        #endregion
            #region int?             
            

        
                        
            
        [TestMethod]
        public void TestSumintNullableArray1ThreatNulls()
        {
            var source = ZEnumerable.Repeat((int?) 1, 1).Select((x, i) => i%3==0 ? x : null).ToArray();
            int? SumActual = ZEnumerable.Sum(source);
            int? SumExpected = (int?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumintNullableArray1ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((int?) 1, 1).Select((x, i) => i%3==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X = x } ).ToArray();
            int? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            int? SumExpected = (int?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumintNullableArray1()
        {
            var source = ZEnumerable.Repeat((int?) 1, 1).ToArray();
            int? SumActual = ZEnumerable.Sum(source);
            int? SumExpected = (int?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumintNullableArray1Map()
        {
            var source = ZEnumerable.Repeat(new { X = (int?) 1 } , 1).ToArray();
            int? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            int? SumExpected = (int?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumintNullableArray2ThreatNulls()
        {
            var source = ZEnumerable.Repeat((int?) 1, 2).Select((x, i) => i%3==0 ? x : null).ToArray();
            int? SumActual = ZEnumerable.Sum(source);
            int? SumExpected = (int?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumintNullableArray2ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((int?) 1, 2).Select((x, i) => i%3==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X = x } ).ToArray();
            int? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            int? SumExpected = (int?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumintNullableArray2()
        {
            var source = ZEnumerable.Repeat((int?) 1, 2).ToArray();
            int? SumActual = ZEnumerable.Sum(source);
            int? SumExpected = (int?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumintNullableArray2Map()
        {
            var source = ZEnumerable.Repeat(new { X = (int?) 1 } , 2).ToArray();
            int? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            int? SumExpected = (int?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumintNullableArray3ThreatNulls()
        {
            var source = ZEnumerable.Repeat((int?) 1, 3).Select((x, i) => i%3==0 ? x : null).ToArray();
            int? SumActual = ZEnumerable.Sum(source);
            int? SumExpected = (int?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumintNullableArray3ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((int?) 1, 3).Select((x, i) => i%3==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X = x } ).ToArray();
            int? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            int? SumExpected = (int?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumintNullableArray3()
        {
            var source = ZEnumerable.Repeat((int?) 1, 3).ToArray();
            int? SumActual = ZEnumerable.Sum(source);
            int? SumExpected = (int?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumintNullableArray3Map()
        {
            var source = ZEnumerable.Repeat(new { X = (int?) 1 } , 3).ToArray();
            int? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            int? SumExpected = (int?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumintNullableArray4ThreatNulls()
        {
            var source = ZEnumerable.Repeat((int?) 1, 4).Select((x, i) => i%3==0 ? x : null).ToArray();
            int? SumActual = ZEnumerable.Sum(source);
            int? SumExpected = (int?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumintNullableArray4ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((int?) 1, 4).Select((x, i) => i%3==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X = x } ).ToArray();
            int? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            int? SumExpected = (int?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumintNullableArray4()
        {
            var source = ZEnumerable.Repeat((int?) 1, 4).ToArray();
            int? SumActual = ZEnumerable.Sum(source);
            int? SumExpected = (int?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumintNullableArray4Map()
        {
            var source = ZEnumerable.Repeat(new { X = (int?) 1 } , 4).ToArray();
            int? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            int? SumExpected = (int?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumintNullableArray100ThreatNulls()
        {
            var source = ZEnumerable.Repeat((int?) 1, 100).Select((x, i) => i%3==0 ? x : null).ToArray();
            int? SumActual = ZEnumerable.Sum(source);
            int? SumExpected = (int?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumintNullableArray100ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((int?) 1, 100).Select((x, i) => i%3==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X = x } ).ToArray();
            int? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            int? SumExpected = (int?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
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
        public void TestSumintNullableArray2048ThreatNulls()
        {
            var source = ZEnumerable.Repeat((int?) 1, 2048).Select((x, i) => i%3==0 ? x : null).ToArray();
            int? SumActual = ZEnumerable.Sum(source);
            int? SumExpected = (int?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumintNullableArray2048ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((int?) 1, 2048).Select((x, i) => i%3==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X = x } ).ToArray();
            int? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            int? SumExpected = (int?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumintNullableArray2048()
        {
            var source = ZEnumerable.Repeat((int?) 1, 2048).ToArray();
            int? SumActual = ZEnumerable.Sum(source);
            int? SumExpected = (int?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumintNullableArray2048Map()
        {
            var source = ZEnumerable.Repeat(new { X = (int?) 1 } , 2048).ToArray();
            int? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            int? SumExpected = (int?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
            
        [TestMethod]
        public void TestSumintNullableArrayNullOrEmpty()
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

            int?[] emptySource = new int?[0].ToArray();
            var sum = ZEnumerable.Sum(emptySource);
            Assert.AreEqual(sum, (int?) 0);
        }

        [TestMethod]
        public void TestSumintNullableArrayMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<int?,int?>((int?) arg, (int?) arg)).ToArray();
            Func<KeyValuePair<int?, int?>, int?> nullMap = null;
            int?[] nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            try
            {
                ZEnumerable.Sum(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            
            var emptySource = source.Take(0).ToArray();
            var sum = ZEnumerable.Sum(emptySource, x => (int?) x.Key);
            Assert.AreEqual(sum, (int?) 0);           
        }

            

        
                        
            
        [TestMethod]
        public void TestSumintNullableList1ThreatNulls()
        {
            var source = ZEnumerable.Repeat((int?) 1, 1).Select((x, i) => i%3==0 ? x : null).ToList();
            int? SumActual = ZEnumerable.Sum(source);
            int? SumExpected = (int?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumintNullableList1ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((int?) 1, 1).Select((x, i) => i%3==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X = x } ).ToList();
            int? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            int? SumExpected = (int?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumintNullableList1()
        {
            var source = ZEnumerable.Repeat((int?) 1, 1).ToList();
            int? SumActual = ZEnumerable.Sum(source);
            int? SumExpected = (int?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumintNullableList1Map()
        {
            var source = ZEnumerable.Repeat(new { X = (int?) 1 } , 1).ToList();
            int? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            int? SumExpected = (int?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumintNullableList2ThreatNulls()
        {
            var source = ZEnumerable.Repeat((int?) 1, 2).Select((x, i) => i%3==0 ? x : null).ToList();
            int? SumActual = ZEnumerable.Sum(source);
            int? SumExpected = (int?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumintNullableList2ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((int?) 1, 2).Select((x, i) => i%3==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X = x } ).ToList();
            int? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            int? SumExpected = (int?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumintNullableList2()
        {
            var source = ZEnumerable.Repeat((int?) 1, 2).ToList();
            int? SumActual = ZEnumerable.Sum(source);
            int? SumExpected = (int?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumintNullableList2Map()
        {
            var source = ZEnumerable.Repeat(new { X = (int?) 1 } , 2).ToList();
            int? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            int? SumExpected = (int?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumintNullableList3ThreatNulls()
        {
            var source = ZEnumerable.Repeat((int?) 1, 3).Select((x, i) => i%3==0 ? x : null).ToList();
            int? SumActual = ZEnumerable.Sum(source);
            int? SumExpected = (int?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumintNullableList3ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((int?) 1, 3).Select((x, i) => i%3==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X = x } ).ToList();
            int? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            int? SumExpected = (int?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumintNullableList3()
        {
            var source = ZEnumerable.Repeat((int?) 1, 3).ToList();
            int? SumActual = ZEnumerable.Sum(source);
            int? SumExpected = (int?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumintNullableList3Map()
        {
            var source = ZEnumerable.Repeat(new { X = (int?) 1 } , 3).ToList();
            int? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            int? SumExpected = (int?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumintNullableList4ThreatNulls()
        {
            var source = ZEnumerable.Repeat((int?) 1, 4).Select((x, i) => i%3==0 ? x : null).ToList();
            int? SumActual = ZEnumerable.Sum(source);
            int? SumExpected = (int?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumintNullableList4ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((int?) 1, 4).Select((x, i) => i%3==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X = x } ).ToList();
            int? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            int? SumExpected = (int?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumintNullableList4()
        {
            var source = ZEnumerable.Repeat((int?) 1, 4).ToList();
            int? SumActual = ZEnumerable.Sum(source);
            int? SumExpected = (int?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumintNullableList4Map()
        {
            var source = ZEnumerable.Repeat(new { X = (int?) 1 } , 4).ToList();
            int? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            int? SumExpected = (int?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumintNullableList100ThreatNulls()
        {
            var source = ZEnumerable.Repeat((int?) 1, 100).Select((x, i) => i%3==0 ? x : null).ToList();
            int? SumActual = ZEnumerable.Sum(source);
            int? SumExpected = (int?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumintNullableList100ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((int?) 1, 100).Select((x, i) => i%3==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X = x } ).ToList();
            int? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            int? SumExpected = (int?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
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
        public void TestSumintNullableList2048ThreatNulls()
        {
            var source = ZEnumerable.Repeat((int?) 1, 2048).Select((x, i) => i%3==0 ? x : null).ToList();
            int? SumActual = ZEnumerable.Sum(source);
            int? SumExpected = (int?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumintNullableList2048ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((int?) 1, 2048).Select((x, i) => i%3==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X = x } ).ToList();
            int? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            int? SumExpected = (int?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumintNullableList2048()
        {
            var source = ZEnumerable.Repeat((int?) 1, 2048).ToList();
            int? SumActual = ZEnumerable.Sum(source);
            int? SumExpected = (int?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumintNullableList2048Map()
        {
            var source = ZEnumerable.Repeat(new { X = (int?) 1 } , 2048).ToList();
            int? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            int? SumExpected = (int?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
            
        [TestMethod]
        public void TestSumintNullableListNullOrEmpty()
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

            List<int?> emptySource = new int?[0].ToList();
            var sum = ZEnumerable.Sum(emptySource);
            Assert.AreEqual(sum, (int?) 0);
        }

        [TestMethod]
        public void TestSumintNullableListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<int?,int?>((int?) arg, (int?) arg)).ToList();
            Func<KeyValuePair<int?, int?>, int?> nullMap = null;
            List<int?> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            try
            {
                ZEnumerable.Sum(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            
            var emptySource = source.Take(0).ToList();
            var sum = ZEnumerable.Sum(emptySource, x => (int?) x.Key);
            Assert.AreEqual(sum, (int?) 0);           
        }

            

        
                        
            
        [TestMethod]
        public void TestSumintNullableIList1ThreatNulls()
        {
            var source = ZEnumerable.Repeat((int?) 1, 1).Select((x, i) => i%3==0 ? x : null).ToIList();
            int? SumActual = ZEnumerable.Sum(source);
            int? SumExpected = (int?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumintNullableIList1ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((int?) 1, 1).Select((x, i) => i%3==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X = x } ).ToIList();
            int? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            int? SumExpected = (int?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumintNullableIList1()
        {
            var source = ZEnumerable.Repeat((int?) 1, 1).ToIList();
            int? SumActual = ZEnumerable.Sum(source);
            int? SumExpected = (int?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumintNullableIList1Map()
        {
            var source = ZEnumerable.Repeat(new { X = (int?) 1 } , 1).ToIList();
            int? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            int? SumExpected = (int?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumintNullableIList2ThreatNulls()
        {
            var source = ZEnumerable.Repeat((int?) 1, 2).Select((x, i) => i%3==0 ? x : null).ToIList();
            int? SumActual = ZEnumerable.Sum(source);
            int? SumExpected = (int?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumintNullableIList2ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((int?) 1, 2).Select((x, i) => i%3==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X = x } ).ToIList();
            int? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            int? SumExpected = (int?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumintNullableIList2()
        {
            var source = ZEnumerable.Repeat((int?) 1, 2).ToIList();
            int? SumActual = ZEnumerable.Sum(source);
            int? SumExpected = (int?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumintNullableIList2Map()
        {
            var source = ZEnumerable.Repeat(new { X = (int?) 1 } , 2).ToIList();
            int? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            int? SumExpected = (int?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumintNullableIList3ThreatNulls()
        {
            var source = ZEnumerable.Repeat((int?) 1, 3).Select((x, i) => i%3==0 ? x : null).ToIList();
            int? SumActual = ZEnumerable.Sum(source);
            int? SumExpected = (int?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumintNullableIList3ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((int?) 1, 3).Select((x, i) => i%3==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X = x } ).ToIList();
            int? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            int? SumExpected = (int?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumintNullableIList3()
        {
            var source = ZEnumerable.Repeat((int?) 1, 3).ToIList();
            int? SumActual = ZEnumerable.Sum(source);
            int? SumExpected = (int?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumintNullableIList3Map()
        {
            var source = ZEnumerable.Repeat(new { X = (int?) 1 } , 3).ToIList();
            int? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            int? SumExpected = (int?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumintNullableIList4ThreatNulls()
        {
            var source = ZEnumerable.Repeat((int?) 1, 4).Select((x, i) => i%3==0 ? x : null).ToIList();
            int? SumActual = ZEnumerable.Sum(source);
            int? SumExpected = (int?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumintNullableIList4ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((int?) 1, 4).Select((x, i) => i%3==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X = x } ).ToIList();
            int? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            int? SumExpected = (int?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumintNullableIList4()
        {
            var source = ZEnumerable.Repeat((int?) 1, 4).ToIList();
            int? SumActual = ZEnumerable.Sum(source);
            int? SumExpected = (int?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumintNullableIList4Map()
        {
            var source = ZEnumerable.Repeat(new { X = (int?) 1 } , 4).ToIList();
            int? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            int? SumExpected = (int?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumintNullableIList100ThreatNulls()
        {
            var source = ZEnumerable.Repeat((int?) 1, 100).Select((x, i) => i%3==0 ? x : null).ToIList();
            int? SumActual = ZEnumerable.Sum(source);
            int? SumExpected = (int?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumintNullableIList100ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((int?) 1, 100).Select((x, i) => i%3==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X = x } ).ToIList();
            int? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            int? SumExpected = (int?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
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
        public void TestSumintNullableIList2048ThreatNulls()
        {
            var source = ZEnumerable.Repeat((int?) 1, 2048).Select((x, i) => i%3==0 ? x : null).ToIList();
            int? SumActual = ZEnumerable.Sum(source);
            int? SumExpected = (int?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumintNullableIList2048ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((int?) 1, 2048).Select((x, i) => i%3==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X = x } ).ToIList();
            int? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            int? SumExpected = (int?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumintNullableIList2048()
        {
            var source = ZEnumerable.Repeat((int?) 1, 2048).ToIList();
            int? SumActual = ZEnumerable.Sum(source);
            int? SumExpected = (int?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumintNullableIList2048Map()
        {
            var source = ZEnumerable.Repeat(new { X = (int?) 1 } , 2048).ToIList();
            int? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            int? SumExpected = (int?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
            
        [TestMethod]
        public void TestSumintNullableIListNullOrEmpty()
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

            IList<int?> emptySource = new int?[0].ToIList();
            var sum = ZEnumerable.Sum(emptySource);
            Assert.AreEqual(sum, (int?) 0);
        }

        [TestMethod]
        public void TestSumintNullableIListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<int?,int?>((int?) arg, (int?) arg)).ToIList();
            Func<KeyValuePair<int?, int?>, int?> nullMap = null;
            IList<int?> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            try
            {
                ZEnumerable.Sum(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            
            var emptySource = source.Take(0).ToIList();
            var sum = ZEnumerable.Sum(emptySource, x => (int?) x.Key);
            Assert.AreEqual(sum, (int?) 0);           
        }

                
        #endregion
            #region uint?             
            

        
                        
            
        [TestMethod]
        public void TestSumuintNullableArray1ThreatNulls()
        {
            var source = ZEnumerable.Repeat((uint?) 1, 1).Select((x, i) => i%3==0 ? x : null).ToArray();
            uint? SumActual = ZEnumerable.Sum(source);
            uint? SumExpected = (uint?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumuintNullableArray1ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((uint?) 1, 1).Select((x, i) => i%3==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X = x } ).ToArray();
            uint? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            uint? SumExpected = (uint?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumuintNullableArray1()
        {
            var source = ZEnumerable.Repeat((uint?) 1, 1).ToArray();
            uint? SumActual = ZEnumerable.Sum(source);
            uint? SumExpected = (uint?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumuintNullableArray1Map()
        {
            var source = ZEnumerable.Repeat(new { X = (uint?) 1 } , 1).ToArray();
            uint? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            uint? SumExpected = (uint?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumuintNullableArray2ThreatNulls()
        {
            var source = ZEnumerable.Repeat((uint?) 1, 2).Select((x, i) => i%3==0 ? x : null).ToArray();
            uint? SumActual = ZEnumerable.Sum(source);
            uint? SumExpected = (uint?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumuintNullableArray2ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((uint?) 1, 2).Select((x, i) => i%3==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X = x } ).ToArray();
            uint? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            uint? SumExpected = (uint?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumuintNullableArray2()
        {
            var source = ZEnumerable.Repeat((uint?) 1, 2).ToArray();
            uint? SumActual = ZEnumerable.Sum(source);
            uint? SumExpected = (uint?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumuintNullableArray2Map()
        {
            var source = ZEnumerable.Repeat(new { X = (uint?) 1 } , 2).ToArray();
            uint? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            uint? SumExpected = (uint?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumuintNullableArray3ThreatNulls()
        {
            var source = ZEnumerable.Repeat((uint?) 1, 3).Select((x, i) => i%3==0 ? x : null).ToArray();
            uint? SumActual = ZEnumerable.Sum(source);
            uint? SumExpected = (uint?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumuintNullableArray3ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((uint?) 1, 3).Select((x, i) => i%3==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X = x } ).ToArray();
            uint? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            uint? SumExpected = (uint?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumuintNullableArray3()
        {
            var source = ZEnumerable.Repeat((uint?) 1, 3).ToArray();
            uint? SumActual = ZEnumerable.Sum(source);
            uint? SumExpected = (uint?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumuintNullableArray3Map()
        {
            var source = ZEnumerable.Repeat(new { X = (uint?) 1 } , 3).ToArray();
            uint? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            uint? SumExpected = (uint?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumuintNullableArray4ThreatNulls()
        {
            var source = ZEnumerable.Repeat((uint?) 1, 4).Select((x, i) => i%3==0 ? x : null).ToArray();
            uint? SumActual = ZEnumerable.Sum(source);
            uint? SumExpected = (uint?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumuintNullableArray4ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((uint?) 1, 4).Select((x, i) => i%3==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X = x } ).ToArray();
            uint? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            uint? SumExpected = (uint?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumuintNullableArray4()
        {
            var source = ZEnumerable.Repeat((uint?) 1, 4).ToArray();
            uint? SumActual = ZEnumerable.Sum(source);
            uint? SumExpected = (uint?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumuintNullableArray4Map()
        {
            var source = ZEnumerable.Repeat(new { X = (uint?) 1 } , 4).ToArray();
            uint? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            uint? SumExpected = (uint?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumuintNullableArray100ThreatNulls()
        {
            var source = ZEnumerable.Repeat((uint?) 1, 100).Select((x, i) => i%3==0 ? x : null).ToArray();
            uint? SumActual = ZEnumerable.Sum(source);
            uint? SumExpected = (uint?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumuintNullableArray100ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((uint?) 1, 100).Select((x, i) => i%3==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X = x } ).ToArray();
            uint? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            uint? SumExpected = (uint?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
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
        public void TestSumuintNullableArray2048ThreatNulls()
        {
            var source = ZEnumerable.Repeat((uint?) 1, 2048).Select((x, i) => i%3==0 ? x : null).ToArray();
            uint? SumActual = ZEnumerable.Sum(source);
            uint? SumExpected = (uint?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumuintNullableArray2048ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((uint?) 1, 2048).Select((x, i) => i%3==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X = x } ).ToArray();
            uint? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            uint? SumExpected = (uint?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumuintNullableArray2048()
        {
            var source = ZEnumerable.Repeat((uint?) 1, 2048).ToArray();
            uint? SumActual = ZEnumerable.Sum(source);
            uint? SumExpected = (uint?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumuintNullableArray2048Map()
        {
            var source = ZEnumerable.Repeat(new { X = (uint?) 1 } , 2048).ToArray();
            uint? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            uint? SumExpected = (uint?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
            
        [TestMethod]
        public void TestSumuintNullableArrayNullOrEmpty()
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

            uint?[] emptySource = new uint?[0].ToArray();
            var sum = ZEnumerable.Sum(emptySource);
            Assert.AreEqual(sum, (uint?) 0);
        }

        [TestMethod]
        public void TestSumuintNullableArrayMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<uint?,uint?>((uint?) arg, (uint?) arg)).ToArray();
            Func<KeyValuePair<uint?, uint?>, uint?> nullMap = null;
            uint?[] nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            try
            {
                ZEnumerable.Sum(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            
            var emptySource = source.Take(0).ToArray();
            var sum = ZEnumerable.Sum(emptySource, x => (uint?) x.Key);
            Assert.AreEqual(sum, (uint?) 0);           
        }

            

        
                        
            
        [TestMethod]
        public void TestSumuintNullableList1ThreatNulls()
        {
            var source = ZEnumerable.Repeat((uint?) 1, 1).Select((x, i) => i%3==0 ? x : null).ToList();
            uint? SumActual = ZEnumerable.Sum(source);
            uint? SumExpected = (uint?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumuintNullableList1ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((uint?) 1, 1).Select((x, i) => i%3==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X = x } ).ToList();
            uint? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            uint? SumExpected = (uint?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumuintNullableList1()
        {
            var source = ZEnumerable.Repeat((uint?) 1, 1).ToList();
            uint? SumActual = ZEnumerable.Sum(source);
            uint? SumExpected = (uint?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumuintNullableList1Map()
        {
            var source = ZEnumerable.Repeat(new { X = (uint?) 1 } , 1).ToList();
            uint? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            uint? SumExpected = (uint?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumuintNullableList2ThreatNulls()
        {
            var source = ZEnumerable.Repeat((uint?) 1, 2).Select((x, i) => i%3==0 ? x : null).ToList();
            uint? SumActual = ZEnumerable.Sum(source);
            uint? SumExpected = (uint?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumuintNullableList2ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((uint?) 1, 2).Select((x, i) => i%3==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X = x } ).ToList();
            uint? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            uint? SumExpected = (uint?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumuintNullableList2()
        {
            var source = ZEnumerable.Repeat((uint?) 1, 2).ToList();
            uint? SumActual = ZEnumerable.Sum(source);
            uint? SumExpected = (uint?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumuintNullableList2Map()
        {
            var source = ZEnumerable.Repeat(new { X = (uint?) 1 } , 2).ToList();
            uint? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            uint? SumExpected = (uint?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumuintNullableList3ThreatNulls()
        {
            var source = ZEnumerable.Repeat((uint?) 1, 3).Select((x, i) => i%3==0 ? x : null).ToList();
            uint? SumActual = ZEnumerable.Sum(source);
            uint? SumExpected = (uint?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumuintNullableList3ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((uint?) 1, 3).Select((x, i) => i%3==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X = x } ).ToList();
            uint? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            uint? SumExpected = (uint?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumuintNullableList3()
        {
            var source = ZEnumerable.Repeat((uint?) 1, 3).ToList();
            uint? SumActual = ZEnumerable.Sum(source);
            uint? SumExpected = (uint?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumuintNullableList3Map()
        {
            var source = ZEnumerable.Repeat(new { X = (uint?) 1 } , 3).ToList();
            uint? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            uint? SumExpected = (uint?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumuintNullableList4ThreatNulls()
        {
            var source = ZEnumerable.Repeat((uint?) 1, 4).Select((x, i) => i%3==0 ? x : null).ToList();
            uint? SumActual = ZEnumerable.Sum(source);
            uint? SumExpected = (uint?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumuintNullableList4ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((uint?) 1, 4).Select((x, i) => i%3==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X = x } ).ToList();
            uint? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            uint? SumExpected = (uint?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumuintNullableList4()
        {
            var source = ZEnumerable.Repeat((uint?) 1, 4).ToList();
            uint? SumActual = ZEnumerable.Sum(source);
            uint? SumExpected = (uint?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumuintNullableList4Map()
        {
            var source = ZEnumerable.Repeat(new { X = (uint?) 1 } , 4).ToList();
            uint? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            uint? SumExpected = (uint?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumuintNullableList100ThreatNulls()
        {
            var source = ZEnumerable.Repeat((uint?) 1, 100).Select((x, i) => i%3==0 ? x : null).ToList();
            uint? SumActual = ZEnumerable.Sum(source);
            uint? SumExpected = (uint?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumuintNullableList100ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((uint?) 1, 100).Select((x, i) => i%3==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X = x } ).ToList();
            uint? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            uint? SumExpected = (uint?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
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
        public void TestSumuintNullableList2048ThreatNulls()
        {
            var source = ZEnumerable.Repeat((uint?) 1, 2048).Select((x, i) => i%3==0 ? x : null).ToList();
            uint? SumActual = ZEnumerable.Sum(source);
            uint? SumExpected = (uint?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumuintNullableList2048ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((uint?) 1, 2048).Select((x, i) => i%3==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X = x } ).ToList();
            uint? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            uint? SumExpected = (uint?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumuintNullableList2048()
        {
            var source = ZEnumerable.Repeat((uint?) 1, 2048).ToList();
            uint? SumActual = ZEnumerable.Sum(source);
            uint? SumExpected = (uint?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumuintNullableList2048Map()
        {
            var source = ZEnumerable.Repeat(new { X = (uint?) 1 } , 2048).ToList();
            uint? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            uint? SumExpected = (uint?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
            
        [TestMethod]
        public void TestSumuintNullableListNullOrEmpty()
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

            List<uint?> emptySource = new uint?[0].ToList();
            var sum = ZEnumerable.Sum(emptySource);
            Assert.AreEqual(sum, (uint?) 0);
        }

        [TestMethod]
        public void TestSumuintNullableListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<uint?,uint?>((uint?) arg, (uint?) arg)).ToList();
            Func<KeyValuePair<uint?, uint?>, uint?> nullMap = null;
            List<uint?> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            try
            {
                ZEnumerable.Sum(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            
            var emptySource = source.Take(0).ToList();
            var sum = ZEnumerable.Sum(emptySource, x => (uint?) x.Key);
            Assert.AreEqual(sum, (uint?) 0);           
        }

            

        
                        
            
        [TestMethod]
        public void TestSumuintNullableIList1ThreatNulls()
        {
            var source = ZEnumerable.Repeat((uint?) 1, 1).Select((x, i) => i%3==0 ? x : null).ToIList();
            uint? SumActual = ZEnumerable.Sum(source);
            uint? SumExpected = (uint?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumuintNullableIList1ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((uint?) 1, 1).Select((x, i) => i%3==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X = x } ).ToIList();
            uint? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            uint? SumExpected = (uint?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumuintNullableIList1()
        {
            var source = ZEnumerable.Repeat((uint?) 1, 1).ToIList();
            uint? SumActual = ZEnumerable.Sum(source);
            uint? SumExpected = (uint?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumuintNullableIList1Map()
        {
            var source = ZEnumerable.Repeat(new { X = (uint?) 1 } , 1).ToIList();
            uint? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            uint? SumExpected = (uint?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumuintNullableIList2ThreatNulls()
        {
            var source = ZEnumerable.Repeat((uint?) 1, 2).Select((x, i) => i%3==0 ? x : null).ToIList();
            uint? SumActual = ZEnumerable.Sum(source);
            uint? SumExpected = (uint?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumuintNullableIList2ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((uint?) 1, 2).Select((x, i) => i%3==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X = x } ).ToIList();
            uint? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            uint? SumExpected = (uint?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumuintNullableIList2()
        {
            var source = ZEnumerable.Repeat((uint?) 1, 2).ToIList();
            uint? SumActual = ZEnumerable.Sum(source);
            uint? SumExpected = (uint?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumuintNullableIList2Map()
        {
            var source = ZEnumerable.Repeat(new { X = (uint?) 1 } , 2).ToIList();
            uint? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            uint? SumExpected = (uint?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumuintNullableIList3ThreatNulls()
        {
            var source = ZEnumerable.Repeat((uint?) 1, 3).Select((x, i) => i%3==0 ? x : null).ToIList();
            uint? SumActual = ZEnumerable.Sum(source);
            uint? SumExpected = (uint?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumuintNullableIList3ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((uint?) 1, 3).Select((x, i) => i%3==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X = x } ).ToIList();
            uint? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            uint? SumExpected = (uint?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumuintNullableIList3()
        {
            var source = ZEnumerable.Repeat((uint?) 1, 3).ToIList();
            uint? SumActual = ZEnumerable.Sum(source);
            uint? SumExpected = (uint?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumuintNullableIList3Map()
        {
            var source = ZEnumerable.Repeat(new { X = (uint?) 1 } , 3).ToIList();
            uint? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            uint? SumExpected = (uint?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumuintNullableIList4ThreatNulls()
        {
            var source = ZEnumerable.Repeat((uint?) 1, 4).Select((x, i) => i%3==0 ? x : null).ToIList();
            uint? SumActual = ZEnumerable.Sum(source);
            uint? SumExpected = (uint?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumuintNullableIList4ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((uint?) 1, 4).Select((x, i) => i%3==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X = x } ).ToIList();
            uint? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            uint? SumExpected = (uint?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumuintNullableIList4()
        {
            var source = ZEnumerable.Repeat((uint?) 1, 4).ToIList();
            uint? SumActual = ZEnumerable.Sum(source);
            uint? SumExpected = (uint?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumuintNullableIList4Map()
        {
            var source = ZEnumerable.Repeat(new { X = (uint?) 1 } , 4).ToIList();
            uint? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            uint? SumExpected = (uint?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumuintNullableIList100ThreatNulls()
        {
            var source = ZEnumerable.Repeat((uint?) 1, 100).Select((x, i) => i%3==0 ? x : null).ToIList();
            uint? SumActual = ZEnumerable.Sum(source);
            uint? SumExpected = (uint?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumuintNullableIList100ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((uint?) 1, 100).Select((x, i) => i%3==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X = x } ).ToIList();
            uint? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            uint? SumExpected = (uint?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
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
        public void TestSumuintNullableIList2048ThreatNulls()
        {
            var source = ZEnumerable.Repeat((uint?) 1, 2048).Select((x, i) => i%3==0 ? x : null).ToIList();
            uint? SumActual = ZEnumerable.Sum(source);
            uint? SumExpected = (uint?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumuintNullableIList2048ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((uint?) 1, 2048).Select((x, i) => i%3==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X = x } ).ToIList();
            uint? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            uint? SumExpected = (uint?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumuintNullableIList2048()
        {
            var source = ZEnumerable.Repeat((uint?) 1, 2048).ToIList();
            uint? SumActual = ZEnumerable.Sum(source);
            uint? SumExpected = (uint?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumuintNullableIList2048Map()
        {
            var source = ZEnumerable.Repeat(new { X = (uint?) 1 } , 2048).ToIList();
            uint? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            uint? SumExpected = (uint?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
            
        [TestMethod]
        public void TestSumuintNullableIListNullOrEmpty()
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

            IList<uint?> emptySource = new uint?[0].ToIList();
            var sum = ZEnumerable.Sum(emptySource);
            Assert.AreEqual(sum, (uint?) 0);
        }

        [TestMethod]
        public void TestSumuintNullableIListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<uint?,uint?>((uint?) arg, (uint?) arg)).ToIList();
            Func<KeyValuePair<uint?, uint?>, uint?> nullMap = null;
            IList<uint?> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            try
            {
                ZEnumerable.Sum(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            
            var emptySource = source.Take(0).ToIList();
            var sum = ZEnumerable.Sum(emptySource, x => (uint?) x.Key);
            Assert.AreEqual(sum, (uint?) 0);           
        }

                
        #endregion
            #region long?             
            

        
                        
            
        [TestMethod]
        public void TestSumlongNullableArray1ThreatNulls()
        {
            var source = ZEnumerable.Repeat((long?) 1, 1).Select((x, i) => i%3==0 ? x : null).ToArray();
            long? SumActual = ZEnumerable.Sum(source);
            long? SumExpected = (long?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumlongNullableArray1ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((long?) 1, 1).Select((x, i) => i%3==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X = x } ).ToArray();
            long? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            long? SumExpected = (long?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumlongNullableArray1()
        {
            var source = ZEnumerable.Repeat((long?) 1, 1).ToArray();
            long? SumActual = ZEnumerable.Sum(source);
            long? SumExpected = (long?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumlongNullableArray1Map()
        {
            var source = ZEnumerable.Repeat(new { X = (long?) 1 } , 1).ToArray();
            long? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            long? SumExpected = (long?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumlongNullableArray2ThreatNulls()
        {
            var source = ZEnumerable.Repeat((long?) 1, 2).Select((x, i) => i%3==0 ? x : null).ToArray();
            long? SumActual = ZEnumerable.Sum(source);
            long? SumExpected = (long?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumlongNullableArray2ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((long?) 1, 2).Select((x, i) => i%3==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X = x } ).ToArray();
            long? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            long? SumExpected = (long?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumlongNullableArray2()
        {
            var source = ZEnumerable.Repeat((long?) 1, 2).ToArray();
            long? SumActual = ZEnumerable.Sum(source);
            long? SumExpected = (long?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumlongNullableArray2Map()
        {
            var source = ZEnumerable.Repeat(new { X = (long?) 1 } , 2).ToArray();
            long? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            long? SumExpected = (long?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumlongNullableArray3ThreatNulls()
        {
            var source = ZEnumerable.Repeat((long?) 1, 3).Select((x, i) => i%3==0 ? x : null).ToArray();
            long? SumActual = ZEnumerable.Sum(source);
            long? SumExpected = (long?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumlongNullableArray3ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((long?) 1, 3).Select((x, i) => i%3==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X = x } ).ToArray();
            long? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            long? SumExpected = (long?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumlongNullableArray3()
        {
            var source = ZEnumerable.Repeat((long?) 1, 3).ToArray();
            long? SumActual = ZEnumerable.Sum(source);
            long? SumExpected = (long?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumlongNullableArray3Map()
        {
            var source = ZEnumerable.Repeat(new { X = (long?) 1 } , 3).ToArray();
            long? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            long? SumExpected = (long?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumlongNullableArray4ThreatNulls()
        {
            var source = ZEnumerable.Repeat((long?) 1, 4).Select((x, i) => i%3==0 ? x : null).ToArray();
            long? SumActual = ZEnumerable.Sum(source);
            long? SumExpected = (long?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumlongNullableArray4ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((long?) 1, 4).Select((x, i) => i%3==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X = x } ).ToArray();
            long? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            long? SumExpected = (long?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumlongNullableArray4()
        {
            var source = ZEnumerable.Repeat((long?) 1, 4).ToArray();
            long? SumActual = ZEnumerable.Sum(source);
            long? SumExpected = (long?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumlongNullableArray4Map()
        {
            var source = ZEnumerable.Repeat(new { X = (long?) 1 } , 4).ToArray();
            long? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            long? SumExpected = (long?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumlongNullableArray100ThreatNulls()
        {
            var source = ZEnumerable.Repeat((long?) 1, 100).Select((x, i) => i%3==0 ? x : null).ToArray();
            long? SumActual = ZEnumerable.Sum(source);
            long? SumExpected = (long?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumlongNullableArray100ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((long?) 1, 100).Select((x, i) => i%3==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X = x } ).ToArray();
            long? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            long? SumExpected = (long?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
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
        public void TestSumlongNullableArray2048ThreatNulls()
        {
            var source = ZEnumerable.Repeat((long?) 1, 2048).Select((x, i) => i%3==0 ? x : null).ToArray();
            long? SumActual = ZEnumerable.Sum(source);
            long? SumExpected = (long?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumlongNullableArray2048ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((long?) 1, 2048).Select((x, i) => i%3==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X = x } ).ToArray();
            long? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            long? SumExpected = (long?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumlongNullableArray2048()
        {
            var source = ZEnumerable.Repeat((long?) 1, 2048).ToArray();
            long? SumActual = ZEnumerable.Sum(source);
            long? SumExpected = (long?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumlongNullableArray2048Map()
        {
            var source = ZEnumerable.Repeat(new { X = (long?) 1 } , 2048).ToArray();
            long? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            long? SumExpected = (long?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
            
        [TestMethod]
        public void TestSumlongNullableArrayNullOrEmpty()
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

            long?[] emptySource = new long?[0].ToArray();
            var sum = ZEnumerable.Sum(emptySource);
            Assert.AreEqual(sum, (long?) 0);
        }

        [TestMethod]
        public void TestSumlongNullableArrayMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<long?,long?>((long?) arg, (long?) arg)).ToArray();
            Func<KeyValuePair<long?, long?>, long?> nullMap = null;
            long?[] nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            try
            {
                ZEnumerable.Sum(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            
            var emptySource = source.Take(0).ToArray();
            var sum = ZEnumerable.Sum(emptySource, x => (long?) x.Key);
            Assert.AreEqual(sum, (long?) 0);           
        }

            

        
                        
            
        [TestMethod]
        public void TestSumlongNullableList1ThreatNulls()
        {
            var source = ZEnumerable.Repeat((long?) 1, 1).Select((x, i) => i%3==0 ? x : null).ToList();
            long? SumActual = ZEnumerable.Sum(source);
            long? SumExpected = (long?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumlongNullableList1ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((long?) 1, 1).Select((x, i) => i%3==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X = x } ).ToList();
            long? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            long? SumExpected = (long?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumlongNullableList1()
        {
            var source = ZEnumerable.Repeat((long?) 1, 1).ToList();
            long? SumActual = ZEnumerable.Sum(source);
            long? SumExpected = (long?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumlongNullableList1Map()
        {
            var source = ZEnumerable.Repeat(new { X = (long?) 1 } , 1).ToList();
            long? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            long? SumExpected = (long?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumlongNullableList2ThreatNulls()
        {
            var source = ZEnumerable.Repeat((long?) 1, 2).Select((x, i) => i%3==0 ? x : null).ToList();
            long? SumActual = ZEnumerable.Sum(source);
            long? SumExpected = (long?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumlongNullableList2ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((long?) 1, 2).Select((x, i) => i%3==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X = x } ).ToList();
            long? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            long? SumExpected = (long?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumlongNullableList2()
        {
            var source = ZEnumerable.Repeat((long?) 1, 2).ToList();
            long? SumActual = ZEnumerable.Sum(source);
            long? SumExpected = (long?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumlongNullableList2Map()
        {
            var source = ZEnumerable.Repeat(new { X = (long?) 1 } , 2).ToList();
            long? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            long? SumExpected = (long?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumlongNullableList3ThreatNulls()
        {
            var source = ZEnumerable.Repeat((long?) 1, 3).Select((x, i) => i%3==0 ? x : null).ToList();
            long? SumActual = ZEnumerable.Sum(source);
            long? SumExpected = (long?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumlongNullableList3ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((long?) 1, 3).Select((x, i) => i%3==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X = x } ).ToList();
            long? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            long? SumExpected = (long?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumlongNullableList3()
        {
            var source = ZEnumerable.Repeat((long?) 1, 3).ToList();
            long? SumActual = ZEnumerable.Sum(source);
            long? SumExpected = (long?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumlongNullableList3Map()
        {
            var source = ZEnumerable.Repeat(new { X = (long?) 1 } , 3).ToList();
            long? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            long? SumExpected = (long?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumlongNullableList4ThreatNulls()
        {
            var source = ZEnumerable.Repeat((long?) 1, 4).Select((x, i) => i%3==0 ? x : null).ToList();
            long? SumActual = ZEnumerable.Sum(source);
            long? SumExpected = (long?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumlongNullableList4ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((long?) 1, 4).Select((x, i) => i%3==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X = x } ).ToList();
            long? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            long? SumExpected = (long?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumlongNullableList4()
        {
            var source = ZEnumerable.Repeat((long?) 1, 4).ToList();
            long? SumActual = ZEnumerable.Sum(source);
            long? SumExpected = (long?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumlongNullableList4Map()
        {
            var source = ZEnumerable.Repeat(new { X = (long?) 1 } , 4).ToList();
            long? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            long? SumExpected = (long?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumlongNullableList100ThreatNulls()
        {
            var source = ZEnumerable.Repeat((long?) 1, 100).Select((x, i) => i%3==0 ? x : null).ToList();
            long? SumActual = ZEnumerable.Sum(source);
            long? SumExpected = (long?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumlongNullableList100ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((long?) 1, 100).Select((x, i) => i%3==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X = x } ).ToList();
            long? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            long? SumExpected = (long?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
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
        public void TestSumlongNullableList2048ThreatNulls()
        {
            var source = ZEnumerable.Repeat((long?) 1, 2048).Select((x, i) => i%3==0 ? x : null).ToList();
            long? SumActual = ZEnumerable.Sum(source);
            long? SumExpected = (long?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumlongNullableList2048ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((long?) 1, 2048).Select((x, i) => i%3==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X = x } ).ToList();
            long? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            long? SumExpected = (long?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumlongNullableList2048()
        {
            var source = ZEnumerable.Repeat((long?) 1, 2048).ToList();
            long? SumActual = ZEnumerable.Sum(source);
            long? SumExpected = (long?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumlongNullableList2048Map()
        {
            var source = ZEnumerable.Repeat(new { X = (long?) 1 } , 2048).ToList();
            long? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            long? SumExpected = (long?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
            
        [TestMethod]
        public void TestSumlongNullableListNullOrEmpty()
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

            List<long?> emptySource = new long?[0].ToList();
            var sum = ZEnumerable.Sum(emptySource);
            Assert.AreEqual(sum, (long?) 0);
        }

        [TestMethod]
        public void TestSumlongNullableListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<long?,long?>((long?) arg, (long?) arg)).ToList();
            Func<KeyValuePair<long?, long?>, long?> nullMap = null;
            List<long?> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            try
            {
                ZEnumerable.Sum(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            
            var emptySource = source.Take(0).ToList();
            var sum = ZEnumerable.Sum(emptySource, x => (long?) x.Key);
            Assert.AreEqual(sum, (long?) 0);           
        }

            

        
                        
            
        [TestMethod]
        public void TestSumlongNullableIList1ThreatNulls()
        {
            var source = ZEnumerable.Repeat((long?) 1, 1).Select((x, i) => i%3==0 ? x : null).ToIList();
            long? SumActual = ZEnumerable.Sum(source);
            long? SumExpected = (long?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumlongNullableIList1ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((long?) 1, 1).Select((x, i) => i%3==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X = x } ).ToIList();
            long? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            long? SumExpected = (long?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumlongNullableIList1()
        {
            var source = ZEnumerable.Repeat((long?) 1, 1).ToIList();
            long? SumActual = ZEnumerable.Sum(source);
            long? SumExpected = (long?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumlongNullableIList1Map()
        {
            var source = ZEnumerable.Repeat(new { X = (long?) 1 } , 1).ToIList();
            long? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            long? SumExpected = (long?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumlongNullableIList2ThreatNulls()
        {
            var source = ZEnumerable.Repeat((long?) 1, 2).Select((x, i) => i%3==0 ? x : null).ToIList();
            long? SumActual = ZEnumerable.Sum(source);
            long? SumExpected = (long?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumlongNullableIList2ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((long?) 1, 2).Select((x, i) => i%3==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X = x } ).ToIList();
            long? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            long? SumExpected = (long?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumlongNullableIList2()
        {
            var source = ZEnumerable.Repeat((long?) 1, 2).ToIList();
            long? SumActual = ZEnumerable.Sum(source);
            long? SumExpected = (long?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumlongNullableIList2Map()
        {
            var source = ZEnumerable.Repeat(new { X = (long?) 1 } , 2).ToIList();
            long? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            long? SumExpected = (long?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumlongNullableIList3ThreatNulls()
        {
            var source = ZEnumerable.Repeat((long?) 1, 3).Select((x, i) => i%3==0 ? x : null).ToIList();
            long? SumActual = ZEnumerable.Sum(source);
            long? SumExpected = (long?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumlongNullableIList3ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((long?) 1, 3).Select((x, i) => i%3==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X = x } ).ToIList();
            long? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            long? SumExpected = (long?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumlongNullableIList3()
        {
            var source = ZEnumerable.Repeat((long?) 1, 3).ToIList();
            long? SumActual = ZEnumerable.Sum(source);
            long? SumExpected = (long?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumlongNullableIList3Map()
        {
            var source = ZEnumerable.Repeat(new { X = (long?) 1 } , 3).ToIList();
            long? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            long? SumExpected = (long?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumlongNullableIList4ThreatNulls()
        {
            var source = ZEnumerable.Repeat((long?) 1, 4).Select((x, i) => i%3==0 ? x : null).ToIList();
            long? SumActual = ZEnumerable.Sum(source);
            long? SumExpected = (long?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumlongNullableIList4ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((long?) 1, 4).Select((x, i) => i%3==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X = x } ).ToIList();
            long? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            long? SumExpected = (long?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumlongNullableIList4()
        {
            var source = ZEnumerable.Repeat((long?) 1, 4).ToIList();
            long? SumActual = ZEnumerable.Sum(source);
            long? SumExpected = (long?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumlongNullableIList4Map()
        {
            var source = ZEnumerable.Repeat(new { X = (long?) 1 } , 4).ToIList();
            long? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            long? SumExpected = (long?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumlongNullableIList100ThreatNulls()
        {
            var source = ZEnumerable.Repeat((long?) 1, 100).Select((x, i) => i%3==0 ? x : null).ToIList();
            long? SumActual = ZEnumerable.Sum(source);
            long? SumExpected = (long?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumlongNullableIList100ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((long?) 1, 100).Select((x, i) => i%3==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X = x } ).ToIList();
            long? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            long? SumExpected = (long?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
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
        public void TestSumlongNullableIList2048ThreatNulls()
        {
            var source = ZEnumerable.Repeat((long?) 1, 2048).Select((x, i) => i%3==0 ? x : null).ToIList();
            long? SumActual = ZEnumerable.Sum(source);
            long? SumExpected = (long?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumlongNullableIList2048ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((long?) 1, 2048).Select((x, i) => i%3==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X = x } ).ToIList();
            long? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            long? SumExpected = (long?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumlongNullableIList2048()
        {
            var source = ZEnumerable.Repeat((long?) 1, 2048).ToIList();
            long? SumActual = ZEnumerable.Sum(source);
            long? SumExpected = (long?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumlongNullableIList2048Map()
        {
            var source = ZEnumerable.Repeat(new { X = (long?) 1 } , 2048).ToIList();
            long? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            long? SumExpected = (long?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
            
        [TestMethod]
        public void TestSumlongNullableIListNullOrEmpty()
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

            IList<long?> emptySource = new long?[0].ToIList();
            var sum = ZEnumerable.Sum(emptySource);
            Assert.AreEqual(sum, (long?) 0);
        }

        [TestMethod]
        public void TestSumlongNullableIListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<long?,long?>((long?) arg, (long?) arg)).ToIList();
            Func<KeyValuePair<long?, long?>, long?> nullMap = null;
            IList<long?> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            try
            {
                ZEnumerable.Sum(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            
            var emptySource = source.Take(0).ToIList();
            var sum = ZEnumerable.Sum(emptySource, x => (long?) x.Key);
            Assert.AreEqual(sum, (long?) 0);           
        }

                
        #endregion
            #region ulong?             
            

        
                        
            
        [TestMethod]
        public void TestSumulongNullableArray1ThreatNulls()
        {
            var source = ZEnumerable.Repeat((ulong?) 1, 1).Select((x, i) => i%3==0 ? x : null).ToArray();
            ulong? SumActual = ZEnumerable.Sum(source);
            ulong? SumExpected = (ulong?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumulongNullableArray1ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((ulong?) 1, 1).Select((x, i) => i%3==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X = x } ).ToArray();
            ulong? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ulong? SumExpected = (ulong?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumulongNullableArray1()
        {
            var source = ZEnumerable.Repeat((ulong?) 1, 1).ToArray();
            ulong? SumActual = ZEnumerable.Sum(source);
            ulong? SumExpected = (ulong?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumulongNullableArray1Map()
        {
            var source = ZEnumerable.Repeat(new { X = (ulong?) 1 } , 1).ToArray();
            ulong? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ulong? SumExpected = (ulong?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumulongNullableArray2ThreatNulls()
        {
            var source = ZEnumerable.Repeat((ulong?) 1, 2).Select((x, i) => i%3==0 ? x : null).ToArray();
            ulong? SumActual = ZEnumerable.Sum(source);
            ulong? SumExpected = (ulong?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumulongNullableArray2ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((ulong?) 1, 2).Select((x, i) => i%3==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X = x } ).ToArray();
            ulong? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ulong? SumExpected = (ulong?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumulongNullableArray2()
        {
            var source = ZEnumerable.Repeat((ulong?) 1, 2).ToArray();
            ulong? SumActual = ZEnumerable.Sum(source);
            ulong? SumExpected = (ulong?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumulongNullableArray2Map()
        {
            var source = ZEnumerable.Repeat(new { X = (ulong?) 1 } , 2).ToArray();
            ulong? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ulong? SumExpected = (ulong?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumulongNullableArray3ThreatNulls()
        {
            var source = ZEnumerable.Repeat((ulong?) 1, 3).Select((x, i) => i%3==0 ? x : null).ToArray();
            ulong? SumActual = ZEnumerable.Sum(source);
            ulong? SumExpected = (ulong?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumulongNullableArray3ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((ulong?) 1, 3).Select((x, i) => i%3==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X = x } ).ToArray();
            ulong? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ulong? SumExpected = (ulong?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumulongNullableArray3()
        {
            var source = ZEnumerable.Repeat((ulong?) 1, 3).ToArray();
            ulong? SumActual = ZEnumerable.Sum(source);
            ulong? SumExpected = (ulong?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumulongNullableArray3Map()
        {
            var source = ZEnumerable.Repeat(new { X = (ulong?) 1 } , 3).ToArray();
            ulong? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ulong? SumExpected = (ulong?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumulongNullableArray4ThreatNulls()
        {
            var source = ZEnumerable.Repeat((ulong?) 1, 4).Select((x, i) => i%3==0 ? x : null).ToArray();
            ulong? SumActual = ZEnumerable.Sum(source);
            ulong? SumExpected = (ulong?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumulongNullableArray4ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((ulong?) 1, 4).Select((x, i) => i%3==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X = x } ).ToArray();
            ulong? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ulong? SumExpected = (ulong?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumulongNullableArray4()
        {
            var source = ZEnumerable.Repeat((ulong?) 1, 4).ToArray();
            ulong? SumActual = ZEnumerable.Sum(source);
            ulong? SumExpected = (ulong?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumulongNullableArray4Map()
        {
            var source = ZEnumerable.Repeat(new { X = (ulong?) 1 } , 4).ToArray();
            ulong? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ulong? SumExpected = (ulong?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumulongNullableArray100ThreatNulls()
        {
            var source = ZEnumerable.Repeat((ulong?) 1, 100).Select((x, i) => i%3==0 ? x : null).ToArray();
            ulong? SumActual = ZEnumerable.Sum(source);
            ulong? SumExpected = (ulong?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumulongNullableArray100ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((ulong?) 1, 100).Select((x, i) => i%3==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X = x } ).ToArray();
            ulong? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ulong? SumExpected = (ulong?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
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
        public void TestSumulongNullableArray2048ThreatNulls()
        {
            var source = ZEnumerable.Repeat((ulong?) 1, 2048).Select((x, i) => i%3==0 ? x : null).ToArray();
            ulong? SumActual = ZEnumerable.Sum(source);
            ulong? SumExpected = (ulong?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumulongNullableArray2048ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((ulong?) 1, 2048).Select((x, i) => i%3==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X = x } ).ToArray();
            ulong? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ulong? SumExpected = (ulong?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumulongNullableArray2048()
        {
            var source = ZEnumerable.Repeat((ulong?) 1, 2048).ToArray();
            ulong? SumActual = ZEnumerable.Sum(source);
            ulong? SumExpected = (ulong?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumulongNullableArray2048Map()
        {
            var source = ZEnumerable.Repeat(new { X = (ulong?) 1 } , 2048).ToArray();
            ulong? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ulong? SumExpected = (ulong?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
            
        [TestMethod]
        public void TestSumulongNullableArrayNullOrEmpty()
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

            ulong?[] emptySource = new ulong?[0].ToArray();
            var sum = ZEnumerable.Sum(emptySource);
            Assert.AreEqual(sum, (ulong?) 0);
        }

        [TestMethod]
        public void TestSumulongNullableArrayMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<ulong?,ulong?>((ulong?) arg, (ulong?) arg)).ToArray();
            Func<KeyValuePair<ulong?, ulong?>, ulong?> nullMap = null;
            ulong?[] nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            try
            {
                ZEnumerable.Sum(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            
            var emptySource = source.Take(0).ToArray();
            var sum = ZEnumerable.Sum(emptySource, x => (ulong?) x.Key);
            Assert.AreEqual(sum, (ulong?) 0);           
        }

            

        
                        
            
        [TestMethod]
        public void TestSumulongNullableList1ThreatNulls()
        {
            var source = ZEnumerable.Repeat((ulong?) 1, 1).Select((x, i) => i%3==0 ? x : null).ToList();
            ulong? SumActual = ZEnumerable.Sum(source);
            ulong? SumExpected = (ulong?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumulongNullableList1ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((ulong?) 1, 1).Select((x, i) => i%3==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X = x } ).ToList();
            ulong? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ulong? SumExpected = (ulong?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumulongNullableList1()
        {
            var source = ZEnumerable.Repeat((ulong?) 1, 1).ToList();
            ulong? SumActual = ZEnumerable.Sum(source);
            ulong? SumExpected = (ulong?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumulongNullableList1Map()
        {
            var source = ZEnumerable.Repeat(new { X = (ulong?) 1 } , 1).ToList();
            ulong? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ulong? SumExpected = (ulong?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumulongNullableList2ThreatNulls()
        {
            var source = ZEnumerable.Repeat((ulong?) 1, 2).Select((x, i) => i%3==0 ? x : null).ToList();
            ulong? SumActual = ZEnumerable.Sum(source);
            ulong? SumExpected = (ulong?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumulongNullableList2ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((ulong?) 1, 2).Select((x, i) => i%3==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X = x } ).ToList();
            ulong? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ulong? SumExpected = (ulong?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumulongNullableList2()
        {
            var source = ZEnumerable.Repeat((ulong?) 1, 2).ToList();
            ulong? SumActual = ZEnumerable.Sum(source);
            ulong? SumExpected = (ulong?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumulongNullableList2Map()
        {
            var source = ZEnumerable.Repeat(new { X = (ulong?) 1 } , 2).ToList();
            ulong? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ulong? SumExpected = (ulong?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumulongNullableList3ThreatNulls()
        {
            var source = ZEnumerable.Repeat((ulong?) 1, 3).Select((x, i) => i%3==0 ? x : null).ToList();
            ulong? SumActual = ZEnumerable.Sum(source);
            ulong? SumExpected = (ulong?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumulongNullableList3ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((ulong?) 1, 3).Select((x, i) => i%3==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X = x } ).ToList();
            ulong? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ulong? SumExpected = (ulong?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumulongNullableList3()
        {
            var source = ZEnumerable.Repeat((ulong?) 1, 3).ToList();
            ulong? SumActual = ZEnumerable.Sum(source);
            ulong? SumExpected = (ulong?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumulongNullableList3Map()
        {
            var source = ZEnumerable.Repeat(new { X = (ulong?) 1 } , 3).ToList();
            ulong? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ulong? SumExpected = (ulong?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumulongNullableList4ThreatNulls()
        {
            var source = ZEnumerable.Repeat((ulong?) 1, 4).Select((x, i) => i%3==0 ? x : null).ToList();
            ulong? SumActual = ZEnumerable.Sum(source);
            ulong? SumExpected = (ulong?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumulongNullableList4ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((ulong?) 1, 4).Select((x, i) => i%3==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X = x } ).ToList();
            ulong? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ulong? SumExpected = (ulong?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumulongNullableList4()
        {
            var source = ZEnumerable.Repeat((ulong?) 1, 4).ToList();
            ulong? SumActual = ZEnumerable.Sum(source);
            ulong? SumExpected = (ulong?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumulongNullableList4Map()
        {
            var source = ZEnumerable.Repeat(new { X = (ulong?) 1 } , 4).ToList();
            ulong? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ulong? SumExpected = (ulong?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumulongNullableList100ThreatNulls()
        {
            var source = ZEnumerable.Repeat((ulong?) 1, 100).Select((x, i) => i%3==0 ? x : null).ToList();
            ulong? SumActual = ZEnumerable.Sum(source);
            ulong? SumExpected = (ulong?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumulongNullableList100ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((ulong?) 1, 100).Select((x, i) => i%3==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X = x } ).ToList();
            ulong? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ulong? SumExpected = (ulong?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
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
        public void TestSumulongNullableList2048ThreatNulls()
        {
            var source = ZEnumerable.Repeat((ulong?) 1, 2048).Select((x, i) => i%3==0 ? x : null).ToList();
            ulong? SumActual = ZEnumerable.Sum(source);
            ulong? SumExpected = (ulong?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumulongNullableList2048ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((ulong?) 1, 2048).Select((x, i) => i%3==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X = x } ).ToList();
            ulong? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ulong? SumExpected = (ulong?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumulongNullableList2048()
        {
            var source = ZEnumerable.Repeat((ulong?) 1, 2048).ToList();
            ulong? SumActual = ZEnumerable.Sum(source);
            ulong? SumExpected = (ulong?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumulongNullableList2048Map()
        {
            var source = ZEnumerable.Repeat(new { X = (ulong?) 1 } , 2048).ToList();
            ulong? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ulong? SumExpected = (ulong?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
            
        [TestMethod]
        public void TestSumulongNullableListNullOrEmpty()
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

            List<ulong?> emptySource = new ulong?[0].ToList();
            var sum = ZEnumerable.Sum(emptySource);
            Assert.AreEqual(sum, (ulong?) 0);
        }

        [TestMethod]
        public void TestSumulongNullableListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<ulong?,ulong?>((ulong?) arg, (ulong?) arg)).ToList();
            Func<KeyValuePair<ulong?, ulong?>, ulong?> nullMap = null;
            List<ulong?> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            try
            {
                ZEnumerable.Sum(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            
            var emptySource = source.Take(0).ToList();
            var sum = ZEnumerable.Sum(emptySource, x => (ulong?) x.Key);
            Assert.AreEqual(sum, (ulong?) 0);           
        }

            

        
                        
            
        [TestMethod]
        public void TestSumulongNullableIList1ThreatNulls()
        {
            var source = ZEnumerable.Repeat((ulong?) 1, 1).Select((x, i) => i%3==0 ? x : null).ToIList();
            ulong? SumActual = ZEnumerable.Sum(source);
            ulong? SumExpected = (ulong?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumulongNullableIList1ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((ulong?) 1, 1).Select((x, i) => i%3==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X = x } ).ToIList();
            ulong? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ulong? SumExpected = (ulong?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumulongNullableIList1()
        {
            var source = ZEnumerable.Repeat((ulong?) 1, 1).ToIList();
            ulong? SumActual = ZEnumerable.Sum(source);
            ulong? SumExpected = (ulong?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumulongNullableIList1Map()
        {
            var source = ZEnumerable.Repeat(new { X = (ulong?) 1 } , 1).ToIList();
            ulong? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ulong? SumExpected = (ulong?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumulongNullableIList2ThreatNulls()
        {
            var source = ZEnumerable.Repeat((ulong?) 1, 2).Select((x, i) => i%3==0 ? x : null).ToIList();
            ulong? SumActual = ZEnumerable.Sum(source);
            ulong? SumExpected = (ulong?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumulongNullableIList2ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((ulong?) 1, 2).Select((x, i) => i%3==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X = x } ).ToIList();
            ulong? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ulong? SumExpected = (ulong?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumulongNullableIList2()
        {
            var source = ZEnumerable.Repeat((ulong?) 1, 2).ToIList();
            ulong? SumActual = ZEnumerable.Sum(source);
            ulong? SumExpected = (ulong?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumulongNullableIList2Map()
        {
            var source = ZEnumerable.Repeat(new { X = (ulong?) 1 } , 2).ToIList();
            ulong? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ulong? SumExpected = (ulong?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumulongNullableIList3ThreatNulls()
        {
            var source = ZEnumerable.Repeat((ulong?) 1, 3).Select((x, i) => i%3==0 ? x : null).ToIList();
            ulong? SumActual = ZEnumerable.Sum(source);
            ulong? SumExpected = (ulong?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumulongNullableIList3ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((ulong?) 1, 3).Select((x, i) => i%3==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X = x } ).ToIList();
            ulong? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ulong? SumExpected = (ulong?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumulongNullableIList3()
        {
            var source = ZEnumerable.Repeat((ulong?) 1, 3).ToIList();
            ulong? SumActual = ZEnumerable.Sum(source);
            ulong? SumExpected = (ulong?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumulongNullableIList3Map()
        {
            var source = ZEnumerable.Repeat(new { X = (ulong?) 1 } , 3).ToIList();
            ulong? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ulong? SumExpected = (ulong?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumulongNullableIList4ThreatNulls()
        {
            var source = ZEnumerable.Repeat((ulong?) 1, 4).Select((x, i) => i%3==0 ? x : null).ToIList();
            ulong? SumActual = ZEnumerable.Sum(source);
            ulong? SumExpected = (ulong?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumulongNullableIList4ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((ulong?) 1, 4).Select((x, i) => i%3==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X = x } ).ToIList();
            ulong? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ulong? SumExpected = (ulong?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumulongNullableIList4()
        {
            var source = ZEnumerable.Repeat((ulong?) 1, 4).ToIList();
            ulong? SumActual = ZEnumerable.Sum(source);
            ulong? SumExpected = (ulong?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumulongNullableIList4Map()
        {
            var source = ZEnumerable.Repeat(new { X = (ulong?) 1 } , 4).ToIList();
            ulong? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ulong? SumExpected = (ulong?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumulongNullableIList100ThreatNulls()
        {
            var source = ZEnumerable.Repeat((ulong?) 1, 100).Select((x, i) => i%3==0 ? x : null).ToIList();
            ulong? SumActual = ZEnumerable.Sum(source);
            ulong? SumExpected = (ulong?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumulongNullableIList100ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((ulong?) 1, 100).Select((x, i) => i%3==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X = x } ).ToIList();
            ulong? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ulong? SumExpected = (ulong?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
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
        public void TestSumulongNullableIList2048ThreatNulls()
        {
            var source = ZEnumerable.Repeat((ulong?) 1, 2048).Select((x, i) => i%3==0 ? x : null).ToIList();
            ulong? SumActual = ZEnumerable.Sum(source);
            ulong? SumExpected = (ulong?) Enumerable.Sum(source.Select(x=> (long?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumulongNullableIList2048ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((ulong?) 1, 2048).Select((x, i) => i%3==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X = x } ).ToIList();
            ulong? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ulong? SumExpected = (ulong?) Enumerable.Sum(source, arg => (long?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumulongNullableIList2048()
        {
            var source = ZEnumerable.Repeat((ulong?) 1, 2048).ToIList();
            ulong? SumActual = ZEnumerable.Sum(source);
            ulong? SumExpected = (ulong?) Enumerable.Sum(source.Select(x=> (long?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumulongNullableIList2048Map()
        {
            var source = ZEnumerable.Repeat(new { X = (ulong?) 1 } , 2048).ToIList();
            ulong? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            ulong? SumExpected = (ulong?) Enumerable.Sum(source, arg => (long?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
            
        [TestMethod]
        public void TestSumulongNullableIListNullOrEmpty()
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

            IList<ulong?> emptySource = new ulong?[0].ToIList();
            var sum = ZEnumerable.Sum(emptySource);
            Assert.AreEqual(sum, (ulong?) 0);
        }

        [TestMethod]
        public void TestSumulongNullableIListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<ulong?,ulong?>((ulong?) arg, (ulong?) arg)).ToIList();
            Func<KeyValuePair<ulong?, ulong?>, ulong?> nullMap = null;
            IList<ulong?> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            try
            {
                ZEnumerable.Sum(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            
            var emptySource = source.Take(0).ToIList();
            var sum = ZEnumerable.Sum(emptySource, x => (ulong?) x.Key);
            Assert.AreEqual(sum, (ulong?) 0);           
        }

                
        #endregion
            #region float?             
            

        
                        
            
        [TestMethod]
        public void TestSumfloatNullableArray1ThreatNulls()
        {
            var source = ZEnumerable.Repeat((float?) 1, 1).Select((x, i) => i%3==0 ? x : null).ToArray();
            float? SumActual = ZEnumerable.Sum(source);
            float? SumExpected = (float?) Enumerable.Sum(source.Select(x=> (double?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumfloatNullableArray1ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((float?) 1, 1).Select((x, i) => i%3==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X = x } ).ToArray();
            float? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            float? SumExpected = (float?) Enumerable.Sum(source, arg => (double?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumfloatNullableArray1()
        {
            var source = ZEnumerable.Repeat((float?) 1, 1).ToArray();
            float? SumActual = ZEnumerable.Sum(source);
            float? SumExpected = (float?) Enumerable.Sum(source.Select(x=> (double?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumfloatNullableArray1Map()
        {
            var source = ZEnumerable.Repeat(new { X = (float?) 1 } , 1).ToArray();
            float? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            float? SumExpected = (float?) Enumerable.Sum(source, arg => (double?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumfloatNullableArray2ThreatNulls()
        {
            var source = ZEnumerable.Repeat((float?) 1, 2).Select((x, i) => i%3==0 ? x : null).ToArray();
            float? SumActual = ZEnumerable.Sum(source);
            float? SumExpected = (float?) Enumerable.Sum(source.Select(x=> (double?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumfloatNullableArray2ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((float?) 1, 2).Select((x, i) => i%3==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X = x } ).ToArray();
            float? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            float? SumExpected = (float?) Enumerable.Sum(source, arg => (double?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumfloatNullableArray2()
        {
            var source = ZEnumerable.Repeat((float?) 1, 2).ToArray();
            float? SumActual = ZEnumerable.Sum(source);
            float? SumExpected = (float?) Enumerable.Sum(source.Select(x=> (double?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumfloatNullableArray2Map()
        {
            var source = ZEnumerable.Repeat(new { X = (float?) 1 } , 2).ToArray();
            float? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            float? SumExpected = (float?) Enumerable.Sum(source, arg => (double?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumfloatNullableArray3ThreatNulls()
        {
            var source = ZEnumerable.Repeat((float?) 1, 3).Select((x, i) => i%3==0 ? x : null).ToArray();
            float? SumActual = ZEnumerable.Sum(source);
            float? SumExpected = (float?) Enumerable.Sum(source.Select(x=> (double?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumfloatNullableArray3ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((float?) 1, 3).Select((x, i) => i%3==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X = x } ).ToArray();
            float? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            float? SumExpected = (float?) Enumerable.Sum(source, arg => (double?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumfloatNullableArray3()
        {
            var source = ZEnumerable.Repeat((float?) 1, 3).ToArray();
            float? SumActual = ZEnumerable.Sum(source);
            float? SumExpected = (float?) Enumerable.Sum(source.Select(x=> (double?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumfloatNullableArray3Map()
        {
            var source = ZEnumerable.Repeat(new { X = (float?) 1 } , 3).ToArray();
            float? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            float? SumExpected = (float?) Enumerable.Sum(source, arg => (double?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumfloatNullableArray4ThreatNulls()
        {
            var source = ZEnumerable.Repeat((float?) 1, 4).Select((x, i) => i%3==0 ? x : null).ToArray();
            float? SumActual = ZEnumerable.Sum(source);
            float? SumExpected = (float?) Enumerable.Sum(source.Select(x=> (double?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumfloatNullableArray4ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((float?) 1, 4).Select((x, i) => i%3==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X = x } ).ToArray();
            float? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            float? SumExpected = (float?) Enumerable.Sum(source, arg => (double?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumfloatNullableArray4()
        {
            var source = ZEnumerable.Repeat((float?) 1, 4).ToArray();
            float? SumActual = ZEnumerable.Sum(source);
            float? SumExpected = (float?) Enumerable.Sum(source.Select(x=> (double?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumfloatNullableArray4Map()
        {
            var source = ZEnumerable.Repeat(new { X = (float?) 1 } , 4).ToArray();
            float? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            float? SumExpected = (float?) Enumerable.Sum(source, arg => (double?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumfloatNullableArray100ThreatNulls()
        {
            var source = ZEnumerable.Repeat((float?) 1, 100).Select((x, i) => i%3==0 ? x : null).ToArray();
            float? SumActual = ZEnumerable.Sum(source);
            float? SumExpected = (float?) Enumerable.Sum(source.Select(x=> (double?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumfloatNullableArray100ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((float?) 1, 100).Select((x, i) => i%3==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X = x } ).ToArray();
            float? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            float? SumExpected = (float?) Enumerable.Sum(source, arg => (double?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
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
        public void TestSumfloatNullableArray2048ThreatNulls()
        {
            var source = ZEnumerable.Repeat((float?) 1, 2048).Select((x, i) => i%3==0 ? x : null).ToArray();
            float? SumActual = ZEnumerable.Sum(source);
            float? SumExpected = (float?) Enumerable.Sum(source.Select(x=> (double?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumfloatNullableArray2048ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((float?) 1, 2048).Select((x, i) => i%3==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X = x } ).ToArray();
            float? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            float? SumExpected = (float?) Enumerable.Sum(source, arg => (double?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumfloatNullableArray2048()
        {
            var source = ZEnumerable.Repeat((float?) 1, 2048).ToArray();
            float? SumActual = ZEnumerable.Sum(source);
            float? SumExpected = (float?) Enumerable.Sum(source.Select(x=> (double?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumfloatNullableArray2048Map()
        {
            var source = ZEnumerable.Repeat(new { X = (float?) 1 } , 2048).ToArray();
            float? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            float? SumExpected = (float?) Enumerable.Sum(source, arg => (double?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
            
        [TestMethod]
        public void TestSumfloatNullableArrayNullOrEmpty()
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

            float?[] emptySource = new float?[0].ToArray();
            var sum = ZEnumerable.Sum(emptySource);
            Assert.AreEqual(sum, (float?) 0);
        }

        [TestMethod]
        public void TestSumfloatNullableArrayMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<float?,float?>((float?) arg, (float?) arg)).ToArray();
            Func<KeyValuePair<float?, float?>, float?> nullMap = null;
            float?[] nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            try
            {
                ZEnumerable.Sum(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            
            var emptySource = source.Take(0).ToArray();
            var sum = ZEnumerable.Sum(emptySource, x => (float?) x.Key);
            Assert.AreEqual(sum, (float?) 0);           
        }

            

        
                        
            
        [TestMethod]
        public void TestSumfloatNullableList1ThreatNulls()
        {
            var source = ZEnumerable.Repeat((float?) 1, 1).Select((x, i) => i%3==0 ? x : null).ToList();
            float? SumActual = ZEnumerable.Sum(source);
            float? SumExpected = (float?) Enumerable.Sum(source.Select(x=> (double?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumfloatNullableList1ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((float?) 1, 1).Select((x, i) => i%3==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X = x } ).ToList();
            float? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            float? SumExpected = (float?) Enumerable.Sum(source, arg => (double?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumfloatNullableList1()
        {
            var source = ZEnumerable.Repeat((float?) 1, 1).ToList();
            float? SumActual = ZEnumerable.Sum(source);
            float? SumExpected = (float?) Enumerable.Sum(source.Select(x=> (double?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumfloatNullableList1Map()
        {
            var source = ZEnumerable.Repeat(new { X = (float?) 1 } , 1).ToList();
            float? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            float? SumExpected = (float?) Enumerable.Sum(source, arg => (double?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumfloatNullableList2ThreatNulls()
        {
            var source = ZEnumerable.Repeat((float?) 1, 2).Select((x, i) => i%3==0 ? x : null).ToList();
            float? SumActual = ZEnumerable.Sum(source);
            float? SumExpected = (float?) Enumerable.Sum(source.Select(x=> (double?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumfloatNullableList2ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((float?) 1, 2).Select((x, i) => i%3==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X = x } ).ToList();
            float? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            float? SumExpected = (float?) Enumerable.Sum(source, arg => (double?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumfloatNullableList2()
        {
            var source = ZEnumerable.Repeat((float?) 1, 2).ToList();
            float? SumActual = ZEnumerable.Sum(source);
            float? SumExpected = (float?) Enumerable.Sum(source.Select(x=> (double?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumfloatNullableList2Map()
        {
            var source = ZEnumerable.Repeat(new { X = (float?) 1 } , 2).ToList();
            float? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            float? SumExpected = (float?) Enumerable.Sum(source, arg => (double?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumfloatNullableList3ThreatNulls()
        {
            var source = ZEnumerable.Repeat((float?) 1, 3).Select((x, i) => i%3==0 ? x : null).ToList();
            float? SumActual = ZEnumerable.Sum(source);
            float? SumExpected = (float?) Enumerable.Sum(source.Select(x=> (double?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumfloatNullableList3ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((float?) 1, 3).Select((x, i) => i%3==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X = x } ).ToList();
            float? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            float? SumExpected = (float?) Enumerable.Sum(source, arg => (double?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumfloatNullableList3()
        {
            var source = ZEnumerable.Repeat((float?) 1, 3).ToList();
            float? SumActual = ZEnumerable.Sum(source);
            float? SumExpected = (float?) Enumerable.Sum(source.Select(x=> (double?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumfloatNullableList3Map()
        {
            var source = ZEnumerable.Repeat(new { X = (float?) 1 } , 3).ToList();
            float? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            float? SumExpected = (float?) Enumerable.Sum(source, arg => (double?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumfloatNullableList4ThreatNulls()
        {
            var source = ZEnumerable.Repeat((float?) 1, 4).Select((x, i) => i%3==0 ? x : null).ToList();
            float? SumActual = ZEnumerable.Sum(source);
            float? SumExpected = (float?) Enumerable.Sum(source.Select(x=> (double?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumfloatNullableList4ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((float?) 1, 4).Select((x, i) => i%3==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X = x } ).ToList();
            float? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            float? SumExpected = (float?) Enumerable.Sum(source, arg => (double?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumfloatNullableList4()
        {
            var source = ZEnumerable.Repeat((float?) 1, 4).ToList();
            float? SumActual = ZEnumerable.Sum(source);
            float? SumExpected = (float?) Enumerable.Sum(source.Select(x=> (double?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumfloatNullableList4Map()
        {
            var source = ZEnumerable.Repeat(new { X = (float?) 1 } , 4).ToList();
            float? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            float? SumExpected = (float?) Enumerable.Sum(source, arg => (double?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumfloatNullableList100ThreatNulls()
        {
            var source = ZEnumerable.Repeat((float?) 1, 100).Select((x, i) => i%3==0 ? x : null).ToList();
            float? SumActual = ZEnumerable.Sum(source);
            float? SumExpected = (float?) Enumerable.Sum(source.Select(x=> (double?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumfloatNullableList100ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((float?) 1, 100).Select((x, i) => i%3==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X = x } ).ToList();
            float? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            float? SumExpected = (float?) Enumerable.Sum(source, arg => (double?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
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
        public void TestSumfloatNullableList2048ThreatNulls()
        {
            var source = ZEnumerable.Repeat((float?) 1, 2048).Select((x, i) => i%3==0 ? x : null).ToList();
            float? SumActual = ZEnumerable.Sum(source);
            float? SumExpected = (float?) Enumerable.Sum(source.Select(x=> (double?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumfloatNullableList2048ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((float?) 1, 2048).Select((x, i) => i%3==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X = x } ).ToList();
            float? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            float? SumExpected = (float?) Enumerable.Sum(source, arg => (double?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumfloatNullableList2048()
        {
            var source = ZEnumerable.Repeat((float?) 1, 2048).ToList();
            float? SumActual = ZEnumerable.Sum(source);
            float? SumExpected = (float?) Enumerable.Sum(source.Select(x=> (double?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumfloatNullableList2048Map()
        {
            var source = ZEnumerable.Repeat(new { X = (float?) 1 } , 2048).ToList();
            float? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            float? SumExpected = (float?) Enumerable.Sum(source, arg => (double?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
            
        [TestMethod]
        public void TestSumfloatNullableListNullOrEmpty()
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

            List<float?> emptySource = new float?[0].ToList();
            var sum = ZEnumerable.Sum(emptySource);
            Assert.AreEqual(sum, (float?) 0);
        }

        [TestMethod]
        public void TestSumfloatNullableListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<float?,float?>((float?) arg, (float?) arg)).ToList();
            Func<KeyValuePair<float?, float?>, float?> nullMap = null;
            List<float?> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            try
            {
                ZEnumerable.Sum(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            
            var emptySource = source.Take(0).ToList();
            var sum = ZEnumerable.Sum(emptySource, x => (float?) x.Key);
            Assert.AreEqual(sum, (float?) 0);           
        }

            

        
                        
            
        [TestMethod]
        public void TestSumfloatNullableIList1ThreatNulls()
        {
            var source = ZEnumerable.Repeat((float?) 1, 1).Select((x, i) => i%3==0 ? x : null).ToIList();
            float? SumActual = ZEnumerable.Sum(source);
            float? SumExpected = (float?) Enumerable.Sum(source.Select(x=> (double?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumfloatNullableIList1ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((float?) 1, 1).Select((x, i) => i%3==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X = x } ).ToIList();
            float? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            float? SumExpected = (float?) Enumerable.Sum(source, arg => (double?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumfloatNullableIList1()
        {
            var source = ZEnumerable.Repeat((float?) 1, 1).ToIList();
            float? SumActual = ZEnumerable.Sum(source);
            float? SumExpected = (float?) Enumerable.Sum(source.Select(x=> (double?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumfloatNullableIList1Map()
        {
            var source = ZEnumerable.Repeat(new { X = (float?) 1 } , 1).ToIList();
            float? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            float? SumExpected = (float?) Enumerable.Sum(source, arg => (double?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumfloatNullableIList2ThreatNulls()
        {
            var source = ZEnumerable.Repeat((float?) 1, 2).Select((x, i) => i%3==0 ? x : null).ToIList();
            float? SumActual = ZEnumerable.Sum(source);
            float? SumExpected = (float?) Enumerable.Sum(source.Select(x=> (double?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumfloatNullableIList2ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((float?) 1, 2).Select((x, i) => i%3==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X = x } ).ToIList();
            float? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            float? SumExpected = (float?) Enumerable.Sum(source, arg => (double?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumfloatNullableIList2()
        {
            var source = ZEnumerable.Repeat((float?) 1, 2).ToIList();
            float? SumActual = ZEnumerable.Sum(source);
            float? SumExpected = (float?) Enumerable.Sum(source.Select(x=> (double?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumfloatNullableIList2Map()
        {
            var source = ZEnumerable.Repeat(new { X = (float?) 1 } , 2).ToIList();
            float? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            float? SumExpected = (float?) Enumerable.Sum(source, arg => (double?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumfloatNullableIList3ThreatNulls()
        {
            var source = ZEnumerable.Repeat((float?) 1, 3).Select((x, i) => i%3==0 ? x : null).ToIList();
            float? SumActual = ZEnumerable.Sum(source);
            float? SumExpected = (float?) Enumerable.Sum(source.Select(x=> (double?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumfloatNullableIList3ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((float?) 1, 3).Select((x, i) => i%3==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X = x } ).ToIList();
            float? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            float? SumExpected = (float?) Enumerable.Sum(source, arg => (double?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumfloatNullableIList3()
        {
            var source = ZEnumerable.Repeat((float?) 1, 3).ToIList();
            float? SumActual = ZEnumerable.Sum(source);
            float? SumExpected = (float?) Enumerable.Sum(source.Select(x=> (double?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumfloatNullableIList3Map()
        {
            var source = ZEnumerable.Repeat(new { X = (float?) 1 } , 3).ToIList();
            float? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            float? SumExpected = (float?) Enumerable.Sum(source, arg => (double?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumfloatNullableIList4ThreatNulls()
        {
            var source = ZEnumerable.Repeat((float?) 1, 4).Select((x, i) => i%3==0 ? x : null).ToIList();
            float? SumActual = ZEnumerable.Sum(source);
            float? SumExpected = (float?) Enumerable.Sum(source.Select(x=> (double?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumfloatNullableIList4ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((float?) 1, 4).Select((x, i) => i%3==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X = x } ).ToIList();
            float? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            float? SumExpected = (float?) Enumerable.Sum(source, arg => (double?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumfloatNullableIList4()
        {
            var source = ZEnumerable.Repeat((float?) 1, 4).ToIList();
            float? SumActual = ZEnumerable.Sum(source);
            float? SumExpected = (float?) Enumerable.Sum(source.Select(x=> (double?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumfloatNullableIList4Map()
        {
            var source = ZEnumerable.Repeat(new { X = (float?) 1 } , 4).ToIList();
            float? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            float? SumExpected = (float?) Enumerable.Sum(source, arg => (double?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumfloatNullableIList100ThreatNulls()
        {
            var source = ZEnumerable.Repeat((float?) 1, 100).Select((x, i) => i%3==0 ? x : null).ToIList();
            float? SumActual = ZEnumerable.Sum(source);
            float? SumExpected = (float?) Enumerable.Sum(source.Select(x=> (double?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumfloatNullableIList100ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((float?) 1, 100).Select((x, i) => i%3==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X = x } ).ToIList();
            float? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            float? SumExpected = (float?) Enumerable.Sum(source, arg => (double?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
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
        public void TestSumfloatNullableIList2048ThreatNulls()
        {
            var source = ZEnumerable.Repeat((float?) 1, 2048).Select((x, i) => i%3==0 ? x : null).ToIList();
            float? SumActual = ZEnumerable.Sum(source);
            float? SumExpected = (float?) Enumerable.Sum(source.Select(x=> (double?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumfloatNullableIList2048ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((float?) 1, 2048).Select((x, i) => i%3==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X = x } ).ToIList();
            float? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            float? SumExpected = (float?) Enumerable.Sum(source, arg => (double?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumfloatNullableIList2048()
        {
            var source = ZEnumerable.Repeat((float?) 1, 2048).ToIList();
            float? SumActual = ZEnumerable.Sum(source);
            float? SumExpected = (float?) Enumerable.Sum(source.Select(x=> (double?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumfloatNullableIList2048Map()
        {
            var source = ZEnumerable.Repeat(new { X = (float?) 1 } , 2048).ToIList();
            float? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            float? SumExpected = (float?) Enumerable.Sum(source, arg => (double?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
            
        [TestMethod]
        public void TestSumfloatNullableIListNullOrEmpty()
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

            IList<float?> emptySource = new float?[0].ToIList();
            var sum = ZEnumerable.Sum(emptySource);
            Assert.AreEqual(sum, (float?) 0);
        }

        [TestMethod]
        public void TestSumfloatNullableIListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<float?,float?>((float?) arg, (float?) arg)).ToIList();
            Func<KeyValuePair<float?, float?>, float?> nullMap = null;
            IList<float?> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            try
            {
                ZEnumerable.Sum(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            
            var emptySource = source.Take(0).ToIList();
            var sum = ZEnumerable.Sum(emptySource, x => (float?) x.Key);
            Assert.AreEqual(sum, (float?) 0);           
        }

                
        #endregion
            #region double?             
            

        
                        
            
        [TestMethod]
        public void TestSumdoubleNullableArray1ThreatNulls()
        {
            var source = ZEnumerable.Repeat((double?) 1, 1).Select((x, i) => i%3==0 ? x : null).ToArray();
            double? SumActual = ZEnumerable.Sum(source);
            double? SumExpected = (double?) Enumerable.Sum(source.Select(x=> (double?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdoubleNullableArray1ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((double?) 1, 1).Select((x, i) => i%3==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X = x } ).ToArray();
            double? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            double? SumExpected = (double?) Enumerable.Sum(source, arg => (double?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumdoubleNullableArray1()
        {
            var source = ZEnumerable.Repeat((double?) 1, 1).ToArray();
            double? SumActual = ZEnumerable.Sum(source);
            double? SumExpected = (double?) Enumerable.Sum(source.Select(x=> (double?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdoubleNullableArray1Map()
        {
            var source = ZEnumerable.Repeat(new { X = (double?) 1 } , 1).ToArray();
            double? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            double? SumExpected = (double?) Enumerable.Sum(source, arg => (double?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumdoubleNullableArray2ThreatNulls()
        {
            var source = ZEnumerable.Repeat((double?) 1, 2).Select((x, i) => i%3==0 ? x : null).ToArray();
            double? SumActual = ZEnumerable.Sum(source);
            double? SumExpected = (double?) Enumerable.Sum(source.Select(x=> (double?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdoubleNullableArray2ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((double?) 1, 2).Select((x, i) => i%3==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X = x } ).ToArray();
            double? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            double? SumExpected = (double?) Enumerable.Sum(source, arg => (double?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumdoubleNullableArray2()
        {
            var source = ZEnumerable.Repeat((double?) 1, 2).ToArray();
            double? SumActual = ZEnumerable.Sum(source);
            double? SumExpected = (double?) Enumerable.Sum(source.Select(x=> (double?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdoubleNullableArray2Map()
        {
            var source = ZEnumerable.Repeat(new { X = (double?) 1 } , 2).ToArray();
            double? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            double? SumExpected = (double?) Enumerable.Sum(source, arg => (double?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumdoubleNullableArray3ThreatNulls()
        {
            var source = ZEnumerable.Repeat((double?) 1, 3).Select((x, i) => i%3==0 ? x : null).ToArray();
            double? SumActual = ZEnumerable.Sum(source);
            double? SumExpected = (double?) Enumerable.Sum(source.Select(x=> (double?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdoubleNullableArray3ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((double?) 1, 3).Select((x, i) => i%3==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X = x } ).ToArray();
            double? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            double? SumExpected = (double?) Enumerable.Sum(source, arg => (double?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumdoubleNullableArray3()
        {
            var source = ZEnumerable.Repeat((double?) 1, 3).ToArray();
            double? SumActual = ZEnumerable.Sum(source);
            double? SumExpected = (double?) Enumerable.Sum(source.Select(x=> (double?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdoubleNullableArray3Map()
        {
            var source = ZEnumerable.Repeat(new { X = (double?) 1 } , 3).ToArray();
            double? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            double? SumExpected = (double?) Enumerable.Sum(source, arg => (double?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumdoubleNullableArray4ThreatNulls()
        {
            var source = ZEnumerable.Repeat((double?) 1, 4).Select((x, i) => i%3==0 ? x : null).ToArray();
            double? SumActual = ZEnumerable.Sum(source);
            double? SumExpected = (double?) Enumerable.Sum(source.Select(x=> (double?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdoubleNullableArray4ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((double?) 1, 4).Select((x, i) => i%3==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X = x } ).ToArray();
            double? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            double? SumExpected = (double?) Enumerable.Sum(source, arg => (double?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumdoubleNullableArray4()
        {
            var source = ZEnumerable.Repeat((double?) 1, 4).ToArray();
            double? SumActual = ZEnumerable.Sum(source);
            double? SumExpected = (double?) Enumerable.Sum(source.Select(x=> (double?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdoubleNullableArray4Map()
        {
            var source = ZEnumerable.Repeat(new { X = (double?) 1 } , 4).ToArray();
            double? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            double? SumExpected = (double?) Enumerable.Sum(source, arg => (double?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumdoubleNullableArray100ThreatNulls()
        {
            var source = ZEnumerable.Repeat((double?) 1, 100).Select((x, i) => i%3==0 ? x : null).ToArray();
            double? SumActual = ZEnumerable.Sum(source);
            double? SumExpected = (double?) Enumerable.Sum(source.Select(x=> (double?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdoubleNullableArray100ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((double?) 1, 100).Select((x, i) => i%3==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X = x } ).ToArray();
            double? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            double? SumExpected = (double?) Enumerable.Sum(source, arg => (double?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
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
        public void TestSumdoubleNullableArray2048ThreatNulls()
        {
            var source = ZEnumerable.Repeat((double?) 1, 2048).Select((x, i) => i%3==0 ? x : null).ToArray();
            double? SumActual = ZEnumerable.Sum(source);
            double? SumExpected = (double?) Enumerable.Sum(source.Select(x=> (double?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdoubleNullableArray2048ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((double?) 1, 2048).Select((x, i) => i%3==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X = x } ).ToArray();
            double? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            double? SumExpected = (double?) Enumerable.Sum(source, arg => (double?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumdoubleNullableArray2048()
        {
            var source = ZEnumerable.Repeat((double?) 1, 2048).ToArray();
            double? SumActual = ZEnumerable.Sum(source);
            double? SumExpected = (double?) Enumerable.Sum(source.Select(x=> (double?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdoubleNullableArray2048Map()
        {
            var source = ZEnumerable.Repeat(new { X = (double?) 1 } , 2048).ToArray();
            double? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            double? SumExpected = (double?) Enumerable.Sum(source, arg => (double?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
            
        [TestMethod]
        public void TestSumdoubleNullableArrayNullOrEmpty()
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

            double?[] emptySource = new double?[0].ToArray();
            var sum = ZEnumerable.Sum(emptySource);
            Assert.AreEqual(sum, (double?) 0);
        }

        [TestMethod]
        public void TestSumdoubleNullableArrayMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<double?,double?>((double?) arg, (double?) arg)).ToArray();
            Func<KeyValuePair<double?, double?>, double?> nullMap = null;
            double?[] nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            try
            {
                ZEnumerable.Sum(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            
            var emptySource = source.Take(0).ToArray();
            var sum = ZEnumerable.Sum(emptySource, x => (double?) x.Key);
            Assert.AreEqual(sum, (double?) 0);           
        }

            

        
                        
            
        [TestMethod]
        public void TestSumdoubleNullableList1ThreatNulls()
        {
            var source = ZEnumerable.Repeat((double?) 1, 1).Select((x, i) => i%3==0 ? x : null).ToList();
            double? SumActual = ZEnumerable.Sum(source);
            double? SumExpected = (double?) Enumerable.Sum(source.Select(x=> (double?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdoubleNullableList1ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((double?) 1, 1).Select((x, i) => i%3==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X = x } ).ToList();
            double? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            double? SumExpected = (double?) Enumerable.Sum(source, arg => (double?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumdoubleNullableList1()
        {
            var source = ZEnumerable.Repeat((double?) 1, 1).ToList();
            double? SumActual = ZEnumerable.Sum(source);
            double? SumExpected = (double?) Enumerable.Sum(source.Select(x=> (double?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdoubleNullableList1Map()
        {
            var source = ZEnumerable.Repeat(new { X = (double?) 1 } , 1).ToList();
            double? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            double? SumExpected = (double?) Enumerable.Sum(source, arg => (double?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumdoubleNullableList2ThreatNulls()
        {
            var source = ZEnumerable.Repeat((double?) 1, 2).Select((x, i) => i%3==0 ? x : null).ToList();
            double? SumActual = ZEnumerable.Sum(source);
            double? SumExpected = (double?) Enumerable.Sum(source.Select(x=> (double?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdoubleNullableList2ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((double?) 1, 2).Select((x, i) => i%3==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X = x } ).ToList();
            double? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            double? SumExpected = (double?) Enumerable.Sum(source, arg => (double?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumdoubleNullableList2()
        {
            var source = ZEnumerable.Repeat((double?) 1, 2).ToList();
            double? SumActual = ZEnumerable.Sum(source);
            double? SumExpected = (double?) Enumerable.Sum(source.Select(x=> (double?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdoubleNullableList2Map()
        {
            var source = ZEnumerable.Repeat(new { X = (double?) 1 } , 2).ToList();
            double? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            double? SumExpected = (double?) Enumerable.Sum(source, arg => (double?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumdoubleNullableList3ThreatNulls()
        {
            var source = ZEnumerable.Repeat((double?) 1, 3).Select((x, i) => i%3==0 ? x : null).ToList();
            double? SumActual = ZEnumerable.Sum(source);
            double? SumExpected = (double?) Enumerable.Sum(source.Select(x=> (double?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdoubleNullableList3ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((double?) 1, 3).Select((x, i) => i%3==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X = x } ).ToList();
            double? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            double? SumExpected = (double?) Enumerable.Sum(source, arg => (double?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumdoubleNullableList3()
        {
            var source = ZEnumerable.Repeat((double?) 1, 3).ToList();
            double? SumActual = ZEnumerable.Sum(source);
            double? SumExpected = (double?) Enumerable.Sum(source.Select(x=> (double?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdoubleNullableList3Map()
        {
            var source = ZEnumerable.Repeat(new { X = (double?) 1 } , 3).ToList();
            double? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            double? SumExpected = (double?) Enumerable.Sum(source, arg => (double?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumdoubleNullableList4ThreatNulls()
        {
            var source = ZEnumerable.Repeat((double?) 1, 4).Select((x, i) => i%3==0 ? x : null).ToList();
            double? SumActual = ZEnumerable.Sum(source);
            double? SumExpected = (double?) Enumerable.Sum(source.Select(x=> (double?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdoubleNullableList4ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((double?) 1, 4).Select((x, i) => i%3==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X = x } ).ToList();
            double? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            double? SumExpected = (double?) Enumerable.Sum(source, arg => (double?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumdoubleNullableList4()
        {
            var source = ZEnumerable.Repeat((double?) 1, 4).ToList();
            double? SumActual = ZEnumerable.Sum(source);
            double? SumExpected = (double?) Enumerable.Sum(source.Select(x=> (double?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdoubleNullableList4Map()
        {
            var source = ZEnumerable.Repeat(new { X = (double?) 1 } , 4).ToList();
            double? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            double? SumExpected = (double?) Enumerable.Sum(source, arg => (double?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumdoubleNullableList100ThreatNulls()
        {
            var source = ZEnumerable.Repeat((double?) 1, 100).Select((x, i) => i%3==0 ? x : null).ToList();
            double? SumActual = ZEnumerable.Sum(source);
            double? SumExpected = (double?) Enumerable.Sum(source.Select(x=> (double?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdoubleNullableList100ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((double?) 1, 100).Select((x, i) => i%3==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X = x } ).ToList();
            double? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            double? SumExpected = (double?) Enumerable.Sum(source, arg => (double?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
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
        public void TestSumdoubleNullableList2048ThreatNulls()
        {
            var source = ZEnumerable.Repeat((double?) 1, 2048).Select((x, i) => i%3==0 ? x : null).ToList();
            double? SumActual = ZEnumerable.Sum(source);
            double? SumExpected = (double?) Enumerable.Sum(source.Select(x=> (double?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdoubleNullableList2048ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((double?) 1, 2048).Select((x, i) => i%3==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X = x } ).ToList();
            double? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            double? SumExpected = (double?) Enumerable.Sum(source, arg => (double?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumdoubleNullableList2048()
        {
            var source = ZEnumerable.Repeat((double?) 1, 2048).ToList();
            double? SumActual = ZEnumerable.Sum(source);
            double? SumExpected = (double?) Enumerable.Sum(source.Select(x=> (double?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdoubleNullableList2048Map()
        {
            var source = ZEnumerable.Repeat(new { X = (double?) 1 } , 2048).ToList();
            double? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            double? SumExpected = (double?) Enumerable.Sum(source, arg => (double?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
            
        [TestMethod]
        public void TestSumdoubleNullableListNullOrEmpty()
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

            List<double?> emptySource = new double?[0].ToList();
            var sum = ZEnumerable.Sum(emptySource);
            Assert.AreEqual(sum, (double?) 0);
        }

        [TestMethod]
        public void TestSumdoubleNullableListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<double?,double?>((double?) arg, (double?) arg)).ToList();
            Func<KeyValuePair<double?, double?>, double?> nullMap = null;
            List<double?> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            try
            {
                ZEnumerable.Sum(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            
            var emptySource = source.Take(0).ToList();
            var sum = ZEnumerable.Sum(emptySource, x => (double?) x.Key);
            Assert.AreEqual(sum, (double?) 0);           
        }

            

        
                        
            
        [TestMethod]
        public void TestSumdoubleNullableIList1ThreatNulls()
        {
            var source = ZEnumerable.Repeat((double?) 1, 1).Select((x, i) => i%3==0 ? x : null).ToIList();
            double? SumActual = ZEnumerable.Sum(source);
            double? SumExpected = (double?) Enumerable.Sum(source.Select(x=> (double?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdoubleNullableIList1ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((double?) 1, 1).Select((x, i) => i%3==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X = x } ).ToIList();
            double? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            double? SumExpected = (double?) Enumerable.Sum(source, arg => (double?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumdoubleNullableIList1()
        {
            var source = ZEnumerable.Repeat((double?) 1, 1).ToIList();
            double? SumActual = ZEnumerable.Sum(source);
            double? SumExpected = (double?) Enumerable.Sum(source.Select(x=> (double?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdoubleNullableIList1Map()
        {
            var source = ZEnumerable.Repeat(new { X = (double?) 1 } , 1).ToIList();
            double? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            double? SumExpected = (double?) Enumerable.Sum(source, arg => (double?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumdoubleNullableIList2ThreatNulls()
        {
            var source = ZEnumerable.Repeat((double?) 1, 2).Select((x, i) => i%3==0 ? x : null).ToIList();
            double? SumActual = ZEnumerable.Sum(source);
            double? SumExpected = (double?) Enumerable.Sum(source.Select(x=> (double?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdoubleNullableIList2ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((double?) 1, 2).Select((x, i) => i%3==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X = x } ).ToIList();
            double? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            double? SumExpected = (double?) Enumerable.Sum(source, arg => (double?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumdoubleNullableIList2()
        {
            var source = ZEnumerable.Repeat((double?) 1, 2).ToIList();
            double? SumActual = ZEnumerable.Sum(source);
            double? SumExpected = (double?) Enumerable.Sum(source.Select(x=> (double?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdoubleNullableIList2Map()
        {
            var source = ZEnumerable.Repeat(new { X = (double?) 1 } , 2).ToIList();
            double? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            double? SumExpected = (double?) Enumerable.Sum(source, arg => (double?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumdoubleNullableIList3ThreatNulls()
        {
            var source = ZEnumerable.Repeat((double?) 1, 3).Select((x, i) => i%3==0 ? x : null).ToIList();
            double? SumActual = ZEnumerable.Sum(source);
            double? SumExpected = (double?) Enumerable.Sum(source.Select(x=> (double?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdoubleNullableIList3ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((double?) 1, 3).Select((x, i) => i%3==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X = x } ).ToIList();
            double? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            double? SumExpected = (double?) Enumerable.Sum(source, arg => (double?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumdoubleNullableIList3()
        {
            var source = ZEnumerable.Repeat((double?) 1, 3).ToIList();
            double? SumActual = ZEnumerable.Sum(source);
            double? SumExpected = (double?) Enumerable.Sum(source.Select(x=> (double?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdoubleNullableIList3Map()
        {
            var source = ZEnumerable.Repeat(new { X = (double?) 1 } , 3).ToIList();
            double? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            double? SumExpected = (double?) Enumerable.Sum(source, arg => (double?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumdoubleNullableIList4ThreatNulls()
        {
            var source = ZEnumerable.Repeat((double?) 1, 4).Select((x, i) => i%3==0 ? x : null).ToIList();
            double? SumActual = ZEnumerable.Sum(source);
            double? SumExpected = (double?) Enumerable.Sum(source.Select(x=> (double?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdoubleNullableIList4ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((double?) 1, 4).Select((x, i) => i%3==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X = x } ).ToIList();
            double? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            double? SumExpected = (double?) Enumerable.Sum(source, arg => (double?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumdoubleNullableIList4()
        {
            var source = ZEnumerable.Repeat((double?) 1, 4).ToIList();
            double? SumActual = ZEnumerable.Sum(source);
            double? SumExpected = (double?) Enumerable.Sum(source.Select(x=> (double?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdoubleNullableIList4Map()
        {
            var source = ZEnumerable.Repeat(new { X = (double?) 1 } , 4).ToIList();
            double? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            double? SumExpected = (double?) Enumerable.Sum(source, arg => (double?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumdoubleNullableIList100ThreatNulls()
        {
            var source = ZEnumerable.Repeat((double?) 1, 100).Select((x, i) => i%3==0 ? x : null).ToIList();
            double? SumActual = ZEnumerable.Sum(source);
            double? SumExpected = (double?) Enumerable.Sum(source.Select(x=> (double?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdoubleNullableIList100ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((double?) 1, 100).Select((x, i) => i%3==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X = x } ).ToIList();
            double? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            double? SumExpected = (double?) Enumerable.Sum(source, arg => (double?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
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
        public void TestSumdoubleNullableIList2048ThreatNulls()
        {
            var source = ZEnumerable.Repeat((double?) 1, 2048).Select((x, i) => i%3==0 ? x : null).ToIList();
            double? SumActual = ZEnumerable.Sum(source);
            double? SumExpected = (double?) Enumerable.Sum(source.Select(x=> (double?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdoubleNullableIList2048ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((double?) 1, 2048).Select((x, i) => i%3==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X = x } ).ToIList();
            double? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            double? SumExpected = (double?) Enumerable.Sum(source, arg => (double?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumdoubleNullableIList2048()
        {
            var source = ZEnumerable.Repeat((double?) 1, 2048).ToIList();
            double? SumActual = ZEnumerable.Sum(source);
            double? SumExpected = (double?) Enumerable.Sum(source.Select(x=> (double?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdoubleNullableIList2048Map()
        {
            var source = ZEnumerable.Repeat(new { X = (double?) 1 } , 2048).ToIList();
            double? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            double? SumExpected = (double?) Enumerable.Sum(source, arg => (double?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
            
        [TestMethod]
        public void TestSumdoubleNullableIListNullOrEmpty()
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

            IList<double?> emptySource = new double?[0].ToIList();
            var sum = ZEnumerable.Sum(emptySource);
            Assert.AreEqual(sum, (double?) 0);
        }

        [TestMethod]
        public void TestSumdoubleNullableIListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<double?,double?>((double?) arg, (double?) arg)).ToIList();
            Func<KeyValuePair<double?, double?>, double?> nullMap = null;
            IList<double?> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            try
            {
                ZEnumerable.Sum(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            
            var emptySource = source.Take(0).ToIList();
            var sum = ZEnumerable.Sum(emptySource, x => (double?) x.Key);
            Assert.AreEqual(sum, (double?) 0);           
        }

                
        #endregion
            #region decimal?             
            

        
                        
            
        [TestMethod]
        public void TestSumdecimalNullableArray1ThreatNulls()
        {
            var source = ZEnumerable.Repeat((decimal?) 1, 1).Select((x, i) => i%3==0 ? x : null).ToArray();
            decimal? SumActual = ZEnumerable.Sum(source);
            decimal? SumExpected = (decimal?) Enumerable.Sum(source.Select(x=> (double?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdecimalNullableArray1ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((decimal?) 1, 1).Select((x, i) => i%3==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X = x } ).ToArray();
            decimal? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            decimal? SumExpected = (decimal?) Enumerable.Sum(source, arg => (double?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumdecimalNullableArray1()
        {
            var source = ZEnumerable.Repeat((decimal?) 1, 1).ToArray();
            decimal? SumActual = ZEnumerable.Sum(source);
            decimal? SumExpected = (decimal?) Enumerable.Sum(source.Select(x=> (double?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdecimalNullableArray1Map()
        {
            var source = ZEnumerable.Repeat(new { X = (decimal?) 1 } , 1).ToArray();
            decimal? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            decimal? SumExpected = (decimal?) Enumerable.Sum(source, arg => (double?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumdecimalNullableArray2ThreatNulls()
        {
            var source = ZEnumerable.Repeat((decimal?) 1, 2).Select((x, i) => i%3==0 ? x : null).ToArray();
            decimal? SumActual = ZEnumerable.Sum(source);
            decimal? SumExpected = (decimal?) Enumerable.Sum(source.Select(x=> (double?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdecimalNullableArray2ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((decimal?) 1, 2).Select((x, i) => i%3==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X = x } ).ToArray();
            decimal? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            decimal? SumExpected = (decimal?) Enumerable.Sum(source, arg => (double?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumdecimalNullableArray2()
        {
            var source = ZEnumerable.Repeat((decimal?) 1, 2).ToArray();
            decimal? SumActual = ZEnumerable.Sum(source);
            decimal? SumExpected = (decimal?) Enumerable.Sum(source.Select(x=> (double?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdecimalNullableArray2Map()
        {
            var source = ZEnumerable.Repeat(new { X = (decimal?) 1 } , 2).ToArray();
            decimal? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            decimal? SumExpected = (decimal?) Enumerable.Sum(source, arg => (double?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumdecimalNullableArray3ThreatNulls()
        {
            var source = ZEnumerable.Repeat((decimal?) 1, 3).Select((x, i) => i%3==0 ? x : null).ToArray();
            decimal? SumActual = ZEnumerable.Sum(source);
            decimal? SumExpected = (decimal?) Enumerable.Sum(source.Select(x=> (double?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdecimalNullableArray3ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((decimal?) 1, 3).Select((x, i) => i%3==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X = x } ).ToArray();
            decimal? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            decimal? SumExpected = (decimal?) Enumerable.Sum(source, arg => (double?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumdecimalNullableArray3()
        {
            var source = ZEnumerable.Repeat((decimal?) 1, 3).ToArray();
            decimal? SumActual = ZEnumerable.Sum(source);
            decimal? SumExpected = (decimal?) Enumerable.Sum(source.Select(x=> (double?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdecimalNullableArray3Map()
        {
            var source = ZEnumerable.Repeat(new { X = (decimal?) 1 } , 3).ToArray();
            decimal? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            decimal? SumExpected = (decimal?) Enumerable.Sum(source, arg => (double?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumdecimalNullableArray4ThreatNulls()
        {
            var source = ZEnumerable.Repeat((decimal?) 1, 4).Select((x, i) => i%3==0 ? x : null).ToArray();
            decimal? SumActual = ZEnumerable.Sum(source);
            decimal? SumExpected = (decimal?) Enumerable.Sum(source.Select(x=> (double?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdecimalNullableArray4ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((decimal?) 1, 4).Select((x, i) => i%3==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X = x } ).ToArray();
            decimal? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            decimal? SumExpected = (decimal?) Enumerable.Sum(source, arg => (double?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumdecimalNullableArray4()
        {
            var source = ZEnumerable.Repeat((decimal?) 1, 4).ToArray();
            decimal? SumActual = ZEnumerable.Sum(source);
            decimal? SumExpected = (decimal?) Enumerable.Sum(source.Select(x=> (double?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdecimalNullableArray4Map()
        {
            var source = ZEnumerable.Repeat(new { X = (decimal?) 1 } , 4).ToArray();
            decimal? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            decimal? SumExpected = (decimal?) Enumerable.Sum(source, arg => (double?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumdecimalNullableArray100ThreatNulls()
        {
            var source = ZEnumerable.Repeat((decimal?) 1, 100).Select((x, i) => i%3==0 ? x : null).ToArray();
            decimal? SumActual = ZEnumerable.Sum(source);
            decimal? SumExpected = (decimal?) Enumerable.Sum(source.Select(x=> (double?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdecimalNullableArray100ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((decimal?) 1, 100).Select((x, i) => i%3==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X = x } ).ToArray();
            decimal? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            decimal? SumExpected = (decimal?) Enumerable.Sum(source, arg => (double?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
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
        public void TestSumdecimalNullableArray2048ThreatNulls()
        {
            var source = ZEnumerable.Repeat((decimal?) 1, 2048).Select((x, i) => i%3==0 ? x : null).ToArray();
            decimal? SumActual = ZEnumerable.Sum(source);
            decimal? SumExpected = (decimal?) Enumerable.Sum(source.Select(x=> (double?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdecimalNullableArray2048ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((decimal?) 1, 2048).Select((x, i) => i%3==0 ? x : null).ToArray();
            var source = baseCol.Select(x => new { X = x } ).ToArray();
            decimal? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            decimal? SumExpected = (decimal?) Enumerable.Sum(source, arg => (double?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumdecimalNullableArray2048()
        {
            var source = ZEnumerable.Repeat((decimal?) 1, 2048).ToArray();
            decimal? SumActual = ZEnumerable.Sum(source);
            decimal? SumExpected = (decimal?) Enumerable.Sum(source.Select(x=> (double?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdecimalNullableArray2048Map()
        {
            var source = ZEnumerable.Repeat(new { X = (decimal?) 1 } , 2048).ToArray();
            decimal? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            decimal? SumExpected = (decimal?) Enumerable.Sum(source, arg => (double?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
            
        [TestMethod]
        public void TestSumdecimalNullableArrayNullOrEmpty()
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

            decimal?[] emptySource = new decimal?[0].ToArray();
            var sum = ZEnumerable.Sum(emptySource);
            Assert.AreEqual(sum, (decimal?) 0);
        }

        [TestMethod]
        public void TestSumdecimalNullableArrayMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<decimal?,decimal?>((decimal?) arg, (decimal?) arg)).ToArray();
            Func<KeyValuePair<decimal?, decimal?>, decimal?> nullMap = null;
            decimal?[] nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            try
            {
                ZEnumerable.Sum(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            
            var emptySource = source.Take(0).ToArray();
            var sum = ZEnumerable.Sum(emptySource, x => (decimal?) x.Key);
            Assert.AreEqual(sum, (decimal?) 0);           
        }

            

        
                        
            
        [TestMethod]
        public void TestSumdecimalNullableList1ThreatNulls()
        {
            var source = ZEnumerable.Repeat((decimal?) 1, 1).Select((x, i) => i%3==0 ? x : null).ToList();
            decimal? SumActual = ZEnumerable.Sum(source);
            decimal? SumExpected = (decimal?) Enumerable.Sum(source.Select(x=> (double?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdecimalNullableList1ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((decimal?) 1, 1).Select((x, i) => i%3==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X = x } ).ToList();
            decimal? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            decimal? SumExpected = (decimal?) Enumerable.Sum(source, arg => (double?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumdecimalNullableList1()
        {
            var source = ZEnumerable.Repeat((decimal?) 1, 1).ToList();
            decimal? SumActual = ZEnumerable.Sum(source);
            decimal? SumExpected = (decimal?) Enumerable.Sum(source.Select(x=> (double?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdecimalNullableList1Map()
        {
            var source = ZEnumerable.Repeat(new { X = (decimal?) 1 } , 1).ToList();
            decimal? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            decimal? SumExpected = (decimal?) Enumerable.Sum(source, arg => (double?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumdecimalNullableList2ThreatNulls()
        {
            var source = ZEnumerable.Repeat((decimal?) 1, 2).Select((x, i) => i%3==0 ? x : null).ToList();
            decimal? SumActual = ZEnumerable.Sum(source);
            decimal? SumExpected = (decimal?) Enumerable.Sum(source.Select(x=> (double?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdecimalNullableList2ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((decimal?) 1, 2).Select((x, i) => i%3==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X = x } ).ToList();
            decimal? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            decimal? SumExpected = (decimal?) Enumerable.Sum(source, arg => (double?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumdecimalNullableList2()
        {
            var source = ZEnumerable.Repeat((decimal?) 1, 2).ToList();
            decimal? SumActual = ZEnumerable.Sum(source);
            decimal? SumExpected = (decimal?) Enumerable.Sum(source.Select(x=> (double?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdecimalNullableList2Map()
        {
            var source = ZEnumerable.Repeat(new { X = (decimal?) 1 } , 2).ToList();
            decimal? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            decimal? SumExpected = (decimal?) Enumerable.Sum(source, arg => (double?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumdecimalNullableList3ThreatNulls()
        {
            var source = ZEnumerable.Repeat((decimal?) 1, 3).Select((x, i) => i%3==0 ? x : null).ToList();
            decimal? SumActual = ZEnumerable.Sum(source);
            decimal? SumExpected = (decimal?) Enumerable.Sum(source.Select(x=> (double?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdecimalNullableList3ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((decimal?) 1, 3).Select((x, i) => i%3==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X = x } ).ToList();
            decimal? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            decimal? SumExpected = (decimal?) Enumerable.Sum(source, arg => (double?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumdecimalNullableList3()
        {
            var source = ZEnumerable.Repeat((decimal?) 1, 3).ToList();
            decimal? SumActual = ZEnumerable.Sum(source);
            decimal? SumExpected = (decimal?) Enumerable.Sum(source.Select(x=> (double?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdecimalNullableList3Map()
        {
            var source = ZEnumerable.Repeat(new { X = (decimal?) 1 } , 3).ToList();
            decimal? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            decimal? SumExpected = (decimal?) Enumerable.Sum(source, arg => (double?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumdecimalNullableList4ThreatNulls()
        {
            var source = ZEnumerable.Repeat((decimal?) 1, 4).Select((x, i) => i%3==0 ? x : null).ToList();
            decimal? SumActual = ZEnumerable.Sum(source);
            decimal? SumExpected = (decimal?) Enumerable.Sum(source.Select(x=> (double?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdecimalNullableList4ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((decimal?) 1, 4).Select((x, i) => i%3==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X = x } ).ToList();
            decimal? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            decimal? SumExpected = (decimal?) Enumerable.Sum(source, arg => (double?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumdecimalNullableList4()
        {
            var source = ZEnumerable.Repeat((decimal?) 1, 4).ToList();
            decimal? SumActual = ZEnumerable.Sum(source);
            decimal? SumExpected = (decimal?) Enumerable.Sum(source.Select(x=> (double?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdecimalNullableList4Map()
        {
            var source = ZEnumerable.Repeat(new { X = (decimal?) 1 } , 4).ToList();
            decimal? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            decimal? SumExpected = (decimal?) Enumerable.Sum(source, arg => (double?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumdecimalNullableList100ThreatNulls()
        {
            var source = ZEnumerable.Repeat((decimal?) 1, 100).Select((x, i) => i%3==0 ? x : null).ToList();
            decimal? SumActual = ZEnumerable.Sum(source);
            decimal? SumExpected = (decimal?) Enumerable.Sum(source.Select(x=> (double?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdecimalNullableList100ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((decimal?) 1, 100).Select((x, i) => i%3==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X = x } ).ToList();
            decimal? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            decimal? SumExpected = (decimal?) Enumerable.Sum(source, arg => (double?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
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
        public void TestSumdecimalNullableList2048ThreatNulls()
        {
            var source = ZEnumerable.Repeat((decimal?) 1, 2048).Select((x, i) => i%3==0 ? x : null).ToList();
            decimal? SumActual = ZEnumerable.Sum(source);
            decimal? SumExpected = (decimal?) Enumerable.Sum(source.Select(x=> (double?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdecimalNullableList2048ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((decimal?) 1, 2048).Select((x, i) => i%3==0 ? x : null).ToList();
            var source = baseCol.Select(x => new { X = x } ).ToList();
            decimal? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            decimal? SumExpected = (decimal?) Enumerable.Sum(source, arg => (double?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumdecimalNullableList2048()
        {
            var source = ZEnumerable.Repeat((decimal?) 1, 2048).ToList();
            decimal? SumActual = ZEnumerable.Sum(source);
            decimal? SumExpected = (decimal?) Enumerable.Sum(source.Select(x=> (double?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdecimalNullableList2048Map()
        {
            var source = ZEnumerable.Repeat(new { X = (decimal?) 1 } , 2048).ToList();
            decimal? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            decimal? SumExpected = (decimal?) Enumerable.Sum(source, arg => (double?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
            
        [TestMethod]
        public void TestSumdecimalNullableListNullOrEmpty()
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

            List<decimal?> emptySource = new decimal?[0].ToList();
            var sum = ZEnumerable.Sum(emptySource);
            Assert.AreEqual(sum, (decimal?) 0);
        }

        [TestMethod]
        public void TestSumdecimalNullableListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<decimal?,decimal?>((decimal?) arg, (decimal?) arg)).ToList();
            Func<KeyValuePair<decimal?, decimal?>, decimal?> nullMap = null;
            List<decimal?> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            try
            {
                ZEnumerable.Sum(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            
            var emptySource = source.Take(0).ToList();
            var sum = ZEnumerable.Sum(emptySource, x => (decimal?) x.Key);
            Assert.AreEqual(sum, (decimal?) 0);           
        }

            

        
                        
            
        [TestMethod]
        public void TestSumdecimalNullableIList1ThreatNulls()
        {
            var source = ZEnumerable.Repeat((decimal?) 1, 1).Select((x, i) => i%3==0 ? x : null).ToIList();
            decimal? SumActual = ZEnumerable.Sum(source);
            decimal? SumExpected = (decimal?) Enumerable.Sum(source.Select(x=> (double?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdecimalNullableIList1ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((decimal?) 1, 1).Select((x, i) => i%3==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X = x } ).ToIList();
            decimal? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            decimal? SumExpected = (decimal?) Enumerable.Sum(source, arg => (double?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumdecimalNullableIList1()
        {
            var source = ZEnumerable.Repeat((decimal?) 1, 1).ToIList();
            decimal? SumActual = ZEnumerable.Sum(source);
            decimal? SumExpected = (decimal?) Enumerable.Sum(source.Select(x=> (double?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdecimalNullableIList1Map()
        {
            var source = ZEnumerable.Repeat(new { X = (decimal?) 1 } , 1).ToIList();
            decimal? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            decimal? SumExpected = (decimal?) Enumerable.Sum(source, arg => (double?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumdecimalNullableIList2ThreatNulls()
        {
            var source = ZEnumerable.Repeat((decimal?) 1, 2).Select((x, i) => i%3==0 ? x : null).ToIList();
            decimal? SumActual = ZEnumerable.Sum(source);
            decimal? SumExpected = (decimal?) Enumerable.Sum(source.Select(x=> (double?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdecimalNullableIList2ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((decimal?) 1, 2).Select((x, i) => i%3==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X = x } ).ToIList();
            decimal? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            decimal? SumExpected = (decimal?) Enumerable.Sum(source, arg => (double?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumdecimalNullableIList2()
        {
            var source = ZEnumerable.Repeat((decimal?) 1, 2).ToIList();
            decimal? SumActual = ZEnumerable.Sum(source);
            decimal? SumExpected = (decimal?) Enumerable.Sum(source.Select(x=> (double?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdecimalNullableIList2Map()
        {
            var source = ZEnumerable.Repeat(new { X = (decimal?) 1 } , 2).ToIList();
            decimal? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            decimal? SumExpected = (decimal?) Enumerable.Sum(source, arg => (double?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumdecimalNullableIList3ThreatNulls()
        {
            var source = ZEnumerable.Repeat((decimal?) 1, 3).Select((x, i) => i%3==0 ? x : null).ToIList();
            decimal? SumActual = ZEnumerable.Sum(source);
            decimal? SumExpected = (decimal?) Enumerable.Sum(source.Select(x=> (double?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdecimalNullableIList3ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((decimal?) 1, 3).Select((x, i) => i%3==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X = x } ).ToIList();
            decimal? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            decimal? SumExpected = (decimal?) Enumerable.Sum(source, arg => (double?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumdecimalNullableIList3()
        {
            var source = ZEnumerable.Repeat((decimal?) 1, 3).ToIList();
            decimal? SumActual = ZEnumerable.Sum(source);
            decimal? SumExpected = (decimal?) Enumerable.Sum(source.Select(x=> (double?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdecimalNullableIList3Map()
        {
            var source = ZEnumerable.Repeat(new { X = (decimal?) 1 } , 3).ToIList();
            decimal? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            decimal? SumExpected = (decimal?) Enumerable.Sum(source, arg => (double?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumdecimalNullableIList4ThreatNulls()
        {
            var source = ZEnumerable.Repeat((decimal?) 1, 4).Select((x, i) => i%3==0 ? x : null).ToIList();
            decimal? SumActual = ZEnumerable.Sum(source);
            decimal? SumExpected = (decimal?) Enumerable.Sum(source.Select(x=> (double?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdecimalNullableIList4ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((decimal?) 1, 4).Select((x, i) => i%3==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X = x } ).ToIList();
            decimal? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            decimal? SumExpected = (decimal?) Enumerable.Sum(source, arg => (double?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumdecimalNullableIList4()
        {
            var source = ZEnumerable.Repeat((decimal?) 1, 4).ToIList();
            decimal? SumActual = ZEnumerable.Sum(source);
            decimal? SumExpected = (decimal?) Enumerable.Sum(source.Select(x=> (double?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdecimalNullableIList4Map()
        {
            var source = ZEnumerable.Repeat(new { X = (decimal?) 1 } , 4).ToIList();
            decimal? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            decimal? SumExpected = (decimal?) Enumerable.Sum(source, arg => (double?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
        
                        
            
        [TestMethod]
        public void TestSumdecimalNullableIList100ThreatNulls()
        {
            var source = ZEnumerable.Repeat((decimal?) 1, 100).Select((x, i) => i%3==0 ? x : null).ToIList();
            decimal? SumActual = ZEnumerable.Sum(source);
            decimal? SumExpected = (decimal?) Enumerable.Sum(source.Select(x=> (double?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdecimalNullableIList100ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((decimal?) 1, 100).Select((x, i) => i%3==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X = x } ).ToIList();
            decimal? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            decimal? SumExpected = (decimal?) Enumerable.Sum(source, arg => (double?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
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
        public void TestSumdecimalNullableIList2048ThreatNulls()
        {
            var source = ZEnumerable.Repeat((decimal?) 1, 2048).Select((x, i) => i%3==0 ? x : null).ToIList();
            decimal? SumActual = ZEnumerable.Sum(source);
            decimal? SumExpected = (decimal?) Enumerable.Sum(source.Select(x=> (double?) x ?? 0));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdecimalNullableIList2048ThreatNullsMap()
        {
            var baseCol = ZEnumerable.Repeat((decimal?) 1, 2048).Select((x, i) => i%3==0 ? x : null).ToIList();
            var source = baseCol.Select(x => new { X = x } ).ToIList();
            decimal? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            decimal? SumExpected = (decimal?) Enumerable.Sum(source, arg => (double?) arg.X ?? 0);        
            Assert.AreEqual(SumExpected, SumActual);
        }
            
        [TestMethod]
        public void TestSumdecimalNullableIList2048()
        {
            var source = ZEnumerable.Repeat((decimal?) 1, 2048).ToIList();
            decimal? SumActual = ZEnumerable.Sum(source);
            decimal? SumExpected = (decimal?) Enumerable.Sum(source.Select(x=> (double?)x));          
            Assert.AreEqual(SumExpected, SumActual);
        }
           
        [TestMethod]
        public void TestSumdecimalNullableIList2048Map()
        {
            var source = ZEnumerable.Repeat(new { X = (decimal?) 1 } , 2048).ToIList();
            decimal? SumActual = ZEnumerable.Sum(source, arg => arg.X);
            decimal? SumExpected = (decimal?) Enumerable.Sum(source, arg => (double?) arg.X);        
            Assert.AreEqual(SumExpected, SumActual);
        }

                
            
        [TestMethod]
        public void TestSumdecimalNullableIListNullOrEmpty()
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

            IList<decimal?> emptySource = new decimal?[0].ToIList();
            var sum = ZEnumerable.Sum(emptySource);
            Assert.AreEqual(sum, (decimal?) 0);
        }

        [TestMethod]
        public void TestSumdecimalNullableIListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<decimal?,decimal?>((decimal?) arg, (decimal?) arg)).ToIList();
            Func<KeyValuePair<decimal?, decimal?>, decimal?> nullMap = null;
            IList<decimal?> nullSource = null;

            try
            {
                ZEnumerable.Sum(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            try
            {
                ZEnumerable.Sum(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            
            var emptySource = source.Take(0).ToIList();
            var sum = ZEnumerable.Sum(emptySource, x => (decimal?) x.Key);
            Assert.AreEqual(sum, (decimal?) 0);           
        }

                
        #endregion
        

    }
}