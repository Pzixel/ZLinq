
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
    
        #region float             
            

         
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
          
        
                        
        #endregion
    
        #region double             
            

         
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
          
        
                        
        #endregion
    
        #region decimal             
            

         
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
          
        
                        
        #endregion
    
        #region ulong             
            

         
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
    
        #region sbyte?             
            

         
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
    
        #region float?             
            

         
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
          
        
                        
        #endregion
    
        #region double?             
            

         
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
          
        
                        
        #endregion
    
        #region decimal?             
            

         
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
          
        
                        
        #endregion
    
        #region ulong?             
            

         
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
      
    }
}