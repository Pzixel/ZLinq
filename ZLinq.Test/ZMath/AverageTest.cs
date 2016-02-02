
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;


// ReSharper disable RedundantCast
namespace ZLinq.Test.ZMath
{
    [TestClass]
    public class Average
    {            
        private const double Tolerance = 0.0000001;
            
    
        #region sbyte             
            
        [TestMethod]
        public void TestAveragesbyteArray()
        {            
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat(expected, 100).ToArray();

            double result = source.Average();

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteArrayMap()
        {
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToArray();

            double result = source.Average(arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                        
        [TestMethod]
        public void TestAveragesbyteArrayNoOverflow()
        {
            const sbyte expected = sbyte.MaxValue;
            var source = Enumerable.Repeat(expected, 2).ToArray();
            double result = source.Average();
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
        
        [TestMethod]
        public void TestAveragesbyteArrayMapNoOverflow()
        {    
            const sbyte expected = sbyte.MaxValue;
            var source =  Enumerable.Repeat(new { X = expected} , 2).ToArray();
            double result = source.Average(arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                    
        [TestMethod]
        public void TestAveragesbyteList()
        {            
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat(expected, 100).ToList();

            double result = source.Average();

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteListMap()
        {
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToList();

            double result = source.Average(arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                        
        [TestMethod]
        public void TestAveragesbyteListNoOverflow()
        {
            const sbyte expected = sbyte.MaxValue;
            var source = Enumerable.Repeat(expected, 2).ToList();
            double result = source.Average();
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
        
        [TestMethod]
        public void TestAveragesbyteListMapNoOverflow()
        {    
            const sbyte expected = sbyte.MaxValue;
            var source =  Enumerable.Repeat(new { X = expected} , 2).ToList();
            double result = source.Average(arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                    
        [TestMethod]
        public void TestAveragesbyteIList()
        {            
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat(expected, 100).ToList();

            double result = source.Average();

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteIListMap()
        {
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToList();

            double result = source.Average(arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                        
        [TestMethod]
        public void TestAveragesbyteIListNoOverflow()
        {
            const sbyte expected = sbyte.MaxValue;
            var source = Enumerable.Repeat(expected, 2).ToList();
            double result = source.Average();
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
        
        [TestMethod]
        public void TestAveragesbyteIListMapNoOverflow()
        {    
            const sbyte expected = sbyte.MaxValue;
            var source =  Enumerable.Repeat(new { X = expected} , 2).ToList();
            double result = source.Average(arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                    
        [TestMethod]
        public void TestAveragesbyteICollection()
        {            
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat(expected, 100).ToList();

            double result = source.Average();

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragesbyteICollectionMap()
        {
            const sbyte expected = sbyte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToList();

            double result = source.Average(arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                        
        [TestMethod]
        public void TestAveragesbyteICollectionNoOverflow()
        {
            const sbyte expected = sbyte.MaxValue;
            var source = Enumerable.Repeat(expected, 2).ToList();
            double result = source.Average();
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
        
        [TestMethod]
        public void TestAveragesbyteICollectionMapNoOverflow()
        {    
            const sbyte expected = sbyte.MaxValue;
            var source =  Enumerable.Repeat(new { X = expected} , 2).ToList();
            double result = source.Average(arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                        
        #endregion
    
        #region byte             
            
        [TestMethod]
        public void TestAveragebyteArray()
        {            
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat(expected, 100).ToArray();

            double result = source.Average();

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteArrayMap()
        {
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToArray();

            double result = source.Average(arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                        
        [TestMethod]
        public void TestAveragebyteArrayNoOverflow()
        {
            const byte expected = byte.MaxValue;
            var source = Enumerable.Repeat(expected, 2).ToArray();
            double result = source.Average();
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
        
        [TestMethod]
        public void TestAveragebyteArrayMapNoOverflow()
        {    
            const byte expected = byte.MaxValue;
            var source =  Enumerable.Repeat(new { X = expected} , 2).ToArray();
            double result = source.Average(arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                    
        [TestMethod]
        public void TestAveragebyteList()
        {            
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat(expected, 100).ToList();

            double result = source.Average();

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteListMap()
        {
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToList();

            double result = source.Average(arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                        
        [TestMethod]
        public void TestAveragebyteListNoOverflow()
        {
            const byte expected = byte.MaxValue;
            var source = Enumerable.Repeat(expected, 2).ToList();
            double result = source.Average();
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
        
        [TestMethod]
        public void TestAveragebyteListMapNoOverflow()
        {    
            const byte expected = byte.MaxValue;
            var source =  Enumerable.Repeat(new { X = expected} , 2).ToList();
            double result = source.Average(arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                    
        [TestMethod]
        public void TestAveragebyteIList()
        {            
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat(expected, 100).ToList();

            double result = source.Average();

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteIListMap()
        {
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToList();

            double result = source.Average(arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                        
        [TestMethod]
        public void TestAveragebyteIListNoOverflow()
        {
            const byte expected = byte.MaxValue;
            var source = Enumerable.Repeat(expected, 2).ToList();
            double result = source.Average();
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
        
        [TestMethod]
        public void TestAveragebyteIListMapNoOverflow()
        {    
            const byte expected = byte.MaxValue;
            var source =  Enumerable.Repeat(new { X = expected} , 2).ToList();
            double result = source.Average(arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                    
        [TestMethod]
        public void TestAveragebyteICollection()
        {            
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat(expected, 100).ToList();

            double result = source.Average();

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragebyteICollectionMap()
        {
            const byte expected = byte.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToList();

            double result = source.Average(arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                        
        [TestMethod]
        public void TestAveragebyteICollectionNoOverflow()
        {
            const byte expected = byte.MaxValue;
            var source = Enumerable.Repeat(expected, 2).ToList();
            double result = source.Average();
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
        
        [TestMethod]
        public void TestAveragebyteICollectionMapNoOverflow()
        {    
            const byte expected = byte.MaxValue;
            var source =  Enumerable.Repeat(new { X = expected} , 2).ToList();
            double result = source.Average(arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                        
        #endregion
    
        #region short             
            
        [TestMethod]
        public void TestAverageshortArray()
        {            
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat(expected, 100).ToArray();

            double result = source.Average();

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortArrayMap()
        {
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToArray();

            double result = source.Average(arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                        
        [TestMethod]
        public void TestAverageshortArrayNoOverflow()
        {
            const short expected = short.MaxValue;
            var source = Enumerable.Repeat(expected, 2).ToArray();
            double result = source.Average();
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
        
        [TestMethod]
        public void TestAverageshortArrayMapNoOverflow()
        {    
            const short expected = short.MaxValue;
            var source =  Enumerable.Repeat(new { X = expected} , 2).ToArray();
            double result = source.Average(arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                    
        [TestMethod]
        public void TestAverageshortList()
        {            
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat(expected, 100).ToList();

            double result = source.Average();

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortListMap()
        {
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToList();

            double result = source.Average(arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                        
        [TestMethod]
        public void TestAverageshortListNoOverflow()
        {
            const short expected = short.MaxValue;
            var source = Enumerable.Repeat(expected, 2).ToList();
            double result = source.Average();
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
        
        [TestMethod]
        public void TestAverageshortListMapNoOverflow()
        {    
            const short expected = short.MaxValue;
            var source =  Enumerable.Repeat(new { X = expected} , 2).ToList();
            double result = source.Average(arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                    
        [TestMethod]
        public void TestAverageshortIList()
        {            
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat(expected, 100).ToList();

            double result = source.Average();

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortIListMap()
        {
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToList();

            double result = source.Average(arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                        
        [TestMethod]
        public void TestAverageshortIListNoOverflow()
        {
            const short expected = short.MaxValue;
            var source = Enumerable.Repeat(expected, 2).ToList();
            double result = source.Average();
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
        
        [TestMethod]
        public void TestAverageshortIListMapNoOverflow()
        {    
            const short expected = short.MaxValue;
            var source =  Enumerable.Repeat(new { X = expected} , 2).ToList();
            double result = source.Average(arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                    
        [TestMethod]
        public void TestAverageshortICollection()
        {            
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat(expected, 100).ToList();

            double result = source.Average();

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageshortICollectionMap()
        {
            const short expected = short.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToList();

            double result = source.Average(arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                        
        [TestMethod]
        public void TestAverageshortICollectionNoOverflow()
        {
            const short expected = short.MaxValue;
            var source = Enumerable.Repeat(expected, 2).ToList();
            double result = source.Average();
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
        
        [TestMethod]
        public void TestAverageshortICollectionMapNoOverflow()
        {    
            const short expected = short.MaxValue;
            var source =  Enumerable.Repeat(new { X = expected} , 2).ToList();
            double result = source.Average(arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                        
        #endregion
    
        #region ushort             
            
        [TestMethod]
        public void TestAverageushortArray()
        {            
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat(expected, 100).ToArray();

            double result = source.Average();

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortArrayMap()
        {
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToArray();

            double result = source.Average(arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                        
        [TestMethod]
        public void TestAverageushortArrayNoOverflow()
        {
            const ushort expected = ushort.MaxValue;
            var source = Enumerable.Repeat(expected, 2).ToArray();
            double result = source.Average();
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
        
        [TestMethod]
        public void TestAverageushortArrayMapNoOverflow()
        {    
            const ushort expected = ushort.MaxValue;
            var source =  Enumerable.Repeat(new { X = expected} , 2).ToArray();
            double result = source.Average(arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                    
        [TestMethod]
        public void TestAverageushortList()
        {            
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat(expected, 100).ToList();

            double result = source.Average();

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortListMap()
        {
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToList();

            double result = source.Average(arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                        
        [TestMethod]
        public void TestAverageushortListNoOverflow()
        {
            const ushort expected = ushort.MaxValue;
            var source = Enumerable.Repeat(expected, 2).ToList();
            double result = source.Average();
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
        
        [TestMethod]
        public void TestAverageushortListMapNoOverflow()
        {    
            const ushort expected = ushort.MaxValue;
            var source =  Enumerable.Repeat(new { X = expected} , 2).ToList();
            double result = source.Average(arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                    
        [TestMethod]
        public void TestAverageushortIList()
        {            
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat(expected, 100).ToList();

            double result = source.Average();

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortIListMap()
        {
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToList();

            double result = source.Average(arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                        
        [TestMethod]
        public void TestAverageushortIListNoOverflow()
        {
            const ushort expected = ushort.MaxValue;
            var source = Enumerable.Repeat(expected, 2).ToList();
            double result = source.Average();
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
        
        [TestMethod]
        public void TestAverageushortIListMapNoOverflow()
        {    
            const ushort expected = ushort.MaxValue;
            var source =  Enumerable.Repeat(new { X = expected} , 2).ToList();
            double result = source.Average(arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                    
        [TestMethod]
        public void TestAverageushortICollection()
        {            
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat(expected, 100).ToList();

            double result = source.Average();

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageushortICollectionMap()
        {
            const ushort expected = ushort.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToList();

            double result = source.Average(arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                        
        [TestMethod]
        public void TestAverageushortICollectionNoOverflow()
        {
            const ushort expected = ushort.MaxValue;
            var source = Enumerable.Repeat(expected, 2).ToList();
            double result = source.Average();
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
        
        [TestMethod]
        public void TestAverageushortICollectionMapNoOverflow()
        {    
            const ushort expected = ushort.MaxValue;
            var source =  Enumerable.Repeat(new { X = expected} , 2).ToList();
            double result = source.Average(arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                        
        #endregion
    
        #region int             
            
        [TestMethod]
        public void TestAverageintArray()
        {            
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat(expected, 100).ToArray();

            double result = source.Average();

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintArrayMap()
        {
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToArray();

            double result = source.Average(arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                        
        [TestMethod]
        public void TestAverageintArrayNoOverflow()
        {
            const int expected = int.MaxValue;
            var source = Enumerable.Repeat(expected, 2).ToArray();
            double result = source.Average();
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
        
        [TestMethod]
        public void TestAverageintArrayMapNoOverflow()
        {    
            const int expected = int.MaxValue;
            var source =  Enumerable.Repeat(new { X = expected} , 2).ToArray();
            double result = source.Average(arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                    
        [TestMethod]
        public void TestAverageintList()
        {            
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat(expected, 100).ToList();

            double result = source.Average();

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintListMap()
        {
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToList();

            double result = source.Average(arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                        
        [TestMethod]
        public void TestAverageintListNoOverflow()
        {
            const int expected = int.MaxValue;
            var source = Enumerable.Repeat(expected, 2).ToList();
            double result = source.Average();
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
        
        [TestMethod]
        public void TestAverageintListMapNoOverflow()
        {    
            const int expected = int.MaxValue;
            var source =  Enumerable.Repeat(new { X = expected} , 2).ToList();
            double result = source.Average(arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                    
        [TestMethod]
        public void TestAverageintIList()
        {            
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat(expected, 100).ToList();

            double result = source.Average();

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintIListMap()
        {
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToList();

            double result = source.Average(arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                        
        [TestMethod]
        public void TestAverageintIListNoOverflow()
        {
            const int expected = int.MaxValue;
            var source = Enumerable.Repeat(expected, 2).ToList();
            double result = source.Average();
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
        
        [TestMethod]
        public void TestAverageintIListMapNoOverflow()
        {    
            const int expected = int.MaxValue;
            var source =  Enumerable.Repeat(new { X = expected} , 2).ToList();
            double result = source.Average(arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                    
        [TestMethod]
        public void TestAverageintICollection()
        {            
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat(expected, 100).ToList();

            double result = source.Average();

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageintICollectionMap()
        {
            const int expected = int.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToList();

            double result = source.Average(arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                        
        [TestMethod]
        public void TestAverageintICollectionNoOverflow()
        {
            const int expected = int.MaxValue;
            var source = Enumerable.Repeat(expected, 2).ToList();
            double result = source.Average();
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
        
        [TestMethod]
        public void TestAverageintICollectionMapNoOverflow()
        {    
            const int expected = int.MaxValue;
            var source =  Enumerable.Repeat(new { X = expected} , 2).ToList();
            double result = source.Average(arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                        
        #endregion
    
        #region uint             
            
        [TestMethod]
        public void TestAverageuintArray()
        {            
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat(expected, 100).ToArray();

            double result = source.Average();

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintArrayMap()
        {
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToArray();

            double result = source.Average(arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                        
        [TestMethod]
        public void TestAverageuintArrayNoOverflow()
        {
            const uint expected = uint.MaxValue;
            var source = Enumerable.Repeat(expected, 2).ToArray();
            double result = source.Average();
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
        
        [TestMethod]
        public void TestAverageuintArrayMapNoOverflow()
        {    
            const uint expected = uint.MaxValue;
            var source =  Enumerable.Repeat(new { X = expected} , 2).ToArray();
            double result = source.Average(arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                    
        [TestMethod]
        public void TestAverageuintList()
        {            
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat(expected, 100).ToList();

            double result = source.Average();

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintListMap()
        {
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToList();

            double result = source.Average(arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                        
        [TestMethod]
        public void TestAverageuintListNoOverflow()
        {
            const uint expected = uint.MaxValue;
            var source = Enumerable.Repeat(expected, 2).ToList();
            double result = source.Average();
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
        
        [TestMethod]
        public void TestAverageuintListMapNoOverflow()
        {    
            const uint expected = uint.MaxValue;
            var source =  Enumerable.Repeat(new { X = expected} , 2).ToList();
            double result = source.Average(arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                    
        [TestMethod]
        public void TestAverageuintIList()
        {            
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat(expected, 100).ToList();

            double result = source.Average();

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintIListMap()
        {
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToList();

            double result = source.Average(arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                        
        [TestMethod]
        public void TestAverageuintIListNoOverflow()
        {
            const uint expected = uint.MaxValue;
            var source = Enumerable.Repeat(expected, 2).ToList();
            double result = source.Average();
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
        
        [TestMethod]
        public void TestAverageuintIListMapNoOverflow()
        {    
            const uint expected = uint.MaxValue;
            var source =  Enumerable.Repeat(new { X = expected} , 2).ToList();
            double result = source.Average(arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                    
        [TestMethod]
        public void TestAverageuintICollection()
        {            
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat(expected, 100).ToList();

            double result = source.Average();

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageuintICollectionMap()
        {
            const uint expected = uint.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToList();

            double result = source.Average(arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                        
        [TestMethod]
        public void TestAverageuintICollectionNoOverflow()
        {
            const uint expected = uint.MaxValue;
            var source = Enumerable.Repeat(expected, 2).ToList();
            double result = source.Average();
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
        
        [TestMethod]
        public void TestAverageuintICollectionMapNoOverflow()
        {    
            const uint expected = uint.MaxValue;
            var source =  Enumerable.Repeat(new { X = expected} , 2).ToList();
            double result = source.Average(arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                        
        #endregion
    
        #region long             
            
        [TestMethod]
        public void TestAveragelongArray()
        {            
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat(expected, 100).ToArray();

            double result = source.Average();

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongArrayMap()
        {
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToArray();

            double result = source.Average(arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                        
        [TestMethod]
        public void TestAveragelongArrayNoOverflow()
        {
            const long expected = long.MaxValue;
            var source = Enumerable.Repeat(expected, 2).ToArray();
            double result = source.Average();
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
        
        [TestMethod]
        public void TestAveragelongArrayMapNoOverflow()
        {    
            const long expected = long.MaxValue;
            var source =  Enumerable.Repeat(new { X = expected} , 2).ToArray();
            double result = source.Average(arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                    
        [TestMethod]
        public void TestAveragelongList()
        {            
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat(expected, 100).ToList();

            double result = source.Average();

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongListMap()
        {
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToList();

            double result = source.Average(arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                        
        [TestMethod]
        public void TestAveragelongListNoOverflow()
        {
            const long expected = long.MaxValue;
            var source = Enumerable.Repeat(expected, 2).ToList();
            double result = source.Average();
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
        
        [TestMethod]
        public void TestAveragelongListMapNoOverflow()
        {    
            const long expected = long.MaxValue;
            var source =  Enumerable.Repeat(new { X = expected} , 2).ToList();
            double result = source.Average(arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                    
        [TestMethod]
        public void TestAveragelongIList()
        {            
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat(expected, 100).ToList();

            double result = source.Average();

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongIListMap()
        {
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToList();

            double result = source.Average(arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                        
        [TestMethod]
        public void TestAveragelongIListNoOverflow()
        {
            const long expected = long.MaxValue;
            var source = Enumerable.Repeat(expected, 2).ToList();
            double result = source.Average();
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
        
        [TestMethod]
        public void TestAveragelongIListMapNoOverflow()
        {    
            const long expected = long.MaxValue;
            var source =  Enumerable.Repeat(new { X = expected} , 2).ToList();
            double result = source.Average(arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                    
        [TestMethod]
        public void TestAveragelongICollection()
        {            
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat(expected, 100).ToList();

            double result = source.Average();

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragelongICollectionMap()
        {
            const long expected = long.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToList();

            double result = source.Average(arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                        
        [TestMethod]
        public void TestAveragelongICollectionNoOverflow()
        {
            const long expected = long.MaxValue;
            var source = Enumerable.Repeat(expected, 2).ToList();
            double result = source.Average();
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
        
        [TestMethod]
        public void TestAveragelongICollectionMapNoOverflow()
        {    
            const long expected = long.MaxValue;
            var source =  Enumerable.Repeat(new { X = expected} , 2).ToList();
            double result = source.Average(arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                        
        #endregion
    
        #region float             
            
        [TestMethod]
        public void TestAveragefloatArray()
        {            
            const float expected = short.MaxValue;
            var source = Enumerable.Repeat(expected, 100).ToArray();

            double result = source.Average();

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatArrayMap()
        {
            const float expected = short.MaxValue;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToArray();

            double result = source.Average(arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                            
        [TestMethod]
        public void TestAveragefloatList()
        {            
            const float expected = short.MaxValue;
            var source = Enumerable.Repeat(expected, 100).ToList();

            double result = source.Average();

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatListMap()
        {
            const float expected = short.MaxValue;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToList();

            double result = source.Average(arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                            
        [TestMethod]
        public void TestAveragefloatIList()
        {            
            const float expected = short.MaxValue;
            var source = Enumerable.Repeat(expected, 100).ToList();

            double result = source.Average();

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatIListMap()
        {
            const float expected = short.MaxValue;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToList();

            double result = source.Average(arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                            
        [TestMethod]
        public void TestAveragefloatICollection()
        {            
            const float expected = short.MaxValue;
            var source = Enumerable.Repeat(expected, 100).ToList();

            double result = source.Average();

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragefloatICollectionMap()
        {
            const float expected = short.MaxValue;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToList();

            double result = source.Average(arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                                
        #endregion
    
        #region double             
            
        [TestMethod]
        public void TestAveragedoubleArray()
        {            
            const double expected = short.MaxValue;
            var source = Enumerable.Repeat(expected, 100).ToArray();

            double result = source.Average();

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleArrayMap()
        {
            const double expected = short.MaxValue;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToArray();

            double result = source.Average(arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                            
        [TestMethod]
        public void TestAveragedoubleList()
        {            
            const double expected = short.MaxValue;
            var source = Enumerable.Repeat(expected, 100).ToList();

            double result = source.Average();

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleListMap()
        {
            const double expected = short.MaxValue;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToList();

            double result = source.Average(arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                            
        [TestMethod]
        public void TestAveragedoubleIList()
        {            
            const double expected = short.MaxValue;
            var source = Enumerable.Repeat(expected, 100).ToList();

            double result = source.Average();

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleIListMap()
        {
            const double expected = short.MaxValue;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToList();

            double result = source.Average(arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                            
        [TestMethod]
        public void TestAveragedoubleICollection()
        {            
            const double expected = short.MaxValue;
            var source = Enumerable.Repeat(expected, 100).ToList();

            double result = source.Average();

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedoubleICollectionMap()
        {
            const double expected = short.MaxValue;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToList();

            double result = source.Average(arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                                
        #endregion
    
        #region decimal             
            
        [TestMethod]
        public void TestAveragedecimalArray()
        {            
            const decimal expected = decimal.MaxValue/10*9;
            var source = Enumerable.Repeat(expected, 100).ToArray();

            double result = source.Average();

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalArrayMap()
        {
            const decimal expected = decimal.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToArray();

            double result = source.Average(arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                        
        [TestMethod]
        public void TestAveragedecimalArrayNoOverflow()
        {
            const decimal expected = decimal.MaxValue;
            var source = Enumerable.Repeat(expected, 2).ToArray();
            double result = source.Average();
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
        
        [TestMethod]
        public void TestAveragedecimalArrayMapNoOverflow()
        {    
            const decimal expected = decimal.MaxValue;
            var source =  Enumerable.Repeat(new { X = expected} , 2).ToArray();
            double result = source.Average(arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                    
        [TestMethod]
        public void TestAveragedecimalList()
        {            
            const decimal expected = decimal.MaxValue/10*9;
            var source = Enumerable.Repeat(expected, 100).ToList();

            double result = source.Average();

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalListMap()
        {
            const decimal expected = decimal.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToList();

            double result = source.Average(arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                        
        [TestMethod]
        public void TestAveragedecimalListNoOverflow()
        {
            const decimal expected = decimal.MaxValue;
            var source = Enumerable.Repeat(expected, 2).ToList();
            double result = source.Average();
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
        
        [TestMethod]
        public void TestAveragedecimalListMapNoOverflow()
        {    
            const decimal expected = decimal.MaxValue;
            var source =  Enumerable.Repeat(new { X = expected} , 2).ToList();
            double result = source.Average(arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                    
        [TestMethod]
        public void TestAveragedecimalIList()
        {            
            const decimal expected = decimal.MaxValue/10*9;
            var source = Enumerable.Repeat(expected, 100).ToList();

            double result = source.Average();

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalIListMap()
        {
            const decimal expected = decimal.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToList();

            double result = source.Average(arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                        
        [TestMethod]
        public void TestAveragedecimalIListNoOverflow()
        {
            const decimal expected = decimal.MaxValue;
            var source = Enumerable.Repeat(expected, 2).ToList();
            double result = source.Average();
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
        
        [TestMethod]
        public void TestAveragedecimalIListMapNoOverflow()
        {    
            const decimal expected = decimal.MaxValue;
            var source =  Enumerable.Repeat(new { X = expected} , 2).ToList();
            double result = source.Average(arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                    
        [TestMethod]
        public void TestAveragedecimalICollection()
        {            
            const decimal expected = decimal.MaxValue/10*9;
            var source = Enumerable.Repeat(expected, 100).ToList();

            double result = source.Average();

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAveragedecimalICollectionMap()
        {
            const decimal expected = decimal.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToList();

            double result = source.Average(arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                        
        [TestMethod]
        public void TestAveragedecimalICollectionNoOverflow()
        {
            const decimal expected = decimal.MaxValue;
            var source = Enumerable.Repeat(expected, 2).ToList();
            double result = source.Average();
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
        
        [TestMethod]
        public void TestAveragedecimalICollectionMapNoOverflow()
        {    
            const decimal expected = decimal.MaxValue;
            var source =  Enumerable.Repeat(new { X = expected} , 2).ToList();
            double result = source.Average(arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                        
        #endregion
    
        #region ulong             
            
        [TestMethod]
        public void TestAverageulongArray()
        {            
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat(expected, 100).ToArray();

            double result = source.Average();

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongArrayMap()
        {
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToArray();

            double result = source.Average(arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                        
        [TestMethod]
        public void TestAverageulongArrayNoOverflow()
        {
            const ulong expected = ulong.MaxValue;
            var source = Enumerable.Repeat(expected, 2).ToArray();
            double result = source.Average();
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
        
        [TestMethod]
        public void TestAverageulongArrayMapNoOverflow()
        {    
            const ulong expected = ulong.MaxValue;
            var source =  Enumerable.Repeat(new { X = expected} , 2).ToArray();
            double result = source.Average(arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                    
        [TestMethod]
        public void TestAverageulongList()
        {            
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat(expected, 100).ToList();

            double result = source.Average();

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongListMap()
        {
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToList();

            double result = source.Average(arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                        
        [TestMethod]
        public void TestAverageulongListNoOverflow()
        {
            const ulong expected = ulong.MaxValue;
            var source = Enumerable.Repeat(expected, 2).ToList();
            double result = source.Average();
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
        
        [TestMethod]
        public void TestAverageulongListMapNoOverflow()
        {    
            const ulong expected = ulong.MaxValue;
            var source =  Enumerable.Repeat(new { X = expected} , 2).ToList();
            double result = source.Average(arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                    
        [TestMethod]
        public void TestAverageulongIList()
        {            
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat(expected, 100).ToList();

            double result = source.Average();

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongIListMap()
        {
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToList();

            double result = source.Average(arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                        
        [TestMethod]
        public void TestAverageulongIListNoOverflow()
        {
            const ulong expected = ulong.MaxValue;
            var source = Enumerable.Repeat(expected, 2).ToList();
            double result = source.Average();
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
        
        [TestMethod]
        public void TestAverageulongIListMapNoOverflow()
        {    
            const ulong expected = ulong.MaxValue;
            var source =  Enumerable.Repeat(new { X = expected} , 2).ToList();
            double result = source.Average(arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                    
        [TestMethod]
        public void TestAverageulongICollection()
        {            
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat(expected, 100).ToList();

            double result = source.Average();

            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

        [TestMethod]
        public void TestAverageulongICollectionMap()
        {
            const ulong expected = ulong.MaxValue/10*9;
            var source = Enumerable.Repeat(new { X = expected}, 100).ToList();

            double result = source.Average(arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }

                        
        [TestMethod]
        public void TestAverageulongICollectionNoOverflow()
        {
            const ulong expected = ulong.MaxValue;
            var source = Enumerable.Repeat(expected, 2).ToList();
            double result = source.Average();
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
        
        [TestMethod]
        public void TestAverageulongICollectionMapNoOverflow()
        {    
            const ulong expected = ulong.MaxValue;
            var source =  Enumerable.Repeat(new { X = expected} , 2).ToList();
            double result = source.Average(arg => arg.X);
            Assert.IsTrue(Math.Abs(1 - result/(double)expected) < Tolerance, $"result = {result}\texpected = {expected}");
        }
                        
        #endregion
        
    }
}