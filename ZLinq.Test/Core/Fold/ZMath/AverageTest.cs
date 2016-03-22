
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZLinq.Test.Helpers;


// ReSharper disable RedundantCast
namespace ZLinq.Test.ZMath
{
    [TestClass]
    public class Average
    {            
        private const double Tolerance = 0.0000001;
                    
    
        #region sbyte             
            

         
        [TestMethod]
        public void TestAveragesbyteArrayNullOrEmpty()
        {        
            sbyte[] nullSource = null;

            try
            {
                ZEnumerable.Average(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            sbyte[] emptySource = new sbyte[0].ToArray();
            try
            {
                ZEnumerable.Average(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestAveragesbyteArrayMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<sbyte,sbyte>((sbyte) arg, (sbyte) arg)).ToArray();
            Func<KeyValuePair<sbyte, sbyte>, sbyte> nullMap = null;
            try
            {
                ZEnumerable.Average(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToArray();
            try
            {
                ZEnumerable.Average(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Average(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }
         
                            [TestMethod]
        public void TestAveragesbyteArray1()
        {            
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat((sbyte) expected, 1).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteArray1Map()
        {
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToArray();

            double result = ZEnumerable.Average(source, arg => (sbyte) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragesbyteArray1Min()
        {            
            const sbyte expected = 1;
            var source = Enumerable.Repeat((sbyte) expected, 1).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteArray1MapMin()
        {
            const sbyte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToArray();

            double result = ZEnumerable.Average(source, arg => (sbyte) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragesbyteArray2()
        {            
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat((sbyte) expected, 2).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteArray2Map()
        {
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToArray();

            double result = ZEnumerable.Average(source, arg => (sbyte) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragesbyteArray2Min()
        {            
            const sbyte expected = 1;
            var source = Enumerable.Repeat((sbyte) expected, 2).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteArray2MapMin()
        {
            const sbyte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToArray();

            double result = ZEnumerable.Average(source, arg => (sbyte) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragesbyteArray3()
        {            
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat((sbyte) expected, 3).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteArray3Map()
        {
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToArray();

            double result = ZEnumerable.Average(source, arg => (sbyte) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragesbyteArray3Min()
        {            
            const sbyte expected = 1;
            var source = Enumerable.Repeat((sbyte) expected, 3).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteArray3MapMin()
        {
            const sbyte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToArray();

            double result = ZEnumerable.Average(source, arg => (sbyte) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragesbyteArray4()
        {            
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat((sbyte) expected, 4).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteArray4Map()
        {
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToArray();

            double result = ZEnumerable.Average(source, arg => (sbyte) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragesbyteArray4Min()
        {            
            const sbyte expected = 1;
            var source = Enumerable.Repeat((sbyte) expected, 4).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteArray4MapMin()
        {
            const sbyte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToArray();

            double result = ZEnumerable.Average(source, arg => (sbyte) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragesbyteArray100()
        {            
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat((sbyte) expected, 100).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteArray100Map()
        {
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToArray();

            double result = ZEnumerable.Average(source, arg => (sbyte) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragesbyteArray100Min()
        {            
            const sbyte expected = 1;
            var source = Enumerable.Repeat((sbyte) expected, 100).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteArray100MapMin()
        {
            const sbyte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToArray();

            double result = ZEnumerable.Average(source, arg => (sbyte) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragesbyteArray4096()
        {            
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat((sbyte) expected, 4096).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteArray4096Map()
        {
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToArray();

            double result = ZEnumerable.Average(source, arg => (sbyte) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragesbyteArray4096Min()
        {            
            const sbyte expected = 1;
            var source = Enumerable.Repeat((sbyte) expected, 4096).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteArray4096MapMin()
        {
            const sbyte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToArray();

            double result = ZEnumerable.Average(source, arg => (sbyte) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
        
              
                        
        [TestMethod]
        public void TestAveragesbyteArrayNoOverflow()
        {
            const sbyte expected = sbyte.MaxValue;
            var source = Enumerable.Repeat((sbyte) expected, 2).ToArray();
            double result = ZEnumerable.Average(source);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                
        [TestMethod]
        public void TestAveragesbyteArrayMapNoOverflow()
        {
            const sbyte expected = sbyte.MaxValue;
            var source = Enumerable.Repeat(new { X = (sbyte) expected}, 2).ToArray();
            double result = ZEnumerable.Average(source, arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                            

         
        [TestMethod]
        public void TestAveragesbyteListNullOrEmpty()
        {        
            List<sbyte> nullSource = null;

            try
            {
                ZEnumerable.Average(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            List<sbyte> emptySource = new sbyte[0].ToList();
            try
            {
                ZEnumerable.Average(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestAveragesbyteListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<sbyte,sbyte>((sbyte) arg, (sbyte) arg)).ToList();
            Func<KeyValuePair<sbyte, sbyte>, sbyte> nullMap = null;
            try
            {
                ZEnumerable.Average(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToList();
            try
            {
                ZEnumerable.Average(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Average(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }
         
                            [TestMethod]
        public void TestAveragesbyteList1()
        {            
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat((sbyte) expected, 1).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteList1Map()
        {
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToList();

            double result = ZEnumerable.Average(source, arg => (sbyte) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragesbyteList1Min()
        {            
            const sbyte expected = 1;
            var source = Enumerable.Repeat((sbyte) expected, 1).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteList1MapMin()
        {
            const sbyte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToList();

            double result = ZEnumerable.Average(source, arg => (sbyte) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragesbyteList2()
        {            
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat((sbyte) expected, 2).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteList2Map()
        {
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToList();

            double result = ZEnumerable.Average(source, arg => (sbyte) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragesbyteList2Min()
        {            
            const sbyte expected = 1;
            var source = Enumerable.Repeat((sbyte) expected, 2).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteList2MapMin()
        {
            const sbyte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToList();

            double result = ZEnumerable.Average(source, arg => (sbyte) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragesbyteList3()
        {            
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat((sbyte) expected, 3).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteList3Map()
        {
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToList();

            double result = ZEnumerable.Average(source, arg => (sbyte) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragesbyteList3Min()
        {            
            const sbyte expected = 1;
            var source = Enumerable.Repeat((sbyte) expected, 3).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteList3MapMin()
        {
            const sbyte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToList();

            double result = ZEnumerable.Average(source, arg => (sbyte) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragesbyteList4()
        {            
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat((sbyte) expected, 4).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteList4Map()
        {
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToList();

            double result = ZEnumerable.Average(source, arg => (sbyte) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragesbyteList4Min()
        {            
            const sbyte expected = 1;
            var source = Enumerable.Repeat((sbyte) expected, 4).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteList4MapMin()
        {
            const sbyte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToList();

            double result = ZEnumerable.Average(source, arg => (sbyte) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragesbyteList100()
        {            
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat((sbyte) expected, 100).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteList100Map()
        {
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToList();

            double result = ZEnumerable.Average(source, arg => (sbyte) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragesbyteList100Min()
        {            
            const sbyte expected = 1;
            var source = Enumerable.Repeat((sbyte) expected, 100).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteList100MapMin()
        {
            const sbyte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToList();

            double result = ZEnumerable.Average(source, arg => (sbyte) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragesbyteList4096()
        {            
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat((sbyte) expected, 4096).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteList4096Map()
        {
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToList();

            double result = ZEnumerable.Average(source, arg => (sbyte) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragesbyteList4096Min()
        {            
            const sbyte expected = 1;
            var source = Enumerable.Repeat((sbyte) expected, 4096).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteList4096MapMin()
        {
            const sbyte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToList();

            double result = ZEnumerable.Average(source, arg => (sbyte) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
        
              
                        
        [TestMethod]
        public void TestAveragesbyteListNoOverflow()
        {
            const sbyte expected = sbyte.MaxValue;
            var source = Enumerable.Repeat((sbyte) expected, 2).ToList();
            double result = ZEnumerable.Average(source);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                
        [TestMethod]
        public void TestAveragesbyteListMapNoOverflow()
        {
            const sbyte expected = sbyte.MaxValue;
            var source = Enumerable.Repeat(new { X = (sbyte) expected}, 2).ToList();
            double result = ZEnumerable.Average(source, arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                            

         
        [TestMethod]
        public void TestAveragesbyteIListNullOrEmpty()
        {        
            IList<sbyte> nullSource = null;

            try
            {
                ZEnumerable.Average(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            IList<sbyte> emptySource = new sbyte[0].ToIList();
            try
            {
                ZEnumerable.Average(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestAveragesbyteIListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<sbyte,sbyte>((sbyte) arg, (sbyte) arg)).ToIList();
            Func<KeyValuePair<sbyte, sbyte>, sbyte> nullMap = null;
            try
            {
                ZEnumerable.Average(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToIList();
            try
            {
                ZEnumerable.Average(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Average(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }
         
                            [TestMethod]
        public void TestAveragesbyteIList1()
        {            
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat((sbyte) expected, 1).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteIList1Map()
        {
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToIList();

            double result = ZEnumerable.Average(source, arg => (sbyte) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragesbyteIList1Min()
        {            
            const sbyte expected = 1;
            var source = Enumerable.Repeat((sbyte) expected, 1).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteIList1MapMin()
        {
            const sbyte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToIList();

            double result = ZEnumerable.Average(source, arg => (sbyte) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragesbyteIList2()
        {            
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat((sbyte) expected, 2).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteIList2Map()
        {
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToIList();

            double result = ZEnumerable.Average(source, arg => (sbyte) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragesbyteIList2Min()
        {            
            const sbyte expected = 1;
            var source = Enumerable.Repeat((sbyte) expected, 2).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteIList2MapMin()
        {
            const sbyte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToIList();

            double result = ZEnumerable.Average(source, arg => (sbyte) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragesbyteIList3()
        {            
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat((sbyte) expected, 3).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteIList3Map()
        {
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToIList();

            double result = ZEnumerable.Average(source, arg => (sbyte) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragesbyteIList3Min()
        {            
            const sbyte expected = 1;
            var source = Enumerable.Repeat((sbyte) expected, 3).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteIList3MapMin()
        {
            const sbyte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToIList();

            double result = ZEnumerable.Average(source, arg => (sbyte) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragesbyteIList4()
        {            
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat((sbyte) expected, 4).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteIList4Map()
        {
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToIList();

            double result = ZEnumerable.Average(source, arg => (sbyte) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragesbyteIList4Min()
        {            
            const sbyte expected = 1;
            var source = Enumerable.Repeat((sbyte) expected, 4).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteIList4MapMin()
        {
            const sbyte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToIList();

            double result = ZEnumerable.Average(source, arg => (sbyte) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragesbyteIList100()
        {            
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat((sbyte) expected, 100).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteIList100Map()
        {
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToIList();

            double result = ZEnumerable.Average(source, arg => (sbyte) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragesbyteIList100Min()
        {            
            const sbyte expected = 1;
            var source = Enumerable.Repeat((sbyte) expected, 100).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteIList100MapMin()
        {
            const sbyte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToIList();

            double result = ZEnumerable.Average(source, arg => (sbyte) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragesbyteIList4096()
        {            
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat((sbyte) expected, 4096).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteIList4096Map()
        {
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToIList();

            double result = ZEnumerable.Average(source, arg => (sbyte) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragesbyteIList4096Min()
        {            
            const sbyte expected = 1;
            var source = Enumerable.Repeat((sbyte) expected, 4096).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteIList4096MapMin()
        {
            const sbyte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToIList();

            double result = ZEnumerable.Average(source, arg => (sbyte) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
        
              
                        
        [TestMethod]
        public void TestAveragesbyteIListNoOverflow()
        {
            const sbyte expected = sbyte.MaxValue;
            var source = Enumerable.Repeat((sbyte) expected, 2).ToIList();
            double result = ZEnumerable.Average(source);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                
        [TestMethod]
        public void TestAveragesbyteIListMapNoOverflow()
        {
            const sbyte expected = sbyte.MaxValue;
            var source = Enumerable.Repeat(new { X = (sbyte) expected}, 2).ToIList();
            double result = ZEnumerable.Average(source, arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                                
        #endregion
    
        #region byte             
            

         
        [TestMethod]
        public void TestAveragebyteArrayNullOrEmpty()
        {        
            byte[] nullSource = null;

            try
            {
                ZEnumerable.Average(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            byte[] emptySource = new byte[0].ToArray();
            try
            {
                ZEnumerable.Average(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestAveragebyteArrayMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<byte,byte>((byte) arg, (byte) arg)).ToArray();
            Func<KeyValuePair<byte, byte>, byte> nullMap = null;
            try
            {
                ZEnumerable.Average(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToArray();
            try
            {
                ZEnumerable.Average(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Average(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }
         
                            [TestMethod]
        public void TestAveragebyteArray1()
        {            
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat((byte) expected, 1).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteArray1Map()
        {
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToArray();

            double result = ZEnumerable.Average(source, arg => (byte) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragebyteArray1Min()
        {            
            const byte expected = 1;
            var source = Enumerable.Repeat((byte) expected, 1).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteArray1MapMin()
        {
            const byte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToArray();

            double result = ZEnumerable.Average(source, arg => (byte) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragebyteArray2()
        {            
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat((byte) expected, 2).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteArray2Map()
        {
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToArray();

            double result = ZEnumerable.Average(source, arg => (byte) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragebyteArray2Min()
        {            
            const byte expected = 1;
            var source = Enumerable.Repeat((byte) expected, 2).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteArray2MapMin()
        {
            const byte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToArray();

            double result = ZEnumerable.Average(source, arg => (byte) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragebyteArray3()
        {            
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat((byte) expected, 3).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteArray3Map()
        {
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToArray();

            double result = ZEnumerable.Average(source, arg => (byte) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragebyteArray3Min()
        {            
            const byte expected = 1;
            var source = Enumerable.Repeat((byte) expected, 3).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteArray3MapMin()
        {
            const byte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToArray();

            double result = ZEnumerable.Average(source, arg => (byte) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragebyteArray4()
        {            
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat((byte) expected, 4).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteArray4Map()
        {
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToArray();

            double result = ZEnumerable.Average(source, arg => (byte) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragebyteArray4Min()
        {            
            const byte expected = 1;
            var source = Enumerable.Repeat((byte) expected, 4).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteArray4MapMin()
        {
            const byte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToArray();

            double result = ZEnumerable.Average(source, arg => (byte) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragebyteArray100()
        {            
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat((byte) expected, 100).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteArray100Map()
        {
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToArray();

            double result = ZEnumerable.Average(source, arg => (byte) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragebyteArray100Min()
        {            
            const byte expected = 1;
            var source = Enumerable.Repeat((byte) expected, 100).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteArray100MapMin()
        {
            const byte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToArray();

            double result = ZEnumerable.Average(source, arg => (byte) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragebyteArray4096()
        {            
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat((byte) expected, 4096).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteArray4096Map()
        {
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToArray();

            double result = ZEnumerable.Average(source, arg => (byte) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragebyteArray4096Min()
        {            
            const byte expected = 1;
            var source = Enumerable.Repeat((byte) expected, 4096).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteArray4096MapMin()
        {
            const byte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToArray();

            double result = ZEnumerable.Average(source, arg => (byte) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
        
              
                        
        [TestMethod]
        public void TestAveragebyteArrayNoOverflow()
        {
            const byte expected = byte.MaxValue;
            var source = Enumerable.Repeat((byte) expected, 2).ToArray();
            double result = ZEnumerable.Average(source);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                
        [TestMethod]
        public void TestAveragebyteArrayMapNoOverflow()
        {
            const byte expected = byte.MaxValue;
            var source = Enumerable.Repeat(new { X = (byte) expected}, 2).ToArray();
            double result = ZEnumerable.Average(source, arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                            

         
        [TestMethod]
        public void TestAveragebyteListNullOrEmpty()
        {        
            List<byte> nullSource = null;

            try
            {
                ZEnumerable.Average(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            List<byte> emptySource = new byte[0].ToList();
            try
            {
                ZEnumerable.Average(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestAveragebyteListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<byte,byte>((byte) arg, (byte) arg)).ToList();
            Func<KeyValuePair<byte, byte>, byte> nullMap = null;
            try
            {
                ZEnumerable.Average(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToList();
            try
            {
                ZEnumerable.Average(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Average(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }
         
                            [TestMethod]
        public void TestAveragebyteList1()
        {            
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat((byte) expected, 1).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteList1Map()
        {
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToList();

            double result = ZEnumerable.Average(source, arg => (byte) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragebyteList1Min()
        {            
            const byte expected = 1;
            var source = Enumerable.Repeat((byte) expected, 1).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteList1MapMin()
        {
            const byte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToList();

            double result = ZEnumerable.Average(source, arg => (byte) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragebyteList2()
        {            
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat((byte) expected, 2).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteList2Map()
        {
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToList();

            double result = ZEnumerable.Average(source, arg => (byte) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragebyteList2Min()
        {            
            const byte expected = 1;
            var source = Enumerable.Repeat((byte) expected, 2).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteList2MapMin()
        {
            const byte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToList();

            double result = ZEnumerable.Average(source, arg => (byte) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragebyteList3()
        {            
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat((byte) expected, 3).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteList3Map()
        {
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToList();

            double result = ZEnumerable.Average(source, arg => (byte) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragebyteList3Min()
        {            
            const byte expected = 1;
            var source = Enumerable.Repeat((byte) expected, 3).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteList3MapMin()
        {
            const byte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToList();

            double result = ZEnumerable.Average(source, arg => (byte) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragebyteList4()
        {            
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat((byte) expected, 4).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteList4Map()
        {
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToList();

            double result = ZEnumerable.Average(source, arg => (byte) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragebyteList4Min()
        {            
            const byte expected = 1;
            var source = Enumerable.Repeat((byte) expected, 4).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteList4MapMin()
        {
            const byte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToList();

            double result = ZEnumerable.Average(source, arg => (byte) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragebyteList100()
        {            
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat((byte) expected, 100).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteList100Map()
        {
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToList();

            double result = ZEnumerable.Average(source, arg => (byte) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragebyteList100Min()
        {            
            const byte expected = 1;
            var source = Enumerable.Repeat((byte) expected, 100).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteList100MapMin()
        {
            const byte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToList();

            double result = ZEnumerable.Average(source, arg => (byte) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragebyteList4096()
        {            
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat((byte) expected, 4096).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteList4096Map()
        {
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToList();

            double result = ZEnumerable.Average(source, arg => (byte) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragebyteList4096Min()
        {            
            const byte expected = 1;
            var source = Enumerable.Repeat((byte) expected, 4096).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteList4096MapMin()
        {
            const byte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToList();

            double result = ZEnumerable.Average(source, arg => (byte) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
        
              
                        
        [TestMethod]
        public void TestAveragebyteListNoOverflow()
        {
            const byte expected = byte.MaxValue;
            var source = Enumerable.Repeat((byte) expected, 2).ToList();
            double result = ZEnumerable.Average(source);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                
        [TestMethod]
        public void TestAveragebyteListMapNoOverflow()
        {
            const byte expected = byte.MaxValue;
            var source = Enumerable.Repeat(new { X = (byte) expected}, 2).ToList();
            double result = ZEnumerable.Average(source, arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                            

         
        [TestMethod]
        public void TestAveragebyteIListNullOrEmpty()
        {        
            IList<byte> nullSource = null;

            try
            {
                ZEnumerable.Average(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            IList<byte> emptySource = new byte[0].ToIList();
            try
            {
                ZEnumerable.Average(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestAveragebyteIListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<byte,byte>((byte) arg, (byte) arg)).ToIList();
            Func<KeyValuePair<byte, byte>, byte> nullMap = null;
            try
            {
                ZEnumerable.Average(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToIList();
            try
            {
                ZEnumerable.Average(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Average(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }
         
                            [TestMethod]
        public void TestAveragebyteIList1()
        {            
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat((byte) expected, 1).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteIList1Map()
        {
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToIList();

            double result = ZEnumerable.Average(source, arg => (byte) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragebyteIList1Min()
        {            
            const byte expected = 1;
            var source = Enumerable.Repeat((byte) expected, 1).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteIList1MapMin()
        {
            const byte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToIList();

            double result = ZEnumerable.Average(source, arg => (byte) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragebyteIList2()
        {            
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat((byte) expected, 2).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteIList2Map()
        {
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToIList();

            double result = ZEnumerable.Average(source, arg => (byte) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragebyteIList2Min()
        {            
            const byte expected = 1;
            var source = Enumerable.Repeat((byte) expected, 2).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteIList2MapMin()
        {
            const byte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToIList();

            double result = ZEnumerable.Average(source, arg => (byte) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragebyteIList3()
        {            
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat((byte) expected, 3).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteIList3Map()
        {
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToIList();

            double result = ZEnumerable.Average(source, arg => (byte) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragebyteIList3Min()
        {            
            const byte expected = 1;
            var source = Enumerable.Repeat((byte) expected, 3).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteIList3MapMin()
        {
            const byte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToIList();

            double result = ZEnumerable.Average(source, arg => (byte) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragebyteIList4()
        {            
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat((byte) expected, 4).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteIList4Map()
        {
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToIList();

            double result = ZEnumerable.Average(source, arg => (byte) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragebyteIList4Min()
        {            
            const byte expected = 1;
            var source = Enumerable.Repeat((byte) expected, 4).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteIList4MapMin()
        {
            const byte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToIList();

            double result = ZEnumerable.Average(source, arg => (byte) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragebyteIList100()
        {            
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat((byte) expected, 100).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteIList100Map()
        {
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToIList();

            double result = ZEnumerable.Average(source, arg => (byte) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragebyteIList100Min()
        {            
            const byte expected = 1;
            var source = Enumerable.Repeat((byte) expected, 100).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteIList100MapMin()
        {
            const byte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToIList();

            double result = ZEnumerable.Average(source, arg => (byte) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragebyteIList4096()
        {            
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat((byte) expected, 4096).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteIList4096Map()
        {
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToIList();

            double result = ZEnumerable.Average(source, arg => (byte) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragebyteIList4096Min()
        {            
            const byte expected = 1;
            var source = Enumerable.Repeat((byte) expected, 4096).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteIList4096MapMin()
        {
            const byte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToIList();

            double result = ZEnumerable.Average(source, arg => (byte) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
        
              
                        
        [TestMethod]
        public void TestAveragebyteIListNoOverflow()
        {
            const byte expected = byte.MaxValue;
            var source = Enumerable.Repeat((byte) expected, 2).ToIList();
            double result = ZEnumerable.Average(source);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                
        [TestMethod]
        public void TestAveragebyteIListMapNoOverflow()
        {
            const byte expected = byte.MaxValue;
            var source = Enumerable.Repeat(new { X = (byte) expected}, 2).ToIList();
            double result = ZEnumerable.Average(source, arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                                
        #endregion
    
        #region short             
            

         
        [TestMethod]
        public void TestAverageshortArrayNullOrEmpty()
        {        
            short[] nullSource = null;

            try
            {
                ZEnumerable.Average(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            short[] emptySource = new short[0].ToArray();
            try
            {
                ZEnumerable.Average(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestAverageshortArrayMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<short,short>((short) arg, (short) arg)).ToArray();
            Func<KeyValuePair<short, short>, short> nullMap = null;
            try
            {
                ZEnumerable.Average(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToArray();
            try
            {
                ZEnumerable.Average(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Average(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }
         
                            [TestMethod]
        public void TestAverageshortArray1()
        {            
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat((short) expected, 1).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortArray1Map()
        {
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToArray();

            double result = ZEnumerable.Average(source, arg => (short) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageshortArray1Min()
        {            
            const short expected = 1;
            var source = Enumerable.Repeat((short) expected, 1).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortArray1MapMin()
        {
            const short expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToArray();

            double result = ZEnumerable.Average(source, arg => (short) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageshortArray2()
        {            
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat((short) expected, 2).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortArray2Map()
        {
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToArray();

            double result = ZEnumerable.Average(source, arg => (short) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageshortArray2Min()
        {            
            const short expected = 1;
            var source = Enumerable.Repeat((short) expected, 2).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortArray2MapMin()
        {
            const short expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToArray();

            double result = ZEnumerable.Average(source, arg => (short) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageshortArray3()
        {            
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat((short) expected, 3).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortArray3Map()
        {
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToArray();

            double result = ZEnumerable.Average(source, arg => (short) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageshortArray3Min()
        {            
            const short expected = 1;
            var source = Enumerable.Repeat((short) expected, 3).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortArray3MapMin()
        {
            const short expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToArray();

            double result = ZEnumerable.Average(source, arg => (short) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageshortArray4()
        {            
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat((short) expected, 4).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortArray4Map()
        {
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToArray();

            double result = ZEnumerable.Average(source, arg => (short) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageshortArray4Min()
        {            
            const short expected = 1;
            var source = Enumerable.Repeat((short) expected, 4).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortArray4MapMin()
        {
            const short expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToArray();

            double result = ZEnumerable.Average(source, arg => (short) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageshortArray100()
        {            
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat((short) expected, 100).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortArray100Map()
        {
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToArray();

            double result = ZEnumerable.Average(source, arg => (short) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageshortArray100Min()
        {            
            const short expected = 1;
            var source = Enumerable.Repeat((short) expected, 100).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortArray100MapMin()
        {
            const short expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToArray();

            double result = ZEnumerable.Average(source, arg => (short) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageshortArray4096()
        {            
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat((short) expected, 4096).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortArray4096Map()
        {
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToArray();

            double result = ZEnumerable.Average(source, arg => (short) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageshortArray4096Min()
        {            
            const short expected = 1;
            var source = Enumerable.Repeat((short) expected, 4096).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortArray4096MapMin()
        {
            const short expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToArray();

            double result = ZEnumerable.Average(source, arg => (short) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
        
              
                        
        [TestMethod]
        public void TestAverageshortArrayNoOverflow()
        {
            const short expected = short.MaxValue;
            var source = Enumerable.Repeat((short) expected, 2).ToArray();
            double result = ZEnumerable.Average(source);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                
        [TestMethod]
        public void TestAverageshortArrayMapNoOverflow()
        {
            const short expected = short.MaxValue;
            var source = Enumerable.Repeat(new { X = (short) expected}, 2).ToArray();
            double result = ZEnumerable.Average(source, arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                            

         
        [TestMethod]
        public void TestAverageshortListNullOrEmpty()
        {        
            List<short> nullSource = null;

            try
            {
                ZEnumerable.Average(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            List<short> emptySource = new short[0].ToList();
            try
            {
                ZEnumerable.Average(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestAverageshortListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<short,short>((short) arg, (short) arg)).ToList();
            Func<KeyValuePair<short, short>, short> nullMap = null;
            try
            {
                ZEnumerable.Average(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToList();
            try
            {
                ZEnumerable.Average(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Average(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }
         
                            [TestMethod]
        public void TestAverageshortList1()
        {            
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat((short) expected, 1).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortList1Map()
        {
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToList();

            double result = ZEnumerable.Average(source, arg => (short) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageshortList1Min()
        {            
            const short expected = 1;
            var source = Enumerable.Repeat((short) expected, 1).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortList1MapMin()
        {
            const short expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToList();

            double result = ZEnumerable.Average(source, arg => (short) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageshortList2()
        {            
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat((short) expected, 2).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortList2Map()
        {
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToList();

            double result = ZEnumerable.Average(source, arg => (short) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageshortList2Min()
        {            
            const short expected = 1;
            var source = Enumerable.Repeat((short) expected, 2).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortList2MapMin()
        {
            const short expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToList();

            double result = ZEnumerable.Average(source, arg => (short) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageshortList3()
        {            
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat((short) expected, 3).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortList3Map()
        {
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToList();

            double result = ZEnumerable.Average(source, arg => (short) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageshortList3Min()
        {            
            const short expected = 1;
            var source = Enumerable.Repeat((short) expected, 3).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortList3MapMin()
        {
            const short expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToList();

            double result = ZEnumerable.Average(source, arg => (short) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageshortList4()
        {            
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat((short) expected, 4).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortList4Map()
        {
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToList();

            double result = ZEnumerable.Average(source, arg => (short) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageshortList4Min()
        {            
            const short expected = 1;
            var source = Enumerable.Repeat((short) expected, 4).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortList4MapMin()
        {
            const short expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToList();

            double result = ZEnumerable.Average(source, arg => (short) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageshortList100()
        {            
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat((short) expected, 100).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortList100Map()
        {
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToList();

            double result = ZEnumerable.Average(source, arg => (short) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageshortList100Min()
        {            
            const short expected = 1;
            var source = Enumerable.Repeat((short) expected, 100).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortList100MapMin()
        {
            const short expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToList();

            double result = ZEnumerable.Average(source, arg => (short) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageshortList4096()
        {            
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat((short) expected, 4096).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortList4096Map()
        {
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToList();

            double result = ZEnumerable.Average(source, arg => (short) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageshortList4096Min()
        {            
            const short expected = 1;
            var source = Enumerable.Repeat((short) expected, 4096).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortList4096MapMin()
        {
            const short expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToList();

            double result = ZEnumerable.Average(source, arg => (short) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
        
              
                        
        [TestMethod]
        public void TestAverageshortListNoOverflow()
        {
            const short expected = short.MaxValue;
            var source = Enumerable.Repeat((short) expected, 2).ToList();
            double result = ZEnumerable.Average(source);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                
        [TestMethod]
        public void TestAverageshortListMapNoOverflow()
        {
            const short expected = short.MaxValue;
            var source = Enumerable.Repeat(new { X = (short) expected}, 2).ToList();
            double result = ZEnumerable.Average(source, arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                            

         
        [TestMethod]
        public void TestAverageshortIListNullOrEmpty()
        {        
            IList<short> nullSource = null;

            try
            {
                ZEnumerable.Average(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            IList<short> emptySource = new short[0].ToIList();
            try
            {
                ZEnumerable.Average(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestAverageshortIListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<short,short>((short) arg, (short) arg)).ToIList();
            Func<KeyValuePair<short, short>, short> nullMap = null;
            try
            {
                ZEnumerable.Average(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToIList();
            try
            {
                ZEnumerable.Average(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Average(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }
         
                            [TestMethod]
        public void TestAverageshortIList1()
        {            
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat((short) expected, 1).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortIList1Map()
        {
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToIList();

            double result = ZEnumerable.Average(source, arg => (short) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageshortIList1Min()
        {            
            const short expected = 1;
            var source = Enumerable.Repeat((short) expected, 1).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortIList1MapMin()
        {
            const short expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToIList();

            double result = ZEnumerable.Average(source, arg => (short) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageshortIList2()
        {            
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat((short) expected, 2).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortIList2Map()
        {
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToIList();

            double result = ZEnumerable.Average(source, arg => (short) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageshortIList2Min()
        {            
            const short expected = 1;
            var source = Enumerable.Repeat((short) expected, 2).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortIList2MapMin()
        {
            const short expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToIList();

            double result = ZEnumerable.Average(source, arg => (short) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageshortIList3()
        {            
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat((short) expected, 3).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortIList3Map()
        {
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToIList();

            double result = ZEnumerable.Average(source, arg => (short) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageshortIList3Min()
        {            
            const short expected = 1;
            var source = Enumerable.Repeat((short) expected, 3).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortIList3MapMin()
        {
            const short expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToIList();

            double result = ZEnumerable.Average(source, arg => (short) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageshortIList4()
        {            
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat((short) expected, 4).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortIList4Map()
        {
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToIList();

            double result = ZEnumerable.Average(source, arg => (short) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageshortIList4Min()
        {            
            const short expected = 1;
            var source = Enumerable.Repeat((short) expected, 4).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortIList4MapMin()
        {
            const short expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToIList();

            double result = ZEnumerable.Average(source, arg => (short) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageshortIList100()
        {            
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat((short) expected, 100).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortIList100Map()
        {
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToIList();

            double result = ZEnumerable.Average(source, arg => (short) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageshortIList100Min()
        {            
            const short expected = 1;
            var source = Enumerable.Repeat((short) expected, 100).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortIList100MapMin()
        {
            const short expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToIList();

            double result = ZEnumerable.Average(source, arg => (short) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageshortIList4096()
        {            
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat((short) expected, 4096).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortIList4096Map()
        {
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToIList();

            double result = ZEnumerable.Average(source, arg => (short) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageshortIList4096Min()
        {            
            const short expected = 1;
            var source = Enumerable.Repeat((short) expected, 4096).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortIList4096MapMin()
        {
            const short expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToIList();

            double result = ZEnumerable.Average(source, arg => (short) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
        
              
                        
        [TestMethod]
        public void TestAverageshortIListNoOverflow()
        {
            const short expected = short.MaxValue;
            var source = Enumerable.Repeat((short) expected, 2).ToIList();
            double result = ZEnumerable.Average(source);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                
        [TestMethod]
        public void TestAverageshortIListMapNoOverflow()
        {
            const short expected = short.MaxValue;
            var source = Enumerable.Repeat(new { X = (short) expected}, 2).ToIList();
            double result = ZEnumerable.Average(source, arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                                
        #endregion
    
        #region ushort             
            

         
        [TestMethod]
        public void TestAverageushortArrayNullOrEmpty()
        {        
            ushort[] nullSource = null;

            try
            {
                ZEnumerable.Average(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            ushort[] emptySource = new ushort[0].ToArray();
            try
            {
                ZEnumerable.Average(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestAverageushortArrayMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<ushort,ushort>((ushort) arg, (ushort) arg)).ToArray();
            Func<KeyValuePair<ushort, ushort>, ushort> nullMap = null;
            try
            {
                ZEnumerable.Average(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToArray();
            try
            {
                ZEnumerable.Average(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Average(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }
         
                            [TestMethod]
        public void TestAverageushortArray1()
        {            
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat((ushort) expected, 1).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortArray1Map()
        {
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToArray();

            double result = ZEnumerable.Average(source, arg => (ushort) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageushortArray1Min()
        {            
            const ushort expected = 1;
            var source = Enumerable.Repeat((ushort) expected, 1).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortArray1MapMin()
        {
            const ushort expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToArray();

            double result = ZEnumerable.Average(source, arg => (ushort) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageushortArray2()
        {            
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat((ushort) expected, 2).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortArray2Map()
        {
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToArray();

            double result = ZEnumerable.Average(source, arg => (ushort) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageushortArray2Min()
        {            
            const ushort expected = 1;
            var source = Enumerable.Repeat((ushort) expected, 2).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortArray2MapMin()
        {
            const ushort expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToArray();

            double result = ZEnumerable.Average(source, arg => (ushort) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageushortArray3()
        {            
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat((ushort) expected, 3).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortArray3Map()
        {
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToArray();

            double result = ZEnumerable.Average(source, arg => (ushort) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageushortArray3Min()
        {            
            const ushort expected = 1;
            var source = Enumerable.Repeat((ushort) expected, 3).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortArray3MapMin()
        {
            const ushort expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToArray();

            double result = ZEnumerable.Average(source, arg => (ushort) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageushortArray4()
        {            
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat((ushort) expected, 4).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortArray4Map()
        {
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToArray();

            double result = ZEnumerable.Average(source, arg => (ushort) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageushortArray4Min()
        {            
            const ushort expected = 1;
            var source = Enumerable.Repeat((ushort) expected, 4).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortArray4MapMin()
        {
            const ushort expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToArray();

            double result = ZEnumerable.Average(source, arg => (ushort) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageushortArray100()
        {            
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat((ushort) expected, 100).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortArray100Map()
        {
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToArray();

            double result = ZEnumerable.Average(source, arg => (ushort) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageushortArray100Min()
        {            
            const ushort expected = 1;
            var source = Enumerable.Repeat((ushort) expected, 100).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortArray100MapMin()
        {
            const ushort expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToArray();

            double result = ZEnumerable.Average(source, arg => (ushort) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageushortArray4096()
        {            
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat((ushort) expected, 4096).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortArray4096Map()
        {
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToArray();

            double result = ZEnumerable.Average(source, arg => (ushort) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageushortArray4096Min()
        {            
            const ushort expected = 1;
            var source = Enumerable.Repeat((ushort) expected, 4096).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortArray4096MapMin()
        {
            const ushort expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToArray();

            double result = ZEnumerable.Average(source, arg => (ushort) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
        
              
                        
        [TestMethod]
        public void TestAverageushortArrayNoOverflow()
        {
            const ushort expected = ushort.MaxValue;
            var source = Enumerable.Repeat((ushort) expected, 2).ToArray();
            double result = ZEnumerable.Average(source);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                
        [TestMethod]
        public void TestAverageushortArrayMapNoOverflow()
        {
            const ushort expected = ushort.MaxValue;
            var source = Enumerable.Repeat(new { X = (ushort) expected}, 2).ToArray();
            double result = ZEnumerable.Average(source, arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                            

         
        [TestMethod]
        public void TestAverageushortListNullOrEmpty()
        {        
            List<ushort> nullSource = null;

            try
            {
                ZEnumerable.Average(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            List<ushort> emptySource = new ushort[0].ToList();
            try
            {
                ZEnumerable.Average(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestAverageushortListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<ushort,ushort>((ushort) arg, (ushort) arg)).ToList();
            Func<KeyValuePair<ushort, ushort>, ushort> nullMap = null;
            try
            {
                ZEnumerable.Average(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToList();
            try
            {
                ZEnumerable.Average(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Average(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }
         
                            [TestMethod]
        public void TestAverageushortList1()
        {            
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat((ushort) expected, 1).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortList1Map()
        {
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToList();

            double result = ZEnumerable.Average(source, arg => (ushort) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageushortList1Min()
        {            
            const ushort expected = 1;
            var source = Enumerable.Repeat((ushort) expected, 1).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortList1MapMin()
        {
            const ushort expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToList();

            double result = ZEnumerable.Average(source, arg => (ushort) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageushortList2()
        {            
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat((ushort) expected, 2).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortList2Map()
        {
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToList();

            double result = ZEnumerable.Average(source, arg => (ushort) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageushortList2Min()
        {            
            const ushort expected = 1;
            var source = Enumerable.Repeat((ushort) expected, 2).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortList2MapMin()
        {
            const ushort expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToList();

            double result = ZEnumerable.Average(source, arg => (ushort) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageushortList3()
        {            
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat((ushort) expected, 3).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortList3Map()
        {
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToList();

            double result = ZEnumerable.Average(source, arg => (ushort) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageushortList3Min()
        {            
            const ushort expected = 1;
            var source = Enumerable.Repeat((ushort) expected, 3).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortList3MapMin()
        {
            const ushort expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToList();

            double result = ZEnumerable.Average(source, arg => (ushort) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageushortList4()
        {            
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat((ushort) expected, 4).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortList4Map()
        {
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToList();

            double result = ZEnumerable.Average(source, arg => (ushort) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageushortList4Min()
        {            
            const ushort expected = 1;
            var source = Enumerable.Repeat((ushort) expected, 4).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortList4MapMin()
        {
            const ushort expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToList();

            double result = ZEnumerable.Average(source, arg => (ushort) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageushortList100()
        {            
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat((ushort) expected, 100).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortList100Map()
        {
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToList();

            double result = ZEnumerable.Average(source, arg => (ushort) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageushortList100Min()
        {            
            const ushort expected = 1;
            var source = Enumerable.Repeat((ushort) expected, 100).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortList100MapMin()
        {
            const ushort expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToList();

            double result = ZEnumerable.Average(source, arg => (ushort) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageushortList4096()
        {            
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat((ushort) expected, 4096).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortList4096Map()
        {
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToList();

            double result = ZEnumerable.Average(source, arg => (ushort) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageushortList4096Min()
        {            
            const ushort expected = 1;
            var source = Enumerable.Repeat((ushort) expected, 4096).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortList4096MapMin()
        {
            const ushort expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToList();

            double result = ZEnumerable.Average(source, arg => (ushort) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
        
              
                        
        [TestMethod]
        public void TestAverageushortListNoOverflow()
        {
            const ushort expected = ushort.MaxValue;
            var source = Enumerable.Repeat((ushort) expected, 2).ToList();
            double result = ZEnumerable.Average(source);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                
        [TestMethod]
        public void TestAverageushortListMapNoOverflow()
        {
            const ushort expected = ushort.MaxValue;
            var source = Enumerable.Repeat(new { X = (ushort) expected}, 2).ToList();
            double result = ZEnumerable.Average(source, arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                            

         
        [TestMethod]
        public void TestAverageushortIListNullOrEmpty()
        {        
            IList<ushort> nullSource = null;

            try
            {
                ZEnumerable.Average(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            IList<ushort> emptySource = new ushort[0].ToIList();
            try
            {
                ZEnumerable.Average(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestAverageushortIListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<ushort,ushort>((ushort) arg, (ushort) arg)).ToIList();
            Func<KeyValuePair<ushort, ushort>, ushort> nullMap = null;
            try
            {
                ZEnumerable.Average(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToIList();
            try
            {
                ZEnumerable.Average(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Average(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }
         
                            [TestMethod]
        public void TestAverageushortIList1()
        {            
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat((ushort) expected, 1).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortIList1Map()
        {
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToIList();

            double result = ZEnumerable.Average(source, arg => (ushort) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageushortIList1Min()
        {            
            const ushort expected = 1;
            var source = Enumerable.Repeat((ushort) expected, 1).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortIList1MapMin()
        {
            const ushort expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToIList();

            double result = ZEnumerable.Average(source, arg => (ushort) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageushortIList2()
        {            
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat((ushort) expected, 2).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortIList2Map()
        {
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToIList();

            double result = ZEnumerable.Average(source, arg => (ushort) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageushortIList2Min()
        {            
            const ushort expected = 1;
            var source = Enumerable.Repeat((ushort) expected, 2).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortIList2MapMin()
        {
            const ushort expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToIList();

            double result = ZEnumerable.Average(source, arg => (ushort) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageushortIList3()
        {            
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat((ushort) expected, 3).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortIList3Map()
        {
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToIList();

            double result = ZEnumerable.Average(source, arg => (ushort) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageushortIList3Min()
        {            
            const ushort expected = 1;
            var source = Enumerable.Repeat((ushort) expected, 3).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortIList3MapMin()
        {
            const ushort expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToIList();

            double result = ZEnumerable.Average(source, arg => (ushort) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageushortIList4()
        {            
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat((ushort) expected, 4).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortIList4Map()
        {
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToIList();

            double result = ZEnumerable.Average(source, arg => (ushort) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageushortIList4Min()
        {            
            const ushort expected = 1;
            var source = Enumerable.Repeat((ushort) expected, 4).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortIList4MapMin()
        {
            const ushort expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToIList();

            double result = ZEnumerable.Average(source, arg => (ushort) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageushortIList100()
        {            
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat((ushort) expected, 100).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortIList100Map()
        {
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToIList();

            double result = ZEnumerable.Average(source, arg => (ushort) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageushortIList100Min()
        {            
            const ushort expected = 1;
            var source = Enumerable.Repeat((ushort) expected, 100).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortIList100MapMin()
        {
            const ushort expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToIList();

            double result = ZEnumerable.Average(source, arg => (ushort) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageushortIList4096()
        {            
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat((ushort) expected, 4096).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortIList4096Map()
        {
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToIList();

            double result = ZEnumerable.Average(source, arg => (ushort) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageushortIList4096Min()
        {            
            const ushort expected = 1;
            var source = Enumerable.Repeat((ushort) expected, 4096).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortIList4096MapMin()
        {
            const ushort expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToIList();

            double result = ZEnumerable.Average(source, arg => (ushort) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
        
              
                        
        [TestMethod]
        public void TestAverageushortIListNoOverflow()
        {
            const ushort expected = ushort.MaxValue;
            var source = Enumerable.Repeat((ushort) expected, 2).ToIList();
            double result = ZEnumerable.Average(source);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                
        [TestMethod]
        public void TestAverageushortIListMapNoOverflow()
        {
            const ushort expected = ushort.MaxValue;
            var source = Enumerable.Repeat(new { X = (ushort) expected}, 2).ToIList();
            double result = ZEnumerable.Average(source, arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                                
        #endregion
    
        #region int             
            

         
        [TestMethod]
        public void TestAverageintArrayNullOrEmpty()
        {        
            int[] nullSource = null;

            try
            {
                ZEnumerable.Average(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            int[] emptySource = new int[0].ToArray();
            try
            {
                ZEnumerable.Average(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestAverageintArrayMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<int,int>((int) arg, (int) arg)).ToArray();
            Func<KeyValuePair<int, int>, int> nullMap = null;
            try
            {
                ZEnumerable.Average(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToArray();
            try
            {
                ZEnumerable.Average(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Average(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }
         
                            [TestMethod]
        public void TestAverageintArray1()
        {            
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat((int) expected, 1).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintArray1Map()
        {
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToArray();

            double result = ZEnumerable.Average(source, arg => (int) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageintArray1Min()
        {            
            const int expected = 1;
            var source = Enumerable.Repeat((int) expected, 1).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintArray1MapMin()
        {
            const int expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToArray();

            double result = ZEnumerable.Average(source, arg => (int) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageintArray2()
        {            
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat((int) expected, 2).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintArray2Map()
        {
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToArray();

            double result = ZEnumerable.Average(source, arg => (int) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageintArray2Min()
        {            
            const int expected = 1;
            var source = Enumerable.Repeat((int) expected, 2).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintArray2MapMin()
        {
            const int expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToArray();

            double result = ZEnumerable.Average(source, arg => (int) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageintArray3()
        {            
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat((int) expected, 3).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintArray3Map()
        {
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToArray();

            double result = ZEnumerable.Average(source, arg => (int) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageintArray3Min()
        {            
            const int expected = 1;
            var source = Enumerable.Repeat((int) expected, 3).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintArray3MapMin()
        {
            const int expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToArray();

            double result = ZEnumerable.Average(source, arg => (int) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageintArray4()
        {            
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat((int) expected, 4).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintArray4Map()
        {
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToArray();

            double result = ZEnumerable.Average(source, arg => (int) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageintArray4Min()
        {            
            const int expected = 1;
            var source = Enumerable.Repeat((int) expected, 4).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintArray4MapMin()
        {
            const int expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToArray();

            double result = ZEnumerable.Average(source, arg => (int) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageintArray100()
        {            
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat((int) expected, 100).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintArray100Map()
        {
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToArray();

            double result = ZEnumerable.Average(source, arg => (int) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageintArray100Min()
        {            
            const int expected = 1;
            var source = Enumerable.Repeat((int) expected, 100).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintArray100MapMin()
        {
            const int expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToArray();

            double result = ZEnumerable.Average(source, arg => (int) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageintArray4096()
        {            
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat((int) expected, 4096).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintArray4096Map()
        {
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToArray();

            double result = ZEnumerable.Average(source, arg => (int) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageintArray4096Min()
        {            
            const int expected = 1;
            var source = Enumerable.Repeat((int) expected, 4096).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintArray4096MapMin()
        {
            const int expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToArray();

            double result = ZEnumerable.Average(source, arg => (int) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
        
              
                        
        [TestMethod]
        public void TestAverageintArrayNoOverflow()
        {
            const int expected = int.MaxValue;
            var source = Enumerable.Repeat((int) expected, 2).ToArray();
            double result = ZEnumerable.Average(source);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                
        [TestMethod]
        public void TestAverageintArrayMapNoOverflow()
        {
            const int expected = int.MaxValue;
            var source = Enumerable.Repeat(new { X = (int) expected}, 2).ToArray();
            double result = ZEnumerable.Average(source, arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                            

         
        [TestMethod]
        public void TestAverageintListNullOrEmpty()
        {        
            List<int> nullSource = null;

            try
            {
                ZEnumerable.Average(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            List<int> emptySource = new int[0].ToList();
            try
            {
                ZEnumerable.Average(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestAverageintListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<int,int>((int) arg, (int) arg)).ToList();
            Func<KeyValuePair<int, int>, int> nullMap = null;
            try
            {
                ZEnumerable.Average(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToList();
            try
            {
                ZEnumerable.Average(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Average(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }
         
                            [TestMethod]
        public void TestAverageintList1()
        {            
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat((int) expected, 1).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintList1Map()
        {
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToList();

            double result = ZEnumerable.Average(source, arg => (int) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageintList1Min()
        {            
            const int expected = 1;
            var source = Enumerable.Repeat((int) expected, 1).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintList1MapMin()
        {
            const int expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToList();

            double result = ZEnumerable.Average(source, arg => (int) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageintList2()
        {            
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat((int) expected, 2).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintList2Map()
        {
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToList();

            double result = ZEnumerable.Average(source, arg => (int) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageintList2Min()
        {            
            const int expected = 1;
            var source = Enumerable.Repeat((int) expected, 2).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintList2MapMin()
        {
            const int expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToList();

            double result = ZEnumerable.Average(source, arg => (int) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageintList3()
        {            
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat((int) expected, 3).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintList3Map()
        {
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToList();

            double result = ZEnumerable.Average(source, arg => (int) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageintList3Min()
        {            
            const int expected = 1;
            var source = Enumerable.Repeat((int) expected, 3).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintList3MapMin()
        {
            const int expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToList();

            double result = ZEnumerable.Average(source, arg => (int) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageintList4()
        {            
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat((int) expected, 4).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintList4Map()
        {
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToList();

            double result = ZEnumerable.Average(source, arg => (int) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageintList4Min()
        {            
            const int expected = 1;
            var source = Enumerable.Repeat((int) expected, 4).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintList4MapMin()
        {
            const int expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToList();

            double result = ZEnumerable.Average(source, arg => (int) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageintList100()
        {            
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat((int) expected, 100).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintList100Map()
        {
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToList();

            double result = ZEnumerable.Average(source, arg => (int) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageintList100Min()
        {            
            const int expected = 1;
            var source = Enumerable.Repeat((int) expected, 100).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintList100MapMin()
        {
            const int expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToList();

            double result = ZEnumerable.Average(source, arg => (int) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageintList4096()
        {            
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat((int) expected, 4096).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintList4096Map()
        {
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToList();

            double result = ZEnumerable.Average(source, arg => (int) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageintList4096Min()
        {            
            const int expected = 1;
            var source = Enumerable.Repeat((int) expected, 4096).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintList4096MapMin()
        {
            const int expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToList();

            double result = ZEnumerable.Average(source, arg => (int) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
        
              
                        
        [TestMethod]
        public void TestAverageintListNoOverflow()
        {
            const int expected = int.MaxValue;
            var source = Enumerable.Repeat((int) expected, 2).ToList();
            double result = ZEnumerable.Average(source);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                
        [TestMethod]
        public void TestAverageintListMapNoOverflow()
        {
            const int expected = int.MaxValue;
            var source = Enumerable.Repeat(new { X = (int) expected}, 2).ToList();
            double result = ZEnumerable.Average(source, arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                            

         
        [TestMethod]
        public void TestAverageintIListNullOrEmpty()
        {        
            IList<int> nullSource = null;

            try
            {
                ZEnumerable.Average(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            IList<int> emptySource = new int[0].ToIList();
            try
            {
                ZEnumerable.Average(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestAverageintIListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<int,int>((int) arg, (int) arg)).ToIList();
            Func<KeyValuePair<int, int>, int> nullMap = null;
            try
            {
                ZEnumerable.Average(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToIList();
            try
            {
                ZEnumerable.Average(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Average(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }
         
                            [TestMethod]
        public void TestAverageintIList1()
        {            
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat((int) expected, 1).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintIList1Map()
        {
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToIList();

            double result = ZEnumerable.Average(source, arg => (int) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageintIList1Min()
        {            
            const int expected = 1;
            var source = Enumerable.Repeat((int) expected, 1).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintIList1MapMin()
        {
            const int expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToIList();

            double result = ZEnumerable.Average(source, arg => (int) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageintIList2()
        {            
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat((int) expected, 2).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintIList2Map()
        {
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToIList();

            double result = ZEnumerable.Average(source, arg => (int) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageintIList2Min()
        {            
            const int expected = 1;
            var source = Enumerable.Repeat((int) expected, 2).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintIList2MapMin()
        {
            const int expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToIList();

            double result = ZEnumerable.Average(source, arg => (int) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageintIList3()
        {            
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat((int) expected, 3).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintIList3Map()
        {
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToIList();

            double result = ZEnumerable.Average(source, arg => (int) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageintIList3Min()
        {            
            const int expected = 1;
            var source = Enumerable.Repeat((int) expected, 3).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintIList3MapMin()
        {
            const int expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToIList();

            double result = ZEnumerable.Average(source, arg => (int) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageintIList4()
        {            
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat((int) expected, 4).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintIList4Map()
        {
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToIList();

            double result = ZEnumerable.Average(source, arg => (int) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageintIList4Min()
        {            
            const int expected = 1;
            var source = Enumerable.Repeat((int) expected, 4).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintIList4MapMin()
        {
            const int expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToIList();

            double result = ZEnumerable.Average(source, arg => (int) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageintIList100()
        {            
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat((int) expected, 100).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintIList100Map()
        {
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToIList();

            double result = ZEnumerable.Average(source, arg => (int) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageintIList100Min()
        {            
            const int expected = 1;
            var source = Enumerable.Repeat((int) expected, 100).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintIList100MapMin()
        {
            const int expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToIList();

            double result = ZEnumerable.Average(source, arg => (int) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageintIList4096()
        {            
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat((int) expected, 4096).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintIList4096Map()
        {
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToIList();

            double result = ZEnumerable.Average(source, arg => (int) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageintIList4096Min()
        {            
            const int expected = 1;
            var source = Enumerable.Repeat((int) expected, 4096).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintIList4096MapMin()
        {
            const int expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToIList();

            double result = ZEnumerable.Average(source, arg => (int) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
        
              
                        
        [TestMethod]
        public void TestAverageintIListNoOverflow()
        {
            const int expected = int.MaxValue;
            var source = Enumerable.Repeat((int) expected, 2).ToIList();
            double result = ZEnumerable.Average(source);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                
        [TestMethod]
        public void TestAverageintIListMapNoOverflow()
        {
            const int expected = int.MaxValue;
            var source = Enumerable.Repeat(new { X = (int) expected}, 2).ToIList();
            double result = ZEnumerable.Average(source, arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                                
        #endregion
    
        #region uint             
            

         
        [TestMethod]
        public void TestAverageuintArrayNullOrEmpty()
        {        
            uint[] nullSource = null;

            try
            {
                ZEnumerable.Average(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            uint[] emptySource = new uint[0].ToArray();
            try
            {
                ZEnumerable.Average(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestAverageuintArrayMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<uint,uint>((uint) arg, (uint) arg)).ToArray();
            Func<KeyValuePair<uint, uint>, uint> nullMap = null;
            try
            {
                ZEnumerable.Average(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToArray();
            try
            {
                ZEnumerable.Average(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Average(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }
         
                            [TestMethod]
        public void TestAverageuintArray1()
        {            
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat((uint) expected, 1).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintArray1Map()
        {
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToArray();

            double result = ZEnumerable.Average(source, arg => (uint) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageuintArray1Min()
        {            
            const uint expected = 1;
            var source = Enumerable.Repeat((uint) expected, 1).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintArray1MapMin()
        {
            const uint expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToArray();

            double result = ZEnumerable.Average(source, arg => (uint) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageuintArray2()
        {            
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat((uint) expected, 2).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintArray2Map()
        {
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToArray();

            double result = ZEnumerable.Average(source, arg => (uint) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageuintArray2Min()
        {            
            const uint expected = 1;
            var source = Enumerable.Repeat((uint) expected, 2).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintArray2MapMin()
        {
            const uint expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToArray();

            double result = ZEnumerable.Average(source, arg => (uint) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageuintArray3()
        {            
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat((uint) expected, 3).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintArray3Map()
        {
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToArray();

            double result = ZEnumerable.Average(source, arg => (uint) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageuintArray3Min()
        {            
            const uint expected = 1;
            var source = Enumerable.Repeat((uint) expected, 3).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintArray3MapMin()
        {
            const uint expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToArray();

            double result = ZEnumerable.Average(source, arg => (uint) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageuintArray4()
        {            
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat((uint) expected, 4).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintArray4Map()
        {
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToArray();

            double result = ZEnumerable.Average(source, arg => (uint) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageuintArray4Min()
        {            
            const uint expected = 1;
            var source = Enumerable.Repeat((uint) expected, 4).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintArray4MapMin()
        {
            const uint expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToArray();

            double result = ZEnumerable.Average(source, arg => (uint) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageuintArray100()
        {            
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat((uint) expected, 100).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintArray100Map()
        {
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToArray();

            double result = ZEnumerable.Average(source, arg => (uint) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageuintArray100Min()
        {            
            const uint expected = 1;
            var source = Enumerable.Repeat((uint) expected, 100).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintArray100MapMin()
        {
            const uint expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToArray();

            double result = ZEnumerable.Average(source, arg => (uint) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageuintArray4096()
        {            
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat((uint) expected, 4096).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintArray4096Map()
        {
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToArray();

            double result = ZEnumerable.Average(source, arg => (uint) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageuintArray4096Min()
        {            
            const uint expected = 1;
            var source = Enumerable.Repeat((uint) expected, 4096).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintArray4096MapMin()
        {
            const uint expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToArray();

            double result = ZEnumerable.Average(source, arg => (uint) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
        
              
                        
        [TestMethod]
        public void TestAverageuintArrayNoOverflow()
        {
            const uint expected = uint.MaxValue;
            var source = Enumerable.Repeat((uint) expected, 2).ToArray();
            double result = ZEnumerable.Average(source);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                
        [TestMethod]
        public void TestAverageuintArrayMapNoOverflow()
        {
            const uint expected = uint.MaxValue;
            var source = Enumerable.Repeat(new { X = (uint) expected}, 2).ToArray();
            double result = ZEnumerable.Average(source, arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                            

         
        [TestMethod]
        public void TestAverageuintListNullOrEmpty()
        {        
            List<uint> nullSource = null;

            try
            {
                ZEnumerable.Average(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            List<uint> emptySource = new uint[0].ToList();
            try
            {
                ZEnumerable.Average(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestAverageuintListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<uint,uint>((uint) arg, (uint) arg)).ToList();
            Func<KeyValuePair<uint, uint>, uint> nullMap = null;
            try
            {
                ZEnumerable.Average(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToList();
            try
            {
                ZEnumerable.Average(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Average(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }
         
                            [TestMethod]
        public void TestAverageuintList1()
        {            
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat((uint) expected, 1).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintList1Map()
        {
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToList();

            double result = ZEnumerable.Average(source, arg => (uint) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageuintList1Min()
        {            
            const uint expected = 1;
            var source = Enumerable.Repeat((uint) expected, 1).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintList1MapMin()
        {
            const uint expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToList();

            double result = ZEnumerable.Average(source, arg => (uint) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageuintList2()
        {            
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat((uint) expected, 2).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintList2Map()
        {
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToList();

            double result = ZEnumerable.Average(source, arg => (uint) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageuintList2Min()
        {            
            const uint expected = 1;
            var source = Enumerable.Repeat((uint) expected, 2).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintList2MapMin()
        {
            const uint expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToList();

            double result = ZEnumerable.Average(source, arg => (uint) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageuintList3()
        {            
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat((uint) expected, 3).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintList3Map()
        {
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToList();

            double result = ZEnumerable.Average(source, arg => (uint) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageuintList3Min()
        {            
            const uint expected = 1;
            var source = Enumerable.Repeat((uint) expected, 3).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintList3MapMin()
        {
            const uint expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToList();

            double result = ZEnumerable.Average(source, arg => (uint) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageuintList4()
        {            
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat((uint) expected, 4).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintList4Map()
        {
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToList();

            double result = ZEnumerable.Average(source, arg => (uint) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageuintList4Min()
        {            
            const uint expected = 1;
            var source = Enumerable.Repeat((uint) expected, 4).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintList4MapMin()
        {
            const uint expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToList();

            double result = ZEnumerable.Average(source, arg => (uint) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageuintList100()
        {            
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat((uint) expected, 100).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintList100Map()
        {
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToList();

            double result = ZEnumerable.Average(source, arg => (uint) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageuintList100Min()
        {            
            const uint expected = 1;
            var source = Enumerable.Repeat((uint) expected, 100).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintList100MapMin()
        {
            const uint expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToList();

            double result = ZEnumerable.Average(source, arg => (uint) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageuintList4096()
        {            
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat((uint) expected, 4096).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintList4096Map()
        {
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToList();

            double result = ZEnumerable.Average(source, arg => (uint) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageuintList4096Min()
        {            
            const uint expected = 1;
            var source = Enumerable.Repeat((uint) expected, 4096).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintList4096MapMin()
        {
            const uint expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToList();

            double result = ZEnumerable.Average(source, arg => (uint) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
        
              
                        
        [TestMethod]
        public void TestAverageuintListNoOverflow()
        {
            const uint expected = uint.MaxValue;
            var source = Enumerable.Repeat((uint) expected, 2).ToList();
            double result = ZEnumerable.Average(source);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                
        [TestMethod]
        public void TestAverageuintListMapNoOverflow()
        {
            const uint expected = uint.MaxValue;
            var source = Enumerable.Repeat(new { X = (uint) expected}, 2).ToList();
            double result = ZEnumerable.Average(source, arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                            

         
        [TestMethod]
        public void TestAverageuintIListNullOrEmpty()
        {        
            IList<uint> nullSource = null;

            try
            {
                ZEnumerable.Average(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            IList<uint> emptySource = new uint[0].ToIList();
            try
            {
                ZEnumerable.Average(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestAverageuintIListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<uint,uint>((uint) arg, (uint) arg)).ToIList();
            Func<KeyValuePair<uint, uint>, uint> nullMap = null;
            try
            {
                ZEnumerable.Average(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToIList();
            try
            {
                ZEnumerable.Average(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Average(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }
         
                            [TestMethod]
        public void TestAverageuintIList1()
        {            
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat((uint) expected, 1).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintIList1Map()
        {
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToIList();

            double result = ZEnumerable.Average(source, arg => (uint) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageuintIList1Min()
        {            
            const uint expected = 1;
            var source = Enumerable.Repeat((uint) expected, 1).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintIList1MapMin()
        {
            const uint expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToIList();

            double result = ZEnumerable.Average(source, arg => (uint) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageuintIList2()
        {            
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat((uint) expected, 2).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintIList2Map()
        {
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToIList();

            double result = ZEnumerable.Average(source, arg => (uint) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageuintIList2Min()
        {            
            const uint expected = 1;
            var source = Enumerable.Repeat((uint) expected, 2).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintIList2MapMin()
        {
            const uint expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToIList();

            double result = ZEnumerable.Average(source, arg => (uint) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageuintIList3()
        {            
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat((uint) expected, 3).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintIList3Map()
        {
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToIList();

            double result = ZEnumerable.Average(source, arg => (uint) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageuintIList3Min()
        {            
            const uint expected = 1;
            var source = Enumerable.Repeat((uint) expected, 3).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintIList3MapMin()
        {
            const uint expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToIList();

            double result = ZEnumerable.Average(source, arg => (uint) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageuintIList4()
        {            
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat((uint) expected, 4).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintIList4Map()
        {
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToIList();

            double result = ZEnumerable.Average(source, arg => (uint) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageuintIList4Min()
        {            
            const uint expected = 1;
            var source = Enumerable.Repeat((uint) expected, 4).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintIList4MapMin()
        {
            const uint expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToIList();

            double result = ZEnumerable.Average(source, arg => (uint) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageuintIList100()
        {            
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat((uint) expected, 100).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintIList100Map()
        {
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToIList();

            double result = ZEnumerable.Average(source, arg => (uint) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageuintIList100Min()
        {            
            const uint expected = 1;
            var source = Enumerable.Repeat((uint) expected, 100).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintIList100MapMin()
        {
            const uint expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToIList();

            double result = ZEnumerable.Average(source, arg => (uint) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageuintIList4096()
        {            
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat((uint) expected, 4096).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintIList4096Map()
        {
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToIList();

            double result = ZEnumerable.Average(source, arg => (uint) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageuintIList4096Min()
        {            
            const uint expected = 1;
            var source = Enumerable.Repeat((uint) expected, 4096).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintIList4096MapMin()
        {
            const uint expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToIList();

            double result = ZEnumerable.Average(source, arg => (uint) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
        
              
                        
        [TestMethod]
        public void TestAverageuintIListNoOverflow()
        {
            const uint expected = uint.MaxValue;
            var source = Enumerable.Repeat((uint) expected, 2).ToIList();
            double result = ZEnumerable.Average(source);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                
        [TestMethod]
        public void TestAverageuintIListMapNoOverflow()
        {
            const uint expected = uint.MaxValue;
            var source = Enumerable.Repeat(new { X = (uint) expected}, 2).ToIList();
            double result = ZEnumerable.Average(source, arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                                
        #endregion
    
        #region long             
            

         
        [TestMethod]
        public void TestAveragelongArrayNullOrEmpty()
        {        
            long[] nullSource = null;

            try
            {
                ZEnumerable.Average(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            long[] emptySource = new long[0].ToArray();
            try
            {
                ZEnumerable.Average(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestAveragelongArrayMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<long,long>((long) arg, (long) arg)).ToArray();
            Func<KeyValuePair<long, long>, long> nullMap = null;
            try
            {
                ZEnumerable.Average(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToArray();
            try
            {
                ZEnumerable.Average(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Average(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }
         
                            [TestMethod]
        public void TestAveragelongArray1()
        {            
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat((long) expected, 1).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongArray1Map()
        {
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToArray();

            double result = ZEnumerable.Average(source, arg => (long) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragelongArray1Min()
        {            
            const long expected = 1;
            var source = Enumerable.Repeat((long) expected, 1).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongArray1MapMin()
        {
            const long expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToArray();

            double result = ZEnumerable.Average(source, arg => (long) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragelongArray2()
        {            
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat((long) expected, 2).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongArray2Map()
        {
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToArray();

            double result = ZEnumerable.Average(source, arg => (long) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragelongArray2Min()
        {            
            const long expected = 1;
            var source = Enumerable.Repeat((long) expected, 2).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongArray2MapMin()
        {
            const long expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToArray();

            double result = ZEnumerable.Average(source, arg => (long) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragelongArray3()
        {            
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat((long) expected, 3).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongArray3Map()
        {
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToArray();

            double result = ZEnumerable.Average(source, arg => (long) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragelongArray3Min()
        {            
            const long expected = 1;
            var source = Enumerable.Repeat((long) expected, 3).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongArray3MapMin()
        {
            const long expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToArray();

            double result = ZEnumerable.Average(source, arg => (long) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragelongArray4()
        {            
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat((long) expected, 4).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongArray4Map()
        {
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToArray();

            double result = ZEnumerable.Average(source, arg => (long) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragelongArray4Min()
        {            
            const long expected = 1;
            var source = Enumerable.Repeat((long) expected, 4).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongArray4MapMin()
        {
            const long expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToArray();

            double result = ZEnumerable.Average(source, arg => (long) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragelongArray100()
        {            
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat((long) expected, 100).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongArray100Map()
        {
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToArray();

            double result = ZEnumerable.Average(source, arg => (long) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragelongArray100Min()
        {            
            const long expected = 1;
            var source = Enumerable.Repeat((long) expected, 100).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongArray100MapMin()
        {
            const long expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToArray();

            double result = ZEnumerable.Average(source, arg => (long) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragelongArray4096()
        {            
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat((long) expected, 4096).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongArray4096Map()
        {
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToArray();

            double result = ZEnumerable.Average(source, arg => (long) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragelongArray4096Min()
        {            
            const long expected = 1;
            var source = Enumerable.Repeat((long) expected, 4096).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongArray4096MapMin()
        {
            const long expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToArray();

            double result = ZEnumerable.Average(source, arg => (long) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
        
              
                        
        [TestMethod]
        public void TestAveragelongArrayNoOverflow()
        {
            const long expected = long.MaxValue;
            var source = Enumerable.Repeat((long) expected, 2).ToArray();
            double result = ZEnumerable.Average(source);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                
        [TestMethod]
        public void TestAveragelongArrayMapNoOverflow()
        {
            const long expected = long.MaxValue;
            var source = Enumerable.Repeat(new { X = (long) expected}, 2).ToArray();
            double result = ZEnumerable.Average(source, arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                            

         
        [TestMethod]
        public void TestAveragelongListNullOrEmpty()
        {        
            List<long> nullSource = null;

            try
            {
                ZEnumerable.Average(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            List<long> emptySource = new long[0].ToList();
            try
            {
                ZEnumerable.Average(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestAveragelongListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<long,long>((long) arg, (long) arg)).ToList();
            Func<KeyValuePair<long, long>, long> nullMap = null;
            try
            {
                ZEnumerable.Average(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToList();
            try
            {
                ZEnumerable.Average(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Average(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }
         
                            [TestMethod]
        public void TestAveragelongList1()
        {            
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat((long) expected, 1).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongList1Map()
        {
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToList();

            double result = ZEnumerable.Average(source, arg => (long) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragelongList1Min()
        {            
            const long expected = 1;
            var source = Enumerable.Repeat((long) expected, 1).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongList1MapMin()
        {
            const long expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToList();

            double result = ZEnumerable.Average(source, arg => (long) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragelongList2()
        {            
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat((long) expected, 2).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongList2Map()
        {
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToList();

            double result = ZEnumerable.Average(source, arg => (long) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragelongList2Min()
        {            
            const long expected = 1;
            var source = Enumerable.Repeat((long) expected, 2).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongList2MapMin()
        {
            const long expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToList();

            double result = ZEnumerable.Average(source, arg => (long) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragelongList3()
        {            
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat((long) expected, 3).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongList3Map()
        {
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToList();

            double result = ZEnumerable.Average(source, arg => (long) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragelongList3Min()
        {            
            const long expected = 1;
            var source = Enumerable.Repeat((long) expected, 3).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongList3MapMin()
        {
            const long expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToList();

            double result = ZEnumerable.Average(source, arg => (long) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragelongList4()
        {            
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat((long) expected, 4).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongList4Map()
        {
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToList();

            double result = ZEnumerable.Average(source, arg => (long) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragelongList4Min()
        {            
            const long expected = 1;
            var source = Enumerable.Repeat((long) expected, 4).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongList4MapMin()
        {
            const long expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToList();

            double result = ZEnumerable.Average(source, arg => (long) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragelongList100()
        {            
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat((long) expected, 100).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongList100Map()
        {
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToList();

            double result = ZEnumerable.Average(source, arg => (long) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragelongList100Min()
        {            
            const long expected = 1;
            var source = Enumerable.Repeat((long) expected, 100).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongList100MapMin()
        {
            const long expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToList();

            double result = ZEnumerable.Average(source, arg => (long) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragelongList4096()
        {            
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat((long) expected, 4096).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongList4096Map()
        {
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToList();

            double result = ZEnumerable.Average(source, arg => (long) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragelongList4096Min()
        {            
            const long expected = 1;
            var source = Enumerable.Repeat((long) expected, 4096).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongList4096MapMin()
        {
            const long expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToList();

            double result = ZEnumerable.Average(source, arg => (long) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
        
              
                        
        [TestMethod]
        public void TestAveragelongListNoOverflow()
        {
            const long expected = long.MaxValue;
            var source = Enumerable.Repeat((long) expected, 2).ToList();
            double result = ZEnumerable.Average(source);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                
        [TestMethod]
        public void TestAveragelongListMapNoOverflow()
        {
            const long expected = long.MaxValue;
            var source = Enumerable.Repeat(new { X = (long) expected}, 2).ToList();
            double result = ZEnumerable.Average(source, arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                            

         
        [TestMethod]
        public void TestAveragelongIListNullOrEmpty()
        {        
            IList<long> nullSource = null;

            try
            {
                ZEnumerable.Average(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            IList<long> emptySource = new long[0].ToIList();
            try
            {
                ZEnumerable.Average(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestAveragelongIListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<long,long>((long) arg, (long) arg)).ToIList();
            Func<KeyValuePair<long, long>, long> nullMap = null;
            try
            {
                ZEnumerable.Average(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToIList();
            try
            {
                ZEnumerable.Average(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Average(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }
         
                            [TestMethod]
        public void TestAveragelongIList1()
        {            
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat((long) expected, 1).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongIList1Map()
        {
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToIList();

            double result = ZEnumerable.Average(source, arg => (long) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragelongIList1Min()
        {            
            const long expected = 1;
            var source = Enumerable.Repeat((long) expected, 1).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongIList1MapMin()
        {
            const long expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToIList();

            double result = ZEnumerable.Average(source, arg => (long) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragelongIList2()
        {            
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat((long) expected, 2).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongIList2Map()
        {
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToIList();

            double result = ZEnumerable.Average(source, arg => (long) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragelongIList2Min()
        {            
            const long expected = 1;
            var source = Enumerable.Repeat((long) expected, 2).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongIList2MapMin()
        {
            const long expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToIList();

            double result = ZEnumerable.Average(source, arg => (long) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragelongIList3()
        {            
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat((long) expected, 3).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongIList3Map()
        {
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToIList();

            double result = ZEnumerable.Average(source, arg => (long) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragelongIList3Min()
        {            
            const long expected = 1;
            var source = Enumerable.Repeat((long) expected, 3).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongIList3MapMin()
        {
            const long expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToIList();

            double result = ZEnumerable.Average(source, arg => (long) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragelongIList4()
        {            
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat((long) expected, 4).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongIList4Map()
        {
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToIList();

            double result = ZEnumerable.Average(source, arg => (long) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragelongIList4Min()
        {            
            const long expected = 1;
            var source = Enumerable.Repeat((long) expected, 4).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongIList4MapMin()
        {
            const long expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToIList();

            double result = ZEnumerable.Average(source, arg => (long) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragelongIList100()
        {            
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat((long) expected, 100).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongIList100Map()
        {
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToIList();

            double result = ZEnumerable.Average(source, arg => (long) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragelongIList100Min()
        {            
            const long expected = 1;
            var source = Enumerable.Repeat((long) expected, 100).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongIList100MapMin()
        {
            const long expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToIList();

            double result = ZEnumerable.Average(source, arg => (long) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragelongIList4096()
        {            
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat((long) expected, 4096).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongIList4096Map()
        {
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToIList();

            double result = ZEnumerable.Average(source, arg => (long) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragelongIList4096Min()
        {            
            const long expected = 1;
            var source = Enumerable.Repeat((long) expected, 4096).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongIList4096MapMin()
        {
            const long expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToIList();

            double result = ZEnumerable.Average(source, arg => (long) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
        
              
                        
        [TestMethod]
        public void TestAveragelongIListNoOverflow()
        {
            const long expected = long.MaxValue;
            var source = Enumerable.Repeat((long) expected, 2).ToIList();
            double result = ZEnumerable.Average(source);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                
        [TestMethod]
        public void TestAveragelongIListMapNoOverflow()
        {
            const long expected = long.MaxValue;
            var source = Enumerable.Repeat(new { X = (long) expected}, 2).ToIList();
            double result = ZEnumerable.Average(source, arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                                
        #endregion
    
        #region ulong             
            

         
        [TestMethod]
        public void TestAverageulongArrayNullOrEmpty()
        {        
            ulong[] nullSource = null;

            try
            {
                ZEnumerable.Average(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            ulong[] emptySource = new ulong[0].ToArray();
            try
            {
                ZEnumerable.Average(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestAverageulongArrayMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<ulong,ulong>((ulong) arg, (ulong) arg)).ToArray();
            Func<KeyValuePair<ulong, ulong>, ulong> nullMap = null;
            try
            {
                ZEnumerable.Average(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToArray();
            try
            {
                ZEnumerable.Average(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Average(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }
         
                            [TestMethod]
        public void TestAverageulongArray1()
        {            
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat((ulong) expected, 1).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongArray1Map()
        {
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToArray();

            double result = ZEnumerable.Average(source, arg => (ulong) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageulongArray1Min()
        {            
            const ulong expected = 1;
            var source = Enumerable.Repeat((ulong) expected, 1).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongArray1MapMin()
        {
            const ulong expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToArray();

            double result = ZEnumerable.Average(source, arg => (ulong) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageulongArray2()
        {            
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat((ulong) expected, 2).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongArray2Map()
        {
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToArray();

            double result = ZEnumerable.Average(source, arg => (ulong) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageulongArray2Min()
        {            
            const ulong expected = 1;
            var source = Enumerable.Repeat((ulong) expected, 2).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongArray2MapMin()
        {
            const ulong expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToArray();

            double result = ZEnumerable.Average(source, arg => (ulong) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageulongArray3()
        {            
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat((ulong) expected, 3).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongArray3Map()
        {
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToArray();

            double result = ZEnumerable.Average(source, arg => (ulong) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageulongArray3Min()
        {            
            const ulong expected = 1;
            var source = Enumerable.Repeat((ulong) expected, 3).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongArray3MapMin()
        {
            const ulong expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToArray();

            double result = ZEnumerable.Average(source, arg => (ulong) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageulongArray4()
        {            
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat((ulong) expected, 4).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongArray4Map()
        {
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToArray();

            double result = ZEnumerable.Average(source, arg => (ulong) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageulongArray4Min()
        {            
            const ulong expected = 1;
            var source = Enumerable.Repeat((ulong) expected, 4).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongArray4MapMin()
        {
            const ulong expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToArray();

            double result = ZEnumerable.Average(source, arg => (ulong) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageulongArray100()
        {            
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat((ulong) expected, 100).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongArray100Map()
        {
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToArray();

            double result = ZEnumerable.Average(source, arg => (ulong) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageulongArray100Min()
        {            
            const ulong expected = 1;
            var source = Enumerable.Repeat((ulong) expected, 100).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongArray100MapMin()
        {
            const ulong expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToArray();

            double result = ZEnumerable.Average(source, arg => (ulong) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageulongArray4096()
        {            
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat((ulong) expected, 4096).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongArray4096Map()
        {
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToArray();

            double result = ZEnumerable.Average(source, arg => (ulong) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageulongArray4096Min()
        {            
            const ulong expected = 1;
            var source = Enumerable.Repeat((ulong) expected, 4096).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongArray4096MapMin()
        {
            const ulong expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToArray();

            double result = ZEnumerable.Average(source, arg => (ulong) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
        
              
                        
        [TestMethod]
        public void TestAverageulongArrayNoOverflow()
        {
            const ulong expected = ulong.MaxValue;
            var source = Enumerable.Repeat((ulong) expected, 2).ToArray();
            double result = ZEnumerable.Average(source);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                
        [TestMethod]
        public void TestAverageulongArrayMapNoOverflow()
        {
            const ulong expected = ulong.MaxValue;
            var source = Enumerable.Repeat(new { X = (ulong) expected}, 2).ToArray();
            double result = ZEnumerable.Average(source, arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                            

         
        [TestMethod]
        public void TestAverageulongListNullOrEmpty()
        {        
            List<ulong> nullSource = null;

            try
            {
                ZEnumerable.Average(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            List<ulong> emptySource = new ulong[0].ToList();
            try
            {
                ZEnumerable.Average(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestAverageulongListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<ulong,ulong>((ulong) arg, (ulong) arg)).ToList();
            Func<KeyValuePair<ulong, ulong>, ulong> nullMap = null;
            try
            {
                ZEnumerable.Average(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToList();
            try
            {
                ZEnumerable.Average(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Average(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }
         
                            [TestMethod]
        public void TestAverageulongList1()
        {            
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat((ulong) expected, 1).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongList1Map()
        {
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToList();

            double result = ZEnumerable.Average(source, arg => (ulong) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageulongList1Min()
        {            
            const ulong expected = 1;
            var source = Enumerable.Repeat((ulong) expected, 1).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongList1MapMin()
        {
            const ulong expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToList();

            double result = ZEnumerable.Average(source, arg => (ulong) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageulongList2()
        {            
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat((ulong) expected, 2).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongList2Map()
        {
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToList();

            double result = ZEnumerable.Average(source, arg => (ulong) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageulongList2Min()
        {            
            const ulong expected = 1;
            var source = Enumerable.Repeat((ulong) expected, 2).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongList2MapMin()
        {
            const ulong expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToList();

            double result = ZEnumerable.Average(source, arg => (ulong) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageulongList3()
        {            
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat((ulong) expected, 3).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongList3Map()
        {
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToList();

            double result = ZEnumerable.Average(source, arg => (ulong) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageulongList3Min()
        {            
            const ulong expected = 1;
            var source = Enumerable.Repeat((ulong) expected, 3).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongList3MapMin()
        {
            const ulong expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToList();

            double result = ZEnumerable.Average(source, arg => (ulong) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageulongList4()
        {            
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat((ulong) expected, 4).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongList4Map()
        {
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToList();

            double result = ZEnumerable.Average(source, arg => (ulong) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageulongList4Min()
        {            
            const ulong expected = 1;
            var source = Enumerable.Repeat((ulong) expected, 4).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongList4MapMin()
        {
            const ulong expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToList();

            double result = ZEnumerable.Average(source, arg => (ulong) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageulongList100()
        {            
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat((ulong) expected, 100).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongList100Map()
        {
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToList();

            double result = ZEnumerable.Average(source, arg => (ulong) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageulongList100Min()
        {            
            const ulong expected = 1;
            var source = Enumerable.Repeat((ulong) expected, 100).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongList100MapMin()
        {
            const ulong expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToList();

            double result = ZEnumerable.Average(source, arg => (ulong) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageulongList4096()
        {            
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat((ulong) expected, 4096).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongList4096Map()
        {
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToList();

            double result = ZEnumerable.Average(source, arg => (ulong) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageulongList4096Min()
        {            
            const ulong expected = 1;
            var source = Enumerable.Repeat((ulong) expected, 4096).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongList4096MapMin()
        {
            const ulong expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToList();

            double result = ZEnumerable.Average(source, arg => (ulong) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
        
              
                        
        [TestMethod]
        public void TestAverageulongListNoOverflow()
        {
            const ulong expected = ulong.MaxValue;
            var source = Enumerable.Repeat((ulong) expected, 2).ToList();
            double result = ZEnumerable.Average(source);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                
        [TestMethod]
        public void TestAverageulongListMapNoOverflow()
        {
            const ulong expected = ulong.MaxValue;
            var source = Enumerable.Repeat(new { X = (ulong) expected}, 2).ToList();
            double result = ZEnumerable.Average(source, arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                            

         
        [TestMethod]
        public void TestAverageulongIListNullOrEmpty()
        {        
            IList<ulong> nullSource = null;

            try
            {
                ZEnumerable.Average(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            IList<ulong> emptySource = new ulong[0].ToIList();
            try
            {
                ZEnumerable.Average(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestAverageulongIListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<ulong,ulong>((ulong) arg, (ulong) arg)).ToIList();
            Func<KeyValuePair<ulong, ulong>, ulong> nullMap = null;
            try
            {
                ZEnumerable.Average(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToIList();
            try
            {
                ZEnumerable.Average(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Average(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }
         
                            [TestMethod]
        public void TestAverageulongIList1()
        {            
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat((ulong) expected, 1).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongIList1Map()
        {
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToIList();

            double result = ZEnumerable.Average(source, arg => (ulong) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageulongIList1Min()
        {            
            const ulong expected = 1;
            var source = Enumerable.Repeat((ulong) expected, 1).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongIList1MapMin()
        {
            const ulong expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToIList();

            double result = ZEnumerable.Average(source, arg => (ulong) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageulongIList2()
        {            
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat((ulong) expected, 2).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongIList2Map()
        {
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToIList();

            double result = ZEnumerable.Average(source, arg => (ulong) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageulongIList2Min()
        {            
            const ulong expected = 1;
            var source = Enumerable.Repeat((ulong) expected, 2).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongIList2MapMin()
        {
            const ulong expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToIList();

            double result = ZEnumerable.Average(source, arg => (ulong) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageulongIList3()
        {            
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat((ulong) expected, 3).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongIList3Map()
        {
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToIList();

            double result = ZEnumerable.Average(source, arg => (ulong) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageulongIList3Min()
        {            
            const ulong expected = 1;
            var source = Enumerable.Repeat((ulong) expected, 3).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongIList3MapMin()
        {
            const ulong expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToIList();

            double result = ZEnumerable.Average(source, arg => (ulong) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageulongIList4()
        {            
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat((ulong) expected, 4).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongIList4Map()
        {
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToIList();

            double result = ZEnumerable.Average(source, arg => (ulong) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageulongIList4Min()
        {            
            const ulong expected = 1;
            var source = Enumerable.Repeat((ulong) expected, 4).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongIList4MapMin()
        {
            const ulong expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToIList();

            double result = ZEnumerable.Average(source, arg => (ulong) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageulongIList100()
        {            
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat((ulong) expected, 100).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongIList100Map()
        {
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToIList();

            double result = ZEnumerable.Average(source, arg => (ulong) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageulongIList100Min()
        {            
            const ulong expected = 1;
            var source = Enumerable.Repeat((ulong) expected, 100).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongIList100MapMin()
        {
            const ulong expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToIList();

            double result = ZEnumerable.Average(source, arg => (ulong) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageulongIList4096()
        {            
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat((ulong) expected, 4096).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongIList4096Map()
        {
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToIList();

            double result = ZEnumerable.Average(source, arg => (ulong) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageulongIList4096Min()
        {            
            const ulong expected = 1;
            var source = Enumerable.Repeat((ulong) expected, 4096).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongIList4096MapMin()
        {
            const ulong expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToIList();

            double result = ZEnumerable.Average(source, arg => (ulong) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
        
              
                        
        [TestMethod]
        public void TestAverageulongIListNoOverflow()
        {
            const ulong expected = ulong.MaxValue;
            var source = Enumerable.Repeat((ulong) expected, 2).ToIList();
            double result = ZEnumerable.Average(source);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                
        [TestMethod]
        public void TestAverageulongIListMapNoOverflow()
        {
            const ulong expected = ulong.MaxValue;
            var source = Enumerable.Repeat(new { X = (ulong) expected}, 2).ToIList();
            double result = ZEnumerable.Average(source, arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                                
        #endregion
    
        #region float             
            

         
        [TestMethod]
        public void TestAveragefloatArrayNullOrEmpty()
        {        
            float[] nullSource = null;

            try
            {
                ZEnumerable.Average(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            float[] emptySource = new float[0].ToArray();
            try
            {
                ZEnumerable.Average(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestAveragefloatArrayMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<float,float>((float) arg, (float) arg)).ToArray();
            Func<KeyValuePair<float, float>, float> nullMap = null;
            try
            {
                ZEnumerable.Average(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToArray();
            try
            {
                ZEnumerable.Average(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Average(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }
         
                            [TestMethod]
        public void TestAveragefloatArray1()
        {            
            const float expected = float.MaxValue/10*9;
            var source = Enumerable.Repeat((float) expected, 1).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatArray1Map()
        {
            const float expected = float.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToArray();

            double result = ZEnumerable.Average(source, arg => (float) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragefloatArray1Min()
        {            
            const float expected = 1;
            var source = Enumerable.Repeat((float) expected, 1).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatArray1MapMin()
        {
            const float expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToArray();

            double result = ZEnumerable.Average(source, arg => (float) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragefloatArray2()
        {            
            const float expected = float.MaxValue/10*9;
            var source = Enumerable.Repeat((float) expected, 2).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatArray2Map()
        {
            const float expected = float.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToArray();

            double result = ZEnumerable.Average(source, arg => (float) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragefloatArray2Min()
        {            
            const float expected = 1;
            var source = Enumerable.Repeat((float) expected, 2).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatArray2MapMin()
        {
            const float expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToArray();

            double result = ZEnumerable.Average(source, arg => (float) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragefloatArray3()
        {            
            const float expected = float.MaxValue/10*9;
            var source = Enumerable.Repeat((float) expected, 3).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatArray3Map()
        {
            const float expected = float.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToArray();

            double result = ZEnumerable.Average(source, arg => (float) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragefloatArray3Min()
        {            
            const float expected = 1;
            var source = Enumerable.Repeat((float) expected, 3).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatArray3MapMin()
        {
            const float expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToArray();

            double result = ZEnumerable.Average(source, arg => (float) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragefloatArray4()
        {            
            const float expected = float.MaxValue/10*9;
            var source = Enumerable.Repeat((float) expected, 4).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatArray4Map()
        {
            const float expected = float.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToArray();

            double result = ZEnumerable.Average(source, arg => (float) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragefloatArray4Min()
        {            
            const float expected = 1;
            var source = Enumerable.Repeat((float) expected, 4).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatArray4MapMin()
        {
            const float expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToArray();

            double result = ZEnumerable.Average(source, arg => (float) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragefloatArray100()
        {            
            const float expected = float.MaxValue/10*9;
            var source = Enumerable.Repeat((float) expected, 100).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatArray100Map()
        {
            const float expected = float.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToArray();

            double result = ZEnumerable.Average(source, arg => (float) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragefloatArray100Min()
        {            
            const float expected = 1;
            var source = Enumerable.Repeat((float) expected, 100).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatArray100MapMin()
        {
            const float expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToArray();

            double result = ZEnumerable.Average(source, arg => (float) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragefloatArray4096()
        {            
            const float expected = float.MaxValue/10*9;
            var source = Enumerable.Repeat((float) expected, 4096).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatArray4096Map()
        {
            const float expected = float.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToArray();

            double result = ZEnumerable.Average(source, arg => (float) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragefloatArray4096Min()
        {            
            const float expected = 1;
            var source = Enumerable.Repeat((float) expected, 4096).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatArray4096MapMin()
        {
            const float expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToArray();

            double result = ZEnumerable.Average(source, arg => (float) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
        
                    

         
        [TestMethod]
        public void TestAveragefloatListNullOrEmpty()
        {        
            List<float> nullSource = null;

            try
            {
                ZEnumerable.Average(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            List<float> emptySource = new float[0].ToList();
            try
            {
                ZEnumerable.Average(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestAveragefloatListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<float,float>((float) arg, (float) arg)).ToList();
            Func<KeyValuePair<float, float>, float> nullMap = null;
            try
            {
                ZEnumerable.Average(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToList();
            try
            {
                ZEnumerable.Average(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Average(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }
         
                            [TestMethod]
        public void TestAveragefloatList1()
        {            
            const float expected = float.MaxValue/10*9;
            var source = Enumerable.Repeat((float) expected, 1).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatList1Map()
        {
            const float expected = float.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToList();

            double result = ZEnumerable.Average(source, arg => (float) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragefloatList1Min()
        {            
            const float expected = 1;
            var source = Enumerable.Repeat((float) expected, 1).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatList1MapMin()
        {
            const float expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToList();

            double result = ZEnumerable.Average(source, arg => (float) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragefloatList2()
        {            
            const float expected = float.MaxValue/10*9;
            var source = Enumerable.Repeat((float) expected, 2).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatList2Map()
        {
            const float expected = float.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToList();

            double result = ZEnumerable.Average(source, arg => (float) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragefloatList2Min()
        {            
            const float expected = 1;
            var source = Enumerable.Repeat((float) expected, 2).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatList2MapMin()
        {
            const float expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToList();

            double result = ZEnumerable.Average(source, arg => (float) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragefloatList3()
        {            
            const float expected = float.MaxValue/10*9;
            var source = Enumerable.Repeat((float) expected, 3).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatList3Map()
        {
            const float expected = float.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToList();

            double result = ZEnumerable.Average(source, arg => (float) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragefloatList3Min()
        {            
            const float expected = 1;
            var source = Enumerable.Repeat((float) expected, 3).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatList3MapMin()
        {
            const float expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToList();

            double result = ZEnumerable.Average(source, arg => (float) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragefloatList4()
        {            
            const float expected = float.MaxValue/10*9;
            var source = Enumerable.Repeat((float) expected, 4).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatList4Map()
        {
            const float expected = float.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToList();

            double result = ZEnumerable.Average(source, arg => (float) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragefloatList4Min()
        {            
            const float expected = 1;
            var source = Enumerable.Repeat((float) expected, 4).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatList4MapMin()
        {
            const float expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToList();

            double result = ZEnumerable.Average(source, arg => (float) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragefloatList100()
        {            
            const float expected = float.MaxValue/10*9;
            var source = Enumerable.Repeat((float) expected, 100).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatList100Map()
        {
            const float expected = float.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToList();

            double result = ZEnumerable.Average(source, arg => (float) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragefloatList100Min()
        {            
            const float expected = 1;
            var source = Enumerable.Repeat((float) expected, 100).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatList100MapMin()
        {
            const float expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToList();

            double result = ZEnumerable.Average(source, arg => (float) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragefloatList4096()
        {            
            const float expected = float.MaxValue/10*9;
            var source = Enumerable.Repeat((float) expected, 4096).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatList4096Map()
        {
            const float expected = float.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToList();

            double result = ZEnumerable.Average(source, arg => (float) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragefloatList4096Min()
        {            
            const float expected = 1;
            var source = Enumerable.Repeat((float) expected, 4096).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatList4096MapMin()
        {
            const float expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToList();

            double result = ZEnumerable.Average(source, arg => (float) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
        
                    

         
        [TestMethod]
        public void TestAveragefloatIListNullOrEmpty()
        {        
            IList<float> nullSource = null;

            try
            {
                ZEnumerable.Average(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            IList<float> emptySource = new float[0].ToIList();
            try
            {
                ZEnumerable.Average(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestAveragefloatIListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<float,float>((float) arg, (float) arg)).ToIList();
            Func<KeyValuePair<float, float>, float> nullMap = null;
            try
            {
                ZEnumerable.Average(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToIList();
            try
            {
                ZEnumerable.Average(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Average(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }
         
                            [TestMethod]
        public void TestAveragefloatIList1()
        {            
            const float expected = float.MaxValue/10*9;
            var source = Enumerable.Repeat((float) expected, 1).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatIList1Map()
        {
            const float expected = float.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToIList();

            double result = ZEnumerable.Average(source, arg => (float) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragefloatIList1Min()
        {            
            const float expected = 1;
            var source = Enumerable.Repeat((float) expected, 1).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatIList1MapMin()
        {
            const float expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToIList();

            double result = ZEnumerable.Average(source, arg => (float) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragefloatIList2()
        {            
            const float expected = float.MaxValue/10*9;
            var source = Enumerable.Repeat((float) expected, 2).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatIList2Map()
        {
            const float expected = float.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToIList();

            double result = ZEnumerable.Average(source, arg => (float) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragefloatIList2Min()
        {            
            const float expected = 1;
            var source = Enumerable.Repeat((float) expected, 2).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatIList2MapMin()
        {
            const float expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToIList();

            double result = ZEnumerable.Average(source, arg => (float) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragefloatIList3()
        {            
            const float expected = float.MaxValue/10*9;
            var source = Enumerable.Repeat((float) expected, 3).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatIList3Map()
        {
            const float expected = float.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToIList();

            double result = ZEnumerable.Average(source, arg => (float) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragefloatIList3Min()
        {            
            const float expected = 1;
            var source = Enumerable.Repeat((float) expected, 3).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatIList3MapMin()
        {
            const float expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToIList();

            double result = ZEnumerable.Average(source, arg => (float) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragefloatIList4()
        {            
            const float expected = float.MaxValue/10*9;
            var source = Enumerable.Repeat((float) expected, 4).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatIList4Map()
        {
            const float expected = float.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToIList();

            double result = ZEnumerable.Average(source, arg => (float) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragefloatIList4Min()
        {            
            const float expected = 1;
            var source = Enumerable.Repeat((float) expected, 4).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatIList4MapMin()
        {
            const float expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToIList();

            double result = ZEnumerable.Average(source, arg => (float) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragefloatIList100()
        {            
            const float expected = float.MaxValue/10*9;
            var source = Enumerable.Repeat((float) expected, 100).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatIList100Map()
        {
            const float expected = float.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToIList();

            double result = ZEnumerable.Average(source, arg => (float) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragefloatIList100Min()
        {            
            const float expected = 1;
            var source = Enumerable.Repeat((float) expected, 100).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatIList100MapMin()
        {
            const float expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToIList();

            double result = ZEnumerable.Average(source, arg => (float) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragefloatIList4096()
        {            
            const float expected = float.MaxValue/10*9;
            var source = Enumerable.Repeat((float) expected, 4096).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatIList4096Map()
        {
            const float expected = float.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToIList();

            double result = ZEnumerable.Average(source, arg => (float) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragefloatIList4096Min()
        {            
            const float expected = 1;
            var source = Enumerable.Repeat((float) expected, 4096).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatIList4096MapMin()
        {
            const float expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToIList();

            double result = ZEnumerable.Average(source, arg => (float) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
        
                        
        #endregion
    
        #region double             
            

         
        [TestMethod]
        public void TestAveragedoubleArrayNullOrEmpty()
        {        
            double[] nullSource = null;

            try
            {
                ZEnumerable.Average(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            double[] emptySource = new double[0].ToArray();
            try
            {
                ZEnumerable.Average(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestAveragedoubleArrayMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<double,double>((double) arg, (double) arg)).ToArray();
            Func<KeyValuePair<double, double>, double> nullMap = null;
            try
            {
                ZEnumerable.Average(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToArray();
            try
            {
                ZEnumerable.Average(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Average(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }
         
                            [TestMethod]
        public void TestAveragedoubleArray1()
        {            
            const double expected = double.MaxValue/10*9;
            var source = Enumerable.Repeat((double) expected, 1).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleArray1Map()
        {
            const double expected = double.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToArray();

            double result = ZEnumerable.Average(source, arg => (double) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragedoubleArray1Min()
        {            
            const double expected = 1;
            var source = Enumerable.Repeat((double) expected, 1).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleArray1MapMin()
        {
            const double expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToArray();

            double result = ZEnumerable.Average(source, arg => (double) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragedoubleArray2()
        {            
            const double expected = double.MaxValue/10*9;
            var source = Enumerable.Repeat((double) expected, 2).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleArray2Map()
        {
            const double expected = double.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToArray();

            double result = ZEnumerable.Average(source, arg => (double) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragedoubleArray2Min()
        {            
            const double expected = 1;
            var source = Enumerable.Repeat((double) expected, 2).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleArray2MapMin()
        {
            const double expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToArray();

            double result = ZEnumerable.Average(source, arg => (double) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragedoubleArray3()
        {            
            const double expected = double.MaxValue/10*9;
            var source = Enumerable.Repeat((double) expected, 3).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleArray3Map()
        {
            const double expected = double.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToArray();

            double result = ZEnumerable.Average(source, arg => (double) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragedoubleArray3Min()
        {            
            const double expected = 1;
            var source = Enumerable.Repeat((double) expected, 3).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleArray3MapMin()
        {
            const double expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToArray();

            double result = ZEnumerable.Average(source, arg => (double) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragedoubleArray4()
        {            
            const double expected = double.MaxValue/10*9;
            var source = Enumerable.Repeat((double) expected, 4).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleArray4Map()
        {
            const double expected = double.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToArray();

            double result = ZEnumerable.Average(source, arg => (double) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragedoubleArray4Min()
        {            
            const double expected = 1;
            var source = Enumerable.Repeat((double) expected, 4).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleArray4MapMin()
        {
            const double expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToArray();

            double result = ZEnumerable.Average(source, arg => (double) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragedoubleArray100()
        {            
            const double expected = double.MaxValue/10*9;
            var source = Enumerable.Repeat((double) expected, 100).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleArray100Map()
        {
            const double expected = double.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToArray();

            double result = ZEnumerable.Average(source, arg => (double) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragedoubleArray100Min()
        {            
            const double expected = 1;
            var source = Enumerable.Repeat((double) expected, 100).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleArray100MapMin()
        {
            const double expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToArray();

            double result = ZEnumerable.Average(source, arg => (double) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragedoubleArray4096()
        {            
            const double expected = double.MaxValue/10*9;
            var source = Enumerable.Repeat((double) expected, 4096).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleArray4096Map()
        {
            const double expected = double.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToArray();

            double result = ZEnumerable.Average(source, arg => (double) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragedoubleArray4096Min()
        {            
            const double expected = 1;
            var source = Enumerable.Repeat((double) expected, 4096).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleArray4096MapMin()
        {
            const double expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToArray();

            double result = ZEnumerable.Average(source, arg => (double) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
        
                    

         
        [TestMethod]
        public void TestAveragedoubleListNullOrEmpty()
        {        
            List<double> nullSource = null;

            try
            {
                ZEnumerable.Average(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            List<double> emptySource = new double[0].ToList();
            try
            {
                ZEnumerable.Average(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestAveragedoubleListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<double,double>((double) arg, (double) arg)).ToList();
            Func<KeyValuePair<double, double>, double> nullMap = null;
            try
            {
                ZEnumerable.Average(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToList();
            try
            {
                ZEnumerable.Average(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Average(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }
         
                            [TestMethod]
        public void TestAveragedoubleList1()
        {            
            const double expected = double.MaxValue/10*9;
            var source = Enumerable.Repeat((double) expected, 1).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleList1Map()
        {
            const double expected = double.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToList();

            double result = ZEnumerable.Average(source, arg => (double) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragedoubleList1Min()
        {            
            const double expected = 1;
            var source = Enumerable.Repeat((double) expected, 1).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleList1MapMin()
        {
            const double expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToList();

            double result = ZEnumerable.Average(source, arg => (double) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragedoubleList2()
        {            
            const double expected = double.MaxValue/10*9;
            var source = Enumerable.Repeat((double) expected, 2).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleList2Map()
        {
            const double expected = double.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToList();

            double result = ZEnumerable.Average(source, arg => (double) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragedoubleList2Min()
        {            
            const double expected = 1;
            var source = Enumerable.Repeat((double) expected, 2).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleList2MapMin()
        {
            const double expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToList();

            double result = ZEnumerable.Average(source, arg => (double) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragedoubleList3()
        {            
            const double expected = double.MaxValue/10*9;
            var source = Enumerable.Repeat((double) expected, 3).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleList3Map()
        {
            const double expected = double.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToList();

            double result = ZEnumerable.Average(source, arg => (double) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragedoubleList3Min()
        {            
            const double expected = 1;
            var source = Enumerable.Repeat((double) expected, 3).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleList3MapMin()
        {
            const double expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToList();

            double result = ZEnumerable.Average(source, arg => (double) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragedoubleList4()
        {            
            const double expected = double.MaxValue/10*9;
            var source = Enumerable.Repeat((double) expected, 4).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleList4Map()
        {
            const double expected = double.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToList();

            double result = ZEnumerable.Average(source, arg => (double) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragedoubleList4Min()
        {            
            const double expected = 1;
            var source = Enumerable.Repeat((double) expected, 4).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleList4MapMin()
        {
            const double expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToList();

            double result = ZEnumerable.Average(source, arg => (double) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragedoubleList100()
        {            
            const double expected = double.MaxValue/10*9;
            var source = Enumerable.Repeat((double) expected, 100).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleList100Map()
        {
            const double expected = double.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToList();

            double result = ZEnumerable.Average(source, arg => (double) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragedoubleList100Min()
        {            
            const double expected = 1;
            var source = Enumerable.Repeat((double) expected, 100).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleList100MapMin()
        {
            const double expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToList();

            double result = ZEnumerable.Average(source, arg => (double) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragedoubleList4096()
        {            
            const double expected = double.MaxValue/10*9;
            var source = Enumerable.Repeat((double) expected, 4096).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleList4096Map()
        {
            const double expected = double.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToList();

            double result = ZEnumerable.Average(source, arg => (double) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragedoubleList4096Min()
        {            
            const double expected = 1;
            var source = Enumerable.Repeat((double) expected, 4096).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleList4096MapMin()
        {
            const double expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToList();

            double result = ZEnumerable.Average(source, arg => (double) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
        
                    

         
        [TestMethod]
        public void TestAveragedoubleIListNullOrEmpty()
        {        
            IList<double> nullSource = null;

            try
            {
                ZEnumerable.Average(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            IList<double> emptySource = new double[0].ToIList();
            try
            {
                ZEnumerable.Average(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestAveragedoubleIListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<double,double>((double) arg, (double) arg)).ToIList();
            Func<KeyValuePair<double, double>, double> nullMap = null;
            try
            {
                ZEnumerable.Average(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToIList();
            try
            {
                ZEnumerable.Average(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Average(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }
         
                            [TestMethod]
        public void TestAveragedoubleIList1()
        {            
            const double expected = double.MaxValue/10*9;
            var source = Enumerable.Repeat((double) expected, 1).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleIList1Map()
        {
            const double expected = double.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToIList();

            double result = ZEnumerable.Average(source, arg => (double) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragedoubleIList1Min()
        {            
            const double expected = 1;
            var source = Enumerable.Repeat((double) expected, 1).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleIList1MapMin()
        {
            const double expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToIList();

            double result = ZEnumerable.Average(source, arg => (double) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragedoubleIList2()
        {            
            const double expected = double.MaxValue/10*9;
            var source = Enumerable.Repeat((double) expected, 2).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleIList2Map()
        {
            const double expected = double.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToIList();

            double result = ZEnumerable.Average(source, arg => (double) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragedoubleIList2Min()
        {            
            const double expected = 1;
            var source = Enumerable.Repeat((double) expected, 2).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleIList2MapMin()
        {
            const double expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToIList();

            double result = ZEnumerable.Average(source, arg => (double) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragedoubleIList3()
        {            
            const double expected = double.MaxValue/10*9;
            var source = Enumerable.Repeat((double) expected, 3).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleIList3Map()
        {
            const double expected = double.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToIList();

            double result = ZEnumerable.Average(source, arg => (double) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragedoubleIList3Min()
        {            
            const double expected = 1;
            var source = Enumerable.Repeat((double) expected, 3).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleIList3MapMin()
        {
            const double expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToIList();

            double result = ZEnumerable.Average(source, arg => (double) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragedoubleIList4()
        {            
            const double expected = double.MaxValue/10*9;
            var source = Enumerable.Repeat((double) expected, 4).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleIList4Map()
        {
            const double expected = double.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToIList();

            double result = ZEnumerable.Average(source, arg => (double) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragedoubleIList4Min()
        {            
            const double expected = 1;
            var source = Enumerable.Repeat((double) expected, 4).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleIList4MapMin()
        {
            const double expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToIList();

            double result = ZEnumerable.Average(source, arg => (double) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragedoubleIList100()
        {            
            const double expected = double.MaxValue/10*9;
            var source = Enumerable.Repeat((double) expected, 100).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleIList100Map()
        {
            const double expected = double.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToIList();

            double result = ZEnumerable.Average(source, arg => (double) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragedoubleIList100Min()
        {            
            const double expected = 1;
            var source = Enumerable.Repeat((double) expected, 100).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleIList100MapMin()
        {
            const double expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToIList();

            double result = ZEnumerable.Average(source, arg => (double) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragedoubleIList4096()
        {            
            const double expected = double.MaxValue/10*9;
            var source = Enumerable.Repeat((double) expected, 4096).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleIList4096Map()
        {
            const double expected = double.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToIList();

            double result = ZEnumerable.Average(source, arg => (double) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragedoubleIList4096Min()
        {            
            const double expected = 1;
            var source = Enumerable.Repeat((double) expected, 4096).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleIList4096MapMin()
        {
            const double expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToIList();

            double result = ZEnumerable.Average(source, arg => (double) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
        
                        
        #endregion
    
        #region decimal             
            

         
        [TestMethod]
        public void TestAveragedecimalArrayNullOrEmpty()
        {        
            decimal[] nullSource = null;

            try
            {
                ZEnumerable.Average(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            decimal[] emptySource = new decimal[0].ToArray();
            try
            {
                ZEnumerable.Average(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestAveragedecimalArrayMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<decimal,decimal>((decimal) arg, (decimal) arg)).ToArray();
            Func<KeyValuePair<decimal, decimal>, decimal> nullMap = null;
            try
            {
                ZEnumerable.Average(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToArray();
            try
            {
                ZEnumerable.Average(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Average(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }
         
                            [TestMethod]
        public void TestAveragedecimalArray1()
        {            
            const decimal expected = decimal.MaxValue/10*9;
            var source = Enumerable.Repeat((decimal) expected, 1).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalArray1Map()
        {
            const decimal expected = decimal.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToArray();

            double result = ZEnumerable.Average(source, arg => (decimal) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragedecimalArray1Min()
        {            
            const decimal expected = 1;
            var source = Enumerable.Repeat((decimal) expected, 1).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalArray1MapMin()
        {
            const decimal expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToArray();

            double result = ZEnumerable.Average(source, arg => (decimal) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragedecimalArray2()
        {            
            const decimal expected = decimal.MaxValue/10*9;
            var source = Enumerable.Repeat((decimal) expected, 2).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalArray2Map()
        {
            const decimal expected = decimal.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToArray();

            double result = ZEnumerable.Average(source, arg => (decimal) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragedecimalArray2Min()
        {            
            const decimal expected = 1;
            var source = Enumerable.Repeat((decimal) expected, 2).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalArray2MapMin()
        {
            const decimal expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToArray();

            double result = ZEnumerable.Average(source, arg => (decimal) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragedecimalArray3()
        {            
            const decimal expected = decimal.MaxValue/10*9;
            var source = Enumerable.Repeat((decimal) expected, 3).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalArray3Map()
        {
            const decimal expected = decimal.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToArray();

            double result = ZEnumerable.Average(source, arg => (decimal) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragedecimalArray3Min()
        {            
            const decimal expected = 1;
            var source = Enumerable.Repeat((decimal) expected, 3).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalArray3MapMin()
        {
            const decimal expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToArray();

            double result = ZEnumerable.Average(source, arg => (decimal) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragedecimalArray4()
        {            
            const decimal expected = decimal.MaxValue/10*9;
            var source = Enumerable.Repeat((decimal) expected, 4).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalArray4Map()
        {
            const decimal expected = decimal.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToArray();

            double result = ZEnumerable.Average(source, arg => (decimal) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragedecimalArray4Min()
        {            
            const decimal expected = 1;
            var source = Enumerable.Repeat((decimal) expected, 4).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalArray4MapMin()
        {
            const decimal expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToArray();

            double result = ZEnumerable.Average(source, arg => (decimal) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragedecimalArray100()
        {            
            const decimal expected = decimal.MaxValue/10*9;
            var source = Enumerable.Repeat((decimal) expected, 100).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalArray100Map()
        {
            const decimal expected = decimal.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToArray();

            double result = ZEnumerable.Average(source, arg => (decimal) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragedecimalArray100Min()
        {            
            const decimal expected = 1;
            var source = Enumerable.Repeat((decimal) expected, 100).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalArray100MapMin()
        {
            const decimal expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToArray();

            double result = ZEnumerable.Average(source, arg => (decimal) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragedecimalArray4096()
        {            
            const decimal expected = decimal.MaxValue/10*9;
            var source = Enumerable.Repeat((decimal) expected, 4096).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalArray4096Map()
        {
            const decimal expected = decimal.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToArray();

            double result = ZEnumerable.Average(source, arg => (decimal) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragedecimalArray4096Min()
        {            
            const decimal expected = 1;
            var source = Enumerable.Repeat((decimal) expected, 4096).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalArray4096MapMin()
        {
            const decimal expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToArray();

            double result = ZEnumerable.Average(source, arg => (decimal) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
        
                    

         
        [TestMethod]
        public void TestAveragedecimalListNullOrEmpty()
        {        
            List<decimal> nullSource = null;

            try
            {
                ZEnumerable.Average(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            List<decimal> emptySource = new decimal[0].ToList();
            try
            {
                ZEnumerable.Average(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestAveragedecimalListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<decimal,decimal>((decimal) arg, (decimal) arg)).ToList();
            Func<KeyValuePair<decimal, decimal>, decimal> nullMap = null;
            try
            {
                ZEnumerable.Average(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToList();
            try
            {
                ZEnumerable.Average(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Average(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }
         
                            [TestMethod]
        public void TestAveragedecimalList1()
        {            
            const decimal expected = decimal.MaxValue/10*9;
            var source = Enumerable.Repeat((decimal) expected, 1).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalList1Map()
        {
            const decimal expected = decimal.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToList();

            double result = ZEnumerable.Average(source, arg => (decimal) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragedecimalList1Min()
        {            
            const decimal expected = 1;
            var source = Enumerable.Repeat((decimal) expected, 1).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalList1MapMin()
        {
            const decimal expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToList();

            double result = ZEnumerable.Average(source, arg => (decimal) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragedecimalList2()
        {            
            const decimal expected = decimal.MaxValue/10*9;
            var source = Enumerable.Repeat((decimal) expected, 2).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalList2Map()
        {
            const decimal expected = decimal.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToList();

            double result = ZEnumerable.Average(source, arg => (decimal) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragedecimalList2Min()
        {            
            const decimal expected = 1;
            var source = Enumerable.Repeat((decimal) expected, 2).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalList2MapMin()
        {
            const decimal expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToList();

            double result = ZEnumerable.Average(source, arg => (decimal) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragedecimalList3()
        {            
            const decimal expected = decimal.MaxValue/10*9;
            var source = Enumerable.Repeat((decimal) expected, 3).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalList3Map()
        {
            const decimal expected = decimal.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToList();

            double result = ZEnumerable.Average(source, arg => (decimal) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragedecimalList3Min()
        {            
            const decimal expected = 1;
            var source = Enumerable.Repeat((decimal) expected, 3).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalList3MapMin()
        {
            const decimal expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToList();

            double result = ZEnumerable.Average(source, arg => (decimal) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragedecimalList4()
        {            
            const decimal expected = decimal.MaxValue/10*9;
            var source = Enumerable.Repeat((decimal) expected, 4).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalList4Map()
        {
            const decimal expected = decimal.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToList();

            double result = ZEnumerable.Average(source, arg => (decimal) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragedecimalList4Min()
        {            
            const decimal expected = 1;
            var source = Enumerable.Repeat((decimal) expected, 4).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalList4MapMin()
        {
            const decimal expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToList();

            double result = ZEnumerable.Average(source, arg => (decimal) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragedecimalList100()
        {            
            const decimal expected = decimal.MaxValue/10*9;
            var source = Enumerable.Repeat((decimal) expected, 100).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalList100Map()
        {
            const decimal expected = decimal.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToList();

            double result = ZEnumerable.Average(source, arg => (decimal) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragedecimalList100Min()
        {            
            const decimal expected = 1;
            var source = Enumerable.Repeat((decimal) expected, 100).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalList100MapMin()
        {
            const decimal expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToList();

            double result = ZEnumerable.Average(source, arg => (decimal) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragedecimalList4096()
        {            
            const decimal expected = decimal.MaxValue/10*9;
            var source = Enumerable.Repeat((decimal) expected, 4096).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalList4096Map()
        {
            const decimal expected = decimal.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToList();

            double result = ZEnumerable.Average(source, arg => (decimal) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragedecimalList4096Min()
        {            
            const decimal expected = 1;
            var source = Enumerable.Repeat((decimal) expected, 4096).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalList4096MapMin()
        {
            const decimal expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToList();

            double result = ZEnumerable.Average(source, arg => (decimal) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
        
                    

         
        [TestMethod]
        public void TestAveragedecimalIListNullOrEmpty()
        {        
            IList<decimal> nullSource = null;

            try
            {
                ZEnumerable.Average(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            IList<decimal> emptySource = new decimal[0].ToIList();
            try
            {
                ZEnumerable.Average(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestAveragedecimalIListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<decimal,decimal>((decimal) arg, (decimal) arg)).ToIList();
            Func<KeyValuePair<decimal, decimal>, decimal> nullMap = null;
            try
            {
                ZEnumerable.Average(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToIList();
            try
            {
                ZEnumerable.Average(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Average(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }
         
                            [TestMethod]
        public void TestAveragedecimalIList1()
        {            
            const decimal expected = decimal.MaxValue/10*9;
            var source = Enumerable.Repeat((decimal) expected, 1).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalIList1Map()
        {
            const decimal expected = decimal.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToIList();

            double result = ZEnumerable.Average(source, arg => (decimal) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragedecimalIList1Min()
        {            
            const decimal expected = 1;
            var source = Enumerable.Repeat((decimal) expected, 1).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalIList1MapMin()
        {
            const decimal expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToIList();

            double result = ZEnumerable.Average(source, arg => (decimal) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragedecimalIList2()
        {            
            const decimal expected = decimal.MaxValue/10*9;
            var source = Enumerable.Repeat((decimal) expected, 2).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalIList2Map()
        {
            const decimal expected = decimal.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToIList();

            double result = ZEnumerable.Average(source, arg => (decimal) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragedecimalIList2Min()
        {            
            const decimal expected = 1;
            var source = Enumerable.Repeat((decimal) expected, 2).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalIList2MapMin()
        {
            const decimal expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToIList();

            double result = ZEnumerable.Average(source, arg => (decimal) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragedecimalIList3()
        {            
            const decimal expected = decimal.MaxValue/10*9;
            var source = Enumerable.Repeat((decimal) expected, 3).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalIList3Map()
        {
            const decimal expected = decimal.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToIList();

            double result = ZEnumerable.Average(source, arg => (decimal) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragedecimalIList3Min()
        {            
            const decimal expected = 1;
            var source = Enumerable.Repeat((decimal) expected, 3).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalIList3MapMin()
        {
            const decimal expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToIList();

            double result = ZEnumerable.Average(source, arg => (decimal) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragedecimalIList4()
        {            
            const decimal expected = decimal.MaxValue/10*9;
            var source = Enumerable.Repeat((decimal) expected, 4).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalIList4Map()
        {
            const decimal expected = decimal.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToIList();

            double result = ZEnumerable.Average(source, arg => (decimal) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragedecimalIList4Min()
        {            
            const decimal expected = 1;
            var source = Enumerable.Repeat((decimal) expected, 4).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalIList4MapMin()
        {
            const decimal expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToIList();

            double result = ZEnumerable.Average(source, arg => (decimal) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragedecimalIList100()
        {            
            const decimal expected = decimal.MaxValue/10*9;
            var source = Enumerable.Repeat((decimal) expected, 100).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalIList100Map()
        {
            const decimal expected = decimal.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToIList();

            double result = ZEnumerable.Average(source, arg => (decimal) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragedecimalIList100Min()
        {            
            const decimal expected = 1;
            var source = Enumerable.Repeat((decimal) expected, 100).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalIList100MapMin()
        {
            const decimal expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToIList();

            double result = ZEnumerable.Average(source, arg => (decimal) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragedecimalIList4096()
        {            
            const decimal expected = decimal.MaxValue/10*9;
            var source = Enumerable.Repeat((decimal) expected, 4096).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalIList4096Map()
        {
            const decimal expected = decimal.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToIList();

            double result = ZEnumerable.Average(source, arg => (decimal) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragedecimalIList4096Min()
        {            
            const decimal expected = 1;
            var source = Enumerable.Repeat((decimal) expected, 4096).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalIList4096MapMin()
        {
            const decimal expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToIList();

            double result = ZEnumerable.Average(source, arg => (decimal) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
        
                        
        #endregion
    
        #region sbyte?             
            

         
        [TestMethod]
        public void TestAveragesbyteNullableArrayNullOrEmpty()
        {        
            sbyte?[] nullSource = null;

            try
            {
                ZEnumerable.Average(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            sbyte?[] emptySource = new sbyte?[0].ToArray();
            try
            {
                ZEnumerable.Average(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestAveragesbyteNullableArrayMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<sbyte?,sbyte?>((sbyte?) arg, (sbyte?) arg)).ToArray();
            Func<KeyValuePair<sbyte?, sbyte?>, sbyte?> nullMap = null;
            try
            {
                ZEnumerable.Average(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToArray();
            try
            {
                ZEnumerable.Average(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Average(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }
         
                            [TestMethod]
        public void TestAveragesbyteNullableArray1()
        {            
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat((sbyte?) expected, 1).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteNullableArray1Map()
        {
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToArray();

            double result = ZEnumerable.Average(source, arg => (sbyte?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragesbyteNullableArray1Min()
        {            
            const sbyte expected = 1;
            var source = Enumerable.Repeat((sbyte?) expected, 1).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteNullableArray1MapMin()
        {
            const sbyte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToArray();

            double result = ZEnumerable.Average(source, arg => (sbyte?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragesbyteNullableArray2()
        {            
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat((sbyte?) expected, 2).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteNullableArray2Map()
        {
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToArray();

            double result = ZEnumerable.Average(source, arg => (sbyte?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragesbyteNullableArray2Min()
        {            
            const sbyte expected = 1;
            var source = Enumerable.Repeat((sbyte?) expected, 2).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteNullableArray2MapMin()
        {
            const sbyte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToArray();

            double result = ZEnumerable.Average(source, arg => (sbyte?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragesbyteNullableArray3()
        {            
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat((sbyte?) expected, 3).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteNullableArray3Map()
        {
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToArray();

            double result = ZEnumerable.Average(source, arg => (sbyte?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragesbyteNullableArray3Min()
        {            
            const sbyte expected = 1;
            var source = Enumerable.Repeat((sbyte?) expected, 3).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteNullableArray3MapMin()
        {
            const sbyte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToArray();

            double result = ZEnumerable.Average(source, arg => (sbyte?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragesbyteNullableArray4()
        {            
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat((sbyte?) expected, 4).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteNullableArray4Map()
        {
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToArray();

            double result = ZEnumerable.Average(source, arg => (sbyte?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragesbyteNullableArray4Min()
        {            
            const sbyte expected = 1;
            var source = Enumerable.Repeat((sbyte?) expected, 4).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteNullableArray4MapMin()
        {
            const sbyte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToArray();

            double result = ZEnumerable.Average(source, arg => (sbyte?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragesbyteNullableArray100()
        {            
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat((sbyte?) expected, 100).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteNullableArray100Map()
        {
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToArray();

            double result = ZEnumerable.Average(source, arg => (sbyte?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragesbyteNullableArray100Min()
        {            
            const sbyte expected = 1;
            var source = Enumerable.Repeat((sbyte?) expected, 100).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteNullableArray100MapMin()
        {
            const sbyte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToArray();

            double result = ZEnumerable.Average(source, arg => (sbyte?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragesbyteNullableArray4096()
        {            
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat((sbyte?) expected, 4096).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteNullableArray4096Map()
        {
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToArray();

            double result = ZEnumerable.Average(source, arg => (sbyte?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragesbyteNullableArray4096Min()
        {            
            const sbyte expected = 1;
            var source = Enumerable.Repeat((sbyte?) expected, 4096).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteNullableArray4096MapMin()
        {
            const sbyte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToArray();

            double result = ZEnumerable.Average(source, arg => (sbyte?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
        
              
                        
        [TestMethod]
        public void TestAveragesbyteNullableArrayNoOverflow()
        {
            const sbyte expected = sbyte.MaxValue;
            var source = Enumerable.Repeat((sbyte?) expected, 2).ToArray();
            double result = ZEnumerable.Average(source);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                
        [TestMethod]
        public void TestAveragesbyteNullableArrayMapNoOverflow()
        {
            const sbyte expected = sbyte.MaxValue;
            var source = Enumerable.Repeat(new { X = (sbyte?) expected}, 2).ToArray();
            double result = ZEnumerable.Average(source, arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                            

         
        [TestMethod]
        public void TestAveragesbyteNullableListNullOrEmpty()
        {        
            List<sbyte?> nullSource = null;

            try
            {
                ZEnumerable.Average(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            List<sbyte?> emptySource = new sbyte?[0].ToList();
            try
            {
                ZEnumerable.Average(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestAveragesbyteNullableListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<sbyte?,sbyte?>((sbyte?) arg, (sbyte?) arg)).ToList();
            Func<KeyValuePair<sbyte?, sbyte?>, sbyte?> nullMap = null;
            try
            {
                ZEnumerable.Average(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToList();
            try
            {
                ZEnumerable.Average(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Average(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }
         
                            [TestMethod]
        public void TestAveragesbyteNullableList1()
        {            
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat((sbyte?) expected, 1).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteNullableList1Map()
        {
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToList();

            double result = ZEnumerable.Average(source, arg => (sbyte?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragesbyteNullableList1Min()
        {            
            const sbyte expected = 1;
            var source = Enumerable.Repeat((sbyte?) expected, 1).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteNullableList1MapMin()
        {
            const sbyte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToList();

            double result = ZEnumerable.Average(source, arg => (sbyte?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragesbyteNullableList2()
        {            
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat((sbyte?) expected, 2).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteNullableList2Map()
        {
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToList();

            double result = ZEnumerable.Average(source, arg => (sbyte?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragesbyteNullableList2Min()
        {            
            const sbyte expected = 1;
            var source = Enumerable.Repeat((sbyte?) expected, 2).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteNullableList2MapMin()
        {
            const sbyte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToList();

            double result = ZEnumerable.Average(source, arg => (sbyte?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragesbyteNullableList3()
        {            
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat((sbyte?) expected, 3).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteNullableList3Map()
        {
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToList();

            double result = ZEnumerable.Average(source, arg => (sbyte?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragesbyteNullableList3Min()
        {            
            const sbyte expected = 1;
            var source = Enumerable.Repeat((sbyte?) expected, 3).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteNullableList3MapMin()
        {
            const sbyte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToList();

            double result = ZEnumerable.Average(source, arg => (sbyte?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragesbyteNullableList4()
        {            
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat((sbyte?) expected, 4).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteNullableList4Map()
        {
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToList();

            double result = ZEnumerable.Average(source, arg => (sbyte?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragesbyteNullableList4Min()
        {            
            const sbyte expected = 1;
            var source = Enumerable.Repeat((sbyte?) expected, 4).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteNullableList4MapMin()
        {
            const sbyte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToList();

            double result = ZEnumerable.Average(source, arg => (sbyte?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragesbyteNullableList100()
        {            
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat((sbyte?) expected, 100).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteNullableList100Map()
        {
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToList();

            double result = ZEnumerable.Average(source, arg => (sbyte?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragesbyteNullableList100Min()
        {            
            const sbyte expected = 1;
            var source = Enumerable.Repeat((sbyte?) expected, 100).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteNullableList100MapMin()
        {
            const sbyte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToList();

            double result = ZEnumerable.Average(source, arg => (sbyte?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragesbyteNullableList4096()
        {            
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat((sbyte?) expected, 4096).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteNullableList4096Map()
        {
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToList();

            double result = ZEnumerable.Average(source, arg => (sbyte?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragesbyteNullableList4096Min()
        {            
            const sbyte expected = 1;
            var source = Enumerable.Repeat((sbyte?) expected, 4096).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteNullableList4096MapMin()
        {
            const sbyte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToList();

            double result = ZEnumerable.Average(source, arg => (sbyte?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
        
              
                        
        [TestMethod]
        public void TestAveragesbyteNullableListNoOverflow()
        {
            const sbyte expected = sbyte.MaxValue;
            var source = Enumerable.Repeat((sbyte?) expected, 2).ToList();
            double result = ZEnumerable.Average(source);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                
        [TestMethod]
        public void TestAveragesbyteNullableListMapNoOverflow()
        {
            const sbyte expected = sbyte.MaxValue;
            var source = Enumerable.Repeat(new { X = (sbyte?) expected}, 2).ToList();
            double result = ZEnumerable.Average(source, arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                            

         
        [TestMethod]
        public void TestAveragesbyteNullableIListNullOrEmpty()
        {        
            IList<sbyte?> nullSource = null;

            try
            {
                ZEnumerable.Average(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            IList<sbyte?> emptySource = new sbyte?[0].ToIList();
            try
            {
                ZEnumerable.Average(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestAveragesbyteNullableIListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<sbyte?,sbyte?>((sbyte?) arg, (sbyte?) arg)).ToIList();
            Func<KeyValuePair<sbyte?, sbyte?>, sbyte?> nullMap = null;
            try
            {
                ZEnumerable.Average(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToIList();
            try
            {
                ZEnumerable.Average(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Average(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }
         
                            [TestMethod]
        public void TestAveragesbyteNullableIList1()
        {            
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat((sbyte?) expected, 1).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteNullableIList1Map()
        {
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToIList();

            double result = ZEnumerable.Average(source, arg => (sbyte?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragesbyteNullableIList1Min()
        {            
            const sbyte expected = 1;
            var source = Enumerable.Repeat((sbyte?) expected, 1).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteNullableIList1MapMin()
        {
            const sbyte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToIList();

            double result = ZEnumerable.Average(source, arg => (sbyte?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragesbyteNullableIList2()
        {            
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat((sbyte?) expected, 2).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteNullableIList2Map()
        {
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToIList();

            double result = ZEnumerable.Average(source, arg => (sbyte?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragesbyteNullableIList2Min()
        {            
            const sbyte expected = 1;
            var source = Enumerable.Repeat((sbyte?) expected, 2).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteNullableIList2MapMin()
        {
            const sbyte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToIList();

            double result = ZEnumerable.Average(source, arg => (sbyte?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragesbyteNullableIList3()
        {            
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat((sbyte?) expected, 3).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteNullableIList3Map()
        {
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToIList();

            double result = ZEnumerable.Average(source, arg => (sbyte?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragesbyteNullableIList3Min()
        {            
            const sbyte expected = 1;
            var source = Enumerable.Repeat((sbyte?) expected, 3).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteNullableIList3MapMin()
        {
            const sbyte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToIList();

            double result = ZEnumerable.Average(source, arg => (sbyte?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragesbyteNullableIList4()
        {            
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat((sbyte?) expected, 4).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteNullableIList4Map()
        {
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToIList();

            double result = ZEnumerable.Average(source, arg => (sbyte?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragesbyteNullableIList4Min()
        {            
            const sbyte expected = 1;
            var source = Enumerable.Repeat((sbyte?) expected, 4).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteNullableIList4MapMin()
        {
            const sbyte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToIList();

            double result = ZEnumerable.Average(source, arg => (sbyte?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragesbyteNullableIList100()
        {            
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat((sbyte?) expected, 100).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteNullableIList100Map()
        {
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToIList();

            double result = ZEnumerable.Average(source, arg => (sbyte?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragesbyteNullableIList100Min()
        {            
            const sbyte expected = 1;
            var source = Enumerable.Repeat((sbyte?) expected, 100).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteNullableIList100MapMin()
        {
            const sbyte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToIList();

            double result = ZEnumerable.Average(source, arg => (sbyte?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragesbyteNullableIList4096()
        {            
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat((sbyte?) expected, 4096).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteNullableIList4096Map()
        {
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToIList();

            double result = ZEnumerable.Average(source, arg => (sbyte?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragesbyteNullableIList4096Min()
        {            
            const sbyte expected = 1;
            var source = Enumerable.Repeat((sbyte?) expected, 4096).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteNullableIList4096MapMin()
        {
            const sbyte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToIList();

            double result = ZEnumerable.Average(source, arg => (sbyte?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
        
              
                        
        [TestMethod]
        public void TestAveragesbyteNullableIListNoOverflow()
        {
            const sbyte expected = sbyte.MaxValue;
            var source = Enumerable.Repeat((sbyte?) expected, 2).ToIList();
            double result = ZEnumerable.Average(source);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                
        [TestMethod]
        public void TestAveragesbyteNullableIListMapNoOverflow()
        {
            const sbyte expected = sbyte.MaxValue;
            var source = Enumerable.Repeat(new { X = (sbyte?) expected}, 2).ToIList();
            double result = ZEnumerable.Average(source, arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                                
        #endregion
    
        #region byte?             
            

         
        [TestMethod]
        public void TestAveragebyteNullableArrayNullOrEmpty()
        {        
            byte?[] nullSource = null;

            try
            {
                ZEnumerable.Average(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            byte?[] emptySource = new byte?[0].ToArray();
            try
            {
                ZEnumerable.Average(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestAveragebyteNullableArrayMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<byte?,byte?>((byte?) arg, (byte?) arg)).ToArray();
            Func<KeyValuePair<byte?, byte?>, byte?> nullMap = null;
            try
            {
                ZEnumerable.Average(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToArray();
            try
            {
                ZEnumerable.Average(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Average(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }
         
                            [TestMethod]
        public void TestAveragebyteNullableArray1()
        {            
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat((byte?) expected, 1).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteNullableArray1Map()
        {
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToArray();

            double result = ZEnumerable.Average(source, arg => (byte?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragebyteNullableArray1Min()
        {            
            const byte expected = 1;
            var source = Enumerable.Repeat((byte?) expected, 1).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteNullableArray1MapMin()
        {
            const byte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToArray();

            double result = ZEnumerable.Average(source, arg => (byte?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragebyteNullableArray2()
        {            
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat((byte?) expected, 2).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteNullableArray2Map()
        {
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToArray();

            double result = ZEnumerable.Average(source, arg => (byte?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragebyteNullableArray2Min()
        {            
            const byte expected = 1;
            var source = Enumerable.Repeat((byte?) expected, 2).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteNullableArray2MapMin()
        {
            const byte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToArray();

            double result = ZEnumerable.Average(source, arg => (byte?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragebyteNullableArray3()
        {            
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat((byte?) expected, 3).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteNullableArray3Map()
        {
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToArray();

            double result = ZEnumerable.Average(source, arg => (byte?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragebyteNullableArray3Min()
        {            
            const byte expected = 1;
            var source = Enumerable.Repeat((byte?) expected, 3).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteNullableArray3MapMin()
        {
            const byte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToArray();

            double result = ZEnumerable.Average(source, arg => (byte?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragebyteNullableArray4()
        {            
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat((byte?) expected, 4).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteNullableArray4Map()
        {
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToArray();

            double result = ZEnumerable.Average(source, arg => (byte?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragebyteNullableArray4Min()
        {            
            const byte expected = 1;
            var source = Enumerable.Repeat((byte?) expected, 4).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteNullableArray4MapMin()
        {
            const byte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToArray();

            double result = ZEnumerable.Average(source, arg => (byte?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragebyteNullableArray100()
        {            
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat((byte?) expected, 100).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteNullableArray100Map()
        {
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToArray();

            double result = ZEnumerable.Average(source, arg => (byte?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragebyteNullableArray100Min()
        {            
            const byte expected = 1;
            var source = Enumerable.Repeat((byte?) expected, 100).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteNullableArray100MapMin()
        {
            const byte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToArray();

            double result = ZEnumerable.Average(source, arg => (byte?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragebyteNullableArray4096()
        {            
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat((byte?) expected, 4096).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteNullableArray4096Map()
        {
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToArray();

            double result = ZEnumerable.Average(source, arg => (byte?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragebyteNullableArray4096Min()
        {            
            const byte expected = 1;
            var source = Enumerable.Repeat((byte?) expected, 4096).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteNullableArray4096MapMin()
        {
            const byte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToArray();

            double result = ZEnumerable.Average(source, arg => (byte?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
        
              
                        
        [TestMethod]
        public void TestAveragebyteNullableArrayNoOverflow()
        {
            const byte expected = byte.MaxValue;
            var source = Enumerable.Repeat((byte?) expected, 2).ToArray();
            double result = ZEnumerable.Average(source);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                
        [TestMethod]
        public void TestAveragebyteNullableArrayMapNoOverflow()
        {
            const byte expected = byte.MaxValue;
            var source = Enumerable.Repeat(new { X = (byte?) expected}, 2).ToArray();
            double result = ZEnumerable.Average(source, arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                            

         
        [TestMethod]
        public void TestAveragebyteNullableListNullOrEmpty()
        {        
            List<byte?> nullSource = null;

            try
            {
                ZEnumerable.Average(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            List<byte?> emptySource = new byte?[0].ToList();
            try
            {
                ZEnumerable.Average(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestAveragebyteNullableListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<byte?,byte?>((byte?) arg, (byte?) arg)).ToList();
            Func<KeyValuePair<byte?, byte?>, byte?> nullMap = null;
            try
            {
                ZEnumerable.Average(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToList();
            try
            {
                ZEnumerable.Average(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Average(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }
         
                            [TestMethod]
        public void TestAveragebyteNullableList1()
        {            
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat((byte?) expected, 1).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteNullableList1Map()
        {
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToList();

            double result = ZEnumerable.Average(source, arg => (byte?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragebyteNullableList1Min()
        {            
            const byte expected = 1;
            var source = Enumerable.Repeat((byte?) expected, 1).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteNullableList1MapMin()
        {
            const byte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToList();

            double result = ZEnumerable.Average(source, arg => (byte?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragebyteNullableList2()
        {            
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat((byte?) expected, 2).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteNullableList2Map()
        {
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToList();

            double result = ZEnumerable.Average(source, arg => (byte?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragebyteNullableList2Min()
        {            
            const byte expected = 1;
            var source = Enumerable.Repeat((byte?) expected, 2).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteNullableList2MapMin()
        {
            const byte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToList();

            double result = ZEnumerable.Average(source, arg => (byte?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragebyteNullableList3()
        {            
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat((byte?) expected, 3).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteNullableList3Map()
        {
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToList();

            double result = ZEnumerable.Average(source, arg => (byte?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragebyteNullableList3Min()
        {            
            const byte expected = 1;
            var source = Enumerable.Repeat((byte?) expected, 3).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteNullableList3MapMin()
        {
            const byte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToList();

            double result = ZEnumerable.Average(source, arg => (byte?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragebyteNullableList4()
        {            
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat((byte?) expected, 4).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteNullableList4Map()
        {
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToList();

            double result = ZEnumerable.Average(source, arg => (byte?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragebyteNullableList4Min()
        {            
            const byte expected = 1;
            var source = Enumerable.Repeat((byte?) expected, 4).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteNullableList4MapMin()
        {
            const byte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToList();

            double result = ZEnumerable.Average(source, arg => (byte?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragebyteNullableList100()
        {            
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat((byte?) expected, 100).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteNullableList100Map()
        {
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToList();

            double result = ZEnumerable.Average(source, arg => (byte?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragebyteNullableList100Min()
        {            
            const byte expected = 1;
            var source = Enumerable.Repeat((byte?) expected, 100).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteNullableList100MapMin()
        {
            const byte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToList();

            double result = ZEnumerable.Average(source, arg => (byte?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragebyteNullableList4096()
        {            
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat((byte?) expected, 4096).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteNullableList4096Map()
        {
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToList();

            double result = ZEnumerable.Average(source, arg => (byte?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragebyteNullableList4096Min()
        {            
            const byte expected = 1;
            var source = Enumerable.Repeat((byte?) expected, 4096).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteNullableList4096MapMin()
        {
            const byte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToList();

            double result = ZEnumerable.Average(source, arg => (byte?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
        
              
                        
        [TestMethod]
        public void TestAveragebyteNullableListNoOverflow()
        {
            const byte expected = byte.MaxValue;
            var source = Enumerable.Repeat((byte?) expected, 2).ToList();
            double result = ZEnumerable.Average(source);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                
        [TestMethod]
        public void TestAveragebyteNullableListMapNoOverflow()
        {
            const byte expected = byte.MaxValue;
            var source = Enumerable.Repeat(new { X = (byte?) expected}, 2).ToList();
            double result = ZEnumerable.Average(source, arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                            

         
        [TestMethod]
        public void TestAveragebyteNullableIListNullOrEmpty()
        {        
            IList<byte?> nullSource = null;

            try
            {
                ZEnumerable.Average(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            IList<byte?> emptySource = new byte?[0].ToIList();
            try
            {
                ZEnumerable.Average(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestAveragebyteNullableIListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<byte?,byte?>((byte?) arg, (byte?) arg)).ToIList();
            Func<KeyValuePair<byte?, byte?>, byte?> nullMap = null;
            try
            {
                ZEnumerable.Average(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToIList();
            try
            {
                ZEnumerable.Average(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Average(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }
         
                            [TestMethod]
        public void TestAveragebyteNullableIList1()
        {            
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat((byte?) expected, 1).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteNullableIList1Map()
        {
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToIList();

            double result = ZEnumerable.Average(source, arg => (byte?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragebyteNullableIList1Min()
        {            
            const byte expected = 1;
            var source = Enumerable.Repeat((byte?) expected, 1).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteNullableIList1MapMin()
        {
            const byte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToIList();

            double result = ZEnumerable.Average(source, arg => (byte?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragebyteNullableIList2()
        {            
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat((byte?) expected, 2).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteNullableIList2Map()
        {
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToIList();

            double result = ZEnumerable.Average(source, arg => (byte?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragebyteNullableIList2Min()
        {            
            const byte expected = 1;
            var source = Enumerable.Repeat((byte?) expected, 2).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteNullableIList2MapMin()
        {
            const byte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToIList();

            double result = ZEnumerable.Average(source, arg => (byte?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragebyteNullableIList3()
        {            
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat((byte?) expected, 3).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteNullableIList3Map()
        {
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToIList();

            double result = ZEnumerable.Average(source, arg => (byte?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragebyteNullableIList3Min()
        {            
            const byte expected = 1;
            var source = Enumerable.Repeat((byte?) expected, 3).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteNullableIList3MapMin()
        {
            const byte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToIList();

            double result = ZEnumerable.Average(source, arg => (byte?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragebyteNullableIList4()
        {            
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat((byte?) expected, 4).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteNullableIList4Map()
        {
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToIList();

            double result = ZEnumerable.Average(source, arg => (byte?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragebyteNullableIList4Min()
        {            
            const byte expected = 1;
            var source = Enumerable.Repeat((byte?) expected, 4).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteNullableIList4MapMin()
        {
            const byte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToIList();

            double result = ZEnumerable.Average(source, arg => (byte?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragebyteNullableIList100()
        {            
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat((byte?) expected, 100).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteNullableIList100Map()
        {
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToIList();

            double result = ZEnumerable.Average(source, arg => (byte?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragebyteNullableIList100Min()
        {            
            const byte expected = 1;
            var source = Enumerable.Repeat((byte?) expected, 100).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteNullableIList100MapMin()
        {
            const byte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToIList();

            double result = ZEnumerable.Average(source, arg => (byte?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragebyteNullableIList4096()
        {            
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat((byte?) expected, 4096).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteNullableIList4096Map()
        {
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToIList();

            double result = ZEnumerable.Average(source, arg => (byte?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragebyteNullableIList4096Min()
        {            
            const byte expected = 1;
            var source = Enumerable.Repeat((byte?) expected, 4096).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteNullableIList4096MapMin()
        {
            const byte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToIList();

            double result = ZEnumerable.Average(source, arg => (byte?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
        
              
                        
        [TestMethod]
        public void TestAveragebyteNullableIListNoOverflow()
        {
            const byte expected = byte.MaxValue;
            var source = Enumerable.Repeat((byte?) expected, 2).ToIList();
            double result = ZEnumerable.Average(source);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                
        [TestMethod]
        public void TestAveragebyteNullableIListMapNoOverflow()
        {
            const byte expected = byte.MaxValue;
            var source = Enumerable.Repeat(new { X = (byte?) expected}, 2).ToIList();
            double result = ZEnumerable.Average(source, arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                                
        #endregion
    
        #region short?             
            

         
        [TestMethod]
        public void TestAverageshortNullableArrayNullOrEmpty()
        {        
            short?[] nullSource = null;

            try
            {
                ZEnumerable.Average(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            short?[] emptySource = new short?[0].ToArray();
            try
            {
                ZEnumerable.Average(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestAverageshortNullableArrayMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<short?,short?>((short?) arg, (short?) arg)).ToArray();
            Func<KeyValuePair<short?, short?>, short?> nullMap = null;
            try
            {
                ZEnumerable.Average(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToArray();
            try
            {
                ZEnumerable.Average(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Average(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }
         
                            [TestMethod]
        public void TestAverageshortNullableArray1()
        {            
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat((short?) expected, 1).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortNullableArray1Map()
        {
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToArray();

            double result = ZEnumerable.Average(source, arg => (short?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageshortNullableArray1Min()
        {            
            const short expected = 1;
            var source = Enumerable.Repeat((short?) expected, 1).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortNullableArray1MapMin()
        {
            const short expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToArray();

            double result = ZEnumerable.Average(source, arg => (short?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageshortNullableArray2()
        {            
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat((short?) expected, 2).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortNullableArray2Map()
        {
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToArray();

            double result = ZEnumerable.Average(source, arg => (short?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageshortNullableArray2Min()
        {            
            const short expected = 1;
            var source = Enumerable.Repeat((short?) expected, 2).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortNullableArray2MapMin()
        {
            const short expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToArray();

            double result = ZEnumerable.Average(source, arg => (short?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageshortNullableArray3()
        {            
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat((short?) expected, 3).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortNullableArray3Map()
        {
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToArray();

            double result = ZEnumerable.Average(source, arg => (short?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageshortNullableArray3Min()
        {            
            const short expected = 1;
            var source = Enumerable.Repeat((short?) expected, 3).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortNullableArray3MapMin()
        {
            const short expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToArray();

            double result = ZEnumerable.Average(source, arg => (short?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageshortNullableArray4()
        {            
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat((short?) expected, 4).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortNullableArray4Map()
        {
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToArray();

            double result = ZEnumerable.Average(source, arg => (short?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageshortNullableArray4Min()
        {            
            const short expected = 1;
            var source = Enumerable.Repeat((short?) expected, 4).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortNullableArray4MapMin()
        {
            const short expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToArray();

            double result = ZEnumerable.Average(source, arg => (short?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageshortNullableArray100()
        {            
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat((short?) expected, 100).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortNullableArray100Map()
        {
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToArray();

            double result = ZEnumerable.Average(source, arg => (short?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageshortNullableArray100Min()
        {            
            const short expected = 1;
            var source = Enumerable.Repeat((short?) expected, 100).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortNullableArray100MapMin()
        {
            const short expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToArray();

            double result = ZEnumerable.Average(source, arg => (short?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageshortNullableArray4096()
        {            
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat((short?) expected, 4096).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortNullableArray4096Map()
        {
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToArray();

            double result = ZEnumerable.Average(source, arg => (short?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageshortNullableArray4096Min()
        {            
            const short expected = 1;
            var source = Enumerable.Repeat((short?) expected, 4096).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortNullableArray4096MapMin()
        {
            const short expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToArray();

            double result = ZEnumerable.Average(source, arg => (short?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
        
              
                        
        [TestMethod]
        public void TestAverageshortNullableArrayNoOverflow()
        {
            const short expected = short.MaxValue;
            var source = Enumerable.Repeat((short?) expected, 2).ToArray();
            double result = ZEnumerable.Average(source);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                
        [TestMethod]
        public void TestAverageshortNullableArrayMapNoOverflow()
        {
            const short expected = short.MaxValue;
            var source = Enumerable.Repeat(new { X = (short?) expected}, 2).ToArray();
            double result = ZEnumerable.Average(source, arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                            

         
        [TestMethod]
        public void TestAverageshortNullableListNullOrEmpty()
        {        
            List<short?> nullSource = null;

            try
            {
                ZEnumerable.Average(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            List<short?> emptySource = new short?[0].ToList();
            try
            {
                ZEnumerable.Average(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestAverageshortNullableListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<short?,short?>((short?) arg, (short?) arg)).ToList();
            Func<KeyValuePair<short?, short?>, short?> nullMap = null;
            try
            {
                ZEnumerable.Average(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToList();
            try
            {
                ZEnumerable.Average(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Average(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }
         
                            [TestMethod]
        public void TestAverageshortNullableList1()
        {            
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat((short?) expected, 1).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortNullableList1Map()
        {
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToList();

            double result = ZEnumerable.Average(source, arg => (short?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageshortNullableList1Min()
        {            
            const short expected = 1;
            var source = Enumerable.Repeat((short?) expected, 1).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortNullableList1MapMin()
        {
            const short expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToList();

            double result = ZEnumerable.Average(source, arg => (short?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageshortNullableList2()
        {            
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat((short?) expected, 2).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortNullableList2Map()
        {
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToList();

            double result = ZEnumerable.Average(source, arg => (short?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageshortNullableList2Min()
        {            
            const short expected = 1;
            var source = Enumerable.Repeat((short?) expected, 2).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortNullableList2MapMin()
        {
            const short expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToList();

            double result = ZEnumerable.Average(source, arg => (short?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageshortNullableList3()
        {            
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat((short?) expected, 3).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortNullableList3Map()
        {
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToList();

            double result = ZEnumerable.Average(source, arg => (short?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageshortNullableList3Min()
        {            
            const short expected = 1;
            var source = Enumerable.Repeat((short?) expected, 3).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortNullableList3MapMin()
        {
            const short expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToList();

            double result = ZEnumerable.Average(source, arg => (short?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageshortNullableList4()
        {            
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat((short?) expected, 4).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortNullableList4Map()
        {
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToList();

            double result = ZEnumerable.Average(source, arg => (short?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageshortNullableList4Min()
        {            
            const short expected = 1;
            var source = Enumerable.Repeat((short?) expected, 4).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortNullableList4MapMin()
        {
            const short expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToList();

            double result = ZEnumerable.Average(source, arg => (short?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageshortNullableList100()
        {            
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat((short?) expected, 100).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortNullableList100Map()
        {
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToList();

            double result = ZEnumerable.Average(source, arg => (short?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageshortNullableList100Min()
        {            
            const short expected = 1;
            var source = Enumerable.Repeat((short?) expected, 100).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortNullableList100MapMin()
        {
            const short expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToList();

            double result = ZEnumerable.Average(source, arg => (short?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageshortNullableList4096()
        {            
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat((short?) expected, 4096).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortNullableList4096Map()
        {
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToList();

            double result = ZEnumerable.Average(source, arg => (short?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageshortNullableList4096Min()
        {            
            const short expected = 1;
            var source = Enumerable.Repeat((short?) expected, 4096).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortNullableList4096MapMin()
        {
            const short expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToList();

            double result = ZEnumerable.Average(source, arg => (short?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
        
              
                        
        [TestMethod]
        public void TestAverageshortNullableListNoOverflow()
        {
            const short expected = short.MaxValue;
            var source = Enumerable.Repeat((short?) expected, 2).ToList();
            double result = ZEnumerable.Average(source);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                
        [TestMethod]
        public void TestAverageshortNullableListMapNoOverflow()
        {
            const short expected = short.MaxValue;
            var source = Enumerable.Repeat(new { X = (short?) expected}, 2).ToList();
            double result = ZEnumerable.Average(source, arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                            

         
        [TestMethod]
        public void TestAverageshortNullableIListNullOrEmpty()
        {        
            IList<short?> nullSource = null;

            try
            {
                ZEnumerable.Average(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            IList<short?> emptySource = new short?[0].ToIList();
            try
            {
                ZEnumerable.Average(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestAverageshortNullableIListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<short?,short?>((short?) arg, (short?) arg)).ToIList();
            Func<KeyValuePair<short?, short?>, short?> nullMap = null;
            try
            {
                ZEnumerable.Average(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToIList();
            try
            {
                ZEnumerable.Average(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Average(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }
         
                            [TestMethod]
        public void TestAverageshortNullableIList1()
        {            
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat((short?) expected, 1).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortNullableIList1Map()
        {
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToIList();

            double result = ZEnumerable.Average(source, arg => (short?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageshortNullableIList1Min()
        {            
            const short expected = 1;
            var source = Enumerable.Repeat((short?) expected, 1).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortNullableIList1MapMin()
        {
            const short expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToIList();

            double result = ZEnumerable.Average(source, arg => (short?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageshortNullableIList2()
        {            
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat((short?) expected, 2).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortNullableIList2Map()
        {
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToIList();

            double result = ZEnumerable.Average(source, arg => (short?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageshortNullableIList2Min()
        {            
            const short expected = 1;
            var source = Enumerable.Repeat((short?) expected, 2).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortNullableIList2MapMin()
        {
            const short expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToIList();

            double result = ZEnumerable.Average(source, arg => (short?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageshortNullableIList3()
        {            
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat((short?) expected, 3).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortNullableIList3Map()
        {
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToIList();

            double result = ZEnumerable.Average(source, arg => (short?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageshortNullableIList3Min()
        {            
            const short expected = 1;
            var source = Enumerable.Repeat((short?) expected, 3).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortNullableIList3MapMin()
        {
            const short expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToIList();

            double result = ZEnumerable.Average(source, arg => (short?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageshortNullableIList4()
        {            
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat((short?) expected, 4).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortNullableIList4Map()
        {
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToIList();

            double result = ZEnumerable.Average(source, arg => (short?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageshortNullableIList4Min()
        {            
            const short expected = 1;
            var source = Enumerable.Repeat((short?) expected, 4).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortNullableIList4MapMin()
        {
            const short expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToIList();

            double result = ZEnumerable.Average(source, arg => (short?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageshortNullableIList100()
        {            
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat((short?) expected, 100).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortNullableIList100Map()
        {
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToIList();

            double result = ZEnumerable.Average(source, arg => (short?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageshortNullableIList100Min()
        {            
            const short expected = 1;
            var source = Enumerable.Repeat((short?) expected, 100).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortNullableIList100MapMin()
        {
            const short expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToIList();

            double result = ZEnumerable.Average(source, arg => (short?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageshortNullableIList4096()
        {            
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat((short?) expected, 4096).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortNullableIList4096Map()
        {
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToIList();

            double result = ZEnumerable.Average(source, arg => (short?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageshortNullableIList4096Min()
        {            
            const short expected = 1;
            var source = Enumerable.Repeat((short?) expected, 4096).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortNullableIList4096MapMin()
        {
            const short expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToIList();

            double result = ZEnumerable.Average(source, arg => (short?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
        
              
                        
        [TestMethod]
        public void TestAverageshortNullableIListNoOverflow()
        {
            const short expected = short.MaxValue;
            var source = Enumerable.Repeat((short?) expected, 2).ToIList();
            double result = ZEnumerable.Average(source);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                
        [TestMethod]
        public void TestAverageshortNullableIListMapNoOverflow()
        {
            const short expected = short.MaxValue;
            var source = Enumerable.Repeat(new { X = (short?) expected}, 2).ToIList();
            double result = ZEnumerable.Average(source, arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                                
        #endregion
    
        #region ushort?             
            

         
        [TestMethod]
        public void TestAverageushortNullableArrayNullOrEmpty()
        {        
            ushort?[] nullSource = null;

            try
            {
                ZEnumerable.Average(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            ushort?[] emptySource = new ushort?[0].ToArray();
            try
            {
                ZEnumerable.Average(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestAverageushortNullableArrayMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<ushort?,ushort?>((ushort?) arg, (ushort?) arg)).ToArray();
            Func<KeyValuePair<ushort?, ushort?>, ushort?> nullMap = null;
            try
            {
                ZEnumerable.Average(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToArray();
            try
            {
                ZEnumerable.Average(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Average(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }
         
                            [TestMethod]
        public void TestAverageushortNullableArray1()
        {            
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat((ushort?) expected, 1).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortNullableArray1Map()
        {
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToArray();

            double result = ZEnumerable.Average(source, arg => (ushort?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageushortNullableArray1Min()
        {            
            const ushort expected = 1;
            var source = Enumerable.Repeat((ushort?) expected, 1).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortNullableArray1MapMin()
        {
            const ushort expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToArray();

            double result = ZEnumerable.Average(source, arg => (ushort?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageushortNullableArray2()
        {            
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat((ushort?) expected, 2).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortNullableArray2Map()
        {
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToArray();

            double result = ZEnumerable.Average(source, arg => (ushort?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageushortNullableArray2Min()
        {            
            const ushort expected = 1;
            var source = Enumerable.Repeat((ushort?) expected, 2).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortNullableArray2MapMin()
        {
            const ushort expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToArray();

            double result = ZEnumerable.Average(source, arg => (ushort?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageushortNullableArray3()
        {            
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat((ushort?) expected, 3).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortNullableArray3Map()
        {
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToArray();

            double result = ZEnumerable.Average(source, arg => (ushort?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageushortNullableArray3Min()
        {            
            const ushort expected = 1;
            var source = Enumerable.Repeat((ushort?) expected, 3).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortNullableArray3MapMin()
        {
            const ushort expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToArray();

            double result = ZEnumerable.Average(source, arg => (ushort?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageushortNullableArray4()
        {            
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat((ushort?) expected, 4).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortNullableArray4Map()
        {
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToArray();

            double result = ZEnumerable.Average(source, arg => (ushort?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageushortNullableArray4Min()
        {            
            const ushort expected = 1;
            var source = Enumerable.Repeat((ushort?) expected, 4).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortNullableArray4MapMin()
        {
            const ushort expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToArray();

            double result = ZEnumerable.Average(source, arg => (ushort?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageushortNullableArray100()
        {            
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat((ushort?) expected, 100).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortNullableArray100Map()
        {
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToArray();

            double result = ZEnumerable.Average(source, arg => (ushort?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageushortNullableArray100Min()
        {            
            const ushort expected = 1;
            var source = Enumerable.Repeat((ushort?) expected, 100).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortNullableArray100MapMin()
        {
            const ushort expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToArray();

            double result = ZEnumerable.Average(source, arg => (ushort?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageushortNullableArray4096()
        {            
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat((ushort?) expected, 4096).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortNullableArray4096Map()
        {
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToArray();

            double result = ZEnumerable.Average(source, arg => (ushort?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageushortNullableArray4096Min()
        {            
            const ushort expected = 1;
            var source = Enumerable.Repeat((ushort?) expected, 4096).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortNullableArray4096MapMin()
        {
            const ushort expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToArray();

            double result = ZEnumerable.Average(source, arg => (ushort?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
        
              
                        
        [TestMethod]
        public void TestAverageushortNullableArrayNoOverflow()
        {
            const ushort expected = ushort.MaxValue;
            var source = Enumerable.Repeat((ushort?) expected, 2).ToArray();
            double result = ZEnumerable.Average(source);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                
        [TestMethod]
        public void TestAverageushortNullableArrayMapNoOverflow()
        {
            const ushort expected = ushort.MaxValue;
            var source = Enumerable.Repeat(new { X = (ushort?) expected}, 2).ToArray();
            double result = ZEnumerable.Average(source, arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                            

         
        [TestMethod]
        public void TestAverageushortNullableListNullOrEmpty()
        {        
            List<ushort?> nullSource = null;

            try
            {
                ZEnumerable.Average(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            List<ushort?> emptySource = new ushort?[0].ToList();
            try
            {
                ZEnumerable.Average(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestAverageushortNullableListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<ushort?,ushort?>((ushort?) arg, (ushort?) arg)).ToList();
            Func<KeyValuePair<ushort?, ushort?>, ushort?> nullMap = null;
            try
            {
                ZEnumerable.Average(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToList();
            try
            {
                ZEnumerable.Average(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Average(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }
         
                            [TestMethod]
        public void TestAverageushortNullableList1()
        {            
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat((ushort?) expected, 1).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortNullableList1Map()
        {
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToList();

            double result = ZEnumerable.Average(source, arg => (ushort?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageushortNullableList1Min()
        {            
            const ushort expected = 1;
            var source = Enumerable.Repeat((ushort?) expected, 1).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortNullableList1MapMin()
        {
            const ushort expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToList();

            double result = ZEnumerable.Average(source, arg => (ushort?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageushortNullableList2()
        {            
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat((ushort?) expected, 2).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortNullableList2Map()
        {
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToList();

            double result = ZEnumerable.Average(source, arg => (ushort?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageushortNullableList2Min()
        {            
            const ushort expected = 1;
            var source = Enumerable.Repeat((ushort?) expected, 2).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortNullableList2MapMin()
        {
            const ushort expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToList();

            double result = ZEnumerable.Average(source, arg => (ushort?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageushortNullableList3()
        {            
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat((ushort?) expected, 3).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortNullableList3Map()
        {
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToList();

            double result = ZEnumerable.Average(source, arg => (ushort?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageushortNullableList3Min()
        {            
            const ushort expected = 1;
            var source = Enumerable.Repeat((ushort?) expected, 3).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortNullableList3MapMin()
        {
            const ushort expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToList();

            double result = ZEnumerable.Average(source, arg => (ushort?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageushortNullableList4()
        {            
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat((ushort?) expected, 4).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortNullableList4Map()
        {
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToList();

            double result = ZEnumerable.Average(source, arg => (ushort?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageushortNullableList4Min()
        {            
            const ushort expected = 1;
            var source = Enumerable.Repeat((ushort?) expected, 4).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortNullableList4MapMin()
        {
            const ushort expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToList();

            double result = ZEnumerable.Average(source, arg => (ushort?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageushortNullableList100()
        {            
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat((ushort?) expected, 100).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortNullableList100Map()
        {
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToList();

            double result = ZEnumerable.Average(source, arg => (ushort?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageushortNullableList100Min()
        {            
            const ushort expected = 1;
            var source = Enumerable.Repeat((ushort?) expected, 100).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortNullableList100MapMin()
        {
            const ushort expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToList();

            double result = ZEnumerable.Average(source, arg => (ushort?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageushortNullableList4096()
        {            
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat((ushort?) expected, 4096).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortNullableList4096Map()
        {
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToList();

            double result = ZEnumerable.Average(source, arg => (ushort?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageushortNullableList4096Min()
        {            
            const ushort expected = 1;
            var source = Enumerable.Repeat((ushort?) expected, 4096).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortNullableList4096MapMin()
        {
            const ushort expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToList();

            double result = ZEnumerable.Average(source, arg => (ushort?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
        
              
                        
        [TestMethod]
        public void TestAverageushortNullableListNoOverflow()
        {
            const ushort expected = ushort.MaxValue;
            var source = Enumerable.Repeat((ushort?) expected, 2).ToList();
            double result = ZEnumerable.Average(source);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                
        [TestMethod]
        public void TestAverageushortNullableListMapNoOverflow()
        {
            const ushort expected = ushort.MaxValue;
            var source = Enumerable.Repeat(new { X = (ushort?) expected}, 2).ToList();
            double result = ZEnumerable.Average(source, arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                            

         
        [TestMethod]
        public void TestAverageushortNullableIListNullOrEmpty()
        {        
            IList<ushort?> nullSource = null;

            try
            {
                ZEnumerable.Average(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            IList<ushort?> emptySource = new ushort?[0].ToIList();
            try
            {
                ZEnumerable.Average(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestAverageushortNullableIListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<ushort?,ushort?>((ushort?) arg, (ushort?) arg)).ToIList();
            Func<KeyValuePair<ushort?, ushort?>, ushort?> nullMap = null;
            try
            {
                ZEnumerable.Average(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToIList();
            try
            {
                ZEnumerable.Average(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Average(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }
         
                            [TestMethod]
        public void TestAverageushortNullableIList1()
        {            
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat((ushort?) expected, 1).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortNullableIList1Map()
        {
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToIList();

            double result = ZEnumerable.Average(source, arg => (ushort?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageushortNullableIList1Min()
        {            
            const ushort expected = 1;
            var source = Enumerable.Repeat((ushort?) expected, 1).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortNullableIList1MapMin()
        {
            const ushort expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToIList();

            double result = ZEnumerable.Average(source, arg => (ushort?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageushortNullableIList2()
        {            
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat((ushort?) expected, 2).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortNullableIList2Map()
        {
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToIList();

            double result = ZEnumerable.Average(source, arg => (ushort?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageushortNullableIList2Min()
        {            
            const ushort expected = 1;
            var source = Enumerable.Repeat((ushort?) expected, 2).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortNullableIList2MapMin()
        {
            const ushort expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToIList();

            double result = ZEnumerable.Average(source, arg => (ushort?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageushortNullableIList3()
        {            
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat((ushort?) expected, 3).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortNullableIList3Map()
        {
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToIList();

            double result = ZEnumerable.Average(source, arg => (ushort?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageushortNullableIList3Min()
        {            
            const ushort expected = 1;
            var source = Enumerable.Repeat((ushort?) expected, 3).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortNullableIList3MapMin()
        {
            const ushort expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToIList();

            double result = ZEnumerable.Average(source, arg => (ushort?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageushortNullableIList4()
        {            
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat((ushort?) expected, 4).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortNullableIList4Map()
        {
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToIList();

            double result = ZEnumerable.Average(source, arg => (ushort?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageushortNullableIList4Min()
        {            
            const ushort expected = 1;
            var source = Enumerable.Repeat((ushort?) expected, 4).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortNullableIList4MapMin()
        {
            const ushort expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToIList();

            double result = ZEnumerable.Average(source, arg => (ushort?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageushortNullableIList100()
        {            
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat((ushort?) expected, 100).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortNullableIList100Map()
        {
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToIList();

            double result = ZEnumerable.Average(source, arg => (ushort?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageushortNullableIList100Min()
        {            
            const ushort expected = 1;
            var source = Enumerable.Repeat((ushort?) expected, 100).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortNullableIList100MapMin()
        {
            const ushort expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToIList();

            double result = ZEnumerable.Average(source, arg => (ushort?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageushortNullableIList4096()
        {            
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat((ushort?) expected, 4096).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortNullableIList4096Map()
        {
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToIList();

            double result = ZEnumerable.Average(source, arg => (ushort?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageushortNullableIList4096Min()
        {            
            const ushort expected = 1;
            var source = Enumerable.Repeat((ushort?) expected, 4096).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortNullableIList4096MapMin()
        {
            const ushort expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToIList();

            double result = ZEnumerable.Average(source, arg => (ushort?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
        
              
                        
        [TestMethod]
        public void TestAverageushortNullableIListNoOverflow()
        {
            const ushort expected = ushort.MaxValue;
            var source = Enumerable.Repeat((ushort?) expected, 2).ToIList();
            double result = ZEnumerable.Average(source);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                
        [TestMethod]
        public void TestAverageushortNullableIListMapNoOverflow()
        {
            const ushort expected = ushort.MaxValue;
            var source = Enumerable.Repeat(new { X = (ushort?) expected}, 2).ToIList();
            double result = ZEnumerable.Average(source, arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                                
        #endregion
    
        #region int?             
            

         
        [TestMethod]
        public void TestAverageintNullableArrayNullOrEmpty()
        {        
            int?[] nullSource = null;

            try
            {
                ZEnumerable.Average(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            int?[] emptySource = new int?[0].ToArray();
            try
            {
                ZEnumerable.Average(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestAverageintNullableArrayMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<int?,int?>((int?) arg, (int?) arg)).ToArray();
            Func<KeyValuePair<int?, int?>, int?> nullMap = null;
            try
            {
                ZEnumerable.Average(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToArray();
            try
            {
                ZEnumerable.Average(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Average(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }
         
                            [TestMethod]
        public void TestAverageintNullableArray1()
        {            
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat((int?) expected, 1).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintNullableArray1Map()
        {
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToArray();

            double result = ZEnumerable.Average(source, arg => (int?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageintNullableArray1Min()
        {            
            const int expected = 1;
            var source = Enumerable.Repeat((int?) expected, 1).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintNullableArray1MapMin()
        {
            const int expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToArray();

            double result = ZEnumerable.Average(source, arg => (int?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageintNullableArray2()
        {            
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat((int?) expected, 2).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintNullableArray2Map()
        {
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToArray();

            double result = ZEnumerable.Average(source, arg => (int?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageintNullableArray2Min()
        {            
            const int expected = 1;
            var source = Enumerable.Repeat((int?) expected, 2).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintNullableArray2MapMin()
        {
            const int expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToArray();

            double result = ZEnumerable.Average(source, arg => (int?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageintNullableArray3()
        {            
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat((int?) expected, 3).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintNullableArray3Map()
        {
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToArray();

            double result = ZEnumerable.Average(source, arg => (int?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageintNullableArray3Min()
        {            
            const int expected = 1;
            var source = Enumerable.Repeat((int?) expected, 3).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintNullableArray3MapMin()
        {
            const int expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToArray();

            double result = ZEnumerable.Average(source, arg => (int?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageintNullableArray4()
        {            
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat((int?) expected, 4).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintNullableArray4Map()
        {
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToArray();

            double result = ZEnumerable.Average(source, arg => (int?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageintNullableArray4Min()
        {            
            const int expected = 1;
            var source = Enumerable.Repeat((int?) expected, 4).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintNullableArray4MapMin()
        {
            const int expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToArray();

            double result = ZEnumerable.Average(source, arg => (int?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageintNullableArray100()
        {            
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat((int?) expected, 100).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintNullableArray100Map()
        {
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToArray();

            double result = ZEnumerable.Average(source, arg => (int?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageintNullableArray100Min()
        {            
            const int expected = 1;
            var source = Enumerable.Repeat((int?) expected, 100).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintNullableArray100MapMin()
        {
            const int expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToArray();

            double result = ZEnumerable.Average(source, arg => (int?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageintNullableArray4096()
        {            
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat((int?) expected, 4096).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintNullableArray4096Map()
        {
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToArray();

            double result = ZEnumerable.Average(source, arg => (int?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageintNullableArray4096Min()
        {            
            const int expected = 1;
            var source = Enumerable.Repeat((int?) expected, 4096).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintNullableArray4096MapMin()
        {
            const int expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToArray();

            double result = ZEnumerable.Average(source, arg => (int?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
        
              
                        
        [TestMethod]
        public void TestAverageintNullableArrayNoOverflow()
        {
            const int expected = int.MaxValue;
            var source = Enumerable.Repeat((int?) expected, 2).ToArray();
            double result = ZEnumerable.Average(source);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                
        [TestMethod]
        public void TestAverageintNullableArrayMapNoOverflow()
        {
            const int expected = int.MaxValue;
            var source = Enumerable.Repeat(new { X = (int?) expected}, 2).ToArray();
            double result = ZEnumerable.Average(source, arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                            

         
        [TestMethod]
        public void TestAverageintNullableListNullOrEmpty()
        {        
            List<int?> nullSource = null;

            try
            {
                ZEnumerable.Average(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            List<int?> emptySource = new int?[0].ToList();
            try
            {
                ZEnumerable.Average(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestAverageintNullableListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<int?,int?>((int?) arg, (int?) arg)).ToList();
            Func<KeyValuePair<int?, int?>, int?> nullMap = null;
            try
            {
                ZEnumerable.Average(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToList();
            try
            {
                ZEnumerable.Average(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Average(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }
         
                            [TestMethod]
        public void TestAverageintNullableList1()
        {            
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat((int?) expected, 1).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintNullableList1Map()
        {
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToList();

            double result = ZEnumerable.Average(source, arg => (int?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageintNullableList1Min()
        {            
            const int expected = 1;
            var source = Enumerable.Repeat((int?) expected, 1).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintNullableList1MapMin()
        {
            const int expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToList();

            double result = ZEnumerable.Average(source, arg => (int?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageintNullableList2()
        {            
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat((int?) expected, 2).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintNullableList2Map()
        {
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToList();

            double result = ZEnumerable.Average(source, arg => (int?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageintNullableList2Min()
        {            
            const int expected = 1;
            var source = Enumerable.Repeat((int?) expected, 2).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintNullableList2MapMin()
        {
            const int expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToList();

            double result = ZEnumerable.Average(source, arg => (int?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageintNullableList3()
        {            
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat((int?) expected, 3).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintNullableList3Map()
        {
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToList();

            double result = ZEnumerable.Average(source, arg => (int?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageintNullableList3Min()
        {            
            const int expected = 1;
            var source = Enumerable.Repeat((int?) expected, 3).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintNullableList3MapMin()
        {
            const int expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToList();

            double result = ZEnumerable.Average(source, arg => (int?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageintNullableList4()
        {            
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat((int?) expected, 4).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintNullableList4Map()
        {
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToList();

            double result = ZEnumerable.Average(source, arg => (int?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageintNullableList4Min()
        {            
            const int expected = 1;
            var source = Enumerable.Repeat((int?) expected, 4).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintNullableList4MapMin()
        {
            const int expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToList();

            double result = ZEnumerable.Average(source, arg => (int?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageintNullableList100()
        {            
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat((int?) expected, 100).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintNullableList100Map()
        {
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToList();

            double result = ZEnumerable.Average(source, arg => (int?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageintNullableList100Min()
        {            
            const int expected = 1;
            var source = Enumerable.Repeat((int?) expected, 100).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintNullableList100MapMin()
        {
            const int expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToList();

            double result = ZEnumerable.Average(source, arg => (int?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageintNullableList4096()
        {            
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat((int?) expected, 4096).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintNullableList4096Map()
        {
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToList();

            double result = ZEnumerable.Average(source, arg => (int?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageintNullableList4096Min()
        {            
            const int expected = 1;
            var source = Enumerable.Repeat((int?) expected, 4096).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintNullableList4096MapMin()
        {
            const int expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToList();

            double result = ZEnumerable.Average(source, arg => (int?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
        
              
                        
        [TestMethod]
        public void TestAverageintNullableListNoOverflow()
        {
            const int expected = int.MaxValue;
            var source = Enumerable.Repeat((int?) expected, 2).ToList();
            double result = ZEnumerable.Average(source);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                
        [TestMethod]
        public void TestAverageintNullableListMapNoOverflow()
        {
            const int expected = int.MaxValue;
            var source = Enumerable.Repeat(new { X = (int?) expected}, 2).ToList();
            double result = ZEnumerable.Average(source, arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                            

         
        [TestMethod]
        public void TestAverageintNullableIListNullOrEmpty()
        {        
            IList<int?> nullSource = null;

            try
            {
                ZEnumerable.Average(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            IList<int?> emptySource = new int?[0].ToIList();
            try
            {
                ZEnumerable.Average(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestAverageintNullableIListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<int?,int?>((int?) arg, (int?) arg)).ToIList();
            Func<KeyValuePair<int?, int?>, int?> nullMap = null;
            try
            {
                ZEnumerable.Average(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToIList();
            try
            {
                ZEnumerable.Average(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Average(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }
         
                            [TestMethod]
        public void TestAverageintNullableIList1()
        {            
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat((int?) expected, 1).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintNullableIList1Map()
        {
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToIList();

            double result = ZEnumerable.Average(source, arg => (int?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageintNullableIList1Min()
        {            
            const int expected = 1;
            var source = Enumerable.Repeat((int?) expected, 1).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintNullableIList1MapMin()
        {
            const int expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToIList();

            double result = ZEnumerable.Average(source, arg => (int?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageintNullableIList2()
        {            
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat((int?) expected, 2).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintNullableIList2Map()
        {
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToIList();

            double result = ZEnumerable.Average(source, arg => (int?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageintNullableIList2Min()
        {            
            const int expected = 1;
            var source = Enumerable.Repeat((int?) expected, 2).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintNullableIList2MapMin()
        {
            const int expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToIList();

            double result = ZEnumerable.Average(source, arg => (int?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageintNullableIList3()
        {            
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat((int?) expected, 3).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintNullableIList3Map()
        {
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToIList();

            double result = ZEnumerable.Average(source, arg => (int?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageintNullableIList3Min()
        {            
            const int expected = 1;
            var source = Enumerable.Repeat((int?) expected, 3).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintNullableIList3MapMin()
        {
            const int expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToIList();

            double result = ZEnumerable.Average(source, arg => (int?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageintNullableIList4()
        {            
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat((int?) expected, 4).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintNullableIList4Map()
        {
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToIList();

            double result = ZEnumerable.Average(source, arg => (int?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageintNullableIList4Min()
        {            
            const int expected = 1;
            var source = Enumerable.Repeat((int?) expected, 4).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintNullableIList4MapMin()
        {
            const int expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToIList();

            double result = ZEnumerable.Average(source, arg => (int?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageintNullableIList100()
        {            
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat((int?) expected, 100).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintNullableIList100Map()
        {
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToIList();

            double result = ZEnumerable.Average(source, arg => (int?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageintNullableIList100Min()
        {            
            const int expected = 1;
            var source = Enumerable.Repeat((int?) expected, 100).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintNullableIList100MapMin()
        {
            const int expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToIList();

            double result = ZEnumerable.Average(source, arg => (int?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageintNullableIList4096()
        {            
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat((int?) expected, 4096).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintNullableIList4096Map()
        {
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToIList();

            double result = ZEnumerable.Average(source, arg => (int?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageintNullableIList4096Min()
        {            
            const int expected = 1;
            var source = Enumerable.Repeat((int?) expected, 4096).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintNullableIList4096MapMin()
        {
            const int expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToIList();

            double result = ZEnumerable.Average(source, arg => (int?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
        
              
                        
        [TestMethod]
        public void TestAverageintNullableIListNoOverflow()
        {
            const int expected = int.MaxValue;
            var source = Enumerable.Repeat((int?) expected, 2).ToIList();
            double result = ZEnumerable.Average(source);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                
        [TestMethod]
        public void TestAverageintNullableIListMapNoOverflow()
        {
            const int expected = int.MaxValue;
            var source = Enumerable.Repeat(new { X = (int?) expected}, 2).ToIList();
            double result = ZEnumerable.Average(source, arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                                
        #endregion
    
        #region uint?             
            

         
        [TestMethod]
        public void TestAverageuintNullableArrayNullOrEmpty()
        {        
            uint?[] nullSource = null;

            try
            {
                ZEnumerable.Average(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            uint?[] emptySource = new uint?[0].ToArray();
            try
            {
                ZEnumerable.Average(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestAverageuintNullableArrayMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<uint?,uint?>((uint?) arg, (uint?) arg)).ToArray();
            Func<KeyValuePair<uint?, uint?>, uint?> nullMap = null;
            try
            {
                ZEnumerable.Average(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToArray();
            try
            {
                ZEnumerable.Average(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Average(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }
         
                            [TestMethod]
        public void TestAverageuintNullableArray1()
        {            
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat((uint?) expected, 1).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintNullableArray1Map()
        {
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToArray();

            double result = ZEnumerable.Average(source, arg => (uint?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageuintNullableArray1Min()
        {            
            const uint expected = 1;
            var source = Enumerable.Repeat((uint?) expected, 1).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintNullableArray1MapMin()
        {
            const uint expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToArray();

            double result = ZEnumerable.Average(source, arg => (uint?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageuintNullableArray2()
        {            
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat((uint?) expected, 2).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintNullableArray2Map()
        {
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToArray();

            double result = ZEnumerable.Average(source, arg => (uint?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageuintNullableArray2Min()
        {            
            const uint expected = 1;
            var source = Enumerable.Repeat((uint?) expected, 2).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintNullableArray2MapMin()
        {
            const uint expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToArray();

            double result = ZEnumerable.Average(source, arg => (uint?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageuintNullableArray3()
        {            
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat((uint?) expected, 3).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintNullableArray3Map()
        {
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToArray();

            double result = ZEnumerable.Average(source, arg => (uint?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageuintNullableArray3Min()
        {            
            const uint expected = 1;
            var source = Enumerable.Repeat((uint?) expected, 3).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintNullableArray3MapMin()
        {
            const uint expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToArray();

            double result = ZEnumerable.Average(source, arg => (uint?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageuintNullableArray4()
        {            
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat((uint?) expected, 4).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintNullableArray4Map()
        {
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToArray();

            double result = ZEnumerable.Average(source, arg => (uint?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageuintNullableArray4Min()
        {            
            const uint expected = 1;
            var source = Enumerable.Repeat((uint?) expected, 4).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintNullableArray4MapMin()
        {
            const uint expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToArray();

            double result = ZEnumerable.Average(source, arg => (uint?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageuintNullableArray100()
        {            
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat((uint?) expected, 100).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintNullableArray100Map()
        {
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToArray();

            double result = ZEnumerable.Average(source, arg => (uint?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageuintNullableArray100Min()
        {            
            const uint expected = 1;
            var source = Enumerable.Repeat((uint?) expected, 100).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintNullableArray100MapMin()
        {
            const uint expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToArray();

            double result = ZEnumerable.Average(source, arg => (uint?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageuintNullableArray4096()
        {            
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat((uint?) expected, 4096).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintNullableArray4096Map()
        {
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToArray();

            double result = ZEnumerable.Average(source, arg => (uint?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageuintNullableArray4096Min()
        {            
            const uint expected = 1;
            var source = Enumerable.Repeat((uint?) expected, 4096).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintNullableArray4096MapMin()
        {
            const uint expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToArray();

            double result = ZEnumerable.Average(source, arg => (uint?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
        
              
                        
        [TestMethod]
        public void TestAverageuintNullableArrayNoOverflow()
        {
            const uint expected = uint.MaxValue;
            var source = Enumerable.Repeat((uint?) expected, 2).ToArray();
            double result = ZEnumerable.Average(source);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                
        [TestMethod]
        public void TestAverageuintNullableArrayMapNoOverflow()
        {
            const uint expected = uint.MaxValue;
            var source = Enumerable.Repeat(new { X = (uint?) expected}, 2).ToArray();
            double result = ZEnumerable.Average(source, arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                            

         
        [TestMethod]
        public void TestAverageuintNullableListNullOrEmpty()
        {        
            List<uint?> nullSource = null;

            try
            {
                ZEnumerable.Average(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            List<uint?> emptySource = new uint?[0].ToList();
            try
            {
                ZEnumerable.Average(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestAverageuintNullableListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<uint?,uint?>((uint?) arg, (uint?) arg)).ToList();
            Func<KeyValuePair<uint?, uint?>, uint?> nullMap = null;
            try
            {
                ZEnumerable.Average(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToList();
            try
            {
                ZEnumerable.Average(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Average(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }
         
                            [TestMethod]
        public void TestAverageuintNullableList1()
        {            
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat((uint?) expected, 1).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintNullableList1Map()
        {
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToList();

            double result = ZEnumerable.Average(source, arg => (uint?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageuintNullableList1Min()
        {            
            const uint expected = 1;
            var source = Enumerable.Repeat((uint?) expected, 1).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintNullableList1MapMin()
        {
            const uint expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToList();

            double result = ZEnumerable.Average(source, arg => (uint?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageuintNullableList2()
        {            
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat((uint?) expected, 2).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintNullableList2Map()
        {
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToList();

            double result = ZEnumerable.Average(source, arg => (uint?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageuintNullableList2Min()
        {            
            const uint expected = 1;
            var source = Enumerable.Repeat((uint?) expected, 2).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintNullableList2MapMin()
        {
            const uint expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToList();

            double result = ZEnumerable.Average(source, arg => (uint?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageuintNullableList3()
        {            
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat((uint?) expected, 3).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintNullableList3Map()
        {
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToList();

            double result = ZEnumerable.Average(source, arg => (uint?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageuintNullableList3Min()
        {            
            const uint expected = 1;
            var source = Enumerable.Repeat((uint?) expected, 3).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintNullableList3MapMin()
        {
            const uint expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToList();

            double result = ZEnumerable.Average(source, arg => (uint?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageuintNullableList4()
        {            
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat((uint?) expected, 4).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintNullableList4Map()
        {
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToList();

            double result = ZEnumerable.Average(source, arg => (uint?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageuintNullableList4Min()
        {            
            const uint expected = 1;
            var source = Enumerable.Repeat((uint?) expected, 4).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintNullableList4MapMin()
        {
            const uint expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToList();

            double result = ZEnumerable.Average(source, arg => (uint?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageuintNullableList100()
        {            
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat((uint?) expected, 100).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintNullableList100Map()
        {
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToList();

            double result = ZEnumerable.Average(source, arg => (uint?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageuintNullableList100Min()
        {            
            const uint expected = 1;
            var source = Enumerable.Repeat((uint?) expected, 100).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintNullableList100MapMin()
        {
            const uint expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToList();

            double result = ZEnumerable.Average(source, arg => (uint?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageuintNullableList4096()
        {            
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat((uint?) expected, 4096).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintNullableList4096Map()
        {
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToList();

            double result = ZEnumerable.Average(source, arg => (uint?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageuintNullableList4096Min()
        {            
            const uint expected = 1;
            var source = Enumerable.Repeat((uint?) expected, 4096).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintNullableList4096MapMin()
        {
            const uint expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToList();

            double result = ZEnumerable.Average(source, arg => (uint?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
        
              
                        
        [TestMethod]
        public void TestAverageuintNullableListNoOverflow()
        {
            const uint expected = uint.MaxValue;
            var source = Enumerable.Repeat((uint?) expected, 2).ToList();
            double result = ZEnumerable.Average(source);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                
        [TestMethod]
        public void TestAverageuintNullableListMapNoOverflow()
        {
            const uint expected = uint.MaxValue;
            var source = Enumerable.Repeat(new { X = (uint?) expected}, 2).ToList();
            double result = ZEnumerable.Average(source, arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                            

         
        [TestMethod]
        public void TestAverageuintNullableIListNullOrEmpty()
        {        
            IList<uint?> nullSource = null;

            try
            {
                ZEnumerable.Average(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            IList<uint?> emptySource = new uint?[0].ToIList();
            try
            {
                ZEnumerable.Average(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestAverageuintNullableIListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<uint?,uint?>((uint?) arg, (uint?) arg)).ToIList();
            Func<KeyValuePair<uint?, uint?>, uint?> nullMap = null;
            try
            {
                ZEnumerable.Average(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToIList();
            try
            {
                ZEnumerable.Average(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Average(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }
         
                            [TestMethod]
        public void TestAverageuintNullableIList1()
        {            
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat((uint?) expected, 1).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintNullableIList1Map()
        {
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToIList();

            double result = ZEnumerable.Average(source, arg => (uint?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageuintNullableIList1Min()
        {            
            const uint expected = 1;
            var source = Enumerable.Repeat((uint?) expected, 1).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintNullableIList1MapMin()
        {
            const uint expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToIList();

            double result = ZEnumerable.Average(source, arg => (uint?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageuintNullableIList2()
        {            
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat((uint?) expected, 2).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintNullableIList2Map()
        {
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToIList();

            double result = ZEnumerable.Average(source, arg => (uint?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageuintNullableIList2Min()
        {            
            const uint expected = 1;
            var source = Enumerable.Repeat((uint?) expected, 2).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintNullableIList2MapMin()
        {
            const uint expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToIList();

            double result = ZEnumerable.Average(source, arg => (uint?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageuintNullableIList3()
        {            
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat((uint?) expected, 3).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintNullableIList3Map()
        {
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToIList();

            double result = ZEnumerable.Average(source, arg => (uint?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageuintNullableIList3Min()
        {            
            const uint expected = 1;
            var source = Enumerable.Repeat((uint?) expected, 3).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintNullableIList3MapMin()
        {
            const uint expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToIList();

            double result = ZEnumerable.Average(source, arg => (uint?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageuintNullableIList4()
        {            
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat((uint?) expected, 4).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintNullableIList4Map()
        {
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToIList();

            double result = ZEnumerable.Average(source, arg => (uint?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageuintNullableIList4Min()
        {            
            const uint expected = 1;
            var source = Enumerable.Repeat((uint?) expected, 4).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintNullableIList4MapMin()
        {
            const uint expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToIList();

            double result = ZEnumerable.Average(source, arg => (uint?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageuintNullableIList100()
        {            
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat((uint?) expected, 100).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintNullableIList100Map()
        {
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToIList();

            double result = ZEnumerable.Average(source, arg => (uint?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageuintNullableIList100Min()
        {            
            const uint expected = 1;
            var source = Enumerable.Repeat((uint?) expected, 100).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintNullableIList100MapMin()
        {
            const uint expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToIList();

            double result = ZEnumerable.Average(source, arg => (uint?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageuintNullableIList4096()
        {            
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat((uint?) expected, 4096).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintNullableIList4096Map()
        {
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToIList();

            double result = ZEnumerable.Average(source, arg => (uint?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageuintNullableIList4096Min()
        {            
            const uint expected = 1;
            var source = Enumerable.Repeat((uint?) expected, 4096).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintNullableIList4096MapMin()
        {
            const uint expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToIList();

            double result = ZEnumerable.Average(source, arg => (uint?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
        
              
                        
        [TestMethod]
        public void TestAverageuintNullableIListNoOverflow()
        {
            const uint expected = uint.MaxValue;
            var source = Enumerable.Repeat((uint?) expected, 2).ToIList();
            double result = ZEnumerable.Average(source);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                
        [TestMethod]
        public void TestAverageuintNullableIListMapNoOverflow()
        {
            const uint expected = uint.MaxValue;
            var source = Enumerable.Repeat(new { X = (uint?) expected}, 2).ToIList();
            double result = ZEnumerable.Average(source, arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                                
        #endregion
    
        #region long?             
            

         
        [TestMethod]
        public void TestAveragelongNullableArrayNullOrEmpty()
        {        
            long?[] nullSource = null;

            try
            {
                ZEnumerable.Average(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            long?[] emptySource = new long?[0].ToArray();
            try
            {
                ZEnumerable.Average(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestAveragelongNullableArrayMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<long?,long?>((long?) arg, (long?) arg)).ToArray();
            Func<KeyValuePair<long?, long?>, long?> nullMap = null;
            try
            {
                ZEnumerable.Average(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToArray();
            try
            {
                ZEnumerable.Average(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Average(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }
         
                            [TestMethod]
        public void TestAveragelongNullableArray1()
        {            
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat((long?) expected, 1).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongNullableArray1Map()
        {
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToArray();

            double result = ZEnumerable.Average(source, arg => (long?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragelongNullableArray1Min()
        {            
            const long expected = 1;
            var source = Enumerable.Repeat((long?) expected, 1).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongNullableArray1MapMin()
        {
            const long expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToArray();

            double result = ZEnumerable.Average(source, arg => (long?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragelongNullableArray2()
        {            
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat((long?) expected, 2).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongNullableArray2Map()
        {
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToArray();

            double result = ZEnumerable.Average(source, arg => (long?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragelongNullableArray2Min()
        {            
            const long expected = 1;
            var source = Enumerable.Repeat((long?) expected, 2).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongNullableArray2MapMin()
        {
            const long expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToArray();

            double result = ZEnumerable.Average(source, arg => (long?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragelongNullableArray3()
        {            
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat((long?) expected, 3).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongNullableArray3Map()
        {
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToArray();

            double result = ZEnumerable.Average(source, arg => (long?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragelongNullableArray3Min()
        {            
            const long expected = 1;
            var source = Enumerable.Repeat((long?) expected, 3).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongNullableArray3MapMin()
        {
            const long expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToArray();

            double result = ZEnumerable.Average(source, arg => (long?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragelongNullableArray4()
        {            
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat((long?) expected, 4).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongNullableArray4Map()
        {
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToArray();

            double result = ZEnumerable.Average(source, arg => (long?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragelongNullableArray4Min()
        {            
            const long expected = 1;
            var source = Enumerable.Repeat((long?) expected, 4).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongNullableArray4MapMin()
        {
            const long expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToArray();

            double result = ZEnumerable.Average(source, arg => (long?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragelongNullableArray100()
        {            
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat((long?) expected, 100).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongNullableArray100Map()
        {
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToArray();

            double result = ZEnumerable.Average(source, arg => (long?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragelongNullableArray100Min()
        {            
            const long expected = 1;
            var source = Enumerable.Repeat((long?) expected, 100).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongNullableArray100MapMin()
        {
            const long expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToArray();

            double result = ZEnumerable.Average(source, arg => (long?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragelongNullableArray4096()
        {            
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat((long?) expected, 4096).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongNullableArray4096Map()
        {
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToArray();

            double result = ZEnumerable.Average(source, arg => (long?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragelongNullableArray4096Min()
        {            
            const long expected = 1;
            var source = Enumerable.Repeat((long?) expected, 4096).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongNullableArray4096MapMin()
        {
            const long expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToArray();

            double result = ZEnumerable.Average(source, arg => (long?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
        
              
                        
        [TestMethod]
        public void TestAveragelongNullableArrayNoOverflow()
        {
            const long expected = long.MaxValue;
            var source = Enumerable.Repeat((long?) expected, 2).ToArray();
            double result = ZEnumerable.Average(source);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                
        [TestMethod]
        public void TestAveragelongNullableArrayMapNoOverflow()
        {
            const long expected = long.MaxValue;
            var source = Enumerable.Repeat(new { X = (long?) expected}, 2).ToArray();
            double result = ZEnumerable.Average(source, arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                            

         
        [TestMethod]
        public void TestAveragelongNullableListNullOrEmpty()
        {        
            List<long?> nullSource = null;

            try
            {
                ZEnumerable.Average(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            List<long?> emptySource = new long?[0].ToList();
            try
            {
                ZEnumerable.Average(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestAveragelongNullableListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<long?,long?>((long?) arg, (long?) arg)).ToList();
            Func<KeyValuePair<long?, long?>, long?> nullMap = null;
            try
            {
                ZEnumerable.Average(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToList();
            try
            {
                ZEnumerable.Average(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Average(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }
         
                            [TestMethod]
        public void TestAveragelongNullableList1()
        {            
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat((long?) expected, 1).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongNullableList1Map()
        {
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToList();

            double result = ZEnumerable.Average(source, arg => (long?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragelongNullableList1Min()
        {            
            const long expected = 1;
            var source = Enumerable.Repeat((long?) expected, 1).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongNullableList1MapMin()
        {
            const long expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToList();

            double result = ZEnumerable.Average(source, arg => (long?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragelongNullableList2()
        {            
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat((long?) expected, 2).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongNullableList2Map()
        {
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToList();

            double result = ZEnumerable.Average(source, arg => (long?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragelongNullableList2Min()
        {            
            const long expected = 1;
            var source = Enumerable.Repeat((long?) expected, 2).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongNullableList2MapMin()
        {
            const long expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToList();

            double result = ZEnumerable.Average(source, arg => (long?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragelongNullableList3()
        {            
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat((long?) expected, 3).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongNullableList3Map()
        {
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToList();

            double result = ZEnumerable.Average(source, arg => (long?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragelongNullableList3Min()
        {            
            const long expected = 1;
            var source = Enumerable.Repeat((long?) expected, 3).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongNullableList3MapMin()
        {
            const long expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToList();

            double result = ZEnumerable.Average(source, arg => (long?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragelongNullableList4()
        {            
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat((long?) expected, 4).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongNullableList4Map()
        {
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToList();

            double result = ZEnumerable.Average(source, arg => (long?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragelongNullableList4Min()
        {            
            const long expected = 1;
            var source = Enumerable.Repeat((long?) expected, 4).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongNullableList4MapMin()
        {
            const long expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToList();

            double result = ZEnumerable.Average(source, arg => (long?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragelongNullableList100()
        {            
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat((long?) expected, 100).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongNullableList100Map()
        {
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToList();

            double result = ZEnumerable.Average(source, arg => (long?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragelongNullableList100Min()
        {            
            const long expected = 1;
            var source = Enumerable.Repeat((long?) expected, 100).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongNullableList100MapMin()
        {
            const long expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToList();

            double result = ZEnumerable.Average(source, arg => (long?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragelongNullableList4096()
        {            
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat((long?) expected, 4096).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongNullableList4096Map()
        {
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToList();

            double result = ZEnumerable.Average(source, arg => (long?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragelongNullableList4096Min()
        {            
            const long expected = 1;
            var source = Enumerable.Repeat((long?) expected, 4096).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongNullableList4096MapMin()
        {
            const long expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToList();

            double result = ZEnumerable.Average(source, arg => (long?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
        
              
                        
        [TestMethod]
        public void TestAveragelongNullableListNoOverflow()
        {
            const long expected = long.MaxValue;
            var source = Enumerable.Repeat((long?) expected, 2).ToList();
            double result = ZEnumerable.Average(source);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                
        [TestMethod]
        public void TestAveragelongNullableListMapNoOverflow()
        {
            const long expected = long.MaxValue;
            var source = Enumerable.Repeat(new { X = (long?) expected}, 2).ToList();
            double result = ZEnumerable.Average(source, arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                            

         
        [TestMethod]
        public void TestAveragelongNullableIListNullOrEmpty()
        {        
            IList<long?> nullSource = null;

            try
            {
                ZEnumerable.Average(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            IList<long?> emptySource = new long?[0].ToIList();
            try
            {
                ZEnumerable.Average(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestAveragelongNullableIListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<long?,long?>((long?) arg, (long?) arg)).ToIList();
            Func<KeyValuePair<long?, long?>, long?> nullMap = null;
            try
            {
                ZEnumerable.Average(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToIList();
            try
            {
                ZEnumerable.Average(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Average(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }
         
                            [TestMethod]
        public void TestAveragelongNullableIList1()
        {            
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat((long?) expected, 1).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongNullableIList1Map()
        {
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToIList();

            double result = ZEnumerable.Average(source, arg => (long?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragelongNullableIList1Min()
        {            
            const long expected = 1;
            var source = Enumerable.Repeat((long?) expected, 1).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongNullableIList1MapMin()
        {
            const long expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToIList();

            double result = ZEnumerable.Average(source, arg => (long?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragelongNullableIList2()
        {            
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat((long?) expected, 2).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongNullableIList2Map()
        {
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToIList();

            double result = ZEnumerable.Average(source, arg => (long?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragelongNullableIList2Min()
        {            
            const long expected = 1;
            var source = Enumerable.Repeat((long?) expected, 2).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongNullableIList2MapMin()
        {
            const long expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToIList();

            double result = ZEnumerable.Average(source, arg => (long?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragelongNullableIList3()
        {            
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat((long?) expected, 3).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongNullableIList3Map()
        {
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToIList();

            double result = ZEnumerable.Average(source, arg => (long?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragelongNullableIList3Min()
        {            
            const long expected = 1;
            var source = Enumerable.Repeat((long?) expected, 3).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongNullableIList3MapMin()
        {
            const long expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToIList();

            double result = ZEnumerable.Average(source, arg => (long?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragelongNullableIList4()
        {            
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat((long?) expected, 4).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongNullableIList4Map()
        {
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToIList();

            double result = ZEnumerable.Average(source, arg => (long?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragelongNullableIList4Min()
        {            
            const long expected = 1;
            var source = Enumerable.Repeat((long?) expected, 4).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongNullableIList4MapMin()
        {
            const long expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToIList();

            double result = ZEnumerable.Average(source, arg => (long?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragelongNullableIList100()
        {            
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat((long?) expected, 100).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongNullableIList100Map()
        {
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToIList();

            double result = ZEnumerable.Average(source, arg => (long?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragelongNullableIList100Min()
        {            
            const long expected = 1;
            var source = Enumerable.Repeat((long?) expected, 100).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongNullableIList100MapMin()
        {
            const long expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToIList();

            double result = ZEnumerable.Average(source, arg => (long?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragelongNullableIList4096()
        {            
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat((long?) expected, 4096).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongNullableIList4096Map()
        {
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToIList();

            double result = ZEnumerable.Average(source, arg => (long?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragelongNullableIList4096Min()
        {            
            const long expected = 1;
            var source = Enumerable.Repeat((long?) expected, 4096).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongNullableIList4096MapMin()
        {
            const long expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToIList();

            double result = ZEnumerable.Average(source, arg => (long?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
        
              
                        
        [TestMethod]
        public void TestAveragelongNullableIListNoOverflow()
        {
            const long expected = long.MaxValue;
            var source = Enumerable.Repeat((long?) expected, 2).ToIList();
            double result = ZEnumerable.Average(source);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                
        [TestMethod]
        public void TestAveragelongNullableIListMapNoOverflow()
        {
            const long expected = long.MaxValue;
            var source = Enumerable.Repeat(new { X = (long?) expected}, 2).ToIList();
            double result = ZEnumerable.Average(source, arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                                
        #endregion
    
        #region ulong?             
            

         
        [TestMethod]
        public void TestAverageulongNullableArrayNullOrEmpty()
        {        
            ulong?[] nullSource = null;

            try
            {
                ZEnumerable.Average(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            ulong?[] emptySource = new ulong?[0].ToArray();
            try
            {
                ZEnumerable.Average(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestAverageulongNullableArrayMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<ulong?,ulong?>((ulong?) arg, (ulong?) arg)).ToArray();
            Func<KeyValuePair<ulong?, ulong?>, ulong?> nullMap = null;
            try
            {
                ZEnumerable.Average(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToArray();
            try
            {
                ZEnumerable.Average(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Average(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }
         
                            [TestMethod]
        public void TestAverageulongNullableArray1()
        {            
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat((ulong?) expected, 1).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongNullableArray1Map()
        {
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToArray();

            double result = ZEnumerable.Average(source, arg => (ulong?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageulongNullableArray1Min()
        {            
            const ulong expected = 1;
            var source = Enumerable.Repeat((ulong?) expected, 1).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongNullableArray1MapMin()
        {
            const ulong expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToArray();

            double result = ZEnumerable.Average(source, arg => (ulong?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageulongNullableArray2()
        {            
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat((ulong?) expected, 2).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongNullableArray2Map()
        {
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToArray();

            double result = ZEnumerable.Average(source, arg => (ulong?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageulongNullableArray2Min()
        {            
            const ulong expected = 1;
            var source = Enumerable.Repeat((ulong?) expected, 2).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongNullableArray2MapMin()
        {
            const ulong expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToArray();

            double result = ZEnumerable.Average(source, arg => (ulong?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageulongNullableArray3()
        {            
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat((ulong?) expected, 3).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongNullableArray3Map()
        {
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToArray();

            double result = ZEnumerable.Average(source, arg => (ulong?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageulongNullableArray3Min()
        {            
            const ulong expected = 1;
            var source = Enumerable.Repeat((ulong?) expected, 3).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongNullableArray3MapMin()
        {
            const ulong expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToArray();

            double result = ZEnumerable.Average(source, arg => (ulong?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageulongNullableArray4()
        {            
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat((ulong?) expected, 4).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongNullableArray4Map()
        {
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToArray();

            double result = ZEnumerable.Average(source, arg => (ulong?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageulongNullableArray4Min()
        {            
            const ulong expected = 1;
            var source = Enumerable.Repeat((ulong?) expected, 4).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongNullableArray4MapMin()
        {
            const ulong expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToArray();

            double result = ZEnumerable.Average(source, arg => (ulong?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageulongNullableArray100()
        {            
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat((ulong?) expected, 100).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongNullableArray100Map()
        {
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToArray();

            double result = ZEnumerable.Average(source, arg => (ulong?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageulongNullableArray100Min()
        {            
            const ulong expected = 1;
            var source = Enumerable.Repeat((ulong?) expected, 100).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongNullableArray100MapMin()
        {
            const ulong expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToArray();

            double result = ZEnumerable.Average(source, arg => (ulong?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageulongNullableArray4096()
        {            
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat((ulong?) expected, 4096).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongNullableArray4096Map()
        {
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToArray();

            double result = ZEnumerable.Average(source, arg => (ulong?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageulongNullableArray4096Min()
        {            
            const ulong expected = 1;
            var source = Enumerable.Repeat((ulong?) expected, 4096).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongNullableArray4096MapMin()
        {
            const ulong expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToArray();

            double result = ZEnumerable.Average(source, arg => (ulong?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
        
              
                        
        [TestMethod]
        public void TestAverageulongNullableArrayNoOverflow()
        {
            const ulong expected = ulong.MaxValue;
            var source = Enumerable.Repeat((ulong?) expected, 2).ToArray();
            double result = ZEnumerable.Average(source);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                
        [TestMethod]
        public void TestAverageulongNullableArrayMapNoOverflow()
        {
            const ulong expected = ulong.MaxValue;
            var source = Enumerable.Repeat(new { X = (ulong?) expected}, 2).ToArray();
            double result = ZEnumerable.Average(source, arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                            

         
        [TestMethod]
        public void TestAverageulongNullableListNullOrEmpty()
        {        
            List<ulong?> nullSource = null;

            try
            {
                ZEnumerable.Average(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            List<ulong?> emptySource = new ulong?[0].ToList();
            try
            {
                ZEnumerable.Average(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestAverageulongNullableListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<ulong?,ulong?>((ulong?) arg, (ulong?) arg)).ToList();
            Func<KeyValuePair<ulong?, ulong?>, ulong?> nullMap = null;
            try
            {
                ZEnumerable.Average(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToList();
            try
            {
                ZEnumerable.Average(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Average(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }
         
                            [TestMethod]
        public void TestAverageulongNullableList1()
        {            
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat((ulong?) expected, 1).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongNullableList1Map()
        {
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToList();

            double result = ZEnumerable.Average(source, arg => (ulong?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageulongNullableList1Min()
        {            
            const ulong expected = 1;
            var source = Enumerable.Repeat((ulong?) expected, 1).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongNullableList1MapMin()
        {
            const ulong expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToList();

            double result = ZEnumerable.Average(source, arg => (ulong?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageulongNullableList2()
        {            
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat((ulong?) expected, 2).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongNullableList2Map()
        {
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToList();

            double result = ZEnumerable.Average(source, arg => (ulong?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageulongNullableList2Min()
        {            
            const ulong expected = 1;
            var source = Enumerable.Repeat((ulong?) expected, 2).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongNullableList2MapMin()
        {
            const ulong expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToList();

            double result = ZEnumerable.Average(source, arg => (ulong?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageulongNullableList3()
        {            
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat((ulong?) expected, 3).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongNullableList3Map()
        {
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToList();

            double result = ZEnumerable.Average(source, arg => (ulong?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageulongNullableList3Min()
        {            
            const ulong expected = 1;
            var source = Enumerable.Repeat((ulong?) expected, 3).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongNullableList3MapMin()
        {
            const ulong expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToList();

            double result = ZEnumerable.Average(source, arg => (ulong?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageulongNullableList4()
        {            
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat((ulong?) expected, 4).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongNullableList4Map()
        {
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToList();

            double result = ZEnumerable.Average(source, arg => (ulong?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageulongNullableList4Min()
        {            
            const ulong expected = 1;
            var source = Enumerable.Repeat((ulong?) expected, 4).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongNullableList4MapMin()
        {
            const ulong expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToList();

            double result = ZEnumerable.Average(source, arg => (ulong?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageulongNullableList100()
        {            
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat((ulong?) expected, 100).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongNullableList100Map()
        {
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToList();

            double result = ZEnumerable.Average(source, arg => (ulong?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageulongNullableList100Min()
        {            
            const ulong expected = 1;
            var source = Enumerable.Repeat((ulong?) expected, 100).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongNullableList100MapMin()
        {
            const ulong expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToList();

            double result = ZEnumerable.Average(source, arg => (ulong?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageulongNullableList4096()
        {            
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat((ulong?) expected, 4096).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongNullableList4096Map()
        {
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToList();

            double result = ZEnumerable.Average(source, arg => (ulong?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageulongNullableList4096Min()
        {            
            const ulong expected = 1;
            var source = Enumerable.Repeat((ulong?) expected, 4096).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongNullableList4096MapMin()
        {
            const ulong expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToList();

            double result = ZEnumerable.Average(source, arg => (ulong?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
        
              
                        
        [TestMethod]
        public void TestAverageulongNullableListNoOverflow()
        {
            const ulong expected = ulong.MaxValue;
            var source = Enumerable.Repeat((ulong?) expected, 2).ToList();
            double result = ZEnumerable.Average(source);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                
        [TestMethod]
        public void TestAverageulongNullableListMapNoOverflow()
        {
            const ulong expected = ulong.MaxValue;
            var source = Enumerable.Repeat(new { X = (ulong?) expected}, 2).ToList();
            double result = ZEnumerable.Average(source, arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                            

         
        [TestMethod]
        public void TestAverageulongNullableIListNullOrEmpty()
        {        
            IList<ulong?> nullSource = null;

            try
            {
                ZEnumerable.Average(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            IList<ulong?> emptySource = new ulong?[0].ToIList();
            try
            {
                ZEnumerable.Average(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestAverageulongNullableIListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<ulong?,ulong?>((ulong?) arg, (ulong?) arg)).ToIList();
            Func<KeyValuePair<ulong?, ulong?>, ulong?> nullMap = null;
            try
            {
                ZEnumerable.Average(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToIList();
            try
            {
                ZEnumerable.Average(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Average(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }
         
                            [TestMethod]
        public void TestAverageulongNullableIList1()
        {            
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat((ulong?) expected, 1).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongNullableIList1Map()
        {
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToIList();

            double result = ZEnumerable.Average(source, arg => (ulong?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageulongNullableIList1Min()
        {            
            const ulong expected = 1;
            var source = Enumerable.Repeat((ulong?) expected, 1).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongNullableIList1MapMin()
        {
            const ulong expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToIList();

            double result = ZEnumerable.Average(source, arg => (ulong?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageulongNullableIList2()
        {            
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat((ulong?) expected, 2).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongNullableIList2Map()
        {
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToIList();

            double result = ZEnumerable.Average(source, arg => (ulong?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageulongNullableIList2Min()
        {            
            const ulong expected = 1;
            var source = Enumerable.Repeat((ulong?) expected, 2).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongNullableIList2MapMin()
        {
            const ulong expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToIList();

            double result = ZEnumerable.Average(source, arg => (ulong?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageulongNullableIList3()
        {            
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat((ulong?) expected, 3).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongNullableIList3Map()
        {
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToIList();

            double result = ZEnumerable.Average(source, arg => (ulong?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageulongNullableIList3Min()
        {            
            const ulong expected = 1;
            var source = Enumerable.Repeat((ulong?) expected, 3).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongNullableIList3MapMin()
        {
            const ulong expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToIList();

            double result = ZEnumerable.Average(source, arg => (ulong?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageulongNullableIList4()
        {            
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat((ulong?) expected, 4).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongNullableIList4Map()
        {
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToIList();

            double result = ZEnumerable.Average(source, arg => (ulong?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageulongNullableIList4Min()
        {            
            const ulong expected = 1;
            var source = Enumerable.Repeat((ulong?) expected, 4).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongNullableIList4MapMin()
        {
            const ulong expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToIList();

            double result = ZEnumerable.Average(source, arg => (ulong?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageulongNullableIList100()
        {            
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat((ulong?) expected, 100).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongNullableIList100Map()
        {
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToIList();

            double result = ZEnumerable.Average(source, arg => (ulong?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageulongNullableIList100Min()
        {            
            const ulong expected = 1;
            var source = Enumerable.Repeat((ulong?) expected, 100).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongNullableIList100MapMin()
        {
            const ulong expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToIList();

            double result = ZEnumerable.Average(source, arg => (ulong?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAverageulongNullableIList4096()
        {            
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat((ulong?) expected, 4096).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongNullableIList4096Map()
        {
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToIList();

            double result = ZEnumerable.Average(source, arg => (ulong?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAverageulongNullableIList4096Min()
        {            
            const ulong expected = 1;
            var source = Enumerable.Repeat((ulong?) expected, 4096).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongNullableIList4096MapMin()
        {
            const ulong expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToIList();

            double result = ZEnumerable.Average(source, arg => (ulong?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
        
              
                        
        [TestMethod]
        public void TestAverageulongNullableIListNoOverflow()
        {
            const ulong expected = ulong.MaxValue;
            var source = Enumerable.Repeat((ulong?) expected, 2).ToIList();
            double result = ZEnumerable.Average(source);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                
        [TestMethod]
        public void TestAverageulongNullableIListMapNoOverflow()
        {
            const ulong expected = ulong.MaxValue;
            var source = Enumerable.Repeat(new { X = (ulong?) expected}, 2).ToIList();
            double result = ZEnumerable.Average(source, arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                                
        #endregion
    
        #region float?             
            

         
        [TestMethod]
        public void TestAveragefloatNullableArrayNullOrEmpty()
        {        
            float?[] nullSource = null;

            try
            {
                ZEnumerable.Average(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            float?[] emptySource = new float?[0].ToArray();
            try
            {
                ZEnumerable.Average(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestAveragefloatNullableArrayMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<float?,float?>((float?) arg, (float?) arg)).ToArray();
            Func<KeyValuePair<float?, float?>, float?> nullMap = null;
            try
            {
                ZEnumerable.Average(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToArray();
            try
            {
                ZEnumerable.Average(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Average(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }
         
                            [TestMethod]
        public void TestAveragefloatNullableArray1()
        {            
            const float expected = float.MaxValue/10*9;
            var source = Enumerable.Repeat((float?) expected, 1).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatNullableArray1Map()
        {
            const float expected = float.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToArray();

            double result = ZEnumerable.Average(source, arg => (float?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragefloatNullableArray1Min()
        {            
            const float expected = 1;
            var source = Enumerable.Repeat((float?) expected, 1).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatNullableArray1MapMin()
        {
            const float expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToArray();

            double result = ZEnumerable.Average(source, arg => (float?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragefloatNullableArray2()
        {            
            const float expected = float.MaxValue/10*9;
            var source = Enumerable.Repeat((float?) expected, 2).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatNullableArray2Map()
        {
            const float expected = float.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToArray();

            double result = ZEnumerable.Average(source, arg => (float?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragefloatNullableArray2Min()
        {            
            const float expected = 1;
            var source = Enumerable.Repeat((float?) expected, 2).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatNullableArray2MapMin()
        {
            const float expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToArray();

            double result = ZEnumerable.Average(source, arg => (float?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragefloatNullableArray3()
        {            
            const float expected = float.MaxValue/10*9;
            var source = Enumerable.Repeat((float?) expected, 3).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatNullableArray3Map()
        {
            const float expected = float.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToArray();

            double result = ZEnumerable.Average(source, arg => (float?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragefloatNullableArray3Min()
        {            
            const float expected = 1;
            var source = Enumerable.Repeat((float?) expected, 3).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatNullableArray3MapMin()
        {
            const float expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToArray();

            double result = ZEnumerable.Average(source, arg => (float?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragefloatNullableArray4()
        {            
            const float expected = float.MaxValue/10*9;
            var source = Enumerable.Repeat((float?) expected, 4).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatNullableArray4Map()
        {
            const float expected = float.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToArray();

            double result = ZEnumerable.Average(source, arg => (float?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragefloatNullableArray4Min()
        {            
            const float expected = 1;
            var source = Enumerable.Repeat((float?) expected, 4).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatNullableArray4MapMin()
        {
            const float expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToArray();

            double result = ZEnumerable.Average(source, arg => (float?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragefloatNullableArray100()
        {            
            const float expected = float.MaxValue/10*9;
            var source = Enumerable.Repeat((float?) expected, 100).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatNullableArray100Map()
        {
            const float expected = float.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToArray();

            double result = ZEnumerable.Average(source, arg => (float?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragefloatNullableArray100Min()
        {            
            const float expected = 1;
            var source = Enumerable.Repeat((float?) expected, 100).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatNullableArray100MapMin()
        {
            const float expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToArray();

            double result = ZEnumerable.Average(source, arg => (float?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragefloatNullableArray4096()
        {            
            const float expected = float.MaxValue/10*9;
            var source = Enumerable.Repeat((float?) expected, 4096).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatNullableArray4096Map()
        {
            const float expected = float.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToArray();

            double result = ZEnumerable.Average(source, arg => (float?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragefloatNullableArray4096Min()
        {            
            const float expected = 1;
            var source = Enumerable.Repeat((float?) expected, 4096).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatNullableArray4096MapMin()
        {
            const float expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToArray();

            double result = ZEnumerable.Average(source, arg => (float?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
        
                    

         
        [TestMethod]
        public void TestAveragefloatNullableListNullOrEmpty()
        {        
            List<float?> nullSource = null;

            try
            {
                ZEnumerable.Average(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            List<float?> emptySource = new float?[0].ToList();
            try
            {
                ZEnumerable.Average(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestAveragefloatNullableListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<float?,float?>((float?) arg, (float?) arg)).ToList();
            Func<KeyValuePair<float?, float?>, float?> nullMap = null;
            try
            {
                ZEnumerable.Average(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToList();
            try
            {
                ZEnumerable.Average(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Average(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }
         
                            [TestMethod]
        public void TestAveragefloatNullableList1()
        {            
            const float expected = float.MaxValue/10*9;
            var source = Enumerable.Repeat((float?) expected, 1).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatNullableList1Map()
        {
            const float expected = float.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToList();

            double result = ZEnumerable.Average(source, arg => (float?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragefloatNullableList1Min()
        {            
            const float expected = 1;
            var source = Enumerable.Repeat((float?) expected, 1).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatNullableList1MapMin()
        {
            const float expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToList();

            double result = ZEnumerable.Average(source, arg => (float?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragefloatNullableList2()
        {            
            const float expected = float.MaxValue/10*9;
            var source = Enumerable.Repeat((float?) expected, 2).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatNullableList2Map()
        {
            const float expected = float.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToList();

            double result = ZEnumerable.Average(source, arg => (float?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragefloatNullableList2Min()
        {            
            const float expected = 1;
            var source = Enumerable.Repeat((float?) expected, 2).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatNullableList2MapMin()
        {
            const float expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToList();

            double result = ZEnumerable.Average(source, arg => (float?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragefloatNullableList3()
        {            
            const float expected = float.MaxValue/10*9;
            var source = Enumerable.Repeat((float?) expected, 3).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatNullableList3Map()
        {
            const float expected = float.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToList();

            double result = ZEnumerable.Average(source, arg => (float?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragefloatNullableList3Min()
        {            
            const float expected = 1;
            var source = Enumerable.Repeat((float?) expected, 3).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatNullableList3MapMin()
        {
            const float expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToList();

            double result = ZEnumerable.Average(source, arg => (float?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragefloatNullableList4()
        {            
            const float expected = float.MaxValue/10*9;
            var source = Enumerable.Repeat((float?) expected, 4).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatNullableList4Map()
        {
            const float expected = float.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToList();

            double result = ZEnumerable.Average(source, arg => (float?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragefloatNullableList4Min()
        {            
            const float expected = 1;
            var source = Enumerable.Repeat((float?) expected, 4).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatNullableList4MapMin()
        {
            const float expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToList();

            double result = ZEnumerable.Average(source, arg => (float?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragefloatNullableList100()
        {            
            const float expected = float.MaxValue/10*9;
            var source = Enumerable.Repeat((float?) expected, 100).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatNullableList100Map()
        {
            const float expected = float.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToList();

            double result = ZEnumerable.Average(source, arg => (float?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragefloatNullableList100Min()
        {            
            const float expected = 1;
            var source = Enumerable.Repeat((float?) expected, 100).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatNullableList100MapMin()
        {
            const float expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToList();

            double result = ZEnumerable.Average(source, arg => (float?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragefloatNullableList4096()
        {            
            const float expected = float.MaxValue/10*9;
            var source = Enumerable.Repeat((float?) expected, 4096).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatNullableList4096Map()
        {
            const float expected = float.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToList();

            double result = ZEnumerable.Average(source, arg => (float?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragefloatNullableList4096Min()
        {            
            const float expected = 1;
            var source = Enumerable.Repeat((float?) expected, 4096).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatNullableList4096MapMin()
        {
            const float expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToList();

            double result = ZEnumerable.Average(source, arg => (float?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
        
                    

         
        [TestMethod]
        public void TestAveragefloatNullableIListNullOrEmpty()
        {        
            IList<float?> nullSource = null;

            try
            {
                ZEnumerable.Average(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            IList<float?> emptySource = new float?[0].ToIList();
            try
            {
                ZEnumerable.Average(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestAveragefloatNullableIListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<float?,float?>((float?) arg, (float?) arg)).ToIList();
            Func<KeyValuePair<float?, float?>, float?> nullMap = null;
            try
            {
                ZEnumerable.Average(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToIList();
            try
            {
                ZEnumerable.Average(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Average(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }
         
                            [TestMethod]
        public void TestAveragefloatNullableIList1()
        {            
            const float expected = float.MaxValue/10*9;
            var source = Enumerable.Repeat((float?) expected, 1).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatNullableIList1Map()
        {
            const float expected = float.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToIList();

            double result = ZEnumerable.Average(source, arg => (float?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragefloatNullableIList1Min()
        {            
            const float expected = 1;
            var source = Enumerable.Repeat((float?) expected, 1).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatNullableIList1MapMin()
        {
            const float expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToIList();

            double result = ZEnumerable.Average(source, arg => (float?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragefloatNullableIList2()
        {            
            const float expected = float.MaxValue/10*9;
            var source = Enumerable.Repeat((float?) expected, 2).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatNullableIList2Map()
        {
            const float expected = float.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToIList();

            double result = ZEnumerable.Average(source, arg => (float?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragefloatNullableIList2Min()
        {            
            const float expected = 1;
            var source = Enumerable.Repeat((float?) expected, 2).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatNullableIList2MapMin()
        {
            const float expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToIList();

            double result = ZEnumerable.Average(source, arg => (float?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragefloatNullableIList3()
        {            
            const float expected = float.MaxValue/10*9;
            var source = Enumerable.Repeat((float?) expected, 3).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatNullableIList3Map()
        {
            const float expected = float.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToIList();

            double result = ZEnumerable.Average(source, arg => (float?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragefloatNullableIList3Min()
        {            
            const float expected = 1;
            var source = Enumerable.Repeat((float?) expected, 3).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatNullableIList3MapMin()
        {
            const float expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToIList();

            double result = ZEnumerable.Average(source, arg => (float?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragefloatNullableIList4()
        {            
            const float expected = float.MaxValue/10*9;
            var source = Enumerable.Repeat((float?) expected, 4).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatNullableIList4Map()
        {
            const float expected = float.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToIList();

            double result = ZEnumerable.Average(source, arg => (float?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragefloatNullableIList4Min()
        {            
            const float expected = 1;
            var source = Enumerable.Repeat((float?) expected, 4).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatNullableIList4MapMin()
        {
            const float expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToIList();

            double result = ZEnumerable.Average(source, arg => (float?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragefloatNullableIList100()
        {            
            const float expected = float.MaxValue/10*9;
            var source = Enumerable.Repeat((float?) expected, 100).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatNullableIList100Map()
        {
            const float expected = float.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToIList();

            double result = ZEnumerable.Average(source, arg => (float?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragefloatNullableIList100Min()
        {            
            const float expected = 1;
            var source = Enumerable.Repeat((float?) expected, 100).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatNullableIList100MapMin()
        {
            const float expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToIList();

            double result = ZEnumerable.Average(source, arg => (float?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragefloatNullableIList4096()
        {            
            const float expected = float.MaxValue/10*9;
            var source = Enumerable.Repeat((float?) expected, 4096).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatNullableIList4096Map()
        {
            const float expected = float.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToIList();

            double result = ZEnumerable.Average(source, arg => (float?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragefloatNullableIList4096Min()
        {            
            const float expected = 1;
            var source = Enumerable.Repeat((float?) expected, 4096).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatNullableIList4096MapMin()
        {
            const float expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToIList();

            double result = ZEnumerable.Average(source, arg => (float?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
        
                        
        #endregion
    
        #region double?             
            

         
        [TestMethod]
        public void TestAveragedoubleNullableArrayNullOrEmpty()
        {        
            double?[] nullSource = null;

            try
            {
                ZEnumerable.Average(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            double?[] emptySource = new double?[0].ToArray();
            try
            {
                ZEnumerable.Average(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestAveragedoubleNullableArrayMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<double?,double?>((double?) arg, (double?) arg)).ToArray();
            Func<KeyValuePair<double?, double?>, double?> nullMap = null;
            try
            {
                ZEnumerable.Average(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToArray();
            try
            {
                ZEnumerable.Average(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Average(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }
         
                            [TestMethod]
        public void TestAveragedoubleNullableArray1()
        {            
            const double expected = double.MaxValue/10*9;
            var source = Enumerable.Repeat((double?) expected, 1).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleNullableArray1Map()
        {
            const double expected = double.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToArray();

            double result = ZEnumerable.Average(source, arg => (double?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragedoubleNullableArray1Min()
        {            
            const double expected = 1;
            var source = Enumerable.Repeat((double?) expected, 1).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleNullableArray1MapMin()
        {
            const double expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToArray();

            double result = ZEnumerable.Average(source, arg => (double?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragedoubleNullableArray2()
        {            
            const double expected = double.MaxValue/10*9;
            var source = Enumerable.Repeat((double?) expected, 2).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleNullableArray2Map()
        {
            const double expected = double.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToArray();

            double result = ZEnumerable.Average(source, arg => (double?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragedoubleNullableArray2Min()
        {            
            const double expected = 1;
            var source = Enumerable.Repeat((double?) expected, 2).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleNullableArray2MapMin()
        {
            const double expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToArray();

            double result = ZEnumerable.Average(source, arg => (double?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragedoubleNullableArray3()
        {            
            const double expected = double.MaxValue/10*9;
            var source = Enumerable.Repeat((double?) expected, 3).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleNullableArray3Map()
        {
            const double expected = double.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToArray();

            double result = ZEnumerable.Average(source, arg => (double?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragedoubleNullableArray3Min()
        {            
            const double expected = 1;
            var source = Enumerable.Repeat((double?) expected, 3).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleNullableArray3MapMin()
        {
            const double expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToArray();

            double result = ZEnumerable.Average(source, arg => (double?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragedoubleNullableArray4()
        {            
            const double expected = double.MaxValue/10*9;
            var source = Enumerable.Repeat((double?) expected, 4).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleNullableArray4Map()
        {
            const double expected = double.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToArray();

            double result = ZEnumerable.Average(source, arg => (double?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragedoubleNullableArray4Min()
        {            
            const double expected = 1;
            var source = Enumerable.Repeat((double?) expected, 4).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleNullableArray4MapMin()
        {
            const double expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToArray();

            double result = ZEnumerable.Average(source, arg => (double?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragedoubleNullableArray100()
        {            
            const double expected = double.MaxValue/10*9;
            var source = Enumerable.Repeat((double?) expected, 100).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleNullableArray100Map()
        {
            const double expected = double.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToArray();

            double result = ZEnumerable.Average(source, arg => (double?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragedoubleNullableArray100Min()
        {            
            const double expected = 1;
            var source = Enumerable.Repeat((double?) expected, 100).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleNullableArray100MapMin()
        {
            const double expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToArray();

            double result = ZEnumerable.Average(source, arg => (double?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragedoubleNullableArray4096()
        {            
            const double expected = double.MaxValue/10*9;
            var source = Enumerable.Repeat((double?) expected, 4096).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleNullableArray4096Map()
        {
            const double expected = double.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToArray();

            double result = ZEnumerable.Average(source, arg => (double?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragedoubleNullableArray4096Min()
        {            
            const double expected = 1;
            var source = Enumerable.Repeat((double?) expected, 4096).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleNullableArray4096MapMin()
        {
            const double expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToArray();

            double result = ZEnumerable.Average(source, arg => (double?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
        
                    

         
        [TestMethod]
        public void TestAveragedoubleNullableListNullOrEmpty()
        {        
            List<double?> nullSource = null;

            try
            {
                ZEnumerable.Average(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            List<double?> emptySource = new double?[0].ToList();
            try
            {
                ZEnumerable.Average(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestAveragedoubleNullableListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<double?,double?>((double?) arg, (double?) arg)).ToList();
            Func<KeyValuePair<double?, double?>, double?> nullMap = null;
            try
            {
                ZEnumerable.Average(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToList();
            try
            {
                ZEnumerable.Average(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Average(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }
         
                            [TestMethod]
        public void TestAveragedoubleNullableList1()
        {            
            const double expected = double.MaxValue/10*9;
            var source = Enumerable.Repeat((double?) expected, 1).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleNullableList1Map()
        {
            const double expected = double.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToList();

            double result = ZEnumerable.Average(source, arg => (double?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragedoubleNullableList1Min()
        {            
            const double expected = 1;
            var source = Enumerable.Repeat((double?) expected, 1).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleNullableList1MapMin()
        {
            const double expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToList();

            double result = ZEnumerable.Average(source, arg => (double?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragedoubleNullableList2()
        {            
            const double expected = double.MaxValue/10*9;
            var source = Enumerable.Repeat((double?) expected, 2).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleNullableList2Map()
        {
            const double expected = double.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToList();

            double result = ZEnumerable.Average(source, arg => (double?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragedoubleNullableList2Min()
        {            
            const double expected = 1;
            var source = Enumerable.Repeat((double?) expected, 2).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleNullableList2MapMin()
        {
            const double expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToList();

            double result = ZEnumerable.Average(source, arg => (double?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragedoubleNullableList3()
        {            
            const double expected = double.MaxValue/10*9;
            var source = Enumerable.Repeat((double?) expected, 3).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleNullableList3Map()
        {
            const double expected = double.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToList();

            double result = ZEnumerable.Average(source, arg => (double?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragedoubleNullableList3Min()
        {            
            const double expected = 1;
            var source = Enumerable.Repeat((double?) expected, 3).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleNullableList3MapMin()
        {
            const double expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToList();

            double result = ZEnumerable.Average(source, arg => (double?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragedoubleNullableList4()
        {            
            const double expected = double.MaxValue/10*9;
            var source = Enumerable.Repeat((double?) expected, 4).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleNullableList4Map()
        {
            const double expected = double.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToList();

            double result = ZEnumerable.Average(source, arg => (double?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragedoubleNullableList4Min()
        {            
            const double expected = 1;
            var source = Enumerable.Repeat((double?) expected, 4).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleNullableList4MapMin()
        {
            const double expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToList();

            double result = ZEnumerable.Average(source, arg => (double?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragedoubleNullableList100()
        {            
            const double expected = double.MaxValue/10*9;
            var source = Enumerable.Repeat((double?) expected, 100).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleNullableList100Map()
        {
            const double expected = double.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToList();

            double result = ZEnumerable.Average(source, arg => (double?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragedoubleNullableList100Min()
        {            
            const double expected = 1;
            var source = Enumerable.Repeat((double?) expected, 100).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleNullableList100MapMin()
        {
            const double expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToList();

            double result = ZEnumerable.Average(source, arg => (double?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragedoubleNullableList4096()
        {            
            const double expected = double.MaxValue/10*9;
            var source = Enumerable.Repeat((double?) expected, 4096).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleNullableList4096Map()
        {
            const double expected = double.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToList();

            double result = ZEnumerable.Average(source, arg => (double?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragedoubleNullableList4096Min()
        {            
            const double expected = 1;
            var source = Enumerable.Repeat((double?) expected, 4096).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleNullableList4096MapMin()
        {
            const double expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToList();

            double result = ZEnumerable.Average(source, arg => (double?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
        
                    

         
        [TestMethod]
        public void TestAveragedoubleNullableIListNullOrEmpty()
        {        
            IList<double?> nullSource = null;

            try
            {
                ZEnumerable.Average(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            IList<double?> emptySource = new double?[0].ToIList();
            try
            {
                ZEnumerable.Average(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestAveragedoubleNullableIListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<double?,double?>((double?) arg, (double?) arg)).ToIList();
            Func<KeyValuePair<double?, double?>, double?> nullMap = null;
            try
            {
                ZEnumerable.Average(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToIList();
            try
            {
                ZEnumerable.Average(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Average(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }
         
                            [TestMethod]
        public void TestAveragedoubleNullableIList1()
        {            
            const double expected = double.MaxValue/10*9;
            var source = Enumerable.Repeat((double?) expected, 1).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleNullableIList1Map()
        {
            const double expected = double.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToIList();

            double result = ZEnumerable.Average(source, arg => (double?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragedoubleNullableIList1Min()
        {            
            const double expected = 1;
            var source = Enumerable.Repeat((double?) expected, 1).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleNullableIList1MapMin()
        {
            const double expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToIList();

            double result = ZEnumerable.Average(source, arg => (double?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragedoubleNullableIList2()
        {            
            const double expected = double.MaxValue/10*9;
            var source = Enumerable.Repeat((double?) expected, 2).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleNullableIList2Map()
        {
            const double expected = double.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToIList();

            double result = ZEnumerable.Average(source, arg => (double?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragedoubleNullableIList2Min()
        {            
            const double expected = 1;
            var source = Enumerable.Repeat((double?) expected, 2).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleNullableIList2MapMin()
        {
            const double expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToIList();

            double result = ZEnumerable.Average(source, arg => (double?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragedoubleNullableIList3()
        {            
            const double expected = double.MaxValue/10*9;
            var source = Enumerable.Repeat((double?) expected, 3).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleNullableIList3Map()
        {
            const double expected = double.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToIList();

            double result = ZEnumerable.Average(source, arg => (double?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragedoubleNullableIList3Min()
        {            
            const double expected = 1;
            var source = Enumerable.Repeat((double?) expected, 3).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleNullableIList3MapMin()
        {
            const double expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToIList();

            double result = ZEnumerable.Average(source, arg => (double?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragedoubleNullableIList4()
        {            
            const double expected = double.MaxValue/10*9;
            var source = Enumerable.Repeat((double?) expected, 4).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleNullableIList4Map()
        {
            const double expected = double.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToIList();

            double result = ZEnumerable.Average(source, arg => (double?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragedoubleNullableIList4Min()
        {            
            const double expected = 1;
            var source = Enumerable.Repeat((double?) expected, 4).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleNullableIList4MapMin()
        {
            const double expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToIList();

            double result = ZEnumerable.Average(source, arg => (double?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragedoubleNullableIList100()
        {            
            const double expected = double.MaxValue/10*9;
            var source = Enumerable.Repeat((double?) expected, 100).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleNullableIList100Map()
        {
            const double expected = double.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToIList();

            double result = ZEnumerable.Average(source, arg => (double?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragedoubleNullableIList100Min()
        {            
            const double expected = 1;
            var source = Enumerable.Repeat((double?) expected, 100).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleNullableIList100MapMin()
        {
            const double expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToIList();

            double result = ZEnumerable.Average(source, arg => (double?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragedoubleNullableIList4096()
        {            
            const double expected = double.MaxValue/10*9;
            var source = Enumerable.Repeat((double?) expected, 4096).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleNullableIList4096Map()
        {
            const double expected = double.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToIList();

            double result = ZEnumerable.Average(source, arg => (double?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragedoubleNullableIList4096Min()
        {            
            const double expected = 1;
            var source = Enumerable.Repeat((double?) expected, 4096).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleNullableIList4096MapMin()
        {
            const double expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToIList();

            double result = ZEnumerable.Average(source, arg => (double?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
        
                        
        #endregion
    
        #region decimal?             
            

         
        [TestMethod]
        public void TestAveragedecimalNullableArrayNullOrEmpty()
        {        
            decimal?[] nullSource = null;

            try
            {
                ZEnumerable.Average(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            decimal?[] emptySource = new decimal?[0].ToArray();
            try
            {
                ZEnumerable.Average(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestAveragedecimalNullableArrayMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<decimal?,decimal?>((decimal?) arg, (decimal?) arg)).ToArray();
            Func<KeyValuePair<decimal?, decimal?>, decimal?> nullMap = null;
            try
            {
                ZEnumerable.Average(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToArray();
            try
            {
                ZEnumerable.Average(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Average(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }
         
                            [TestMethod]
        public void TestAveragedecimalNullableArray1()
        {            
            const decimal expected = decimal.MaxValue/10*9;
            var source = Enumerable.Repeat((decimal?) expected, 1).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalNullableArray1Map()
        {
            const decimal expected = decimal.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToArray();

            double result = ZEnumerable.Average(source, arg => (decimal?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragedecimalNullableArray1Min()
        {            
            const decimal expected = 1;
            var source = Enumerable.Repeat((decimal?) expected, 1).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalNullableArray1MapMin()
        {
            const decimal expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToArray();

            double result = ZEnumerable.Average(source, arg => (decimal?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragedecimalNullableArray2()
        {            
            const decimal expected = decimal.MaxValue/10*9;
            var source = Enumerable.Repeat((decimal?) expected, 2).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalNullableArray2Map()
        {
            const decimal expected = decimal.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToArray();

            double result = ZEnumerable.Average(source, arg => (decimal?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragedecimalNullableArray2Min()
        {            
            const decimal expected = 1;
            var source = Enumerable.Repeat((decimal?) expected, 2).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalNullableArray2MapMin()
        {
            const decimal expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToArray();

            double result = ZEnumerable.Average(source, arg => (decimal?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragedecimalNullableArray3()
        {            
            const decimal expected = decimal.MaxValue/10*9;
            var source = Enumerable.Repeat((decimal?) expected, 3).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalNullableArray3Map()
        {
            const decimal expected = decimal.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToArray();

            double result = ZEnumerable.Average(source, arg => (decimal?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragedecimalNullableArray3Min()
        {            
            const decimal expected = 1;
            var source = Enumerable.Repeat((decimal?) expected, 3).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalNullableArray3MapMin()
        {
            const decimal expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToArray();

            double result = ZEnumerable.Average(source, arg => (decimal?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragedecimalNullableArray4()
        {            
            const decimal expected = decimal.MaxValue/10*9;
            var source = Enumerable.Repeat((decimal?) expected, 4).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalNullableArray4Map()
        {
            const decimal expected = decimal.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToArray();

            double result = ZEnumerable.Average(source, arg => (decimal?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragedecimalNullableArray4Min()
        {            
            const decimal expected = 1;
            var source = Enumerable.Repeat((decimal?) expected, 4).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalNullableArray4MapMin()
        {
            const decimal expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToArray();

            double result = ZEnumerable.Average(source, arg => (decimal?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragedecimalNullableArray100()
        {            
            const decimal expected = decimal.MaxValue/10*9;
            var source = Enumerable.Repeat((decimal?) expected, 100).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalNullableArray100Map()
        {
            const decimal expected = decimal.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToArray();

            double result = ZEnumerable.Average(source, arg => (decimal?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragedecimalNullableArray100Min()
        {            
            const decimal expected = 1;
            var source = Enumerable.Repeat((decimal?) expected, 100).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalNullableArray100MapMin()
        {
            const decimal expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToArray();

            double result = ZEnumerable.Average(source, arg => (decimal?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragedecimalNullableArray4096()
        {            
            const decimal expected = decimal.MaxValue/10*9;
            var source = Enumerable.Repeat((decimal?) expected, 4096).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalNullableArray4096Map()
        {
            const decimal expected = decimal.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToArray();

            double result = ZEnumerable.Average(source, arg => (decimal?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragedecimalNullableArray4096Min()
        {            
            const decimal expected = 1;
            var source = Enumerable.Repeat((decimal?) expected, 4096).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalNullableArray4096MapMin()
        {
            const decimal expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToArray();

            double result = ZEnumerable.Average(source, arg => (decimal?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
        
                    

         
        [TestMethod]
        public void TestAveragedecimalNullableListNullOrEmpty()
        {        
            List<decimal?> nullSource = null;

            try
            {
                ZEnumerable.Average(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            List<decimal?> emptySource = new decimal?[0].ToList();
            try
            {
                ZEnumerable.Average(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestAveragedecimalNullableListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<decimal?,decimal?>((decimal?) arg, (decimal?) arg)).ToList();
            Func<KeyValuePair<decimal?, decimal?>, decimal?> nullMap = null;
            try
            {
                ZEnumerable.Average(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToList();
            try
            {
                ZEnumerable.Average(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Average(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }
         
                            [TestMethod]
        public void TestAveragedecimalNullableList1()
        {            
            const decimal expected = decimal.MaxValue/10*9;
            var source = Enumerable.Repeat((decimal?) expected, 1).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalNullableList1Map()
        {
            const decimal expected = decimal.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToList();

            double result = ZEnumerable.Average(source, arg => (decimal?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragedecimalNullableList1Min()
        {            
            const decimal expected = 1;
            var source = Enumerable.Repeat((decimal?) expected, 1).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalNullableList1MapMin()
        {
            const decimal expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToList();

            double result = ZEnumerable.Average(source, arg => (decimal?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragedecimalNullableList2()
        {            
            const decimal expected = decimal.MaxValue/10*9;
            var source = Enumerable.Repeat((decimal?) expected, 2).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalNullableList2Map()
        {
            const decimal expected = decimal.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToList();

            double result = ZEnumerable.Average(source, arg => (decimal?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragedecimalNullableList2Min()
        {            
            const decimal expected = 1;
            var source = Enumerable.Repeat((decimal?) expected, 2).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalNullableList2MapMin()
        {
            const decimal expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToList();

            double result = ZEnumerable.Average(source, arg => (decimal?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragedecimalNullableList3()
        {            
            const decimal expected = decimal.MaxValue/10*9;
            var source = Enumerable.Repeat((decimal?) expected, 3).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalNullableList3Map()
        {
            const decimal expected = decimal.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToList();

            double result = ZEnumerable.Average(source, arg => (decimal?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragedecimalNullableList3Min()
        {            
            const decimal expected = 1;
            var source = Enumerable.Repeat((decimal?) expected, 3).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalNullableList3MapMin()
        {
            const decimal expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToList();

            double result = ZEnumerable.Average(source, arg => (decimal?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragedecimalNullableList4()
        {            
            const decimal expected = decimal.MaxValue/10*9;
            var source = Enumerable.Repeat((decimal?) expected, 4).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalNullableList4Map()
        {
            const decimal expected = decimal.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToList();

            double result = ZEnumerable.Average(source, arg => (decimal?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragedecimalNullableList4Min()
        {            
            const decimal expected = 1;
            var source = Enumerable.Repeat((decimal?) expected, 4).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalNullableList4MapMin()
        {
            const decimal expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToList();

            double result = ZEnumerable.Average(source, arg => (decimal?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragedecimalNullableList100()
        {            
            const decimal expected = decimal.MaxValue/10*9;
            var source = Enumerable.Repeat((decimal?) expected, 100).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalNullableList100Map()
        {
            const decimal expected = decimal.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToList();

            double result = ZEnumerable.Average(source, arg => (decimal?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragedecimalNullableList100Min()
        {            
            const decimal expected = 1;
            var source = Enumerable.Repeat((decimal?) expected, 100).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalNullableList100MapMin()
        {
            const decimal expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToList();

            double result = ZEnumerable.Average(source, arg => (decimal?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragedecimalNullableList4096()
        {            
            const decimal expected = decimal.MaxValue/10*9;
            var source = Enumerable.Repeat((decimal?) expected, 4096).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalNullableList4096Map()
        {
            const decimal expected = decimal.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToList();

            double result = ZEnumerable.Average(source, arg => (decimal?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragedecimalNullableList4096Min()
        {            
            const decimal expected = 1;
            var source = Enumerable.Repeat((decimal?) expected, 4096).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalNullableList4096MapMin()
        {
            const decimal expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToList();

            double result = ZEnumerable.Average(source, arg => (decimal?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
        
                    

         
        [TestMethod]
        public void TestAveragedecimalNullableIListNullOrEmpty()
        {        
            IList<decimal?> nullSource = null;

            try
            {
                ZEnumerable.Average(nullSource);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            IList<decimal?> emptySource = new decimal?[0].ToIList();
            try
            {
                ZEnumerable.Average(emptySource);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }

        [TestMethod]
        public void TestAveragedecimalNullableIListMapNullOrEmpty()
        {
            var source = Enumerable.Range(1, 1).Select(arg => new KeyValuePair<decimal?,decimal?>((decimal?) arg, (decimal?) arg)).ToIList();
            Func<KeyValuePair<decimal?, decimal?>, decimal?> nullMap = null;
            try
            {
                ZEnumerable.Average(source, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }

            var emptySource = source.Take(0).ToIList();
            try
            {
                ZEnumerable.Average(emptySource, nullMap);                
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                
            }
            try
            {
                ZEnumerable.Average(emptySource, x => x.Key);                
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                
            }
        }
         
                            [TestMethod]
        public void TestAveragedecimalNullableIList1()
        {            
            const decimal expected = decimal.MaxValue/10*9;
            var source = Enumerable.Repeat((decimal?) expected, 1).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalNullableIList1Map()
        {
            const decimal expected = decimal.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToIList();

            double result = ZEnumerable.Average(source, arg => (decimal?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragedecimalNullableIList1Min()
        {            
            const decimal expected = 1;
            var source = Enumerable.Repeat((decimal?) expected, 1).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalNullableIList1MapMin()
        {
            const decimal expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 1).ToIList();

            double result = ZEnumerable.Average(source, arg => (decimal?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragedecimalNullableIList2()
        {            
            const decimal expected = decimal.MaxValue/10*9;
            var source = Enumerable.Repeat((decimal?) expected, 2).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalNullableIList2Map()
        {
            const decimal expected = decimal.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToIList();

            double result = ZEnumerable.Average(source, arg => (decimal?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragedecimalNullableIList2Min()
        {            
            const decimal expected = 1;
            var source = Enumerable.Repeat((decimal?) expected, 2).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalNullableIList2MapMin()
        {
            const decimal expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2).ToIList();

            double result = ZEnumerable.Average(source, arg => (decimal?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragedecimalNullableIList3()
        {            
            const decimal expected = decimal.MaxValue/10*9;
            var source = Enumerable.Repeat((decimal?) expected, 3).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalNullableIList3Map()
        {
            const decimal expected = decimal.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToIList();

            double result = ZEnumerable.Average(source, arg => (decimal?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragedecimalNullableIList3Min()
        {            
            const decimal expected = 1;
            var source = Enumerable.Repeat((decimal?) expected, 3).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalNullableIList3MapMin()
        {
            const decimal expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 3).ToIList();

            double result = ZEnumerable.Average(source, arg => (decimal?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragedecimalNullableIList4()
        {            
            const decimal expected = decimal.MaxValue/10*9;
            var source = Enumerable.Repeat((decimal?) expected, 4).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalNullableIList4Map()
        {
            const decimal expected = decimal.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToIList();

            double result = ZEnumerable.Average(source, arg => (decimal?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragedecimalNullableIList4Min()
        {            
            const decimal expected = 1;
            var source = Enumerable.Repeat((decimal?) expected, 4).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalNullableIList4MapMin()
        {
            const decimal expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4).ToIList();

            double result = ZEnumerable.Average(source, arg => (decimal?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragedecimalNullableIList100()
        {            
            const decimal expected = decimal.MaxValue/10*9;
            var source = Enumerable.Repeat((decimal?) expected, 100).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalNullableIList100Map()
        {
            const decimal expected = decimal.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToIList();

            double result = ZEnumerable.Average(source, arg => (decimal?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragedecimalNullableIList100Min()
        {            
            const decimal expected = 1;
            var source = Enumerable.Repeat((decimal?) expected, 100).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalNullableIList100MapMin()
        {
            const decimal expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToIList();

            double result = ZEnumerable.Average(source, arg => (decimal?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
                            [TestMethod]
        public void TestAveragedecimalNullableIList4096()
        {            
            const decimal expected = decimal.MaxValue/10*9;
            var source = Enumerable.Repeat((decimal?) expected, 4096).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalNullableIList4096Map()
        {
            const decimal expected = decimal.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToIList();

            double result = ZEnumerable.Average(source, arg => (decimal?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                [TestMethod]
        public void TestAveragedecimalNullableIList4096Min()
        {            
            const decimal expected = 1;
            var source = Enumerable.Repeat((decimal?) expected, 4096).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalNullableIList4096MapMin()
        {
            const decimal expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 4096).ToIList();

            double result = ZEnumerable.Average(source, arg => (decimal?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                  
        
                        
        #endregion
      
    }
}