using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ZLinq.Test.Core
{
    [TestClass]
    public class Flatten
    {   	
		 

        [TestMethod]
        public void TestFlatten2Dim()
        {
            var array = new int[1,2];
			for (int a = 0; a < array.GetLength(0); a++) 
			for (int b = 0; b < array.GetLength(1); b++) 
			
				unchecked
                {
					array[a,b] = a+b;
                }

            var arr1 = array.Flatten().ToArray();
            var arr2 = array.Cast<int>().ToArray();

            Assert.AreEqual(arr1.Length, arr2.Length);
            Assert.IsTrue(arr1.SequenceEqual(arr2));
        }
		 

        [TestMethod]
        public void TestFlatten3Dim()
        {
            var array = new int[1,2,3];
			for (int a = 0; a < array.GetLength(0); a++) 
			for (int b = 0; b < array.GetLength(1); b++) 
			for (int c = 0; c < array.GetLength(2); c++) 
			
				unchecked
                {
					array[a,b,c] = a+b+c;
                }

            var arr1 = array.Flatten().ToArray();
            var arr2 = array.Cast<int>().ToArray();

            Assert.AreEqual(arr1.Length, arr2.Length);
            Assert.IsTrue(arr1.SequenceEqual(arr2));
        }
		 

        [TestMethod]
        public void TestFlatten4Dim()
        {
            var array = new int[1,2,3,1];
			for (int a = 0; a < array.GetLength(0); a++) 
			for (int b = 0; b < array.GetLength(1); b++) 
			for (int c = 0; c < array.GetLength(2); c++) 
			for (int d = 0; d < array.GetLength(3); d++) 
			
				unchecked
                {
					array[a,b,c,d] = a+b+c+d;
                }

            var arr1 = array.Flatten().ToArray();
            var arr2 = array.Cast<int>().ToArray();

            Assert.AreEqual(arr1.Length, arr2.Length);
            Assert.IsTrue(arr1.SequenceEqual(arr2));
        }
		 

        [TestMethod]
        public void TestFlatten5Dim()
        {
            var array = new int[1,2,3,1,2];
			for (int a = 0; a < array.GetLength(0); a++) 
			for (int b = 0; b < array.GetLength(1); b++) 
			for (int c = 0; c < array.GetLength(2); c++) 
			for (int d = 0; d < array.GetLength(3); d++) 
			for (int e = 0; e < array.GetLength(4); e++) 
			
				unchecked
                {
					array[a,b,c,d,e] = a+b+c+d+e;
                }

            var arr1 = array.Flatten().ToArray();
            var arr2 = array.Cast<int>().ToArray();

            Assert.AreEqual(arr1.Length, arr2.Length);
            Assert.IsTrue(arr1.SequenceEqual(arr2));
        }
		 

        [TestMethod]
        public void TestFlatten6Dim()
        {
            var array = new int[1,2,3,1,2,3];
			for (int a = 0; a < array.GetLength(0); a++) 
			for (int b = 0; b < array.GetLength(1); b++) 
			for (int c = 0; c < array.GetLength(2); c++) 
			for (int d = 0; d < array.GetLength(3); d++) 
			for (int e = 0; e < array.GetLength(4); e++) 
			for (int f = 0; f < array.GetLength(5); f++) 
			
				unchecked
                {
					array[a,b,c,d,e,f] = a+b+c+d+e+f;
                }

            var arr1 = array.Flatten().ToArray();
            var arr2 = array.Cast<int>().ToArray();

            Assert.AreEqual(arr1.Length, arr2.Length);
            Assert.IsTrue(arr1.SequenceEqual(arr2));
        }
		 

        [TestMethod]
        public void TestFlatten7Dim()
        {
            var array = new int[1,2,3,1,2,3,1];
			for (int a = 0; a < array.GetLength(0); a++) 
			for (int b = 0; b < array.GetLength(1); b++) 
			for (int c = 0; c < array.GetLength(2); c++) 
			for (int d = 0; d < array.GetLength(3); d++) 
			for (int e = 0; e < array.GetLength(4); e++) 
			for (int f = 0; f < array.GetLength(5); f++) 
			for (int g = 0; g < array.GetLength(6); g++) 
			
				unchecked
                {
					array[a,b,c,d,e,f,g] = a+b+c+d+e+f+g;
                }

            var arr1 = array.Flatten().ToArray();
            var arr2 = array.Cast<int>().ToArray();

            Assert.AreEqual(arr1.Length, arr2.Length);
            Assert.IsTrue(arr1.SequenceEqual(arr2));
        }
		 

        [TestMethod]
        public void TestFlatten8Dim()
        {
            var array = new int[1,2,3,1,2,3,1,2];
			for (int a = 0; a < array.GetLength(0); a++) 
			for (int b = 0; b < array.GetLength(1); b++) 
			for (int c = 0; c < array.GetLength(2); c++) 
			for (int d = 0; d < array.GetLength(3); d++) 
			for (int e = 0; e < array.GetLength(4); e++) 
			for (int f = 0; f < array.GetLength(5); f++) 
			for (int g = 0; g < array.GetLength(6); g++) 
			for (int h = 0; h < array.GetLength(7); h++) 
			
				unchecked
                {
					array[a,b,c,d,e,f,g,h] = a+b+c+d+e+f+g+h;
                }

            var arr1 = array.Flatten().ToArray();
            var arr2 = array.Cast<int>().ToArray();

            Assert.AreEqual(arr1.Length, arr2.Length);
            Assert.IsTrue(arr1.SequenceEqual(arr2));
        }
		 

        [TestMethod]
        public void TestFlatten9Dim()
        {
            var array = new int[1,2,3,1,2,3,1,2,3];
			for (int a = 0; a < array.GetLength(0); a++) 
			for (int b = 0; b < array.GetLength(1); b++) 
			for (int c = 0; c < array.GetLength(2); c++) 
			for (int d = 0; d < array.GetLength(3); d++) 
			for (int e = 0; e < array.GetLength(4); e++) 
			for (int f = 0; f < array.GetLength(5); f++) 
			for (int g = 0; g < array.GetLength(6); g++) 
			for (int h = 0; h < array.GetLength(7); h++) 
			for (int i = 0; i < array.GetLength(8); i++) 
			
				unchecked
                {
					array[a,b,c,d,e,f,g,h,i] = a+b+c+d+e+f+g+h+i;
                }

            var arr1 = array.Flatten().ToArray();
            var arr2 = array.Cast<int>().ToArray();

            Assert.AreEqual(arr1.Length, arr2.Length);
            Assert.IsTrue(arr1.SequenceEqual(arr2));
        }
		 

        [TestMethod]
        public void TestFlatten10Dim()
        {
            var array = new int[1,2,3,1,2,3,1,2,3,1];
			for (int a = 0; a < array.GetLength(0); a++) 
			for (int b = 0; b < array.GetLength(1); b++) 
			for (int c = 0; c < array.GetLength(2); c++) 
			for (int d = 0; d < array.GetLength(3); d++) 
			for (int e = 0; e < array.GetLength(4); e++) 
			for (int f = 0; f < array.GetLength(5); f++) 
			for (int g = 0; g < array.GetLength(6); g++) 
			for (int h = 0; h < array.GetLength(7); h++) 
			for (int i = 0; i < array.GetLength(8); i++) 
			for (int j = 0; j < array.GetLength(9); j++) 
			
				unchecked
                {
					array[a,b,c,d,e,f,g,h,i,j] = a+b+c+d+e+f+g+h+i+j;
                }

            var arr1 = array.Flatten().ToArray();
            var arr2 = array.Cast<int>().ToArray();

            Assert.AreEqual(arr1.Length, arr2.Length);
            Assert.IsTrue(arr1.SequenceEqual(arr2));
        }
		
		 

        [TestMethod]
        public void TestFlattenToArray2Dim()
        {
            var array = new int[1,2];
			for (int a = 0; a < array.GetLength(0); a++) 
			for (int b = 0; b < array.GetLength(1); b++) 
			
				unchecked
                {
					array[a,b] = a+b;
                }

            var arr1 = array.FlattenToArray();
            var arr2 = array.Cast<int>().ToArray();

            Assert.AreEqual(arr1.Length, arr2.Length);
            Assert.IsTrue(arr1.SequenceEqual(arr2));
        }
		 

        [TestMethod]
        public void TestFlattenToArray3Dim()
        {
            var array = new int[1,2,3];
			for (int a = 0; a < array.GetLength(0); a++) 
			for (int b = 0; b < array.GetLength(1); b++) 
			for (int c = 0; c < array.GetLength(2); c++) 
			
				unchecked
                {
					array[a,b,c] = a+b+c;
                }

            var arr1 = array.FlattenToArray();
            var arr2 = array.Cast<int>().ToArray();

            Assert.AreEqual(arr1.Length, arr2.Length);
            Assert.IsTrue(arr1.SequenceEqual(arr2));
        }
		 

        [TestMethod]
        public void TestFlattenToArray4Dim()
        {
            var array = new int[1,2,3,1];
			for (int a = 0; a < array.GetLength(0); a++) 
			for (int b = 0; b < array.GetLength(1); b++) 
			for (int c = 0; c < array.GetLength(2); c++) 
			for (int d = 0; d < array.GetLength(3); d++) 
			
				unchecked
                {
					array[a,b,c,d] = a+b+c+d;
                }

            var arr1 = array.FlattenToArray();
            var arr2 = array.Cast<int>().ToArray();

            Assert.AreEqual(arr1.Length, arr2.Length);
            Assert.IsTrue(arr1.SequenceEqual(arr2));
        }
		 

        [TestMethod]
        public void TestFlattenToArray5Dim()
        {
            var array = new int[1,2,3,1,2];
			for (int a = 0; a < array.GetLength(0); a++) 
			for (int b = 0; b < array.GetLength(1); b++) 
			for (int c = 0; c < array.GetLength(2); c++) 
			for (int d = 0; d < array.GetLength(3); d++) 
			for (int e = 0; e < array.GetLength(4); e++) 
			
				unchecked
                {
					array[a,b,c,d,e] = a+b+c+d+e;
                }

            var arr1 = array.FlattenToArray();
            var arr2 = array.Cast<int>().ToArray();

            Assert.AreEqual(arr1.Length, arr2.Length);
            Assert.IsTrue(arr1.SequenceEqual(arr2));
        }
		 

        [TestMethod]
        public void TestFlattenToArray6Dim()
        {
            var array = new int[1,2,3,1,2,3];
			for (int a = 0; a < array.GetLength(0); a++) 
			for (int b = 0; b < array.GetLength(1); b++) 
			for (int c = 0; c < array.GetLength(2); c++) 
			for (int d = 0; d < array.GetLength(3); d++) 
			for (int e = 0; e < array.GetLength(4); e++) 
			for (int f = 0; f < array.GetLength(5); f++) 
			
				unchecked
                {
					array[a,b,c,d,e,f] = a+b+c+d+e+f;
                }

            var arr1 = array.FlattenToArray();
            var arr2 = array.Cast<int>().ToArray();

            Assert.AreEqual(arr1.Length, arr2.Length);
            Assert.IsTrue(arr1.SequenceEqual(arr2));
        }
		 

        [TestMethod]
        public void TestFlattenToArray7Dim()
        {
            var array = new int[1,2,3,1,2,3,1];
			for (int a = 0; a < array.GetLength(0); a++) 
			for (int b = 0; b < array.GetLength(1); b++) 
			for (int c = 0; c < array.GetLength(2); c++) 
			for (int d = 0; d < array.GetLength(3); d++) 
			for (int e = 0; e < array.GetLength(4); e++) 
			for (int f = 0; f < array.GetLength(5); f++) 
			for (int g = 0; g < array.GetLength(6); g++) 
			
				unchecked
                {
					array[a,b,c,d,e,f,g] = a+b+c+d+e+f+g;
                }

            var arr1 = array.FlattenToArray();
            var arr2 = array.Cast<int>().ToArray();

            Assert.AreEqual(arr1.Length, arr2.Length);
            Assert.IsTrue(arr1.SequenceEqual(arr2));
        }
		 

        [TestMethod]
        public void TestFlattenToArray8Dim()
        {
            var array = new int[1,2,3,1,2,3,1,2];
			for (int a = 0; a < array.GetLength(0); a++) 
			for (int b = 0; b < array.GetLength(1); b++) 
			for (int c = 0; c < array.GetLength(2); c++) 
			for (int d = 0; d < array.GetLength(3); d++) 
			for (int e = 0; e < array.GetLength(4); e++) 
			for (int f = 0; f < array.GetLength(5); f++) 
			for (int g = 0; g < array.GetLength(6); g++) 
			for (int h = 0; h < array.GetLength(7); h++) 
			
				unchecked
                {
					array[a,b,c,d,e,f,g,h] = a+b+c+d+e+f+g+h;
                }

            var arr1 = array.FlattenToArray();
            var arr2 = array.Cast<int>().ToArray();

            Assert.AreEqual(arr1.Length, arr2.Length);
            Assert.IsTrue(arr1.SequenceEqual(arr2));
        }
		 

        [TestMethod]
        public void TestFlattenToArray9Dim()
        {
            var array = new int[1,2,3,1,2,3,1,2,3];
			for (int a = 0; a < array.GetLength(0); a++) 
			for (int b = 0; b < array.GetLength(1); b++) 
			for (int c = 0; c < array.GetLength(2); c++) 
			for (int d = 0; d < array.GetLength(3); d++) 
			for (int e = 0; e < array.GetLength(4); e++) 
			for (int f = 0; f < array.GetLength(5); f++) 
			for (int g = 0; g < array.GetLength(6); g++) 
			for (int h = 0; h < array.GetLength(7); h++) 
			for (int i = 0; i < array.GetLength(8); i++) 
			
				unchecked
                {
					array[a,b,c,d,e,f,g,h,i] = a+b+c+d+e+f+g+h+i;
                }

            var arr1 = array.FlattenToArray();
            var arr2 = array.Cast<int>().ToArray();

            Assert.AreEqual(arr1.Length, arr2.Length);
            Assert.IsTrue(arr1.SequenceEqual(arr2));
        }
		 

        [TestMethod]
        public void TestFlattenToArray10Dim()
        {
            var array = new int[1,2,3,1,2,3,1,2,3,1];
			for (int a = 0; a < array.GetLength(0); a++) 
			for (int b = 0; b < array.GetLength(1); b++) 
			for (int c = 0; c < array.GetLength(2); c++) 
			for (int d = 0; d < array.GetLength(3); d++) 
			for (int e = 0; e < array.GetLength(4); e++) 
			for (int f = 0; f < array.GetLength(5); f++) 
			for (int g = 0; g < array.GetLength(6); g++) 
			for (int h = 0; h < array.GetLength(7); h++) 
			for (int i = 0; i < array.GetLength(8); i++) 
			for (int j = 0; j < array.GetLength(9); j++) 
			
				unchecked
                {
					array[a,b,c,d,e,f,g,h,i,j] = a+b+c+d+e+f+g+h+i+j;
                }

            var arr1 = array.FlattenToArray();
            var arr2 = array.Cast<int>().ToArray();

            Assert.AreEqual(arr1.Length, arr2.Length);
            Assert.IsTrue(arr1.SequenceEqual(arr2));
        }
			        

    }
}
