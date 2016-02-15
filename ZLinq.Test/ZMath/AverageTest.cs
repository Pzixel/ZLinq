
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
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
        public void TestAveragesbyteArray0()
        {            
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat((sbyte) expected, 0).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteArray0Map()
        {
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToArray();

            double result = ZEnumerable.Average(source, arg => (sbyte) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteArray0Min()
        {            
            const sbyte expected = 1;
            var source = Enumerable.Repeat((sbyte) expected, 0).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteArray0MapMin()
        {
            const sbyte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToArray();

            double result = ZEnumerable.Average(source, arg => (sbyte) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
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
        public void TestAveragesbyteArray2049()
        {            
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat((sbyte) expected, 2049).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteArray2049Map()
        {
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToArray();

            double result = ZEnumerable.Average(source, arg => (sbyte) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteArray2049Min()
        {            
            const sbyte expected = 1;
            var source = Enumerable.Repeat((sbyte) expected, 2049).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteArray2049MapMin()
        {
            const sbyte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToArray();

            double result = ZEnumerable.Average(source, arg => (sbyte) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
          
                [TestMethod]
        public void TestAveragesbyteArray2051()
        {            
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat((sbyte) expected, 2051).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteArray2051Map()
        {
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToArray();

            double result = ZEnumerable.Average(source, arg => (sbyte) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteArray2051Min()
        {            
            const sbyte expected = 1;
            var source = Enumerable.Repeat((sbyte) expected, 2051).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteArray2051MapMin()
        {
            const sbyte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToArray();

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
            var source =  Enumerable.Repeat(new { X = (sbyte) expected} , 2).ToArray();
            double result = ZEnumerable.Average(source, arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                    

         
                [TestMethod]
        public void TestAveragesbyteList0()
        {            
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat((sbyte) expected, 0).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteList0Map()
        {
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToList();

            double result = ZEnumerable.Average(source, arg => (sbyte) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteList0Min()
        {            
            const sbyte expected = 1;
            var source = Enumerable.Repeat((sbyte) expected, 0).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteList0MapMin()
        {
            const sbyte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToList();

            double result = ZEnumerable.Average(source, arg => (sbyte) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
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
        public void TestAveragesbyteList2049()
        {            
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat((sbyte) expected, 2049).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteList2049Map()
        {
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToList();

            double result = ZEnumerable.Average(source, arg => (sbyte) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteList2049Min()
        {            
            const sbyte expected = 1;
            var source = Enumerable.Repeat((sbyte) expected, 2049).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteList2049MapMin()
        {
            const sbyte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToList();

            double result = ZEnumerable.Average(source, arg => (sbyte) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
          
                [TestMethod]
        public void TestAveragesbyteList2051()
        {            
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat((sbyte) expected, 2051).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteList2051Map()
        {
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToList();

            double result = ZEnumerable.Average(source, arg => (sbyte) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteList2051Min()
        {            
            const sbyte expected = 1;
            var source = Enumerable.Repeat((sbyte) expected, 2051).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteList2051MapMin()
        {
            const sbyte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToList();

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
            var source =  Enumerable.Repeat(new { X = (sbyte) expected} , 2).ToList();
            double result = ZEnumerable.Average(source, arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                    

         
                [TestMethod]
        public void TestAveragesbyteIList0()
        {            
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat((sbyte) expected, 0).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteIList0Map()
        {
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToIList();

            double result = ZEnumerable.Average(source, arg => (sbyte) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteIList0Min()
        {            
            const sbyte expected = 1;
            var source = Enumerable.Repeat((sbyte) expected, 0).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteIList0MapMin()
        {
            const sbyte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToIList();

            double result = ZEnumerable.Average(source, arg => (sbyte) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
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
        public void TestAveragesbyteIList2049()
        {            
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat((sbyte) expected, 2049).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteIList2049Map()
        {
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToIList();

            double result = ZEnumerable.Average(source, arg => (sbyte) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteIList2049Min()
        {            
            const sbyte expected = 1;
            var source = Enumerable.Repeat((sbyte) expected, 2049).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteIList2049MapMin()
        {
            const sbyte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToIList();

            double result = ZEnumerable.Average(source, arg => (sbyte) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
          
                [TestMethod]
        public void TestAveragesbyteIList2051()
        {            
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat((sbyte) expected, 2051).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteIList2051Map()
        {
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToIList();

            double result = ZEnumerable.Average(source, arg => (sbyte) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteIList2051Min()
        {            
            const sbyte expected = 1;
            var source = Enumerable.Repeat((sbyte) expected, 2051).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteIList2051MapMin()
        {
            const sbyte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToIList();

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
            var source =  Enumerable.Repeat(new { X = (sbyte) expected} , 2).ToIList();
            double result = ZEnumerable.Average(source, arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                        
        #endregion
    
        #region byte             
            

         
                [TestMethod]
        public void TestAveragebyteArray0()
        {            
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat((byte) expected, 0).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteArray0Map()
        {
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToArray();

            double result = ZEnumerable.Average(source, arg => (byte) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteArray0Min()
        {            
            const byte expected = 1;
            var source = Enumerable.Repeat((byte) expected, 0).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteArray0MapMin()
        {
            const byte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToArray();

            double result = ZEnumerable.Average(source, arg => (byte) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
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
        public void TestAveragebyteArray2049()
        {            
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat((byte) expected, 2049).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteArray2049Map()
        {
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToArray();

            double result = ZEnumerable.Average(source, arg => (byte) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteArray2049Min()
        {            
            const byte expected = 1;
            var source = Enumerable.Repeat((byte) expected, 2049).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteArray2049MapMin()
        {
            const byte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToArray();

            double result = ZEnumerable.Average(source, arg => (byte) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
          
                [TestMethod]
        public void TestAveragebyteArray2051()
        {            
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat((byte) expected, 2051).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteArray2051Map()
        {
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToArray();

            double result = ZEnumerable.Average(source, arg => (byte) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteArray2051Min()
        {            
            const byte expected = 1;
            var source = Enumerable.Repeat((byte) expected, 2051).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteArray2051MapMin()
        {
            const byte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToArray();

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
            var source =  Enumerable.Repeat(new { X = (byte) expected} , 2).ToArray();
            double result = ZEnumerable.Average(source, arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                    

         
                [TestMethod]
        public void TestAveragebyteList0()
        {            
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat((byte) expected, 0).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteList0Map()
        {
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToList();

            double result = ZEnumerable.Average(source, arg => (byte) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteList0Min()
        {            
            const byte expected = 1;
            var source = Enumerable.Repeat((byte) expected, 0).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteList0MapMin()
        {
            const byte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToList();

            double result = ZEnumerable.Average(source, arg => (byte) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
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
        public void TestAveragebyteList2049()
        {            
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat((byte) expected, 2049).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteList2049Map()
        {
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToList();

            double result = ZEnumerable.Average(source, arg => (byte) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteList2049Min()
        {            
            const byte expected = 1;
            var source = Enumerable.Repeat((byte) expected, 2049).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteList2049MapMin()
        {
            const byte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToList();

            double result = ZEnumerable.Average(source, arg => (byte) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
          
                [TestMethod]
        public void TestAveragebyteList2051()
        {            
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat((byte) expected, 2051).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteList2051Map()
        {
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToList();

            double result = ZEnumerable.Average(source, arg => (byte) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteList2051Min()
        {            
            const byte expected = 1;
            var source = Enumerable.Repeat((byte) expected, 2051).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteList2051MapMin()
        {
            const byte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToList();

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
            var source =  Enumerable.Repeat(new { X = (byte) expected} , 2).ToList();
            double result = ZEnumerable.Average(source, arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                    

         
                [TestMethod]
        public void TestAveragebyteIList0()
        {            
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat((byte) expected, 0).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteIList0Map()
        {
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToIList();

            double result = ZEnumerable.Average(source, arg => (byte) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteIList0Min()
        {            
            const byte expected = 1;
            var source = Enumerable.Repeat((byte) expected, 0).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteIList0MapMin()
        {
            const byte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToIList();

            double result = ZEnumerable.Average(source, arg => (byte) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
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
        public void TestAveragebyteIList2049()
        {            
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat((byte) expected, 2049).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteIList2049Map()
        {
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToIList();

            double result = ZEnumerable.Average(source, arg => (byte) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteIList2049Min()
        {            
            const byte expected = 1;
            var source = Enumerable.Repeat((byte) expected, 2049).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteIList2049MapMin()
        {
            const byte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToIList();

            double result = ZEnumerable.Average(source, arg => (byte) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
          
                [TestMethod]
        public void TestAveragebyteIList2051()
        {            
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat((byte) expected, 2051).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteIList2051Map()
        {
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToIList();

            double result = ZEnumerable.Average(source, arg => (byte) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteIList2051Min()
        {            
            const byte expected = 1;
            var source = Enumerable.Repeat((byte) expected, 2051).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteIList2051MapMin()
        {
            const byte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToIList();

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
            var source =  Enumerable.Repeat(new { X = (byte) expected} , 2).ToIList();
            double result = ZEnumerable.Average(source, arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                        
        #endregion
    
        #region short             
            

         
                [TestMethod]
        public void TestAverageshortArray0()
        {            
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat((short) expected, 0).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortArray0Map()
        {
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToArray();

            double result = ZEnumerable.Average(source, arg => (short) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortArray0Min()
        {            
            const short expected = 1;
            var source = Enumerable.Repeat((short) expected, 0).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortArray0MapMin()
        {
            const short expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToArray();

            double result = ZEnumerable.Average(source, arg => (short) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
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
        public void TestAverageshortArray2049()
        {            
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat((short) expected, 2049).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortArray2049Map()
        {
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToArray();

            double result = ZEnumerable.Average(source, arg => (short) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortArray2049Min()
        {            
            const short expected = 1;
            var source = Enumerable.Repeat((short) expected, 2049).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortArray2049MapMin()
        {
            const short expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToArray();

            double result = ZEnumerable.Average(source, arg => (short) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
          
                [TestMethod]
        public void TestAverageshortArray2051()
        {            
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat((short) expected, 2051).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortArray2051Map()
        {
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToArray();

            double result = ZEnumerable.Average(source, arg => (short) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortArray2051Min()
        {            
            const short expected = 1;
            var source = Enumerable.Repeat((short) expected, 2051).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortArray2051MapMin()
        {
            const short expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToArray();

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
            var source =  Enumerable.Repeat(new { X = (short) expected} , 2).ToArray();
            double result = ZEnumerable.Average(source, arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                    

         
                [TestMethod]
        public void TestAverageshortList0()
        {            
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat((short) expected, 0).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortList0Map()
        {
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToList();

            double result = ZEnumerable.Average(source, arg => (short) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortList0Min()
        {            
            const short expected = 1;
            var source = Enumerable.Repeat((short) expected, 0).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortList0MapMin()
        {
            const short expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToList();

            double result = ZEnumerable.Average(source, arg => (short) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
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
        public void TestAverageshortList2049()
        {            
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat((short) expected, 2049).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortList2049Map()
        {
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToList();

            double result = ZEnumerable.Average(source, arg => (short) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortList2049Min()
        {            
            const short expected = 1;
            var source = Enumerable.Repeat((short) expected, 2049).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortList2049MapMin()
        {
            const short expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToList();

            double result = ZEnumerable.Average(source, arg => (short) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
          
                [TestMethod]
        public void TestAverageshortList2051()
        {            
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat((short) expected, 2051).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortList2051Map()
        {
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToList();

            double result = ZEnumerable.Average(source, arg => (short) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortList2051Min()
        {            
            const short expected = 1;
            var source = Enumerable.Repeat((short) expected, 2051).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortList2051MapMin()
        {
            const short expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToList();

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
            var source =  Enumerable.Repeat(new { X = (short) expected} , 2).ToList();
            double result = ZEnumerable.Average(source, arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                    

         
                [TestMethod]
        public void TestAverageshortIList0()
        {            
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat((short) expected, 0).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortIList0Map()
        {
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToIList();

            double result = ZEnumerable.Average(source, arg => (short) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortIList0Min()
        {            
            const short expected = 1;
            var source = Enumerable.Repeat((short) expected, 0).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortIList0MapMin()
        {
            const short expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToIList();

            double result = ZEnumerable.Average(source, arg => (short) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
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
        public void TestAverageshortIList2049()
        {            
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat((short) expected, 2049).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortIList2049Map()
        {
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToIList();

            double result = ZEnumerable.Average(source, arg => (short) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortIList2049Min()
        {            
            const short expected = 1;
            var source = Enumerable.Repeat((short) expected, 2049).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortIList2049MapMin()
        {
            const short expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToIList();

            double result = ZEnumerable.Average(source, arg => (short) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
          
                [TestMethod]
        public void TestAverageshortIList2051()
        {            
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat((short) expected, 2051).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortIList2051Map()
        {
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToIList();

            double result = ZEnumerable.Average(source, arg => (short) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortIList2051Min()
        {            
            const short expected = 1;
            var source = Enumerable.Repeat((short) expected, 2051).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortIList2051MapMin()
        {
            const short expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToIList();

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
            var source =  Enumerable.Repeat(new { X = (short) expected} , 2).ToIList();
            double result = ZEnumerable.Average(source, arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                        
        #endregion
    
        #region ushort             
            

         
                [TestMethod]
        public void TestAverageushortArray0()
        {            
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat((ushort) expected, 0).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortArray0Map()
        {
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToArray();

            double result = ZEnumerable.Average(source, arg => (ushort) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortArray0Min()
        {            
            const ushort expected = 1;
            var source = Enumerable.Repeat((ushort) expected, 0).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortArray0MapMin()
        {
            const ushort expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToArray();

            double result = ZEnumerable.Average(source, arg => (ushort) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
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
        public void TestAverageushortArray2049()
        {            
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat((ushort) expected, 2049).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortArray2049Map()
        {
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToArray();

            double result = ZEnumerable.Average(source, arg => (ushort) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortArray2049Min()
        {            
            const ushort expected = 1;
            var source = Enumerable.Repeat((ushort) expected, 2049).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortArray2049MapMin()
        {
            const ushort expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToArray();

            double result = ZEnumerable.Average(source, arg => (ushort) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
          
                [TestMethod]
        public void TestAverageushortArray2051()
        {            
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat((ushort) expected, 2051).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortArray2051Map()
        {
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToArray();

            double result = ZEnumerable.Average(source, arg => (ushort) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortArray2051Min()
        {            
            const ushort expected = 1;
            var source = Enumerable.Repeat((ushort) expected, 2051).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortArray2051MapMin()
        {
            const ushort expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToArray();

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
            var source =  Enumerable.Repeat(new { X = (ushort) expected} , 2).ToArray();
            double result = ZEnumerable.Average(source, arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                    

         
                [TestMethod]
        public void TestAverageushortList0()
        {            
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat((ushort) expected, 0).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortList0Map()
        {
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToList();

            double result = ZEnumerable.Average(source, arg => (ushort) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortList0Min()
        {            
            const ushort expected = 1;
            var source = Enumerable.Repeat((ushort) expected, 0).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortList0MapMin()
        {
            const ushort expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToList();

            double result = ZEnumerable.Average(source, arg => (ushort) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
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
        public void TestAverageushortList2049()
        {            
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat((ushort) expected, 2049).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortList2049Map()
        {
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToList();

            double result = ZEnumerable.Average(source, arg => (ushort) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortList2049Min()
        {            
            const ushort expected = 1;
            var source = Enumerable.Repeat((ushort) expected, 2049).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortList2049MapMin()
        {
            const ushort expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToList();

            double result = ZEnumerable.Average(source, arg => (ushort) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
          
                [TestMethod]
        public void TestAverageushortList2051()
        {            
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat((ushort) expected, 2051).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortList2051Map()
        {
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToList();

            double result = ZEnumerable.Average(source, arg => (ushort) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortList2051Min()
        {            
            const ushort expected = 1;
            var source = Enumerable.Repeat((ushort) expected, 2051).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortList2051MapMin()
        {
            const ushort expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToList();

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
            var source =  Enumerable.Repeat(new { X = (ushort) expected} , 2).ToList();
            double result = ZEnumerable.Average(source, arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                    

         
                [TestMethod]
        public void TestAverageushortIList0()
        {            
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat((ushort) expected, 0).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortIList0Map()
        {
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToIList();

            double result = ZEnumerable.Average(source, arg => (ushort) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortIList0Min()
        {            
            const ushort expected = 1;
            var source = Enumerable.Repeat((ushort) expected, 0).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortIList0MapMin()
        {
            const ushort expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToIList();

            double result = ZEnumerable.Average(source, arg => (ushort) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
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
        public void TestAverageushortIList2049()
        {            
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat((ushort) expected, 2049).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortIList2049Map()
        {
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToIList();

            double result = ZEnumerable.Average(source, arg => (ushort) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortIList2049Min()
        {            
            const ushort expected = 1;
            var source = Enumerable.Repeat((ushort) expected, 2049).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortIList2049MapMin()
        {
            const ushort expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToIList();

            double result = ZEnumerable.Average(source, arg => (ushort) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
          
                [TestMethod]
        public void TestAverageushortIList2051()
        {            
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat((ushort) expected, 2051).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortIList2051Map()
        {
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToIList();

            double result = ZEnumerable.Average(source, arg => (ushort) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortIList2051Min()
        {            
            const ushort expected = 1;
            var source = Enumerable.Repeat((ushort) expected, 2051).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortIList2051MapMin()
        {
            const ushort expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToIList();

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
            var source =  Enumerable.Repeat(new { X = (ushort) expected} , 2).ToIList();
            double result = ZEnumerable.Average(source, arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                        
        #endregion
    
        #region int             
            

         
                [TestMethod]
        public void TestAverageintArray0()
        {            
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat((int) expected, 0).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintArray0Map()
        {
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToArray();

            double result = ZEnumerable.Average(source, arg => (int) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintArray0Min()
        {            
            const int expected = 1;
            var source = Enumerable.Repeat((int) expected, 0).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintArray0MapMin()
        {
            const int expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToArray();

            double result = ZEnumerable.Average(source, arg => (int) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
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
        public void TestAverageintArray2049()
        {            
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat((int) expected, 2049).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintArray2049Map()
        {
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToArray();

            double result = ZEnumerable.Average(source, arg => (int) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintArray2049Min()
        {            
            const int expected = 1;
            var source = Enumerable.Repeat((int) expected, 2049).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintArray2049MapMin()
        {
            const int expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToArray();

            double result = ZEnumerable.Average(source, arg => (int) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
          
                [TestMethod]
        public void TestAverageintArray2051()
        {            
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat((int) expected, 2051).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintArray2051Map()
        {
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToArray();

            double result = ZEnumerable.Average(source, arg => (int) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintArray2051Min()
        {            
            const int expected = 1;
            var source = Enumerable.Repeat((int) expected, 2051).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintArray2051MapMin()
        {
            const int expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToArray();

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
            var source =  Enumerable.Repeat(new { X = (int) expected} , 2).ToArray();
            double result = ZEnumerable.Average(source, arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                    

         
                [TestMethod]
        public void TestAverageintList0()
        {            
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat((int) expected, 0).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintList0Map()
        {
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToList();

            double result = ZEnumerable.Average(source, arg => (int) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintList0Min()
        {            
            const int expected = 1;
            var source = Enumerable.Repeat((int) expected, 0).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintList0MapMin()
        {
            const int expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToList();

            double result = ZEnumerable.Average(source, arg => (int) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
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
        public void TestAverageintList2049()
        {            
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat((int) expected, 2049).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintList2049Map()
        {
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToList();

            double result = ZEnumerable.Average(source, arg => (int) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintList2049Min()
        {            
            const int expected = 1;
            var source = Enumerable.Repeat((int) expected, 2049).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintList2049MapMin()
        {
            const int expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToList();

            double result = ZEnumerable.Average(source, arg => (int) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
          
                [TestMethod]
        public void TestAverageintList2051()
        {            
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat((int) expected, 2051).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintList2051Map()
        {
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToList();

            double result = ZEnumerable.Average(source, arg => (int) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintList2051Min()
        {            
            const int expected = 1;
            var source = Enumerable.Repeat((int) expected, 2051).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintList2051MapMin()
        {
            const int expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToList();

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
            var source =  Enumerable.Repeat(new { X = (int) expected} , 2).ToList();
            double result = ZEnumerable.Average(source, arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                    

         
                [TestMethod]
        public void TestAverageintIList0()
        {            
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat((int) expected, 0).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintIList0Map()
        {
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToIList();

            double result = ZEnumerable.Average(source, arg => (int) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintIList0Min()
        {            
            const int expected = 1;
            var source = Enumerable.Repeat((int) expected, 0).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintIList0MapMin()
        {
            const int expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToIList();

            double result = ZEnumerable.Average(source, arg => (int) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
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
        public void TestAverageintIList2049()
        {            
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat((int) expected, 2049).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintIList2049Map()
        {
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToIList();

            double result = ZEnumerable.Average(source, arg => (int) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintIList2049Min()
        {            
            const int expected = 1;
            var source = Enumerable.Repeat((int) expected, 2049).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintIList2049MapMin()
        {
            const int expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToIList();

            double result = ZEnumerable.Average(source, arg => (int) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
          
                [TestMethod]
        public void TestAverageintIList2051()
        {            
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat((int) expected, 2051).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintIList2051Map()
        {
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToIList();

            double result = ZEnumerable.Average(source, arg => (int) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintIList2051Min()
        {            
            const int expected = 1;
            var source = Enumerable.Repeat((int) expected, 2051).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintIList2051MapMin()
        {
            const int expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToIList();

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
            var source =  Enumerable.Repeat(new { X = (int) expected} , 2).ToIList();
            double result = ZEnumerable.Average(source, arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                        
        #endregion
    
        #region uint             
            

         
                [TestMethod]
        public void TestAverageuintArray0()
        {            
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat((uint) expected, 0).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintArray0Map()
        {
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToArray();

            double result = ZEnumerable.Average(source, arg => (uint) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintArray0Min()
        {            
            const uint expected = 1;
            var source = Enumerable.Repeat((uint) expected, 0).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintArray0MapMin()
        {
            const uint expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToArray();

            double result = ZEnumerable.Average(source, arg => (uint) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
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
        public void TestAverageuintArray2049()
        {            
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat((uint) expected, 2049).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintArray2049Map()
        {
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToArray();

            double result = ZEnumerable.Average(source, arg => (uint) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintArray2049Min()
        {            
            const uint expected = 1;
            var source = Enumerable.Repeat((uint) expected, 2049).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintArray2049MapMin()
        {
            const uint expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToArray();

            double result = ZEnumerable.Average(source, arg => (uint) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
          
                [TestMethod]
        public void TestAverageuintArray2051()
        {            
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat((uint) expected, 2051).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintArray2051Map()
        {
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToArray();

            double result = ZEnumerable.Average(source, arg => (uint) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintArray2051Min()
        {            
            const uint expected = 1;
            var source = Enumerable.Repeat((uint) expected, 2051).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintArray2051MapMin()
        {
            const uint expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToArray();

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
            var source =  Enumerable.Repeat(new { X = (uint) expected} , 2).ToArray();
            double result = ZEnumerable.Average(source, arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                    

         
                [TestMethod]
        public void TestAverageuintList0()
        {            
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat((uint) expected, 0).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintList0Map()
        {
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToList();

            double result = ZEnumerable.Average(source, arg => (uint) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintList0Min()
        {            
            const uint expected = 1;
            var source = Enumerable.Repeat((uint) expected, 0).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintList0MapMin()
        {
            const uint expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToList();

            double result = ZEnumerable.Average(source, arg => (uint) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
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
        public void TestAverageuintList2049()
        {            
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat((uint) expected, 2049).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintList2049Map()
        {
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToList();

            double result = ZEnumerable.Average(source, arg => (uint) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintList2049Min()
        {            
            const uint expected = 1;
            var source = Enumerable.Repeat((uint) expected, 2049).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintList2049MapMin()
        {
            const uint expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToList();

            double result = ZEnumerable.Average(source, arg => (uint) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
          
                [TestMethod]
        public void TestAverageuintList2051()
        {            
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat((uint) expected, 2051).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintList2051Map()
        {
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToList();

            double result = ZEnumerable.Average(source, arg => (uint) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintList2051Min()
        {            
            const uint expected = 1;
            var source = Enumerable.Repeat((uint) expected, 2051).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintList2051MapMin()
        {
            const uint expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToList();

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
            var source =  Enumerable.Repeat(new { X = (uint) expected} , 2).ToList();
            double result = ZEnumerable.Average(source, arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                    

         
                [TestMethod]
        public void TestAverageuintIList0()
        {            
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat((uint) expected, 0).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintIList0Map()
        {
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToIList();

            double result = ZEnumerable.Average(source, arg => (uint) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintIList0Min()
        {            
            const uint expected = 1;
            var source = Enumerable.Repeat((uint) expected, 0).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintIList0MapMin()
        {
            const uint expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToIList();

            double result = ZEnumerable.Average(source, arg => (uint) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
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
        public void TestAverageuintIList2049()
        {            
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat((uint) expected, 2049).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintIList2049Map()
        {
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToIList();

            double result = ZEnumerable.Average(source, arg => (uint) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintIList2049Min()
        {            
            const uint expected = 1;
            var source = Enumerable.Repeat((uint) expected, 2049).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintIList2049MapMin()
        {
            const uint expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToIList();

            double result = ZEnumerable.Average(source, arg => (uint) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
          
                [TestMethod]
        public void TestAverageuintIList2051()
        {            
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat((uint) expected, 2051).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintIList2051Map()
        {
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToIList();

            double result = ZEnumerable.Average(source, arg => (uint) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintIList2051Min()
        {            
            const uint expected = 1;
            var source = Enumerable.Repeat((uint) expected, 2051).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintIList2051MapMin()
        {
            const uint expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToIList();

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
            var source =  Enumerable.Repeat(new { X = (uint) expected} , 2).ToIList();
            double result = ZEnumerable.Average(source, arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                        
        #endregion
    
        #region long             
            

         
                [TestMethod]
        public void TestAveragelongArray0()
        {            
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat((long) expected, 0).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongArray0Map()
        {
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToArray();

            double result = ZEnumerable.Average(source, arg => (long) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongArray0Min()
        {            
            const long expected = 1;
            var source = Enumerable.Repeat((long) expected, 0).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongArray0MapMin()
        {
            const long expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToArray();

            double result = ZEnumerable.Average(source, arg => (long) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
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
        public void TestAveragelongArray2049()
        {            
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat((long) expected, 2049).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongArray2049Map()
        {
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToArray();

            double result = ZEnumerable.Average(source, arg => (long) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongArray2049Min()
        {            
            const long expected = 1;
            var source = Enumerable.Repeat((long) expected, 2049).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongArray2049MapMin()
        {
            const long expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToArray();

            double result = ZEnumerable.Average(source, arg => (long) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
          
                [TestMethod]
        public void TestAveragelongArray2051()
        {            
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat((long) expected, 2051).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongArray2051Map()
        {
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToArray();

            double result = ZEnumerable.Average(source, arg => (long) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongArray2051Min()
        {            
            const long expected = 1;
            var source = Enumerable.Repeat((long) expected, 2051).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongArray2051MapMin()
        {
            const long expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToArray();

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
            var source =  Enumerable.Repeat(new { X = (long) expected} , 2).ToArray();
            double result = ZEnumerable.Average(source, arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                    

         
                [TestMethod]
        public void TestAveragelongList0()
        {            
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat((long) expected, 0).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongList0Map()
        {
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToList();

            double result = ZEnumerable.Average(source, arg => (long) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongList0Min()
        {            
            const long expected = 1;
            var source = Enumerable.Repeat((long) expected, 0).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongList0MapMin()
        {
            const long expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToList();

            double result = ZEnumerable.Average(source, arg => (long) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
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
        public void TestAveragelongList2049()
        {            
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat((long) expected, 2049).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongList2049Map()
        {
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToList();

            double result = ZEnumerable.Average(source, arg => (long) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongList2049Min()
        {            
            const long expected = 1;
            var source = Enumerable.Repeat((long) expected, 2049).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongList2049MapMin()
        {
            const long expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToList();

            double result = ZEnumerable.Average(source, arg => (long) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
          
                [TestMethod]
        public void TestAveragelongList2051()
        {            
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat((long) expected, 2051).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongList2051Map()
        {
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToList();

            double result = ZEnumerable.Average(source, arg => (long) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongList2051Min()
        {            
            const long expected = 1;
            var source = Enumerable.Repeat((long) expected, 2051).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongList2051MapMin()
        {
            const long expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToList();

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
            var source =  Enumerable.Repeat(new { X = (long) expected} , 2).ToList();
            double result = ZEnumerable.Average(source, arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                    

         
                [TestMethod]
        public void TestAveragelongIList0()
        {            
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat((long) expected, 0).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongIList0Map()
        {
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToIList();

            double result = ZEnumerable.Average(source, arg => (long) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongIList0Min()
        {            
            const long expected = 1;
            var source = Enumerable.Repeat((long) expected, 0).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongIList0MapMin()
        {
            const long expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToIList();

            double result = ZEnumerable.Average(source, arg => (long) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
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
        public void TestAveragelongIList2049()
        {            
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat((long) expected, 2049).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongIList2049Map()
        {
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToIList();

            double result = ZEnumerable.Average(source, arg => (long) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongIList2049Min()
        {            
            const long expected = 1;
            var source = Enumerable.Repeat((long) expected, 2049).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongIList2049MapMin()
        {
            const long expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToIList();

            double result = ZEnumerable.Average(source, arg => (long) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
          
                [TestMethod]
        public void TestAveragelongIList2051()
        {            
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat((long) expected, 2051).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongIList2051Map()
        {
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToIList();

            double result = ZEnumerable.Average(source, arg => (long) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongIList2051Min()
        {            
            const long expected = 1;
            var source = Enumerable.Repeat((long) expected, 2051).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongIList2051MapMin()
        {
            const long expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToIList();

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
            var source =  Enumerable.Repeat(new { X = (long) expected} , 2).ToIList();
            double result = ZEnumerable.Average(source, arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                        
        #endregion
    
        #region ulong             
            

         
                [TestMethod]
        public void TestAverageulongArray0()
        {            
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat((ulong) expected, 0).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongArray0Map()
        {
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToArray();

            double result = ZEnumerable.Average(source, arg => (ulong) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongArray0Min()
        {            
            const ulong expected = 1;
            var source = Enumerable.Repeat((ulong) expected, 0).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongArray0MapMin()
        {
            const ulong expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToArray();

            double result = ZEnumerable.Average(source, arg => (ulong) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
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
        public void TestAverageulongArray2049()
        {            
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat((ulong) expected, 2049).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongArray2049Map()
        {
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToArray();

            double result = ZEnumerable.Average(source, arg => (ulong) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongArray2049Min()
        {            
            const ulong expected = 1;
            var source = Enumerable.Repeat((ulong) expected, 2049).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongArray2049MapMin()
        {
            const ulong expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToArray();

            double result = ZEnumerable.Average(source, arg => (ulong) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
          
                [TestMethod]
        public void TestAverageulongArray2051()
        {            
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat((ulong) expected, 2051).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongArray2051Map()
        {
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToArray();

            double result = ZEnumerable.Average(source, arg => (ulong) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongArray2051Min()
        {            
            const ulong expected = 1;
            var source = Enumerable.Repeat((ulong) expected, 2051).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongArray2051MapMin()
        {
            const ulong expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToArray();

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
            var source =  Enumerable.Repeat(new { X = (ulong) expected} , 2).ToArray();
            double result = ZEnumerable.Average(source, arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                    

         
                [TestMethod]
        public void TestAverageulongList0()
        {            
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat((ulong) expected, 0).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongList0Map()
        {
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToList();

            double result = ZEnumerable.Average(source, arg => (ulong) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongList0Min()
        {            
            const ulong expected = 1;
            var source = Enumerable.Repeat((ulong) expected, 0).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongList0MapMin()
        {
            const ulong expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToList();

            double result = ZEnumerable.Average(source, arg => (ulong) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
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
        public void TestAverageulongList2049()
        {            
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat((ulong) expected, 2049).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongList2049Map()
        {
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToList();

            double result = ZEnumerable.Average(source, arg => (ulong) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongList2049Min()
        {            
            const ulong expected = 1;
            var source = Enumerable.Repeat((ulong) expected, 2049).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongList2049MapMin()
        {
            const ulong expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToList();

            double result = ZEnumerable.Average(source, arg => (ulong) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
          
                [TestMethod]
        public void TestAverageulongList2051()
        {            
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat((ulong) expected, 2051).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongList2051Map()
        {
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToList();

            double result = ZEnumerable.Average(source, arg => (ulong) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongList2051Min()
        {            
            const ulong expected = 1;
            var source = Enumerable.Repeat((ulong) expected, 2051).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongList2051MapMin()
        {
            const ulong expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToList();

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
            var source =  Enumerable.Repeat(new { X = (ulong) expected} , 2).ToList();
            double result = ZEnumerable.Average(source, arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                    

         
                [TestMethod]
        public void TestAverageulongIList0()
        {            
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat((ulong) expected, 0).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongIList0Map()
        {
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToIList();

            double result = ZEnumerable.Average(source, arg => (ulong) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongIList0Min()
        {            
            const ulong expected = 1;
            var source = Enumerable.Repeat((ulong) expected, 0).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongIList0MapMin()
        {
            const ulong expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToIList();

            double result = ZEnumerable.Average(source, arg => (ulong) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
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
        public void TestAverageulongIList2049()
        {            
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat((ulong) expected, 2049).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongIList2049Map()
        {
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToIList();

            double result = ZEnumerable.Average(source, arg => (ulong) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongIList2049Min()
        {            
            const ulong expected = 1;
            var source = Enumerable.Repeat((ulong) expected, 2049).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongIList2049MapMin()
        {
            const ulong expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToIList();

            double result = ZEnumerable.Average(source, arg => (ulong) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
          
                [TestMethod]
        public void TestAverageulongIList2051()
        {            
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat((ulong) expected, 2051).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongIList2051Map()
        {
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToIList();

            double result = ZEnumerable.Average(source, arg => (ulong) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongIList2051Min()
        {            
            const ulong expected = 1;
            var source = Enumerable.Repeat((ulong) expected, 2051).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongIList2051MapMin()
        {
            const ulong expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToIList();

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
            var source =  Enumerable.Repeat(new { X = (ulong) expected} , 2).ToIList();
            double result = ZEnumerable.Average(source, arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                        
        #endregion
    
        #region float             
            

         
                [TestMethod]
        public void TestAveragefloatArray0()
        {            
            const float expected = short.MaxValue;
            var source = Enumerable.Repeat((float) expected, 0).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatArray0Map()
        {
            const float expected = short.MaxValue;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToArray();

            double result = ZEnumerable.Average(source, arg => (float) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatArray0Min()
        {            
            const float expected = 1;
            var source = Enumerable.Repeat((float) expected, 0).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatArray0MapMin()
        {
            const float expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToArray();

            double result = ZEnumerable.Average(source, arg => (float) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
          
                [TestMethod]
        public void TestAveragefloatArray1()
        {            
            const float expected = short.MaxValue;
            var source = Enumerable.Repeat((float) expected, 1).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatArray1Map()
        {
            const float expected = short.MaxValue;
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
            const float expected = short.MaxValue;
            var source = Enumerable.Repeat((float) expected, 2).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatArray2Map()
        {
            const float expected = short.MaxValue;
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
            const float expected = short.MaxValue;
            var source = Enumerable.Repeat((float) expected, 3).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatArray3Map()
        {
            const float expected = short.MaxValue;
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
            const float expected = short.MaxValue;
            var source = Enumerable.Repeat((float) expected, 4).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatArray4Map()
        {
            const float expected = short.MaxValue;
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
            const float expected = short.MaxValue;
            var source = Enumerable.Repeat((float) expected, 100).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatArray100Map()
        {
            const float expected = short.MaxValue;
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
        public void TestAveragefloatArray2049()
        {            
            const float expected = short.MaxValue;
            var source = Enumerable.Repeat((float) expected, 2049).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatArray2049Map()
        {
            const float expected = short.MaxValue;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToArray();

            double result = ZEnumerable.Average(source, arg => (float) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatArray2049Min()
        {            
            const float expected = 1;
            var source = Enumerable.Repeat((float) expected, 2049).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatArray2049MapMin()
        {
            const float expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToArray();

            double result = ZEnumerable.Average(source, arg => (float) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
          
                [TestMethod]
        public void TestAveragefloatArray2051()
        {            
            const float expected = short.MaxValue;
            var source = Enumerable.Repeat((float) expected, 2051).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatArray2051Map()
        {
            const float expected = short.MaxValue;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToArray();

            double result = ZEnumerable.Average(source, arg => (float) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatArray2051Min()
        {            
            const float expected = 1;
            var source = Enumerable.Repeat((float) expected, 2051).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatArray2051MapMin()
        {
            const float expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToArray();

            double result = ZEnumerable.Average(source, arg => (float) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
          
        
                    

         
                [TestMethod]
        public void TestAveragefloatList0()
        {            
            const float expected = short.MaxValue;
            var source = Enumerable.Repeat((float) expected, 0).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatList0Map()
        {
            const float expected = short.MaxValue;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToList();

            double result = ZEnumerable.Average(source, arg => (float) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatList0Min()
        {            
            const float expected = 1;
            var source = Enumerable.Repeat((float) expected, 0).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatList0MapMin()
        {
            const float expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToList();

            double result = ZEnumerable.Average(source, arg => (float) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
          
                [TestMethod]
        public void TestAveragefloatList1()
        {            
            const float expected = short.MaxValue;
            var source = Enumerable.Repeat((float) expected, 1).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatList1Map()
        {
            const float expected = short.MaxValue;
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
            const float expected = short.MaxValue;
            var source = Enumerable.Repeat((float) expected, 2).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatList2Map()
        {
            const float expected = short.MaxValue;
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
            const float expected = short.MaxValue;
            var source = Enumerable.Repeat((float) expected, 3).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatList3Map()
        {
            const float expected = short.MaxValue;
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
            const float expected = short.MaxValue;
            var source = Enumerable.Repeat((float) expected, 4).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatList4Map()
        {
            const float expected = short.MaxValue;
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
            const float expected = short.MaxValue;
            var source = Enumerable.Repeat((float) expected, 100).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatList100Map()
        {
            const float expected = short.MaxValue;
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
        public void TestAveragefloatList2049()
        {            
            const float expected = short.MaxValue;
            var source = Enumerable.Repeat((float) expected, 2049).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatList2049Map()
        {
            const float expected = short.MaxValue;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToList();

            double result = ZEnumerable.Average(source, arg => (float) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatList2049Min()
        {            
            const float expected = 1;
            var source = Enumerable.Repeat((float) expected, 2049).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatList2049MapMin()
        {
            const float expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToList();

            double result = ZEnumerable.Average(source, arg => (float) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
          
                [TestMethod]
        public void TestAveragefloatList2051()
        {            
            const float expected = short.MaxValue;
            var source = Enumerable.Repeat((float) expected, 2051).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatList2051Map()
        {
            const float expected = short.MaxValue;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToList();

            double result = ZEnumerable.Average(source, arg => (float) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatList2051Min()
        {            
            const float expected = 1;
            var source = Enumerable.Repeat((float) expected, 2051).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatList2051MapMin()
        {
            const float expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToList();

            double result = ZEnumerable.Average(source, arg => (float) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
          
        
                    

         
                [TestMethod]
        public void TestAveragefloatIList0()
        {            
            const float expected = short.MaxValue;
            var source = Enumerable.Repeat((float) expected, 0).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatIList0Map()
        {
            const float expected = short.MaxValue;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToIList();

            double result = ZEnumerable.Average(source, arg => (float) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatIList0Min()
        {            
            const float expected = 1;
            var source = Enumerable.Repeat((float) expected, 0).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatIList0MapMin()
        {
            const float expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToIList();

            double result = ZEnumerable.Average(source, arg => (float) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
          
                [TestMethod]
        public void TestAveragefloatIList1()
        {            
            const float expected = short.MaxValue;
            var source = Enumerable.Repeat((float) expected, 1).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatIList1Map()
        {
            const float expected = short.MaxValue;
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
            const float expected = short.MaxValue;
            var source = Enumerable.Repeat((float) expected, 2).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatIList2Map()
        {
            const float expected = short.MaxValue;
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
            const float expected = short.MaxValue;
            var source = Enumerable.Repeat((float) expected, 3).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatIList3Map()
        {
            const float expected = short.MaxValue;
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
            const float expected = short.MaxValue;
            var source = Enumerable.Repeat((float) expected, 4).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatIList4Map()
        {
            const float expected = short.MaxValue;
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
            const float expected = short.MaxValue;
            var source = Enumerable.Repeat((float) expected, 100).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatIList100Map()
        {
            const float expected = short.MaxValue;
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
        public void TestAveragefloatIList2049()
        {            
            const float expected = short.MaxValue;
            var source = Enumerable.Repeat((float) expected, 2049).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatIList2049Map()
        {
            const float expected = short.MaxValue;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToIList();

            double result = ZEnumerable.Average(source, arg => (float) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatIList2049Min()
        {            
            const float expected = 1;
            var source = Enumerable.Repeat((float) expected, 2049).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatIList2049MapMin()
        {
            const float expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToIList();

            double result = ZEnumerable.Average(source, arg => (float) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
          
                [TestMethod]
        public void TestAveragefloatIList2051()
        {            
            const float expected = short.MaxValue;
            var source = Enumerable.Repeat((float) expected, 2051).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatIList2051Map()
        {
            const float expected = short.MaxValue;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToIList();

            double result = ZEnumerable.Average(source, arg => (float) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatIList2051Min()
        {            
            const float expected = 1;
            var source = Enumerable.Repeat((float) expected, 2051).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatIList2051MapMin()
        {
            const float expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToIList();

            double result = ZEnumerable.Average(source, arg => (float) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
          
        
                        
        #endregion
    
        #region double             
            

         
                [TestMethod]
        public void TestAveragedoubleArray0()
        {            
            const double expected = short.MaxValue;
            var source = Enumerable.Repeat((double) expected, 0).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleArray0Map()
        {
            const double expected = short.MaxValue;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToArray();

            double result = ZEnumerable.Average(source, arg => (double) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleArray0Min()
        {            
            const double expected = 1;
            var source = Enumerable.Repeat((double) expected, 0).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleArray0MapMin()
        {
            const double expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToArray();

            double result = ZEnumerable.Average(source, arg => (double) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
          
                [TestMethod]
        public void TestAveragedoubleArray1()
        {            
            const double expected = short.MaxValue;
            var source = Enumerable.Repeat((double) expected, 1).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleArray1Map()
        {
            const double expected = short.MaxValue;
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
            const double expected = short.MaxValue;
            var source = Enumerable.Repeat((double) expected, 2).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleArray2Map()
        {
            const double expected = short.MaxValue;
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
            const double expected = short.MaxValue;
            var source = Enumerable.Repeat((double) expected, 3).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleArray3Map()
        {
            const double expected = short.MaxValue;
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
            const double expected = short.MaxValue;
            var source = Enumerable.Repeat((double) expected, 4).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleArray4Map()
        {
            const double expected = short.MaxValue;
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
            const double expected = short.MaxValue;
            var source = Enumerable.Repeat((double) expected, 100).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleArray100Map()
        {
            const double expected = short.MaxValue;
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
        public void TestAveragedoubleArray2049()
        {            
            const double expected = short.MaxValue;
            var source = Enumerable.Repeat((double) expected, 2049).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleArray2049Map()
        {
            const double expected = short.MaxValue;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToArray();

            double result = ZEnumerable.Average(source, arg => (double) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleArray2049Min()
        {            
            const double expected = 1;
            var source = Enumerable.Repeat((double) expected, 2049).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleArray2049MapMin()
        {
            const double expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToArray();

            double result = ZEnumerable.Average(source, arg => (double) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
          
                [TestMethod]
        public void TestAveragedoubleArray2051()
        {            
            const double expected = short.MaxValue;
            var source = Enumerable.Repeat((double) expected, 2051).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleArray2051Map()
        {
            const double expected = short.MaxValue;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToArray();

            double result = ZEnumerable.Average(source, arg => (double) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleArray2051Min()
        {            
            const double expected = 1;
            var source = Enumerable.Repeat((double) expected, 2051).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleArray2051MapMin()
        {
            const double expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToArray();

            double result = ZEnumerable.Average(source, arg => (double) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
          
        
                    

         
                [TestMethod]
        public void TestAveragedoubleList0()
        {            
            const double expected = short.MaxValue;
            var source = Enumerable.Repeat((double) expected, 0).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleList0Map()
        {
            const double expected = short.MaxValue;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToList();

            double result = ZEnumerable.Average(source, arg => (double) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleList0Min()
        {            
            const double expected = 1;
            var source = Enumerable.Repeat((double) expected, 0).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleList0MapMin()
        {
            const double expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToList();

            double result = ZEnumerable.Average(source, arg => (double) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
          
                [TestMethod]
        public void TestAveragedoubleList1()
        {            
            const double expected = short.MaxValue;
            var source = Enumerable.Repeat((double) expected, 1).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleList1Map()
        {
            const double expected = short.MaxValue;
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
            const double expected = short.MaxValue;
            var source = Enumerable.Repeat((double) expected, 2).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleList2Map()
        {
            const double expected = short.MaxValue;
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
            const double expected = short.MaxValue;
            var source = Enumerable.Repeat((double) expected, 3).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleList3Map()
        {
            const double expected = short.MaxValue;
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
            const double expected = short.MaxValue;
            var source = Enumerable.Repeat((double) expected, 4).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleList4Map()
        {
            const double expected = short.MaxValue;
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
            const double expected = short.MaxValue;
            var source = Enumerable.Repeat((double) expected, 100).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleList100Map()
        {
            const double expected = short.MaxValue;
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
        public void TestAveragedoubleList2049()
        {            
            const double expected = short.MaxValue;
            var source = Enumerable.Repeat((double) expected, 2049).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleList2049Map()
        {
            const double expected = short.MaxValue;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToList();

            double result = ZEnumerable.Average(source, arg => (double) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleList2049Min()
        {            
            const double expected = 1;
            var source = Enumerable.Repeat((double) expected, 2049).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleList2049MapMin()
        {
            const double expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToList();

            double result = ZEnumerable.Average(source, arg => (double) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
          
                [TestMethod]
        public void TestAveragedoubleList2051()
        {            
            const double expected = short.MaxValue;
            var source = Enumerable.Repeat((double) expected, 2051).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleList2051Map()
        {
            const double expected = short.MaxValue;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToList();

            double result = ZEnumerable.Average(source, arg => (double) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleList2051Min()
        {            
            const double expected = 1;
            var source = Enumerable.Repeat((double) expected, 2051).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleList2051MapMin()
        {
            const double expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToList();

            double result = ZEnumerable.Average(source, arg => (double) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
          
        
                    

         
                [TestMethod]
        public void TestAveragedoubleIList0()
        {            
            const double expected = short.MaxValue;
            var source = Enumerable.Repeat((double) expected, 0).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleIList0Map()
        {
            const double expected = short.MaxValue;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToIList();

            double result = ZEnumerable.Average(source, arg => (double) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleIList0Min()
        {            
            const double expected = 1;
            var source = Enumerable.Repeat((double) expected, 0).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleIList0MapMin()
        {
            const double expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToIList();

            double result = ZEnumerable.Average(source, arg => (double) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
          
                [TestMethod]
        public void TestAveragedoubleIList1()
        {            
            const double expected = short.MaxValue;
            var source = Enumerable.Repeat((double) expected, 1).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleIList1Map()
        {
            const double expected = short.MaxValue;
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
            const double expected = short.MaxValue;
            var source = Enumerable.Repeat((double) expected, 2).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleIList2Map()
        {
            const double expected = short.MaxValue;
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
            const double expected = short.MaxValue;
            var source = Enumerable.Repeat((double) expected, 3).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleIList3Map()
        {
            const double expected = short.MaxValue;
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
            const double expected = short.MaxValue;
            var source = Enumerable.Repeat((double) expected, 4).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleIList4Map()
        {
            const double expected = short.MaxValue;
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
            const double expected = short.MaxValue;
            var source = Enumerable.Repeat((double) expected, 100).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleIList100Map()
        {
            const double expected = short.MaxValue;
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
        public void TestAveragedoubleIList2049()
        {            
            const double expected = short.MaxValue;
            var source = Enumerable.Repeat((double) expected, 2049).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleIList2049Map()
        {
            const double expected = short.MaxValue;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToIList();

            double result = ZEnumerable.Average(source, arg => (double) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleIList2049Min()
        {            
            const double expected = 1;
            var source = Enumerable.Repeat((double) expected, 2049).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleIList2049MapMin()
        {
            const double expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToIList();

            double result = ZEnumerable.Average(source, arg => (double) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
          
                [TestMethod]
        public void TestAveragedoubleIList2051()
        {            
            const double expected = short.MaxValue;
            var source = Enumerable.Repeat((double) expected, 2051).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleIList2051Map()
        {
            const double expected = short.MaxValue;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToIList();

            double result = ZEnumerable.Average(source, arg => (double) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleIList2051Min()
        {            
            const double expected = 1;
            var source = Enumerable.Repeat((double) expected, 2051).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleIList2051MapMin()
        {
            const double expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToIList();

            double result = ZEnumerable.Average(source, arg => (double) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
          
        
                        
        #endregion
    
        #region decimal             
            

         
                [TestMethod]
        public void TestAveragedecimalArray0()
        {            
            const decimal expected = short.MaxValue;
            var source = Enumerable.Repeat((decimal) expected, 0).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalArray0Map()
        {
            const decimal expected = short.MaxValue;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToArray();

            double result = ZEnumerable.Average(source, arg => (decimal) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalArray0Min()
        {            
            const decimal expected = 1;
            var source = Enumerable.Repeat((decimal) expected, 0).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalArray0MapMin()
        {
            const decimal expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToArray();

            double result = ZEnumerable.Average(source, arg => (decimal) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
          
                [TestMethod]
        public void TestAveragedecimalArray1()
        {            
            const decimal expected = short.MaxValue;
            var source = Enumerable.Repeat((decimal) expected, 1).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalArray1Map()
        {
            const decimal expected = short.MaxValue;
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
            const decimal expected = short.MaxValue;
            var source = Enumerable.Repeat((decimal) expected, 2).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalArray2Map()
        {
            const decimal expected = short.MaxValue;
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
            const decimal expected = short.MaxValue;
            var source = Enumerable.Repeat((decimal) expected, 3).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalArray3Map()
        {
            const decimal expected = short.MaxValue;
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
            const decimal expected = short.MaxValue;
            var source = Enumerable.Repeat((decimal) expected, 4).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalArray4Map()
        {
            const decimal expected = short.MaxValue;
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
            const decimal expected = short.MaxValue;
            var source = Enumerable.Repeat((decimal) expected, 100).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalArray100Map()
        {
            const decimal expected = short.MaxValue;
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
        public void TestAveragedecimalArray2049()
        {            
            const decimal expected = short.MaxValue;
            var source = Enumerable.Repeat((decimal) expected, 2049).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalArray2049Map()
        {
            const decimal expected = short.MaxValue;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToArray();

            double result = ZEnumerable.Average(source, arg => (decimal) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalArray2049Min()
        {            
            const decimal expected = 1;
            var source = Enumerable.Repeat((decimal) expected, 2049).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalArray2049MapMin()
        {
            const decimal expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToArray();

            double result = ZEnumerable.Average(source, arg => (decimal) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
          
                [TestMethod]
        public void TestAveragedecimalArray2051()
        {            
            const decimal expected = short.MaxValue;
            var source = Enumerable.Repeat((decimal) expected, 2051).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalArray2051Map()
        {
            const decimal expected = short.MaxValue;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToArray();

            double result = ZEnumerable.Average(source, arg => (decimal) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalArray2051Min()
        {            
            const decimal expected = 1;
            var source = Enumerable.Repeat((decimal) expected, 2051).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalArray2051MapMin()
        {
            const decimal expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToArray();

            double result = ZEnumerable.Average(source, arg => (decimal) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
          
        
                    

         
                [TestMethod]
        public void TestAveragedecimalList0()
        {            
            const decimal expected = short.MaxValue;
            var source = Enumerable.Repeat((decimal) expected, 0).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalList0Map()
        {
            const decimal expected = short.MaxValue;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToList();

            double result = ZEnumerable.Average(source, arg => (decimal) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalList0Min()
        {            
            const decimal expected = 1;
            var source = Enumerable.Repeat((decimal) expected, 0).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalList0MapMin()
        {
            const decimal expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToList();

            double result = ZEnumerable.Average(source, arg => (decimal) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
          
                [TestMethod]
        public void TestAveragedecimalList1()
        {            
            const decimal expected = short.MaxValue;
            var source = Enumerable.Repeat((decimal) expected, 1).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalList1Map()
        {
            const decimal expected = short.MaxValue;
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
            const decimal expected = short.MaxValue;
            var source = Enumerable.Repeat((decimal) expected, 2).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalList2Map()
        {
            const decimal expected = short.MaxValue;
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
            const decimal expected = short.MaxValue;
            var source = Enumerable.Repeat((decimal) expected, 3).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalList3Map()
        {
            const decimal expected = short.MaxValue;
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
            const decimal expected = short.MaxValue;
            var source = Enumerable.Repeat((decimal) expected, 4).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalList4Map()
        {
            const decimal expected = short.MaxValue;
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
            const decimal expected = short.MaxValue;
            var source = Enumerable.Repeat((decimal) expected, 100).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalList100Map()
        {
            const decimal expected = short.MaxValue;
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
        public void TestAveragedecimalList2049()
        {            
            const decimal expected = short.MaxValue;
            var source = Enumerable.Repeat((decimal) expected, 2049).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalList2049Map()
        {
            const decimal expected = short.MaxValue;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToList();

            double result = ZEnumerable.Average(source, arg => (decimal) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalList2049Min()
        {            
            const decimal expected = 1;
            var source = Enumerable.Repeat((decimal) expected, 2049).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalList2049MapMin()
        {
            const decimal expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToList();

            double result = ZEnumerable.Average(source, arg => (decimal) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
          
                [TestMethod]
        public void TestAveragedecimalList2051()
        {            
            const decimal expected = short.MaxValue;
            var source = Enumerable.Repeat((decimal) expected, 2051).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalList2051Map()
        {
            const decimal expected = short.MaxValue;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToList();

            double result = ZEnumerable.Average(source, arg => (decimal) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalList2051Min()
        {            
            const decimal expected = 1;
            var source = Enumerable.Repeat((decimal) expected, 2051).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalList2051MapMin()
        {
            const decimal expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToList();

            double result = ZEnumerable.Average(source, arg => (decimal) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
          
        
                    

         
                [TestMethod]
        public void TestAveragedecimalIList0()
        {            
            const decimal expected = short.MaxValue;
            var source = Enumerable.Repeat((decimal) expected, 0).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalIList0Map()
        {
            const decimal expected = short.MaxValue;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToIList();

            double result = ZEnumerable.Average(source, arg => (decimal) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalIList0Min()
        {            
            const decimal expected = 1;
            var source = Enumerable.Repeat((decimal) expected, 0).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalIList0MapMin()
        {
            const decimal expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToIList();

            double result = ZEnumerable.Average(source, arg => (decimal) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
          
                [TestMethod]
        public void TestAveragedecimalIList1()
        {            
            const decimal expected = short.MaxValue;
            var source = Enumerable.Repeat((decimal) expected, 1).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalIList1Map()
        {
            const decimal expected = short.MaxValue;
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
            const decimal expected = short.MaxValue;
            var source = Enumerable.Repeat((decimal) expected, 2).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalIList2Map()
        {
            const decimal expected = short.MaxValue;
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
            const decimal expected = short.MaxValue;
            var source = Enumerable.Repeat((decimal) expected, 3).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalIList3Map()
        {
            const decimal expected = short.MaxValue;
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
            const decimal expected = short.MaxValue;
            var source = Enumerable.Repeat((decimal) expected, 4).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalIList4Map()
        {
            const decimal expected = short.MaxValue;
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
            const decimal expected = short.MaxValue;
            var source = Enumerable.Repeat((decimal) expected, 100).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalIList100Map()
        {
            const decimal expected = short.MaxValue;
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
        public void TestAveragedecimalIList2049()
        {            
            const decimal expected = short.MaxValue;
            var source = Enumerable.Repeat((decimal) expected, 2049).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalIList2049Map()
        {
            const decimal expected = short.MaxValue;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToIList();

            double result = ZEnumerable.Average(source, arg => (decimal) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalIList2049Min()
        {            
            const decimal expected = 1;
            var source = Enumerable.Repeat((decimal) expected, 2049).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalIList2049MapMin()
        {
            const decimal expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToIList();

            double result = ZEnumerable.Average(source, arg => (decimal) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
          
                [TestMethod]
        public void TestAveragedecimalIList2051()
        {            
            const decimal expected = short.MaxValue;
            var source = Enumerable.Repeat((decimal) expected, 2051).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalIList2051Map()
        {
            const decimal expected = short.MaxValue;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToIList();

            double result = ZEnumerable.Average(source, arg => (decimal) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalIList2051Min()
        {            
            const decimal expected = 1;
            var source = Enumerable.Repeat((decimal) expected, 2051).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalIList2051MapMin()
        {
            const decimal expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToIList();

            double result = ZEnumerable.Average(source, arg => (decimal) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
          
        
                        
        #endregion
    
        #region sbyte?             
            

         
                [TestMethod]
        public void TestAveragesbyteNullableArray0()
        {            
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat((sbyte?) expected, 0).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteNullableArray0Map()
        {
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToArray();

            double result = ZEnumerable.Average(source, arg => (sbyte?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteNullableArray0Min()
        {            
            const sbyte expected = 1;
            var source = Enumerable.Repeat((sbyte?) expected, 0).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteNullableArray0MapMin()
        {
            const sbyte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToArray();

            double result = ZEnumerable.Average(source, arg => (sbyte?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
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
        public void TestAveragesbyteNullableArray2049()
        {            
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat((sbyte?) expected, 2049).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteNullableArray2049Map()
        {
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToArray();

            double result = ZEnumerable.Average(source, arg => (sbyte?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteNullableArray2049Min()
        {            
            const sbyte expected = 1;
            var source = Enumerable.Repeat((sbyte?) expected, 2049).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteNullableArray2049MapMin()
        {
            const sbyte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToArray();

            double result = ZEnumerable.Average(source, arg => (sbyte?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
          
                [TestMethod]
        public void TestAveragesbyteNullableArray2051()
        {            
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat((sbyte?) expected, 2051).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteNullableArray2051Map()
        {
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToArray();

            double result = ZEnumerable.Average(source, arg => (sbyte?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteNullableArray2051Min()
        {            
            const sbyte expected = 1;
            var source = Enumerable.Repeat((sbyte?) expected, 2051).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteNullableArray2051MapMin()
        {
            const sbyte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToArray();

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
            var source =  Enumerable.Repeat(new { X = (sbyte?) expected} , 2).ToArray();
            double result = ZEnumerable.Average(source, arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                    

         
                [TestMethod]
        public void TestAveragesbyteNullableList0()
        {            
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat((sbyte?) expected, 0).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteNullableList0Map()
        {
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToList();

            double result = ZEnumerable.Average(source, arg => (sbyte?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteNullableList0Min()
        {            
            const sbyte expected = 1;
            var source = Enumerable.Repeat((sbyte?) expected, 0).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteNullableList0MapMin()
        {
            const sbyte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToList();

            double result = ZEnumerable.Average(source, arg => (sbyte?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
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
        public void TestAveragesbyteNullableList2049()
        {            
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat((sbyte?) expected, 2049).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteNullableList2049Map()
        {
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToList();

            double result = ZEnumerable.Average(source, arg => (sbyte?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteNullableList2049Min()
        {            
            const sbyte expected = 1;
            var source = Enumerable.Repeat((sbyte?) expected, 2049).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteNullableList2049MapMin()
        {
            const sbyte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToList();

            double result = ZEnumerable.Average(source, arg => (sbyte?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
          
                [TestMethod]
        public void TestAveragesbyteNullableList2051()
        {            
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat((sbyte?) expected, 2051).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteNullableList2051Map()
        {
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToList();

            double result = ZEnumerable.Average(source, arg => (sbyte?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteNullableList2051Min()
        {            
            const sbyte expected = 1;
            var source = Enumerable.Repeat((sbyte?) expected, 2051).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteNullableList2051MapMin()
        {
            const sbyte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToList();

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
            var source =  Enumerable.Repeat(new { X = (sbyte?) expected} , 2).ToList();
            double result = ZEnumerable.Average(source, arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                    

         
                [TestMethod]
        public void TestAveragesbyteNullableIList0()
        {            
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat((sbyte?) expected, 0).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteNullableIList0Map()
        {
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToIList();

            double result = ZEnumerable.Average(source, arg => (sbyte?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteNullableIList0Min()
        {            
            const sbyte expected = 1;
            var source = Enumerable.Repeat((sbyte?) expected, 0).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteNullableIList0MapMin()
        {
            const sbyte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToIList();

            double result = ZEnumerable.Average(source, arg => (sbyte?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
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
        public void TestAveragesbyteNullableIList2049()
        {            
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat((sbyte?) expected, 2049).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteNullableIList2049Map()
        {
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToIList();

            double result = ZEnumerable.Average(source, arg => (sbyte?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteNullableIList2049Min()
        {            
            const sbyte expected = 1;
            var source = Enumerable.Repeat((sbyte?) expected, 2049).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteNullableIList2049MapMin()
        {
            const sbyte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToIList();

            double result = ZEnumerable.Average(source, arg => (sbyte?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
          
                [TestMethod]
        public void TestAveragesbyteNullableIList2051()
        {            
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat((sbyte?) expected, 2051).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteNullableIList2051Map()
        {
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToIList();

            double result = ZEnumerable.Average(source, arg => (sbyte?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteNullableIList2051Min()
        {            
            const sbyte expected = 1;
            var source = Enumerable.Repeat((sbyte?) expected, 2051).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteNullableIList2051MapMin()
        {
            const sbyte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToIList();

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
            var source =  Enumerable.Repeat(new { X = (sbyte?) expected} , 2).ToIList();
            double result = ZEnumerable.Average(source, arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                        
        #endregion
    
        #region byte?             
            

         
                [TestMethod]
        public void TestAveragebyteNullableArray0()
        {            
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat((byte?) expected, 0).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteNullableArray0Map()
        {
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToArray();

            double result = ZEnumerable.Average(source, arg => (byte?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteNullableArray0Min()
        {            
            const byte expected = 1;
            var source = Enumerable.Repeat((byte?) expected, 0).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteNullableArray0MapMin()
        {
            const byte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToArray();

            double result = ZEnumerable.Average(source, arg => (byte?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
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
        public void TestAveragebyteNullableArray2049()
        {            
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat((byte?) expected, 2049).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteNullableArray2049Map()
        {
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToArray();

            double result = ZEnumerable.Average(source, arg => (byte?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteNullableArray2049Min()
        {            
            const byte expected = 1;
            var source = Enumerable.Repeat((byte?) expected, 2049).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteNullableArray2049MapMin()
        {
            const byte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToArray();

            double result = ZEnumerable.Average(source, arg => (byte?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
          
                [TestMethod]
        public void TestAveragebyteNullableArray2051()
        {            
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat((byte?) expected, 2051).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteNullableArray2051Map()
        {
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToArray();

            double result = ZEnumerable.Average(source, arg => (byte?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteNullableArray2051Min()
        {            
            const byte expected = 1;
            var source = Enumerable.Repeat((byte?) expected, 2051).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteNullableArray2051MapMin()
        {
            const byte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToArray();

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
            var source =  Enumerable.Repeat(new { X = (byte?) expected} , 2).ToArray();
            double result = ZEnumerable.Average(source, arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                    

         
                [TestMethod]
        public void TestAveragebyteNullableList0()
        {            
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat((byte?) expected, 0).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteNullableList0Map()
        {
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToList();

            double result = ZEnumerable.Average(source, arg => (byte?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteNullableList0Min()
        {            
            const byte expected = 1;
            var source = Enumerable.Repeat((byte?) expected, 0).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteNullableList0MapMin()
        {
            const byte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToList();

            double result = ZEnumerable.Average(source, arg => (byte?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
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
        public void TestAveragebyteNullableList2049()
        {            
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat((byte?) expected, 2049).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteNullableList2049Map()
        {
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToList();

            double result = ZEnumerable.Average(source, arg => (byte?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteNullableList2049Min()
        {            
            const byte expected = 1;
            var source = Enumerable.Repeat((byte?) expected, 2049).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteNullableList2049MapMin()
        {
            const byte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToList();

            double result = ZEnumerable.Average(source, arg => (byte?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
          
                [TestMethod]
        public void TestAveragebyteNullableList2051()
        {            
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat((byte?) expected, 2051).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteNullableList2051Map()
        {
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToList();

            double result = ZEnumerable.Average(source, arg => (byte?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteNullableList2051Min()
        {            
            const byte expected = 1;
            var source = Enumerable.Repeat((byte?) expected, 2051).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteNullableList2051MapMin()
        {
            const byte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToList();

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
            var source =  Enumerable.Repeat(new { X = (byte?) expected} , 2).ToList();
            double result = ZEnumerable.Average(source, arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                    

         
                [TestMethod]
        public void TestAveragebyteNullableIList0()
        {            
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat((byte?) expected, 0).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteNullableIList0Map()
        {
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToIList();

            double result = ZEnumerable.Average(source, arg => (byte?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteNullableIList0Min()
        {            
            const byte expected = 1;
            var source = Enumerable.Repeat((byte?) expected, 0).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteNullableIList0MapMin()
        {
            const byte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToIList();

            double result = ZEnumerable.Average(source, arg => (byte?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
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
        public void TestAveragebyteNullableIList2049()
        {            
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat((byte?) expected, 2049).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteNullableIList2049Map()
        {
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToIList();

            double result = ZEnumerable.Average(source, arg => (byte?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteNullableIList2049Min()
        {            
            const byte expected = 1;
            var source = Enumerable.Repeat((byte?) expected, 2049).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteNullableIList2049MapMin()
        {
            const byte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToIList();

            double result = ZEnumerable.Average(source, arg => (byte?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
          
                [TestMethod]
        public void TestAveragebyteNullableIList2051()
        {            
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat((byte?) expected, 2051).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteNullableIList2051Map()
        {
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToIList();

            double result = ZEnumerable.Average(source, arg => (byte?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteNullableIList2051Min()
        {            
            const byte expected = 1;
            var source = Enumerable.Repeat((byte?) expected, 2051).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteNullableIList2051MapMin()
        {
            const byte expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToIList();

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
            var source =  Enumerable.Repeat(new { X = (byte?) expected} , 2).ToIList();
            double result = ZEnumerable.Average(source, arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                        
        #endregion
    
        #region short?             
            

         
                [TestMethod]
        public void TestAverageshortNullableArray0()
        {            
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat((short?) expected, 0).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortNullableArray0Map()
        {
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToArray();

            double result = ZEnumerable.Average(source, arg => (short?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortNullableArray0Min()
        {            
            const short expected = 1;
            var source = Enumerable.Repeat((short?) expected, 0).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortNullableArray0MapMin()
        {
            const short expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToArray();

            double result = ZEnumerable.Average(source, arg => (short?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
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
        public void TestAverageshortNullableArray2049()
        {            
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat((short?) expected, 2049).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortNullableArray2049Map()
        {
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToArray();

            double result = ZEnumerable.Average(source, arg => (short?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortNullableArray2049Min()
        {            
            const short expected = 1;
            var source = Enumerable.Repeat((short?) expected, 2049).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortNullableArray2049MapMin()
        {
            const short expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToArray();

            double result = ZEnumerable.Average(source, arg => (short?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
          
                [TestMethod]
        public void TestAverageshortNullableArray2051()
        {            
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat((short?) expected, 2051).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortNullableArray2051Map()
        {
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToArray();

            double result = ZEnumerable.Average(source, arg => (short?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortNullableArray2051Min()
        {            
            const short expected = 1;
            var source = Enumerable.Repeat((short?) expected, 2051).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortNullableArray2051MapMin()
        {
            const short expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToArray();

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
            var source =  Enumerable.Repeat(new { X = (short?) expected} , 2).ToArray();
            double result = ZEnumerable.Average(source, arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                    

         
                [TestMethod]
        public void TestAverageshortNullableList0()
        {            
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat((short?) expected, 0).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortNullableList0Map()
        {
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToList();

            double result = ZEnumerable.Average(source, arg => (short?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortNullableList0Min()
        {            
            const short expected = 1;
            var source = Enumerable.Repeat((short?) expected, 0).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortNullableList0MapMin()
        {
            const short expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToList();

            double result = ZEnumerable.Average(source, arg => (short?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
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
        public void TestAverageshortNullableList2049()
        {            
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat((short?) expected, 2049).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortNullableList2049Map()
        {
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToList();

            double result = ZEnumerable.Average(source, arg => (short?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortNullableList2049Min()
        {            
            const short expected = 1;
            var source = Enumerable.Repeat((short?) expected, 2049).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortNullableList2049MapMin()
        {
            const short expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToList();

            double result = ZEnumerable.Average(source, arg => (short?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
          
                [TestMethod]
        public void TestAverageshortNullableList2051()
        {            
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat((short?) expected, 2051).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortNullableList2051Map()
        {
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToList();

            double result = ZEnumerable.Average(source, arg => (short?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortNullableList2051Min()
        {            
            const short expected = 1;
            var source = Enumerable.Repeat((short?) expected, 2051).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortNullableList2051MapMin()
        {
            const short expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToList();

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
            var source =  Enumerable.Repeat(new { X = (short?) expected} , 2).ToList();
            double result = ZEnumerable.Average(source, arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                    

         
                [TestMethod]
        public void TestAverageshortNullableIList0()
        {            
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat((short?) expected, 0).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortNullableIList0Map()
        {
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToIList();

            double result = ZEnumerable.Average(source, arg => (short?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortNullableIList0Min()
        {            
            const short expected = 1;
            var source = Enumerable.Repeat((short?) expected, 0).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortNullableIList0MapMin()
        {
            const short expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToIList();

            double result = ZEnumerable.Average(source, arg => (short?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
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
        public void TestAverageshortNullableIList2049()
        {            
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat((short?) expected, 2049).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortNullableIList2049Map()
        {
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToIList();

            double result = ZEnumerable.Average(source, arg => (short?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortNullableIList2049Min()
        {            
            const short expected = 1;
            var source = Enumerable.Repeat((short?) expected, 2049).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortNullableIList2049MapMin()
        {
            const short expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToIList();

            double result = ZEnumerable.Average(source, arg => (short?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
          
                [TestMethod]
        public void TestAverageshortNullableIList2051()
        {            
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat((short?) expected, 2051).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortNullableIList2051Map()
        {
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToIList();

            double result = ZEnumerable.Average(source, arg => (short?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortNullableIList2051Min()
        {            
            const short expected = 1;
            var source = Enumerable.Repeat((short?) expected, 2051).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortNullableIList2051MapMin()
        {
            const short expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToIList();

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
            var source =  Enumerable.Repeat(new { X = (short?) expected} , 2).ToIList();
            double result = ZEnumerable.Average(source, arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                        
        #endregion
    
        #region ushort?             
            

         
                [TestMethod]
        public void TestAverageushortNullableArray0()
        {            
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat((ushort?) expected, 0).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortNullableArray0Map()
        {
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToArray();

            double result = ZEnumerable.Average(source, arg => (ushort?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortNullableArray0Min()
        {            
            const ushort expected = 1;
            var source = Enumerable.Repeat((ushort?) expected, 0).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortNullableArray0MapMin()
        {
            const ushort expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToArray();

            double result = ZEnumerable.Average(source, arg => (ushort?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
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
        public void TestAverageushortNullableArray2049()
        {            
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat((ushort?) expected, 2049).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortNullableArray2049Map()
        {
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToArray();

            double result = ZEnumerable.Average(source, arg => (ushort?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortNullableArray2049Min()
        {            
            const ushort expected = 1;
            var source = Enumerable.Repeat((ushort?) expected, 2049).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortNullableArray2049MapMin()
        {
            const ushort expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToArray();

            double result = ZEnumerable.Average(source, arg => (ushort?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
          
                [TestMethod]
        public void TestAverageushortNullableArray2051()
        {            
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat((ushort?) expected, 2051).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortNullableArray2051Map()
        {
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToArray();

            double result = ZEnumerable.Average(source, arg => (ushort?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortNullableArray2051Min()
        {            
            const ushort expected = 1;
            var source = Enumerable.Repeat((ushort?) expected, 2051).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortNullableArray2051MapMin()
        {
            const ushort expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToArray();

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
            var source =  Enumerable.Repeat(new { X = (ushort?) expected} , 2).ToArray();
            double result = ZEnumerable.Average(source, arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                    

         
                [TestMethod]
        public void TestAverageushortNullableList0()
        {            
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat((ushort?) expected, 0).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortNullableList0Map()
        {
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToList();

            double result = ZEnumerable.Average(source, arg => (ushort?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortNullableList0Min()
        {            
            const ushort expected = 1;
            var source = Enumerable.Repeat((ushort?) expected, 0).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortNullableList0MapMin()
        {
            const ushort expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToList();

            double result = ZEnumerable.Average(source, arg => (ushort?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
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
        public void TestAverageushortNullableList2049()
        {            
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat((ushort?) expected, 2049).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortNullableList2049Map()
        {
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToList();

            double result = ZEnumerable.Average(source, arg => (ushort?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortNullableList2049Min()
        {            
            const ushort expected = 1;
            var source = Enumerable.Repeat((ushort?) expected, 2049).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortNullableList2049MapMin()
        {
            const ushort expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToList();

            double result = ZEnumerable.Average(source, arg => (ushort?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
          
                [TestMethod]
        public void TestAverageushortNullableList2051()
        {            
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat((ushort?) expected, 2051).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortNullableList2051Map()
        {
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToList();

            double result = ZEnumerable.Average(source, arg => (ushort?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortNullableList2051Min()
        {            
            const ushort expected = 1;
            var source = Enumerable.Repeat((ushort?) expected, 2051).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortNullableList2051MapMin()
        {
            const ushort expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToList();

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
            var source =  Enumerable.Repeat(new { X = (ushort?) expected} , 2).ToList();
            double result = ZEnumerable.Average(source, arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                    

         
                [TestMethod]
        public void TestAverageushortNullableIList0()
        {            
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat((ushort?) expected, 0).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortNullableIList0Map()
        {
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToIList();

            double result = ZEnumerable.Average(source, arg => (ushort?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortNullableIList0Min()
        {            
            const ushort expected = 1;
            var source = Enumerable.Repeat((ushort?) expected, 0).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortNullableIList0MapMin()
        {
            const ushort expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToIList();

            double result = ZEnumerable.Average(source, arg => (ushort?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
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
        public void TestAverageushortNullableIList2049()
        {            
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat((ushort?) expected, 2049).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortNullableIList2049Map()
        {
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToIList();

            double result = ZEnumerable.Average(source, arg => (ushort?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortNullableIList2049Min()
        {            
            const ushort expected = 1;
            var source = Enumerable.Repeat((ushort?) expected, 2049).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortNullableIList2049MapMin()
        {
            const ushort expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToIList();

            double result = ZEnumerable.Average(source, arg => (ushort?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
          
                [TestMethod]
        public void TestAverageushortNullableIList2051()
        {            
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat((ushort?) expected, 2051).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortNullableIList2051Map()
        {
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToIList();

            double result = ZEnumerable.Average(source, arg => (ushort?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortNullableIList2051Min()
        {            
            const ushort expected = 1;
            var source = Enumerable.Repeat((ushort?) expected, 2051).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortNullableIList2051MapMin()
        {
            const ushort expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToIList();

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
            var source =  Enumerable.Repeat(new { X = (ushort?) expected} , 2).ToIList();
            double result = ZEnumerable.Average(source, arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                        
        #endregion
    
        #region int?             
            

         
                [TestMethod]
        public void TestAverageintNullableArray0()
        {            
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat((int?) expected, 0).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintNullableArray0Map()
        {
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToArray();

            double result = ZEnumerable.Average(source, arg => (int?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintNullableArray0Min()
        {            
            const int expected = 1;
            var source = Enumerable.Repeat((int?) expected, 0).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintNullableArray0MapMin()
        {
            const int expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToArray();

            double result = ZEnumerable.Average(source, arg => (int?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
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
        public void TestAverageintNullableArray2049()
        {            
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat((int?) expected, 2049).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintNullableArray2049Map()
        {
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToArray();

            double result = ZEnumerable.Average(source, arg => (int?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintNullableArray2049Min()
        {            
            const int expected = 1;
            var source = Enumerable.Repeat((int?) expected, 2049).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintNullableArray2049MapMin()
        {
            const int expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToArray();

            double result = ZEnumerable.Average(source, arg => (int?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
          
                [TestMethod]
        public void TestAverageintNullableArray2051()
        {            
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat((int?) expected, 2051).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintNullableArray2051Map()
        {
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToArray();

            double result = ZEnumerable.Average(source, arg => (int?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintNullableArray2051Min()
        {            
            const int expected = 1;
            var source = Enumerable.Repeat((int?) expected, 2051).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintNullableArray2051MapMin()
        {
            const int expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToArray();

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
            var source =  Enumerable.Repeat(new { X = (int?) expected} , 2).ToArray();
            double result = ZEnumerable.Average(source, arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                    

         
                [TestMethod]
        public void TestAverageintNullableList0()
        {            
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat((int?) expected, 0).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintNullableList0Map()
        {
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToList();

            double result = ZEnumerable.Average(source, arg => (int?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintNullableList0Min()
        {            
            const int expected = 1;
            var source = Enumerable.Repeat((int?) expected, 0).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintNullableList0MapMin()
        {
            const int expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToList();

            double result = ZEnumerable.Average(source, arg => (int?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
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
        public void TestAverageintNullableList2049()
        {            
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat((int?) expected, 2049).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintNullableList2049Map()
        {
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToList();

            double result = ZEnumerable.Average(source, arg => (int?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintNullableList2049Min()
        {            
            const int expected = 1;
            var source = Enumerable.Repeat((int?) expected, 2049).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintNullableList2049MapMin()
        {
            const int expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToList();

            double result = ZEnumerable.Average(source, arg => (int?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
          
                [TestMethod]
        public void TestAverageintNullableList2051()
        {            
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat((int?) expected, 2051).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintNullableList2051Map()
        {
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToList();

            double result = ZEnumerable.Average(source, arg => (int?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintNullableList2051Min()
        {            
            const int expected = 1;
            var source = Enumerable.Repeat((int?) expected, 2051).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintNullableList2051MapMin()
        {
            const int expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToList();

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
            var source =  Enumerable.Repeat(new { X = (int?) expected} , 2).ToList();
            double result = ZEnumerable.Average(source, arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                    

         
                [TestMethod]
        public void TestAverageintNullableIList0()
        {            
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat((int?) expected, 0).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintNullableIList0Map()
        {
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToIList();

            double result = ZEnumerable.Average(source, arg => (int?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintNullableIList0Min()
        {            
            const int expected = 1;
            var source = Enumerable.Repeat((int?) expected, 0).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintNullableIList0MapMin()
        {
            const int expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToIList();

            double result = ZEnumerable.Average(source, arg => (int?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
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
        public void TestAverageintNullableIList2049()
        {            
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat((int?) expected, 2049).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintNullableIList2049Map()
        {
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToIList();

            double result = ZEnumerable.Average(source, arg => (int?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintNullableIList2049Min()
        {            
            const int expected = 1;
            var source = Enumerable.Repeat((int?) expected, 2049).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintNullableIList2049MapMin()
        {
            const int expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToIList();

            double result = ZEnumerable.Average(source, arg => (int?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
          
                [TestMethod]
        public void TestAverageintNullableIList2051()
        {            
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat((int?) expected, 2051).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintNullableIList2051Map()
        {
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToIList();

            double result = ZEnumerable.Average(source, arg => (int?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintNullableIList2051Min()
        {            
            const int expected = 1;
            var source = Enumerable.Repeat((int?) expected, 2051).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintNullableIList2051MapMin()
        {
            const int expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToIList();

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
            var source =  Enumerable.Repeat(new { X = (int?) expected} , 2).ToIList();
            double result = ZEnumerable.Average(source, arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                        
        #endregion
    
        #region uint?             
            

         
                [TestMethod]
        public void TestAverageuintNullableArray0()
        {            
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat((uint?) expected, 0).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintNullableArray0Map()
        {
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToArray();

            double result = ZEnumerable.Average(source, arg => (uint?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintNullableArray0Min()
        {            
            const uint expected = 1;
            var source = Enumerable.Repeat((uint?) expected, 0).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintNullableArray0MapMin()
        {
            const uint expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToArray();

            double result = ZEnumerable.Average(source, arg => (uint?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
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
        public void TestAverageuintNullableArray2049()
        {            
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat((uint?) expected, 2049).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintNullableArray2049Map()
        {
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToArray();

            double result = ZEnumerable.Average(source, arg => (uint?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintNullableArray2049Min()
        {            
            const uint expected = 1;
            var source = Enumerable.Repeat((uint?) expected, 2049).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintNullableArray2049MapMin()
        {
            const uint expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToArray();

            double result = ZEnumerable.Average(source, arg => (uint?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
          
                [TestMethod]
        public void TestAverageuintNullableArray2051()
        {            
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat((uint?) expected, 2051).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintNullableArray2051Map()
        {
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToArray();

            double result = ZEnumerable.Average(source, arg => (uint?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintNullableArray2051Min()
        {            
            const uint expected = 1;
            var source = Enumerable.Repeat((uint?) expected, 2051).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintNullableArray2051MapMin()
        {
            const uint expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToArray();

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
            var source =  Enumerable.Repeat(new { X = (uint?) expected} , 2).ToArray();
            double result = ZEnumerable.Average(source, arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                    

         
                [TestMethod]
        public void TestAverageuintNullableList0()
        {            
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat((uint?) expected, 0).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintNullableList0Map()
        {
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToList();

            double result = ZEnumerable.Average(source, arg => (uint?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintNullableList0Min()
        {            
            const uint expected = 1;
            var source = Enumerable.Repeat((uint?) expected, 0).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintNullableList0MapMin()
        {
            const uint expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToList();

            double result = ZEnumerable.Average(source, arg => (uint?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
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
        public void TestAverageuintNullableList2049()
        {            
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat((uint?) expected, 2049).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintNullableList2049Map()
        {
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToList();

            double result = ZEnumerable.Average(source, arg => (uint?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintNullableList2049Min()
        {            
            const uint expected = 1;
            var source = Enumerable.Repeat((uint?) expected, 2049).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintNullableList2049MapMin()
        {
            const uint expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToList();

            double result = ZEnumerable.Average(source, arg => (uint?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
          
                [TestMethod]
        public void TestAverageuintNullableList2051()
        {            
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat((uint?) expected, 2051).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintNullableList2051Map()
        {
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToList();

            double result = ZEnumerable.Average(source, arg => (uint?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintNullableList2051Min()
        {            
            const uint expected = 1;
            var source = Enumerable.Repeat((uint?) expected, 2051).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintNullableList2051MapMin()
        {
            const uint expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToList();

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
            var source =  Enumerable.Repeat(new { X = (uint?) expected} , 2).ToList();
            double result = ZEnumerable.Average(source, arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                    

         
                [TestMethod]
        public void TestAverageuintNullableIList0()
        {            
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat((uint?) expected, 0).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintNullableIList0Map()
        {
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToIList();

            double result = ZEnumerable.Average(source, arg => (uint?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintNullableIList0Min()
        {            
            const uint expected = 1;
            var source = Enumerable.Repeat((uint?) expected, 0).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintNullableIList0MapMin()
        {
            const uint expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToIList();

            double result = ZEnumerable.Average(source, arg => (uint?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
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
        public void TestAverageuintNullableIList2049()
        {            
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat((uint?) expected, 2049).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintNullableIList2049Map()
        {
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToIList();

            double result = ZEnumerable.Average(source, arg => (uint?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintNullableIList2049Min()
        {            
            const uint expected = 1;
            var source = Enumerable.Repeat((uint?) expected, 2049).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintNullableIList2049MapMin()
        {
            const uint expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToIList();

            double result = ZEnumerable.Average(source, arg => (uint?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
          
                [TestMethod]
        public void TestAverageuintNullableIList2051()
        {            
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat((uint?) expected, 2051).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintNullableIList2051Map()
        {
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToIList();

            double result = ZEnumerable.Average(source, arg => (uint?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintNullableIList2051Min()
        {            
            const uint expected = 1;
            var source = Enumerable.Repeat((uint?) expected, 2051).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintNullableIList2051MapMin()
        {
            const uint expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToIList();

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
            var source =  Enumerable.Repeat(new { X = (uint?) expected} , 2).ToIList();
            double result = ZEnumerable.Average(source, arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                        
        #endregion
    
        #region long?             
            

         
                [TestMethod]
        public void TestAveragelongNullableArray0()
        {            
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat((long?) expected, 0).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongNullableArray0Map()
        {
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToArray();

            double result = ZEnumerable.Average(source, arg => (long?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongNullableArray0Min()
        {            
            const long expected = 1;
            var source = Enumerable.Repeat((long?) expected, 0).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongNullableArray0MapMin()
        {
            const long expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToArray();

            double result = ZEnumerable.Average(source, arg => (long?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
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
        public void TestAveragelongNullableArray2049()
        {            
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat((long?) expected, 2049).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongNullableArray2049Map()
        {
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToArray();

            double result = ZEnumerable.Average(source, arg => (long?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongNullableArray2049Min()
        {            
            const long expected = 1;
            var source = Enumerable.Repeat((long?) expected, 2049).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongNullableArray2049MapMin()
        {
            const long expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToArray();

            double result = ZEnumerable.Average(source, arg => (long?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
          
                [TestMethod]
        public void TestAveragelongNullableArray2051()
        {            
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat((long?) expected, 2051).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongNullableArray2051Map()
        {
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToArray();

            double result = ZEnumerable.Average(source, arg => (long?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongNullableArray2051Min()
        {            
            const long expected = 1;
            var source = Enumerable.Repeat((long?) expected, 2051).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongNullableArray2051MapMin()
        {
            const long expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToArray();

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
            var source =  Enumerable.Repeat(new { X = (long?) expected} , 2).ToArray();
            double result = ZEnumerable.Average(source, arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                    

         
                [TestMethod]
        public void TestAveragelongNullableList0()
        {            
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat((long?) expected, 0).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongNullableList0Map()
        {
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToList();

            double result = ZEnumerable.Average(source, arg => (long?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongNullableList0Min()
        {            
            const long expected = 1;
            var source = Enumerable.Repeat((long?) expected, 0).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongNullableList0MapMin()
        {
            const long expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToList();

            double result = ZEnumerable.Average(source, arg => (long?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
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
        public void TestAveragelongNullableList2049()
        {            
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat((long?) expected, 2049).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongNullableList2049Map()
        {
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToList();

            double result = ZEnumerable.Average(source, arg => (long?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongNullableList2049Min()
        {            
            const long expected = 1;
            var source = Enumerable.Repeat((long?) expected, 2049).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongNullableList2049MapMin()
        {
            const long expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToList();

            double result = ZEnumerable.Average(source, arg => (long?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
          
                [TestMethod]
        public void TestAveragelongNullableList2051()
        {            
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat((long?) expected, 2051).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongNullableList2051Map()
        {
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToList();

            double result = ZEnumerable.Average(source, arg => (long?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongNullableList2051Min()
        {            
            const long expected = 1;
            var source = Enumerable.Repeat((long?) expected, 2051).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongNullableList2051MapMin()
        {
            const long expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToList();

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
            var source =  Enumerable.Repeat(new { X = (long?) expected} , 2).ToList();
            double result = ZEnumerable.Average(source, arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                    

         
                [TestMethod]
        public void TestAveragelongNullableIList0()
        {            
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat((long?) expected, 0).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongNullableIList0Map()
        {
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToIList();

            double result = ZEnumerable.Average(source, arg => (long?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongNullableIList0Min()
        {            
            const long expected = 1;
            var source = Enumerable.Repeat((long?) expected, 0).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongNullableIList0MapMin()
        {
            const long expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToIList();

            double result = ZEnumerable.Average(source, arg => (long?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
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
        public void TestAveragelongNullableIList2049()
        {            
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat((long?) expected, 2049).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongNullableIList2049Map()
        {
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToIList();

            double result = ZEnumerable.Average(source, arg => (long?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongNullableIList2049Min()
        {            
            const long expected = 1;
            var source = Enumerable.Repeat((long?) expected, 2049).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongNullableIList2049MapMin()
        {
            const long expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToIList();

            double result = ZEnumerable.Average(source, arg => (long?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
          
                [TestMethod]
        public void TestAveragelongNullableIList2051()
        {            
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat((long?) expected, 2051).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongNullableIList2051Map()
        {
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToIList();

            double result = ZEnumerable.Average(source, arg => (long?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongNullableIList2051Min()
        {            
            const long expected = 1;
            var source = Enumerable.Repeat((long?) expected, 2051).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongNullableIList2051MapMin()
        {
            const long expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToIList();

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
            var source =  Enumerable.Repeat(new { X = (long?) expected} , 2).ToIList();
            double result = ZEnumerable.Average(source, arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                        
        #endregion
    
        #region ulong?             
            

         
                [TestMethod]
        public void TestAverageulongNullableArray0()
        {            
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat((ulong?) expected, 0).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongNullableArray0Map()
        {
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToArray();

            double result = ZEnumerable.Average(source, arg => (ulong?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongNullableArray0Min()
        {            
            const ulong expected = 1;
            var source = Enumerable.Repeat((ulong?) expected, 0).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongNullableArray0MapMin()
        {
            const ulong expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToArray();

            double result = ZEnumerable.Average(source, arg => (ulong?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
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
        public void TestAverageulongNullableArray2049()
        {            
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat((ulong?) expected, 2049).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongNullableArray2049Map()
        {
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToArray();

            double result = ZEnumerable.Average(source, arg => (ulong?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongNullableArray2049Min()
        {            
            const ulong expected = 1;
            var source = Enumerable.Repeat((ulong?) expected, 2049).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongNullableArray2049MapMin()
        {
            const ulong expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToArray();

            double result = ZEnumerable.Average(source, arg => (ulong?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
          
                [TestMethod]
        public void TestAverageulongNullableArray2051()
        {            
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat((ulong?) expected, 2051).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongNullableArray2051Map()
        {
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToArray();

            double result = ZEnumerable.Average(source, arg => (ulong?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongNullableArray2051Min()
        {            
            const ulong expected = 1;
            var source = Enumerable.Repeat((ulong?) expected, 2051).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongNullableArray2051MapMin()
        {
            const ulong expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToArray();

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
            var source =  Enumerable.Repeat(new { X = (ulong?) expected} , 2).ToArray();
            double result = ZEnumerable.Average(source, arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                    

         
                [TestMethod]
        public void TestAverageulongNullableList0()
        {            
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat((ulong?) expected, 0).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongNullableList0Map()
        {
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToList();

            double result = ZEnumerable.Average(source, arg => (ulong?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongNullableList0Min()
        {            
            const ulong expected = 1;
            var source = Enumerable.Repeat((ulong?) expected, 0).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongNullableList0MapMin()
        {
            const ulong expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToList();

            double result = ZEnumerable.Average(source, arg => (ulong?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
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
        public void TestAverageulongNullableList2049()
        {            
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat((ulong?) expected, 2049).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongNullableList2049Map()
        {
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToList();

            double result = ZEnumerable.Average(source, arg => (ulong?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongNullableList2049Min()
        {            
            const ulong expected = 1;
            var source = Enumerable.Repeat((ulong?) expected, 2049).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongNullableList2049MapMin()
        {
            const ulong expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToList();

            double result = ZEnumerable.Average(source, arg => (ulong?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
          
                [TestMethod]
        public void TestAverageulongNullableList2051()
        {            
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat((ulong?) expected, 2051).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongNullableList2051Map()
        {
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToList();

            double result = ZEnumerable.Average(source, arg => (ulong?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongNullableList2051Min()
        {            
            const ulong expected = 1;
            var source = Enumerable.Repeat((ulong?) expected, 2051).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongNullableList2051MapMin()
        {
            const ulong expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToList();

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
            var source =  Enumerable.Repeat(new { X = (ulong?) expected} , 2).ToList();
            double result = ZEnumerable.Average(source, arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                    

         
                [TestMethod]
        public void TestAverageulongNullableIList0()
        {            
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat((ulong?) expected, 0).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongNullableIList0Map()
        {
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToIList();

            double result = ZEnumerable.Average(source, arg => (ulong?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongNullableIList0Min()
        {            
            const ulong expected = 1;
            var source = Enumerable.Repeat((ulong?) expected, 0).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongNullableIList0MapMin()
        {
            const ulong expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToIList();

            double result = ZEnumerable.Average(source, arg => (ulong?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
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
        public void TestAverageulongNullableIList2049()
        {            
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat((ulong?) expected, 2049).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongNullableIList2049Map()
        {
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToIList();

            double result = ZEnumerable.Average(source, arg => (ulong?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongNullableIList2049Min()
        {            
            const ulong expected = 1;
            var source = Enumerable.Repeat((ulong?) expected, 2049).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongNullableIList2049MapMin()
        {
            const ulong expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToIList();

            double result = ZEnumerable.Average(source, arg => (ulong?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
          
                [TestMethod]
        public void TestAverageulongNullableIList2051()
        {            
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat((ulong?) expected, 2051).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongNullableIList2051Map()
        {
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToIList();

            double result = ZEnumerable.Average(source, arg => (ulong?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongNullableIList2051Min()
        {            
            const ulong expected = 1;
            var source = Enumerable.Repeat((ulong?) expected, 2051).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongNullableIList2051MapMin()
        {
            const ulong expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToIList();

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
            var source =  Enumerable.Repeat(new { X = (ulong?) expected} , 2).ToIList();
            double result = ZEnumerable.Average(source, arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                        
        #endregion
    
        #region float?             
            

         
                [TestMethod]
        public void TestAveragefloatNullableArray0()
        {            
            const float expected = short.MaxValue;
            var source = Enumerable.Repeat((float?) expected, 0).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatNullableArray0Map()
        {
            const float expected = short.MaxValue;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToArray();

            double result = ZEnumerable.Average(source, arg => (float?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatNullableArray0Min()
        {            
            const float expected = 1;
            var source = Enumerable.Repeat((float?) expected, 0).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatNullableArray0MapMin()
        {
            const float expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToArray();

            double result = ZEnumerable.Average(source, arg => (float?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
          
                [TestMethod]
        public void TestAveragefloatNullableArray1()
        {            
            const float expected = short.MaxValue;
            var source = Enumerable.Repeat((float?) expected, 1).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatNullableArray1Map()
        {
            const float expected = short.MaxValue;
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
            const float expected = short.MaxValue;
            var source = Enumerable.Repeat((float?) expected, 2).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatNullableArray2Map()
        {
            const float expected = short.MaxValue;
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
            const float expected = short.MaxValue;
            var source = Enumerable.Repeat((float?) expected, 3).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatNullableArray3Map()
        {
            const float expected = short.MaxValue;
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
            const float expected = short.MaxValue;
            var source = Enumerable.Repeat((float?) expected, 4).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatNullableArray4Map()
        {
            const float expected = short.MaxValue;
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
            const float expected = short.MaxValue;
            var source = Enumerable.Repeat((float?) expected, 100).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatNullableArray100Map()
        {
            const float expected = short.MaxValue;
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
        public void TestAveragefloatNullableArray2049()
        {            
            const float expected = short.MaxValue;
            var source = Enumerable.Repeat((float?) expected, 2049).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatNullableArray2049Map()
        {
            const float expected = short.MaxValue;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToArray();

            double result = ZEnumerable.Average(source, arg => (float?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatNullableArray2049Min()
        {            
            const float expected = 1;
            var source = Enumerable.Repeat((float?) expected, 2049).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatNullableArray2049MapMin()
        {
            const float expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToArray();

            double result = ZEnumerable.Average(source, arg => (float?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
          
                [TestMethod]
        public void TestAveragefloatNullableArray2051()
        {            
            const float expected = short.MaxValue;
            var source = Enumerable.Repeat((float?) expected, 2051).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatNullableArray2051Map()
        {
            const float expected = short.MaxValue;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToArray();

            double result = ZEnumerable.Average(source, arg => (float?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatNullableArray2051Min()
        {            
            const float expected = 1;
            var source = Enumerable.Repeat((float?) expected, 2051).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatNullableArray2051MapMin()
        {
            const float expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToArray();

            double result = ZEnumerable.Average(source, arg => (float?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
          
        
                    

         
                [TestMethod]
        public void TestAveragefloatNullableList0()
        {            
            const float expected = short.MaxValue;
            var source = Enumerable.Repeat((float?) expected, 0).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatNullableList0Map()
        {
            const float expected = short.MaxValue;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToList();

            double result = ZEnumerable.Average(source, arg => (float?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatNullableList0Min()
        {            
            const float expected = 1;
            var source = Enumerable.Repeat((float?) expected, 0).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatNullableList0MapMin()
        {
            const float expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToList();

            double result = ZEnumerable.Average(source, arg => (float?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
          
                [TestMethod]
        public void TestAveragefloatNullableList1()
        {            
            const float expected = short.MaxValue;
            var source = Enumerable.Repeat((float?) expected, 1).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatNullableList1Map()
        {
            const float expected = short.MaxValue;
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
            const float expected = short.MaxValue;
            var source = Enumerable.Repeat((float?) expected, 2).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatNullableList2Map()
        {
            const float expected = short.MaxValue;
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
            const float expected = short.MaxValue;
            var source = Enumerable.Repeat((float?) expected, 3).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatNullableList3Map()
        {
            const float expected = short.MaxValue;
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
            const float expected = short.MaxValue;
            var source = Enumerable.Repeat((float?) expected, 4).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatNullableList4Map()
        {
            const float expected = short.MaxValue;
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
            const float expected = short.MaxValue;
            var source = Enumerable.Repeat((float?) expected, 100).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatNullableList100Map()
        {
            const float expected = short.MaxValue;
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
        public void TestAveragefloatNullableList2049()
        {            
            const float expected = short.MaxValue;
            var source = Enumerable.Repeat((float?) expected, 2049).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatNullableList2049Map()
        {
            const float expected = short.MaxValue;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToList();

            double result = ZEnumerable.Average(source, arg => (float?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatNullableList2049Min()
        {            
            const float expected = 1;
            var source = Enumerable.Repeat((float?) expected, 2049).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatNullableList2049MapMin()
        {
            const float expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToList();

            double result = ZEnumerable.Average(source, arg => (float?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
          
                [TestMethod]
        public void TestAveragefloatNullableList2051()
        {            
            const float expected = short.MaxValue;
            var source = Enumerable.Repeat((float?) expected, 2051).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatNullableList2051Map()
        {
            const float expected = short.MaxValue;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToList();

            double result = ZEnumerable.Average(source, arg => (float?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatNullableList2051Min()
        {            
            const float expected = 1;
            var source = Enumerable.Repeat((float?) expected, 2051).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatNullableList2051MapMin()
        {
            const float expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToList();

            double result = ZEnumerable.Average(source, arg => (float?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
          
        
                    

         
                [TestMethod]
        public void TestAveragefloatNullableIList0()
        {            
            const float expected = short.MaxValue;
            var source = Enumerable.Repeat((float?) expected, 0).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatNullableIList0Map()
        {
            const float expected = short.MaxValue;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToIList();

            double result = ZEnumerable.Average(source, arg => (float?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatNullableIList0Min()
        {            
            const float expected = 1;
            var source = Enumerable.Repeat((float?) expected, 0).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatNullableIList0MapMin()
        {
            const float expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToIList();

            double result = ZEnumerable.Average(source, arg => (float?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
          
                [TestMethod]
        public void TestAveragefloatNullableIList1()
        {            
            const float expected = short.MaxValue;
            var source = Enumerable.Repeat((float?) expected, 1).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatNullableIList1Map()
        {
            const float expected = short.MaxValue;
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
            const float expected = short.MaxValue;
            var source = Enumerable.Repeat((float?) expected, 2).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatNullableIList2Map()
        {
            const float expected = short.MaxValue;
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
            const float expected = short.MaxValue;
            var source = Enumerable.Repeat((float?) expected, 3).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatNullableIList3Map()
        {
            const float expected = short.MaxValue;
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
            const float expected = short.MaxValue;
            var source = Enumerable.Repeat((float?) expected, 4).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatNullableIList4Map()
        {
            const float expected = short.MaxValue;
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
            const float expected = short.MaxValue;
            var source = Enumerable.Repeat((float?) expected, 100).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatNullableIList100Map()
        {
            const float expected = short.MaxValue;
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
        public void TestAveragefloatNullableIList2049()
        {            
            const float expected = short.MaxValue;
            var source = Enumerable.Repeat((float?) expected, 2049).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatNullableIList2049Map()
        {
            const float expected = short.MaxValue;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToIList();

            double result = ZEnumerable.Average(source, arg => (float?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatNullableIList2049Min()
        {            
            const float expected = 1;
            var source = Enumerable.Repeat((float?) expected, 2049).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatNullableIList2049MapMin()
        {
            const float expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToIList();

            double result = ZEnumerable.Average(source, arg => (float?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
          
                [TestMethod]
        public void TestAveragefloatNullableIList2051()
        {            
            const float expected = short.MaxValue;
            var source = Enumerable.Repeat((float?) expected, 2051).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatNullableIList2051Map()
        {
            const float expected = short.MaxValue;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToIList();

            double result = ZEnumerable.Average(source, arg => (float?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatNullableIList2051Min()
        {            
            const float expected = 1;
            var source = Enumerable.Repeat((float?) expected, 2051).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatNullableIList2051MapMin()
        {
            const float expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToIList();

            double result = ZEnumerable.Average(source, arg => (float?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
          
        
                        
        #endregion
    
        #region double?             
            

         
                [TestMethod]
        public void TestAveragedoubleNullableArray0()
        {            
            const double expected = short.MaxValue;
            var source = Enumerable.Repeat((double?) expected, 0).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleNullableArray0Map()
        {
            const double expected = short.MaxValue;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToArray();

            double result = ZEnumerable.Average(source, arg => (double?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleNullableArray0Min()
        {            
            const double expected = 1;
            var source = Enumerable.Repeat((double?) expected, 0).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleNullableArray0MapMin()
        {
            const double expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToArray();

            double result = ZEnumerable.Average(source, arg => (double?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
          
                [TestMethod]
        public void TestAveragedoubleNullableArray1()
        {            
            const double expected = short.MaxValue;
            var source = Enumerable.Repeat((double?) expected, 1).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleNullableArray1Map()
        {
            const double expected = short.MaxValue;
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
            const double expected = short.MaxValue;
            var source = Enumerable.Repeat((double?) expected, 2).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleNullableArray2Map()
        {
            const double expected = short.MaxValue;
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
            const double expected = short.MaxValue;
            var source = Enumerable.Repeat((double?) expected, 3).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleNullableArray3Map()
        {
            const double expected = short.MaxValue;
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
            const double expected = short.MaxValue;
            var source = Enumerable.Repeat((double?) expected, 4).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleNullableArray4Map()
        {
            const double expected = short.MaxValue;
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
            const double expected = short.MaxValue;
            var source = Enumerable.Repeat((double?) expected, 100).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleNullableArray100Map()
        {
            const double expected = short.MaxValue;
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
        public void TestAveragedoubleNullableArray2049()
        {            
            const double expected = short.MaxValue;
            var source = Enumerable.Repeat((double?) expected, 2049).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleNullableArray2049Map()
        {
            const double expected = short.MaxValue;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToArray();

            double result = ZEnumerable.Average(source, arg => (double?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleNullableArray2049Min()
        {            
            const double expected = 1;
            var source = Enumerable.Repeat((double?) expected, 2049).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleNullableArray2049MapMin()
        {
            const double expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToArray();

            double result = ZEnumerable.Average(source, arg => (double?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
          
                [TestMethod]
        public void TestAveragedoubleNullableArray2051()
        {            
            const double expected = short.MaxValue;
            var source = Enumerable.Repeat((double?) expected, 2051).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleNullableArray2051Map()
        {
            const double expected = short.MaxValue;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToArray();

            double result = ZEnumerable.Average(source, arg => (double?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleNullableArray2051Min()
        {            
            const double expected = 1;
            var source = Enumerable.Repeat((double?) expected, 2051).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleNullableArray2051MapMin()
        {
            const double expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToArray();

            double result = ZEnumerable.Average(source, arg => (double?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
          
        
                    

         
                [TestMethod]
        public void TestAveragedoubleNullableList0()
        {            
            const double expected = short.MaxValue;
            var source = Enumerable.Repeat((double?) expected, 0).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleNullableList0Map()
        {
            const double expected = short.MaxValue;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToList();

            double result = ZEnumerable.Average(source, arg => (double?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleNullableList0Min()
        {            
            const double expected = 1;
            var source = Enumerable.Repeat((double?) expected, 0).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleNullableList0MapMin()
        {
            const double expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToList();

            double result = ZEnumerable.Average(source, arg => (double?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
          
                [TestMethod]
        public void TestAveragedoubleNullableList1()
        {            
            const double expected = short.MaxValue;
            var source = Enumerable.Repeat((double?) expected, 1).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleNullableList1Map()
        {
            const double expected = short.MaxValue;
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
            const double expected = short.MaxValue;
            var source = Enumerable.Repeat((double?) expected, 2).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleNullableList2Map()
        {
            const double expected = short.MaxValue;
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
            const double expected = short.MaxValue;
            var source = Enumerable.Repeat((double?) expected, 3).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleNullableList3Map()
        {
            const double expected = short.MaxValue;
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
            const double expected = short.MaxValue;
            var source = Enumerable.Repeat((double?) expected, 4).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleNullableList4Map()
        {
            const double expected = short.MaxValue;
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
            const double expected = short.MaxValue;
            var source = Enumerable.Repeat((double?) expected, 100).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleNullableList100Map()
        {
            const double expected = short.MaxValue;
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
        public void TestAveragedoubleNullableList2049()
        {            
            const double expected = short.MaxValue;
            var source = Enumerable.Repeat((double?) expected, 2049).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleNullableList2049Map()
        {
            const double expected = short.MaxValue;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToList();

            double result = ZEnumerable.Average(source, arg => (double?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleNullableList2049Min()
        {            
            const double expected = 1;
            var source = Enumerable.Repeat((double?) expected, 2049).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleNullableList2049MapMin()
        {
            const double expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToList();

            double result = ZEnumerable.Average(source, arg => (double?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
          
                [TestMethod]
        public void TestAveragedoubleNullableList2051()
        {            
            const double expected = short.MaxValue;
            var source = Enumerable.Repeat((double?) expected, 2051).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleNullableList2051Map()
        {
            const double expected = short.MaxValue;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToList();

            double result = ZEnumerable.Average(source, arg => (double?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleNullableList2051Min()
        {            
            const double expected = 1;
            var source = Enumerable.Repeat((double?) expected, 2051).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleNullableList2051MapMin()
        {
            const double expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToList();

            double result = ZEnumerable.Average(source, arg => (double?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
          
        
                    

         
                [TestMethod]
        public void TestAveragedoubleNullableIList0()
        {            
            const double expected = short.MaxValue;
            var source = Enumerable.Repeat((double?) expected, 0).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleNullableIList0Map()
        {
            const double expected = short.MaxValue;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToIList();

            double result = ZEnumerable.Average(source, arg => (double?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleNullableIList0Min()
        {            
            const double expected = 1;
            var source = Enumerable.Repeat((double?) expected, 0).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleNullableIList0MapMin()
        {
            const double expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToIList();

            double result = ZEnumerable.Average(source, arg => (double?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
          
                [TestMethod]
        public void TestAveragedoubleNullableIList1()
        {            
            const double expected = short.MaxValue;
            var source = Enumerable.Repeat((double?) expected, 1).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleNullableIList1Map()
        {
            const double expected = short.MaxValue;
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
            const double expected = short.MaxValue;
            var source = Enumerable.Repeat((double?) expected, 2).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleNullableIList2Map()
        {
            const double expected = short.MaxValue;
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
            const double expected = short.MaxValue;
            var source = Enumerable.Repeat((double?) expected, 3).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleNullableIList3Map()
        {
            const double expected = short.MaxValue;
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
            const double expected = short.MaxValue;
            var source = Enumerable.Repeat((double?) expected, 4).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleNullableIList4Map()
        {
            const double expected = short.MaxValue;
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
            const double expected = short.MaxValue;
            var source = Enumerable.Repeat((double?) expected, 100).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleNullableIList100Map()
        {
            const double expected = short.MaxValue;
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
        public void TestAveragedoubleNullableIList2049()
        {            
            const double expected = short.MaxValue;
            var source = Enumerable.Repeat((double?) expected, 2049).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleNullableIList2049Map()
        {
            const double expected = short.MaxValue;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToIList();

            double result = ZEnumerable.Average(source, arg => (double?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleNullableIList2049Min()
        {            
            const double expected = 1;
            var source = Enumerable.Repeat((double?) expected, 2049).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleNullableIList2049MapMin()
        {
            const double expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToIList();

            double result = ZEnumerable.Average(source, arg => (double?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
          
                [TestMethod]
        public void TestAveragedoubleNullableIList2051()
        {            
            const double expected = short.MaxValue;
            var source = Enumerable.Repeat((double?) expected, 2051).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleNullableIList2051Map()
        {
            const double expected = short.MaxValue;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToIList();

            double result = ZEnumerable.Average(source, arg => (double?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleNullableIList2051Min()
        {            
            const double expected = 1;
            var source = Enumerable.Repeat((double?) expected, 2051).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleNullableIList2051MapMin()
        {
            const double expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToIList();

            double result = ZEnumerable.Average(source, arg => (double?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
          
        
                        
        #endregion
    
        #region decimal?             
            

         
                [TestMethod]
        public void TestAveragedecimalNullableArray0()
        {            
            const decimal expected = short.MaxValue;
            var source = Enumerable.Repeat((decimal?) expected, 0).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalNullableArray0Map()
        {
            const decimal expected = short.MaxValue;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToArray();

            double result = ZEnumerable.Average(source, arg => (decimal?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalNullableArray0Min()
        {            
            const decimal expected = 1;
            var source = Enumerable.Repeat((decimal?) expected, 0).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalNullableArray0MapMin()
        {
            const decimal expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToArray();

            double result = ZEnumerable.Average(source, arg => (decimal?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
          
                [TestMethod]
        public void TestAveragedecimalNullableArray1()
        {            
            const decimal expected = short.MaxValue;
            var source = Enumerable.Repeat((decimal?) expected, 1).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalNullableArray1Map()
        {
            const decimal expected = short.MaxValue;
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
            const decimal expected = short.MaxValue;
            var source = Enumerable.Repeat((decimal?) expected, 2).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalNullableArray2Map()
        {
            const decimal expected = short.MaxValue;
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
            const decimal expected = short.MaxValue;
            var source = Enumerable.Repeat((decimal?) expected, 3).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalNullableArray3Map()
        {
            const decimal expected = short.MaxValue;
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
            const decimal expected = short.MaxValue;
            var source = Enumerable.Repeat((decimal?) expected, 4).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalNullableArray4Map()
        {
            const decimal expected = short.MaxValue;
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
            const decimal expected = short.MaxValue;
            var source = Enumerable.Repeat((decimal?) expected, 100).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalNullableArray100Map()
        {
            const decimal expected = short.MaxValue;
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
        public void TestAveragedecimalNullableArray2049()
        {            
            const decimal expected = short.MaxValue;
            var source = Enumerable.Repeat((decimal?) expected, 2049).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalNullableArray2049Map()
        {
            const decimal expected = short.MaxValue;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToArray();

            double result = ZEnumerable.Average(source, arg => (decimal?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalNullableArray2049Min()
        {            
            const decimal expected = 1;
            var source = Enumerable.Repeat((decimal?) expected, 2049).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalNullableArray2049MapMin()
        {
            const decimal expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToArray();

            double result = ZEnumerable.Average(source, arg => (decimal?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
          
                [TestMethod]
        public void TestAveragedecimalNullableArray2051()
        {            
            const decimal expected = short.MaxValue;
            var source = Enumerable.Repeat((decimal?) expected, 2051).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalNullableArray2051Map()
        {
            const decimal expected = short.MaxValue;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToArray();

            double result = ZEnumerable.Average(source, arg => (decimal?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalNullableArray2051Min()
        {            
            const decimal expected = 1;
            var source = Enumerable.Repeat((decimal?) expected, 2051).ToArray();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalNullableArray2051MapMin()
        {
            const decimal expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToArray();

            double result = ZEnumerable.Average(source, arg => (decimal?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
          
        
                    

         
                [TestMethod]
        public void TestAveragedecimalNullableList0()
        {            
            const decimal expected = short.MaxValue;
            var source = Enumerable.Repeat((decimal?) expected, 0).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalNullableList0Map()
        {
            const decimal expected = short.MaxValue;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToList();

            double result = ZEnumerable.Average(source, arg => (decimal?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalNullableList0Min()
        {            
            const decimal expected = 1;
            var source = Enumerable.Repeat((decimal?) expected, 0).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalNullableList0MapMin()
        {
            const decimal expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToList();

            double result = ZEnumerable.Average(source, arg => (decimal?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
          
                [TestMethod]
        public void TestAveragedecimalNullableList1()
        {            
            const decimal expected = short.MaxValue;
            var source = Enumerable.Repeat((decimal?) expected, 1).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalNullableList1Map()
        {
            const decimal expected = short.MaxValue;
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
            const decimal expected = short.MaxValue;
            var source = Enumerable.Repeat((decimal?) expected, 2).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalNullableList2Map()
        {
            const decimal expected = short.MaxValue;
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
            const decimal expected = short.MaxValue;
            var source = Enumerable.Repeat((decimal?) expected, 3).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalNullableList3Map()
        {
            const decimal expected = short.MaxValue;
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
            const decimal expected = short.MaxValue;
            var source = Enumerable.Repeat((decimal?) expected, 4).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalNullableList4Map()
        {
            const decimal expected = short.MaxValue;
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
            const decimal expected = short.MaxValue;
            var source = Enumerable.Repeat((decimal?) expected, 100).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalNullableList100Map()
        {
            const decimal expected = short.MaxValue;
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
        public void TestAveragedecimalNullableList2049()
        {            
            const decimal expected = short.MaxValue;
            var source = Enumerable.Repeat((decimal?) expected, 2049).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalNullableList2049Map()
        {
            const decimal expected = short.MaxValue;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToList();

            double result = ZEnumerable.Average(source, arg => (decimal?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalNullableList2049Min()
        {            
            const decimal expected = 1;
            var source = Enumerable.Repeat((decimal?) expected, 2049).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalNullableList2049MapMin()
        {
            const decimal expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToList();

            double result = ZEnumerable.Average(source, arg => (decimal?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
          
                [TestMethod]
        public void TestAveragedecimalNullableList2051()
        {            
            const decimal expected = short.MaxValue;
            var source = Enumerable.Repeat((decimal?) expected, 2051).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalNullableList2051Map()
        {
            const decimal expected = short.MaxValue;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToList();

            double result = ZEnumerable.Average(source, arg => (decimal?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalNullableList2051Min()
        {            
            const decimal expected = 1;
            var source = Enumerable.Repeat((decimal?) expected, 2051).ToList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalNullableList2051MapMin()
        {
            const decimal expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToList();

            double result = ZEnumerable.Average(source, arg => (decimal?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
          
        
                    

         
                [TestMethod]
        public void TestAveragedecimalNullableIList0()
        {            
            const decimal expected = short.MaxValue;
            var source = Enumerable.Repeat((decimal?) expected, 0).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalNullableIList0Map()
        {
            const decimal expected = short.MaxValue;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToIList();

            double result = ZEnumerable.Average(source, arg => (decimal?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalNullableIList0Min()
        {            
            const decimal expected = 1;
            var source = Enumerable.Repeat((decimal?) expected, 0).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalNullableIList0MapMin()
        {
            const decimal expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 0).ToIList();

            double result = ZEnumerable.Average(source, arg => (decimal?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
          
                [TestMethod]
        public void TestAveragedecimalNullableIList1()
        {            
            const decimal expected = short.MaxValue;
            var source = Enumerable.Repeat((decimal?) expected, 1).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalNullableIList1Map()
        {
            const decimal expected = short.MaxValue;
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
            const decimal expected = short.MaxValue;
            var source = Enumerable.Repeat((decimal?) expected, 2).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalNullableIList2Map()
        {
            const decimal expected = short.MaxValue;
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
            const decimal expected = short.MaxValue;
            var source = Enumerable.Repeat((decimal?) expected, 3).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalNullableIList3Map()
        {
            const decimal expected = short.MaxValue;
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
            const decimal expected = short.MaxValue;
            var source = Enumerable.Repeat((decimal?) expected, 4).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalNullableIList4Map()
        {
            const decimal expected = short.MaxValue;
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
            const decimal expected = short.MaxValue;
            var source = Enumerable.Repeat((decimal?) expected, 100).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalNullableIList100Map()
        {
            const decimal expected = short.MaxValue;
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
        public void TestAveragedecimalNullableIList2049()
        {            
            const decimal expected = short.MaxValue;
            var source = Enumerable.Repeat((decimal?) expected, 2049).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalNullableIList2049Map()
        {
            const decimal expected = short.MaxValue;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToIList();

            double result = ZEnumerable.Average(source, arg => (decimal?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalNullableIList2049Min()
        {            
            const decimal expected = 1;
            var source = Enumerable.Repeat((decimal?) expected, 2049).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalNullableIList2049MapMin()
        {
            const decimal expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2049).ToIList();

            double result = ZEnumerable.Average(source, arg => (decimal?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
          
                [TestMethod]
        public void TestAveragedecimalNullableIList2051()
        {            
            const decimal expected = short.MaxValue;
            var source = Enumerable.Repeat((decimal?) expected, 2051).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalNullableIList2051Map()
        {
            const decimal expected = short.MaxValue;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToIList();

            double result = ZEnumerable.Average(source, arg => (decimal?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalNullableIList2051Min()
        {            
            const decimal expected = 1;
            var source = Enumerable.Repeat((decimal?) expected, 2051).ToIList();

            double result = ZEnumerable.Average(source);

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalNullableIList2051MapMin()
        {
            const decimal expected = 1;
            var source = Enumerable.Repeat(new { X = expected}, 2051).ToIList();

            double result = ZEnumerable.Average(source, arg => (decimal?) arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
          
        
                        
        #endregion
      
    }
}